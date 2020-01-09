<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadSubFinalizacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadSubFinalizacao))
        Me.ckboxEfetivo = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ckboxPassivelEfet = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ckboxRotearFinalizado = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ckboxGerarNovoCaso = New System.Windows.Forms.CheckBox()
        Me.cbFilaDestino = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbAging = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbFila = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.cbFinalizacao = New System.Windows.Forms.ComboBox()
        Me.txtSubFinalizacao = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckboxAtivo = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbFiltrofila = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnRemoveFiltro = New System.Windows.Forms.Button()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.listviewFilasPorFinalizacao = New System.Windows.Forms.ListView()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ckboxEfetivo
        '
        Me.ckboxEfetivo.AutoSize = True
        Me.ckboxEfetivo.BackColor = System.Drawing.Color.Transparent
        Me.ckboxEfetivo.Location = New System.Drawing.Point(118, 137)
        Me.ckboxEfetivo.Name = "ckboxEfetivo"
        Me.ckboxEfetivo.Size = New System.Drawing.Size(15, 14)
        Me.ckboxEfetivo.TabIndex = 6
        Me.ckboxEfetivo.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(16, 137)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 190
        Me.Label24.Text = "Efetivo:"
        '
        'ckboxPassivelEfet
        '
        Me.ckboxPassivelEfet.AutoSize = True
        Me.ckboxPassivelEfet.BackColor = System.Drawing.Color.Transparent
        Me.ckboxPassivelEfet.Location = New System.Drawing.Point(118, 117)
        Me.ckboxPassivelEfet.Name = "ckboxPassivelEfet"
        Me.ckboxPassivelEfet.Size = New System.Drawing.Size(15, 14)
        Me.ckboxPassivelEfet.TabIndex = 5
        Me.ckboxPassivelEfet.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(16, 117)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 13)
        Me.Label23.TabIndex = 188
        Me.Label23.Text = "Passível Efetiv.:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(16, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(392, 22)
        Me.Label6.TabIndex = 187
        Me.Label6.Text = "Roteamento:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label22.Location = New System.Drawing.Point(137, 271)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(205, 13)
        Me.Label22.TabIndex = 186
        Me.Label22.Text = "(Não será encaminhado para os analistas)"
        '
        'ckboxRotearFinalizado
        '
        Me.ckboxRotearFinalizado.AutoSize = True
        Me.ckboxRotearFinalizado.BackColor = System.Drawing.Color.Transparent
        Me.ckboxRotearFinalizado.Location = New System.Drawing.Point(118, 271)
        Me.ckboxRotearFinalizado.Name = "ckboxRotearFinalizado"
        Me.ckboxRotearFinalizado.Size = New System.Drawing.Size(15, 14)
        Me.ckboxRotearFinalizado.TabIndex = 10
        Me.ckboxRotearFinalizado.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(16, 271)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 184
        Me.Label15.Text = "Rotear Finalizado:"
        '
        'ckboxGerarNovoCaso
        '
        Me.ckboxGerarNovoCaso.AutoSize = True
        Me.ckboxGerarNovoCaso.BackColor = System.Drawing.Color.Transparent
        Me.ckboxGerarNovoCaso.Location = New System.Drawing.Point(118, 194)
        Me.ckboxGerarNovoCaso.Name = "ckboxGerarNovoCaso"
        Me.ckboxGerarNovoCaso.Size = New System.Drawing.Size(15, 14)
        Me.ckboxGerarNovoCaso.TabIndex = 7
        Me.ckboxGerarNovoCaso.UseVisualStyleBackColor = False
        '
        'cbFilaDestino
        '
        Me.cbFilaDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbFilaDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFilaDestino.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbFilaDestino.FormattingEnabled = True
        Me.cbFilaDestino.Location = New System.Drawing.Point(118, 241)
        Me.cbFilaDestino.Name = "cbFilaDestino"
        Me.cbFilaDestino.Size = New System.Drawing.Size(290, 21)
        Me.cbFilaDestino.TabIndex = 9
        Me.cbFilaDestino.Tag = "Fila"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(16, 244)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 182
        Me.Label13.Text = "Fila Destino:"
        '
        'cbAging
        '
        Me.cbAging.FormattingEnabled = True
        Me.cbAging.Items.AddRange(New Object() {"", "Hoje", "Amanhã", "Depois de amanhã", "1 semana", "15 dias", "1 mês", "2 meses", "3 meses", "6 meses", "1 ano", "2 anos"})
        Me.cbAging.Location = New System.Drawing.Point(118, 214)
        Me.cbAging.Name = "cbAging"
        Me.cbAging.Size = New System.Drawing.Size(290, 21)
        Me.cbAging.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(16, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 175
        Me.Label11.Text = "Aging novo caso:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(16, 194)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 13)
        Me.Label16.TabIndex = 174
        Me.Label16.Text = "Gera Novo Caso:"
        '
        'cbFila
        '
        Me.cbFila.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbFila.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFila.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbFila.FormattingEnabled = True
        Me.cbFila.Location = New System.Drawing.Point(118, 63)
        Me.cbFila.Name = "cbFila"
        Me.cbFila.Size = New System.Drawing.Size(290, 21)
        Me.cbFila.TabIndex = 2
        Me.cbFila.Tag = "Fila"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(16, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 173
        Me.Label10.Text = "Fila:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(284, 293)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "   Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcluir.Location = New System.Drawing.Point(203, 293)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 30)
        Me.btnExcluir.TabIndex = 13
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Enabled = False
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAlterar.Location = New System.Drawing.Point(122, 293)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 30)
        Me.btnAlterar.TabIndex = 12
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = CType(resources.GetObject("btnIncluir.Image"), System.Drawing.Image)
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnIncluir.Location = New System.Drawing.Point(41, 293)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(75, 30)
        Me.btnIncluir.TabIndex = 11
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'cbFinalizacao
        '
        Me.cbFinalizacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbFinalizacao.FormattingEnabled = True
        Me.cbFinalizacao.Location = New System.Drawing.Point(118, 90)
        Me.cbFinalizacao.Name = "cbFinalizacao"
        Me.cbFinalizacao.Size = New System.Drawing.Size(290, 21)
        Me.cbFinalizacao.TabIndex = 3
        Me.cbFinalizacao.Tag = "Finalização"
        '
        'txtSubFinalizacao
        '
        Me.txtSubFinalizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubFinalizacao.Location = New System.Drawing.Point(118, 37)
        Me.txtSubFinalizacao.Name = "txtSubFinalizacao"
        Me.txtSubFinalizacao.Size = New System.Drawing.Size(290, 20)
        Me.txtSubFinalizacao.TabIndex = 1
        Me.txtSubFinalizacao.Tag = "SubFinalização"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(16, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 172
        Me.Label8.Text = "Finalização:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 171
        Me.Label5.Text = "Ativo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(16, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "SubFinalização:"
        '
        'ckboxAtivo
        '
        Me.ckboxAtivo.AutoSize = True
        Me.ckboxAtivo.BackColor = System.Drawing.Color.Transparent
        Me.ckboxAtivo.Location = New System.Drawing.Point(118, 17)
        Me.ckboxAtivo.Name = "ckboxAtivo"
        Me.ckboxAtivo.Size = New System.Drawing.Size(15, 14)
        Me.ckboxAtivo.TabIndex = 0
        Me.ckboxAtivo.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Location = New System.Drawing.Point(16, 326)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(400, 22)
        Me.Label19.TabIndex = 192
        Me.Label19.Text = "Filtros de Busca:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(16, 359)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 13)
        Me.Label17.TabIndex = 194
        Me.Label17.Text = "Fila:"
        '
        'cbFiltrofila
        '
        Me.cbFiltrofila.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbFiltrofila.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFiltrofila.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbFiltrofila.FormattingEnabled = True
        Me.cbFiltrofila.Location = New System.Drawing.Point(118, 356)
        Me.cbFiltrofila.Name = "cbFiltrofila"
        Me.cbFiltrofila.Size = New System.Drawing.Size(290, 21)
        Me.cbFiltrofila.TabIndex = 15
        Me.cbFiltrofila.Tag = "Fila"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(16, 386)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 13)
        Me.Label20.TabIndex = 196
        Me.Label20.Text = "SubFinalização:"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(118, 383)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(290, 20)
        Me.txtFiltro.TabIndex = 16
        '
        'btnRemoveFiltro
        '
        Me.btnRemoveFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveFiltro.Image = CType(resources.GetObject("btnRemoveFiltro.Image"), System.Drawing.Image)
        Me.btnRemoveFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveFiltro.Location = New System.Drawing.Point(496, 356)
        Me.btnRemoveFiltro.Name = "btnRemoveFiltro"
        Me.btnRemoveFiltro.Size = New System.Drawing.Size(70, 47)
        Me.btnRemoveFiltro.TabIndex = 18
        Me.btnRemoveFiltro.Text = "     Limpar"
        Me.btnRemoveFiltro.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(420, 356)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(70, 47)
        Me.btnFiltrar.TabIndex = 17
        Me.btnFiltrar.Text = "   Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(11, 409)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(828, 294)
        Me.ListView1.TabIndex = 199
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(153, 712)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Inativo"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(130, 711)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox2.TabIndex = 205
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 711)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 204
        Me.Label3.Text = "Legenda:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(94, 712)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 203
        Me.Label9.Text = "Ativo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(71, 711)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox1.TabIndex = 202
        Me.PictureBox1.TabStop = False
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(713, 708)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(126, 20)
        Me.txtID.TabIndex = 200
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(686, 711)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 201
        Me.Label1.Text = "ID:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(555, 711)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 207
        Me.Label4.Text = "(Duplo clique para editar)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(467, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(349, 52)
        Me.Label14.TabIndex = 210
        Me.Label14.Text = resources.GetString("Label14.Text")
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Location = New System.Drawing.Point(444, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(338, 22)
        Me.Label18.TabIndex = 209
        Me.Label18.Text = "Finalizações vinculadas:"
        '
        'listviewFilasPorFinalizacao
        '
        Me.listviewFilasPorFinalizacao.HideSelection = False
        Me.listviewFilasPorFinalizacao.Location = New System.Drawing.Point(447, 37)
        Me.listviewFilasPorFinalizacao.Name = "listviewFilasPorFinalizacao"
        Me.listviewFilasPorFinalizacao.Size = New System.Drawing.Size(392, 225)
        Me.listviewFilasPorFinalizacao.TabIndex = 208
        Me.listviewFilasPorFinalizacao.UseCompatibleStateImageBehavior = False
        '
        'frmCadSubFinalizacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(851, 749)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.listviewFilasPorFinalizacao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnRemoveFiltro)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cbFiltrofila)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.ckboxEfetivo)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.ckboxPassivelEfet)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.ckboxRotearFinalizado)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ckboxGerarNovoCaso)
        Me.Controls.Add(Me.cbFilaDestino)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbAging)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cbFila)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.cbFinalizacao)
        Me.Controls.Add(Me.txtSubFinalizacao)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ckboxAtivo)
        Me.Name = "frmCadSubFinalizacao"
        Me.Tag = ".: Cadastro de SubFinalizações :."
        Me.Text = ".: Cadastro de SubFinalizações :."
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ckboxEfetivo As CheckBox
    Friend WithEvents Label24 As Label
    Friend WithEvents ckboxPassivelEfet As CheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents ckboxRotearFinalizado As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ckboxGerarNovoCaso As CheckBox
    Friend WithEvents cbFilaDestino As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbAging As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cbFila As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnIncluir As Button
    Friend WithEvents cbFinalizacao As ComboBox
    Friend WithEvents txtSubFinalizacao As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ckboxAtivo As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cbFiltrofila As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents btnRemoveFiltro As Button
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents listviewFilasPorFinalizacao As ListView
End Class
