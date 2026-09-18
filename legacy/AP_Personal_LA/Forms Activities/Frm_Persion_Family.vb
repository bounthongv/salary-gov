Public Class Frm_Persion_Family
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
    Private Sub Frm_Persion_Family_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        loadCMB()

        Fg1.FormatString = "ລ/ດ |<ລະຫັດ  |<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ ພະນັກງານ   |<ຊື່ ແລະ ນາມສະກຸນ ຄົນໃນຄອບຄົວ |<ສາຍພົວພັນ |^ວັນ,ເດືອນ,ປີເກີດ|<ທີ່ຢູ່ປັດຈຸບັນ ບ້ານ |<ເມືອງ           |<ແຂວງ            |<ອາຊີບຫຼັງປົດປ່ອຍ |<ຕຳແໜ່ງ  |<ບ່ອນເຮັດວຽກ   |<ອາຊີບກ່ອນປົດປ່ອຍ |<ຕຳແໜ່ງ  |<ບ່ອນເຮັດວຽກ   |<ໄດ້ເຂົ້າຮ່ວມການຈັດຕັ້ງການເມືອງ, ສັງຄົມ, ສຳນັກງານຢູ່ໃສ, ແຕ່ປີໃດຫາປີໃດ?"
        Fg1.set_ColHidden(1, True)
        Sql = ""
        'Sql = " AND AP_Check.Bill_Dt between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'   "
        'P = 1

        If MDEdit = True Then

            Call loaddata_one()

            LoadData_CV()
            AutoNumber()
        Else
            Call loaddata()
        End If


    End Sub
    Private Sub loadCMB()
     

     

        CmbBProvince.Items.Clear()
        Call load_Cmb("select PV_nm from AP_Province", "PV_nm", CmbBProvince)
        CmbBProvince.SelectedIndex = 0

        CmbAProvince.Items.Clear()
        Call load_Cmb("select PV_nm from AP_Province", "PV_nm", CmbAProvince)
        CmbAProvince.SelectedIndex = 0

        cmb_Relation.Items.Clear()
        Call load_Cmb("select relation_nm from Relation", "relation_nm", cmb_Relation)
        cmb_Relation.SelectedIndex = 0
    End Sub

    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Bill_no from AP_Persion_Family    Order by bill_no DESC", VIOT)
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
            aa = "SELECT     AP_Persion_Family.*,AP_CV.Sections, AP_CV.Department, AP_Village.Vl_nm, AP_District.Dt_nm, AP_Province.PV_nm " & _
                   " FROM         AP_Persion_Family INNER JOIN " & _
                 "     AP_CV ON AP_Persion_Family.E_ID = AP_CV.E_ID INNER JOIN " & _
                  "    AP_Village ON AP_Persion_Family.txtA_VillID = AP_Village.Vl_ID INNER JOIN " & _
                  "    AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
                 "     AP_Province ON AP_District.PV_id = AP_Province.PV_ID   where 1=1   " & Sql & " " & _
                   " " & shr_section & " " & shr_Department & " " & shr_type_in & "  " & shr_duties & "  " & shr_job_phuk & "     ORDER BY AP_Persion_Family.bill_no "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                           Chr(9) & Trim((RSC.Fields("Bill_no").Value).ToString) & _
                                   Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                                       Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("txtname_relation").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("cmb_Relation").Value).ToString) & _
                                        Chr(9) & Format(CDate(RSC.Fields("DT_DOB").Value), "dd/MM/yyyy") & _
                                Chr(9) & Trim((RSC.Fields("Vl_nm").Value).ToString) & _
                                     Chr(9) & Trim((RSC.Fields("Dt_nm").Value).ToString) & _
                            Chr(9) & Trim((RSC.Fields("PV_nm").Value).ToString) & _
                            Chr(9) & Trim((RSC.Fields("txtJobBefore").Value).ToString) & _
                         Chr(9) & Trim((RSC.Fields("txtsection_JobBefore").Value).ToString) & _
                               Chr(9) & Trim((RSC.Fields("txtlocation_JobBefore").Value).ToString) & _
                             Chr(9) & Trim((RSC.Fields("txtJobAfter").Value).ToString) & _
                              Chr(9) & Trim((RSC.Fields("txtsection_JobAfter").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("txtlocation_JobAfter").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("txtDetil").Value).ToString))

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
            aa = " SELECT     AP_Persion_Family.*,  AP_CV.Sections, AP_CV.Department, AP_Village.Vl_nm, AP_District.Dt_nm, " & _
      " AP_Province.PV_nm, AP_Village_1.Vl_nm AS Vl_nm2, AP_District_1.Dt_nm AS Dt_nm2,  AP_Province_1.PV_nm AS PV_nm2 " & _
    " FROM         AP_Persion_Family INNER JOIN " & _
                  "    AP_CV ON AP_Persion_Family.E_ID = AP_CV.E_ID INNER JOIN " & _
                   "   AP_Village ON AP_Persion_Family.txtA_VillID = AP_Village.Vl_ID INNER JOIN " & _
                  "    AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
                  "    AP_Province ON AP_District.PV_id = AP_Province.PV_ID INNER JOIN " & _
                    "  AP_Village AS AP_Village_1 ON AP_Persion_Family.txtB_VillID = AP_Village_1.Vl_ID INNER JOIN " & _
                  "    AP_District AS AP_District_1 ON AP_Village_1.Dt_id = AP_District_1.Dt_id INNER JOIN " & _
                  "    AP_Province AS AP_Province_1 ON AP_District_1.PV_id = AP_Province_1.PV_ID  WHERE 1=1  AND AP_Persion_Family.bill_no=N'" & Fg1.get_TextMatrix(Fg1.Row, 1) & "' and AP_Persion_Family.E_ID=N'" & Fg1.get_TextMatrix(Fg1.Row, 2) & "'  "
            Call LoadRs(aa, rs)
            If .RecordCount <> 0 Then
                txt_no.Text = (.Fields("bill_no").Value.ToString)
                txtid.Text = (.Fields("E_ID").Value.ToString)
                TxtPersonNmL.Text = (.Fields("Name_L").Value.ToString)
                txtname_relation.Text = (.Fields("txtname_relation").Value.ToString)
                cmb_Relation.Text = (.Fields("cmb_Relation").Value.ToString)
                DT_DOB.Value = (.Fields("DT_DOB").Value.ToString)

                CmbBProvince.Text = (.Fields("PV_nm2").Value.ToString)
                CmbBDistrict.Text = (.Fields("Dt_nm2").Value.ToString)
                CmbBVillage.Text = (.Fields("Vl_nm2").Value.ToString)

                CmbAProvince.Text = (.Fields("PV_nm").Value.ToString)
                CmbADistrict.Text = (.Fields("Dt_nm").Value.ToString)
                CmbAVillage.Text = (.Fields("Vl_nm").Value.ToString)

                txtJobBefore.Text = (.Fields("txtJobBefore").Value.ToString)
                txtsection_JobBefore.Text = (.Fields("txtsection_JobBefore").Value.ToString)
                txtlocation_JobBefore.Text = (.Fields("txtlocation_JobBefore").Value.ToString)

                txtJobAfter.Text = (.Fields("txtJobAfter").Value.ToString)
                txtsection_JobAfter.Text = (.Fields("txtsection_JobAfter").Value.ToString)
                txtlocation_JobAfter.Text = (.Fields("txtlocation_JobAfter").Value.ToString)

                txtDetil.Text = (.Fields("txtDetil").Value.ToString)



            End If

        End With

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        MDEdit = False
        If txtid.Text = "" Or txt_no.Text = "" Then Exit Sub
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການ : " & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Persion_Family Where  bill_no='" & txt_no.Text & "' and E_id='" & txtid.Text & "'")

            Call loaddata()
        End If



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

            Sql = " AND AP_Persion_Study.DT_Finish between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
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

            Sql = " AND AP_Persion_Study.DT_Finish between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
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
        E_ID = " and AP_Persion_Family.E_ID=N'" & txtid.Text & "'"
        loaddata_one()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)


        AutoNumber()
        txtname_relation.Text = ""
        cmb_Relation.Text = ""
        CmbBProvince.SelectedIndex = 0
        CmbAProvince.SelectedIndex = 0
        DT_DOB.Value = Today
        txtJobBefore.Text = ""
        txtsection_JobBefore.Text = ""
        txtlocation_JobBefore.Text = ""
        txtJobAfter.Text = ""
        txtsection_JobAfter.Text = ""
        txtlocation_JobAfter.Text = ""

        txtDetil.Text = ""

    End Sub
    Private Sub Save()

        Dim rs As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT * FROM  AP_Persion_Family WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO   AP_Persion_Family ( bill_no, E_ID, Name_L, txtname_relation, txt_Relation_id, cmb_Relation, DT_DOB, txtB_VillID, txtA_VillID, txtJobBefore, txtsection_JobBefore, " & _
           "     txtlocation_JobBefore, txtJobAfter, txtsection_JobAfter, txtlocation_JobAfter, txtDetil, lst_updt,lst_usr,  Pc_nm) " & _
               " VALUES(N'" & (txt_no.Text) & "'," & _
                 " N'" & (txtid.Text) & "'," & _
                 " N'" & (TxtPersonNmL.Text) & "'," & _
                  " N'" & (txtname_relation.Text) & "'," & _
                 " N'" & (txt_Relation_id.Text) & "'," & _
                " N'" & (cmb_Relation.Text) & "'," & _
                " '" & Format(DT_DOB.Value, "yyyy-MM-dd") & "'," & _
               " N'" & (txtB_VillID.Text) & "'," & _
                   " N'" & (txtA_VillID.Text) & "'," & _
                " N'" & (txtJobBefore.Text) & "'," & _
               " N'" & (txtsection_JobBefore.Text) & "'," & _
               " N'" & (txtlocation_JobBefore.Text) & "'," & _
              " N'" & (txtJobAfter.Text) & "'," & _
              " N'" & (txtsection_JobAfter.Text) & "'," & _
                  " N'" & (txtlocation_JobAfter.Text) & "'," & _
                    " N'" & (txtDetil.Text) & "'," & _
                      " Getdate()," & _
                               " N'" & MUserName & "'," & _
                            " '" & MDServerName & "')"
                Conn.Execute(aa)
            Else
                Conn.Execute("delete from   AP_Persion_Family WHERE  Bill_no= '" & (txt_no.Text) & "' and  E_ID= '" & (txtid.Text) & "'")
                Dim aa As String
                aa = "INSERT INTO   AP_Persion_Family ( bill_no, E_ID, Name_L, txtname_relation, txt_Relation_id, cmb_Relation, DT_DOB, txtB_VillID, txtA_VillID, txtJobBefore, txtsection_JobBefore, " & _
          "     txtlocation_JobBefore, txtJobAfter, txtsection_JobAfter, txtlocation_JobAfter, txtDetil,lst_updt, lst_usr,  Pc_nm) " & _
              " VALUES(N'" & (txt_no.Text) & "'," & _
                " N'" & (txtid.Text) & "'," & _
                " N'" & (TxtPersonNmL.Text) & "'," & _
                 " N'" & (txtname_relation.Text) & "'," & _
                " N'" & (txt_Relation_id.Text) & "'," & _
               " N'" & (cmb_Relation.Text) & "'," & _
               " '" & Format(DT_DOB.Value, "yyyy-MM-dd") & "'," & _
              " N'" & (txtB_VillID.Text) & "'," & _
                  " N'" & (txtA_VillID.Text) & "'," & _
               " N'" & (txtJobBefore.Text) & "'," & _
              " N'" & (txtsection_JobBefore.Text) & "'," & _
              " N'" & (txtlocation_JobBefore.Text) & "'," & _
             " N'" & (txtJobAfter.Text) & "'," & _
             " N'" & (txtsection_JobAfter.Text) & "'," & _
                 " N'" & (txtlocation_JobAfter.Text) & "'," & _
                   " N'" & (txtDetil.Text) & "'," & _
                     " Getdate()," & _
                              " N'" & MUserName & "'," & _
                           " '" & MDServerName & "')"
                Conn.Execute(aa)
            End If
        End With

    End Sub

    Private Sub loaddata_one()
        Fg1.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT     AP_Persion_Family.*,AP_CV.Sections, AP_CV.Department, AP_Village.Vl_nm, AP_District.Dt_nm, AP_Province.PV_nm " & _
                  " FROM         AP_Persion_Family INNER JOIN " & _
                "     AP_CV ON AP_Persion_Family.E_ID = AP_CV.E_ID INNER JOIN " & _
                 "    AP_Village ON AP_Persion_Family.txtA_VillID = AP_Village.Vl_ID INNER JOIN " & _
                 "    AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
                "     AP_Province ON AP_District.PV_id = AP_Province.PV_ID where 1=1 " & E_ID & "    ORDER BY AP_Persion_Family.bill_no "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                         Chr(9) & Trim((RSC.Fields("Bill_no").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                                     Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                               Chr(9) & Trim((RSC.Fields("txtname_relation").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("cmb_Relation").Value).ToString) & _
                                      Chr(9) & Format(CDate(RSC.Fields("DT_DOB").Value), "dd/MM/yyyy") & _
                              Chr(9) & Trim((RSC.Fields("Vl_nm").Value).ToString) & _
                                   Chr(9) & Trim((RSC.Fields("Dt_nm").Value).ToString) & _
                          Chr(9) & Trim((RSC.Fields("PV_nm").Value).ToString) & _
                          Chr(9) & Trim((RSC.Fields("txtJobBefore").Value).ToString) & _
                       Chr(9) & Trim((RSC.Fields("txtsection_JobBefore").Value).ToString) & _
                             Chr(9) & Trim((RSC.Fields("txtlocation_JobBefore").Value).ToString) & _
                           Chr(9) & Trim((RSC.Fields("txtJobAfter").Value).ToString) & _
                            Chr(9) & Trim((RSC.Fields("txtsection_JobAfter").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("txtlocation_JobAfter").Value).ToString) & _
                              Chr(9) & Trim((RSC.Fields("txtDetil").Value).ToString))

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

        E_ID = " and AP_Persion_Family.E_ID=N'" & txtid.Text & "'"
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
        txtname_relation.Text = ""
        cmb_Relation.Text = ""
        CmbBProvince.SelectedIndex = 0
        CmbAProvince.SelectedIndex = 0
        DT_DOB.Value = Today
        txtJobBefore.Text = ""
        txtsection_JobBefore.Text = ""
        txtlocation_JobBefore.Text = ""
        txtJobAfter.Text = ""
        txtsection_JobAfter.Text = ""
        txtlocation_JobAfter.Text = ""

        txtDetil.Text = ""


    End Sub



    Private Sub chk_Job_Phuk2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_visa.CheckedChanged
        If chk_visa.Checked = True Then

            cmb_visa2.Items.Clear()

            Call load_Cmb("select Field_Name from Study_Field   ", "Field_Name", cmb_visa2)
            cmb_visa2.SelectedIndex = 0
            shr_job_phuk = " AND  AP_Persion_Study.txtvisa_id = N'" & txtvisa_id2.Text & "' "

        Else
            cmb_visa2.Items.Clear()
            cmb_visa2.Text = ""
            shr_job_phuk = ""
        End If
    End Sub

    Private Sub chk_job_lut2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_lang2.CheckedChanged
        If chk_lang2.Checked = True Then
            cmb_visa2.Items.Add("ທັງໝົດ")
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



 

    Private Sub cmb_visa2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_visa2.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Study_Field Where  Field_Name=N'" & Trim(cmb_visa2.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtvisa_id2.Text = Trim(RSC("Field_ID").Value)
            shr_job_phuk = " AND  AP_Persion_Study.txtvisa_id = N'" & txtvisa_id2.Text & "' "
        End If

    End Sub

   
 
    Private Sub CmbAProvince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAProvince.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Province Where  PV_nm=N'" & Trim(CmbAProvince.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtA_ProID.Text = Trim(RSC("PV_ID").Value)
        End If

        CmbADistrict.Items.Clear()
        Call load_Cmb(" Select * From AP_District  where PV_id =N'" & Trim(txtA_ProID.Text) & "'   ORDER BY Dt_id ", "Dt_nm", CmbADistrict)
        If CmbADistrict.Items.Count > 0 Then
            CmbADistrict.SelectedIndex = 0
        End If
    End Sub

  

    Private Sub CmbAVillage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAVillage.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Village Where  Vl_nm=N'" & Trim(CmbAVillage.Text) & "' and Dt_id =N'" & Trim(txtA_DistID.Text) & "'     ", RSC)
        If RSC.RecordCount > 0 Then
            txtA_VillID.Text = Trim(RSC("Vl_ID").Value)
        End If

    End Sub

    Private Sub CmbBProvince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBProvince.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Province Where  PV_nm=N'" & Trim(CmbBProvince.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtB_ProID.Text = Trim(RSC("PV_ID").Value)
        End If

        CmbBDistrict.Items.Clear()
        Call load_Cmb(" Select * From AP_District  where PV_id =N'" & Trim(txtB_ProID.Text) & "'   ORDER BY Dt_id ", "Dt_nm", CmbBDistrict)
        If CmbBDistrict.Items.Count > 0 Then
            CmbBDistrict.SelectedIndex = 0
        End If
    End Sub

    Private Sub CmbBDistrict_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBDistrict.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_District Where  Dt_nm=N'" & Trim(CmbBDistrict.Text) & "'  and PV_id =N'" & Trim(txtB_ProID.Text) & "'    ", RSC)
        If RSC.RecordCount > 0 Then
            txtB_DistID.Text = Trim(RSC("Dt_id").Value)
        End If

        CmbBVillage.Items.Clear()
        Call load_Cmb(" Select * From AP_Village  where Dt_id =N'" & Trim(txtB_DistID.Text) & "'   ORDER BY Vl_ID ", "Vl_nm", CmbBVillage)
        If CmbBVillage.Items.Count > 0 Then
            CmbBVillage.SelectedIndex = 0
        End If
    End Sub

    Private Sub CmbBVillage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBVillage.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Village Where  Vl_nm=N'" & Trim(CmbBVillage.Text) & "' and Dt_id =N'" & Trim(txtB_DistID.Text) & "'     ", RSC)
        If RSC.RecordCount > 0 Then
            txtB_VillID.Text = Trim(RSC("Vl_ID").Value)
        End If


    End Sub

    Private Sub cmb_Relation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Relation.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Relation Where  relation_nm=N'" & Trim(cmb_Relation.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_Relation_id.Text = Trim(RSC("relation_id").Value)
        End If
    End Sub

    Private Sub chk_Relation2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Relation2.CheckedChanged
        If chk_Relation2.Checked = True Then

            cmb_Relation2.Items.Clear()
            'cmb_duties2.Items.Add("ທັງໝົດ")

            Call load_Cmb("select relation_nm from Relation", "relation_nm", cmb_Relation2)
            cmb_Relation2.SelectedIndex = 0
            shr_duties = " AND AP_Persion_Family.txt_Relation_id = N'" & txt_Relation_id2.Text & "' "

        Else
            cmb_Relation2.Items.Clear()
            cmb_Relation2.Text = ""
            shr_duties = ""
        End If
    End Sub

    Private Sub cmb_Relation2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Relation2.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Relation Where  relation_nm=N'" & Trim(cmb_Relation2.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_Relation_id2.Text = Trim(RSC("relation_id").Value)
        End If
        shr_duties = " AND AP_Persion_Family.txt_Relation_id = N'" & txt_Relation_id2.Text & "' "

    End Sub

    Private Sub CmbADistrict_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbADistrict.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_District Where  Dt_nm=N'" & Trim(CmbADistrict.Text) & "'  and PV_id =N'" & Trim(txtA_ProID.Text) & "'    ", RSC)
        If RSC.RecordCount > 0 Then
            txtA_DistID.Text = Trim(RSC("Dt_id").Value)
        End If

        CmbAVillage.Items.Clear()
        Call load_Cmb(" Select * From AP_Village  where Dt_id =N'" & Trim(txtA_DistID.Text) & "'   ORDER BY Vl_ID ", "Vl_nm", CmbAVillage)
        If CmbAVillage.Items.Count > 0 Then
            CmbAVillage.SelectedIndex = 0
        End If
    End Sub
End Class