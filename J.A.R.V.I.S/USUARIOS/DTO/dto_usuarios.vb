Public Class dto_usuarios
    'Utilizando a nova sintaxe do .Net
    'Propriedades autoimplementadas permitem que você 
    'especifique uma propriedade de uma classe rapidamente sem precisar 
    'escrever código para os Gets e Sets.
    'Fonte: https://msdn.microsoft.com/pt-br/library/dd293589.aspx

    Public Property id As Integer
    Public Property nome As String
    Public Property senha As String
    Public Property ativo As Boolean
    Public Property dataCadastro As Date
    Public Property idCadastro As String
    Public Property perfilAcesso As Integer
    Public Property Acao As Byte
End Class
