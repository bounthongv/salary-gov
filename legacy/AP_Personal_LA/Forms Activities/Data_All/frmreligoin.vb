Public Class frmreligoin
    Private Sub Loadfg1()

        FG.FormatString = "^ລ/ດ |<ລະຫັດ |< ຊື່ສາດສະໜາ                                    "
        FG.Rows = 1
        With RSC
            Call LoadRs("Select * From religoin Order By  religoin_ID ", RSC)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG.AddItem(.AbsolutePosition & vbTab & (.Fields("religoin_ID").Value.ToString) & vbTab & (CStr(.Fields("Namereligoin").Value.ToString)))

                    .MoveNext()
                End While
            Else
                FG.Rows = 2
            End If
        End With
    End Sub
    Sub addnew()
        Ac_Save = False
        txtID.Enabled = True
        txtID.Text = ""
        txtname.Text = ""
        txtID.Focus()
    End Sub

    Private Sub Badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badd.Click
        addnew()
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        If Me.txtID.Text = "" Then MsgBox("ທ່ານຍັງບໍ່ທັນໃສ່ລະຫັດ ບໍ່ສາມາດບັນທຶກ .", vbCritical) : txtID.Focus() : Exit Sub
        If Me.txtname.Text = "" Then MsgBox("ທ່ານຍັງບໍ່ທັນໃສ່ຊື່ ບໍ່ສາມາດບັນທຶກ .", vbCritical) : txtname.Focus() : Exit Sub
        If Ac_Save = False Then

            Conn.Execute("Insert Into religoin(religoin_ID,Namereligoin) Values('" & Trim(txtID.Text) & "',N'" & Trim(txtname.Text) & "')")
        Else

            Conn.Execute("Update religoin Set Namereligoin=N'" & Trim(txtname.Text) & "'  Where  religoin_ID='" & Trim(txtID.Text) & "'")
        End If
        MsgBox("Save Completed")
        Ac_Save = True
        Loadfg1()
        Call addnew()
    End Sub
    Sub dels()
        If txtID.Text = "" Then Exit Sub
        If MsgBox("Do you want to delete ID'" & txtID.Text & "' ?", vbYesNo + vbQuestion, "") = vbYes Then
            Conn.Execute("Delete From religoin Where  religoin_ID='" & Trim(txtID.Text) & "'")
        End If
        Loadfg1()
        addnew()
    End Sub



    Private Sub Bdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdel.Click
        dels()
    End Sub

    Private Sub frmreligoin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Loadfg1()
        addnew()
    End Sub

    Private Sub FG_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.DblClick
        
    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange
        txtID.Text = FG.get_TextMatrix(FG.Row, 1)
        txtname.Text = FG.get_TextMatrix(FG.Row, 2)
        txtID.Enabled = False
        Ac_Save = True
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        If e.KeyChar = Chr(13) Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If e.KeyChar = Chr(13) Then
            Bsave.Focus()
        End If
    End Sub

    Private Sub Bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclose.Click
        Me.Close()

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Badd_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Bsave_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Bdel_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class