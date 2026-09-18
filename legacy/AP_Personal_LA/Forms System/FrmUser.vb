Imports System.Text
Imports System.IO
Imports System.Security.Cryptography

Public Class FrmUser
    Dim desCrypt As DESCryptoServiceProvider
    Dim PwdWithEncrypt As String
    Dim ms As MemoryStream
    Dim cs As CryptoStream
    Public RSC As New ADODB.Recordset

    Dim itemfgacc As Boolean
    Dim rs As New ADODB.Recordset
    Dim Sql As String
    Dim MDCheckWrite, MDCheckEdit, MDCheckDelete, MDCheckForstaff As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub FrmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cmbDist.Items.Clear()
        'Call load_Cmb(" SELECT Dt_nm FROM AP_District  where PV_ID=N'" & Trim(txtProvince_id.Text) & "'  ORDER BY Dt_id ", "Dt_nm", cmbDist)
        'If cmbDist.Items.Count > 0 Then
        '    cmbDist.SelectedIndex = 0
        'End If

        'Cmb_HSV.Items.Clear()
        'Call load_Cmb(" SELECT Health_Name FROM AP_Health_Service  where Dist_ID=N'" & Trim(txtDis_id.Text) & "'  ORDER BY Dist_ID ", "Health_Name", Cmb_HSV)
        'If Cmb_HSV.Items.Count > 0 Then
        '    Cmb_HSV.SelectedIndex = 0
        'End If

     

      
        If EditActive = False Then
            txtUsr_id.Enabled = True
            txtUsr_id.Focus()
            Call ClearText()

        Else
            txtUsr_id.Enabled = False

            LoadData()
         
            LoadData_Item()

        End If
      

      
    End Sub
    Private Sub LoadData()
        Dim sa As String
        Dim rs As New ADODB.Recordset
        With rs
            sa = "SELECT   * from  AP_Users WHERE Usr_id='" & SaleID & "'  "
            Call LoadRs(sa, rs)

            If .RecordCount <> 0 Then

                txtUsr_id.Text = (.Fields("Usr_id").Value.ToString)
                txtUsr_nm.Text = (.Fields("Usr_nm").Value.ToString)
                cmbpermision.Text = (.Fields("permision").Value.ToString)
                txtPWD.Text = (.Fields("PWD").Value.ToString)
                txtConfrim.Text = (.Fields("PWD").Value.ToString)
                'TxtPV_NM.Text = (.Fields("Bar_Code").Value.ToString)
                txtStff_Id.Text = (.Fields("Stff_Id").Value.ToString)
            End If
        End With
    End Sub

    Private Sub LoadData_Item()
        Dim sa As String
        Dim rs As New ADODB.Recordset
        With rs
            sa = "SELECT   *  from  AP_Users_item WHERE Usr_id='" & SaleID & "'  "
            Call LoadRs(sa, rs)
            If .RecordCount <> 0 Then
                TxtPV_NM.Text = (.Fields("ProV_nm").Value.ToString)
                If cmbpermision.SelectedIndex = 3 Then
                    Call LoadData_Prov()
                End If
                While Not .EOF()

                    For i = 1 To Fg.Rows - 1

                        If cmbpermision.SelectedIndex = 3 Then
                            If Fg.get_TextMatrix(i, 2) = Trim((.Fields("ProV_id").Value).ToString) Then
                                Fg.set_TextMatrix(i, 1, True)
                            End If

                        ElseIf cmbpermision.SelectedIndex = 5 Then
                            If Fg.get_TextMatrix(i, 2) = Trim((.Fields("Dist_id").Value).ToString) Then
                                Fg.set_TextMatrix(i, 1, True)

                            End If

                        End If
                    Next i
                    .MoveNext()
                End While

            Else
                Fg.Rows = 1
                Fg.Rows = 2
            End If
        End With
        If cmbpermision.SelectedIndex = 3 Or cmbpermision.SelectedIndex = 4 Then
            TxtPV_NM.Text = ""
        End If
    End Sub
    Public Sub LoadLang()
        MDLang = 1
        BtnAddNew.Text = "AddNew"
        BtnSave.Text = "Save"
        BtnDel.Text = "Delete"
        lblID.Text = "UserID:"
        lblNm.Text = "UserName:"
        lblPass.Text = "Password:"
        lblConfirm.Text = "Confirm:"
        lblPermission.Text = "Permission:"
        lblPermissions.Text = "Permission:"
        lblSec.Text = "Section:"
        ChkForStaff.Text = "For Sale"
        'Fg.FormatString = "NO|<UserID  |<UserName    |<Permission         |<Section"

    End Sub
    Public Sub LangLao()

        MDLang = 1
        BtnAddNew.Text = "ເພີ່ມໃໝ່"
        BtnSave.Text = "ບັນທຶກ"
        BtnDel.Text = "ລຶບ"
        lblID.Text = "ລະຫັດຜູ້ໃຊ້:"
        lblNm.Text = "ຊື່ ຜູ້ໃຊ້:"
        lblPass.Text = "ລະຫັດຜ່ານ:"
        lblConfirm.Text = "ຢືນຢັນລະຫັດຜ່ານ:"
        lblPermission.Text = "ສິດໃຊ້ໂປຣແກຣມ:"
        lblPermissions.Text = "ສິດໃຊ້ໂປຣແກຣມ:"
        lblSec.Text = "ພະແນກ:"
        ChkForStaff.Text = "ສໍາລັບພະນັກງານຂາຍ"
        'Fg.FormatString = "ລ/ດ|<ລະຫັດຜູ້ໃຊ້  |<ຊື່ ຜູ້ໃຊ້    |<ສິດໃຊ້ໂປຣແກຣມ        |<ພະແນກ  "
        'Fg.set_ColHidden(4, True)

    End Sub
    Private Sub LoadData_Prov()
        Fg.Rows = 1
        With rs
            Call LoadRs("SELECT  * from AP_Province where PV_ID <>00   order by PV_ID", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    Fg.AddItem(.AbsolutePosition & _
                       Chr(9) & ("") & _
                    Chr(9) & (.Fields("PV_ID").Value.ToString) & _
                    Chr(9) & (.Fields("PV_nm").Value.ToString))

                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub LoadData_Dist()
        Fg.Rows = 1
        With rs
            Call LoadRs("SELECT  * from AP_District where PV_id='" & txtProvince_id.Text & "'  order by Dt_id", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    Fg.AddItem(.AbsolutePosition & _
                       Chr(9) & ("") & _
                    Chr(9) & (.Fields("Dt_id").Value.ToString) & _
                    Chr(9) & (.Fields("Dt_nm").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub
    Private Sub ClearText()
        txtUsr_id.Text = ""
        txtUsr_nm.Text = ""
        txtPWD.Text = ""
        txtConfrim.Text = ""
        txtStff_Id.Text = ""
        Fg.Rows = 1
        Fg.Rows = 2

        txtDep_ID.Text = ""
        txtDep_Nm.Text = ""
        cmbpermision.Text = "Admin"
        cmbUsrPermit.Text = "Administrator"
        CheckWrite_bit.Enabled = False
        CheckEdit_bit.Enabled = False
        CheckDelete_bit.Enabled = False

        CheckWrite_bit.Checked = True
        CheckEdit_bit.Checked = True
        CheckDelete_bit.Checked = True
        ChkForStaff.Checked = False
        txtUsr_id.Focus()
    End Sub

    Private Sub cmbpermision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbpermision.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDep_ID.Focus()
        End If
    End Sub
    Private Sub cmbpermision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpermision.SelectedIndexChanged
        If cmbpermision.SelectedIndex = 0 Then
            'addmin
            txtpermision_id.Text = 0
            TxtPV_NM.Items.Clear()
            TxtPV_NM.Text = ""

        ElseIf cmbpermision.SelectedIndex = 1 Then
            'SupAdmin
            txtpermision_id.Text = 1
            TxtPV_NM.Items.Clear()
            TxtPV_NM.Text = ""

        ElseIf cmbpermision.SelectedIndex = 2 Then
            ' Pro-Super
            If Fg.Col = 1 Then
                Fg.Editable = VSFlex8U.EditableSettings.flexEDNone
            End If
            Fg.set_ColDataType(1, VSFlex8U.DataTypeSettings.flexDTBoolean)
            Fg.FormatString = "ລ/ດ|<ເລືອກ|<ລະຫັດແຂວງ|<ຊື່ ແຂວງ                "
            LoadData_Prov()
            txtpermision_id.Text = 2
            For i = 1 To Fg.Rows - 1
                Fg.set_TextMatrix(i, 1, True)
            Next

        ElseIf cmbpermision.SelectedIndex = 3 Then
            '   Pro-User
            txtpermision_id.Text = 3
            If Fg.Col = 1 Then
                Fg.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
            End If
            Fg.set_ColDataType(1, VSFlex8U.DataTypeSettings.flexDTBoolean)
            Fg.FormatString = "ລ/ດ|<ເລືອກ|<ລະຫັດແຂວງ|<ຊື່ ແຂວງ                "
            LoadData_Prov()
        ElseIf cmbpermision.SelectedIndex = 4 Then
            ' Dis-Spuer
            TxtPV_NM.Enabled = True
            txtpermision_id.Text = 4
            TxtPV_NM.Items.Clear()
            Call load_Cmb(" SELECT PV_nm FROM AP_Province  where PV_ID<>00  ORDER BY PV_ID ", "PV_nm", TxtPV_NM)
            If TxtPV_NM.Items.Count > 0 Then
                TxtPV_NM.SelectedIndex = 0
            End If
            Fg.FormatString = "ລ/ດ|<ເລືອກ|<ລະຫັດເມືອງ|<ຊື່ ເມືອງ                "
            Fg.set_ColDataType(1, VSFlex8U.DataTypeSettings.flexDTBoolean)
            If Fg.Col = 1 Then
                Fg.Editable = VSFlex8U.EditableSettings.flexEDNone
            End If
            For i = 1 To Fg.Rows - 1
                Fg.set_TextMatrix(i, 1, True)
            Next
            

        ElseIf cmbpermision.SelectedIndex = 5 Then
            'Dis-User
            TxtPV_NM.Enabled = True
            txtpermision_id.Text = 5
            If Fg.Col = 1 Then
                Fg.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
            End If
            TxtPV_NM.Items.Clear()
            Call load_Cmb(" SELECT PV_nm FROM AP_Province  where PV_ID<>00  ORDER BY PV_ID ", "PV_nm", TxtPV_NM)
            If TxtPV_NM.Items.Count > 0 Then
                TxtPV_NM.SelectedIndex = 0
            End If
            Fg.set_ColDataType(1, VSFlex8U.DataTypeSettings.flexDTBoolean)
            Fg.FormatString = "ລ/ດ|<ເລືອກ|<ລະຫັດເມືອງ|<ຊື່ ເມືອງ                "
            LoadData_Dist()

        End If
    End Sub

    Private Sub cmbUsrPermit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUsrPermit.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbpermision.Focus()
        End If
    End Sub
    Private Sub cmbUsrPermit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsrPermit.SelectedIndexChanged
        'If cmbpermision.Text = "Administrator" Then
        '    CheckWrite_bit.Enabled = False
        '    CheckEdit_bit.Enabled = False
        '    CheckDelete_bit.Enabled = False
        '    CheckWrite_bit.Checked = False
        '    CheckEdit_bit.Checked = False
        '    CheckDelete_bit.Checked = False
        'End If
        'If cmbpermision.Text = "User" Then
        '    CheckWrite_bit.Enabled = True
        '    CheckEdit_bit.Enabled = True
        '    CheckDelete_bit.Enabled = True
        '    CheckWrite_bit.Checked = True
        '    CheckEdit_bit.Checked = True
        '    CheckDelete_bit.Checked = True
        'End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Call ClearText()
        txtUsr_id.Enabled = True
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If txtUsr_id.Text = "" Then MsgBox("Please add user ID!", MsgBoxStyle.OkOnly) : txtUsr_id.Focus() : Exit Sub
        'If txtStff_Id.Text = "" Then MsgBox("Please add Staff ID!", MsgBoxStyle.OkOnly) : txtStff_Id.Focus() : Exit Sub
        If txtUsr_id.Enabled = True Then
            Call LoadRs("SELECT Usr_id FROM AP_Users WHERE Usr_id = N'" & Trim(txtUsr_id.Text) & "'", RSC)
            If RSC.RecordCount > 0 Then
                MsgBox("User ID : " & Trim(txtUsr_id.Text) & " have in data base please to change!", MsgBoxStyle.OkOnly)
                txtUsr_id.Focus()
                If RSC.State = ConnectionState.Open Then RSC.Close()
                Exit Sub
            End If
            If RSC.State = ConnectionState.Open Then RSC.Close()
        End If
        Call Save()

        Conn.Execute("delete from  AP_Users_item WHERE  Usr_id = N'" & txtUsr_id.Text & "'")
        Call Save_Item()
        MsgBox("Save Complete!", MsgBoxStyle.OkOnly)

    End Sub
    Private Sub Save_Item()
        Dim Rschk As New ADODB.Recordset
        Dim i As Integer
        With Rschk
            If cmbpermision.SelectedIndex = 2 Or cmbpermision.SelectedIndex = 3 Then
                Call LoadRs("SELECT * FROM AP_Users_item WHERE Usr_id = N'" & txtUsr_id.Text & "'", Rschk)
                For i = 1 To Fg.Rows - 1
                    If .RecordCount = 0 Then
                        If Fg.get_ValueMatrix(i, 1) = True Then
                            Conn.Execute("INSERT INTO  AP_Users_item (Usr_id,Stff_Id,Usr_nm, permision_id, permision, ProV_id, ProV_nm) " & _
                                " VALUES('" & (txtUsr_id.Text) & "'," & _
                                      " N'" & (MUserID) & "'," & _
                           " N'" & (txtUsr_nm.Text) & "'," & _
                               " N'" & (txtpermision_id.Text) & "'," & _
                           " N'" & (cmbpermision.Text) & "'," & _
                                " N'" & Apostrophe(Fg.get_TextMatrix(i, 2)) & "'," & _
                                  " N'" & Apostrophe(Fg.get_TextMatrix(i, 3)) & "')")
                        End If
                    End If
                Next i

            ElseIf cmbpermision.SelectedIndex = 4 Or cmbpermision.SelectedIndex = 5 Then

                Call LoadRs("SELECT * FROM AP_Users_item WHERE Usr_id = N'" & txtUsr_id.Text & "'", Rschk)
                For i = 1 To Fg.Rows - 1
                    If .RecordCount = 0 Then
                        If Fg.get_ValueMatrix(i, 1) = True Then
                            Conn.Execute("INSERT INTO  AP_Users_item (Usr_id,Stff_Id, Usr_nm, permision_id, permision, ProV_id, ProV_nm,Dist_id, Dist_Nm) " & _
                                " VALUES('" & (txtUsr_id.Text) & "'," & _
                                        " N'" & (MUserID) & "'," & _
                           " N'" & (txtUsr_nm.Text) & "'," & _
                               " N'" & (txtpermision_id.Text) & "'," & _
                           " N'" & (cmbpermision.Text) & "'," & _
                                 " N'" & (txtProvince_id.Text) & "'," & _
                               " N'" & (TxtPV_NM.Text) & "'," & _
                                " N'" & Apostrophe(Fg.get_TextMatrix(i, 2)) & "'," & _
                                  " N'" & Apostrophe(Fg.get_TextMatrix(i, 3)) & "')")
                        End If
                    End If
                Next i

            End If
        


        End With
 

    End Sub
    Private Sub Save()
      
        'Call Encrypt_Text()
        Call LoadRs("SELECT * FROM AP_Users WHERE Usr_id = N'" & txtUsr_id.Text & "'", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_Users (Usr_id,Stff_Id,Usr_nm,permision_id,permision,Sec_id,UsrPermit, " & _
                "PWD,lst_updt,lst_usr,pc_nm) " & _
                   " VALUES('" & (txtUsr_id.Text) & "'," & _
                      " N'" & (MUserID) & "'," & _
                   " N'" & (txtUsr_nm.Text) & "'," & _
                       " N'" & (txtpermision_id.Text) & "'," & _
                   " N'" & (cmbpermision.Text) & "'," & _
                   " N'" & (txtDep_ID.Text) & "'," & _
                   " N'" & (cmbUsrPermit.Text) & "'," & _
                   " N'" & (txtPWD.Text.Trim) & "'," & _
                   " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " N'" & MDServerName & "')")
            Else
                'Conn.Execute("INSERT INTO AP_Users_ED ( Usr_id,Stff_Id, Usr_nm, permision, Sec_id, UsrPermit, Write_bit, Edit_bit, Delete_bit, PWD, lst_usr, lst_updt, pc_nm) " & _
                '" Select Usr_id, Usr_nm, permision, Sec_id, UsrPermit, Write_bit, Edit_bit, Delete_bit, PWD, lst_usr, lst_updt, pc_nm From AP_Users WHERE Usr_id='" & Trim(Me.txtUsr_id.Text) & "'")
                Conn.Execute("UPDATE AP_Users SET " & _
                               " Usr_nm=N'" & txtUsr_nm.Text & "'," & _
                   " Stff_Id=N'" & MUserID & "'," & _
                   " permision_id=N'" & (txtpermision_id.Text) & "'," & _
                   " permision=N'" & (cmbpermision.Text) & "'," & _
                   " Sec_id=N'" & txtDep_ID.Text & "'," & _
                   " UsrPermit=N'" & (cmbUsrPermit.Text) & "'," & _
                    " PWD=N'" & txtPWD.Text & "'," & _
                   " lst_updt=Getdate()," & _
                   " lst_usr=N'" & MUserName & "'," & _
                   " pc_nm=N'" & MDServerName & "' " & _
                   "WHERE Usr_id=N'" & (txtUsr_id.Text) & "'")
            End If
        End With



    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        If Fg.Rows = 2 Then MsgBox("You do not delete , because is last list ", MsgBoxStyle.OkOnly) : Exit Sub

        'Call LoadRs("SELECT Staff_ID FROM AP_Airline_Bill WHERE Staff_ID=N'" & Trim(txtStff_Id.Text) & "'", rs)
        'If rs.RecordCount <> 0 Then MsgBox("You do not to delete , because activity.", MsgBoxStyle.OkOnly) : Exit Sub

        Dim Rsch As New ADODB.Recordset
        AccCD = Trim(txtUsr_id.Text)
        If MessageBox.Show("Do you want to delete '" & AccCD & "' yes or no ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.BeginTrans()
            Conn.Execute("delete from AP_Users where Usr_id=N'" & AccCD & "'")
            Conn.CommitTrans()

            Call ClearText()
        End If
    End Sub
 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub txtDep_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDep_ID.KeyPress
        Button1_Click(sender, e)
    End Sub
    Private Sub txtDep_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDep_ID.TextChanged
        Call LoadRs("select *  from AP_Sections WHERE Sec_id=N'" & txtDep_ID.Text & "' ", rs)
        If rs.RecordCount > 0 Then
            txtDep_Nm.Text = rs.Fields("Sec_nmL").Value.ToString
        End If
    End Sub

    Private Sub txtUsr_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsr_id.KeyPress
        If e.KeyChar = Chr(13) Then
            txtUsr_nm.Focus()
        End If
    End Sub

    Private Sub txtUsr_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsr_id.TextChanged

    End Sub

    Private Sub txtUsr_nm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsr_nm.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPWD.Focus()
        End If
    End Sub

    Private Sub txtUsr_nm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsr_nm.TextChanged

    End Sub

    Private Sub txtPWD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPWD.KeyPress
        If e.KeyChar = Chr(13) Then
            txtConfrim.Focus()
        End If
    End Sub

    Private Sub txtPWD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPWD.TextChanged

    End Sub

    Private Sub txtConfrim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfrim.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbUsrPermit.Focus()
        End If
    End Sub
    Private Sub txtStff_Id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStff_Id.TextChanged

    End Sub


    Private Sub Encrypt_Text()
        Dim CurrentIV As Byte() = New Byte() {31, 32, 33, 34, 35, 36, 37, 38}
        Dim CurrentKey As Byte() = {}
        If lblText_encrypt.Text.Length = 8 Then
            CurrentKey = Encoding.ASCII.GetBytes(lblText_encrypt.Text)
        ElseIf lblText_encrypt.Text.Length > 8 Then
            CurrentKey = Encoding.ASCII.GetBytes(lblText_encrypt.Text.Substring(0, 8))
        Else
            Dim i As Integer
            Dim AddString As String = lblText_encrypt.Text.Substring(0, 1)
            Dim TotalLoop As Integer = 8 - CInt(lblText_encrypt.Text.Length)
            Dim tmpKey As String = lblText_encrypt.Text
            For i = 1 To TotalLoop
                tmpKey = tmpKey & AddString
            Next
            CurrentKey = Encoding.ASCII.GetBytes(tmpKey)
        End If
        desCrypt = New DESCryptoServiceProvider
        With desCrypt
            .IV = CurrentIV
            .Key = CurrentKey
        End With
        ms = New MemoryStream
        ms.Position = 0
        cs = New CryptoStream(ms, desCrypt.CreateEncryptor, CryptoStreamMode.Write)
        Dim arrByte As Byte() = Encoding.ASCII.GetBytes(txtPWD.Text)
        cs.Write(arrByte, 0, arrByte.Length)
        cs.FlushFinalBlock()
        cs.Close()
        PwdWithEncrypt = Convert.ToBase64String(ms.ToArray())
        txtEncrypt.Text = PwdWithEncrypt
    End Sub

    Private Sub TxtPV_NM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPV_NM.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Province Where   PV_nm =N'" & Trim(TxtPV_NM.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtProvince_id.Text = Trim(rs("PV_ID").Value)
        End If
      
        LoadData_Dist()
      
        If cmbpermision.SelectedIndex = 4 Then
            Fg.set_ColDataType(1, VSFlex8U.DataTypeSettings.flexDTBoolean)
            If Fg.Col = 1 Then
                Fg.Editable = VSFlex8U.EditableSettings.flexEDNone
            End If
            For i = 1 To Fg.Rows - 1
                Fg.set_TextMatrix(i, 1, True)
            Next
        End If
    End Sub

    Private Sub Cmb_hospital_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_hospital.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Location_Hos_Pro Where   Bk_nm =N'" & Trim(Cmb_hospital.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txt_hospital_id.Text = Trim(rs("PV_id").Value)

        End If
    End Sub

    Private Sub cmbDist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDist.SelectedIndexChanged
        Call LoadRs("Select *  From AP_District Where   Dt_nm =N'" & Trim(cmbDist.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtDis_id.Text = Trim(rs("Dt_id").Value)
        End If

      
    End Sub

    Private Sub Cmb_HSV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_HSV.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Health_Service Where   Dt_nm =N'" & Trim(Cmb_HSV.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtHSV_id.Text = Trim(rs("Dist_ID").Value)
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Chk_prov_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub
 

 

    Private Sub Chk_hospital_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_hospital.CheckedChanged
        If Chk_hospital.Checked = True Then

            Cmb_hospital.Items.Clear()
            Call load_Cmb(" SELECT Bk_nm FROM AP_Location_Hos_Pro   ORDER BY PV_id ", "Bk_nm", Cmb_hospital)
            If Cmb_hospital.Items.Count > 0 Then
                Cmb_hospital.SelectedIndex = 0
            End If

        Else
            Cmb_hospital.Items.Clear()
            Cmb_hospital.Text = ""

        End If
    End Sub

    Private Sub txtDep_Nm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDep_Nm.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then

            Cmb_hospital.Items.Clear()
            Call load_Cmb(" SELECT Bk_nm FROM AP_Location_Hos_Pro   ORDER BY PV_id ", "Bk_nm", Cmb_hospital)
            If Cmb_hospital.Items.Count > 0 Then
                Cmb_hospital.SelectedIndex = 0
            End If
        Else
            Cmb_hospital.Items.Clear()
            Cmb_hospital.Text = ""

        End If
    End Sub

 
End Class