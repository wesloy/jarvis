Public Class dto_bancos
    Public Property id As Integer
    Public Property nomeBanco As String
    Public Property codBanco As Integer
    Public Property agencia As Integer
    Public Property digitoAgencia As Integer
    Public Property contaCorrente As Integer
    Public Property digitoContaCorrente As Integer
    Public Property saldo As Double
    Public Property observacao As String

    'Controles de registros
    Public Property ativo As Boolean
    Public Property dataCadastro As Date
    Public Property idCadastro As String
    Public Property acao As Byte
End Class
