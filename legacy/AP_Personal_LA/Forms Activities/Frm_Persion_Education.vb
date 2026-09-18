Public Class Frm_Persion_Education
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
    Private Sub Frm_Persion_Education_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_Nation.Items.Clear()
        Call load_Cmb("select NationNmL from Nationall", "NationNmL", cmb_Nation)
        cmb_Nation.SelectedIndex = 0

        Fg1.FormatString = "ລ/ດ |<ລະຫັດ  |<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ      |<ບ່ອນປະຈຳການ   |<ພະແນກ    |<ລະດັບການສຶກສາ  |<ຂະແໜ່ງວິຊາຮຽນ |<ສຶກສາທີ່ປະເທດ |^ປີຈົບ    |<ພາສາຕ່າງປະເທດ|<ໝາຍເຫດ          "
        Fg1.set_ColHidden(1, True)
        Sql = ""
        'Sql = " AND AP_Check.Bill_Dt between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'   "
        'P = 1
        RadioButton1.Checked = True
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
        Call LoadRs("SELECT top 1 Bill_no from AP_Persion_Study    Order by bill_no DESC", VIOT)
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
            aa = "SELECT    AP_Persion_Study.*,AP_CV.Sections,AP_CV.Department  " & _
                   "   FROM         AP_Persion_Study INNER JOIN " & _
                   "   AP_CV ON AP_Persion_Study.E_ID = AP_CV.E_ID   where 1=1   " & Sql & " " & _
                   " " & shr_section & " " & shr_Department & " " & shr_type_in & "  " & shr_duties & "  " & shr_job_phuk & "     ORDER BY AP_Persion_Study.E_id "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                           Chr(9) & Trim((RSC.Fields("Bill_no").Value).ToString) & _
                                   Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                                       Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("Sections").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("Department").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("cmb_study").Value).ToString) & _
                                     Chr(9) & Trim((RSC.Fields("cmb_visa").Value).ToString) & _
                                      Chr(9) & Trim((RSC.Fields("cmb_Nation").Value).ToString) & _
                                         Chr(9) & Format(CDate(RSC.Fields("DT_Finish").Value), "yyyy") & _
                                          Chr(9) & Trim((RSC.Fields("cmb_lang").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("remark").Value).ToString))

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
            aa = "SELECT  * from AP_Persion_Study  WHERE 1=1  AND bill_no=N'" & Fg1.get_TextMatrix(Fg1.Row, 1) & "' and E_ID=N'" & Fg1.get_TextMatrix(Fg1.Row, 2) & "'  "
            Call LoadRs(aa, rs)
            If .RecordCount <> 0 Then
                If .Fields("txtsamun_id").Value = 0 Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True
                End If

                txt_no.Text = (.Fields("bill_no").Value.ToString)
                txtid.Text = (.Fields("E_ID").Value.ToString)
                TxtPersonNmL.Text = (.Fields("Name_L").Value.ToString)
                cmb_study.Text = (.Fields("cmb_study").Value.ToString)
                cmb_visa.Text = (.Fields("cmb_visa").Value.ToString)
                cmb_Nation.Text = (.Fields("cmb_Nation").Value.ToString)
                DT_Finish.Value = (.Fields("DT_Finish").Value.ToString)

                txtremark.Text = (.Fields("remark").Value.ToString)


                If .Fields("chk_lang").Value = 1 Then
                    chk_lang.Checked = True
                    cmb_lang.Text = (.Fields("cmb_lang").Value.ToString)
                Else
                    chk_lang.Checked = False
                End If

            End If

        End With

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        MDEdit = False
        If txtid.Text = "" Or txt_no.Text = "" Then Exit Sub
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການ : " & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Persion_Study Where  bill_no='" & txt_no.Text & "' and E_id='" & txtid.Text & "'")

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
        cmb_study.Text = ""
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
        E_ID = " and AP_Persion_Study.E_ID=N'" & txtid.Text & "'"
        loaddata_one()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
    End Sub
    Private Sub Save()

        Dim rs As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT * FROM  AP_Persion_Study WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO   AP_Persion_Study ( bill_no, E_ID, Name_L, txtsamun_id, txtsamun, txtstudy_id, cmb_study, txtvisa_id, cmb_visa, txt_Nation_id, cmb_Nation, DT_Finish,remark,lst_updt, lst_usr, Pc_nm) " & _
               " VALUES(N'" & (txt_no.Text) & "'," & _
                 " N'" & (txtid.Text) & "'," & _
                     " N'" & (TxtPersonNmL.Text) & "'," & _
                       " N'" & (txtsamun_id.Text) & "'," & _
                         " N'" & (txtsamun.Text) & "'," & _
                             " N'" & (txtstudy_id.Text) & "'," & _
                           " N'" & (cmb_study.Text) & "'," & _
                              " N'" & (txtvisa_id.Text) & "'," & _
                           " N'" & (cmb_visa.Text) & "'," & _
                               " N'" & (txt_Nation_id.Text) & "'," & _
                           " N'" & (cmb_Nation.Text) & "'," & _
                            " '" & Format(DT_Finish.Value, "yyyy-MM-dd") & "'," & _
                                     " N'" & (txtremark.Text) & "'," & _
                                           " Getdate()," & _
                               " N'" & MUserName & "'," & _
                            " '" & MDServerName & "')"
                Conn.Execute(aa)
            Else
                Conn.Execute("delete from   AP_Persion_Study WHERE  Bill_no= '" & (txt_no.Text) & "' and  E_ID= '" & (txtid.Text) & "'")
                Dim aa As String
                aa = "INSERT INTO   AP_Persion_Study ( bill_no, E_ID, Name_L, txtsamun_id, txtsamun, txtstudy_id, cmb_study, txtvisa_id, cmb_visa, txt_Nation_id, cmb_Nation, DT_Finish,remark,lst_updt, lst_usr, Pc_nm) " & _
              " VALUES(N'" & (txt_no.Text) & "'," & _
                " N'" & (txtid.Text) & "'," & _
                    " N'" & (TxtPersonNmL.Text) & "'," & _
                      " N'" & (txtsamun_id.Text) & "'," & _
                        " N'" & (txtsamun.Text) & "'," & _
                            " N'" & (txtstudy_id.Text) & "'," & _
                          " N'" & (cmb_study.Text) & "'," & _
                             " N'" & (txtvisa_id.Text) & "'," & _
                          " N'" & (cmb_visa.Text) & "'," & _
                              " N'" & (txt_Nation_id.Text) & "'," & _
                          " N'" & (cmb_Nation.Text) & "'," & _
                           " '" & Format(DT_Finish.Value, "yyyy-MM-dd") & "'," & _
                                    " N'" & (txtremark.Text) & "'," & _
                                          " Getdate()," & _
                              " N'" & MUserName & "'," & _
                           " '" & MDServerName & "')"
                Conn.Execute(aa)
            End If
        End With
       
   
        If chk_lang.Checked = True Then
            Conn.Execute(" UPDATE AP_Persion_Study SET " & _
                     " chk_lang=1," & _
                           " txtlang_id=N'" & txtlang_id.Text & "'," & _
                 " cmb_lang=N'" & cmb_lang.Text & "'" & _
                                  " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        Else
            Conn.Execute(" UPDATE AP_Persion_Study SET " & _
                 " chk_lang=0," & _
                      " txtlang_id=NULL, " & _
             " cmb_lang=NULL " & _
                               " WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'")
        End If

 
  
        If chk_lang.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                     " chk_lang=1," & _
                     " lang_id=N'" & txtlang_id.Text & "'," & _
                        " lang=N'" & cmb_lang.Text & "'" & _
                     " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                      " chk_lang=0," & _
                      " lang_ID=NULL, " & _
                          " lang=NULL " & _
                      " WHERE E_ID= '" & (txtid.Text) & "'")
        End If


    End Sub

    Private Sub loaddata_one()
        Fg1.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT    AP_Persion_Study.*,AP_CV.Sections,AP_CV.Department  " & _
          "   FROM         AP_Persion_Study INNER JOIN " & _
          "   AP_CV ON AP_Persion_Study.E_ID = AP_CV.E_ID  where 1=1 " & E_ID & "    ORDER BY AP_Persion_Study.DT_Finish desc "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                             Chr(9) & Trim((RSC.Fields("Bill_no").Value).ToString) & _
                                     Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                                         Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                   Chr(9) & Trim((RSC.Fields("Sections").Value).ToString) & _
                                    Chr(9) & Trim((RSC.Fields("Department").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("cmb_study").Value).ToString) & _
                                       Chr(9) & Trim((RSC.Fields("cmb_visa").Value).ToString) & _
                                        Chr(9) & Trim((RSC.Fields("cmb_Nation").Value).ToString) & _
                                           Chr(9) & Format(CDate(RSC.Fields("DT_Finish").Value), "yyyy") & _
                                               Chr(9) & Trim((RSC.Fields("cmb_lang").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("remark").Value).ToString))
                    .MoveNext()
                End While

            End If
        End With

    End Sub

    Private Sub cmb_duties_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_study.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Education Where  E_nm=N'" & Trim(cmb_study.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtstudy_id.Text = Trim(RSC("E_id").Value)
        End If
    End Sub

  



    Private Sub chk_job_lut_visakan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_lang.CheckedChanged
        If chk_lang.Checked = True Then
            cmb_lang.Enabled = True
            cmb_lang.Items.Clear()
            Call load_Cmb("select NationNmL from Nationall where NationID>001 ", "NationNmL", cmb_lang)
            cmb_lang.SelectedIndex = 0

        Else
            cmb_lang.Items.Clear()
            cmb_lang.Text = ""
            cmb_lang.Enabled = False
        End If
    End Sub



    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FrmCustomer_item.ShowDialog()
        If MDCusID = "" Then Exit Sub
        MDCusID = " AND AP_CV.E_ID=N'" & CustID & "'"
        LoadData_CV()

        E_ID = " and AP_Persion_Study.E_ID=N'" & txtid.Text & "'"
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
        txtremark.Text = ""
        txtid.Text = ""
        txt_no.Text = ""
        TxtPersonNmL.Text = ""
        cmb_study.SelectedIndex = 0
        cmb_visa.SelectedIndex = 0
        cmb_Nation.SelectedIndex = 0
        chk_lang.Checked = False
        DT_Finish.Value = Today
        RadioButton1.Checked = True

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

    Private Sub cmb_duties2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_study2.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Education Where  E_nm=N'" & Trim(cmb_study2.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtstudy_id2.Text = Trim(RSC("E_id").Value)
        End If
        shr_duties = " AND AP_Persion_Study.txtstudy_id = N'" & txtstudy_id2.Text & "' "

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudy_id2.TextChanged

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

    Private Sub Button91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button91.Click

    End Sub

    Private Sub cmb_Nation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Nation.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Nationall Where  NationNmL=N'" & Trim(cmb_Nation.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_Nation_id.Text = Trim(RSC("NationID").Value)
        End If
    End Sub

 
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            cmb_study.Items.Clear()
            Call load_Cmb("select E_nm from Education where E_ID>09 ", "E_nm", cmb_study)
            cmb_study.SelectedIndex = 0

            cmb_visa.Items.Clear()
            Call load_Cmb("select Field_Name from Study_Field where Field_ID<004 ", "Field_Name", cmb_visa)
            cmb_visa.SelectedIndex = 0

            txtsamun.Text = RadioButton1.Text
            txtsamun_id.Text = 0
            Label5.Text = "ຊັນຮຽນ"
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            cmb_study.Items.Clear()
            Call load_Cmb("select E_nm from Education where E_ID<09 ", "E_nm", cmb_study)
            cmb_study.SelectedIndex = 0
            Label5.Text = "ຂະແໜ່ງວິຊາຮຽນ"
        End If


        cmb_visa.Items.Clear()
        Call load_Cmb("select Field_Name from Study_Field where Field_ID>003 ", "Field_Name", cmb_visa)
        cmb_visa.SelectedIndex = 0

        txtsamun.Text = RadioButton2.Text
        txtsamun_id.Text = 1
    End Sub

    Private Sub cmb_lang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_lang.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Nationall Where  NationNmL=N'" & Trim(cmb_lang.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtlang_id.Text = Trim(RSC("NationID").Value)
        End If
    End Sub

    Private Sub cmb_visa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_visa.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Study_Field Where  Field_Name=N'" & Trim(cmb_visa.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtvisa_id.Text = Trim(RSC("Field_ID").Value)
            'shr_job_phuk = " AND AP_CV.job_phuk_ID = N'" & txtvisa_id.Text & "' "
        End If
        'Call loaddata()
    End Sub

    Private Sub chk_study_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_study.CheckedChanged
        If chk_study.Checked = True Then

            cmb_study2.Items.Clear()
            'cmb_duties2.Items.Add("ທັງໝົດ")
            Call load_Cmb("select E_nm from Education  ", "E_nm", cmb_study2)
            cmb_study2.SelectedIndex = 0
            shr_duties = " AND AP_Persion_Study.txtstudy_id = N'" & txtstudy_id2.Text & "' "

        Else
            cmb_study2.Items.Clear()
            cmb_study2.Text = ""
            shr_duties = ""
        End If
    End Sub

    Private Sub cmb_visa2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_visa2.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Study_Field Where  Field_Name=N'" & Trim(cmb_visa2.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtvisa_id2.Text = Trim(RSC("Field_ID").Value)
            shr_job_phuk = " AND  AP_Persion_Study.txtvisa_id = N'" & txtvisa_id2.Text & "' "
        End If

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

    End Sub
End Class