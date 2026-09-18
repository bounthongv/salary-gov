Public Class frmAddditional_Deducation_List
    Dim id As String
    Private Sub FrmSubpro_ject_group_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call Loadlang()
        'SetControlText(Me)
        'ChgChildForm()
        FG.set_ColDataType(4, VSFlex8U.DataTypeSettings.flexDTBoolean)
        FG2.set_ColDataType(4, VSFlex8U.DataTypeSettings.flexDTBoolean)
        FG1_After.set_ColDataType(4, VSFlex8U.DataTypeSettings.flexDTBoolean)
        FG2_After.set_ColDataType(4, VSFlex8U.DataTypeSettings.flexDTBoolean)
        txtid.Enabled = False
        Call addnew()
        'Call ItemNew()

        'FG.FormatString = "^No  |<ID         |<Name                       |<Days Leave |<Cut day work"
        FG.FormatString = "^No |<Code   |<Description      |<Amount Money  "
        FG2.FormatString = "^No |<Code   |<Description      |<Amount Money  "
        FG1_After.FormatString = "^No |<Code   |<Description      |<Amount Money  "
        FG2_After.FormatString = "^No |<Code   |<Description      |<Amount Money  "
        'Button3.Text = "Add New"
        'Button1.Text = "Save"
        'Button10.Text = "Delete"
        'If Lang = True Then
        '    Label20.Text = "Additional  Befor Tax"
        '    Label36.Text = "Deductions Befor Tax"
        '    Label40.Text = "Additional  After Tax  "
        '    Label3.Text = "Deductions After Tax"

        'Else
        Label20.Text = "ລາຍການເງີນເພີ່ມກ່ອນອາກອນ"
        Label36.Text = "ລາຍການເງີນລົບກ່ອນອາກອນ"
        Label40.Text = "ລາຍການເງີນເພີ່ມຫຼັງອາກອນ"
        Label3.Text = "ລາຍການເງີນລົບຫຼັງອາກອນ"
        'End If
     
        Call loadlist1()
        Call loadlist2()
        Call loadlist3()
        Call loadlist4()
    End Sub
    Private Sub ItemNew()
        Dim cRS As New ADODB.Recordset
        Dim mstNew, sss As String
        sss = "SELECT TOP 1 LeaveTypeID  FROM ListLeaveType  ORDER BY LeaveTypeID DESC"
        Call LoadRs(sss, cRS)
        If cRS.RecordCount <> 0 Then
            mstNew = Format(Val(Mid(cRS.Fields("LeaveTypeID").Value, 2, 6)) + 1, "0000")
            'mstNew = Format(Val(Mid(cRS.Fields("Dist_ID").Value, 1, 4)) + 1, "0000")

        Else

            mstNew = "0001"
        End If
        'txtPro_id.Text = Pro_id
        txtid.Text = "P" & Trim(CStr(mstNew.ToString))
    End Sub
    Private Sub loadlist1()
        FG.Rows = 1
        With RSC
            Call LoadRs("SELECT * FROM List_Add_Befor order by Code  ", RSC)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG.AddItem(.AbsolutePosition & _
                        Chr(9) & .Fields("Code").Value & _
                         Chr(9) & .Fields("Add_Dition_Befor").Value & _
                           Chr(9) & .Fields("Money_QTY").Value & _
                              Chr(9) & .Fields("chk").Value)

                    .MoveNext()
                End While
            Else
                FG.Rows = 2
            End If
        End With
    End Sub
    Private Sub loadlist2()
        FG2.Rows = 1
        With RSC
            Call LoadRs("SELECT * FROM List_Deduc_Befor order by Code  ", RSC)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG2.AddItem(.AbsolutePosition & _
                        Chr(9) & .Fields("Code").Value & _
                         Chr(9) & .Fields("Deduc_Befor").Value & _
                           Chr(9) & .Fields("Money_QTY").Value & _
                              Chr(9) & .Fields("chk").Value)

                    .MoveNext()
                End While
            Else
                FG2.Rows = 2
            End If
        End With
    End Sub
    Private Sub loadlist3()

        FG1_After.Rows = 1
        With RSC
            Call LoadRs("SELECT * FROM List_Add_After order by Code  ", RSC)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG1_After.AddItem(.AbsolutePosition & _
                        Chr(9) & .Fields("Code").Value & _
                         Chr(9) & .Fields("Add_Dition_AfTer").Value & _
                           Chr(9) & .Fields("Money_QTY").Value & _
                              Chr(9) & .Fields("chk").Value)

                    .MoveNext()
                End While
            Else
                FG1_After.Rows = 2
            End If
        End With
    End Sub
    Private Sub loadlist4()

        FG2_After.Rows = 1
        With RSC
            Call LoadRs("SELECT * FROM List_Deduc_After order by Code  ", RSC)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG2_After.AddItem(.AbsolutePosition & _
                        Chr(9) & .Fields("Code").Value & _
                         Chr(9) & .Fields("Deduc_After").Value & _
                           Chr(9) & .Fields("Money_QTY").Value & _
                              Chr(9) & .Fields("chk").Value)

                    .MoveNext()
                End While
            Else
                FG2_After.Rows = 2
            End If
        End With
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub FG_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.ClickEvent
        myID = ""
        myID = FG.get_TextMatrix(FG.Row, 1)

    End Sub

    Private Sub FG_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.DblClick


        If FG.Row = 0 Then FG.Row = 1
        If FG.get_TextMatrix(1, 1) = "" Then Exit Sub
        'Koum_id = FG.get_TextMatrix(FG.Row, 2)

        Call edit()
        txtid.Enabled = False
    End Sub
    Private Sub edit()
        Dim rs As New ADODB.Recordset

        Call LoadRs("SELECT * FROM ListLeaveType WHERE LeaveTypeID='" & FG.get_TextMatrix(FG.Row, 1) & "' ", rs)
        With rs
            If rs.RecordCount <> 0 Then
                txtid.Text = .Fields("LeaveTypeID").Value.ToString
                txtnm.Text = .Fields("LeaveType").Value.ToString
                txtreport.Text = .Fields("DaysLeave").Value.ToString
                CheckBox1.Checked = .Fields("CutDayWork").Value
            End If

        End With

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MDEdit = False
        Add_Befor.ShowDialog()
        Call loadlist1()
        Call loadlist2()
        Call loadlist3()
        Call loadlist4()
    End Sub

    Private Sub addnew()
        'txtid.Enabled = True
        'txtid.Text = ""
        txtnme.Text = ""
        txtnm.Text = ""
        txtsymbol.Text = ""
        txtreport.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Lang = True Then
            If txtid.Text = "" And txtreport.Text = "" Then MsgBox("ກະລຸນາໃສ້ຂໍ້ມູນໃຫ້ຄົບຖ້ວນ") : Exit Sub


            SAVE()
            MsgBox("Save Complete")
        Else
            If txtid.Text = "" And txtreport.Text = "" Then MsgBox("ກະລຸນາໃສ້ຂໍ້ມູນໃຫ້ຄົບຖ້ວນ") : Exit Sub

            SAVE()
            MsgBox("ບັນທຶກສຳເລັດ")
        End If
        Call loadlist1()
        'Call ItemNew()
    End Sub

    Private Sub SAVE()

        Dim rs As New ADODB.Recordset
        Call LoadRs("SELECT * FROM ListLeaveType WHERE LeaveTypeID=N'" & txtid.Text & "'", rs)
        If rs.RecordCount = 0 Then
            Conn.Execute("INSERT INTO ListLeaveType(LeaveTypeID,LeaveType,DaysLeave,Lst_Updt,Lst_Usr,pc_nm) " & _
           " VALUES(N'" & Trim(txtid.Text.ToString) & "'," & _
          " N'" & Trim(txtnm.Text.ToString) & "'," & _
              " N'" & Trim(txtreport.Text.ToString) & "'," & _
             " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
                         " N'" & MUserName & "', " & _
   " N'" & MDServerName & "')")

        Else
            Conn.Execute("DELETE FROM ListLeaveType WHERE LeaveTypeID=N'" & txtid.Text & "' ")
            Conn.Execute("INSERT INTO ListLeaveType(LeaveTypeID,LeaveType,DaysLeave,Lst_Updt,Lst_Usr,pc_nm) " & _
           " VALUES(N'" & Trim(txtid.Text.ToString) & "'," & _
          " N'" & Trim(txtnm.Text.ToString) & "'," & _
              " N'" & Trim(txtreport.Text.ToString) & "'," & _
             " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
                         " N'" & MUserName & "', " & _
   " N'" & MDServerName & "')")


        End If
        If CheckBox1.Checked = True Then
            Dim ssss As String
            ssss = "UPDATE ListLeaveType SET CutDayWork = '1'" & _
                " WHERE LeaveTypeID =N'" & CStr(txtid.Text) & "'"
            Conn.Execute(ssss)
        Else
            Dim ssss As String
            ssss = "UPDATE ListLeaveType SET CutDayWork = '0'" & _
                " WHERE LeaveTypeID =N'" & CStr(txtid.Text) & "'"
            Conn.Execute(ssss)
        End If

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If FG.get_TextMatrix(1, 1) = "" Then Exit Sub
        If Lang = True Then
            'If RSC.RecordCount <> 0 Then MsgBox("Cannot delete item,It's being to Used by another transaction!") : Exit Sub
            If MessageBox.Show("Are you sure you want to delete province?'" & FG.get_TextMatrix(FG.Row, 1) & "' ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Conn.Execute("DELETE FROM ListLeaveType WHERE CutDayWork=N'" & FG.get_TextMatrix(FG.Row, 1) & "' ")
                If FG.Rows > 1 Then
                    FG.RemoveItem(FG.Row)
                Else
                    FG.Rows = 1
                    FG.Rows = 2
                End If
                Call loadlist1()
            End If

        Else
            'If RSC.RecordCount <> 0 Then MsgBox("ໄດ້ມີການເຄື່ຶນໄຫວແລ້ວ ບໍ່ສາມາດລຶບໄດ້") : Exit Sub
            If MessageBox.Show("ທ່ານຕ້ອງການລຶບຂໍ້ມູນນີ້ ຫຼື ບໍ່?'" & FG.get_TextMatrix(FG.Row, 1) & "", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Conn.Execute("DELETE FROM ListLeaveType WHERE CutDayWork=N'" & FG.get_TextMatrix(FG.Row, 1) & "' ")
                If FG.Rows > 1 Then
                    FG.RemoveItem(FG.Row)
                Else
                    FG.Rows = 1
                    FG.Rows = 2
                End If
                Call loadlist1()
            End If
        End If
        Call ItemNew()
    End Sub

    

    Private Sub txtreport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreport.KeyPress
        If e.KeyChar = Chr(13) Then
            txtreport.Text = Format(CDbl(txtreport.Text), "##,##0.00")

        End If
    End Sub

    Private Sub txtreport_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreport.TextChanged
        If IsNumeric(txtreport.Text) = False Or txtreport.Text = "" Then
            txtreport.Text = 0
        End If
    End Sub

    Private Sub FG2_After_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG2_After.ClickEvent
        myID = ""
        myID = FG2_After.get_TextMatrix(FG2_After.Row, 1)
    End Sub

  
    
    Private Sub FG2_After_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG2_After.SelChange

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MDEdit = False
        Add_After.ShowDialog()
        Call loadlist1()
        Call loadlist2()
        Call loadlist3()
        Call loadlist4()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MDEdit = True
        myID = FG1_After.get_TextMatrix(FG1_After.Row, 1)
        Add_After.ShowDialog()
        Call loadlist1()
        Call loadlist2()
        Call loadlist3()
        Call loadlist4()
    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange

    End Sub

    Private Sub FG1_After_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG1_After.ClickEvent
        myID = ""
        myID = FG1_After.get_TextMatrix(FG1_After.Row, 1)

    End Sub

    Private Sub FG1_After_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG1_After.DblClick
        MDEdit = True
        myID = FG1_After.get_TextMatrix(FG1_After.Row, 1)
        Add_After.ShowDialog()
    End Sub

    Private Sub FG1_After_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG1_After.SelChange

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MDEdit = False
        Deduc_Befor.ShowDialog()
        Call loadlist1()
        Call loadlist2()
        Call loadlist3()
        Call loadlist4()
    End Sub

  
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MDEdit = True
        Deduc_Befor.ShowDialog()
        Call loadlist1()
        Call loadlist2()
        Call loadlist3()
        Call loadlist4()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        MDEdit = False
        Deduc_After.ShowDialog()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        MDEdit = True
        Deduc_After.ShowDialog()
        Call loadlist1()
        Call loadlist2()
        Call loadlist3()
        Call loadlist4()
    End Sub

     
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        MDEdit = True
        Add_Befor.ShowDialog()
        Call loadlist1()
        Call loadlist2()
        Call loadlist3()
        Call loadlist4()
    End Sub

    Private Sub FG2_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG2.ClickEvent
        myID = ""
        myID = FG2.get_TextMatrix(FG2.Row, 1)

    End Sub

    Private Sub FG2_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG2.SelChange

    End Sub
End Class