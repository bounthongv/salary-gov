Public Class FrmCustomers
    Public RSC As New ADODB.Recordset
    Public EditActive As Boolean
    Dim itemfgacc As Boolean
    Dim rs As New ADODB.Recordset
    Dim Sql As String
    Dim StrCus As String
    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        Pnl1.Visible = True
        PnL2.Visible = True
        BtnEdit.Enabled = False
        If MDEdit = 0 Then
            BtnSave.Enabled = False
        Else
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Pnl1.Visible = False
        PnL2.Visible = False
        BtnEdit.Enabled = True
        BtnSave.Enabled = False
    End Sub
  
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'If txtCust_id.Text = "" Then MsgBox("Please add customer ID", MsgBoxStyle.OkOnly) : txtCust_id.Focus() : Exit Sub
        If txtCust_nmL.Text = "" Then MsgBox("Please add customer name", MsgBoxStyle.OkOnly) : txtCust_nmL.Focus() : Exit Sub
        'If txtCty_id.Text = "" Then MsgBox("Please select customer type", MsgBoxStyle.OkOnly) : txtCty_id.Focus() : Exit Sub
        If txtCust_id.Text = "" Then
            Call Autonumber()
        Else

        End If
        If txtCust_id.Enabled = True Then
            Call loadrs("SELECT Cust_id FROM AP_Customers WHERE Cust_id = '" & Trim(txtCust_id.Text) & "'", RSC)
        End If
        Call Save()
        MsgBox("Save Complete!", MsgBoxStyle.OkOnly)
        Call LoadData()
        txtCust_id.Focus()
    End Sub
    Private Sub Autonumber()
        Dim VIOT As New ADODB.Recordset
        Call LoadRs("SELECT top 1 Cust_id from AP_Customers Order by Cust_id DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            txtCust_id.Text = Format(CDbl(CDbl(VIOT.Fields("Cust_id").Value) + 1), "00000")
        Else
            txtCust_id.Text = Format(1, "00000")
        End If
    End Sub
    Private Sub LoadData()
        Fg1.Rows = 1
        With rs
            Call LoadRs("SELECT     dbo.AP_Customers.*, dbo.AP_Province.PV_nm, dbo.AP_District.Dt_nm, dbo.AP_Village.Vl_nm " & _
                      " FROM         dbo.AP_Customers INNER JOIN " & _
                      " dbo.AP_Province ON dbo.AP_Customers.Province = dbo.AP_Province.PV_ID INNER JOIN " & _
                      " dbo.AP_District ON dbo.AP_Customers.District = dbo.AP_District.Dt_id INNER JOIN " & _
                      " dbo.AP_Village ON dbo.AP_Customers.Village = dbo.AP_Village.Vl_ID WHERE  dbo.AP_Customers.Cust_id<>'' " & Sql & " order by  dbo.AP_Customers.Cust_id", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("Cust_id").Value) & _
                    Chr(9) & (.Fields("Cust_nmL").Value) & _
                    Chr(9) & (.Fields("cust_depart").Value) & _
                    Chr(9) & (.Fields("Cty_id").Value) & _
                    Chr(9) & (.Fields("Phone").Value) & _
                    Chr(9) & (.Fields("Contact_PP").Value) & _
                    Chr(9) & (.Fields("Vl_nm").Value) & _
                    Chr(9) & (.Fields("Dt_nm").Value) & _
                    Chr(9) & (.Fields("PV_nm").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With

        fg2.Rows = 1
        With rs
            Call loadrs("select *  from AP_Customers WHERE Cust_id<>'' " & Sql & " order by Cust_id", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg2.AddItem(.AbsolutePosition & _
                    Chr(9) & CStr(.Fields("Cust_id").Value) & _
                    Chr(9) & CStr(.Fields("Cust_nmL").Value) & _
                    Chr(9) & (.Fields("cust_depart").Value) & _
                    Chr(9) & CStr(.Fields("Cty_id").Value) & _
                    Chr(9) & CStr(.Fields("Phone").Value) & _
                    Chr(9) & CStr(.Fields("Contact_PP").Value) & _
                    Chr(9) & CStr(.Fields("Village").Value) & _
                    Chr(9) & CStr(.Fields("District").Value) & _
                    Chr(9) & CStr(.Fields("Province").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub
    Private Sub Save()
        Call loadrs("SELECT Cust_id FROM AP_Customers WHERE Cust_id = '" & txtCust_id.Text & "'", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_Customers (Shop_ID,Cust_id,CTy_id,Cust_nmL, " & _
                "Cust_nmE,cust_depart,street,Village, " & _
                "District,Province,Phone,Fax,Bank_accnt,Contact_PP,Lst_order,Remark,Lst_updt,Lst_usr,Pc_nm) " & _
                   " VALUES( ' STOCK ', N'" & Apostrophe(txtCust_id.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtCty_id.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtCust_nmL.Text.Trim) & "'," & _
                   " '" & Apostrophe(txtCust_nmE.Text.Trim) & "'," & _
                   " '" & Apostrophe(txtCust_Depart.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtstreet.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtVillage.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtDistrict.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtProvince.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtPhone.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtFax.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtBank_accnt.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtContact_PP.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtLst_order.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtRemark.Text.Trim) & "'," & _
                   " Getdate()," & _
                   " '" & MUserName & "'," & _
                   " '" & MDServerName & "')")
            Else

                'Conn.Execute("INSERT INTO AP_Customers_ED (Shop_ID, Cty_id,Cust_id,Cust_nmL,Cust_nmE,cust_depart,street,Village,District,Province,Phone,Fax,Bank_accnt,Contact_PP,Lst_order,Remark,Lst_updt,Lst_usr,Pc_nm) " & _
                '" SELECT Shop_ID, Cty_id,Cust_id,Cust_nmL,Cust_nmE,cust_depart,street,Village,District,Province,Phone,Fax,Bank_accnt,Contact_PP,Lst_order,Remark,Lst_updt,Lst_usr,Pc_nm FROM AP_Customers WHERE Cust_ID='" & Trim(Me.txtCust_id.Text) & "'")

                Conn.Execute("UPDATE AP_Customers SET " & _
                   " CTy_id=N'" & txtCty_id.Text & "'," & _
                   " Cust_nmL=N'" & txtCust_nmL.Text & "'," & _
                   " Cust_nmE='" & (txtCust_nmE.Text) & "'," & _
                   " cust_depart=N'" & (txtCust_Depart.Text) & "'," & _
                   " street=N'" & txtstreet.Text & "'," & _
                   " Village=N'" & (txtVillage.Text) & "'," & _
                   " District=N'" & txtDistrict.Text & "'," & _
                   " Province=N'" & txtProvince.Text & "'," & _
                   " Phone=N'" & (txtPhone.Text) & "'," & _
                   " Fax=N'" & txtFax.Text & "'," & _
                   " Bank_accnt=N'" & (txtBank_accnt.Text) & "'," & _
                   " Contact_PP=N'" & txtContact_PP.Text & "'," & _
                   " Lst_order=N'" & (txtLst_order.Text) & "'," & _
                   " Remark=N'" & txtRemark.Text & "'," & _
                   " Lst_usr='" & MUserName & "'," & _
                   " Lst_updt=Getdate()," & _
                   "Pc_nm='" & MDServerName & "'" & _
                   "WHERE Cust_id= '" & (txtCust_id.Text) & "'") 'rate_dt
            End If
            '    " Rec_Cnt='" & (txtRec_cnt.Text) & "'," & _
        End With
    End Sub
    Private Sub FrmCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtVillage_nm.Items.Clear()
        Call load_Cmb(" SELECT PV_nm FROM AP_Province ORDER BY PV_ID ", "PV_nm", TxtPV_NM)
        If TxtPV_NM.Items.Count > 0 Then
            TxtPV_NM.SelectedIndex = 0
        End If
        Call LoadData()
        If MDLanguage = 0 Then
            LangLao()
        Else
            Call Langs()
        End If

        If MDWrite = 0 Then
            Button9.Enabled = False
            BtnSave.Enabled = False
        Else
            Button9.Enabled = True
            BtnSave.Enabled = True
        End If
        'If MDEdit = 0 Then
        '    BtnSave.Enabled = False
        'Else
        '    BtnSave.Enabled = True
        'End If
        If MDDelete = 0 Then
            Button7.Enabled = False
        Else
            Button7.Enabled = True
        End If
    End Sub
    Public Sub Langs()
        Button9.Text = "AddNew"
        Button7.Text = "Delete"
        Button2.Text = "Hide"
        BtnEdit.Text = "Edit"
        BtnSave.Text = "Save"
        BtnShow.Text = "Show"
        Label1.Text = "CustomerID:"
        Label2.Text = "Customer name(Lao):"
        Label3.Text = "Customer name(Eng):"
        Label4.Text = "Street:"
        Label5.Text = "Village:"
        Label6.Text = "District:"
        Label7.Text = "Province:"
        Label8.Text = "Phone number:"
        Label9.Text = "Fax:"
        Label10.Text = "Bank_accnt:"
        Label11.Text = "House No:"
        Label12.Text = "Customer type:"
        Label13.Text = "Date order:"
        Label14.Text = "Remark:"
        Fg1.FormatString = "NO|<CustomerID |<Customer name(Lao)        |<Series parts               |<Customer type  |<Phone number       |<Contact     |<Village  |<District        |<Province         "
        fg2.FormatString = "NO|<CustomerID |<Customer name(Lao)        |<Series parts                |<Customer type  |<Phone number       |<Contact      |<Village  |<District        |<Province         "

    End Sub
    Public Sub LangLao()
        Button9.Text = "ເພີ່ມໃໝ່"
        Button7.Text = "ລຶບ"
        Button2.Text = "ເຊື່ອງ"
        BtnEdit.Text = "ແກ້ໄຂ"
        BtnSave.Text = "ບັນທຶກ"
        BtnShow.Text = "ໂຊ"
        Label1.Text = "ລະຫັດລູກຄ້າ:"
        Label2.Text = "ຊື່ ລູກຄ້າ(Lao):"
        Label3.Text = "ຊື່ ລູກຄ້າ(Eng):"
        Label4.Text = "ຖະໜົນ:"
        Label5.Text = "ບ້ານ:"
        Label6.Text = "ເມືອງ:"
        Label7.Text = "ແຂວງ:"
        Label8.Text = "ເບີໂທລະສັບ:"
        Label9.Text = "ແຝັກ:"
        Label10.Text = "ເລກບັນຊີທະນາຄານ:"
        Label11.Text = "ເຮືອນເລກທີ່:"
        Label12.Text = "ປະເພດລູກຄ້າ:"
        Label13.Text = "ວັນທີ່ສັ່ງຊື້ລ່າສຸດ:"
        Label14.Text = "ໝາຍເຫດ:"
        Fg1.FormatString = "ລ/ດ|<ລະຫັດລູກຄ້າ |<ຊື່ ລູກຄ້າ(Lao)        |<ພາກສ່ວນ  |<ປະເພດ ລູກຄ້າ|<ເບີໂທລະສັບ       |<ຕິດຕໍ່ພົວພັນ     |<ບ້ານ             |<ເມືອງ                |<ແຂວງ         "
        fg2.FormatString = "ລ/ດ|<ລະຫັດລູກຄ້າ |<ຊື່ ລູກຄ້າ(Lao)        |<ພາກສ່ວນ  |<ປະເພດ ລູກຄ້າ|<ເບີໂທລະສັບ       |<ຕິດຕໍ່ພົວພັນ      |<ບ້ານ            |<ເມືອງ                 |<ແຂວງ         "

    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If txtCust_id.Text = "" Then
            Exit Sub
        Else
            'Dim RSC As New ADODB.Recordset
            'Call LoadRs("Select Bill_no From AP_SaleForStock WHERE Cust_ID='" & txtCust_id.Text & "'", RSC)
            'If RSC.RecordCount <> 0 Then MsgBox("You do not delete '" & txtCust_id.Text & "' because Activity", MsgBoxStyle.OkOnly) : RSC = Nothing : Exit Sub

            'Call LoadRs("Select Bill_no From AP_SaleForStockDE WHERE Cust_ID='" & txtCust_id.Text & "'", RSC)
            'If RSC.RecordCount <> 0 Then MsgBox("You do not delete '" & txtCust_id.Text & "' because Activity", MsgBoxStyle.OkOnly) : RSC = Nothing : Exit Sub

            'Call LoadRs("Select Bill_no From AP_SaleForStockPO WHERE Cust_ID='" & txtCust_id.Text & "'", RSC)
            'If RSC.RecordCount <> 0 Then MsgBox("You do not delete '" & txtCust_id.Text & "' because Activity", MsgBoxStyle.OkOnly) : RSC = Nothing : Exit Sub

            Dim Rsch As New ADODB.Recordset
            AccCD = Trim(txtCust_id.Text)
            If MessageBox.Show("Do you want to delete '" & AccCD & "' yes or no ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'Conn.BeginTrans()
                Conn.Execute("delete from AP_Customers where Cust_id='" & AccCD & "'")
                ' Conn.Execute("INSERT INTO AP_Customers_ED(Shop_ID, Cty_id,Cust_id,Cust_nmL,Cust_nmE,cust_depart,street,Village,District,Province,Phone,Fax,Bank_accnt,Contact_PP,Lst_order,Remark,Lst_updt,Lst_usr,Pc_nm) " & _
                '" Select Shop_ID, Cty_id,Cust_id,Cust_nmL,Cust_nmE,cust_depart,street,Village,District,Province,Phone,Fax,Bank_accnt,Contact_PP,Lst_order,Remark, getdate(), '" & MUserName & "', '" & MDServerName & "' From AP_Customers WHERE Cust_id='" & txtCust_id.Text & "'")
                ' Conn.CommitTrans()
                Call LoadData()
                Call ClearText()
            End If
        End If
    End Sub
    Private Sub ClearText()
        txtCust_id.Text = ""
        txtCust_nmL.Text = ""
        txtCust_nmE.Text = ""
        txtCust_Depart.Text = ""
        txtVillage_nm.Text = ""
        txtDistrict.Text = ""
        'txtProvince.Text = ""
        txtPhone.Text = ""
        txtFax.Text = ""
        txtBank_accnt.Text = ""
        txtContact_PP.Text = ""
        txtLst_order.Text = ""
        txtRemark.Text = ""
        txtstreet.Text = ""
        txtCty_id.Text = ""
        txtCty_Nm.Text = ""
        txtCust_id.Enabled = True
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Pnl1.Visible = True
        PnL2.Visible = True
        BtnEdit.Enabled = False
        BtnSave.Enabled = True
        Call ClearText()
        txtCust_nmL.Focus()
        txtCust_id.Enabled = False

        txtVillage.Text = ""
        txtVillage_nm.Text = ""
        txtDistrict.Text = ""
        TxtDt_Nm.Text = ""
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Pnl1.Visible = True
        PnL2.Visible = True
        txtCust_id.Enabled = False
        BtnEdit.Enabled = False
        If MDEdit = 0 Then
            BtnSave.Enabled = False
        Else
            BtnSave.Enabled = True
        End If
        txtCust_nmL.Focus()
    End Sub

    Private Sub fg2_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg2.DblClick
        If MDEdit = 0 Then Exit Sub
        Dim FGSel As New ADODB.Recordset
        With FGSel
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            Dim sa As String = "SELECT     dbo.AP_Customers.*, dbo.AP_Province.PV_nm, dbo.AP_District.Dt_nm, dbo.AP_Village.Vl_nm " & _
                     " FROM         dbo.AP_Customers INNER JOIN " & _
                     " dbo.AP_Province ON dbo.AP_Customers.Province = dbo.AP_Province.PV_ID INNER JOIN " & _
                     " dbo.AP_District ON dbo.AP_Customers.District = dbo.AP_District.Dt_id INNER JOIN " & _
                     " dbo.AP_Village ON dbo.AP_Customers.Village = dbo.AP_Village.Vl_ID Where Cust_id='" & fg2.get_TextMatrix(fg2.Row, 1) & "' "
            Call LoadRs(sa, rs)
            If rs.RecordCount <> 0 Then
                txtCust_id.Text = CStr(rs.Fields("Cust_id").Value.ToString)
                txtCust_nmL.Text = CStr(rs.Fields("Cust_nmL").Value.ToString)
                txtCust_nmE.Text = CStr(rs.Fields("Cust_nmE").Value.ToString)
                txtCust_Depart.Text = CStr(rs.Fields("cust_depart").Value.ToString)
                txtstreet.Text = CStr(rs.Fields("street").Value.ToString)
                txtVillage.Text = CStr(rs.Fields("Village").Value.ToString)
                txtVillage_nm.Text = CStr(rs.Fields("Vl_nm").Value.ToString)
                txtDistrict.Text = CStr(rs.Fields("District").Value.ToString)
                TxtDt_Nm.Text = CStr(rs.Fields("Dt_nm").Value.ToString)
                txtProvince.Text = CStr(rs.Fields("Province").Value.ToString)
                TxtPV_NM.Text = CStr(rs.Fields("PV_nm").Value.ToString)
                txtPhone.Text = CStr(rs.Fields("Phone").Value.ToString)
                txtFax.Text = CStr(rs.Fields("Fax").Value.ToString)
                txtBank_accnt.Text = CStr(rs.Fields("Bank_accnt").Value.ToString)
                txtContact_PP.Text = CStr(rs.Fields("Contact_PP").Value.ToString)
                txtLst_order.Text = CStr(rs.Fields("Lst_order").Value.ToString)
                txtRemark.Text = CStr(rs.Fields("Remark").Value.ToString)
                txtCust_id.Enabled = False
            End If
        End With
        txtCust_nmL.Focus()
    End Sub
    Private Sub fg2_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg2.SelChange
       
    End Sub
    Private Sub Fg1_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg1.DblClick
        Pnl1.Visible = True
        PnL2.Visible = True
        BtnEdit.Enabled = False
        BtnSave.Enabled = True
    End Sub
    Private Sub Fg1_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg1.SelChange
        If MDEdit = 0 Then Exit Sub
        Dim FGSel As New ADODB.Recordset
        With FGSel
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .Open("Select AP_Customers.*,AP_Cust_type.CTy_nmL From AP_Customers INNER JOIN AP_Cust_type ON AP_Customers.Cty_id=AP_Cust_type.Cty_id  Where(Cust_id='" & _
        Fg1.get_TextMatrix(Fg1.Row, 1) & "')", Conn, _
             ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
            If .RecordCount <> 0 Then
                txtCust_id.Text = CStr(.Fields("Cust_id").Value.ToString)
                txtCust_nmL.Text = CStr(.Fields("Cust_nmL").Value.ToString)
                txtCust_nmE.Text = CStr(.Fields("Cust_nmE").Value.ToString)
                txtCust_Depart.Text = CStr(.Fields("cust_depart").Value.ToString)
                txtstreet.Text = CStr(.Fields("street").Value.ToString)
                txtVillage_nm.Text = CStr(.Fields("Village").Value.ToString)
                txtDistrict.Text = CStr(.Fields("District").Value.ToString)
                txtProvince.Text = CStr(.Fields("Province").Value.ToString)
                txtPhone.Text = CStr(.Fields("Phone").Value.ToString)
                txtFax.Text = CStr(.Fields("Fax").Value.ToString)
                txtBank_accnt.Text = CStr(.Fields("Bank_accnt").Value.ToString)
                txtContact_PP.Text = CStr(.Fields("Contact_PP").Value.ToString)
                txtLst_order.Text = CStr(.Fields("Lst_order").Value.ToString)
                txtRemark.Text = CStr(.Fields("Remark").Value.ToString)
                txtCty_id.Text = CStr(.Fields("Cty_id").Value.ToString)
                txtCty_Nm.Text = CStr(.Fields("CTy_nmL").Value.ToString)
                txtCust_id.Enabled = False
            End If
        End With
        txtCust_nmL.Focus()
    End Sub
    Private Sub txtCty_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rsPrv As New ADODB.Recordset
        Call loadrs("select * from AP_Cust_type WHERE CTy_id='" & txtCty_id.Text.Trim & "'", rsPrv)
        If rsPrv.RecordCount > 0 Then
            txtCty_Nm.Text = rsPrv.Fields("CTy_nmL").Value.ToString
        End If
    End Sub
    Private Sub CMBCty_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call loadrs("SELECT CTy_id,CTy_nmL FROM AP_Cust_type WHERE CTy_nmL='" & txtCty_Nm.Text & "'", rs)
        If rs.RecordCount <> 0 Then
            txtCty_id.Text = rs.Fields("CTy_id").Value
        End If
    End Sub
    Private Sub txtCty_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCty_id.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    Call LoadRs("SELECT CTy_id,CTy_nmL FROM AP_Cust_type WHERE CTy_id='" & txtCty_id.Text & "'", rs)
        '    If rs.RecordCount = 0 Then
        '        txtCty_id.Text = ""
        '        txtCty_Nm.Text = ""
        '        Button3_Click(sender, e)
        '    Else
        '        txtCty_id.Text = CStr(rs.Fields("CTy_id").Value.ToString)
        '        txtCty_Nm.Text = CStr(rs.Fields("CTy_nmL").Value.ToString)
        '        txtLst_order.Focus()
        '    End If
        'End If
    End Sub

    Private Sub txtCty_id_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCty_id.LostFocus
        '  If txtCty_id.Text = "" Then txtCty_id.Text = txtCty_id.Text : Exit Sub
    End Sub
    Private Sub txtCty_id_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCty_id.TextChanged
        'Call LoadRs("SELECT CTy_id,CTy_nmL FROM AP_Cust_type WHERE CTy_id='" & StrCus & "'", rs)
        'If rs.RecordCount > 0 Then
        '    txtCty_Nm.Text = CStr(rs.Fields("CTy_nmL").Value.ToString)
        'End If
    End Sub

    Private Sub txtCust_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCust_id.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCust_nmL.Focus()
        End If
    End Sub

    Private Sub txtCust_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCust_id.TextChanged

    End Sub

    Private Sub txtCust_nmL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCust_nmL.KeyPress, txtCust_Depart.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCust_nmE.Focus()
        End If
    End Sub

    Private Sub txtCust_nmL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCust_nmL.TextChanged, txtCust_Depart.TextChanged

    End Sub

    Private Sub txtCust_nmE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCust_nmE.KeyPress
        If e.KeyChar = Chr(13) Then
            txtstreet.Focus()
        End If
    End Sub

    Private Sub txtCust_nmE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCust_nmE.TextChanged

    End Sub

    Private Sub txtstreet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstreet.KeyPress
        If e.KeyChar = Chr(13) Then
            txtVillage_nm.Focus()
        End If
    End Sub

    Private Sub txtstreet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstreet.TextChanged

    End Sub

    Private Sub txtVillage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtDistrict.Focus()
        End If
    End Sub

    Private Sub txtVillage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtDistrict_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtProvince.Focus()
        End If
    End Sub

    Private Sub txtDistrict_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtProvince_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtPhone.Focus()
        End If
    End Sub

    Private Sub txtProvince_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        If e.KeyChar = Chr(13) Then
            txtFax.Focus()
        End If
    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub txtFax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFax.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBank_accnt.Focus()
        End If
    End Sub

    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged

    End Sub

    Private Sub txtBank_accnt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBank_accnt.KeyPress
        If e.KeyChar = Chr(13) Then
            txtContact_PP.Focus()
        End If
    End Sub

    Private Sub txtBank_accnt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank_accnt.TextChanged

    End Sub

    Private Sub txtContact_PP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact_PP.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCty_id.Focus()
        End If
    End Sub

    Private Sub txtContact_PP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact_PP.TextChanged

    End Sub

    Private Sub txtLst_order_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLst_order.KeyPress
        If e.KeyChar = Chr(13) Then
            txtRemark.Focus()
        End If
    End Sub

    Private Sub txtLst_order_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLst_order.TextChanged

    End Sub

    Private Sub txtRemark_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRemark.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    If txtCust_id.Text = "" Then MsgBox("ກະລຸນາໃສ່ລະຫັດລູກຄ້າກ່ອນ", MsgBoxStyle.OkOnly) : txtCust_id.Focus() : Exit Sub
        '    If txtCust_nmL.Text = "" Then MsgBox("ກະລຸນາໃສ່ຊື່ລູກຄ້າກ່ອນ", MsgBoxStyle.OkOnly) : txtCust_nmL.Focus() : Exit Sub
        '    If txtCty_id.Text = "" Then MsgBox("ກະລຸນາເລືອກປະເພດລູກຄ້າກ່ອນ", MsgBoxStyle.OkOnly) : txtCty_id.Focus() : Exit Sub
        '    BtnSave_Click(sender, e)
        'End If
    End Sub

    Private Sub txtRemark_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemark.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TxtPV_NM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage_nm.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Village Where   Dt_id =N'" & Trim(txtDistrict.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtVillage.Text = Trim(rs("Vl_ID").Value)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage_nm.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPV_NM.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Province Where   PV_nm =N'" & Trim(TxtPV_NM.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtProvince.Text = Trim(rs("PV_ID").Value)
        End If


        TxtDt_Nm.Items.Clear()
        Call load_Cmb(" SELECT Dt_nm FROM AP_District  WHERE PV_ID='" & txtProvince.Text & "' ORDER BY Dt_id ", "Dt_nm", TxtDt_Nm)
        If TxtDt_Nm.Items.Count > 0 Then
            TxtDt_Nm.SelectedIndex = 0
            TxtDt_Nm.Text = ""
            txtDistrict.Text = ""

        End If
    End Sub

    Private Sub TxtDt_Nm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDt_Nm.SelectedIndexChanged
        Call LoadRs("Select *  From AP_District Where   Dt_nm =N'" & Trim(TxtDt_Nm.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtDistrict.Text = Trim(rs("Dt_id").Value)
        End If


        txtVillage_nm.Items.Clear()
        Call load_Cmb(" SELECT * FROM AP_Village  WHERE Dt_id='" & txtDistrict.Text & "' ORDER BY Vl_ID ", "Vl_nm", txtVillage_nm)
        If txtVillage_nm.Items.Count > 0 Then
            txtVillage_nm.SelectedIndex = 0
          

        End If
    End Sub
End Class