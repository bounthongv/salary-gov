Public Class Frm_Persion_Health
    'Public RSC As New ADODB.Recordset

    Dim itemfgacc As Boolean
    Dim rs As New ADODB.Recordset
    Dim Sql As String
    Dim RemainQty As Double
    Dim rsPro As New ADODB.Recordset
    Dim Last_page As Integer
    Dim StrSQL, ConString, SUPP, shr_duties, shr_vsakan As String
    Dim P As Integer
    Dim SQl1 As String
    Dim sql2 As String
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Frm_Persion_Health_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chk_A.Checked = True
        txt_higth.Text = 0
        Fg1.FormatString = "ລ/ດ |<ລະຫັດ  |<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ      |<ບ່ອນປະຈຳການ   |<ພະແນກ    |>ລວງສູງ|<ໝວດເລືອດ |<ດ້ານສຸຂະພາບ  |^ຖ້າສຸຂະພາບອ່ອນເພຍເລີ່ມແຕ່ປີ|<ເປັນຫຍັງ |^ຖ້າເປັນພະຍາດຕິດແປດເລີ່ມແຕ່ປີ|<ພະຍາດຫຍັງ|<ເສຍອົງຄະບໍ່ ປະເພດໃດ|^ເແຕ່ປີ     |<ສາເຫດຫຍັງ     "
        Fg1.set_ColHidden(1, True)
        Sql = ""
        'Sql = " AND AP_Check.Bill_Dt between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'   "
        'P = 1
        chk_A.Checked = True
        If MDEdit = True Then

            Call loaddata_one()

            LoadData_CV()
            AutoNumber()
        Else
            Call loaddata()
        End If


    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Bill_no from AP_Persion_Health    Order by bill_no DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Bill_no").Value, 1, 6)) + 1, "000000")
        Else
            VIOTNEW = "000001"

        End If
        txt_no.Text = Trim(CStr(VIOTNEW.ToString))
    End Sub
    Private Sub loaddata()
        Fg1.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT    AP_Persion_Health.*,AP_CV.Sections,AP_CV.Department  " & _
                   "   FROM         AP_Persion_Health INNER JOIN " & _
                   "   AP_CV ON AP_Persion_Health.E_ID = AP_CV.E_ID   where 1=1   " & Sql & " " & _
                   " " & shr_section & " " & shr_Department & " " & shr_type_in & "  " & shr_duties & "  " & shr_job_phuk & "     ORDER BY AP_Persion_Health.E_id "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then
                '"ລ/ດ |<ລະຫັດ  |<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ      |<ບ່ອນປະຈຳການ   |<ພະແນກ    |>ລວງສູງ|<ໝວດເລືອດ |<ດ້ານສຸຂະພາບ 
                '  |^ຖ້າສຸຂະພາບອ່ອນເພຍເລີ່ມແຕ່ປີ|<ເປັນຫຍັງ |^ຖ້າເປັນພະຍາດຕິດແປດເລີ່ມແຕ່ປີ|<ພະຍາດຫຍັງ|<ເສຍອົງຄະບໍ່ ປະເພດໃດ|^ເແຕ່ປີ     |<ສາເຫດຫຍັງ     "
                While Not .EOF()
                    Dim DT1, DT2, DT3, H1, H2, H3, H4 As String
                    If .Fields("txt_H3_id").Value.ToString = 1 Then
                        DT1 = Format(CDate(RSC.Fields("DT_exhausted").Value), "yyyy")
                    Else
                        DT1 = ""
                    End If
                    If .Fields("txt_H4_id").Value.ToString = 1 Then
                        DT2 = Format(CDate(RSC.Fields("DT_disease").Value), "yyyy")
                    Else
                        DT2 = ""
                    End If
                    If .Fields("chk_disabled_Type").Value.ToString = 1 Then
                        DT3 = Format(CDate(RSC.Fields("DT_disabled").Value), "yyyy")
                    Else
                        DT3 = ""
                    End If
                    If .Fields("txt_H1_nm").Value.ToString <> "NULL" Then
                        H1 = Trim((RSC.Fields("txt_H1_nm").Value).ToString)
                    Else
                        H1 = ""
                    End If
                    If .Fields("txt_H2_nm").Value.ToString <> "NULL" Then
                        H2 = Trim((RSC.Fields("txt_H2_nm").Value).ToString)
                    Else
                        H2 = ""
                    End If
                    If .Fields("txt_H3_nm").Value.ToString <> "NULL" Then
                        H3 = Trim((RSC.Fields("txt_H3_nm").Value).ToString)
                    Else
                        H3 = ""
                    End If
                    If .Fields("txt_H4_nm").Value.ToString <> "NULL" Then
                        H4 = Trim((RSC.Fields("txt_H3_nm").Value).ToString)
                    Else
                        H4 = ""
                    End If
                    Fg1.AddItem(.AbsolutePosition & _
                           Chr(9) & Trim((RSC.Fields("Bill_no").Value).ToString) & _
                                   Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                                       Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("Sections").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("Department").Value).ToString) & _
                                Chr(9) & Trim(RSC.Fields("txt_higth").Value) & " Cm" & _
                                     Chr(9) & Trim((RSC.Fields("txtBlood_nm").Value).ToString) & _
                                      Chr(9) & H1 & " " & H2 & " " & H3 & " " & H4 & _
                                         Chr(9) & DT1 & _
                                          Chr(9) & Trim((RSC.Fields("txt_exhausted").Value).ToString) & _
                                              Chr(9) & DT2 & _
                                          Chr(9) & Trim((RSC.Fields("txt_disease").Value).ToString) & _
                                   Chr(9) & Trim((RSC.Fields("txr_disabled1_nm").Value).ToString) & " " & .Fields("txr_disabled2_nm").Value.ToString & " " & .Fields("txr_disabled3_nm").Value.ToString & _
                                Chr(9) & DT3 & _
                            Chr(9) & Trim((RSC.Fields("txt_disabled").Value).ToString))

                    .MoveNext()
                End While

            End If
        End With

    End Sub
    Public Sub Lngs()


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


        BtnDel.Text = "ລຶບ"
        Button2.Text = "ເອີ້ນຄືນ"
        Button3.Text = "ເບິ່ງຂໍ້ມູນ"

        'Label1.Text = "ວັນທີ່:"
        Label2.Text = "ເຖິງ"

        Fg1.FormatString = "ລ/ດ |<ເລກບິນ       |<ເລກບິນ       |<ວັນທີ່       |<Refer no  |<ລະຫັດຜູ້ສະໜອງ |< ຊື່ ຜູ້ສະໜອງ    |>ຈໍານວນລ/ກ|>ເປັນເງິນ    |<ຜູ້ສົ່ງ             |<ຜູ້ຮັບ             |<  "

    End Sub




    Private Sub Fg1_MouseUpEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_MouseUpEvent) Handles Fg1.MouseUpEvent

        SaleID = Fg1.get_TextMatrix(Fg1.Row, 1)
        LoadData_Edit()

    End Sub

    Private Sub Fg1_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg1.SelChange

    End Sub
    Private Sub LoadData_Edit()
        MDEdit = True
        Dim rs As New ADODB.Recordset
        Dim aa As String
        With rs
            aa = "SELECT  * from AP_Persion_Health  WHERE 1=1  AND bill_no=N'" & Fg1.get_TextMatrix(Fg1.Row, 1) & "' and E_ID=N'" & Fg1.get_TextMatrix(Fg1.Row, 2) & "'  "
            Call LoadRs(aa, rs)
            If .RecordCount <> 0 Then
                If .Fields("txtBlood_ID").Value = 1 Then
                    chk_A.Checked = True
                ElseIf .Fields("txtBlood_ID").Value = 2 Then
                    chk_B.Checked = True
                ElseIf .Fields("txtBlood_ID").Value = 3 Then
                    chk_O.Checked = True
                Else
                    chk_AB.Checked = True
                End If

                txt_no.Text = (.Fields("bill_no").Value.ToString)
                txtid.Text = (.Fields("E_ID").Value.ToString)
                TxtPersonNmL.Text = (.Fields("Name_L").Value.ToString)
                txt_higth.Text = (.Fields("txt_higth").Value.ToString)

                If .Fields("txt_H1_id").Value = 1 Then
                    chk_H1.Checked = True
                Else
                    chk_H1.Checked = False
                End If
                If .Fields("txt_H2_id").Value = 1 Then
                    chk_H2.Checked = True
                Else
                    chk_H2.Checked = False
                End If
                If .Fields("txt_H3_id").Value = 1 Then
                    chk_H3.Checked = True
                Else
                    chk_H3.Checked = False
                End If
                If .Fields("txt_H4_id").Value = 1 Then
                    chk_H4.Checked = True
                Else
                    chk_H4.Checked = False
                End If

                If Trim(.Fields("DT_exhausted").Value.ToString) <> "" Then
                    DT_exhausted.Value = Trim(.Fields("DT_exhausted").Value.ToString)
                Else
                    DT_exhausted.Value = Today
                End If

                txt_exhausted.Text = (.Fields("txt_exhausted").Value.ToString)
                If (.Fields("DT_disease").Value.ToString) <> "" Then
                    DT_disease.Value = (.Fields("DT_disease").Value.ToString)
                Else
                    DT_disease.Value = Today
                End If

                txt_disease.Text = (.Fields("txt_disease").Value.ToString)

                If .Fields("chk_disabled_Type").Value = 1 Then
                    chk_disabled_Type.Checked = True
                Else
                    chk_disabled_Type.Checked = False
                End If
                If .Fields("chk_disabled1").Value = 1 Then
                    chk_disabled1.Checked = True
                Else
                    chk_disabled1.Checked = False
                End If
                If .Fields("chk_disabled2").Value = 1 Then
                    chk_disabled2.Checked = True
                Else
                    chk_disabled2.Checked = False
                End If
                If .Fields("chk_disabled3").Value = 1 Then
                    chk_disabled3.Checked = True
                Else
                    chk_disabled3.Checked = False
                End If
                If (.Fields("DT_disabled").Value.ToString) <> "" Then
                    DT_disabled.Value = (.Fields("DT_disabled").Value.ToString)
                Else
                    DT_disabled.Value = Today
                End If

                txt_disabled.Text = (.Fields("txt_disabled").Value.ToString)

            End If
        End With

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        MDEdit = False
        If txtid.Text = "" Or txt_no.Text = "" Then Exit Sub
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການ : " & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Persion_Health Where  bill_no='" & txt_no.Text & "' and E_id='" & txtid.Text & "'")

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

        '       With RSC
        '           Dim sa As String = " SELECT   dbo.AP_Brith_Data_List.*,AP_Books.Mobile1, dbo.AP_Books.Cust_nm,dbo.AP_Books.Vaccin_Check,AP_Books.Expect_Date, " & _
        '       "    dbo.AP_Province.PV_nm, dbo.AP_Village.Vl_nm, dbo.AP_District.Dt_nm, dbo.AP_LocationBk.Bk_nm, dbo.AP_Office.off_nm, dbo.AP_Office.Tel,  " & _
        '         "  dbo.AP_Office.com_logo " & _
        '                    " FROM         dbo.AP_Brith_Data_List INNER JOIN " & _
        '         "     dbo.AP_Books ON dbo.AP_Books.bill_no = dbo.AP_Brith_Data_List.Book_id INNER JOIN " & _
        '                 "    dbo.AP_Province ON dbo.AP_Books.PV_id = dbo.AP_Province.PV_ID INNER JOIN " & _
        '                 "    dbo.AP_Village ON dbo.AP_Books.Vl_Id = dbo.AP_Village.Vl_ID INNER JOIN " & _
        '                   "  dbo.AP_District ON dbo.AP_Books.Dt_ID = dbo.AP_District.Dt_id LEFT OUTER JOIN " & _
        '                   "  dbo.AP_LocationBk ON dbo.AP_Books.Book_id = dbo.AP_LocationBk.BK_ID CROSS JOIN " & _
        '"           dbo.AP_Office  WHERE 1=1     AND dbo.AP_Brith_Data_List.office='" & MDST & "' " & Shr_ALL & " order by AP_Brith_Data_List.Brith_no "
        '           Call LoadRs(sa, RSC)
        '           If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
        '           Dim Frm As New FrmPreview
        '           Dim Rpt As New Report_Birth_Data
        '           Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
        '           myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
        '           myTextObjectOnReport.Text = FrmAPInvioce.Label1.Text


        '           'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T1"), CrystalDecisions.CrystalReports.Engine.TextObject)
        '           'myTextObjectOnReport.Text = txtFdate.Value


        '           'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T2"), CrystalDecisions.CrystalReports.Engine.TextObject)
        '           'myTextObjectOnReport.Text = txtTdate.Value

        '           Rpt.SetDataSource(RSC)
        '           Rpt.Refresh()
        '           Frm.ReportViewer.ReportSource = Rpt
        '           Frm.ReportViewer.Zoom(100%)
        '           Frm.ReportViewer.DisplayGroupTree = False
        '           Frm.WindowState = FormWindowState.Maximized
        '           Frm.Show()
        '       End With
    End Sub

    Private Sub txtIn_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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



    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        If chk_date.Checked = True Then
            txtFdate.Enabled = True
            txtTdate.Enabled = True

            Sql = " AND AP_Persion_Health.DT_Finish between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Else
            txtFdate.Enabled = False
            txtTdate.Enabled = False
            Sql = ""
        End If
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click


        Call loaddata()

    End Sub






    Private Sub txtDoctor_Place_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtid.Text = ""
        txt_no.Text = ""
        TxtPersonNmL.Text = ""

        Sql = ""
        shr_section = ""
        shr_Department = ""
        shr_job_phuk = ""
        shr_job_lut = ""
        shr_type_in = ""
        shr_duties = ""
        shr_vsakan = ""
        Call loaddata()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_date.CheckedChanged
        If chk_date.Checked = True Then
            txtFdate.Enabled = True
            txtTdate.Enabled = True

            Sql = " AND AP_Persion_Health.DT_Finish between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Else
            txtFdate.Enabled = False
            txtTdate.Enabled = False
            Sql = ""
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





    Private Sub chk_department_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_department.CheckedChanged
        If chk_department.Checked = True Then
            cmb_Department.Items.Clear()
            Call load_Cmb("select DP_Name from Department", "DP_Name", cmb_Department)
            cmb_Department.SelectedIndex = 0
            shr_Department = " AND AP_CV.Department_id = N'" & txtdepart_ID.Text & "' "

        Else

            cmb_Department.Items.Clear()
            cmb_Department.Text = ""
            shr_Department = ""
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

    Private Sub chk_type_in_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_type_in.CheckedChanged
        If chk_type_in.Checked = True Then
            cmb_type_in.Items.Clear()
            Call load_Cmb("select In_nm from Type_In", "In_nm", cmb_type_in)
            cmb_type_in.SelectedIndex = 0
            shr_type_in = " AND AP_CV.type_in_id = N'" & txt_type_in_id.Text & "' "

        Else

            cmb_type_in.Items.Clear()
            shr_type_in = ""
            cmb_type_in.Text = ""
        End If
        Call loaddata()
    End Sub

    Private Sub cmb_type_in_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type_in.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Type_In Where  In_nm=N'" & Trim(cmb_type_in.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_type_in_id.Text = Trim(RSC("In_ID").Value)
            shr_type_in = " AND AP_CV.type_in_id = N'" & txt_type_in_id.Text & "' "
        End If
        Call loaddata()
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Sql = ""
        shr_section = ""
        shr_Department = ""
        shr_job_phuk = ""
        shr_job_lut = ""
        shr_type_in = ""
        shr_duties = ""
        shr_vsakan = ""
        G.Visible = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        G.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtid.Text = "" And txt_no.Text = "" Then Exit Sub
        If txt_no.Text = "" Or MDEdit = False Then
            AutoNumber()
        End If

        Save()
        E_ID = " and AP_Persion_Health.E_ID=N'" & txtid.Text & "'"
        loaddata_one()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
    End Sub
    Private Sub Save()

        Dim rs As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT * FROM  AP_Persion_Health WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO   AP_Persion_Health ( bill_no, E_ID, Name_L, txt_higth, txtBlood_ID, txtBlood_nm,  " & _
                  " txt_H1_id, txt_H1_nm, txt_H2_id, txt_H2_nm, txt_H3_id, txt_H3_nm, txt_H4_id, txt_H4_nm,lst_updt, lst_usr, Pc_nm) " & _
               " VALUES(N'" & (txt_no.Text) & "'," & _
                 " N'" & (txtid.Text) & "'," & _
                     " N'" & (TxtPersonNmL.Text) & "'," & _
                       " " & CDbl(txt_higth.Text) & "," & _
                         " N'" & (txtBlood_ID.Text) & "'," & _
                             " N'" & (txtBlood_nm.Text) & "'," & _
                           " N'" & (txt_H1_id.Text) & "'," & _
                              " N'" & (txt_H1_nm.Text) & "'," & _
                                  " N'" & (txt_H2_id.Text) & "'," & _
                              " N'" & (txt_H2_nm.Text) & "'," & _
                                  " N'" & (txt_H3_id.Text) & "'," & _
                              " N'" & (txt_H3_nm.Text) & "'," & _
                                  " N'" & (txt_H4_id.Text) & "'," & _
                              " N'" & (txt_H4_nm.Text) & "'," & _
                                           " Getdate()," & _
                               " N'" & MUserName & "'," & _
                            " '" & MDServerName & "')"
                Conn.Execute(aa)
            Else
                Conn.Execute("delete from   AP_Persion_Health WHERE  Bill_no= '" & (txt_no.Text) & "' and  E_ID= '" & (txtid.Text) & "'")
                Dim aa As String
                aa = "INSERT INTO   AP_Persion_Health ( bill_no, E_ID, Name_L, txt_higth, txtBlood_ID, txtBlood_nm,  " & _
                  " txt_H1_id, txt_H1_nm, txt_H2_id, txt_H2_nm, txt_H3_id, txt_H3_nm, txt_H4_id, txt_H4_nm,lst_updt, lst_usr, Pc_nm) " & _
               " VALUES(N'" & (txt_no.Text) & "'," & _
                 " N'" & (txtid.Text) & "'," & _
                     " N'" & (TxtPersonNmL.Text) & "'," & _
                           " " & CDbl(txt_higth.Text) & "," & _
                         " N'" & (txtBlood_ID.Text) & "'," & _
                             " N'" & (txtBlood_nm.Text) & "'," & _
                           " N'" & (txt_H1_id.Text) & "'," & _
                              " N'" & (txt_H1_nm.Text) & "'," & _
                                  " N'" & (txt_H2_id.Text) & "'," & _
                              " N'" & (txt_H2_nm.Text) & "'," & _
                                  " N'" & (txt_H3_id.Text) & "'," & _
                              " N'" & (txt_H3_nm.Text) & "'," & _
                                  " N'" & (txt_H4_id.Text) & "'," & _
                              " N'" & (txt_H4_nm.Text) & "'," & _
                                           " Getdate()," & _
                               " N'" & MUserName & "'," & _
                            " '" & MDServerName & "')"
                Conn.Execute(aa)
            End If
        End With


        If chk_H3.Checked = True Then
            Conn.Execute(" UPDATE  AP_Persion_Health SET " & _
                     " DT_exhausted= '" & Format(DT_exhausted.Value, "yyyy-MM-dd") & "'," & _
                           " txt_exhausted=N'" & txt_exhausted.Text & "'" & _
                                  " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        Else
            Conn.Execute(" UPDATE AP_Persion_Health SET " & _
                      " DT_exhausted=NULL, " & _
             " txt_exhausted=NULL " & _
                               " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If

        If chk_H4.Checked = True Then
            Conn.Execute(" UPDATE  AP_Persion_Health SET " & _
                     " DT_disease= '" & Format(DT_disease.Value, "yyyy-MM-dd") & "'," & _
                           " txt_disease=N'" & txt_disease.Text & "'" & _
                                  " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        Else
            Conn.Execute(" UPDATE AP_Persion_Health SET " & _
                      " DT_disease=NULL, " & _
             " txt_disease=NULL " & _
                               " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If



        If chk_disabled_Type.Checked = True Then
            Conn.Execute(" UPDATE  AP_Persion_Health SET " & _
                        " chk_disabled_Type=1, " & _
                              " DT_disabled= '" & Format(DT_disabled.Value, "yyyy-MM-dd") & "'," & _
                                  " txt_disabled=N'" & txt_disabled.Text & "'" & _
                                  " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
            If chk_disabled1.Checked = True Then
                Conn.Execute(" UPDATE  AP_Persion_Health SET " & _
                           " chk_disabled1=1,txr_disabled1_nm=N'ປະເພດ1' WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
            End If
            If chk_disabled2.Checked = True Then

                Conn.Execute(" UPDATE  AP_Persion_Health SET " & _
                   " chk_disabled2=1 ,txr_disabled2_nm=N'ປະເພດ2'  WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
            End If
            If chk_disabled3.Checked = True Then
                Conn.Execute(" UPDATE  AP_Persion_Health SET " & _
                          " chk_disabled3=1 ,txr_disabled3_nm=N'ປະເພດ3'  WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
            End If
        Else
            Conn.Execute(" UPDATE AP_Persion_Health SET " & _
                         " chk_disabled_Type=0, " & _
                           " chk_disabled1=0, " & _
                             " chk_disabled2=0, " & _
                               " chk_disabled3=0, " & _
                               " txr_disabled1_nm=NULL, " & _
                                 " txr_disabled2_nm=NULL, " & _
                                  " txr_disabled3_nm=NULL, " & _
                      " DT_disease=NULL, " & _
                 " txt_disease=NULL " & _
             " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If


    End Sub

    Private Sub loaddata_one()
        Fg1.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT    AP_Persion_Health.*,AP_CV.Sections,AP_CV.Department  " & _
                   "   FROM         AP_Persion_Health INNER JOIN " & _
                   "   AP_CV ON AP_Persion_Health.E_ID = AP_CV.E_ID    where 1=1 " & E_ID & "    ORDER BY AP_Persion_Health.E_id "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Dim DT1, DT2, DT3, H1, H2, H3, H4 As String
                    If .Fields("txt_H3_id").Value.ToString = 1 Then
                        DT1 = Format(CDate(RSC.Fields("DT_exhausted").Value), "yyyy")
                    Else
                        DT1 = ""
                    End If
                    If .Fields("txt_H4_id").Value.ToString = 1 Then
                        DT2 = Format(CDate(RSC.Fields("DT_disease").Value), "yyyy")
                    Else
                        DT2 = ""
                    End If
                    If .Fields("chk_disabled_Type").Value.ToString = 1 Then
                        DT3 = Format(CDate(RSC.Fields("DT_disabled").Value), "yyyy")
                    Else
                        DT3 = ""
                    End If
                    If .Fields("txt_H1_nm").Value.ToString <> "NULL" Then
                        H1 = Trim((RSC.Fields("txt_H1_nm").Value).ToString)
                    Else
                        H1 = ""
                    End If
                    If .Fields("txt_H2_nm").Value.ToString <> "NULL" Then
                        H2 = Trim((RSC.Fields("txt_H2_nm").Value).ToString)
                    Else
                        H2 = ""
                    End If
                    If .Fields("txt_H3_nm").Value.ToString <> "NULL" Then
                        H3 = Trim((RSC.Fields("txt_H3_nm").Value).ToString)
                    Else
                        H3 = ""
                    End If
                    If .Fields("txt_H4_nm").Value.ToString <> "NULL" Then
                        H4 = Trim((RSC.Fields("txt_H3_nm").Value).ToString)
                    Else
                        H4 = ""
                    End If
                    Fg1.AddItem(.AbsolutePosition & _
                           Chr(9) & Trim((RSC.Fields("Bill_no").Value).ToString) & _
                                   Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                                       Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("Sections").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("Department").Value).ToString) & _
                                Chr(9) & Trim(RSC.Fields("txt_higth").Value) & " Cm" & _
                                     Chr(9) & Trim((RSC.Fields("txtBlood_nm").Value).ToString) & _
                                      Chr(9) & H1 & " " & H2 & " " & H3 & " " & H4 & _
                                         Chr(9) & DT1 & _
                                          Chr(9) & Trim((RSC.Fields("txt_exhausted").Value).ToString) & _
                                              Chr(9) & DT2 & _
                                          Chr(9) & Trim((RSC.Fields("txt_disease").Value).ToString) & _
                                   Chr(9) & Trim((RSC.Fields("txr_disabled1_nm").Value).ToString) & " " & .Fields("txr_disabled2_nm").Value.ToString & " " & .Fields("txr_disabled3_nm").Value.ToString & _
                                Chr(9) & DT3 & _
                            Chr(9) & Trim((RSC.Fields("txt_disabled").Value).ToString))

                    .MoveNext()
                End While

            End If
        End With

    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FrmCustomer_item.ShowDialog()
        If MDCusID = "" Then Exit Sub
        MDCusID = " AND AP_CV.E_ID=N'" & CustID & "'"
        LoadData_CV()

        E_ID = " and AP_Persion_Health.E_ID=N'" & txtid.Text & "'"
        loaddata_one()
        If MDEdit = False Then
            AutoNumber()
        End If

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
                    "   AP_Province AS AP_Province_1 ON AP_District_1.PV_id = AP_Province_1.PV_ID WHERE 1=1 " & MDCusID & " "
            Call LoadRs(aa, rs)
            If .RecordCount <> 0 Then
                txtid.Text = (.Fields("E_ID").Value.ToString)
                TxtPersonNmL.Text = (.Fields("Name_L").Value.ToString)


            End If
        End With

    End Sub

    Private Sub Badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badd.Click
        MDEdit = False
        addnew()
    End Sub
    Private Sub addnew()
        txt_higth.Text = 0
        txtid.Text = ""
        txt_no.Text = ""
        TxtPersonNmL.Text = ""
     
        DT_exhausted.Value = Today
        chk_A.Checked = True

    End Sub
    Private Sub chk_job_lut2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_lang2.CheckedChanged
        If chk_lang2.Checked = True Then
            cmb_disabled.Items.Add("ທັງໝົດ")
            cmb_lang2.Items.Clear()
            Call load_Cmb("select lut_id,lut_nm from lut", "lut_nm", cmb_lang2)
            cmb_lang2.SelectedIndex = 0
            shr_job_lut = " AND AP_Position.chk_job_lut =1"

        Else
            cmb_lang2.Items.Clear()
            cmb_lang2.Text = ""
            shr_job_lut = ""
        End If
    End Sub

    Private Sub cmb_job_lut2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_lang2.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From lut Where  lut_nm=N'" & Trim(cmb_lang2.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_Nation_id2.Text = Trim(RSC("lut_id").Value)
        End If
        If cmb_lang2.SelectedIndex = 0 Then
            shr_job_lut = " AND AP_Position.chk_job_lut =1"
        Else
            shr_job_lut = " AND AP_Position.job_lut_ID = N'" & txt_Nation_id2.Text & "' "
        End If
    End Sub

    Private Sub chk_job_lut_visakan2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Nation.CheckedChanged
        If chk_Nation.Checked = True Then

            'cmb_job_lut_visakan2.Items.Clear()
            'cmb_job_lut_visakan2.Items.Add("ທັງໝົດ")
            cmb_Nation2.Text = "ວິຊາການ"
            shr_vsakan = " AND AP_Position.chk_job_lut_visakan =1"
        Else
            cmb_Nation2.Items.Clear()
            cmb_Nation2.Text = ""
            shr_vsakan = ""
        End If
    End Sub

    Private Sub chk_year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_year.CheckedChanged
        If chk_year.Checked = True Then
            DT_year.Enabled = True
            Sql = " and    year(AP_Persion_Study.DT_Finish) ='" & Year(DT_year.Value) & "' "
        Else
            DT_year.Enabled = False
            Sql = ""
        End If

    End Sub

    Private Sub DT_year_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_year.ValueChanged

        Sql = " and    year(AP_Persion_Study.DT_Finish) ='" & Year(DT_year.Value) & "' "

    End Sub



    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBlood_ID2.TextChanged

    End Sub

    Private Sub cmb_job_lut_visakan2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Nation2.SelectedIndexChanged

    End Sub

    Private Sub txtFdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFdate.ValueChanged
        If chk_date.Checked = True Then
            txtFdate.Enabled = True
            txtTdate.Enabled = True

            Sql = " AND AP_Persion_Study.DT_Finish between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Else
            txtFdate.Enabled = False
            txtTdate.Enabled = False
            Sql = ""
        End If
    End Sub

    Private Sub Button91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub chk_A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_A.CheckedChanged
        If chk_A.Checked = True Then
            txtBlood_ID.Text = 1
            txtBlood_nm.Text = chk_A.Text
        End If
    End Sub

    Private Sub chk_B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_B.CheckedChanged
        If chk_B.Checked = True Then
            txtBlood_ID.Text = 2
            txtBlood_nm.Text = chk_B.Text
        End If
    End Sub

    Private Sub chk_O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_O.CheckedChanged
        If chk_O.Checked = True Then
            txtBlood_ID.Text = 3
            txtBlood_nm.Text = chk_O.Text
        End If
    End Sub

    Private Sub chk_AB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AB.CheckedChanged
        If chk_AB.Checked = True Then
            txtBlood_ID.Text = 4
            txtBlood_nm.Text = chk_AB.Text
        End If
    End Sub

    Private Sub chk_H1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_H1.CheckedChanged
        If chk_H1.Checked = True Then
            txt_H1_id.Text = 1
            txt_H1_nm.Text = chk_H1.Text
        Else
            txt_H1_id.Text = 0
            txt_H1_nm.Text = "NULL"
        End If
    End Sub

    Private Sub chk_H2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_H2.CheckedChanged
        If chk_H2.Checked = True Then
            txt_H2_id.Text = 1
            txt_H2_nm.Text = chk_H2.Text
        Else
            txt_H2_id.Text = 0
            txt_H2_nm.Text = "NULL"
        End If
    End Sub

    Private Sub chk_H3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_H3.CheckedChanged
        If chk_H3.Checked = True Then
            txt_H3_id.Text = 1
            txt_H3_nm.Text = chk_H3.Text
            DT_exhausted.Enabled = True
            txt_exhausted.Enabled = True
        Else
            txt_H3_id.Text = 0
            txt_H3_nm.Text = "NULL"
            txt_exhausted.Text = ""
            DT_exhausted.Enabled = False
            txt_exhausted.Enabled = False

        End If
    End Sub

    Private Sub chk_H4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_H4.CheckedChanged
        If chk_H4.Checked = True Then
            txt_H4_id.Text = 1
            txt_H4_nm.Text = chk_H4.Text
            DT_disease.Enabled = True
            txt_disease.Enabled = True
        Else
            txt_H4_id.Text = 0
            txt_H4_nm.Text = "NULL"
            txt_disease.Text = ""
            DT_disease.Enabled = False
            txt_disease.Enabled = False
        End If
    End Sub

    Private Sub chk_disabled_Type_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_disabled_Type.CheckedChanged
        If chk_disabled_Type.Checked = True Then
            chk_disabled1.Enabled = True
            chk_disabled2.Enabled = True
            chk_disabled3.Enabled = True
            DT_disabled.Enabled = True
            txt_disabled.Enabled = True
        Else
            chk_disabled1.Enabled = False
            chk_disabled2.Enabled = False
            chk_disabled3.Enabled = False
            DT_disabled.Enabled = False
            txt_disabled.Enabled = False

            chk_disabled1.Checked = False
            chk_disabled2.Checked = False
            chk_disabled3.Checked = False
            DT_disabled.Value = Today
            txt_disabled.Text = ""
        End If
    End Sub

    Private Sub chk_Blood_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Blood.CheckedChanged
        If chk_Blood.Checked = True Then
            cmb_Blood.SelectedIndex = 0
            shr_duties = ""
            'shr_duties = " AND AP_Persion_Health.txtBlood_ID = N'" & txtBlood_ID2.Text & "' "

        Else
            cmb_Blood.Text = ""
            shr_duties = ""
        End If
    End Sub

    Private Sub cmb_Blood_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Blood.SelectedIndexChanged
        If cmb_Blood.SelectedIndex = 0 Then
            shr_duties = ""
        ElseIf cmb_Blood.SelectedIndex = 1 Then
            txtBlood_ID2.Text = 1
            shr_duties = " AND AP_Persion_Health.txtBlood_ID = N'" & txtBlood_ID2.Text & "' "
        ElseIf cmb_Blood.SelectedIndex = 2 Then
            txtBlood_ID2.Text = 2
            shr_duties = " AND AP_Persion_Health.txtBlood_ID = N'" & txtBlood_ID2.Text & "' "
        ElseIf cmb_Blood.SelectedIndex = 3 Then
            txtBlood_ID2.Text = 3
            shr_duties = " AND AP_Persion_Health.txtBlood_ID = N'" & txtBlood_ID2.Text & "' "
        ElseIf cmb_Blood.SelectedIndex = 4 Then
            txtBlood_ID2.Text = 4
            shr_duties = " AND AP_Persion_Health.txtBlood_ID = N'" & txtBlood_ID2.Text & "' "
        End If

    End Sub

    Private Sub chk_disabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_disabled.CheckedChanged
        If chk_disabled.Checked = True Then
            cmb_disabled.SelectedIndex = 0
            shr_job_phuk = " AND  AP_Persion_Health.chk_disabled_Type = N'" & txtdisabled_id.Text & "' "

        Else
            cmb_disabled.Text = ""
            shr_job_phuk = ""
        End If
    End Sub

    Private Sub cmb_disabled_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_disabled.SelectedIndexChanged
        txtdisabled_id.Text = 1
        If cmb_disabled.SelectedIndex = 0 Then
            shr_job_phuk = " AND  AP_Persion_Health.chk_disabled_Type = N'" & txtdisabled_id.Text & "' "
        ElseIf cmb_disabled.SelectedIndex = 1 Then
            shr_job_phuk = " AND  AP_Persion_Health.chk_disabled1 = N'" & txtdisabled_id.Text & "' "
        ElseIf cmb_disabled.SelectedIndex = 2 Then
            shr_job_phuk = " AND  AP_Persion_Health.chk_disabled2 = N'" & txtdisabled_id.Text & "' "
        ElseIf cmb_disabled.SelectedIndex = 3 Then
            shr_job_phuk = " AND  AP_Persion_Health.chk_disabled3 = N'" & txtdisabled_id.Text & "' "
        End If
    End Sub
End Class