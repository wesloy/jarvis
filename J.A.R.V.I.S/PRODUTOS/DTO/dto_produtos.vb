Public Class dto_produtos
    Public Property id As Integer
    Public Property produto As String
    Public Property sigla As String
    Public Property descricao As String
    Public Property valor As Double
    Public Property ativo As Boolean

    Public Property album As Boolean
    Public Property albumQtdeFolhas As Integer
    Public Property albumTamanho As String
    Public Property albumTipo As String

    Public Property painel As Boolean
    Public Property painelQtde As Integer
    Public Property painelTamanho As String
    Public Property painelMoldura As String

    Public Property caixa As Boolean
    Public Property caixaQtde As Integer
    Public Property caixaTamanho As String
    Public Property caixaTipo As String

    Public Property ensaios As Boolean
    Public Property ensaiosQtde As Integer
    Public Property ensaiosPeriodo As String
    Public Property ensaiosMeses As String

    Public Property dataCadastro As Date
    Public Property idCadastro As String
    Public Property acao As Byte
End Class
