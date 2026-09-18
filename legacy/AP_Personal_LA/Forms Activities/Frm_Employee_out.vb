Public Class Frm_Employee_out

    Private Sub Frm_Employee_out_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      

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
        aa = "SELECT    *  from AP_Employee_out  where E_ID=N'" & SaleID & "'  "
        Call LoadRs(aa, rs)
        With rs
            If .RecordCount > 0 Then
                txt_no.Text = Trim(.Fields("Bill_no").Value.ToString)
                txtid.Text = Trim(.Fields("E_ID").Value.ToString)
                DT_out.Value = Trim(.Fields("DT_out").Value.ToString)
                txtSection_ID.Text = Trim(.Fields("Sections_id").Value.ToString)
                Cmb_Sections.Text = Trim(.Fields("Sections").Value.ToString)
                txtdepart_ID.Text = Trim(.Fields("Department_id").Value.ToString)
                cmb_Department.Text = Trim(.Fields("Department").Value.ToString)

                TxtPersonNmL.Text = Trim(.Fields("Name_L").Value.ToString)
                TxtPersonNmE.Text = Trim(.Fields("Name_E").Value.ToString)
                TxtTel.Text = Trim(.Fields("Phone").Value.ToString)

                'txtson.Text = Format(CDbl(.Fields("txtson").Value), "##,##0")
                'txtson_Money.Text = Format(CDbl(.Fields("txtson_Money").Value), "##,##0.00")
                txtabount.Text = Trim(.Fields("abount").Value.ToString)
                txtremark.Text = Trim(.Fields("remark").Value.ToString)

            End If
        End With
    End Sub
    Private Sub addnew()






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
        Dim aa As String
        aa = "SELECT     AP_CV.E_ID, AP_CV.*, AP_Village.Vl_nm, AP_District.Dt_id, " & _
"    AP_District.Dt_nm, AP_Province.PV_ID, AP_Province.PV_nm, AP_Village_1.Vl_nm AS Vl_nm1, AP_District_1.Dt_nm AS Dt_nm1, AP_Province_1.PV_nm AS PV_nm1,  " & _
"    AP_Sections.Sec_nmL, Department.DP_Name, Type_In.In_nm  , job.job_nm  " & _
"    FROM         AP_CV INNER JOIN " & _
"   AP_Village ON AP_CV.BVill_ID = AP_Village.Vl_ID INNER JOIN " & _
    "       AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
         "  AP_Province ON AP_District.PV_id = AP_Province.PV_ID INNER JOIN " & _
        "   AP_Village AS AP_Village_1 ON AP_CV.Add_Vill_ID = AP_Village_1.Vl_ID INNER JOIN " & _
        "   AP_District AS AP_District_1 ON AP_Village_1.Dt_id = AP_District_1.Dt_id INNER JOIN " & _
        "   AP_Province AS AP_Province_1 ON AP_District_1.PV_id = AP_Province_1.PV_ID LEFT OUTER JOIN " & _
        "   job ON AP_CV.duties_Id = job.job_id LEFT OUTER JOIN " & _
        "   Type_In ON AP_CV.type_in_id = Type_In.In_ID LEFT OUTER JOIN " & _
       "    Department ON AP_CV.Department_id = Department.DP_ID LEFT OUTER JOIN " & _
        "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id  WHERE   E_ID = N'" & CustID & "'   "
        Call LoadRs(aa, rs)

        If rs.RecordCount > 0 Then
            'MsgBox("ທ່ານໄດ້ບັນທຶກຂໍ້ມູນຂອງພະນັກງານນີ້ແລ້ວ ກະລຸນາປ່ຽນໄໝ່", MsgBoxStyle.OkOnly)
            'Exit Sub


            txtid.Text = (rs.Fields("E_ID").Value.ToString)
            TxtPersonNmL.Text = (rs.Fields("Name_L").Value.ToString)
            TxtPersonNmE.Text = (rs.Fields("Name_E").Value.ToString)
            Cmb_Sections.Text = (rs.Fields("Sec_nmL").Value.ToString)
            cmb_Department.Text = (rs.Fields("DP_Name").Value.ToString)
            TxtTel.Text = (rs.Fields("Phone").Value.ToString)
            txtSection_ID.Text = Trim(rs("Sections_id").Value)
            txtdepart_ID.Text = Trim(rs("Department_id").Value)
            'txtabount.Text = (rs.Fields("txtabount").Value.ToString)
            'txtson_Money.Text = Format(CDbl(rs.Fields("txtson_Money").Value), "##,##0.00")
            'txtremark.Text = (rs.Fields("remark").Value.ToString)
        Else
            AutoNumber()
            DT_out.Value = Today
            'txtson.Text = 0
            'txtson_Money.Text = 0
            txtabount.Text = ""
        End If
        'LoadData_CV()
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
        'Dim RSC As New ADODB.Recordset
        'Call LoadRs("Select * From AP_Sections Where Sec_nmL=N'" & Trim(Cmb_Sections.Text) & "'   ", RSC)
        'If RSC.RecordCount > 0 Then
        '    txtSection_ID.Text = Trim(RSC("Sec_id").Value)
        'End If
    End Sub

    Private Sub cmb_Department_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Department.SelectedIndexChanged
        'Dim RSC As New ADODB.Recordset
        'Call LoadRs("Select * From Department Where DP_name=N'" & Trim(cmb_Department.Text) & "'   ", RSC)
        'If RSC.RecordCount > 0 Then
        '    txtdepart_ID.Text = Trim(RSC("DP_ID").Value)
        'End If
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
            Call LoadRs("SELECT * FROM  AP_Employee_out WHERE    E_ID = '" & txtid.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO AP_Employee_out(E_ID, Sections_id, Sections, Department_id, Department, type_in_id, type_in_nm, Name_L, Name_E, Phone, Bank_no, SSO_no, DT_strt_work, " & _
                   "   start_work_ID, start_work, txtmoney_basic, DT_Work_now, cmbclass, cmblevel, txtV_C, txt_parts_id, cmb_parts, txt_work_id, cmb_work, percen, DOB, age, gender,  " & _
                  "    BProv_ID, BVill_ID, Add_Vill_ID, houeNo, Road, Street, Card_no, dateOutID, txt_hours_money, Level_Clss_Money, Tumnang_Money, year_money, txttotal, AGL,  " & _
                  "    Total_remaining, Tax, khongsep, txtson, txtson_Money, txtmom, txtMom_mony, txtWomen_mony, txtoil_mony, txtPhone_money, txtToltal_All, chk_lut, dt_Lut,  " & _
                 "     chk_Phuk_sumhong, Dt_Phuk_sumhong, chk_Phuk, Dt_Phuk, chk_Job_Phuk, job_phuk_ID, job_phuk, chk_job_lut, job_lut_ID, job_lut, txthong, chk_job_lut_visakan,  " & _
                 "     job_lut_visakan, duties_Id, duties, chk_study, DT_study, chk_start, DT_Start, study_ID, study, txtvisa_id, txtvisa, Study_cuntry_id, Study_cuntry, chk_study2,  " & _
                 "     DT_study2, txtstudy2, chk_lang, lang_ID, lang, CmbNation1_ID, CmbNation1, CmbNation2_ID, CmbNation2, CmbNation3_ID, CmbNation3, CmbReligion_id,  " & _
             "   CmbReligion, Status_son, Status_Mom, Status_donw, Status_Up, Status_Per_id, Status_Per, Status_out,abount, remark,Bill_no,DT_out, lst_updt,lst_usr, Pc_nm)   " & _
         "  (SELECT E_ID, Sections_id, Sections, Department_id, Department, type_in_id, type_in_nm, Name_L, Name_E, Phone, Bank_no, SSO_no, DT_strt_work, " & _
                   "   start_work_ID, start_work, txtmoney_basic, DT_Work_now, cmbclass, cmblevel, txtV_C, txt_parts_id, cmb_parts, txt_work_id, cmb_work, percen, DOB, age, gender,  " & _
                  "    BProv_ID, BVill_ID, Add_Vill_ID, houeNo, Road, Street, Card_no, dateOutID, txt_hours_money, Level_Clss_Money, Tumnang_Money, year_money, txttotal, AGL,  " & _
                  "    Total_remaining, Tax, khongsep, txtson, txtson_Money, txtmom, txtMom_mony, txtWomen_mony, txtoil_mony, txtPhone_money, txtToltal_All, chk_lut, dt_Lut,  " & _
                 "     chk_Phuk_sumhong, Dt_Phuk_sumhong, chk_Phuk, Dt_Phuk, chk_Job_Phuk, job_phuk_ID, job_phuk, chk_job_lut, job_lut_ID, job_lut, txthong, chk_job_lut_visakan,  " & _
                 "     job_lut_visakan, duties_Id, duties, chk_study, DT_study, chk_start, DT_Start, study_ID, study, txtvisa_id, txtvisa, Study_cuntry_id, Study_cuntry, chk_study2,  " & _
                 "     DT_study2, txtstudy2, chk_lang, lang_ID, lang, CmbNation1_ID, CmbNation1, CmbNation2_ID, CmbNation2, CmbNation3_ID, CmbNation3, CmbReligion_id,  " & _
             "   CmbReligion, Status_son, Status_Mom, Status_donw, Status_Up, Status_Per_id, Status_Per, Status_out, " & _
                       " N'" & (txtabount.Text) & "'," & _
              " N'" & (txtremark.Text) & "'," & _
                       " N'" & (txt_no.Text) & "'," & _
             " '" & Format(DT_out.Value, "yyyy-MM-dd") & "'," & _
                  " Getdate()," & _
           " N'" & MUserName & "', " & _
             " N'" & MDServerName & "' " & _
               "  FROM   AP_CV where E_ID ='" & txtid.Text & "' ) "
                Conn.Execute(aa)

            Else
                Conn.Execute("delete from   AP_Employee_out WHERE    E_ID= '" & (txtid.Text) & "' ")
                Dim aa As String
                aa = "INSERT INTO AP_Employee_out(E_ID, Sections_id, Sections, Department_id, Department, type_in_id, type_in_nm, Name_L, Name_E, Phone, Bank_no, SSO_no, DT_strt_work, " & _
                  "   start_work_ID, start_work, txtmoney_basic, DT_Work_now, cmbclass, cmblevel, txtV_C, txt_parts_id, cmb_parts, txt_work_id, cmb_work, percen, DOB, age, gender,  " & _
                 "    BProv_ID, BVill_ID, Add_Vill_ID, houeNo, Road, Street, Card_no, dateOutID, txt_hours_money, Level_Clss_Money, Tumnang_Money, year_money, txttotal, AGL,  " & _
                 "    Total_remaining, Tax, khongsep, txtson, txtson_Money, txtmom, txtMom_mony, txtWomen_mony, txtoil_mony, txtPhone_money, txtToltal_All, chk_lut, dt_Lut,  " & _
                "     chk_Phuk_sumhong, Dt_Phuk_sumhong, chk_Phuk, Dt_Phuk, chk_Job_Phuk, job_phuk_ID, job_phuk, chk_job_lut, job_lut_ID, job_lut, txthong, chk_job_lut_visakan,  " & _
                "     job_lut_visakan, duties_Id, duties, chk_study, DT_study, chk_start, DT_Start, study_ID, study, txtvisa_id, txtvisa, Study_cuntry_id, Study_cuntry, chk_study2,  " & _
                "     DT_study2, txtstudy2, chk_lang, lang_ID, lang, CmbNation1_ID, CmbNation1, CmbNation2_ID, CmbNation2, CmbNation3_ID, CmbNation3, CmbReligion_id,  " & _
            "   CmbReligion, Status_son, Status_Mom, Status_donw, Status_Up, Status_Per_id, Status_Per, Status_out,abount, remark,Bill_no,DT_out, lst_updt,lst_usr, Pc_nm)   " & _
        "  (SELECT E_ID, Sections_id, Sections, Department_id, Department, type_in_id, type_in_nm, Name_L, Name_E, Phone, Bank_no, SSO_no, DT_strt_work, " & _
                  "   start_work_ID, start_work, txtmoney_basic, DT_Work_now, cmbclass, cmblevel, txtV_C, txt_parts_id, cmb_parts, txt_work_id, cmb_work, percen, DOB, age, gender,  " & _
                 "    BProv_ID, BVill_ID, Add_Vill_ID, houeNo, Road, Street, Card_no, dateOutID, txt_hours_money, Level_Clss_Money, Tumnang_Money, year_money, txttotal, AGL,  " & _
                 "    Total_remaining, Tax, khongsep, txtson, txtson_Money, txtmom, txtMom_mony, txtWomen_mony, txtoil_mony, txtPhone_money, txtToltal_All, chk_lut, dt_Lut,  " & _
                "     chk_Phuk_sumhong, Dt_Phuk_sumhong, chk_Phuk, Dt_Phuk, chk_Job_Phuk, job_phuk_ID, job_phuk, chk_job_lut, job_lut_ID, job_lut, txthong, chk_job_lut_visakan,  " & _
                "     job_lut_visakan, duties_Id, duties, chk_study, DT_study, chk_start, DT_Start, study_ID, study, txtvisa_id, txtvisa, Study_cuntry_id, Study_cuntry, chk_study2,  " & _
                "     DT_study2, txtstudy2, chk_lang, lang_ID, lang, CmbNation1_ID, CmbNation1, CmbNation2_ID, CmbNation2, CmbNation3_ID, CmbNation3, CmbReligion_id,  " & _
            "   CmbReligion, Status_son, Status_Mom, Status_donw, Status_Up, Status_Per_id, Status_Per, Status_out, " & _
                      " N'" & (txtabount.Text) & "'," & _
             " N'" & (txtremark.Text) & "'," & _
                      " N'" & (txt_no.Text) & "'," & _
            " '" & Format(DT_out.Value, "yyyy-MM-dd") & "'," & _
                 " Getdate()," & _
          " N'" & MUserName & "', " & _
            " N'" & MDServerName & "' " & _
              "  FROM   AP_CV where E_ID ='" & txtid.Text & "' ) "
                Conn.Execute(aa)
            End If
        End With

      
        Conn.Execute("delete from   AP_CV WHERE    E_ID= '" & (txtid.Text) & "' ")
        'Conn.Execute(" UPDATE AP_CV SET Status_out=1 " & _
        ' " WHERE E_ID= '" & (txtid.Text) & "'")

       
    End Sub

 
    Private Sub txtson_Money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class