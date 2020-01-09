Public Class Bll_modulo_usuarios
    Private ReadOnly db As New dal_modulo_usuarios
    Private dt As New DataTable

    Public Function AtualizaListViewModuloAcessoUsuario(Optional ByVal filtro As String = "") As Boolean 'Função para carregar o listview
        dt = db.GetModulosAcesso(filtro)
        frmCadUsuarios.listviewModulosAcesso.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadUsuarios.listviewModulosAcesso
            .View = View.Details
            .LabelEdit = False
            .CheckBoxes = False
            .SmallImageList = imglist() 'Utilizando um modulo publico
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ID", 0, HorizontalAlignment.Center)
            .Columns.Add("ID DE REDE", 0, HorizontalAlignment.Center)
            .Columns.Add("ID MODULO", 0, HorizontalAlignment.Center)
            .Columns.Add("MÓDULO", 315, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("id_usuario"))
                item.SubItems.Add(drRow("id_modulo"))
                item.SubItems.Add(drRow("DescricaoModulo"))
                frmCadUsuarios.listviewModulosAcesso.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function

    Public Function GetModuloAcessoUsuarioPorCodigo(ByVal _moduloId As Integer) As dto_modulo_usuarios
        Return db.GetModuloAcessoPorId(_moduloId)
    End Function
    Public Function SalvaModuloAcessoUsuario(ByVal _modulo As dto_modulo_usuarios) As Boolean
        If db.ValidaDuplicidade(_modulo.idModulo, _modulo.id, _modulo.idUsuario) Then
            Return db.Salvar(_modulo)
        Else
            Return False
        End If
    End Function
    Public Function DeletaModuloAcessoUsuario(ByVal _moduloId As Integer) As Boolean
        Return db.DeletaModuloAcessoPorId(_moduloId)
    End Function

    Public Sub PreencheComboModulosAcessoUsuario(ByVal strIdUsuario As String, frm As Form, cb As ComboBox)
        db.GetComboboxModulosAcessoLogin(strIdUsuario, frm, cb)
    End Sub
End Class
