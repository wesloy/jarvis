<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutos))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSigla = New System.Windows.Forms.TextBox()
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
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbAlbum = New System.Windows.Forms.GroupBox()
        Me.album_rbSim = New System.Windows.Forms.RadioButton()
        Me.album_rbNao = New System.Windows.Forms.RadioButton()
        Me.album_txtTamanho = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.album_txtFolhas = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.album_txtTipo = New System.Windows.Forms.TextBox()
        Me.gbPainel = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.painel_txtMoldura = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.painel_txtQtde = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.painel_txtTamanho = New System.Windows.Forms.TextBox()
        Me.painel_rbNao = New System.Windows.Forms.RadioButton()
        Me.painel_rbSim = New System.Windows.Forms.RadioButton()
        Me.gbEnsaios = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ensaios_txtMeses = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ensaios_txtQtdade = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ensaios_rbNao = New System.Windows.Forms.RadioButton()
        Me.ensaios_rbSim = New System.Windows.Forms.RadioButton()
        Me.ensaios_cbPeriodo = New System.Windows.Forms.ComboBox()
        Me.gbCaixa = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.caixa_txtTipo = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.caixa_txtQtde = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.caixa_txtTamanho = New System.Windows.Forms.TextBox()
        Me.caixa_rbNao = New System.Windows.Forms.RadioButton()
        Me.caixa_rbSim = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAlbum.SuspendLayout()
        Me.gbPainel.SuspendLayout()
        Me.gbEnsaios.SuspendLayout()
        Me.gbCaixa.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(716, 579)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 13)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Dê um duplo click para editar um registro!"
        '
        'txtSigla
        '
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSigla.Location = New System.Drawing.Point(771, 43)
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(76, 20)
        Me.txtSigla.TabIndex = 2
        Me.txtSigla.Tag = "SIGLA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(732, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Sigla:"
        '
        'btnRemoveFiltro
        '
        Me.btnRemoveFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveFiltro.Image = CType(resources.GetObject("btnRemoveFiltro.Image"), System.Drawing.Image)
        Me.btnRemoveFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveFiltro.Location = New System.Drawing.Point(570, 372)
        Me.btnRemoveFiltro.Name = "btnRemoveFiltro"
        Me.btnRemoveFiltro.Size = New System.Drawing.Size(75, 30)
        Me.btnRemoveFiltro.TabIndex = 12
        Me.btnRemoveFiltro.Text = "     Limpar"
        Me.btnRemoveFiltro.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(150, 584)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Inativo"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(136, 582)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(29, 584)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Legenda:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(102, 584)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Ativo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(85, 582)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(331, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 13)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Filtro por Produto ou Sigla:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(491, 372)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 30)
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "   Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(331, 382)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(154, 20)
        Me.txtFiltro.TabIndex = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(250, 372)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "   Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcluir.Location = New System.Drawing.Point(175, 372)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 30)
        Me.btnExcluir.TabIndex = 8
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Enabled = False
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlterar.Location = New System.Drawing.Point(100, 372)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 30)
        Me.btnAlterar.TabIndex = 7
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(25, 408)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(901, 168)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = CType(resources.GetObject("btnIncluir.Image"), System.Drawing.Image)
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnIncluir.Location = New System.Drawing.Point(25, 372)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(75, 30)
        Me.btnIncluir.TabIndex = 6
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label14.Location = New System.Drawing.Point(319, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(219, 13)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "Quando inativa, não é listado para utilização."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(263, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Ativo:"
        '
        'ckboxAtivo
        '
        Me.ckboxAtivo.AutoSize = True
        Me.ckboxAtivo.BackColor = System.Drawing.Color.Transparent
        Me.ckboxAtivo.Location = New System.Drawing.Point(303, 20)
        Me.ckboxAtivo.Name = "ckboxAtivo"
        Me.ckboxAtivo.Size = New System.Drawing.Size(15, 14)
        Me.ckboxAtivo.TabIndex = 5
        Me.ckboxAtivo.Tag = "ATIVO"
        Me.ckboxAtivo.UseVisualStyleBackColor = False
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(25, 253)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(901, 92)
        Me.txtDescricao.TabIndex = 4
        Me.txtDescricao.Tag = "DESCRIÇÃO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(25, 237)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Descrição:"
        '
        'txtProduto
        '
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(78, 43)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(648, 20)
        Me.txtProduto.TabIndex = 1
        Me.txtProduto.Tag = "PRODUTO"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(78, 17)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(179, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.Tag = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(25, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Produto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "ID:"
        '
        'txtValor
        '
        Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Location = New System.Drawing.Point(78, 69)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(150, 20)
        Me.txtValor.TabIndex = 3
        Me.txtValor.Tag = "VALOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(25, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Valor:"
        '
        'gbAlbum
        '
        Me.gbAlbum.Controls.Add(Me.Label15)
        Me.gbAlbum.Controls.Add(Me.album_txtTipo)
        Me.gbAlbum.Controls.Add(Me.Label13)
        Me.gbAlbum.Controls.Add(Me.album_txtFolhas)
        Me.gbAlbum.Controls.Add(Me.Label8)
        Me.gbAlbum.Controls.Add(Me.album_txtTamanho)
        Me.gbAlbum.Controls.Add(Me.album_rbNao)
        Me.gbAlbum.Controls.Add(Me.album_rbSim)
        Me.gbAlbum.Location = New System.Drawing.Point(25, 97)
        Me.gbAlbum.Name = "gbAlbum"
        Me.gbAlbum.Size = New System.Drawing.Size(200, 126)
        Me.gbAlbum.TabIndex = 122
        Me.gbAlbum.TabStop = False
        Me.gbAlbum.Text = "Álbum"
        '
        'album_rbSim
        '
        Me.album_rbSim.AutoSize = True
        Me.album_rbSim.Location = New System.Drawing.Point(18, 19)
        Me.album_rbSim.Name = "album_rbSim"
        Me.album_rbSim.Size = New System.Drawing.Size(44, 17)
        Me.album_rbSim.TabIndex = 122
        Me.album_rbSim.Tag = "Álbum SIM"
        Me.album_rbSim.Text = "SIM"
        Me.album_rbSim.UseVisualStyleBackColor = True
        '
        'album_rbNao
        '
        Me.album_rbNao.AutoSize = True
        Me.album_rbNao.Checked = True
        Me.album_rbNao.Location = New System.Drawing.Point(68, 19)
        Me.album_rbNao.Name = "album_rbNao"
        Me.album_rbNao.Size = New System.Drawing.Size(48, 17)
        Me.album_rbNao.TabIndex = 123
        Me.album_rbNao.TabStop = True
        Me.album_rbNao.Tag = "Álbum NÃO"
        Me.album_rbNao.Text = "NÃO"
        Me.album_rbNao.UseVisualStyleBackColor = True
        '
        'album_txtTamanho
        '
        Me.album_txtTamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.album_txtTamanho.Enabled = False
        Me.album_txtTamanho.Location = New System.Drawing.Point(76, 69)
        Me.album_txtTamanho.Name = "album_txtTamanho"
        Me.album_txtTamanho.Size = New System.Drawing.Size(96, 20)
        Me.album_txtTamanho.TabIndex = 124
        Me.album_txtTamanho.Tag = "Álbum TAMANHO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(15, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "Tamanho:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(19, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Folhas:"
        '
        'album_txtFolhas
        '
        Me.album_txtFolhas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.album_txtFolhas.Enabled = False
        Me.album_txtFolhas.Location = New System.Drawing.Point(76, 43)
        Me.album_txtFolhas.Name = "album_txtFolhas"
        Me.album_txtFolhas.Size = New System.Drawing.Size(96, 20)
        Me.album_txtFolhas.TabIndex = 126
        Me.album_txtFolhas.Tag = "Álbum FOLHAS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(15, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "Tipo:"
        '
        'album_txtTipo
        '
        Me.album_txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.album_txtTipo.Enabled = False
        Me.album_txtTipo.Location = New System.Drawing.Point(76, 95)
        Me.album_txtTipo.Name = "album_txtTipo"
        Me.album_txtTipo.Size = New System.Drawing.Size(96, 20)
        Me.album_txtTipo.TabIndex = 128
        Me.album_txtTipo.Tag = "Álbum TIPO"
        '
        'gbPainel
        '
        Me.gbPainel.Controls.Add(Me.Label16)
        Me.gbPainel.Controls.Add(Me.painel_txtMoldura)
        Me.gbPainel.Controls.Add(Me.Label17)
        Me.gbPainel.Controls.Add(Me.painel_txtQtde)
        Me.gbPainel.Controls.Add(Me.Label18)
        Me.gbPainel.Controls.Add(Me.painel_txtTamanho)
        Me.gbPainel.Controls.Add(Me.painel_rbNao)
        Me.gbPainel.Controls.Add(Me.painel_rbSim)
        Me.gbPainel.Location = New System.Drawing.Point(231, 97)
        Me.gbPainel.Name = "gbPainel"
        Me.gbPainel.Size = New System.Drawing.Size(200, 126)
        Me.gbPainel.TabIndex = 130
        Me.gbPainel.TabStop = False
        Me.gbPainel.Text = "Painel"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(15, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 129
        Me.Label16.Text = "Moldura:"
        '
        'painel_txtMoldura
        '
        Me.painel_txtMoldura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.painel_txtMoldura.Enabled = False
        Me.painel_txtMoldura.Location = New System.Drawing.Point(76, 95)
        Me.painel_txtMoldura.Name = "painel_txtMoldura"
        Me.painel_txtMoldura.Size = New System.Drawing.Size(96, 20)
        Me.painel_txtMoldura.TabIndex = 128
        Me.painel_txtMoldura.Tag = "Painel MOLDURA"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(19, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 127
        Me.Label17.Text = "Qtdade:"
        '
        'painel_txtQtde
        '
        Me.painel_txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.painel_txtQtde.Enabled = False
        Me.painel_txtQtde.Location = New System.Drawing.Point(76, 43)
        Me.painel_txtQtde.Name = "painel_txtQtde"
        Me.painel_txtQtde.Size = New System.Drawing.Size(96, 20)
        Me.painel_txtQtde.TabIndex = 126
        Me.painel_txtQtde.Tag = "Painel QUANTIDADE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(15, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Tamanho:"
        '
        'painel_txtTamanho
        '
        Me.painel_txtTamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.painel_txtTamanho.Enabled = False
        Me.painel_txtTamanho.Location = New System.Drawing.Point(76, 69)
        Me.painel_txtTamanho.Name = "painel_txtTamanho"
        Me.painel_txtTamanho.Size = New System.Drawing.Size(96, 20)
        Me.painel_txtTamanho.TabIndex = 124
        Me.painel_txtTamanho.Tag = "Painel TAMANHO"
        '
        'painel_rbNao
        '
        Me.painel_rbNao.AutoSize = True
        Me.painel_rbNao.Checked = True
        Me.painel_rbNao.Location = New System.Drawing.Point(68, 19)
        Me.painel_rbNao.Name = "painel_rbNao"
        Me.painel_rbNao.Size = New System.Drawing.Size(48, 17)
        Me.painel_rbNao.TabIndex = 123
        Me.painel_rbNao.TabStop = True
        Me.painel_rbNao.Tag = "Painel NÃO"
        Me.painel_rbNao.Text = "NÃO"
        Me.painel_rbNao.UseVisualStyleBackColor = True
        '
        'painel_rbSim
        '
        Me.painel_rbSim.AutoSize = True
        Me.painel_rbSim.Location = New System.Drawing.Point(18, 19)
        Me.painel_rbSim.Name = "painel_rbSim"
        Me.painel_rbSim.Size = New System.Drawing.Size(44, 17)
        Me.painel_rbSim.TabIndex = 122
        Me.painel_rbSim.Tag = "Painel SIM"
        Me.painel_rbSim.Text = "SIM"
        Me.painel_rbSim.UseVisualStyleBackColor = True
        '
        'gbEnsaios
        '
        Me.gbEnsaios.Controls.Add(Me.ensaios_cbPeriodo)
        Me.gbEnsaios.Controls.Add(Me.Label19)
        Me.gbEnsaios.Controls.Add(Me.ensaios_txtMeses)
        Me.gbEnsaios.Controls.Add(Me.Label20)
        Me.gbEnsaios.Controls.Add(Me.ensaios_txtQtdade)
        Me.gbEnsaios.Controls.Add(Me.Label21)
        Me.gbEnsaios.Controls.Add(Me.ensaios_rbNao)
        Me.gbEnsaios.Controls.Add(Me.ensaios_rbSim)
        Me.gbEnsaios.Location = New System.Drawing.Point(437, 97)
        Me.gbEnsaios.Name = "gbEnsaios"
        Me.gbEnsaios.Size = New System.Drawing.Size(200, 126)
        Me.gbEnsaios.TabIndex = 131
        Me.gbEnsaios.TabStop = False
        Me.gbEnsaios.Text = "Ensaios"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(15, 98)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 13)
        Me.Label19.TabIndex = 129
        Me.Label19.Text = "Meses:"
        '
        'ensaios_txtMeses
        '
        Me.ensaios_txtMeses.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ensaios_txtMeses.Enabled = False
        Me.ensaios_txtMeses.Location = New System.Drawing.Point(76, 95)
        Me.ensaios_txtMeses.Name = "ensaios_txtMeses"
        Me.ensaios_txtMeses.Size = New System.Drawing.Size(96, 20)
        Me.ensaios_txtMeses.TabIndex = 128
        Me.ensaios_txtMeses.Tag = "Ensaios MESES"
        Me.ensaios_txtMeses.Text = "EXEMPLO: 1 E 2"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(19, 46)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 127
        Me.Label20.Text = "Qtdade:"
        '
        'ensaios_txtQtdade
        '
        Me.ensaios_txtQtdade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ensaios_txtQtdade.Enabled = False
        Me.ensaios_txtQtdade.Location = New System.Drawing.Point(76, 43)
        Me.ensaios_txtQtdade.Name = "ensaios_txtQtdade"
        Me.ensaios_txtQtdade.Size = New System.Drawing.Size(96, 20)
        Me.ensaios_txtQtdade.TabIndex = 126
        Me.ensaios_txtQtdade.Tag = "Ensaios QUANTIDADE"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(15, 72)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 13)
        Me.Label21.TabIndex = 125
        Me.Label21.Text = "Período:"
        '
        'ensaios_rbNao
        '
        Me.ensaios_rbNao.AutoSize = True
        Me.ensaios_rbNao.Checked = True
        Me.ensaios_rbNao.Location = New System.Drawing.Point(68, 19)
        Me.ensaios_rbNao.Name = "ensaios_rbNao"
        Me.ensaios_rbNao.Size = New System.Drawing.Size(48, 17)
        Me.ensaios_rbNao.TabIndex = 123
        Me.ensaios_rbNao.TabStop = True
        Me.ensaios_rbNao.Tag = "Ensaios NÃO"
        Me.ensaios_rbNao.Text = "NÃO"
        Me.ensaios_rbNao.UseVisualStyleBackColor = True
        '
        'ensaios_rbSim
        '
        Me.ensaios_rbSim.AutoSize = True
        Me.ensaios_rbSim.Location = New System.Drawing.Point(18, 19)
        Me.ensaios_rbSim.Name = "ensaios_rbSim"
        Me.ensaios_rbSim.Size = New System.Drawing.Size(44, 17)
        Me.ensaios_rbSim.TabIndex = 122
        Me.ensaios_rbSim.Tag = "Ensaios SIM"
        Me.ensaios_rbSim.Text = "SIM"
        Me.ensaios_rbSim.UseVisualStyleBackColor = True
        '
        'ensaios_cbPeriodo
        '
        Me.ensaios_cbPeriodo.Enabled = False
        Me.ensaios_cbPeriodo.FormattingEnabled = True
        Me.ensaios_cbPeriodo.Items.AddRange(New Object() {"MENSAL", "BIMESTRAL", "TRIMESTRAL", "SEMESTRAL", "ANUAL", "OUTROS"})
        Me.ensaios_cbPeriodo.Location = New System.Drawing.Point(76, 69)
        Me.ensaios_cbPeriodo.Name = "ensaios_cbPeriodo"
        Me.ensaios_cbPeriodo.Size = New System.Drawing.Size(96, 21)
        Me.ensaios_cbPeriodo.TabIndex = 130
        Me.ensaios_cbPeriodo.Tag = "Ensaios PERÍODO"
        '
        'gbCaixa
        '
        Me.gbCaixa.Controls.Add(Me.Label22)
        Me.gbCaixa.Controls.Add(Me.caixa_txtTipo)
        Me.gbCaixa.Controls.Add(Me.Label23)
        Me.gbCaixa.Controls.Add(Me.caixa_txtQtde)
        Me.gbCaixa.Controls.Add(Me.Label24)
        Me.gbCaixa.Controls.Add(Me.caixa_txtTamanho)
        Me.gbCaixa.Controls.Add(Me.caixa_rbNao)
        Me.gbCaixa.Controls.Add(Me.caixa_rbSim)
        Me.gbCaixa.Location = New System.Drawing.Point(643, 97)
        Me.gbCaixa.Name = "gbCaixa"
        Me.gbCaixa.Size = New System.Drawing.Size(200, 126)
        Me.gbCaixa.TabIndex = 132
        Me.gbCaixa.TabStop = False
        Me.gbCaixa.Text = "Caixa"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(15, 98)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(31, 13)
        Me.Label22.TabIndex = 129
        Me.Label22.Text = "Tipo:"
        '
        'caixa_txtTipo
        '
        Me.caixa_txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.caixa_txtTipo.Enabled = False
        Me.caixa_txtTipo.Location = New System.Drawing.Point(76, 95)
        Me.caixa_txtTipo.Name = "caixa_txtTipo"
        Me.caixa_txtTipo.Size = New System.Drawing.Size(96, 20)
        Me.caixa_txtTipo.TabIndex = 128
        Me.caixa_txtTipo.Tag = "Caixa TIPO"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(19, 46)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 127
        Me.Label23.Text = "Qtdade:"
        '
        'caixa_txtQtde
        '
        Me.caixa_txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.caixa_txtQtde.Enabled = False
        Me.caixa_txtQtde.Location = New System.Drawing.Point(76, 43)
        Me.caixa_txtQtde.Name = "caixa_txtQtde"
        Me.caixa_txtQtde.Size = New System.Drawing.Size(96, 20)
        Me.caixa_txtQtde.TabIndex = 126
        Me.caixa_txtQtde.Tag = "Caixa QUANTIDADE"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(15, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(55, 13)
        Me.Label24.TabIndex = 125
        Me.Label24.Text = "Tamanho:"
        '
        'caixa_txtTamanho
        '
        Me.caixa_txtTamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.caixa_txtTamanho.Enabled = False
        Me.caixa_txtTamanho.Location = New System.Drawing.Point(76, 69)
        Me.caixa_txtTamanho.Name = "caixa_txtTamanho"
        Me.caixa_txtTamanho.Size = New System.Drawing.Size(96, 20)
        Me.caixa_txtTamanho.TabIndex = 124
        Me.caixa_txtTamanho.Tag = "Caixa TAMANHO"
        '
        'caixa_rbNao
        '
        Me.caixa_rbNao.AutoSize = True
        Me.caixa_rbNao.Checked = True
        Me.caixa_rbNao.Location = New System.Drawing.Point(68, 19)
        Me.caixa_rbNao.Name = "caixa_rbNao"
        Me.caixa_rbNao.Size = New System.Drawing.Size(48, 17)
        Me.caixa_rbNao.TabIndex = 123
        Me.caixa_rbNao.TabStop = True
        Me.caixa_rbNao.Tag = "Caixa NÃO"
        Me.caixa_rbNao.Text = "NÃO"
        Me.caixa_rbNao.UseVisualStyleBackColor = True
        '
        'caixa_rbSim
        '
        Me.caixa_rbSim.AutoSize = True
        Me.caixa_rbSim.Location = New System.Drawing.Point(18, 19)
        Me.caixa_rbSim.Name = "caixa_rbSim"
        Me.caixa_rbSim.Size = New System.Drawing.Size(44, 17)
        Me.caixa_rbSim.TabIndex = 122
        Me.caixa_rbSim.Tag = "Caixa SIM"
        Me.caixa_rbSim.Text = "SIM"
        Me.caixa_rbSim.UseVisualStyleBackColor = True
        '
        'frmCadProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(952, 615)
        Me.Controls.Add(Me.gbCaixa)
        Me.Controls.Add(Me.gbEnsaios)
        Me.Controls.Add(Me.gbPainel)
        Me.Controls.Add(Me.gbAlbum)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label7)
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
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ckboxAtivo)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCadProdutos"
        Me.Tag = ".: Cadastro de Produtlos :."
        Me.Text = ".: Cadastro de Produtlos :."
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAlbum.ResumeLayout(False)
        Me.gbAlbum.PerformLayout()
        Me.gbPainel.ResumeLayout(False)
        Me.gbPainel.PerformLayout()
        Me.gbEnsaios.ResumeLayout(False)
        Me.gbEnsaios.PerformLayout()
        Me.gbCaixa.ResumeLayout(False)
        Me.gbCaixa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtSigla As TextBox
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
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gbAlbum As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents album_txtTipo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents album_txtFolhas As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents album_txtTamanho As TextBox
    Friend WithEvents album_rbNao As RadioButton
    Friend WithEvents album_rbSim As RadioButton
    Friend WithEvents gbPainel As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents painel_txtMoldura As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents painel_txtQtde As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents painel_txtTamanho As TextBox
    Friend WithEvents painel_rbNao As RadioButton
    Friend WithEvents painel_rbSim As RadioButton
    Friend WithEvents gbEnsaios As GroupBox
    Friend WithEvents ensaios_cbPeriodo As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ensaios_txtMeses As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ensaios_txtQtdade As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents ensaios_rbNao As RadioButton
    Friend WithEvents ensaios_rbSim As RadioButton
    Friend WithEvents gbCaixa As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents caixa_txtTipo As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents caixa_txtQtde As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents caixa_txtTamanho As TextBox
    Friend WithEvents caixa_rbNao As RadioButton
    Friend WithEvents caixa_rbSim As RadioButton
End Class
