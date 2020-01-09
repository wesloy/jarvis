Public Class bll_clientes
    Private dal As New dal_clientes
    Private dt As New DataTable
    Private dto As New dto_clientes


    Public Function AtualizaListViewRegistros(Optional ByVal filtro As String = "") As Boolean 'Função para carregar o listview de usuario
        dt = dal.GetRegistros(filtro)
        frmCadClientes.ListView1.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadClientes.ListView1
            .View = View.Details
            .LabelEdit = False
            .CheckBoxes = False
            .SmallImageList = imglist() 'Utilizando um modulo publico
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ID", 50, HorizontalAlignment.Center)
            .Columns.Add("CLIENTE", 250, HorizontalAlignment.Left)
            .Columns.Add("COMPANHEIRO(A)", 250, HorizontalAlignment.Left)
            .Columns.Add("TELEFONE", 120, HorizontalAlignment.Left)
            .Columns.Add("CELULAR", 120, HorizontalAlignment.Left)
            .Columns.Add("E-MAIL", 150, HorizontalAlignment.Left)
            .Columns.Add("INSTAGRAM", 150, HorizontalAlignment.Left)
            .Columns.Add("FACEBOOK", 150, HorizontalAlignment.Left)
            .Columns.Add("CPF", 150, HorizontalAlignment.Left)
            .Columns.Add("DTA. NASCIMENTO", 150, HorizontalAlignment.Left)
            .Columns.Add("GESTANTE", 150, HorizontalAlignment.Left)
            .Columns.Add("SEMANAS GESTAÇÃO", 150, HorizontalAlignment.Left)
            .Columns.Add("PREVISÃO NASC.", 150, HorizontalAlignment.Left)
            .Columns.Add("QTDE FILHOS", 150, HorizontalAlignment.Left)
            .Columns.Add("OBSERVAÇÃO", 800, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("cliente"))
                item.SubItems.Add(drRow("companheiro"))
                item.SubItems.Add(drRow("telefone"))
                item.SubItems.Add(drRow("celular"))
                item.SubItems.Add(drRow("email"))
                item.SubItems.Add(drRow("instagram"))
                item.SubItems.Add(drRow("facebook"))
                item.SubItems.Add(drRow("cpf"))
                item.SubItems.Add(drRow("dataNascimento"))
                item.SubItems.Add(drRow("gestante"))
                item.SubItems.Add(drRow("semanasGestacao"))
                item.SubItems.Add(drRow("previsaoNascimento"))
                item.SubItems.Add(drRow("qtdeFilhos"))
                item.SubItems.Add(drRow("observacao"))

                If drRow("ativo") Then
                    item.ImageKey = 1 'verde
                Else
                    item.ImageKey = 3 'vermelho
                End If
                frmCadClientes.ListView1.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function

    Public Function GetIdRegistroPorNome(ByVal _registroNome As String) As Integer
        Return dal.GetIdRegistroPorNome(_registroNome)
    End Function

    Public Function GetDescricaoRegistroPorID(_id As Integer) As String
        Dim dto As New dto_clientes
        dto = dal.GetRegistrosPorId(_id)
        Return dto.cliente
    End Function

    Public Function GetRegistroPorID(_id As Integer) As dto_clientes
        Dim dto As New dto_clientes
        Return dal.GetRegistrosPorId(_id)
    End Function

    Public Sub PreencheCombobox(frm As Form, cb As ComboBox)
        dal.GetComboboxRegistros(frm, cb)
    End Sub

    Public Function SalvarRegistro(ByVal _obj As dto_clientes) As Boolean
        If dal.ValidaDuplicidade(_obj.cliente, _obj.id) Then
            Return dal.Salvar(_obj)
        Else Return False
        End If
    End Function
    Public Function DeletarRegistro(ByVal _id As Integer) As Boolean
        Return dal.DeletaPorId(_id)
    End Function

    Public Function AtualizaListViewRegistrosFilhos(ByVal id_tbl_clientes As Integer) As Boolean 'Função para carregar o listview de usuario
        dt = dal.GetRegistrosFilhos(id_tbl_clientes)
        frmCadClientes.ListView2.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadClientes.ListView2
            .View = View.Details
            .LabelEdit = False
            .CheckBoxes = False
            .SmallImageList = imglist() 'Utilizando um modulo publico
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ID", 50, HorizontalAlignment.Center)
            .Columns.Add("NOME", 180, HorizontalAlignment.Left)
            .Columns.Add("SEXO", 80, HorizontalAlignment.Left)
            .Columns.Add("DTA. NASCIMENTO", 150, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("nomeFilho"))
                item.SubItems.Add(drRow("sexo"))
                item.SubItems.Add(drRow("dataNascimento_filho"))
                item.ImageKey = 9
                frmCadClientes.ListView2.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function

    Public Function GetRegistroPorIDFilho(_id As Integer) As dto_clientes
        Dim dto As New dto_clientes
        Return dal.GetRegistrosPorIdFilhos(_id)
    End Function
    Public Function SalvarRegistroFilho(ByVal _obj As dto_clientes) As Boolean
        If dal.ValidaDuplicidadeFilhos(_obj.nomeFilho, _obj.id_tblClientes) Then
            Return dal.SalvarFilhos(_obj)
        Else Return False
        End If
    End Function
    Public Function DeletarRegistroFilho(ByVal _id As Integer) As Boolean
        Return dal.DeletaPorIdFilhos(_id)
    End Function
End Class
