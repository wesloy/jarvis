Public Class frmCadClientes

    Private dto As New dto_clientes
    Private bll As New bll_clientes
    Private hlp As New Uteis.Helpers
    Private filtro As String = ""
    Private camposObrigatorios As String = ""
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
        cbxGestante.Text = ""
        cbxSexo.Text = ""
        hlp.limparCampos(Me)
        hlp.limparCampos(gbFilhos)
    End Sub

    Private Function salvarRegistro(ByVal tipoManutencao As Integer) As Boolean
        camposObrigatorios = "txtCliente;txtCpf"
        If hlp.validaCamposObrigatorios(Me, camposObrigatorios) Then
            If tipoManutencao = 2 Then
                dto = bll.GetRegistroPorID(Me.txtID.Text)
            End If

            With dto
                .cliente = Me.txtCliente.Text.Trim
                .companheiro = Me.txtCompanheiro.Text.Trim
                .telefone = Me.txtTelefone.Text.Trim
                .celular = Me.txtCelular.Text.Trim
                .email = Me.txtEmail.Text.Trim
                .instagram = Me.txtInstagram.Text.Trim
                .facebook = Me.txtFacebook.Text.Trim
                .dataNascimento = Me.dtpDataNascimento.Text.Trim
                .gestante = IIf(Me.cbxGestante.Text.Trim = "SIM", True, False)
                .semanasGestacao = Me.txtSemanasGestacao.Text.Trim
                .previsaoNascimento = Me.dtpPreviscaoNascimento.Value
                .qtdeFilhos = Me.txtQtdeFilhos.Text.Trim
                .cpf = Me.txtCpf.Text.Trim
                .observacao = Me.txtObservacao.Text.Trim
                .ativo = Me.ckboxAtivo.Checked
                .acao = tipoManutencao
            End With
            With bll
                If .SalvarRegistro(dto) Then
                    .AtualizaListViewRegistros()
                    bloqueiaBotoes()
                    MsgBox("Manutenção realizada com sucesso!", vbInformation, TITULO_ALERTA)
                    salvarRegistro = True
                Else
                    MsgBox("A manutenção no registro: " & Me.txtCliente.Text.ToUpper & " não pode ser realizada!", MsgBoxStyle.Exclamation, TITULO_ALERTA)
                    salvarRegistro = False
                End If
            End With
        End If

        bloqueiaBotoes()
        Return salvarRegistro

    End Function

    Private Sub frmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueiaBotoes()
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
                Me.txtCliente.Text = .cliente
                Me.txtCompanheiro.Text = .companheiro
                Me.txtTelefone.Text = .telefone
                Me.txtCelular.Text = .celular
                Me.txtEmail.Text = .email
                Me.txtInstagram.Text = .instagram
                Me.txtFacebook.Text = .facebook
                Me.dtpDataNascimento.Text = .dataNascimento
                Me.cbxGestante.Text = IIf(.gestante, "SIM", "NÃO")
                Me.txtSemanasGestacao.Text = .semanasGestacao
                Me.dtpPreviscaoNascimento.Text = .previsaoNascimento
                Me.txtQtdeFilhos.Text = .qtdeFilhos
                Me.txtCpf.Text = .cpf
                Me.txtObservacao.Text = .observacao
                Me.ckboxAtivo.Checked = .ativo

                'carregando listview de filhos
                bll.AtualizaListViewRegistrosFilhos(.id)
            End With
        End If

        liberaBotoes()
    End Sub

    Private Function salvarRegistroFilhos(ByVal tipoManutencao As Integer) As Boolean
        camposObrigatorios = "txtNomeFIlho;dtpNascimentoFIlho;cbxSexo"
        If hlp.validaCamposObrigatorios(gbFilhos, camposObrigatorios) Then
            If tipoManutencao = 2 Then
                dto = bll.GetRegistroPorIDFilho(Me.txtIdFilhos.Text)
            End If

            With dto
                .id_tblClientes = Me.txtID.Text.Trim
                .nomeFilho = Me.txtNomeFIlho.Text.Trim
                .dataNascimento_filho = Me.dtpNascimentoFIlho.Value
                .sexo = cbxSexo.Text.Trim
                .acao = tipoManutencao
            End With
            With bll
                If .SalvarRegistroFilho(dto) Then
                    hlp.limparCampos(gbFilhos)
                    cbxSexo.Text = ""
                    btnAlterarFilho.Enabled = False
                    btnExcluirFilho.Enabled = False
                    btnIncluirFilho.Enabled = True
                    bll.AtualizaListViewRegistrosFilhos(Int(txtID.Text))
                    MsgBox("Manutenção realizada com sucesso!", vbInformation, TITULO_ALERTA)
                    salvarRegistroFilhos = True
                Else
                    MsgBox("A manutenção no registro: " & Me.txtNomeFIlho.Text.ToUpper & " não pode ser realizada!", MsgBoxStyle.Exclamation, TITULO_ALERTA)
                    salvarRegistroFilhos = False
                End If
            End With
        End If

        Return salvarRegistroFilhos

    End Function

    Private Sub btnIncluirFilho_Click(sender As Object, e As EventArgs) Handles btnIncluirFilho.Click
        salvarRegistroFilhos(FlagAcao.Insert)
    End Sub

    Private Sub btnAlterarFilho_Click(sender As Object, e As EventArgs) Handles btnAlterarFilho.Click
        If String.IsNullOrEmpty(Me.txtIdFilhos.Text) Or Me.txtIdFilhos.Text = 0 Then
            MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
            Exit Sub
        Else
            salvarRegistroFilhos(FlagAcao.Update)
        End If
    End Sub

    Private Sub btnExcluirFilho_Click(sender As Object, e As EventArgs) Handles btnExcluirFilho.Click

        If MsgBox("Tem certeza que deseja remover " & Me.txtNomeFIlho.Text.Trim.ToUpper & " do sistema?", vbQuestion + vbYesNo, TITULO_ALERTA) = vbYes Then
            With bll
                If .DeletarRegistroFilho(Me.txtIdFilhos.Text) Then
                    hlp.limparCampos(gbFilhos)
                    cbxSexo.Text = ""
                    .AtualizaListViewRegistrosFilhos(Int(txtID.Text))
                    MsgBox("Registro exluído com sucesso.", vbInformation, TITULO_ALERTA)
                    btnAlterarFilho.Enabled = False
                    btnExcluirFilho.Enabled = False
                    btnIncluirFilho.Enabled = True
                Else
                    MsgBox("Registro não pode ser excluído. Tente mais tarde ou contate o desenvolvedor do sistema.", vbInformation, TITULO_ALERTA)
                End If
            End With
        End If
    End Sub

    Private Sub ListView2_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView2.ColumnClick
        If Me.ListView2.Sorting = SortOrder.Ascending Then
            Me.ListView2.Sorting = SortOrder.Descending
        Else
            Me.ListView2.Sorting = SortOrder.Ascending
        End If
        Me.ListView2.ListViewItemSorter = New mdlOrdenacaoListView(e.Column, Me.ListView1.Sorting)
    End Sub

    Private Sub ListView2_DoubleClick(sender As Object, e As EventArgs) Handles ListView2.DoubleClick
        Dim id_registro As Integer
        id_registro = Me.ListView2.SelectedItems(0).SubItems(0).Text 'captura informações da primeira coluna selecionada
        If String.IsNullOrEmpty(id_registro) Or id_registro = 0 Then
            MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
            Exit Sub
        Else
            dto = bll.GetRegistroPorIDFilho(id_registro)
            With dto
                Me.txtIdFilhos.Text = .id_filhos
                Me.txtNomeFIlho.Text = .nomeFilho
                Me.cbxSexo.Text = .sexo
                Me.dtpNascimentoFIlho.Text = .dataNascimento_filho
            End With
        End If

        btnAlterarFilho.Enabled = True
        btnExcluirFilho.Enabled = True
        btnIncluirFilho.Enabled = False

    End Sub

    Private Sub cbxSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSexo.KeyPress
        e.Handled = True
    End Sub
End Class