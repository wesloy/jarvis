Public Class dal_menu
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private sql As String
    Private dto As New dto_menu
    Private dt As DataTable
    Private hlp As New Uteis.Helpers

    Public Function DeletaMenuPorId(ByVal _Id As Integer) As Boolean
        sql = "Delete from tb_menu where id=" & objCon.valorSql(_Id)
        Return objCon.ExecutaQuery(sql)
    End Function
    'Salvo toda as informações dentro de um DataTable
    'parametro de filtro opcional
    Public Function GetMenus(Optional ByVal filtro As String = "") As DataTable ' OleDb.OleDbDataReader
        sql = "Select * "
        sql = sql & "from tb_menu "
        sql = sql & "where descricao like ('" & filtro & "%') " 'filtro opcional 

        GetMenus = objCon.RetornaDataTable(sql)
    End Function
    'incluir no banco de dados o objeto passado via parametro
    Public Function Incluir(ByVal menu As dto_menu) As Boolean
        sql = "Insert into tb_menu "
        sql = sql & "(descricao)"
        sql = sql & "values( "
        sql = sql & objCon.valorSql(menu.descricao.Trim) & ")"

        Return objCon.executaQuery(sql)
    End Function
    Public Function Atualizar(ByVal menu As dto_menu) As Boolean
        sql = "Update tb_menu "
        sql = sql & "set descricao = " & objCon.valorSql(menu.descricao.Trim) & " "
        sql = sql & "where id = " & objCon.valorSql(menu.ID) & " "

        Return objCon.executaQuery(sql)
    End Function
    Public Function Salvar(ByVal menu As dto_menu) As Boolean
        If menu.Acao = FlagAcao.Insert Then
            Salvar = Me.Incluir(menu)
        ElseIf menu.Acao = FlagAcao.Update Then
            Salvar = Me.Atualizar(menu)
        End If
        Return Salvar
    End Function

    Public Sub GetComboboxMenus(frm As Form, cb As ComboBox)

        Try
            sql = "Select id, descricao from tb_menu Order By descricao "
            dt = objCon.RetornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try

    End Sub

    'Função para capturar o nome do menu liberado por modulo
    Public Function getNomeMenuPorId(intId As Integer) As String
        sql = "Select * "
        sql += "FROM tb_menu "
        sql += "WHERE id = " & objCon.valorSql(intId) & " "

        dt = objCon.retornaDataTable(sql)
        Dim retorno As String = "" ' Form
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                retorno = objCon.retornaVazioParaValorNulo(drRow("descricao"))
            Next drRow
        Else
            retorno = ""
        End If
        Return retorno
    End Function

    'Função para capturar o comentário do menu
    Public Function getComentarioMenuPorId(intId As Integer) As String
        sql = "Select * "
        sql += "FROM tb_menu "
        sql += "WHERE id = " & objCon.valorSql(intId) & " "

        dt = objCon.retornaDataTable(sql)
        Dim retorno As String = "" ' Form
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                retorno = objCon.retornaVazioParaValorNulo(drRow("comentario"))
            Next drRow
        Else
            retorno = ""
        End If
        Return retorno
    End Function
End Class
