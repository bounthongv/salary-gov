Public Class Frm_persion_list_Report
    Dim Sql As String

    Private Sub Frm_persion_list_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = ""

        shr_Class_vel = ""
        shr_Department = ""
        shr_section = ""
        shr_phuk = ""
        shr_job_lut = ""
        Shr_persen = ""

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sa As String
        With RSC

            '          sa = "SELECT   AP_CV.e_id,AP_CV.Name_L,AP_CV.Sections,AP_CV.Department,AP_CV.job_lut_ID,AP_CV.job_lut,AP_CV.DT_strt_work,AP_CV.start_work, " & _
            '       "   AP_CV.DT_Work_now, AP_CV.txtV_C, AP_Village.Vl_nm, AP_District.Dt_id, AP_District.Dt_nm, AP_Province.PV_ID, AP_Province.PV_nm " & _
            '    "     FROM         AP_CV INNER JOIN    " & _
            '"   AP_Village ON AP_CV.Add_Vill_ID = AP_Village.Vl_ID INNER JOIN   " & _
            ' "    AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN  " & _
            '   "    AP_Province ON AP_District.PV_id = AP_Province.PV_ID  LEFT OUTER JOIN  " & _
            '  "          AP_Persion_Study ON AP_CV.E_ID = AP_Persion_Study.E_Id  where 1=1  " & _
            '  "  " & Sql & " " & shr_section & " " & shr_Department & " " & shr_job_phuk & "" & shr_type_in & " " & Shr_persen & " " & shr_Class_vel & "" & _
            ' " " & shr_year_phuksumhong & "" & shr_year_phuk & " " & shr_year_lut & "" & shr_year_DOB & " " & shr_lang & " " & shr_study & " " & shr_visa & " " & shr_Nation & " " & _
            ' "group by  AP_CV.e_id,AP_CV.Name_L,AP_CV.Sections,AP_CV.Department,AP_CV.job_lut_ID,AP_CV.job_lut, AP_CV.DT_strt_work,AP_CV.start_work, AP_CV.DT_Work_now, AP_CV.txtV_C, " & _
            '  "      AP_Village.Vl_nm, AP_District.Dt_id, AP_District.Dt_nm, AP_Province.PV_ID, AP_Province.PV_nm  ORDER BY  AP_CV.txtV_C  desc "


            sa = "SELECT     AP_CV.E_ID, AP_CV.*, AP_Village.Vl_nm, AP_District.Dt_id, " & _
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
                             "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id   where 1=1  " & _
                        "  " & Sql & " " & shr_section & " " & shr_Department & " " & shr_job_phuk & "" & shr_type_in & " " & Shr_persen & " " & shr_Class_vel & "" & _
             " " & shr_year_phuksumhong & "" & shr_year_phuk & " " & shr_year_lut & "" & shr_year_DOB & " " & shr_lang & " " & shr_study & " " & shr_visa & " " & shr_Nation & " ORDER BY   AP_CV.order_no  "






            Call LoadRs(sa, RSC)
            If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
            Dim Frm As New FrmPreview
            Dim Rpt As New Report_Persion_list2
            'Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
            'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'myTextObjectOnReport.Text = FrmAPInvioce.Label1.Text


            'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T1"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'myTextObjectOnReport.Text = txtFdate.Value


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
 
    Private Sub txtFdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFdate.ValueChanged
        Sql = " AND AP_CV.DT_Work_now between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
    End Sub

    Private Sub txtTdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTdate.ValueChanged
        Sql = " AND AP_CV.DT_Work_now between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
    End Sub

    Private Sub DT_month_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_year_phuk.ValueChanged
        If chk_year_phuk.Checked = True Then
            shr_year_phuk = " and    year(AP_CV.Dt_Phuk) ='" & Year(DT_year_phuk.Value) & "' "
        Else
            shr_year_phuk = ""

        End If
    End Sub


    Private Sub DT_year_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT__study_finish.ValueChanged

        If chk_study_finish.Checked = True Then
            shr_year_Study = " and    year(AP_CV.Dt_lut) ='" & Year(DT_DOB.Value) & "' "
        Else
            shr_year_Study = ""

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

    Private Sub chk_start_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_start.CheckedChanged
        If chk_start.Checked = True Then
            txtFdate.Enabled = True
            txtTdate.Enabled = True
            Sql = " AND AP_CV.DT_Work_now between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"

        Else
            txtFdate.Enabled = False
            txtTdate.Enabled = False
            Sql = ""

        End If
    End Sub

 
    Private Sub chk_study_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_study.CheckedChanged
        If chk_study.Checked = True Then

            cmb_study.Items.Clear()
            'cmb_duties2.Items.Add("ທັງໝົດ")
            Call load_Cmb("select E_nm from Education  ", "E_nm", cmb_study)
            cmb_study.SelectedIndex = 0
            shr_study = " AND AP_Persion_Study.txtstudy_id = N'" & txtstudy_id.Text & "' "

        Else
            cmb_study.Items.Clear()
            cmb_study.Text = ""
            shr_study = ""
        End If
    End Sub

    Private Sub cmb_study_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_study.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Education Where  E_nm=N'" & Trim(cmb_study.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtstudy_id.Text = Trim(RSC("E_id").Value)
            shr_study = " AND AP_Persion_Study.txtstudy_id = N'" & txtstudy_id.Text & "' "
        End If
    End Sub

    Private Sub chk_visa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_visa.CheckedChanged
        If chk_visa.Checked = True Then

            cmb_visa.Items.Clear()

            Call load_Cmb("select Field_Name from Study_Field   ", "Field_Name", cmb_visa)
            cmb_visa.SelectedIndex = 0
            shr_visa = " AND  AP_Persion_Study.txtvisa_id = N'" & txtvisa_id.Text & "' "

        Else
            cmb_visa.Items.Clear()
            cmb_visa.Text = ""
            shr_visa = ""
        End If
    End Sub

    Private Sub cmb_visa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_visa.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Study_Field Where  Field_Name=N'" & Trim(cmb_visa.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtvisa_id.Text = Trim(RSC("Field_ID").Value)
            shr_visa = " AND  AP_Persion_Study.txtvisa_id = N'" & txtvisa_id.Text & "' "
        End If
    End Sub

    Private Sub chk_Nation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Nation.CheckedChanged
        If chk_Nation.Checked = True Then
            cmb_Nation.Items.Clear()
            Call load_Cmb("select NationNmL from Nationall", "NationNmL", cmb_Nation)
            cmb_Nation.SelectedIndex = 0
            shr_Nation = " AND  AP_Persion_Study.txt_Nation_id = N'" & txt_Nation_id.Text & "' "
        Else
            cmb_Nation.Items.Clear()
            cmb_Nation.Text = ""
            shr_Nation = ""

        End If
    End Sub

    Private Sub cmb_Nation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Nation.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Nationall Where  NationNmL=N'" & Trim(cmb_Nation.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_Nation_id.Text = Trim(RSC("NationID").Value)
            shr_Nation = " AND  AP_Persion_Study.txt_Nation_id = N'" & txt_Nation_id.Text & "' "
        End If
    End Sub

    Private Sub chk_lang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_lang.CheckedChanged
        If chk_lang.Checked = True Then
            cmb_lang.Items.Clear()
            cmb_lang.Items.Add("ທັງໝົດ")
            Call load_Cmb("select NationNmL from Nationall where NationID>001 ", "NationNmL", cmb_lang)
            cmb_lang.SelectedIndex = 0
            shr_lang = " AND AP_CV.chk_lang =1"

        Else
            cmb_lang.Items.Clear()
            cmb_lang.Text = ""
            shr_lang = ""
        End If
    End Sub

    Private Sub cmb_lang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_lang.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Nationall Where  NationNmL=N'" & Trim(cmb_lang.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtlang_id.Text = Trim(RSC("NationID").Value)
        End If
        If cmb_lang.SelectedIndex = 0 Then
            shr_lang = " AND AP_CV.chk_lang =1"
        Else
            shr_lang = " AND AP_CV.lang_ID = N'" & txtlang_id.Text & "' "
        End If
    End Sub

    Private Sub chk_phuksumhong_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_phuksumhong.CheckedChanged
        If chk_phuksumhong.Checked = True Then
            shr_year_phuksumhong = " and    year(AP_CV.Dt_Phuk_sumhong) ='" & Year(DT_year_phuksumhong.Value) & "' "
        Else
            shr_year_phuksumhong = ""

        End If
    End Sub

    Private Sub DT_year_phuksumhong_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_year_phuksumhong.ValueChanged
        If chk_phuksumhong.Checked = True Then
            shr_year_phuksumhong = " and    year(AP_CV.Dt_Phuk_sumhong) ='" & Year(DT_year_phuksumhong.Value) & "' "
        Else
            shr_year_phuksumhong = ""

        End If
    End Sub

    
    Private Sub chk_year_phuk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_year_phuk.CheckedChanged
        If chk_year_phuk.Checked = True Then
            shr_year_phuk = " and    year(AP_CV.Dt_Phuk) ='" & Year(DT_year_phuk.Value) & "' "
        Else
            shr_year_phuk = ""

        End If
    End Sub

    Private Sub chk_lut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_lut.CheckedChanged
        If chk_lut.Checked = True Then
            shr_year_lut = " and    year(AP_CV.Dt_lut) ='" & Year(DT_year_phuk.Value) & "' "
        Else
            shr_year_lut = ""

        End If
    End Sub

    Private Sub DT_year_lut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_year_lut.ValueChanged
        If chk_lut.Checked = True Then
            shr_year_lut = " and    year(AP_CV.Dt_lut) ='" & Year(DT_year_lut.Value) & "' "
        Else
            shr_year_lut = ""

        End If
    End Sub

    Private Sub chk_DOB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DOB.CheckedChanged
        If chk_DOB.Checked = True Then
            shr_year_DOB = " and    year(AP_CV.DOB) ='" & Year(DT_DOB.Value) & "' "
        Else
            shr_year_DOB = ""

        End If
    End Sub

    Private Sub DT_DOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_DOB.ValueChanged
        If chk_DOB.Checked = True Then
            shr_year_DOB = " and    year(AP_CV.DOB) ='" & Year(DT_DOB.Value) & "' "
        Else
            shr_year_DOB = ""

        End If
    End Sub

    Private Sub chk_study_finish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_study_finish.CheckedChanged
        If chk_study_finish.Checked = True Then
            shr_year_Study = " and    year(AP_CV.DT_study) ='" & Year(DT_DOB.Value) & "' "
        Else
            shr_year_Study = ""

        End If
    End Sub
End Class