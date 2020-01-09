Public Class bll_subfinalizacoes
    Private db As New dal_subfinalizacoes
    Private dt As New DataTable
    Private dto As New dto_subfinalizacoes

    Public Function AtualizaListViewSubFinalizacao(Optional ByVal filtro As String = "", Optional ByVal filtroArea As String = "", Optional ByVal filtroFila As String = "") As Boolean 'Função para carregar o listview de usuario
        dt = db.GetSubFinalizacoes(filtro, filtroArea, filtroFila)
        frmCadSubFinalizacao.ListView1.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadSubFinalizacao.ListView1
            .View = View.Details
            .LabelEdit = False
            .CheckBoxes = False
            .SmallImageList = imglist() 'Utilizando um modulo publico
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ID", 50, HorizontalAlignment.Center)
            .Columns.Add("SUBFINALIZAÇÃO", 220, HorizontalAlignment.Left)
            .Columns.Add("ÁREA", 80, HorizontalAlignment.Left)
            .Columns.Add("FILA", 180, HorizontalAlignment.Left)
            .Columns.Add("FINALIZAÇÃO", 160, HorizontalAlignment.Left)
            .Columns.Add("PASSIVEL EF.", 200, HorizontalAlignment.Left)
            .Columns.Add("EFETIVO.", 200, HorizontalAlignment.Left)
            .Columns.Add("FRAUDE", 200, HorizontalAlignment.Left)
            .Columns.Add("NÃO FRAUDE", 200, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("descricao"))
                item.SubItems.Add(drRow("DescricaoArea"))
                item.SubItems.Add(drRow("DescricaoFila"))
                item.SubItems.Add(drRow("DescricaoFinalizacao"))
                item.SubItems.Add(drRow("cttoPassivelEfetividade"))
                item.SubItems.Add(drRow("cttoEfetivo"))
                item.SubItems.Add(drRow("fraude"))
                item.SubItems.Add(drRow("naoFraude"))
                If drRow("situacao") Then
                    item.ImageKey = 1 'verde
                Else
                    item.ImageKey = 3 'vermelho
                End If
                frmCadSubFinalizacao.ListView1.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function
    Public Sub PreencheComboSubFinalizacao(frm As Form, cb As ComboBox, Optional ByVal idFinalizacao As Integer = 0)
        db.GetComboboxSubFinalizacao(frm, cb, idFinalizacao)
    End Sub
    Public Function GetNomeSubFinalizacaoPorID(ByVal idSubFinalizacao As Integer) As String
        dto = GetSubFinalizacaoPorCodigo(idSubFinalizacao)
        Return dto.Descricao.ToString.ToUpper
    End Function

    Public Function GetSubFinalizacaoPorCodigo(ByVal _SubfinalizacaoId As Integer) As dto_subfinalizacoes
        Return db.GetSubFinalizacaoPorId(_SubfinalizacaoId)
    End Function
    Public Function SalvaSubFinalizacao(ByVal _SubfinalizacaoId As dto_subfinalizacoes) As Boolean
        If db.ValidaDuplicidade(_SubfinalizacaoId.descricao, _SubfinalizacaoId.id, _SubfinalizacaoId.idFinalizacao) Then
            Return db.Salvar(_SubfinalizacaoId)
        Else
            Return False
        End If
    End Function
    Public Function DeletaSubFinalizacao(ByVal _SubfinalizacaoId As Integer) As Boolean
        Return db.DeletaSubFinalizacaoPorId(_SubfinalizacaoId)
    End Function

    Public Function roteamentoPorSubFinalizacao(ByVal idSubfinalizacao As Integer) As dto_subfinalizacoes
        Return db.roteamentoPorSubFinalizacao(idSubfinalizacao)
    End Function
End Class
