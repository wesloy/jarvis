<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCaixa = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmContratos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEstoques = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFilaTrabalho = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContorleDeCaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentroDeCustoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FilasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalizaçõesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubfinalizaçõesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRelatorios = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasPorPeríodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasPorProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasPorMédiaDeIdadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasPorLocalidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSenha = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmLogoff = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusBar = New System.Windows.Forms.StatusStrip()
        Me.stb_lb1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stb_lb2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stb_lb3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PainelFormularios = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.statusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmHome, Me.tsmCaixa, Me.tsmContratos, Me.tsmEstoques, Me.tsmFilaTrabalho, Me.tsmCadastro, Me.tsmRelatorios, Me.tsmSenha, Me.tsmLogoff, Me.tsmSair})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(954, 37)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmHome
        '
        Me.tsmHome.Image = CType(resources.GetObject("tsmHome.Image"), System.Drawing.Image)
        Me.tsmHome.Name = "tsmHome"
        Me.tsmHome.Size = New System.Drawing.Size(66, 33)
        Me.tsmHome.Text = "Início"
        '
        'tsmCaixa
        '
        Me.tsmCaixa.Enabled = False
        Me.tsmCaixa.Image = CType(resources.GetObject("tsmCaixa.Image"), System.Drawing.Image)
        Me.tsmCaixa.Name = "tsmCaixa"
        Me.tsmCaixa.Size = New System.Drawing.Size(67, 33)
        Me.tsmCaixa.Text = "Cai&xa"
        '
        'tsmContratos
        '
        Me.tsmContratos.Enabled = False
        Me.tsmContratos.Image = CType(resources.GetObject("tsmContratos.Image"), System.Drawing.Image)
        Me.tsmContratos.Name = "tsmContratos"
        Me.tsmContratos.Size = New System.Drawing.Size(93, 33)
        Me.tsmContratos.Text = "Con&tratos"
        '
        'tsmEstoques
        '
        Me.tsmEstoques.Enabled = False
        Me.tsmEstoques.Image = CType(resources.GetObject("tsmEstoques.Image"), System.Drawing.Image)
        Me.tsmEstoques.Name = "tsmEstoques"
        Me.tsmEstoques.Size = New System.Drawing.Size(89, 33)
        Me.tsmEstoques.Text = "&Estoques"
        '
        'tsmFilaTrabalho
        '
        Me.tsmFilaTrabalho.Enabled = False
        Me.tsmFilaTrabalho.Image = CType(resources.GetObject("tsmFilaTrabalho.Image"), System.Drawing.Image)
        Me.tsmFilaTrabalho.Name = "tsmFilaTrabalho"
        Me.tsmFilaTrabalho.Size = New System.Drawing.Size(129, 33)
        Me.tsmFilaTrabalho.Text = "&Fila de Trabalho"
        '
        'tsmCadastro
        '
        Me.tsmCadastro.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.tsmCadastro.BackColor = System.Drawing.Color.Transparent
        Me.tsmCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsmCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContorleDeCaixaToolStripMenuItem, Me.ToolStripSeparator1, Me.ClientesToolStripMenuItem, Me.ContratosToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.ToolStripSeparator2, Me.FilasToolStripMenuItem, Me.ToolStripSeparator4, Me.UsuáriosToolStripMenuItem})
        Me.tsmCadastro.Enabled = False
        Me.tsmCadastro.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tsmCadastro.ForeColor = System.Drawing.Color.Black
        Me.tsmCadastro.Image = CType(resources.GetObject("tsmCadastro.Image"), System.Drawing.Image)
        Me.tsmCadastro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmCadastro.Name = "tsmCadastro"
        Me.tsmCadastro.Size = New System.Drawing.Size(103, 33)
        Me.tsmCadastro.Tag = "Cadastros"
        Me.tsmCadastro.Text = "&Cadastros"
        Me.tsmCadastro.ToolTipText = "Cadastros"
        '
        'ContorleDeCaixaToolStripMenuItem
        '
        Me.ContorleDeCaixaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BancosToolStripMenuItem, Me.CentroDeCustoToolStripMenuItem, Me.ReceitasToolStripMenuItem})
        Me.ContorleDeCaixaToolStripMenuItem.Image = CType(resources.GetObject("ContorleDeCaixaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContorleDeCaixaToolStripMenuItem.Name = "ContorleDeCaixaToolStripMenuItem"
        Me.ContorleDeCaixaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContorleDeCaixaToolStripMenuItem.Text = "Caixa"
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'CentroDeCustoToolStripMenuItem
        '
        Me.CentroDeCustoToolStripMenuItem.Name = "CentroDeCustoToolStripMenuItem"
        Me.CentroDeCustoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CentroDeCustoToolStripMenuItem.Text = "Centro de Custo"
        '
        'ReceitasToolStripMenuItem
        '
        Me.ReceitasToolStripMenuItem.Name = "ReceitasToolStripMenuItem"
        Me.ReceitasToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ReceitasToolStripMenuItem.Text = "Receitas / Despesas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'FilasToolStripMenuItem
        '
        Me.FilasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilasToolStripMenuItem1, Me.FinalizaçõesToolStripMenuItem1, Me.SubfinalizaçõesToolStripMenuItem1})
        Me.FilasToolStripMenuItem.Image = CType(resources.GetObject("FilasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FilasToolStripMenuItem.Name = "FilasToolStripMenuItem"
        Me.FilasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FilasToolStripMenuItem.Text = "Filas de Trabalho"
        '
        'FilasToolStripMenuItem1
        '
        Me.FilasToolStripMenuItem1.Name = "FilasToolStripMenuItem1"
        Me.FilasToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.FilasToolStripMenuItem1.Text = "Filas"
        '
        'FinalizaçõesToolStripMenuItem1
        '
        Me.FinalizaçõesToolStripMenuItem1.Name = "FinalizaçõesToolStripMenuItem1"
        Me.FinalizaçõesToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.FinalizaçõesToolStripMenuItem1.Text = "Finalizações"
        '
        'SubfinalizaçõesToolStripMenuItem1
        '
        Me.SubfinalizaçõesToolStripMenuItem1.Name = "SubfinalizaçõesToolStripMenuItem1"
        Me.SubfinalizaçõesToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.SubfinalizaçõesToolStripMenuItem1.Text = "Subfinalizações"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.Image = CType(resources.GetObject("UsuáriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'tsmRelatorios
        '
        Me.tsmRelatorios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendasPorPeríodoToolStripMenuItem, Me.VendasPorProdutoToolStripMenuItem, Me.VendasPorMédiaDeIdadeToolStripMenuItem, Me.VendasPorClienteToolStripMenuItem, Me.VendasPorLocalidadeToolStripMenuItem})
        Me.tsmRelatorios.Enabled = False
        Me.tsmRelatorios.Image = CType(resources.GetObject("tsmRelatorios.Image"), System.Drawing.Image)
        Me.tsmRelatorios.Name = "tsmRelatorios"
        Me.tsmRelatorios.Size = New System.Drawing.Size(95, 33)
        Me.tsmRelatorios.Text = "&Relatórios"
        '
        'VendasPorPeríodoToolStripMenuItem
        '
        Me.VendasPorPeríodoToolStripMenuItem.Name = "VendasPorPeríodoToolStripMenuItem"
        Me.VendasPorPeríodoToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.VendasPorPeríodoToolStripMenuItem.Text = "Vendas por Período"
        '
        'VendasPorProdutoToolStripMenuItem
        '
        Me.VendasPorProdutoToolStripMenuItem.Name = "VendasPorProdutoToolStripMenuItem"
        Me.VendasPorProdutoToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.VendasPorProdutoToolStripMenuItem.Text = "Vendas por Produto"
        '
        'VendasPorMédiaDeIdadeToolStripMenuItem
        '
        Me.VendasPorMédiaDeIdadeToolStripMenuItem.Name = "VendasPorMédiaDeIdadeToolStripMenuItem"
        Me.VendasPorMédiaDeIdadeToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.VendasPorMédiaDeIdadeToolStripMenuItem.Text = "Vendas por Média de Idade"
        '
        'VendasPorClienteToolStripMenuItem
        '
        Me.VendasPorClienteToolStripMenuItem.Name = "VendasPorClienteToolStripMenuItem"
        Me.VendasPorClienteToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.VendasPorClienteToolStripMenuItem.Text = "Vendas por Cliente"
        '
        'VendasPorLocalidadeToolStripMenuItem
        '
        Me.VendasPorLocalidadeToolStripMenuItem.Name = "VendasPorLocalidadeToolStripMenuItem"
        Me.VendasPorLocalidadeToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.VendasPorLocalidadeToolStripMenuItem.Text = "Vendas por Localidade"
        '
        'tsmSenha
        '
        Me.tsmSenha.Image = CType(resources.GetObject("tsmSenha.Image"), System.Drawing.Image)
        Me.tsmSenha.Name = "tsmSenha"
        Me.tsmSenha.Size = New System.Drawing.Size(71, 33)
        Me.tsmSenha.Text = "Sen&ha"
        '
        'tsmLogoff
        '
        Me.tsmLogoff.BackColor = System.Drawing.Color.Transparent
        Me.tsmLogoff.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tsmLogoff.ForeColor = System.Drawing.Color.Black
        Me.tsmLogoff.Image = CType(resources.GetObject("tsmLogoff.Image"), System.Drawing.Image)
        Me.tsmLogoff.Name = "tsmLogoff"
        Me.tsmLogoff.Size = New System.Drawing.Size(74, 33)
        Me.tsmLogoff.Tag = "Logoff"
        Me.tsmLogoff.Text = "&Logoff"
        Me.tsmLogoff.ToolTipText = "Logoff"
        '
        'tsmSair
        '
        Me.tsmSair.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tsmSair.Image = CType(resources.GetObject("tsmSair.Image"), System.Drawing.Image)
        Me.tsmSair.Name = "tsmSair"
        Me.tsmSair.Size = New System.Drawing.Size(58, 33)
        Me.tsmSair.Tag = "Sair"
        Me.tsmSair.Text = "&Sair"
        Me.tsmSair.ToolTipText = "Sair"
        '
        'statusBar
        '
        Me.statusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stb_lb1, Me.ToolStripStatusLabel1, Me.stb_lb2, Me.stb_lb3})
        Me.statusBar.Location = New System.Drawing.Point(0, 426)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusBar.Size = New System.Drawing.Size(954, 24)
        Me.statusBar.TabIndex = 3
        '
        'stb_lb1
        '
        Me.stb_lb1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stb_lb1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.stb_lb1.Name = "stb_lb1"
        Me.stb_lb1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.stb_lb1.Size = New System.Drawing.Size(52, 19)
        Me.stb_lb1.Text = "{Nome}"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 19)
        '
        'stb_lb2
        '
        Me.stb_lb2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stb_lb2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.stb_lb2.Name = "stb_lb2"
        Me.stb_lb2.Size = New System.Drawing.Size(53, 19)
        Me.stb_lb2.Text = "{Versão}"
        '
        'stb_lb3
        '
        Me.stb_lb3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stb_lb3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.stb_lb3.Name = "stb_lb3"
        Me.stb_lb3.Size = New System.Drawing.Size(71, 19)
        Me.stb_lb3.Text = "{IdiomaPC}"
        '
        'PainelFormularios
        '
        Me.PainelFormularios.BackColor = System.Drawing.SystemColors.Control
        Me.PainelFormularios.BackgroundImage = CType(resources.GetObject("PainelFormularios.BackgroundImage"), System.Drawing.Image)
        Me.PainelFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PainelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PainelFormularios.Location = New System.Drawing.Point(0, 37)
        Me.PainelFormularios.Name = "PainelFormularios"
        Me.PainelFormularios.Size = New System.Drawing.Size(954, 389)
        Me.PainelFormularios.TabIndex = 6
        '
        'frmPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(954, 450)
        Me.Controls.Add(Me.PainelFormularios)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: J.A.R.V.I.S :."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.statusBar.ResumeLayout(False)
        Me.statusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmCadastro As ToolStripMenuItem
    Friend WithEvents FilasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmLogoff As ToolStripMenuItem
    Friend WithEvents tsmSair As ToolStripMenuItem
    Friend WithEvents statusBar As StatusStrip
    Friend WithEvents stb_lb1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents stb_lb2 As ToolStripStatusLabel
    Friend WithEvents stb_lb3 As ToolStripStatusLabel
    Friend WithEvents tsmFilaTrabalho As ToolStripMenuItem
    Friend WithEvents PainelFormularios As Panel
    Friend WithEvents tsmCaixa As ToolStripMenuItem
    Friend WithEvents tsmContratos As ToolStripMenuItem
    Friend WithEvents tsmEstoques As ToolStripMenuItem
    Friend WithEvents ContorleDeCaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CentroDeCustoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceitasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FilasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FinalizaçõesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SubfinalizaçõesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsmRelatorios As ToolStripMenuItem
    Friend WithEvents VendasPorPeríodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasPorProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasPorMédiaDeIdadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasPorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasPorLocalidadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmSenha As ToolStripMenuItem
    Friend WithEvents tsmHome As ToolStripMenuItem
End Class
