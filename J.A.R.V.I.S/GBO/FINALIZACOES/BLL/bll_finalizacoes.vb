Public Class bll_finalizacoes
    Private db As New dal_finalizacoes
    Private dt As New DataTable
    Private dto As New dto_finalizacoes

    Public Function AtualizaListViewFinalizacao(Optional ByVal filtro As String = "", Optional ByVal filtroFila As String = "") As Boolean
        'Função para carregar o listview de usuario

        dt = db.GetFinalizacoes(filtro, filtroFila)
        frmCadFinalizacoes.ListView1.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadFinalizacoes.ListView1
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
                frmCadFinalizacoes.ListView1.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function

    'Função para carregar o listview
    Public Function AtualizaListViewFilasPorFinalizacao(ByVal finalizacao As String) As Boolean
        dt = db.GetFilasPorFinalizacao(finalizacao)
        frmCadFinalizacoes.listviewFilasPorFinalizacao.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadFinalizacoes.listviewFilasPorFinalizacao
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
                frmCadFinalizacoes.listviewFilasPorFinalizacao.Items.Add(item)
            Next drRow
        End If
        Return True
    End Function
    Public Sub PreencheComboFinalizacao(frm As Form, cb As ComboBox, Optional ByVal fila As Integer = 0)
        db.GetComboboxFinalizacao(frm, cb, fila)
    End Sub

    Public Function GetNomeFinalizacaoPorID(ByVal idFinalizacao As Integer) As String
        dto = GetFinalizacaoPorCodigo(idFinalizacao)
        Return dto.Descricao.ToString.ToUpper
    End Function

    Public Function GetFinalizacaoPorCodigo(ByVal _finalizacaoId As Integer) As dto_finalizacoes
        Return db.GetFinalizacaoPorId(_finalizacaoId)
    End Function
    Public Function SalvaFinalizacao(ByVal _finalizacao As dto_finalizacoes) As Boolean
        If db.ValidaDuplicidade(_finalizacao) Then
            Return db.Salvar(_finalizacao)
        Else
            Return False
        End If
    End Function
    Public Function DeletaFinalizacao(ByVal _finalizacaoId As Integer) As Boolean
        Return db.DeletaFinalizacaoPorId(_finalizacaoId)
    End Function
    ''' <summary>
    ''' Retorna o objeto, se o a finalização é passível de roteamento
    ''' </summary>
    ''' <param name="idfinalizacao"></param>
    ''' <returns></returns>
    Public Function roteamentoPorFinalizacao(ByVal idfinalizacao As Integer, ByRef dto_fin As dto_finalizacoes) As Boolean

        dto_fin = db.roteamentoPorFinalizacao(idfinalizacao)

        If dto_fin Is Nothing Then
            Return False
        Else
            Return True
        End If

    End Function
End Class
