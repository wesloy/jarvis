Public Class frmPrincipal
    Dim hlp As New Uteis.Helpers
    Dim objMenu As New bll_menu
    Private Logs As New Bll_log

    Private fechamentoForcado As Boolean = True 'Variável para registrar o fechameto do formulário forçado
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stb_lb1.Text = sessaoNomeUsuario.ToString
        stb_lb2.Text = hlp.versaoSistema.ToString
        stb_lb3.Text = hlp.retornaIdiomaPC.ToString
        tsmSair.Enabled = True
        objMenu.bloquearMenus(MenuStrip1)
        hlp.RemoveXButton(Me.Handle())
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If fechamentoForcado Then
            Logs.RegistrarLOG(, , Me.Text, "FECHAMENTO FORÇADO")
            Logs.fecharAplicativo(False)
        End If
    End Sub

    Private Sub tsmSair_Click(sender As Object, e As EventArgs) Handles tsmSair.Click
        fechamentoForcado = False
        Logs.FecharAplicativo(True)
    End Sub

    Private Sub tsmLogoff_Click(sender As Object, e As EventArgs) Handles tsmLogoff.Click
        fechamentoForcado = False
        sessaoModulo = "NÃO SELECIONADO"
        hlp.abrirForm(frmLogin)
        hlp.fecharForm(Me)
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        hlp.abrirFormInPanelMDI(frmCadUsuarios, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub tsmSenha_Click(sender As Object, e As EventArgs) Handles tsmSenha.Click
        hlp.abrirForm(frmSenhaAtualizar, True, False)
    End Sub

    Private Sub tsmHome_Click(sender As Object, e As EventArgs) Handles tsmHome.Click
        hlp.fecharFormInPanel(Me)
    End Sub

    Private Sub FilasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FilasToolStripMenuItem1.Click
        hlp.abrirFormInPanelMDI(frmCadFilas, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub FinalizaçõesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FinalizaçõesToolStripMenuItem1.Click
        hlp.abrirFormInPanelMDI(frmCadFinalizacoes, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub SubfinalizaçõesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SubfinalizaçõesToolStripMenuItem1.Click
        hlp.abrirFormInPanelMDI(frmCadSubFinalizacao, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        hlp.abrirFormInPanelMDI(frmCadProdutos, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        hlp.abrirFormInPanelMDI(frmCadFornecedores, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        hlp.abrirFormInPanelMDI(frmCadClientes, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub BancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem.Click
        hlp.abrirFormInPanelMDI(frmCadBancos, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub CentroDeCustoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentroDeCustoToolStripMenuItem.Click
        hlp.abrirFormInPanelMDI(frmCadCentroCusto, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub ReceitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceitasToolStripMenuItem.Click
        hlp.abrirFormInPanelMDI(frmCadReceitasDespesas, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub AtenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtenderToolStripMenuItem.Click
        hlp.abrirFormInPanelMDI(frmBackOffice, Me, PainelFormularios, FormBorderStyle.None)
    End Sub

    Private Sub DesbloquearRegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesbloquearRegistrosToolStripMenuItem.Click
        Try
            Dim int_OK As Boolean = False
            Dim tempoMinutos As Integer = 1
            Dim bll_backOffice As New bll_backoffice
            Dim capturaInformacao As String = InputBox("Informe o tempo em MINUTOS que deve ser considerado, para liberar os registros reservados para trabalho: ", TITULO_ALERTA, 5)

            int_OK = Integer.TryParse(capturaInformacao, tempoMinutos)

            If int_OK Then
                If bll_backOffice.rollbackRegistros(tempoMinutos) Then
                    MsgBox("Todos os registros que estavam reservados para trabalho foram liberados.", TITULO_ALERTA, vbInformation)
                End If
            Else
                MsgBox("Informa apenas números, para prosseguir com a liberação dos registros reservados para trabalho!", vbOKOnly + vbCritical, TITULO_ALERTA)
            End If

        Catch ex As Exception
            MsgBox("Informa apenas números, para prosseguir com a liberação dos registros reservados para trabalho!", vbOKOnly + vbCritical, TITULO_ALERTA)
        End Try

    End Sub

    Private Sub tsmContratos_Click(sender As Object, e As EventArgs) Handles tsmContratos.Click
        hlp.abrirForm(frmCadContratos, True, True)
        'hlp.abrirFormInPanelMDI(frmCadContratos, Me, PainelFormularios, FormBorderStyle.None)
    End Sub
End Class