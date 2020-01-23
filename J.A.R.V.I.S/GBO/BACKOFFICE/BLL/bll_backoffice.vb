Public Class bll_backoffice

    Private dal As New dal_backoffice
    Private dt As New DataTable
    Private dto As New dto_backoffice
    Private Logs As New Bll_log
    Private hlp As New Uteis.Helpers

    Public Function capturarRegistro(ByRef dto_back As dto_backoffice) As Boolean
        Try
            With dto_back

                'Validar se há algum registro preso para o usuário logado
                Dim id_locado = dal.validarRegistroLocadoPorUsuario(dto_back)
                If id_locado > 0 Then
                    If MsgBox(sessaoNomeUsuario & " existe um registro que você não finalizou. Deseja finalizar agora?", vbQuestion + vbYesNo, TITULO_ALERTA) = vbYes Then
                        dto_back.id = id_locado
                    End If
                End If


                'Específico
                If .id > 0 Then
                    capturarRegistro = dal.capturarRegistroTrabalho(dto_back)
                End If

                'Automático
                If .tipo_registro = "A" And .id = 0 Then
                    capturarRegistro = dal.capturarRegistroTrabalho(dto_back)
                End If

                'Manual
                If .tipo_registro = "M" And .id = 0 Then
                    dto_back.data_imp = hlp.dataHoraAtual()
                    capturarRegistro = dal.gerarNovoCaso(dto_back)
                End If


            End With

            If capturarRegistro Then
                Return True
            Else
                MsgBox("Não foi possível capturar nenhum registro com as características solicitadas!", vbInformation + vbOKOnly, TITULO_ALERTA)
                dto_back = Nothing
                Return False
            End If

        Catch ex As Exception
            dto_back = Nothing
            Return False
        End Try
    End Function

    Public Sub capturarListaClientesDisponiveisPorFila(ByVal frm As Form, ByVal cb As ComboBox, ByVal id_fila As Integer)
        dal.capturarClientesDiposniveisPorFila(frm, cb, id_fila)
    End Sub

    Public Function carregarListViewHistoricoCliente(ByVal ltv As ListView, ByVal id_cliente As Integer) As Boolean
        Try
            dt = dal.getHistoricoRegistrosPorCliente(id_cliente)
            ltv.Clear()
            'AJUSTANDO AS COLUNAS
            With ltv
                .View = View.Details
                .LabelEdit = False
                .CheckBoxes = False
                .SmallImageList = imglist() 'Utilizando um modulo publico
                .GridLines = True
                .FullRowSelect = True
                .HideSelection = False
                .MultiSelect = False
                .Columns.Add("PROTOCOLO:", 100, HorizontalAlignment.Center)
                .Columns.Add("FILA:", 100, HorizontalAlignment.Left)
                .Columns.Add("TRABALHAR À PARTIR DE:", 150, HorizontalAlignment.Left)
                .Columns.Add("DATA TRABALHADA:", 150, HorizontalAlignment.Left)
                .Columns.Add("FINALIZAÇÃO:", 150, HorizontalAlignment.Left)
                .Columns.Add("SUBFINALIZAÇÃO:", 150, HorizontalAlignment.Left)
                .Columns.Add("OBSERVAÇÃO:", 300, HorizontalAlignment.Left)
            End With
            'POPULANDO
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows
                    Dim item As New ListViewItem()
                    item.Text = drRow("id")
                    item.SubItems.Add(drRow("fila"))
                    item.SubItems.Add(IIf(IsDBNull(drRow("data_imp")), "", drRow("data_imp")))
                    item.SubItems.Add(IIf(IsDBNull(drRow("data_cat")), "", drRow("data_cat")))
                    item.SubItems.Add(IIf(IsDBNull(drRow("finalizacao")), "", drRow("finalizacao")))
                    item.SubItems.Add(IIf(IsDBNull(drRow("subfinalizacao")), "", drRow("subfinalizacao")))
                    item.SubItems.Add(IIf(IsDBNull(drRow("observacao")), "", drRow("observacao")))

                    If drRow("status") = 0 Then
                        item.ImageKey = 3 'vermelho
                    ElseIf drRow("status") = 1 Then
                        item.ImageKey = 2 'amarelo
                    Else
                        item.ImageKey = 1 'verde
                    End If
                    ltv.Items.Add(item)
                Next drRow
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

    Public Function liberarRegistro(ByVal dto_back As dto_backoffice) As Boolean

        Try
            'Confirmar se o registro está locado para o mesmo usuário que deseja liberar o registro
            'Se sim, prosseguir com a alteração de status
            'Se não, apenas retornar um FALSO POSITIVO para que as funções que invoquem este médoto possa prosseguir com suas etapas
            If Not dal.confirmarUsuiarioCatAntesSalvar(dto_back) Then
                MsgBox("Registro já trabalho em outro momento. Limpeza de SUAS alterações realizadas com sucesso!", vbInformation + vbOKOnly, TITULO_ALERTA)
                Return True
            End If

            If dal.alterarStatus(dto_back, 0) Then
                MsgBox("Cancelado, com sucesso!", vbInformation + vbOKOnly, TITULO_ALERTA)
                Return True
            Else
                MsgBox("Não foi possível cancelar a categorização deste registro!", vbCritical + vbOKOnly, TITULO_ALERTA)
                Return False
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub rollbackRegistros()
        dal.rollbackRegistrosLocados()
    End Sub

    Public Function finalizarRegistro(ByVal dto_back As dto_backoffice) As Boolean
        Try
            Dim validacao As Boolean = False
            Dim rotear As Boolean = False
            Dim roteado As Boolean = False
            Dim filaNovoCaso As Integer = 0
            Dim agingNovoCaso As Integer = 0

            Dim finalizacao As New bll_finalizacoes
            Dim fin_dto As New dto_finalizacoes

            Dim subfinalizacao As New bll_subfinalizacoes
            Dim subfin_dto As New dto_subfinalizacoes

            'Fazer rollback de registros locados
            rollbackRegistros()

            'Validar se o registro está locado para o mesmo usuário que está tentando finalizar
            If Not dal.confirmarUsuiarioCatAntesSalvar(dto_back) Then
                MsgBox("Atualize a fila de trabalho e confirme que este registro ainda está disponível para trablahar!", vbInformation, TITULO_ALERTA)
                Return False
            End If

            'Finalizar o registro
            If dal.salvarRegistro(dto_back) Then
                validacao = True

                'Validar se as subfin requer um follow
                If Not subfinalizacao.roteamentoPorSubFinalizacao(dto_back.subfinalizacao_id, subfin_dto) Then
                    'Se a subfin não requer um follow, verificar se a fin requer
                    If finalizacao.roteamentoPorFinalizacao(dto.finalizacao_id, fin_dto) Then
                        filaNovoCaso = fin_dto.filaNovoCaso
                        agingNovoCaso = fin_dto.agingNovoCaso
                        rotear = True
                    End If
                Else
                    filaNovoCaso = subfin_dto.filaNovoCaso
                    agingNovoCaso = subfin_dto.agingNovoCaso
                    rotear = True
                End If

            End If


            If rotear Then

                'Criar novo registro
                With dto_back
                    .roteamento_id = .id
                    .fila_id = filaNovoCaso
                    .status = 0
                    .tipo_registro = "A"
                    '.cliente_id = .cliente_id
                    .produto_id = 0
                    .contrato_id = 0
                    .contrato_assinado = False
                    .pgto_realizado = False
                    .finalizacao_id = 0
                    .subfinalizacao_id = 0
                    .observacao = "Protocolo anterior = " & .id
                    .data_cat = Nothing
                    .usuario_cat = Nothing
                    .data_imp = hlp.dataAbreviada().AddDays(agingNovoCaso) & " 08:00:00" 'calculando o aging de retorno
                End With

                'Validando se o roteamento ocorreu corretamente
                roteado = dal.gerarNovoCaso(dto_back)

            End If

            If (validacao And Not rotear) Or (validacao And rotear And roteado) Then
                MsgBox("Registro salvo com sucesso!", vbInformation, TITULO_ALERTA)
                Return True
            Else
                If Not validacao Then
                    MsgBox("Erro ao salvar o registro!", vbCritical, TITULO_ALERTA)
                    Return False
                ElseIf validacao And Not roteado Then
                    MsgBox("Registro salvo, porém não foi possível criar um novo registro para contato futuro!", vbCritical, TITULO_ALERTA)
                    Return False
                Else
                    MsgBox("Erro ao salvar o registro!", vbCritical, TITULO_ALERTA)
                    Return False
                End If
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
