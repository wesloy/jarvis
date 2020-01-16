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
                        .id = id_locado
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


End Class
