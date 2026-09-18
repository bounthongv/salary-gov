Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Frm_Summary_Salary_Report
    Dim Sql As String
    Private Sub Frm_Summary_Salary_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = ""
        shr_Class_vel = ""
        shr_Department = ""
        shr_section = ""
        shr_phuk = ""
        shr_job_lut = ""
        Shr_persen = ""
        chk_department.Checked = True
        RadioButton2.Checked = True

    End Sub

    Private Sub chk_section_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_section.CheckedChanged
        If chk_section.Checked = True Then
            Cmb_Sections.Enabled = True

            Cmb_Sections.Items.Clear()
            Call load_Cmb("select Sec_nmL from AP_Sections", "Sec_nmL", Cmb_Sections)
            Cmb_Sections.SelectedIndex = 0
            shr_section = " AND AP_CV.Sections_id = N'" & txtSection_ID.Text & "' "
        Else
            Cmb_Sections.Enabled = False
            Cmb_Sections.Items.Clear()
            Cmb_Sections.Text = ""
            shr_section = ""
        End If
    End Sub

    Private Sub Cmb_Sections_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Sections.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Sections Where Sec_nmL=N'" & Trim(Cmb_Sections.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtSection_ID.Text = Trim(RSC("Sec_id").Value)
            shr_section = " AND AP_CV.Sections_id = N'" & txtSection_ID.Text & "' "

        End If
    End Sub

    Private Sub chk_department_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_department.CheckedChanged
        If chk_department.Checked = True Then
            cmb_Department.Enabled = True
            cmb_Department.Items.Clear()
            Call load_Cmb("select DP_Name from Department  order by sec_id ", "DP_Name", cmb_Department)
            cmb_Department.SelectedIndex = 0
            shr_Department = " AND AP_CV.Department_id = N'" & txtdepart_ID.Text & "' "

        Else
            cmb_Department.Enabled = False
            cmb_Department.Items.Clear()
            cmb_Department.Text = ""
            shr_Department = ""
        End If
    End Sub

    Private Sub cmb_Department_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Department.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Department Where DP_name=N'" & Trim(cmb_Department.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtdepart_ID.Text = Trim(RSC("DP_ID").Value)
            shr_Department = " AND AP_CV.Department_id = N'" & txtdepart_ID.Text & "' "
        End If
    End Sub

    Private Sub chk_Job_Phuk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Job_Phuk.CheckedChanged
        If chk_Job_Phuk.Checked = True Then
            cmb_job_phuk.Enabled = True
            cmb_job_phuk.Items.Clear()
            Call load_Cmb("select job_nm from job", "job_nm", cmb_job_phuk)

            cmb_job_phuk.SelectedIndex = 0
            shr_job_phuk = " AND AP_CV.duties_Id = N'" & txt_job_phuk_id.Text & "' "

        Else
            cmb_job_phuk.Enabled = False
            cmb_job_phuk.Items.Clear()
            cmb_job_phuk.Text = ""
            shr_job_phuk = ""
        End If
    End Sub

    Private Sub cmb_job_phuk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_phuk.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From job  Where  job_nm=N'" & Trim(cmb_job_phuk.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_phuk_id.Text = Trim(RSC("job_id").Value)
            shr_job_phuk = " AND AP_CV.duties_Id = N'" & txt_job_phuk_id.Text & "' "
        End If
    End Sub

    Private Sub cmbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclass.SelectedIndexChanged
        txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text
        shr_Class_vel = " AND AP_CV.txtV_C = N'" & txtV_C.Text & "' "
    End Sub

    Private Sub cmblevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblevel.SelectedIndexChanged
        txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text
        shr_Class_vel = " AND AP_CV.txtV_C = N'" & txtV_C.Text & "' "
    End Sub


    Private Sub chk_clss_vel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_clss_vel.CheckedChanged
        If chk_clss_vel.Checked = True Then
            cmbclass.Enabled = True
            cmblevel.Enabled = True
            cmbclass.Items.Clear()
            Call load_Cmb("select cl_ID from Class", "cl_ID", cmbclass)
            cmbclass.SelectedIndex = 0

            cmblevel.Items.Clear()
            Call load_Cmb("select LV_ID from Level", "LV_ID", cmblevel)
            cmblevel.SelectedIndex = 0
            shr_Class_vel = " AND AP_CV.txtV_C = N'" & txtV_C.Text & "' "
        Else
            cmbclass.Items.Clear()
            cmblevel.Items.Clear()
            cmbclass.Enabled = False
            cmblevel.Enabled = False
            cmbclass.Text = ""
            cmblevel.Text = ""
            shr_Class_vel = ""
        End If
    End Sub

    Private Sub sum_ALL()
        'ສັງລວມ
        Dim ss As String

        ss = "delete from Sumary_salary_EX "
        Conn.Execute(ss)
        '   ss = "   insert into Sumary_salary_in (DP_ID ) " & _
        ' " Select AP_CV.Department_id " & _
        ' "    FROM         AP_Salary_in_Month INNER JOIN " & _
        '"    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
        '"    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
        '" WHERE  AP_Sections.Group_Sec_id  =01 and  AP_CV.Department_id <> 001 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  group by  AP_CV.Department_id  "
        '   Conn.Execute(ss)
        'ss = "   insert into Sumary_salary_EX (DP_ID,Sections_id ,type_in_id,Group_Sec_id,lck) " & _
        '   " Select AP_CV.Department_id ,AP_CV.Sections_id,AP_CV.type_in_id,AP_Sections.Group_Sec_id,0" & _
        '   "    FROM         AP_Salary_in_Month INNER JOIN " & _
        '  "    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
        '  "    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
        '  "   group by  AP_CV.Department_id ,AP_CV.Sections_id,AP_CV.type_in_id ,AP_Sections.Group_Sec_id "
        'Conn.Execute(ss)
        ss = "   insert into Sumary_salary_EX (DP_ID,lck) " & _
           " Select AP_CV.Department_id,0" & _
           "    FROM         AP_Salary_in_Month INNER JOIN " & _
          "    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
          "    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
          "   group by  AP_CV.Department_id  "
        Conn.Execute(ss)
 

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.QTY_Per = ( select count(AP_Salary_in_Month.PersonID) " & _
      "    FROM         AP_Salary_in_Month INNER JOIN " & _
       "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
          "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Salary_basic = ( select sum(AP_Salary_in_Month.salary) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
 "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
    "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Salary_basic_kip = ( select   sum(AP_Salary_in_Month.salary *(AP_Salary_in_Month.Rate))   " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Tum_money = ( select sum(AP_Salary_in_Month.txtTum_money) " & _
 "    FROM         AP_Salary_in_Month INNER JOIN " & _
  "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.normal_Time = ( select sum(AP_Salary_in_Month.WDayOfMonth) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
  "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.over_Time = ( select sum(AP_Salary_in_Month.txt_H_oertime) " & _
 "    FROM         AP_Salary_in_Month INNER JOIN " & _
  "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
   "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.normal_Money =  (select sum(AP_Salary_in_Month.total_amount - AP_Salary_in_Month.txtTum_money)  " & _
  "    FROM         AP_Salary_in_Month INNER JOIN " & _
 "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
  "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.over_Money = ( select sum(AP_Salary_in_Month.MOvertimeTotal) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Sum_salary =( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal)  - sum( AP_Salary_in_Month.txtTum_money) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.add_money = ( select sum(AP_Salary_in_Month.Sum_Addtional ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.cut_money = ( select sum(AP_Salary_in_Month.Sum_Deducation ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
 "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.other_money = ( select sum(AP_Salary_in_Month.Sum_Addtional_After ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.total_money = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal) +  sum(AP_Salary_in_Month.Employer_LAK )  + sum( AP_Salary_in_Month.tax_money) +  sum(AP_Salary_in_Month.Sum_Addtional ) - (sum( AP_Salary_in_Month.Sum_Deducation)) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Employee = ( select sum(AP_Salary_in_Month.Employee_LAK ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
    "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Employeer = ( select sum(AP_Salary_in_Month.Employer_LAK ) " & _
         "    FROM         AP_Salary_in_Month INNER JOIN " & _
        "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
             "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Sum_SSO = ( select sum(AP_Salary_in_Month.Employer_LAK ) +   sum(AP_Salary_in_Month.Employee_LAK )  " & _
    "    FROM         AP_Salary_in_Month INNER JOIN " & _
   "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
        "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Summoney_in_tax =  ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal) +  sum(AP_Salary_in_Month.Employer_LAK )  +  sum(AP_Salary_in_Month.Sum_Addtional ) - (sum( AP_Salary_in_Month.Sum_Deducation))  " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
   "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.tax = ( select sum(AP_Salary_in_Month.tax_money ) " & _
        "    FROM         AP_Salary_in_Month INNER JOIN " & _
       "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
            "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.money_after_tax =( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal)  +  sum(AP_Salary_in_Month.tax_money) + sum(AP_Salary_in_Month.Sum_Addtional)  + sum(AP_Salary_in_Month.Sum_Deducation) -( sum(AP_Salary_in_Month.Employee_LAK)   + sum(AP_Salary_in_Month.tax_money) ) " & _
                    "    FROM         AP_Salary_in_Month INNER JOIN " & _
                   "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                        "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.cut_after_tax = ( select sum(AP_Salary_in_Month.Sum_Deducation_After ) " & _
                                 "    FROM         AP_Salary_in_Month INNER JOIN " & _
                                "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                     "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Net_money = ( select sum(AP_Salary_in_Month.Total_Money_curr_Exing ) " & _
                             "    FROM         AP_Salary_in_Month INNER JOIN " & _
                            "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                 "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)
        '( select sum(AP_Salary_in_Month.Money_Befor ) - (sum( AP_Salary_in_Month.Employee_LAK) + sum( AP_Salary_in_Month.Sum_Deducation_After)) 
        '( select   sum(AP_Salary_in_Month.Total_Money_curr_Exing * (AP_Salary_in_Month.Rate))
        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Net_money_kip = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal)  +  sum(AP_Salary_in_Month.tax_money) + sum(AP_Salary_in_Month.Sum_Addtional)  + sum(AP_Salary_in_Month.Sum_Deducation) -( sum(AP_Salary_in_Month.Employee_LAK)   + sum(AP_Salary_in_Month.tax_money)+ sum(AP_Salary_in_Month.Sum_Deducation_After ) )  " & _
             "    FROM         AP_Salary_in_Month INNER JOIN " & _
             "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
             "  where    AP_CV.Department_id = Sumary_salary_EX.DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ''        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Net_money_kip = ( select sum(AP_Salary_in_Month.Money_Befor ) - (sum( AP_Salary_in_Month.Employee_LAK) + sum( AP_Salary_in_Month.Sum_Deducation_After))   " & _
        ''"    FROM         AP_Salary_in_Month INNER JOIN " & _
        ''"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
        ''"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        ''        Conn.Execute(ss)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim RSC As New ADODB.Recordset
        Dim aa As String
        With RSC
            If RadioButton1.Checked = True Then
                sum_ALL()
                Dim ss As String
                ss = "delete Sumary_salary_EX2 "
                Conn.Execute(ss)
                ss = " insert into Sumary_salary_EX2 (   DP_ID, QTY_Per, Salary_basic, Salary_basic_kip, Tum_money, normal_Time, over_Time, normal_Money, over_Money, Sum_salary, add_money, cut_money, other_money, total_money, " & _
                " Employee, Employeer, Sum_SSO, Summoney_in_tax, tax, money_after_tax, cut_after_tax, Net_money, Net_money_kip )   " & _
                 " SELECT     Sumary_salary_EX.DP_ID, Sumary_salary_EX.QTY_Per, Sumary_salary_EX.Salary_basic, Sumary_salary_EX.Salary_basic_kip, Sumary_salary_EX.Tum_money, Sumary_salary_EX.normal_Time, Sumary_salary_EX.over_Time, Sumary_salary_EX.normal_Money, Sumary_salary_EX.over_Money, Sumary_salary_EX.Sum_salary, Sumary_salary_EX.add_money, Sumary_salary_EX.cut_money, Sumary_salary_EX.other_money, Sumary_salary_EX.total_money, " & _
              "  Sumary_salary_EX.Employee, Sumary_salary_EX.Employeer, Sumary_salary_EX.Sum_SSO, Sumary_salary_EX.Summoney_in_tax, Sumary_salary_EX.tax, Sumary_salary_EX.money_after_tax, Sumary_salary_EX.cut_after_tax, Sumary_salary_EX.Net_money, Sumary_salary_EX.Net_money_kip " & _
           "   FROM         Sumary_salary_EX INNER JOIN " & _
                     "  Department ON Sumary_salary_EX.DP_ID = Department.DP_ID   where  Department.Section_id='01' order by Department.sec_id "
                Conn.Execute(ss)

 

                ss = " insert into Sumary_salary_EX2 (DP_ID, QTY_Per, Salary_basic, Salary_basic_kip, Tum_money, normal_Time, over_Time, normal_Money, over_Money, Sum_salary, add_money, cut_money, other_money, total_money, " & _
                      " Employee, Employeer, Sum_SSO, Summoney_in_tax, tax, money_after_tax, cut_after_tax, Net_money, Net_money_kip )   " & _
                     "    SELECT  Department.Group_SLR_id,  sum(Sumary_salary_EX.QTY_Per), sum(Sumary_salary_EX.Salary_basic), sum(Sumary_salary_EX.Salary_basic_kip), sum(Sumary_salary_EX.Tum_money),  " & _
               "    sum(Sumary_salary_EX.normal_Time), sum(Sumary_salary_EX.over_Time), sum(Sumary_salary_EX.normal_Money), sum(Sumary_salary_EX.over_Money), sum(Sumary_salary_EX.Sum_salary),  " & _
                " sum(Sumary_salary_EX.add_money), sum(Sumary_salary_EX.cut_money), sum(Sumary_salary_EX.other_money), sum(Sumary_salary_EX.total_money),   " & _
                   "  sum(Sumary_salary_EX.Employee), sum(Sumary_salary_EX.Employeer), sum(Sumary_salary_EX.Sum_SSO), sum(Sumary_salary_EX.Summoney_in_tax), " & _
                   "        sum(Sumary_salary_EX.tax), sum(Sumary_salary_EX.money_after_tax), sum(Sumary_salary_EX.cut_after_tax), sum(Sumary_salary_EX.Net_money),  " & _
                "    sum(Sumary_salary_EX.Net_money_kip) " & _
              "                FROM     Sumary_salary_EX INNER JOIN    " & _
                "   Department ON Sumary_salary_EX.DP_ID = Department.DP_ID  " & _
             "    where        Department.Section_id='02'   and Department.Group_SLR_id='1'    group by Department.Group_SLR_id "
                Conn.Execute(ss)

                ss = " insert into Sumary_salary_EX2 (DP_ID, QTY_Per, Salary_basic, Salary_basic_kip, Tum_money, normal_Time, over_Time, normal_Money, over_Money, Sum_salary, add_money, cut_money, other_money, total_money, " & _
                      " Employee, Employeer, Sum_SSO, Summoney_in_tax, tax, money_after_tax, cut_after_tax, Net_money, Net_money_kip )   " & _
                     "    SELECT  '2',  sum(Sumary_salary_EX.QTY_Per), sum(Sumary_salary_EX.Salary_basic), sum(Sumary_salary_EX.Salary_basic_kip), sum(Sumary_salary_EX.Tum_money),  " & _
               "    sum(Sumary_salary_EX.normal_Time), sum(Sumary_salary_EX.over_Time), sum(Sumary_salary_EX.normal_Money), sum(Sumary_salary_EX.over_Money), sum(Sumary_salary_EX.Sum_salary),  " & _
                " sum(Sumary_salary_EX.add_money), sum(Sumary_salary_EX.cut_money), sum(Sumary_salary_EX.other_money), sum(Sumary_salary_EX.total_money),   " & _
                   "  sum(Sumary_salary_EX.Employee), sum(Sumary_salary_EX.Employeer), sum(Sumary_salary_EX.Sum_SSO), sum(Sumary_salary_EX.Summoney_in_tax), " & _
                   "        sum(Sumary_salary_EX.tax), sum(Sumary_salary_EX.money_after_tax), sum(Sumary_salary_EX.cut_after_tax), sum(Sumary_salary_EX.Net_money),  " & _
                "    sum(Sumary_salary_EX.Net_money_kip) " & _
              "                FROM     Sumary_salary_EX INNER JOIN    " & _
                "   Department ON Sumary_salary_EX.DP_ID = Department.DP_ID  " & _
             "    where        Department.Section_id='02'   and Department.Group_SLR_id='2'    group by Department.Group_SLR_id "
                Conn.Execute(ss)

                ss = " insert into Sumary_salary_EX2 (DP_ID, QTY_Per, Salary_basic, Salary_basic_kip, Tum_money, normal_Time, over_Time, normal_Money, over_Money, Sum_salary, add_money, cut_money, other_money, total_money, " & _
              " Employee, Employeer, Sum_SSO, Summoney_in_tax, tax, money_after_tax, cut_after_tax, Net_money, Net_money_kip )   " & _
             "    SELECT  '4',  sum(Sumary_salary_EX.QTY_Per), sum(Sumary_salary_EX.Salary_basic), sum(Sumary_salary_EX.Salary_basic_kip), sum(Sumary_salary_EX.Tum_money),  " & _
       "    sum(Sumary_salary_EX.normal_Time), sum(Sumary_salary_EX.over_Time), sum(Sumary_salary_EX.normal_Money), sum(Sumary_salary_EX.over_Money), sum(Sumary_salary_EX.Sum_salary),  " & _
        " sum(Sumary_salary_EX.add_money), sum(Sumary_salary_EX.cut_money), sum(Sumary_salary_EX.other_money), sum(Sumary_salary_EX.total_money),   " & _
           "  sum(Sumary_salary_EX.Employee), sum(Sumary_salary_EX.Employeer), sum(Sumary_salary_EX.Sum_SSO), sum(Sumary_salary_EX.Summoney_in_tax), " & _
           "        sum(Sumary_salary_EX.tax), sum(Sumary_salary_EX.money_after_tax), sum(Sumary_salary_EX.cut_after_tax), sum(Sumary_salary_EX.Net_money),  " & _
        "    sum(Sumary_salary_EX.Net_money_kip) " & _
      "                FROM     Sumary_salary_EX INNER JOIN    " & _
        "   Department ON Sumary_salary_EX.DP_ID = Department.DP_ID  " & _
     "    where        Department.Section_id='03'   and Department.Group_SLR_id='2'    group by Department.Group_SLR_id "
                Conn.Execute(ss)

                aa = "   update Sumary_salary_EX2 set  DP_nm  = Department.DP_Name from Department where Sumary_salary_EX2.DP_ID =Department.DP_ID "
                Conn.Execute(aa)
                aa = "   update Sumary_salary_EX2 set  DP_nm  = N'ພະນັກງານສົມບູນ ສາຂາພາຍໃນ' where DP_ID ='1'  "
                Conn.Execute(aa)
                aa = "   update Sumary_salary_EX2 set  DP_nm  = N'ພະນັກງານສັນຍາຈ້າງ ສາຂາພາຍໃນ' where DP_ID ='2'  "
                Conn.Execute(aa)
                aa = "   update Sumary_salary_EX2 set  DP_nm  = N'ພະນັກງານ ສາຂາຕ່າງປະທດ' where DP_ID ='4'  "
                Conn.Execute(aa)

                aa = "   update Sumary_salary_EX2 set  sec_id  = Department.sec_id from Department  where  Sumary_salary_EX2.DP_ID=Department.DP_ID  "
                Conn.Execute(aa)

                aa = "   update Sumary_salary_EX2 set  Sections_id  = '01' where  DP_ID<>'1' and DP_ID<>'2'  and DP_ID<>'3'"
                Conn.Execute(aa)

                aa = "   update Sumary_salary_EX2 set  Sections_id  = '02' where  DP_ID='1'  "
                Conn.Execute(aa)
                aa = "   update Sumary_salary_EX2 set  Sections_id  = '02' where  DP_ID='2'  "
                Conn.Execute(aa)
                aa = "   update Sumary_salary_EX2 set  Sections_id  = '04' where  DP_ID='4'  "
                Conn.Execute(aa)
                'ສັງລວມທັງໝົດ

                'aa = "SELECT  Sumary_salary_EX.* , Department.Group_SLR_id, Department.DP_Name, Department.Sec_id " & _
                '             "   FROM         Sumary_salary_EX INNER JOIN " & _
                '              "      Department ON Sumary_salary_EX.DP_ID = Department.DP_ID  where  Sumary_salary_EX.QTY_Per >0   order by Department.Sec_id, Sumary_salary_EX.DP_ID  "
                'Call LoadRs(aa, RSC)

                aa = "SELECT  *  FROM     Sumary_salary_EX2 where Sumary_salary_EX2.QTY_Per >0    order by Sumary_salary_EX2.sec_id "
                Call LoadRs(aa, RSC)
                If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
                Dim Frm As New FrmPreview
                Dim Rpt As New Report_summary_Salary_ALL
                Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
                myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text3"), CrystalDecisions.CrystalReports.Engine.TextObject)
                myTextObjectOnReport.Text = "ສັງລວມບັນຊີເງີນເດືອນຂອງພະນັກງານ - ກຳມະກອນລັດວິສາຫະກິດການບິນລາວ"

                myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
                myTextObjectOnReport.Text = (Format(DT_Month.Value, "MM/yyyy"))
                If chk_section.Checked = True Then
                    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                    myTextObjectOnReport.Text = Cmb_Sections.Text


                Else
                    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                    myTextObjectOnReport.Text = ""
                End If
                'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T2"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'myTextObjectOnReport.Text = txtTdate.Value
                Rpt.SetDataSource(RSC)
                Rpt.Refresh()
                Frm.ReportViewer.ReportSource = Rpt
                Frm.ReportViewer.Zoom(100%)
                Frm.ReportViewer.DisplayGroupTree = False
                Frm.WindowState = FormWindowState.Maximized
                Frm.Show()

            ElseIf RadioButton2.Checked = True Then
                'ສັງລວມພາຍໃນສູນກາງ
                Dim ss As String

                ss = "delete from Sumary_salary_in "
                Conn.Execute(ss)
                '   ss = "   insert into Sumary_salary_in (DP_ID ) " & _
                ' " Select AP_CV.Department_id " & _
                ' "    FROM         AP_Salary_in_Month INNER JOIN " & _
                '"    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
                '"    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
                '" WHERE  AP_Sections.Group_Sec_id  =01 and  AP_CV.Department_id <> 001 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  group by  AP_CV.Department_id  "
                '   Conn.Execute(ss)
                ss = "   insert into Sumary_salary_in (DP_ID ) " & _
                   " Select AP_CV.Department_id " & _
                   "    FROM         AP_Salary_in_Month INNER JOIN " & _
                  "    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
                  "    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
                  " WHERE  AP_Sections.Group_Sec_id  =01 and  AP_Sections.Sec_id  =01   group by  AP_CV.Department_id  "
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.QTY_Per = ( select count(AP_Salary_in_Month.PersonID) " & _
              "    FROM         AP_Salary_in_Month INNER JOIN " & _
               "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                  "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Salary_basic = ( select sum(AP_Salary_in_Month.salary) " & _
        "    FROM         AP_Salary_in_Month INNER JOIN " & _
         "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
            "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Tum_money = ( select sum(AP_Salary_in_Month.txtTum_money) " & _
         "    FROM         AP_Salary_in_Month INNER JOIN " & _
          "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
      "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)


                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.normal_Time = ( select sum(AP_Salary_in_Month.WDayOfMonth) " & _
   "    FROM         AP_Salary_in_Month INNER JOIN " & _
    "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
          "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)


                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.over_Time = ( select sum(AP_Salary_in_Month.txt_H_oertime) " & _
         "    FROM         AP_Salary_in_Month INNER JOIN " & _
          "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
           "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.normal_Money = (select sum(AP_Salary_in_Month.total_amount - AP_Salary_in_Month.txtTum_money) " & _
          "    FROM         AP_Salary_in_Month INNER JOIN " & _
         "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
          "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.over_Money = ( select sum(AP_Salary_in_Month.MOvertimeTotal) " & _
     "    FROM         AP_Salary_in_Month INNER JOIN " & _
    "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
     "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Sum_salary = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal)  - sum( AP_Salary_in_Month.txtTum_money) " & _
       "    FROM         AP_Salary_in_Month INNER JOIN " & _
        "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
        "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.add_money = ( select sum(AP_Salary_in_Month.Sum_Addtional ) " & _
       "    FROM         AP_Salary_in_Month INNER JOIN " & _
        "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
        "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.cut_money = ( select sum(AP_Salary_in_Month.Sum_Deducation ) " & _
       "    FROM         AP_Salary_in_Month INNER JOIN " & _
       "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
         "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.other_money = ( select sum(AP_Salary_in_Month.Sum_Addtional_After ) " & _
     "    FROM         AP_Salary_in_Month INNER JOIN " & _
     "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
       "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.total_money = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal) +  sum(AP_Salary_in_Month.Employer_LAK )  + sum( AP_Salary_in_Month.tax_money) +  sum(AP_Salary_in_Month.Sum_Addtional ) - (sum( AP_Salary_in_Month.Sum_Deducation)) " & _
 "    FROM         AP_Salary_in_Month INNER JOIN " & _
 "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
   "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Employee = ( select sum(AP_Salary_in_Month.Employee_LAK ) " & _
        "    FROM         AP_Salary_in_Month INNER JOIN " & _
       "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
            "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Employeer = ( select sum(AP_Salary_in_Month.Employer_LAK ) " & _
                 "    FROM         AP_Salary_in_Month INNER JOIN " & _
                "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                     "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)


                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Sum_SSO = ( select sum(AP_Salary_in_Month.Employer_LAK ) +   sum(AP_Salary_in_Month.Employee_LAK )  " & _
            "    FROM         AP_Salary_in_Month INNER JOIN " & _
           "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Summoney_in_tax = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal) +  sum(AP_Salary_in_Month.Employer_LAK )  +  sum(AP_Salary_in_Month.Sum_Addtional ) - (sum( AP_Salary_in_Month.Sum_Deducation)) " & _
       "    FROM         AP_Salary_in_Month INNER JOIN " & _
      "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
           "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.tax = ( select sum(AP_Salary_in_Month.tax_money ) " & _
                "    FROM         AP_Salary_in_Month INNER JOIN " & _
               "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                    "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.money_after_tax = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal)  +  sum(AP_Salary_in_Month.tax_money) + sum(AP_Salary_in_Month.Sum_Addtional)  + sum(AP_Salary_in_Month.Sum_Deducation) -( sum(AP_Salary_in_Month.Employee_LAK) + + sum(AP_Salary_in_Month.tax_money) )  " & _
                            "    FROM         AP_Salary_in_Month INNER JOIN " & _
                           "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.cut_after_tax = ( select sum(AP_Salary_in_Month.Sum_Deducation_After ) " & _
                                         "    FROM         AP_Salary_in_Month INNER JOIN " & _
                                        "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                             "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)

                ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Net_money = ( select sum(AP_Salary_in_Month.Total_Money_curr_Exing ) " & _
                                     "    FROM         AP_Salary_in_Month INNER JOIN " & _
                                    "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                         "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
                Conn.Execute(ss)
                aa = "SELECT  Sumary_salary_in.* , Department.Group_SLR_id, Department.DP_Name, Department.Sec_id " & _
               "   FROM         Sumary_salary_in INNER JOIN " & _
                "      Department ON Sumary_salary_in.DP_ID = Department.DP_ID  where  Sumary_salary_in.QTY_Per >0  order by    Department.Sec_id,Sumary_salary_in.DP_ID   "
                Call LoadRs(aa, RSC)
                If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
                Dim Frm As New FrmPreview
                Dim Rpt As New Report_summary_Salary_in
                Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
                'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'myTextObjectOnReport.Text = "(ຂອງ " & Location_nm & ")"

                myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
                myTextObjectOnReport.Text = (Format(DT_Month.Value, "MM/yyyy"))
                myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text3"), CrystalDecisions.CrystalReports.Engine.TextObject)
                myTextObjectOnReport.Text = "ສັງລວມບັນຊີເງີນເດືອນຂອງພະນັກງານ - ກຳມະກອນລັດວິສາຫະກິດການບິນລາວ ສູນກາງ ນະຄອນຫລວງວຽງຈັນ"
                If chk_section.Checked = True Then
                    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                    myTextObjectOnReport.Text = Cmb_Sections.Text


                Else
                    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                    myTextObjectOnReport.Text = ""
                End If
                'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T2"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'myTextObjectOnReport.Text = txtTdate.Value
                Rpt.SetDataSource(RSC)
                Rpt.Refresh()
                Frm.ReportViewer.ReportSource = Rpt
                Frm.ReportViewer.Zoom(100%)
                Frm.ReportViewer.DisplayGroupTree = False
                Frm.WindowState = FormWindowState.Maximized
                Frm.Show()
            ElseIf RadioButton4.Checked = True Then
                'ສັງລວມສາຂາພາຍໃນ

                sum_sakha()
                aa = "SELECT  Sumary_salary_in.* , Department.Group_SLR_id, Department.DP_Name, Department.Sec_id " & _
                             "   FROM         Sumary_salary_in INNER JOIN " & _
                              "      Department ON Sumary_salary_in.DP_ID = Department.DP_ID   where  Sumary_salary_in.QTY_Per >0   order by    Department.Sec_id,Sumary_salary_in.DP_ID  "
                Call LoadRs(aa, RSC)
                If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
                Dim Frm As New FrmPreview
                Dim Rpt As New Report_summary_Salary_in
                Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
                'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'myTextObjectOnReport.Text = "(ຂອງ " & Location_nm & ")"

                myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
                myTextObjectOnReport.Text = (Format(DT_Month.Value, "MM/yyyy"))
                If chk_section.Checked = True Then
                    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                    myTextObjectOnReport.Text = Cmb_Sections.Text


                Else
                    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                    myTextObjectOnReport.Text = ""
                End If
                'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T2"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'myTextObjectOnReport.Text = txtTdate.Value
                Rpt.SetDataSource(RSC)
                Rpt.Refresh()
                Frm.ReportViewer.ReportSource = Rpt
                Frm.ReportViewer.Zoom(100%)
                Frm.ReportViewer.DisplayGroupTree = False
                Frm.WindowState = FormWindowState.Maximized
                Frm.Show()
            Else
                'ສັງລວມສາຂາຕ່າງປະເທດ
                sum_sakha_EX()
                aa = "SELECT  Sumary_salary_EX.* , Department.Group_SLR_id, Department.DP_Name, Department.Sec_id " & _
                             "   FROM         Sumary_salary_EX INNER JOIN " & _
                              "      Department ON Sumary_salary_EX.DP_ID = Department.DP_ID  where  Sumary_salary_EX.QTY_Per >0    order by    Department.Sec_id,Sumary_salary_EX.DP_ID  "
                Call LoadRs(aa, RSC)
                If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
                Dim Frm As New FrmPreview
                Dim Rpt As New Report_summary_Salary_EX
                Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
                'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'myTextObjectOnReport.Text = "(ຂອງ " & Location_nm & ")"

                myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
                myTextObjectOnReport.Text = (Format(DT_Month.Value, "MM/yyyy"))
                If chk_section.Checked = True Then
                    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                    myTextObjectOnReport.Text = Cmb_Sections.Text


                Else
                    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                    myTextObjectOnReport.Text = ""
                End If
                'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T2"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'myTextObjectOnReport.Text = txtTdate.Value
                Rpt.SetDataSource(RSC)
                Rpt.Refresh()
                Frm.ReportViewer.ReportSource = Rpt
                Frm.ReportViewer.Zoom(100%)
                Frm.ReportViewer.DisplayGroupTree = False
                Frm.WindowState = FormWindowState.Maximized
                Frm.Show()
            End If




        End With
    End Sub
    Private Sub sum_cnter()

        'ສັງລວມພາຍໃນສູນກາງ
        Dim ss As String

        ss = "delete from Sumary_salary_in "
        Conn.Execute(ss)
        '   ss = "   insert into Sumary_salary_in (DP_ID ) " & _
        ' " Select AP_CV.Department_id " & _
        ' "    FROM         AP_Salary_in_Month INNER JOIN " & _
        '"    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
        '"    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
        '" WHERE  AP_Sections.Group_Sec_id  =01 and  AP_CV.Department_id <> 001 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  group by  AP_CV.Department_id  "
        '   Conn.Execute(ss)
        ss = "   insert into Sumary_salary_in (DP_ID ) " & _
           " Select AP_CV.Department_id " & _
           "    FROM         AP_Salary_in_Month INNER JOIN " & _
          "    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
          "    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
          " WHERE  AP_Sections.Group_Sec_id  =01 and  AP_Sections.Sec_id  =01   group by  AP_CV.Department_id  "
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.QTY_Per = ( select count(AP_Salary_in_Month.PersonID) " & _
      "    FROM         AP_Salary_in_Month INNER JOIN " & _
       "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
          "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Salary_basic = ( select sum(AP_Salary_in_Month.salary) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
 "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
    "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Tum_money = ( select sum(AP_Salary_in_Month.txtTum_money) " & _
 "    FROM         AP_Salary_in_Month INNER JOIN " & _
  "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.normal_Time = ( select sum(AP_Salary_in_Month.WDayOfMonth) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
  "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.over_Time = ( select sum(AP_Salary_in_Month.txt_H_oertime) " & _
 "    FROM         AP_Salary_in_Month INNER JOIN " & _
  "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
   "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.normal_Money = ( select sum(AP_Salary_in_Month.total_amount) " & _
  "    FROM         AP_Salary_in_Month INNER JOIN " & _
 "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
  "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.over_Money = ( select sum(AP_Salary_in_Month.MOvertimeTotal) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Sum_salary = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.add_money = ( select sum(AP_Salary_in_Month.Sum_Addtional ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.cut_money = ( select sum(AP_Salary_in_Month.Sum_Deducation ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
 "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.other_money = ( select sum(AP_Salary_in_Month.Sum_Addtional_After ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.total_money = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal) +  sum(AP_Salary_in_Month.Sum_Addtional ) - sum( AP_Salary_in_Month.Sum_Deducation) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Employee = ( select sum(AP_Salary_in_Month.Employee_LAK ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
    "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Employeer = ( select sum(AP_Salary_in_Month.Employer_LAK ) " & _
         "    FROM         AP_Salary_in_Month INNER JOIN " & _
        "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
             "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Sum_SSO = ( select sum(AP_Salary_in_Month.Employer_LAK ) +   sum(AP_Salary_in_Month.Employee_LAK )  " & _
    "    FROM         AP_Salary_in_Month INNER JOIN " & _
   "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
        "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Summoney_in_tax = ( select sum(AP_Salary_in_Month.Money_Befor ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
   "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.tax = ( select sum(AP_Salary_in_Month.tax_money ) " & _
        "    FROM         AP_Salary_in_Month INNER JOIN " & _
       "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
            "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.money_after_tax = ( select sum(AP_Salary_in_Month.Money_After ) " & _
                    "    FROM         AP_Salary_in_Month INNER JOIN " & _
                   "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                        "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.cut_after_tax = ( select sum(AP_Salary_in_Month.Sum_Deducation_After ) " & _
                                 "    FROM         AP_Salary_in_Month INNER JOIN " & _
                                "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                     "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Net_money = ( select sum(AP_Salary_in_Month.Total_Money_curr_Exing ) " & _
                             "    FROM         AP_Salary_in_Month INNER JOIN " & _
                            "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                 "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)
    End Sub

    Private Sub sum_sakha_EX()
        'ສັງລວມສາຂາຕ່າງປະເທດ
        Dim ss As String

        ss = "delete from Sumary_salary_EX "
        Conn.Execute(ss)
        '   ss = "   insert into Sumary_salary_in (DP_ID ) " & _
        ' " Select AP_CV.Department_id " & _
        ' "    FROM         AP_Salary_in_Month INNER JOIN " & _
        '"    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
        '"    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
        '" WHERE  AP_Sections.Group_Sec_id  =01 and  AP_CV.Department_id <> 001 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  group by  AP_CV.Department_id  "
        '   Conn.Execute(ss)
        ss = "   insert into Sumary_salary_EX (DP_ID ) " & _
           " Select AP_CV.Department_id " & _
           "    FROM         AP_Salary_in_Month INNER JOIN " & _
          "    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
          "    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
          " WHERE  AP_Sections.Group_Sec_id  =02      group by  AP_CV.Department_id  "
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.QTY_Per = ( select count(AP_Salary_in_Month.PersonID) " & _
      "    FROM         AP_Salary_in_Month INNER JOIN " & _
       "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
          "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Salary_basic = ( select sum(AP_Salary_in_Month.salary) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
 "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
    "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Salary_basic_kip = ( select   sum(AP_Salary_in_Month.salary *(AP_Salary_in_Month.Rate))   " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Tum_money = ( select sum(AP_Salary_in_Month.txtTum_money) " & _
 "    FROM         AP_Salary_in_Month INNER JOIN " & _
  "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.normal_Time = ( select sum(AP_Salary_in_Month.WDayOfMonth) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
  "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.over_Time = ( select sum(AP_Salary_in_Month.txt_H_oertime) " & _
 "    FROM         AP_Salary_in_Month INNER JOIN " & _
  "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
   "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.normal_Money =  (select sum(AP_Salary_in_Month.total_amount - AP_Salary_in_Month.txtTum_money) " & _
  "    FROM         AP_Salary_in_Month INNER JOIN " & _
 "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
  "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.over_Money = ( select sum(AP_Salary_in_Month.MOvertimeTotal) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Sum_salary =( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal)  - sum( AP_Salary_in_Month.txtTum_money)  " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.add_money = ( select sum(AP_Salary_in_Month.Sum_Addtional ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.cut_money = ( select sum(AP_Salary_in_Month.Sum_Deducation ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
 "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.other_money = ( select sum(AP_Salary_in_Month.Sum_Addtional_After ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.total_money = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal) +  sum(AP_Salary_in_Month.Employer_LAK )  + sum( AP_Salary_in_Month.tax_money) +  sum(AP_Salary_in_Month.Sum_Addtional ) - (sum( AP_Salary_in_Month.Sum_Deducation)) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Employee = ( select sum(AP_Salary_in_Month.Employee_LAK ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
    "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Employeer = ( select sum(AP_Salary_in_Month.Employer_LAK ) " & _
         "    FROM         AP_Salary_in_Month INNER JOIN " & _
        "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
             "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Sum_SSO = ( select sum(AP_Salary_in_Month.Employer_LAK ) +   sum(AP_Salary_in_Month.Employee_LAK )  " & _
    "    FROM         AP_Salary_in_Month INNER JOIN " & _
   "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
        "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Summoney_in_tax = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal) +  sum(AP_Salary_in_Month.Employer_LAK )  +  sum(AP_Salary_in_Month.Sum_Addtional ) - (sum( AP_Salary_in_Month.Sum_Deducation)) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
   "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.tax = ( select sum(AP_Salary_in_Month.tax_money ) " & _
        "    FROM         AP_Salary_in_Month INNER JOIN " & _
       "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
            "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.money_after_tax = ( select sum(AP_Salary_in_Month.Money_Befor ) - sum( AP_Salary_in_Month.Employee_LAK) " & _
                    "    FROM         AP_Salary_in_Month INNER JOIN " & _
                   "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                        "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.cut_after_tax = ( select sum(AP_Salary_in_Month.Sum_Deducation_After ) " & _
                                 "    FROM         AP_Salary_in_Month INNER JOIN " & _
                                "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                     "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)
        'ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Net_money = ( select sum(AP_Salary_in_Month.Total_Money_curr_Exing ) " & _

        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Net_money =  ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal)  +  sum(AP_Salary_in_Month.Sum_Addtional) - sum(AP_Salary_in_Month.Sum_Deducation_After )  " & _
                             "    FROM         AP_Salary_in_Month INNER JOIN " & _
                            "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                 "  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)
        'ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Net_money_kip = ( select   sum(AP_Salary_in_Month.Total_Money_curr_Exing * (AP_Salary_in_Month.Rate))   " & _


        ss = "    update Sumary_salary_EX  Set  Sumary_salary_EX.Net_money_kip = ( select sum(AP_Salary_in_Month.Money_Befor ) - (sum( AP_Salary_in_Month.Employee_LAK) + sum( AP_Salary_in_Month.Sum_Deducation_After))  " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_EX .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

    End Sub
    Private Sub sum_sakha()
        'ສັງລວມສາຂາພາຍໃນ
        Dim ss As String

        ss = "delete from Sumary_salary_in "
        Conn.Execute(ss)
        '   ss = "   insert into Sumary_salary_in (DP_ID ) " & _
        ' " Select AP_CV.Department_id " & _
        ' "    FROM         AP_Salary_in_Month INNER JOIN " & _
        '"    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
        '"    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
        '" WHERE  AP_Sections.Group_Sec_id  =01 and  AP_CV.Department_id <> 001 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  group by  AP_CV.Department_id  "
        '   Conn.Execute(ss)
        ss = "   insert into Sumary_salary_in (DP_ID ) " & _
           " Select AP_CV.Department_id " & _
           "    FROM         AP_Salary_in_Month INNER JOIN " & _
          "    AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
          "    AP_Sections  on ap_cv.Sections_id=AP_Sections .Sec_id " & _
          " WHERE  AP_Sections.Group_Sec_id  =01 and  AP_Sections.Sec_id  <> 01   group by  AP_CV.Department_id  "
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.QTY_Per = ( select count(AP_Salary_in_Month.PersonID) " & _
      "    FROM         AP_Salary_in_Month INNER JOIN " & _
       "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
          "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Salary_basic = ( select sum(AP_Salary_in_Month.salary) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
 "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
    "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Tum_money = ( select sum(AP_Salary_in_Month.txtTum_money) " & _
 "    FROM         AP_Salary_in_Month INNER JOIN " & _
  "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.normal_Time = ( select sum(AP_Salary_in_Month.WDayOfMonth) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
  "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.over_Time = ( select sum(AP_Salary_in_Month.txt_H_oertime) " & _
 "    FROM         AP_Salary_in_Month INNER JOIN " & _
  "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
   "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set   Sumary_salary_in.normal_Money = (select sum(AP_Salary_in_Month.total_amount - AP_Salary_in_Month.txtTum_money) " & _
  "    FROM         AP_Salary_in_Month INNER JOIN " & _
 "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
  "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.over_Money = ( select sum(AP_Salary_in_Month.MOvertimeTotal) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set    Sumary_salary_in.Sum_salary = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal)  - sum( AP_Salary_in_Month.txtTum_money) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.add_money = ( select sum(AP_Salary_in_Month.Sum_Addtional ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.cut_money = ( select sum(AP_Salary_in_Month.Sum_Deducation ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
 "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.other_money = ( select sum(AP_Salary_in_Month.Sum_Addtional_After ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.total_money = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal) +  sum(AP_Salary_in_Month.Employer_LAK )  + sum( AP_Salary_in_Month.tax_money) +  sum(AP_Salary_in_Month.Sum_Addtional ) - (sum( AP_Salary_in_Month.Sum_Deducation)) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
"  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Employee = ( select sum(AP_Salary_in_Month.Employee_LAK ) " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
    "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Employeer = ( select sum(AP_Salary_in_Month.Employer_LAK ) " & _
         "    FROM         AP_Salary_in_Month INNER JOIN " & _
        "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
             "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)


        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Sum_SSO = ( select sum(AP_Salary_in_Month.Employer_LAK ) +   sum(AP_Salary_in_Month.Employee_LAK )  " & _
    "    FROM         AP_Salary_in_Month INNER JOIN " & _
   "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
        "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Summoney_in_tax = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal) +  sum(AP_Salary_in_Month.Employer_LAK )  +  sum(AP_Salary_in_Month.Sum_Addtional ) - (sum( AP_Salary_in_Month.Sum_Deducation))  " & _
"    FROM         AP_Salary_in_Month INNER JOIN " & _
"  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
   "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.tax = ( select sum(AP_Salary_in_Month.tax_money ) " & _
        "    FROM         AP_Salary_in_Month INNER JOIN " & _
       "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
            "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.money_after_tax = ( select sum(AP_Salary_in_Month.total_amount ) + sum( AP_Salary_in_Month.MOvertimeTotal)  +  sum(AP_Salary_in_Month.tax_money) + sum(AP_Salary_in_Month.Sum_Addtional)  + sum(AP_Salary_in_Month.Sum_Deducation) -( sum(AP_Salary_in_Month.Employee_LAK) + + sum(AP_Salary_in_Month.tax_money) ) " & _
                    "    FROM         AP_Salary_in_Month INNER JOIN " & _
                   "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                        "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.cut_after_tax = ( select sum(AP_Salary_in_Month.Sum_Deducation_After ) " & _
                                 "    FROM         AP_Salary_in_Month INNER JOIN " & _
                                "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                     "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

        ss = "    update Sumary_salary_in  Set  Sumary_salary_in.Net_money = ( select sum(AP_Salary_in_Month.Total_Money_curr_Exing ) " & _
                             "    FROM         AP_Salary_in_Month INNER JOIN " & _
                            "  AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID " & _
                                 "  where    AP_CV.Department_id = Sumary_salary_in .DP_ID and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'  )"
        Conn.Execute(ss)

    End Sub


    Private Sub Chk_Dt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Dt.CheckedChanged
        If Chk_Dt.Checked = True Then
            txtFdate.Enabled = True
            txtTdate.Enabled = True
            'Sql = " AND AP_CV.DT_Work_now between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"

        Else
            txtFdate.Enabled = False
            txtTdate.Enabled = False
            Sql = ""

        End If
    End Sub

    Private Sub txtFdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFdate.ValueChanged
        'Sql = " AND AP_CV.DT_Work_now between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
    End Sub

    Private Sub txtTdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTdate.ValueChanged
        'Sql = " AND AP_CV.DT_Work_now between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
    End Sub

    Private Sub DT_month_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_Month.ValueChanged
        'Sql = " and  month(AP_CV.DT_Work_now ) ='" & Month(DT_month.Value) & "' and year(AP_CV.DT_Work_now ) ='" & Year(DT_month.Value) & "' "
    End Sub


    Private Sub DT_year_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_year.ValueChanged
        'Sql = " and    year(AP_CV.DT_Work_now) ='" & Year(DT_year.Value) & "' "
    End Sub


    Private Sub Chk_year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_year.CheckedChanged
        If Chk_year.Checked = True Then
            DT_year.Enabled = True
            'Sql = " and    year(AP_CV.DT_Work_now) ='" & Year(DT_year.Value) & "' "
        Else
            DT_year.Enabled = False
            Sql = ""
        End If
    End Sub

    Private Sub chk_job_lut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_job_lut.CheckedChanged
        If chk_job_lut.Checked = True Then
            cmb_job_lut.Enabled = True
            cmb_job_lut.Items.Clear()
            Call load_Cmb("select In_nm from Type_In", "In_nm", cmb_job_lut)

            cmb_job_lut.SelectedIndex = 0
            cmb_job_lut.Enabled = True
            shr_job_lut = " AND AP_CV.type_in_id = N'" & txt_job_lut_id.Text & "' "
        Else
            cmb_job_lut.Items.Clear()
            cmb_job_lut.Text = ""
            shr_job_lut = ""
            cmb_job_lut.Enabled = False
        End If
    End Sub

    Private Sub cmb_job_lut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_lut.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Type_In Where  In_nm=N'" & Trim(cmb_job_lut.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_lut_id.Text = Trim(RSC("In_ID").Value)
            shr_job_lut = " AND AP_CV.type_in_id = N'" & txt_job_lut_id.Text & "' "
        End If

    End Sub

    Private Sub chk_percen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_percen.CheckedChanged
        If chk_percen.Checked = True Then
            cmb_percen.Enabled = True
            cmb_percen.SelectedIndex = 0
            Shr_persen = ""
            Shr_persen = " AND AP_CV.percen = N'" & cmb_percen.Text & "' "
        Else
            cmb_percen.Enabled = False
            cmb_percen.Text = ""
            Shr_persen = ""

        End If
    End Sub

    Private Sub cmb_percen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_percen.SelectedIndexChanged
        Shr_persen = " AND AP_CV.percen = N'" & cmb_percen.Text & "' "
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        txtpart.Text = FolderBrowserDialog1.SelectedPath
        'txtnm.Text = FolderBrowserDialog1.SafeFileName

        Dim aa As String
        Dim Rslaw As New ADODB.Recordset
        If RadioButton1.Checked = True Then

        ElseIf RadioButton2.Checked = True Then
            'ສັງລວມພາຍໃນສູນກາງ
            sum_cnter()
            Call LoadRs("SELECT * FROM Sumary_salary_in  ", Rslaw)
            Try
                With RSC


                    aa = "SELECT     Department.DP_Name, Sumary_salary_in.QTY_Per, Sumary_salary_in.Salary_basic, Sumary_salary_in.Tum_money, Sumary_salary_in.normal_Time, Sumary_salary_in.over_Time, " & _
                   "   Sumary_salary_in.normal_Money, Sumary_salary_in.over_Money, Sumary_salary_in.add_money, Sumary_salary_in.Sum_salary, Sumary_salary_in.Employee, Sumary_salary_in.Employeer,  " & _
                  "  Sumary_salary_in.tax, Sumary_salary_in.money_after_tax, Sumary_salary_in.cut_after_tax, Sumary_salary_in.Net_money " & _
                 "    FROM         Sumary_salary_in INNER JOIN " & _
                  "    Department ON Sumary_salary_in.DP_ID = Department.DP_ID   order by Sumary_salary_in.DP_ID    "
                    Call LoadRs(aa, RSC)
                    If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
                    'Make Connection ' Ammar
                    Dim cnn As New SqlConnection
                    ' Variable ' Ammar
                    Dim i, j As Integer
                    'Excel WorkBook object ' Ammar
                    Dim xlApp As Microsoft.Office.Interop.Excel.Application
                    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                    Dim misValue As Object = System.Reflection.Missing.Value
                    xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    ' Sheet Name or Number ' Ammar
                    xlWorkSheet = xlWorkBook.Sheets("sheet1")
                    ' Sql QUery ' Ammar
                    '  xlWorkBook.Sheets.Select("A1:A2")

                    'Dim sql As String = "SELECT * FROM Employee"
                    ' SqlAdapter
                    Dim dscmd As New SqlDataAdapter(aa, cnn)
                    '' DataSet
                    Dim ds As New DataSet
                    With cnn
                        If .State = ConnectionState.Open Then .Close()
                        .ConnectionString = "Data Source=" & MDServerName & ";Initial Catalog=" & MDDatabaName & ";User ID= " & MDServerUser & ";Password=" & MDServerPassword & ";"
                        '          .ConnectionString = "Provider = SQLOLEDB.1; Password = " & MDServerPassword & "; Persist Security Info = True; " & _
                        '"User ID = " & MDServerUser & "; Initial Catalog = " & MDDatabaName & "; Data Source =" & MDServerName & ""
                        .Open()
                    End With

                    dscmd.Fill(ds)

                    'COLUMN NAME ADD IN EXCEL SHEET OR HEADING 
                    xlWorkSheet.Cells(1, 1).Value = "ພະແນກ/ພາກສ່ວນ    "
                    xlWorkSheet.Cells(1, 2).Value = "ຈຳນວນພົນ "
                    xlWorkSheet.Cells(1, 3).Value = "ລະດັບເງິນເດືອນພື້ຖານນລວມ      "
                    xlWorkSheet.Cells(1, 4).Value = "ເງິນອຸດໜູນຕຳແໜ່ງ "
                    xlWorkSheet.Cells(1, 5).Value = "ຊົວໂມງປົກກະຕິ"
                    xlWorkSheet.Cells(1, 6).Value = "ຊົວໂມງເກີນ  "
                    xlWorkSheet.Cells(1, 7).Value = "ຄິດເປັນເງິນປົກກະຕິ"
                    xlWorkSheet.Cells(1, 8).Value = "ຄິດເປັນເງິນເກີນ "
                    xlWorkSheet.Cells(1, 9).Value = "ເງີນອຸດໜູນເພີ່ມ"
                    xlWorkSheet.Cells(1, 10).Value = "ລວມເງິນທັງໝົດ"
                    xlWorkSheet.Cells(1, 11).Value = "ບຸກຄົນ 4.5% "
                    xlWorkSheet.Cells(1, 12).Value = "ບໍລິສັດ 5% "
                    xlWorkSheet.Cells(1, 13).Value = "ຈຳນວນເງິນທີ່ເສຍອາກອນ"
                    xlWorkSheet.Cells(1, 14).Value = "ລາຍຮັບຫຼັງປະກັນສັງຄົມ ແລະ ອາກອນ "
                    xlWorkSheet.Cells(1, 15).Value = "ຫັກເງິນຢືມ ແລະ ເຂົ້າຄັງສົງເຄາະ"
                    xlWorkSheet.Cells(1, 16).Value = "ຈຳນວນເບິກຈ່າຍຕົວຈິງ"




                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        'Column
                        'xlApp = New Excel.ApplicationClass
                        'xlWorkBook = xlApp.Workbooks.Add(misValue)
                        'xlWorkSheet = xlWorkBook.Sheets("Prov_NmL")
                        'xlWorkSheet.Cells(i, 1).Value = ds.Fill("Prov_NmL")
                        'xlWorkSheet.Cells(i + 3, j + 1) = _
                        '  ds.Tables(0).Rows(i).Item(j)
                        'xlWorkSheet.Cells(i, 1).Value = RSC.Fields("Prov_NmL").Value
                        'xlWorkSheet.Cells.Item(i, 2).Value = RSC.Fields("Represendtative1").Value
                        For j = 0 To ds.Tables(0).Columns.Count - 1
                            ' this i change to header line cells >>>
                            xlWorkSheet.Cells(i + 3, j + 1) = _
                            ds.Tables(0).Rows(i).Item(j)
                            'MsgBox(xlWorkSheet.Cells(i + 3, j + 1) = ds.Tables(0).Rows(i).Item(j))
                        Next
                    Next
                    'HardCode in Excel sheet
                    ' this i change to footer line cells  >>>
                    'xlWorkSheet.Cells(i + 3, 1) = "Total"
                    'xlWorkSheet.Cells(i + 3, 2) = "=SUM(B2:B18)"
                    ''xlWorkSheet.Cells(i + 3, 3) = "=SUM(C2:C18)"
                    'xlWorkSheet.Cells(i + 3, 4) = "=SUM(D2:D18)"
                    'xlWorkSheet.Cells.Item(i + 3, 5) = "=SUM(C2:C18)"
                    ' Save as path of excel sheet
                    'mStrFTP = mStrFTP & "/" & Trim(txtpic1_nm.Text)
                    xlWorkSheet.SaveAs("" & Trim(txtpart.Text) & "\ໃບສັງລວມພາຍໃນສູນກາງ.xlsx")
                    xlWorkBook.Close()
                    xlApp.Quit()
                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkSheet)
                    'Msg Box of Excel Sheet Path
                    MsgBox("Export Complete")
                End With
                If RSC.State = ConnectionState.Open Then RSC.Close()
            Catch ex As Exception
                'MessageBox.Show(ex.Message)

            End Try


        ElseIf RadioButton4.Checked = True Then
            'ສັງລວມສາຂາພາຍໃນ
            sum_sakha()
            Call LoadRs("SELECT * FROM Sumary_salary_in  ", Rslaw)

            Try
                With RSC


                    aa = "SELECT     Department.DP_Name, Sumary_salary_in.QTY_Per, Sumary_salary_in.Salary_basic, Sumary_salary_in.Tum_money, Sumary_salary_in.normal_Time, Sumary_salary_in.over_Time, " & _
                   "   Sumary_salary_in.normal_Money, Sumary_salary_in.over_Money, Sumary_salary_in.add_money, Sumary_salary_in.Sum_salary, Sumary_salary_in.Employee, Sumary_salary_in.Employeer,  " & _
                  "  Sumary_salary_in.tax, Sumary_salary_in.money_after_tax, Sumary_salary_in.cut_after_tax, Sumary_salary_in.Net_money " & _
                 "    FROM         Sumary_salary_in INNER JOIN " & _
                  "    Department ON Sumary_salary_in.DP_ID = Department.DP_ID   order by Sumary_salary_in.DP_ID    "
                    Call LoadRs(aa, RSC)
                    If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
                    'Make Connection ' Ammar
                    Dim cnn As New SqlConnection
                    ' Variable ' Ammar
                    Dim i, j As Integer
                    'Excel WorkBook object ' Ammar
                    Dim xlApp As Microsoft.Office.Interop.Excel.Application
                    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                    Dim misValue As Object = System.Reflection.Missing.Value
                    xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    ' Sheet Name or Number ' Ammar
                    xlWorkSheet = xlWorkBook.Sheets("sheet1")
                    ' Sql QUery ' Ammar
                    '  xlWorkBook.Sheets.Select("A1:A2")

                    'Dim sql As String = "SELECT * FROM Employee"
                    ' SqlAdapter
                    Dim dscmd As New SqlDataAdapter(aa, cnn)
                    '' DataSet
                    Dim ds As New DataSet
                    With cnn
                        If .State = ConnectionState.Open Then .Close()
                        .ConnectionString = "Data Source=" & MDServerName & ";Initial Catalog=" & MDDatabaName & ";User ID= " & MDServerUser & ";Password=" & MDServerPassword & ";"
                        '          .ConnectionString = "Provider = SQLOLEDB.1; Password = " & MDServerPassword & "; Persist Security Info = True; " & _
                        '"User ID = " & MDServerUser & "; Initial Catalog = " & MDDatabaName & "; Data Source =" & MDServerName & ""
                        .Open()
                    End With

                    dscmd.Fill(ds)

                    'COLUMN NAME ADD IN EXCEL SHEET OR HEADING 
                    xlWorkSheet.Cells(1, 1).Value = "ພະແນກ/ພາກສ່ວນ    "
                    xlWorkSheet.Cells(1, 2).Value = "ຈຳນວນພົນ "
                    xlWorkSheet.Cells(1, 3).Value = "ລະດັບເງິນເດືອນພື້ຖານນລວມ      "
                    xlWorkSheet.Cells(1, 4).Value = "ເງິນອຸດໜູນຕຳແໜ່ງ "
                    xlWorkSheet.Cells(1, 5).Value = "ຊົວໂມງປົກກະຕິ"
                    xlWorkSheet.Cells(1, 6).Value = "ຊົວໂມງເກີນ  "
                    xlWorkSheet.Cells(1, 7).Value = "ຄິດເປັນເງິນປົກກະຕິ"
                    xlWorkSheet.Cells(1, 8).Value = "ຄິດເປັນເງິນເກີນ "
                    xlWorkSheet.Cells(1, 9).Value = "ເງີນອຸດໜູນເພີ່ມ"
                    xlWorkSheet.Cells(1, 10).Value = "ລວມເງິນທັງໝົດ"
                    xlWorkSheet.Cells(1, 11).Value = "ບຸກຄົນ 4.5% "
                    xlWorkSheet.Cells(1, 12).Value = "ບໍລິສັດ 5% "
                    xlWorkSheet.Cells(1, 13).Value = "ຈຳນວນເງິນທີ່ເສຍອາກອນ"
                    xlWorkSheet.Cells(1, 14).Value = "ລາຍຮັບຫຼັງປະກັນສັງຄົມ ແລະ ອາກອນ "
                    xlWorkSheet.Cells(1, 15).Value = "ຫັກເງິນຢືມ ແລະ ເຂົ້າຄັງສົງເຄາະ"
                    xlWorkSheet.Cells(1, 16).Value = "ຈຳນວນເບິກຈ່າຍຕົວຈິງ"

                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        'Column
                        'xlApp = New Excel.ApplicationClass
                        'xlWorkBook = xlApp.Workbooks.Add(misValue)
                        'xlWorkSheet = xlWorkBook.Sheets("Prov_NmL")
                        'xlWorkSheet.Cells(i, 1).Value = ds.Fill("Prov_NmL")
                        'xlWorkSheet.Cells(i + 3, j + 1) = _
                        '  ds.Tables(0).Rows(i).Item(j)
                        'xlWorkSheet.Cells(i, 1).Value = RSC.Fields("Prov_NmL").Value
                        'xlWorkSheet.Cells.Item(i, 2).Value = RSC.Fields("Represendtative1").Value
                        For j = 0 To ds.Tables(0).Columns.Count - 1
                            ' this i change to header line cells >>>
                            xlWorkSheet.Cells(i + 3, j + 1) = _
                            ds.Tables(0).Rows(i).Item(j)
                            'MsgBox(xlWorkSheet.Cells(i + 3, j + 1) = ds.Tables(0).Rows(i).Item(j))
                        Next
                    Next
                    'HardCode in Excel sheet
                    ' this i change to footer line cells  >>>
                    'xlWorkSheet.Cells(i + 3, 1) = "Total"
                    'xlWorkSheet.Cells(i + 3, 2) = "=SUM(B2:B18)"
                    ''xlWorkSheet.Cells(i + 3, 3) = "=SUM(C2:C18)"
                    'xlWorkSheet.Cells(i + 3, 4) = "=SUM(D2:D18)"
                    'xlWorkSheet.Cells.Item(i + 3, 5) = "=SUM(C2:C18)"
                    ' Save as path of excel sheet
                    'mStrFTP = mStrFTP & "/" & Trim(txtpic1_nm.Text)
                    xlWorkSheet.SaveAs("" & Trim(txtpart.Text) & "\ໃບສັງລວມສາຂາພາຍໃນ.xlsx")
                    xlWorkBook.Close()
                    xlApp.Quit()
                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkSheet)
                    'Msg Box of Excel Sheet Path
                    MsgBox("Export Complete")
                End With
                If RSC.State = ConnectionState.Open Then RSC.Close()
            Catch ex As Exception
                'MessageBox.Show(ex.Message)

            End Try


        Else

            'ສັງລວມສາຂາຕ່າງປະເທດ
            sum_sakha_EX()
            Call LoadRs("SELECT * FROM Sumary_salary_EX  ", Rslaw)
            Try
                With RSC


                    aa = "SELECT     Department.DP_Name, Sumary_salary_EX.QTY_Per, Sumary_salary_EX.Salary_basic, Sumary_salary_EX.Salary_basic_kip, Sumary_salary_EX.normal_Time, Sumary_salary_EX.over_Time, " & _
                  "    Sumary_salary_EX.normal_Money, Sumary_salary_EX.over_Money, Sumary_salary_EX.Sum_salary, Sumary_salary_EX.add_money, Sumary_salary_EX.cut_money,  " & _
                   "   Sumary_salary_EX.total_money, Sumary_salary_EX.Employee, Sumary_salary_EX.Employeer, Sumary_salary_EX.Summoney_in_tax, Sumary_salary_EX.tax,  " & _
                 "   Sumary_salary_EX.money_after_tax, Sumary_salary_EX.cut_after_tax, Sumary_salary_EX.Net_money_kip " & _
            "   FROM         Sumary_salary_EX INNER JOIN " & _
                  "    Department ON Sumary_salary_EX.DP_ID = Department.DP_ID   order by Sumary_salary_EX.DP_ID    "
                    Call LoadRs(aa, RSC)
                    If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
                    'Make Connection ' Ammar
                    Dim cnn As New SqlConnection
                    ' Variable ' Ammar
                    Dim i, j As Integer
                    'Excel WorkBook object ' Ammar
                    Dim xlApp As Microsoft.Office.Interop.Excel.Application
                    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                    Dim misValue As Object = System.Reflection.Missing.Value
                    xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    ' Sheet Name or Number ' Ammar
                    xlWorkSheet = xlWorkBook.Sheets("sheet1")
                    ' Sql QUery ' Ammar
                    '  xlWorkBook.Sheets.Select("A1:A2")

                    'Dim sql As String = "SELECT * FROM Employee"
                    ' SqlAdapter
                    Dim dscmd As New SqlDataAdapter(aa, cnn)
                    '' DataSet
                    Dim ds As New DataSet
                    With cnn
                        If .State = ConnectionState.Open Then .Close()
                        .ConnectionString = "Data Source=" & MDServerName & ";Initial Catalog=" & MDDatabaName & ";User ID= " & MDServerUser & ";Password=" & MDServerPassword & ";"
                        '          .ConnectionString = "Provider = SQLOLEDB.1; Password = " & MDServerPassword & "; Persist Security Info = True; " & _
                        '"User ID = " & MDServerUser & "; Initial Catalog = " & MDDatabaName & "; Data Source =" & MDServerName & ""
                        .Open()
                    End With

                    dscmd.Fill(ds)

                    'COLUMN NAME ADD IN EXCEL SHEET OR HEADING 
                    xlWorkSheet.Cells(1, 1).Value = "ພະແນກ/ພາກສ່ວນ    "
                    xlWorkSheet.Cells(1, 2).Value = "ຈຳນວນພົນ "
                    xlWorkSheet.Cells(1, 3).Value = "ອັດຕາຕ່າງປະເທດ"
                    xlWorkSheet.Cells(1, 4).Value = "ໄລ່ເປັນກິບ"
                    xlWorkSheet.Cells(1, 5).Value = "ຊົວໂມງປົກກະຕິ"
                    xlWorkSheet.Cells(1, 6).Value = "ຊົວໂມງເກີນ  "
                    xlWorkSheet.Cells(1, 7).Value = "ຄິດເປັນເງິນປົກກະຕິ"
                    xlWorkSheet.Cells(1, 8).Value = "ຄິດເປັນເງິນເກີນ "
                    xlWorkSheet.Cells(1, 9).Value = "ລວມເງິນແຮງງານ"
                    xlWorkSheet.Cells(1, 10).Value = "ເງິນດັດແກ້ເພີ່ມ"
                    xlWorkSheet.Cells(1, 11).Value = "ເງິນດັດແກ້ຫັກ"
                    xlWorkSheet.Cells(1, 12).Value = "ລວມເງິນທັງໝົດ"
                    xlWorkSheet.Cells(1, 13).Value = "ບຸກຄົນ 4.5% "
                    xlWorkSheet.Cells(1, 14).Value = "ບໍລິສັດ 5% "
                    xlWorkSheet.Cells(1, 15).Value = "ຈຳນວນເງິນຖຶກອາກອນ"
                    xlWorkSheet.Cells(1, 16).Value = "ຈຳນວນເງິນທີ່ເສຍອາກອນ"
                    xlWorkSheet.Cells(1, 17).Value = "ລາຍຮັບຫຼັງປະກັນສັງຄົມ ແລະ ອາກອນ "
                    xlWorkSheet.Cells(1, 18).Value = "ຫັກເງິນຢືມລ່ວງໜ້າ"
                    xlWorkSheet.Cells(1, 19).Value = "ຈຳນວນເບິກຈ່າຍຕົວຈິງ"

                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        'Column
                        'xlApp = New Excel.ApplicationClass
                        'xlWorkBook = xlApp.Workbooks.Add(misValue)
                        'xlWorkSheet = xlWorkBook.Sheets("Prov_NmL")
                        'xlWorkSheet.Cells(i, 1).Value = ds.Fill("Prov_NmL")
                        'xlWorkSheet.Cells(i + 3, j + 1) = _
                        '  ds.Tables(0).Rows(i).Item(j)
                        'xlWorkSheet.Cells(i, 1).Value = RSC.Fields("Prov_NmL").Value
                        'xlWorkSheet.Cells.Item(i, 2).Value = RSC.Fields("Represendtative1").Value
                        For j = 0 To ds.Tables(0).Columns.Count - 1
                            ' this i change to header line cells >>>
                            xlWorkSheet.Cells(i + 3, j + 1) = _
                            ds.Tables(0).Rows(i).Item(j)
                            'MsgBox(xlWorkSheet.Cells(i + 3, j + 1) = ds.Tables(0).Rows(i).Item(j))
                        Next
                    Next
                    'HardCode in Excel sheet
                    ' this i change to footer line cells  >>>
                    'xlWorkSheet.Cells(i + 3, 1) = "Total"
                    'xlWorkSheet.Cells(i + 3, 2) = "=SUM(B2:B18)"
                    ''xlWorkSheet.Cells(i + 3, 3) = "=SUM(C2:C18)"
                    'xlWorkSheet.Cells(i + 3, 4) = "=SUM(D2:D18)"
                    'xlWorkSheet.Cells.Item(i + 3, 5) = "=SUM(C2:C18)"
                    ' Save as path of excel sheet
                    'mStrFTP = mStrFTP & "/" & Trim(txtpic1_nm.Text)
                    xlWorkSheet.SaveAs("" & Trim(txtpart.Text) & "\ໃບສັງລວມສາຂາຕ່າງປະເທດ.xlsx")
                    xlWorkBook.Close()
                    xlApp.Quit()
                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkSheet)
                    'Msg Box of Excel Sheet Path
                    MsgBox("Export Complete")
                End With
                If RSC.State = ConnectionState.Open Then RSC.Close()
            Catch ex As Exception
                'MessageBox.Show(ex.Message)

            End Try

        End If
     




    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class