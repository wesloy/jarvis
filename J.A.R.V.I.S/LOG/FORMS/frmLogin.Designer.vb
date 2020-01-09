<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lbCopyright = New System.Windows.Forms.Label()
        Me.lbHost = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.lbIdiomaPC = New System.Windows.Forms.Label()
        Me.lblVersao = New System.Windows.Forms.Label()
        Me.lbData = New System.Windows.Forms.Label()
        Me.lbEmpresa = New System.Windows.Forms.Label()
        Me.lbDesenvolvidoPor = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnAcessar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rtAlerta = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ocultarSenha = New System.Windows.Forms.PictureBox()
        Me.mostrarSenha = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ocultarSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrarSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCopyright
        '
        Me.lbCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lbCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCopyright.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbCopyright.Location = New System.Drawing.Point(12, 9)
        Me.lbCopyright.Name = "lbCopyright"
        Me.lbCopyright.Size = New System.Drawing.Size(202, 23)
        Me.lbCopyright.TabIndex = 202
        Me.lbCopyright.Text = "{Copyright}"
        '
        'lbHost
        '
        Me.lbHost.BackColor = System.Drawing.Color.Transparent
        Me.lbHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbHost.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbHost.Location = New System.Drawing.Point(137, 105)
        Me.lbHost.Name = "lbHost"
        Me.lbHost.Size = New System.Drawing.Size(101, 13)
        Me.lbHost.TabIndex = 234
        Me.lbHost.Text = "{Hostname}"
        Me.lbHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 235
        Me.Label11.Text = "Hostname:"
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.Location = New System.Drawing.Point(319, 201)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(87, 45)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'lbIdiomaPC
        '
        Me.lbIdiomaPC.BackColor = System.Drawing.Color.Transparent
        Me.lbIdiomaPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbIdiomaPC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdiomaPC.Location = New System.Drawing.Point(137, 78)
        Me.lbIdiomaPC.Name = "lbIdiomaPC"
        Me.lbIdiomaPC.Size = New System.Drawing.Size(101, 13)
        Me.lbIdiomaPC.TabIndex = 220
        Me.lbIdiomaPC.Text = "{IdiomaPC}"
        Me.lbIdiomaPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersao
        '
        Me.lblVersao.BackColor = System.Drawing.Color.Transparent
        Me.lblVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblVersao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVersao.Location = New System.Drawing.Point(137, 92)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(101, 13)
        Me.lblVersao.TabIndex = 219
        Me.lblVersao.Text = "{Versao}"
        Me.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbData
        '
        Me.lbData.BackColor = System.Drawing.Color.Transparent
        Me.lbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbData.Location = New System.Drawing.Point(137, 36)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(101, 13)
        Me.lbData.TabIndex = 232
        Me.lbData.Text = "{Data}"
        Me.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbEmpresa
        '
        Me.lbEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbEmpresa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbEmpresa.Location = New System.Drawing.Point(137, 50)
        Me.lbEmpresa.Name = "lbEmpresa"
        Me.lbEmpresa.Size = New System.Drawing.Size(180, 13)
        Me.lbEmpresa.TabIndex = 231
        Me.lbEmpresa.Text = "{Empresa}"
        Me.lbEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDesenvolvidoPor
        '
        Me.lbDesenvolvidoPor.BackColor = System.Drawing.Color.Transparent
        Me.lbDesenvolvidoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbDesenvolvidoPor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbDesenvolvidoPor.Location = New System.Drawing.Point(137, 64)
        Me.lbDesenvolvidoPor.Name = "lbDesenvolvidoPor"
        Me.lbDesenvolvidoPor.Size = New System.Drawing.Size(182, 14)
        Me.lbDesenvolvidoPor.TabIndex = 230
        Me.lbDesenvolvidoPor.Text = "{Desenvolvido por}"
        Me.lbDesenvolvidoPor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 229
        Me.Label9.Text = "Versão:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 228
        Me.Label8.Text = "Idioma:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 14)
        Me.Label7.TabIndex = 227
        Me.Label7.Text = "Desenvolvido por:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 226
        Me.Label6.Text = "Empresa:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 14)
        Me.Label5.TabIndex = 225
        Me.Label5.Text = "Data:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(144, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 224
        Me.Label2.Text = "Usuário:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(144, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Senha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Location = New System.Drawing.Point(230, 149)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(176, 20)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.Tag = "Usuário:"
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.White
        Me.txtSenha.Location = New System.Drawing.Point(230, 175)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(176, 20)
        Me.txtSenha.TabIndex = 1
        Me.txtSenha.Tag = "Senha:"
        '
        'btnAcessar
        '
        Me.btnAcessar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnAcessar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAcessar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcessar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcessar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAcessar.Image = CType(resources.GetObject("btnAcessar.Image"), System.Drawing.Image)
        Me.btnAcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcessar.Location = New System.Drawing.Point(230, 201)
        Me.btnAcessar.Name = "btnAcessar"
        Me.btnAcessar.Size = New System.Drawing.Size(87, 45)
        Me.btnAcessar.TabIndex = 2
        Me.btnAcessar.Text = "Acessar"
        Me.btnAcessar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAcessar.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(325, 36)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(81, 71)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 215
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(276, 252)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 74)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 238
        Me.PictureBox2.TabStop = False
        '
        'rtAlerta
        '
        Me.rtAlerta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.rtAlerta.AutoSize = True
        Me.rtAlerta.BackColor = System.Drawing.Color.Transparent
        Me.rtAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtAlerta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rtAlerta.Location = New System.Drawing.Point(302, 335)
        Me.rtAlerta.Name = "rtAlerta"
        Me.rtAlerta.Size = New System.Drawing.Size(45, 13)
        Me.rtAlerta.TabIndex = 237
        Me.rtAlerta.Text = "{Alerta!}"
        Me.rtAlerta.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(283, 331)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 236
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'ocultarSenha
        '
        Me.ocultarSenha.BackColor = System.Drawing.Color.Transparent
        Me.ocultarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ocultarSenha.ErrorImage = Nothing
        Me.ocultarSenha.Image = CType(resources.GetObject("ocultarSenha.Image"), System.Drawing.Image)
        Me.ocultarSenha.InitialImage = Nothing
        Me.ocultarSenha.Location = New System.Drawing.Point(403, 175)
        Me.ocultarSenha.Name = "ocultarSenha"
        Me.ocultarSenha.Size = New System.Drawing.Size(27, 20)
        Me.ocultarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ocultarSenha.TabIndex = 247
        Me.ocultarSenha.TabStop = False
        '
        'mostrarSenha
        '
        Me.mostrarSenha.BackColor = System.Drawing.Color.Transparent
        Me.mostrarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mostrarSenha.ErrorImage = Nothing
        Me.mostrarSenha.Image = CType(resources.GetObject("mostrarSenha.Image"), System.Drawing.Image)
        Me.mostrarSenha.InitialImage = Nothing
        Me.mostrarSenha.Location = New System.Drawing.Point(403, 175)
        Me.mostrarSenha.Name = "mostrarSenha"
        Me.mostrarSenha.Size = New System.Drawing.Size(27, 20)
        Me.mostrarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mostrarSenha.TabIndex = 246
        Me.mostrarSenha.TabStop = False
        Me.mostrarSenha.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 391)
        Me.Controls.Add(Me.ocultarSenha)
        Me.Controls.Add(Me.mostrarSenha)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.rtAlerta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbHost)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.lbIdiomaPC)
        Me.Controls.Add(Me.lblVersao)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.lbEmpresa)
        Me.Controls.Add(Me.lbDesenvolvidoPor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.btnAcessar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lbCopyright)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Login J.A.R.V.I.S :."
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ocultarSenha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrarSenha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCopyright As Label
    Friend WithEvents lbHost As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnFechar As Button
    Friend WithEvents lbIdiomaPC As Label
    Friend WithEvents lblVersao As Label
    Friend WithEvents lbData As Label
    Friend WithEvents lbEmpresa As Label
    Friend WithEvents lbDesenvolvidoPor As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents btnAcessar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents rtAlerta As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ocultarSenha As PictureBox
    Friend WithEvents mostrarSenha As PictureBox
End Class
