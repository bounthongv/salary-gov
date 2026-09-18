Public Class Frm_Case_patment
    Dim rs As New ADODB.Recordset

    Private Sub Frm_Unit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລດ |<ລະຫັດ|<ສະນິດວັກຊີນ                      |<ການບໍລິການ(ກີບ)|<ໝາຍເຫດ                "
        FG2.FormatString = "ລດ |<ລະຫັດ|<ສະນິດວັກຊີນ                      |<ການບໍລິການ(ກີບ)|<ໝາຍເຫດ              "
        Call LoadData()
        LoadData2()
        BtnAddNew_Click(sender, e)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'If Txt_ID.Text = "" Then MsgBox("Please add product Type ID !", MsgBoxStyle.OkOnly) : Txt_ID.Focus() : Exit Sub
        'If Txt_ID.Enabled = True Then
        '    If Txt_name.Text = "" Then MsgBox("Please add Unit Type name !", MsgBoxStyle.OkOnly) : Txt_name.Focus() : Exit Sub
        '    Call LoadRs("SELECT PV_ID FROM AP_Province WHERE PV_ID = '" & Trim(Txt_ID.Text) & "'", RSC)
        '    If RSC.RecordCount > 0 Then
        '        MsgBox("ລະຫັດສາຍນີ້ມີແລ້ວ : " & Trim(Txt_ID.Text) & "  ກະລຸນາປ່ຽນເລກໃໝ່!", MsgBoxStyle.OkOnly)
        '        Txt_ID.Focus()
        '        If RSC.State = ConnectionState.Open Then RSC.Close()
        '        Exit Sub
        '    End If
        '    If RSC.State = ConnectionState.Open Then RSC.Close()
        'End If
        Call save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        Call LoadData()
        Txt_ID.Focus()
    End Sub
    Public Sub save()
        Call LoadRs("SELECT * FROM AP_Dist_PayMent WHERE Pay_ID = '" & Txt_ID.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_Dist_PayMent (Pay_ID,Pay_Name,Pay_Amoumt,Pay_remark) " & _
                   " VALUES(N'" & Apostrophe(Txt_ID.Text.Trim) & "'," & _
                     " N'" & Txt_name.Text & "'," & _
                  " " & CDbl(txtamount.Text) & "," & _
                   " N'" & txtremark.Text & "')")
            Else
                Conn.Execute("UPDATE AP_Dist_PayMent SET " & _
                   " Pay_Name=N'" & Txt_name.Text & "', " & _
                    " Pay_Amoumt=" & txtamount.Text & ", " & _
                     " Pay_remark=N'" & txtremark.Text & "' " & _
                     " WHERE Pay_ID= '" & (Txt_ID.Text) & "'  ")
            End If
        End With

    End Sub
    Public Sub save2()
        Call LoadRs("SELECT * FROM AP_Prov_Payment WHERE P_Pay_ID = '" & txtP_ID.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_Prov_Payment (P_Pay_ID,P_Pay_Name,P_Pay_Amoumt,P_Pay_remark) " & _
                   " VALUES(N'" & Apostrophe(txtP_ID.Text.Trim) & "'," & _
                     " N'" & txtP_Name.Text & "'," & _
                  " " & CDbl(txtP_Amount.Text) & "," & _
                   " N'" & txtP_Remark.Text & "')")
            Else
                Conn.Execute("UPDATE AP_Prov_Payment SET " & _
                   " P_Pay_Name=N'" & txtP_Name.Text & "', " & _
                    " P_Pay_Amoumt=" & txtP_Amount.Text & ", " & _
                     " P_Pay_remark=N'" & txtP_Remark.Text & "' " & _
                     " WHERE P_Pay_ID= '" & (txtP_ID.Text) & "'  ")
            End If
        End With

    End Sub
    Public Sub LoadData()
        fg.Rows = 1
        With rs
            Call LoadRs("select *  from AP_Dist_PayMent order by Pay_ID", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("Pay_ID").Value.ToString) & _
                      Chr(9) & (.Fields("Pay_Name").Value.ToString) & _
                      Chr(9) & Format(CDbl(.Fields("Pay_Amoumt").Value), "#,##0") & _
                               Chr(9) & (.Fields("Pay_remark").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Public Sub LoadData2()
        FG2.Rows = 1
        With rs
            Call LoadRs("select *  from AP_Prov_Payment order by P_Pay_ID", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    FG2.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("P_Pay_ID").Value.ToString) & _
                      Chr(9) & (.Fields("P_Pay_Name").Value.ToString) & _
                             Chr(9) & Format(CDbl(.Fields("P_Pay_Amoumt").Value), "#,##0") & _
                    Chr(9) & (.Fields("P_Pay_remark").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub LoadData_Edit()
        Dim rs As New ADODB.Recordset
        Dim sa As String
        With rs
            sa = " SELECT  * from AP_Dist_PayMent   WHERE  Pay_ID='" & SaleID & "'  "
            Call LoadRs(sa, rs)

            If .RecordCount <> 0 Then
                Txt_ID.Text = (.Fields("Pay_ID").Value.ToString)
                Txt_name.Text = (.Fields("Pay_Name").Value.ToString)
                txtamount.Text = (.Fields("Pay_Amoumt").Value.ToString)
                txtremark.Text = (.Fields("Pay_remark").Value.ToString)


            End If
        End With
    End Sub

    Private Sub LoadData_Edit2()
        Dim rs As New ADODB.Recordset
        Dim sa As String
        With rs
            sa = " SELECT  * from AP_Prov_Payment   WHERE  P_Pay_ID='" & Trim(FG2.get_TextMatrix(FG2.Row, 1)) & "'"
            Call LoadRs(sa, rs)

            If .RecordCount <> 0 Then
                txtP_ID.Text = (.Fields("P_Pay_ID").Value.ToString)
                txtP_Name.Text = (.Fields("P_Pay_Name").Value.ToString)
                txtP_Amount.Text = (.Fields("P_Pay_Amoumt").Value.ToString)
                txtP_Remark.Text = (.Fields("P_Pay_remark").Value.ToString)


            End If
        End With
    End Sub
    Private Sub fg_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.ClickEvent
        SaleID = fg.get_TextMatrix(fg.Row, 1)
    End Sub

    Private Sub fg_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DblClick
        If fg.Row = 0 Or fg.get_TextMatrix(fg.Row, 1) = "" Then Exit Sub
        Txt_ID.Enabled = False
        SaleID = fg.get_TextMatrix(fg.Row, 1)
        Call LoadData_Edit()
    End Sub

    Private Sub fg_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.SelChange

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Txt_ID.Text = ""
        Txt_name.Text = ""
        Txt_ID.Visible = True
        Txt_ID.Enabled = True
        txtamount.Text = 0
        txtremark.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການນີ້: " & Trim(fg.get_TextMatrix(fg.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Dist_PayMent Where  Pay_ID='" & Trim(fg.get_TextMatrix(fg.Row, 1) & "'"))
            Call LoadData()
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call save2()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        Call LoadData2()
        txtP_ID.Focus()
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        txtamount.Text = Format(CDbl(txtamount.Text), "#,##0")

    End Sub

    Private Sub FG2_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG2.DblClick
        LoadData_Edit2()
    End Sub

    Private Sub FG2_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG2.SelChange

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtP_ID.Text = ""
        txtP_Name.Text = ""

        txtP_ID.Enabled = True
        txtP_Amount.Text = 0
        txtP_Remark.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການນີ້: " & Trim(fg.get_TextMatrix(fg.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Prov_Payment Where  P_Pay_ID='" & Trim(FG2.get_TextMatrix(FG2.Row, 1) & "'"))
            Call LoadData2()
        End If
    End Sub

    Private Sub txtP_Amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtP_Amount.TextChanged
        txtP_Amount.Text = Format(CDbl(txtP_Amount.Text), "#,##0")
    End Sub
End Class