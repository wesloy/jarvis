Public Class dal_finalizacoes
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private sql As String
    Private finalizacaoDTO As New dto_finalizacoes
    Private dt As DataTable
    Private hlp As New Uteis.Helpers
    Private Logs As New Bll_log


    'parametro de filtro opcional
    Public Function GetFinalizacoes(Optional ByVal filtro As String = "", Optional ByVal filtroFila As String = "") As DataTable
        sql = "Select tb_finalizacoes.*, tb_filas.descricao as DescricaoFila, tb_usuarios.nome, fd.descricao as DescricaoFilaDestino "
        sql += "from ((tb_finalizacoes "
        sql += "LEFT JOIN tb_filas ON tb_finalizacoes.IdFila = tb_filas.id) "
        sql += "LEFT JOIN tb_usuarios ON tb_usuarios.id = tb_finalizacoes.idCadastro) "
        sql += "LEFT JOIN tb_filas fd ON tb_finalizacoes.filaNovoCaso = fd.id "
        sql += "where tb_finalizacoes.descricao like ('" & filtro & "%') " 'filtro opcional por finalizacao
        sql += "and tb_filas.descricao like ('" & filtroFila & "%') "
        GetFinalizacoes = objCon.retornaDataTable(sql)
    End Function
    'captura as filas relacionadas de uma determinada finalizacao
    Public Function GetFilasPorFinalizacao(ByVal finalizacao As String) As DataTable
        sql = "SELECT tb_filas.id, tb_filas.descricao, tb_filas.sigla  "
        sql += "FROM tb_filas "
        sql += "INNER JOIN tb_finalizacoes ON tb_filas.id = tb_finalizacoes.IdFila "
        sql += "WHERE tb_finalizacoes.descricao = " & objCon.valorSql(finalizacao) & " "
        sql += "GROUP BY tb_filas.id, tb_filas.descricao, tb_filas.sigla "
        GetFilasPorFinalizacao = objCon.retornaDataTable(sql)
    End Function
    'captura as informações por id e retorna o objeto
    Public Function GetFinalizacaoPorId(ByVal _finalizacaoID As Integer) As dto_finalizacoes
        sql = "Select * from tb_finalizacoes where id= " & objCon.valorSql(_finalizacaoID)
        dt = objCon.retornaDataTable(sql)
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                With finalizacaoDTO
                    'geral
                    .ID = objCon.retornaVazioParaValorNulo(drRow("id"))
                    .Descricao = objCon.retornaVazioParaValorNulo(drRow("descricao"))
                    .Situacao = objCon.retornaVazioParaValorNulo(drRow("situacao"))
                    .IDFila = objCon.retornaVazioParaValorNulo(drRow("idFila"))
                    'roteamento
                    .GeraNovoCaso = objCon.retornaVazioParaValorNulo(drRow("geraNovoCaso"))
                    .agingNovoCaso = objCon.retornaVazioParaValorNulo(drRow("agingNovoCaso"), 0)
                    .filaNovoCaso = objCon.retornaVazioParaValorNulo(drRow("filaNovoCaso"), 0)
                    .renomearParaRoteamento = objCon.retornaVazioParaValorNulo(drRow("renomearParaRoteamento"), 0)
                    'Caracterização da finalização
                    .cttoEfetivo = objCon.retornaVazioParaValorNulo(drRow("cttoEfetivo"), 0)
                    .cttoPassivelEfetividade = objCon.retornaVazioParaValorNulo(drRow("cttoPassivelEfetividade"), 0)
                    .dataCadastro = objCon.retornaVazioParaValorNulo(drRow("dataCadastro"), Nothing)
                    .idCadastro = objCon.retornaVazioParaValorNulo(drRow("idCadastro"))
                    .Acao = FlagAcao.NoAction
                End With
            Next drRow
        End If
        Return finalizacaoDTO
    End Function
    'deleta as informações por id
    Public Function DeletaFinalizacaoPorId(ByVal _finalizacaoId As Integer) As Boolean
        Try
            sql = "Delete from tb_finalizacoes where id=" & objCon.valorSql(_finalizacaoId)

            DeletaFinalizacaoPorId = objCon.executaQuery(sql)
            If DeletaFinalizacaoPorId Then
                Logs.RegistrarLOG(_finalizacaoId, , hlp.getCurrentMethodName, "MANUTENÇÃO FINALIZACAO")
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    'incluir no banco de dados o objeto passado via parametro
    Public Function Incluir(ByVal _finalizacao As dto_finalizacoes) As Boolean
        Try
            sql = "Insert into tb_finalizacoes "
            'Geral
            sql += "(descricao,"
            sql += "situacao,"
            sql += "idFila, "
            'Roteamento
            sql += "agingNovoCaso, "
            sql += "filaNovoCaso, "
            sql += "geraNovoCaso, "
            'Caracterização Finalização
            sql += "cttoEfetivo, "
            sql += "cttoPassivelEfetividade, "
            sql += "dataCadastro, "
            sql += "idCadastro) "


            'Geral
            sql += "values ("
            sql += objCon.valorSql(_finalizacao.descricao, False) & ","
            sql += objCon.valorSql(_finalizacao.situacao, False) & ","
            sql += objCon.valorSql(_finalizacao.idFila, False) & ","
            'Roteamento
            sql += objCon.valorSql(_finalizacao.agingNovoCaso, False) & ","
            sql += objCon.valorSql(_finalizacao.filaNovoCaso, False) & ","
            sql += objCon.valorSql(_finalizacao.geraNovoCaso, False) & ","
            'Caracterização Finalização
            sql += objCon.valorSql(_finalizacao.cttoEfetivo, False) & ","
            sql += objCon.valorSql(_finalizacao.cttoPassivelEfetividade, False) & ","
            sql += objCon.valorSql(hlp.dataHoraAtual) & ","
            sql += objCon.valorSql(sessaoIdUsuario) & ")"

            Incluir = objCon.executaQuery(sql)
            If Incluir Then
                Logs.RegistrarLOG(0, _finalizacao.Descricao, hlp.getCurrentMethodName, "MANUTENÇÃO FINALIZACAO")
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Atualizar(ByVal _finalizacao As dto_finalizacoes) As Boolean
        Try
            sql = "Update tb_finalizacoes "
            'Geral
            sql += "set descricao = " & objCon.valorSql(_finalizacao.Descricao.Trim) & ","
            sql += "situacao = " & objCon.valorSql(_finalizacao.Situacao) & ","
            sql += "idFila = " & objCon.valorSql(_finalizacao.IDFila) & ","
            'Roteamento
            sql += "agingNovoCaso = " & objCon.valorSql(_finalizacao.agingNovoCaso) & ", "
            sql += "filaNovoCaso = " & objCon.valorSql(_finalizacao.filaNovoCaso) & ", "
            sql += "geraNovoCaso = " & objCon.valorSql(_finalizacao.GeraNovoCaso) & ", "
            'Caracterizacao da finalização
            sql += "cttoEfetivo = " & objCon.valorSql(_finalizacao.cttoEfetivo) & ", "
            sql += "cttoPassivelEfetividade = " & objCon.valorSql(_finalizacao.cttoPassivelEfetividade) & ", "
            sql += "dataCadastro = " & objCon.valorSql(hlp.dataHoraAtual) & ", "
            sql += "idCadastro = " & objCon.valorSql(sessaoIdUsuario) & " "
            sql += "where id = " & objCon.valorSql(_finalizacao.ID) & " "
            Atualizar = objCon.executaQuery(sql)
            If Atualizar Then
                Logs.RegistrarLOG(_finalizacao.ID, _finalizacao.Descricao, hlp.getCurrentMethodName, "MANUTENÇÃO FINALIZACAO")
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    'função que verifica se ja existe cadastrado
    Public Function ValidaDuplicidade(obj As dto_finalizacoes) As Boolean
        sql = "Select * from tb_finalizacoes "
        sql += "where descricao = " & objCon.valorSql(obj.Descricao.Trim) & " "
        sql += "and tb_finalizacoes.idFila = " & objCon.valorSql(obj.IDFila) & " "

        dt = objCon.retornaDataTable(sql)
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                'se alterar
                If obj.Acao = FlagAcao.Update Then
                    If obj.ID = drRow("id") Then
                        ValidaDuplicidade = True 'para permitir alterar o mesmo caso
                        Exit Function 'Sair imediatamente
                    Else : ValidaDuplicidade = False
                    End If
                    'se novo registros
                ElseIf obj.Acao = FlagAcao.Insert Then
                    If obj.Descricao.ToUpper = drRow("descricao").ToString.ToUpper And obj.IDFila = drRow("idFila") Then
                        ValidaDuplicidade = False
                        Exit Function 'Sair imediatamente
                    Else : ValidaDuplicidade = True
                    End If
                Else
                End If
            Next drRow
        Else
            ValidaDuplicidade = True 'Deixa incluir
        End If
        Return ValidaDuplicidade
    End Function
    Public Function Salvar(ByVal _finalizacao As dto_finalizacoes) As Boolean
        If _finalizacao.Acao = FlagAcao.Insert Then
            Salvar = Me.Incluir(_finalizacao)
        ElseIf _finalizacao.Acao = FlagAcao.Update Then
            Salvar = Me.Atualizar(_finalizacao)
        End If
        Return Salvar
    End Function

    'Finalização por area/Fila
    Public Sub GetComboboxFinalizacao(frm As Form, cb As ComboBox, Optional ByVal fila As Integer = 0)
        Try
            sql = "Select * from tb_finalizacoes "
            sql += "where situacao = " & objCon.valorSql(True) & " "
            sql += "and tb_finalizacoes.idfila = " & objCon.valorSql(fila) & " "
            sql += "order by tb_finalizacoes.descricao asc "
            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try

    End Sub

    'Finalização por Area
    Public Sub GetComboboxFinalizacaoPorArea_DescricaoFila(frm As Form, cb As ComboBox, Optional ByVal fila As String = "")

        Try
            sql = "Select tb_finalizacoes.id as id, tb_finalizacoes.descricao as descricao, * from tb_finalizacoes "
            sql += "INNER JOIN tb_filas ON tb_finalizacoes.IdFila = tb_filas.id "
            sql += "where tb_finalizacoes.situacao = " & objCon.valorSql(True) & " "
            sql += "and tb_filas.descricao = " & objCon.valorSql(fila) & " "
            sql += "order by tb_finalizacoes.descricao asc "
            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try

    End Sub


    'Captura de informação se a finalização GERA Roteamento
    Public Function roteamentoPorFinalizacao(ByVal idFinalizacao As Integer) As dto_finalizacoes

        If idFinalizacao = 0 Then
            Return Nothing
        End If

        finalizacaoDTO = GetFinalizacaoPorId(idFinalizacao)
        With finalizacaoDTO
            If .GeraNovoCaso Then 'Retorna dto apenas se a finalização for passível de roteamento
                Return finalizacaoDTO
            Else
                Return Nothing
            End If
        End With
    End Function
End Class
