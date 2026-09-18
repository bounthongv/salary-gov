Public Class Frm_User_List
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
    Private Sub Frm_Birth_Data_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 

        If MDWrite = 0 Then
            BtnAddNew.Enabled = False
        Else
            BtnAddNew.Enabled = True
        End If
        If MDEdit = 0 Then
            BtnEdit.Enabled = False
        Else
            BtnEdit.Enabled = True
        End If
        If MDDelete = 0 Then
            BtnDel.Enabled = False
        Else
            BtnDel.Enabled = True
        End If



        Fg1.FormatString = "ລ/ດ|<ລະຫັດຜູ້ໃຊ້   |<ຊື່ ຜູ້ໃຊ້      |<ສິດໃຊ້ໂປຣແກຣມ        "
        FG2.FormatString = "ລ/ດ|<ຊື່ ແຂວງ           |<ຊື່ ເມືອງ              "
        'Fg1.set_ColHidden(8, True)
        Sql = ""
        'Sql = " AND AP_Check.Bill_Dt between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'   "
        'P = 1
        Call loaddata()
    End Sub
   
    Private Sub loaddata()
        Fg1.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT  * from AP_Users   "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                                 Chr(9) & Trim((RSC.Fields("Usr_id").Value).ToString) & _
                                    Chr(9) & Trim((RSC.Fields("Usr_nm").Value).ToString) & _
                                              Chr(9) & Trim((RSC.Fields("permision").Value).ToString))

                    .MoveNext()
                End While

            End If
        End With

    End Sub

    Private Sub loaddata_Item()
        FG2.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT  * from AP_Users_Item  where Usr_id=N'" & SaleID & "' "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    FG2.AddItem(.AbsolutePosition & _
                                 Chr(9) & Trim((RSC.Fields("ProV_nm").Value).ToString) & _
                                              Chr(9) & Trim((RSC.Fields("Dist_Nm").Value).ToString))

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


        'Label1.Text = "Date:"


        Fg1.FormatString = "NO |<Bill       |<In no       |<date       |<Refer no  |<SuppliersID |< Suppliers name    |<Items|<Amount    |<Donor                    |<Receipt"

    End Sub
    Private Sub sakhone2()

    End Sub

    Public Sub LngLao()

        BtnAddNew.Text = "ເພີ່ມໃໝ່"
        BtnEdit.Text = "ແກ້ໄຂ"
        BtnDel.Text = "ລຶບ"
        Button2.Text = "ເອີ້ນຄືນ"


        'Label1.Text = "ວັນທີ່:"


        Fg1.FormatString = "ລ/ດ |<ເລກບິນ       |<ເລກບິນ       |<ວັນທີ່       |<Refer no  |<ລະຫັດຜູ້ສະໜອງ |< ຊື່ ຜູ້ສະໜອງ    |>ຈໍານວນລ/ກ|>ເປັນເງິນ    |<ຜູ້ສົ່ງ             |<ຜູ້ຮັບ             |<  "

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        EditActive = False
        FrmUser.ShowDialog()
    End Sub

    Private Sub Fg1_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg1.ClickEvent
        loaddata_Item()
    End Sub

    Private Sub Fg1_MouseUpEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_MouseUpEvent) Handles Fg1.MouseUpEvent
        SaleID = Fg1.get_TextMatrix(Fg1.Row, 1)
    End Sub
    Private Sub Fg1_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg1.SelChange

    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
     
        EditActive = True
        FrmUser.ShowDialog()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click

      

        Dim cmdDel As New ADODB.Command
        If Me.Fg1.get_TextMatrix(Me.Fg1.Row, 1) = "" Then MsgBox("ກະລຸນາເລຶອກລາຍການທ່ານຕ້ອງການລຶບກ່ອນ !") : Exit Sub
        Call LoadRs("SELECT * FROM AP_Brith_Data  WHERE   Brith_no=N'" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "'  ", rs)
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການ : " & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Users Where  Usr_id='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1) & "'"))
            Conn.Execute("Delete From AP_Users_Item Where  Usr_id='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1) & "'"))
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



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '       With RSC
        '           Dim sa As String = " SELECT   dbo.AP_Brith_Data_List.*,AP_Books.Mobile1, dbo.AP_Books.Cust_nm,dbo.AP_Books.Vaccin_Check,AP_Books.Expect_Date, " & _
        '       "    dbo.AP_Province.PV_nm, dbo.AP_Village.Vl_nm, dbo.AP_District.Dt_nm, dbo.AP_LocationBk.Bk_nm, dbo.AP_Office.off_nm, dbo.AP_Office.Tel,  " & _
        '         "  dbo.AP_Office.com_logo " & _
        '                    " FROM         dbo.AP_Brith_Data_List INNER JOIN " & _
        '         "     dbo.AP_Books ON dbo.AP_Books.bill_no = dbo.AP_Brith_Data_List.Book_id INNER JOIN " & _
        '                 "    dbo.AP_Province ON dbo.AP_Books.PV_id = dbo.AP_Province.PV_ID INNER JOIN " & _
        '                 "    dbo.AP_Village ON dbo.AP_Books.Vl_Id = dbo.AP_Village.Vl_ID INNER JOIN " & _
        '                   "  dbo.AP_District ON dbo.AP_Books.Dt_ID = dbo.AP_District.Dt_id INNER JOIN " & _
        '                   "  dbo.AP_LocationBk ON dbo.AP_Books.Book_id = dbo.AP_LocationBk.BK_ID CROSS JOIN " & _
        '"           dbo.AP_Office  WHERE 1=1  " & Sql & "   AND dbo.AP_Brith_Data_List.office='" & MDST & "' order by AP_Brith_Data_List.Brith_no "
        '           Call LoadRs(sa, RSC)
        '           If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
        '           Dim Frm As New FrmPreview
        '           Dim Rpt As New Report_Birth_Data
        '           Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
        '           myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
        '           myTextObjectOnReport.Text = Location_nm



        '           Rpt.SetDataSource(RSC)
        '           Rpt.Refresh()
        '           Frm.ReportViewer.ReportSource = Rpt
        '           Frm.ReportViewer.Zoom(100%)
        '           Frm.ReportViewer.DisplayGroupTree = False
        '           Frm.WindowState = FormWindowState.Maximized
        '           Frm.Show()
        '       End With
    End Sub

    Private Sub txtIn_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIn_no.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

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

    Private Sub txtFdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub txtTdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Sql = " AND AP_Brith_Data.B_Date between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'"
        Call loaddata()
    End Sub

    Private Sub txtBK_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Call loaddata()
    End Sub

    Private Sub txtbarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Call loaddata()
    End Sub

    Private Sub txtmom_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Call loaddata()
    End Sub

    Private Sub txt_Mobail2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Call loaddata()
    End Sub

    Private Sub txtDoctor_Place_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Sql = " AND AP_Brith_Data.Place LIKE N'%" & txtDoctor_Place.Text & "%' "
        Call loaddata()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Sql = ""
        Call loaddata()
    End Sub

   

  

    Private Sub FG2_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FG2_SelChange_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
   

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With RSC
            Dim sa As String = "SELECT     AP_Delivery_Record.*, AP_Books.Mobile1, AP_Village.Vl_ID, AP_Village.Vl_nm, AP_District.Dt_id, AP_District.Dt_nm, " & _
           " AP_Province.PV_ID, AP_Province.PV_nm  " & _
          "  FROM         AP_Delivery_Record INNER JOIN " & _
                    "  AP_Books ON AP_Delivery_Record.Book_id = AP_Books.Bill_no INNER JOIN " & _
                    "  AP_Village ON AP_Books.Vl_Id = AP_Village.Vl_ID INNER JOIN " & _
                    "  AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
                    "  AP_Province ON AP_District.PV_id = AP_Province.PV_ID where AP_Delivery_Record.Baby_ID=N'" & Baby_id & "'   "
            Call LoadRs(sa, RSC)
            If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
            Dim Frm As New FrmPreview
            Dim Rpt As New Report_DiaryRecord
            Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
            myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
            myTextObjectOnReport.Text = Location_nm
            Rpt.SetDataSource(RSC)
            Rpt.Refresh()
            Frm.ReportViewer.ReportSource = Rpt
            Frm.ReportViewer.Zoom(100%)
            Frm.ReportViewer.DisplayGroupTree = False
            Frm.WindowState = FormWindowState.Maximized
            Frm.Show()
        End With
    End Sub
End Class