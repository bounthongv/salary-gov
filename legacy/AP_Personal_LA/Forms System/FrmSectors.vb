Public Class FrmSectors
    Public RSC As New ADODB.Recordset
    Public EditActive As Boolean
    Dim itemfgacc As Boolean
    Dim rs As New ADODB.Recordset
    Dim Sql As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '
        Me.Close()
    End Sub
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
    Private Sub FrmSectors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        If MDLanguage = 0 Then
            LangLao()
        Else
            Call Langs()
        End If

        Pnl1.Visible = False
        PnL2.Visible = False
        BtnEdit.Enabled = True
        BtnSave.Enabled = False
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
        Label1.Text = "SectionID:"
        Label2.Text = "Section name(Lao):"
        Label3.Text = "Section name(Eng):"
        Label4.Text = "Address:"
        Label5.Text = "Phone number:"
        Label6.Text = "Fax:"
        Label7.Text = "Contact:"
        Label8.Text = "Remark:"
        ChFor_Shop.Text = "For shop"
        Fg1.FormatString = "NO|<SectionID  |<Section name(Lao)    |<Phone number           |<Contact   "
        Fg2.FormatString = "NO|<SectionID  |<Section name(Lao)    |<Phone number           |<Contact   "
    End Sub
    Public Sub LangLao()
        Button9.Text = "ເພີ່ມໃໝ່"
        Button7.Text = "ລຶບ"
        Button2.Text = "ເຊື່ອງ"
        BtnEdit.Text = "ແກ້ໄຂ"
        BtnSave.Text = "ບັນທຶກ"
        BtnShow.Text = "ໂຊ"
        Label1.Text = "ລະຫັດພະແນກ:"
        Label2.Text = "ຊື່ ພະແນກ(Lao):"
        Label3.Text = "ຊື່ ພະແນກ(Eng):"
        Label4.Text = "ທີ່ຢູ່:"
        Label5.Text = "ເບີໂທລະສັບ:"
        Label6.Text = "ແຝັກ:"
        Label7.Text = "ຕິດຕໍ່ພົວພັນ:"
        Label8.Text = "ໝາຍເຫດ:"
        ChFor_Shop.Text = "For shop"
        Fg1.FormatString = "ລ/ດ|<ລະຫັດພະແນກ  |<ຊື່ ພະແນກ(Lao)                  |<ຊື່ ພະແນກ(E)            |<ເບີໂທລະສັບ           |<ຕິດຕໍ່ພົວພັນ  "
        Fg2.FormatString = "NO|<ລະຫັດພະແນກ   |<ຊື່ ພະແນກ(Lao)                 |<ຊື່ ພະແນກ(E)             |<ເບີໂທລະສັບ           |<ຕິດຕໍ່ພົວພັນ   "
    End Sub
    Private Sub LoadData()
        Fg1.Rows = 1
        With rs
            Call loadrs("select *  from AP_Sections WHERE Sec_id<>'' " & Sql & " order by Sec_id", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("Sec_id").Value.ToString) & _
                    Chr(9) & (.Fields("Sec_nmL").Value.ToString) & _
                    Chr(9) & (.Fields("Sec_nmE").Value.ToString) & _
                    Chr(9) & (.Fields("phone").Value.ToString) & _
                    Chr(9) & (.Fields("Contact_PP").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With

        Fg2.Rows = 1
        With rs
            Call loadrs("select *  from AP_Sections WHERE Sec_id<>'' " & Sql & " order by Sec_id", rs)

            If .RecordCount > 0 Then
                While Not .EOF()
                    Fg2.AddItem(.AbsolutePosition & _
                  Chr(9) & (.Fields("Sec_id").Value.ToString) & _
                  Chr(9) & (.Fields("Sec_nmL").Value.ToString) & _
                  Chr(9) & (.Fields("Sec_nmE").Value.ToString) & _
                  Chr(9) & (.Fields("phone").Value.ToString) & _
                  Chr(9) & (.Fields("Contact_PP").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If txtSec_id.Text = "" Then MsgBox("Please add section ID", MsgBoxStyle.OkOnly) : txtSec_id.Focus() : Exit Sub
        If txtSec_nmL.Text = "" Then MsgBox("Please add section name", MsgBoxStyle.OkOnly) : txtSec_nmL.Focus() : Exit Sub
        If txtSec_id.Enabled = True Then
            Call LoadRs("SELECT Sec_id FROM AP_Sections WHERE Sec_id = N'" & Trim(txtSec_id.Text) & "'", RSC)
            If RSC.RecordCount > 0 Then
                MsgBox("Section ID : " & Trim(txtSec_id.Text) & " have in data base please to change!", MsgBoxStyle.OkOnly)
                txtSec_id.Focus()
                If RSC.State = ConnectionState.Open Then RSC.Close()
                Exit Sub
            End If
            If RSC.State = ConnectionState.Open Then RSC.Close()
        End If
        Call Save()
        MsgBox("Save Complete!", MsgBoxStyle.OkOnly)
        Call LoadData()
    End Sub
    Private Sub Save()
        Dim ForAShop As Integer
        If ChFor_Shop.Checked = True Then
            ForAShop = 1
        Else
            ForAShop = 0
        End If
        Call LoadRs("SELECT Sec_id FROM AP_Sections WHERE Sec_id = N'" & txtSec_id.Text & "'", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_Sections (Sec_id,Sec_nmL,Sec_nmE,Group_Sec_id,Group_Sec_nm,address,phone, " & _
                "Fax,Contact_PP,remark,For_Shop,lst_updt,lst_usr,Pc_nm) " & _
                   " VALUES(N'" & Apostrophe(txtSec_id.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtSec_nmL.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtSec_nmE.Text.Trim) & "'," & _
                        " N'" & Apostrophe(txtsakha_id.Text.Trim) & "'," & _
                             " N'" & Apostrophe(cmb_sakha.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtaddress.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtphone.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtFax.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtContact_PP.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtremark.Text.Trim) & "'," & _
                   " N'" & CDbl(ForAShop) & "'," & _
                   " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " N'" & MDServerName & "')")
            Else
                Conn.Execute("UPDATE AP_Sections SET " & _
                   " Sec_nmL=N'" & txtSec_nmL.Text & "'," & _
                   " Sec_nmE=N'" & (txtSec_nmE.Text) & "'," & _
                    " Group_Sec_id=N'" & txtsakha_id.Text & "'," & _
                   " Group_Sec_nm=N'" & (cmb_sakha.Text) & "'," & _
                   " address=N'" & txtaddress.Text & "'," & _
                   " phone=N'" & (txtphone.Text) & "'," & _
                   " Fax=N'" & txtFax.Text & "'," & _
                   " Contact_PP=N'" & (txtContact_PP.Text) & "'," & _
                   " remark=N'" & txtremark.Text & "'," & _
                   " For_Shop='" & CDbl(ForAShop) & "'," & _
                   " Lst_updt=Getdate()," & _
                   " Lst_usr=N'" & MUserName & "'," & _
                   " Pc_nm=N'" & MDServerName & "' " & _
                   "WHERE Sec_id= N'" & (txtSec_id.Text) & "'")
            End If
        End With
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Pnl1.Visible = True
        PnL2.Visible = True
        BtnSave.Enabled = True
        BtnEdit.Enabled = False
        Call ClearText()
    End Sub
    Private Sub ClearText()
        txtSec_id.Text = ""
        txtSec_nmL.Text = ""
        txtSec_nmE.Text = ""
        txtaddress.Text = ""
        txtphone.Text = ""
        txtFax.Text = ""
        txtContact_PP.Text = ""
        txtremark.Text = ""
        ChFor_Shop.Checked = False
        txtSec_id.Enabled = True
        txtSec_id.Focus()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Pnl1.Visible = True
        PnL2.Visible = True
        If MDEdit = 0 Then
            BtnSave.Enabled = False
        Else
            BtnSave.Enabled = True
        End If
        BtnEdit.Enabled = False
        txtSec_id.Enabled = False
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If txtSec_id.Text = "" Then
            Exit Sub
        Else
            AccCD = Trim(txtSec_id.Text)
            'Call LoadRs("Select Bill_no From AP_Bills WHERE Sec_id=N'" & AccCD & "'", rs)
            'If rs.RecordCount <> 0 Then MsgBox("You do not delete '" & AccCD & "' because activity", MsgBoxStyle.OkOnly) : Exit Sub

            Call LoadRs("Select * From AP_Users WHERE Sec_id=N'" & AccCD & "'", rs)
            If rs.RecordCount <> 0 Then MsgBox("You do not delete '" & AccCD & "' because activity", MsgBoxStyle.OkOnly) : Exit Sub

            If MessageBox.Show("Do you want to delete '" & AccCD & "' yes or no  ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Conn.BeginTrans()
                Conn.Execute("delete from AP_Sections where Sec_id=N'" & AccCD & "'")
                Conn.Execute("INSERT INTO AP_Sections_ED (Sec_id, Sec_nmL, Sec_nmE, address, phone, Fax, Contact_PP, remark, For_Shop, lst_usr, lst_updt, Pc_nm) " & _
                "SELECT Sec_id, Sec_nmL, Sec_nmE, address, phone, Fax, Contact_PP, remark, For_Shop, lst_usr, lst_updt, Pc_nm From AP_Sections WHERE Sec_id=N'" & txtSec_id.Text & "'")

                Conn.CommitTrans()
                Call LoadData()
                Call ClearText()
            End If
        End If
    End Sub
    Private Sub Fg2_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg2.SelChange
        If MDEdit = 0 Then Exit Sub
        txtSec_id.Enabled = False
        Dim FGSel As New ADODB.Recordset
        Dim ForAShop As Integer
        With FGSel
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .Open("Select * From AP_Sections Where(Sec_id=N'" & _
        Fg2.get_TextMatrix(Fg2.Row, 1) & "')", Conn, _
             ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
            If .RecordCount <> 0 Then
                cmb_sakha.Text = CStr(.Fields("Group_Sec_nm").Value.ToString)
                txtSec_id.Text = CStr(.Fields("Sec_id").Value.ToString)
                txtSec_nmE.Text = CStr(.Fields("Sec_nmE").Value.ToString)
                txtSec_nmL.Text = CStr(.Fields("Sec_nmL").Value.ToString)
                txtaddress.Text = CStr(.Fields("address").Value.ToString)
                txtphone.Text = CStr(.Fields("phone").Value.ToString)
                txtFax.Text = CStr(.Fields("Fax").Value.ToString)
                txtContact_PP.Text = CStr(.Fields("Contact_PP").Value.ToString)
                txtremark.Text = CStr(.Fields("remark").Value.ToString)
                ForAShop = CDbl(.Fields("For_Shop").Value)
            End If
        End With
        If ForAShop = 0 Then
            ChFor_Shop.Checked = False
        Else
            ChFor_Shop.Checked = True
        End If
    End Sub
    Private Sub Fg1_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg1.DblClick
        Pnl1.Visible = True
        PnL2.Visible = True
        BtnSave.Enabled = True
        BtnEdit.Enabled = False
        txtSec_id.Enabled = False
    End Sub
    Private Sub Fg1_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg1.SelChange
        If MDEdit = 0 Then Exit Sub
        Dim FGSel As New ADODB.Recordset
        Dim ForAShop As Integer
        With FGSel
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .Open("Select * From AP_Sections Where(Sec_id=N'" & _
        Fg1.get_TextMatrix(Fg1.Row, 1) & "')", Conn, _
             ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
            If .RecordCount <> 0 Then
                txtSec_id.Text = CStr(.Fields("Sec_id").Value.ToString)
                txtSec_nmE.Text = CStr(.Fields("Sec_nmE").Value.ToString)
                txtSec_nmL.Text = CStr(.Fields("Sec_nmL").Value.ToString)
                txtaddress.Text = CStr(.Fields("address").Value.ToString)
                txtphone.Text = CStr(.Fields("phone").Value.ToString)
                txtFax.Text = CStr(.Fields("Fax").Value.ToString)
                txtContact_PP.Text = CStr(.Fields("Contact_PP").Value.ToString)
                txtremark.Text = CStr(.Fields("remark").Value.ToString)
                ForAShop = CDbl(.Fields("For_Shop").Value)
                txtSec_id.Enabled = False
            End If
        End With
        If ForAShop = 0 Then
            ChFor_Shop.Checked = False
        Else
            ChFor_Shop.Checked = True
        End If
    End Sub

    Private Sub txtSec_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSec_id.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSec_nmL.Focus()
        End If
    End Sub

    Private Sub txtSec_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSec_id.TextChanged

    End Sub

    Private Sub txtSec_nmL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSec_nmL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSec_nmE.Focus()
        End If
    End Sub

    Private Sub txtSec_nmL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSec_nmL.TextChanged

    End Sub

    Private Sub txtSec_nmE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSec_nmE.KeyPress
        If e.KeyChar = Chr(13) Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub txtSec_nmE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSec_nmE.TextChanged

    End Sub

    Private Sub txtaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddress.KeyPress
        If e.KeyChar = Chr(13) Then
            txtphone.Focus()
        End If
    End Sub

    Private Sub txtaddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub txtphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress
        If e.KeyChar = Chr(13) Then
            txtFax.Focus()
        End If
    End Sub

    Private Sub txtphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone.TextChanged

    End Sub

    Private Sub txtFax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFax.KeyPress
        If e.KeyChar = Chr(13) Then
            txtContact_PP.Focus()
        End If
    End Sub

    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged

    End Sub

    Private Sub txtContact_PP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact_PP.KeyPress
        If e.KeyChar = Chr(13) Then
            txtremark.Focus()
        End If
    End Sub

    Private Sub txtContact_PP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact_PP.TextChanged

    End Sub

    Private Sub cmb_sakha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_sakha.SelectedIndexChanged
        If cmb_sakha.SelectedIndex = 0 Then
            txtsakha_id.Text = "01"
        Else
            txtsakha_id.Text = "02"
        End If
    End Sub
End Class