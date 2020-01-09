Public Class dto_finalizacoes
    'Utilizando a nova sintaxe do .Net
    'Propriedades autoimplementadas permitem que você 
    'especifique uma propriedade de uma classe rapidamente sem precisar 
    'escrever código para os Gets e Sets.
    'Fonte: https://msdn.microsoft.com/pt-br/library/dd293589.aspx

    'Geral
    Public Property ID As Integer
    Public Property descricao As String
    Public Property situacao As Boolean
    Public Property idFila As Integer

    'Roteamentos
    Public Property geraNovoCaso As Boolean
    Public Property agingNovoCaso As Integer
    Public Property filaNovoCaso As Integer
    Public Property renomearParaRoteamento As Boolean


    'Caracterização da finalização
    Public Property cttoPassivelEfetividade As Boolean
    Public Property cttoEfetivo As Boolean

    Public Property dataCadastro As Date
    Public Property idCadastro As String

    Public Property Acao As Byte
End Class
