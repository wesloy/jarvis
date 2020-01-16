Public Class dal_usuarios
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private hlp As New Uteis.Helpers
    Private logs As New Bll_log
    Private sql As String
    Private usuario As New dto_usuarios
    Private dt As DataTable


    Public Function DeletaUsuarioPorId(ByVal _usuarioId As Integer) As Boolean
        Try
            sql = "Delete from tb_usuarios where id=" & objCon.valorSql(_usuarioId)
            Return objCon.executaQuery(sql)
        Catch ex As Exception
            logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Deletar Usuário")
            Return False
        End Try

    End Function
    'Salvo toda a relação de usuários dentro de um DataReader
    'parametro de filtro opcional
    Public Function GetUsuarios(Optional ByVal filtro As String = "") As DataTable ' OleDb.OleDbDataReader
        Try
            sql = "select tb_usuarios.ativo, tb_usuarios.id, tb_usuarios.nome, tb_usuarios.dataCadastro, U.nome AS responsavel, M.descricao as perfilAcesso "
            sql += "FROM (tb_usuarios "
            sql += "LEFT JOIN tb_usuarios U ON tb_usuarios.idCadastro = U.id) "
            sql += "LEFT JOIN tb_menu M ON M.id = tb_usuarios.perfilAcesso "
            sql += "WHERE tb_usuarios.nome like ('" & filtro & "%') " 'filtro opcional
            sql += "GROUP BY tb_usuarios.ativo, tb_usuarios.id, tb_usuarios.nome, tb_usuarios.dataCadastro, U.nome, M.descricao "
            sql += "ORDER BY tb_usuarios.nome "
            dt = objCon.retornaDataTable(sql)
            Return dt
        Catch ex As Exception
            logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Capturar usuários")
            Return Nothing
        End Try
    End Function
    'captura lista de usuários ativos
    Public Function getListaUsuariosAtivos() As DataTable
        Try
            sql = "Select tb_usuarios.id, tb_usuarios.nome from tb_usuarios "
            sql += "where tb_usuarios.ativo = 1 "
            sql += "order by tb_usuarios.nome "
            Return objCon.retornaDataTable(sql)
        Catch ex As Exception
            logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Capturar usuários ativos")
            Return Nothing
        End Try
    End Function
    Private Function carregaDto(ByVal sql As String) As dto_usuarios

        Try
            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    With usuario
                        .id = objCon.retornaVazioParaValorNulo(drRow("id"))
                        .nome = objCon.retornaVazioParaValorNulo(drRow("nome"))
                        .ativo = objCon.retornaVazioParaValorNulo(drRow("ativo"), False)
                        .senha = objCon.retornaVazioParaValorNulo(drRow("senha"))
                        .dataCadastro = objCon.retornaVazioParaValorNulo(drRow("dataCadastro"), Nothing)
                        .idCadastro = objCon.retornaVazioParaValorNulo(drRow("idCadastro"))
                        .perfilAcesso = objCon.retornaVazioParaValorNulo(drRow("perfilAcesso"), Nothing)
                    End With
                Next drRow
            End If
            Return usuario
        Catch ex As Exception
            logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Carregar informações DTO")
            Return Nothing
        End Try

    End Function

    'captura as informações de usuário por id e retorna o objeto
    Public Function GetUsuarioPorId(ByVal _usuarioId As Integer) As dto_usuarios
        sql = "Select * from tb_usuarios where id= " & objCon.valorSql(_usuarioId)
        Return carregaDto(sql)
    End Function
    'captura as informações de usuário por id de REDE e retorna o objeto
    Public Function GetUsuarioPorNome(ByVal _nome As String) As dto_usuarios
        sql = "Select * from tb_usuarios where nome = " & objCon.valorSql(_nome)
        Return carregaDto(sql)
    End Function


    'incluir no banco de dados o objeto passado via parametro
    Public Function Incluir(ByVal usuario As dto_usuarios) As Boolean
        Try
            sql = "Insert into tb_usuarios "
            sql += "(nome, "
            sql += "senha, "
            sql += "ativo, "
            sql += "perfilAcesso, "
            sql += "dataCadastro, "
            sql += "idCadastro) "
            sql += "values( "
            sql += objCon.valorSql(usuario.nome) & ","
            sql += objCon.valorSql(usuario.senha) & ","
            sql += objCon.valorSql(usuario.ativo) & ","
            sql += objCon.valorSql(usuario.perfilAcesso) & ","
            sql += objCon.valorSql(hlp.dataHoraAtual()) & ","
            sql += objCon.valorSql(sessaoIdUsuario) & ")"
            Return objCon.executaQuery(sql)
        Catch ex As Exception
            logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Incluir Usuário")
            Return False
        End Try
    End Function
    Public Function Atualizar(ByVal usuario As dto_usuarios) As Boolean
        Try
            sql = "Update tb_usuarios "
            sql += "set nome = " & objCon.valorSql(usuario.nome.Trim) & ", "
            sql += "ativo = " & objCon.valorSql(usuario.ativo) & ", "
            sql += "perfilAcesso = " & objCon.valorSql(usuario.perfilAcesso) & ", "
            sql += "dataCadastro = " & objCon.valorSql(hlp.dataHoraAtual()) & ", "
            sql += "idCadastro = " & objCon.valorSql(sessaoIdUsuario) & " "
            sql += "where id = " & objCon.valorSql(usuario.id) & " "
            Return objCon.executaQuery(sql)
        Catch ex As Exception
            logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Atualizar Usuário")
            Return False
        End Try
    End Function

    'função que verifica se o usuário ja esta cadastrado
    Public Function ValidacaoNome(ByVal _nome As String, ByVal id_registro As Integer) As Boolean
        Try
            sql = "Select * from tb_usuarios where nome = " & objCon.valorSql(_nome.Trim) & " "
            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    If id_registro = drRow("id") Then
                        ValidacaoNome = True 'retorna true nos casos em que pode alterar o id de rede
                    Else
                        ValidacaoNome = False 'Não permite inclusão/alteração pois o ID de rede já existe
                    End If
                Next drRow
            Else
                ValidacaoNome = True 'Deixa incluir, pois o usuário já foi validado
            End If
            Return ValidacaoNome
        Catch ex As Exception
            logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Validação nome")
            Return False
        End Try

    End Function

    Public Sub GetComboboxUsuarios(frm As Form, cb As ComboBox, ByVal area As Integer)

        Try
            sql = "Select tb_usuarios.id, tb_usuarios.nome from tb_usuarios where ativo = " & objCon.valorSql(True) & " "
            sql += "Group by tb_usuarios.id, tb_usuarios.nome "
            sql = sql & "order by tb_usuarios.nome asc"

            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try

    End Sub

    Public Function ConsultaNomePorID(ByVal id As Integer) As String
        Dim nome As String = Nothing
        Try
            sql = "Select * from tb_usuarios where ([id] = " & objCon.valorSql(id, False) & ")"
            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then 'Ou seja, o caso já está sendo trabalhado por outra pessoa
                For Each linha As DataRow In dt.Rows 'Efeturar o looping até o fim
                    nome = linha("nome")
                Next
            End If
            Return nome
        Catch ex As Exception
            logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Consultar Nome")
            Return ""
        End Try

    End Function
    Public Function AtualizarSenha(ByVal id As Integer, ByVal Optional senha As String = "123456") As Boolean
        Try
            sql = "Update tb_usuarios set "
            sql += "senha = " & objCon.valorSql(hlp.Encrypt(senha)) & " "
            sql += "where id = " & objCon.valorSql(id) & " "
            Return objCon.executaQuery(sql)
        Catch ex As Exception
            logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Atualizar Senha")
            Return False
        End Try
    End Function

    Public Function Salvar(ByVal usuario As dto_usuarios) As Boolean
        Try
            If usuario.Acao = FlagAcao.Insert Then
                Salvar = Me.Incluir(usuario)
            ElseIf usuario.Acao = FlagAcao.Update Then
                Salvar = Me.Atualizar(usuario)
            End If
            Return Salvar
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
