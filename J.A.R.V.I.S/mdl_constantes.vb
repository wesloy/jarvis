Imports System.Configuration
Module mdl_constantes
    'Path de configurações do sistema
    Public PATH_ICONS As String = Application.StartupPath & ConfigurationManager.AppSettings("PATH_ICONS")
    Public PATH_IMAGENS As String = Application.StartupPath & ConfigurationManager.AppSettings("PATH_IMAGENS")
    Public PATH_PASTA_MIS As String = Application.StartupPath & ConfigurationManager.AppSettings("PATH_PASTA_MIS")
    Public PATH_PASTA_ANEXO As String = Application.StartupPath & ConfigurationManager.AppSettings("PATH_PASTA_ANEXO")
    Public PATH_LOG_IMPORT As String = Application.StartupPath & ConfigurationManager.AppSettings("PATH_LOG_IMPORT")
    Public PATH_MODELOS As String = Application.StartupPath & ConfigurationManager.AppSettings("PATH_MODELOS")
    Public PATH_RELATORIOS As String = Application.StartupPath & ConfigurationManager.AppSettings("PATH_RELATORIOS")
    Public PATH_BD As String = Application.StartupPath & ConfigurationManager.AppSettings("PATH_BD")

    'Determinador de qual BD irá usar
    Public SGBD As String = ConfigurationManager.AppSettings("SGBD")

    'const BD
    Public _BD As String = ConfigurationManager.AppSettings("BD")
    Public _SERVIDOR As String = ConfigurationManager.AppSettings("SERVIDOR")
    Public _USER As String = ConfigurationManager.AppSettings("USER")
    Public _PWD As String = GetConfig("PWD")

    'Constantes DO SISTEMA
    Public Const TITULO_ALERTA = ".: J.A.R.V.I.S Informa :. "
    Public Const FormatoDataUniversal = "yyyy-MM-dd"
    Public Const FormatoDataHoraUniversal = "yyyy-MM-dd HH:mm:ss"
    Public Const CREDITOS = "Wesley Eloy"
    Public Const Copyright = "Copyright © Microsoft"

    Public Function GetConfig(key As String) As String
        'Método que pega os valores do arquivo de configuração e decriptografa.
        Dim crypt As New Uteis.Helpers
        Return crypt.Decrypt(ConfigurationManager.AppSettings(key))
    End Function

    Public Function FlagRoteamentoRetornaExpressao(ByVal _valorParaCalculo As Integer) As String

        Select Case _valorParaCalculo
            Case 0
                Return "Hoje"
            Case 1
                Return "Amanhã"
            Case 2
                Return "Depois de amahã"
            Case 7
                Return "1 semana"
            Case 15
                Return "15 dias"
            Case 30
                Return "1 mês"
            Case 60
                Return "2 meses"
            Case 90
                Return "3 meses"
            Case 180
                Return "6 meses"
            Case 360
                Return "1 ano"
            Case 720
                Return "2 anos"
        End Select
        Return 0
    End Function

    Public Function FlagRoteamentoRetornaDias(ByVal _valorParaCalculo As String) As Integer

        Select Case _valorParaCalculo
            Case "Hoje"
                Return 0
            Case "Amanhã"
                Return 1
            Case "Depois de amahã"
                Return 2
            Case "1 semana"
                Return 7
            Case "15 dias"
                Return 15
            Case "1 mês"
                Return 30
            Case "2 meses"
                Return 60
            Case "3 meses"
                Return 90
            Case "6 meses"
                Return 180
            Case "1 ano"
                Return 360
            Case "2 anos"
                Return 720
        End Select
        Return 0
    End Function

    Public Enum FlagAcao
        Insert = 1
        Update = 2
        Delete = 3
        NoAction = 0
    End Enum

    Public Enum FlagStatus
        LiberarRegistro = 0
        TrabalharRegistro = 1
        FinalizarRegistro = 2
    End Enum

    Public Function imglist() As ImageList
        'cria um imagelist se necessario
        Dim imageListSmall As New ImageList
        With imageListSmall
            '.ImageSize = New Size(16, 16) ' (the default is 16 x 16).
            .Images.Add(1, Image.FromFile(PATH_ICONS & "01.ico"))
            .Images.Add(2, Image.FromFile(PATH_ICONS & "02.ico"))
            .Images.Add(3, Image.FromFile(PATH_ICONS & "03.ico"))
            .Images.Add(4, Image.FromFile(PATH_ICONS & "04.ico"))
            .Images.Add(5, Image.FromFile(PATH_ICONS & "05.ico"))
            .Images.Add(6, Image.FromFile(PATH_ICONS & "06.ico"))
            .Images.Add(7, Image.FromFile(PATH_ICONS & "07.ico"))
            .Images.Add(8, Image.FromFile(PATH_ICONS & "08.ico"))
            .Images.Add(9, Image.FromFile(PATH_ICONS & "09.ico"))
            .Images.Add(10, Image.FromFile(PATH_ICONS & "10.ico"))
            .Images.Add(11, Image.FromFile(PATH_ICONS & "11.ico"))
            .Images.Add(12, Image.FromFile(PATH_ICONS & "12.ico"))
            .Images.Add(13, Image.FromFile(PATH_ICONS & "13.ico"))
            .Images.Add(14, Image.FromFile(PATH_ICONS & "14.ico"))
        End With
        'fim da criacao do imagelist
        Return imageListSmall
    End Function

    'Armazena as sessoes de login
    Public sessaoNomeUsuario As String
    Public sessaoIdUsuario As Integer
    Public sessaoIdModulo As Integer
    Public sessaoModulo As String

    'Armazena o SQL do ultimo relatório rodado...
    Public sql_relatorios As String
End Module
