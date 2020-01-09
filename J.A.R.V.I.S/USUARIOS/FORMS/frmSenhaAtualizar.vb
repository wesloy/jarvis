Public Class frmSenhaAtualizar

    Private hlp As New Uteis.Helpers
    Private bll As New bll_usuarios

    Private Sub frmSenhaAtualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarConfirmacaoSenha.Visible = False
        mostrarNovaSenha.Visible = False
        mostrarSenhaAtual.Visible = False
        txtConfirmacaoSenha.PasswordChar = "*"
        txtNovaSenha.PasswordChar = "*"
        txtSenhaAtual.PasswordChar = "*"
    End Sub

    Private Sub ocultarSenhaAtual_Click(sender As Object, e As EventArgs) Handles ocultarSenhaAtual.Click
        ocultarSenhaAtual.Visible = False
        mostrarSenhaAtual.Visible = True
        txtSenhaAtual.PasswordChar = ""
    End Sub

    Private Sub mostrarSenhaAtual_Click(sender As Object, e As EventArgs) Handles mostrarSenhaAtual.Click
        ocultarSenhaAtual.Visible = True
        mostrarSenhaAtual.Visible = False
        txtSenhaAtual.PasswordChar = "*"
    End Sub

    Private Sub ocultarNovaSenha_Click(sender As Object, e As EventArgs) Handles ocultarNovaSenha.Click
        ocultarNovaSenha.Visible = False
        mostrarNovaSenha.Visible = True
        txtNovaSenha.PasswordChar = ""
    End Sub

    Private Sub mostrarNovaSenha_Click(sender As Object, e As EventArgs) Handles mostrarNovaSenha.Click
        ocultarNovaSenha.Visible = True
        mostrarNovaSenha.Visible = False
        txtNovaSenha.PasswordChar = "*"
    End Sub

    Private Sub ocultarConfirmacaoSenha_Click(sender As Object, e As EventArgs) Handles ocultarConfirmacaoSenha.Click
        ocultarConfirmacaoSenha.Visible = False
        mostrarConfirmacaoSenha.Visible = True
        txtConfirmacaoSenha.PasswordChar = ""
    End Sub

    Private Sub mostrarConfirmacaoSenha_Click(sender As Object, e As EventArgs) Handles mostrarConfirmacaoSenha.Click
        ocultarConfirmacaoSenha.Visible = True
        mostrarConfirmacaoSenha.Visible = False
        txtConfirmacaoSenha.PasswordChar = "*"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        hlp.fecharForm(Me)
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If hlp.validaCamposObrigatorios(Me, "txtUsuario;txtSenhaAtual;txtNovaSenha;txtConfirmacaoSenha") Then
            If bll.atualizarSenha(txtUsuario.Text, txtSenhaAtual.Text, txtNovaSenha.Text, txtConfirmacaoSenha.Text) Then
                hlp.fecharForm(Me)
            End If
        End If
    End Sub
End Class