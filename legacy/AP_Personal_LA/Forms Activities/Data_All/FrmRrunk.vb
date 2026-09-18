Public Class FrmRrunk

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmRrunk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadfg()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Call addnew()
    End Sub
    Private Sub addnew()
        TxtID.Text = ""
        TxtID.Enabled = True
        txtname.Text = ""
        txtname.Enabled = True
        TxtID.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtID.Text = "" Then MsgBox("ທ່ານຍັງບໍ່ໃສ່ລະຫັດ ບໍ່ສາມາດບັນທຶກໄດ້!", MsgBoxStyle.OkOnly) : TxtID.Focus() : Exit Sub
        If txtname.Text = "" Then MsgBox("ທ່ານຍັງບໍ່ໃສ່ຊື່ ບໍ່ສາມາດບັນທຶກໄດ້!", MsgBoxStyle.OkOnly) : TxtID.Focus() : Exit Sub
        If TxtID.Enabled = True Then
            Call LoadRs("SELECT Runk_ID FROM Rrunk WHERE Runk_ID= '" & Trim(TxtID.Text) & "'", RSC)
            If RSC.RecordCount > 0 Then
                MsgBox("ລະຫັດ :" & Trim(TxtID.Text) & "ມີແລ້ວ , ກະລຸນາປ່ຽນ!", MsgBoxStyle.OkOnly) : Exit Sub
                TxtID.Focus()
                If RSC.State = ConnectionState.Open Then RSC.Close()
                Exit Sub
            End If
            If RSC.State = ConnectionState.Open Then RSC.Close()
        End If
        Call LoadRs("SELECT Runk_ID FROM Rrunk WHERE Runk_ID= '" & Trim(TxtID.Text) & "'", RSC)
        If RSC.RecordCount = 0 Then
            Call Saves()
        Else
            Updates()
        End If
        MsgBox("ບັນທຶກສໍາເລັດ!", MsgBoxStyle.OkOnly)
        Loadfg()
    End Sub
    Private Sub saves()
        Conn.Execute("INSERT INTO Rrunk(Runk_ID,RunK_name) " & _
                    "VALUES(N'" & (TxtID.Text.Trim) & "', " & _
                   " N'" & txtname.Text & "')")
    End Sub
    Private Sub updates()
        Conn.Execute("UPDATE Rrunk SET " & _
                       "Runk_ID=N'" & TxtID.Text & "' ," & _
                     "RunK_name=N'" & txtname.Text & "' " & _
                     "WHERE Runk_ID= '" & (TxtID.Text) & "'")
    End Sub
    Private Sub loadfg()
        FG.FormatString = "^ລ/ດ|<ລະຫັດ |<  ຊື່                                 "
        FG.Rows = 1
        With RSC
            Call LoadRs("SELECT * FROM Rrunk  ", RSC)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG.AddItem(.AbsolutePosition & vbTab & Trim(CStr(.Fields("Runk_ID").Value)) & vbTab & Trim(CStr(.Fields("RunK_name").Value)))
                    .MoveNext()
                End While
            Else
                FG.Rows = 2
            End If
        End With
        TxtID.Focus()
    End Sub

    Private Sub BtnDele_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDele.Click
        If Me.TxtID.Text = "" Then Exit Sub
        If MsgBox("Do you want to delete ?", vbYesNo + vbQuestion, "") = vbYes Then
            Conn.Execute("Delete From Rrunk Where  Runk_ID = '" & Trim(TxtID.Text) & "'")
            If FG.Rows = 1 Then FG.Rows = 2
        End If
        Call addnew()
        Call loadfg()
    End Sub

    Private Sub FG_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.DblClick
        TxtID.Text = FG.get_TextMatrix(FG.Row, 1)
        txtname.Text = FG.get_TextMatrix(FG.Row, 2)
        TxtID.Enabled = False
    End Sub

    Private Sub FG_MouseUpEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_MouseUpEvent) Handles FG.MouseUpEvent
        TxtID.Text = FG.get_TextMatrix(FG.Row, 1)
        txtname.Text = FG.get_TextMatrix(FG.Row, 2)
        TxtID.Enabled = False
    End Sub

    Private Sub TxtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtID.KeyPress
        If e.KeyChar = Chr(13) Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If e.KeyChar = Chr(13) Then
            BtnSave_Click(sender, e)
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtID.TextChanged

    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange

    End Sub
End Class