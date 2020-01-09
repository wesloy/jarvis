Public Class bll_bancos
    Private dal As New dal_bancos
    Private dt As New DataTable
    Private dto As New dto_bancos

    Public Function AtualizaListViewRegistros(Optional ByVal filtro As String = "") As Boolean 'Função para carregar o listview de usuario
        dt = dal.GetRegistros(filtro)
        frmCadBancos.ListView1.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadBancos.ListView1
            .View = View.Details
            .LabelEdit = False
            .CheckBoxes = False
            .SmallImageList = imglist() 'Utilizando um modulo publico
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ID", 50, HorizontalAlignment.Center)
            .Columns.Add("BANCO", 300, HorizontalAlignment.Left)
            .Columns.Add("COD. BANCO", 150, HorizontalAlignment.Left)
            .Columns.Add("AGÊNCIA", 150, HorizontalAlignment.Left)
            .Columns.Add("DIG. AGÊNCIA", 120, HorizontalAlignment.Left)
            .Columns.Add("CONTA CORRENTE", 150, HorizontalAlignment.Left)
            .Columns.Add("DIG. CONTA CORRENTE", 120, HorizontalAlignment.Left)
            .Columns.Add("SALDO", 100, HorizontalAlignment.Center)
            .Columns.Add("OBSERVAÇÃO", 300, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("nomeBanco"))
                item.SubItems.Add(drRow("codBanco"))
                item.SubItems.Add(drRow("agencia"))
                item.SubItems.Add(drRow("digitoAgencia"))
                item.SubItems.Add(drRow("contaCorrente"))
                item.SubItems.Add(drRow("digitoContaCorrente"))
                item.SubItems.Add(drRow("saldo"))
                item.SubItems.Add(drRow("observacao"))

                If drRow("ativo") Then
                    item.ImageKey = 1 'verde
                Else
                    item.ImageKey = 3 'vermelho
                End If
                frmCadBancos.ListView1.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function

    Public Function GetIdRegistroPorNome(ByVal _registroNome As String) As Integer
        Return dal.GetIdRegistroPorNome(_registroNome)
    End Function

    Public Function GetDescricaoRegistroPorID(_id As Integer) As String
        Dim dto As New dto_bancos
        dto = dal.GetRegistrosPorId(_id)
        Return dto.nomeBanco
    End Function

    Public Function GetRegistroPorID(_id As Integer) As dto_bancos
        Dim dto As New dto_bancos
        Return dal.GetRegistrosPorId(_id)
    End Function

    Public Sub PreencheCombobox(frm As Form, cb As ComboBox)
        dal.GetComboboxRegistros(frm, cb)
    End Sub

    Public Function SalvarRegistro(ByVal _obj As dto_bancos) As Boolean
        If dal.ValidaDuplicidade(_obj.nomeBanco, _obj.id) Then
            Return dal.Salvar(_obj)
        Else Return False
        End If
    End Function
    Public Function DeletarRegistro(ByVal _id As Integer) As Boolean
        Return dal.DeletaPorId(_id)
    End Function
End Class
