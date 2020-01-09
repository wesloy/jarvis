Public Class bll_receitas_despesas
    Private dal As New dal_recetias_despesas
    Private dt As New DataTable
    Private dto As New dto_receitas_despesas

    Public Function AtualizaListViewRegistros(Optional ByVal filtro As String = "") As Boolean 'Função para carregar o listview de usuario
        dt = dal.GetRegistros(filtro)
        frmCadReceitasDespesas.ListView1.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadReceitasDespesas.ListView1
            .View = View.Details
            .LabelEdit = False
            .CheckBoxes = False
            .SmallImageList = imglist() 'Utilizando um modulo publico
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ID", 50, HorizontalAlignment.Center)
            .Columns.Add("TIPO REGISTRO", 100, HorizontalAlignment.Left)
            .Columns.Add("DESCRIÇÃO", 150, HorizontalAlignment.Left)
            .Columns.Add("OBSERVAÇÃO", 300, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("tipoRegistro"))
                item.SubItems.Add(drRow("descricao"))
                item.SubItems.Add(drRow("observacao"))

                If drRow("ativo") Then
                    item.ImageKey = 1 'verde
                Else
                    item.ImageKey = 3 'vermelho
                End If
                frmCadReceitasDespesas.ListView1.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function

    Public Function GetIdRegistroPorNome(ByVal _registroNome As String) As Integer
        Return dal.GetIdRegistroPorNome(_registroNome)
    End Function

    Public Function GetDescricaoRegistroPorID(_id As Integer) As String
        Dim dto As New dto_receitas_despesas
        dto = dal.GetRegistrosPorId(_id)
        Return dto.descricao
    End Function

    Public Function GetRegistroPorID(_id As Integer) As dto_receitas_despesas
        Dim dto As New dto_receitas_despesas
        Return dal.GetRegistrosPorId(_id)
    End Function

    Public Sub PreencheCombobox(frm As Form, cb As ComboBox)
        dal.GetComboboxRegistros(frm, cb)
    End Sub

    Public Function SalvarRegistro(ByVal _obj As dto_receitas_despesas) As Boolean
        If dal.ValidaDuplicidade(_obj.descricao, _obj.id) Then
            Return dal.Salvar(_obj)
        Else Return False
        End If
    End Function
    Public Function DeletarRegistro(ByVal _id As Integer) As Boolean
        Return dal.DeletaPorId(_id)
    End Function
End Class
