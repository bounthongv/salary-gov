Public Class Frm_Salary_Up_Report
    Dim Sql As String
    Private Sub Frm_Salary_Up_Report_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = ""
        shr_Class_vel = ""
        shr_Department = ""
        shr_section = ""
        shr_phuk = ""
        shr_job_lut = ""
        Shr_persen = ""
        shr_type_in = ""
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
            Call load_Cmb("select DP_Name from Department", "DP_Name", cmb_Department)
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
            Call load_Cmb("select phuk_id,Phuk_nm from Phuk", "Phuk_nm", cmb_job_phuk)
            cmb_job_phuk.SelectedIndex = 0
            shr_job_phuk = " AND AP_CV.job_phuk_ID = N'" & txt_job_phuk_id.Text & "' "

        Else
            cmb_job_phuk.Enabled = False
            cmb_job_phuk.Items.Clear()
            cmb_job_phuk.Text = ""
            shr_job_phuk = ""
        End If
    End Sub

    Private Sub cmb_job_phuk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_phuk.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Phuk Where  Phuk_nm=N'" & Trim(cmb_job_phuk.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_phuk_id.Text = Trim(RSC("phuk_id").Value)
            shr_job_phuk = " AND AP_CV.job_phuk_ID = N'" & txt_job_phuk_id.Text & "' "
        End If
    End Sub

    Private Sub cmbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclass.SelectedIndexChanged
        txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text
        shr_Class_vel = " AND AP_Up_Personal.txtV_C = N'" & txtV_C.Text & "' "
    End Sub

    Private Sub cmblevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblevel.SelectedIndexChanged
        txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text
        shr_Class_vel = " AND AP_Up_Personal.txtV_C = N'" & txtV_C.Text & "' "
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
            shr_Class_vel = " AND AP_Up_Personal.txtV_C = N'" & txtV_C.Text & "' "
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim RSC As New ADODB.Recordset
        Dim aa As String
        With RSC
            aa = "SELECT     AP_CV.E_ID, AP_CV.Sections_id, AP_CV.Sections, AP_CV.Department_id, AP_CV.Department, AP_CV.type_in_id, AP_CV.type_in_nm, AP_CV.Name_L, AP_CV.Name_E, " & _
                "      AP_CV.Phone, AP_CV.Bank_no, AP_CV.SSO_no, AP_CV.DT_strt_work, AP_CV.start_work_ID, AP_CV.start_work, AP_CV.DT_Work_now, AP_CV.job_lut_ID, AP_CV.job_lut,  " & _
                  "    AP_CV.Add_Vill_ID, AP_Village.Vl_nm, AP_District.Dt_id, AP_District.Dt_nm, AP_Province.PV_ID, AP_Province.PV_nm, AP_Up_Personal.txtclass_old,  " & _
                 "     AP_Up_Personal.txtlevel_old, AP_Up_Personal.txtclass, AP_Up_Personal.txtlevel, AP_Up_Personal.txtV_C, AP_Up_Personal.DT_Up,  " & _
     "       AP_Up_Personal.txtkhor_tok_long, AP_Up_Personal.txtAccount_clss_level, AP_Up_Personal.type_up_id, AP_Up_Personal.type_up, AP_Up_Personal.percen, AP_Up_Personal.remark " & _
           "   FROM         AP_CV INNER JOIN " & _
               "       AP_Village ON AP_CV.Add_Vill_ID = AP_Village.Vl_ID INNER JOIN " & _
                 "     AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
                   "   AP_Province ON AP_District.PV_id = AP_Province.PV_ID INNER JOIN " & _
                   "   AP_Up_Personal ON AP_CV.E_ID = AP_Up_Personal.E_ID CROSS JOIN " & _
                    "  AP_Office  WHERE 1=1  " & Sql & " " & shr_type_in & " " & shr_Class_vel & " " & shr_Department & " " & shr_section & " " & shr_phuk & " " & shr_job_lut & "" & Shr_persen & "  order by AP_CV.cmbclass desc "
            Call LoadRs(aa, RSC)
            If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
            Dim Frm As New FrmPreview
            Dim Rpt As New Report_Salary_Up
            'Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
            'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'myTextObjectOnReport.Text = "(ຂອງ " & Location_nm & ")"

            'If Chk_Dt.Checked = True Then
            '    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T1"), CrystalDecisions.CrystalReports.Engine.TextObject)
            '    myTextObjectOnReport.Text = txtFdate.Value & " ຫາ " & txtTdate.Value

            'ElseIf Chk_Month.Checked = True Then
            '    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T1"), CrystalDecisions.CrystalReports.Engine.TextObject)
            '    myTextObjectOnReport.Text = "ປະຈຳເດືອນ " & DT_month.Value.Month & "/" & DT_year.Value.Year
            'Else
            '    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T1"), CrystalDecisions.CrystalReports.Engine.TextObject)
            '    myTextObjectOnReport.Text = "ປະຈຳປີ " & DT_year.Value.Year
            'End If


            'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T2"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'myTextObjectOnReport.Text = txtTdate.Value

            Rpt.SetDataSource(RSC)
            Rpt.Refresh()
            Frm.ReportViewer.ReportSource = Rpt
            Frm.ReportViewer.Zoom(100%)
            Frm.ReportViewer.DisplayGroupTree = False
            Frm.WindowState = FormWindowState.Maximized
            Frm.Show()
        End With
    End Sub

    Private Sub Chk_Dt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Dt.CheckedChanged
        If Chk_Dt.Checked = True Then
            txtFdate.Enabled = True
            txtTdate.Enabled = True
            Sql = " AND AP_Up_Personal.DT_Up between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"

        Else
            txtFdate.Enabled = False
            txtTdate.Enabled = False
            Sql = ""

        End If
    End Sub

    Private Sub txtFdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFdate.ValueChanged
        Sql = " AND   AP_Up_Personal.DT_Up between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
    End Sub

    Private Sub txtTdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTdate.ValueChanged
        Sql = " AND AND AP_Up_Personal.DT_Up '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
    End Sub

    Private Sub DT_month_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_month.ValueChanged
        Sql = " and  month(AND AP_Up_Personal.DT_Up) ='" & Month(DT_month.Value) & "' and year(AND AP_Up_Personal.DT_Up) ='" & Year(DT_month.Value) & "' "
    End Sub


    Private Sub DT_year_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_year.ValueChanged
        Sql = " and    year(AP_Up_Personal.DT_Up) ='" & Year(DT_year.Value) & "' "
    End Sub

    Private Sub Chk_Month_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Month.CheckedChanged
        If Chk_Dt.Checked = True Then
            DT_month.Enabled = True
            Sql = " and  month(AP_Up_Personal.DT_Up) ='" & Month(DT_month.Value) & "' and year(AP_Up_Personal.DT_dn) ='" & Year(DT_month.Value) & "' "
        Else
            DT_month.Enabled = False
            Sql = ""
        End If
    End Sub

    Private Sub Chk_year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_year.CheckedChanged
        If Chk_year.Checked = True Then
            DT_year.Enabled = True
            Sql = " and    year(AP_Up_Personal.DT_Up) ='" & Year(DT_year.Value) & "' "
        Else
            DT_year.Enabled = False
            Sql = ""
        End If
    End Sub

    Private Sub chk_job_lut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_job_lut.CheckedChanged
        If chk_job_lut.Checked = True Then
            cmb_job_lut.Enabled = True
            cmb_job_lut.Items.Clear()
            Call load_Cmb("select lut_id,lut_nm from lut", "lut_nm", cmb_job_lut)
            cmb_job_lut.SelectedIndex = 0
            cmb_job_lut.Enabled = True
            shr_job_lut = " AND AP_CV.job_lut_ID = N'" & txt_job_lut_id.Text & "' "
        Else
            cmb_job_lut.Items.Clear()
            cmb_job_lut.Text = ""
            shr_job_lut = ""
            cmb_job_lut.Enabled = False
        End If
    End Sub

    Private Sub cmb_job_lut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_lut.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From lut Where  lut_nm=N'" & Trim(cmb_job_lut.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_lut_id.Text = Trim(RSC("lut_id").Value)
            shr_job_lut = " AND AP_CV.job_lut_ID = N'" & txt_job_lut_id.Text & "' "
        End If
    End Sub

    Private Sub chk_percen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_percen.CheckedChanged
        If chk_percen.Checked = True Then
            cmb_percen.Enabled = True
            cmb_percen.SelectedIndex = 0
            Shr_persen = ""
            Shr_persen = " AND AP_Up_Personal.percen = N'" & cmb_percen.Text & "' "
        Else
            cmb_percen.Text = ""
            cmb_percen.Enabled = False

            Shr_persen = ""

        End If
    End Sub

    Private Sub cmb_percen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_percen.SelectedIndexChanged
        Shr_persen = " AND AP_Up_Personal.percen = N'" & cmb_percen.Text & "' "
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub chk_up_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_dn.CheckedChanged
        If chk_dn.Checked = True Then
            cmb_type_up.Enabled = True
            Call load_Cmb("select up_nm from Type_up", "up_nm", cmb_type_up)
            cmb_type_up.SelectedIndex = 0
            shr_type_in = " AND AP_Up_Personal.type_up_id = N'" & txtup_id.Text & "' "
        Else
            cmb_type_up.Enabled = False
            cmb_type_up.Text = ""
            shr_type_in = ""
        End If
    End Sub

    Private Sub cmb_type_up_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type_up.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Type_up Where up_nm=N'" & Trim(cmb_type_up.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtup_id.Text = Trim(RSC("up_id").Value)
            shr_type_in = " AND AP_Up_Personal.type_up_id = N'" & txtup_id.Text & "' "

        End If
    End Sub
End Class