<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_persion_list_Report
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
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtFdate = New System.Windows.Forms.DateTimePicker
        Me.txtTdate = New System.Windows.Forms.DateTimePicker
        Me.DT_year_phuk = New System.Windows.Forms.DateTimePicker
        Me.DT__study_finish = New System.Windows.Forms.DateTimePicker
        Me.chk_Job_Phuk = New System.Windows.Forms.CheckBox
        Me.cmb_job_phuk = New System.Windows.Forms.ComboBox
        Me.cmb_Department = New System.Windows.Forms.ComboBox
        Me.Cmb_Sections = New System.Windows.Forms.ComboBox
        Me.chk_department = New System.Windows.Forms.CheckBox
        Me.chk_section = New System.Windows.Forms.CheckBox
        Me.txtSection_ID = New System.Windows.Forms.TextBox
        Me.txtdepart_ID = New System.Windows.Forms.TextBox
        Me.txt_job_phuk_id = New System.Windows.Forms.TextBox
        Me.cmblevel = New System.Windows.Forms.ComboBox
        Me.cmbclass = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtV_C = New System.Windows.Forms.TextBox
        Me.chk_clss_vel = New System.Windows.Forms.CheckBox
        Me.chk_job_lut = New System.Windows.Forms.CheckBox
        Me.cmb_job_lut = New System.Windows.Forms.ComboBox
        Me.txt_job_lut_id = New System.Windows.Forms.TextBox
        Me.cmb_percen = New System.Windows.Forms.ComboBox
        Me.chk_percen = New System.Windows.Forms.CheckBox
        Me.chk_start = New System.Windows.Forms.CheckBox
        Me.chk_DOB = New System.Windows.Forms.CheckBox
        Me.DT_DOB = New System.Windows.Forms.DateTimePicker
        Me.chk_study_finish = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmb_visa = New System.Windows.Forms.ComboBox
        Me.chk_Nation = New System.Windows.Forms.CheckBox
        Me.chk_visa = New System.Windows.Forms.CheckBox
        Me.chk_study = New System.Windows.Forms.CheckBox
        Me.txtlang_id = New System.Windows.Forms.TextBox
        Me.txtstudy_id = New System.Windows.Forms.TextBox
        Me.cmb_lang = New System.Windows.Forms.ComboBox
        Me.chk_lang = New System.Windows.Forms.CheckBox
        Me.txt_Nation_id = New System.Windows.Forms.TextBox
        Me.cmb_study = New System.Windows.Forms.ComboBox
        Me.txtvisa_id = New System.Windows.Forms.TextBox
        Me.cmb_Nation = New System.Windows.Forms.ComboBox
        Me.chk_year_phuk = New System.Windows.Forms.CheckBox
        Me.chk_phuksumhong = New System.Windows.Forms.CheckBox
        Me.DT_year_phuksumhong = New System.Windows.Forms.DateTimePicker
        Me.chk_lut = New System.Windows.Forms.CheckBox
        Me.DT_year_lut = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Saysettha OT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(188, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(296, 38)
        Me.Label15.TabIndex = 312
        Me.Label15.Text = "ລາຍງານຈຳນວນພະນັກງານ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 24)
        Me.Label2.TabIndex = 45842
        Me.Label2.Text = "ເຖິງ:"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.APInvioce.My.Resources.Resources.preview_f2
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(47, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 46)
        Me.Button3.TabIndex = 45841
        Me.Button3.Text = "ເບີ່ງ/Preview "
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button2.Location = New System.Drawing.Point(-1, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 46)
        Me.Button2.TabIndex = 45840
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtFdate
        '
        Me.txtFdate.CustomFormat = "dd/MM/yyyy"
        Me.txtFdate.Enabled = False
        Me.txtFdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFdate.Location = New System.Drawing.Point(184, 56)
        Me.txtFdate.Name = "txtFdate"
        Me.txtFdate.ShowUpDown = True
        Me.txtFdate.Size = New System.Drawing.Size(105, 35)
        Me.txtFdate.TabIndex = 45847
        '
        'txtTdate
        '
        Me.txtTdate.CustomFormat = "dd/MM/yyyy"
        Me.txtTdate.Enabled = False
        Me.txtTdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTdate.Location = New System.Drawing.Point(335, 56)
        Me.txtTdate.Name = "txtTdate"
        Me.txtTdate.ShowUpDown = True
        Me.txtTdate.Size = New System.Drawing.Size(104, 35)
        Me.txtTdate.TabIndex = 45846
        '
        'DT_year_phuk
        '
        Me.DT_year_phuk.CustomFormat = "yyyy"
        Me.DT_year_phuk.Enabled = False
        Me.DT_year_phuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_year_phuk.Location = New System.Drawing.Point(617, 97)
        Me.DT_year_phuk.Name = "DT_year_phuk"
        Me.DT_year_phuk.ShowUpDown = True
        Me.DT_year_phuk.Size = New System.Drawing.Size(74, 35)
        Me.DT_year_phuk.TabIndex = 45848
        '
        'DT__study_finish
        '
        Me.DT__study_finish.CustomFormat = "yyyy"
        Me.DT__study_finish.Enabled = False
        Me.DT__study_finish.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT__study_finish.Location = New System.Drawing.Point(150, 29)
        Me.DT__study_finish.Name = "DT__study_finish"
        Me.DT__study_finish.ShowUpDown = True
        Me.DT__study_finish.Size = New System.Drawing.Size(80, 35)
        Me.DT__study_finish.TabIndex = 45849
        '
        'chk_Job_Phuk
        '
        Me.chk_Job_Phuk.AutoSize = True
        Me.chk_Job_Phuk.Location = New System.Drawing.Point(50, 238)
        Me.chk_Job_Phuk.Name = "chk_Job_Phuk"
        Me.chk_Job_Phuk.Size = New System.Drawing.Size(100, 28)
        Me.chk_Job_Phuk.TabIndex = 45855
        Me.chk_Job_Phuk.Text = "ຕຳແໜ່ງພັກ"
        Me.chk_Job_Phuk.UseVisualStyleBackColor = True
        '
        'cmb_job_phuk
        '
        Me.cmb_job_phuk.BackColor = System.Drawing.Color.White
        Me.cmb_job_phuk.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_phuk.FormattingEnabled = True
        Me.cmb_job_phuk.Location = New System.Drawing.Point(211, 234)
        Me.cmb_job_phuk.Name = "cmb_job_phuk"
        Me.cmb_job_phuk.Size = New System.Drawing.Size(200, 32)
        Me.cmb_job_phuk.TabIndex = 45854
        '
        'cmb_Department
        '
        Me.cmb_Department.BackColor = System.Drawing.Color.White
        Me.cmb_Department.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_Department.FormattingEnabled = True
        Me.cmb_Department.Location = New System.Drawing.Point(210, 200)
        Me.cmb_Department.Name = "cmb_Department"
        Me.cmb_Department.Size = New System.Drawing.Size(201, 32)
        Me.cmb_Department.TabIndex = 45853
        '
        'Cmb_Sections
        '
        Me.Cmb_Sections.BackColor = System.Drawing.Color.White
        Me.Cmb_Sections.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.Cmb_Sections.FormattingEnabled = True
        Me.Cmb_Sections.Location = New System.Drawing.Point(210, 166)
        Me.Cmb_Sections.Name = "Cmb_Sections"
        Me.Cmb_Sections.Size = New System.Drawing.Size(201, 32)
        Me.Cmb_Sections.TabIndex = 45852
        '
        'chk_department
        '
        Me.chk_department.AutoSize = True
        Me.chk_department.Location = New System.Drawing.Point(50, 204)
        Me.chk_department.Name = "chk_department"
        Me.chk_department.Size = New System.Drawing.Size(78, 28)
        Me.chk_department.TabIndex = 45851
        Me.chk_department.Text = "ພະແນກ"
        Me.chk_department.UseVisualStyleBackColor = True
        '
        'chk_section
        '
        Me.chk_section.AutoSize = True
        Me.chk_section.Location = New System.Drawing.Point(50, 170)
        Me.chk_section.Name = "chk_section"
        Me.chk_section.Size = New System.Drawing.Size(124, 28)
        Me.chk_section.TabIndex = 45850
        Me.chk_section.Text = "ບ່ອນປະຈຳການ"
        Me.chk_section.UseVisualStyleBackColor = True
        '
        'txtSection_ID
        '
        Me.txtSection_ID.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection_ID.Location = New System.Drawing.Point(1, 182)
        Me.txtSection_ID.Name = "txtSection_ID"
        Me.txtSection_ID.Size = New System.Drawing.Size(31, 30)
        Me.txtSection_ID.TabIndex = 45856
        Me.txtSection_ID.Visible = False
        '
        'txtdepart_ID
        '
        Me.txtdepart_ID.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepart_ID.Location = New System.Drawing.Point(2, 214)
        Me.txtdepart_ID.Name = "txtdepart_ID"
        Me.txtdepart_ID.Size = New System.Drawing.Size(31, 30)
        Me.txtdepart_ID.TabIndex = 45857
        Me.txtdepart_ID.Visible = False
        '
        'txt_job_phuk_id
        '
        Me.txt_job_phuk_id.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job_phuk_id.Location = New System.Drawing.Point(3, 247)
        Me.txt_job_phuk_id.Name = "txt_job_phuk_id"
        Me.txt_job_phuk_id.Size = New System.Drawing.Size(31, 30)
        Me.txt_job_phuk_id.TabIndex = 45858
        Me.txt_job_phuk_id.Visible = False
        '
        'cmblevel
        '
        Me.cmblevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblevel.Enabled = False
        Me.cmblevel.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblevel.ForeColor = System.Drawing.Color.Black
        Me.cmblevel.FormattingEnabled = True
        Me.cmblevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cmblevel.Location = New System.Drawing.Point(270, 131)
        Me.cmblevel.Name = "cmblevel"
        Me.cmblevel.Size = New System.Drawing.Size(45, 32)
        Me.cmblevel.TabIndex = 45859
        '
        'cmbclass
        '
        Me.cmbclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbclass.Enabled = False
        Me.cmbclass.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbclass.ForeColor = System.Drawing.Color.Black
        Me.cmbclass.FormattingEnabled = True
        Me.cmbclass.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbclass.Location = New System.Drawing.Point(210, 132)
        Me.cmbclass.Name = "cmbclass"
        Me.cmbclass.Size = New System.Drawing.Size(43, 32)
        Me.cmbclass.TabIndex = 45860
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(251, 137)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 24)
        Me.Label10.TabIndex = 45862
        Me.Label10.Text = "/"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtV_C
        '
        Me.txtV_C.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtV_C.Location = New System.Drawing.Point(321, 130)
        Me.txtV_C.Name = "txtV_C"
        Me.txtV_C.Size = New System.Drawing.Size(56, 35)
        Me.txtV_C.TabIndex = 45863
        Me.txtV_C.Visible = False
        '
        'chk_clss_vel
        '
        Me.chk_clss_vel.AutoSize = True
        Me.chk_clss_vel.Location = New System.Drawing.Point(51, 135)
        Me.chk_clss_vel.Name = "chk_clss_vel"
        Me.chk_clss_vel.Size = New System.Drawing.Size(73, 28)
        Me.chk_clss_vel.TabIndex = 45864
        Me.chk_clss_vel.Text = "ຊັ້ນ/ຂັ້ນ"
        Me.chk_clss_vel.UseVisualStyleBackColor = True
        '
        'chk_job_lut
        '
        Me.chk_job_lut.AutoSize = True
        Me.chk_job_lut.Location = New System.Drawing.Point(50, 269)
        Me.chk_job_lut.Name = "chk_job_lut"
        Me.chk_job_lut.Size = New System.Drawing.Size(158, 28)
        Me.chk_job_lut.TabIndex = 45866
        Me.chk_job_lut.Text = "ຕຳແໜ່ງລັດ ບໍລິຫານ"
        Me.chk_job_lut.UseVisualStyleBackColor = True
        '
        'cmb_job_lut
        '
        Me.cmb_job_lut.BackColor = System.Drawing.Color.White
        Me.cmb_job_lut.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_lut.FormattingEnabled = True
        Me.cmb_job_lut.Location = New System.Drawing.Point(210, 268)
        Me.cmb_job_lut.Name = "cmb_job_lut"
        Me.cmb_job_lut.Size = New System.Drawing.Size(201, 32)
        Me.cmb_job_lut.TabIndex = 45865
        '
        'txt_job_lut_id
        '
        Me.txt_job_lut_id.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job_lut_id.Location = New System.Drawing.Point(3, 278)
        Me.txt_job_lut_id.Name = "txt_job_lut_id"
        Me.txt_job_lut_id.Size = New System.Drawing.Size(31, 30)
        Me.txt_job_lut_id.TabIndex = 45867
        Me.txt_job_lut_id.Visible = False
        '
        'cmb_percen
        '
        Me.cmb_percen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_percen.Enabled = False
        Me.cmb_percen.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_percen.FormattingEnabled = True
        Me.cmb_percen.Items.AddRange(New Object() {"100", "99", "98", "97", "96", "95", "94", "93", "92", "91", "90", "89", "88", "87", "86", "85", "84", "83", "82", "81", "80", "79", "78", "77", "76", "75", "74", "73", "72", "71", "70", "69", "68", "67", "66", "65", "64", "63", "62", "61", "60", "59", "58", "57", "56", "55", "54", "53", "52", "51", "50"})
        Me.cmb_percen.Location = New System.Drawing.Point(274, 96)
        Me.cmb_percen.Name = "cmb_percen"
        Me.cmb_percen.Size = New System.Drawing.Size(106, 32)
        Me.cmb_percen.TabIndex = 45869
        '
        'chk_percen
        '
        Me.chk_percen.AutoSize = True
        Me.chk_percen.Location = New System.Drawing.Point(49, 97)
        Me.chk_percen.Name = "chk_percen"
        Me.chk_percen.Size = New System.Drawing.Size(193, 28)
        Me.chk_percen.TabIndex = 45870
        Me.chk_percen.Text = "ພ/ງຮັບເງີນເດືອນຕົວຈີງ(%)"
        Me.chk_percen.UseVisualStyleBackColor = True
        '
        'chk_start
        '
        Me.chk_start.AutoSize = True
        Me.chk_start.Location = New System.Drawing.Point(49, 60)
        Me.chk_start.Name = "chk_start"
        Me.chk_start.Size = New System.Drawing.Size(140, 28)
        Me.chk_start.TabIndex = 45871
        Me.chk_start.Text = "ວັນທີເລີມເຮັດການ"
        Me.chk_start.UseVisualStyleBackColor = True
        '
        'chk_DOB
        '
        Me.chk_DOB.AutoSize = True
        Me.chk_DOB.Location = New System.Drawing.Point(451, 175)
        Me.chk_DOB.Name = "chk_DOB"
        Me.chk_DOB.Size = New System.Drawing.Size(65, 28)
        Me.chk_DOB.TabIndex = 45872
        Me.chk_DOB.Text = "ປີເກີດ"
        Me.chk_DOB.UseVisualStyleBackColor = True
        '
        'DT_DOB
        '
        Me.DT_DOB.CustomFormat = "yyyy"
        Me.DT_DOB.Enabled = False
        Me.DT_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_DOB.Location = New System.Drawing.Point(617, 170)
        Me.DT_DOB.Name = "DT_DOB"
        Me.DT_DOB.ShowUpDown = True
        Me.DT_DOB.Size = New System.Drawing.Size(74, 35)
        Me.DT_DOB.TabIndex = 45873
        '
        'chk_study_finish
        '
        Me.chk_study_finish.AutoSize = True
        Me.chk_study_finish.Location = New System.Drawing.Point(16, 34)
        Me.chk_study_finish.Name = "chk_study_finish"
        Me.chk_study_finish.Size = New System.Drawing.Size(85, 28)
        Me.chk_study_finish.TabIndex = 45874
        Me.chk_study_finish.Text = "ປີຮຽນຈົບ"
        Me.chk_study_finish.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_visa)
        Me.GroupBox1.Controls.Add(Me.chk_Nation)
        Me.GroupBox1.Controls.Add(Me.chk_visa)
        Me.GroupBox1.Controls.Add(Me.chk_study)
        Me.GroupBox1.Controls.Add(Me.txtlang_id)
        Me.GroupBox1.Controls.Add(Me.txtstudy_id)
        Me.GroupBox1.Controls.Add(Me.cmb_lang)
        Me.GroupBox1.Controls.Add(Me.chk_lang)
        Me.GroupBox1.Controls.Add(Me.txt_Nation_id)
        Me.GroupBox1.Controls.Add(Me.cmb_study)
        Me.GroupBox1.Controls.Add(Me.txtvisa_id)
        Me.GroupBox1.Controls.Add(Me.cmb_Nation)
        Me.GroupBox1.Controls.Add(Me.DT__study_finish)
        Me.GroupBox1.Controls.Add(Me.chk_study_finish)
        Me.GroupBox1.Location = New System.Drawing.Point(433, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 212)
        Me.GroupBox1.TabIndex = 45875
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ຊອກຫາຕາມ ການສຶກສາ-ວິຊາສະເພາະ"
        '
        'cmb_visa
        '
        Me.cmb_visa.BackColor = System.Drawing.Color.White
        Me.cmb_visa.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_visa.FormattingEnabled = True
        Me.cmb_visa.Location = New System.Drawing.Point(150, 101)
        Me.cmb_visa.Name = "cmb_visa"
        Me.cmb_visa.Size = New System.Drawing.Size(188, 32)
        Me.cmb_visa.TabIndex = 45882
        '
        'chk_Nation
        '
        Me.chk_Nation.AutoSize = True
        Me.chk_Nation.Location = New System.Drawing.Point(16, 141)
        Me.chk_Nation.Name = "chk_Nation"
        Me.chk_Nation.Size = New System.Drawing.Size(124, 28)
        Me.chk_Nation.TabIndex = 45889
        Me.chk_Nation.Text = "ສຶກສາທີ່ປະເທດ"
        Me.chk_Nation.UseVisualStyleBackColor = True
        '
        'chk_visa
        '
        Me.chk_visa.AutoSize = True
        Me.chk_visa.Location = New System.Drawing.Point(16, 105)
        Me.chk_visa.Name = "chk_visa"
        Me.chk_visa.Size = New System.Drawing.Size(135, 28)
        Me.chk_visa.TabIndex = 45888
        Me.chk_visa.Text = "ຂະແໜ່ງວິຊາຮຽນ"
        Me.chk_visa.UseVisualStyleBackColor = True
        '
        'chk_study
        '
        Me.chk_study.AutoSize = True
        Me.chk_study.Location = New System.Drawing.Point(15, 68)
        Me.chk_study.Name = "chk_study"
        Me.chk_study.Size = New System.Drawing.Size(134, 28)
        Me.chk_study.TabIndex = 45887
        Me.chk_study.Text = "ລະດັບການສຶກສາ"
        Me.chk_study.UseVisualStyleBackColor = True
        '
        'txtlang_id
        '
        Me.txtlang_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtlang_id.Enabled = False
        Me.txtlang_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlang_id.Location = New System.Drawing.Point(344, 173)
        Me.txtlang_id.Name = "txtlang_id"
        Me.txtlang_id.Size = New System.Drawing.Size(40, 27)
        Me.txtlang_id.TabIndex = 45886
        Me.txtlang_id.Visible = False
        '
        'txtstudy_id
        '
        Me.txtstudy_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtstudy_id.Enabled = False
        Me.txtstudy_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudy_id.Location = New System.Drawing.Point(344, 66)
        Me.txtstudy_id.Name = "txtstudy_id"
        Me.txtstudy_id.Size = New System.Drawing.Size(40, 27)
        Me.txtstudy_id.TabIndex = 45881
        Me.txtstudy_id.Visible = False
        '
        'cmb_lang
        '
        Me.cmb_lang.BackColor = System.Drawing.Color.White
        Me.cmb_lang.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_lang.FormattingEnabled = True
        Me.cmb_lang.Items.AddRange(New Object() {"ວິຊາການ"})
        Me.cmb_lang.Location = New System.Drawing.Point(150, 173)
        Me.cmb_lang.Name = "cmb_lang"
        Me.cmb_lang.Size = New System.Drawing.Size(188, 32)
        Me.cmb_lang.TabIndex = 45880
        '
        'chk_lang
        '
        Me.chk_lang.AutoSize = True
        Me.chk_lang.Location = New System.Drawing.Point(16, 178)
        Me.chk_lang.Name = "chk_lang"
        Me.chk_lang.Size = New System.Drawing.Size(137, 28)
        Me.chk_lang.TabIndex = 45879
        Me.chk_lang.Text = "ພາສາຕ່າງປະເທດ"
        Me.chk_lang.UseVisualStyleBackColor = True
        '
        'txt_Nation_id
        '
        Me.txt_Nation_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Nation_id.Enabled = False
        Me.txt_Nation_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nation_id.Location = New System.Drawing.Point(344, 137)
        Me.txt_Nation_id.Name = "txt_Nation_id"
        Me.txt_Nation_id.Size = New System.Drawing.Size(40, 27)
        Me.txt_Nation_id.TabIndex = 45876
        Me.txt_Nation_id.Visible = False
        '
        'cmb_study
        '
        Me.cmb_study.BackColor = System.Drawing.Color.White
        Me.cmb_study.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_study.FormattingEnabled = True
        Me.cmb_study.Location = New System.Drawing.Point(150, 66)
        Me.cmb_study.Name = "cmb_study"
        Me.cmb_study.Size = New System.Drawing.Size(188, 32)
        Me.cmb_study.TabIndex = 45878
        '
        'txtvisa_id
        '
        Me.txtvisa_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtvisa_id.Enabled = False
        Me.txtvisa_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvisa_id.Location = New System.Drawing.Point(343, 102)
        Me.txtvisa_id.Name = "txtvisa_id"
        Me.txtvisa_id.Size = New System.Drawing.Size(40, 27)
        Me.txtvisa_id.TabIndex = 45883
        Me.txtvisa_id.Visible = False
        '
        'cmb_Nation
        '
        Me.cmb_Nation.BackColor = System.Drawing.Color.White
        Me.cmb_Nation.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_Nation.FormattingEnabled = True
        Me.cmb_Nation.Location = New System.Drawing.Point(150, 137)
        Me.cmb_Nation.Name = "cmb_Nation"
        Me.cmb_Nation.Size = New System.Drawing.Size(188, 32)
        Me.cmb_Nation.TabIndex = 45875
        '
        'chk_year_phuk
        '
        Me.chk_year_phuk.AutoSize = True
        Me.chk_year_phuk.Location = New System.Drawing.Point(451, 104)
        Me.chk_year_phuk.Name = "chk_year_phuk"
        Me.chk_year_phuk.Size = New System.Drawing.Size(123, 28)
        Me.chk_year_phuk.TabIndex = 45876
        Me.chk_year_phuk.Text = "ປີເຂົ້າພັກສົມບູນ"
        Me.chk_year_phuk.UseVisualStyleBackColor = True
        '
        'chk_phuksumhong
        '
        Me.chk_phuksumhong.AutoSize = True
        Me.chk_phuksumhong.Location = New System.Drawing.Point(451, 63)
        Me.chk_phuksumhong.Name = "chk_phuksumhong"
        Me.chk_phuksumhong.Size = New System.Drawing.Size(169, 28)
        Me.chk_phuksumhong.TabIndex = 45878
        Me.chk_phuksumhong.Text = "ປີເຂົ້າພັກສົມບູນສຳຮອງ"
        Me.chk_phuksumhong.UseVisualStyleBackColor = True
        '
        'DT_year_phuksumhong
        '
        Me.DT_year_phuksumhong.CustomFormat = "yyyy"
        Me.DT_year_phuksumhong.Enabled = False
        Me.DT_year_phuksumhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_year_phuksumhong.Location = New System.Drawing.Point(617, 60)
        Me.DT_year_phuksumhong.Name = "DT_year_phuksumhong"
        Me.DT_year_phuksumhong.ShowUpDown = True
        Me.DT_year_phuksumhong.Size = New System.Drawing.Size(74, 35)
        Me.DT_year_phuksumhong.TabIndex = 45877
        '
        'chk_lut
        '
        Me.chk_lut.AutoSize = True
        Me.chk_lut.Location = New System.Drawing.Point(451, 141)
        Me.chk_lut.Name = "chk_lut"
        Me.chk_lut.Size = New System.Drawing.Size(83, 28)
        Me.chk_lut.TabIndex = 45880
        Me.chk_lut.Text = "ປີເຂົ້າລັດ"
        Me.chk_lut.UseVisualStyleBackColor = True
        '
        'DT_year_lut
        '
        Me.DT_year_lut.CustomFormat = "yyyy"
        Me.DT_year_lut.Enabled = False
        Me.DT_year_lut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_year_lut.Location = New System.Drawing.Point(617, 134)
        Me.DT_year_lut.Name = "DT_year_lut"
        Me.DT_year_lut.ShowUpDown = True
        Me.DT_year_lut.Size = New System.Drawing.Size(74, 35)
        Me.DT_year_lut.TabIndex = 45879
        '
        'Frm_persion_list_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 438)
        Me.Controls.Add(Me.chk_lut)
        Me.Controls.Add(Me.DT_year_lut)
        Me.Controls.Add(Me.DT_year_phuksumhong)
        Me.Controls.Add(Me.chk_phuksumhong)
        Me.Controls.Add(Me.chk_year_phuk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DT_DOB)
        Me.Controls.Add(Me.chk_DOB)
        Me.Controls.Add(Me.txtFdate)
        Me.Controls.Add(Me.chk_start)
        Me.Controls.Add(Me.chk_percen)
        Me.Controls.Add(Me.cmb_percen)
        Me.Controls.Add(Me.txt_job_lut_id)
        Me.Controls.Add(Me.chk_job_lut)
        Me.Controls.Add(Me.cmb_job_lut)
        Me.Controls.Add(Me.chk_clss_vel)
        Me.Controls.Add(Me.cmblevel)
        Me.Controls.Add(Me.cmbclass)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtV_C)
        Me.Controls.Add(Me.txt_job_phuk_id)
        Me.Controls.Add(Me.txtdepart_ID)
        Me.Controls.Add(Me.txtSection_ID)
        Me.Controls.Add(Me.chk_Job_Phuk)
        Me.Controls.Add(Me.cmb_job_phuk)
        Me.Controls.Add(Me.cmb_Department)
        Me.Controls.Add(Me.Cmb_Sections)
        Me.Controls.Add(Me.chk_department)
        Me.Controls.Add(Me.chk_section)
        Me.Controls.Add(Me.DT_year_phuk)
        Me.Controls.Add(Me.txtTdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label15)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_persion_list_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_persion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtFdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_year_phuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT__study_finish As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_Job_Phuk As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_job_phuk As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Department As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_Sections As System.Windows.Forms.ComboBox
    Friend WithEvents chk_department As System.Windows.Forms.CheckBox
    Friend WithEvents chk_section As System.Windows.Forms.CheckBox
    Friend WithEvents txtSection_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtdepart_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_job_phuk_id As System.Windows.Forms.TextBox
    Friend WithEvents cmblevel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbclass As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtV_C As System.Windows.Forms.TextBox
    Friend WithEvents chk_clss_vel As System.Windows.Forms.CheckBox
    Friend WithEvents chk_job_lut As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_job_lut As System.Windows.Forms.ComboBox
    Friend WithEvents txt_job_lut_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_percen As System.Windows.Forms.ComboBox
    Friend WithEvents chk_percen As System.Windows.Forms.CheckBox
    Friend WithEvents chk_start As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DOB As System.Windows.Forms.CheckBox
    Friend WithEvents DT_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_study_finish As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Nation As System.Windows.Forms.CheckBox
    Friend WithEvents chk_visa As System.Windows.Forms.CheckBox
    Friend WithEvents chk_study As System.Windows.Forms.CheckBox
    Friend WithEvents txtlang_id As System.Windows.Forms.TextBox
    Friend WithEvents txtstudy_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_lang As System.Windows.Forms.ComboBox
    Friend WithEvents chk_lang As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Nation_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_study As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_visa As System.Windows.Forms.ComboBox
    Friend WithEvents txtvisa_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Nation As System.Windows.Forms.ComboBox
    Friend WithEvents chk_year_phuk As System.Windows.Forms.CheckBox
    Friend WithEvents chk_phuksumhong As System.Windows.Forms.CheckBox
    Friend WithEvents DT_year_phuksumhong As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_lut As System.Windows.Forms.CheckBox
    Friend WithEvents DT_year_lut As System.Windows.Forms.DateTimePicker
End Class
