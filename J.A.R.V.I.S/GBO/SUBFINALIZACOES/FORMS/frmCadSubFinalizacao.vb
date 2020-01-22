Public Class frmCadSubFinalizacao
    Private dto As New dto_subfinalizacoes
    Private bll As New bll_subfinalizacoes
    Private hlp As New Uteis.Helpers
    Private fbll As New bll_finalizacoes
    Private filabll As New bll_filas
    Private Logs As New Bll_log
    Private filtro As String = ""
    Private camposObrigatorios As String = ""
    Private nomeDosCampos As String = ""
    Private Sub liberaBotoes()
        Me.btnAlterar.Enabled = True
        Me.btnExcluir.Enabled = True
        Me.btnIncluir.Enabled = False
        Me.btnCancelar.Enabled = True
    End Sub

    Private Sub bloqueiaBotoes()
        Me.btnIncluir.Enabled = True
        Me.btnAlterar.Enabled = False
        Me.btnExcluir.Enabled = False
    End Sub
    Private Sub frmCadSubFinalizacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueiaBotoes()
        hlp.limparCampos(Me)
        bll.AtualizaListViewSubFinalizacao()
        filabll.PreencheComboFila(Me, cbFila)
        filabll.PreencheComboFilaAutomatica(Me, cbFilaDestino)
        filabll.PreencheComboFila(Me, cbFiltrofila)
        hlp.limparCampos(Me)
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim filtro_descricao As String = ""
        Dim filtro_fila As String = ""
        filtro_descricao = IIf(IsDBNull(Me.txtFiltro.Text), vbEmpty, Me.txtFiltro.Text.Trim) 'captura o valor, se existir.      
        filtro_fila = IIf(IsDBNull(Me.cbFiltrofila.Text), vbEmpty, Me.cbFiltrofila.Text.Trim) 'captura o valor, se existir.      
        bll.AtualizaListViewSubFinalizacao(filtro_descricao, filtro_fila)
    End Sub

    Private Sub btnRemoveFiltro_Click(sender As Object, e As EventArgs) Handles btnRemoveFiltro.Click
        bll.AtualizaListViewSubFinalizacao()
        cbFiltrofila.Text = ""
        txtFiltro.Text = ""
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        camposObrigatorios = "txtSubFinalizacao;cbFila;cbFinalizacao"

        'validação para preencher o campo cbaging
        If ckboxGerarNovoCaso.Checked Then
            If String.IsNullOrEmpty(cbAging.Text) Then
                MsgBox("Favor preencher o aging do novo caso", vbInformation, TITULO_ALERTA)
                cbAging.Focus()
                Exit Sub
            End If
        End If

        If hlp.validaCamposObrigatorios(Me, camposObrigatorios, nomeDosCampos) Then
            With dto
                'Geral
                .descricao = Me.txtSubFinalizacao.Text.Trim
                .idFila = IIf(Me.cbFila.SelectedValue = 0, 1, Me.cbFila.SelectedValue)
                .IDFinalizacao = IIf(Me.cbFinalizacao.SelectedValue = 0, 1, Me.cbFinalizacao.SelectedValue)
                .situacao = Me.ckboxAtivo.Checked
                'Caracterização
                .cttoPassivelEfetividade = Me.ckboxPassivelEfet.Checked
                .cttoEfetivo = Me.ckboxEfetivo.Checked
                'Roteamento
                .geraNovoCaso = Me.ckboxGerarNovoCaso.Checked
                .agingNovoCaso = IIf(String.IsNullOrEmpty(Me.cbAging.Text), 0, Me.cbAging.Text)
                .filaNovoCaso = Me.cbFilaDestino.SelectedValue
                .Acao = FlagAcao.Insert
            End With
            With bll
                If .SalvaSubFinalizacao(dto) Then
                    MsgBox("Registro incluído com sucesso!", vbInformation, TITULO_ALERTA)
                    Logs.registrarLOG("Inclusão", "SubFinalização", hlp.getCurrentMethodName, Me.txtSubFinalizacao.Text.Trim)
                    .AtualizaListViewSubFinalizacao()
                Else
                    MsgBox("A Subfinalização: " & Me.txtSubFinalizacao.Text.ToUpper & " já esta cadastrada!", MsgBoxStyle.Exclamation, TITULO_ALERTA)
                    Exit Sub
                End If
            End With
            hlp.limparCampos(Me)
            bloqueiaBotoes()
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        camposObrigatorios = "txtSubFinalizacao;cbFila;cbFinalizacao"
        If String.IsNullOrEmpty(Me.txtID.Text) Or Me.txtID.Text = 0 Then
            MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
            Exit Sub
        Else

            'validação para preencher o campo cbaging
            If ckboxGerarNovoCaso.Checked Then
                If String.IsNullOrEmpty(cbAging.Text) Then
                    MsgBox("Favor preencher o aging do novo caso", vbInformation, TITULO_ALERTA)
                    cbAging.Focus()
                    Exit Sub
                End If
            End If
            If hlp.validaCamposObrigatorios(Me, camposObrigatorios, nomeDosCampos) Then
                dto = bll.GetSubFinalizacaoPorCodigo(Me.txtID.Text)
                With dto
                    'Geral
                    .descricao = Me.txtSubFinalizacao.Text.Trim
                    .idFila = IIf(Me.cbFila.SelectedValue = 0, 1, Me.cbFila.SelectedValue)
                    .idFinalizacao = IIf(Me.cbFinalizacao.SelectedValue = 0, 1, Me.cbFinalizacao.SelectedValue)
                    .situacao = Me.ckboxAtivo.Checked
                    'Caracterização
                    .cttoPassivelEfetividade = Me.ckboxPassivelEfet.Checked
                    .cttoEfetivo = Me.ckboxEfetivo.Checked
                    'Roteamento
                    .geraNovoCaso = Me.ckboxGerarNovoCaso.Checked
                    .agingNovoCaso = IIf(String.IsNullOrEmpty(Me.cbAging.Text), 0, Me.cbAging.Text)
                    .filaNovoCaso = Me.cbFilaDestino.SelectedValue
                    .Acao = FlagAcao.Update
                End With
                With bll
                    If .SalvaSubFinalizacao(dto) Then
                        MsgBox("Registro alterado com sucesso!", vbInformation, TITULO_ALERTA)
                        Logs.RegistrarLOG("Alteração", "SubFinalização", hlp.getCurrentMethodName, Me.txtSubFinalizacao.Text.Trim)
                        .AtualizaListViewSubFinalizacao()
                        hlp.limparCampos(Me)
                        Me.cbAging.Text = ""
                        bloqueiaBotoes()
                        MsgBox("Registro alterado com sucesso.", vbInformation, TITULO_ALERTA)
                    Else
                        MsgBox("A Subfinalização: " & Me.txtSubFinalizacao.Text.ToUpper & " já esta cadastrada!", MsgBoxStyle.Exclamation, TITULO_ALERTA)
                        Exit Sub
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        MsgBox("A exclusão de subFinalização não é permitida!" & vbNewLine & vbNewLine &
                "Porém " & sessaoNomeUsuario & ", você pode desativar a subFinalização e assim não estará mais disponível para trabalho.", vbInformation, TITULO_ALERTA)

        'Dim valor As Integer = 0
        'valor = IIf(IsDBNull(Me.txtID.Text), vbEmpty, Me.txtID.Text) 'captura o valor do id, se existir.
        'If String.IsNullOrEmpty(valor) Or valor = 0 Then
        '    MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
        '    Exit Sub
        'Else
        '    If MsgBox("Tem certeza que deseja remover " & Me.txtSubFinalizacao.Text.Trim.ToUpper & " do sistema?", vbQuestion + vbYesNo, TITULO_ALERTA) = vbYes Then
        '        With bll
        '            If .DeletaSubFinalizacao(Me.txtID.Text) Then
        '                .AtualizaListViewSubFinalizacao()
        '                MsgBox("Registro excluído com sucesso!", vbInformation, TITULO_ALERTA)
        '                Logs.registrarLOG("Exclusão", "SubFinalização", hlp.getCurrentMethodName, Me.txtSubFinalizacao.Text.Trim)
        '            Else
        '                MsgBox("Registro não pode ser excluído. Desative-o para não ser visualizado em relatórios ou procedimentos.", vbInformation, TITULO_ALERTA)
        '            End If

        '        End With
        '        hlp.LimparCampos(Me)
        '        bloqueiaBotoes()
        '    End If
        'End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        hlp.limparCampos(Me)
        bloqueiaBotoes()
    End Sub

    Private Sub cbFila_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbFila.SelectionChangeCommitted
        fbll.PreencheComboFinalizacao(Me, cbFinalizacao, cbFila.SelectedValue)
    End Sub

    Private Sub cbFila_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbFila.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbFinalizacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbFinalizacao.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbAging_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbAging.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbFilaDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbFilaDestino.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbFiltrofila_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbFiltrofila.KeyPress
        e.Handled = True
    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        If Me.ListView1.Sorting = SortOrder.Ascending Then
            Me.ListView1.Sorting = SortOrder.Descending
        Else
            Me.ListView1.Sorting = SortOrder.Ascending
        End If
        Me.ListView1.ListViewItemSorter = New mdlOrdenacaoListView(e.Column, Me.ListView1.Sorting)
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim id_registro As Integer
        id_registro = Me.ListView1.SelectedItems(0).SubItems(0).Text 'captura informações da primeira coluna selecionada
        If String.IsNullOrEmpty(id_registro) Or id_registro = 0 Then
            MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
            Exit Sub
        Else
            dto = bll.GetSubFinalizacaoPorCodigo(id_registro)
            With dto
                'GERAL
                Me.ckboxAtivo.Checked = .situacao
                Me.txtID.Text = .id
                Me.txtSubFinalizacao.Text = .descricao
                Me.cbFila.SelectedValue = .idFila
                Me.cbFinalizacao.SelectedValue = .idFinalizacao

                'CARACTERISTICA DA FINALIZACAO
                Me.ckboxPassivelEfet.Checked = .cttoPassivelEfetividade
                Me.ckboxEfetivo.Checked = .cttoEfetivo

                'ROTEAMENTO
                Me.ckboxGerarNovoCaso.Checked = .geraNovoCaso
                Me.cbAging.Text = FlagRoteamentoRetornaExpressao(.agingNovoCaso)
                Me.cbFilaDestino.SelectedValue = .filaNovoCaso

            End With
            bll.AtualizaListViewFilasPorSubFinalizacao(dto.descricao)
        End If
        liberaBotoes()
    End Sub
End Class