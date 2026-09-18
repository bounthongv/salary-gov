Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Public Class FrmChang_password
    Dim desCrypt As DESCryptoServiceProvider
    Dim PwdWithEncrypt As String
    Dim ms As MemoryStream
    Dim cs As CryptoStream
    Public RSC As New ADODB.Recordset
    Dim rs As New ADODB.Recordset
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Decrypt_Text()
        If Trim(txtEncrypt.Text) <> MPws Then MsgBox("Password incorrect!", MsgBoxStyle.OkOnly) : txtPWDOld.Focus() : Exit Sub
        ' If Trim(txtPWDNew.Text) = "" Then MsgBox("ກະລຸນາປ້ອນລະຫັດຜ່ານໃໝ່!", MsgBoxStyle.OkOnly) : txtPWDNew.Focus() : Exit Sub
        ' If Trim(txtConfirm.Text) = "" Then MsgBox("ກະລຸນາຢືນຢັນລະຫັດຜ່ານ!", MsgBoxStyle.OkOnly) : txtConfirm.Focus() : Exit Sub
        If Trim(txtPWDNew.Text) <> Trim(txtConfirm.Text) Then MsgBox("Password different!", MsgBoxStyle.OkOnly) : txtPWDNew.Focus() : Exit Sub
        Call Encrypt_Text()
        Conn.Execute("UPDATE AP_Users SET PWD =N'" & txtEncrypt.Text & "' WHERE Usr_id =N'" & MUserID & "'")
        Me.Close()
        If RSC.State = ConnectionState.Open Then RSC.Close()
        txtPWDOld.Focus()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtPWDOld_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPWDOld.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPWDNew.Focus()
        End If
    End Sub

    Private Sub txtPWDOld_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPWDOld.TextChanged

    End Sub

    Private Sub txtPWDNew_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPWDNew.KeyPress
        If e.KeyChar = Chr(13) Then
            txtConfirm.Focus()
        End If
    End Sub

    Private Sub txtPWDNew_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPWDNew.TextChanged

    End Sub

    Private Sub txtConfirm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirm.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub txtConfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirm.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub FrmChang_password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Lang = False Then
            Label1.Text = "ລະຫັດຜ່ານເກົ່າ:"
            Label2.Text = "ລະຫັດຜ່ານໃໝ່:"
            Label3.Text = "ຢໍ້າຄືນລະຫັດໃໝ່:"
        Else
            Label1.Text = "Old Password"
            Label2.Text = "New Password"
            Label3.Text = "Confirm"
        End If
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
        Dim arrByte As Byte() = Encoding.ASCII.GetBytes(txtPWDNew.Text)
        cs.Write(arrByte, 0, arrByte.Length)
        cs.FlushFinalBlock()
        cs.Close()
        PwdWithEncrypt = Convert.ToBase64String(ms.ToArray())
        txtEncrypt.Text = PwdWithEncrypt
    End Sub
    Private Sub Decrypt_Text()
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
        Dim arrByte As Byte() = Encoding.ASCII.GetBytes(txtPWDOld.Text)
        cs.Write(arrByte, 0, arrByte.Length)
        cs.FlushFinalBlock()
        cs.Close()
        PwdWithEncrypt = Convert.ToBase64String(ms.ToArray())
        txtEncrypt.Text = PwdWithEncrypt
    End Sub
End Class