Public Class dal_backoffice
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private Logs As New Bll_log
    Private rs As ADODB.Recordset
    Private sql As String
    Private dt As DataTable
    Private hlp As New Uteis.Helpers
    Private dto As New dto_backoffice

    Public Function GerarNovoCaso(ByVal dto As dto_backoffice) As Boolean
        Try
            With dto
                sql = "Insert Into tb_base "
                sql += "(fila_id, "
                sql += "status, "
                sql += "cliente_id, "
                sql += "produto_id, "
                sql += "contrato_id, "
                sql += "contrato_assinado, "
                sql += "pgto_realizado, "
                sql += "finalizacao_id, "
                sql += "subfinalizacao_id, "
                sql += "observacao, "
                sql += "data_cat, "
                sql += "usuario_cat, "
                sql += "data_imp, "
                sql += "usuario_imp) "
                sql += "values ("
                sql += objCon.valorSql(.fila_id, False) & ", "
                sql += objCon.valorSql(.status, False) & ", "
                sql += objCon.valorSql(.cliente_id, False) & ", "
                sql += objCon.valorSql(.produto_id, False) & ", "
                sql += objCon.valorSql(.contrato_id, False) & ", "
                sql += objCon.valorSql(.contrato_assinado, False) & ", "
                sql += objCon.valorSql(.pgto_realizado, False) & ", "
                sql += objCon.valorSql(.finalizacao_id, False) & ", "
                sql += objCon.valorSql(.subfinalizacao_id, False) & ", "
                sql += objCon.valorSql(.observacao, False) & ", "
                sql += objCon.valorSql(.data_cat, False) & ", "
                sql += objCon.valorSql(.usuario_cat, False) & ", "
                sql += objCon.valorSql(.data_imp, False) & ", "
                sql += objCon.valorSql(.usuario_imp, False) & ") "


                Return objCon.executaQuery(sql)
            End With
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Criar Novo Caso")
            Return False
        End Try
    End Function

    Public Function criarCasoManualmente(ByVal _dto As dto_backoffice) As dto_backoffice
        Try
            With _dto

                If GerarNovoCaso(_dto) Then
                    'Após registrar na base um novo caso, buscar o mesmo para carregar o número de ID para ser usado no preenchimento do form
                    sql = "Select * from tb_base "
                    sql += "WHERE ([usuario_imp] = " & objCon.valorSql(.usuario_imp) & ") "
                    sql += "AND ([data_imp] = " & objCon.valorSql(.data_imp) & ") "
                    sql += "AND ([status] = " & objCon.valorSql(.status) & ") "

                    dt = objCon.retornaDataTable(sql)

                    If dt.Rows.Count > 0 Then 'Carregando o DTO
                        For Each linha As DataRow In dt.Rows 'Efeturar o looping até o fim
                            _dto = GetBasePorId(objCon.retornaVazioParaValorNulo(linha("id")))
                        Next
                    End If
                End If
            End With

            Return _dto

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


End Class
