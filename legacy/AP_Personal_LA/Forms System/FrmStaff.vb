Public Class FrmStaff
    Public RSC As New ADODB.Recordset
    Public EditActive As Boolean
    Dim itemfgacc As Boolean
    Dim rs As New ADODB.Recordset
    Dim Sql As String
    Private Sub FrmStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        If MDLanguage = 0 Then
            Call LangLao()
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

        If Staff_Add_New = 1 Then
            Pnl.Visible = True
            PnL2.Visible = True
            BtnSave.Enabled = True
            BtnEdit.Enabled = False
            Call ClearText()
        ElseIf Staff_Add_New = 0 Then

        End If
    End Sub
    Public Sub Langs()
        Button9.Text = "AddNew"
        Button7.Text = "Delete"
        Button2.Text = "Hide"
        BtnEdit.Text = "Edit"
        BtnSave.Text = "Save"
        BtnShow.Text = "Show"
        Label1.Text = "StaffID:"
        Label2.Text = "Staff name(Lao):"
        Label3.Text = "Staff name(Eng):"
        Label4.Text = "Street:"
        Label5.Text = "Village:"
        Label6.Text = "District:"
        Label7.Text = "Province:"
        Label8.Text = "Phone number:"
        Label9.Text = "Contact:"
        Fg1.FormatString = "NO|<StaffID  |<Staff name    |<Phone number           |<Contact    |<Village            |<District            |<Province"
        Fg2.FormatString = "NO|<StaffID  |<Staff name    |<Phone number           |<Contact    |<Village            |<District            |<Province"

    End Sub
    Public Sub LangLao()
        Button9.Text = "ເພີ່ມໃໝ່"
        Button7.Text = "ລຶບ"
        Button2.Text = "ເຊື່ອງ"
        BtnEdit.Text = "ແກ້ໄຂ"
        BtnSave.Text = "ບັນທຶກ"
        BtnShow.Text = "ໂຊ"
        Label1.Text = "ລະຫັດພະນັກງານ:"
        Label2.Text = "ຊື່ ພະນັກງານ(Lao):"
        Label3.Text = "ຊື່ ພະນັກງານ(Eng):"
        Label4.Text = "ຖະໜົນ:"
        Label5.Text = "ບ້ານ:"
        Label6.Text = "ເມືອງ:"
        Label7.Text = "ແຂວງ:"
        Label8.Text = "ເບີໂທລະສັບ:"
        Label9.Text = "ຕິດຕໍ່ພົວພັນ:"
        Fg1.FormatString = "ລ/ດ|<ລະຫັດພະນັກງານ|<ຊື່ ພະນັກງານ    |<ເບີໂທລະສັບ      |<ຕິດຕໍ່ພົວພັນ   |<ບ້ານ            |<ເມືອງ            |<ແຂວງ"
        Fg2.FormatString = "ລ/ດ|<ລະຫັດພະນັກງານ|<ຊື່ ພະນັກງານ    |<ເບີໂທລະສັບ      |<ຕິດຕໍ່ພົວພັນ   |<ບ້ານ            |<ເມືອງ            |<ແຂວງ"

    End Sub
    Private Sub LoadData()
        Fg1.Rows = 1
        With rs
            Call loadrs("select *  from AP_Staffs WHERE Stff_Id<>'' " & Sql & " order by Stff_Id", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    Fg1.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("Stff_Id").Value.ToString) & _
                    Chr(9) & (.Fields("Stff_nmL").Value.ToString) & _
                    Chr(9) & (.Fields("Phone").Value.ToString) & _
                    Chr(9) & (.Fields("Contact_pp").Value.ToString) & _
                    Chr(9) & (.Fields("Village").Value.ToString) & _
                    Chr(9) & (.Fields("District").Value.ToString) & _
                    Chr(9) & (.Fields("Province").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With

        Fg2.Rows = 1
        With rs
            Call loadrs("select *  from AP_Staffs WHERE Stff_Id<>'' " & Sql & " order by Stff_Id", rs)

            If .RecordCount > 0 Then
                While Not .EOF()
                    Fg2.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("Stff_Id").Value.ToString) & _
                    Chr(9) & (.Fields("Stff_nmL").Value.ToString) & _
                    Chr(9) & (.Fields("Phone").Value.ToString) & _
                    Chr(9) & (.Fields("Contact_pp").Value.ToString) & _
                    Chr(9) & (.Fields("Village").Value.ToString) & _
                    Chr(9) & (.Fields("District").Value.ToString) & _
                    Chr(9) & (.Fields("Province").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '
        Me.Close()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        Pnl.Visible = True
        PnL2.Visible = True
        BtnEdit.Enabled = False
        If MDEdit = 0 Then
            BtnSave.Enabled = False
        Else
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Pnl.Visible = False
        PnL2.Visible = False
        BtnEdit.Enabled = True
        BtnSave.Enabled = False
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Pnl.Visible = True
        PnL2.Visible = True
        BtnSave.Enabled = True
        BtnEdit.Enabled = False
        Call ClearText()

    End Sub
    Public Sub ClearText()
        txtStaff_ID.Text = ""
        txtStaffNmL.Text = ""
        txtStaffNmE.Text = ""
        txtStreet.Text = ""
        txtVillage.Text = ""
        txtDistrict.Text = ""
        txtProvince.Text = ""
        txtPhone.Text = ""
        txtContact_pp.Text = ""
        txtStaff_ID.Enabled = True
        txtStaff_ID.Focus()
    End Sub
    Private Sub AutoRunnumber()
        'Dim Runnumber As String
        'Dim RsRunnumber As New ADODB.Recordset
        'With RsRunnumber
        '    loadrs("SELECT TOP 1 Rec_Cnt from AP_Staffs ORDER BY Rec_Cnt DESC", RsRunnumber)
        '    If .RecordCount = 0 Then
        '        Runnumber = "01"
        '        'ElseIf (.Fields("Rec_Cnt").Value = "") Or DBNull.Value.Equals(.Fields("Rec_Cnt").Value) Then
        '        Runnumber = "01   "
        '    Else
        '        Runnumber = Val(.Fields("Rec_Cnt").Value) + 1
        '    End If
        '    txtRec_cnt.Text = Format(Val(Runnumber), "0#")
        'End With
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call AutoRunnumber()
        If txtStaff_ID.Text = "" Then MsgBox("Please add staff ID", MsgBoxStyle.OkOnly) : txtStaff_ID.Focus() : Exit Sub
        If txtStaffNmL.Text = "" Then MsgBox("Please add staff name ", MsgBoxStyle.OkOnly) : txtStaffNmL.Focus() : Exit Sub
        If txtStaff_ID.Enabled = True Then
            Call LoadRs("SELECT Stff_Id FROM AP_Staffs WHERE Stff_Id = N'" & Trim(txtStaff_ID.Text) & "'", RSC)
            If RSC.RecordCount > 0 Then
                MsgBox("Staff ID : " & Trim(txtStaff_ID.Text) & " have in data base please to change!", MsgBoxStyle.OkOnly)
                txtStaff_ID.Focus()
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
        Call LoadRs("SELECT Stff_Id FROM AP_Staffs WHERE Stff_Id =N'" & txtStaff_ID.Text & "'", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_Staffs (Stff_Id,Stff_nmL,Stff_nmE,street,Village, " & _
                "District,Province,Phone,Contact_pp,Lst_updt,Lst_usr,Pc_nm) " & _
                   " VALUES(N'" & Apostrophe(txtStaff_ID.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtStaffNmL.Text.Trim) & "'," & _
                   " '" & Apostrophe(txtStaffNmE.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtStreet.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtVillage.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtDistrict.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtProvince.Text.Trim) & "'," & _
                   " '" & Apostrophe(txtPhone.Text.Trim) & "'," & _
                   " N'" & Apostrophe(txtContact_pp.Text.Trim) & "'," & _
                   " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " N'" & MDServerName & "')")
            Else
                Conn.Execute("UPDATE AP_Users SET " & _
                  " Usr_nm=N'" & txtStaffNmL.Text & "' " & _
                  "WHERE Usr_nm=N'" & (txtStaffNmL.Text) & "'")

                Conn.Execute("UPDATE AP_Staffs SET " & _
                   " Stff_nmL=N'" & txtStaffNmL.Text & "'," & _
                   " Stff_nmE=N'" & (txtStaffNmE.Text) & "'," & _
                   " street=N'" & txtStreet.Text & "'," & _
                   " Village=N'" & (txtVillage.Text) & "'," & _
                   " District=N'" & txtDistrict.Text & "'," & _
                   " Province=N'" & (txtProvince.Text) & "'," & _
                   " Phone=N'" & txtPhone.Text & "'," & _
                   " Contact_pp=N'" & txtContact_pp.Text & "'," & _
                   " Lst_updt=Getdate()," & _
                   " Lst_usr=N'" & MUserName & "'," & _
                   " Pc_nm=N'" & MDServerName & "' " & _
                   "WHERE Stff_Id= N'" & (txtStaff_ID.Text) & "'")
            End If
        End With
    End Sub
    Private Sub Fg1_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg1.DblClick
        Pnl.Visible = True
        PnL2.Visible = True
        BtnSave.Enabled = True
        BtnEdit.Enabled = False
        txtStaff_ID.Enabled = False
    End Sub
    Private Sub Fg1_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg1.SelChange
        If MDEdit = 0 Then Exit Sub
        Dim FGSel As New ADODB.Recordset
        With FGSel
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .Open("Select * From AP_Staffs Where(Stff_Id=N'" & _
        Fg1.get_TextMatrix(Fg1.Row, 1) & "')", Conn, _
             ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
            If .RecordCount <> 0 Then
                txtStaff_ID.Text = CStr(.Fields("Stff_Id").Value.ToString)
                txtStaffNmL.Text = CStr(.Fields("Stff_nmL").Value.ToString)
                txtStaffNmE.Text = CStr(.Fields("Stff_nmE").Value.ToString)
                txtStreet.Text = CStr(.Fields("street").Value.ToString)
                txtVillage.Text = CStr(.Fields("Village").Value.ToString)
                txtDistrict.Text = CStr(.Fields("District").Value.ToString)
                txtProvince.Text = CStr(.Fields("Province").Value.ToString)
                txtPhone.Text = CStr(.Fields("Phone").Value.ToString)
                txtContact_pp.Text = CStr(.Fields("Contact_pp").Value.ToString)
                txtStaff_ID.Enabled = False
            End If
        End With
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Pnl.Visible = True
        PnL2.Visible = True
        If MDEdit = 0 Then
            BtnSave.Enabled = False
        Else
            BtnSave.Enabled = True
        End If
        BtnEdit.Enabled = False
        txtStaff_ID.Enabled = False
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If txtStaff_ID.Text = "" Then
            Exit Sub
        Else
            Dim RSC As New ADODB.Recordset
            'Call LoadRs("Select Bill_no From AP_Sales WHERE Stff_Id='" & txtStaff_ID.Text & "'", RSC)
            Call LoadRs("Select Stff_ID From AP_Staffs WHERE Stff_ID=N'" & txtStaff_ID.Text & "'", RSC)
            If RSC.RecordCount <> 0 Then MsgBox("You do not delete '" & AccCD & "' because activity", MsgBoxStyle.OkOnly) : RSC = Nothing : Exit Sub

            ' Call LoadRs("Select Bill_no From AP_SaleForStock WHERE Stff_Id='" & txtStaff_ID.Text & "'", RSC)
            'If RSC.RecordCount <> 0 Then MsgBox("You do not delete '" & AccCD & "' because activity", MsgBoxStyle.OkOnly) : RSC = Nothing : Exit Sub

            'Call LoadRs("Select Bill_no From AP_SaleForStockDE WHERE Stff_Id='" & txtStaff_ID.Text & "'", RSC)
            'If RSC.RecordCount <> 0 Then MsgBox("You do not delete '" & AccCD & "' because activity", MsgBoxStyle.OkOnly) : RSC = Nothing : Exit Sub

            'Call LoadRs("Select Bill_no From AP_SaleForStockPO WHERE Stff_Id='" & txtStaff_ID.Text & "'", RSC)
            'If RSC.RecordCount <> 0 Then MsgBox("You do not delete '" & AccCD & "' because activity", MsgBoxStyle.OkOnly) : RSC = Nothing : Exit Sub

            'Call LoadRs("Select Usr_nm FROM AP_Users  WHERE Usr_nm=N'" & (txtStaffNmL.Text) & "' ", RSC)
            'If RSC.RecordCount <> 0 Then MsgBox("You do not delete '" & AccCD & "' because activity", MsgBoxStyle.OkOnly) : RSC = Nothing : Exit Sub

            Dim Rsch As New ADODB.Recordset
            AccCD = Trim(txtStaff_ID.Text)
            If MessageBox.Show("Do you want to delete '" & AccCD & "' yes or no ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Conn.BeginTrans()
                Conn.Execute("delete from AP_Staffs where Stff_Id=N'" & AccCD & "'")
                Conn.Execute("delete from AP_Users where Stff_Id=N'" & AccCD & "'")
                Conn.Execute("INSERT INTO AP_Staffs_ED (Stff_Id, Stff_nmL, Stff_nmE, street, Village, District, Province, Phone, Contact_pp, Lst_updt, Lst_usr, Pc_nm) " & _
                "Select Stff_Id, Stff_nmL, Stff_nmE, street, Village, District, Province, Phone, Contact_pp, getdate(), N'" & MUserName & "', N'" & MDServerName & "' From AP_Staffs WHERE Stff_Id=N'" & txtStaff_ID.Text & "'")
                Conn.CommitTrans()
                Call LoadData()
                Call ClearText()
            End If
        End If
    End Sub
    Private Sub Fg2_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg2.SelChange
        If MDEdit = 0 Then Exit Sub
        Dim FGSel As New ADODB.Recordset
        With FGSel
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .Open("Select * From AP_Staffs Where(Stff_Id=N'" & _
        Fg2.get_TextMatrix(Fg2.Row, 1) & "')", Conn, _
             ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
            If .RecordCount <> 0 Then
                txtStaff_ID.Text = CStr(.Fields("Stff_Id").Value.ToString)
                txtStaffNmL.Text = CStr(.Fields("Stff_nmL").Value.ToString)
                txtStaffNmE.Text = CStr(.Fields("Stff_nmE").Value.ToString)
                txtStreet.Text = CStr(.Fields("street").Value.ToString)
                txtVillage.Text = CStr(.Fields("Village").Value.ToString)
                txtDistrict.Text = CStr(.Fields("District").Value.ToString)
                txtProvince.Text = CStr(.Fields("Province").Value.ToString)
                txtPhone.Text = CStr(.Fields("Phone").Value.ToString)
                txtContact_pp.Text = CStr(.Fields("Contact_pp").Value.ToString)
                txtStaff_ID.Enabled = False
            End If
        End With
    End Sub

    Private Sub txtStaff_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStaff_ID.KeyPress
        If e.KeyChar = Chr(13) Then
            txtStaffNmL.Focus()
        End If
    End Sub

    Private Sub txtStaff_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStaff_ID.TextChanged

    End Sub

    Private Sub txtStaffNmL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStaffNmL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtStaffNmE.Focus()
        End If
    End Sub

    Private Sub txtStaffNmL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStaffNmL.TextChanged

    End Sub

    Private Sub txtStaffNmE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStaffNmE.KeyPress
        If e.KeyChar = Chr(13) Then
            txtStreet.Focus()
        End If
    End Sub

    Private Sub txtStaffNmE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStaffNmE.TextChanged

    End Sub

    Private Sub txtStreet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStreet.KeyPress
        If e.KeyChar = Chr(13) Then
            txtVillage.Focus()
        End If
    End Sub

    Private Sub txtStreet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStreet.TextChanged

    End Sub

    Private Sub txtVillage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVillage.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDistrict.Focus()
        End If
    End Sub

    Private Sub txtVillage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage.TextChanged

    End Sub

    Private Sub txtDistrict_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDistrict.KeyPress
        If e.KeyChar = Chr(13) Then
            txtProvince.Focus()
        End If
    End Sub

    Private Sub txtDistrict_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDistrict.TextChanged

    End Sub

    Private Sub txtProvince_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProvince.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPhone.Focus()
        End If
    End Sub

    Private Sub txtProvince_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProvince.TextChanged
       
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        If e.KeyChar = Chr(13) Then
            txtContact_pp.Focus()
        End If
    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub txtContact_pp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact_pp.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    Call AutoRunnumber()
        '    If txtStaff_ID.Text = "" Then MsgBox("ກະລຸນາປ້ອນລະຫັດກ່ອນ", MsgBoxStyle.OkOnly) : txtStaff_ID.Focus() : Exit Sub
        '    If txtStaffNmL.Text = "" Then MsgBox("ກະລຸນາປ້ອນຊື່ກ່ອນ", MsgBoxStyle.OkOnly) : txtStaffNmL.Focus() : Exit Sub
        '    If txtStaff_ID.Enabled = True Then
        '        Call LoadRs("SELECT Stff_Id FROM AP_Staffs WHERE Stff_Id = '" & Trim(txtStaff_ID.Text) & "'", RSC)
        '        If RSC.RecordCount > 0 Then
        '            MsgBox("ເລກລະຫັດ : " & Trim(txtStaff_ID.Text) & " ມີໃນຖານຂໍ້ມູນແລ້ວ ກະລຸນາປ່ຽນ!", MsgBoxStyle.OkOnly)
        '            txtStaff_ID.Focus()
        '            If RSC.State = ConnectionState.Open Then RSC.Close()
        '            Exit Sub
        '        End If
        '        If RSC.State = ConnectionState.Open Then RSC.Close()
        '    End If
        '    Call Save()
        '    MsgBox("ຂໍ້ມູນຂອງທ່ານ ໄດ້ຖຶກຈັດເກັບ ເປັນທີ່ຮຽບຮ້ອຍແລ້ວ!", MsgBoxStyle.OkOnly)
        '    Call LoadData()
        'End If
    End Sub

    Private Sub txtContact_pp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact_pp.TextChanged

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

End Class