<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin_Sata
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin_Sata))
        Me.lblUserID = New System.Windows.Forms.Label
        Me.lblPWD = New System.Windows.Forms.Label
        Me.lblUsername = New System.Windows.Forms.Label
        Me.lblDept = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.lblUserNm = New System.Windows.Forms.Label
        Me.lblDPM = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDecrypt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtPV_NM = New System.Windows.Forms.ComboBox
        Me.txtProvince = New System.Windows.Forms.RichTextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txt_Bk_ID = New System.Windows.Forms.RichTextBox
        Me.txt_Bk_nm = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Cmb_HSV = New System.Windows.Forms.ComboBox
        Me.cmbDist = New System.Windows.Forms.ComboBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.txtDis_id = New System.Windows.Forms.RichTextBox
        Me.txtHSV_id = New System.Windows.Forms.RichTextBox
        Me.txtHost_id = New System.Windows.Forms.RichTextBox
        Me.lblText_encrypt = New System.Windows.Forms.Label
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserID
        '
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.Blue
        Me.lblUserID.Location = New System.Drawing.Point(-48, 86)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(140, 29)
        Me.lblUserID.TabIndex = 7
        Me.lblUserID.Text = "ລະຫັດຜູ້ໃຊ້:"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPWD
        '
        Me.lblPWD.BackColor = System.Drawing.Color.Transparent
        Me.lblPWD.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPWD.ForeColor = System.Drawing.Color.Red
        Me.lblPWD.Location = New System.Drawing.Point(-20, 121)
        Me.lblPWD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPWD.Name = "lblPWD"
        Me.lblPWD.Size = New System.Drawing.Size(110, 29)
        Me.lblPWD.TabIndex = 8
        Me.lblPWD.Text = "ລະຫັດຜ່ານ:"
        Me.lblPWD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Blue
        Me.lblUsername.Location = New System.Drawing.Point(23, 161)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(67, 29)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "ຊື່ຜູ້ໃຊ້:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDept
        '
        Me.lblDept.ForeColor = System.Drawing.Color.Black
        Me.lblDept.Location = New System.Drawing.Point(527, 403)
        Me.lblDept.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(110, 29)
        Me.lblDept.TabIndex = 10
        Me.lblDept.Text = "&Department:"
        Me.lblDept.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnOK
        '
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Blue
        Me.btnOK.Location = New System.Drawing.Point(116, 332)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(127, 37)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "Login"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(243, 332)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(139, 37)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Red
        Me.txtPassword.Location = New System.Drawing.Point(121, 120)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(264, 35)
        Me.txtPassword.TabIndex = 2
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(122, 82)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(264, 35)
        Me.txtUserID.TabIndex = 1
        '
        'lblUserNm
        '
        Me.lblUserNm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserNm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblUserNm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserNm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUserNm.Location = New System.Drawing.Point(121, 158)
        Me.lblUserNm.Name = "lblUserNm"
        Me.lblUserNm.Size = New System.Drawing.Size(264, 28)
        Me.lblUserNm.TabIndex = 11
        '
        'lblDPM
        '
        Me.lblDPM.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDPM.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDPM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDPM.Location = New System.Drawing.Point(642, 403)
        Me.lblDPM.Name = "lblDPM"
        Me.lblDPM.Size = New System.Drawing.Size(210, 28)
        Me.lblDPM.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-160, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 61)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Label3"
        '
        'txtDecrypt
        '
        Me.txtDecrypt.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecrypt.ForeColor = System.Drawing.Color.Red
        Me.txtDecrypt.Location = New System.Drawing.Point(623, 160)
        Me.txtDecrypt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDecrypt.Name = "txtDecrypt"
        Me.txtDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDecrypt.Size = New System.Drawing.Size(42, 35)
        Me.txtDecrypt.TabIndex = 2
        Me.txtDecrypt.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(71, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 64)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ກະຊວງພະລັງງານ ແລະ ບໍ່ແຮ່"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(580, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 29)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "28/08/2013"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'TxtPV_NM
        '
        Me.TxtPV_NM.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtPV_NM.FormattingEnabled = True
        Me.TxtPV_NM.Location = New System.Drawing.Point(122, 227)
        Me.TxtPV_NM.Name = "TxtPV_NM"
        Me.TxtPV_NM.Size = New System.Drawing.Size(263, 32)
        Me.TxtPV_NM.TabIndex = 45551
        '
        'txtProvince
        '
        Me.txtProvince.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(392, 228)
        Me.txtProvince.Multiline = False
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtProvince.Size = New System.Drawing.Size(51, 31)
        Me.txtProvince.TabIndex = 45550
        Me.txtProvince.Text = ""
        Me.txtProvince.Visible = False
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(174, 423)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(79, 33)
        Me.Label28.TabIndex = 45546
        Me.Label28.Text = "ສະຖານທີ່:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label28.Visible = False
        '
        'txt_Bk_ID
        '
        Me.txt_Bk_ID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Bk_ID.Location = New System.Drawing.Point(392, 188)
        Me.txt_Bk_ID.Multiline = False
        Me.txt_Bk_ID.Name = "txt_Bk_ID"
        Me.txt_Bk_ID.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txt_Bk_ID.Size = New System.Drawing.Size(51, 36)
        Me.txt_Bk_ID.TabIndex = 45547
        Me.txt_Bk_ID.Text = ""
        Me.txt_Bk_ID.Visible = False
        '
        'txt_Bk_nm
        '
        Me.txt_Bk_nm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Bk_nm.FormattingEnabled = True
        Me.txt_Bk_nm.Location = New System.Drawing.Point(121, 192)
        Me.txt_Bk_nm.Name = "txt_Bk_nm"
        Me.txt_Bk_nm.Size = New System.Drawing.Size(265, 32)
        Me.txt_Bk_nm.TabIndex = 45548
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox1.Location = New System.Drawing.Point(12, 262)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 28)
        Me.CheckBox1.TabIndex = 45552
        Me.CheckBox1.Text = "ໂຮງໝໍເມືອງ"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Cmb_HSV
        '
        Me.Cmb_HSV.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmb_HSV.FormattingEnabled = True
        Me.Cmb_HSV.Location = New System.Drawing.Point(121, 296)
        Me.Cmb_HSV.Name = "Cmb_HSV"
        Me.Cmb_HSV.Size = New System.Drawing.Size(265, 32)
        Me.Cmb_HSV.TabIndex = 45563
        '
        'cmbDist
        '
        Me.cmbDist.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbDist.FormattingEnabled = True
        Me.cmbDist.Location = New System.Drawing.Point(122, 262)
        Me.cmbDist.Name = "cmbDist"
        Me.cmbDist.Size = New System.Drawing.Size(263, 32)
        Me.cmbDist.TabIndex = 45562
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox2.Location = New System.Drawing.Point(12, 296)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(85, 28)
        Me.CheckBox2.TabIndex = 45564
        Me.CheckBox2.Text = "ສຸກສາລາ"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Blue
        Me.RadioButton1.Location = New System.Drawing.Point(12, 193)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 28)
        Me.RadioButton1.TabIndex = 45565
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ໂຮງໝໍ"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Blue
        Me.RadioButton2.Location = New System.Drawing.Point(12, 228)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(108, 28)
        Me.RadioButton2.TabIndex = 45566
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "ໂຮງໝໍແຂວງ"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.APInvioce.My.Resources.Resources.ดาวน์โหลด
        Me.PictureBox2.Location = New System.Drawing.Point(657, 262)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 74)
        Me.PictureBox2.TabIndex = 107
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'txtDis_id
        '
        Me.txtDis_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDis_id.Location = New System.Drawing.Point(392, 265)
        Me.txtDis_id.Multiline = False
        Me.txtDis_id.Name = "txtDis_id"
        Me.txtDis_id.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtDis_id.Size = New System.Drawing.Size(51, 31)
        Me.txtDis_id.TabIndex = 45567
        Me.txtDis_id.Text = ""
        Me.txtDis_id.Visible = False
        '
        'txtHSV_id
        '
        Me.txtHSV_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHSV_id.Location = New System.Drawing.Point(392, 302)
        Me.txtHSV_id.Multiline = False
        Me.txtHSV_id.Name = "txtHSV_id"
        Me.txtHSV_id.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtHSV_id.Size = New System.Drawing.Size(51, 31)
        Me.txtHSV_id.TabIndex = 45568
        Me.txtHSV_id.Text = ""
        Me.txtHSV_id.Visible = False
        '
        'txtHost_id
        '
        Me.txtHost_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHost_id.Location = New System.Drawing.Point(392, 146)
        Me.txtHost_id.Multiline = False
        Me.txtHost_id.Name = "txtHost_id"
        Me.txtHost_id.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtHost_id.Size = New System.Drawing.Size(51, 36)
        Me.txtHost_id.TabIndex = 45569
        Me.txtHost_id.Text = ""
        Me.txtHost_id.Visible = False
        '
        'lblText_encrypt
        '
        Me.lblText_encrypt.AutoSize = True
        Me.lblText_encrypt.Location = New System.Drawing.Point(634, 238)
        Me.lblText_encrypt.Name = "lblText_encrypt"
        Me.lblText_encrypt.Size = New System.Drawing.Size(108, 24)
        Me.lblText_encrypt.TabIndex = 104
        Me.lblText_encrypt.Text = "SoUkSaVhAy"
        Me.lblText_encrypt.Visible = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 402)
        Me.Controls.Add(Me.txtHost_id)
        Me.Controls.Add(Me.txtHSV_id)
        Me.Controls.Add(Me.txtDis_id)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Cmb_HSV)
        Me.Controls.Add(Me.cmbDist)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtPV_NM)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.txt_Bk_nm)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txt_Bk_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblDPM)
        Me.Controls.Add(Me.lblUserNm)
        Me.Controls.Add(Me.lblText_encrypt)
        Me.Controls.Add(Me.txtDecrypt)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.lblPWD)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblPWD As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserNm As System.Windows.Forms.Label
    Friend WithEvents lblDPM As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtPV_NM As System.Windows.Forms.ComboBox
    Friend WithEvents txtProvince As System.Windows.Forms.RichTextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_Bk_ID As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_Bk_nm As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_HSV As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDist As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtDis_id As System.Windows.Forms.RichTextBox
    Friend WithEvents txtHSV_id As System.Windows.Forms.RichTextBox
    Friend WithEvents txtHost_id As System.Windows.Forms.RichTextBox
    Friend WithEvents lblText_encrypt As System.Windows.Forms.Label
End Class
