Public Class Frm_Son

    Private Sub Frm_Son_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        txtson.Text = 0

        txtson_Money.Text = 0

        addnew()

        Load_Tax()
        loadCMB()


        If EditActive = True Then
            Editdata()


        Else
            EditActive = False
            'addnew()


        End If
    End Sub
    Private Sub Editdata()
        Dim aa As String
        Dim rs As New ADODB.Recordset
        aa = "SELECT    * from AP_Son_Money  where E_ID=N'" & E_ID & "' and bill_no=N'" & Bill_ID & "' "
        Call LoadRs(aa, rs)
        With rs
            If .RecordCount > 0 Then
                txt_no.Text = Trim(.Fields("bill_no").Value.ToString)
                txtid.Text = Trim(.Fields("E_ID").Value.ToString)
                DT_in.Value = Trim(.Fields("DT_in").Value.ToString)
                txtSection_ID.Text = Trim(.Fields("Sections_id").Value.ToString)
                Cmb_Sections.Text = Trim(.Fields("Sections").Value.ToString)
                txtdepart_ID.Text = Trim(.Fields("Department_id").Value.ToString)
                cmb_Department.Text = Trim(.Fields("Department").Value.ToString)

                TxtPersonNmL.Text = Trim(.Fields("Name_L").Value.ToString)
                TxtPersonNmE.Text = Trim(.Fields("Name_E").Value.ToString)
                TxtTel.Text = Trim(.Fields("Phone").Value.ToString)

                txtson.Text = Format(CDbl(.Fields("txtson").Value), "##,##0")
                txtson_Money.Text = Format(CDbl(.Fields("txtson_Money").Value), "##,##0.00")
                txtabount_son.Text = Trim(.Fields("txtabount_son").Value.ToString)
                txtremark.Text = Trim(.Fields("remark").Value.ToString)

            End If
        End With
    End Sub
    Private Sub addnew()
      
        txtson.Text = 0

        txtson_Money.Text = 0



  
        AutoNumber()
    End Sub
    Private Sub loadCMB()
        'Cmb_Sections.Items.Clear()
        'Call load_Cmb("select Sec_nmL from AP_Sections", "Sec_nmL", Cmb_Sections)
        'Cmb_Sections.SelectedIndex = 0

        'cmb_Department.Items.Clear()
        'Call load_Cmb("select DP_Name from Department", "DP_Name", cmb_Department)
        'cmb_Department.SelectedIndex = 0


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmCustomer_item.ShowDialog()
        If MDCusID = "" Then Exit Sub
        Dim rs As New ADODB.Recordset
        Call LoadRs("SELECT * FROM  AP_son_Money WHERE   E_ID = N'" & CustID & "' and  status =0 ", rs)
        If rs.RecordCount > 0 Then
            'MsgBox("ທ່ານໄດ້ບັນທຶກຂໍ້ມູນຂອງພະນັກງານນີ້ແລ້ວ ກະລຸນາປ່ຽນໄໝ່", MsgBoxStyle.OkOnly)
            'Exit Sub
            txt_no.Text = (rs.Fields("bill_no").Value.ToString)
            DT_in.Value = (rs.Fields("dt_in").Value.ToString)
            txtson.Text = (rs.Fields("txtson").Value.ToString)
            txtson_Money.Text = Format(CDbl(rs.Fields("txtson_Money").Value), "##,##0.00")
            txtabount_son.Text = (rs.Fields("txtabount_son").Value.ToString)
        Else
            AutoNumber()
            DT_in.Value = Today
            txtson.Text = 0
            txtson_Money.Text = 0
            txtabount_son.Text = ""
        End If
        LoadData_CV()
    End Sub
    Private Sub LoadData_CV()
        Dim rs As New ADODB.Recordset
        Dim aa As String
        With rs
            aa = "SELECT    AP_CV.*, AP_Village.Vl_nm, AP_District.Dt_id, AP_District.Dt_nm, AP_Province.PV_ID, AP_Province.PV_nm, " & _
                    "   AP_Village_1.Vl_nm AS Vl_nm1, AP_District_1.Dt_nm AS Dt_nm1, AP_Province_1.PV_nm AS PV_nm1 " & _
                    "   FROM         AP_CV INNER JOIN " & _
                    "   AP_Village ON AP_CV.BVill_ID = AP_Village.Vl_ID INNER JOIN  " & _
                     "  AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
                     "  AP_Province ON AP_District.PV_id = AP_Province.PV_ID INNER JOIN " & _
                     "  AP_Village AS AP_Village_1 ON AP_CV.Add_Vill_ID = AP_Village_1.Vl_ID INNER JOIN " & _
                     "  AP_District AS AP_District_1 ON AP_Village_1.Dt_id = AP_District_1.Dt_id INNER JOIN " & _
                    "   AP_Province AS AP_Province_1 ON AP_District_1.PV_id = AP_Province_1.PV_ID WHERE 1=1  AND AP_CV.E_ID=N'" & CustID & "' "
            Call LoadRs(aa, rs)
            If .RecordCount <> 0 Then
                txtid.Text = (.Fields("E_ID").Value.ToString)
                TxtPersonNmL.Text = (.Fields("Name_L").Value.ToString)
                TxtPersonNmE.Text = (.Fields("Name_E").Value.ToString)

                txtSection_ID.Text = (.Fields("Sections_id").Value.ToString)
                Cmb_Sections.Text = (.Fields("Sections").Value.ToString)

                txtdepart_ID.Text = (.Fields("Department_id").Value.ToString)
                cmb_Department.Text = (.Fields("Department").Value.ToString)

                TxtTel.Text = (.Fields("Phone").Value.ToString)
      

                'txtson.Text = 0
                'txtson_Money.Text = 0
                'txtson.Text = (.Fields("txtson").Value.ToString)
                'txtson_Money.Text = Format(CDbl(.Fields("txtson_Money").Value), "##,##0.00")
            

            End If
        End With

    End Sub

    Private Sub Bclos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclos.Click
        Me.Close()
    End Sub

    Private Sub Cmb_Sections_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Sections.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Sections Where Sec_nmL=N'" & Trim(Cmb_Sections.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtSection_ID.Text = Trim(RSC("Sec_id").Value)
        End If
    End Sub

    Private Sub cmb_Department_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Department.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Department Where DP_name=N'" & Trim(cmb_Department.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtdepart_ID.Text = Trim(RSC("DP_ID").Value)
        End If
    End Sub

    Private Sub Badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badd.Click
        addnew()
    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Bill_no from AP_Son_Money    Order by Bill_no DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Bill_no").Value, 1, 6)) + 1, "000000")
        Else
            VIOTNEW = "000001"

        End If
        txt_no.Text = Trim(CStr(VIOTNEW.ToString))
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txt_no.Text = "" Then MsgBox("ໃສ່ລະຫັດພະນັກງານກ່ອນ") : Exit Sub

        If txtid.Text = "" Then MsgBox("ໃສ່ລະຫັດພະນັກງານກ່ອນ") : txtid.Focus() : Exit Sub


        Save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Save()

        Dim rs As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT * FROM  AP_Son_Money WHERE bill_no = '" & txt_no.Text & "' and  E_ID = '" & txtid.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO   AP_Son_Money ( bill_no, DT_in, E_ID, Sections_id, Sections, Department_id, Department, Name_L, Name_E, Phone, " & _
                " txtson, txtson_Money,txtabount_son, remark, lst_updt, lst_usr, Pc_nm) " & _
               " VALUES(N'" & (txt_no.Text) & "'," & _
                  " '" & Format(DT_in.Value, "yyyy-MM-dd") & "'," & _
                  " N'" & (txtid.Text) & "'," & _
                     " N'" & (txtSection_ID.Text) & "'," & _
                   " N'" & (Cmb_Sections.Text) & "'," & _
                     " N'" & (txtdepart_ID.Text) & "'," & _
                   " N'" & (cmb_Department.Text) & "'," & _
                       " N'" & (TxtPersonNmL.Text) & "'," & _
                 " N'" & (TxtPersonNmE.Text) & "'," & _
                      " N'" & (TxtTel.Text) & "'," & _
                          " " & CDbl(txtson.Text) & "," & _
                           " " & CDbl(txtson_Money.Text) & "," & _
                               " N'" & (txtabount_son.Text) & "'," & _
                               " N'" & (txtremark.Text) & "'," & _
                                        " Getdate()," & _
                               " N'" & MUserName & "'," & _
                            " '" & MDServerName & "')"
                Conn.Execute(aa)
            Else
                Conn.Execute("delete from   AP_Son_Money WHERE    E_ID= '" & (txtid.Text) & "' and  bill_no= '" & (txt_no.Text) & "'")
                Dim aa As String
                aa = "INSERT INTO   AP_Son_Money ( bill_no, DT_in, E_ID, Sections_id, Sections, Department_id, Department, Name_L, Name_E, Phone, " & _
                " txtson, txtson_Money,txtabount_son, remark, lst_updt, lst_usr, Pc_nm) " & _
               " VALUES(N'" & (txt_no.Text) & "'," & _
                  " '" & Format(DT_in.Value, "yyyy-MM-dd") & "'," & _
                  " N'" & (txtid.Text) & "'," & _
                     " N'" & (txtSection_ID.Text) & "'," & _
                   " N'" & (Cmb_Sections.Text) & "'," & _
                     " N'" & (txtdepart_ID.Text) & "'," & _
                   " N'" & (cmb_Department.Text) & "'," & _
                       " N'" & (TxtPersonNmL.Text) & "'," & _
                 " N'" & (TxtPersonNmE.Text) & "'," & _
                      " N'" & (TxtTel.Text) & "'," & _
                          " " & CDbl(txtson.Text) & "," & _
                           " " & CDbl(txtson_Money.Text) & "," & _
                               " N'" & (txtabount_son.Text) & "'," & _
                               " N'" & (txtremark.Text) & "'," & _
                                        " Getdate()," & _
                               " N'" & MUserName & "'," & _
                            " '" & MDServerName & "')"
                Conn.Execute(aa)
               
            End If
        End With

        Dim rsc As New ADODB.Recordset
        Call LoadRs("SELECT * FROM  AP_Son_Money WHERE bill_no = '" & txt_no.Text & "' and  E_ID = '" & txtid.Text & "' and  status =0 ", rsc)
        If rsc.RecordCount > 0 Then

            Conn.Execute(" UPDATE AP_CV SET txtToltal_All=0 " & _
             " WHERE E_ID= '" & (txtid.Text) & "'")
            Conn.Execute(" UPDATE AP_CV SET txtToltal_All=Total_remaining-Tax+khongsep+" & CDbl(txtson_Money.Text) & "+txtMom_mony " & _
            " WHERE E_ID= '" & (txtid.Text) & "'")
            Conn.Execute(" UPDATE AP_CV SET " & _
                  " Status_son=1," & _
                          " txtson_Money=" & CDbl(txtson_Money.Text) & "," & _
                      " txtson=" & CDbl(txtson.Text) & "" & _
              " WHERE E_ID= '" & (txtid.Text) & "'")

            Conn.Execute(" UPDATE AP_Salary SET txtToltal_All=0 " & _
          " WHERE E_ID= '" & (txtid.Text) & "'")
            Conn.Execute(" UPDATE AP_Salary SET txtToltal_All=Total_remaining-Tax+khongsep+" & CDbl(txtson_Money.Text) & "+txtMom_mony " & _
            " WHERE E_ID= '" & (txtid.Text) & "'")
            Conn.Execute(" UPDATE AP_Salary SET " & _
                  " Status_son=1," & _
                  " txtson_Money=" & CDbl(txtson_Money.Text) & "," & _
                      " txtson=" & CDbl(txtson.Text) & "" & _
              " WHERE E_ID= '" & (txtid.Text) & "'")


            Conn.Execute(" UPDATE AP_Son_Money SET " & _
      " status=0," & _
      " status_nm=N'ຍັງອະນຸມັດຈ່າຍຢູ່' " & _
       " WHERE bill_no= '" & txt_no.Text & "' and E_ID= '" & txtid.Text & "'")
        End If
    End Sub

    Private Sub txtson_Money_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtson_Money.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtson_Money.Text = Format(CDbl(txtson_Money.Text), "##,##0.00")
        End Select
    End Sub

    Private Sub txtson_Money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtson_Money.TextChanged

    End Sub
End Class