Public Class bll_fornecedores
    Private dal As New dal_fornecedores
    Private dt As New DataTable
    Private dto As New dto_fornecedores

    Public Function AtualizaListViewRegistros(Optional ByVal filtro As String = "") As Boolean 'Função para carregar o listview de usuario
        dt = dal.GetRegistros(filtro)
        frmCadFornecedores.ListView1.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadFornecedores.ListView1
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
            .Columns.Add("FORNECEDOR", 250, HorizontalAlignment.Left)
            .Columns.Add("TELEFONE", 120, HorizontalAlignment.Left)
            .Columns.Add("CELULAR", 120, HorizontalAlignment.Left)
            .Columns.Add("CONTATO", 150, HorizontalAlignment.Left)
            .Columns.Add("E-MAIL", 150, HorizontalAlignment.Left)
            .Columns.Add("SITE", 150, HorizontalAlignment.Left)
            .Columns.Add("HORÁRIO FUNC.", 150, HorizontalAlignment.Left)
            .Columns.Add("CNPJ", 150, HorizontalAlignment.Left)
            .Columns.Add("OBSERVAÇÃO", 800, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("sigla"))
                item.SubItems.Add(drRow("fornecedor"))
                item.SubItems.Add(drRow("telefone"))
                item.SubItems.Add(drRow("celular"))
                item.SubItems.Add(drRow("contato"))
                item.SubItems.Add(drRow("email"))
                item.SubItems.Add(drRow("site"))
                item.SubItems.Add(drRow("horarioFuncionamento"))
                item.SubItems.Add(drRow("cnpj"))
                item.SubItems.Add(drRow("observacao"))

                If drRow("ativo") Then
                    item.ImageKey = 1 'verde
                Else
                    item.ImageKey = 3 'vermelho
                End If
                frmCadFornecedores.ListView1.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function

    Public Function GetIdRegistroPorNome(ByVal _registroNome As String) As Integer
        Return dal.GetIdRegistroPorNome(_registroNome)
    End Function

    Public Function GetDescricaoRegistroPorID(_id As Integer) As String
        Dim dto As New dto_fornecedores
        dto = dal.GetRegistrosPorId(_id)
        Return dto.fornecedor
    End Function

    Public Function GetRegistroPorID(_id As Integer) As dto_fornecedores
        Dim dto As New dto_fornecedores
        Return dal.GetRegistrosPorId(_id)
    End Function

    Public Sub PreencheCombobox(frm As Form, cb As ComboBox)
        dal.GetComboboxRegistros(frm, cb)
    End Sub

    Public Function SalvarRegistro(ByVal _obj As dto_fornecedores) As Boolean
        If dal.ValidaDuplicidade(_obj.fornecedor, _obj.id) Then
            Return dal.Salvar(_obj)
        Else Return False
        End If
    End Function
    Public Function DeletarRegistro(ByVal _id As Integer) As Boolean
        Return dal.DeletaPorId(_id)
    End Function
End Class
