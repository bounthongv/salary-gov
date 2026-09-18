Public Class Frm_Salary_in_month_List
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
    Private Sub Frm_Salary_in_month_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'Fg1.FormatString = ">ລ/ດ |<ລະຫັດພະນັກງານ |<ເລກບັນຊີ             |<ຊື່ ແລະ ນາມສະກຸນ   |^ວັນເດືອນປີເກີດ|<ຕຳແໜ່ງຮັບຜິດຊອບ|>ຊັ້ນ/ຂັນ|>ເງີນເດືອນພື້ນຖານ|>ເງີນອຸດໜູນຕຳແໜ່ງ|>ຈ/ນປິການ|>ຈ/ນເງີນປິການ|>ລວມເງີນທັງໝົດ |>ປະກັນສັງຄົມ 8%|>ລວມເງີນຍັງເຫຼືອ|>ອາກອນ(Tax)|>ຄ່າຄອງຊີບ|>ຈ/ນລູກ|>ປັນເງີນ     |>ຈ/ນເມຍ|>ເປັນເງີນ     |>ລວມເງີນໄດ້ຮັບຕົວຈິງ|<ໝາຍເຫດ"
        Fg1.FormatString = "ລ/ດ|<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ      |<ຊື່ (ພາສາອັງກິດ)    |<ບ່ອນປະຈຳການ           |<ພະແນກ          |<ກຸ່ມເງີນເດືອນ                             |>ເງີນເດືອນພື້ນຖານ   |>ເງີນຕຳແໜ່ງບໍລິຫານ |<ໝາຍເຫດ        "
        'Fg1.set_ColHidden(1, True)
        Sql = ""
        shr_section = ""
        shr_Department = ""
        shr_job_phuk = ""
        chk_department.Checked = True
        Call loaddata()
    End Sub
    Private Sub loaddata_in_Month()
        Fg1.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT      AP_Salary_in_Month.*, AP_CV.Name_E,AP_CV.Bank_no,AP_CV.SSO_no,  " & _
          "   AP_CV.Phone,AP_CV.txtV_C, AP_Sections.Sec_nmL, AP_Sections.Sec_id,     " & _
   "  Department.DP_ID, Department.DP_Name ,   " & _
   "  Type_In.In_ID, Type_In.In_nm , job.job_nm  FROM         " & _
    "   AP_Salary_in_Month INNER JOIN       AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN   " & _
        "    AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN      " & _
          "     Department ON AP_CV.Department_id = Department.DP_ID INNER JOIN       " & _
               "   Type_In ON AP_CV.type_in_id = Type_In.In_ID  INNER JOIN  " & _
              "        job ON AP_CV.duties_Id = job.job_id   where 1=1   " & shr_Month & " " & shr_section & " " & shr_Department & "  " & shr_job_phuk & "   ORDER BY  AP_CV.E_ID "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                                          Chr(9) & Trim((RSC.Fields("PersonID").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("Name_E").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("Phone").Value).ToString) & _
                                    Chr(9) & Trim((RSC.Fields("Sec_nmL").Value).ToString) & _
                                     Chr(9) & Trim(RSC.Fields("DP_Name").Value.ToString) & _
                                        Chr(9) & Format(CDbl(.Fields("Salary").Value), "##,##0.00") & _
                                         Chr(9) & Trim((RSC.Fields("SalaryCurrency").Value).ToString) & _
                                           Chr(9) & Format(CDbl(.Fields("txtTum_money").Value), "##,##0.00") & _
                                          Chr(9) & Format(CDbl(.Fields("Money_Befor").Value), "##,##0.00"))


                    .MoveNext()
                End While
            Else
                Fg1.Rows = 1
                Fg1.Rows = 2
            End If
        End With

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
                  "  Salary_group ON AP_Salary.txtgroup_id = Salary_group.Group_SLR_id   where 1=1   " & Sql & " " & shr_section & " " & shr_Department & "  " & shr_job_phuk & "   ORDER BY    AP_CV.order_no  "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                                          Chr(9) & Trim((RSC.Fields("E_id").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("Name_E").Value).ToString) & _
                                                Chr(9) & Trim((RSC.Fields("Sec_nmL").Value).ToString) & _
                                          Chr(9) & Trim(RSC.Fields("DP_Name").Value.ToString) & _
                                          Chr(9) & Trim((RSC.Fields("Group_SLR_nm").Value).ToString) & _
                                                   Chr(9) & Format(CDbl(.Fields("txtsalary").Value), "##,##0.00") & _
                                     Chr(9) & Format(CDbl(.Fields("txtTum_money").Value), "##,##0.00") & _
                                  Chr(9) & Trim((RSC.Fields("remark").Value).ToString))


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
        'Label2.Text = "to"

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
        'Label2.Text = "ເຖິງ"

        Fg1.FormatString = "ລ/ດ |<ເລກບິນ       |<ເລກບິນ       |<ວັນທີ່       |<Refer no  |<ລະຫັດຜູ້ສະໜອງ |< ຊື່ ຜູ້ສະໜອງ    |>ຈໍານວນລ/ກ|>ເປັນເງິນ    |<ຜູ້ສົ່ງ             |<ຜູ້ຮັບ             |<  "

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        MDEdit = False
        EditActive = False
        'shr_Month = "and  month(DT_Month) ='" & Month(DT_Month.Value) & "' and year(DT_Month) ='" & Year(DT_Month.Value) & "'"
        frm_salary_calculate.MdiParent = FrmAPInvioce
        frm_salary_calculate.WindowState = FormWindowState.Maximized
        frm_salary_calculate.ShowIcon = False
        frm_salary_calculate.Show()
        'Panel1.Visible = True
    End Sub

    Private Sub Fg1_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg1.ClickEvent
        
        'Dim i As Integer
        'Dim J As Integer

        'For i = 1 To Fg1.Rows - 1
        '    For J = 1 To Fg1.RowSel - 1


        '        If Fg1.Row = i Then
        '            Fg1.Col = J
        '            Fg1.CellForeColor = Color.Red

        '        Else
        '            ''Fg1.Row = i
        '            'Fg1.Col = 1
        '            'Fg1.CellForeColor = Color.Black
        '            'Fg1.Col = 2
        '            'Fg1.CellForeColor = Color.Black
        '            'Fg1.Col = 3
        '            'Fg1.CellForeColor = Color.Black
        '            'Fg1.Col = 4
        '            'Fg1.CellForeColor = Color.Black

        '        End If

        '    Next
        'Next
        loadColor()
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
        Button9_Click(sender, e)

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
        MDEdit = True
        shr_Month = "and  month(DT_Month) ='" & Month(DT_Month.Value) & "' and year(DT_Month) ='" & Year(DT_Month.Value) & "'"
        frm_salary_calculate.MdiParent = FrmAPInvioce
        frm_salary_calculate.WindowState = FormWindowState.Maximized
        frm_salary_calculate.ShowIcon = False
        frm_salary_calculate.Show()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click

        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການ ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Salary_in_Month Where E_id=N'" & E_ID & "' and  month(DT_Month) ='" & Month(DT_Month.Value) & "' and year(DT_Month) ='" & Year(DT_Month.Value) & "'")
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
            aa = "SELECT      AP_Salary_in_Month.*, AP_CV.Name_E,AP_CV.Bank_no,AP_CV.SSO_no,  " & _
         "   AP_CV.Phone,AP_CV.txtV_C, AP_Sections.Sec_nmL, AP_Sections.Sec_id,Department.DP_ID, Department.DP_Name ,  " & _
        "     Type_In.In_ID, Type_In.In_nm , job.job_nm  FROM        " & _
        "  AP_Salary_in_Month INNER JOIN       AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN  " & _
          "  AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN     " & _
           "    Department ON AP_CV.Department_id = Department.DP_ID INNER JOIN      " & _
              "    Type_In ON AP_CV.type_in_id = Type_In.In_ID  INNER JOIN " & _
                "      job ON AP_CV.duties_Id = job.job_id  " & _
   "   where 1=1   " & Sql & " " & shr_section & " " & shr_Department & "  " & shr_job_phuk & " and   month(AtMonth) ='" & Month(DT_Month.Value) & "' and year(AtMonth) ='" & Year(DT_Month.Value) & "'    ORDER BY  AP_CV.duties_Id "
            Call LoadRs(aa, RSC)
            If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
            Dim Frm As New FrmPreview
            Dim Rpt As New Report_Salary_In_Month
            Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
            myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text27"), CrystalDecisions.CrystalReports.Engine.TextObject)
            myTextObjectOnReport.Text = cmb_Department.Text


            myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
            myTextObjectOnReport.Text = (Format(DT_Month.Value, "MM/yyyy"))


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
        txt_Hder.Text = "ແຕ່ວັນທີ " & DT_Month.Value & " - " & DT_Tran.Value
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

    Private Sub txtTdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_Tran.ValueChanged
        'Sql = " AND AP_CV.DT_strt_work between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'Sql = " AND AP_CV.DT_strt_work between '" & Format(DT_Month.Value, "MM/dd/yyyy") & "'AND '" & Format(DT_Tran.Value, "MM/dd/yyyy") & "'"

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

    Private Sub txtFdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_Month.ValueChanged
        'Sql = " AND AP_CV.DT_strt_work between '" & Format(DT_Month.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        'DT_Month = "and  month(DT_Month) ='" & Month(DT_Month.Value) & "' and year(DT_Month) ='" & Year(DT_Month.Value) & "'"
        shr_Month = "and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'"
        Call loaddata_in_Month()
        'loaddata()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim aa As String
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Salary_in_Month Where  month(DT_Month) ='" & Month(DT_Tran.Value) & "' and year(DT_Month) ='" & Year(DT_Tran.Value) & "'  ", RSC)
        If RSC.RecordCount = 0 Then

            aa = "INSERT INTO AP_Salary_in_Month(E_ID, Sections_id, Sections, Department_id, Department, txt_type_in_id, cmb_type_in, Name_L, Name_E, Phone, Bank_no, " & _
                " SSO_no, DT_Month, percen, txtclass, txtlevel, txtV_C, Level_Clss_Money, Tumnang_Money, year_money, txttotal, AGL, Total_remaining, Tax, khongsep, " & _
                " txtson, txtson_Money, txtmom,  txtMom_mony, txtToltal_All, remark, Status_son, Status_Mom, lst_updt, lst_usr, Pc_nm)   " & _
        "  (  SELECT  E_ID, Sections_id, Sections, Department_id, Department, txt_type_in_id, cmb_type_in, Name_L, Name_E, Phone, Bank_no, SSO_no  ,N'" & (Format(DT_Tran.Value, "yyyy-MM-dd")) & "', percen, " & _
             "    txtclass, txtlevel, txtV_C, Level_Clss_Money, Tumnang_Money, year_money, txttotal, AGL, Total_remaining, Tax, khongsep, txtson, txtson_Money, txtmom, " & _
           "     txtMom_mony, txtToltal_All, remark, Status_son, Status_Mom, " & _
                    "'" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
                     " N'" & MUserName & "', " & _
                       " N'" & MDServerName & "' " & _
                         "  FROM   AP_Salary where 1=1 ) "
            Conn.Execute(aa)

            aa = "update AP_Salary_in_Month set DT_work_today ='" & (Format(DT_Tran.Value, "yyyy-MM-dd")) & "'" & _
                  "   where   month(DT_Month) ='" & Month(DT_Tran.Value) & "' and year(DT_Month) ='" & Year(DT_Tran.Value) & "' "
            Conn.Execute(aa)

            aa = "update AP_Salary_in_Month set AP_Salary_in_Month.QTY_year = DateDiff(YEAR,AP_CV.DT_strt_work,AP_Salary_in_Month.DT_work_today ) " & _
                     "   from AP_CV where AP_Salary_in_Month.e_id = AP_CV.E_ID "
            Conn.Execute(aa)



        Else
            MsgBox("ລາຍການເດືອນ " & (Format(DT_Tran.Value, "MM/yyyy")) & " ມີແລ້ວ!", MsgBoxStyle.OkOnly)

            aa = "update AP_Salary set DT_work_today ='" & (Format(DT_Tran.Value, "yyyy-MM-dd")) & "'" & _
              "   where   1=1 "
            Conn.Execute(aa)

            aa = "update AP_Salary set AP_Salary.QTY_year = DateDiff(YEAR,AP_CV.DT_strt_work,AP_Salary.DT_work_today ) " & _
                     "   from AP_CV where AP_Salary.E_id = AP_CV.E_ID "
            Conn.Execute(aa)

        End If
        'Conn.Execute("Delete From AP_Salary_in_Month Where   month(DT_Month) ='" & Month(DT_Tran.Value) & "' and year(DT_Month) ='" & Year(DT_Tran.Value) & "' ")

        MsgBox("complete!", MsgBoxStyle.OkOnly)
        Button2_Click(sender, e)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If MessageBox.Show("ທ່ານຕ້ອງການລຶບຂໍ້ມູນປະຈຳເດືອນ " & (Format(DT_Tran.Value, "yyyy-MM-dd")) & " ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Salary_in_Month Where   month(DT_Month) ='" & Month(DT_Month.Value) & "' and year(DT_Month) ='" & Year(DT_Month.Value) & "'")
        End If
        Call loaddata()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DT_Month.Enabled = True

            shr_Month = "and  month(AP_Salary_in_Month.AtMonth) ='" & Month(DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(DT_Month.Value) & "'"
            Fg1.FormatString = "ລ/ດ|<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ      |<ຊື່ (ພາສາອັງກິດ)       |<ເບີໂທລະສັບ  |<ບ່ອນປະຈຳການ           |<ພະແນກ        |<ຊັ້ນ/ຂັນ |>ເງີນເດືອນພື້ນຖານ  |<ສະກຸນເງີນ|<ເງີນຕຳແໜ່ງ|>ລວມເງີນໄດ້ຮັບ      "
            Call loaddata_in_Month()
        Else
            DT_Month.Enabled = False
            shr_Month = ""
            Fg1.FormatString = "ລ/ດ|<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ      |<ຊື່ (ພາສາອັງກິດ)       |<ເບີໂທລະສັບ  |<ບ່ອນປະຈຳການ            |<ພະແນກ        |<ຊັ້ນ/ຂັນ |<ກຸ່ມເງີນເດືອນ            |>ເງີນເດືອນພື້ນຖານ  |<ສະກຸນເງີນ|<ໝາຍເຫດ        "
            Call loaddata()
        End If
    End Sub
End Class