Public Class frmDetalhes

    Public titulo As String
    Public id_busca As Integer
    Private dt As New DataTable

    Private Sub frmDetalhes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbTitulo.Text = titulo

        Select Case lbTitulo.Text.ToUpper
            Case "CLIENTE", "CLIENTES"
                Dim cliente As New bll_clientes
                dt = cliente.GetRegistroPorID_retornaDT(id_busca)
            Case "PRODUTO", "PRODUTOS"
                Dim produtos As New bll_produtos
                dt = produtos.GetRegistroPorID_retornaDT(id_busca)
            Case Else
                dt = Nothing
                lbTitulo.Text = "Pesquisa mal sucedida!  :¬("
        End Select

        dgvDetalhes.DataSource = dt


    End Sub
End Class