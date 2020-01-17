Public Class bll_backoffice

    Private dal As New dal_backoffice
    Private dt As New DataTable
    Private dto As New dto_backoffice
    Private Logs As New Bll_log
    Private hlp As New Uteis.Helpers

    Public Function capturarRegistro(ByRef dto_back As dto_backoffice) As Boolean
        Try
            With dto_back

                'Validar se há algum registro preso para o usuário logado
                Dim id_locado = dal.validarRegistroLocadoPorUsuario(sessaoIdUsuario)
                If id_locado > 0 Then
                    If MsgBox(sessaoNomeUsuario & " existe um registro que você não finalizou. Deseja finalizar agora?", vbQuestion + vbYesNo, TITULO_ALERTA) = vbYes Then
                        dto_back.id = id_locado
                    End If
                End If


                'Específico
                If .id > 0 Then
                    capturarRegistro = dal.capturarRegistroTrabalho(dto_back)
                End If

                'Automático
                If .tipo_registro = "A" And .id = 0 Then
                    capturarRegistro = dal.capturarRegistroTrabalho(dto_back)
                End If

                'Manual
                If .tipo_registro = "M" And .id = 0 Then
                    capturarRegistro = dal.gerarNovoCaso(dto_back)
                End If


            End With

            If capturarRegistro Then
                Return True
            Else
                MsgBox("Não foi possível capturar nenhum registro com as características solicitadas!", vbInformation + vbOKOnly, TITULO_ALERTA)
                dto_back = Nothing
                Return False
            End If

        Catch ex As Exception
            dto_back = Nothing
            Return False
        End Try
    End Function

    Public Function liberarRegistro(ByVal dto_back As dto_backoffice) As Boolean

        Try
            If dal.alterarStatus(dto_back, 0) Then
                MsgBox("Cancelado, com sucesso!", vbInformation + vbOKOnly, TITULO_ALERTA)
                Return True
            Else
                MsgBox("Não foi possível cancelar a categorização deste registro!", vbCritical + vbOKOnly, TITULO_ALERTA)
                Return False
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function carregarListViewHistoricoCliente(ByVal ltv As ListView, ByVal id_cliente As Integer) As Boolean
        Try
            dt = dal.getHistoricoRegistrosPorCliente(id_cliente)
            ltv.Clear()
            'AJUSTANDO AS COLUNAS
            With ltv
                .View = View.Details
                .LabelEdit = False
                .CheckBoxes = False
                .SmallImageList = imglist() 'Utilizando um modulo publico
                .GridLines = True
                .FullRowSelect = True
                .HideSelection = False
                .MultiSelect = False
                .Columns.Add("PROTOCOLO", 100, HorizontalAlignment.Center)
                .Columns.Add("FILA", 100, HorizontalAlignment.Left)
                .Columns.Add("DATA TRABALHADA", 150, HorizontalAlignment.Left)
                .Columns.Add("FINALIZAÇÃO", 150, HorizontalAlignment.Left)
                .Columns.Add("SUBFINALIZAÇÃO", 150, HorizontalAlignment.Left)
                .Columns.Add("OBSERVAÇÃO", 300, HorizontalAlignment.Left)
            End With
            'POPULANDO
            If dt.Rows.Count > 0 Then 'verifica se existem registros
                For Each drRow As DataRow In dt.Rows
                    Dim item As New ListViewItem()
                    item.Text = drRow("id")
                    item.SubItems.Add(drRow("fila"))
                    item.SubItems.Add(IIf(IsDBNull(drRow("data_cat")), "", drRow("data_cat")))
                    item.SubItems.Add(IIf(IsDBNull(drRow("finalizacao")), "", drRow("finalizacao")))
                    item.SubItems.Add(IIf(IsDBNull(drRow("subfinalizacao")), "", drRow("subfinalizacao")))
                    item.SubItems.Add(IIf(IsDBNull(drRow("observacao")), "", drRow("observacao")))

                    If drRow("status") = 0 Then
                        item.ImageKey = 1 'verde
                    ElseIf drRow("status") = 1 Then
                        item.ImageKey = 2 'amarelo
                    Else
                        item.ImageKey = 3 'vermelho
                    End If
                    ltv.Items.Add(item)
                Next drRow
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

End Class
