Public Class frmCadFinalizacoes
    Private dto As New dto_finalizacoes
    Private bll As New bll_finalizacoes
    Private hlp As New Uteis.Helpers
    Private fbll As New bll_filas
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
    Private Sub frmCadFinalizacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueiaBotoes()
        hlp.limparCampos(Me)
        Me.cbAging.Text = ""
        bll.AtualizaListViewFinalizacao()
        fbll.PreencheComboFila(Me, cbFila)
        fbll.PreencheComboFilaAutomatica(Me, cbFilaDestino, False)
        fbll.PreencheComboFila(Me, cbFiltrofila)
        cbFila.SelectedIndex = -1
        cbFilaDestino.SelectedIndex = -1
        cbFiltrofila.SelectedIndex = -1
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim filtro_descricao As String = ""
        Dim filtro_area As String = ""
        Dim filtro_fila As String = ""
        filtro_descricao = IIf(IsDBNull(Me.txtFiltro.Text), vbEmpty, Me.txtFiltro.Text.Trim) 'captura o valor, se existir. 
        filtro_fila = IIf(IsDBNull(Me.cbFiltrofila.Text), vbEmpty, Me.cbFiltrofila.Text.Trim) 'captura o valor, se existir.
        bll.AtualizaListViewFinalizacao(filtro_descricao, filtro_fila)
    End Sub

    Private Sub btnRemoveFiltro_Click(sender As Object, e As EventArgs) Handles btnRemoveFiltro.Click
        bll.AtualizaListViewFinalizacao()
        cbFiltrofila.Text = ""
        txtFiltro.Text = ""
    End Sub

    Private Function carregarDTO(ByRef dto_fin As dto_finalizacoes, ByVal flagAcao As Integer) As Boolean
        Try
            With dto_fin

                'Geral
                .idFila = Me.cbFila.SelectedValue
                .descricao = Me.txtFinalizacao.Text
                .situacao = ckboxAtivo.Checked
                'Caracterização
                .cttoPassivelEfetividade = ckboxPassivelEfet.Checked
                .cttoEfetivo = ckboxEfetivo.Checked
                'Roteamento
                .geraNovoCaso = ckboxGerarNovoCaso.Checked
                .agingNovoCaso = IIf(String.IsNullOrEmpty(Me.cbAging.Text), 0, FlagRoteamentoRetornaDias(Me.cbAging.Text))
                .filaNovoCaso = cbFilaDestino.SelectedValue
                .Acao = flagAcao
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

    Private Sub cbFiltrofila_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbFiltrofila.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbFila_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbFila.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbAging_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbAging.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbFilaDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbFilaDestino.KeyPress
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
            dto = bll.GetFinalizacaoPorCodigo(id_registro)
            With dto
                'GERAL
                Me.ckboxAtivo.Checked = .situacao
                Me.txtID.Text = .ID
                Me.txtFinalizacao.Text = .descricao
                Me.cbFila.SelectedValue = .idFila

                'CARACTERISTICA DA FINALIZACAO
                Me.ckboxPassivelEfet.Checked = .cttoPassivelEfetividade
                Me.ckboxEfetivo.Checked = .cttoEfetivo

                'ROTEAMENTO
                Me.ckboxGerarNovoCaso.Checked = .geraNovoCaso
                Me.cbAging.Text = FlagRoteamentoRetornaExpressao(.agingNovoCaso)
                Me.cbFilaDestino.SelectedValue = .filaNovoCaso

            End With
            bll.AtualizaListViewFilasPorFinalizacao(dto.descricao)
        End If
        liberaBotoes()
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click


        Dim finalizacao As New dto_finalizacoes
        camposObrigatorios = "txtFinalizacao;cbFila"

        'validação para preencher o campo cbaging
        If Me.ckboxGerarNovoCaso.Checked Then
            If String.IsNullOrEmpty(cbAging.Text) Then
                MsgBox("Favor preencher o aging do novo caso", vbInformation, TITULO_ALERTA)
                cbAging.Focus()
                Exit Sub
            End If
        End If

        If hlp.validaCamposObrigatorios(Me, camposObrigatorios) Then

            'Carregar DTO
            If carregarDTO(finalizacao, FlagAcao.Insert) Then
                If bll.SalvaFinalizacao(finalizacao) Then
                    bll.AtualizaListViewFilasPorFinalizacao(finalizacao.descricao)
                    bll.AtualizaListViewFinalizacao()
                    MsgBox("Finalização salva com sucesso!", vbInformation, TITULO_ALERTA)
                    Logs.RegistrarLOG("Inclusão", "Finalização", hlp.getCurrentMethodName, Me.txtFinalizacao.Text)
                    hlp.limparCampos(Me)
                    bloqueiaBotoes()
                    Me.cbAging.Text = ""
                Else
                    MsgBox("Esta finalização " & finalizacao.descricao & " já esta cadastrado.", vbExclamation, TITULO_ALERTA)
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        camposObrigatorios = "txtFinalizacao;cbFila"
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
                dto = bll.GetFinalizacaoPorCodigo(Me.txtID.Text)
                If carregarDTO(dto, FlagAcao.Update) Then
                    With bll
                        If .SalvaFinalizacao(dto) Then
                            .AtualizaListViewFinalizacao()
                            bll.AtualizaListViewFilasPorFinalizacao(dto.descricao)
                            hlp.limparCampos(Me)
                            Me.cbAging.Text = ""
                            bloqueiaBotoes()
                            MsgBox("Registro alterado com sucesso.", vbInformation, TITULO_ALERTA)
                            Logs.RegistrarLOG("Alteração", "Finalização", hlp.getCurrentMethodName, Me.txtFinalizacao.Text)
                        Else
                            MsgBox("Esta finalização " & dto.descricao & " já esta cadastrado.", vbExclamation, TITULO_ALERTA)
                            Exit Sub
                        End If
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        MsgBox("A exclusão de finalização não é permitida!" & vbNewLine & vbNewLine &
                "Porém " & sessaoNomeUsuario & ", você pode desativar a finalização e assim não estará mais disponível para trabalho.", vbInformation, TITULO_ALERTA)

        'Dim valor As Integer = 0
        'valor = IIf(IsDBNull(Me.txtID.Text), vbEmpty, Me.txtID.Text) 'captura o valor do id, se existir.
        'If String.IsNullOrEmpty(valor) Or valor = 0 Then
        '    MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
        '    Exit Sub
        'Else
        '    If MsgBox("Tem certeza que deseja remover " & Me.txtFinalizacao.Text.Trim.ToUpper & " do sistema?", vbQuestion + vbYesNo, TITULO_ALERTA) = vbYes Then
        '        With bll
        '            If .DeletaFinalizacao(Me.txtID.Text) Then
        '                .AtualizaListViewFinalizacao()
        '                bll.AtualizaListViewFilasPorFinalizacao(Me.txtFinalizacao.Text, Me.cbArea.SelectedValue)
        '                MsgBox("Registro exluído com sucesso.", vbInformation, TITULO_ALERTA)
        '                Logs.registrarLOG("Exclusão", "Finalização", hlp.getCurrentMethodName, Me.txtFinalizacao.Text)
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
        Me.cbAging.Text = ""
        listviewFilasPorFinalizacao.Clear()
        bloqueiaBotoes()
    End Sub
End Class