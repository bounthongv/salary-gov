Public Class FrmSet_as_default_printer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub FrmSet_as_default_printer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim R As Long
            Dim Buffer As String
            Buffer = Space(8192)
            R = GetSetting("PrinterPorts", vbNullString, "", Buffer)
            Fg.AddItem(RSC.AbsolutePosition, Buffer)
        Catch ex As Exception

        End Try
    End Sub
End Class