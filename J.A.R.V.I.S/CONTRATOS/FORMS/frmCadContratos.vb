Public Class frmCadContratos

    Private Captura As Bitmap


    Private Sub CapturarForm()
        Dim Rect As WindowHelper.Rect
        WindowHelper.DwmGetWindowAttribute(Me.Handle, CInt(WindowHelper.Dwmwindowattribute.DwmwaExtendedFrameBounds),
                                       Rect, System.Runtime.InteropServices.Marshal.SizeOf(GetType(WindowHelper.Rect)))
        Dim Rectangle = Rect.ToRectangle()

        Captura = New Bitmap(Rectangle.Width, Rectangle.Height)
        Dim Graphics = System.Drawing.Graphics.FromImage(Captura)
        Graphics.CopyFromScreen(Rectangle.Left, Rectangle.Top, 0, 0, Rectangle.Size)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        CapturarForm()
        PrintDocument.Print()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        e.Graphics.DrawImage(Captura, 20, 20)
    End Sub
End Class