Public Class dal_relatorios

    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private Logs As New Bll_log
    Private rs As ADODB.Recordset
    Private sql As String
    Private dt As DataTable
    Private hlp As New Uteis.Helpers


    ''' <summary>
    ''' Função para exportar um RS para excel
    ''' </summary>
    ''' <param name="strSql"></param>
    ''' <returns></returns>
    Public Function exportarRS_excel(ByVal strSql As String) As Boolean
        Try
            Dim rs As New ADODB.Recordset
            rs = objCon.retornaRs(strSql)
            hlp.exportarRS_excel(rs)
            rs.Close()
            rs = Nothing
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
