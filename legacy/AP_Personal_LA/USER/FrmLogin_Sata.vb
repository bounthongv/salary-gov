Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Public Class FrmLogin_Sata
    Dim desCrypt As DESCryptoServiceProvider
    Dim PwdWithEncrypt As String
    Dim ms As MemoryStream
    Dim cs As CryptoStream
    Public RSC As New ADODB.Recordset
    Public EditActive As Boolean
    Dim itemfgacc As Boolean
    Dim rs As New ADODB.Recordset
    Dim SQl As String
    Dim Rpt As New Object
    Private Sub FrmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call txtUserID.Focus()
        Call Connect()
        Call Loadserial()
        Call CheckAge()

        Dim rsProj As New ADODB.Recordset
        Call LoadData("SELECT * FROM Conect ", rsProj)
        With rsProj
            If .RecordCount <> 0 Then
                MDServerName = (.Fields("ServerName").Value.ToString)
                MDDatabaName = (.Fields("DatabaseName").Value.ToString)
                MDServerUser = (.Fields("UserName").Value.ToString)
                MDServerPassword = (.Fields("UserPassword").Value.ToString)

            End If
        End With
        Call ConnectionData()
        If VSysError = True Then
            FrmData_server.Show()
            Me.Hide()
            Exit Sub
        End If
    End Sub
    Private Sub CheckAge()
        Dim datTim1 As Date = MDStarDate
        Dim datTim2 As Date = Date.Today
        MDUsingDay = DateDiff(DateInterval.Day, datTim1, datTim2)
        If CDbl(MDUsingDay) >= MDSerielAge Then
            Call SaveSerialUpdat()
            '  FrmSerial_For_Registration.Show()
            ' Me.Hide()
        End If
    End Sub
    Private Sub Loadserial()
        Call LoadData("Select * from SerialUpdat WHERE SerialID='" & "001" & "' ", rs)
        With rs
            If .RecordCount <> 0 Then
                MDSeriel = (.Fields("Serial").Value.ToString)
                MDSerielAge = (.Fields("SerialAge").Value.ToString)
                MDStarDate = (.Fields("StartData").Value.ToString)
            End If
            If .RecordCount = 0 Then
                MDSerielAge = ""
            End If
        End With
        If MDSeriel = "0000-0000-0000-0000" Then
            '  FrmSerial_For_Registration.Show()
            ' Me.Hide()
        End If
    End Sub
    Private Sub SaveSerialUpdat()
        Call LoadData("select * from SerialUpdat where SerialID='" & "001" & "'", rs)
        CNN.Execute("Update SerialUpdat Set Serial ='" & "0000-0000-0000-0000" & "' " & _
                     " WHERE SerialID='" & "001" & "' ")
    End Sub
    Private Sub Load_Rpt()
        'rs = New ADODB.Recordset
        'With rs
        '    Call LoadRs("SELECT top 1 ID FROM AP_Office ", rs)
        '    If .RecordCount <= 0 Then Exit Sub
        '    Rpt = New Rpt_Load
        '    Rpt.SetDataSource(rs)
        '    Rpt.Refresh()
        '    CrystalReportViewer1.ReportSource = Rpt
        '    CrystalReportViewer1.DisplayGroupTree = False
        '    Rpt = Nothing
        'End With
    End Sub
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtDecrypt.Hide()
        'lblText_encrypt.Hide()
        Sym = ""
        Call txtUserID.Focus()
        Call Connect()
        If DatabaseServer_ON = False Then
            End
        End If
        Dim rsProj As New ADODB.Recordset
        Call LoadData("SELECT * FROM Conect  ", rsProj)
        With rsProj
            If .RecordCount <> 0 Then

                MDServerName = (.Fields("ServerName").Value.ToString)
                MDDatabaName = (.Fields("DatabaseName").Value.ToString)
                MDServerUser = (.Fields("UserName").Value.ToString)
                MDServerPassword = (.Fields("UserPassword").Value.ToString)
            End If
        End With
        Call ConnectionData()
        Call ConnectionData()
        Call FrmAPInvioce.LangLao()

    End Sub
    Sub CheckUserNm()
        Dim rsProj As New ADODB.Recordset
        With rsProj

            Call LoadRs("SELECT    * from AP_Users  where dbo.AP_Users.Usr_id=N'" & Trim(Apostrophe(txtUserID.Text)) & "' ", rsProj)

            If .RecordCount <> 0 Then


                Do Until .EOF = True
                    MUserID = Trim(.Fields("Usr_id").Value)
                    MUserName = Trim(.Fields("Usr_nm").Value)
                    Mpermiss = .Fields("Permision").Value.ToString
                    Mpermiss_ID = .Fields("Permision_id").Value.ToString
                    MPws = Trim(.Fields("PWD").Value)
                    MDWrite = (.Fields("Write_bit").Value)
                    MDEdit = (.Fields("Edit_bit").Value)
                    MDDelete = (.Fields("Delete_bit").Value)
                    MDPV_ID1 = (.Fields("PV_ID").Value.ToString)
                    MDN_ID1 = (.Fields("BK_ID").Value.ToString)
                    'MUSTID = (.Fields("Stff_Id").Value)
                    .MoveNext()
                Loop
            End If
        End With

    End Sub

    Private Sub LoadUser()
        Call LoadRs("select * from AP_Users where Usr_id='" & Trim(Apostrophe(txtUserID.Text)) & "'", rs)
        With rs
            If .RecordCount = 0 Then
                MessageBox.Show("User ID ບໍ່ຖືກຕ້ອງ", "ບໍ່ສາມາດເຂົ້າລະບົບໄດ້", MessageBoxButtons.OK, MessageBoxIcon.Error) : txtUserID.Focus() : lblUserNm.Text = "" : Exit Sub
            Else
                lblUserNm.Text = Trim(.Fields("Usr_nm").Value.ToString)
                lblDPM.Text = Trim(.Fields("UsrPermit").Value.ToString)
                PERMIT = Trim(.Fields("permision").Value.ToString)
                Mpermiss_ID = .Fields("Permision_id").Value.ToString
                'FrmAPCashier.txtAP_ID.Text = Trim(.Fields("Usr_nm").Value.ToString)
                MUserName = Trim(.Fields("Usr_nm").Value.ToString)
                txtPassword.Focus()

            End If
        End With
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress, txtDecrypt.KeyPress
        If e.KeyChar = Chr(13) Then
            btnOK_Click(sender, e)
        End If
    End Sub

    Private Sub txtUserID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserID.KeyPress
        If e.KeyChar = Chr(13) Then
            Call CheckUserNm()
            Call LoadUser()

            If Mpermiss_ID = 0 Then
                MDPV_ID = " AND AP_Province.PV_id<>'00' "
                MDN_ID = ""
                RadioButton1.Checked = True
                RadioButton1.Enabled = True
                TxtPV_NM.Enabled = True
                txtProvince.Enabled = True
                txt_Bk_nm.Enabled = True
                txt_Bk_ID.Enabled = True

            ElseIf Mpermiss_ID = 1 Then

                RadioButton2.Checked = True
                RadioButton1.Enabled = False
                TxtPV_NM.Enabled = True
                txtProvince.Enabled = True
                txt_Bk_nm.Enabled = True
                txt_Bk_ID.Enabled = True
                MDPV_ID = " AND AP_Province.PV_id='" & MDPV_ID1 & "' "
                MDN_ID = ""
            ElseIf Mpermiss_ID = 2 Then
                RadioButton1.Enabled = False
                RadioButton2.Checked = True

                TxtPV_NM.Enabled = True
                txtProvince.Enabled = True
                txt_Bk_nm.Enabled = True
                txt_Bk_ID.Enabled = True
                MDPV_ID = "AND AP_Province.PV_id='" & MDPV_ID1 & "'"
                MDN_ID = "AND AP_LocationBk.BK_ID='" & MDN_ID1 & "'"

            ElseIf Mpermiss_ID = 3 Then
                RadioButton1.Enabled = False
                RadioButton2.Checked = True

                TxtPV_NM.Items.Clear()
                Call load_Cmb(" SELECT ProV_nm FROM AP_Users_Item  where Usr_id=N'" & txtUserID.Text & "'  ORDER BY ProV_id ", "ProV_nm", TxtPV_NM)
                If TxtPV_NM.Items.Count > 0 Then
                    TxtPV_NM.SelectedIndex = 0
                End If
                TxtPV_NM.Enabled = True
                txtProvince.Enabled = True
                txt_Bk_nm.Enabled = True
                txt_Bk_ID.Enabled = True

            ElseIf Mpermiss_ID = 4 Then
                RadioButton1.Enabled = False
                RadioButton2.Checked = True

                TxtPV_NM.Items.Clear()
                Call load_Cmb(" SELECT ProV_nm FROM AP_Users_Item  where Usr_id=N'" & txtUserID.Text & "'  ORDER BY ProV_id ", "ProV_nm", TxtPV_NM)
                If TxtPV_NM.Items.Count > 0 Then
                    TxtPV_NM.SelectedIndex = 0
                End If
                TxtPV_NM.Enabled = False

            ElseIf Mpermiss_ID = 5 Then
                RadioButton1.Enabled = False
                RadioButton2.Checked = True

                TxtPV_NM.Items.Clear()
                Call load_Cmb(" SELECT ProV_nm FROM AP_Users_Item  where Usr_id=N'" & txtUserID.Text & "'  ORDER BY ProV_id ", "ProV_nm", TxtPV_NM)
                If TxtPV_NM.Items.Count > 0 Then
                    TxtPV_NM.SelectedIndex = 0
                End If


                TxtPV_NM.Enabled = False



            End If
            'TxtPV_NM.Items.Clear()
            'Call load_Cmb(" SELECT PV_nm FROM AP_Province WHERE 1=1 " & MDPV_ID & "  ORDER BY PV_ID ", "PV_nm", TxtPV_NM)
            'If TxtPV_NM.Items.Count > 0 Then
            '    TxtPV_NM.SelectedIndex = 0
            'End If
        End If
        Location_Dist_id = " and  Prov_id =N'" & Trim(Prov_Id) & "'"



        Call LoadRs("Select *  From AP_Location_Hos_Center Where   Bk_nm =N'" & Trim(txt_Bk_nm.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            'txt_Bk_ID.Text = Trim(rs("BK_ID").Value)
            'Location_nm = Trim(rs("Bk_nm").Value.ToString)
            'Prov_Id = Trim(rs("Hos_id").Value.ToString)
            Sym = Trim(rs("sym").Value.ToString)
        Else
            Sym = ""
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'Me.Cursor = Cursors.WaitCursor
        Call CheckUserNm()

        If Trim(txtUserID.Text) = "" Then MsgBox("Please insert your UserID!", MsgBoxStyle.OkOnly) : txtUserID.Focus() : Exit Sub

        If txtUserID.Text <> MUserID Then MsgBox(" No have UserID in data base ", MsgBoxStyle.OkOnly) : txtUserID.Focus() : lblUsername.Text = "" : Exit Sub
        If txtPassword.Text <> MPws Then MsgBox("No have Password in data base ", MsgBoxStyle.OkOnly) : txtPassword.Focus() : Exit Sub
        Call Load_Rpt()
        'Me.Cursor = Cursors.Default
        Me.Hide()
        If Mpermiss = "Admin" Then
            MDPV_ID = ""
            MDN_ID = ""
        ElseIf Mpermiss = "Sub-Admin" Then
            MDPV_ID = " AND AP_LocationBk='" & txtProvince.Text & "'"
            MDN_ID = ""
        Else
            MDPV_ID = " AND AP_LocationBk='" & txtProvince.Text & "'"
            MDN_ID = " AND AP_LocationBk='" & txtProvince.Text & "'"

        End If
        MDST = txt_Bk_ID.Text
        MDSTPV_ID = txtProvince.Text
        FrmAPInvioce.Show()
        FrmAPInvioce.Focus()
        FrmAPInvioce.Refresh()
 
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub lblDPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDPM.Click

    End Sub

    Private Sub txtUserID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserID.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged, txtDecrypt.TextChanged

    End Sub
    Private Sub Decrypt()
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
        Dim arrByte As Byte() = Encoding.ASCII.GetBytes(txtPassword.Text)
        cs.Write(arrByte, 0, arrByte.Length)
        cs.FlushFinalBlock()
        cs.Close()
        PwdWithEncrypt = Convert.ToBase64String(ms.ToArray())
        txtDecrypt.Text = PwdWithEncrypt
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click


    End Sub

    Private Sub TxtPV_NM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPV_NM.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Province Where   PV_nm =N'" & Trim(TxtPV_NM.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtProvince.Text = Trim(rs("PV_ID").Value)
            txt_Bk_ID.Text = Trim(rs("Prov_Sym").Value)
            Prov_Id = Trim(rs("PV_ID").Value)
            Location_nm = Trim(rs("PV_nm").Value.ToString)
            Shr_Dristic = ""
            Shr_HSV = ""
        Else

        End If


        If CheckBox1.Checked = True Then
            If Mpermiss_ID = 5 Then
                cmbDist.Items.Clear()
                Call load_Cmb(" SELECT Dist_Nm FROM AP_Users_Item  where Usr_id=N'" & txtUserID.Text & "'  ORDER BY Dist_id ", "Dist_Nm", cmbDist)
                If cmbDist.Items.Count > 0 Then
                    cmbDist.SelectedIndex = 0
                End If

            Else
                cmbDist.Items.Clear()
                Call load_Cmb(" SELECT Dt_nm FROM AP_District  where PV_ID=N'" & Trim(txtProvince.Text) & "'  ORDER BY Dt_id ", "Dt_nm", cmbDist)
                If cmbDist.Items.Count > 0 Then
                    cmbDist.SelectedIndex = 0
                End If
            End If
        Else
            cmbDist.Items.Clear()
            cmbDist.Text = ""


        End If

    End Sub

    Private Sub txt_Bk_nm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Bk_nm.SelectedIndexChanged


        Call LoadRs("Select *  From AP_Location_Hos_Center Where   Bk_nm =N'" & Trim(txt_Bk_nm.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtHost_id.Text = Trim(rs("Hos_id").Value)
            txt_Bk_ID.Text = Trim(rs("BK_ID").Value)
            Location_nm = Trim(rs("Bk_nm").Value.ToString)
            Prov_Id = Trim(rs("Hos_id").Value.ToString)
            Sym = Trim(rs("sym").Value.ToString)
        End If
        If RadioButton1.Checked = True Then
            Prov_Id = "01"
        End If

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txt_Bk_nm.Enabled = True
            txt_Bk_nm.Items.Clear()
            Call load_Cmb(" SELECT * FROM AP_Location_Hos_Center   ", "Bk_nm", txt_Bk_nm)
            If txt_Bk_nm.Items.Count > 0 Then
                txt_Bk_nm.SelectedIndex = 0
            End If
        Else
            txt_Bk_nm.Items.Clear()
            txt_Bk_nm.Text = ""
            txtProvince.Text = ""
            txt_Bk_nm.Enabled = False
            txtHost_id.Text = ""
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TxtPV_NM.Enabled = True
            TxtPV_NM.Items.Clear()
            Call load_Cmb(" SELECT PV_nm FROM AP_Province  where PV_ID<>00  ORDER BY PV_ID ", "PV_nm", TxtPV_NM)
            If TxtPV_NM.Items.Count > 0 Then
                TxtPV_NM.SelectedIndex = 0
            End If
        Else
            txtProvince.Text = ""
            TxtPV_NM.Text = ""
            txt_Bk_ID.Text = ""
            TxtPV_NM.Enabled = False
        End If
        Shr_Dristic = ""
        Shr_HSV = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If Mpermiss_ID = 5 Then
                cmbDist.Items.Clear()
                Call load_Cmb(" SELECT Dist_Nm FROM AP_Users_Item  where Usr_id=N'" & txtUserID.Text & "'  ORDER BY Dist_id ", "Dist_Nm", cmbDist)
                If cmbDist.Items.Count > 0 Then
                    cmbDist.SelectedIndex = 0
                End If

            Else
                cmbDist.Items.Clear()
                Call load_Cmb(" SELECT Dt_nm FROM AP_District  where PV_ID=N'" & Trim(txtProvince.Text) & "'  ORDER BY Dt_id ", "Dt_nm", cmbDist)
                If cmbDist.Items.Count > 0 Then
                    cmbDist.SelectedIndex = 0
                End If
            End If
            Location_Dist_id = " and  Dist_ID =N'" & Trim(txtDis_id.Text) & "'"
        Else
            cmbDist.Items.Clear()
            cmbDist.Text = ""
            Dist_Locat = ""
            Location_Dist_id = " and  Prov_id =N'" & Trim(txtProvince.Text) & "'"
            Shr_Dristic = ""
            Shr_HSV = ""
        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Cmb_HSV.Items.Clear()
            Call load_Cmb(" SELECT Health_Name FROM AP_Health_Service  where Dist_ID=N'" & Trim(txtDis_id.Text) & "'  ORDER BY Heal_ID ", "Health_Name", Cmb_HSV)
            If Cmb_HSV.Items.Count > 0 Then
                Cmb_HSV.SelectedIndex = 0
            End If
        Else
            Cmb_HSV.Items.Clear()
            Cmb_HSV.Text = ""
            Shr_HSV = ""
        End If
    End Sub

    Private Sub Cmb_HSV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_HSV.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Health_Service Where   Health_Name =N'" & Trim(Cmb_HSV.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtHSV_id.Text = Trim(rs("Heal_ID").Value)
        End If
        If CheckBox2.Checked = True Then

            Shr_HSV = " and  AP_Books.Health_Service_id =N'" & Trim(txtHSV_id.Text) & "'"
        Else
            Shr_HSV = ""

        End If

    End Sub

    Private Sub cmbDist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDist.SelectedIndexChanged
        Call LoadRs("Select *  From AP_District Where   Dt_nm =N'" & Trim(cmbDist.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtDis_id.Text = Trim(rs("Dt_id").Value)

        End If
        If CheckBox1.Checked = True Then
            Dist = " and  Dt_ID =N'" & Trim(txtDis_id.Text) & "'"
            Dist_Locat = " and  AP_Books.Dist_locat =N'" & Trim(txtDis_id.Text) & "'"
            Shr_Dristic = " and  AP_Books.Place_id =N'" & Trim(txtDis_id.Text) & "'"
            Shr_HSV = ""
            Location_Dist_id = " and  Dist_ID =N'" & Trim(txtDis_id.Text) & "'"
        Else
            Shr_Dristic = ""
            Shr_HSV = ""
            Dist = ""
            Dist_Locat = ""
        End If


        If CheckBox2.Checked = True Then
            Call LoadRs("Select *  From AP_District Where   Dt_nm =N'" & Trim(cmbDist.Text) & "'", rs)
            If rs.RecordCount > 0 Then
                txtDis_id.Text = Trim(rs("Dt_id").Value)
                Location_nm = Trim(rs("Dt_nm").Value.ToString)
            End If
            If CheckBox1.Checked = True Then
                Dist = " and  Dt_ID =N'" & Trim(txtDis_id.Text) & "'"
            Else
                Dist = ""
            End If

            Cmb_HSV.Items.Clear()
            Call load_Cmb(" SELECT Health_Name FROM AP_Health_Service  where Dist_ID=N'" & Trim(txtDis_id.Text) & "'  ORDER BY Heal_ID ", "Health_Name", Cmb_HSV)
            If Cmb_HSV.Items.Count > 0 Then
                Cmb_HSV.SelectedIndex = 0
            End If
            Location_Dist_id = " and  Dist_ID =N'" & Trim(txtDis_id.Text) & "'"

        Else
            Cmb_HSV.Items.Clear()
            Cmb_HSV.Text = ""

        End If

    End Sub

    Private Sub txt_Bk_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Bk_ID.TextChanged

    End Sub
End Class