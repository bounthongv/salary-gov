Imports System.Data.SqlClient
Public Class FrmBackup_Database
    Dim MyProgress As Integer
    '===================BackUpData==========================
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Function Factorial(ByVal Value As Double) As Double
        If (Value = 0) Then
            Factorial = 1.0
            System.Threading.Thread.Sleep(3000)
        Else
            Factorial = Value * Factorial(Math.Ceiling(Value - 1))
        End If
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dl As New FolderBrowserDialog
        dl.ShowDialog()
        If dl.SelectedPath = "" Then
            txtSaveIn.Text = "C:\Backup data"
        Else
            txtSaveIn.Text = dl.SelectedPath
            ProgressBar1.Value = 0
            MyProgress = 0
        End If
    End Sub
    Private Sub FrmBackup_Database_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Call Connect()
        ProgressBar1.Value = 0
        MyProgress = 0
        txtFileNane.Text = MDDatabaName & "-" & DateString
        Call Langs()
    End Sub
    Private Sub Langs()
        Button1.Text = "Backup"
        Button2.Text = "Cancle"
        Label1.Text = "File State:"
        Label2.Text = "File name:"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.Step = 1
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = MyProgress
        If MyProgress < 100 Then MyProgress = MyProgress + 5
        LbStatus.Text = "BackUp Data= " & MyProgress & "%"
        If MyProgress = 100 Then
            con = New SqlConnection("Data Source='" & MDServerName & "';Integrated Security=SSPI;Initial Catalog='"& MDDatabaName &"'")
            cmd = New SqlCommand("backup database " & MDDatabaName & " to disk='" & txtSaveIn.Text & "\" & txtFileNane.Text & ".bak" & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            LbStatus.Text = "BackUp Data " & "(" & "Complete" & ")"
            Timer1.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub
End Class