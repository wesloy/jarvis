Public Class dal_filas
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private Logs As New Bll_log
    Private rs As ADODB.Recordset
    Private sql As String
    Private dt As DataTable
    Private hlp As New Uteis.Helpers
    Private dto As New dto_filas

    Public Function DeletaFilaPorId(ByVal _filaId As Integer) As Boolean 'deleta as informações por id

        Try
            sql = "Delete from tb_filas where id=" & objCon.valorSql(_filaId)

            DeletaFilaPorId = objCon.executaQuery(sql)
            If DeletaFilaPorId Then
                Logs.RegistrarLOG(_filaId, , hlp.getCurrentMethodName, "MANUTENÇÃO FILAS")
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    'parametro de filtro opcional
    Public Function GetFilas(Optional ByVal filtro As String = "") As DataTable
        sql = "Select tb_filas.* "
        sql += "from tb_filas "
        sql += "where (descricao like ('" & filtro & "%') " 'filtro opcional por fila
        sql += "or sigla like ('" & filtro & "%')) " 'filtro opcional por sigla
        sql += "order by tb_filas.id ASC, tb_filas.capturaAutomatica asc "
        GetFilas = objCon.retornaDataTable(sql)
    End Function

    'captura as informações por id e retorna o objeto
    Public Function GetFilaPorId(ByVal _filaId As Integer) As dto_filas
        sql = "Select * from tb_filas where id= " & objCon.valorSql(_filaId)

        dt = objCon.retornaDataTable(sql)
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                With dto
                    .id = objCon.retornaVazioParaValorNulo(drRow("id"))
                    .descricao = objCon.retornaVazioParaValorNulo(drRow("descricao"))
                    .sigla = objCon.retornaVazioParaValorNulo(drRow("sigla"))
                    .ativo = objCon.retornaVazioParaValorNulo(drRow("ativo"))
                    .capturaAutomatica = objCon.retornaVazioParaValorNulo(drRow("capturaAutomatica"))
                    .grupo = objCon.retornaVazioParaValorNulo(drRow("grupo"))
                    .permitirAberturaManual = objCon.retornaVazioParaValorNulo(drRow("permitirAberturaManual"))
                    .dataCadastro = objCon.retornaVazioParaValorNulo(drRow("dataCadastro"), Nothing)
                    .idCadastro = objCon.retornaVazioParaValorNulo(drRow("idCadastro"))
                    .acao = FlagAcao.NoAction
                End With
            Next drRow
        End If
        Return dto
    End Function

    'incluir no banco de dados o objeto passado via parametro
    Public Function Incluir(ByVal _fila As dto_filas) As Boolean
        Try
            sql = "Insert into tb_filas "
            sql += "(descricao,"
            sql += "sigla,"
            sql += "ativo,"
            sql += "capturaAutomatica,"
            sql += "grupo, "
            sql += "permitirAberturaManual, "
            sql += "dataCadastro, "
            sql += "idCadastro) "
            sql += "values( "
            sql += objCon.valorSql(_fila.descricao) & ","
            sql += objCon.valorSql(_fila.sigla) & ","
            sql += objCon.valorSql(_fila.ativo) & ","
            sql += objCon.valorSql(_fila.capturaAutomatica) & ","
            sql += objCon.valorSql(_fila.grupo) & ", "
            sql += objCon.valorSql(_fila.permitirAberturaManual) & ", "
            sql += objCon.valorSql(hlp.dataHoraAtual()) & ", "
            sql += objCon.valorSql(sessaoIdUsuario) & ")"

            Incluir = objCon.executaQuery(sql)
            If Incluir Then
                Logs.RegistrarLOG(0, _fila.descricao.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO FILAS")
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Atualizar(ByVal _fila As dto_filas) As Boolean

        Try
            sql = "Update tb_filas "
            sql += "set descricao = " & objCon.valorSql(_fila.descricao.Trim) & ","
            sql += "sigla = " & objCon.valorSql(_fila.sigla.Trim) & ","
            sql += "ativo = " & objCon.valorSql(_fila.ativo) & ","
            sql += "capturaAutomatica = " & objCon.valorSql(_fila.capturaAutomatica) & ","
            sql += "permitirAberturaManual = " & objCon.valorSql(_fila.permitirAberturaManual) & ","
            sql += "grupo = " & objCon.valorSql(_fila.grupo) & ", "
            sql += "dataCadastro = " & objCon.valorSql(hlp.dataHoraAtual()) & ","
            sql += "idCadastro = " & objCon.valorSql(sessaoIdUsuario) & " "
            sql += "where id = " & objCon.valorSql(_fila.id) & " "

            Atualizar = objCon.executaQuery(sql)
            If Atualizar Then
                Logs.RegistrarLOG(_fila.id, _fila.descricao.Trim, hlp.getCurrentMethodName, "MANUTENÇÃO FILAS")
            End If
            Return Atualizar
        Catch ex As Exception
            Return False
        End Try

    End Function

    'função que verifica se ja existe fila cadastrada
    Public Function ValidaDuplicidade(ByVal _fila As String, ByVal id_registro As Integer) As Boolean
        sql = "Select * from tb_filas where descricao = " & objCon.valorSql(_fila.Trim)

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
    End Function
    Public Function Salvar(ByVal _fila As dto_filas) As Boolean
        If _fila.acao = FlagAcao.Insert Then
            Salvar = Me.Incluir(_fila)
        ElseIf _fila.acao = FlagAcao.Update Then
            Salvar = Me.Atualizar(_fila)
        End If
        Return Salvar
    End Function


    'Capturar o ID da Fila pelo nome
    Public Function GetIdFilaPorNome(ByVal NomeFila As String) As Integer
        sql = "Select ID from tb_filas WHERE tb_filas.descricao like " & objCon.valorSql(NomeFila) & " "

        dt = objCon.retornaDataTable(sql)

        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                Return drRow("ID")
            Next drRow
        End If
        Return 0
    End Function
    'Todas as filas ou todas as filas por área
    Public Sub GetComboboxFila(frm As Form, cb As ComboBox)

        Try
            sql = "Select tb_filas.id, tb_filas.descricao from tb_filas where ativo = true "
            sql += "order by tb_filas.descricao asc"

            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try
    End Sub

    'Filas que podem ter abertura manual 
    Public Sub GetComboboxFilasAberturaProducaoManual(frm As Form, cb As ComboBox)

        Try
            sql = "Select tb_filas.id, tb_filas.descricao from tb_filas where ativo = " & objCon.valorSql(True) & " and permitirAberturaManual = " & objCon.valorSql(True) & " "
            sql = sql & "order by tb_filas.descricao asc"

            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try


    End Sub



    'listagem de filas com volume para trabalho e também de todas as filas
    Public Sub GetComboboxFilaAutomatica(frm As Form, cb As ComboBox, ByVal area As Integer, Optional somenteComVolume As Boolean = True, Optional siglaFila As String = "sigla")


        Try

            Dim data As Date = hlp.FormataDataAbreviada(Now)

            sql = "Select tb_filas.id, tb_filas.descricao "

            If somenteComVolume Then
                ''FILAS COM VOLUME
                sql += "FROM tb_base INNER JOIN tb_filas On tb_base.fila_id = tb_filas.id "
                sql += "where "
                sql += "(tb_filas.ativo = " & objCon.valorSql(True) & ") "
                sql += "And (tb_filas.capturaAutomatica = " & objCon.valorSql(True) & ") "
                sql += "And (tb_base.status = 0 ) " 'status de casos que ainda não foram trabalhados
                sql += "And Convert(varchar, tb_base.dataImportacao, 121) + ' ' + convert(varchar, tb_base.horaimportacao, 114) <= " & objCon.valorSql(hlp.dataHoraAtual) & " "
                sql += "GROUP BY tb_filas.id, tb_filas.descricao, tb_filas.ativo, tb_filas.capturaAutomatica, tb_base.status "

            Else
                ''RELACAO DAS FILAS
                sql += "from tb_filas "
                sql += "where "
                sql += "(tb_filas.ativo = " & objCon.valorSql(True) & ") "
                sql += "and (tb_filas.capturaAutomatica = " & objCon.valorSql(True) & ") "
                sql += "GROUP BY tb_filas.id, tb_filas.descricao, tb_filas.ativo, tb_filas.capturaAutomatica "
            End If

            sql = sql & "order by tb_filas.descricao asc"

            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try

    End Sub

    Public Sub GetComboboxFilaManual(frm As Form, cb As ComboBox)

        Try
            sql = "Select tb_filas.id, tb_filas.descricao "
            sql += "FROM tb_filas "
            sql += "where "
            sql += "(tb_filas.ativo = " & objCon.valorSql(True) & ") "
            sql += "and (tb_filas.permitirAberturaManual = " & objCon.valorSql(True) & ") "
            sql += "order by tb_filas.descricao asc"

            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try


    End Sub

    Public Function AlterarStatusTodasFilas(ByVal situacao As Boolean) As Boolean
        sql = "Update tb_filas Set "
        sql = sql & "ativo = " & objCon.valorSql(situacao) & " "
        Logs.RegistrarLOG(, , hlp.getCurrentMethodName, situacao)
        Return objCon.executaQuery(sql)
    End Function

    'Esta manutenção foi necessária porque na criação foi estabelecido DUPLO ID nas tabelas (tb_base, MX_sysFinalizacao, MX_sysSubFinalizacao, tb_filasDeAcessoUsuario, MX_sysPlanejamento)
    'de forma desnecessária, poderia apenas ser o ID de Fila. Como o programa já está em utilização e existe inúmeras amarrações, optei em fazer esta adequação.
    Public Function propagarAlteracaoIdArea(ByVal nomeTabela As String, ByVal idArea As Integer, ByVal idFila As Integer) As Boolean

        Select Case nomeTabela.ToUpper
            Case "MATRIX"
                sql = "UPDATE tb_base T SET T.area_ID = " & objCon.valorSql(idArea)
                sql += " WHERE (T.fila_ID = " & objCon.valorSql(idFila) & ") "

            Case "FINALIZACAO"
                sql = "UPDATE MX_sysFinalizacao T SET T.idArea = " & objCon.valorSql(idArea)
                sql += " WHERE (T.idFila = " & objCon.valorSql(idFila) & ") "

            Case "SUBFINALIZACAO"
                sql = "UPDATE MX_sysSubFinalizacao T SET T.idArea = " & objCon.valorSql(idArea)
                sql += " WHERE (T.idFila = " & objCon.valorSql(idFila) & ") "

            Case "FILASPORUSUARIOS"
                sql = "UPDATE tb_filasDeAcessoUsuario T SET T.id_area = " & objCon.valorSql(idArea)
                sql += " WHERE (T.id_fila = " & objCon.valorSql(idFila) & ") "

            Case "VOLPLANEJADO"
                sql = "UPDATE MX_sysPlanejamento T SET T.areaID =  " & objCon.valorSql(idArea)
                sql += " WHERE (T.filaID = " & objCon.valorSql(idFila) & ") "

        End Select

        Return objCon.executaQuery(sql)

    End Function


End Class
