<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
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
        Me.lblText_encrypt = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtHost_id = New System.Windows.Forms.RichTextBox
        Me.txtDepart_id = New System.Windows.Forms.RichTextBox
        Me.Cmb_Department = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.Blue
        Me.lblUserID.Location = New System.Drawing.Point(79, 45)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(83, 24)
        Me.lblUserID.TabIndex = 7
        Me.lblUserID.Text = "ລະຫັດຜູ້ໃຊ້:"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPWD
        '
        Me.lblPWD.AutoSize = True
        Me.lblPWD.BackColor = System.Drawing.Color.Transparent
        Me.lblPWD.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPWD.ForeColor = System.Drawing.Color.Red
        Me.lblPWD.Location = New System.Drawing.Point(79, 80)
        Me.lblPWD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPWD.Name = "lblPWD"
        Me.lblPWD.Size = New System.Drawing.Size(83, 24)
        Me.lblPWD.TabIndex = 8
        Me.lblPWD.Text = "ລະຫັດຜ່ານ:"
        Me.lblPWD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Blue
        Me.lblUsername.Location = New System.Drawing.Point(110, 119)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(52, 24)
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
        Me.btnOK.Location = New System.Drawing.Point(169, 183)
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
        Me.btnCancel.Location = New System.Drawing.Point(296, 183)
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
        Me.txtPassword.Location = New System.Drawing.Point(169, 74)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(264, 35)
        Me.txtPassword.TabIndex = 2
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(170, 36)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(264, 35)
        Me.txtUserID.TabIndex = 1
        '
        'lblUserNm
        '
        Me.lblUserNm.BackColor = System.Drawing.Color.Cyan
        Me.lblUserNm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblUserNm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserNm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUserNm.Location = New System.Drawing.Point(169, 112)
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
        Me.Label1.Location = New System.Drawing.Point(750, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 47)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ພະລັງງານ ແລະ ບໍ່ແຮ່"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
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
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(619, 354)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(79, 33)
        Me.Label28.TabIndex = 45546
        Me.Label28.Text = "ສະຖານທີ່:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label28.Visible = False
        '
        'txtHost_id
        '
        Me.txtHost_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHost_id.Location = New System.Drawing.Point(439, 112)
        Me.txtHost_id.Multiline = False
        Me.txtHost_id.Name = "txtHost_id"
        Me.txtHost_id.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtHost_id.Size = New System.Drawing.Size(51, 36)
        Me.txtHost_id.TabIndex = 45569
        Me.txtHost_id.Text = ""
        Me.txtHost_id.Visible = False
        '
        'txtDepart_id
        '
        Me.txtDepart_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDepart_id.Location = New System.Drawing.Point(439, 74)
        Me.txtDepart_id.Multiline = False
        Me.txtDepart_id.Name = "txtDepart_id"
        Me.txtDepart_id.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtDepart_id.Size = New System.Drawing.Size(51, 36)
        Me.txtDepart_id.TabIndex = 45547
        Me.txtDepart_id.Text = ""
        Me.txtDepart_id.Visible = False
        '
        'Cmb_Department
        '
        Me.Cmb_Department.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmb_Department.FormattingEnabled = True
        Me.Cmb_Department.Location = New System.Drawing.Point(169, 144)
        Me.Cmb_Department.Name = "Cmb_Department"
        Me.Cmb_Department.Size = New System.Drawing.Size(265, 32)
        Me.Cmb_Department.TabIndex = 45548
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(72, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 24)
        Me.Label4.TabIndex = 45570
        Me.Label4.Text = "ຊື່ ພາກສ່ວນ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(561, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 107
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(825, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 47)
        Me.Label5.TabIndex = 45571
        Me.Label5.Text = "ກະຊວງ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 294)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHost_id)
        Me.Controls.Add(Me.Cmb_Department)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtDepart_id)
        Me.Controls.Add(Me.Label2)
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
        Me.Controls.Add(Me.PictureBox2)
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
    Friend WithEvents lblText_encrypt As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtHost_id As System.Windows.Forms.RichTextBox
    Friend WithEvents txtDepart_id As System.Windows.Forms.RichTextBox
    Friend WithEvents Cmb_Department As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
