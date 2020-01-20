Public Class dal_clientes
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private Logs As New Bll_log
    Private rs As ADODB.Recordset
    Private sql As String
    Private dt As DataTable
    Private hlp As New Uteis.Helpers
    Private dto As New dto_clientes

    Public Function DeletaPorId(ByVal _id As Integer) As Boolean 'deleta as informações por id

        Try
            sql = "Delete from tb_clientes where id=" & objCon.valorSql(_id)

            DeletaPorId = objCon.executaQuery(sql)
            If DeletaPorId Then
                Logs.RegistrarLOG(_id, , hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            End If
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            Return False
        End Try

    End Function

    Public Function GetRegistros_retornaDT(ByVal _id As Integer) As DataTable
        Try
            sql = "Select tb_clientes.* "
            sql += "from tb_clientes "
            sql += "where id = " & objCon.valorSql(_id) & " "
            sql += "order by tb_clientes.id ASC "
            Return objCon.retornaDataTable(sql)
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            Return Nothing
        End Try

    End Function

    'parametro de filtro opcional
    Public Function GetRegistros(Optional ByVal filtro As String = "") As DataTable
        Try
            sql = "Select tb_clientes.* "
            sql += "from tb_clientes "
            sql += "where (cliente like ('" & filtro & "%') " 'filtro opcional por descricção do registro
            sql += "or companheiro like ('" & filtro & "%')) " 'filtro opcional por sigla
            sql += "order by tb_clientes.id ASC "
            Return objCon.retornaDataTable(sql)
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            Return Nothing
        End Try

    End Function

    'captura as informações por id e retorna o objeto
    Public Function GetRegistrosPorId(ByVal _id As Integer) As dto_clientes
        Try
            sql = "Select * from tb_clientes where id= " & objCon.valorSql(_id)

            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    With dto
                        .id = objCon.retornaVazioParaValorNulo(drRow("id"))
                        .cliente = objCon.retornaVazioParaValorNulo(drRow("cliente"))
                        .companheiro = objCon.retornaVazioParaValorNulo(drRow("companheiro"))
                        .telefone = objCon.retornaVazioParaValorNulo(drRow("telefone"))
                        .celular = objCon.retornaVazioParaValorNulo(drRow("celular"))
                        .email = objCon.retornaVazioParaValorNulo(drRow("email"))
                        .instagram = objCon.retornaVazioParaValorNulo(drRow("instagram"))
                        .facebook = objCon.retornaVazioParaValorNulo(drRow("facebook"))
                        .dataNascimento = objCon.retornaVazioParaValorNulo(drRow("dataNascimento"), Nothing)
                        .gestante = objCon.retornaVazioParaValorNulo(drRow("gestante"))
                        .semanasGestacao = objCon.retornaVazioParaValorNulo(drRow("semanasGestacao"))
                        .previsaoNascimento = objCon.retornaVazioParaValorNulo(drRow("previsaoNascimento"), Nothing)
                        .qtdeFilhos = objCon.retornaVazioParaValorNulo(drRow("qtdeFilhos"))
                        .cpf = objCon.retornaVazioParaValorNulo(drRow("cpf"))
                        .observacao = objCon.retornaVazioParaValorNulo(drRow("observacao"))
                        .ativo = objCon.retornaVazioParaValorNulo(drRow("ativo"))
                        .dataCadastro = objCon.retornaVazioParaValorNulo(drRow("dataCadastro"), Nothing)
                        .idCadastro = objCon.retornaVazioParaValorNulo(drRow("idCadastro"))
                        .acao = FlagAcao.NoAction
                    End With
                Next drRow
            End If
            Return dto
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            Return Nothing
        End Try

    End Function

    'incluir no banco de dados o objeto passado via parametro
    Public Function Incluir(ByVal _obj As dto_clientes) As Boolean
        Try
            sql = "Insert into tb_clientes "
            sql += "(cliente,"
            sql += "companheiro,"
            sql += "telefone, "
            sql += "celular, "
            sql += "email, "
            sql += "instagram, "
            sql += "facebook, "
            sql += "dataNascimento, "
            sql += "gestante, "
            sql += "semanasGestacao, "
            sql += "previsaoNascimento, "
            sql += "qtdeFilhos, "
            sql += "cpf, "
            sql += "observacao, "
            sql += "ativo,"
            sql += "dataCadastro, "
            sql += "idCadastro) "
            sql += "values( "
            sql += objCon.valorSql(_obj.cliente) & ","
            sql += objCon.valorSql(_obj.companheiro) & ","
            sql += objCon.valorSql(_obj.telefone) & ","
            sql += objCon.valorSql(_obj.celular) & ","
            sql += objCon.valorSql(_obj.email) & ","
            sql += objCon.valorSql(_obj.instagram) & ","
            sql += objCon.valorSql(_obj.facebook) & ","
            sql += objCon.valorSql(_obj.dataNascimento) & ","
            sql += objCon.valorSql(_obj.gestante) & ","
            sql += objCon.valorSql(_obj.semanasGestacao) & ","
            sql += objCon.valorSql(_obj.previsaoNascimento) & ","
            sql += objCon.valorSql(_obj.qtdeFilhos) & ","
            sql += objCon.valorSql(_obj.cpf) & ","
            sql += objCon.valorSql(_obj.observacao) & ","
            sql += objCon.valorSql(_obj.ativo) & ","
            sql += objCon.valorSql(hlp.dataHoraAtual()) & ", "
            sql += objCon.valorSql(sessaoIdUsuario) & ")"

            Incluir = objCon.executaQuery(sql)
            If Incluir Then
                Logs.RegistrarLOG(0, _obj.cliente.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            End If
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            Return False
        End Try

    End Function
    Public Function Atualizar(ByVal _obj As dto_clientes) As Boolean

        Try
            sql = "Update tb_clientes "
            sql += "set cliente = " & objCon.valorSql(_obj.cliente.Trim) & ","
            sql += "companheiro = " & objCon.valorSql(_obj.companheiro.Trim) & ","
            sql += "telefone = " & objCon.valorSql(_obj.telefone.Trim) & ","
            sql += "celular = " & objCon.valorSql(_obj.celular) & ", "
            sql += "email = " & objCon.valorSql(_obj.email) & ", "
            sql += "instagram = " & objCon.valorSql(_obj.instagram) & ", "
            sql += "facebook = " & objCon.valorSql(_obj.facebook) & ", "
            sql += "dataNascimento = " & objCon.valorSql(_obj.dataNascimento) & ", "
            sql += "gestante = " & objCon.valorSql(_obj.gestante) & ", "
            sql += "semanasGestacao = " & objCon.valorSql(_obj.semanasGestacao) & ", "
            sql += "previsaoNascimento = " & objCon.valorSql(_obj.previsaoNascimento) & ", "
            sql += "qtdeFilhos = " & objCon.valorSql(_obj.qtdeFilhos) & ", "
            sql += "cpf = " & objCon.valorSql(_obj.cpf) & ", "
            sql += "observacao = " & objCon.valorSql(_obj.observacao) & ", "
            sql += "ativo = " & objCon.valorSql(_obj.ativo) & ","
            sql += "dataCadastro = " & objCon.valorSql(hlp.dataHoraAtual()) & ","
            sql += "idCadastro = " & objCon.valorSql(sessaoIdUsuario) & " "
            sql += "where id = " & objCon.valorSql(_obj.id) & " "

            Atualizar = objCon.executaQuery(sql)
            If Atualizar Then
                Logs.RegistrarLOG(_obj.id, _obj.cliente.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            End If
            Return Atualizar
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            Return False
        End Try

    End Function

    'função que verifica se ja existe registro já cadastrado
    Public Function ValidaDuplicidade(ByVal _desc_registro As String, ByVal id_registro As Integer) As Boolean

        Try
            sql = "Select * from tb_clientes where cliente = " & objCon.valorSql(_desc_registro.Trim)
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
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            Return False
        End Try

    End Function
    Public Function Salvar(ByVal _obj As dto_clientes) As Boolean
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
            sql = "Select ID from tb_clientes WHERE tb_clientes.cliente like " & objCon.valorSql(_registroNome) & " "
            dt = objCon.retornaDataTable(sql)

            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    Return drRow("ID")
                Next drRow
            End If
            Return 0
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
            Return 0
        End Try

    End Function
    'Todas os registros ativos para listagem em combobox
    Public Sub GetComboboxRegistros(frm As Form, cb As ComboBox)

        Try
            sql = "Select tb_clientes.id, tb_clientes.cliente from tb_clientes where ativo = true "
            sql += "order by tb_clientes.cliente asc"

            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, False,,, True)
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO CLIENTES")
        End Try
    End Sub

    Public Function DeletaPorIdFilhos(ByVal _id As Integer) As Boolean 'deleta as informações por id

        Try
            sql = "Delete from tb_clientes_filhos where id =" & objCon.valorSql(_id)

            DeletaPorIdFilhos = objCon.executaQuery(sql)
            If DeletaPorIdFilhos Then
                Logs.RegistrarLOG(_id, , hlp.getCurrentMethodName, "MANUTENÇÃO FILHOS DE CLIENTES")
            End If
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO FILHOS DE CLIENTES")
            Return False
        End Try

    End Function
    Public Function GetRegistrosFilhos(ByVal id_tbl_clientes As Integer) As DataTable
        Try
            sql = "Select tb_clientes_filhos.* "
            sql += "from tb_clientes_filhos "
            sql += "where id_tblClientes = " & objCon.valorSql(id_tbl_clientes) & " " 'filtro opcional por descricção do registro
            sql += "order by tb_clientes_filhos.id ASC "
            Return objCon.retornaDataTable(sql)
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO FILHOS DE CLIENTES")
            Return Nothing
        End Try

    End Function

    Public Function GetRegistrosPorIdFilhos(ByVal _id As Integer) As dto_clientes
        Try
            sql = "Select * from tb_clientes_filhos where id= " & objCon.valorSql(_id)

            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    With dto
                        .id_filhos = objCon.retornaVazioParaValorNulo(drRow("id"))
                        .id_tblClientes = objCon.retornaVazioParaValorNulo(drRow("id_tblClientes"))
                        .nomeFilho = objCon.retornaVazioParaValorNulo(drRow("nomeFilho"))
                        .sexo = objCon.retornaVazioParaValorNulo(drRow("sexo"))
                        .dataNascimento_filho = objCon.retornaVazioParaValorNulo(drRow("dataNascimento_filho"), Nothing)
                    End With
                Next drRow
            End If
            Return dto
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO FILLHOS DE CLIENTES")
            Return Nothing
        End Try

    End Function
    Public Function SalvarFilhos(ByVal _obj As dto_clientes) As Boolean
        If _obj.acao = FlagAcao.Insert Then
            SalvarFilhos = Me.IncluirFilhos(_obj)
        ElseIf _obj.acao = FlagAcao.Update Then
            SalvarFilhos = Me.AtualizarFilhos(_obj)
        End If
        Return SalvarFilhos
    End Function

    Public Function IncluirFilhos(ByVal _obj As dto_clientes) As Boolean
        Try
            sql = "Insert into tb_clientes_filhos "
            sql += "(id_tblClientes,"
            sql += "nomeFilho,"
            sql += "sexo,"
            sql += "dataNascimento_filho) "
            sql += "values( "
            sql += objCon.valorSql(_obj.id_tblClientes) & ","
            sql += objCon.valorSql(_obj.nomeFilho) & ","
            sql += objCon.valorSql(_obj.sexo) & ","
            sql += objCon.valorSql(_obj.dataNascimento_filho) & ")"


            IncluirFilhos = objCon.executaQuery(sql)
            If IncluirFilhos Then
                Logs.RegistrarLOG(0, _obj.cliente.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO FILHOS DE CLIENTES")
            End If
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO FILHOS DE CLIENTES")
            Return False
        End Try

    End Function
    Public Function AtualizarFilhos(ByVal _obj As dto_clientes) As Boolean

        Try
            sql = "Update tb_clientes_filhos "
            sql += "set id_tblClientes = " & objCon.valorSql(_obj.id_tblClientes) & ","
            sql += "nomeFilho = " & objCon.valorSql(_obj.nomeFilho.Trim) & ","
            sql += "sexo = " & objCon.valorSql(_obj.sexo.Trim) & ","
            sql += "dataNascimento_filho = " & objCon.valorSql(_obj.dataNascimento_filho) & " "
            sql += "where id = " & objCon.valorSql(_obj.id) & " "

            AtualizarFilhos = objCon.executaQuery(sql)
            If AtualizarFilhos Then
                Logs.RegistrarLOG(_obj.id, _obj.cliente.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO FILHOS DE CLIENTES")
            End If
            Return AtualizarFilhos
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO FILHOS DE CLIENTES")
            Return False
        End Try

    End Function

    'função que verifica se ja existe registro já cadastrado
    Public Function ValidaDuplicidadeFilhos(ByVal _desc_registro As String, ByVal id_registro As Integer) As Boolean

        Try
            sql = "Select * from tb_clientes_filhos where nomeFilho = " & objCon.valorSql(_desc_registro.Trim)
            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    If id_registro = drRow("id") Then
                        ValidaDuplicidadeFilhos = True 'retorna true nos casos em que pode alterar
                    Else
                        ValidaDuplicidadeFilhos = False 'Não permite inclusão/alteração pois já existe
                    End If
                Next drRow
            Else
                ValidaDuplicidadeFilhos = True 'Deixa incluir
            End If
            Return ValidaDuplicidadeFilhos
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO FILHOS DE CLIENTES")
            Return False
        End Try

    End Function
End Class
