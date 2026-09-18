Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Public Class FrmLogin
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
        Call LoadData("SELECT * FROM Conn where Serverid='001'  ", rsProj)
        With rsProj
            If .RecordCount <> 0 Then
                MDServerName = (.Fields("Servernm").Value.ToString)
                MDDatabaName = (.Fields("Datanm").Value.ToString)
                MDServerUser = (.Fields("Usernm").Value.ToString)
                MDServerPassword = (.Fields("UserPass").Value.ToString)

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
        Call LoadData("SELECT * FROM Conn where Serverid='001'  ", rsProj)
        With rsProj
            If .RecordCount <> 0 Then
                MDServerName = (.Fields("Servernm").Value.ToString)
                MDDatabaName = (.Fields("Datanm").Value.ToString)
                MDServerUser = (.Fields("Usernm").Value.ToString)
                MDServerPassword = (.Fields("UserPass").Value.ToString)
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


 
            Cmb_Department.Items.Clear()
            Call load_Cmb(" SELECT * FROM AP_Sections WHERE 1=1   ORDER BY Sec_id ", "Sec_nmL", Cmb_Department)
            If Cmb_Department.Items.Count > 0 Then
                Cmb_Department.SelectedIndex = 0
            End If
        End If
       


        Call LoadRs("Select *  From AP_Sections Where   Sec_nmL =N'" & Trim(Cmb_Department.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtDepart_id.Text = Trim(rs("Sec_id").Value)
            Location_nm = Trim(rs("Sec_nmL").Value.ToString)
            'Prov_Id = Trim(rs("Hos_id").Value.ToString)
            'Sym = Trim(rs("sym").Value.ToString)
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

        MDST = txtDepart_id.Text
        FrmAPInvioce.Label2.Text = Location_nm
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



    Private Sub txt_Bk_nm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Department.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Sections Where   Sec_nmL =N'" & Trim(Cmb_Department.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtDepart_id.Text = Trim(rs("Sec_id").Value)
            Location_nm = Trim(rs("Sec_nmL").Value.ToString)
            'Prov_Id = Trim(rs("Hos_id").Value.ToString)
            'Sym = Trim(rs("sym").Value.ToString)
      
        End If
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUsername.Click

    End Sub





    Private Sub txt_Bk_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepart_id.TextChanged

    End Sub
End Class