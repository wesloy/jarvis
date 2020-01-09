
Public Class frmSplash

    Dim hlp As New Uteis.Helpers
    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Version.Text = My.Application.Info.Version.ToString
        Copyright.Text = My.Application.Info.Copyright.ToString
        Company.Text = My.Application.Info.CompanyName.ToString
        desenvolvido.Text = My.Application.Info.Description.ToString
        InitializeMyTimer()
    End Sub

    Private Sub IncreaseProgressBar(ByVal sender As Object, ByVal e As EventArgs)
        'ProgressBar1.Increment(10)
        ProgressBar1.Value = ProgressBar1.Value + 10
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        'Debug.Print(ProgressBar1.Value)
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            time.Stop()
            'frmLogin.Show()
        End If
    End Sub

    Private time As New Timer()
    Private Sub InitializeMyTimer()
        time.Enabled = True
        time.Interval = 110
        'milisegundos 1000 = 1 segundo
        AddHandler time.Tick, AddressOf IncreaseProgressBar
        time.Start()
    End Sub
End Class