Imports Utils

Public Class dal_modulo_usuarios
    Private objCon As New Utils.Conexao(Utils.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private sql As String
    Private dto As New dto_modulo_usuarios
    Private hlp As New Utils.Helpers
    Private dt As DataTable


    Public Function DeletaModuloAcessoPorId(ByVal _moduloId As Integer) As Boolean
        sql = "Delete from MX_sysModuloDeAcessoUsuario where id=" & objCon.valorSql(_moduloId)

        Return objCon.executaQuery(sql)
    End Function
    'Salvo toda as informações dentro de um DataTable
    'parametro de filtro opcional
    Public Function GetModulosAcesso(Optional ByVal filtro As String = "") As DataTable ' OleDb.OleDbDataReader
        sql = "Select MX_sysModuloDeAcessoUsuario.*, MX_sysModulos.modulo as DescricaoModulo  "
        sql += "from MX_sysModuloDeAcessoUsuario "
        sql += "LEFT JOIN MX_sysModulos ON MX_sysModuloDeAcessoUsuario.id_modulo = MX_sysModulos.id "
        sql += "WHERE id_usuario like ('" & filtro & "') " 'filtro opcional por id de rede
        GetModulosAcesso = objCon.retornaDataTable(sql)
    End Function
    'captura as informações por id e retorna o objeto
    Public Function GetModuloAcessoPorId(ByVal _moduloId As Integer) As dto_modulo_usuarios
        sql = "Select * from MX_sysModuloDeAcessoUsuario where id = " & objCon.valorSql(_moduloId)

        dt = objCon.retornaDataTable(sql)
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                With dto
                    .id = objCon.retornaVazioParaValorNulo(drRow("id"))
                    .idUsuario = objCon.retornaVazioParaValorNulo(drRow("id_usuario"))
                    .idModulo = objCon.retornaVazioParaValorNulo(drRow("id_modulo"))
                    .Acao = FlagAcao.NoAction
                End With
            Next drRow
        End If
        Return dto
    End Function
    'incluir no banco de dados o objeto passado via parametro
    Public Function Incluir(ByVal modulo As dto_modulo_usuarios) As Boolean
        sql = "Insert into MX_sysModuloDeAcessoUsuario "
        sql = sql & "(id_usuario,"
        sql = sql & "id_modulo) "
        sql = sql & "values( "
        sql = sql & objCon.valorSql(modulo.idUsuario) & ","
        sql = sql & objCon.valorSql(modulo.idModulo) & ")"

        Return objCon.executaQuery(sql)
    End Function
    Public Function Atualizar(ByVal modulo As dto_modulo_usuarios) As Boolean
        sql = "Update MX_sysModuloDeAcessoUsuario "
        sql = sql & "set id_usuario = " & objCon.valorSql(modulo.idUsuario.Trim) & ", "
        sql = sql & "id_modulo = " & objCon.valorSql(modulo.idModulo) & " "
        sql = sql & "where id = " & objCon.valorSql(modulo.id) & " "

        Return objCon.executaQuery(sql)
    End Function
    Public Function Salvar(ByVal modulo As dto_modulo_usuarios) As Boolean
        If modulo.Acao = FlagAcao.Insert Then
            Salvar = Me.Incluir(modulo)
        ElseIf modulo.Acao = FlagAcao.Update Then
            Salvar = Me.Atualizar(modulo)
        End If
        Return Salvar
    End Function
    'função que verifica se ja existe cadastrado
    Public Function ValidaDuplicidade(ByVal _modulo As Integer, ByVal id_registro As Integer, ByVal _id_rede As String) As Boolean
        sql = "Select * from MX_sysModuloDeAcessoUsuario "
        sql = sql & "where id_usuario = " & objCon.valorSql(_id_rede.Trim)
        sql = sql & "and id_modulo = " & objCon.valorSql(_modulo)

        dt = objCon.retornaDataTable(sql)
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                If id_registro = drRow("id") Or _modulo <> drRow("id_modulo") Then
                    ValidaDuplicidade = True 'retorna true nos casos em que pode alterar
                Else
                    ValidaDuplicidade = False 'Não permite inclusão/alteração pois já existe
                End If
            Next drRow
        Else
            ValidaDuplicidade = True 'Deixa incluir
        End If
        Return ValidaDuplicidade
    End Function

    'Método para listar no combobox os modulos liberados por usuário
    Public Sub GetComboboxModulosAcessoLogin(strIdRede As String, frm As Form, cb As ComboBox)

        Try
            sql = "select MX_sysModulos.id, MX_sysModulos.modulo "
            sql = sql & "FROM MX_sysModuloDeAcessoUsuario INNER JOIN MX_sysModulos ON MX_sysModuloDeAcessoUsuario.id_modulo = MX_sysModulos.id "
            sql = sql & "where MX_sysModuloDeAcessoUsuario.id_usuario = " & objCon.valorSql(strIdRede) & " "
            sql = sql & "order by MX_sysModulos.modulo asc "

            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try

    End Sub

End Class
