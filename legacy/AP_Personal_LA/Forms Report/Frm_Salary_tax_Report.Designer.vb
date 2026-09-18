<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Salary_tax_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Salary_tax_Report))
        Me.Chk_year = New System.Windows.Forms.RadioButton
        Me.Chk_Dt = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtFdate = New System.Windows.Forms.DateTimePicker
        Me.txtTdate = New System.Windows.Forms.DateTimePicker
        Me.DT_Month = New System.Windows.Forms.DateTimePicker
        Me.DT_year = New System.Windows.Forms.DateTimePicker
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
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtpart = New System.Windows.Forms.TextBox
        Me.txtProv_Sym = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Chk_em_In = New System.Windows.Forms.RadioButton
        Me.Chk_em_Extra = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chk_year
        '
        Me.Chk_year.AutoSize = True
        Me.Chk_year.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_year.Location = New System.Drawing.Point(793, 316)
        Me.Chk_year.Name = "Chk_year"
        Me.Chk_year.Size = New System.Drawing.Size(42, 28)
        Me.Chk_year.TabIndex = 45845
        Me.Chk_year.TabStop = True
        Me.Chk_year.Text = "ປີ:"
        Me.Chk_year.UseVisualStyleBackColor = True
        Me.Chk_year.Visible = False
        '
        'Chk_Dt
        '
        Me.Chk_Dt.AutoSize = True
        Me.Chk_Dt.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Dt.Location = New System.Drawing.Point(766, 241)
        Me.Chk_Dt.Name = "Chk_Dt"
        Me.Chk_Dt.Size = New System.Drawing.Size(63, 28)
        Me.Chk_Dt.TabIndex = 45843
        Me.Chk_Dt.TabStop = True
        Me.Chk_Dt.Text = "ວັນທີ:"
        Me.Chk_Dt.UseVisualStyleBackColor = True
        Me.Chk_Dt.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(793, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 24)
        Me.Label2.TabIndex = 45842
        Me.Label2.Text = "ເຖິງ:"
        Me.Label2.Visible = False
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
        Me.txtFdate.Location = New System.Drawing.Point(836, 238)
        Me.txtFdate.Name = "txtFdate"
        Me.txtFdate.ShowUpDown = True
        Me.txtFdate.Size = New System.Drawing.Size(105, 35)
        Me.txtFdate.TabIndex = 45847
        Me.txtFdate.Visible = False
        '
        'txtTdate
        '
        Me.txtTdate.CustomFormat = "dd/MM/yyyy"
        Me.txtTdate.Enabled = False
        Me.txtTdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTdate.Location = New System.Drawing.Point(837, 274)
        Me.txtTdate.Name = "txtTdate"
        Me.txtTdate.ShowUpDown = True
        Me.txtTdate.Size = New System.Drawing.Size(104, 35)
        Me.txtTdate.TabIndex = 45846
        Me.txtTdate.Visible = False
        '
        'DT_Month
        '
        Me.DT_Month.CustomFormat = "MM/yyyy"
        Me.DT_Month.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_Month.Location = New System.Drawing.Point(224, 59)
        Me.DT_Month.Name = "DT_Month"
        Me.DT_Month.ShowUpDown = True
        Me.DT_Month.Size = New System.Drawing.Size(105, 35)
        Me.DT_Month.TabIndex = 45848
        '
        'DT_year
        '
        Me.DT_year.CustomFormat = "yyyy"
        Me.DT_year.Enabled = False
        Me.DT_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_year.Location = New System.Drawing.Point(837, 312)
        Me.DT_year.Name = "DT_year"
        Me.DT_year.ShowUpDown = True
        Me.DT_year.Size = New System.Drawing.Size(105, 35)
        Me.DT_year.TabIndex = 45849
        Me.DT_year.Visible = False
        '
        'chk_Job_Phuk
        '
        Me.chk_Job_Phuk.AutoSize = True
        Me.chk_Job_Phuk.Location = New System.Drawing.Point(50, 172)
        Me.chk_Job_Phuk.Name = "chk_Job_Phuk"
        Me.chk_Job_Phuk.Size = New System.Drawing.Size(172, 28)
        Me.chk_Job_Phuk.TabIndex = 45855
        Me.chk_Job_Phuk.Text = "ໜ້າທີ່ຮັບຜິດຊອປະຈຸບັນ"
        Me.chk_Job_Phuk.UseVisualStyleBackColor = True
        '
        'cmb_job_phuk
        '
        Me.cmb_job_phuk.BackColor = System.Drawing.Color.White
        Me.cmb_job_phuk.Enabled = False
        Me.cmb_job_phuk.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_phuk.FormattingEnabled = True
        Me.cmb_job_phuk.Location = New System.Drawing.Point(225, 168)
        Me.cmb_job_phuk.Name = "cmb_job_phuk"
        Me.cmb_job_phuk.Size = New System.Drawing.Size(323, 32)
        Me.cmb_job_phuk.TabIndex = 45854
        '
        'cmb_Department
        '
        Me.cmb_Department.Enabled = False
        Me.cmb_Department.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_Department.FormattingEnabled = True
        Me.cmb_Department.Location = New System.Drawing.Point(224, 134)
        Me.cmb_Department.Name = "cmb_Department"
        Me.cmb_Department.Size = New System.Drawing.Size(324, 32)
        Me.cmb_Department.TabIndex = 45853
        '
        'Cmb_Sections
        '
        Me.Cmb_Sections.Enabled = False
        Me.Cmb_Sections.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.Cmb_Sections.FormattingEnabled = True
        Me.Cmb_Sections.Location = New System.Drawing.Point(224, 100)
        Me.Cmb_Sections.Name = "Cmb_Sections"
        Me.Cmb_Sections.Size = New System.Drawing.Size(324, 32)
        Me.Cmb_Sections.TabIndex = 45852
        '
        'chk_department
        '
        Me.chk_department.AutoSize = True
        Me.chk_department.Location = New System.Drawing.Point(50, 138)
        Me.chk_department.Name = "chk_department"
        Me.chk_department.Size = New System.Drawing.Size(78, 28)
        Me.chk_department.TabIndex = 45851
        Me.chk_department.Text = "ພະແນກ"
        Me.chk_department.UseVisualStyleBackColor = True
        '
        'chk_section
        '
        Me.chk_section.AutoSize = True
        Me.chk_section.Location = New System.Drawing.Point(103, 275)
        Me.chk_section.Name = "chk_section"
        Me.chk_section.Size = New System.Drawing.Size(124, 28)
        Me.chk_section.TabIndex = 45850
        Me.chk_section.Text = "ບ່ອນປະຈຳການ"
        Me.chk_section.UseVisualStyleBackColor = True
        Me.chk_section.Visible = False
        '
        'txtSection_ID
        '
        Me.txtSection_ID.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection_ID.Location = New System.Drawing.Point(13, 105)
        Me.txtSection_ID.Name = "txtSection_ID"
        Me.txtSection_ID.Size = New System.Drawing.Size(31, 30)
        Me.txtSection_ID.TabIndex = 45856
        Me.txtSection_ID.Visible = False
        '
        'txtdepart_ID
        '
        Me.txtdepart_ID.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepart_ID.Location = New System.Drawing.Point(14, 137)
        Me.txtdepart_ID.Name = "txtdepart_ID"
        Me.txtdepart_ID.Size = New System.Drawing.Size(31, 30)
        Me.txtdepart_ID.TabIndex = 45857
        Me.txtdepart_ID.Visible = False
        '
        'txt_job_phuk_id
        '
        Me.txt_job_phuk_id.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job_phuk_id.Location = New System.Drawing.Point(15, 170)
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
        Me.cmblevel.Location = New System.Drawing.Point(333, 397)
        Me.cmblevel.Name = "cmblevel"
        Me.cmblevel.Size = New System.Drawing.Size(45, 32)
        Me.cmblevel.TabIndex = 45859
        Me.cmblevel.Visible = False
        '
        'cmbclass
        '
        Me.cmbclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbclass.Enabled = False
        Me.cmbclass.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbclass.ForeColor = System.Drawing.Color.Black
        Me.cmbclass.FormattingEnabled = True
        Me.cmbclass.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbclass.Location = New System.Drawing.Point(273, 398)
        Me.cmbclass.Name = "cmbclass"
        Me.cmbclass.Size = New System.Drawing.Size(43, 32)
        Me.cmbclass.TabIndex = 45860
        Me.cmbclass.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(314, 403)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 24)
        Me.Label10.TabIndex = 45862
        Me.Label10.Text = "/"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'txtV_C
        '
        Me.txtV_C.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtV_C.Location = New System.Drawing.Point(384, 396)
        Me.txtV_C.Name = "txtV_C"
        Me.txtV_C.Size = New System.Drawing.Size(56, 35)
        Me.txtV_C.TabIndex = 45863
        Me.txtV_C.Visible = False
        '
        'chk_clss_vel
        '
        Me.chk_clss_vel.AutoSize = True
        Me.chk_clss_vel.Location = New System.Drawing.Point(100, 401)
        Me.chk_clss_vel.Name = "chk_clss_vel"
        Me.chk_clss_vel.Size = New System.Drawing.Size(73, 28)
        Me.chk_clss_vel.TabIndex = 45864
        Me.chk_clss_vel.Text = "ຊັ້ນ/ຂັ້ນ"
        Me.chk_clss_vel.UseVisualStyleBackColor = True
        Me.chk_clss_vel.Visible = False
        '
        'chk_job_lut
        '
        Me.chk_job_lut.AutoSize = True
        Me.chk_job_lut.Location = New System.Drawing.Point(50, 203)
        Me.chk_job_lut.Name = "chk_job_lut"
        Me.chk_job_lut.Size = New System.Drawing.Size(139, 28)
        Me.chk_job_lut.TabIndex = 45866
        Me.chk_job_lut.Text = "ປະເພດພະນັກງານ"
        Me.chk_job_lut.UseVisualStyleBackColor = True
        '
        'cmb_job_lut
        '
        Me.cmb_job_lut.BackColor = System.Drawing.Color.White
        Me.cmb_job_lut.Enabled = False
        Me.cmb_job_lut.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_lut.FormattingEnabled = True
        Me.cmb_job_lut.Location = New System.Drawing.Point(224, 202)
        Me.cmb_job_lut.Name = "cmb_job_lut"
        Me.cmb_job_lut.Size = New System.Drawing.Size(324, 32)
        Me.cmb_job_lut.TabIndex = 45865
        '
        'txt_job_lut_id
        '
        Me.txt_job_lut_id.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job_lut_id.Location = New System.Drawing.Point(15, 201)
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
        Me.cmb_percen.Location = New System.Drawing.Point(312, 359)
        Me.cmb_percen.Name = "cmb_percen"
        Me.cmb_percen.Size = New System.Drawing.Size(161, 32)
        Me.cmb_percen.TabIndex = 45869
        Me.cmb_percen.Visible = False
        '
        'chk_percen
        '
        Me.chk_percen.AutoSize = True
        Me.chk_percen.Location = New System.Drawing.Point(99, 361)
        Me.chk_percen.Name = "chk_percen"
        Me.chk_percen.Size = New System.Drawing.Size(193, 28)
        Me.chk_percen.TabIndex = 45870
        Me.chk_percen.Text = "ພ/ງຮັບເງີນເດືອນຕົວຈີງ(%)"
        Me.chk_percen.UseVisualStyleBackColor = True
        Me.chk_percen.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(61, 66)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(137, 24)
        Me.Label18.TabIndex = 45872
        Me.Label18.Text = "ລາຍງານປະຈຳເດືອນ"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Saysettha OT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(49, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(724, 38)
        Me.Label15.TabIndex = 45873
        Me.Label15.Text = "ລາຍງານອາກອນລາຍໄດ້ຈາກເງີນເດືອນ ຂອງພະນັກງານ - ກຳມະກອນ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtpart)
        Me.Panel1.Controls.Add(Me.txtProv_Sym)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DT_Month)
        Me.Panel1.Controls.Add(Me.chk_section)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.chk_department)
        Me.Panel1.Controls.Add(Me.Cmb_Sections)
        Me.Panel1.Controls.Add(Me.cmb_Department)
        Me.Panel1.Controls.Add(Me.txt_job_lut_id)
        Me.Panel1.Controls.Add(Me.cmb_job_phuk)
        Me.Panel1.Controls.Add(Me.chk_job_lut)
        Me.Panel1.Controls.Add(Me.chk_Job_Phuk)
        Me.Panel1.Controls.Add(Me.cmb_job_lut)
        Me.Panel1.Controls.Add(Me.txtSection_ID)
        Me.Panel1.Controls.Add(Me.txtdepart_ID)
        Me.Panel1.Controls.Add(Me.txt_job_phuk_id)
        Me.Panel1.Location = New System.Drawing.Point(47, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 365)
        Me.Panel1.TabIndex = 45874
        '
        'txtpart
        '
        Me.txtpart.BackColor = System.Drawing.Color.White
        Me.txtpart.Enabled = False
        Me.txtpart.Location = New System.Drawing.Point(322, 268)
        Me.txtpart.Name = "txtpart"
        Me.txtpart.Size = New System.Drawing.Size(154, 35)
        Me.txtpart.TabIndex = 45880
        Me.txtpart.Visible = False
        '
        'txtProv_Sym
        '
        Me.txtProv_Sym.BackColor = System.Drawing.Color.White
        Me.txtProv_Sym.Enabled = False
        Me.txtProv_Sym.Location = New System.Drawing.Point(225, 268)
        Me.txtProv_Sym.Name = "txtProv_Sym"
        Me.txtProv_Sym.Size = New System.Drawing.Size(91, 35)
        Me.txtProv_Sym.TabIndex = 45879
        Me.txtProv_Sym.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 45877
        Me.Label1.Text = "ບ່ອນປະຈຳການ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Chk_em_In)
        Me.Panel2.Controls.Add(Me.Chk_em_Extra)
        Me.Panel2.Location = New System.Drawing.Point(5, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(721, 50)
        Me.Panel2.TabIndex = 45876
        Me.Panel2.Visible = False
        '
        'Chk_em_In
        '
        Me.Chk_em_In.AutoSize = True
        Me.Chk_em_In.Font = New System.Drawing.Font("Saysettha OT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_em_In.Location = New System.Drawing.Point(4, 3)
        Me.Chk_em_In.Name = "Chk_em_In"
        Me.Chk_em_In.Size = New System.Drawing.Size(330, 38)
        Me.Chk_em_In.TabIndex = 45875
        Me.Chk_em_In.TabStop = True
        Me.Chk_em_In.Text = "ສະເພາະພະນັກງານສາຂາພານໃນ"
        Me.Chk_em_In.UseVisualStyleBackColor = True
        '
        'Chk_em_Extra
        '
        Me.Chk_em_Extra.AutoSize = True
        Me.Chk_em_Extra.Font = New System.Drawing.Font("Saysettha OT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_em_Extra.Location = New System.Drawing.Point(349, 3)
        Me.Chk_em_Extra.Name = "Chk_em_Extra"
        Me.Chk_em_Extra.Size = New System.Drawing.Size(367, 38)
        Me.Chk_em_Extra.TabIndex = 45874
        Me.Chk_em_Extra.TabStop = True
        Me.Chk_em_Extra.Text = "ສະເພາະພະນັກງານສາຂາຕ່າງປະເທດ"
        Me.Chk_em_Extra.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(186, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 47)
        Me.Button1.TabIndex = 45875
        Me.Button1.Tag = "3028"
        Me.Button1.Text = "ສົ່ງໄປ Excel"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_Salary_tax_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(807, 468)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.chk_percen)
        Me.Controls.Add(Me.cmb_percen)
        Me.Controls.Add(Me.chk_clss_vel)
        Me.Controls.Add(Me.cmblevel)
        Me.Controls.Add(Me.cmbclass)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtV_C)
        Me.Controls.Add(Me.DT_year)
        Me.Controls.Add(Me.txtFdate)
        Me.Controls.Add(Me.txtTdate)
        Me.Controls.Add(Me.Chk_year)
        Me.Controls.Add(Me.Chk_Dt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Salary_tax_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_persion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chk_year As System.Windows.Forms.RadioButton
    Friend WithEvents Chk_Dt As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtFdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_Month As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_year As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Chk_em_In As System.Windows.Forms.RadioButton
    Friend WithEvents Chk_em_Extra As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtpart As System.Windows.Forms.TextBox
    Friend WithEvents txtProv_Sym As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
