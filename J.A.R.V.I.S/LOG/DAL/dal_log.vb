Public Class Dal_log
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private sql As String

    Public Function Incluir(ByVal log As dto_log) As Boolean
        sql = "Insert into tb_log ("
        sql += "[data], "
        sql += "[funcaoExecutada], "
        sql += "[erroNumero], "
        sql += "[erroDescricao], "
        sql += "[idUsuario], "
        sql += "[versaoSis], "
        sql += "[idiomaPC], "
        sql += "[hostname], "
        sql += "[acao]) "
        sql += "values ( "
        sql += objCon.valorSql(log.data) & ", "
        sql += objCon.valorSql(log.funcaoExecutada) & ", "
        sql += objCon.valorSql(log.erroNumero) & ", "
        sql += objCon.valorSql(log.erroDescricao) & ", "
        sql += objCon.valorSql(log.idUsuario) & ", "
        sql += objCon.valorSql(log.versaoSis) & ", "
        sql += objCon.valorSql(log.idiomaPC) & ", "
        sql += objCon.valorSql(log.hostname) & ", "
        sql += objCon.valorSql(log.acao) & ") "

        Incluir = objCon.executaQuery(sql)
    End Function
End Class
