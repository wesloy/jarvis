Public Class frmCadCentroCusto
    Private dto As New dto_centroCusto
    Private bll As New bll_centroCusto
    Private hlp As New Uteis.Helpers
    Private filtro As String = ""
    Private camposObrigatorios As String = "txtCentroCusto"
    Private Logs As New Bll_log
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
    Private Function salvarRegistro(ByVal tipoManutencao As Integer) As Boolean


        If hlp.validaCamposObrigatorios(Me, camposObrigatorios) Then
            If tipoManutencao = 2 Then
                dto = bll.GetRegistroPorID(Me.txtID.Text)
            End If

            With dto
                .centroCusto = Me.txtCentroCusto.Text.Trim
                .observacao = Me.txtObservacao.Text.Trim
                .ativo = Me.ckboxAtivo.Checked
                .acao = tipoManutencao
            End With
            With bll
                If .SalvarRegistro(dto) Then
                    .AtualizaListViewRegistros()
                    hlp.limparCampos(Me)
                    bloqueiaBotoes()
                    MsgBox("Manutenção realizada com sucesso!", vbInformation, TITULO_ALERTA)
                    salvarRegistro = True
                Else
                    MsgBox("A manutenção no registro: " & Me.txtCentroCusto.Text.ToUpper & " não pode ser realizada!", MsgBoxStyle.Exclamation, TITULO_ALERTA)
                    salvarRegistro = False
                End If
            End With
        End If

        hlp.limparCampos(Me)
        bloqueiaBotoes()
        Return salvarRegistro

    End Function

    Private Sub frmCentroCusto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueiaBotoes()
        hlp.limparCampos(Me)
        bll.AtualizaListViewRegistros()
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        salvarRegistro(FlagAcao.Insert)
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If String.IsNullOrEmpty(Me.txtID.Text) Or Me.txtID.Text = 0 Then
            MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
            Exit Sub
        Else
            salvarRegistro(FlagAcao.Update)
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        MsgBox("A exclusão de um registro não é permitida!" & vbNewLine & vbNewLine &
                "Porém " & sessaoNomeUsuario & ", você pode desativar o registro e assim não estará mais disponível para trabalho.", vbInformation, TITULO_ALERTA)

        'Dim valor As Integer = 0
        'valor = IIf(IsDBNull(Me.txtID.Text), vbEmpty, Me.txtID.Text) 'captura o valor do id, se existir.
        'If String.IsNullOrEmpty(valor) Or valor = 0 Then
        '    MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
        '    Exit Sub
        'Else
        '    If MsgBox("Tem certeza que deseja remover " & Me.txtSigla.Text.Trim.ToUpper & " do sistema?", vbQuestion + vbYesNo, TITULO_ALERTA) = vbYes Then
        '        With bll
        '            If .DeletaFila(Me.txtID.Text) Then
        '                .AtualizaListViewFilas()
        '                MsgBox("Registro exluído com sucesso.", vbInformation, TITULO_ALERTA)
        '                Logs.registrarLOG("Exclusão", "Fila", hlp.getCurrentMethodName, Me.txtFila.Text.Trim)
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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim filtro As String = ""
        filtro = IIf(IsDBNull(Me.txtFiltro.Text), vbEmpty, Me.txtFiltro.Text.Trim) 'captura o valor, se existir.        
        bll.AtualizaListViewRegistros(filtro)
    End Sub

    Private Sub btnRemoveFiltro_Click(sender As Object, e As EventArgs) Handles btnRemoveFiltro.Click
        Dim filtro As String = ""
        bll.AtualizaListViewRegistros(filtro)
        Me.txtFiltro.Text = ""
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
            dto = bll.GetRegistroPorID(id_registro)
            With dto
                Me.txtID.Text = .id
                Me.txtCentroCusto.Text = .centroCusto
                Me.txtObservacao.Text = .observacao
                Me.ckboxAtivo.Checked = .ativo
            End With
        End If
        liberaBotoes()
    End Sub
End Class