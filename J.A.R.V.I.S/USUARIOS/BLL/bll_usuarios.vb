Public Class bll_usuarios
    Private dt As New DataTable
    Private dal As New dal_usuarios
    Private hlp As New Uteis.Helpers
    Private dto As New dto_usuarios

    Public Function AtualizaListViewUsuarios(Optional ByVal filtro As String = "") As Boolean 'Função para carregar o listview de usuario
        Dim cont As Long = 0
        dt = dal.GetUsuarios(filtro)
        frmCadUsuarios.ListView1.Clear()
        'AJUSTANDO AS COLUNAS
        With frmCadUsuarios.ListView1
            .View = View.Details
            .LabelEdit = False
            .CheckBoxes = False
            .SmallImageList = imglist() 'Utilizando um modulo publico
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ID", 50, HorizontalAlignment.Center)
            .Columns.Add("NOME", 350, HorizontalAlignment.Left)
            .Columns.Add("NÍVEL DE ACESSO", 200, HorizontalAlignment.Left)
            .Columns.Add("DATA MANUTENÇÃO", 130, HorizontalAlignment.Left)
            .Columns.Add("RESPONSÁVEL MANUTENÇÃO", 220, HorizontalAlignment.Left)
        End With
        'POPULANDO
        If dt.Rows.Count > 0 Then 'verifica se existem registros
            For Each drRow As DataRow In dt.Rows
                Dim item As New ListViewItem()
                item.Text = drRow("id")
                item.SubItems.Add(drRow("nome"))
                item.SubItems.Add(drRow("perfilAcesso"))
                item.SubItems.Add(drRow("dataCadastro"))
                item.SubItems.Add(drRow("responsavel"))
                'item.SubItems.Add(drRow("situacao"))
                If drRow("ativo") Then
                    item.ImageKey = 1 'verde
                Else
                    item.ImageKey = 3 'vermelho
                End If
                frmCadUsuarios.ListView1.Items.Add(item)
                cont = cont + 1
            Next drRow
        End If
        frmCadUsuarios.lbTotalRegistros.Text = cont
        Return True
    End Function
    Public Sub ResetSenha(ByVal id As Integer)

        If dal.AtualizarSenha(id) Then
            MsgBox("Reset de senha ocorrido com sucesso!", vbInformation, TITULO_ALERTA)
        Else
            MsgBox("Ocorreu um erro ao tentar resetar a senha!", vbCritical, TITULO_ALERTA)
        End If

    End Sub
    Public Function atualizarSenha(ByVal usuario As String, ByVal senhaAtual As String, ByVal senhaNova As String, ByVal senhaConfirmacao As String) As Boolean

        dto = GetUsuariosPorNome(usuario.Trim())
        If IsNothing(dto.nome) Then
            MsgBox("Usuário não localizado para que a senha seja atualiazada!", vbInformation, TITULO_ALERTA)
            Return False
        End If

        If dto.senha <> hlp.Encrypt(senhaAtual) Then
            MsgBox("Senha atual é diferente da senha digitada!", vbInformation, TITULO_ALERTA)
            Return False
        End If

        If senhaNova <> senhaConfirmacao Then
            MsgBox("Nova senha e confirmação de senha são diferentes!", vbInformation, TITULO_ALERTA)
            Return False
        End If

        If dal.AtualizarSenha(dto.id, senhaNova) Then
            MsgBox("Senha atualizada com sucesso!", vbInformation, TITULO_ALERTA)
            Return True
        Else
            MsgBox("Ocorreu um erro ao tentar atualizar a senha!", vbCritical, TITULO_ALERTA)
            Return False
        End If

    End Function
    Public Sub PreencheComboboxUsuariosAtivos(frm As Form, cb As ComboBox, Optional ByVal area As Integer = 0)
        dal.GetComboboxUsuarios(frm, cb, area)
    End Sub

    Public Function GetUsuariosPorCodigo(ByVal _usuarioId As Integer) As dto_usuarios
        Return dal.GetUsuarioPorId(_usuarioId)
    End Function
    Public Function GetUsuariosPorNome(ByVal _nome As String) As dto_usuarios
        Return dal.GetUsuarioPorNome(_nome)
    End Function
    Public Function SalvaUsuario(ByVal _usuario As dto_usuarios) As Boolean
        If dal.ValidacaoNome(_usuario.nome, _usuario.id) Then
            Return dal.Salvar(_usuario)
        Else
            Return False
        End If
    End Function
    Public Function DeletaUsuario(ByVal _usuarioId As Integer) As Boolean
        Return dal.DeletaUsuarioPorId(_usuarioId)
    End Function

    Public Function listaUsuariosAtivos() As DataTable
        Return dal.getListaUsuariosAtivos
    End Function



End Class
