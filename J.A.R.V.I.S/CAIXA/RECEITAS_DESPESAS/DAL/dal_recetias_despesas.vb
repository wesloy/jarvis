Public Class dal_recetias_despesas
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private Logs As New Bll_log
    Private rs As ADODB.Recordset
    Private sql As String
    Private dt As DataTable
    Private hlp As New Uteis.Helpers
    Private dto As New dto_receitas_despesas

    Public Function DeletaPorId(ByVal _id As Integer) As Boolean 'deleta as informações por id

        Try
            sql = "Delete from tb_receitas_despesas where id=" & objCon.valorSql(_id)
            DeletaPorId = objCon.executaQuery(sql)
            If DeletaPorId Then
                Logs.RegistrarLOG(_id, , hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
            End If
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
            Return False
        End Try

    End Function

    'parametro de filtro opcional
    Public Function GetRegistros(Optional ByVal filtro As String = "") As DataTable
        Try
            sql = "Select tb_receitas_despesas.* "
            sql += "from tb_receitas_despesas "
            sql += "where (descricao like ('" & filtro & "%')) " 'filtro opcional por descricção do registro
            sql += "order by tb_receitas_despesas.id ASC "
            Return objCon.retornaDataTable(sql)
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
            Return Nothing
        End Try

    End Function

    'captura as informações por id e retorna o objeto
    Public Function GetRegistrosPorId(ByVal _id As Integer) As dto_receitas_despesas
        Try
            sql = "Select * from tb_receitas_despesas where id = " & objCon.valorSql(_id)

            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    With dto
                        .id = objCon.retornaVazioParaValorNulo(drRow("id"))
                        .descricao = objCon.retornaVazioParaValorNulo(drRow("descricao"))
                        .tipoRegistro = objCon.retornaVazioParaValorNulo(drRow("tipoRegistro"))
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
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
            Return Nothing
        End Try

    End Function

    'incluir no banco de dados o objeto passado via parametro
    Public Function Incluir(ByVal _obj As dto_receitas_despesas) As Boolean
        Try
            sql = "Insert into tb_receitas_despesas "
            sql += "(descricao,"
            sql += "tipoRegistro, "
            sql += "observacao, "
            sql += "ativo,"
            sql += "dataCadastro, "
            sql += "idCadastro) "
            sql += "values( "
            sql += objCon.valorSql(_obj.descricao) & ","
            sql += objCon.valorSql(_obj.tipoRegistro) & ","
            sql += objCon.valorSql(_obj.observacao) & ","
            sql += objCon.valorSql(_obj.ativo) & ","
            sql += objCon.valorSql(hlp.dataHoraAtual()) & ", "
            sql += objCon.valorSql(sessaoIdUsuario) & ")"

            Incluir = objCon.executaQuery(sql)
            If Incluir Then
                Logs.RegistrarLOG(0, _obj.descricao.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
            End If
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
            Return False
        End Try

    End Function
    Public Function Atualizar(ByVal _obj As dto_receitas_despesas) As Boolean

        Try
            sql = "Update tb_receitas_despesas "
            sql += "set descricao = " & objCon.valorSql(_obj.descricao.Trim) & ","
            sql += "tipoRegistro = " & objCon.valorSql(_obj.tipoRegistro) & ", "
            sql += "observacao = " & objCon.valorSql(_obj.observacao) & ", "
            sql += "ativo = " & objCon.valorSql(_obj.ativo) & ","
            sql += "dataCadastro = " & objCon.valorSql(hlp.dataHoraAtual()) & ","
            sql += "idCadastro = " & objCon.valorSql(sessaoIdUsuario) & " "
            sql += "where id = " & objCon.valorSql(_obj.id) & " "

            Atualizar = objCon.executaQuery(sql)
            If Atualizar Then
                Logs.RegistrarLOG(_obj.id, _obj.descricao.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
            End If
            Return Atualizar
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
            Return False
        End Try

    End Function

    'função que verifica se ja existe registro já cadastrado
    Public Function ValidaDuplicidade(ByVal _desc_registro As String, ByVal id_registro As Integer) As Boolean

        Try
            sql = "Select * from tb_receitas_despesas where descricao = " & objCon.valorSql(_desc_registro.Trim)
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
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
            Return False
        End Try

    End Function
    Public Function Salvar(ByVal _obj As dto_receitas_despesas) As Boolean
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
            sql = "Select ID from tb_receitas_despesas WHERE tb_receitas_despesas.descricao like " & objCon.valorSql(_registroNome) & " "
            dt = objCon.retornaDataTable(sql)

            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    Return drRow("ID")
                Next drRow
            End If
            Return 0
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
            Return 0
        End Try

    End Function
    'Todas os registros ativos para listagem em combobox
    Public Sub GetComboboxRegistros(frm As Form, cb As ComboBox)

        Try
            sql = "Select tb_receitas_despesas.id, tb_receitas_despesas.descricao from tb_receitas_despesas where ativo = true "
            sql += "order by tb_receitas_despesas.descricao asc"

            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "MANUTENÇÃO RECEITAS DESPESAS")
        End Try
    End Sub
End Class
