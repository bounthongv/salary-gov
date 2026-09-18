Public Class Frm_Book_List
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
    Private Sub Frm_Book_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox2.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0
        If MWorkSetting = "" Then
            txtFdate.Value = Date.Today
            txtTdate.Value = Date.Today
        Else
            txtFdate.Value = MWorkSetting
            txtTdate.Value = MWorkSetting
        End If

        'If MDLanguage = 0 Then
        '    Call LngLao()
        'Else
        '    Call Lngs()
        'End If

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
        'Sql = " AND AP_Books.Bill_Dt between '" & Format(txtFdate.Value, "MM/dd/yyyy") & "'AND '" & Format(txtTdate.Value, "MM/dd/yyyy") & "'   "
        'P = 1
        'Call PageCnt(StrSQL, ConString, P, 500)
        'Me.lblpage_total.Text = "1/" & Last_page
        'Me.Enabled = True

        Fg1.FormatString = "ລ/ດ |<ລະຫັດປື້ມ        |^ວັນທີ       |<ລະຫັດ   |<ບ່ອນອອກປື້ມ                  |<ບາໂຄດປື້ມ        |<ຊື່ ແລະນາມສະກຸນ ແມ່      |^ອາຍຸ|<ອາຊີບ          |<ບ່ອນເຮັດວຽກ       |<ເບີໂທຕິດຕໍ່         |<ຊື່ແລະນາມສະກຸນພໍ່|<ເບີໂທຕິດຕໍ່     |^ມີຫ້ອງນ້ຳໃຊ້ບໍ່|<ແຫຼ່ງນ້ຳໃຊ້      |<ບ້ານ          |<ເມືອງ          |<ແຂວງ        "

        Fg1.set_ColHidden(3, True)
       
        Sql = ""
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
    End Sub
    Public Sub Lngs()

        BtnAddNew.Text = "AddNew"
        BtnEdit.Text = "Edit"
        BtnDel.Text = "Delete"
        Button2.Text = "Refresh"
        Button3.Text = "Peview"
        Button4.Text = "Search"
        'Label1.Text = "Date:"
        Label2.Text = "to"
        'Label3.Text = "Bill no:"
        Fg1.FormatString = "NO |<Bill       |<In no       |<date       |<Refer no  |<SuppliersID |< Suppliers name    |<Items|<Amount    |<Donor                    |<Receipt"
        Fg2.FormatString = "NO |<CategoryID    |<ProductID                  |<Category name (Lao)       |<Category name (Eng)      |<Unit    |<Model    |<Cost     |<Quantity |<Lost date     |<Amount"

    End Sub
    Private Sub sakhone2()

    End Sub

    Public Sub LngLao()

        BtnAddNew.Text = "ເພີ່ມໃໝ່"
        BtnEdit.Text = "ແກ້ໄຂ"
        BtnDel.Text = "ລຶບ"
        Button2.Text = "ເອີ້ນຄືນ"
        Button3.Text = "ເບິ່ງຂໍ້ມູນ"
        Button4.Text = "ຄົ້ນຫາ"
        'Label1.Text = "ວັນທີ່:"
        Label2.Text = "ເຖິງ"
        'Label3.Text = "ເລກບິນ:"
        Fg1.FormatString = "ລ/ດ |<ເລກບິນ       |<ເລກບິນ       |<ວັນທີ່       |<Refer no  |<ລະຫັດຜູ້ສະໜອງ |< ຊື່ ຜູ້ສະໜອງ    |>ຈໍານວນລ/ກ|>ເປັນເງິນ    |<ຜູ້ສົ່ງ             |<ຜູ້ຮັບ             |<  "
        Fg2.FormatString = "ລ/ດ |<ລະຫັດສີນຄ້າ    |<ລະຫັດສີນຄ້າ           |<ຊື່ ສີນຄ້າ            |<ເລກປະຈໍາຕົງເຄື່ອງ     |<ຫົວໜ່ວຍ    |<ລຸ້ນ    |>ລາຄາຕົ້ນທຶນ    |>ຈໍານວນ |<Lost ວັນທີ່     |>ເປັນເງິນ"

    End Sub
    Private Sub LoadData()
        Fg1.Rows = 1
        With rs
            Sql = " AND in_dt BETWEEN '" & Format(txtFdate.Value, "yyyy-MM-dd") & "' AND '" & Format(txtTdate.Value, "yyyy-MM-dd") & "'  "
            Call LoadRs("select AP_Stockin_Order.*,AP_Suppliers.Supp_id,AP_Suppliers.Supp_nmL from AP_Stockin_Order" & _
                        " LEFT OUTER JOIN AP_Suppliers ON AP_Stockin_Order.Supp_id = AP_Suppliers.Supp_id " & _
                        "WHERE In_no<>'' AND  AP_Suppliers.Company=N'" & Company & "' AND  AP_Stockin_Order.Company=N'" & Company & "' " & Sql & " order by In_no", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("In_no").Value.ToString) & _
                    Chr(9) & Format(.Fields("refer_no").Value.ToString) & _
                    Chr(9) & Format(.Fields("in_dt").Value, "dd/MM/yyyy") & _
                    Chr(9) & Format((.Fields("PO_No").Value.ToString)) & _
                    Chr(9) & Format((.Fields("Supp_id").Value.ToString)) & _
                    Chr(9) & Format((.Fields("Supp_nmL").Value.ToString)) & _
                    Chr(9) & Format(CDbl(.Fields("item_cnt").Value), "#,##0.00") & _
                    Chr(9) & Format(CDbl(.Fields("Bill_Amt").Value), "#,##0.00") & _
                    Chr(9) & Format((.Fields("doner").Value.ToString)) & _
                    Chr(9) & (.Fields("receiver").Value.ToString) & _
                    Chr(9) & (.Fields("Used").Value))
                    .MoveNext()
                End While
            End If
        End With
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        EditActive = False
        Frm_Books.ShowDialog()
        Fg1.Row = 1
        Call PageCnt(StrSQL, ConString, P, 500)
    End Sub
    Private Sub Fg1_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg1.DblClick
        Button8_Click(sender, e)
    End Sub
    Private Sub Fg1_MouseUpEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_MouseUpEvent) Handles Fg1.MouseUpEvent
        Book_id = Fg1.get_TextMatrix(Fg1.Row, 3)
        SaleID = Fg1.get_TextMatrix(Fg1.Row, 1)
    End Sub
    Private Sub Fg1_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg1.SelChange
        If Fg1.get_TextMatrix(Fg1.Row, 1) = "" Or Fg1.Row = 0 Then Exit Sub
        With RSC
            Call LoadRs("select * FROM AP_Stockin_Items WHERE Bill_ID=N'" & Fg1.get_TextMatrix(Fg1.Row, 1) & "' ", RSC)
            If .RecordCount <> 0 Then
                Fg2.Rows = 1
                While Not .EOF
                    Fg2.AddItem(.AbsolutePosition & _
                   Chr(9) & (.Fields("GoodsType").Value.ToString) & _
                    Chr(9) & Format(.Fields("NaTure").Value.ToString) & _
                    Chr(9) & Format((.Fields("WightTotal").Value), "#,##0.00") & _
                    Chr(9) & Format((.Fields("Wight").Value), "#,##0.00") & _
                    Chr(9) & Format((.Fields("WightLS").Value.ToString)) & _
                    Chr(9) & Format(CDbl(.Fields("Price").Value), "#,##0.00") & _
                    Chr(9) & Format(CDbl(.Fields("Total").Value), "#,##0.00"))
                    .MoveNext()
                End While
            Else
                Fg2.Rows = 1
                Fg2.Rows = 2
            End If
        End With

        '''''=====================================================

        'Fg2.Rows = 1
        'With rs
        '    Call LoadRs("SELECT dbo.AP_Books.Bill_ID, dbo.AP_Books.Bill_Dt, dbo.AP_Books_ITEM.Name, dbo.AP_Books_ITEM.Qty, dbo.AP_Books_ITEM.Unit, dbo.AP_Books_ITEM.Unit_Price, " & _
        '               " dbo.AP_Books_ITEM.total_k, dbo.AP_Books_ITEM.curr_e, dbo.AP_Books_ITEM.Curr, dbo.AP_Books_ITEM.Total, dbo.AP_Books_ITEM.Designation " & _
        '               " FROM dbo.AP_Books LEFT OUTER JOIN " & _
        '               " dbo.AP_Books_ITEM ON dbo.AP_Books.Bill_ID = dbo.AP_Books_ITEM.Bill_ID " & _
        '               " WHERE AP_Books_ITEM.Bill_no='" & Fg1.get_TextMatrix(Fg1.Row, 1), rs)
        '    If .RecordCount > 0 Then
        '        While Not .EOF()
        '            Fg2.AddItem(.AbsolutePosition & _
        '            Chr(9) & (.Fields("Bill_ID").Value.ToString) & _
        '            Chr(9) & Format(.Fields("Bill_Dt").Value, "dd/MM/yyyy") & _
        '            Chr(9) & Format(.Fields("Name").Value.ToString) & _
        '            Chr(9) & Format((.Fields("Qty").Value.ToString)) & _
        '            Chr(9) & Format((.Fields("Unit").Value.ToString)) & _
        '            Chr(9) & Format((.Fields("Unit_Price").Value.ToString)) & _
        '            Chr(9) & Format((.Fields("Curr").Value.ToString)) & _
        '            Chr(9) & Format(CDbl(.Fields("curr_e").Value), "#,##0.00") & _
        '            Chr(9) & Format(CDbl(.Fields("total_k").Value), "#,##0.00"))
        '            .MoveNext()
        '        End While
        '    End If
        'End With
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        'rs = New ADODB.Recordset
        'With rs
        '    Dim sa As String = "Select Bill_no From AP_Stock_Pay_Item_IN WHERE Bill_no='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "'  Order By Bill_no"
        '    Call LoadRs(sa, rs)
        '    If rs.RecordCount <> 0 Then MsgBox("ທ່ານບໍ່ສາມາດແກ້ໄຂລາຍການນີ້ໄດ້ ເພາະມີການຈ່າຍເຄື່ອງຂື້ນຍົນແລ້ວ", MsgBoxStyle.OkOnly) : Exit Sub

        '    If .RecordCount > 0 Then

        '    Else

        '    End If
        'End With
        EditActive = True
        Frm_Books.ShowDialog()
        Fg1.Row = 1
        Call PageCnt(StrSQL, ConString, P, 500)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click

        'rs = New ADODB.Recordset
        'With rs
        '    Dim sa As String = "Select Bill_no From AP_Stock_Pay_Item_IN WHERE Bill_no='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "'  Order By Bill_no"
        '    Call LoadRs(sa, rs)
        '    If rs.RecordCount <> 0 Then MsgBox("ທ່ານບໍ່ສາມາດລືບລາຍການນີ້ໄດ້ ເພາະມີການຈ່າຍເຄື່ອງຂື້ນຍົນແລ້ວ", MsgBoxStyle.OkOnly) : Exit Sub

        '    If .RecordCount > 0 Then

        '    Else

        '    End If
        'End With

        Dim cmdDel As New ADODB.Command
        If Me.Fg1.get_TextMatrix(Me.Fg1.Row, 1) = "" Then MsgBox("ກະລຸນາເລຶອກລາຍການທ່ານຕ້ອງການລຶບກ່ອນ !") : Exit Sub
        Call LoadRs("SELECT * FROM AP_Books  WHERE   Bill_No=N'" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "'  ", rs)
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການ : " & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Books Where  Bill_No='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1) & "' AND Book_id='" & MDST & "' "))
            P = 1
            Call PageCnt(StrSQL, ConString, P, 500)
            Me.lblpage_total.Text = "1/" & Last_page
            Me.Enabled = True
        End If
        Fg1.Row = 1
        Call PageCnt(StrSQL, ConString, P, 500)

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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIn_no.KeyPress
        If txtIn_no.Text = "ທັງໝົດ" Then
            P = 1
            Call PageCnt(StrSQL, ConString, P, 500)
            Me.lblpage_total.Text = "1/" & Last_page
            Me.Enabled = True
            'Call sa()
            'ທັງໝົດ()
            'ເລກທີບິນ()
            'ໄປລົງສະໜາມບິນ()
            'ຜູ້ສົ່ງເຄື່ອງ()
            'ຜູ້ຮັບເຄື່ອງ()
        Else
            If ComboBox1.SelectedIndex = 1 Then
                sql2 = " AND AP_Books.Bill_no LIKE N'%" & txtIn_no.Text & "%' "
            ElseIf ComboBox1.SelectedIndex = 2 Then
                sql2 = " AND AP_Books.Bar_Code LIKE N'%" & txtIn_no.Text & "%' "
            ElseIf ComboBox1.SelectedIndex = 3 Then
                sql2 = " AND AP_Books.Cust_nm LIKE N'%" & txtIn_no.Text & "%' "
            ElseIf ComboBox1.SelectedIndex = 4 Then
                sql2 = " AND AP_Village.Vl_nm LIKE N'%" & txtIn_no.Text & "%' "
            ElseIf ComboBox1.SelectedIndex = 5 Then
                sql2 = " AND AP_Books.Mobile1 LIKE N'%" & txtIn_no.Text & "%' "
            End If
            P = 1
            Call PageCnt(StrSQL, ConString, P, 500)
            Me.lblpage_total.Text = "1/" & Last_page
            Me.Enabled = True
            'Call sa()
        End If

    End Sub
    Private Sub sa()

        Fg1.Rows = 1
        With rs
            Dim sa As String = "SELECT dbo.AP_Books.Bill_ID, dbo.AP_Books.Bill_Dt, dbo.AP_Books.date_to, dbo.AP_Books.date_m, dbo.AP_Books.Supp, dbo.AP_Suppliers.Supp_nmL, dbo.AP_Books.Stff," & _
                        " dbo.AP_Staffs.Stff_nmL, dbo.AP_Books.EO, dbo.AP_Books.RO, dbo.AP_Books.PO,dbo.AP_Books.RF  " & _
                        " FROM dbo.AP_Books LEFT OUTER JOIN " & _
                        " dbo.AP_Suppliers ON dbo.AP_Books.Supp = dbo.AP_Suppliers.Supp_id LEFT OUTER JOIN " & _
                        " dbo.AP_Staffs ON dbo.AP_Books.Stff = dbo.AP_Staffs.Stff_Id  " & sql2 & " ORDER BY dbo.AP_Books.Bill_ID "
            Call LoadRs(sa, rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                             Chr(9) & Trim((rs.Fields("Bill_ID").Value)) & _
                             Chr(9) & Trim((rs.Fields("PO").Value).ToString) & _
                             Chr(9) & Trim((rs.Fields("RO").Value).ToString) & _
                             Chr(9) & Trim((rs.Fields("EO").Value).ToString) & _
                             Chr(9) & Trim((rs.Fields("RF").Value).ToString) & _
                             Chr(9) & Format(CDate(rs.Fields("Bill_Dt").Value), "dd/MM/yyyy") & _
                             Chr(9) & Format(CDate(rs.Fields("Date_to").Value), "dd/MM/yyyy") & _
                             Chr(9) & Format((rs.Fields("date_m").Value.ToString) & _
                             Chr(9) & (rs.Fields("Supp_nmL").Value) & _
                             Chr(9) & (rs.Fields("Stff_nmL").Value.ToString)))

                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With RSC
            Dim sa As String = " SELECT     dbo.AP_Books.*, dbo.AP_Province.PV_nm, dbo.AP_Village.Vl_nm, dbo.AP_District.Dt_nm, dbo.AP_LocationBk.Bk_nm, dbo.AP_Office.off_nm, dbo.AP_Office.Tel, " & _
                               " dbo.AP_Office.com_logo " & _
                               " FROM         dbo.AP_Books INNER JOIN " & _
                               " dbo.AP_Province ON dbo.AP_Books.PV_id = dbo.AP_Province.PV_ID INNER JOIN " & _
                               " dbo.AP_Village ON dbo.AP_Books.Vl_Id = dbo.AP_Village.Vl_ID INNER JOIN " & _
                               " dbo.AP_District ON dbo.AP_Books.Dt_ID = dbo.AP_District.Dt_id LEFT OUTER JOIN " & _
                               " dbo.AP_LocationBk ON dbo.AP_Books.Book_id = dbo.AP_LocationBk.BK_ID CROSS JOIN " & _
                               " dbo.AP_Office " & _
                               " WHERE 1=1  " & Sql & "" & Provice & " " & Dristic & " " & Village & "  " & sql2 & "" & Shr_Dristic & " " & Shr_HSV & "   AND dbo.AP_Books.Book_id='" & MDST & "'  ORDER BY dbo.AP_Books.Bill_No"
            Call LoadRs(sa, RSC)
            If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
            Dim Frm As New FrmPreview
            Dim Rpt As New CrystalReport_List_Books
            Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
            myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
            myTextObjectOnReport.Text = FrmAPInvioce.Label2.Text
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
        Sql = " AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
    End Sub
    Public Sub PageCnt(ByVal StrSQL As String, ByVal ConStr As String, ByVal PageNum As Long, ByVal RowPerPage As Integer)
        'Fg1.FormatString = "ລ/ດ |<ເລກທີ         |^ວັນທີ       |<ລະຫັດປື້ມ      |<ບາໂຄດສຳຮອງ         |<ຊື່ ແລະນາມສະກຸນ ແມ່              |^ອາຍຸ   |<ອາຊີບ              |<ບ່ອນເຮັດວຽກ        |<ເບີໂທຕິດຕໍ່             |<ບ້ານ                   |<ໝາຍເຫດ                    "
        Dim i As Integer
        Fg1.Rows = 1
        PageNum = PageNum - 1
        With RSC
            Dim sa As String = " SELECT     AP_Books.Bill_no, AP_Books.Bill_Dt, AP_Books.Stff_Id, AP_Books.Cust_nm, AP_Books.Book_id, AP_Books.Bar_Code, AP_Books.Age, AP_Books.Height,AP_Books.Health_Service_id,AP_Books.Health_Service, " & _
                  "  AP_Books.Place,AP_Books.Tolet,AP_Books.Tolet_nm,AP_Books.Watter,  AP_Books.Profession, AP_Books.Work_Add, AP_Books.Dad_Name, AP_Books.BabyTh, AP_Books.Baby_Name, AP_Books.Mobile1, AP_Books.Mobile2, " & _
                 "     AP_Books.Unit, AP_Books.Date_of_BirthM, AP_Books.Last_Date, AP_Books.Expect_Date, AP_Books.Birth_Date, AP_Books.Remark, AP_Books.Get_date, " & _
                "      AP_Books.lst_usr, AP_Books.Pc_nm, AP_LocationBk.Bk_nm, AP_Books.Vl_Id, AP_Village.Vl_nm, AP_District.Dt_id, AP_District.Dt_nm, AP_Province.PV_ID, " & _
          "  AP_Province.PV_nm " & _
             "   FROM         AP_Books INNER JOIN " & _
               "       AP_Village ON AP_Books.Vl_Id = AP_Village.Vl_ID LEFT OUTER  JOIN " & _
               "       AP_LocationBk ON AP_Books.Book_id = AP_LocationBk.BK_ID INNER JOIN " & _
                   "   AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
                  "    AP_Province ON AP_District.PV_id = AP_Province.PV_ID where 1=1  " & Sql & "" & Provice & " " & Dristic & " " & Village & "  " & sql2 & "" & Shr_Dristic & " " & Shr_HSV & "   AND dbo.AP_Books.Book_id='" & MDST & "'  ORDER BY dbo.AP_Books.Bill_No "
            Call LoadRs(sa, RSC)

            If .RecordCount <> 0 Then
                .MoveFirst()
                .Move(RowPerPage * PageNum)
                If Int(.RecordCount Mod RowPerPage) = 0 Then
                    Last_page = Int(.RecordCount / 500)
                Else
                    Last_page = Int(.RecordCount / 500) + 1
                    If P = Last_page Then RowPerPage = (.RecordCount Mod RowPerPage)
                End If
                '===========================================================
                Fg1.Redraw = False
                Fg1.Rows = 1
                For i = 0 To RowPerPage - 1
                    Dim HS As String
                    If RSC.Fields("Health_Service").Value.ToString <> "" Then

                        HS = RSC.Fields("Health_Service").Value
                    Else
                        HS = RSC.Fields("Place").Value
                    End If




                    Fg1.AddItem(.AbsolutePosition & _
                               Chr(9) & Trim((RSC.Fields("Bill_no").Value)) & _
                               Chr(9) & Format(CDate(RSC.Fields("Bill_Dt").Value), "dd/MM/yyyy") & _
                                Chr(9) & Trim((RSC.Fields("Book_id").Value).ToString) & _
                               Chr(9) & HS & _
                                  Chr(9) & Trim((RSC.Fields("Bar_Code").Value).ToString) & _
                               Chr(9) & Trim((RSC.Fields("Cust_nm").Value).ToString) & _
                               Chr(9) & Trim((RSC.Fields("Age").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("Profession").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("Work_Add").Value).ToString) & _
                                    Chr(9) & Trim((RSC.Fields("Mobile1").Value).ToString) & _
                                          Chr(9) & Trim((RSC.Fields("Dad_Name").Value).ToString) & _
                                                   Chr(9) & Trim((RSC.Fields("Mobile2").Value).ToString) & _
                                                     Chr(9) & Trim((RSC.Fields("Tolet_nm").Value).ToString) & _
                                                                 Chr(9) & Trim((RSC.Fields("Watter").Value).ToString) & _
                                                            Chr(9) & Trim((RSC.Fields("Vl_nm").Value).ToString) & _
                                                                     Chr(9) & Trim((RSC.Fields("Dt_nm").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("PV_nm").Value).ToString))
                    '==================================================
                    'Dim M As Integer
                    'M = Format(CDbl(.Fields("Ints").Value))
                    'If M = 1 Then
                    '    For j = 1 To Fg1.Cols - 1
                    '        Fg1.Col = j
                    '        Fg1.Row = Fg1.Rows - 1
                    '        Fg1.CellBackColor = Color.Silver
                    '        Fg1.CellForeColor = Color.Blue
                    '    Next j
                    'End If
                    '==================================================
                    .MoveNext()
                    Fg1.Redraw = True
                    '==================================================
                    LbTotal.Text = " ທັງໝົດ" & Fg1.Rows - 1 & " ລາຍການ"
                Next i
                Fg1.Row = Fg1.Rows - 1
                lblpage_total.Text = P & "/" & Int(Last_page)
            Else
                Fg1.Rows = 1
                Fg1.Rows = 2
                lblpage_total.Text = "0/0"
                LbTotal.Text = " ທັງໝົດ" & Fg1.Rows - 1 & " ລາຍການ"
            End If
        End With
    End Sub
    Public Sub PageCnt2(ByVal StrSQL As String, ByVal ConStr As String, ByVal PageNum As Long, ByVal RowPerPage As Integer)
        Dim i As Integer
        Fg1.Rows = 1
        PageNum = PageNum - 1
        With RSC
            Dim sa As String = "SELECT dbo.AP_Books.Bill_ID, dbo.AP_Books.Bill_Dt,dbo.AP_Books.RF, dbo.AP_Books.date_to, dbo.AP_Books.date_m, dbo.AP_Books.Supp, dbo.AP_Suppliers.Supp_nmL, dbo.AP_Books.Stff," & _
                       " dbo.AP_Staffs.Stff_nmL, dbo.AP_Books.EO, dbo.AP_Books.RO, dbo.AP_Books.PO, dbo.AP_Suppliers.Chk1 " & _
                       " FROM dbo.AP_Books LEFT OUTER JOIN " & _
                       " dbo.AP_Suppliers ON dbo.AP_Books.Supp = dbo.AP_Suppliers.Supp_id LEFT OUTER JOIN " & _
                       " dbo.AP_Staffs ON dbo.AP_Books.Stff = dbo.AP_Staffs.Stff_Id where 1=1 " & Sql & "  ORDER BY dbo.AP_Books.Bill_Dt "
            Call LoadRs(sa, RSC)
            If .RecordCount <> 0 Then
                .MoveFirst()
                .Move(RowPerPage * PageNum)
                If Int(.RecordCount Mod RowPerPage) = 0 Then
                    Last_page = Int(.RecordCount / 500)
                Else
                    Last_page = Int(.RecordCount / 500) + 1
                    If P = Last_page Then RowPerPage = (.RecordCount Mod RowPerPage)
                End If
                '===========================================================
                Fg1.Redraw = False
                '===========================================================
                Fg1.Rows = 1
                For i = 0 To RowPerPage - 1
                    Fg1.AddItem(.AbsolutePosition & _
                               Chr(9) & Trim((RSC.Fields("Bill_ID").Value)) & _
                               Chr(9) & Trim((RSC.Fields("PO").Value).ToString) & _
                               Chr(9) & Trim((RSC.Fields("RO").Value).ToString) & _
                               Chr(9) & Trim((RSC.Fields("EO").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("RF").Value).ToString) & _
                               Chr(9) & Format(CDate(RSC.Fields("Bill_Dt").Value), "dd/MM/yyyy") & _
                               Chr(9) & Format(CDate(RSC.Fields("Date_to").Value), "dd/MM/yyyy") & _
                               Chr(9) & Format((RSC.Fields("date_m").Value.ToString) & _
                               Chr(9) & (RSC.Fields("Supp_nmL").Value) & _
                               Chr(9) & (RSC.Fields("Stff_nmL").Value.ToString)))
                    '==================================================
                    'Dim M As Integer
                    'M = Format(CDbl(.Fields("Ints").Value))
                    'If M = 1 Then
                    '    For j = 1 To Fg1.Cols - 1
                    '        Fg1.Col = j
                    '        Fg1.Row = Fg1.Rows - 1
                    '        Fg1.CellBackColor = Color.Silver
                    '        Fg1.CellForeColor = Color.Blue
                    '    Next j
                    'End If
                    '==================================================
                    .MoveNext()
                    Fg1.Redraw = True
                    '==================================================
                    LbTotal.Text = " ທັງໝົດ" & Fg1.Rows - 1 & " ລາຍການ"
                Next i
                Fg1.Row = Fg1.Rows - 1
                lblpage_total.Text = P & "/" & Int(Last_page)
            Else
                Fg1.Rows = 1
                Fg1.Rows = 2
                lblpage_total.Text = "0/0"
                LbTotal.Text = " ທັງໝົດ" & Fg1.Rows - 1 & " ລາຍການ"
            End If
        End With
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If P = 1 Then Exit Sub
        P = P - 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = P & "/" & Last_page
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If P >= Last_page Then Exit Sub
        P = P + 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = P & "/" & Last_page
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        P = Last_page
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = Last_page & "/" & Last_page
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 1"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='01' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
        'P = 1
        'Sakhone()

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 2"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='02' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
        'P = 1
        'sakhone()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 3"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='03' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
        'P = 1
        'sakhone()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 4"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='04' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
        'P = 1
        'sakhone()
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 5"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='05' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
        'P = 1
        'sakhone()
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 6"
        'SQl1 = "AND MONTH (AP_Books.Bill_Dt)='06' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        'P = 1
        'sakhone()
        Sql = "AND MONTH (AP_Books.Bill_Dt)='06' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 7"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='07' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 8"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='08' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
        'P = 1
        'sakhone()
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 9"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='09' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
        'P = 1
        'sakhone()
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 10"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='10' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
        'P = 1
        'sakhone()
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 11"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='11' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
        'P = 1
        'sakhone()
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        txt_Hder.Text = "ປະຈຳເດືອນ 12"
        Sql = "AND MONTH (AP_Books.Bill_Dt)='12' AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
        'P = 1
        'sakhone()
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        txt_Hder.Text = "ປະຈຳປີ " & TextBox1.Text & ""
        Sql = " AND YEAR(AP_Books.Bill_Dt)='" & Year(Date.Today) & "'"
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True

    End Sub
    Private Sub sakhone()
        Fg1.Rows = 1
        Call LoadRs("SELECT dbo.AP_Suppliers.Supp_nmL, dbo.AP_Suppliers.Supp_nmE, dbo.AP_Books.Bill_Dt, dbo.AP_Books.Supp, dbo.AP_Books.date_m, dbo.AP_Books.date_to, dbo.AP_Books.remark,  " & _
                     " dbo.AP_Books.Bill_Amt, dbo.AP_Books.total_n, dbo.AP_Books.Paid_Fin, dbo.AP_Books.Bill_net, dbo.AP_Books.Company, dbo.AP_Books.Bill_Paid, dbo.AP_Suppliers.Supp_id,  " & _
                     "dbo.AP_Books.Bill_ID, dbo.AP_Books.Stff, dbo.AP_Staffs.Stff_nmL, dbo.AP_Books.PO, dbo.AP_Books.RO, dbo.AP_Books.EO FROM   dbo.AP_Books LEFT OUTER JOIN " & _
                      "dbo.AP_Suppliers ON dbo.AP_Books.Supp = dbo.AP_Suppliers.Supp_id LEFT OUTER JOIN " & _
                     " dbo.AP_Staffs ON dbo.AP_Books.Stff = dbo.AP_Staffs.Stff_Id where  1=1 " & SQl1 & "  ORDER BY dbo.AP_Books.Bill_ID ", RSC)
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

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Sql = " AND AP_Books.Bill_Dt between '" & Format(txtFdate.Value, "yyyy-MM-dd") & "' AND '" & Format(txtTdate.Value, "yyyy-MM-dd") & "'   "
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
    End Sub
    Private Sub loaddata_new()
        Sql = " AND AP_Books.Bill_Dt between '" & Format(txtFdate.Value, "yyyy-MM-dd") & "' AND '" & Format(txtTdate.Value, "yyyy-MM-dd") & "'   "
        P = 1
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
        Me.Enabled = True
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

    Private Sub txtFdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFdate.KeyUp
        Call loaddata_new()
    End Sub

    Private Sub txtFdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFdate.ValueChanged

        DateTimePicker1.Value = txtFdate.Value

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox1.Text = Format((DateTimePicker1.Value), "yyyy")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການໃບຮຽກເກັບເງິນ : " & Trim(Fg1.get_TextMatrix(Fg1.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sa As String = "Delete From AP_Books Where  Bill_ID='" & Trim(Fg1.get_TextMatrix(Fg1.Row, 1) & "'")
            Conn.Execute(sa)
            Call LoadData()
        End If
    End Sub
    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtTdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTdate.KeyUp
        Call loaddata_new()
    End Sub

    Private Sub txtTdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTdate.ValueChanged

        Me.Enabled = True
    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            TxtPV_NM.Items.Clear()
            Call load_Cmb(" SELECT PV_nm FROM AP_Province WHERE 1=1 AND PV_ID<>'00' ORDER BY PV_ID ", "PV_nm", TxtPV_NM)
            If TxtPV_NM.Items.Count > 0 Then
                TxtPV_NM.SelectedIndex = 0
            End If
            TxtPV_NM.Enabled = True
            TxtDt_Nm.Enabled = True
            txtVillage_nm.Enabled = True
        Else
            TxtPV_NM.Items.Clear()
            TxtPV_NM.Text = ""
            TxtDt_Nm.Text = ""
            txtVillage_nm.Text = ""
            TxtPV_NM.Enabled = False
            TxtDt_Nm.Enabled = False
            txtVillage_nm.Enabled = False
            Provice = ""
            Dristic = ""
            Village = ""
            Sql = " AND AP_Books.Bill_Dt between '" & Format(txtFdate.Value, "yyyy-MM-dd") & "' AND '" & Format(txtTdate.Value, "yyyy-MM-dd") & "'   "
            P = 1
            Call PageCnt(StrSQL, ConString, P, 500)
            Me.lblpage_total.Text = "1/" & Last_page
            Me.Enabled = True
        End If
    End Sub

    Private Sub TxtPV_NM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPV_NM.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Province Where   PV_nm =N'" & Trim(TxtPV_NM.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtProvince.Text = Trim(rs("PV_ID").Value)


            TxtDt_Nm.Items.Clear()
            Call load_Cmb(" SELECT Dt_nm FROM AP_District  WHERE PV_ID='" & txtProvince.Text & "' ORDER BY Dt_id ", "Dt_nm", TxtDt_Nm)
            If TxtDt_Nm.Items.Count > 0 Then
                TxtDt_Nm.SelectedIndex = 0
            End If
            TxtDt_Nm.Text = ""
            txtDistrict.Text = ""
            txtVillage_nm.Text = ""
            txtVillage.Text = ""
            Dristic = ""
            Village = ""

            Provice = " AND AP_Province.PV_ID = N'" & txtProvince.Text & "' "
            Call PageCnt(StrSQL, ConString, P, 500)
            Me.lblpage_total.Text = "1/" & Last_page

        End If


    End Sub

    Private Sub txtBK_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBK_no.TextChanged
        Sql = " AND AP_Books.Bill_no LIKE N'%" & txtBK_no.Text & "%' "
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
    End Sub

    Private Sub txtbarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarcode.TextChanged
        Sql = " AND AP_Books.Bar_Code LIKE N'%" & txtbarcode.Text & "%' "
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
    End Sub

    Private Sub txt_Dad_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Dad_Name.TextChanged
        Sql = " AND AP_Books.Dad_Name LIKE N'%" & txt_Dad_Name.Text & "%' "
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
    End Sub

    Private Sub txt_Mobail1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Mobail1.TextChanged
        Sql = " AND AP_Books.Mobile2 LIKE N'%" & txt_Mobail1.Text & "%' "
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
    End Sub

    Private Sub txt_Mobail2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Mobail2.TextChanged
        Sql = " AND AP_Books.Mobile1 LIKE N'%" & txt_Mobail2.Text & "%' "
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
    End Sub

    Private Sub txtmom_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmom_name.TextChanged
        Sql = " AND AP_Books.Cust_nm LIKE N'%" & txtmom_name.Text & "%' "
        Call PageCnt(StrSQL, ConString, P, 500)
        Me.lblpage_total.Text = "1/" & Last_page
    End Sub

    Private Sub TxtDt_Nm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDt_Nm.SelectedIndexChanged
        Call LoadRs("Select *  From AP_District Where   Dt_nm =N'" & Trim(TxtDt_Nm.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtDistrict.Text = Trim(rs("Dt_id").Value)


            txtVillage_nm.Items.Clear()
            Call load_Cmb(" SELECT * FROM AP_Village  WHERE Dt_id='" & txtDistrict.Text & "' ORDER BY Vl_ID ", "Vl_nm", txtVillage_nm)
            If txtVillage_nm.Items.Count > 0 Then
                txtVillage_nm.SelectedIndex = 0
            End If


            txtVillage_nm.Text = ""
            txtVillage.Text = ""
            Village = ""
            Dristic = " AND AP_District.Dt_id = N'" & txtDistrict.Text & "' "
            Call PageCnt(StrSQL, ConString, P, 500)
            Me.lblpage_total.Text = "1/" & Last_page

        End If

    End Sub

    Private Sub txtVillage_nm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage_nm.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Village Where   Dt_id =N'" & Trim(txtDistrict.Text) & "'and   Vl_nm =N'" & Trim(txtVillage_nm.Text) & "' ", rs)
        If rs.RecordCount > 0 Then
            txtVillage.Text = Trim(rs("Vl_ID").Value)
            Village = " AND AP_Village.Vl_ID = N'" & txtVillage.Text & "' "
            Call PageCnt(StrSQL, ConString, P, 500)
            Me.lblpage_total.Text = "1/" & Last_page
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtFdate.Enabled = True
            txtTdate.Enabled = True
            Button9.Enabled = True
            'Sql = " AND AP_Books.Bill_Dt between '" & Format(txtFdate.Value, "yyyy-MM-dd") & "' AND '" & Format(txtTdate.Value, "yyyy-MM-dd") & "'   "
            P = 1
            Call PageCnt(StrSQL, ConString, P, 500)
            Me.lblpage_total.Text = "1/" & Last_page
        Else
            txtFdate.Enabled = False
            txtTdate.Enabled = False
            Button9.Enabled = False
            Sql = ""
            Call PageCnt(StrSQL, ConString, P, 500)
            Me.lblpage_total.Text = "1/" & Last_page
        End If
    End Sub
End Class