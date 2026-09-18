Public Class Frm_Organization
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
    Private Sub Frm_Organization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'cmb_duties.Items.Clear()
        'Call load_Cmb("select job_nm from job", "job_nm", cmb_duties)
        'cmb_duties.SelectedIndex = 0



        Fg1.FormatString = "ລ/ດ |<ລະຫັດ   |<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ  |^ສັງກັດລັດ ວັນທີ |<ເຮັດຫຍັງ       |<ຢູ່ໃສ          |^ເຂົ້າຮ່ວມການປະຕິວັດ ວັນທີ |<ເຮັດຫຍັງ       |<ຢູ່ໃສ       |^ເຂົ້າການປະຕິວັດ ວັນທີ |<ເຮັດຫຍັງ       |<ຢູ່ໃສ       |^ເຂົ້າພັກສຳຮອງ ວັນທີ|^ເຂົ້າພັກສົມບູນ ວັນທີ|^ເຂົ້າອົງການຊາວໜຸ່ມປປລາວ ວັນທີ|<ຢູ່ໃສ          |^ເຂົ້າອົງກຳມະບານລາວ ວັນທີ|<ຢູ່ໃສ        |^ເຂົ້າອົງການສະຫະພັນແມ່ຍິງລາວ ວັນທີ|<ຢູ່ໃສ          "
        Fg1.set_ColHidden(1, True)
        Sql = ""
        'Sql = " AND AP_Check.Bill_Dt between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'   "
        'P = 1
        If MDEdit = True Then

            Call loaddata_one()

            LoadData_CV()
        Else
            Call loaddata()
        End If


    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Bill_no from AP_Organization    Order by bill_no DESC", VIOT)
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
            aa = "SELECT    AP_Organization.*,AP_CV.Sections,AP_CV.Department " & _
                    "   FROM         AP_Organization INNER JOIN " & _
                    "   AP_CV ON AP_Organization.E_ID = AP_CV.E_ID     where 1=1   " & Sql & " " & _
                    " " & shr_section & " " & shr_Department & " " & shr_type_in & "  " & shr_job_phuk & " " & shr_job_lut & " " & shr_vsakan & "" & shr_duties & " " & shr_phuk_sumhong & "" & shr_phuk & "    ORDER BY  AP_Organization.E_ID "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    If .Fields("dt_Lut").Value.ToString <> "" Then
                        a = Format(CDate(RSC.Fields("dt_Lut").Value), "dd/MM/yyyy")
                    Else
                        a = ""
                    End If
                    If .Fields("Dt_In_Independence").Value.ToString <> "" Then
                        b = Format(CDate(RSC.Fields("Dt_In_Independence").Value), "dd/MM/yyyy")
                    Else
                        b = ""
                    End If
                    If .Fields("DT_IndependenceDate").Value.ToString <> "" Then
                        c = Format(CDate(RSC.Fields("DT_IndependenceDate").Value), "dd/MM/yyyy")
                    Else
                        c = ""
                    End If
                    If .Fields("Dt_Phuk_sumhong").Value.ToString <> "" Then
                        d = Format(CDate(RSC.Fields("Dt_Phuk_sumhong").Value), "dd/MM/yyyy")
                    Else
                        d = ""
                    End If

                    If .Fields("Dt_Phuk").Value.ToString <> "" Then
                        e = Format(CDate(RSC.Fields("Dt_Phuk").Value), "dd/MM/yyyy")
                    Else
                        e = ""
                    End If
                    If .Fields("DT_young").Value.ToString <> "" Then
                        f = Format(CDate(RSC.Fields("DT_young").Value), "dd/MM/yyyy")
                    Else
                        f = ""
                    End If
                    If .Fields("Dt_khummaban").Value.ToString <> "" Then
                        g = Format(CDate(RSC.Fields("Dt_khummaban").Value), "dd/MM/yyyy")
                    Else
                        g = ""
                    End If
                    If .Fields("Dt_woman").Value.ToString <> "" Then
                        g = Format(CDate(RSC.Fields("Dt_woman").Value), "dd/MM/yyyy")
                    Else
                        g = ""
                    End If

                    Fg1.AddItem(.AbsolutePosition & _
                           Chr(9) & Trim((RSC.Fields("Bill_no").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                           Chr(9) & a & _
                           Chr(9) & Trim((RSC.Fields("txtjob_In_lut").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("txtlocatoin_In_lut").Value).ToString) & _
                            Chr(9) & b & _
                           Chr(9) & Trim((RSC.Fields("txt_job_In_Independence").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("txtlocation_In_Independence").Value).ToString) & _
                           Chr(9) & c & _
                           Chr(9) & Trim((RSC.Fields("txtJob_Independence").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("txtlocation_Independence").Value).ToString) & _
                           Chr(9) & d & _
                           Chr(9) & e & _
                               Chr(9) & f & _
                            Chr(9) & Trim((RSC.Fields("txtlocation_young").Value).ToString) & _
                                   Chr(9) & g & _
                            Chr(9) & Trim((RSC.Fields("txtlocation_khummaban").Value).ToString) & _
                                   Chr(9) & h & _
                                   Chr(9) & Trim((RSC.Fields("txtlocationU_woman").Value).ToString))

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
            aa = "SELECT  * from AP_Organization  WHERE 1=1  AND E_ID=N'" & Fg1.get_TextMatrix(Fg1.Row, 2) & "' and bill_no=N'" & Fg1.get_TextMatrix(Fg1.Row, 1) & "'  "
            Call LoadRs(aa, rs)
            If .RecordCount <> 0 Then
                txt_no.Text = (.Fields("bill_no").Value.ToString)
                txtid.Text = (.Fields("E_ID").Value.ToString)
                TxtPersonNmL.Text = (.Fields("Name_L").Value.ToString)

                If .Fields("chk_lut").Value = 1 Then
                    chk_lut.Checked = True
                    dt_Lut.Value = (.Fields("dt_Lut").Value.ToString)
                    txtjob_In_lut.Text = (.Fields("txtjob_In_lut").Value.ToString)
                    txtlocatoin_In_lut.Text = (.Fields("txtlocatoin_In_lut").Value.ToString)
                Else
                    chk_lut.Checked = False
                    dt_Lut.Value = Today
                    txtjob_In_lut.Text = ""
                    txtlocatoin_In_lut.Text = ""
                End If
                If .Fields("chk_In_Independence").Value = 1 Then
                    chk_In_Independence.Checked = True
                    Dt_In_Independence.Value = (.Fields("Dt_In_Independence").Value.ToString)
                    txt_job_In_Independence.Text = (.Fields("txt_job_In_Independence").Value.ToString)
                    txtlocation_In_Independence.Text = (.Fields("txtlocation_In_Independence").Value.ToString)
                Else
                    chk_In_Independence.Checked = False
                    Dt_In_Independence.Value = Today
                    txt_job_In_Independence.Text = ""
                    txtlocation_In_Independence.Text = ""
                End If

                If .Fields("Chk_INreform").Value = 1 Then
                    Chk_INreform.Checked = True
                    DT_IndependenceDate.Value = (.Fields("DT_IndependenceDate").Value.ToString)
                    txtJob_Independence.Text = (.Fields("txtJob_Independence").Value.ToString)
                    txtlocation_Independence.Text = (.Fields("txtlocation_Independence").Value.ToString)
                Else
                    Chk_INreform.Checked = False
                    DT_IndependenceDate.Value = Today
                    txtJob_Independence.Text = ""
                    txtlocation_Independence.Text = ""
                End If

                If .Fields("chk_Phuk_sumhong").Value = 1 Then
                    chk_Phuk_sumhong.Checked = True
                    Dt_Phuk_sumhong.Value = (.Fields("Dt_Phuk_sumhong").Value.ToString)
                    txtthe_committee.Text = (.Fields("txtthe_committee").Value.ToString)
                    txtlocation.Text = (.Fields("txtlocation").Value.ToString)
                Else
                    chk_Phuk_sumhong.Checked = False
                    Dt_Phuk_sumhong.Value = Today
                    txtthe_committee.Text = ""
                    txtlocation.Text = ""
                End If
                If .Fields("chk_Phuk").Value = 1 Then
                    chk_Phuk.Checked = True
                    Dt_Phuk.Value = (.Fields("Dt_Phuk").Value.ToString)
                    txtthe_committee.Text = (.Fields("txtthe_committee").Value.ToString)
                    txtlocation.Text = (.Fields("txtlocation").Value.ToString)
                Else
                    chk_Phuk.Checked = False
                    Dt_Phuk.Value = Today
                    txtthe_committee.Text = ""
                    txtlocation.Text = ""
                End If
                If .Fields("Chk_young").Value = 1 Then
                    Chk_young.Checked = True
                    DT_young.Value = (.Fields("DT_young").Value.ToString)
                    txtlocation_young.Text = (.Fields("txtlocation_young").Value.ToString)

                Else
                    Chk_young.Checked = False
                    DT_young.Value = Today
                    txtlocation_young.Text = ""

                End If
                If .Fields("Chk_khummaban").Value = 1 Then
                    Chk_khummaban.Checked = True
                    Dt_khummaban.Value = (.Fields("Dt_khummaban").Value.ToString)
                    txtlocation_khummaban.Text = (.Fields("txtlocation_khummaban").Value.ToString)

                Else
                    Chk_khummaban.Checked = False
                    Dt_khummaban.Value = Today
                    txtlocation_khummaban.Text = ""

                End If

                If .Fields("Chk_woman").Value = 1 Then
                    Chk_woman.Checked = True
                    Dt_woman.Value = (.Fields("Dt_woman").Value.ToString)
                    txtlocationU_woman.Text = (.Fields("txtlocationU_woman").Value.ToString)

                Else
                    Chk_woman.Checked = False
                    Dt_woman.Value = Today
                    txtlocationU_woman.Text = ""

                End If
            End If

        End With

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        MDEdit = False
        If txtid.Text = "" Or txt_no.Text = "" Then Exit Sub
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການ : " & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Organization Where  bill_no='" & txt_no.Text & "' and E_id='" & txtid.Text & "'")

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

            Sql = " AND AP_Organization.dt_Lut between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Else
            txtFdate.Enabled = False
            txtTdate.Enabled = False
            Sql = ""
        End If
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'Sql = " AND AP_CV.DT_strt_work between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Call loaddata()
    End Sub






    Private Sub txtDoctor_Place_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtid.Text = ""
        txt_no.Text = ""
        TxtPersonNmL.Text = ""

        chk_lut.Checked = False
        dt_Lut.Value = Today
        txtjob_In_lut.Text = ""
        txtlocatoin_In_lut.Text = ""

        chk_In_Independence.Checked = False
        Dt_In_Independence.Value = Today
        txt_job_In_Independence.Text = ""
        txtlocation_In_Independence.Text = ""

        Chk_INreform.Checked = False
        DT_IndependenceDate.Value = Today
        txtJob_Independence.Text = ""
        txtlocation_Independence.Text = ""

        chk_Phuk_sumhong.Checked = False
        Dt_Phuk_sumhong.Value = Today
        txtthe_committee.Text = ""
        txtlocation.Text = ""
        chk_Phuk.Checked = False
        Dt_Phuk.Value = Today

        Chk_young.Checked = False
        DT_young.Value = Today
        txtlocation_young.Text = ""

        Chk_khummaban.Checked = False
        Dt_khummaban.Value = Today
        txtlocation_khummaban.Text = ""

        Chk_woman.Checked = False
        Dt_woman.Value = Today
        txtlocationU_woman.Text = ""

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

            Sql = " AND AP_Organization.dt_Lut between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
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
        Groub.Visible = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Groub.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtid.Text = "" And txt_no.Text = "" Then Exit Sub
        If txt_no.Text = "" Or MDEdit = False Then
            AutoNumber()
        End If
        Save()
        E_ID = " and AP_Organization.E_ID=N'" & txtid.Text & "'"
        loaddata_one()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
    End Sub
    Private Sub Save()

        Dim rs As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT * FROM  AP_Organization WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO   AP_Organization (  Bill_no, E_ID,Name_L, lst_updt, lst_usr, Pc_nm) " & _
               " VALUES(N'" & (txt_no.Text) & "'," & _
                 " N'" & (txtid.Text) & "'," & _
                     " N'" & (TxtPersonNmL.Text) & "'," & _
                                                " Getdate()," & _
                               " N'" & MUserName & "'," & _
                            " '" & MDServerName & "')"
                Conn.Execute(aa)
            Else
                Conn.Execute("delete from   AP_Organization WHERE  Bill_no= '" & (txt_no.Text) & "' and  E_ID= '" & (txtid.Text) & "'")
                Dim aa As String
                aa = "INSERT INTO   AP_Organization (  Bill_no, E_ID,Name_L,  lst_updt, lst_usr, Pc_nm) " & _
                " VALUES(N'" & (txt_no.Text) & "'," & _
                  " N'" & (txtid.Text) & "'," & _
                      " N'" & (TxtPersonNmL.Text) & "'," & _
                                    " Getdate()," & _
                                " N'" & MUserName & "'," & _
                             " '" & MDServerName & "')"
                Conn.Execute(aa)
            End If
        End With
        If chk_lut.Checked = True Then
            Conn.Execute(" UPDATE AP_Organization SET " & _
                     " chk_lut=1," & _
                        " dt_Lut=N'" & Format(dt_Lut.Value, "yyyy-MM-dd") & "'," & _
                 " txtjob_In_lut=N'" & txtjob_In_lut.Text & "'," & _
                       " txtlocatoin_In_lut=N'" & txtlocatoin_In_lut.Text & "'" & _
                     " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")

            Conn.Execute(" UPDATE AP_CV SET " & _
                             " chk_lut=1," & _
                         " dt_Lut=N'" & Format(dt_Lut.Value, "yyyy-MM-dd") & "'" & _
                             " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_Organization SET " & _
                      " chk_lut=0," & _
                          " dt_Lut=NULL," & _
                  " txtjob_In_lut=NULL," & _
                        " txtlocatoin_In_lut=NULL " & _
                             " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")


        End If

        If chk_In_Independence.Checked = True Then
            Conn.Execute(" UPDATE AP_Organization SET " & _
                     " chk_In_Independence=1," & _
                        " Dt_In_Independence=N'" & Format(Dt_In_Independence.Value, "yyyy-MM-dd") & "'," & _
                 " txt_job_In_Independence=N'" & txt_job_In_Independence.Text & "'," & _
                       " txtlocation_In_Independence=N'" & txtlocation_In_Independence.Text & "'" & _
                     " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        Else
            Conn.Execute(" UPDATE AP_Organization SET " & _
                      " chk_In_Independence=0," & _
                          " Dt_In_Independence=NULL," & _
                  " txt_job_In_Independence=NULL," & _
                        " txtlocation_In_Independence=NULL " & _
                             " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If

        If Chk_INreform.Checked = True Then
            Conn.Execute(" UPDATE AP_Organization SET " & _
                     " Chk_INreform=1," & _
                        " DT_IndependenceDate=N'" & Format(DT_IndependenceDate.Value, "yyyy-MM-dd") & "'," & _
                 " txtJob_Independence=N'" & txtJob_Independence.Text & "'," & _
                       " txtlocation_Independence=N'" & txtlocation_Independence.Text & "'" & _
                     " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        Else
            Conn.Execute(" UPDATE AP_Organization SET " & _
                      " Chk_INreform=0," & _
                          " DT_IndependenceDate=NULL," & _
                  " txtJob_Independence=NULL," & _
                        " txtlocation_Independence=NULL " & _
                             " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If

        If chk_Phuk_sumhong.Checked = True Then
            Conn.Execute(" UPDATE AP_Organization SET " & _
                     " chk_Phuk_sumhong=1," & _
                        " Dt_Phuk_sumhong=N'" & Format(Dt_Phuk_sumhong.Value, "yyyy-MM-dd") & "'," & _
                 " txtthe_committee=N'" & txtthe_committee.Text & "'," & _
                       " txtlocation=N'" & txtlocation.Text & "'" & _
                     " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")

            Conn.Execute(" UPDATE AP_CV SET " & _
                 " chk_Phuk_sumhong=1," & _
             " dt_Phuk_sumhong=N'" & Format(Dt_Phuk_sumhong.Value, "yyyy-MM-dd") & "'" & _
                 " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_Organization SET " & _
                      " chk_Phuk_sumhong=0," & _
                          " Dt_Phuk_sumhong=NULL," & _
                  " txtthe_committee=NULL," & _
                        " txtlocation=NULL " & _
                             " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If

        If chk_Phuk.Checked = True Then
            Conn.Execute(" UPDATE AP_Organization SET " & _
                     " chk_Phuk=1," & _
                        " Dt_Phuk=N'" & Format(Dt_Phuk.Value, "yyyy-MM-dd") & "'," & _
                 " txtthe_committee=N'" & txtthe_committee.Text & "'," & _
                       " txtlocation=N'" & txtlocation.Text & "'" & _
                     " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")

            Conn.Execute(" UPDATE AP_CV SET " & _
                               " chk_Phuk=1," & _
                           " dt_Phuk=N'" & Format(Dt_Phuk.Value, "yyyy-MM-dd") & "'" & _
                               " WHERE E_ID= '" & (txtid.Text) & "'")

        Else
            Conn.Execute(" UPDATE AP_Organization SET " & _
                      " chk_Phuk=0," & _
                          " Dt_Phuk=NULL," & _
                  " txtthe_committee=NULL," & _
                        " txtlocation=NULL " & _
                             " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If

        If Chk_young.Checked = True Then
            Conn.Execute(" UPDATE AP_Organization SET " & _
                     " Chk_young=1," & _
                        " DT_young=N'" & Format(DT_young.Value, "yyyy-MM-dd") & "'," & _
                       " txtlocation_young=N'" & txtlocation_young.Text & "'" & _
                     " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        Else
            Conn.Execute(" UPDATE AP_Organization SET " & _
                      " Chk_young=0," & _
                          " DT_young=NULL," & _
                        " txtlocation_young=NULL " & _
                             " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If

        If Chk_khummaban.Checked = True Then
            Conn.Execute(" UPDATE AP_Organization SET " & _
                     " Chk_khummaban=1," & _
                        " Dt_khummaban=N'" & Format(Dt_khummaban.Value, "yyyy-MM-dd") & "'," & _
                       " txtlocation_khummaban=N'" & txtlocation_khummaban.Text & "'" & _
                     " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        Else
            Conn.Execute(" UPDATE AP_Organization SET " & _
                      " Chk_khummaban=0," & _
                          " Dt_khummaban=NULL," & _
                        " txtlocation_khummaban=NULL " & _
                             " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If

        If Chk_woman.Checked = True Then
            Conn.Execute(" UPDATE AP_Organization SET " & _
                     " Chk_woman=1," & _
                        " Dt_woman=N'" & Format(Dt_woman.Value, "yyyy-MM-dd") & "'," & _
                       " txtlocationU_woman=N'" & txtlocation_khummaban.Text & "'" & _
                     " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        Else
            Conn.Execute(" UPDATE AP_Organization SET " & _
                      " Chk_woman=0," & _
                          " Dt_woman=NULL," & _
                        " txtlocationU_woman=NULL " & _
                             " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If

    End Sub

    Private Sub loaddata_one()
        Fg1.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT    AP_Organization.*,AP_CV.Sections,AP_CV.Department " & _
                   "   FROM         AP_Organization INNER JOIN " & _
                   "   AP_CV ON AP_Organization.E_ID = AP_CV.E_ID   where 1=1 " & E_ID & "    ORDER BY AP_Organization.E_ID "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    If .Fields("dt_Lut").Value.ToString <> "" Then
                        a = Format(CDate(RSC.Fields("dt_Lut").Value), "dd/MM/yyyy")
                    Else
                        a = ""
                    End If
                    If .Fields("Dt_In_Independence").Value.ToString <> "" Then
                        b = Format(CDate(RSC.Fields("Dt_In_Independence").Value), "dd/MM/yyyy")
                    Else
                        b = ""
                    End If
                    If .Fields("DT_IndependenceDate").Value.ToString <> "" Then
                        c = Format(CDate(RSC.Fields("DT_IndependenceDate").Value), "dd/MM/yyyy")
                    Else
                        c = ""
                    End If
                    If .Fields("Dt_Phuk_sumhong").Value.ToString <> "" Then
                        d = Format(CDate(RSC.Fields("Dt_Phuk_sumhong").Value), "dd/MM/yyyy")
                    Else
                        d = ""
                    End If

                    If .Fields("Dt_Phuk").Value.ToString <> "" Then
                        e = Format(CDate(RSC.Fields("Dt_Phuk").Value), "dd/MM/yyyy")
                    Else
                        e = ""
                    End If
                    If .Fields("DT_young").Value.ToString <> "" Then
                        f = Format(CDate(RSC.Fields("DT_young").Value), "dd/MM/yyyy")
                    Else
                        f = ""
                    End If
                    If .Fields("Dt_khummaban").Value.ToString <> "" Then
                        g = Format(CDate(RSC.Fields("Dt_khummaban").Value), "dd/MM/yyyy")
                    Else
                        g = ""
                    End If
                    If .Fields("Dt_woman").Value.ToString <> "" Then
                        g = Format(CDate(RSC.Fields("Dt_woman").Value), "dd/MM/yyyy")
                    Else
                        g = ""
                    End If

                    Fg1.AddItem(.AbsolutePosition & _
                           Chr(9) & Trim((RSC.Fields("Bill_no").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                           Chr(9) & a & _
                           Chr(9) & Trim((RSC.Fields("txtjob_In_lut").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("txtlocatoin_In_lut").Value).ToString) & _
                            Chr(9) & b & _
                           Chr(9) & Trim((RSC.Fields("txt_job_In_Independence").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("txtlocation_In_Independence").Value).ToString) & _
                           Chr(9) & c & _
                           Chr(9) & Trim((RSC.Fields("txtJob_Independence").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("txtlocation_Independence").Value).ToString) & _
                           Chr(9) & d & _
                           Chr(9) & e & _
                                   Chr(9) & f & _
                            Chr(9) & Trim((RSC.Fields("txtlocation_young").Value).ToString) & _
                                   Chr(9) & g & _
                            Chr(9) & Trim((RSC.Fields("txtlocation_khummaban").Value).ToString) & _
                                   Chr(9) & h & _
                                   Chr(9) & Trim((RSC.Fields("txtlocationU_woman").Value).ToString))

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

        E_ID = " and AP_Organization.E_ID=N'" & txtid.Text & "'"
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
        txtid.Text = ""
        txt_no.Text = ""
        TxtPersonNmL.Text = ""

        chk_lut.Checked = False
        dt_Lut.Value = Today
        txtjob_In_lut.Text = ""
        txtlocatoin_In_lut.Text = ""

        chk_In_Independence.Checked = False
        Dt_In_Independence.Value = Today
        txt_job_In_Independence.Text = ""
        txtlocation_In_Independence.Text = ""

        Chk_INreform.Checked = False
        DT_IndependenceDate.Value = Today
        txtJob_Independence.Text = ""
        txtlocation_Independence.Text = ""

        chk_Phuk_sumhong.Checked = False
        Dt_Phuk_sumhong.Value = Today
        txtthe_committee.Text = ""
        txtlocation.Text = ""
        chk_Phuk.Checked = False
        Dt_Phuk.Value = Today

        Chk_young.Checked = False
        DT_young.Value = Today
        txtlocation_young.Text = ""

        Chk_khummaban.Checked = False
        Dt_khummaban.Value = Today
        txtlocation_khummaban.Text = ""

        Chk_woman.Checked = False
        Dt_woman.Value = Today
        txtlocationU_woman.Text = ""
    End Sub

    Private Sub chk_duties_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_duties.CheckedChanged
        If chk_duties.Checked = True Then

            cmb_duties2.Items.Clear()
            'cmb_duties2.Items.Add("ທັງໝົດ")
            Call load_Cmb("select job_nm from job", "job_nm", cmb_duties2)
            cmb_duties2.SelectedIndex = 0
            shr_duties = ""

        Else
            cmb_duties2.Items.Clear()
            cmb_duties2.Text = ""
            shr_duties = ""
        End If

    End Sub

    Private Sub chk_Job_Phuk2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Job_Phuk2.CheckedChanged
        If chk_Job_Phuk2.Checked = True Then

            cmb_job_phuk2.Items.Clear()
            cmb_job_phuk2.Items.Add("ທັງໝົດ")
            Call load_Cmb("select phuk_id,Phuk_nm from Phuk", "Phuk_nm", cmb_job_phuk2)
            cmb_job_phuk2.SelectedIndex = 0
            shr_job_phuk = " AND AP_CV.chk_Job_Phuk =1"

        Else
            cmb_job_phuk2.Items.Clear()
            cmb_job_phuk2.Text = ""
            shr_job_phuk = ""
        End If
    End Sub

    Private Sub cmb_job_phuk2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_phuk2.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Phuk Where  Phuk_nm=N'" & Trim(cmb_job_phuk2.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_phuk_id2.Text = Trim(RSC("phuk_id").Value)
            shr_job_phuk = " AND AP_CV.job_phuk_ID = N'" & txt_job_phuk_id2.Text & "' "
        End If

        If cmb_job_phuk2.SelectedIndex = 0 Then
            shr_job_phuk = " AND AP_CV.chk_Job_Phuk =1"
        Else
            shr_job_phuk = " AND AP_CV.job_phuk_ID = N'" & txt_job_phuk_id2.Text & "' "
        End If
    End Sub

    Private Sub chk_job_lut2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_job_lut2.CheckedChanged
        If chk_job_lut2.Checked = True Then
            cmb_job_phuk2.Items.Add("ທັງໝົດ")
            cmb_job_lut2.Items.Clear()
            Call load_Cmb("select lut_id,lut_nm from lut", "lut_nm", cmb_job_lut2)
            cmb_job_lut2.SelectedIndex = 0
            shr_job_lut = " AND AP_CV.chk_job_lut =1"

        Else
            cmb_job_lut2.Items.Clear()
            cmb_job_lut2.Text = ""
            shr_job_lut = ""
        End If
    End Sub

    Private Sub cmb_job_lut2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_lut2.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From lut Where  lut_nm=N'" & Trim(cmb_job_lut2.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_lut_id2.Text = Trim(RSC("lut_id").Value)
        End If
        If cmb_job_lut2.SelectedIndex = 0 Then
            shr_job_lut = " AND AP_CV.chk_job_lut =1"
        Else
            shr_job_lut = " AND AP_CV.job_lut_ID = N'" & txt_job_lut_id2.Text & "' "
        End If
    End Sub

    Private Sub chk_job_lut_visakan2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_job_lut_visakan2.CheckedChanged
        If chk_job_lut_visakan2.Checked = True Then

            'cmb_job_lut_visakan2.Items.Clear()
            'cmb_job_lut_visakan2.Items.Add("ທັງໝົດ")
            cmb_job_lut_visakan2.Text = "ວິຊາການ"
            shr_vsakan = " AND AP_CV.chk_job_lut_visakan =1"
        Else
            cmb_job_lut_visakan2.Items.Clear()
            cmb_job_lut_visakan2.Text = ""
            shr_vsakan = ""
        End If
    End Sub

    Private Sub chk_year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_year.CheckedChanged
        If chk_year.Checked = True Then
            DT_year.Enabled = True
            Sql = " and    year(AP_Organization.dt_Lut) ='" & Year(DT_year.Value) & "' "
        Else
            DT_year.Enabled = False
            Sql = ""
        End If

    End Sub

    Private Sub DT_year_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_year.ValueChanged
        If chk_year.Checked = True Then
            DT_year.Enabled = True
            Sql = " and    year(AP_Organization.dt_Lut) ='" & Year(DT_year.Value) & "' "
        Else
            DT_year.Enabled = False
            Sql = ""
        End If


    End Sub

    Private Sub cmb_duties2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_duties2.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From job Where  job_nm=N'" & Trim(cmb_duties2.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_duties_id2.Text = Trim(RSC("job_id").Value)
        End If
        shr_duties = " AND AP_CV.duties_Id = N'" & txt_duties_id2.Text & "' "

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_duties_id2.TextChanged

    End Sub

    Private Sub cmb_job_lut_visakan2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_lut_visakan2.SelectedIndexChanged

    End Sub

 
    Private Sub txt_job_In_Independence_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_job_In_Independence.TextChanged

    End Sub

    Private Sub txtFdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFdate.ValueChanged
        If chk_date.Checked = True Then
            txtFdate.Enabled = True
            txtTdate.Enabled = True

            Sql = " AND AP_Organization.dt_Lut between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Else
            txtFdate.Enabled = False
            txtTdate.Enabled = False
            Sql = ""
        End If
    End Sub

    Private Sub chk_puk_sumhong_year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_puk_sumhong_year.CheckedChanged
        If chk_puk_sumhong_year.Checked = True Then
            dt_puk_sumhong_year.Enabled = True
            shr_phuk_sumhong = " and    year(AP_Organization.Dt_Phuk_sumhong) ='" & Year(dt_puk_sumhong_year.Value) & "' "
        Else
            dt_puk_sumhong_year.Enabled = False
            shr_phuk_sumhong = ""
        End If
    End Sub

    Private Sub dt_puk_sumhong_year_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_puk_sumhong_year.ValueChanged
        If chk_puk_sumhong_year.Checked = True Then
            dt_puk_sumhong_year.Enabled = True
            shr_phuk_sumhong = " and    year(AP_Organization.Dt_Phuk_sumhong) ='" & Year(dt_puk_sumhong_year.Value) & "' "
        Else
            dt_puk_sumhong_year.Enabled = False
            shr_phuk_sumhong = ""
        End If
    End Sub

    Private Sub chk_puk_year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_puk_year.CheckedChanged
        If chk_puk_year.Checked = True Then
            dt_puk_year.Enabled = True
            shr_phuk_sumhong = " and    year(AP_Organization.Dt_Phuk) ='" & Year(dt_puk_year.Value) & "' "
        Else
            dt_puk_year.Enabled = False
            shr_phuk_sumhong = ""
        End If
    End Sub

    Private Sub dt_puk_year_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_puk_year.ValueChanged
        If chk_puk_year.Checked = True Then
            dt_puk_year.Enabled = True
            shr_phuk_sumhong = " and    year(AP_Organization.Dt_Phuk) ='" & Year(dt_puk_year.Value) & "' "
        Else
            dt_puk_year.Enabled = False
            shr_phuk_sumhong = ""
        End If
    End Sub
End Class