Imports System.Data
Imports System
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class FrmOffice
    Dim rs As New ADODB.Recordset
    Dim Sql As String
    Dim StrFIlePath As String
    Dim StrFilename As String
    Dim a, b, c, d, g, f As Integer
    Private mImageFile As Image
    Dim objcuur As CurrencyManager
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim addnewmod As Boolean
    Dim FileName1, address, stradrres As String
    Dim pic2 As Byte
    Dim txt_proText As New Integer
    Dim DataFile As String, Chunks As Integer, FI As Long
    'Dim FileName As String
    Dim Fragment As Integer
    Dim dttable As DataTable
    Dim obj As CurrencyManager
    Dim imgName As String
    Private mImageFilePath As String
    Dim sFilePath As String
    Private Sub Office_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        's = 0
        If MDLanguage = 0 Then
            Call LngLao()
        Else
            Call Lngs()
        End If
        Call filldata()
        'Call LoadImage()
        'Call LoadPhoto(ImageSlno)
    End Sub
    Public Sub Lngs()
        Label2.Text = "Company:"
        Label9.Text = "Home no:"
        Label10.Text = "Steet:"
        Label14.Text = "Village:"
        Label13.Text = "District:"
        Label12.Text = "Province:"
        Label8.Text = "Tel:"
        Label11.Text = "Fax:"
        Label5.Text = "Bank name(1):"
        Label55.Text = "Account NO(1):"
        Label6.Text = "Bank name(2):"
        Label3.Text = "Account NO(2):"
        Label17.Text = "Bank name(3):"
        Label7.Text = "Account NO(3):"
        Button3.Text = "Save"
        Button1.Text = "Exit"
    End Sub
    Public Sub LngLao()
        Label2.Text = "ສໍານັກງານ:"
        Label9.Text = "ສໍານັກງານເລກທີ່:"
        Label10.Text = "ຖະໜົນ:"
        Label14.Text = "ບ້ານ:"
        Label13.Text = "ເມືອງ:"
        Label12.Text = "ແຂວງ:"
        Label8.Text = "ເບີໂທ:"
        Label11.Text = "ແຝັກ:"
        Label5.Text = "ຊື່ທະນາຄານ(1):"
        Label55.Text = "ເລກບັນຊີ(1):"
        Label6.Text = "ຊື່ທະນາຄານ((2):"
        Label3.Text = "ເລກບັນຊີ(2):"
        Label17.Text = "ຊື່ທະນາຄານ((3):"
        Label7.Text = "ເລກບັນຊີ(3):"
        Button3.Text = "ບັນທຶກ"
        Button1.Text = "ອອກ"
    End Sub
    Private Sub LoadImage()
        With rs
            Call LoadRs("select AddressPic from AP_Office where off_iD='" & "APIS" & "'", rs)
            If .RecordCount <> 0 Then
                txtLogo.Image = Image.FromFile(.Fields("AddressPic").Value)
                LbBackgroundAddress.Text = .Fields("AddressPic").Value
                mImageFilePath = .Fields("AddressPic").Value
            End If
        End With
    End Sub
    Private Sub filldata()
        With rs
            Call LoadRs("select * from AP_Office where off_iD<>''" & Sql & " ORDER BY off_id", rs)
            If .RecordCount <> 0 Then
                txtBnk1.Text = (.Fields("Bnk1").Value.ToString)
                txtBnk2.Text = (.Fields("Bnk2").Value.ToString)
                txtBnk3.Text = (.Fields("Bnk3").Value.ToString)
                txtAcc1.Text = (.Fields("Acc1").Value.ToString)
                txtAcc2.Text = (.Fields("Acc2").Value.ToString)
                txtAcc3.Text = (.Fields("Acc3").Value.ToString)

                txtTIN.Text = CStr(.Fields("TIN").Value)
                txtID.Text = CStr(.Fields("off_id").Value)
                txtNmL.Text = CStr(.Fields("off_nm").Value)
                'txtNmE.Text = CStr(.Fields("off_nmE").Value)
                txtHnoL.Text = CStr(.Fields("off_NoL").Value)
                '  txtHnoE.Text = CStr(.Fields("off_NoE").Value)
                txtStL.Text = CStr(.Fields("off_StrtL").Value)
                '  txtStE.Text = CStr(.Fields("off_StrtE").Value)
                txtvillL.Text = CStr(.Fields("off_VillageL").Value)
                '  txtVillE.Text = CStr(.Fields("Off_VillageE").Value)
                txtDisL.Text = CStr(.Fields("Off_DistL").Value)
                '  txtDisE.Text = CStr(.Fields("Off_DistE").Value)
                txtProL.Text = CStr(.Fields("Off_ProvL").Value)
                '  txtProE.Text = CStr(.Fields("Off_ProvE").Value)
                txtTel.Text = CStr(.Fields("Tel").Value)
                txtFax.Text = CStr(.Fields("Fax").Value)
                txtLocalH.Text = CStr(.Fields("Logo_W").Value)
                txtLocalW.Text = CStr(.Fields("Logo_H").Value)

                txtindex.Text = Format(CDbl(.Fields("index_monney").Value), "##,##0.00")
            End If
        End With
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Apimage = True
        Me.Close()
    End Sub
    Private Sub txtNmL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNmL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtHnoL.Focus()
        End If
    End Sub
    Private Sub txtNmE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtHnoL.Focus()
        End If
    End Sub
    Private Sub txtHnoL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHnoL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtStL.Focus()
        End If
    End Sub
    Private Sub txtStL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtvillL.Focus()
        End If
    End Sub
    Private Sub txtvillL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvillL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDisL.Focus()
        End If
    End Sub
    Private Sub txtDisL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDisL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtProL.Focus()
        End If
    End Sub
    Private Sub txtProL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTel.Focus()
        End If
    End Sub
    Private Sub txtTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        If e.KeyChar = Chr(13) Then
            txtFax.Focus()
        End If
    End Sub
    Private Sub txtHnoE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            ' txtStE.Focus()
        End If
    End Sub
    Private Sub txtStE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            '  txtVillE.Focus()
        End If
    End Sub
    Private Sub txtVillE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            '    txtDisE.Focus()
        End If
    End Sub
    Private Sub txtDisE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            '   txtProE.Focus()
        End If
    End Sub
    Private Sub txtProE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtFax.Focus()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Conn.Execute("UPDATE AP_Office SET " & _
         " Bnk1 =N'" & CStr(txtBnk1.Text) & "'," & _
         " Bnk2 =N'" & CStr(txtBnk2.Text) & "'," & _
         " Bnk3 =N'" & CStr(txtBnk3.Text) & "'," & _
         " Acc1 =N'" & CStr(txtAcc1.Text) & "'," & _
         " Acc2 =N'" & CStr(txtAcc2.Text) & "'," & _
         " Acc3 =N'" & CStr(txtAcc3.Text) & "'," & _
         " TIN =N'" & CStr(txtTIN.Text) & "'," & _
         " off_nm =N'" & CStr(txtNmL.Text) & "'," & _
         " off_NoL = N'" & CStr(txtHnoL.Text) & "'," & _
         " off_StrtL =N'" & CStr(txtStL.Text) & "'," & _
         " off_VillageL =N'" & CStr(txtvillL.Text) & "'," & _
         " Off_DistL =N'" & CStr(txtDisL.Text) & "'," & _
         " Off_ProvL =N'" & CStr(txtProL.Text) & "'," & _
         " Tel =N'" & txtTel.Text & "'," & _
         " Fax =N'" & txtFax.Text & "'," & _
         " Logo_W =  '" & txtLocalW.Text & "'," & _
          " index_monney = '" & CDbl(txtindex.Text) & "', " & _
         " Logo_H = '" & txtLocalH.Text & "' " & _
         " WHERE off_id =N'" & CStr(txtID.Text) & "'")
        'If s = 1 Then
        '    Call Update_Image()
        '    'Call add_img()
        '    MsgBox("Save Complete!", MsgBoxStyle.OkOnly)
        '    Call filldata()
        '    'Call LoadPhoto(ImageSlno)
        'Else
        '    MsgBox("Save Complete!", MsgBoxStyle.OkOnly)
        '    Call filldata()
        '    'Call LoadPhoto(ImageSlno)
        'End If
        Conn.Execute("UPDATE Level_class SET " & _
        " index_monney = '" & CDbl(txtindex.Text) & "' " & _
     " WHERE cc =1")
    End Sub
    Public Sub add_img()
        mImageFilePath = sFilePath
        Dim fs As FileStream = New FileStream(mImageFilePath.ToString(), FileMode.Open)
        Dim img As Byte() = New Byte(fs.Length) {}
        fs.Read(img, 0, fs.Length)
        fs.Close()
        mImageFile = Image.FromFile(mImageFilePath.ToString())
        Dim imgHeight As Integer = mImageFile.Height
        Dim imgWidth As Integer = mImageFile.Width
        Dim imgLength As Integer = mImageFile.PropertyItems.Length
        Dim imgType As String = Path.GetExtension(mImageFilePath)
        mImageFile = Nothing
        'If imgWidth > 240 Or imgLength > 320 Then MsgBox("ກະລຸນາເລືອກຮູບທີມີຂະໜາດໜ້ອຍກວ່າ 240 x 320 ") : Exit Sub
        con = New SqlConnection("Data Source=  " & MDServerName & ";Integrated Security=SSPI;Initial Catalog= " & MDDatabaName & "")
        'Dim sSQL As String = "INSERT INTO pics(mageContent,ip) VALUES(@pic,N'" & mImageFilePath & "')"
        Dim sSQL As String = "UPDATE AP_Office SET Logo= @pic,AddressPic=N'" & mImageFilePath & "' WHERE off_id =N'" & (txtID.Text) & "' "
        Dim cmd As SqlCommand = New SqlCommand(sSQL, con)
        'Image(content)
        Dim pic As SqlParameter = New SqlParameter("@pic", SqlDbType.Image)
        pic.Value = img
        cmd.Parameters.Add(pic)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
            Exit Sub
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' OpenFileDialog1.Title = "Set Image File"
        ' OpenFileDialog1.Filter = "Bitmap Files|*.bmp" & _
        '"|Gif Files|*.gif|JPEG Files|*.jpg"
        ' OpenFileDialog1.DefaultExt = "bmp"
        ' OpenFileDialog1.FilterIndex = 1
        ' OpenFileDialog1.FileName = ""
        ' OpenFileDialog1.ShowDialog()
        ' StrFilename = OpenFileDialog1.SafeFileName
        ' StrFIlePath = OpenFileDialog1.FileName
        ' If StrFIlePath = "" Then Exit Sub
        ' txtLogo.Image = Image.FromFile(StrFilename)
        ' LbBackgroundAddress.Text = StrFIlePath
        's = 1
        OpenFileDialog1.Title = "Set Image File"
        OpenFileDialog1.Filter = "Bitmap Files|*.bmp" & _
       "|Gif Files|*.gif|JPEG Files|*.jpg"
        OpenFileDialog1.DefaultExt = "bmp"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        'If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
        '    Exit Sub
        'End If

        sFilePath = OpenFileDialog1.FileName
        If sFilePath = "" Then Exit Sub
        If System.IO.File.Exists(sFilePath) = False Then
            Exit Sub
        Else
            txtLogo.Image = Image.FromFile(sFilePath)
            LbBackgroundAddress.Text = sFilePath
            mImageFilePath = sFilePath
        End If



       

    End Sub

    Private Sub txtFax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFax.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBnk1.Focus()
        End If
    End Sub

    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged

    End Sub

    Private Sub txtTel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTel.TextChanged

    End Sub

    Private Sub txtNmL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNmL.TextChanged

    End Sub

    Private Sub txtAcc3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAcc3.KeyPress
        If e.KeyChar = Chr(13) Then
            Button3_Click(sender, e)
        End If
    End Sub

    Private Sub txtAcc3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAcc3.TextChanged

    End Sub

    Private Sub txtBnk1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBnk1.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAcc1.Focus()
        End If
    End Sub

    Private Sub txtBnk1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBnk1.TextChanged

    End Sub

    Private Sub txtAcc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAcc1.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBnk2.Focus()
        End If
    End Sub

    Private Sub txtAcc1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAcc1.TextChanged

    End Sub

    Private Sub txtBnk2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBnk2.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAcc2.Focus()
        End If
    End Sub

    Private Sub txtBnk2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBnk2.TextChanged

    End Sub

    Private Sub txtAcc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAcc2.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBnk3.Focus()
        End If
    End Sub

    Private Sub txtAcc2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAcc2.TextChanged

    End Sub

    Private Sub txtBnk3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBnk3.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAcc3.Focus()
        End If
    End Sub

    Private Sub txtBnk3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBnk3.TextChanged

    End Sub

    Private Sub txtStL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStL.TextChanged

    End Sub

    Private Sub txtProL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProL.TextChanged

    End Sub

    Private Sub txtindex_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtindex.KeyPress
        If e.KeyChar = Chr(13) Then
            txtindex.Text = Format(CDbl(txtindex.Text), "#,##0.00")
        End If
    End Sub

    Private Sub txtindex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtindex.TextChanged
        'txtindex.Text = Format(CDbl(txtindex.Text), "#,##0.00")
    End Sub
End Class