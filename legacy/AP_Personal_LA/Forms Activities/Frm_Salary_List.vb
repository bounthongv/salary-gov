Public Class Frm_Salary_List
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
    Private Sub Frm_Salary_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Fg1.FormatString = "ລ/ດ|<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ      |<ຊື່ (ພາສາອັງກິດ)       |<ເບີໂທລະສັບ  |<ບ່ອນປະຈຳການ     |<ພະແນກ     |<ກຸ່ມເງີນເດືອນ                     |>ເງີນເດືອນພື້ນຖານ|>ເງີນຕຳແໜ່ງບໍລິຫານ|<ໝາຍເຫດ"

        'FG2.FormatString = ">ລ/ດ     |<ລະຫັດພະນັກງານ|<ເລກທີ       |^ວັນທີ      |<ບ່ອນປະຈຳການ   |<ພະແນກ     |<ຂໍ້ຕົກລົງ        |<ບັນຊີທຽບຊັ້ນ-ຂັ້ນ  |<ປະເພດການເລື່ອນຊັ້ນ-ຂັ້ນ  |<ຊື່ ແລະ ນາມສະກຸນ|<ຊັ້ນ/ຂັນເກົ່າ  |<ເງີນເດືອນຕາມຊັ້ນ/ຂັ້ນເກົ່າ|<ຊັ້ນ/ຂັນໃໝ່|<ເງີນເດືອນຕາມ ຊັ້ນ/ຂັ້ນໃໝ່|<ເງີນອຸດໜູນຕຳແໜ່ງ|<ເງີນອຸດໜູນປີການ|<ລວມເງີນ |<ເງີນປະກັນສັງຄົມ(8%)|<ລວມເງີນຍັງເຫຼືອ|<ອາກອນເງີນເດືອນ|<ເງີນອຸດໜູນຄ່າຄອງຊີບ|<ຈ/ນລູກ|<ເງີນອຸດໜູນ ລູກ|<ຈ/ນເມຍ|<ເງີນອຸດໜູນ  ເມຍ|<ລວມເງີນໄດຕົວຈີງ"
        'FG2.set_ColHidden(1, True)
        Sql = ""
        shr_section = ""
        shr_Department = ""
        shr_job_phuk = ""
        chk_department.Checked = True

        Call loaddata()
    End Sub

    Private Sub loaddata()
        Fg1.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT      AP_Salary.*, AP_CV.Name_L, AP_CV.Name_E, " & _
         "   AP_CV.Phone,AP_CV.txtV_C, AP_Sections.Sec_nmL, AP_Sections.Sec_id,   " & _
         "   Department.DP_ID, Department.DP_Name ,Salary_group.Group_SLR_nm " & _
              "   FROM         AP_Salary INNER JOIN  " & _
                 "     AP_CV ON AP_Salary.E_ID = AP_CV.E_ID INNER JOIN " & _
                 "     AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN " & _
                "      Department ON AP_CV.Department_id = Department.DP_ID INNER JOIN " & _
                    "  Salary_group ON AP_Salary.txtgroup_id = Salary_group.Group_SLR_id   where 1=1   " & Sql & " " & shr_section & " " & shr_Department & "  " & shr_job_phuk & "   ORDER BY    AP_CV.order_no "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                                          Chr(9) & Trim((RSC.Fields("E_id").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("Name_E").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("Phone").Value).ToString) & _
                                                 Chr(9) & Trim((RSC.Fields("Sec_nmL").Value).ToString) & _
                                          Chr(9) & Trim(RSC.Fields("DP_Name").Value.ToString) & _
                                                      Chr(9) & Trim((RSC.Fields("Group_SLR_nm").Value).ToString) & _
                                                   Chr(9) & Format(CDbl(.Fields("txtsalary").Value), "##,##0.00") & _
                                                                            Chr(9) & Format(CDbl(.Fields("txtTum_money").Value), "##,##0.00") & _
                                                                                   Chr(9) & Trim((RSC.Fields("remark").Value).ToString))

                          
                    'Chr(9) & Format(CDbl(.Fields("txtmoney_basic").Value), "##,##0.00") & _
                         

                    .MoveNext()
                End While

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

        Fg1.FormatString = "NO |<Bill       |<In no       |<date       |<Refer no  |<SuppliersID |< Suppliers name    |<Items|<Amount    |<Donor                    |<Receipt"

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

        Fg1.FormatString = "ລ/ດ |<ເລກບິນ       |<ເລກບິນ       |<ວັນທີ່       |<Refer no  |<ລະຫັດຜູ້ສະໜອງ |< ຊື່ ຜູ້ສະໜອງ    |>ຈໍານວນລ/ກ|>ເປັນເງິນ    |<ຜູ້ສົ່ງ             |<ຜູ້ຮັບ             |<  "

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click

        EditActive = False
        Frm_Salary.MdiParent = FrmAPInvioce
        Frm_Salary.WindowState = FormWindowState.Maximized
        Frm_Salary.ShowIcon = False
        Frm_Salary.Show()
    End Sub

    Private Sub Fg1_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg1.ClickEvent
        loadColor()

        Dim aa As String
        Dim rs As New ADODB.Recordset
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
                  "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id    " & _
               "   where 1=1 and  AP_CV.e_id='" & E_ID & "' "
        Call LoadRs(aa, rs)
        With rs
            If .RecordCount > 0 Then

                txt_Sections.Text = Trim(.Fields("Sec_nmL").Value.ToString)
                txt_Department.Text = Trim(.Fields("DP_Name").Value.ToString)
                TxtPersonNmL.Text = Trim(.Fields("Name_L").Value.ToString)
                txtorder_no.Text = Trim(.Fields("order_no").Value.ToString)
            End If
        End With
        txtorder_no.Focus()
    End Sub
 
    Private Sub loadColor()
        Dim J As Integer
        Dim i As Integer
        Dim aa As Integer
        aa = Fg1.Row
        For i = 1 To Fg1.Cols - 1
            For J = 1 To Fg1.Rows - 1
                Fg1.Row = J
                If aa = J Then
                    Fg1.Col = i
                    Fg1.CellForeColor = Color.Red
                Else
                    Fg1.Col = i
                    Fg1.CellForeColor = Color.Black
                End If
            Next J
        Next i
    End Sub

    Private Sub Fg1_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg1.DblClick
        Button8_Click(sender, e)
    End Sub

    Private Sub Fg1_MouseUpEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_MouseUpEvent) Handles Fg1.MouseUpEvent
        bttn_delete.Visible = False
        Btt_Edit.Visible = False
        SaleID = Fg1.get_TextMatrix(Fg1.Row, 1)
        E_ID = Fg1.get_TextMatrix(Fg1.Row, 1)
        'Bill_no = FG2.get_TextMatrix(FG2.Row, 2)
        'Call loaddata_list()

    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click

        If E_ID = "" Then Exit Sub
        EditActive = True
        Frm_Salary.MdiParent = FrmAPInvioce
        Frm_Salary.WindowState = FormWindowState.Maximized
        Frm_Salary.ShowIcon = False
        Frm_Salary.Show()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click

        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການ ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Salary Where  E_ID='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1) & "'"))
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
        Dim aa As String
        With RSC
            aa = "SELECT     AP_Salary.*, AP_CV.Name_E, AP_CV.Bank_no, AP_CV.SSO_no, AP_CV.Phone,   AP_CV.start_work_ID, " & _
                  "    AP_Sections.Sec_nmL, AP_Sections.Sec_id, Department.DP_ID, Department.DP_Name, Salary_group.Group_SLR_nm, AP_CV.DT_strt_work, job.job_nm,  " & _
         "   Type_In.In_ID, Type_In.In_nm " & _
             "   FROM         AP_Salary INNER JOIN " & _
                   "   AP_CV ON AP_Salary.E_ID = AP_CV.E_ID INNER JOIN " & _
                   "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN " & _
                    "  Department ON AP_CV.Department_id = Department.DP_ID INNER JOIN " & _
                     " Salary_group ON AP_Salary.txtgroup_id = Salary_group.Group_SLR_id INNER JOIN " & _
                    "  job ON AP_CV.duties_Id = job.job_id INNER JOIN " & _
                     " Type_In ON AP_CV.type_in_id = Type_In.In_ID   where 1=1   " & Sql & " " & shr_section & " " & shr_Department & "  " & shr_job_phuk & "   ORDER BY  AP_CV.duties_Id "
            Call LoadRs(aa, RSC)
            If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
            Dim Frm As New FrmPreview
            Dim Rpt As New Report_Persion_salary_list
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

    Private Sub txtIn_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub txtTdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTdate.ValueChanged
        Sql = " AND AP_CV.DT_strt_work between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Sql = " AND AP_CV.DT_strt_work between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Call loaddata()
    End Sub

    Private Sub txtBK_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBK_no.TextChanged
        Sql = " AND dbo.AP_CV.E_ID LIKE N'%" & txtBK_no.Text & "%' "
        Call loaddata()
    End Sub

    Private Sub txtbarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarcode.TextChanged
        Sql = " AND AP_CV.Name_L LIKE N'%" & txtbarcode.Text & "%' "
        Call loaddata()
    End Sub



    Private Sub txtDoctor_Place_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Sql = ""
        'shr_section = ""
        'shr_Department = ""
        'shr_job_phuk = ""
        Call loaddata()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtFdate.Enabled = True
            txtTdate.Enabled = True
            Button9.Enabled = True
            Sql = " AND AP_CV.DT_strt_work between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
            Call loaddata()
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
            Cmb_Sections.Text = ""
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

    Private Sub chk_department_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_department.CheckedChanged
        If chk_department.Checked = True Then


            cmb_Department.Items.Clear()
            Call load_Cmb("select DP_Name from Department  order by sec_id", "DP_Name", cmb_Department)
            cmb_Department.SelectedIndex = 0
            shr_Department = " AND AP_CV.Department_id = N'" & txtdepart_ID.Text & "' "

        Else

            cmb_Department.Items.Clear()

            cmb_Department.Text = ""
            shr_Department = ""
        End If
        Call loaddata()
    End Sub

    Private Sub chk_Job_Phuk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Job_Phuk.CheckedChanged
        If chk_Job_Phuk.Checked = True Then

            cmb_job_phuk.Items.Clear()
            Call load_Cmb("select phuk_id,Phuk_nm from Phuk", "Phuk_nm", cmb_job_phuk)
            cmb_job_phuk.SelectedIndex = 0
            shr_job_phuk = " AND AP_CV.job_phuk_ID = N'" & txt_job_phuk_id.Text & "' "

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
            shr_job_phuk = " AND AP_CV.job_phuk_ID = N'" & txt_job_phuk_id.Text & "' "
        End If
        Call loaddata()
    End Sub
 
    Private Sub FG2_SelChange_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btt_Edit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt_Edit.Click
        If E_ID = "" Then Exit Sub
        EditActive = True
        Frm_Donwlevel.MdiParent = FrmAPInvioce
        Frm_Donwlevel.WindowState = FormWindowState.Maximized
        Frm_Donwlevel.ShowIcon = False
        Frm_Donwlevel.Show()
    End Sub

    Private Sub bttn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_delete.Click
        'If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການ ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    Conn.Execute("Delete From AP_Up_Personal Where  E_ID='" & Trim(FG2.get_TextMatrix(FG2.Row, 1) & "' and   Bill_no='" & Trim(FG2.get_TextMatrix(FG2.Row, 2) & "'")))
        'End If


    End Sub

    Private Sub Fg1_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg1.SelChange

    End Sub

    Private Sub txtFdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFdate.ValueChanged
        Sql = " AND AP_CV.DT_strt_work between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Panel2.Visible = True

        Dim aa As String
        Dim rs As New ADODB.Recordset
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
                  "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id    " & _
               "   where 1=1 and  AP_CV.e_id='" & E_ID & "' "
        Call LoadRs(aa, rs)
        With rs
            If .RecordCount > 0 Then

                txt_Sections.Text = Trim(.Fields("Sec_nmL").Value.ToString)
                txt_Department.Text = Trim(.Fields("DP_Name").Value.ToString)
                TxtPersonNmL.Text = Trim(.Fields("Name_L").Value.ToString)
                txtorder_no.Text = Trim(.Fields("order_no").Value.ToString)
            End If
        End With
        txtorder_no.Focus()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Conn.Execute(" update ap_cv set order_no='" & txtorder_no.Text & "' where AP_CV.e_id='" & E_ID & "'  ")
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        Call loaddata()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Panel2.Visible = False
    End Sub
End Class