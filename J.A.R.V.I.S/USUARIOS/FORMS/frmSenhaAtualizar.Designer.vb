<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSenhaAtualizar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSenhaAtualizar))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNovaSenha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConfirmacaoSenha = New System.Windows.Forms.TextBox()
        Me.txtSenhaAtual = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.mostrarSenhaAtual = New System.Windows.Forms.PictureBox()
        Me.ocultarSenhaAtual = New System.Windows.Forms.PictureBox()
        Me.ocultarNovaSenha = New System.Windows.Forms.PictureBox()
        Me.mostrarNovaSenha = New System.Windows.Forms.PictureBox()
        Me.ocultarConfirmacaoSenha = New System.Windows.Forms.PictureBox()
        Me.mostrarConfirmacaoSenha = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrarSenhaAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ocultarSenhaAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ocultarNovaSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrarNovaSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ocultarConfirmacaoSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrarConfirmacaoSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(148, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "Nova Senha:"
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.Location = New System.Drawing.Point(259, 86)
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaSenha.Size = New System.Drawing.Size(236, 20)
        Me.txtNovaSenha.TabIndex = 2
        Me.txtNovaSenha.Tag = "NOVA SENHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(148, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Confirmação Senha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(150, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Senha Atual:"
        '
        'txtConfirmacaoSenha
        '
        Me.txtConfirmacaoSenha.Location = New System.Drawing.Point(259, 112)
        Me.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha"
        Me.txtConfirmacaoSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmacaoSenha.Size = New System.Drawing.Size(236, 20)
        Me.txtConfirmacaoSenha.TabIndex = 3
        Me.txtConfirmacaoSenha.Tag = "CONFIRMAÇÃO SENHA"
        '
        'txtSenhaAtual
        '
        Me.txtSenhaAtual.Location = New System.Drawing.Point(259, 60)
        Me.txtSenhaAtual.Name = "txtSenhaAtual"
        Me.txtSenhaAtual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaAtual.Size = New System.Drawing.Size(236, 20)
        Me.txtSenhaAtual.TabIndex = 1
        Me.txtSenhaAtual.Tag = "SENHA ATUAL"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(19, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 239
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(150, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Usuário:"
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Location = New System.Drawing.Point(259, 34)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(236, 20)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.Tag = "USUÁRIO"
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(339, 138)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "   Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlterar.Location = New System.Drawing.Point(420, 138)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 30)
        Me.btnAlterar.TabIndex = 5
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'mostrarSenhaAtual
        '
        Me.mostrarSenhaAtual.BackColor = System.Drawing.Color.Transparent
        Me.mostrarSenhaAtual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mostrarSenhaAtual.ErrorImage = Nothing
        Me.mostrarSenhaAtual.Image = CType(resources.GetObject("mostrarSenhaAtual.Image"), System.Drawing.Image)
        Me.mostrarSenhaAtual.InitialImage = Nothing
        Me.mostrarSenhaAtual.Location = New System.Drawing.Point(501, 61)
        Me.mostrarSenhaAtual.Name = "mostrarSenhaAtual"
        Me.mostrarSenhaAtual.Size = New System.Drawing.Size(27, 20)
        Me.mostrarSenhaAtual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mostrarSenhaAtual.TabIndex = 244
        Me.mostrarSenhaAtual.TabStop = False
        '
        'ocultarSenhaAtual
        '
        Me.ocultarSenhaAtual.BackColor = System.Drawing.Color.Transparent
        Me.ocultarSenhaAtual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ocultarSenhaAtual.ErrorImage = Nothing
        Me.ocultarSenhaAtual.Image = CType(resources.GetObject("ocultarSenhaAtual.Image"), System.Drawing.Image)
        Me.ocultarSenhaAtual.InitialImage = Nothing
        Me.ocultarSenhaAtual.Location = New System.Drawing.Point(501, 61)
        Me.ocultarSenhaAtual.Name = "ocultarSenhaAtual"
        Me.ocultarSenhaAtual.Size = New System.Drawing.Size(27, 20)
        Me.ocultarSenhaAtual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ocultarSenhaAtual.TabIndex = 245
        Me.ocultarSenhaAtual.TabStop = False
        '
        'ocultarNovaSenha
        '
        Me.ocultarNovaSenha.BackColor = System.Drawing.Color.Transparent
        Me.ocultarNovaSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ocultarNovaSenha.ErrorImage = Nothing
        Me.ocultarNovaSenha.Image = CType(resources.GetObject("ocultarNovaSenha.Image"), System.Drawing.Image)
        Me.ocultarNovaSenha.InitialImage = Nothing
        Me.ocultarNovaSenha.Location = New System.Drawing.Point(501, 87)
        Me.ocultarNovaSenha.Name = "ocultarNovaSenha"
        Me.ocultarNovaSenha.Size = New System.Drawing.Size(27, 20)
        Me.ocultarNovaSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ocultarNovaSenha.TabIndex = 247
        Me.ocultarNovaSenha.TabStop = False
        '
        'mostrarNovaSenha
        '
        Me.mostrarNovaSenha.BackColor = System.Drawing.Color.Transparent
        Me.mostrarNovaSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mostrarNovaSenha.ErrorImage = Nothing
        Me.mostrarNovaSenha.Image = CType(resources.GetObject("mostrarNovaSenha.Image"), System.Drawing.Image)
        Me.mostrarNovaSenha.InitialImage = Nothing
        Me.mostrarNovaSenha.Location = New System.Drawing.Point(501, 87)
        Me.mostrarNovaSenha.Name = "mostrarNovaSenha"
        Me.mostrarNovaSenha.Size = New System.Drawing.Size(27, 20)
        Me.mostrarNovaSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mostrarNovaSenha.TabIndex = 246
        Me.mostrarNovaSenha.TabStop = False
        '
        'ocultarConfirmacaoSenha
        '
        Me.ocultarConfirmacaoSenha.BackColor = System.Drawing.Color.Transparent
        Me.ocultarConfirmacaoSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ocultarConfirmacaoSenha.ErrorImage = Nothing
        Me.ocultarConfirmacaoSenha.Image = CType(resources.GetObject("ocultarConfirmacaoSenha.Image"), System.Drawing.Image)
        Me.ocultarConfirmacaoSenha.InitialImage = Nothing
        Me.ocultarConfirmacaoSenha.Location = New System.Drawing.Point(501, 112)
        Me.ocultarConfirmacaoSenha.Name = "ocultarConfirmacaoSenha"
        Me.ocultarConfirmacaoSenha.Size = New System.Drawing.Size(27, 20)
        Me.ocultarConfirmacaoSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ocultarConfirmacaoSenha.TabIndex = 249
        Me.ocultarConfirmacaoSenha.TabStop = False
        '
        'mostrarConfirmacaoSenha
        '
        Me.mostrarConfirmacaoSenha.BackColor = System.Drawing.Color.Transparent
        Me.mostrarConfirmacaoSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mostrarConfirmacaoSenha.ErrorImage = Nothing
        Me.mostrarConfirmacaoSenha.Image = CType(resources.GetObject("mostrarConfirmacaoSenha.Image"), System.Drawing.Image)
        Me.mostrarConfirmacaoSenha.InitialImage = Nothing
        Me.mostrarConfirmacaoSenha.Location = New System.Drawing.Point(501, 112)
        Me.mostrarConfirmacaoSenha.Name = "mostrarConfirmacaoSenha"
        Me.mostrarConfirmacaoSenha.Size = New System.Drawing.Size(27, 20)
        Me.mostrarConfirmacaoSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mostrarConfirmacaoSenha.TabIndex = 248
        Me.mostrarConfirmacaoSenha.TabStop = False
        '
        'frmSenhaAtualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 178)
        Me.Controls.Add(Me.ocultarConfirmacaoSenha)
        Me.Controls.Add(Me.mostrarConfirmacaoSenha)
        Me.Controls.Add(Me.ocultarNovaSenha)
        Me.Controls.Add(Me.mostrarNovaSenha)
        Me.Controls.Add(Me.ocultarSenhaAtual)
        Me.Controls.Add(Me.mostrarSenhaAtual)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNovaSenha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtConfirmacaoSenha)
        Me.Controls.Add(Me.txtSenhaAtual)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSenhaAtualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Atualizar Senha de Acesso :."
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrarSenhaAtual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ocultarSenhaAtual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ocultarNovaSenha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrarNovaSenha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ocultarConfirmacaoSenha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrarConfirmacaoSenha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents txtNovaSenha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirmacaoSenha As TextBox
    Friend WithEvents txtSenhaAtual As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents mostrarSenhaAtual As PictureBox
    Friend WithEvents ocultarSenhaAtual As PictureBox
    Friend WithEvents ocultarNovaSenha As PictureBox
    Friend WithEvents mostrarNovaSenha As PictureBox
    Friend WithEvents ocultarConfirmacaoSenha As PictureBox
    Friend WithEvents mostrarConfirmacaoSenha As PictureBox
End Class
