Public Class Bll_log
    Private hlp As New Uteis.Helpers
    Public Sub RegistrarLOG(Optional ByVal erroNumero As String = "", Optional ByVal erroDescricao As String = "", Optional ByVal funcaoExecutada As Object = "", Optional ByVal acao As String = "")
        Dim logDTO As New dto_log
        Dim logDAL As New dal_log
        With logDTO
            .data = Now()
            .idUsuario = sessaoIdUsuario
            .erroDescricao = erroDescricao.ToString
            .erroNumero = erroNumero.ToString
            .funcaoExecutada = funcaoExecutada.ToString
            .versaoSis = hlp.versaoSistema()
            .idiomaPC = hlp.retornaIdiomaPC()
            .hostname = Environ("COMPUTERNAME")
            .acao = acao.ToString
        End With
        logDAL.Incluir(logDTO)
    End Sub

    Public Sub FecharAplicativo(ByVal enviarMsg As Boolean)

        Dim fechar As Boolean = True

        If enviarMsg Then
            'Temos opção de enviar ou não msg, visto que quando o usuário fecha por ALT+F4 
            'ou BOTÃO DIREITO Do MOUSE não é possível questionar se deseja ou não fechar, 
            'pq o aplicativo irá fechar de toda forma.
            If MsgBox("Deseja realmente fechar o aplicativo?", vbQuestion + vbYesNo, TITULO_ALERTA) = vbNo Then
                fechar = False
            End If
        End If

        'Função para fechar o aplicativo
        If fechar Then
            'registrar na tbl de usuários a saída do sistema
            logOut()
            Application.Exit()
        End If

    End Sub

    Public Sub logOut()
        Try
            RegistrarLOG(,, hlp.getCurrentMethodName, "Logout")
        Catch ex As Exception

        End Try
    End Sub

    Public Function Autenticar(ByVal _nome As String, ByVal _senha As String) As Boolean 'autentica o usuário e efetura Login

        Try
            Dim dto_user As New dto_usuarios
            Dim bll_user As New bll_usuarios
            dto_user = bll_user.GetUsuariosPorNome(_nome)


            'não autenticado
            If IsNothing(dto_user.nome) Then 'String.IsNullOrEmpty(login.Nome)
                MsgBox("O usuário digitado não tem acesso ao J.A.R.V.I.S!", vbCritical, TITULO_ALERTA)
                'Application.DoEvents()
                Application.Exit()
                Return False
                Exit Function
            Else

                If dto_user.senha <> hlp.Encrypt(_senha) Then
                    MsgBox("A senha digitada está incorreta!", vbCritical, TITULO_ALERTA)
                    'Application.DoEvents()
                    Application.Exit()
                    Return False
                    Exit Function
                End If

                'autenticado
                With dto_user
                    'Salva as informações nas variaveis de sessão publicas
                    sessaoIdUsuario = .id
                    sessaoNomeUsuario = hlp.abreviaNome(.nome)
                    sessaoIdModulo = .perfilAcesso
                End With
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    'Função para abrir/redirecionar para um determinado formulario a partir de uma string
    'autentica usuário e redirecionar caso necessário
    Public Sub Redireciona(ByVal _nomeForm As String)
        Try
            Select Case _nomeForm
                Case "frmPrincipal"
                    hlp.abrirForm(frmPrincipal,, True)
                    hlp.fecharForm(frmLogin)
            End Select
        Catch ex As Exception
            RegistrarLOG(Err.Number, Err.Description, hlp.getCurrentMethodName, "Redirecionamento de Login")
        End Try

    End Sub

End Class
