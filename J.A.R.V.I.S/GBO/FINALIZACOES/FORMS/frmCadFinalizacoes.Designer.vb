<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadFinalizacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadFinalizacoes))
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ckboxEfetivo = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ckboxPassivelEfet = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbFilaDestino = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ckboxGerarNovoCaso = New System.Windows.Forms.CheckBox()
        Me.cbAging = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.listviewFilasPorFinalizacao = New System.Windows.Forms.ListView()
        Me.cbFila = New System.Windows.Forms.ComboBox()
        Me.txtFinalizacao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckboxAtivo = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbFiltrofila = New System.Windows.Forms.ComboBox()
        Me.btnRemoveFiltro = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Image = CType(resources.GetObject("Label29.Image"), System.Drawing.Image)
        Me.Label29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label29.Location = New System.Drawing.Point(31, 164)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(344, 22)
        Me.Label29.TabIndex = 183
        Me.Label29.Text = "Roteamento:"
        '
        'ckboxEfetivo
        '
        Me.ckboxEfetivo.AutoSize = True
        Me.ckboxEfetivo.BackColor = System.Drawing.Color.Transparent
        Me.ckboxEfetivo.Location = New System.Drawing.Point(133, 142)
        Me.ckboxEfetivo.Name = "ckboxEfetivo"
        Me.ckboxEfetivo.Size = New System.Drawing.Size(15, 14)
        Me.ckboxEfetivo.TabIndex = 4
        Me.ckboxEfetivo.Tag = "EFETIVO"
        Me.ckboxEfetivo.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(31, 142)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 173
        Me.Label24.Text = "Efetivo:"
        '
        'ckboxPassivelEfet
        '
        Me.ckboxPassivelEfet.AutoSize = True
        Me.ckboxPassivelEfet.BackColor = System.Drawing.Color.Transparent
        Me.ckboxPassivelEfet.Location = New System.Drawing.Point(133, 120)
        Me.ckboxPassivelEfet.Name = "ckboxPassivelEfet"
        Me.ckboxPassivelEfet.Size = New System.Drawing.Size(15, 14)
        Me.ckboxPassivelEfet.TabIndex = 3
        Me.ckboxPassivelEfet.Tag = "PASSÍVEL DE EFETIVIDADE"
        Me.ckboxPassivelEfet.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(31, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 13)
        Me.Label23.TabIndex = 171
        Me.Label23.Text = "Passível Efetiv.:"
        '
        'cbFilaDestino
        '
        Me.cbFilaDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbFilaDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFilaDestino.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbFilaDestino.FormattingEnabled = True
        Me.cbFilaDestino.Location = New System.Drawing.Point(133, 238)
        Me.cbFilaDestino.Name = "cbFilaDestino"
        Me.cbFilaDestino.Size = New System.Drawing.Size(258, 21)
        Me.cbFilaDestino.TabIndex = 7
        Me.cbFilaDestino.Tag = "FILA DESTINO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(31, 243)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 167
        Me.Label17.Text = "Fila Destino:"
        '
        'ckboxGerarNovoCaso
        '
        Me.ckboxGerarNovoCaso.AutoSize = True
        Me.ckboxGerarNovoCaso.BackColor = System.Drawing.Color.Transparent
        Me.ckboxGerarNovoCaso.Location = New System.Drawing.Point(133, 190)
        Me.ckboxGerarNovoCaso.Name = "ckboxGerarNovoCaso"
        Me.ckboxGerarNovoCaso.Size = New System.Drawing.Size(15, 14)
        Me.ckboxGerarNovoCaso.TabIndex = 5
        Me.ckboxGerarNovoCaso.Tag = "GERAR NOVO CASO"
        Me.ckboxGerarNovoCaso.UseVisualStyleBackColor = False
        '
        'cbAging
        '
        Me.cbAging.FormattingEnabled = True
        Me.cbAging.Items.AddRange(New Object() {"", "Hoje", "Amanhã", "Depois de amanhã", "1 semana", "15 dias", "1 mês", "2 meses", "3 meses", "6 meses", "1 ano", "2 anos"})
        Me.cbAging.Location = New System.Drawing.Point(133, 211)
        Me.cbAging.Name = "cbAging"
        Me.cbAging.Size = New System.Drawing.Size(258, 21)
        Me.cbAging.TabIndex = 6
        Me.cbAging.Tag = "AGING NOVO CASO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(31, 219)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "Aging novo caso:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(31, 191)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 160
        Me.Label16.Text = "Gerar Novo Caso:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(31, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 159
        Me.Label8.Text = "Fila:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(31, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(347, 22)
        Me.Label11.TabIndex = 158
        Me.Label11.Text = "Dados da finalização:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(394, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(338, 22)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "Filas vinculadas:"
        '
        'listviewFilasPorFinalizacao
        '
        Me.listviewFilasPorFinalizacao.HideSelection = False
        Me.listviewFilasPorFinalizacao.Location = New System.Drawing.Point(397, 47)
        Me.listviewFilasPorFinalizacao.Name = "listviewFilasPorFinalizacao"
        Me.listviewFilasPorFinalizacao.Size = New System.Drawing.Size(335, 243)
        Me.listviewFilasPorFinalizacao.TabIndex = 156
        Me.listviewFilasPorFinalizacao.UseCompatibleStateImageBehavior = False
        '
        'cbFila
        '
        Me.cbFila.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbFila.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFila.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbFila.FormattingEnabled = True
        Me.cbFila.Location = New System.Drawing.Point(133, 93)
        Me.cbFila.Name = "cbFila"
        Me.cbFila.Size = New System.Drawing.Size(258, 21)
        Me.cbFila.TabIndex = 2
        Me.cbFila.Tag = "FILA"
        '
        'txtFinalizacao
        '
        Me.txtFinalizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFinalizacao.Location = New System.Drawing.Point(133, 67)
        Me.txtFinalizacao.Name = "txtFinalizacao"
        Me.txtFinalizacao.Size = New System.Drawing.Size(258, 20)
        Me.txtFinalizacao.TabIndex = 1
        Me.txtFinalizacao.Tag = "FINALIZAÇÃO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(31, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "Ativo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(31, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Finalização:"
        '
        'ckboxAtivo
        '
        Me.ckboxAtivo.AutoSize = True
        Me.ckboxAtivo.BackColor = System.Drawing.Color.Transparent
        Me.ckboxAtivo.Location = New System.Drawing.Point(133, 47)
        Me.ckboxAtivo.Name = "ckboxAtivo"
        Me.ckboxAtivo.Size = New System.Drawing.Size(15, 14)
        Me.ckboxAtivo.TabIndex = 0
        Me.ckboxAtivo.Tag = "ATIVO"
        Me.ckboxAtivo.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(403, 303)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(327, 52)
        Me.Label20.TabIndex = 206
        Me.Label20.Text = resources.GetString("Label20.Text")
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(19, 372)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(701, 22)
        Me.Label19.TabIndex = 205
        Me.Label19.Text = "Filtros de Busca:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(25, 408)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 204
        Me.Label14.Text = "Fila:"
        '
        'cbFiltrofila
        '
        Me.cbFiltrofila.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbFiltrofila.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFiltrofila.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbFiltrofila.FormattingEnabled = True
        Me.cbFiltrofila.Location = New System.Drawing.Point(93, 405)
        Me.cbFiltrofila.Name = "cbFiltrofila"
        Me.cbFiltrofila.Size = New System.Drawing.Size(489, 21)
        Me.cbFiltrofila.TabIndex = 12
        Me.cbFiltrofila.Tag = "FILA BUSCA"
        '
        'btnRemoveFiltro
        '
        Me.btnRemoveFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveFiltro.Image = CType(resources.GetObject("btnRemoveFiltro.Image"), System.Drawing.Image)
        Me.btnRemoveFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveFiltro.Location = New System.Drawing.Point(662, 405)
        Me.btnRemoveFiltro.Name = "btnRemoveFiltro"
        Me.btnRemoveFiltro.Size = New System.Drawing.Size(70, 46)
        Me.btnRemoveFiltro.TabIndex = 15
        Me.btnRemoveFiltro.Text = "     Limpar"
        Me.btnRemoveFiltro.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Gray
        Me.Label12.Location = New System.Drawing.Point(484, 716)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 13)
        Me.Label12.TabIndex = 202
        Me.Label12.Text = "(Duplo clique para editar)"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(162, 716)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 201
        Me.Label7.Text = "Inativo"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(139, 715)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox2.TabIndex = 200
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(23, 716)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 199
        Me.Label3.Text = "Legenda:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(103, 716)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 198
        Me.Label9.Text = "Ativo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(80, 715)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox1.TabIndex = 197
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(25, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 196
        Me.Label6.Text = "Finalização:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(588, 405)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(70, 46)
        Me.btnFiltrar.TabIndex = 14
        Me.btnFiltrar.Text = "   Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(93, 431)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(489, 20)
        Me.txtFiltro.TabIndex = 13
        Me.txtFiltro.Tag = "FINALIZAÇÃO BUSCA"
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(300, 274)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(83, 30)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "   Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcluir.Location = New System.Drawing.Point(213, 274)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(83, 30)
        Me.btnExcluir.TabIndex = 10
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Enabled = False
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlterar.Location = New System.Drawing.Point(126, 274)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(83, 30)
        Me.btnAlterar.TabIndex = 9
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(22, 457)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(710, 254)
        Me.ListView1.TabIndex = 194
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = CType(resources.GetObject("btnIncluir.Image"), System.Drawing.Image)
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnIncluir.Location = New System.Drawing.Point(39, 274)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(83, 30)
        Me.btnIncluir.TabIndex = 8
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(647, 713)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(85, 20)
        Me.txtID.TabIndex = 184
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(615, 716)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "ID:"
        '
        'frmCadFinalizacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(752, 749)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbFiltrofila)
        Me.Controls.Add(Me.btnRemoveFiltro)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.ckboxEfetivo)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.ckboxPassivelEfet)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cbFilaDestino)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ckboxGerarNovoCaso)
        Me.Controls.Add(Me.cbAging)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.listviewFilasPorFinalizacao)
        Me.Controls.Add(Me.cbFila)
        Me.Controls.Add(Me.txtFinalizacao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ckboxAtivo)
        Me.Name = "frmCadFinalizacoes"
        Me.Tag = ".: Cadastro de Finalizações :."
        Me.Text = ".: Cadastro de Finalizações :."
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label29 As Label
    Friend WithEvents ckboxEfetivo As CheckBox
    Friend WithEvents Label24 As Label
    Friend WithEvents ckboxPassivelEfet As CheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cbFilaDestino As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ckboxGerarNovoCaso As CheckBox
    Friend WithEvents cbAging As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents listviewFilasPorFinalizacao As ListView
    Friend WithEvents cbFila As ComboBox
    Friend WithEvents txtFinalizacao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ckboxAtivo As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbFiltrofila As ComboBox
    Friend WithEvents btnRemoveFiltro As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnIncluir As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
End Class
