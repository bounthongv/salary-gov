Public Class frmSSO
    Dim id As String
    Private Sub frmSSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call Loadlang()
        'SetControlText(Me)
        'ChgChildForm()

        'txtid.Enabled = False
        Call addnew()
        Call ItemNew()
        FG.FormatString = "^No  |<ID   |^ວັນທີ       |<ພະນັກງານ     |<ຜູ້ຈ້າງ       "
        Button3.Text = "Add New"
        Button1.Text = "Save"
        Button10.Text = "Delete"
        'Label11.Text = "Sub Prolect-group"
        'Label1.Text = "Code"
        'Label2.Text = "Symbol  "
        'Label3.Text = "Name In lao     "
        'Label4.Text = "Name In English   "
        Call loadlist()
    End Sub
    Private Sub ItemNew()
        Dim cRS As New ADODB.Recordset
        Dim mstNew, sss As String
        sss = "SELECT TOP 1 No  FROM SSO  ORDER BY No DESC"
        Call LoadRs(sss, cRS)
        If cRS.RecordCount <> 0 Then
            mstNew = Format(Val(Mid(cRS.Fields("No").Value, 1, 3)) + 1, "000")
            'mstNew = Format(Val(Mid(cRS.Fields("Dist_ID").Value, 1, 4)) + 1, "0000")

        Else

            mstNew = "001"
        End If
        'txtPro_id.Text = Pro_id
        txtid.Text = Trim(CStr(mstNew.ToString))
    End Sub
    Private Sub loadlist()
        Dim aa As String
        FG.Rows = 1
        With RSC
            Call LoadRs("SELECT * FROM SSO order by DT_SSO desc  ", RSC)
            aa = FG.get_TextMatrix(FG.Row, 2)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG.AddItem(.AbsolutePosition & _
                        Chr(9) & .Fields("No").Value & _
                          Chr(9) & .Fields("DT_SSO").Value & _
                                 Chr(9) & .Fields("employee").Value & " %" & _
                              Chr(9) & .Fields("employer").Value & " %")

                    .MoveNext()
                End While
            Else
                FG.Rows = 2
            End If
        End With
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub FG_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.ClickEvent
        id = FG.get_TextMatrix(FG.Row, 2)
        Call edit()
        txtid.Enabled = False
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

        Call LoadRs("SELECT * FROM SSO WHERE No='" & FG.get_TextMatrix(FG.Row, 1) & "' ", rs)
        With rs
            If rs.RecordCount <> 0 Then
                txtid.Text = .Fields("No").Value.ToString
                dt_month.Value = .Fields("DT_SSO").Value.ToString
                txtnm.Text = .Fields("employee").Value.ToString
                txtnm_L.Text = .Fields("employer").Value.ToString


            End If

        End With

    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call addnew()
        Call ItemNew()
    End Sub

    Private Sub addnew()
        'txtid.Enabled = True
        'txtid.Text = ""
        txtnme.Text = 0
        txtnm_L.Text = 0
        txtnm.Text = 0
        txtsymbol.Text = ""
        txtcode.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
 
            If txtid.Text = "" And txtcode.Text = "" Then MsgBox("ກະລຸນາໃສ້ຂໍ້ມູນໃຫ້ຄົບຖ້ວນ") : Exit Sub

            SAVE()
            MsgBox("ບັນທຶກສຳເລັດ")

        Call loadlist()
        'Call ItemNew()
    End Sub

    Private Sub SAVE()

        Dim rs As New ADODB.Recordset
        Call LoadRs("SELECT * FROM SSO WHERE No=N'" & txtid.Text & "'", rs)
        If rs.RecordCount = 0 Then
            Conn.Execute("INSERT INTO SSO (No,DT_SSO,employee,employer,Lst_Updt,Lst_Usr,pc_nm) " & _
           " VALUES(N'" & Trim(txtid.Text.ToString) & "'," & _
               " '" & Format(dt_month.Value, "yyyy-MM-dd") & "'," & _
      " N'" & (txtnm.Text.ToString) & "'," & _
         " N'" & (txtnm_L.Text.ToString) & "'," & _
              " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
                 " N'" & MUserName & "', " & _
   " N'" & MDServerName & "')")

        Else
            Conn.Execute("DELETE FROM SSO WHERE No=N'" & txtid.Text & "' ")
            Conn.Execute("INSERT INTO SSO (No,DT_SSO,employee,employer,Lst_Updt,Lst_Usr,pc_nm) " & _
           " VALUES(N'" & Trim(txtid.Text.ToString) & "'," & _
               " '" & Format(dt_month.Value, "yyyy-MM-dd") & "'," & _
      " N'" & (txtnm.Text.ToString) & "'," & _
         " N'" & (txtnm_L.Text.ToString) & "'," & _
              " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
                 " N'" & MUserName & "', " & _
               " N'" & MDServerName & "')")
        End If

        '     Dim ssss As String
        '     ssss = "UPDATE AP_Provinces SET STATUS = '1'" & _
        '" WHERE Prov_ID =N'" & CStr(txtPro_id.Text) & "'"
        '     CNN.Execute(ssss)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If FG.get_TextMatrix(1, 1) = "" Then Exit Sub
       
        'If RSC.RecordCount <> 0 Then MsgBox("ໄດ້ມີການເຄື່ຶນໄຫວແລ້ວ ບໍ່ສາມາດລຶບໄດ້") : Exit Sub
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບຂໍ້ມູນນີ້ ຫຼື ບໍ່?'" & FG.get_TextMatrix(FG.Row, 1) & "", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("DELETE FROM SSO WHERE No=N'" & FG.get_TextMatrix(FG.Row, 1) & "' ")
            If FG.Rows > 1 Then
                FG.RemoveItem(FG.Row)
            Else
                FG.Rows = 1
                FG.Rows = 2
            End If
            Call loadlist()

        End If

        Call ItemNew()
    End Sub

    Private Sub txtnme_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnme.TextChanged

    End Sub

    Private Sub txtnmlao_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnm.TextChanged

    End Sub

    Private Sub txtsymbol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsymbol.TextChanged

    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged

    End Sub
End Class