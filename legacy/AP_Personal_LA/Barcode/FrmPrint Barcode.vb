Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmPrint_Barcode
    Dim rs As New ADODB.Recordset
    Dim Sql As String
    Dim j As Integer
    Dim filePath As String
    Dim cn As New SqlConnection
    Dim cnstr As String = "Data Source=" & MDServerName & ";Initial Catalog=" & MDDatabaName & ";User ID=" & MDServerUser & ";Password=" & MDServerPassword & " "
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'FrmCustomer_item.ShowDialog()
        Dim N As Integer = 0
        Dim i As Integer
        Dim j As String
        Dim B1, B2 As String
        N = Val(txt_2.Text) - Val(txt_1.Text) + 1
        j = Trim(txt_Bk_ID.Text) & Format(Val(txt_1.Text), "00000")
        Fg.Rows = N + 1

        For i = 1 To N

            Fg.set_TextMatrix(i, 1, j)
            j = Trim(txt_Bk_ID.Text) & Format(Val(txt_1.Text) + i, "00000")


            B1 = (Fg.get_TextMatrix(i, 1)) & ".01"
            Fg.set_TextMatrix(i, 2, B1)

            B2 = (Fg.get_TextMatrix(i, 1)) & ".02"
            Fg.set_TextMatrix(i, 3, B2)


      

        Next


        'If MDBarcode = "" Then Exit Sub
        'Dim RsCat As New ADODB.Recordset
        'With RsCat
        '    Call LoadRs("Select * from AP_Books WHERE Bill_no='" & CustID & "'", RsCat)
        '    If .RecordCount = 0 Then
        '        Call Button8_Click(sender, e)
        '    Else
        '        If Trim(Fg.get_TextMatrix(1, 1)) <> "" Then
        '            For i = 1 To Fg.Rows - 1
        '                If UCase(MDBarcode) = UCase(Fg.get_TextMatrix(i, 1)) Then Exit Sub
        '            Next i
        '        Else
        '            Fg.Rows = 1
        '        End If
        '        Fg.AddItem(Fg.Rows & _
        '        Chr(9) & .Fields("Cat_ID").Value & _
        '        Chr(9) & .Fields("Bar_Code").Value & _
        '        Chr(9) & .Fields("Cat_nmL").Value & _
        '        Chr(9) & "1" & _
        '        Chr(9) & .Fields("Price").Value)
        '    End If
        'End With
    End Sub
    Private Sub FrmPrint_Barcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtsearch.Location = New System.Drawing.Point(499, 12)
        txtsearch.Size = New System.Drawing.Point(100, 23)

        Call Langs()
        txt_Bk_nm.Items.Clear()
        Call load_Cmb(" SELECT Bk_nm FROM AP_LocationBk WHERE BK_ID <> '00' ORDER BY BK_ID ", "Bk_nm", txt_Bk_nm)
        If txt_Bk_nm.Items.Count > 0 Then
            txt_Bk_nm.SelectedIndex = 0
        End If

    End Sub
    Private Sub Langs()
        Button8.Text = "ເພີ່ມໃໝ່"
        Button2.Text = "ພິມ Barcode"
        Fg.FormatString = "ລ/ດ |<ບາໂຄດປື້ມ              |<ບາໂຄດເດັກ 1                     |<ບາໂຄດເດັກ 2                       "
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Conn.Execute("delete from  RPT_PintBarcode ")
        Dim Rschk As New ADODB.Recordset
        Dim i As Integer
        With Rschk
            For i = 1 To Fg.Rows - 1
                'Call LoadRs("Select * From RPT_PintBarcode WHERE Bill_no=N'" & txtBill_no.Text & "' AND Cat_ID=N'" & (Fg.get_TextMatrix(i, 1)) & "' and  serial_no=N'" & (Fg.get_TextMatrix(i, 2)) & "' AND Price = " & CDbl(Fg.get_TextMatrix(i, 5)) & " ", Rschk)
                'If Rschk.RecordCount = 0 Then
                Conn.Execute("INSERT INTO RPT_PintBarcode (BK_ID, BB_ID1, BB_ID2) " & _
                " VALUES ( " & _
                       " N'" & Apostrophe(Fg.get_TextMatrix(i, 1)) & "'," & _
                     " N'" & Apostrophe(Fg.get_TextMatrix(i, 2)) & "'," & _
                         " N'" & Apostrophe(Fg.get_TextMatrix(i, 3)) & "') ")
                'End If
            Next i
        End With
        Call Report()
    End Sub
    Private Sub OpenData()
        Try
            With cn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = cnstr
                .Open()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SaveData()
        'Try
        '    Dim fs As FileStream

        '    filePath = Application.StartupPath & "Barcode.jpg"
        '    Dim img As Image = SCapture.Control(Me.PictureBox1.Handle, False)
        '    img.Save(filePath, Drawing.Imaging.ImageFormat.Png)

        '    fs = New FileStream(filePath, FileMode.Open, FileAccess.Read)

        '    Dim picByte As Byte() = New Byte(fs.Length - 1) {}

        '    fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))

        '    fs.Close()
        '    '===
        '    'OpenData()

        '    Dim strSQL As String

        '    strSQL = "INSERT INTO tblBarcode(Barcode,ImgBarcode) values ('" & Trim(txtEAN.Text) & "',@Img)"

        '    Dim imgParam As New SqlParameter()

        '    imgParam.SqlDbType = SqlDbType.Binary
        '    imgParam.ParameterName = "Img"
        '    imgParam.Value = picByte

        '    Dim cmd As New SqlCommand(strSQL, cn)

        '    cmd.Parameters.Add(imgParam)
        '    cmd.ExecuteNonQuery()

        '    ' MessageBox.Show("successfully saved.")
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub Report()
        With rs
            Call LoadRs("SELECT *  from RPT_PintBarcode", rs)
            If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
            Dim Frm As New FrmPreview
            Dim Rpt As New Report_bacode
            Rpt.SetDataSource(rs)
            Rpt.Refresh()
            Frm.ReportViewer.ReportSource = Rpt
            Frm.ReportViewer.DisplayGroupTree = False
            ' Frm.ReportViewer.ShowZoomButton = False
            Frm.WindowState = FormWindowState.Maximized
            Frm.Show()
            Rpt = Nothing
        End With
    End Sub

    Private Sub Bracode()
        With Fg
            Conn.Execute("insert into  RPT_PintBarcode (Cat_ID,Barcode ,Cat_nm ) values( N'" & Trim(.get_TextMatrix(j, 1)) & "',  N'" & Trim(.get_TextMatrix(j, 2)) & "', N'" & Trim(.get_TextMatrix(j, 3)) & "' ) ")
        End With
    End Sub
    Private Sub Bracode1()
        With Fg
            Conn.Execute("insert into  RPT_PintBarcode (Cat_ID,Barcode ,Barcode1,Cat_nm ) values( N'" & Trim(.get_TextMatrix(j, 1)) & "',  N'" & Trim(.get_TextMatrix(j, 2)) & "',  N'" & Trim(.get_TextMatrix(j, 2)) & "', N'" & Trim(.get_TextMatrix(j, 3)) & "' ) ")
        End With
    End Sub
    Private Sub Bracode2()
        With Fg
            Conn.Execute("insert into  RPT_PintBarcode (Cat_ID,Barcode ,Barcode1,Barcode2,Cat_nm ) values( N'" & Trim(.get_TextMatrix(j, 1)) & "',  N'" & Trim(.get_TextMatrix(j, 2)) & "', N'" & Trim(.get_TextMatrix(j, 2)) & "',  N'" & Trim(.get_TextMatrix(j, 2)) & "', N'" & Trim(.get_TextMatrix(j, 3)) & "' ) ")
        End With
    End Sub
    Private Sub Bracode3()
        With Fg
            Conn.Execute("insert into  RPT_PintBarcode (Cat_ID,Barcode ,Barcode1,Barcode2,Barcode3,Cat_nm ) values( N'" & Trim(.get_TextMatrix(j, 1)) & "',  N'" & Trim(.get_TextMatrix(j, 2)) & "',N'" & Trim(.get_TextMatrix(j, 2)) & "', N'" & Trim(.get_TextMatrix(j, 2)) & "',  N'" & Trim(.get_TextMatrix(j, 2)) & "', N'" & Trim(.get_TextMatrix(j, 3)) & "' ) ")
        End With
    End Sub
    Private Sub Fg_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg.DblClick
        If Trim(Fg.get_TextMatrix(1, 0)) = "" Then Exit Sub
        If MsgBox("Do you want to cancle ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Fg.Rows = 2 Then
                Fg.Rows = 1
                Fg.Rows = 2
            Else
                Fg.RemoveItem(Fg.Row)
            End If
        End If
    End Sub

    Private Sub Fg_KeyUpEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_KeyUpEvent) Handles Fg.KeyUpEvent
        Fg.set_TextMatrix(Fg.Row, 4, Fg.get_TextMatrix(Fg.Row, 4))
    End Sub
    Private Sub Fg_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg.SelChange
        Sql = Fg.get_TextMatrix(Fg.Row, 4)
        If Sql = "" Then
            txtsearch.Text = ""
        Else
            txtsearch.Text = Sql
        End If
        txtRow.Text = Fg.Row
        txtCol.Text = Fg.Col
        If txtCol.Text < 4 Then txtsearch.Visible = False : Exit Sub
        If txtRow.Text = 1 Then
            If txtCol.Text = 4 Then
                txtsearch.Size = New System.Drawing.Point(100, 23)
                txtsearch.Location = New System.Drawing.Point(738, 64)
                'txtsearch.Visible = True
                txtsearch.Focus()
            End If
        End If
        If txtRow.Text > 1 Then
            If txtCol.Text = 4 Then
                txtsearch.Size = New System.Drawing.Point(100, 23)
                txtsearch.Location = New System.Drawing.Point(738, CDbl(64) + CDbl(CDbl(24) * txtRow.Text) - 24)
                'txtsearch.Visible = True
                txtsearch.Focus()

            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtRow.Text = Fg.Row
        txtCol.Text = Fg.Col
        If txtRow.Text = 1 Then
            If txtCol.Text = 4 Then
                txtsearch.Size = New System.Drawing.Point(100, 23)
                txtsearch.Location = New System.Drawing.Point(646, 64)
                txtsearch.Visible = True
                txtsearch.Focus()
            End If
        End If
        If txtRow.Text > 1 Then
            If txtCol.Text = 4 Then
                txtsearch.Size = New System.Drawing.Point(100, 23)
                txtsearch.Location = New System.Drawing.Point(646, CDbl(64) + CDbl(CDbl(24) * txtRow.Text) - 24)
                txtsearch.Visible = True
                txtsearch.Focus()

            End If
        End If
    End Sub
    Private Sub txtsearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            Fg.set_TextMatrix(txtRow.Text, 4, txtsearch.Text)
            txtsearch.Visible = False
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub txt_Bk_nm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Bk_nm.SelectedIndexChanged
        Call LoadRs("Select *  From AP_LocationBk Where   Bk_nm =N'" & Trim(txt_Bk_nm.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txt_Bk_ID.Text = Trim(rs("BK_ID").Value)

        End If
    End Sub
End Class