Public Class frmCadUsuarios
    Dim udto As New dto_usuarios
    Dim ubll As New bll_usuarios
    Dim mBll As New bll_menu
    Dim hlp As New Uteis.Helpers
    Dim Logs As New Bll_log

    Private filtro As String = ""
    Private camposObrigatorios As String = ""

    Private Sub liberaBotoes()
        Me.btnAlterar.Enabled = True
        Me.btnIncluir.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.lkResetarSenha.Enabled = True
    End Sub

    Private Sub bloqueiaBotoes()
        Me.btnIncluir.Enabled = True
        Me.btnAlterar.Enabled = False
        Me.lkResetarSenha.Enabled = False
    End Sub

    Private Sub frmCadUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueiaBotoes()
        hlp.limparCampos(Me)
        ubll.AtualizaListViewUsuarios()
        mBll.CarregaCombobox(Me, Me.cbPerfilAcesso)
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim filtro As String = ""
        filtro = IIf(IsDBNull(Me.txtFiltro.Text), vbEmpty, Me.txtFiltro.Text.Trim) 'captura o valor, se existir.        
        ubll.AtualizaListViewUsuarios(filtro)
    End Sub

    Private Sub btnRemoveFiltro_Click(sender As Object, e As EventArgs) Handles btnRemoveFiltro.Click
        Dim filtro As String = ""
        Me.txtFiltro.Text = ""
        ubll.AtualizaListViewUsuarios(filtro)
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim id_registro As Integer
        id_registro = Me.ListView1.SelectedItems(0).SubItems(0).Text 'captura informações da primeira coluna selecionada
        If String.IsNullOrEmpty(id_registro) Or id_registro = 0 Then
            MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
            Exit Sub
        Else
            udto = ubll.GetUsuariosPorCodigo(id_registro)
            With udto
                Me.txtID.Text = .id
                Me.txtNome.Text = .nome
                Me.cbPerfilAcesso.SelectedValue = .perfilAcesso
                Me.ckboxAtivo.Checked = .ativo
            End With
        End If
        liberaBotoes()
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        camposObrigatorios = "txtNome;cbPerfilAcesso"
        If hlp.validaCamposObrigatorios(Me, camposObrigatorios) Then
            With udto
                .nome = Me.txtNome.Text.Trim
                .ativo = Me.ckboxAtivo.Checked
                .perfilAcesso = Me.cbPerfilAcesso.SelectedValue
                .senha = hlp.Encrypt("123456")
                .Acao = FlagAcao.Insert
            End With
            With ubll
                If .SalvaUsuario(udto) Then
                    .AtualizaListViewUsuarios()
                    MsgBox("Registro incluído com sucesso!", vbInformation, TITULO_ALERTA)
                    Logs.registrarLOG("Inclusão", "Usuário", hlp.getCurrentMethodName, Me.txtNome.Text.Trim)
                Else
                    MsgBox("Este nome de usuário (" & Me.txtNome.Text.ToUpper & ") já está em usom tente outro por favor!", vbInformation, TITULO_ALERTA)
                    Exit Sub
                End If
            End With
            hlp.limparCampos(Me)
            bloqueiaBotoes()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        MsgBox("A exclusão de usuário não é permitida!" & vbNewLine & vbNewLine &
                "Porém " & sessaoNomeUsuario & ", você pode desativar o usuário e assim o mesmo não terá mais acesso ao J.A.R.V.I.S.", vbInformation, TITULO_ALERTA)

        'Dim valor As Integer = 0
        'valor = IIf(IsDBNull(Me.txtID.Text), vbEmpty, Me.txtID.Text) 'captura o valor do id, se existir.

        'Dim filtro As String = ""
        'filtro = IIf(IsDBNull(Me.txtFiltro.Text), vbEmpty, Me.txtFiltro.Text.Trim) 'captura o valor, se existir.        

        'If String.IsNullOrEmpty(valor) Or valor = 0 Then
        '    MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
        '    Exit Sub
        'Else
        '    If MsgBox("Tem certeza que deseja remover " & Me.txtNome.Text.Trim.ToUpper & " do sistema?", vbQuestion + vbYesNo, TITULO_ALERTA) = vbYes Then
        '        With ubll
        '            If .DeletaUsuario(Me.txtID.Text) Then
        '                .AtualizaListViewUsuarios(filtro)
        '                MsgBox("Registro excluído com sucesso!", vbInformation, TITULO_ALERTA)
        '                Logs.registrarLOG("Exclusão", "Usuário", hlp.getCurrentMethodName, Me.txtNome.Text.Trim)
        '            Else
        '                MsgBox("Registro não pode ser excluído. Desative-o para não ser visualizado em relatórios ou procedimentos.", vbInformation, TITULO_ALERTA)
        '            End If

        '        End With
        '        hlp.LimparCampos(Me)
        '        bloqueiaBotoes()
        '    End If
        'End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim filtro As String = ""
        filtro = IIf(IsDBNull(Me.txtFiltro.Text), vbEmpty, Me.txtFiltro.Text.Trim) 'captura o valor, se existir.        
        camposObrigatorios = "txtNome;cbPerfilAcesso"
        If String.IsNullOrEmpty(Me.txtID.Text) Or Me.txtID.Text = 0 Then
            MsgBox("Nenhum registro foi selecionado!", MsgBoxStyle.Information, TITULO_ALERTA)
            Exit Sub
        Else
            If hlp.validaCamposObrigatorios(Me, camposObrigatorios) Then
                udto = ubll.GetUsuariosPorCodigo(Me.txtID.Text)
                With udto
                    .nome = Me.txtNome.Text.Trim
                    .ativo = Me.ckboxAtivo.Checked
                    .perfilAcesso = Me.cbPerfilAcesso.SelectedValue
                    .Acao = FlagAcao.Update
                End With
                With ubll
                    If .SalvaUsuario(udto) Then
                        .AtualizaListViewUsuarios(filtro)
                        hlp.limparCampos(Me)
                        bloqueiaBotoes()
                        MsgBox("Registro alterado com sucesso!", vbInformation, TITULO_ALERTA)
                        Logs.RegistrarLOG("Alteração", "Usuário", hlp.getCurrentMethodName, Me.txtNome.Text.Trim)
                    Else
                        MsgBox("Este nome de usuário (" & Me.txtNome.Text.ToUpper & ") já está em usom tente outro por favor!", vbInformation, TITULO_ALERTA)
                        Exit Sub
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        hlp.limparCampos(Me)
        ubll.AtualizaListViewUsuarios(Me.txtFiltro.Text)
        bloqueiaBotoes()
    End Sub

    Private Sub lkResetarSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkResetarSenha.LinkClicked
        If MsgBox("Deseja continuar com o reset de senha do usuário: " & txtNome.Text & "?", vbYesNo + vbQuestion, TITULO_ALERTA) = vbYes Then
            ubll.ResetSenha(txtID.Text)
        Else
            MsgBox("Cancelado o processo de resete de senha para o usuário: " & txtNome.Text & "", vbInformation, TITULO_ALERTA)
        End If
    End Sub

    Private Sub cbPerfilAcesso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbPerfilAcesso.KeyPress
        e.Handled = True
    End Sub
End Class