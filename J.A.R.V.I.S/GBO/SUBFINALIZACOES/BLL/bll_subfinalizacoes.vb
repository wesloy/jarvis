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
            .Columns.Add("ID:", 50, HorizontalAlignment.Center)
            .Columns.Add("DESCRIÇÃO:", 180, HorizontalAlignment.Left)
            .Columns.Add("FILA:", 200, HorizontalAlignment.Left)
            .Columns.Add("FINALIZAÇÃO:", 200, HorizontalAlignment.Left)
            .Columns.Add("PASSIVEL EF.:", 200, HorizontalAlignment.Left)
            .Columns.Add("EFETIVO:", 200, HorizontalAlignment.Left)
            .Columns.Add("GERAR NOVO CASO:", 200, HorizontalAlignment.Left)
            .Columns.Add("AGING NOVO CASO:", 200, HorizontalAlignment.Left)
            .Columns.Add("FILA DESTINO:", 200, HorizontalAlignment.Left)
            .Columns.Add("DATA MANUTENÇÃO:", 200, HorizontalAlignment.Left)
            .Columns.Add("MANUTENÇÃO REALIZADA POR:", 200, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("descricao"))
                item.SubItems.Add(drRow("DescricaoFila"))
                item.SubItems.Add(drRow("DescricaoFinalizacao"))
                item.SubItems.Add(IIf(drRow("cttoPassivelEfetividade") = True, "SIM", "NÃO"))
                item.SubItems.Add(IIf(drRow("cttoEfetivo") = True, "SIM", "NÃO"))
                item.SubItems.Add(IIf(drRow("geraNovoCaso") = True, "SIM", "NÃO"))
                item.SubItems.Add(IIf(drRow("geraNovoCaso") = True, FlagRoteamentoRetornaExpressao(drRow("agingNovoCaso")).ToUpper, "NÃO SE APLICA"))
                item.SubItems.Add(IIf(IsDBNull(drRow("DescricaoFilaDestino")), "NÃO SE APLICA", drRow("DescricaoFilaDestino")))
                item.SubItems.Add(drRow("dataCadastro"))
                item.SubItems.Add(drRow("nome"))
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
        Return dto.descricao.ToString.ToUpper
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

    ''' <summary>
    ''' Retorna o objeto, se o a subfinalização é passível de roteamento
    ''' </summary>
    ''' <param name="idSubfinalizacao"></param>
    ''' <returns></returns>
    Public Function roteamentoPorSubFinalizacao(ByVal idSubfinalizacao As Integer, ByRef dto_subfin As dto_subfinalizacoes) As Boolean

        dto_subfin = db.roteamentoPorSubFinalizacao(idSubfinalizacao)

        If dto_subfin Is Nothing Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function AtualizaListViewFilasPorSubFinalizacao(ByVal subfinalizacao As String) As Boolean
        dt = db.GetFilasPorSubFinalizacao(subfinalizacao)
        frmCadSubFinalizacao.listviewFilasPorSubFinalizacao.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadSubFinalizacao.listviewFilasPorSubFinalizacao
            .View = View.Details
            .LabelEdit = False
            .CheckBoxes = False
            .SmallImageList = imglist() 'Utilizando um modulo publico
            .GridLines = True
            .FullRowSelect = False
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ID_FILA", 0, HorizontalAlignment.Center)
            .Columns.Add("FILA", 200, HorizontalAlignment.Left)
            .Columns.Add("SIGLA", 100, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("descricao"))
                item.SubItems.Add(drRow("sigla"))
                frmCadSubFinalizacao.listviewFilasPorSubFinalizacao.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function


End Class
