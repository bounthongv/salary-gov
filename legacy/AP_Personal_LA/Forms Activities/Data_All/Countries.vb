Public Class Countries
    Private Sub Loadfg1()

        FG.FormatString = "ລ/ດ|<ລະຫັດ|< ຊື່                        "
        FG.Rows = 1
        With RSC
            Call LoadRs("Select *From Countries Order By  Country_ID ", RSC)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG.AddItem(.AbsolutePosition & vbTab & Trim(.Fields("Country_ID").Value) & vbTab & Trim(.Fields("Country_Name").Value))

                    .MoveNext()
                End While
            Else
                FG.Rows = 2
            End If
        End With

    End Sub
    Sub Cmdnew_Click()
        txtID.Enabled = True
        Ac_Save = False
        txtID.Text = ""
        Txtname.Text = ""
        txtID.Focus()
    End Sub
    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        On Error GoTo HH
        If txtID.Text = "" Then MsgBox("ທ່ານຍັງບໍ່ທັນໃສ່ລະຫັດ ບໍ່ສາມາດບັນທຶກ .", vbCritical) : txtID.Focus() : Exit Sub
        If Txtname.Text = "" Then MsgBox("ທ່ານຍັງບໍ່ທັນໃສ່ຊື່ ບໍ່ສາມາດບັນທຶກ .", vbCritical) : Txtname.Focus() : Exit Sub
        If Ac_Save = False Then
            Call LoadRs("Select * From Countries Where  Country_ID = '" & Trim(txtID.Text) & "'", RSC)
            If RSC.RecordCount > 0 Then
                MsgBox("ເລກລະຫັດນີ້ມີແລ້ວ ທ່ານຄວນປ່ຽນໃໜ່") : txtID.Focus()
                txtID.Focus()

                Exit Sub
            End If

            Conn.Execute("Insert Into Countries(Country_ID, Country_Name) " & _
            "Values('" & Trim(txtID.Text) & "', N'" & Trim(Txtname.Text) & "')")
            MsgBox("ເພີ່ມສຳເລັດແລ້ວ")
        Else
            Conn.Execute("Update Countries Set Country_Name = N'" & Trim(Txtname.Text) & "'" & _
            "Where  Country_ID = '" & Trim(txtID.Text) & "'")
            MsgBox("ແກ້ໄຂສຳເລັດແລ້ວ")
        End If
HH:
        If Err.Number <> 0 Then MsgBox(Err.Description)

        Cmdnew_Click()
        Loadfg1()
    End Sub

    Private Sub Badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badd.Click
        Cmdnew_Click()
    End Sub

    Private Sub Countries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Loadfg1()
        Call Cmdnew_Click()
    End Sub

    Private Sub Bdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If Me.txtID.Text = "" Then Exit Sub
        'Call LoadRs("Select countryID From APPersonnelDetail_sty Where countryID  =  '" & Trim(txtID.Text) & "'", RSC)
        'If RSC.RecordCount > 0 Then
        '    MsgBox("ເລກລະຫັດນີ້ໄດ້ນຳໃຊ້ເຂົ້າໃນປະຫັວດພະນັກງານແລ້ວ ບໍ່ສາມາດລຶບ.", vbCritical)

        '    Exit Sub
        'End If

        If MsgBox("ທ່ານຕ້ອງການລຶບຂໍ້ມູນນີ້ແມ່ນບໍ ?", vbYesNo + vbQuestion, "") = vbYes Then
            Conn.Execute("Delete From Countries Where  Country_ID = '" & Trim(txtID.Text) & "'")
            Call Cmdnew_Click()
            Loadfg1()
            Call Cmdnew_Click()
        End If
    End Sub

    Private Sub FG_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.DblClick
        txtID.Text = Trim(FG.get_TextMatrix(FG.Row, 1))
        Txtname.Text = Trim(FG.get_TextMatrix(FG.Row, 2))
        txtID.Enabled = False
        Ac_Save = True

    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange
        txtID.Text = Trim(FG.get_TextMatrix(FG.Row, 1))
        Txtname.Text = Trim(FG.get_TextMatrix(FG.Row, 2))
        txtID.Enabled = False
        Ac_Save = True
    End Sub

    Private Sub Bclos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclos.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Badd_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Bsave_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Bdelete_Click(sender, e)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txtID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Down
                txtname.Focus()
        End Select
    End Sub

    Private Sub txtname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtname.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Bsave_Click(sender, e)
            Case Keys.Up
                txtID.Focus()
        End Select
    End Sub
End Class