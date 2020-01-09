Public Class bll_filas
    Private dal As New dal_filas
    Private dt As New DataTable
    Private dto As New dto_filas

    Public Function AtualizaListViewFilas(Optional ByVal filtro As String = "") As Boolean 'Função para carregar o listview de usuario
        dt = dal.GetFilas(filtro)
        frmCadFilas.ListView1.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadFilas.ListView1
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
            .Columns.Add("GRUPO", 100, HorizontalAlignment.Left)
            .Columns.Add("FILA", 200, HorizontalAlignment.Left)
            .Columns.Add("CAPTURA AUTOMÁTICA", 200, HorizontalAlignment.Left)
            .Columns.Add("PERMITE CATEGORIZAÇÃO", 200, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("sigla"))
                item.SubItems.Add(drRow("grupo"))
                item.SubItems.Add(drRow("descricao"))
                item.SubItems.Add(IIf(drRow("capturaAutomatica") = True, "SIM", "NÃO"))
                item.SubItems.Add(IIf(drRow("permitirAberturaManual") = False, "NÃO PERMITE CAT. MANUAL", "PERMITE"))

                If drRow("ativo") Then
                    item.ImageKey = 1 'verde
                Else
                    item.ImageKey = 3 'vermelho
                End If
                frmCadFilas.ListView1.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function


    Public Function GetIdFilaPorNome(ByVal NomeFila As String) As Integer
        Return dal.GetIdFilaPorNome(NomeFila)
    End Function

    Public Function GetDescricaoFilaPorID(IDFILA As Integer) As String
        Dim fdto As New dto_filas
        fdto = GetFilaPorCodigo(IDFILA)
        Return fdto.descricao
    End Function

    Public Sub PreencheComboFila(frm As Form, cb As ComboBox)
        dal.GetComboboxFila(frm, cb)
    End Sub

    Public Sub PreencheComboFilaAutomatica(frm As Form, cb As ComboBox, Optional ByVal area As Integer = 0, Optional somenteComVolume As Boolean = True, Optional siglaFila As String = "sigla")
        dal.GetComboboxFilaAutomatica(frm, cb, area, somenteComVolume, siglaFila)
    End Sub
    Public Sub PreencheComboFilaManual(frm As Form, cb As ComboBox)
        dal.GetComboboxFilaManual(frm, cb)
    End Sub
    Public Function GetFilaPorCodigo(ByVal _filaId As Integer) As dto_filas
        Return dal.GetFilaPorId(_filaId)
    End Function

    Public Function SalvaFila(ByVal _fila As dto_filas) As Boolean
        If dal.ValidaDuplicidade(_fila.descricao, _fila.id) Then
            Return dal.Salvar(_fila)
        Else
            Return False
        End If
    End Function
    Public Function DeletaFila(ByVal _filaId As Integer) As Boolean
        Return dal.DeletaFilaPorId(_filaId)
    End Function
    Public Function AlterarStatusTodasFilas(ByVal Situacao As Boolean) As Boolean
        Return dal.AlterarStatusTodasFilas(Situacao)
    End Function

    Public Function capturarSiglaFila(ByVal id_fila As Integer) As String
        Return GetFilaPorCodigo(id_fila).sigla
    End Function
End Class
