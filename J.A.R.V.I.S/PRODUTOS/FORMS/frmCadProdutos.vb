Public Class frmCadProdutos
    Private dto As New dto_produtos
    Private bll As New bll_produtos
    Private hlp As New Uteis.Helpers
    Private filtro As String = ""
    Private camposObrigatorios As String = "txtProduto;txtSigla;txtValor"
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

    Private Sub frmCadProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueiaBotoes()
        hlp.limparCampos(Me)
        bll.AtualizaListViewRegistros()
    End Sub

    Private Function salvarRegistro(ByVal tipoManutencao As Integer) As Boolean


        If hlp.validaCamposObrigatorios(Me, camposObrigatorios) Then
            If tipoManutencao = 2 Then
                dto = bll.GetRegistroPorID(Me.txtID.Text)
            End If

            With dto
                .produto = Me.txtProduto.Text.Trim
                .sigla = hlp.desacentua(Me.txtSigla.Text.Trim)
                .descricao = Me.txtDescricao.Text.Trim
                .valor = hlp.transformarMoeda(Me.txtValor.Text.Trim)
                .ativo = Me.ckboxAtivo.Checked

                If album_rbSim.Checked Then
                    If hlp.validaCamposObrigatorios(gbAlbum, "album_txtTamanho;album_txtTipo;album_txtFolhas") Then
                        .album = True
                        .albumQtdeFolhas = hlp.retornaSoNumeroDeString(Me.album_txtFolhas.Text)
                        .albumTamanho = album_txtTamanho.Text.Trim
                        .albumTipo = album_txtTipo.Text.Trim
                    Else
                        Return False
                    End If
                Else
                    .album = False
                    .albumQtdeFolhas = 0
                    .albumTamanho = ""
                    .albumTipo = ""
                End If

                If caixa_rbSim.Checked Then
                    If hlp.validaCamposObrigatorios(gbCaixa, "caixa_txtTipo;caixa_txtTamanho;caixa_txtQtde") Then
                        .caixa = True
                        .caixaQtde = hlp.retornaSoNumeroDeString(Me.caixa_txtQtde.Text)
                        .caixaTamanho = caixa_txtTamanho.Text.Trim
                        .caixaTipo = caixa_txtTipo.Text.Trim
                    Else
                        Return False
                    End If
                Else
                    .caixa = False
                    .caixaQtde = 0
                    .caixaTamanho = ""
                    .caixaTipo = ""
                End If

                If painel_rbSim.Checked Then
                    If hlp.validaCamposObrigatorios(gbPainel, "painel_txtQtde;painel_txtTamanho;painel_txtMoldura") Then
                        .painel = True
                        .painelQtde = hlp.retornaSoNumeroDeString(Me.painel_txtQtde.Text)
                        .painelTamanho = painel_txtTamanho.Text.Trim
                        .painelMoldura = painel_txtMoldura.Text.Trim
                    Else
                        Return False
                    End If
                Else
                    .painel = False
                    .painelQtde = 0
                    .painelTamanho = ""
                    .painelMoldura = ""
                End If

                If ensaios_rbSim.Checked Then
                    If hlp.validaCamposObrigatorios(gbEnsaios, "ensaios_txtQtdade;ensaios_txtMeses;ensaios_cbPeriodo") Then
                        .ensaios = True
                        .ensaiosQtde = hlp.retornaSoNumeroDeString(Me.ensaios_txtQtdade.Text)
                        .ensaiosMeses = ensaios_txtMeses.Text.Trim
                        .ensaiosPeriodo = ensaios_cbPeriodo.Text.Trim
                    Else
                        Return False
                    End If
                Else
                    .ensaios = False
                    .ensaiosQtde = 0
                    .ensaiosMeses = ""
                    .ensaiosPeriodo = ""
                End If

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
                    MsgBox("A manutenção no registro: " & Me.txtProduto.Text.ToUpper & " não pode ser realizada!", MsgBoxStyle.Exclamation, TITULO_ALERTA)
                    salvarRegistro = False
                End If
            End With
        End If

        hlp.limparCampos(Me)
        bloqueiaBotoes()
        Return salvarRegistro

    End Function

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

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

        Dim id_registro As Integer
        Try
            id_registro = Me.ListView1.SelectedItems(0).SubItems(0).Text 'captura informações da primeira coluna selecionada
            If String.IsNullOrEmpty(id_registro) Or id_registro = 0 Then
                MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
                Exit Sub
            Else
                dto = bll.GetRegistroPorID(id_registro)
                With dto
                    Me.txtID.Text = .id
                    Me.ckboxAtivo.Checked = .ativo
                    Me.txtProduto.Text = .produto
                    Me.txtSigla.Text = .sigla
                    Me.txtValor.Text = hlp.transformarMoeda(.valor)

                    If .album Then
                        album_rbSim.Checked = True
                        Me.album_txtFolhas.Text = .albumQtdeFolhas
                        Me.album_txtTamanho.Text = .albumTamanho
                        Me.album_txtTipo.Text = .albumTipo
                    Else
                        album_rbNao.Checked = True
                    End If


                    If .painel Then
                        painel_rbSim.Checked = True
                        Me.painel_txtMoldura.Text = .painelMoldura
                        Me.painel_txtQtde.Text = .painelQtde
                        Me.painel_txtTamanho.Text = .painelTamanho
                    Else
                        painel_rbNao.Checked = True
                    End If


                    If .ensaios Then
                        ensaios_rbSim.Checked = True
                        Me.ensaios_txtMeses.Text = .ensaiosMeses
                        Me.ensaios_txtQtdade.Text = .ensaiosQtde
                        Me.ensaios_cbPeriodo.Text = .ensaiosPeriodo
                    Else
                        ensaios_rbNao.Checked = True
                    End If


                    If .caixa Then
                        caixa_rbSim.Checked = True
                        Me.caixa_txtQtde.Text = .caixaQtde
                        Me.caixa_txtTamanho.Text = .caixaTamanho
                        Me.caixa_txtTipo.Text = .caixaTipo
                    Else
                        caixa_rbNao.Checked = True
                    End If


                    Me.txtDescricao.Text = .descricao

                End With
            End If
            liberaBotoes()
        Catch ex As Exception
            MsgBox("Ocorreu um erro e não foi possível carregar o produto selecionado!", vbCritical + vbOKOnly, TITULO_ALERTA)
        End Try

    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        If Me.ListView1.Sorting = SortOrder.Ascending Then
            Me.ListView1.Sorting = SortOrder.Descending
        Else
            Me.ListView1.Sorting = SortOrder.Ascending
        End If
        Me.ListView1.ListViewItemSorter = New mdlOrdenacaoListView(e.Column, Me.ListView1.Sorting)
    End Sub

    Private Sub album_rbSim_CheckedChanged(sender As Object, e As EventArgs) Handles album_rbSim.CheckedChanged
        album_txtFolhas.Enabled = True
        album_txtTamanho.Enabled = True
        album_txtTipo.Enabled = True
    End Sub

    Private Sub album_rbNao_CheckedChanged(sender As Object, e As EventArgs) Handles album_rbNao.CheckedChanged
        album_txtFolhas.Enabled = False
        album_txtTamanho.Enabled = False
        album_txtTipo.Enabled = False
    End Sub

    Private Sub painel_rbSim_CheckedChanged(sender As Object, e As EventArgs) Handles painel_rbSim.CheckedChanged
        painel_txtQtde.Enabled = True
        painel_txtMoldura.Enabled = True
        painel_txtTamanho.Enabled = True
    End Sub

    Private Sub painel_rbNao_CheckedChanged(sender As Object, e As EventArgs) Handles painel_rbNao.CheckedChanged
        painel_txtQtde.Enabled = False
        painel_txtMoldura.Enabled = False
        painel_txtTamanho.Enabled = False
    End Sub

    Private Sub ensaios_rbSim_CheckedChanged(sender As Object, e As EventArgs) Handles ensaios_rbSim.CheckedChanged
        ensaios_txtMeses.Enabled = True
        ensaios_txtQtdade.Enabled = True
        ensaios_cbPeriodo.Enabled = True
    End Sub

    Private Sub ensaios_rbNao_CheckedChanged(sender As Object, e As EventArgs) Handles ensaios_rbNao.CheckedChanged
        ensaios_txtMeses.Enabled = False
        ensaios_txtQtdade.Enabled = False
        ensaios_cbPeriodo.Enabled = False
    End Sub

    Private Sub caixa_rbSim_CheckedChanged(sender As Object, e As EventArgs) Handles caixa_rbSim.CheckedChanged
        caixa_txtQtde.Enabled = True
        caixa_txtTamanho.Enabled = True
        caixa_txtTipo.Enabled = True
    End Sub

    Private Sub caixa_rbNao_CheckedChanged(sender As Object, e As EventArgs) Handles caixa_rbNao.CheckedChanged
        caixa_txtQtde.Enabled = False
        caixa_txtTamanho.Enabled = False
        caixa_txtTipo.Enabled = False
    End Sub

    Private Sub ensaios_cbPeriodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ensaios_cbPeriodo.KeyPress
        e.Handled = True
    End Sub
End Class