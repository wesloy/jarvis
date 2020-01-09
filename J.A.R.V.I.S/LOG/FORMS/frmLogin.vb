Public Class frmLogin

    Private hlp As New Uteis.Helpers
    Private Logs As New Bll_log
    Private fechamentoForcado As Boolean = True

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Copyright
        lbCopyright.Text = Copyright.ToString & " " & Year(Now)
        'Data
        lbData.Text = hlp.DataAbreviada()
        'Empresa
        lbEmpresa.Text = My.Application.Info.CompanyName.ToString
        'Créditos
        lbDesenvolvidoPor.Text = CREDITOS.ToString
        'idiomapc
        lbIdiomaPC.Text = hlp.retornaIdiomaPC.ToString
        'Versao
        lblVersao.Text = hlp.versaoSistema.ToString
        'Hosntame
        lbHost.Text = Environ("COMPUTERNAME").ToString

        'retira o botão fechar
        hlp.RemoveXButton(Me.Handle())

    End Sub

    Private Sub btnAcessar_Click(sender As Object, e As EventArgs) Handles btnAcessar.Click

        If Not hlp.validarIdiomaPC("PT-BR") Then Logs.fecharAplicativo(False)

        Dim camposObrigatorios = "txtUsuario;txtSenha"
        hlp.CursorPointer(True)

        If Not hlp.validaCamposObrigatorios(Me, camposObrigatorios) Then
            hlp.CursorPointer(False)
            Exit Sub
        End If

        If txtSenha.Text = "123456" Then
            MsgBox("Você está usando uma senha temporária, deve ser trocada antes de acessar o J.A.R.V.I.S!", vbInformation, TITULO_ALERTA)
            hlp.abrirForm(frmSenhaAtualizar, True, False)
            txtSenha.Text = ""
            Exit Sub
        End If


        If Not Logs.Autenticar(txtUsuario.Text, txtSenha.Text) Then
            hlp.CursorPointer(False)
            Exit Sub
        End If

        Me.btnAcessar.Enabled = False
        fechamentoForcado = False 'Variável para não fechar o aplicativo
        Logs.Redireciona("frmPrincipal")
        Logs.RegistrarLOG(, , "frmPrincipal", "Login")

        hlp.CursorPointer(False)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        fechamentoForcado = False
        Logs.fecharAplicativo(True)
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If fechamentoForcado Then
            Logs.registrarLOG(, , Me.Text, "FECHAMENTO FORÇADO")
            Logs.fecharAplicativo(False)
        End If

    End Sub

    Private Sub PictureBox3_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox3.DoubleClick
        Dim senha As String
        senha = InputBox("Entre com a senha para criptografar", "")
        senha = hlp.Encrypt(senha)
        MessageBox.Show(senha)
    End Sub

    Private Sub mostrarSenha_Click(sender As Object, e As EventArgs) Handles mostrarSenha.Click
        Me.ocultarSenha.Visible = True
        Me.mostrarSenha.Visible = False
        txtSenha.PasswordChar = "*"
    End Sub

    Private Sub ocultarSenha_Click(sender As Object, e As EventArgs) Handles ocultarSenha.Click
        Me.mostrarSenha.Visible = True
        Me.ocultarSenha.Visible = False
        txtSenha.PasswordChar = ""
    End Sub
End Class