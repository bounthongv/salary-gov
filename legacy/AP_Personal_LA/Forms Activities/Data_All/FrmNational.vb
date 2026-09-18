Public Class FrmNationall
    Dim AccCD As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FrmNationall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDataList()
    End Sub

    Private Sub BAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAddnew.Click
        Call addnew()
    End Sub
    Private Sub addnew()
        txtID.Text = ""
        txtID.Enabled = True
        txtname.Text = ""
        txtID.Focus()
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If txtID.Text = "" Then MsgBox("ທ່ານຍັງບໍ່ໃສ່ລະຫັດ ກະລຸນາໃສ່ລະຫັດ!", MsgBoxStyle.OkOnly) : txtID.Focus() : Exit Sub
        If txtname.Text = "" Then MsgBox("ທ່ານຍັງບໍ່ໃສ່ຊື່ ກະລຸນາໃສ່ຊື່!", MsgBoxStyle.OkOnly) : txtname.Focus() : Exit Sub
        If txtID.Enabled = True Then
         
        End If
        Call LoadRs("SELECT NationID FROM Nationall WHERE NationID= '" & Trim(txtID.Text) & "'", RSC)
        If RSC.RecordCount = 0 Then
            Call saves()
        Else
            updates()
        End If
        MsgBox("ບັນທຶກສໍາເລັດ!", MsgBoxStyle.OkOnly)
        Call loadDataList()
    End Sub
    Private Sub saves()
        Conn.Execute("INSERT INTO Nationall(NationID,NationNmL) " & _
                     "VALUES(N'" & (txtID.Text.Trim) & "' , " & _
                     "N'" & txtname.Text & "')")
    End Sub
    Private Sub updates()
        Conn.Execute("UPDATE Nationall set " & _
                     "NationNmL=N'" & txtname.Text & "' " & _
                     "WHERE NationID = '" & (txtID.Text) & "'")
    End Sub
    Private Sub loadDataList()
        FG.FormatString = "^ລ/ດ  |< ລະຫັດ     |<  ຊື່                         "
        FG.Rows = 1
        Call LoadRs("SELECT * FROM Nationall ORDER BY NationID ", RSC)
        With RSC
            If .RecordCount > 0 Then
                While Not .EOF
                    FG.AddItem(.AbsolutePosition & vbTab & Trim(CStr(.Fields("NationID").Value)) & vbTab & Trim(CStr(.Fields("NationNmL").Value)))
                    .MoveNext()
                End While
            Else
                FG.Rows = 2
            End If
        End With
        txtID.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtID.Text = "" Then Exit Sub
        If MessageBox.Show("Do you want to delete '" & AccCD & "' yes or no ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute(" DELETE FROM Nationall WHERE NationID ='" & txtID.Text & "'")
            If FG.Rows = 1 Then FG.Rows = 2
        End If
        Call addnew()
        Call loadDataList()
    End Sub

    Private Sub FG_MouseUpEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_MouseUpEvent) Handles FG.MouseUpEvent
        txtID.Text = FG.get_TextMatrix(FG.Row, 1)
        txtname.Text = FG.get_TextMatrix(FG.Row, 2)
        txtID.Enabled = False
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        If e.KeyChar = Chr(13) Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If e.KeyChar = Chr(13) Then
            Bsave_Click(sender, e)
        End If
    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange
        AccCD = FG.get_TextMatrix(FG.Row, 2)
    End Sub
End Class