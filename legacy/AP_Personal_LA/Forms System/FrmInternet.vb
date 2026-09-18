Public Class FrmInternet

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.Url = New System.Uri(TextBox1.Text)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            WebBrowser1.Url = New System.Uri(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub FrmInternet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TextBox1.Text = INternet
        'WebBrowser1.Url = New System.Uri(INternet)
    End Sub
End Class