<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadClientes))
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtInstagram = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCompanheiro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ckboxAtivo = New System.Windows.Forms.CheckBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFacebook = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbxGestante = New System.Windows.Forms.ComboBox()
        Me.txtQtdeFilhos = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.txtNomeFIlho = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnExcluirFilho = New System.Windows.Forms.Button()
        Me.btnAlterarFilho = New System.Windows.Forms.Button()
        Me.btnIncluirFilho = New System.Windows.Forms.Button()
        Me.gbFilhos = New System.Windows.Forms.GroupBox()
        Me.txtIdFilhos = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpNascimentoFIlho = New System.Windows.Forms.DateTimePicker()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.dtpDataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtpPreviscaoNascimento = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtSemanasGestacao = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFilhos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Location = New System.Drawing.Point(115, 143)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(262, 20)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.Tag = "E-MAIL"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(28, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 202
        Me.Label18.Text = "E-mail:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(115, 118)
        Me.txtCelular.Mask = "(99) 0000-0000"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(262, 20)
        Me.txtCelular.TabIndex = 4
        Me.txtCelular.Tag = "CELULAR"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(115, 92)
        Me.txtTelefone.Mask = "(99) 00000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(262, 20)
        Me.txtTelefone.TabIndex = 3
        Me.txtTelefone.Tag = "TELEFONE FIXO"
        '
        'txtObservacao
        '
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(115, 351)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(262, 65)
        Me.txtObservacao.TabIndex = 14
        Me.txtObservacao.Tag = "OBSERVAÇÃO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(28, 354)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 200
        Me.Label16.Text = "Observações:"
        '
        'txtInstagram
        '
        Me.txtInstagram.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInstagram.Location = New System.Drawing.Point(115, 169)
        Me.txtInstagram.Name = "txtInstagram"
        Me.txtInstagram.Size = New System.Drawing.Size(262, 20)
        Me.txtInstagram.TabIndex = 6
        Me.txtInstagram.Tag = "INSTAGRAM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(28, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 197
        Me.Label12.Text = "Instagram:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(28, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 196
        Me.Label8.Text = "Celular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(28, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "Telefone Fixo:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(896, 593)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 13)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "Dê um duplo click para editar um registro!"
        '
        'txtCompanheiro
        '
        Me.txtCompanheiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompanheiro.Location = New System.Drawing.Point(115, 66)
        Me.txtCompanheiro.Name = "txtCompanheiro"
        Me.txtCompanheiro.Size = New System.Drawing.Size(262, 20)
        Me.txtCompanheiro.TabIndex = 2
        Me.txtCompanheiro.Tag = "COMPANHEIRO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(28, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 193
        Me.Label3.Text = "Companheiro(a):"
        '
        'btnRemoveFiltro
        '
        Me.btnRemoveFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveFiltro.Image = CType(resources.GetObject("btnRemoveFiltro.Image"), System.Drawing.Image)
        Me.btnRemoveFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveFiltro.Location = New System.Drawing.Point(688, 460)
        Me.btnRemoveFiltro.Name = "btnRemoveFiltro"
        Me.btnRemoveFiltro.Size = New System.Drawing.Size(75, 30)
        Me.btnRemoveFiltro.TabIndex = 22
        Me.btnRemoveFiltro.Text = "     Limpar"
        Me.btnRemoveFiltro.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(153, 593)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 192
        Me.Label9.Text = "Inativo"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(139, 591)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox2.TabIndex = 191
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(32, 593)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 190
        Me.Label10.Text = "Legenda:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(105, 593)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 189
        Me.Label11.Text = "Ativo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(88, 591)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox1.TabIndex = 188
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(337, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 13)
        Me.Label6.TabIndex = 187
        Me.Label6.Text = "Filtro por Cliente ou Companheiro(a):"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(609, 460)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 30)
        Me.btnFiltrar.TabIndex = 21
        Me.btnFiltrar.Text = "   Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(337, 470)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(266, 20)
        Me.txtFiltro.TabIndex = 179
        Me.txtFiltro.Tag = "FILTRO"
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(256, 460)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "   Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcluir.Location = New System.Drawing.Point(181, 460)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 30)
        Me.btnExcluir.TabIndex = 19
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Enabled = False
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlterar.Location = New System.Drawing.Point(106, 460)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 30)
        Me.btnAlterar.TabIndex = 18
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(31, 496)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1067, 94)
        Me.ListView1.TabIndex = 182
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = CType(resources.GetObject("btnIncluir.Image"), System.Drawing.Image)
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnIncluir.Location = New System.Drawing.Point(31, 460)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(75, 30)
        Me.btnIncluir.TabIndex = 17
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(136, 422)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(219, 13)
        Me.Label14.TabIndex = 186
        Me.Label14.Text = "Quando inativa, não é listado para utilização."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(28, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 185
        Me.Label5.Text = "Ativo:"
        '
        'ckboxAtivo
        '
        Me.ckboxAtivo.AutoSize = True
        Me.ckboxAtivo.BackColor = System.Drawing.Color.Transparent
        Me.ckboxAtivo.Location = New System.Drawing.Point(115, 422)
        Me.ckboxAtivo.Name = "ckboxAtivo"
        Me.ckboxAtivo.Size = New System.Drawing.Size(15, 14)
        Me.ckboxAtivo.TabIndex = 15
        Me.ckboxAtivo.Tag = "ATIVO"
        Me.ckboxAtivo.UseVisualStyleBackColor = False
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(115, 40)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(262, 20)
        Me.txtCliente.TabIndex = 1
        Me.txtCliente.Tag = "CLIENTE"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(115, 14)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(262, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.Tag = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(28, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(28, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "ID:"
        '
        'txtFacebook
        '
        Me.txtFacebook.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFacebook.Location = New System.Drawing.Point(115, 195)
        Me.txtFacebook.Name = "txtFacebook"
        Me.txtFacebook.Size = New System.Drawing.Size(262, 20)
        Me.txtFacebook.TabIndex = 7
        Me.txtFacebook.Tag = "FACEBOOK"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(28, 198)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 204
        Me.Label19.Text = "Facebook:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(28, 224)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 206
        Me.Label20.Text = "Gestante:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(240, 224)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 13)
        Me.Label21.TabIndex = 207
        Me.Label21.Text = "Qtde Semanas:"
        '
        'cbxGestante
        '
        Me.cbxGestante.FormattingEnabled = True
        Me.cbxGestante.Items.AddRange(New Object() {"SIM", "NÃO"})
        Me.cbxGestante.Location = New System.Drawing.Point(115, 221)
        Me.cbxGestante.Name = "cbxGestante"
        Me.cbxGestante.Size = New System.Drawing.Size(119, 21)
        Me.cbxGestante.TabIndex = 8
        Me.cbxGestante.Tag = "GESTANTE"
        '
        'txtQtdeFilhos
        '
        Me.txtQtdeFilhos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQtdeFilhos.Location = New System.Drawing.Point(115, 273)
        Me.txtQtdeFilhos.Name = "txtQtdeFilhos"
        Me.txtQtdeFilhos.Size = New System.Drawing.Size(262, 20)
        Me.txtQtdeFilhos.TabIndex = 11
        Me.txtQtdeFilhos.Tag = "QTDE DE FILHOS"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(28, 276)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 13)
        Me.Label22.TabIndex = 210
        Me.Label22.Text = "Qtde Filhos:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(28, 302)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 13)
        Me.Label23.TabIndex = 212
        Me.Label23.Text = "CPF:"
        '
        'ListView2
        '
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(14, 178)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(650, 199)
        Me.ListView2.TabIndex = 6
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'txtNomeFIlho
        '
        Me.txtNomeFIlho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFIlho.Location = New System.Drawing.Point(106, 37)
        Me.txtNomeFIlho.Name = "txtNomeFIlho"
        Me.txtNomeFIlho.Size = New System.Drawing.Size(254, 20)
        Me.txtNomeFIlho.TabIndex = 0
        Me.txtNomeFIlho.Tag = "NOME FILHO(A)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(25, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 217
        Me.Label13.Text = "Data Nasc.:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(25, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 216
        Me.Label15.Text = "Nome Filho(a):"
        '
        'cbxSexo
        '
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Items.AddRange(New Object() {"FEMININO", "MASCULINO"})
        Me.cbxSexo.Location = New System.Drawing.Point(106, 89)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(254, 21)
        Me.cbxSexo.TabIndex = 2
        Me.cbxSexo.Tag = "SEXO FILHO(A)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(25, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 218
        Me.Label17.Text = "Sexo:"
        '
        'btnExcluirFilho
        '
        Me.btnExcluirFilho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluirFilho.Enabled = False
        Me.btnExcluirFilho.Image = CType(resources.GetObject("btnExcluirFilho.Image"), System.Drawing.Image)
        Me.btnExcluirFilho.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcluirFilho.Location = New System.Drawing.Point(272, 115)
        Me.btnExcluirFilho.Name = "btnExcluirFilho"
        Me.btnExcluirFilho.Size = New System.Drawing.Size(75, 30)
        Me.btnExcluirFilho.TabIndex = 5
        Me.btnExcluirFilho.Text = "Excluir"
        Me.btnExcluirFilho.UseVisualStyleBackColor = True
        '
        'btnAlterarFilho
        '
        Me.btnAlterarFilho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterarFilho.Enabled = False
        Me.btnAlterarFilho.Image = CType(resources.GetObject("btnAlterarFilho.Image"), System.Drawing.Image)
        Me.btnAlterarFilho.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlterarFilho.Location = New System.Drawing.Point(197, 115)
        Me.btnAlterarFilho.Name = "btnAlterarFilho"
        Me.btnAlterarFilho.Size = New System.Drawing.Size(75, 30)
        Me.btnAlterarFilho.TabIndex = 4
        Me.btnAlterarFilho.Text = "Alterar"
        Me.btnAlterarFilho.UseVisualStyleBackColor = True
        '
        'btnIncluirFilho
        '
        Me.btnIncluirFilho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluirFilho.Image = CType(resources.GetObject("btnIncluirFilho.Image"), System.Drawing.Image)
        Me.btnIncluirFilho.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnIncluirFilho.Location = New System.Drawing.Point(122, 115)
        Me.btnIncluirFilho.Name = "btnIncluirFilho"
        Me.btnIncluirFilho.Size = New System.Drawing.Size(75, 30)
        Me.btnIncluirFilho.TabIndex = 3
        Me.btnIncluirFilho.Text = "Incluir"
        Me.btnIncluirFilho.UseVisualStyleBackColor = True
        '
        'gbFilhos
        '
        Me.gbFilhos.Controls.Add(Me.Label27)
        Me.gbFilhos.Controls.Add(Me.txtIdFilhos)
        Me.gbFilhos.Controls.Add(Me.Label25)
        Me.gbFilhos.Controls.Add(Me.dtpNascimentoFIlho)
        Me.gbFilhos.Controls.Add(Me.btnExcluirFilho)
        Me.gbFilhos.Controls.Add(Me.ListView2)
        Me.gbFilhos.Controls.Add(Me.btnAlterarFilho)
        Me.gbFilhos.Controls.Add(Me.Label15)
        Me.gbFilhos.Controls.Add(Me.btnIncluirFilho)
        Me.gbFilhos.Controls.Add(Me.Label13)
        Me.gbFilhos.Controls.Add(Me.cbxSexo)
        Me.gbFilhos.Controls.Add(Me.txtNomeFIlho)
        Me.gbFilhos.Controls.Add(Me.Label17)
        Me.gbFilhos.Enabled = False
        Me.gbFilhos.Location = New System.Drawing.Point(407, 17)
        Me.gbFilhos.Name = "gbFilhos"
        Me.gbFilhos.Size = New System.Drawing.Size(678, 399)
        Me.gbFilhos.TabIndex = 16
        Me.gbFilhos.TabStop = False
        Me.gbFilhos.Text = "Controle de descendentes:"
        '
        'txtIdFilhos
        '
        Me.txtIdFilhos.Enabled = False
        Me.txtIdFilhos.Location = New System.Drawing.Point(21, 121)
        Me.txtIdFilhos.Name = "txtIdFilhos"
        Me.txtIdFilhos.Size = New System.Drawing.Size(79, 20)
        Me.txtIdFilhos.TabIndex = 229
        Me.txtIdFilhos.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label25.Location = New System.Drawing.Point(462, 159)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(202, 13)
        Me.Label25.TabIndex = 227
        Me.Label25.Text = "Dê um duplo click para editar um registro!"
        '
        'dtpNascimentoFIlho
        '
        Me.dtpNascimentoFIlho.Location = New System.Drawing.Point(106, 63)
        Me.dtpNascimentoFIlho.Name = "dtpNascimentoFIlho"
        Me.dtpNascimentoFIlho.Size = New System.Drawing.Size(254, 20)
        Me.dtpNascimentoFIlho.TabIndex = 1
        Me.dtpNascimentoFIlho.Tag = "DATA NASCIMENTO FILHO(A)"
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(115, 299)
        Me.txtCpf.Mask = "000.000.000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(262, 20)
        Me.txtCpf.TabIndex = 12
        Me.txtCpf.Tag = "CPF"
        '
        'dtpDataNascimento
        '
        Me.dtpDataNascimento.Location = New System.Drawing.Point(115, 325)
        Me.dtpDataNascimento.Name = "dtpDataNascimento"
        Me.dtpDataNascimento.Size = New System.Drawing.Size(262, 20)
        Me.dtpDataNascimento.TabIndex = 13
        Me.dtpDataNascimento.Tag = "DATA DE NASCIMENTO"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(28, 329)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 13)
        Me.Label24.TabIndex = 225
        Me.Label24.Text = "Data Nasc.:"
        '
        'dtpPreviscaoNascimento
        '
        Me.dtpPreviscaoNascimento.Location = New System.Drawing.Point(115, 247)
        Me.dtpPreviscaoNascimento.Name = "dtpPreviscaoNascimento"
        Me.dtpPreviscaoNascimento.Size = New System.Drawing.Size(262, 20)
        Me.dtpPreviscaoNascimento.TabIndex = 10
        Me.dtpPreviscaoNascimento.Tag = "PREVISÃO NASCIMENTO"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(28, 251)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 13)
        Me.Label26.TabIndex = 227
        Me.Label26.Text = "Previsão Nasc.:"
        '
        'txtSemanasGestacao
        '
        Me.txtSemanasGestacao.Location = New System.Drawing.Point(326, 221)
        Me.txtSemanasGestacao.Mask = "00"
        Me.txtSemanasGestacao.Name = "txtSemanasGestacao"
        Me.txtSemanasGestacao.Size = New System.Drawing.Size(51, 20)
        Me.txtSemanasGestacao.TabIndex = 228
        Me.txtSemanasGestacao.Tag = "QTDE SEMANAS"
        Me.txtSemanasGestacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSemanasGestacao.ValidatingType = GetType(Integer)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label27.Location = New System.Drawing.Point(386, 52)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(261, 52)
        Me.Label27.TabIndex = 230
        Me.Label27.Text = "Para incluir descendentes a um cliente é necessário " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "primeiramente incluir o cli" &
    "ente na J.A.R.V.I.S e depois " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "editar o cliente incluindo quantos descendentes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "forem necessários."
        '
        'frmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1121, 629)
        Me.Controls.Add(Me.txtSemanasGestacao)
        Me.Controls.Add(Me.dtpPreviscaoNascimento)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.dtpDataNascimento)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtQtdeFilhos)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbxGestante)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtFacebook)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtInstagram)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCompanheiro)
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
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ckboxAtivo)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbFilhos)
        Me.Name = "frmCadClientes"
        Me.Text = ".: Cadastro de Clientes :."
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFilhos.ResumeLayout(False)
        Me.gbFilhos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtInstagram As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCompanheiro As TextBox
    Friend WithEvents Label3 As Label
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
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ckboxAtivo As CheckBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFacebook As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cbxGestante As ComboBox
    Friend WithEvents txtQtdeFilhos As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents txtNomeFIlho As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbxSexo As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnExcluirFilho As Button
    Friend WithEvents btnAlterarFilho As Button
    Friend WithEvents btnIncluirFilho As Button
    Friend WithEvents gbFilhos As GroupBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents dtpNascimentoFIlho As DateTimePicker
    Friend WithEvents dtpDataNascimento As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents dtpPreviscaoNascimento As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents txtSemanasGestacao As MaskedTextBox
    Friend WithEvents txtIdFilhos As TextBox
    Friend WithEvents Label27 As Label
End Class
