<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackOffice
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
        Me.components = New System.ComponentModel.Container()
        Me.gpIniciar = New System.Windows.Forms.GroupBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.lbFila = New System.Windows.Forms.Label()
        Me.cbFila = New System.Windows.Forms.ComboBox()
        Me.rbManual = New System.Windows.Forms.RadioButton()
        Me.rbAutomatica = New System.Windows.Forms.RadioButton()
        Me.gbConcluir = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbSubfinalizacao = New System.Windows.Forms.ComboBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFinalizacao = New System.Windows.Forms.ComboBox()
        Me.gbInformacoesRelevantes = New System.Windows.Forms.GroupBox()
        Me.txtOutrasInformacoes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsuarioCadastro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDataCadastro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProtocolo = New System.Windows.Forms.TextBox()
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.linkAdcCliente = New System.Windows.Forms.LinkLabel()
        Me.linkDetalhesCliente = New System.Windows.Forms.LinkLabel()
        Me.linkDetalhesProduto = New System.Windows.Forms.LinkLabel()
        Me.linkAdcProduto = New System.Windows.Forms.LinkLabel()
        Me.gpIniciar.SuspendLayout()
        Me.gbConcluir.SuspendLayout()
        Me.gbInformacoesRelevantes.SuspendLayout()
        Me.gbDados.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpIniciar
        '
        Me.gpIniciar.Controls.Add(Me.btnIniciar)
        Me.gpIniciar.Controls.Add(Me.lbFila)
        Me.gpIniciar.Controls.Add(Me.cbFila)
        Me.gpIniciar.Controls.Add(Me.rbManual)
        Me.gpIniciar.Controls.Add(Me.rbAutomatica)
        Me.gpIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpIniciar.Location = New System.Drawing.Point(12, 12)
        Me.gpIniciar.Name = "gpIniciar"
        Me.gpIniciar.Size = New System.Drawing.Size(311, 113)
        Me.gpIniciar.TabIndex = 2
        Me.gpIniciar.TabStop = False
        Me.gpIniciar.Text = "Iniciar"
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(215, 78)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.Text = "&Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'lbFila
        '
        Me.lbFila.AutoSize = True
        Me.lbFila.Location = New System.Drawing.Point(17, 54)
        Me.lbFila.Name = "lbFila"
        Me.lbFila.Size = New System.Drawing.Size(26, 13)
        Me.lbFila.TabIndex = 4
        Me.lbFila.Text = "Fila:"
        '
        'cbFila
        '
        Me.cbFila.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFila.FormattingEnabled = True
        Me.cbFila.Location = New System.Drawing.Point(47, 51)
        Me.cbFila.Name = "cbFila"
        Me.cbFila.Size = New System.Drawing.Size(243, 21)
        Me.cbFila.TabIndex = 3
        Me.cbFila.Tag = "FILA"
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.Location = New System.Drawing.Point(104, 23)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(60, 17)
        Me.rbManual.TabIndex = 3
        Me.rbManual.TabStop = True
        Me.rbManual.Tag = "MANUAL"
        Me.rbManual.Text = "Manual"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'rbAutomatica
        '
        Me.rbAutomatica.AutoSize = True
        Me.rbAutomatica.Location = New System.Drawing.Point(20, 23)
        Me.rbAutomatica.Name = "rbAutomatica"
        Me.rbAutomatica.Size = New System.Drawing.Size(78, 17)
        Me.rbAutomatica.TabIndex = 2
        Me.rbAutomatica.TabStop = True
        Me.rbAutomatica.Tag = "AUTOMÁTICO"
        Me.rbAutomatica.Text = "Automático"
        Me.rbAutomatica.UseVisualStyleBackColor = True
        '
        'gbConcluir
        '
        Me.gbConcluir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbConcluir.Controls.Add(Me.btnCancelar)
        Me.gbConcluir.Controls.Add(Me.Label3)
        Me.gbConcluir.Controls.Add(Me.txtObservacao)
        Me.gbConcluir.Controls.Add(Me.Label2)
        Me.gbConcluir.Controls.Add(Me.cbSubfinalizacao)
        Me.gbConcluir.Controls.Add(Me.btnFinalizar)
        Me.gbConcluir.Controls.Add(Me.Label1)
        Me.gbConcluir.Controls.Add(Me.cbFinalizacao)
        Me.gbConcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbConcluir.Location = New System.Drawing.Point(12, 389)
        Me.gbConcluir.Name = "gbConcluir"
        Me.gbConcluir.Size = New System.Drawing.Size(1036, 165)
        Me.gbConcluir.TabIndex = 5
        Me.gbConcluir.TabStop = False
        Me.gbConcluir.Text = "Concluir"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(861, 131)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.Location = New System.Drawing.Point(104, 73)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(913, 52)
        Me.txtObservacao.TabIndex = 7
        Me.txtObservacao.Tag = "OBSERVACAO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Subfinalização:"
        '
        'cbSubfinalizacao
        '
        Me.cbSubfinalizacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSubfinalizacao.FormattingEnabled = True
        Me.cbSubfinalizacao.Location = New System.Drawing.Point(104, 46)
        Me.cbSubfinalizacao.Name = "cbSubfinalizacao"
        Me.cbSubfinalizacao.Size = New System.Drawing.Size(913, 21)
        Me.cbSubfinalizacao.TabIndex = 5
        Me.cbSubfinalizacao.Tag = "SUBFINALIZAÇÃO"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.Location = New System.Drawing.Point(942, 131)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btnFinalizar.TabIndex = 3
        Me.btnFinalizar.Text = "&Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Finalização:"
        '
        'cbFinalizacao
        '
        Me.cbFinalizacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFinalizacao.FormattingEnabled = True
        Me.cbFinalizacao.Location = New System.Drawing.Point(104, 19)
        Me.cbFinalizacao.Name = "cbFinalizacao"
        Me.cbFinalizacao.Size = New System.Drawing.Size(913, 21)
        Me.cbFinalizacao.TabIndex = 3
        Me.cbFinalizacao.Tag = "FINALIZAÇÃO"
        '
        'gbInformacoesRelevantes
        '
        Me.gbInformacoesRelevantes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbInformacoesRelevantes.Controls.Add(Me.txtOutrasInformacoes)
        Me.gbInformacoesRelevantes.Controls.Add(Me.Label7)
        Me.gbInformacoesRelevantes.Controls.Add(Me.Label6)
        Me.gbInformacoesRelevantes.Controls.Add(Me.txtUsuarioCadastro)
        Me.gbInformacoesRelevantes.Controls.Add(Me.Label5)
        Me.gbInformacoesRelevantes.Controls.Add(Me.txtDataCadastro)
        Me.gbInformacoesRelevantes.Controls.Add(Me.Label4)
        Me.gbInformacoesRelevantes.Controls.Add(Me.txtProtocolo)
        Me.gbInformacoesRelevantes.Location = New System.Drawing.Point(12, 131)
        Me.gbInformacoesRelevantes.Name = "gbInformacoesRelevantes"
        Me.gbInformacoesRelevantes.Size = New System.Drawing.Size(311, 252)
        Me.gbInformacoesRelevantes.TabIndex = 6
        Me.gbInformacoesRelevantes.TabStop = False
        Me.gbInformacoesRelevantes.Text = "Informações Relevantes"
        '
        'txtOutrasInformacoes
        '
        Me.txtOutrasInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOutrasInformacoes.Location = New System.Drawing.Point(20, 157)
        Me.txtOutrasInformacoes.Multiline = True
        Me.txtOutrasInformacoes.Name = "txtOutrasInformacoes"
        Me.txtOutrasInformacoes.ReadOnly = True
        Me.txtOutrasInformacoes.Size = New System.Drawing.Size(270, 72)
        Me.txtOutrasInformacoes.TabIndex = 11
        Me.txtOutrasInformacoes.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Outras Informações:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Usuário Cadastrou:"
        '
        'txtUsuarioCadastro
        '
        Me.txtUsuarioCadastro.Location = New System.Drawing.Point(22, 118)
        Me.txtUsuarioCadastro.Name = "txtUsuarioCadastro"
        Me.txtUsuarioCadastro.ReadOnly = True
        Me.txtUsuarioCadastro.Size = New System.Drawing.Size(270, 20)
        Me.txtUsuarioCadastro.TabIndex = 8
        Me.txtUsuarioCadastro.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Data Cadastro:"
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.Location = New System.Drawing.Point(22, 79)
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.ReadOnly = True
        Me.txtDataCadastro.Size = New System.Drawing.Size(270, 20)
        Me.txtDataCadastro.TabIndex = 6
        Me.txtDataCadastro.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Protocolo:"
        '
        'txtProtocolo
        '
        Me.txtProtocolo.Location = New System.Drawing.Point(22, 40)
        Me.txtProtocolo.Name = "txtProtocolo"
        Me.txtProtocolo.ReadOnly = True
        Me.txtProtocolo.Size = New System.Drawing.Size(270, 20)
        Me.txtProtocolo.TabIndex = 0
        Me.txtProtocolo.TabStop = False
        '
        'gbDados
        '
        Me.gbDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDados.Controls.Add(Me.linkDetalhesProduto)
        Me.gbDados.Controls.Add(Me.linkAdcProduto)
        Me.gbDados.Controls.Add(Me.linkDetalhesCliente)
        Me.gbDados.Controls.Add(Me.linkAdcCliente)
        Me.gbDados.Controls.Add(Me.ComboBox1)
        Me.gbDados.Controls.Add(Me.Label9)
        Me.gbDados.Controls.Add(Me.cbCliente)
        Me.gbDados.Controls.Add(Me.Label8)
        Me.gbDados.Location = New System.Drawing.Point(329, 12)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(719, 371)
        Me.gbDados.TabIndex = 7
        Me.gbDados.TabStop = False
        Me.gbDados.Text = "Cadastro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cliente:"
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(17, 42)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(439, 21)
        Me.cbCliente.TabIndex = 4
        Me.cbCliente.Tag = "FILA"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(17, 82)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(439, 21)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.Tag = "FILA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Produto"
        '
        'linkAdcCliente
        '
        Me.linkAdcCliente.AutoSize = True
        Me.linkAdcCliente.Location = New System.Drawing.Point(359, 26)
        Me.linkAdcCliente.Name = "linkAdcCliente"
        Me.linkAdcCliente.Size = New System.Drawing.Size(51, 13)
        Me.linkAdcCliente.TabIndex = 9
        Me.linkAdcCliente.TabStop = True
        Me.linkAdcCliente.Text = "Adicionar"
        '
        'linkDetalhesCliente
        '
        Me.linkDetalhesCliente.AutoSize = True
        Me.linkDetalhesCliente.Location = New System.Drawing.Point(407, 26)
        Me.linkDetalhesCliente.Name = "linkDetalhesCliente"
        Me.linkDetalhesCliente.Size = New System.Drawing.Size(49, 13)
        Me.linkDetalhesCliente.TabIndex = 10
        Me.linkDetalhesCliente.TabStop = True
        Me.linkDetalhesCliente.Text = "Detalhes"
        '
        'linkDetalhesProduto
        '
        Me.linkDetalhesProduto.AutoSize = True
        Me.linkDetalhesProduto.Location = New System.Drawing.Point(407, 66)
        Me.linkDetalhesProduto.Name = "linkDetalhesProduto"
        Me.linkDetalhesProduto.Size = New System.Drawing.Size(49, 13)
        Me.linkDetalhesProduto.TabIndex = 12
        Me.linkDetalhesProduto.TabStop = True
        Me.linkDetalhesProduto.Text = "Detalhes"
        '
        'linkAdcProduto
        '
        Me.linkAdcProduto.AutoSize = True
        Me.linkAdcProduto.Location = New System.Drawing.Point(359, 66)
        Me.linkAdcProduto.Name = "linkAdcProduto"
        Me.linkAdcProduto.Size = New System.Drawing.Size(51, 13)
        Me.linkAdcProduto.TabIndex = 11
        Me.linkAdcProduto.TabStop = True
        Me.linkAdcProduto.Text = "Adicionar"
        '
        'frmBackOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1060, 566)
        Me.Controls.Add(Me.gbDados)
        Me.Controls.Add(Me.gbInformacoesRelevantes)
        Me.Controls.Add(Me.gbConcluir)
        Me.Controls.Add(Me.gpIniciar)
        Me.Name = "frmBackOffice"
        Me.Text = ".: Atendimento :."
        Me.gpIniciar.ResumeLayout(False)
        Me.gpIniciar.PerformLayout()
        Me.gbConcluir.ResumeLayout(False)
        Me.gbConcluir.PerformLayout()
        Me.gbInformacoesRelevantes.ResumeLayout(False)
        Me.gbInformacoesRelevantes.PerformLayout()
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpIniciar As GroupBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents lbFila As Label
    Friend WithEvents cbFila As ComboBox
    Friend WithEvents rbManual As RadioButton
    Friend WithEvents rbAutomatica As RadioButton
    Friend WithEvents gbConcluir As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbSubfinalizacao As ComboBox
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFinalizacao As ComboBox
    Friend WithEvents gbInformacoesRelevantes As GroupBox
    Friend WithEvents txtOutrasInformacoes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUsuarioCadastro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDataCadastro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProtocolo As TextBox
    Friend WithEvents gbDados As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents linkDetalhesProduto As LinkLabel
    Friend WithEvents linkAdcProduto As LinkLabel
    Friend WithEvents linkDetalhesCliente As LinkLabel
    Friend WithEvents linkAdcCliente As LinkLabel
End Class
