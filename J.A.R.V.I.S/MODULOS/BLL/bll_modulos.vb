Public Class bll_modulos
    Private db As New dal_modulos
    Private dt As New DataTable
    'Função para carregar o listview no formulario de cadastro de modulos
    Public Function AtualizaListViewModulo(Optional ByVal filtro As String = "") As Boolean
        dt = db.GetModulos(filtro)
        'frmCadModulo.ListView1.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadModulo.ListView1
            .Clear()
            .View = View.Details
            .LabelEdit = False
            .CheckBoxes = False
            .SmallImageList = imglist() 'Utilizando um modulo publico
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ID", 50, HorizontalAlignment.Center)
            .Columns.Add("MODULO", 200, HorizontalAlignment.Left)
            .Columns.Add("FORM PRINCIPAL", 200, HorizontalAlignment.Left)
            .Columns.Add("ÁREA", 120, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("modulo"))
                item.SubItems.Add(drRow("NomeFormPrincipal"))
                item.SubItems.Add(drRow("DescricaoArea"))
                If drRow("situacao") Then
                    item.ImageKey = 1 'verde
                Else
                    item.ImageKey = 3 'vermelho
                End If
                frmCadModulo.ListView1.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function
    Public Function GetModuloPorCodigo(ByVal _moduloId As Integer) As dto_modulos
        Return db.GetModuloPorId(_moduloId)
    End Function
    Public Sub SalvaModulo(ByVal _modulo As dto_modulos)
        db.Salvar(_modulo)
    End Sub
    Public Function DeletaModulo(ByVal _moduloId As Integer) As Boolean
        Return db.DeletaModuloPorId(_moduloId)
    End Function
    Public Sub PreencheComboModulo(frm As Form, cb As ComboBox)
        db.GetComboboxModulos(frm, cb)
    End Sub
    Public Function capturaNomeForm(idModulo As Integer) As String
        Return db.capturaNomeFormPrincipalModulo(idModulo)
    End Function
    Public Function GetNomeAreaPorModulo(idModulo As Integer) As String
        Return db.capturaNomeAreaPorModulo(idModulo)
    End Function
    Public Function GetIdAreaPorModulo(idModulo As Integer) As String
        Return db.capturaIDAreaPorModulo(idModulo)
    End Function
End Class
