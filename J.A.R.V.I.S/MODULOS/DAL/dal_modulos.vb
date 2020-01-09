Public Class dal_modulos
    Private objCon As New Utils.Conexao(Utils.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private sql As String
    Private dto As New dto_modulos
    Private dt As DataTable
    Private hlp As New Utils.Helpers
    Private Logs As New Bll_log

    'Salvo toda as informações dentro de um DataTable
    'parametro de filtro opcional
    Public Function GetModulos(Optional ByVal filtro As String = "") As DataTable ' OleDb.OleDbDataReader
        sql = "Select MX_sysModulos.*, MX_sysAreas.area AS DescricaoArea "
        sql = sql & "from MX_sysModulos "
        sql = sql & "LEFT JOIN MX_sysAreas ON MX_sysModulos.idArea = MX_sysAreas.id "
        sql = sql & "where modulo like ('" & filtro & "%') " 'filtro opcional por id de rede
        sql = sql & "order by MX_sysModulos.modulo asc"
        GetModulos = objCon.retornaDataTable(sql)
    End Function
    'captura as informações por id e retorna o objeto
    Public Function GetModuloPorId(ByVal _moduloId As Integer) As dto_modulos
        sql = "Select * from MX_sysModulos where id= " & objCon.valorSql(_moduloId)
        dt = objCon.retornaDataTable(sql)
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                With dto
                    .ID = objCon.retornaVazioParaValorNulo(drRow("id"))
                    .Modulo = objCon.retornaVazioParaValorNulo(drRow("modulo"))
                    .NomeFormPrincipal = objCon.retornaVazioParaValorNulo(drRow("NomeFormPrincipal"))
                    .Situacao = objCon.retornaVazioParaValorNulo(drRow("situacao"))
                    .IdMenu = objCon.retornaVazioParaValorNulo(drRow("id_menu"))
                    .IDArea = objCon.retornaVazioParaValorNulo(drRow("idArea"))
                    .Acao = FlagAcao.NoAction
                End With
            Next drRow
        End If
        Return dto
    End Function
    'Deletar Módulo
    Public Function DeletaModuloPorId(ByVal _moduloId As Integer) As Boolean
        Try
            sql = "Delete from MX_sysModulos where id=" & objCon.valorSql(_moduloId)

            DeletaModuloPorId = objCon.executaQuery(sql)
            If DeletaModuloPorId Then
                Logs.registrarLOG(_moduloId, , hlp.getCurrentMethodName, "MANUTENÇÃO MODULO")
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function
    'incluir no banco de dados o objeto passado via parametro
    Public Function Incluir(ByVal modulo As dto_modulos) As Boolean
        Try
            sql = "Insert into MX_sysModulos "
            sql = sql & "(modulo,"
            sql = sql & "NomeFormPrincipal,"
            sql = sql & "situacao, "
            sql = sql & "id_menu, "
            sql = sql & "idArea) "
            sql = sql & "values( "
            sql = sql & objCon.valorSql(modulo.Modulo) & ","
            sql = sql & objCon.valorSql(modulo.NomeFormPrincipal) & ","
            sql = sql & objCon.valorSql(modulo.Situacao) & ","
            sql = sql & objCon.valorSql(modulo.IdMenu) & ","
            sql = sql & objCon.valorSql(modulo.IDArea) & ")"

            Incluir = objCon.executaQuery(sql)
            If Incluir Then
                Logs.registrarLOG(0, modulo.Modulo, hlp.getCurrentMethodName, "MANUTENÇÃO MDULO")
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Atualizar(ByVal modulo As dto_modulos) As Boolean
        Try
            sql = "Update MX_sysModulos "
            sql = sql & "set modulo = " & objCon.valorSql(modulo.Modulo.Trim) & ", "
            sql = sql & "NomeFormPrincipal = " & objCon.valorSql(modulo.NomeFormPrincipal.Trim) & ", "
            sql = sql & "situacao = " & objCon.valorSql(modulo.Situacao) & ", "
            sql = sql & "id_menu = " & objCon.valorSql(modulo.IdMenu) & ", "
            sql = sql & "idArea = " & objCon.valorSql(modulo.IDArea) & " "
            sql = sql & "where id = " & objCon.valorSql(modulo.ID) & " "

            Atualizar = objCon.executaQuery(sql)
            If Atualizar Then
                Logs.registrarLOG(modulo.ID, modulo.Modulo.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO MODULO")
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Salvar(ByVal modulo As dto_modulos) As Boolean
        If modulo.Acao = FlagAcao.Insert Then
            Salvar = Me.Incluir(modulo)
        ElseIf modulo.Acao = FlagAcao.Update Then
            Salvar = Me.Atualizar(modulo)
        End If
        Return Salvar
    End Function

    Public Sub GetComboboxModulos(frm As Form, cb As ComboBox)
        Try
            dt = objCon.retornaDataTable("Select * from MX_sysModulos where situacao = " & objCon.valorSql(True) & " order by MX_sysModulos.modulo asc ")
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try
    End Sub

    'Função para capturar o nome do formulario que deve ser carregado por modulo
    Public Function capturaNomeFormPrincipalModulo(intIdModulo As Integer) As String
        sql = "Select NomeFormPrincipal from MX_sysModulos where situacao = " & objCon.valorSql(True) & " and id = " & objCon.valorSql(intIdModulo) & " "

        dt = objCon.RetornaDataTable(sql)
        Dim retorno As String = "" ' Form
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                retorno = objCon.retornaVazioParaValorNulo(drRow("NomeFormPrincipal"))
            Next drRow
        Else
            retorno = ""
        End If
        Return retorno
    End Function

    'Função para capturar a área do modulo acessado
    Public Function capturaNomeAreaPorModulo(intIdModulo As Integer) As String
        sql = "Select MX_sysAreas.area AS DescricaoArea "
        sql = sql & "from MX_sysModulos "
        sql = sql & "LEFT JOIN MX_sysAreas ON MX_sysModulos.idArea = MX_sysAreas.id "
        sql = sql & "where [MX_sysModulos].situacao = " & objCon.valorSql(True) & " and [MX_sysModulos].id = " & objCon.valorSql(intIdModulo) & " "
        dt = objCon.retornaDataTable(sql)
        Dim retorno As String = "" ' Form
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                retorno = objCon.retornaVazioParaValorNulo(drRow("DescricaoArea"))
            Next drRow
        Else
            retorno = ""
        End If
        Return retorno
    End Function

    'Função para capturar a área do modulo acessado
    Public Function capturaIDAreaPorModulo(intIdModulo As Integer) As String
        sql = "Select MX_sysAreas.ID AS Id_Area "
        sql = sql & "from MX_sysModulos "
        sql = sql & "LEFT JOIN MX_sysAreas ON MX_sysModulos.idArea = MX_sysAreas.id "
        sql = sql & "where [MX_sysModulos].situacao = " & objCon.valorSql(True) & " and [MX_sysModulos].id = " & objCon.valorSql(intIdModulo) & " "
        dt = objCon.retornaDataTable(sql)
        Dim retorno As String = "" ' Form
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                retorno = objCon.retornaVazioParaValorNulo(drRow("Id_Area"))
            Next drRow
        Else
            retorno = 0
        End If
        Return retorno
    End Function
End Class
