Public Class frmCadFilas
    Private dto As New dto_filas
    Private bll As New bll_filas
    Private hlp As New Uteis.Helpers
    Private filtro As String = ""
    Private camposObrigatorios As String = "txtFila;txtSigla;txtGrupo"
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
    Private Sub frmCadFilas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueiaBotoes()
        hlp.limparCampos(Me)
        bll.AtualizaListViewFilas()
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        If hlp.validaCamposObrigatorios(Me, camposObrigatorios) Then
            With dto
                .descricao = Me.txtFila.Text.Trim
                .sigla = hlp.desacentua(Me.txtSigla.Text.Trim)
                .ativo = Me.ckboxAtivo.Checked
                .capturaAutomatica = Me.ckboxAutomatico.Checked
                .grupo = Me.txtGrupo.Text
                .permitirAberturaManual = Me.ckboxCategorizador.Checked
                .acao = FlagAcao.Insert
            End With
            With bll
                If .SalvaFila(dto) Then
                    .AtualizaListViewFilas()
                    MsgBox("A Fila: " & Me.txtFila.Text.ToUpper & " foi cadastrada com sucesso!", MsgBoxStyle.Information, TITULO_ALERTA)
                    Logs.RegistrarLOG("Inclusão", "Fila", hlp.getCurrentMethodName, Me.txtFila.Text.Trim)
                Else
                    MsgBox("A Fila: " & Me.txtFila.Text.ToUpper & " já esta cadastrada!", MsgBoxStyle.Exclamation, TITULO_ALERTA)
                    Exit Sub
                End If
            End With
            hlp.limparCampos(Me)
            bloqueiaBotoes()
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If String.IsNullOrEmpty(Me.txtID.Text) Or Me.txtID.Text = 0 Then
            MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
            Exit Sub
        Else
            If hlp.validaCamposObrigatorios(Me, camposObrigatorios) Then
                dto = bll.GetFilaPorCodigo(Me.txtID.Text)

                With dto
                    .descricao = Me.txtFila.Text.Trim
                    .sigla = hlp.desacentua(Me.txtSigla.Text.Trim)
                    .ativo = Me.ckboxAtivo.Checked
                    .capturaAutomatica = Me.ckboxAutomatico.Checked
                    .grupo = Me.txtGrupo.Text
                    .permitirAberturaManual = Me.ckboxCategorizador.Checked
                    .acao = FlagAcao.Update
                End With
                With bll
                    If .SalvaFila(dto) Then
                        .AtualizaListViewFilas()
                        hlp.limparCampos(Me)
                        bloqueiaBotoes()
                        MsgBox("Registro alterado com sucesso.", vbInformation, TITULO_ALERTA)
                        Logs.RegistrarLOG("Alteração", "Fila", hlp.getCurrentMethodName, Me.txtFila.Text.Trim)
                    Else
                        MsgBox("A Fila: " & Me.txtFila.Text.ToUpper & " já esta cadastrada!", MsgBoxStyle.Exclamation, TITULO_ALERTA)
                        Exit Sub
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        MsgBox("A exclusão de fila não é permitida!" & vbNewLine & vbNewLine &
                "Porém " & sessaoNomeUsuario & ", você pode desativar a fila e assim não estará mais disponível para trabalho.", vbInformation, TITULO_ALERTA)

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
        bll.AtualizaListViewFilas(filtro)
    End Sub

    Private Sub btnRemoveFiltro_Click(sender As Object, e As EventArgs) Handles btnRemoveFiltro.Click
        Dim filtro As String = ""
        bll.AtualizaListViewFilas(filtro)
        Me.txtFiltro.Text = ""
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim id_registro As Integer
        id_registro = Me.ListView1.SelectedItems(0).SubItems(0).Text 'captura informações da primeira coluna selecionada
        If String.IsNullOrEmpty(id_registro) Or id_registro = 0 Then
            MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
            Exit Sub
        Else
            dto = bll.GetFilaPorCodigo(id_registro)
            With dto
                Me.txtID.Text = .id
                Me.txtFila.Text = .descricao
                Me.txtSigla.Text = .sigla
                Me.txtGrupo.Text = .grupo
                Me.ckboxAutomatico.Checked = .capturaAutomatica
                Me.ckboxCategorizador.Checked = .permitirAberturaManual
                Me.ckboxAtivo.Checked = .ativo
            End With
        End If
        liberaBotoes()
    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        If Me.ListView1.Sorting = SortOrder.Ascending Then
            Me.ListView1.Sorting = SortOrder.Descending
        Else
            Me.ListView1.Sorting = SortOrder.Ascending
        End If
        Me.ListView1.ListViewItemSorter = New mdlOrdenacaoListView(e.Column, Me.ListView1.Sorting)
    End Sub
End Class