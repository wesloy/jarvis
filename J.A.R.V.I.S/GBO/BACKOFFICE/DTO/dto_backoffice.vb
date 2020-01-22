Public Class dto_backoffice
    Public Property id As Integer
    Public Property roteamento_id As Integer
    Public Property fila_id As Integer
    Public Property status As Integer
    Public Property tipo_registro As String 'A ou M (Automático ou Manual)
    Public Property cliente_id As Integer
    Public Property produto_id As Integer
    Public Property contrato_id As Integer
    Public Property contrato_assinado As Boolean
    Public Property pgto_realizado As Boolean
    Public Property finalizacao_id As Integer
    Public Property subfinalizacao_id As Integer
    Public Property observacao As String
    Public Property data_cat As Date
    Public Property usuario_cat As Integer
    Public Property data_imp As Date
    Public Property usuario_imp As Integer
    Public Property acao As Byte

    'Variáveis auxiliares
    Public Property fila_desc As String
    Public Property cliente_desc As String
    Public Property produto_desc As String
    Public Property contrato_desc As String
    Public Property finalizacao_desc As String
    Public Property subfinalizacao_desc As String
    Public Property usuario_cat_desc As String
    Public Property usuario_imp_desc As String



End Class
