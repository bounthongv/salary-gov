Public Class Add_After



    Private Sub Add_After_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call Loadlang()
        'SetControlText(Me)
        'ChgChildForm()

        If MDEdit = True Then
            EditData()
        Else
            Call ItemNew()
            Call addnew()
        End If
        If Lang = True Then
            Button1.Text = "Save"
            Button3.Text = "Add New"


            Label1.Text = "Province ID:"
            Label2.Text = "Symbol:"
            Label3.Text = "Province Name:"
            Label4.Text = "Name In English:"
            Label5.Text = "Bank Name:"
            Label6.Text = "Bank of Account:"
            Label7.Text = "NSC Code:"
            CheckBox1.Text = "Actively"
        Else
            Button3.Text = "ເພີ່ມໄໝ່"
            Button1.Text = "ບັນທຶກ"

            Label1.Text = "ລະຫັດແຂວງ:"
            Label2.Text = "ເຄື່ອງໝາຍ:"
            Label3.Text = "ຊື່ແຂວງ ລາວ:"
            Label4.Text = "ຊື່ແຂວງ ອັງກິດ:"
            Label5.Text = "ບັນຊີທະນາຄານ:"
            Label6.Text = "ເລກບັນຊີ:"
            Label7.Text = "ລະຫັດ ສສຕ:"
            CheckBox1.Text = "ຈັດຕັ້ງປະຕິບັດ"
        End If

        'itemcnt()
    End Sub
    Private Sub addnew()
        txtsymbol.Text = ""
        txtaccbank.Text = ""
        txtnmE.Text = ""
        txtNm.Text = ""
        txtnsc.Text = ""
        txtbankno.Text = ""
        txtTotal_QTY.Text = 0
    End Sub
    Private Sub EditData()
        Dim rs As New ADODB.Recordset
        Call LoadRs("SELECT * FROM List_Add_After WHERE Code='" & myID & "' ", rs)
        With rs
            If rs.RecordCount <> 0 Then
                txtid.Text = .Fields("Code").Value.ToString

                txtNm.Text = .Fields("Add_Dition_AfTer").Value.ToString

                txtTotal_QTY.Text = Format(CDbl(.Fields("Money_QTY").Value), "##,##0.00")
                ''===================================================
                If .Fields("chk").Value = 1 Then
                    Chk.Checked = True
                Else
                    Chk.Checked = False

                End If
                'If IsDBNull(.Fields("dt_Kuk").Value) = True Then
                '    dt_Kuk.Checked = False
                'Else
                '    dt_Kuk.Value = Format(.Fields("dt_Kuk").Value, "dd/MM/yyyy")
                '    dt_Kuk.Checked = True
                'End If

            End If
        End With

    End Sub

    Function itemcnt()
        Dim cRS As New ADODB.Recordset
        Call LoadRs("SELECT COUNT(*) AS nCnt FROM AP_Provinces '", cRS)
        itemcnt = cRS.Fields("ncnt").Value
        txtid.Text = itemcnt + 1
    End Function
    Private Sub ItemNew()
        Dim cRS As New ADODB.Recordset
        Dim mstNew, sss As String
        sss = "SELECT TOP 1 Code FROM List_Add_After  ORDER BY Code DESC"
        Call LoadRs(sss, cRS)
        If cRS.RecordCount <> 0 Then
            mstNew = Format(Val(Mid(cRS.Fields("Code").Value, 1, 2)) + 1, "00")

        Else

            mstNew = "01"
        End If
        txtid.Text = Trim(CStr(mstNew.ToString))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SAVE()
        If Lang = True Then
            MsgBox("Save Complete")
        Else
            MsgBox("ບັນທຶກສຳເລັດ")
        End If


    End Sub
    Private Sub SAVE()
        Dim dd As String
        Dim rs As New ADODB.Recordset
        Call LoadRs("SELECT * FROM List_Add_After WHERE Code=N'" & txtid.Text & "'", rs)
        If rs.RecordCount = 0 Then
            dd = "INSERT INTO List_Add_After(Code, Add_Dition_AfTer,Money_QTY,Lst_Updt,Lst_Usr,pc_nm) " & _
            " VALUES(N'" & Trim(txtid.Text.ToString) & "'," & _
           " N'" & Trim(txtNm.Text.ToString) & "'," & _
            " " & CDbl(txtTotal_QTY.Text) & "," & _
              " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
                " N'" & MUserName & "', " & _
   " N'" & MDServerName & "')"
            Conn.Execute(dd)


        Else
            Conn.Execute("DELETE FROM List_Add_After WHERE Code=N'" & txtid.Text & "' ")
            dd = "INSERT INTO List_Add_After(Code, Add_Dition_AfTer,Money_QTY,Lst_Updt,Lst_Usr,pc_nm) " & _
              " VALUES(N'" & Trim(txtid.Text.ToString) & "'," & _
             " N'" & Trim(txtNm.Text.ToString) & "'," & _
             " " & CDbl(txtTotal_QTY.Text) & "," & _
                " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
                  " N'" & MUserName & "', " & _
     " N'" & MDServerName & "')"
            Conn.Execute(dd)
        End If
        If Chk.Checked = True Then
            Dim ssss As String
            ssss = "UPDATE List_Add_After SET chk  = '1'" & _
                " WHERE Code =N'" & CStr(txtid.Text) & "'"
            Conn.Execute(ssss)
        Else
            Dim ssss As String
            ssss = "UPDATE List_Add_After SET chk = '0'" & _
                " WHERE Code =N'" & CStr(txtid.Text) & "'"
            Conn.Execute(ssss)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call addnew()
        Call ItemNew()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal_QTY.TextChanged

    End Sub
End Class