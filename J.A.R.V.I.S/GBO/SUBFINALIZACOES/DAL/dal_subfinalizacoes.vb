Public Class dal_subfinalizacoes
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private sql As String
    Private SubFinalizacaoDTO As New dto_subfinalizacoes
    Private dt As DataTable
    Private hlp As New Uteis.Helpers
    Private RS As ADODB.Recordset
    Private Logs As New Bll_log


    'parametro de filtro opcional
    Public Function GetSubFinalizacoes(Optional ByVal filtro As String = "", Optional ByVal filtroArea As String = "", Optional ByVal filtroFila As String = "") As DataTable
        sql = "Select tb_subfinalizacoes.*, MX_sysAreas.area AS DescricaoArea, MX_sysFinalizacao.descricao as DescricaoFinalizacao, MX_sysFilas.fila as DescricaoFila "
        sql += "from ((tb_subfinalizacoes "
        sql += "LEFT JOIN MX_sysAreas ON tb_subfinalizacoes.idArea = MX_sysAreas.id) "
        sql += "LEFT JOIN MX_sysFinalizacao ON tb_subfinalizacoes.IdFinalizacao = MX_sysFinalizacao.id) "
        sql += "LEFT JOIN MX_sysFilas ON tb_subfinalizacoes.IdFila = MX_sysFilas.id "
        sql += "where tb_subfinalizacoes.descricao like ('" & filtro & "%') " 'filtro opcional por finalizacao
        sql += "and MX_sysAreas.area like('" & filtroArea & "%') "
        sql += "and MX_sysFilas.fila like('" & filtroFila & "%') "

        GetSubFinalizacoes = objCon.retornaDataTable(sql)
    End Function
    'captura as informações por id e retorna o objeto
    Public Function GetSubFinalizacaoPorId(ByVal _SubFinalizacaoId As Integer) As dto_subfinalizacoes
        sql = "Select * from tb_subfinalizacoes where id= " & objCon.valorSql(_SubFinalizacaoId)

        dt = objCon.retornaDataTable(sql)
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                With SubFinalizacaoDTO
                    'GERAL
                    .id = objCon.retornaVazioParaValorNulo(drRow("id"))
                    .descricao = objCon.retornaVazioParaValorNulo(drRow("descricao"))
                    .situacao = objCon.retornaVazioParaValorNulo(drRow("situacao"))
                    .idFinalizacao = objCon.retornaVazioParaValorNulo(drRow("idFinalizacao"))
                    .idFila = objCon.retornaVazioParaValorNulo(drRow("idFila"))
                    'ROTEAMENTO
                    .geraNovoCaso = objCon.retornaVazioParaValorNulo(drRow("geraNovoCaso"))
                    .agingNovoCaso = objCon.retornaVazioParaValorNulo(drRow("agingNovoCaso"), 0)
                    .filaNovoCaso = objCon.retornaVazioParaValorNulo(drRow("filaNovoCaso"), 0)
                    'CARACTERISTICA
                    .cttoEfetivo = objCon.retornaVazioParaValorNulo(drRow("cttoEfetivo"), 0)
                    .cttoPassivelEfetividade = objCon.retornaVazioParaValorNulo(drRow("cttoPassivelEfetividade"), 0)
                    .Acao = FlagAcao.NoAction
                End With
            Next drRow
        End If
        Return SubFinalizacaoDTO
    End Function
    'EXCLUIR SUB
    Public Function DeletaSubFinalizacaoPorId(ByVal _SubFinalizacaoId As Integer) As Boolean 'deleta as informações por id
        Try
            sql = "Delete from tb_subfinalizacoes where id=" & objCon.valorSql(_SubFinalizacaoId)

            DeletaSubFinalizacaoPorId = objCon.executaQuery(sql)
            If DeletaSubFinalizacaoPorId Then
                Logs.registrarLOG(_SubFinalizacaoId, , hlp.getCurrentMethodName, "MANUTENÇÃO SUBFINALIZACAO")
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    'incluir no banco de dados o objeto passado via parametro
    Public Function Incluir(ByVal _SubFinalizacao As dto_subfinalizacoes) As Boolean
        Try
            sql = "Insert into tb_subfinalizacoes "
            'Geral
            sql += "(descricao,"
            sql += "situacao,"
            sql += "idFila, "
            sql += "idFinalizacao, "
            'Roteamento
            sql += "agingNovoCaso, "
            sql += "filaNovoCaso, "
            sql += "geraNovoCaso, "
            'Caracterização Finalização
            sql += "cttoEfetivo, "
            sql += "cttoPassivelEfetividade, "
            sql += "dataCadastro, "
            'Manipulação Case Manager
            sql += "idCadastro) "

            'Geral
            sql += "values ("
            sql += objCon.valorSql(_SubFinalizacao.descricao) & ","
            sql += objCon.valorSql(_SubFinalizacao.situacao, False) & ","
            sql += objCon.valorSql(_SubFinalizacao.idFila) & ","
            sql += objCon.valorSql(_SubFinalizacao.idFinalizacao) & ","
            'Roteamento                 
            sql += objCon.valorSql(_SubFinalizacao.agingNovoCaso, False) & ","
            sql += objCon.valorSql(_SubFinalizacao.filaNovoCaso) & ","
            sql += objCon.valorSql(_SubFinalizacao.geraNovoCaso, False) & ","
            'Caracterização Finalização 
            sql += objCon.valorSql(_SubFinalizacao.cttoEfetivo, False) & ","
            sql += objCon.valorSql(_SubFinalizacao.cttoPassivelEfetividade, False) & ","
            sql += objCon.valorSql(hlp.dataHoraAtual) & ","
            'Manipulação Case Manager
            sql += objCon.valorSql(sessaoIdUsuario) & ")"

            Incluir = objCon.executaQuery(sql)
            If Incluir Then
                Logs.registrarLOG(0, _SubFinalizacao.descricao, hlp.getCurrentMethodName, "MANUTENÇÃO SUBFINALIZACAO")
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Atualizar(ByVal _SubFinalizacao As dto_subfinalizacoes) As Boolean
        Try
            sql = "Update tb_subfinalizacoes "
            'Geral
            sql += "set descricao = " & objCon.valorSql(_SubFinalizacao.descricao.Trim) & ","
            sql += "situacao = " & objCon.valorSql(_SubFinalizacao.situacao) & ","
            sql += "idFila = " & objCon.valorSql(_SubFinalizacao.idFila) & ","
            sql += "idFinalizacao = " & objCon.valorSql(_SubFinalizacao.idFinalizacao) & ","
            'Roteamento
            sql += "agingNovoCaso = " & objCon.valorSql(_SubFinalizacao.agingNovoCaso) & ", "
            sql += "filaNovoCaso = " & objCon.valorSql(_SubFinalizacao.filaNovoCaso) & ", "
            sql += "geraNovoCaso = " & objCon.valorSql(_SubFinalizacao.geraNovoCaso) & ", "
            'Caracterizacao da finalização
            sql += "cttoEfetivo = " & objCon.valorSql(_SubFinalizacao.cttoEfetivo) & ", "
            sql += "cttoPassivelEfetividade = " & objCon.valorSql(_SubFinalizacao.cttoPassivelEfetividade) & ", "
            sql += "dataCadastro = " & objCon.valorSql(hlp.dataHoraAtual) & ", "
            'Manipulação Case Manager
            sql += "idCadastro = " & objCon.valorSql(sessaoIdUsuario) & " "
            sql += "where id = " & objCon.valorSql(_SubFinalizacao.id) & " "
            Atualizar = objCon.executaQuery(sql)
            If Atualizar Then
                Logs.registrarLOG(_SubFinalizacao.id, _SubFinalizacao.descricao, hlp.getCurrentMethodName, "MANUTENÇÃO SUBFINALIZACAO")
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    'função que verifica se ja existe cadastrado
    Public Function ValidaDuplicidade(ByVal _Subfinalizacao As String, ByVal id_registro As Integer, ByVal finalizacao As Integer) As Boolean
        sql = "Select * from tb_subfinalizacoes where descricao = " & objCon.valorSql(_Subfinalizacao.Trim)

        dt = objCon.retornaDataTable(sql)
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                If id_registro = drRow("id") Or finalizacao <> drRow("idFinalizacao") Then
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

    Public Sub GetComboboxSubFinalizacao(frm As Form, cb As ComboBox, Optional ByVal idFinalizacao As Integer = 0)

        Try
            sql = "Select * from tb_subfinalizacoes "
            sql += "where tb_subfinalizacoes.situacao = " & objCon.valorSql(True, False) & " "
            sql += "and tb_subfinalizacoes.idFinalizacao = " & objCon.valorSql(idFinalizacao) & " "
            sql += "order by tb_subfinalizacoes.descricao asc "

            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, True,,, True)
        Catch ex As Exception
            MsgBox(Err.Description & " - " & hlp.getCurrentMethodName)
        End Try

    End Sub

    Public Function Salvar(ByVal _SubFinalizacao As dto_subfinalizacoes) As Boolean
        If _SubFinalizacao.Acao = FlagAcao.Insert Then
            Salvar = Me.Incluir(_SubFinalizacao)
        ElseIf _SubFinalizacao.Acao = FlagAcao.Update Then
            Salvar = Me.Atualizar(_SubFinalizacao)
        End If
        Return Salvar
    End Function


    'Captura de informação se a Subfinalização GERA Roteamento
    Public Function roteamentoPorSubFinalizacao(ByVal idSubFinalizacao As Integer) As dto_subfinalizacoes

        If idSubFinalizacao = 0 Then
            Return Nothing
        End If
        SubFinalizacaoDTO = GetSubFinalizacaoPorId(idSubFinalizacao)
        With SubFinalizacaoDTO
            If .geraNovoCaso Then 'Retorna dto apenas se a finalização for passível de roteamento
                Return SubFinalizacaoDTO
            Else
                Return Nothing
            End If
        End With
    End Function

End Class
