<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadFilas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadFilas))
        Me.txtFila = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ckboxCategorizador = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ckboxAutomatico = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ckboxAtivo = New System.Windows.Forms.CheckBox()
        Me.btnRemoveFiltro = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.txtSigla = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFila
        '
        Me.txtFila.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFila.Location = New System.Drawing.Point(96, 47)
        Me.txtFila.Name = "txtFila"
        Me.txtFila.Size = New System.Drawing.Size(262, 20)
        Me.txtFila.TabIndex = 10
        Me.txtFila.Tag = "Fila"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(96, 21)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(122, 20)
        Me.txtID.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(23, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fila:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID:"
        '
        'txtGrupo
        '
        Me.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrupo.Location = New System.Drawing.Point(96, 99)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(262, 20)
        Me.txtGrupo.TabIndex = 57
        Me.txtGrupo.Tag = "Grupo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(23, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Grupo:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(116, 167)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(399, 13)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "Permite uma fila AUTOMÁTICA, receber registros de forma manual (Categorização)."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(20, 166)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "Trab. Manual:"
        '
        'ckboxCategorizador
        '
        Me.ckboxCategorizador.AutoSize = True
        Me.ckboxCategorizador.BackColor = System.Drawing.Color.Transparent
        Me.ckboxCategorizador.Location = New System.Drawing.Point(95, 166)
        Me.ckboxCategorizador.Name = "ckboxCategorizador"
        Me.ckboxCategorizador.Size = New System.Drawing.Size(15, 14)
        Me.ckboxCategorizador.TabIndex = 64
        Me.ckboxCategorizador.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(116, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(437, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Significa que os registros serão disponibilizados em uma fila obedecendo priorida" &
    "des (GBO)."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(116, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Quando inativa, não aparece para o analista."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(21, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Automática:"
        '
        'ckboxAutomatico
        '
        Me.ckboxAutomatico.AutoSize = True
        Me.ckboxAutomatico.BackColor = System.Drawing.Color.Transparent
        Me.ckboxAutomatico.Location = New System.Drawing.Point(95, 146)
        Me.ckboxAutomatico.Name = "ckboxAutomatico"
        Me.ckboxAutomatico.Size = New System.Drawing.Size(15, 14)
        Me.ckboxAutomatico.TabIndex = 59
        Me.ckboxAutomatico.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(21, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Ativo:"
        '
        'ckboxAtivo
        '
        Me.ckboxAtivo.AutoSize = True
        Me.ckboxAtivo.BackColor = System.Drawing.Color.Transparent
        Me.ckboxAtivo.Location = New System.Drawing.Point(95, 125)
        Me.ckboxAtivo.Name = "ckboxAtivo"
        Me.ckboxAtivo.Size = New System.Drawing.Size(15, 14)
        Me.ckboxAtivo.TabIndex = 58
        Me.ckboxAtivo.UseVisualStyleBackColor = False
        '
        'btnRemoveFiltro
        '
        Me.btnRemoveFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveFiltro.Image = CType(resources.GetObject("btnRemoveFiltro.Image"), System.Drawing.Image)
        Me.btnRemoveFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveFiltro.Location = New System.Drawing.Point(568, 209)
        Me.btnRemoveFiltro.Name = "btnRemoveFiltro"
        Me.btnRemoveFiltro.Size = New System.Drawing.Size(75, 30)
        Me.btnRemoveFiltro.TabIndex = 80
        Me.btnRemoveFiltro.Text = "     Limpar"
        Me.btnRemoveFiltro.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(150, 519)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Inativo"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(136, 517)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(29, 519)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Legenda:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(102, 519)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Ativo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(85, 517)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(329, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Filtro por Fila/Sigla:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(489, 209)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 30)
        Me.btnFiltrar.TabIndex = 72
        Me.btnFiltrar.Text = "   Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(329, 219)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(154, 20)
        Me.txtFiltro.TabIndex = 71
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(248, 209)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 70
        Me.btnCancelar.Text = "   Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcluir.Location = New System.Drawing.Point(173, 209)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 30)
        Me.btnExcluir.TabIndex = 69
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Enabled = False
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlterar.Location = New System.Drawing.Point(98, 209)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 30)
        Me.btnAlterar.TabIndex = 68
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(23, 245)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(620, 266)
        Me.ListView1.TabIndex = 73
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = CType(resources.GetObject("btnIncluir.Image"), System.Drawing.Image)
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnIncluir.Location = New System.Drawing.Point(23, 209)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(75, 30)
        Me.btnIncluir.TabIndex = 67
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'txtSigla
        '
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSigla.Location = New System.Drawing.Point(96, 73)
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(262, 20)
        Me.txtSigla.TabIndex = 81
        Me.txtSigla.Tag = "Fila"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(23, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Sigla:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(441, 514)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 13)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Dê um duplo click para editar um registro!"
        '
        'frmCadFilas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(661, 554)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSigla)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRemoveFiltro)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ckboxCategorizador)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ckboxAutomatico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ckboxAtivo)
        Me.Controls.Add(Me.txtGrupo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtFila)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCadFilas"
        Me.Tag = ".: Cadastro de Filas :."
        Me.Text = ".: Cadastro de Filas :."
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFila As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ckboxCategorizador As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ckboxAutomatico As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ckboxAtivo As CheckBox
    Friend WithEvents btnRemoveFiltro As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnIncluir As Button
    Friend WithEvents txtSigla As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
