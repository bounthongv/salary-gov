Public Class Frm_Salary_group
    Dim rs As New ADODB.Recordset

    Private Sub Frm_Salary_group_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລດ |<ລະຫັດ|<ຊື່ກຸ່ມ                                           |^ອັດຕາຊົວໂມວ|^ເປີເຊັນ  |^ອັດຕາຊົວໂມວ|^ເປີເຊັນ  |^ອັດຕາຊົວໂມວ|^ເປີເຊັນ  |^ອັດຕາຊົວໂມວ|^ເປີເຊັນ  |^ອັດຕາຊົວໂມວ|^ເປີເຊັນ   "
        'fg.set_ColHidden(1, True)
        'fg.set_ColHidden(2, True)

        Call LoadData()
        BtnAddNew_Click(sender, e)
        With rs
            Call LoadRs("select * from AP_Office  ", rs)
            If .RecordCount <> 0 Then
                'txtindex_money.Text = Format(CDbl(.Fields("index_monney").Value), "##,##0.00")

            End If
        End With
    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Group_SLR_id from Salary_group    Order by Group_SLR_id DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Group_SLR_id").Value, 1, 2)) + 1, "00")
        Else
            VIOTNEW = "01"

        End If
        Txt_ID.Text = Trim(CStr(VIOTNEW.ToString))

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Txt_ID.Text = "" Then MsgBox("Type ID !", MsgBoxStyle.OkOnly) : Txt_ID.Focus() : Exit Sub

        Call save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        Call LoadData()
        Txt_ID.Focus()
    End Sub
    Public Sub save()
        Call LoadRs("SELECT * FROM Salary_group where Group_SLR_id = '" & Txt_ID.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO Salary_group (Group_SLR_id, Group_SLR_nm, Group_100, Group_percen100, Group_90, Group_percen90, Group_80, Group_percen80, Group_70, Group_percen70) " & _
                   " VALUES('" & (Txt_ID.Text) & "'," & _
                   " N'" & txtnm.Text & "', " & _
                       " " & CDbl(txtGroup_100.Text) & ", " & _
                        " " & CDbl(txtGroup_percen100.Text) & ", " & _
                         " " & CDbl(txtGroup_90.Text) & ", " & _
                               " " & CDbl(txtGroup_percen90.Text) & ", " & _
                                 " " & CDbl(txtGroup_80.Text) & ", " & _
                               " " & CDbl(txtGroup_percen80.Text) & ", " & _
                                    " " & CDbl(txtGroup_70.Text) & ", " & _
                                         " " & CDbl(txtGroup_percen70.Text) & ", " & _
                                  " " & CDbl(txtGroup_60.Text) & ", " & _
                                 " " & CDbl(txtGroup_percen60.Text) & ")"
                Conn.Execute(aa)
            Else
                Conn.Execute("UPDATE Salary_group SET " & _
                              " Group_SLR_nm=N'" & txtnm.Text & "', " & _
                       " Group_100=" & CDbl(txtGroup_100.Text) & ", " & _
                      " Group_percen100=" & CDbl(txtGroup_percen100.Text) & ", " & _
                         " Group_90=" & CDbl(txtGroup_90.Text) & ", " & _
                      " Group_percen90=" & CDbl(txtGroup_percen90.Text) & ", " & _
                      " Group_80=" & CDbl(txtGroup_80.Text) & ", " & _
                      " Group_percen80=" & CDbl(txtGroup_percen80.Text) & ", " & _
                                            " Group_70=" & CDbl(txtGroup_70.Text) & ", " & _
                      " Group_percen70=" & CDbl(txtGroup_percen70.Text) & ", " & _
                         " Group_60=" & CDbl(txtGroup_60.Text) & ", " & _
                      " Group_percen60=" & CDbl(txtGroup_percen60.Text) & " " & _
                                   " WHERE Group_SLR_id= '" & (Txt_ID.Text) & "'  ")
            End If
        End With

    End Sub
    Public Sub LoadData()
        fg.Rows = 1
        With rs
            Call LoadRs("SELECT   * from Salary_group order by Group_SLR_id ", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("Group_SLR_id").Value.ToString) & _
                          Chr(9) & (.Fields("Group_SLR_nm").Value.ToString) & _
                       Chr(9) & (.Fields("Group_100").Value.ToString) & _
                    Chr(9) & (.Fields("Group_percen100").Value.ToString) & " %" & _
                       Chr(9) & (.Fields("Group_90").Value.ToString) & _
                    Chr(9) & (.Fields("Group_percen90").Value.ToString) & " %" & _
                       Chr(9) & (.Fields("Group_80").Value.ToString) & _
                    Chr(9) & (.Fields("Group_percen80").Value.ToString) & " %" & _
                       Chr(9) & (.Fields("Group_70").Value.ToString) & _
                       Chr(9) & (.Fields("Group_percen70").Value.ToString & " %") & _
                                Chr(9) & (.Fields("Group_60").Value.ToString) & _
                       Chr(9) & (.Fields("Group_percen60").Value.ToString & " %"))
                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub fg_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.ClickEvent

        txtnm.Text = fg.get_TextMatrix(fg.Row, 2)
        Txt_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        txtGroup_100.Text = fg.get_TextMatrix(fg.Row, 3)
        txtGroup_90.Text = fg.get_TextMatrix(fg.Row, 5)
        txtGroup_80.Text = fg.get_TextMatrix(fg.Row, 7)
        txtGroup_70.Text = fg.get_TextMatrix(fg.Row, 9)
        txtGroup_60.Text = fg.get_TextMatrix(fg.Row, 11)


    End Sub

    Private Sub fg_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DblClick
        If fg.Row = 0 Or fg.get_TextMatrix(fg.Row, 1) = "" Then Exit Sub
        Txt_ID.Enabled = False
        txtGroup_100.Text = fg.get_TextMatrix(fg.Row, 4)
        'txtindex_money.Text = fg.get_TextMatrix(fg.Row, 5)
        'txttoltle.Text = fg.get_TextMatrix(fg.Row, 6)
        txtnm.Text = fg.get_TextMatrix(fg.Row, 2)
        Txt_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        txtGroup_percen100.Text = fg.get_TextMatrix(fg.Row, 3)
    End Sub

    Private Sub fg_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.SelChange

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Txt_ID.Text = ""
        txtnm.Text = ""
        Txt_ID.Visible = True
        Txt_ID.Enabled = True
        txtGroup_100.Text = 0
        txtGroup_90.Text = 0
        txtGroup_80.Text = 0
        txtGroup_70.Text = 0

        AutoNumber()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການນີ້: " & Trim(fg.get_TextMatrix(fg.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From Level_class Where  no=N'" & Trim(fg.get_TextMatrix(fg.Row, 2)) & "' ")
            Call LoadData()
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TxtPV_NM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPV_NM.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Province Where   PV_nm =N'" & Trim(TxtPV_NM.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            TxtPV_ID.Text = Trim(rs("PV_ID").Value)
        End If
        Call LoadData()
    End Sub

    Private Sub txtindex_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub txtindex_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGroup_100.KeyPress
        If e.KeyChar = Chr(13) Then

            'txttoltle.Text = CDbl(txtindex.Text) * CDbl(txtindex_money.Text)
            'txttoltle.Text = Format(CDbl(txttoltle.Text), "#,##0.00")
        End If
    End Sub
 
  
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroup_90.TextChanged

    End Sub

    Private Sub txtGroup_70_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroup_70.TextChanged

    End Sub
End Class