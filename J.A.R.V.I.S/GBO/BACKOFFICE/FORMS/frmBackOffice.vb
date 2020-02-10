Public Class frmBackOffice

#Region "VARIAVEIS"
    Private hlp As New Uteis.Helpers
    Private backOffice As New bll_backoffice
    Private filas As New bll_filas
    Private clientes As New bll_clientes
    Private produtos As New bll_produtos
    Private contratos As New bll_contratos
    Private finalizacoes As New bll_finalizacoes
    Private subFinalizacoes As New bll_subfinalizacoes

#End Region

    Private Sub limpeza(Optional ByVal parcial = False)
        hlp.limparCampos(gbInformacoesRelevantes)
        hlp.limparCampos(gbDados)
        hlp.limparCampos(gbConcluir)
        lvHistoricoCliente.Clear()

        cbFinalizacao.DataSource = Nothing
        cbSubfinalizacao.DataSource = Nothing

        If Not parcial Then
            hlp.limparCampos(gbIniciar)
        End If

        gbDados.Enabled = False
        gbConcluir.Enabled = False
        gbIniciar.Enabled = True

        clientes.PreencheCombobox(Me, cbCliente)

    End Sub

    Private Sub exibirDetalhes(ByVal titulo As String, ByVal id_busca As Integer)
        frmDetalhes.titulo = titulo
        frmDetalhes.id_busca = id_busca
        hlp.abrirForm(frmDetalhes)
    End Sub

    Private Function carregarDto(ByVal Optional parcial As Boolean = False) As dto_backoffice
        Try
            Dim dto_back As New dto_backoffice
            With dto_back
                If parcial Then

                    'Capturando dados básicos para criar ou buscar um registro para trabalho
                    .id = IIf(txtProtocolo.Text = "", 0, txtProtocolo.Text)
                    .fila_id = IIf(cbFila.Text <> "", cbFila.SelectedValue, 0)
                    .tipo_registro = IIf(rbAutomatica.Checked, "A", "M")
                    .cliente_id = IIf(cbCliente.SelectedValue Is Nothing, 0, cbCliente.SelectedValue)
                    .usuario_cat = sessaoIdUsuario
                Else

                    'Capturando todos os dados da tela
                    .id = IIf(txtProtocolo.Text = "", 0, txtProtocolo.Text)
                    .fila_id = IIf(cbFila.Text <> "", cbFila.SelectedValue, 0)
                    .tipo_registro = IIf(rbAutomatica.Checked, "A", "M")

                    .cliente_id = cbCliente.SelectedValue
                    .cliente_desc = cbCliente.Text
                    .produto_id = cbProduto.SelectedValue
                    .produto_desc = cbProduto.Text
                    .contrato_assinado = cbxContratoAssinado.Checked
                    .pgto_realizado = cbxPagamento.Checked

                    .usuario_cat = sessaoIdUsuario
                    .usuario_cat_desc = sessaoNomeUsuario
                    .finalizacao_id = cbFinalizacao.SelectedValue
                    .finalizacao_desc = cbFinalizacao.Text
                    .subfinalizacao_id = cbSubfinalizacao.SelectedValue
                    .subfinalizacao_desc = cbSubfinalizacao.Text
                    .observacao = txtObservacao.Text

                End If
            End With

            Return dto_back

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Sub historicoCliente()
        'Carregamento listviewHistórico
        Try
            If cbCliente.SelectedValue > 0 Then
                If Not backOffice.carregarListViewHistoricoCliente(lvHistoricoCliente, cbCliente.SelectedValue) Then
                    lvHistoricoCliente.Clear()
                End If
            End If
        Catch ex As Exception
            lvHistoricoCliente.Clear()
        End Try
    End Sub

    Private Sub frmBackOffice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpeza()

    End Sub

    Private Sub rbAutomatica_CheckedChanged(sender As Object, e As EventArgs) Handles rbAutomatica.CheckedChanged
        If rbAutomatica.Checked Then
            filas.PreencheComboFilaAutomatica(Me, cbFila, True)
            cbCliente.Enabled = False
            limpeza(True)
            linkAdcCliente.Enabled = False
            linkAtualizarCliente.Enabled = False
        End If
        cbFila.Enabled = True

    End Sub

    Private Sub rbManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbManual.CheckedChanged
        If rbManual.Checked Then
            filas.PreencheComboFilaManual(Me, cbFila)
            cbCliente.Enabled = True
            limpeza(True)
            linkAdcCliente.Enabled = True
            linkAtualizarCliente.Enabled = True
        End If
        cbFila.Enabled = True

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        'Validações de campos obrigatórios
        If Not rbAutomatica.Checked And Not rbManual.Checked Then
            MsgBox("Não foi selecionado o tipo de entrada! Selecione AUTOMÁTCO ou MANUAL.", vbInformation + vbOKOnly, TITULO_ALERTA)
            Exit Sub
        End If

        If Not hlp.validaCamposObrigatorios(gbIniciar, "cbFila") Then
            Exit Sub
        End If

        Dim dto_back As New dto_backoffice
        dto_back = carregarDto(True)
        'Carregando dados, se a captura ocorreu corretamente
        If backOffice.capturarRegistro(dto_back) Then
            With dto_back

                'Iniciar
                cbFila.SelectedValue = .fila_id
                cbCliente.SelectedValue = .cliente_id

                'Informações Relevantes
                txtProtocolo.Text = .id
                txtDataRegistro.Text = hlp.retornaDataTextBox(.data_imp)
                txtUsuarioResponsavel.Text = .usuario_imp_desc
                Dim d_fila As New dto_filas
                d_fila = filas.GetFilaPorCodigo(.fila_id)
                txtOutrasInformacoes.Text = d_fila.detalhesDaFila

                'Informações
                cbProduto.SelectedValue = .produto_id
                cbxContratoAssinado.Checked = .contrato_assinado
                cbxPagamento.Checked = .pgto_realizado
            End With

            'Carregamento histórico cliente
            historicoCliente()

            'Carregando finalizações independnete do tipo de entrada do registro
            If cbFila.SelectedValue > 0 Then
                finalizacoes.PreencheComboFinalizacao(Me, cbFinalizacao, cbFila.SelectedValue)
            End If


            'Bloqueando/Liberando grupos
            gbDados.Enabled = True
            gbConcluir.Enabled = True
            produtos.PreencheCombobox(Me, cbProduto)
            'contratos.PreencheCombobox(Me, cbContrato)

            If dto_back.cliente_id = 0 Then
                cbCliente.Enabled = True
                btnIniciar.Enabled = False
            Else
                gbIniciar.Enabled = False
            End If

        Else
            limpeza()
        End If

    End Sub

    Private Sub linkAdcProduto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAdcProduto.LinkClicked
        hlp.abrirForm(frmCadProdutos, False, False)
    End Sub

    Private Sub linkAdcContrato_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        hlp.abrirForm(frmCadContratos, False, False)
    End Sub

    Private Sub linkDetalhesProduto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDetalhesProduto.LinkClicked
        If cbProduto.Text <> "" Then
            exibirDetalhes("PRODUTOS", cbProduto.SelectedValue)
        End If
    End Sub

    Private Sub cbFila_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbFila.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbFinalizacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbFinalizacao.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbSubfinalizacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSubfinalizacao.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbCliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cbProduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbProduto.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbContrato_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim dto_back As New dto_backoffice

        'Limpeza simples, visto não haver registro capturado para trabalho
        If txtProtocolo.Text = "" Or txtProtocolo.Text = 0 Then
            limpeza()
            Exit Sub
        End If

        'Limpeza completa, envolvendo rollback (FILA AUTOMÁTICA) de caso ou delete de registro (FILA MANUAL)
        dto_back = carregarDto(False)
        If backOffice.liberarRegistro(dto_back) Then
            limpeza()
        End If

    End Sub

    Private Sub lvHistoricoCliente_ColumnClick(sender As Object, e As ColumnClickEventArgs)
        If Me.lvHistoricoCliente.Sorting = SortOrder.Ascending Then
            Me.lvHistoricoCliente.Sorting = SortOrder.Descending
        Else
            Me.lvHistoricoCliente.Sorting = SortOrder.Ascending
        End If
        Me.lvHistoricoCliente.ListViewItemSorter = New mdlOrdenacaoListView(e.Column, Me.lvHistoricoCliente.Sorting)
    End Sub

    Private Sub linkAtualizarHistoricoCliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Try
            If cbCliente.SelectedValue > 0 Then
                If Not backOffice.carregarListViewHistoricoCliente(lvHistoricoCliente, cbCliente.SelectedValue) Then
                    lvHistoricoCliente.Clear()
                End If
            Else
                MsgBox("Não foi selecionado nenhum cliente para que o Histórico seja carregado.", vbInformation + vbOKOnly, TITULO_ALERTA)
                lvHistoricoCliente.Clear()
            End If
        Catch ex As Exception
            lvHistoricoCliente.Clear()
        End Try
    End Sub

    Private Sub linkAtualizarProduto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAtualizarProduto.LinkClicked
        produtos.PreencheCombobox(Me, cbProduto)
    End Sub

    Private Sub linkAtualizarContrato_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub cbFila_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbFila.SelectionChangeCommitted

        'If rbAutomatica.Checked Then
        '    'Carregar combo de clientes apenas com os disponíveis para trabalho na fila e bloquear o link de adicionar/alterar tbm o de atualizar
        '    backOffice.capturarListaClientesDisponiveisPorFila(Me, cbCliente, cbFila.SelectedValue)
        'End If

        'If rbManual.Checked Then
        '    'Carregar combo de clientes com todos os clientes disponíveis na base de clientes e liberar o link de adicionar/alterar tbm o de atualizar
        '    clientes.PreencheCombobox(Me, cbCliente)
        'End If


        'Carregando com todos as filas disponíveis pq pode-se ter recuperação de registro e a lista deve estar completa
        'Enable = false para que o usuário não tenha acesso a lista completa de usuários e possa alterar o registro, causando uma fraude
        Dim id_fila As Integer = cbFila.SelectedValue
        filas.PreencheComboFila(Me, cbFila)
        cbFila.SelectedValue = id_fila
        cbFila.Enabled = False

    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        'Validar campos obrigatórios
        If Not hlp.validaCamposObrigatorios(gbDados, "cbProduto") Then
            Exit Sub
        End If

        If Not hlp.validaCamposObrigatorios(gbConcluir, "cbFinalizacao;cbSubfinalizacao") Then
            Exit Sub
        End If

        'Salvar
        Dim dto_back As New dto_backoffice
        dto_back = carregarDto()
        dto_back.status = 2 'Finalizar registro
        dto_back.data_cat = hlp.dataHoraAtual

        If backOffice.finalizarRegistro(dto_back) Then
            limpeza()
        End If

    End Sub

    Private Sub linkAtualizarCliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAtualizarCliente.LinkClicked
        clientes.PreencheCombobox(Me, cbCliente)
    End Sub

    Private Sub cbCliente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCliente.SelectionChangeCommitted
        historicoCliente()
    End Sub

    Private Sub linkDetalhesCliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDetalhesCliente.LinkClicked
        If cbCliente.Text <> "" Then
            exibirDetalhes("CLIENTES", cbCliente.SelectedValue)
        End If
    End Sub

    Private Sub linkAdcCliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAdcCliente.LinkClicked
        hlp.abrirForm(frmCadClientes, False, False)
    End Sub

    Private Sub cbFinalizacao_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbFinalizacao.SelectionChangeCommitted
        'Validando se foi selecionado um registro
        If cbFinalizacao.SelectedValue > 0 Then
            subFinalizacoes.PreencheComboSubFinalizacao(Me, cbSubfinalizacao, cbFinalizacao.SelectedValue)
        End If
    End Sub

    Private Sub frmBackOffice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not String.IsNullOrEmpty(txtProtocolo.Text) Then
            Dim dto_back As New dto_backoffice
            dto_back = carregarDto()
            backOffice.liberarRegistro(dto_back)
        End If
    End Sub

    Private Sub btnCancelarCaptura_Click(sender As Object, e As EventArgs) Handles btnCancelarCaptura.Click
        limpeza(True)
    End Sub

    Private Sub cbProduto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbProduto.SelectionChangeCommitted

    End Sub
End Class