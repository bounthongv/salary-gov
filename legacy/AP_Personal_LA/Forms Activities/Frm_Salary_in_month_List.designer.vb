<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Salary_in_month_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Salary_in_month_List))
        Me.DT_Tran = New System.Windows.Forms.DateTimePicker
        Me.Fg1 = New AxVSFlex8U.AxVSFlexGrid
        Me.Label15 = New System.Windows.Forms.Label
        Me.RadioButton8 = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton9 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton10 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton11 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton12 = New System.Windows.Forms.RadioButton
        Me.RadioButton14 = New System.Windows.Forms.RadioButton
        Me.RadioButton13 = New System.Windows.Forms.RadioButton
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_Hder = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.chk_section = New System.Windows.Forms.CheckBox
        Me.chk_department = New System.Windows.Forms.CheckBox
        Me.txtSection_ID = New System.Windows.Forms.TextBox
        Me.txtdepart_ID = New System.Windows.Forms.TextBox
        Me.cmb_Department = New System.Windows.Forms.ComboBox
        Me.Cmb_Sections = New System.Windows.Forms.ComboBox
        Me.chk_Job_Phuk = New System.Windows.Forms.CheckBox
        Me.cmb_job_phuk = New System.Windows.Forms.ComboBox
        Me.txt_job_phuk_id = New System.Windows.Forms.TextBox
        Me.DT_Month = New System.Windows.Forms.DateTimePicker
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Btt_Edit = New System.Windows.Forms.Button
        Me.bttn_delete = New System.Windows.Forms.Button
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DT_Tran
        '
        Me.DT_Tran.CustomFormat = "MM/yyyy"
        Me.DT_Tran.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_Tran.Location = New System.Drawing.Point(225, 53)
        Me.DT_Tran.Name = "DT_Tran"
        Me.DT_Tran.ShowUpDown = True
        Me.DT_Tran.Size = New System.Drawing.Size(87, 35)
        Me.DT_Tran.TabIndex = 105
        '
        'Fg1
        '
        Me.Fg1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fg1.DataSource = Nothing
        Me.Fg1.Location = New System.Drawing.Point(6, 131)
        Me.Fg1.Name = "Fg1"
        Me.Fg1.OcxState = CType(resources.GetObject("Fg1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg1.Size = New System.Drawing.Size(1184, 531)
        Me.Fg1.TabIndex = 106
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Saysettha OT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(842, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(275, 38)
        Me.Label15.TabIndex = 311
        Me.Label15.Text = "ລາຍການຄິດໄລ່ເງີນເດືອນ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton8
        '
        Me.RadioButton8.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton8.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.ForeColor = System.Drawing.Color.Black
        Me.RadioButton8.Location = New System.Drawing.Point(418, 250)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(57, 37)
        Me.RadioButton8.TabIndex = 45594
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = " ສິງຫາ"
        Me.RadioButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton8.UseVisualStyleBackColor = False
        '
        'RadioButton7
        '
        Me.RadioButton7.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton7.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.ForeColor = System.Drawing.Color.Black
        Me.RadioButton7.Location = New System.Drawing.Point(361, 250)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(58, 37)
        Me.RadioButton7.TabIndex = 45593
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "ກໍລະກົດ"
        Me.RadioButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton7.UseVisualStyleBackColor = False
        '
        'RadioButton6
        '
        Me.RadioButton6.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton6.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.ForeColor = System.Drawing.Color.Black
        Me.RadioButton6.Location = New System.Drawing.Point(307, 250)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(55, 37)
        Me.RadioButton6.TabIndex = 45592
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = " ມີຖຸນາ"
        Me.RadioButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton5.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(242, 250)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(66, 37)
        Me.RadioButton5.TabIndex = 45591
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "ພຶດສະພາ"
        Me.RadioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'RadioButton9
        '
        Me.RadioButton9.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton9.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton9.ForeColor = System.Drawing.Color.Black
        Me.RadioButton9.Location = New System.Drawing.Point(475, 250)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(55, 37)
        Me.RadioButton9.TabIndex = 45595
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = " ກັນຍາ"
        Me.RadioButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton9.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton4.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(188, 250)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(55, 37)
        Me.RadioButton4.TabIndex = 45590
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = " ເມສາ"
        Me.RadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton3.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(134, 250)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(55, 37)
        Me.RadioButton3.TabIndex = 45589
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = " ມີນາ "
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton10
        '
        Me.RadioButton10.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton10.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton10.ForeColor = System.Drawing.Color.Black
        Me.RadioButton10.Location = New System.Drawing.Point(529, 250)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(55, 37)
        Me.RadioButton10.TabIndex = 45596
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = " ຕຸລາ"
        Me.RadioButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton10.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton2.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(80, 250)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(55, 37)
        Me.RadioButton2.TabIndex = 45588
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "ກຸມພາ"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton11
        '
        Me.RadioButton11.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton11.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton11.ForeColor = System.Drawing.Color.Black
        Me.RadioButton11.Location = New System.Drawing.Point(583, 250)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(55, 37)
        Me.RadioButton11.TabIndex = 45598
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "ພະຈິກ"
        Me.RadioButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton11.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton1.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(24, 250)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 37)
        Me.RadioButton1.TabIndex = 45587
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ມັງກອນ"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton12
        '
        Me.RadioButton12.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton12.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton12.ForeColor = System.Drawing.Color.Black
        Me.RadioButton12.Location = New System.Drawing.Point(637, 250)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(63, 37)
        Me.RadioButton12.TabIndex = 45597
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = " ທັນວາ"
        Me.RadioButton12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton12.UseVisualStyleBackColor = False
        '
        'RadioButton14
        '
        Me.RadioButton14.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton14.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton14.ForeColor = System.Drawing.Color.Black
        Me.RadioButton14.Location = New System.Drawing.Point(753, 250)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(63, 37)
        Me.RadioButton14.TabIndex = 45600
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Text = "ແຕ່ວັນທີ"
        Me.RadioButton14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton14.UseVisualStyleBackColor = False
        '
        'RadioButton13
        '
        Me.RadioButton13.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton13.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton13.ForeColor = System.Drawing.Color.Black
        Me.RadioButton13.Location = New System.Drawing.Point(699, 250)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(55, 37)
        Me.RadioButton13.TabIndex = 45599
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "ໝົດປີ"
        Me.RadioButton13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton13.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"ທັງໝົດ", "ຜູ້ສະໜອງພາຍໃນພາຍໃນ", "ຜູ້ສະໜອງຕ່າງປະເທດ"})
        Me.ComboBox2.Location = New System.Drawing.Point(657, 171)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(242, 32)
        Me.ComboBox2.TabIndex = 45630
        Me.ComboBox2.Visible = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(518, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 37)
        Me.Label12.TabIndex = 45631
        Me.Label12.Text = "ຜູ້ສະໜອງ:"
        Me.Label12.Visible = False
        '
        'txt_Hder
        '
        Me.txt_Hder.Location = New System.Drawing.Point(895, -20)
        Me.txt_Hder.Name = "txt_Hder"
        Me.txt_Hder.Size = New System.Drawing.Size(259, 35)
        Me.txt_Hder.TabIndex = 45632
        Me.txt_Hder.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(1162, -20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(129, 35)
        Me.DateTimePicker1.TabIndex = 45633
        Me.DateTimePicker1.Value = New Date(2009, 12, 29, 0, 0, 0, 0)
        Me.DateTimePicker1.Visible = False
        '
        'chk_section
        '
        Me.chk_section.AutoSize = True
        Me.chk_section.Location = New System.Drawing.Point(210, 53)
        Me.chk_section.Name = "chk_section"
        Me.chk_section.Size = New System.Drawing.Size(124, 28)
        Me.chk_section.TabIndex = 45799
        Me.chk_section.Text = "ບ່ອນປະຈຳການ"
        Me.chk_section.UseVisualStyleBackColor = True
        '
        'chk_department
        '
        Me.chk_department.AutoSize = True
        Me.chk_department.Location = New System.Drawing.Point(650, 50)
        Me.chk_department.Name = "chk_department"
        Me.chk_department.Size = New System.Drawing.Size(78, 28)
        Me.chk_department.TabIndex = 45800
        Me.chk_department.Text = "ພະແນກ"
        Me.chk_department.UseVisualStyleBackColor = True
        '
        'txtSection_ID
        '
        Me.txtSection_ID.Location = New System.Drawing.Point(475, 209)
        Me.txtSection_ID.Name = "txtSection_ID"
        Me.txtSection_ID.Size = New System.Drawing.Size(43, 35)
        Me.txtSection_ID.TabIndex = 45804
        Me.txtSection_ID.Visible = False
        '
        'txtdepart_ID
        '
        Me.txtdepart_ID.Location = New System.Drawing.Point(1266, 45)
        Me.txtdepart_ID.Name = "txtdepart_ID"
        Me.txtdepart_ID.Size = New System.Drawing.Size(46, 35)
        Me.txtdepart_ID.TabIndex = 45803
        Me.txtdepart_ID.Visible = False
        '
        'cmb_Department
        '
        Me.cmb_Department.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_Department.FormattingEnabled = True
        Me.cmb_Department.Location = New System.Drawing.Point(734, 46)
        Me.cmb_Department.Name = "cmb_Department"
        Me.cmb_Department.Size = New System.Drawing.Size(244, 32)
        Me.cmb_Department.TabIndex = 45802
        '
        'Cmb_Sections
        '
        Me.Cmb_Sections.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.Cmb_Sections.FormattingEnabled = True
        Me.Cmb_Sections.Location = New System.Drawing.Point(340, 48)
        Me.Cmb_Sections.Name = "Cmb_Sections"
        Me.Cmb_Sections.Size = New System.Drawing.Size(298, 32)
        Me.Cmb_Sections.TabIndex = 45801
        '
        'chk_Job_Phuk
        '
        Me.chk_Job_Phuk.AutoSize = True
        Me.chk_Job_Phuk.Location = New System.Drawing.Point(212, 87)
        Me.chk_Job_Phuk.Name = "chk_Job_Phuk"
        Me.chk_Job_Phuk.Size = New System.Drawing.Size(100, 28)
        Me.chk_Job_Phuk.TabIndex = 45807
        Me.chk_Job_Phuk.Text = "ຕຳແໜ່ງພັກ"
        Me.chk_Job_Phuk.UseVisualStyleBackColor = True
        '
        'cmb_job_phuk
        '
        Me.cmb_job_phuk.BackColor = System.Drawing.Color.White
        Me.cmb_job_phuk.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_phuk.FormattingEnabled = True
        Me.cmb_job_phuk.Location = New System.Drawing.Point(340, 83)
        Me.cmb_job_phuk.Name = "cmb_job_phuk"
        Me.cmb_job_phuk.Size = New System.Drawing.Size(299, 32)
        Me.cmb_job_phuk.TabIndex = 45805
        '
        'txt_job_phuk_id
        '
        Me.txt_job_phuk_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_job_phuk_id.Enabled = False
        Me.txt_job_phuk_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job_phuk_id.Location = New System.Drawing.Point(576, 238)
        Me.txt_job_phuk_id.Name = "txt_job_phuk_id"
        Me.txt_job_phuk_id.Size = New System.Drawing.Size(40, 27)
        Me.txt_job_phuk_id.TabIndex = 45809
        Me.txt_job_phuk_id.Visible = False
        '
        'DT_Month
        '
        Me.DT_Month.CalendarFont = New System.Drawing.Font("Saysettha OT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_Month.CustomFormat = "MM/yyyy"
        Me.DT_Month.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_Month.Location = New System.Drawing.Point(115, 52)
        Me.DT_Month.Name = "DT_Month"
        Me.DT_Month.ShowUpDown = True
        Me.DT_Month.Size = New System.Drawing.Size(84, 35)
        Me.DT_Month.TabIndex = 45812
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button8.Location = New System.Drawing.Point(12, 9)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(42, 34)
        Me.Button8.TabIndex = 45836
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.APInvioce.My.Resources.Resources.MoveToTable
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(12, 55)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 35)
        Me.Button4.TabIndex = 45835
        Me.Button4.Text = "OK"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Btt_Edit
        '
        Me.Btt_Edit.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btt_Edit.Image = Global.APInvioce.My.Resources.Resources.Edit
        Me.Btt_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btt_Edit.Location = New System.Drawing.Point(340, 440)
        Me.Btt_Edit.Name = "Btt_Edit"
        Me.Btt_Edit.Size = New System.Drawing.Size(110, 32)
        Me.Btt_Edit.TabIndex = 45810
        Me.Btt_Edit.Text = "ແກ້ໄຂ"
        Me.Btt_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btt_Edit.UseVisualStyleBackColor = True
        Me.Btt_Edit.Visible = False
        '
        'bttn_delete
        '
        Me.bttn_delete.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn_delete.ForeColor = System.Drawing.Color.Black
        Me.bttn_delete.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.bttn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttn_delete.Location = New System.Drawing.Point(451, 440)
        Me.bttn_delete.Name = "bttn_delete"
        Me.bttn_delete.Size = New System.Drawing.Size(112, 32)
        Me.bttn_delete.TabIndex = 45811
        Me.bttn_delete.Text = "ລືບ"
        Me.bttn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttn_delete.UseVisualStyleBackColor = True
        Me.bttn_delete.Visible = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.APInvioce.My.Resources.Resources.Edit
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(159, 1)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(110, 47)
        Me.BtnEdit.TabIndex = 110
        Me.BtnEdit.Text = "ແກ້ໄຂ"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(649, 79)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(83, 38)
        Me.Button9.TabIndex = 45627
        Me.Button9.Text = "ຄົ້ນຫາ"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.APInvioce.My.Resources.Resources.preview_f2
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(530, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 46)
        Me.Button3.TabIndex = 113
        Me.Button3.Text = "ເບີ່ງ/Preview "
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.APInvioce.My.Resources.Resources.Refresh
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(385, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 47)
        Me.Button2.TabIndex = 112
        Me.Button2.Text = "ພະນັກງານທັງໝົດ"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Enabled = False
        Me.BtnDel.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.Black
        Me.BtnDel.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.BtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDel.Location = New System.Drawing.Point(270, 1)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(112, 47)
        Me.BtnDel.TabIndex = 111
        Me.BtnDel.Text = "ລືບລາຍການ"
        Me.BtnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Image = Global.APInvioce.My.Resources.Resources.Chgangetab1le
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(47, 1)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(110, 47)
        Me.BtnAddNew.TabIndex = 109
        Me.BtnAddNew.Text = "ຄິດໄລ່"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button1.Location = New System.Drawing.Point(6, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 46)
        Me.Button1.TabIndex = 108
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(681, 250)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 34)
        Me.Button5.TabIndex = 294
        Me.Button5.Text = "ສັ່ງຊື້ລົດ"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.DT_Tran)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(159, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 164)
        Me.Panel1.TabIndex = 45814
        Me.Panel1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "ຄິດໄລ່ປະຈຳເດືອນ"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 96)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 28)
        Me.CheckBox1.TabIndex = 45816
        Me.CheckBox1.Text = "ປະຈຳເດືອນ"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(81, 110)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 47)
        Me.Button6.TabIndex = 45815
        Me.Button6.Text = "ລືບໝົດເດືອນ"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(87, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 35)
        Me.Label3.TabIndex = 312
        Me.Label3.Text = "ຄິດໄລ່ເງີນເດືອນ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 45817
        Me.Label2.Text = "ປະຈຳເດືອນ"
        '
        'Frm_Salary_in_month_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1189, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DT_Month)
        Me.Controls.Add(Me.Btt_Edit)
        Me.Controls.Add(Me.bttn_delete)
        Me.Controls.Add(Me.txt_job_phuk_id)
        Me.Controls.Add(Me.chk_Job_Phuk)
        Me.Controls.Add(Me.cmb_job_phuk)
        Me.Controls.Add(Me.txtSection_ID)
        Me.Controls.Add(Me.txtdepart_ID)
        Me.Controls.Add(Me.cmb_Department)
        Me.Controls.Add(Me.Cmb_Sections)
        Me.Controls.Add(Me.chk_department)
        Me.Controls.Add(Me.chk_section)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.Fg1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txt_Hder)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.RadioButton8)
        Me.Controls.Add(Me.RadioButton7)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton9)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton10)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton11)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton12)
        Me.Controls.Add(Me.RadioButton14)
        Me.Controls.Add(Me.RadioButton13)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Salary_in_month_List"
        Me.Text = "Receipe Supplier list"
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_Tran As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fg1 As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton14 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton13 As System.Windows.Forms.RadioButton
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Hder As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_section As System.Windows.Forms.CheckBox
    Friend WithEvents chk_department As System.Windows.Forms.CheckBox
    Friend WithEvents txtSection_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtdepart_ID As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Department As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_Sections As System.Windows.Forms.ComboBox
    Friend WithEvents chk_Job_Phuk As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_job_phuk As System.Windows.Forms.ComboBox
    Friend WithEvents txt_job_phuk_id As System.Windows.Forms.TextBox
    Friend WithEvents Btt_Edit As System.Windows.Forms.Button
    Friend WithEvents bttn_delete As System.Windows.Forms.Button
    Friend WithEvents DT_Month As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
