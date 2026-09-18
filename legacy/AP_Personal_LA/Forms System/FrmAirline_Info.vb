Public Class FrmAirline_Info
    Public RSC As New ADODB.Recordset
    Dim itemfgacc As Boolean
    Dim rs As New ADODB.Recordset
    Dim Sql, Sqls As String
    Dim lak, thb, usd, eur As String
    Private Sub FrmAirline_Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        's = 0
        If MDLanguage = 0 Then
            'Call LngLao()
        Else
            '   Call Lngs()
        End If
        Call Load_Data_info()
        txtLogo.Hide()
        btnBrow.Hide()
        PictureBox1.Hide()
        Label13.Hide()
        '   PictureBox1.Image = Image.FromFile(txtLogo.Text)
        '   Call LoadPhoto(ImageSlno)
    End Sub
    Public Sub Load_Data_info()
        With rs
            Call LoadRs(" SELECT * FROM AP_Airline_info WHERE ID = 'APIS'", rs)
            If .RecordCount > 0 Then
                txtCom_in.Text = .Fields("com_in").Value.ToString
                txtcom_nam.Text = .Fields("com_name").Value.ToString
                txtSec.Text = .Fields("Sec").Value.ToString
                txtStreet.Text = .Fields("com_st").Value.ToString
                txtTel.Text = .Fields("com_tel").Value.ToString
                txtFax.Text = .Fields("com_fax").Value.ToString
                txtpost.Text = .Fields("com_post").Value.ToString
                txtAccount_K.Text = .Fields("Account_K").Value.ToString
                txtAccount_USD.Text = .Fields("Account_USD").Value.ToString
                txtNation_Account_K.Text = .Fields("Na_Account_K").Value.ToString
                txtAccount_Knm.Text = .Fields("Account_Knm").Value.ToString
                txtAccount_USDnm.Text = .Fields("Account_USDnm").Value.ToString
                txtNation_Account_Knm.Text = .Fields("Na_Account_Knm").Value.ToString
            End If
        End With
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call Update_Info()
        Call ADD_BANK()
        ' Call Update_Image()
        MsgBox("ການບັນທຶກຂໍ້ມູນສຳເລັດແລ້ວ !")
    End Sub
    Private Sub Update_Info()
        Conn.Execute("UPDATE AP_Airline_info SET com_in=N'" & txtCom_in.Text & "', " & _
                     " com_name=N'" & txtcom_nam.Text & "', " & _
                     " Sec=N'" & txtSec.Text & "', " & _
                     " com_st=N'" & txtStreet.Text & "', " & _
                     " com_tel=N'" & txtTel.Text & "', " & _
                     " com_fax=N'" & txtFax.Text & "', " & _
                     " com_post=N'" & txtpost.Text & "', " & _
                     " Account_Knm=N'" & txtAccount_Knm.Text & "', " & _
                     " Account_K=N'" & txtAccount_K.Text & "', " & _
                     " Account_USDnm=N'" & txtAccount_USDnm.Text & "', " & _
                     " Account_USD=N'" & txtAccount_USD.Text & "', " & _
                     " Na_Account_Knm=N'" & txtNation_Account_Knm.Text & "', " & _
                     " Na_Account_K=N'" & txtNation_Account_K.Text & "' " & _
                     " WHERE ID='APIS'")
    End Sub
    Private Sub ADD_BANK()
        Conn.Execute("DELETE  AP_Airline_Bank ")
        If txtAccount_Knm.Text <> "" Then
            Conn.Execute("INSERT INTO  AP_Airline_Bank (Bnm,Acc) VALUES (N'" & txtAccount_Knm.Text & "',N'" & txtAccount_K.Text & "') ")
        End If
        If txtNation_Account_Knm.Text <> "" Then
            Conn.Execute("INSERT INTO  AP_Airline_Bank (Bnm,Acc) VALUES (N'" & txtNation_Account_Knm.Text & "',N'" & txtNation_Account_K.Text & "') ")
        End If
        If txtAccount_USDnm.Text <> "" Then
            Conn.Execute("INSERT INTO  AP_Airline_Bank (Bnm,Acc) VALUES (N'" & txtAccount_USDnm.Text & "',N'" & txtAccount_USD.Text & "') ")
        End If
    End Sub

    Private Sub btnBrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrow.Click
        With OpenFileDialog1
            .Filter = "Bitmap Files|*.bmp|Gif Files|*.gif|JPEG Files|*.jpg"
            .DefaultExt = "bmp"
            .FilterIndex = 1
        End With
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLogo.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(txtLogo.Text)
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub
End Class