Public Class bll_produtos
    Private dal As New dal_produtos
    Private dt As New DataTable
    Private dto As New dto_produtos

    Public Function AtualizaListViewRegistros(Optional ByVal filtro As String = "") As Boolean 'Função para carregar o listview de usuario
        dt = dal.GetRegistros(filtro)
        frmCadProdutos.ListView1.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadProdutos.ListView1
            .View = View.Details
            .LabelEdit = False
            .CheckBoxes = False
            .SmallImageList = imglist() 'Utilizando um modulo publico
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ID", 50, HorizontalAlignment.Center)
            .Columns.Add("SIGLA", 60, HorizontalAlignment.Left)
            .Columns.Add("PRODUTO", 300, HorizontalAlignment.Left)
            .Columns.Add("VALOR", 200, HorizontalAlignment.Left)
            .Columns.Add("DESCRIÇÃO", 600, HorizontalAlignment.Left)

        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("sigla"))
                item.SubItems.Add(drRow("produto"))
                item.SubItems.Add(drRow("valor"))
                item.SubItems.Add(drRow("descricao"))

                If drRow("ativo") Then
                    item.ImageKey = 1 'verde
                Else
                    item.ImageKey = 3 'vermelho
                End If
                frmCadProdutos.ListView1.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function

    Public Function GetIdRegistroPorNome(ByVal _registroNome As String) As Integer
        Return dal.GetIdRegistroPorNome(_registroNome)
    End Function

    Public Function GetDescricaoRegistroPorID(_id As Integer) As String
        Dim dto As New dto_produtos
        dto = dal.GetRegistrosPorId(_id)
        Return dto.produto
    End Function

    Public Function GetRegistroPorID(_id As Integer) As dto_produtos
        Dim dto As New dto_produtos
        Return dal.GetRegistrosPorId(_id)
    End Function

    Public Sub PreencheCombobox(frm As Form, cb As ComboBox)
        dal.GetComboboxRegistros(frm, cb)
    End Sub

    Public Function SalvarRegistro(ByVal _obj As dto_produtos) As Boolean
        If dal.ValidaDuplicidade(_obj.produto, _obj.id) Then
            Return dal.Salvar(_obj)
        Else Return False
        End If
    End Function
    Public Function DeletarRegistro(ByVal _id As Integer) As Boolean
        Return dal.DeletaPorId(_id)
    End Function

End Class
