
Public Class FrmAPInvioce

    Dim rsProj As New ADODB.Recordset
    Public editProj As Boolean
    Dim Sql As String
    Dim Fn As String
    Dim rs As New ADODB.Recordset
    Dim StrFIlePath As String
    Dim StrFilename As String
    Private Sub APCashier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Private Sub FrmAPCashier_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Do you want to exit program?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
            Me.Close()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub APCashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Button1.Visible = True
        'Call HideMenu()
        'Call ConnectionData()
        'Call Connect()
        'Call CheckStaff()
        'MDForMain = "Kantana"
        Me.WindowState = FormWindowState.Maximized
        'Call LangLao()
        Call LoadBackground()
        'Call ພາສາລາວToolStripMenuItem_Click(sender, e)
        ' ToolStripMenuItem1.Visible = True

        '============================================== ລາຍງານການຮັບເງິນສົດ - ຕິດໜີ້

        If Mpermiss = "Admin" Then

        End If
       
        Call LoadLng()
        Lang = False
        Call Loadlang()
        Call SetControlText(Me)
        Call ChgChildForm()
    End Sub
    Private Sub CheckStaff()
        If ForStaff = 0 Then

            tlsBackup.Visible = True
            tlsStaff.Visible = True
            tlsSec.Visible = True
            tlsSecurity.Visible = True
            ToolStripSeparator59.Visible = True
            ToolStripSeparator61.Visible = True
        Else

            tlsBackup.Visible = False
            tlsStaff.Visible = False
            tlsSec.Visible = False
            tlsSecurity.Visible = False
            ToolStripSeparator61.Visible = False
        End If
    End Sub
    Private Sub LoadBackground()
        Call LoadData("select * from TblImage where BackID='" & "00001" & "'", rs)
        If rs.RecordCount = 0 Then
            Exit Sub
        Else
            On Error GoTo hang
hang:
            If Err.Number = 0 Then
                Me.BackgroundImage = Image.FromFile(rs.Fields("FileAddress").Value.ToString)
                VSysError = False
            Else
                VSysError = True
                MessageBox.Show("No Background " & (rs.Fields("FileAddress").Value.ToString) & "  in data base please Select Image To Background")
                OpenFileDialog1.ShowDialog()
                StrFilename = OpenFileDialog1.SafeFileName
                StrFIlePath = OpenFileDialog1.FileName
                If StrFIlePath = "" Or StrFIlePath = "OpenFileDialog1" Then Exit Sub
                CNN.Execute("UPDATE TblImage SET FileAddress ='" & StrFIlePath & "' ," & _
                                       " FileNmae='" & StrFIlePath & "' " & _
                                      " WHERE BackID='" & "00001" & "' ")
                Call LoadData("select * from TblImage where BackID='" & "00001" & "'", rs)
                If rs.RecordCount <> 0 Then
                    While Not rs.EOF
                        Me.BackgroundImage = Image.FromFile(rs.Fields("FileAddress").Value.ToString)
                        Me.BackgroundImageLayout = ImageLayout.Stretch
                        rs.MoveNext()
                    End While
                End If

            End If
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
        Call LoadData("select * from BackGroundImage where BackID='" & "00001" & "'", rs)
        If rs.RecordCount <> 0 Then
            While Not rs.EOF
                MenuStrip1.BackgroundImage = Image.FromFile(rs.Fields("FileAddress").Value)
                MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub ຂມນສານກງານToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Apimage = False
        Dim frm As New FrmOffice
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
    Private Sub ຕງວນທເຮດວຽກToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Set_date_working.ShowDialog()
    End Sub
    Private Sub ຕງຄາອດຕາແລກປToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Apimage = False
        'Dim frm As New Rate_setting
        'frm.MdiParent = Me
        'frm.WindowState = FormWindowState.Maximized
        'frm.Show()
    End Sub
    Private Sub ລາຍການພະນກງານToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Apimage = False
        Dim frm As New FrmStaff
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
    Private Sub ລາຍການພາກສວນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Apimage = False
        Dim frm As New FrmSectors
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
    Private Sub ລາຍການລກຄາToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Apimage = False
        Dim frm As New FrmCustomers
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
    Private Sub ຂມນຜນາໃຊໂປຣແກຣມToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Apimage = False
        Dim frm As New FrmUser
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
    Private Sub ການປຽນລະຫດຜານToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' PictureBox1.Visible = False
        FrmChang_password.ShowDialog()
    End Sub

    Private Sub ປດບນຊປະຈງເດອນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmMonthly_closing_account.ShowDialog()
    End Sub
    Private Sub ການສາຮອງຂມນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmBackup_Database.ShowDialog()
    End Sub
    Private Sub ອອກຈາກໂປຣແກຣມToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ອອກຈາກໂປຣແກຣມToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ອອກຈາກໂປຣແກຣມToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsOffice.Click
        Apimage = False
        'Dim frm As New FrmProduct_group
        FrmOffice.MdiParent = Me
        FrmOffice.WindowState = FormWindowState.Maximized
        FrmOffice.Show()
        'Apimage = False
        'FrmOffice.MdiParent = Me
        'FrmOffice.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsdate.Click
        Set_date_working.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsRate.Click
        Apimage = False
        frmRate.MdiParent = Me
        frmRate.WindowState = FormWindowState.Maximized
        frmRate.Show()

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsStaff.Click
        Apimage = False
        'Dim frm As New FrmStaff
        FrmStaff.MdiParent = Me
        FrmStaff.WindowState = FormWindowState.Maximized
        FrmStaff.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsSec.Click
        Apimage = False
        'Dim frm As New FrmSectors
        FrmSectors.MdiParent = Me
        FrmSectors.WindowState = FormWindowState.Maximized
        FrmSectors.Show()
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsUser.Click
        Apimage = False
        'Dim frm As New FrmUser
        Frm_User_List.MdiParent = Me
        Frm_User_List.WindowState = FormWindowState.Maximized
        Frm_User_List.Show()

        'Apimage = False
        'FrmUsersNew.MdiParent = Me
        ''FrmUsersNew.WindowState = FormWindowState.Maximized
        ''FrmUsersNew.Show()

        'FrmUser_DDC.MdiParent = Me
        'FrmUser_DDC.WindowState = FormWindowState.Maximized
        'FrmUser_DDC.Show()
        'FrmUser_DDC.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsPass.Click
        FrmChang_password.Show()
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmMonthly_closing_account.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsBackup.Click
        FrmBackup_Database.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsExit.Click
        Me.Close()
    End Sub


    Private Sub ToolStripMenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem80.Click
        FrmData_server.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmSet_as_default_printer.ShowDialog()
        'PrintDialog1.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem74.Click
        OpenFileDialog1.ShowDialog()
        StrFilename = OpenFileDialog1.SafeFileName
        StrFIlePath = OpenFileDialog1.FileName
        If StrFIlePath = "" Or StrFIlePath = "OpenFileDialog1" Then Exit Sub
        CNN.Execute("UPDATE TblImage SET FileAddress ='" & StrFIlePath & "' ," & _
                               " FileNmae='" & StrFIlePath & "' " & _
                              " WHERE BackID='" & "00001" & "' ")
        Call LoadData("select * from TblImage where BackID='" & "00001" & "'", rs)
        If rs.RecordCount <> 0 Then
            While Not rs.EOF
                Me.BackgroundImage = Image.FromFile(rs.Fields("FileAddress").Value.ToString)
                Me.BackgroundImageLayout = ImageLayout.Stretch
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub ToolStripMenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmOder_Products_Report.ShowDialog()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem81.Click
        FrmAbount_Program.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem82.Click
        frmCredit.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem73.Click
        'FrmCalculate.Show()
        Shell("calc.exe", vbNormalFocus)
    End Sub
    Public Sub LangEng()
        MDLanguage = 1

        '= System ===================================================================
        tlssystem.Text = "System"
        tlsOffice.Text = "Office information"
        tlsdate.Text = "Set date working"
        tlsRate.Text = "Rate setting"
        tlsStaff.Text = "Staff"
        tlsSec.Text = "Section"
        tlsSecurity.Text = "Security"
        tlsUser.Text = "User"
        tlsPass.Text = "Change password"
        tlsBackup.Text = "Backup Database"
        tlsExit.Text = "Exit Programe"
        '=========================================================================
        '= Product ===============================================================
        '=======================================================
        '= ຮັບສີນຄ້າເຂົ້າສາງ =========================================
        '=======================================================
        '= ຈ່າຍສີນຄ້າອອກສາງ =======================================
        '======================================================
        '= ຂາຍສີນຄ້າ ============================================

        '======================================================
        '= ພາສາ ===============================================

        '=====================================================
        '= ຊ່ວຍເຫຼືອ =============================================
        ToolStripMenuItem71.Text = "Help"
        ToolStripMenuItem74.Text = "Change background"
        ToolStripMenuItem80.Text = "Connection Datebase"
        ToolStripMenuItem81.Text = "Abount"
        ToolStripMenuItem82.Text = "Contact"
        '=====================================================
    End Sub

    Public Sub LangLao1()
        MDLanguage = 0

        tlssystem.Text = "ລະບົບ"
        ToolStripMenuItem71.Text = "ຊ່ວຍເຫຼືອ"
        tlsBackup.Text = "ສໍາຮອງຂໍ້ມູນ"
        tlsdate.Text = "ຕັ້ງເວລາເຮັດວຽກ"
        tlsExit.Text = "ອອກຈາກໂປຼແກຣມ"
        tlsOffice.Text = "ຂໍ້ມູນສໍານັກງານ"
        tlsPass.Text = "ປ່ຽນລະຫັດ"
        tlsSec.Text = "ລາຍການພະແນກ"
        tlsSecurity.Text = "ລະບົບປ້ອງກັນ"
        tlsStaff.Text = "ລາຍການພະນັກງານ"
        tlsUser.Text = "ລາຍການຜູ້ໃຊ້"
        'ToolStripMenuItem72.Text = "ເລືອກເຄື່ອງພິມ"
        'ToolStripMenuItem73.Text = "ຈັກຄິດໄລ່"
        'ToolStripMenuItem74.Text = "ປ່ຽນພາບພື້ນຫຼັງ"
        'ToolStripMenuItem75.Text = "ຮູບແບບເມນູ"
        'ToolStripMenuItem76.Text = "ຮູບແບບ XP"
        'ToolStripMenuItem77.Text = "ຮູບແບບ Office 2003"
        'ToolStripMenuItem78.Text = "By Money"
        'ToolStripMenuItem79.Text = "ຮູບແບບ ຕາມລະບົບ"
        ToolStripMenuItem80.Text = "ຕິດຕໍ່ຖານຂໍ້ມູນ"
        ToolStripMenuItem81.Text = "ຂໍ້ມູນກ່ຽວຂ້ອງ"
        ToolStripMenuItem82.Text = "ຕິດຕໍ່ພົວພັນ"
        'ToolStripMenuItem83.Text = "ປັບປຸງຂໍ້ມູນຂາຍ"
    End Sub
    Public Sub LangLao()
        MDLanguage = 0

        '= ລະບົບ ===================================================================
        tlssystem.Text = "ລະບົບ"
        tlsOffice.Text = "ຂໍ້ມູນສໍານັກງານ"
        tlsdate.Text = "ຕັ້ງເວລາເຮັດວຽກ"
        tlsRate.Text = "ອັດຕາແລກປ່ຽນ"
        tlsStaff.Text = "ລາຍການພະນັກງານ"
        tlsSec.Text = "ລາຍການພະແນກ"
        tlsSecurity.Text = "ລະບົບປ້ອງກັນ"
        tlsUser.Text = "ລາຍການຜູ້ໃຊ້"
        tlsPass.Text = "ປ່ຽນລະຫັດ"
        tlsExit.Text = "ອອກຈາກໂປຼແກຣມ"
        '=========================================================================
        '= ລາຍການສີນຄ້າ ===============================================================
        '=======================================================
        '= ຮັບສີນຄ້າເຂົ້າສາງ =========================================
        '=======================================================
        '= ຈ່າຍສີນຄ້າອອກສາງ =======================================
        '======================================================
        '= ຂາຍສີນຄ້າ ============================================
        '======================================================
        '= ພາສາ ===============================================

        '=====================================================
        '= ຊ່ວຍເຫຼືອ =============================================
        ToolStripMenuItem71.Text = "ຊ່ວຍເຫຼືອ"
        ToolStripMenuItem74.Text = "ປ່ຽນພາບພື້ນຫຼັງ"
        ToolStripMenuItem82.Text = "ຕິດຕໍ່ພົວພັນ"
        '=====================================================
    End Sub

    Private Sub StatusStrip3_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlscascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub EnddingBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmMonthly_closing_account.ShowDialog()
    End Sub


    Private Sub ToolStripMenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuStrip1.BackgroundImage = Image.FromFile("title.PNG")
        MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
        Dim Images As String
        Images = "title.PNG"
        CNN.Execute("UPDATE BackGroundImage SET FileAddress ='" & Images & "' ," & _
                            " FileNmae='" & Images & "' " & _
                           " WHERE BackID='" & "00001" & "' ")
        Call LoadData("select * from BackGroundImage where BackID='" & "00001" & "'", rs)
        If rs.RecordCount <> 0 Then
            While Not rs.EOF
                MenuStrip1.BackgroundImage = Image.FromFile(rs.Fields("FileAddress").Value)
                MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub ToolStripMenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuStrip1.BackgroundImage = Image.FromFile("labelInfo.BMP")
        MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
        Dim Images As String
        Images = "labelInfo.BMP"
        CNN.Execute("UPDATE BackGroundImage SET FileAddress ='" & Images & "' ," & _
                            " FileNmae='" & Images & "' " & _
                           " WHERE BackID='" & "00001" & "' ")
        Call LoadData("select * from BackGroundImage where BackID='" & "00001" & "'", rs)
        If rs.RecordCount <> 0 Then
            While Not rs.EOF
                MenuStrip1.BackgroundImage = Image.FromFile(rs.Fields("FileAddress").Value)
                MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub ToolStripMenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuStrip1.BackgroundImage = Image.FromFile("STATIC_CP_INFO.BMP")
        MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
        Dim Images As String
        Images = "STATIC_CP_INFO.BMP"
        CNN.Execute("UPDATE BackGroundImage SET FileAddress ='" & Images & "' ," & _
                            " FileNmae='" & Images & "' " & _
                           " WHERE BackID='" & "00001" & "' ")
        Call LoadData("select * from BackGroundImage where BackID='" & "00001" & "'", rs)
        If rs.RecordCount <> 0 Then
            While Not rs.EOF
                MenuStrip1.BackgroundImage = Image.FromFile(rs.Fields("FileAddress").Value)
                MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub ToolStripMenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuStrip1.BackgroundImage = Image.FromFile("STATIC_CP_INFO.BMP")
        MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
        Dim Images As String
        Images = "STATIC_CP_INFO.BMP"
        CNN.Execute("UPDATE BackGroundImage SET FileAddress ='" & Images & "' ," & _
                            " FileNmae='" & Images & "' " & _
                           " WHERE BackID='" & "00001" & "' ")
        Call LoadData("select * from BackGroundImage where BackID='" & "00001" & "'", rs)
        If rs.RecordCount <> 0 Then
            While Not rs.EOF
                MenuStrip1.BackgroundImage = Image.FromFile(rs.Fields("FileAddress").Value)
                MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub tlslang_lao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LangLao()
        '========ລະບົບ=========
        FrmOffice.LngLao()
        'Rate_setting.LangLao()
        FrmStaff.LangLao()
        FrmSectors.LangLao()
        FrmCustomers.LangLao()
        FrmUser.LangLao()
    End Sub

    Private Sub tlslang_en_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LangEng()
        '========ລະບົບ=========
        FrmOffice.Lngs()
        'Rate_setting.Langs()
        FrmStaff.Langs()
        FrmSectors.Langs()
        FrmCustomers.Langs()
        FrmUser.LoadLang()
        'Frm_In.Langs()
        '=========== ສາຍການບິນ ==========

    End Sub

    Private Sub tlsairline_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tlsAirline_ticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tlsAirline_Bill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tlsPlayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tlsBill_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tlsReport_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Apimage = False

    End Sub

    Private Sub ລາຍການລກຄາToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການລກຄາToolStripMenuItem1.Click
        Apimage = False
        'Dim frm As New FrmCustomers
        FrmCustomers.MdiParent = Me
        FrmCustomers.WindowState = FormWindowState.Maximized
        FrmCustomers.Show()
    End Sub

    Private Sub ລາຍການຂມນບານToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການຂມນບານToolStripMenuItem.Click
        Edit_Quotation = 0
        EditActive = False
        Frm_Location.MdiParent = Me
        Frm_Location.WindowState = FormWindowState.Maximized
        Frm_Location.Show()
    End Sub

    Private Sub ລາຍການຂມນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການຂມນToolStripMenuItem.Click
        Edit_Quotation = 0
        EditActive = False
        Frm_District.MdiParent = Me
        Frm_District.WindowState = FormWindowState.Maximized
        Frm_District.Show()
    End Sub

    Private Sub ລາຍການຂມນບານToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການຂມນບານToolStripMenuItem1.Click
        Edit_Quotation = 0
        EditActive = False
        Frm_Village.MdiParent = Me
        Frm_Village.WindowState = FormWindowState.Maximized
        Frm_Village.Show()
    End Sub

    Private Sub ເຂາຂມນປມຕດຕາມສຂະພາບToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ເຂາຂມນປມຕດຕາມສຂະພາບToolStripMenuItem.Click
        'Frm_Book_List.MdiParent = Me
        'Frm_Book_List.WindowState = FormWindowState.Maximized
        'Frm_Book_List.ShowIcon = False
        'Frm_Book_List.Show()

        Apimage = False

        FrmSectors.MdiParent = Me
        FrmSectors.WindowState = FormWindowState.Maximized
        FrmSectors.Show()
    End Sub
 

    Private Sub ລາຍການສະຖານທToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການສະຖານທToolStripMenuItem.Click
        Edit_Quotation = 0
        EditActive = False
        Frm_Location_BK.MdiParent = Me
        Frm_Location_BK.WindowState = FormWindowState.Maximized
        Frm_Location_BK.Show()
    End Sub

    Private Sub ປຽນພາບພນຫງToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ປຽນພາບພນຫງToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        StrFilename = OpenFileDialog1.SafeFileName
        StrFIlePath = OpenFileDialog1.FileName
        If StrFIlePath = "" Or StrFIlePath = "OpenFileDialog1" Then Exit Sub
        CNN.Execute("UPDATE TblImage SET FileAddress ='" & StrFIlePath & "' ," & _
                               " FileNmae='" & StrFIlePath & "' " & _
                              " WHERE BackID='" & "00001" & "' ")
        Call LoadData("select * from TblImage where BackID='" & "00001" & "'", rs)
        If rs.RecordCount <> 0 Then
            While Not rs.EOF
                Me.BackgroundImage = Image.FromFile(rs.Fields("FileAddress").Value.ToString)
                Me.BackgroundImageLayout = ImageLayout.Stretch
                rs.MoveNext()
            End While
        End If
    End Sub
 

    Private Sub ບນທກການເກດToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ບນທກການເກດToolStripMenuItem.Click
        'Frm_Birth_Data_List.MdiParent = Me
        'Frm_Birth_Data_List.WindowState = FormWindowState.Maximized
        'Frm_Birth_Data_List.ShowIcon = False
        'Frm_Birth_Data_List.Show()
        Frm_Level.Show()
    End Sub
 
     

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ພມບາໂຄດBarcodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ພມບາໂຄດBarcodeToolStripMenuItem.Click
        FrmPrint_Barcode.Show()
    End Sub

     
     

   

  

    
     

    Private Sub TeamViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeamViewerToolStripMenuItem.Click
        Process.Start("C:\Program Files (x86)\TeamViewer\Version8\TeamViewer.exe")
    End Sub

    Private Sub ກຳນດຄາບລການສກຢາກນພະຍາດToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_Case_patment.MdiParent = Me
        Frm_Case_patment.WindowState = FormWindowState.Maximized
        Frm_Case_patment.ShowIcon = False
        Frm_Case_patment.Show()
    End Sub

    Private Sub ກຳລງເຊອມຕກບຖານຂມນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ກຳລງເຊອມຕກບຖານຂມນToolStripMenuItem.Click
        Process.Start("Conection_To_Server.exe")
    End Sub

    Private Sub ToolStripMenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        FrmLogin.Show()
      
    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ການຕດຕາມກວດທອງToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ການຕດຕາມກວດທອງToolStripMenuItem.Click
        Frm_Class.Show()
    End Sub

    Private Sub ການປນປວຂແງແມToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ການປນປວຂແງແມToolStripMenuItem.Click
        Frm_Education.Show()
    End Sub

    Private Sub ຂມນການເກດແລະການກວດຫງເກດຂອງແມToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ຂມນການເກດແລະການກວດຫງເກດຂອງແມToolStripMenuItem.Click
        Frm_Type_In.Show()
    End Sub

    Private Sub ການວາງແຜນຄອບຄວToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ການວາງແຜນຄອບຄວToolStripMenuItem.Click
        Frm_Type_Out.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MDEdit = False
        Frm_CV.MdiParent = Me
        Frm_CV.WindowState = FormWindowState.Maximized
        Frm_CV.ShowIcon = False
        Frm_CV.Show()
    End Sub

    Private Sub ການກວດຫງການເກດToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ການກວດຫງການເກດToolStripMenuItem.Click
        MDEdit = False
        Frm_CV_List.MdiParent = Me
        Frm_CV_List.WindowState = FormWindowState.Maximized
        Frm_CV_List.ShowIcon = False
        Frm_CV_List.Show()
    End Sub

    Private Sub ສນຊາດToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ສນຊາດToolStripMenuItem.Click
        Countries.Show()
    End Sub

    Private Sub ເຊອຊາດToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ເຊອຊາດToolStripMenuItem.Click
        FrmNationall.Show()
    End Sub

    Private Sub ເຜາຊນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ເຜາຊນToolStripMenuItem.Click
        FrmAPListEthnic.Show()
    End Sub

    Private Sub ສາສະໜາToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ສາສະໜາToolStripMenuItem.Click
        frmreligoin.Show()
    End Sub

    Private Sub ຕນກຳເນດToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ຕນກຳເນດToolStripMenuItem.Click
        FrmRrunk.Show()
    End Sub

    Private Sub ດດສະນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ດດສະນToolStripMenuItem.Click
        Frm_Index.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Frm_Department.Show()
    End Sub

    Private Sub ຕຳແໜງພກToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ຕຳແໜງພກToolStripMenuItem.Click
        Frm_phuk.Show()
    End Sub

    Private Sub ຕຳແໜງລດToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ຕຳແໜງລດToolStripMenuItem.Click
        Frm_lut.Show()
    End Sub

    Private Sub ໜາທຮບຜດຊອບToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ໜາທຮບຜດຊອບToolStripMenuItem.Click
        Frm_job.Show()
    End Sub

    Private Sub ຕາຕະລາງອກອນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ຕາຕະລາງອກອນToolStripMenuItem.Click
        
        frmTax_Unit.MdiParent = Me
        frmTax_Unit.WindowState = FormWindowState.Maximized
        frmTax_Unit.ShowIcon = False
        frmTax_Unit.Show()
    End Sub

    Private Sub ລາຍການເລອນຊນແລະຂນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການເລອນຊນແລະຂນToolStripMenuItem.Click
        MDEdit = False
        Frm_Position_work.MdiParent = Me
        Frm_Position_work.WindowState = FormWindowState.Maximized
        Frm_Position_work.ShowIcon = False
        Frm_Position_work.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Frm_Type_up.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Frm_Type_donw.Show()
    End Sub

    Private Sub ລາຍການປບປງຊນຂນເງນເດອນຫດToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການປບປງຊນຂນເງນເດອນຫດToolStripMenuItem.Click
        MDEdit = False
        Frm_Organization.MdiParent = Me
        Frm_Organization.WindowState = FormWindowState.Maximized
        Frm_Organization.ShowIcon = False
        Frm_Organization.Show()
    End Sub

    Private Sub ລາຍການປບປງຊນຂນເງນເດອນເພມToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການປບປງຊນຂນເງນເດອນເພມToolStripMenuItem.Click
        Frm_UpLevel_List.MdiParent = Me
        Frm_UpLevel_List.WindowState = FormWindowState.Maximized
        Frm_UpLevel_List.ShowIcon = False
        Frm_UpLevel_List.Show()
    End Sub

    Private Sub ລາຍການປບປງຊນຂນເງນເດອນຫດToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການປບປງຊນຂນເງນເດອນຫດToolStripMenuItem1.Click
        Frm_DonwLevel_List.MdiParent = Me
        Frm_DonwLevel_List.WindowState = FormWindowState.Maximized
        Frm_DonwLevel_List.ShowIcon = False
        Frm_DonwLevel_List.Show()
    End Sub

    Private Sub ການສກສາວຊາສະເພາະToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ການສກສາວຊາສະເພາະToolStripMenuItem.Click
        MDEdit = False
        Frm_Persion_Education.MdiParent = Me
        Frm_Persion_Education.WindowState = FormWindowState.Maximized
        Frm_Persion_Education.ShowIcon = False
        Frm_Persion_Education.Show()
    End Sub

    Private Sub ຄອບຄວToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ຄອບຄວToolStripMenuItem.Click
        MDEdit = False
        Frm_Persion_Family.MdiParent = Me
        Frm_Persion_Family.WindowState = FormWindowState.Maximized
        Frm_Persion_Family.ShowIcon = False
        Frm_Persion_Family.Show()
    End Sub

    Private Sub ສກຂະພາບToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ສກຂະພາບToolStripMenuItem.Click
        MDEdit = False
        Frm_Persion_Health.MdiParent = Me
        Frm_Persion_Health.WindowState = FormWindowState.Maximized
        Frm_Persion_Health.ShowIcon = False
        Frm_Persion_Health.Show()
    End Sub

    Private Sub ToolStripMenuItem11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Frm_Salary_List.MdiParent = Me
        Frm_Salary_List.WindowState = FormWindowState.Maximized
        Frm_Salary_List.ShowIcon = False
        Frm_Salary_List.Show()
    End Sub

    Private Sub ລາຍການປບປງຊນຂນເງນເດອນເພມToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການປບປງຊນຂນເງນເດອນເພມToolStripMenuItem1.Click
        Frm_son_List.MdiParent = Me
        Frm_son_List.WindowState = FormWindowState.Maximized
        Frm_son_List.ShowIcon = False
        Frm_son_List.Show()
    End Sub

    Private Sub ລາຍການປບປງເງນອດໜນລກແລະເມຍToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການປບປງເງນອດໜນລກແລະເມຍToolStripMenuItem.Click
        Frm_Mom_List.MdiParent = Me
        Frm_Mom_List.WindowState = FormWindowState.Maximized
        Frm_Mom_List.ShowIcon = False
        Frm_Mom_List.Show()
    End Sub

    Private Sub ລາຍງານຂຳນວນພນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍງານຂຳນວນພນToolStripMenuItem.Click
        Frm_persion_Report.Show()
    End Sub

    Private Sub ລາຍງານຈຳນວນພນແລະຊນຂນເງນເດອນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍງານຈຳນວນພນແລະຊນຂນເງນເດອນToolStripMenuItem.Click
        Frm_Salary_donw_Report.Show()
    End Sub

    Private Sub ລາຍງານຈຳນວນພນແລະຊນຂນເງນເດອນToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍງານຈຳນວນພນແລະຊນຂນເງນເດອນToolStripMenuItem1.Click
        Frm_Salary_Up_Report.Show()
    End Sub

    Private Sub ToolStripMenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        Frm_Salary_in_month_List.MdiParent = Me
        Frm_Salary_in_month_List.WindowState = FormWindowState.Maximized
        Frm_Salary_in_month_List.ShowIcon = False
        Frm_Salary_in_month_List.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        Frm_Salary_Report.Show()
    End Sub

    Private Sub ToolStripMenuItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        Frm_persion_list_Report.Show()
    End Sub




    Private Sub ToolStripMenuItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        Frm_Study.Show()
    End Sub

    Private Sub ໂຄງຮາງການຈດຕງຂອງຫອງການກະຊວງToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ໂຄງຮາງການຈດຕງຂອງຫອງການກະຊວງToolStripMenuItem.Click
        Frm_Organization_Office.MdiParent = Me
        Frm_Organization_Office.WindowState = FormWindowState.Maximized
        Frm_Organization_Office.ShowIcon = False
        Frm_Organization_Office.Show()
    End Sub

    Private Sub ໂຄງຮາງການຈດຕງຂອງກມຈດຕງແລະພະນກງານToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ໂຄງຮາງການຈດຕງຂອງກມຈດຕງແລະພະນກງານToolStripMenuItem.Click
        Frm_DPO_Chart.MdiParent = Me
        Frm_DPO_Chart.WindowState = FormWindowState.Maximized
        Frm_DPO_Chart.ShowIcon = False
        Frm_DPO_Chart.Show()
    End Sub

    Private Sub ໂຄງຮາງການຈດຕງຂອງກມກວດກາToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ໂຄງຮາງການຈດຕງຂອງກມກວດກາToolStripMenuItem.Click
        Frm_DOI_Chart.MdiParent = Me
        Frm_DOI_Chart.WindowState = FormWindowState.Maximized
        Frm_DOI_Chart.ShowIcon = False
        Frm_DOI_Chart.Show()
    End Sub

    Private Sub ໂຄງຮາງການຈດຕງຂອງກມບແຮToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ໂຄງຮາງການຈດຕງຂອງກມບແຮToolStripMenuItem.Click
        Frm_DoM_Chart.MdiParent = Me
        Frm_DoM_Chart.WindowState = FormWindowState.Maximized
        Frm_DoM_Chart.ShowIcon = False
        Frm_DoM_Chart.Show()
    End Sub

    Private Sub ໂຄງຮາງການຈດຕງຂອງກມນະໂຍບາຍແລະແຜນພະລງງານToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ໂຄງຮາງການຈດຕງຂອງກມນະໂຍບາຍແລະແຜນພະລງງານToolStripMenuItem.Click
        Frm_DEPP_Chart.MdiParent = Me
        Frm_DEPP_Chart.WindowState = FormWindowState.Maximized
        Frm_DEPP_Chart.ShowIcon = False
        Frm_DEPP_Chart.Show()
    End Sub

    Private Sub ໂຄງຮາງການຈດຕງຂອງກມທລະກດພະລງງງານToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ໂຄງຮາງການຈດຕງຂອງກມທລະກດພະລງງງານToolStripMenuItem.Click
        Frm_DEB_Chart.MdiParent = Me
        Frm_DEB_Chart.WindowState = FormWindowState.Maximized
        Frm_DEB_Chart.ShowIcon = False
        Frm_DEB_Chart.Show()
    End Sub

    Private Sub ໂຄງຮາງການຈດຕງຂອງກມບລຫານພະລງງານToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ໂຄງຮາງການຈດຕງຂອງກມບລຫານພະລງງານToolStripMenuItem.Click
        Frm_DEM_Chart.MdiParent = Me
        Frm_DEM_Chart.WindowState = FormWindowState.Maximized
        Frm_DEM_Chart.ShowIcon = False
        Frm_DEM_Chart.Show()
    End Sub

    Private Sub ໂຄງຮາງການຈດຕງຂອງສະຖາບນສງເສມພະລງງານທດແທນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ໂຄງຮາງການຈດຕງຂອງສະຖາບນສງເສມພະລງງານທດແທນToolStripMenuItem.Click
        Frm_IREP_Chart.MdiParent = Me
        Frm_IREP_Chart.WindowState = FormWindowState.Maximized
        Frm_IREP_Chart.ShowIcon = False
        Frm_IREP_Chart.Show()
    End Sub

    Private Sub ຫກປະກນສງຄມToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ຫກປະກນສງຄມToolStripMenuItem.Click
        frmSSO.Show()
    End Sub

    Private Sub LaoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaoToolStripMenuItem.Click
        Lang = False

        Call Loadlang()
        Call SetControlText(Me)
        Call ChgChildForm()
        LaoToolStripMenuItem.Checked = True
        EToolStripMenuItem.Checked = False
    End Sub

    Private Sub EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EToolStripMenuItem.Click
        Lang = True

        Call Loadlang()
        Call SetControlText(Me)
        Call ChgChildForm()
        LaoToolStripMenuItem.Checked = False
        EToolStripMenuItem.Checked = True

    End Sub

    Private Sub ລາຍການພະນກງານອອກການToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການພະນກງານອອກການToolStripMenuItem.Click
        Frm_Employee_out_List.MdiParent = Me
        Frm_Employee_out_List.WindowState = FormWindowState.Maximized
        Frm_Employee_out_List.ShowIcon = False
        Frm_Employee_out_List.Show()
    End Sub

    Private Sub ລາຍການພະນກງານອອກການToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍການພະນກງານອອກການToolStripMenuItem1.Click
        Frm_Employee_Ticket_List.MdiParent = Me
        Frm_Employee_Ticket_List.WindowState = FormWindowState.Maximized
        Frm_Employee_Ticket_List.ShowIcon = False
        Frm_Employee_Ticket_List.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click

    End Sub

    Private Sub ຕງສດຄດໄລລະດບເງນເດອນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ຕງສດຄດໄລລະດບເງນເດອນToolStripMenuItem.Click
        Frm_Salary_group.MdiParent = Me
        Frm_Salary_group.WindowState = FormWindowState.Maximized
        Frm_Salary_group.ShowIcon = False
        Frm_Salary_group.Show()
    End Sub

    Private Sub ReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReToolStripMenuItem.Click
        frmAddditional_Deducation_List.MdiParent = Me
        frmAddditional_Deducation_List.WindowState = FormWindowState.Maximized
        frmAddditional_Deducation_List.ShowIcon = False
        frmAddditional_Deducation_List.Show()
    End Sub

    Private Sub ToolStripMenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        Frm_Salary_bank_Report.Show()
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        Frm_Employee_take_leave_List.MdiParent = Me
        Frm_Employee_take_leave_List.WindowState = FormWindowState.Maximized
        Frm_Employee_take_leave_List.ShowIcon = False
        Frm_Employee_take_leave_List.Show()
    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        Frm_Summary_Salary_Report.Show()
    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        Frm_Salary_tax_Report.Show()
    End Sub

    Private Sub ÌÀòÈöêöÀíºöññöToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÌÀòÈöêöÀíºöññöToolStripMenuItem.Click
        Frm_SSO_Report.Show()
    End Sub

    Private Sub ລາຍງານອາກອນລາຍໄດຈາກເງນເດອນຂອງພະນກງານກຳມະກອນToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ລາຍງານອາກອນລາຍໄດຈາກເງນເດອນຂອງພະນກງານກຳມະກອນToolStripMenuItem.Click
        Frm_Salary_in_tax_Report.Show()
    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem22.Click
        Frm_Salary_add_deduc_Report.MdiParent = Me
        Frm_Salary_add_deduc_Report.WindowState = FormWindowState.Maximized
        Frm_Salary_add_deduc_Report.ShowIcon = False
        Frm_Salary_add_deduc_Report.Show()
    End Sub
End Class
