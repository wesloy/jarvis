Public Class dal_backoffice
    Private objCon As New Uteis.Conexao(Uteis.Conexao.FLAG_SGBD.ACESS, _PWD, _BD, _SERVIDOR, _USER, PATH_BD)
    Private Logs As New Bll_log
    Private rs As ADODB.Recordset
    Private sql As String
    Private dt As DataTable
    Private hlp As New Uteis.Helpers
    Private dto As New dto_backoffice

    Public Function gerarNovoCaso(ByRef dto As dto_backoffice) As Boolean
        Try

            Dim dataHoraAtual As DateTime = hlp.dataHoraAtual()

            With dto
                sql = "Insert Into tb_base "
                sql += "(roteamento_id, "
                sql += "fila_id, "
                sql += "status, "
                sql += "tipo_registro, "
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
                sql += objCon.valorSql(.roteamento_id, False) & ", "
                sql += objCon.valorSql(.fila_id, False) & ", "
                sql += objCon.valorSql(.status, False) & ", "
                sql += objCon.valorSql(.tipo_registro, False) & ", "
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
                sql += objCon.valorSql(sessaoIdUsuario, False) & ") "
            End With

            'Capturando registro recem criado, caso a data de importação seja para hoje, se a data for futura, trata-se de um follow e não é necessário capturar
            If objCon.executaQuery(sql) Then
                If hlp.FormataDataAbreviada(dto.data_imp) = hlp.dataAbreviada() Then
                    sql = "Select * from tb_base "
                    sql += "WHERE usuario_imp = " & objCon.valorSql(sessaoIdUsuario, False) & " "
                    sql += "AND day(data_imp) = " & objCon.valorSql(dataHoraAtual.Day, False) & " "
                    sql += "AND month(data_imp) = " & objCon.valorSql(dataHoraAtual.Month, False) & " "
                    sql += "AND year(data_imp) = " & objCon.valorSql(dataHoraAtual.Year, False) & " "
                    sql += "AND hour(data_imp) = " & objCon.valorSql(dataHoraAtual.Hour, False) & " "
                    sql += "AND Minute(data_imp) = " & objCon.valorSql(dataHoraAtual.Minute, False) & " "
                    sql += "AND Second(data_imp) = " & objCon.valorSql(dataHoraAtual.Second, False) & " "
                    sql += "AND fila_id = " & objCon.valorSql(dto.fila_id, False) & " "
                    sql += "AND status = 0 "
                    dt = objCon.retornaDataTable(sql)

                    dto = Nothing
                    If dt.Rows.Count > 0 Then 'Carregando o DTO
                        For Each linha As DataRow In dt.Rows 'Efeturar o looping até o fim
                            dto = getRegistroPorId(objCon.retornaVazioParaValorNulo(linha("id")))
                        Next
                    End If
                End If

            Else
                'Sair da função de forma positiva, já que não é preciso capturar o registro criado por se
                Return True
            End If

            'Não criou o registro
            If dto Is Nothing Then
                Return False
            Else
                'capturar o registro para trabalho
                If capturarRegistroTrabalho(dto) Then
                    Return True
                End If
            End If

            Return False

        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "CRIAR NOVO CASO")
            Return False
        End Try
    End Function

    Public Function getRegistroPorId(ByVal _ID As Long, Optional idRoteamento As Long = 0) As dto_backoffice
        Try
            Dim dtoBase As New dto_backoffice
            If idRoteamento = 0 Then
                sql = "Select * from tb_base where id = " & objCon.valorSql(_ID)
            Else
                sql = "Select * from tb_base where roteamento_id = " & objCon.valorSql(idRoteamento)
            End If
            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows 'efetua o loop até o fim
                    With dtoBase
                        .id = objCon.retornaVazioParaValorNulo(drRow("id"), 0)
                        .roteamento_id = objCon.retornaVazioParaValorNulo(drRow("roteamento_id"), 0)
                        .fila_id = objCon.retornaVazioParaValorNulo(drRow("fila_id"), 0)
                        If .fila_id > 0 Then
                            Dim obj As New bll_filas
                            .fila_desc = obj.GetDescricaoFilaPorID(.fila_id)
                        End If
                        .status = objCon.retornaVazioParaValorNulo(drRow("status"), 0)
                        .tipo_registro = objCon.retornaVazioParaValorNulo(drRow("tipo_registro"), Nothing)
                        .cliente_id = objCon.retornaVazioParaValorNulo(drRow("cliente_id"), 0)
                        If .cliente_id > 0 Then
                            Dim obj As New bll_clientes
                            .cliente_desc = obj.GetDescricaoRegistroPorID(.cliente_id)
                        End If
                        .produto_id = objCon.retornaVazioParaValorNulo(drRow("produto_id"), 0)
                        If .produto_id > 0 Then
                            Dim obj As New bll_produtos
                            .produto_desc = obj.GetDescricaoRegistroPorID(.produto_id)
                        End If
                        .contrato_id = objCon.retornaVazioParaValorNulo(drRow("contrato_id"), 0)
                        If .contrato_id > 0 Then
                            Dim obj As New bll_contratos
                            '.contrato_desc = obj.GetDescricaoRegistroPorID(.contrato_id)
                        End If
                        .contrato_assinado = objCon.retornaVazioParaValorNulo(drRow("contrato_assinado"), False)
                        .pgto_realizado = objCon.retornaVazioParaValorNulo(drRow("pgto_realizado"), False)
                        .finalizacao_id = objCon.retornaVazioParaValorNulo(drRow("finalizacao_id"), 0)
                        If .finalizacao_id > 0 Then
                            Dim obj As New bll_finalizacoes
                            .finalizacao_desc = obj.GetNomeFinalizacaoPorID(.finalizacao_id)
                        End If
                        .subfinalizacao_id = objCon.retornaVazioParaValorNulo(drRow("subfinalizacao_id"), 0)
                        If .subfinalizacao_id > 0 Then
                            Dim obj As New bll_subfinalizacoes
                            .subfinalizacao_desc = obj.GetNomeSubFinalizacaoPorID(.subfinalizacao_id)
                        End If
                        .observacao = objCon.retornaVazioParaValorNulo(drRow("observacao"), Nothing)
                        .data_cat = objCon.retornaVazioParaValorNulo(drRow("data_cat"), Nothing)
                        .usuario_cat = objCon.retornaVazioParaValorNulo(drRow("usuario_cat"), Nothing)
                        If .usuario_cat > 0 Then
                            Dim obj As New bll_usuarios
                            .usuario_cat_desc = obj.GetNomeUsuarioPorCodigo(.usuario_cat)
                        End If
                        .data_imp = objCon.retornaVazioParaValorNulo(drRow("data_imp"), Nothing)
                        .usuario_imp = objCon.retornaVazioParaValorNulo(drRow("usuario_imp"), Nothing)
                        If .usuario_imp > 0 Then
                            Dim obj As New bll_usuarios
                            .usuario_imp_desc = obj.GetNomeUsuarioPorCodigo(.usuario_imp)
                        End If
                        .acao = FlagAcao.NoAction
                    End With
                Next drRow
            Else
                dtoBase = Nothing
            End If
            Return dtoBase
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "CAPTURAR CASO POR ID")
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Utilizado para confirmar se o registro que será salvo está locado para o mesmo usuário que o capturou
    ''' se a locação do registro for diferente, significa que o mesmo sofreu rollback devido o tempo que ficou locado
    ''' </summary>
    ''' <param name="dto"></param>
    ''' <returns></returns>
    Public Function confirmarUsuiarioCatAntesSalvar(ByVal dto As dto_backoffice) As Boolean
        Try
            sql = "Select * from tb_base where id = " & objCon.valorSql(dto.id, False) & " "
            dt = objCon.retornaDataTable(sql)
            If dt.Rows.Count > 0 Then
                For Each linha As DataRow In dt.Rows
                    If linha("usuario_cat") = dto.usuario_cat Then
                        Return True
                    End If
                Next
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function salvarRegistro(dto As dto_backoffice) As Boolean
        Try
            With dto
                sql = "Update tb_base SET "
                sql += "roteamento_id = " & objCon.valorSql(.roteamento_id, False) & ", "
                sql += "fila_id = " & objCon.valorSql(.fila_id, False) & ", "
                sql += "status = " & objCon.valorSql(.status, False) & ", "
                sql += "tipo_registro = " & objCon.valorSql(.tipo_registro, False) & ", "
                sql += "cliente_id = " & objCon.valorSql(.cliente_id, False) & ", "
                sql += "produto_id = " & objCon.valorSql(.produto_id, False) & ", "
                sql += "contrato_id = " & objCon.valorSql(.contrato_id, False) & ", "
                sql += "contrato_assinado = " & objCon.valorSql(.contrato_assinado, False) & ", "
                sql += "pgto_realizado = " & objCon.valorSql(.pgto_realizado, False) & ", "
                sql += "finalizacao_id = " & objCon.valorSql(.finalizacao_id, False) & ", "
                sql += "subfinalizacao_id = " & objCon.valorSql(.subfinalizacao_id, False) & ", "
                sql += "observacao = " & objCon.valorSql(.observacao, False) & ", "
                sql += "data_cat = " & objCon.valorSql(.data_cat, False) & ", "
                sql += "usuario_cat = " & objCon.valorSql(.usuario_cat, False) & " "
                sql += "Where "
                sql += "id = " & objCon.valorSql(.id) & " "
            End With
            Return objCon.executaQuery(sql)
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "SALVAR REGISTRO")
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Função para deletar registro por ID
    ''' Principal utilização é quando o usuário cria um novo caso manualmente e depois cancela a ação de categorização
    ''' </summary>
    ''' <param name="idRegistro"></param>
    ''' <returns></returns>
    Public Function deletarPorID(ByVal idRegistro As Integer) As Boolean

        sql = "Delete FROM tb_base "
        sql += "WHERE tb_base.ID = " & objCon.valorSql(idRegistro, False) & " "
        Try
            Return objCon.executaQuery(sql)
        Catch ex As Exception
            MsgBox("Não foi possível apagar o registro, tente outra vez. Se o erro persistir contate o a Administrador!" _
                   , vbInformation, TITULO_ALERTA)
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Deleção registro = " & idRegistro)
            Return False
        End Try
    End Function

    Public Function validarRegistroLocadoPorUsuario(ByVal dto_back As dto_backoffice) As Integer
        Try
            sql = "Select * from tb_base where status = 1 and usuario_cat = " & objCon.valorSql(dto_back.usuario_cat, False) & " "
            sql += "and tipo_registro =  " & objCon.valorSql(dto_back.tipo_registro, False) & " "
            dt = objCon.retornaDataTable(sql)

            If dt.Rows.Count > 0 Then
                For Each linha As DataRow In dt.Rows
                    Return linha("id")
                Next
            End If

            Return 0
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "CAPTURAR REGISTRO LOCADO USUÁRIO = " & dto_back.usuario_cat)
            Return 0
        End Try
    End Function
    ''' <summary>
    ''' 0 carregado
    ''' 1 trabalhando
    ''' 2 finalizado
    ''' </summary>
    ''' <param name="dto_base"></param>
    ''' <returns></returns>
    Public Function alterarStatus(ByVal dto_base As dto_backoffice, ByVal status As Integer) As Boolean
        Try
            With dto_base

                'Deletar apenas se for para alterar o status para 0 e for uma entrada MANUAL
                If status = 0 And .tipo_registro = "M" Then
                    sql = "Delete from tb_base where id = " & objCon.valorSql(.id, False) & " "
                Else
                    sql = "Update tb_base set "
                    sql += "status = " & objCon.valorSql(status, False) & ", "
                    sql += "usuario_cat = " & objCon.valorSql(sessaoIdUsuario) & ", "
                    sql += "data_cat = " & objCon.valorSql(hlp.dataHoraAtual, False) & " "
                    sql += "WHERE tb_base.ID = " & objCon.valorSql(.id, False) & " "
                End If
                Return objCon.executaQuery(sql)
            End With

        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "ALTERAÇÃO DE STATUS. ID = " & dto_base.id)
            Return False
        End Try
    End Function

    Public Function capturarRegistroTrabalho(ByRef dto_base As dto_backoffice) As Boolean

        Try
            With dto_base
                If .id > 0 Then
                    'capturar de um registro específico
                    sql = "Select * from tb_base where id = " & objCon.valorSql(.id, False) & " "
                    dt = objCon.retornaDataTable(sql)

                    If dt.Rows.Count > 0 Then
                        For Each linha As DataRow In dt.Rows
                            If linha("status") < 2 Then
                                'Alterar status
                                alterarStatus(dto_base, FlagStatus.TrabalharRegistro)
                                'Retornando registro atualizado
                                dto_base = getRegistroPorId(.id)
                            Else
                                'Caso já finalizado
                                MsgBox("O registro selecionado para trablaho já foi finalizado e não pode ser reaberto!", vbInformation + vbOKOnly, TITULO_ALERTA)
                                Return False
                            End If
                        Next
                    End If

                Else
                    'buscando um registro disponível para trabalho

                    Dim id_bloqueado As Integer
                    Dim validacao As Boolean
                    Dim retorno As Integer

                    sql = "Select * from tb_base where fila_id = " & objCon.valorSql(.fila_id) & " and status = 0"
                    dt = objCon.retornaDataTable(sql)
                    'looping para conseguir um registro disponível
                    If dt.Rows.Count > 0 Then
                        For Each ln As DataRow In dt.Rows
                            id_bloqueado = ln("id")
                            sql = "Update tb_base set "
                            sql += "status = " & objCon.valorSql(FlagStatus.TrabalharRegistro, False) & ", "
                            sql += "usuario_cat = " & objCon.valorSql(sessaoIdUsuario) & ", "
                            sql += "data_cat = " & objCon.valorSql(hlp.dataHoraAtual, False) & " "
                            sql += "Where 1 = 1 "
                            sql += "and fila_id = " & objCon.valorSql(.fila_id, False) & " "
                            sql += "and status = 0 " 'Garantindo que outra pessoa não capturou o mesmo registro
                            validacao = objCon.executaQuery(sql, retorno)
                            If retorno > 0 Then
                                dto_base = getRegistroPorId(id_bloqueado)
                            End If
                        Next
                    Else
                        'Caso não consiga capturar nenhum registro
                        Return False
                    End If
                End If
            End With

            'Status de caso capturado para trabalho
            If dto_base.status = 1 Then
                Return True
            Else
                dto_base = Nothing
                Return False
            End If


        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "CAPTURAR REGISTRO P/ TRABALHO = " & dto_base.id)
            dto_base = Nothing
            Return False
        End Try
    End Function

    Public Function getHistoricoRegistrosPorCliente(ByVal idCliente As Integer) As DataTable
        Try
            sql = "select b.id, f.descricao as fila, b.data_cat, fin.descricao as finalizacao, sfin.descricao as subfinalizacao, b.observacao, b.status   
                        from (((tb_base b 
                        left join tb_filas f on b.fila_id = f.id)  
                        left join tb_finalizacoes fin on b.finalizacao_id = fin.id) 
                        left join tb_subfinalizacoes sfin on b.subfinalizacao_id = sfin.id) "
            sql += "where b.cliente_id = 1 "
            Return objCon.retornaDataTable(sql)

        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "CAPTURAR HISTORICO DO CLIENTE = " & idCliente)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Voltar registros para a fila e/ou deletar registros após um tempo de espera.
    ''' Padrão atual de 6 horas de espera.
    ''' </summary>
    Public Sub rollbackRegistrosLocados()
        Try
            sql = "Select * from tb_base where status = 1 and data_cat < " & objCon.valorSql(hlp.dataHoraAtual.AddHours(-6), False) & " "
            dt = objCon.retornaDataTable(sql)


            If dt.Rows.Count = 0 Then
                sql = "Select * from tb_base where data_imp < " & objCon.valorSql(hlp.dataHoraAtual.AddHours(-6), False) & " "
                sql += "and status < 2 and tipo_registro = 'M'"
                dt = objCon.retornaDataTable(sql)
            End If

            If dt.Rows.Count > 0 Then
                For Each ln As DataRow In dt.Rows
                    If ln("tipo_registro") = "M" Then
                        'Deletar já que o registro tem entrada manual
                        deletarPorID(ln("id"))
                    Else
                        'Alterar status para disponível já que a entrada é automática (GBO)
                        alterarStatus(getRegistroPorId(ln("id")), 0)
                    End If
                Next
            End If

        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "ROLLBACK DE REGISTROS")
        End Try

    End Sub

    Public Sub capturarClientesDiposniveisPorFila(ByVal frm As Form, ByVal cb As ComboBox, ByVal id_fila As Integer)
        Try

            'Rollback casos presos
            rollbackRegistrosLocados()

            'Capturar lista de clientes (ID + NOME)
            sql = "select c.id, c.cliente from tb_base b inner join tb_clientes c on b.cliente_id = c.id "
            sql += "Where b.fila_id = " & objCon.valorSql(id_fila, False) & " "
            sql += "and status = 0 "
            dt = objCon.retornaDataTable(sql)
            hlp.carregaComboBox(dt, frm, cb, False,,, True)
        Catch ex As Exception
            Logs.RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "CAPTURAR CLIENTES DISP POR FILA")
        End Try
    End Sub


End Class
