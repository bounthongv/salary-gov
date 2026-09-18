Public Class Frm_Employee_take_leave_List
    'Public RSC As New ADODB.Recordset

    Dim itemfgacc As Boolean
    Dim rs As New ADODB.Recordset
    Dim Sql As String
    Dim RemainQty As Double
    Dim rsPro As New ADODB.Recordset
    Dim Last_page As Integer
    Dim StrSQL, ConString, SUPP As String
    Dim P As Integer
    Dim SQl1 As String
    Dim sql2 As String
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Frm_Employee_out_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fg1.FormatString = "ລ/ດ |<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ              |<ຊື່ (ພາສາອັງກິດ)  |<ເບີໂທລະສັບ  |<ບ່ອນປະຈຳການ     |<ຕຳແໜ່ງລັດ      |<ພະແນກ               |^ວັນທີເລີມເຮັດການ|<ຊັ້ນ/ຂັນ|^ວັນທີ່ເລື່ອນຊັ້ນຂັ້ນ|<ຊັ້ນ/ຂັນ|<ຮັບເງີນເດືອນຕົວຈີງ(%|<ບ້ານຢູ່ປະຈຸບັນ |<ເມືອງ            |<ແຂວງ           "

        Fg1.FormatString = "ລ/ດ|<ເລກທີ      |<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ      |<ຊື່ (ພາສາອັງກິດ)        |<ບ່ອນປະຈຳການ     |<ພະແນກ              |^ລາພັກວັນທີ      |^ຫາວັນທີ   |>ຈຳນວນມື້ລາພັກ|<ລະອຽດຂອງການລາພັກ|<ໝາຍເຫດ        "
        'Fg1.set_ColHidden(1, True)
        'Fg1.set_ColHidden(5, True)
        Sql = ""
        shr_section = ""
        shr_Department = ""
        shr_job_phuk = ""
        shr_type_in = ""
        chk_department.Checked = True
        Call loaddata()
    End Sub

    Private Sub loaddata()
        Fg1.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT      Ap_Employee_take_leave.*, AP_CV.Name_L, AP_CV.Name_E, " & _
      "       AP_CV.Phone,AP_CV.txtV_C, " & _
      "   AP_Sections.Sec_nmL, AP_Sections.Sec_id,  " & _
    "     Department.DP_ID, Department.DP_Name " & _
       "     FROM         Ap_Employee_take_leave INNER JOIN       " & _
         "   AP_CV ON Ap_Employee_take_leave.E_ID = AP_CV.E_ID INNER JOIN       " & _
         "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id " & _
         "    INNER JOIN       Department ON AP_CV.Department_id = Department.DP_ID  " & _
      "   where   1=1  " & shr_section & " " & shr_Department & " " & shr_job_phuk & "" & shr_type_in & " " & shr_job_lut & " order by  Ap_Employee_take_leave.E_id    "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                                                     Chr(9) & Trim((RSC.Fields("bill_no").Value).ToString) & _
                                            Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("Name_E").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("Sec_nmL").Value).ToString) & _
                                          Chr(9) & Trim(RSC.Fields("DP_Name").Value.ToString) & _
                         Chr(9) & Format(CDate(RSC.Fields("DT_from").Value), "dd/MM/yyyy") & _
                             Chr(9) & Format(CDate(RSC.Fields("dt_to").Value), "dd/MM/yyyy") & _
                                Chr(9) & Trim((RSC.Fields("qty_day").Value).ToString) & _
                                       Chr(9) & Trim((RSC.Fields("about").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("remark").Value).ToString))

                    '          Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                    '         Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                    '          Chr(9) & Trim((RSC.Fields("Name_E").Value).ToString) & _
                    '           Chr(9) & Trim((RSC.Fields("Phone").Value).ToString) & _
                    '          Chr(9) & Trim((RSC.Fields("Sections").Value).ToString) & _
                    '                      Chr(9) & Trim((RSC.Fields("job_lut").Value).ToString) & _
                    '           Chr(9) & Trim((RSC.Fields("Department").Value).ToString) & _
                    '         Chr(9) & Format(CDate(RSC.Fields("DT_strt_work").Value), "dd/MM/yyyy") & _
                    '           Chr(9) & Trim((RSC.Fields("start_work").Value).ToString) & _
                    'Chr(9) & Format(CDate(RSC.Fields("DT_Work_now").Value), "dd/MM/yyyy") & _
                    '                          Chr(9) & Trim((RSC.Fields("txtV_C").Value).ToString) & _
                    '                   Chr(9) & Trim(RSC.Fields("percen").Value) & " %" & _
                    '               Chr(9) & Trim((RSC.Fields("Vl_nm1").Value).ToString) & _
                    '               Chr(9) & Trim((RSC.Fields("Dt_nm1").Value).ToString) & _
                    '           Chr(9) & Trim((RSC.Fields("PV_nm1").Value).ToString))

                    .MoveNext()
                End While
            Else

                Fg1.Rows = 2

            End If
        End With

    End Sub
    Public Sub Lngs()

        BtnAddNew.Text = "AddNew"
        BtnEdit.Text = "Edit"
        BtnDel.Text = "Delete"
        Button2.Text = "Refresh"
        Button3.Text = "Peview"

        'Label1.Text = "Date:"
        Label2.Text = "to"

    End Sub
    Private Sub sakhone2()

    End Sub

    Public Sub LngLao()

        BtnAddNew.Text = "ເພີ່ມໃໝ່"
        BtnEdit.Text = "ແກ້ໄຂ"
        BtnDel.Text = "ລຶບ"
        Button2.Text = "ເອີ້ນຄືນ"
        Button3.Text = "ເບິ່ງຂໍ້ມູນ"

        'Label1.Text = "ວັນທີ່:"
        Label2.Text = "ເຖິງ"

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click

        EditActive = False
        Frm_Employee_take_leave.MdiParent = FrmAPInvioce
        Frm_Employee_take_leave.WindowState = FormWindowState.Maximized
        Frm_Employee_take_leave.ShowIcon = False
        Frm_Employee_take_leave.Show()

    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click

        If SaleID = "" Then Exit Sub
        EditActive = True
        Frm_Employee_take_leave.MdiParent = FrmAPInvioce
        Frm_Employee_take_leave.WindowState = FormWindowState.Maximized
        Frm_Employee_take_leave.ShowIcon = False
        Frm_Employee_take_leave.Show()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        Dim aa As String
        aa = "INSERT INTO AP_CV(E_ID, Sections_id, Sections, Department_id, Department, type_in_id, type_in_nm, Name_L, Name_E, Phone, Bank_no, SSO_no, DT_strt_work, " & _
       "   start_work_ID, start_work, txtmoney_basic, DT_Work_now, cmbclass, cmblevel, txtV_C, txt_parts_id, cmb_parts, txt_work_id, cmb_work, percen, DOB, age, gender,  " & _
      "    BProv_ID, BVill_ID, Add_Vill_ID, houeNo, Road, Street, Card_no, dateOutID, txt_hours_money, Level_Clss_Money, Tumnang_Money, year_money, txttotal, AGL,  " & _
      "    Total_remaining, Tax, khongsep, txtson, txtson_Money, txtmom, txtMom_mony, txtWomen_mony, txtoil_mony, txtPhone_money, txtToltal_All, chk_lut, dt_Lut,  " & _
     "     chk_Phuk_sumhong, Dt_Phuk_sumhong, chk_Phuk, Dt_Phuk, chk_Job_Phuk, job_phuk_ID, job_phuk, chk_job_lut, job_lut_ID, job_lut, txthong, chk_job_lut_visakan,  " & _
      "     job_lut_visakan, duties_Id, duties, chk_study, DT_study, chk_start, DT_Start, study_ID, study, txtvisa_id, txtvisa, Study_cuntry_id, Study_cuntry, chk_study2,  " & _
       "     DT_study2, txtstudy2, chk_lang, lang_ID, lang, CmbNation1_ID, CmbNation1, CmbNation2_ID, CmbNation2, CmbNation3_ID, CmbNation3, CmbReligion_id,  " & _
        "   CmbReligion, Status_son, Status_Mom, Status_donw, Status_Up, Status_Per_id, Status_Per, Status_out, lst_updt,lst_usr, Pc_nm)   " & _
       "  (SELECT E_ID, Sections_id, Sections, Department_id, Department, type_in_id, type_in_nm, Name_L, Name_E, Phone, Bank_no, SSO_no, DT_strt_work, " & _
        "   start_work_ID, start_work, txtmoney_basic, DT_Work_now, cmbclass, cmblevel, txtV_C, txt_parts_id, cmb_parts, txt_work_id, cmb_work, percen, DOB, age, gender,  " & _
       "    BProv_ID, BVill_ID, Add_Vill_ID, houeNo, Road, Street, Card_no, dateOutID, txt_hours_money, Level_Clss_Money, Tumnang_Money, year_money, txttotal, AGL,  " & _
       "    Total_remaining, Tax, khongsep, txtson, txtson_Money, txtmom, txtMom_mony, txtWomen_mony, txtoil_mony, txtPhone_money, txtToltal_All, chk_lut, dt_Lut,  " & _
       "     chk_Phuk_sumhong, Dt_Phuk_sumhong, chk_Phuk, Dt_Phuk, chk_Job_Phuk, job_phuk_ID, job_phuk, chk_job_lut, job_lut_ID, job_lut, txthong, chk_job_lut_visakan,  " & _
      "     job_lut_visakan, duties_Id, duties, chk_study, DT_study, chk_start, DT_Start, study_ID, study, txtvisa_id, txtvisa, Study_cuntry_id, Study_cuntry, chk_study2,  " & _
       "     DT_study2, txtstudy2, chk_lang, lang_ID, lang, CmbNation1_ID, CmbNation1, CmbNation2_ID, CmbNation2, CmbNation3_ID, CmbNation3, CmbReligion_id,  " & _
          "   CmbReligion, Status_son, Status_Mom, Status_donw, Status_Up, Status_Per_id, Status_Per, Status_out, " & _
          " Getdate()," & _
        " N'" & MUserName & "', " & _
          " N'" & MDServerName & "' " & _
         "  FROM   AP_Employee_out where E_ID ='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "')"
        Conn.Execute(aa)


        Dim cmdDel As New ADODB.Command
        If Me.Fg1.get_TextMatrix(Me.Fg1.Row, 1) = "" Then MsgBox("ກະລຸນາເລຶອກລາຍການທ່ານຕ້ອງການລຶບກ່ອນ !") : Exit Sub
        'Call LoadRs("SELECT * FROM AP_Brith_Data  WHERE   Brith_no=N'" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "'  ", rs)
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການ : " & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Employee_out Where  e_id='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1) & "'"))
            'Conn.Execute("Delete From AP_Brith_Data_list Where  Book_id='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1) & "'"))
            Call loaddata()
        End If

        Call loaddata()


    End Sub
    Public Sub CheckData(ByVal i As Integer, ByVal KQTY As Double, ByVal ID As String, ByVal NQty As Double)
        'MsgBox KQTY
        Call LoadRs("SELECT Qty FROM AP_Products WHERE Pro_ID = '" & Trim(ID) & "'", rs)
        If rs.RecordCount > 0 Then
            RemainQty = rs.Fields("Qty").Value - KQTY + NQty
            rs = Nothing
            If CDbl(RemainQty) < 0 Then MsgBox("¥¿­¸­¦ò­£û¾´ó¡¾­¯ú¼­Á¯¤Áìû¸ ®Ò¦¾´¾©ìô® ¹õù ©ñ©Á¡ûÄ©û!", MsgBoxStyle.OkOnly) : Exit Sub
        End If
        '    MsgBox RemainQty & " : " & KQTY & " : " & NQty & " : " & ID
        rs = Nothing
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        With RSC
            Dim aa As String
            aa = "SELECT      Ap_Employee_take_leave.*, AP_CV.Name_L, AP_CV.Name_E, " & _
     "       AP_CV.Phone,AP_CV.txtV_C, " & _
     "   AP_Sections.Sec_nmL, AP_Sections.Sec_id,  " & _
   "     Department.DP_ID, Department.DP_Name " & _
      "     FROM         Ap_Employee_take_leave INNER JOIN       " & _
        "   AP_CV ON Ap_Employee_take_leave.E_ID = AP_CV.E_ID INNER JOIN       " & _
        "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id " & _
        "    INNER JOIN       Department ON AP_CV.Department_id = Department.DP_ID  " & _
     "   where   1=1  " & shr_section & " " & shr_Department & " " & shr_job_phuk & "" & shr_type_in & " " & shr_job_lut & " order by  Ap_Employee_take_leave.E_id    "
            Call LoadRs(aa, RSC)
            If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
            Dim Frm As New FrmPreview
            Dim Rpt As New Report_Employee_take_leave
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

    Private Sub txtIn_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIn_no.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged
        txt_Hder.Text = "ແຕ່ວັນທີ " & txtFdate.Value & " - " & txtTdate.Value
        Sql = " AND YEAR(AP_Ject.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call loaddata()
        Me.Enabled = True
    End Sub




    Private Sub sakhone()
        Fg1.Rows = 1
        Call LoadRs("SELECT dbo.AP_Suppliers.Supp_nmL, dbo.AP_Suppliers.Supp_nmE, dbo.AP_Ject.Bill_Dt, dbo.AP_Ject.Supp, dbo.AP_Ject.date_m, dbo.AP_Ject.date_to, dbo.AP_Ject.remark,  " & _
                     " dbo.AP_Ject.Bill_Amt, dbo.AP_Ject.total_n, dbo.AP_Ject.Paid_Fin, dbo.AP_Ject.Bill_net, dbo.AP_Ject.Company, dbo.AP_Ject.Bill_Paid, dbo.AP_Suppliers.Supp_id,  " & _
                     "dbo.AP_Ject.Bill_ID, dbo.AP_Ject.Stff, dbo.AP_Staffs.Stff_nmL, dbo.AP_Ject.PO, dbo.AP_Ject.RO, dbo.AP_Ject.EO FROM   dbo.AP_Ject LEFT OUTER JOIN " & _
                      "dbo.AP_Suppliers ON dbo.AP_Ject.Supp = dbo.AP_Suppliers.Supp_id LEFT OUTER JOIN " & _
                     " dbo.AP_Staffs ON dbo.AP_Ject.Stff = dbo.AP_Staffs.Stff_Id where  1=1 " & SQl1 & "  ORDER BY dbo.AP_Ject.Bill_ID ", RSC)
        'FG1.FormatString = "ລ/ດ|ເລກທີບີນ  |^ວັນທີສັ່ງຊື້        |^ວັນທີນັດຈ່າຍ      |^ຈຳນວນມື້ |^ຜູ້ສະໜອງ              |>ມູນຄ່າທັງໝົດເປັນກີບ                 |^ຜູ້ຮັບ                   "
        With RSC
            If .RecordCount > 0 Then
                While Not .EOF
                    Fg1.AddItem(.AbsolutePosition & _
                               Chr(9) & Trim((RSC.Fields("Bill_ID").Value)) & _
                               Chr(9) & Trim((RSC.Fields("PO").Value).ToString) & _
                               Chr(9) & Trim((RSC.Fields("RO").Value).ToString) & _
                               Chr(9) & Trim((RSC.Fields("EO").Value).ToString) & _
                               Chr(9) & Format(CDate(RSC.Fields("Bill_Dt").Value), "dd/MM/yyyy") & _
                               Chr(9) & Format(CDate(RSC.Fields("Date_to").Value), "dd/MM/yyyy") & _
                               Chr(9) & Format((RSC.Fields("date_m").Value.ToString) & _
                               Chr(9) & (RSC.Fields("Supp_nmL").Value) & _
                               Chr(9) & (RSC.Fields("Stff_nmL").Value.ToString)))

                    .MoveNext()
                End While
            Else
                Fg1.Rows = 2
            End If
        End With
    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        'If ComboBox2.SelectedIndex = 0 Then
        '    SUPP = ""
        '    P = 1
        '    Call PageCnt2(StrSQL, ConString, P, 500)
        '    Me.lblpage_total.Text = "1/" & Last_page
        '    Me.Enabled = True
        'ElseIf ComboBox2.SelectedIndex = 1 Then
        '    SUPP = " and chk1=0"
        '    P = 1
        '    Call PageCnt(StrSQL, ConString, P, 500)
        '    Me.lblpage_total.Text = "1/" & Last_page
        '    Me.Enabled = True
        'Else
        '    SUPP = " and chk1=1"
        '    P = 1
        '    Call PageCnt(StrSQL, ConString, P, 500)
        '    Me.lblpage_total.Text = "1/" & Last_page
        '    Me.Enabled = True
        'End If
    End Sub



    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox1.Text = Format((DateTimePicker1.Value), "yyyy")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການໃບຮຽກເກັບເງິນ : " & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sa As String = "Delete From AP_Ject Where  Bill_ID='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1) & "'")
            Conn.Execute(sa)

        End If
    End Sub
    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Fg2_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Sql = " AND AP_Employee_out.DT_out between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Call loaddata()
    End Sub

    Private Sub txtBK_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBK_no.TextChanged
        Sql = " AND dbo.AP_Employee_out.E_ID LIKE N'%" & txtBK_no.Text & "%' "
        Call loaddata()
    End Sub

    Private Sub txtbarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarcode.TextChanged
        Sql = " AND AP_Employee_out.Name_L LIKE N'%" & txtbarcode.Text & "%' "
        Call loaddata()
    End Sub



    Private Sub txtDoctor_Place_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Sql = ""
        shr_section = ""
        shr_Department = ""
        shr_job_phuk = ""
        shr_type_in = ""

        Call loaddata()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtFdate.Enabled = True
            txtTdate.Enabled = True
            Button9.Enabled = True
            Sql = " AND AP_Employee_out.DT_strt_work between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"

        Else
            txtFdate.Enabled = False
            txtTdate.Enabled = False
            Button9.Enabled = False
            Sql = ""
            Call loaddata()
        End If
    End Sub



    Private Sub FG2_DblClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Btt_Edit_Click(sender, e)
    End Sub

    Private Sub FG2_SelChange_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btt_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SaleID = "" Then Exit Sub
        EditActive = True
        Frm_Birth_Data.MdiParent = FrmAPInvioce
        Frm_Birth_Data.WindowState = FormWindowState.Maximized
        Frm_Birth_Data.ShowIcon = False
        Frm_Birth_Data.Show()
    End Sub



    Private Sub chk_section_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_section.CheckedChanged
        If chk_section.Checked = True Then
            Cmb_Sections.Items.Clear()
            Call load_Cmb("select Sec_nmL from AP_Sections", "Sec_nmL", Cmb_Sections)
            Cmb_Sections.SelectedIndex = 0
            shr_section = " AND AP_CV.Sections_id = N'" & txtSection_ID.Text & "' "



        Else
            Cmb_Sections.Items.Clear()
            shr_section = ""
        End If
        Call loaddata()
    End Sub

    Private Sub Cmb_Sections_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Sections.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Sections Where Sec_nmL=N'" & Trim(Cmb_Sections.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtSection_ID.Text = Trim(RSC("Sec_id").Value)
            shr_section = " AND AP_CV.Sections_id = N'" & txtSection_ID.Text & "' "

        End If
        Call loaddata()
    End Sub

    Private Sub chk_Job_Phuk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Job_Phuk.CheckedChanged
        If chk_Job_Phuk.Checked = True Then

            cmb_job_phuk.Items.Clear()
            Call load_Cmb("select phuk_id,Phuk_nm from Phuk", "Phuk_nm", cmb_job_phuk)
            cmb_job_phuk.SelectedIndex = 0
            shr_job_phuk = " AND AP_Employee_out.job_phuk_ID = N'" & txt_job_phuk_id.Text & "' "

        Else
            cmb_job_phuk.Items.Clear()
            cmb_job_phuk.Text = ""
            shr_job_phuk = ""
        End If
        Call loaddata()
    End Sub

    Private Sub cmb_job_phuk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_phuk.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Phuk Where  Phuk_nm=N'" & Trim(cmb_job_phuk.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_phuk_id.Text = Trim(RSC("phuk_id").Value)
            shr_job_phuk = " AND AP_Employee_out.job_phuk_ID = N'" & txt_job_phuk_id.Text & "' "
        End If
        Call loaddata()
    End Sub

    Private Sub chk_department_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_department.CheckedChanged
        If chk_department.Checked = True Then


            cmb_Department.Items.Clear()
            Call load_Cmb("select DP_Name from Department  order by sec_id", "DP_Name", cmb_Department)
            cmb_Department.SelectedIndex = 0

         
            shr_Department = " AND AP_CV.Department_id = N'" & txtdepart_ID.Text & "' "

        Else

            cmb_Department.Items.Clear()
            shr_Department = ""
        End If
        Call loaddata()
    End Sub

    Private Sub cmb_Department_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Department.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Department Where DP_name=N'" & Trim(cmb_Department.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtdepart_ID.Text = Trim(RSC("DP_ID").Value)
            DP_id = Trim(RSC("DP_ID").Value)
            shr_Department = " AND AP_CV.Department_id = N'" & txtdepart_ID.Text & "' "
        End If
        Call loaddata()
    End Sub

    Private Sub chk_type_in_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_type_in.CheckedChanged
        If chk_type_in.Checked = True Then
            cmb_type_in.Items.Clear()
            Call load_Cmb("select In_nm from Type_In", "In_nm", cmb_type_in)
            cmb_type_in.SelectedIndex = 0
            shr_type_in = " AND AP_Employee_out.type_in_id = N'" & txt_type_in_id.Text & "' "

        Else

            cmb_type_in.Items.Clear()
            shr_type_in = ""
        End If
        Call loaddata()
    End Sub

    Private Sub cmb_type_in_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type_in.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Type_In Where  In_nm=N'" & Trim(cmb_type_in.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_type_in_id.Text = Trim(RSC("In_ID").Value)
            shr_type_in = " AND AP_Employee_out.type_in_id = N'" & txt_type_in_id.Text & "' "
        End If
        Call loaddata()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If SaleID = "" Then Exit Sub

        E_ID = " and AP_Position.E_ID=N'" & SaleID & "'"
        MDCusID = " AND AP_Employee_out.E_ID=N'" & SaleID & "'"
        MDEdit = True
        Frm_Position_work.MdiParent = FrmAPInvioce
        Frm_Position_work.WindowState = FormWindowState.Maximized
        Frm_Position_work.ShowIcon = False
        Frm_Position_work.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If SaleID = "" Then
            EditActive = False
        Else
            EditActive = True
        End If

        Frm_CV.MdiParent = FrmAPInvioce
        Frm_CV.WindowState = FormWindowState.Maximized
        Frm_CV.ShowIcon = False
        Frm_CV.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If SaleID = "" Then Exit Sub

        E_ID = " and AP_Organization.E_ID=N'" & SaleID & "'"
        MDCusID = " AND AP_CV.E_ID=N'" & SaleID & "'"
        MDEdit = True
        Frm_Organization.MdiParent = FrmAPInvioce
        Frm_Organization.WindowState = FormWindowState.Maximized
        Frm_Organization.ShowIcon = False
        Frm_Organization.Show()
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        If SaleID = "" Then Exit Sub

        E_ID = " and AP_Persion_Study.E_ID=N'" & SaleID & "'"
        MDCusID = " AND AP_CV.E_ID=N'" & SaleID & "'"
        MDEdit = True
        Frm_Persion_Education.MdiParent = FrmAPInvioce
        Frm_Persion_Education.WindowState = FormWindowState.Maximized
        Frm_Persion_Education.ShowIcon = False
        Frm_Persion_Education.Show()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        If SaleID = "" Then Exit Sub

        E_ID = " and AP_Persion_Family.E_ID=N'" & SaleID & "'"
        MDCusID = " AND AP_CV.E_ID=N'" & SaleID & "'"
        MDEdit = True
        Frm_Persion_Family.MdiParent = FrmAPInvioce
        Frm_Persion_Family.WindowState = FormWindowState.Maximized
        Frm_Persion_Family.ShowIcon = False
        Frm_Persion_Family.Show()
    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If SaleID = "" Then Exit Sub

        E_ID = " and AP_Persion_Health.E_ID=N'" & SaleID & "'"
        MDCusID = " AND AP_CV.E_ID=N'" & SaleID & "'"
        MDEdit = True
        Frm_Persion_Health.MdiParent = FrmAPInvioce
        Frm_Persion_Health.WindowState = FormWindowState.Maximized
        Frm_Persion_Health.ShowIcon = False
        Frm_Persion_Health.Show()
    End Sub

    Private Sub Fg1_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg1.ClickEvent
        SaleID = Fg1.get_TextMatrix(Fg1.Row, 2)
    End Sub

    Private Sub Fg1_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg1.DblClick
        Btt_Edit_Click(sender, e)
    End Sub

    Private Sub Fg1_SelChange_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg1.SelChange

    End Sub

    Private Sub chk_Job_lut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Job_lut.CheckedChanged
        If chk_Job_lut.Checked = True Then
            cmb_job_lut.Enabled = True
            cmb_job_lut.Items.Clear()
            Call load_Cmb("select job_id,job_nm from job", "job_nm", cmb_job_lut)
            cmb_job_lut.SelectedIndex = 0
            shr_job_lut = " AND AP_Employee_out.duties_Id = N'" & txt_job_lut_id.Text & "' "

        Else
            shr_job_lut = ""
            cmb_job_lut.Items.Clear()
            cmb_job_lut.Text = ""
        End If
        Call loaddata()
    End Sub

    Private Sub cmb_job_lut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_lut.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From job Where  job_nm=N'" & Trim(cmb_job_lut.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_lut_id.Text = Trim(RSC("job_id").Value)
            shr_job_lut = " AND AP_Employee_out.duties_Id = N'" & txt_job_lut_id.Text & "' "

        End If
        Call loaddata()
    End Sub

    Private Sub txtTdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtFdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtFdate_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFdate.ValueChanged
        Sql = " AND AP_Employee_out.DT_out between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Call loaddata()
    End Sub

    Private Sub txtTdate_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTdate.ValueChanged
        Sql = " AND AP_Employee_out.DT_out between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Call loaddata()
    End Sub
End Class