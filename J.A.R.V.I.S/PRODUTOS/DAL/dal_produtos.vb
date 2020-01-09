Public Class dal_produtos
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private Logs As New Bll_log
    Private rs As ADODB.Recordset
    Private sql As String
    Private dt As DataTable
    Private hlp As New Uteis.Helpers
    Private dto As New dto_produtos

    Public Function DeletaPorId(ByVal _id As Integer) As Boolean 'deleta as informações por id

        Try
            sql = "Delete from tb_produtos where id=" & objCon.valorSql(_id)

            DeletaPorId = objCon.executaQuery(sql)
            If DeletaPorId Then
                Logs.RegistrarLOG(_id, , hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
            End If
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
            Return False
        End Try

    End Function

    'parametro de filtro opcional
    Public Function GetRegistros(Optional ByVal filtro As String = "") As DataTable
        Try
            sql = "Select tb_produtos.* "
            sql += "from tb_produtos "
            sql += "where (produto like ('" & filtro & "%') " 'filtro opcional por descricção do registro
            sql += "or sigla like ('" & filtro & "%')) " 'filtro opcional por sigla
            sql += "order by tb_produtos.id ASC "
            Return objCon.retornaDataTable(sql)
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
            Return Nothing
        End Try

    End Function

    'captura as informações por id e retorna o objeto
    Public Function GetRegistrosPorId(ByVal _id As Integer) As dto_produtos
        Try
            sql = "Select * from tb_produtos where id= " & objCon.valorSql(_id)

            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    With dto
                        .id = objCon.retornaVazioParaValorNulo(drRow("id"))
                        .produto = objCon.retornaVazioParaValorNulo(drRow("produto"))
                        .descricao = objCon.retornaVazioParaValorNulo(drRow("descricao"))
                        .sigla = objCon.retornaVazioParaValorNulo(drRow("sigla"))
                        .ativo = objCon.retornaVazioParaValorNulo(drRow("ativo"))
                        .valor = objCon.retornaVazioParaValorNulo(drRow("valor"))
                        .dataCadastro = objCon.retornaVazioParaValorNulo(drRow("dataCadastro"), Nothing)
                        .idCadastro = objCon.retornaVazioParaValorNulo(drRow("idCadastro"))
                        .acao = FlagAcao.NoAction
                    End With
                Next drRow
            End If
            Return dto
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
            Return Nothing
        End Try

    End Function

    'incluir no banco de dados o objeto passado via parametro
    Public Function Incluir(ByVal _obj As dto_produtos) As Boolean
        Try
            sql = "Insert into tb_produtos "
            sql += "(produto,"
            sql += "descricao,"
            sql += "sigla,"
            sql += "ativo,"
            sql += "valor, "
            sql += "dataCadastro, "
            sql += "idCadastro) "
            sql += "values( "
            sql += objCon.valorSql(_obj.produto) & ","
            sql += objCon.valorSql(_obj.descricao) & ","
            sql += objCon.valorSql(_obj.sigla) & ","
            sql += objCon.valorSql(_obj.ativo) & ","
            sql += objCon.valorSql(_obj.valor) & ","
            sql += objCon.valorSql(hlp.dataHoraAtual()) & ", "
            sql += objCon.valorSql(sessaoIdUsuario) & ")"

            Incluir = objCon.executaQuery(sql)
            If Incluir Then
                Logs.RegistrarLOG(0, _obj.produto.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
            End If
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
            Return False
        End Try

    End Function
    Public Function Atualizar(ByVal _obj As dto_produtos) As Boolean

        Try
            sql = "Update tb_produtos "
            sql += "set produto = " & objCon.valorSql(_obj.produto.Trim) & ","
            sql += "sigla = " & objCon.valorSql(_obj.sigla.Trim) & ","
            sql += "descricao = " & objCon.valorSql(_obj.descricao.Trim) & ","
            sql += "ativo = " & objCon.valorSql(_obj.ativo) & ","
            sql += "valor = " & objCon.valorSql(_obj.valor) & ", "
            sql += "dataCadastro = " & objCon.valorSql(hlp.dataHoraAtual()) & ","
            sql += "idCadastro = " & objCon.valorSql(sessaoIdUsuario) & " "
            sql += "where id = " & objCon.valorSql(_obj.id) & " "

            Atualizar = objCon.executaQuery(sql)
            If Atualizar Then
                Logs.RegistrarLOG(_obj.id, _obj.produto.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
            End If
            Return Atualizar
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
            Return False
        End Try

    End Function

    'função que verifica se ja existe registro já cadastrado
    Public Function ValidaDuplicidade(ByVal _desc_registro As String, ByVal id_registro As Integer) As Boolean

        Try
            sql = "Select * from tb_produtos where produto = " & objCon.valorSql(_desc_registro.Trim)
            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    If id_registro = drRow("id") Then
                        ValidaDuplicidade = True 'retorna true nos casos em que pode alterar
                    Else
                        ValidaDuplicidade = False 'Não permite inclusão/alteração pois já existe
                    End If
                Next drRow
            Else
                ValidaDuplicidade = True 'Deixa incluir
            End If
            Return ValidaDuplicidade
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
            Return False
        End Try

    End Function
    Public Function Salvar(ByVal _obj As dto_produtos) As Boolean
        If _obj.acao = FlagAcao.Insert Then
            Salvar = Me.Incluir(_obj)
        ElseIf _obj.acao = FlagAcao.Update Then
            Salvar = Me.Atualizar(_obj)
        End If
        Return Salvar
    End Function


    'Capturar o ID do registro pelo nome
    Public Function GetIdRegistroPorNome(ByVal _registroNome As String) As Integer
        Try
            sql = "Select ID from tb_produtos WHERE tb_produtos.produto like " & objCon.valorSql(_registroNome) & " "
            dt = objCon.retornaDataTable(sql)

            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    Return drRow("ID")
                Next drRow
            End If
            Return 0
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
            Return 0
        End Try

    End Function
    'Todas os registros ativos para listagem em combobox
    Public Sub GetComboboxRegistros(frm As Form, cb As ComboBox)

        Try
            sql = "Select tb_produtos.id, tb_produtos.produto from tb_produtos where ativo = true "
            sql += "order by tb_produtos.produto asc"

            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO PRODUTOS")
        End Try
    End Sub

End Class
