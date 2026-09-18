
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Frm_Salary_in_tax_Report
    Dim Sql As String
    Private Sub Frm_Salary_in_tax_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = ""
        shr_Class_vel = ""
        shr_Department = ""
        shr_section = ""
        shr_phuk = ""
        shr_job_lut = ""
        Shr_persen = ""
        'chk_department.Checked = True

        Chk_em_In.Checked = True
    End Sub

    Private Sub chk_section_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_section.CheckedChanged
        If chk_section.Checked = True Then
            Cmb_Sections.Enabled = True

            Cmb_Sections.Items.Clear()
            Call load_Cmb("select Sec_nmL from AP_Sections order by Group_Sec_id", "Sec_nmL", Cmb_Sections)
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Dim RSC As New ADODB.Recordset
        Dim aa As String
        '    aa = "update AP_Salary_in_Month set tax_level =1" & _
        '"   where  Tax_Level1>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        '    Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =1" & _
 "   where  Tax_Level2>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =2" & _
"   where  Tax_Level3>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =3" & _
"   where  Tax_Level4>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =4" & _
"   where  Tax_Level5>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =5" & _
"   where  Tax_Level6>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =6" & _
"   where  Tax_Level7>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        If Chk_em_In.Checked = True Then
            With RSC
                aa = "SELECT      AP_Salary_in_Month.*, AP_CV.Name_E,AP_CV.Bank_no,AP_CV.SSO_no,  " & _
             "   AP_CV.Phone,AP_CV.txtV_C, AP_Sections.Sec_nmL, AP_Sections.Sec_id,Department.DP_ID, Department.DP_Name ,  " & _
            "     Type_In.In_ID, Type_In.In_nm , job.job_nm  FROM        " & _
         "  AP_Salary_in_Month INNER JOIN       AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN  " & _
              "  AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN     " & _
               "    Department ON AP_CV.Department_id = Department.DP_ID INNER JOIN      " & _
                  "    Type_In ON AP_CV.type_in_id = Type_In.In_ID  INNER JOIN " & _
                    "      job ON AP_CV.duties_Id = job.job_id  WHERE 1=1  " & Sql & " " & shr_Class_vel & " " & shr_Department & " " & shr_section & " " & shr_job_phuk & " " & shr_job_lut & "" & Shr_persen & " " & _
        " and   month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' order by AP_CV.order_no   "
                Call LoadRs(aa, RSC)
                If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub

                Dim Frm As New FrmPreview
                'Dim Rpt As New Report_Salary_In_Month_in
                Dim Rpt As New Report_Salary_In_tax
                Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
                'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'myTextObjectOnReport.Text = "" & Cmb_Sections.Text & ""

                'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'myTextObjectOnReport.Text = (Format(DT_Month.Value, "MM/yyyy"))
                myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text6"), CrystalDecisions.CrystalReports.Engine.TextObject)
                myTextObjectOnReport.Text = "" & Cmb_Sections.Text & ""


                myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text30"), CrystalDecisions.CrystalReports.Engine.TextObject)
                myTextObjectOnReport.Text = "ເດືອນ " & (Format(DT_Month.Value, "MM/yyyy"))


                'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text30"), CrystalDecisions.CrystalReports.Engine.TextObject)
                'myTextObjectOnReport.Text = "ສະເພາະ " & Cmb_Sections.Text & " ປະຈຳເດືອນ " & (Format(DT_Month.Value, "MM/yyyy"))

                Rpt.SetDataSource(RSC)
                Rpt.Refresh()
                Frm.ReportViewer.ReportSource = Rpt
                Frm.ReportViewer.Zoom(100%)
                Frm.ReportViewer.DisplayGroupTree = False
                Frm.WindowState = FormWindowState.Maximized
                Frm.Show()

            End With
        Else
            With RSC
                aa = "SELECT      AP_Salary_in_Month.*, AP_CV.Name_E,AP_CV.Bank_no,AP_CV.SSO_no,  " & _
             "   AP_CV.Phone,AP_CV.txtV_C, AP_Sections.Sec_nmL, AP_Sections.Sec_id,Department.DP_ID, Department.DP_Name ,  " & _
            "     Type_In.In_ID, Type_In.In_nm , job.job_nm  FROM        " & _
         "  AP_Salary_in_Month INNER JOIN       AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN  " & _
              "  AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN     " & _
               "    Department ON AP_CV.Department_id = Department.DP_ID INNER JOIN      " & _
                  "    Type_In ON AP_CV.type_in_id = Type_In.In_ID  INNER JOIN " & _
                    "      job ON AP_CV.duties_Id = job.job_id  WHERE 1=1  " & Sql & " " & shr_Class_vel & " " & shr_Department & " " & shr_section & " " & shr_job_phuk & " " & shr_job_lut & "" & Shr_persen & " " & _
        " and   month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' order by AP_CV.order_no   "
                Call LoadRs(aa, RSC)
                If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub

                Dim Frm As New FrmPreview
                Dim Rpt As New Report_Salary_In_tax
                Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
                myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text6"), CrystalDecisions.CrystalReports.Engine.TextObject)
                myTextObjectOnReport.Text = "" & Cmb_Sections.Text & ""


                myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text30"), CrystalDecisions.CrystalReports.Engine.TextObject)
                myTextObjectOnReport.Text = "ເດືອນ " & (Format(DT_Month.Value, "MM/yyyy"))
                'If chk_section.Checked = True Then
                '    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                '    myTextObjectOnReport.Text = Cmb_Sections.Text

                'Else
                '    myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
                '    myTextObjectOnReport.Text = ""
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
        End If




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




    Private Sub Chk_em_Extra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_em_Extra.CheckedChanged
        If Chk_em_Extra.Checked = True Then
            'chk_section.Checked = True
            Cmb_Sections.Enabled = True

            Cmb_Sections.Items.Clear()
            Call load_Cmb("select Sec_nmL from AP_Sections where Group_Sec_id='02' ", "Sec_nmL", Cmb_Sections)
            Cmb_Sections.SelectedIndex = 0
            shr_section = " AND AP_CV.Sections_id = N'" & txtSection_ID.Text & "' "
        Else


        End If
    End Sub

    Private Sub Chk_em_In_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_em_In.CheckedChanged
        If Chk_em_In.Checked = True Then
            'chk_section.Checked = True
            Cmb_Sections.Enabled = True

            Cmb_Sections.Items.Clear()
            Call load_Cmb("select Sec_nmL from AP_Sections where Group_Sec_id='01' ", "Sec_nmL", Cmb_Sections)
            Cmb_Sections.SelectedIndex = 0
            shr_section = " AND AP_CV.Sections_id = N'" & txtSection_ID.Text & "' "
        Else


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        txtpart.Text = FolderBrowserDialog1.SelectedPath
        'txtnm.Text = FolderBrowserDialog1.SafeFileName

        Dim aa As String
        Dim Rslaw As New ADODB.Recordset
        Dim RSC As New ADODB.Recordset
        aa = "update AP_Salary_in_Month set tax_level =1" & _
       "   where  Tax_Level2>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =2" & _
     "   where  Tax_Level3>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =3" & _
        "   where  Tax_Level4>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =4" & _
       "   where  Tax_Level5>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =5" & _
     "   where  Tax_Level6>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)

        aa = "update AP_Salary_in_Month set tax_level =6" & _
    "   where  Tax_Level7>0 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' "
        Conn.Execute(aa)


        Call LoadRs("SELECT * FROM AP_Salary_in_Month  ", Rslaw)
        Try
            With RSC
                aa = "SELECT  str( month(AP_Salary_in_Month.AtMonth))+'/'+str(year(AP_Salary_in_Month.AtMonth)),  AP_Sections.Sec_nmL,Department.DP_Name ,job.job_nm ,AP_CV.Name_L,AP_CV.Name_E,AP_CV.Bank_no, " & _
        "   AP_Salary_in_Month.total_amount +AP_Salary_in_Month.MOvertimeTotal+AP_Salary_in_Month.tax_money - (AP_Salary_in_Month.Employee_LAK), " & _
       " AP_Salary_in_Month.tax_level,AP_Salary_in_Month.tax_money, " & _
        "  AP_Salary_in_Month.total_amount +AP_Salary_in_Month.MOvertimeTotal+AP_Salary_in_Month.tax_money - (AP_Salary_in_Month.Employee_LAK) - AP_Salary_in_Month.tax_money, " & _
       "  AP_CV.Phone,    Type_In.In_nm  FROM          " & _
    " AP_Salary_in_Month INNER JOIN       AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN    " & _
         " AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN       " & _
            " Department ON AP_CV.Department_id = Department.DP_ID INNER JOIN        " & _
              "  Type_In ON AP_CV.type_in_id = Type_In.In_ID  INNER JOIN   " & _
                 "   job ON AP_CV.duties_Id = job.job_id  WHERE 1=1  " & Sql & " " & shr_Class_vel & " " & shr_Department & " " & shr_section & " " & shr_job_phuk & " " & shr_job_lut & "" & Shr_persen & " " & _
       " and   month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "' order by AP_CV.order_no   "
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
                xlWorkSheet.Cells(1, 1).Value = "ເດືອນ   "
                xlWorkSheet.Cells(1, 2).Value = "ສາຂາ  "
                xlWorkSheet.Cells(1, 3).Value = "ພະແນກ   "
                xlWorkSheet.Cells(1, 4).Value = "ຕຳແໜ່ງ  "
                xlWorkSheet.Cells(1, 5).Value = "ຊື່ ແລະ ນາມສະກຸນ (ລາວ)"
                xlWorkSheet.Cells(1, 6).Value = "ຊື່ ແລະ ນາມສະກຸນ (ອັດກິດ)"
                xlWorkSheet.Cells(1, 7).Value = "ເລກບັນຊີທະນາຄານ  "
                xlWorkSheet.Cells(1, 8).Value = "ລາຍຮັບທີ່ເສຍອາກອນ"
                xlWorkSheet.Cells(1, 9).Value = "ລະດັບຂັ້ນເສຍອາກອນ "
                xlWorkSheet.Cells(1, 10).Value = "ອາກອນເງິນເດືອນ "
                xlWorkSheet.Cells(1, 11).Value = "ລາຍຮັບຫລັງອາກອນ"
                xlWorkSheet.Cells(1, 12).Value = "ເບີໂທ    "
                xlWorkSheet.Cells(1, 13).Value = "ສະຖານະ"
 
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
                If Chk_em_In.Checked = True Then
                    xlWorkSheet.SaveAs("" & Trim(txtpart.Text) & "\ລຳດັບອາກອນ ສາຂາພາຍໃນ.xlsx")
                Else
                    xlWorkSheet.SaveAs("" & Trim(txtpart.Text) & "\ລຳດັບອາກອນ ສາຂາຕ່າງປະເທດ.xlsx")
                End If

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
End Class