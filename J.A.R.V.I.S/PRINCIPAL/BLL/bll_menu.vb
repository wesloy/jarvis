Public Class bll_menu
    Private db As New dal_menu
    Private dt As New DataTable
    Public Sub SalvaMenu(ByVal _menu As dto_menu)
        db.Salvar(_menu)
    End Sub
    Public Sub DeletaMenu(ByVal _Id As Integer)
        db.DeletaMenuPorId(_Id)
    End Sub
    Public Sub CarregaCombobox(frm As Form, cb As ComboBox)
        db.GetComboboxMenus(frm, cb)
    End Sub
    Public Function GetNomeMenuPorId(idModulo As Integer) As String
        Return db.getNomeMenuPorId(idModulo)
    End Function
    Public Function GetComentarioMenuPorId(idModulo As Integer) As String
        Return db.getComentarioMenuPorId(idModulo)
    End Function

    Public Sub bloquearMenus(ByVal objMenuStrip As System.Windows.Forms.MenuStrip)
        Dim GrupoMenu As String = Microsoft.VisualBasic.Left(db.getNomeMenuPorId(sessaoIdModulo), 3) 'CAPTURA SOMENTE O NRO NO FORMATO 1.0
        Dim nomeMenus As String = String.Empty
        Dim MenusLiberados() As String ' = String.Empty
        Dim dados() As String
        Dim cont As Long = 0
        Dim i As Long = 0
        Dim i_ As Long = 0
        Dim inicio As Long
        Dim fim As Long
        'Salva o nome de todos os SubMenus em um array
        'ToostripMenuItem
        For Each tsmi In objMenuStrip.Items
            nomeMenus = nomeMenus & tsmi.Name.ToString & ";"
            cont = cont + 1
        Next tsmi

        'salva no array
        dados = Split(Microsoft.VisualBasic.Left(nomeMenus, Len(nomeMenus) - 1), ";")
        'captura o inicio e fim do array
        inicio = LBound(dados)
        fim = UBound(dados)
        Select Case GrupoMenu

            Case "1.0" '1.0 - ADMINISTRADOR
                'inicia a liberação uma a uma
                For i = inicio To fim
                    objMenuStrip.Items(dados(i)).Enabled = True
                Next i

            Case "2.0" '2.0 - RELATÓRIOS
                MenusLiberados = Split("tsmFilaTrabalho;tsmRelatorios;tsmSenha;tsmLogoff;tsmSair", ";")
                'inicia a liberação uma a uma
                For i = inicio To fim
                    For i_ = 0 To UBound(MenusLiberados)
                        If dados(i) = MenusLiberados(i_) Then
                            objMenuStrip.Items(MenusLiberados(i_)).Enabled = True
                        End If
                    Next i_
                Next i

            Case "3.0" '3.0 - USUÁRIO
                MenusLiberados = Split("tsmFilaTrabalho;tsmLogoff;tsmSenha;tsmSair", ";")
                'inicia a liberação uma a uma
                For i = inicio To fim
                    For i_ = 0 To UBound(MenusLiberados)
                        If dados(i) = MenusLiberados(i_) Then
                            objMenuStrip.Items(MenusLiberados(i_)).Enabled = True
                        End If
                    Next i_
                Next i

            Case "4.0" '4.0 - SEM ACESSO
                MenusLiberados = Split("tsmLogoff;tsmSair", ";")
                'inicia a liberação uma a uma
                For i = inicio To fim
                    For i_ = 0 To UBound(MenusLiberados)
                        If dados(i) = MenusLiberados(i_) Then
                            objMenuStrip.Items(MenusLiberados(i_)).Enabled = True
                        End If
                    Next i_
                Next i

        End Select
    End Sub
End Class
