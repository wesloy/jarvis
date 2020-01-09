Public Class dto_clientes
    Public Property id As Integer
    Public Property cliente As String
    Public Property companheiro As String
    Public Property telefone As String
    Public Property celular As String
    Public Property email As String
    Public Property instagram As String
    Public Property facebook As String
    Public Property dataNascimento As Date
    Public Property gestante As Boolean
    Public Property semanasGestacao As Integer
    Public Property previsaoNascimento As Date
    Public Property qtdeFilhos As Integer
    Public Property cpf As String
    Public Property observacao As String

    'Tabela auxiliar tb_cliente_filhos
    Public Property id_filhos As Integer
    Public Property id_tblClientes As Integer
    Public Property nomeFilho As String
    Public Property sexo As String
    Public Property dataNascimento_filho As Date


    'Controles de registros
    Public Property ativo As Boolean
    Public Property dataCadastro As Date
    Public Property idCadastro As String
    Public Property acao As Byte


End Class
