Public Class frmBackOffice

#Region "VARIAVEIS"
    Private hlp As New Uteis.Helpers
    Private backOffice As New bll_backoffice
    Private filas As New bll_filas
    Private clientes As New bll_clientes
    Private produtos As New bll_produtos
    Private contratos As New bll_contratos
#End Region

    Private Sub limpeza(Optional ByVal parcial = False)
        hlp.limparCampos(gbInformacoesRelevantes)
        hlp.limparCampos(gbDados)
        hlp.limparCampos(gbConcluir)
        If Not parcial Then
            hlp.limparCampos(gbIniciar)
        End If
        gbDados.Enabled = False
        gbConcluir.Enabled = False
        gbIniciar.Enabled = True
    End Sub

    Private Sub exibirDetalhes(ByVal titulo As String, ByVal id_busca As Integer)
        frmDetalhes.titulo = titulo
        frmDetalhes.id_busca = id_busca
        hlp.abrirForm(frmDetalhes)
    End Sub

    Private Sub frmBackOffice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpeza()
    End Sub

    Private Sub rbAutomatica_CheckedChanged(sender As Object, e As EventArgs) Handles rbAutomatica.CheckedChanged
        If rbAutomatica.Checked Then
            filas.PreencheComboFilaAutomatica(Me, cbFila, True)
            limpeza(True)
        End If
    End Sub

    Private Sub rbManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbManual.CheckedChanged
        If rbManual.Checked Then
            filas.PreencheComboFilaManual(Me, cbFila)
            limpeza(True)
        End If
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        gbDados.Enabled = True
        gbConcluir.Enabled = True
        clientes.PreencheCombobox(Me, cbCliente)
        produtos.PreencheCombobox(Me, cbProduto)
        'contratos.PreencheCombobox(Me, cbContrato)


        'Validações de campos obrigatórios
        If Not rbAutomatica.Checked And Not rbManual.Checked Then
            MsgBox("Não foi selecionado o tipo de entrada! Selecione AUTOMÁTCO ou MANUAL.", vbInformation + vbOKOnly, TITULO_ALERTA)
            Exit Sub
        End If

        If Not hlp.validaCamposObrigatorios(gbIniciar, "cbFila") Then
            Exit Sub
        End If

        'Bloqueando grupo iniciar para evitar alterações durante o trabalho 
        gbIniciar.Enabled = False

        Dim dto_back As New dto_backoffice
        With dto_back
            'Capturando dados básicos para criar ou buscar um registro para trabalho
            .id = IIf(txtProtocolo.Text = "", 0, txtProtocolo.Text)
            .fila_id = IIf(cbFila.Text <> "", cbFila.SelectedValue, 0)
            .tipo_registro = IIf(rbAutomatica.Checked, "A", "M")
        End With

        'Carregando dados, se a captura ocorreu corretamente
        If backOffice.capturarRegistro(dto_back) Then
            With dto_back

                'Iniciar
                cbFila.SelectedValue = .fila_id
                If .tipo_registro = "A" Then
                    rbAutomatica.Checked = True
                Else
                    rbManual.Checked = True
                End If

                'Informações Relevantes
                txtProtocolo.Text = .id
                txtDataRegistro.Text = hlp.retornaDataTextBox(.data_imp)
                txtUsuarioResponsavel.Text = .usuario_imp_desc
                Dim d_fila As New dto_filas
                d_fila = filas.GetFilaPorCodigo(.fila_id)
                txtOutrasInformacoes.Text = d_fila.detalhesDaFila

                'Informações
                cbCliente.SelectedValue = .cliente_id
                cbProduto.SelectedValue = .produto_id
                cbContrato.SelectedValue = .contrato_id
                cbxContratoAssinado.Checked = .contrato_assinado
                cbxPagamento.Checked = .pgto_realizado
            End With

        Else
            limpeza()
        End If

    End Sub

    Private Sub linkAdcCliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAdcCliente.LinkClicked
        hlp.abrirForm(frmCadClientes, False, False)
    End Sub

    Private Sub linkAdcProduto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAdcProduto.LinkClicked
        hlp.abrirForm(frmCadProdutos, False, False)
    End Sub

    Private Sub linkAdcContrato_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAdcContrato.LinkClicked
        hlp.abrirForm(frmCadContratos, False, False)
    End Sub

    Private Sub linkDetalhesCliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDetalhesCliente.LinkClicked
        If cbCliente.Text <> "" Then
            exibirDetalhes("CLIENTES", cbCliente.SelectedValue)
        End If
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

    Private Sub cbCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCliente.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbProduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbProduto.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbContrato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbContrato.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Limpeza simples, visto não haver registro capturado para trabalho
        If txtProtocolo.Text <> "" Or txtProtocolo.Text <> 0 Then
            limpeza()
            Exit Sub
        End If

        'Limpeza completa, envolvendo rollback (FILA AUTOMÁTICA) de caso ou delete de registro (FILA MANUAL)


    End Sub
End Class