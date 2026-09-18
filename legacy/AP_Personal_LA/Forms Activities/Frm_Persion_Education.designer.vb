<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Persion_Education
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Persion_Education))
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTdate = New System.Windows.Forms.DateTimePicker
        Me.Fg1 = New AxVSFlex8U.AxVSFlexGrid
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtvisa_id = New System.Windows.Forms.TextBox
        Me.cmb_visa = New System.Windows.Forms.ComboBox
        Me.txtSection_ID = New System.Windows.Forms.TextBox
        Me.txtdepart_ID = New System.Windows.Forms.TextBox
        Me.cmb_Department = New System.Windows.Forms.ComboBox
        Me.Cmb_Sections = New System.Windows.Forms.ComboBox
        Me.chk_department = New System.Windows.Forms.CheckBox
        Me.chk_section = New System.Windows.Forms.CheckBox
        Me.txt_type_in_id = New System.Windows.Forms.TextBox
        Me.cmb_type_in = New System.Windows.Forms.ComboBox
        Me.chk_type_in = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtid = New System.Windows.Forms.TextBox
        Me.TxtPersonNmL = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.txtstudy_id = New System.Windows.Forms.TextBox
        Me.cmb_lang = New System.Windows.Forms.ComboBox
        Me.chk_lang = New System.Windows.Forms.CheckBox
        Me.chk_visa = New System.Windows.Forms.CheckBox
        Me.Button91 = New System.Windows.Forms.Button
        Me.txt_Nation_id = New System.Windows.Forms.TextBox
        Me.cmb_study = New System.Windows.Forms.ComboBox
        Me.Label206 = New System.Windows.Forms.Label
        Me.Button15 = New System.Windows.Forms.Button
        Me.cmb_visa2 = New System.Windows.Forms.ComboBox
        Me.cmb_Nation = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_no = New System.Windows.Forms.TextBox
        Me.G = New System.Windows.Forms.GroupBox
        Me.txtstudy_id2 = New System.Windows.Forms.TextBox
        Me.txtlang_id2 = New System.Windows.Forms.TextBox
        Me.chk_study = New System.Windows.Forms.CheckBox
        Me.txt_Nation_id2 = New System.Windows.Forms.TextBox
        Me.txtvisa_id2 = New System.Windows.Forms.TextBox
        Me.cmb_Nation2 = New System.Windows.Forms.ComboBox
        Me.chk_Nation = New System.Windows.Forms.CheckBox
        Me.chk_lang2 = New System.Windows.Forms.CheckBox
        Me.cmb_lang2 = New System.Windows.Forms.ComboBox
        Me.cmb_study2 = New System.Windows.Forms.ComboBox
        Me.DT_year = New System.Windows.Forms.DateTimePicker
        Me.chk_year = New System.Windows.Forms.CheckBox
        Me.txtFdate = New System.Windows.Forms.DateTimePicker
        Me.chk_date = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.DT_Finish = New System.Windows.Forms.DateTimePicker
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.txtremark = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtlang_id = New System.Windows.Forms.TextBox
        Me.txtsamun = New System.Windows.Forms.TextBox
        Me.txtsamun_id = New System.Windows.Forms.TextBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Badd = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.G.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 24)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "ເຖິງ:"
        '
        'txtTdate
        '
        Me.txtTdate.CustomFormat = "dd/MM/yyyy"
        Me.txtTdate.Enabled = False
        Me.txtTdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTdate.Location = New System.Drawing.Point(235, 22)
        Me.txtTdate.Name = "txtTdate"
        Me.txtTdate.ShowUpDown = True
        Me.txtTdate.Size = New System.Drawing.Size(104, 35)
        Me.txtTdate.TabIndex = 105
        '
        'Fg1
        '
        Me.Fg1.DataSource = Nothing
        Me.Fg1.Location = New System.Drawing.Point(4, 305)
        Me.Fg1.Name = "Fg1"
        Me.Fg1.OcxState = CType(resources.GetObject("Fg1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg1.Size = New System.Drawing.Size(1351, 359)
        Me.Fg1.TabIndex = 106
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Saysettha OT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(787, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(324, 46)
        Me.Label15.TabIndex = 311
        Me.Label15.Text = "ການສຶກສາ-ວິຊາສະເພາະ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtvisa_id
        '
        Me.txtvisa_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtvisa_id.Enabled = False
        Me.txtvisa_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvisa_id.Location = New System.Drawing.Point(459, 163)
        Me.txtvisa_id.Name = "txtvisa_id"
        Me.txtvisa_id.Size = New System.Drawing.Size(40, 27)
        Me.txtvisa_id.TabIndex = 45818
        Me.txtvisa_id.Visible = False
        '
        'cmb_visa
        '
        Me.cmb_visa.BackColor = System.Drawing.Color.White
        Me.cmb_visa.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_visa.FormattingEnabled = True
        Me.cmb_visa.Location = New System.Drawing.Point(166, 161)
        Me.cmb_visa.Name = "cmb_visa"
        Me.cmb_visa.Size = New System.Drawing.Size(246, 32)
        Me.cmb_visa.TabIndex = 45816
        '
        'txtSection_ID
        '
        Me.txtSection_ID.Location = New System.Drawing.Point(1095, 367)
        Me.txtSection_ID.Name = "txtSection_ID"
        Me.txtSection_ID.Size = New System.Drawing.Size(43, 35)
        Me.txtSection_ID.TabIndex = 45815
        Me.txtSection_ID.Visible = False
        '
        'txtdepart_ID
        '
        Me.txtdepart_ID.Location = New System.Drawing.Point(1229, 13)
        Me.txtdepart_ID.Name = "txtdepart_ID"
        Me.txtdepart_ID.Size = New System.Drawing.Size(46, 35)
        Me.txtdepart_ID.TabIndex = 45814
        Me.txtdepart_ID.Visible = False
        '
        'cmb_Department
        '
        Me.cmb_Department.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_Department.FormattingEnabled = True
        Me.cmb_Department.Location = New System.Drawing.Point(515, 129)
        Me.cmb_Department.Name = "cmb_Department"
        Me.cmb_Department.Size = New System.Drawing.Size(220, 32)
        Me.cmb_Department.TabIndex = 45813
        '
        'Cmb_Sections
        '
        Me.Cmb_Sections.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.Cmb_Sections.FormattingEnabled = True
        Me.Cmb_Sections.Location = New System.Drawing.Point(515, 95)
        Me.Cmb_Sections.Name = "Cmb_Sections"
        Me.Cmb_Sections.Size = New System.Drawing.Size(220, 32)
        Me.Cmb_Sections.TabIndex = 45812
        '
        'chk_department
        '
        Me.chk_department.AutoSize = True
        Me.chk_department.Location = New System.Drawing.Point(352, 131)
        Me.chk_department.Name = "chk_department"
        Me.chk_department.Size = New System.Drawing.Size(78, 28)
        Me.chk_department.TabIndex = 45811
        Me.chk_department.Text = "ພະແນກ"
        Me.chk_department.UseVisualStyleBackColor = True
        '
        'chk_section
        '
        Me.chk_section.AutoSize = True
        Me.chk_section.Location = New System.Drawing.Point(350, 95)
        Me.chk_section.Name = "chk_section"
        Me.chk_section.Size = New System.Drawing.Size(124, 28)
        Me.chk_section.TabIndex = 45810
        Me.chk_section.Text = "ບ່ອນປະຈຳການ"
        Me.chk_section.UseVisualStyleBackColor = True
        '
        'txt_type_in_id
        '
        Me.txt_type_in_id.Font = New System.Drawing.Font("Saysettha OT", 8.0!)
        Me.txt_type_in_id.Location = New System.Drawing.Point(1209, 367)
        Me.txt_type_in_id.Name = "txt_type_in_id"
        Me.txt_type_in_id.Size = New System.Drawing.Size(34, 26)
        Me.txt_type_in_id.TabIndex = 45821
        Me.txt_type_in_id.Visible = False
        '
        'cmb_type_in
        '
        Me.cmb_type_in.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_type_in.FormattingEnabled = True
        Me.cmb_type_in.Location = New System.Drawing.Point(515, 60)
        Me.cmb_type_in.Name = "cmb_type_in"
        Me.cmb_type_in.Size = New System.Drawing.Size(220, 32)
        Me.cmb_type_in.TabIndex = 45819
        '
        'chk_type_in
        '
        Me.chk_type_in.AutoSize = True
        Me.chk_type_in.Location = New System.Drawing.Point(350, 64)
        Me.chk_type_in.Name = "chk_type_in"
        Me.chk_type_in.Size = New System.Drawing.Size(170, 28)
        Me.chk_type_in.TabIndex = 45822
        Me.chk_type_in.Text = "ຮູບການເຂົ້າລັດຖະກອນ"
        Me.chk_type_in.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(44, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 45828
        Me.Label1.Tag = "2001"
        Me.Label1.Text = "ລະຫັດພະນັກງານ"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 24)
        Me.Label4.TabIndex = 45824
        Me.Label4.Text = "ຊື່ ແລະ ນາມສະກຸນ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(166, 56)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(174, 34)
        Me.txtid.TabIndex = 45827
        '
        'TxtPersonNmL
        '
        Me.TxtPersonNmL.Location = New System.Drawing.Point(538, 59)
        Me.TxtPersonNmL.Name = "TxtPersonNmL"
        Me.TxtPersonNmL.Size = New System.Drawing.Size(237, 35)
        Me.TxtPersonNmL.TabIndex = 45829
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(417, 127)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(41, 29)
        Me.Button5.TabIndex = 111
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtstudy_id
        '
        Me.txtstudy_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtstudy_id.Enabled = False
        Me.txtstudy_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudy_id.Location = New System.Drawing.Point(460, 127)
        Me.txtstudy_id.Name = "txtstudy_id"
        Me.txtstudy_id.Size = New System.Drawing.Size(40, 27)
        Me.txtstudy_id.TabIndex = 110
        Me.txtstudy_id.Visible = False
        '
        'cmb_lang
        '
        Me.cmb_lang.BackColor = System.Drawing.Color.White
        Me.cmb_lang.Enabled = False
        Me.cmb_lang.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_lang.FormattingEnabled = True
        Me.cmb_lang.Items.AddRange(New Object() {"ວິຊາການ"})
        Me.cmb_lang.Location = New System.Drawing.Point(166, 263)
        Me.cmb_lang.Name = "cmb_lang"
        Me.cmb_lang.Size = New System.Drawing.Size(246, 32)
        Me.cmb_lang.TabIndex = 109
        '
        'chk_lang
        '
        Me.chk_lang.AutoSize = True
        Me.chk_lang.Location = New System.Drawing.Point(26, 267)
        Me.chk_lang.Name = "chk_lang"
        Me.chk_lang.Size = New System.Drawing.Size(137, 28)
        Me.chk_lang.TabIndex = 108
        Me.chk_lang.Text = "ພາສາຕ່າງປະເທດ"
        Me.chk_lang.UseVisualStyleBackColor = True
        '
        'chk_visa
        '
        Me.chk_visa.AutoSize = True
        Me.chk_visa.Location = New System.Drawing.Point(11, 97)
        Me.chk_visa.Name = "chk_visa"
        Me.chk_visa.Size = New System.Drawing.Size(135, 28)
        Me.chk_visa.TabIndex = 106
        Me.chk_visa.Text = "ຂະແໜ່ງວິຊາຮຽນ"
        Me.chk_visa.UseVisualStyleBackColor = True
        '
        'Button91
        '
        Me.Button91.ForeColor = System.Drawing.Color.Black
        Me.Button91.Location = New System.Drawing.Point(418, 198)
        Me.Button91.Name = "Button91"
        Me.Button91.Size = New System.Drawing.Size(41, 29)
        Me.Button91.TabIndex = 98
        Me.Button91.Text = "..."
        Me.Button91.UseVisualStyleBackColor = True
        '
        'txt_Nation_id
        '
        Me.txt_Nation_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Nation_id.Enabled = False
        Me.txt_Nation_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nation_id.Location = New System.Drawing.Point(460, 198)
        Me.txt_Nation_id.Name = "txt_Nation_id"
        Me.txt_Nation_id.Size = New System.Drawing.Size(40, 27)
        Me.txt_Nation_id.TabIndex = 91
        Me.txt_Nation_id.Visible = False
        '
        'cmb_study
        '
        Me.cmb_study.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_study.FormattingEnabled = True
        Me.cmb_study.Location = New System.Drawing.Point(166, 127)
        Me.cmb_study.Name = "cmb_study"
        Me.cmb_study.Size = New System.Drawing.Size(246, 32)
        Me.cmb_study.TabIndex = 93
        '
        'Label206
        '
        Me.Label206.AutoSize = True
        Me.Label206.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label206.Location = New System.Drawing.Point(48, 133)
        Me.Label206.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label206.Name = "Label206"
        Me.Label206.Size = New System.Drawing.Size(115, 24)
        Me.Label206.TabIndex = 92
        Me.Label206.Text = "ລະດັບການສຶກສາ"
        Me.Label206.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button15
        '
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Location = New System.Drawing.Point(418, 163)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(41, 29)
        Me.Button15.TabIndex = 87
        Me.Button15.Text = "..."
        Me.Button15.UseVisualStyleBackColor = True
        '
        'cmb_visa2
        '
        Me.cmb_visa2.BackColor = System.Drawing.Color.White
        Me.cmb_visa2.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_visa2.FormattingEnabled = True
        Me.cmb_visa2.Location = New System.Drawing.Point(175, 95)
        Me.cmb_visa2.Name = "cmb_visa2"
        Me.cmb_visa2.Size = New System.Drawing.Size(164, 32)
        Me.cmb_visa2.TabIndex = 46
        '
        'cmb_Nation
        '
        Me.cmb_Nation.BackColor = System.Drawing.Color.White
        Me.cmb_Nation.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_Nation.FormattingEnabled = True
        Me.cmb_Nation.Location = New System.Drawing.Point(166, 194)
        Me.cmb_Nation.Name = "cmb_Nation"
        Me.cmb_Nation.Size = New System.Drawing.Size(246, 32)
        Me.cmb_Nation.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(1121, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 24)
        Me.Label16.TabIndex = 45832
        Me.Label16.Tag = "2001"
        Me.Label16.Text = "ເລກນັບ"
        Me.Label16.Visible = False
        '
        'txt_no
        '
        Me.txt_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_no.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no.Location = New System.Drawing.Point(1178, 11)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(97, 34)
        Me.txt_no.TabIndex = 45831
        Me.txt_no.Visible = False
        '
        'G
        '
        Me.G.Controls.Add(Me.txtstudy_id2)
        Me.G.Controls.Add(Me.txtlang_id2)
        Me.G.Controls.Add(Me.chk_study)
        Me.G.Controls.Add(Me.txt_Nation_id2)
        Me.G.Controls.Add(Me.txtvisa_id2)
        Me.G.Controls.Add(Me.Button8)
        Me.G.Controls.Add(Me.cmb_Nation2)
        Me.G.Controls.Add(Me.chk_Nation)
        Me.G.Controls.Add(Me.chk_lang2)
        Me.G.Controls.Add(Me.cmb_lang2)
        Me.G.Controls.Add(Me.cmb_study2)
        Me.G.Controls.Add(Me.DT_year)
        Me.G.Controls.Add(Me.chk_year)
        Me.G.Controls.Add(Me.txtFdate)
        Me.G.Controls.Add(Me.txtTdate)
        Me.G.Controls.Add(Me.Label2)
        Me.G.Controls.Add(Me.Button9)
        Me.G.Controls.Add(Me.chk_date)
        Me.G.Controls.Add(Me.chk_department)
        Me.G.Controls.Add(Me.chk_visa)
        Me.G.Controls.Add(Me.cmb_Department)
        Me.G.Controls.Add(Me.cmb_type_in)
        Me.G.Controls.Add(Me.chk_type_in)
        Me.G.Controls.Add(Me.Cmb_Sections)
        Me.G.Controls.Add(Me.chk_section)
        Me.G.Controls.Add(Me.cmb_visa2)
        Me.G.Location = New System.Drawing.Point(506, 101)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(746, 199)
        Me.G.TabIndex = 45833
        Me.G.TabStop = False
        Me.G.Text = "ຄັ້ນຫາ"
        Me.G.Visible = False
        '
        'txtstudy_id2
        '
        Me.txtstudy_id2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtstudy_id2.Enabled = False
        Me.txtstudy_id2.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudy_id2.Location = New System.Drawing.Point(130, 62)
        Me.txtstudy_id2.Name = "txtstudy_id2"
        Me.txtstudy_id2.Size = New System.Drawing.Size(40, 27)
        Me.txtstudy_id2.TabIndex = 45837
        Me.txtstudy_id2.Visible = False
        '
        'txtlang_id2
        '
        Me.txtlang_id2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtlang_id2.Enabled = False
        Me.txtlang_id2.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlang_id2.Location = New System.Drawing.Point(350, 167)
        Me.txtlang_id2.Name = "txtlang_id2"
        Me.txtlang_id2.Size = New System.Drawing.Size(40, 27)
        Me.txtlang_id2.TabIndex = 45847
        Me.txtlang_id2.Visible = False
        '
        'chk_study
        '
        Me.chk_study.AutoSize = True
        Me.chk_study.Location = New System.Drawing.Point(11, 62)
        Me.chk_study.Name = "chk_study"
        Me.chk_study.Size = New System.Drawing.Size(134, 28)
        Me.chk_study.TabIndex = 45827
        Me.chk_study.Text = "ລະດັບການສຶກສາ"
        Me.chk_study.UseVisualStyleBackColor = True
        '
        'txt_Nation_id2
        '
        Me.txt_Nation_id2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Nation_id2.Enabled = False
        Me.txt_Nation_id2.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nation_id2.Location = New System.Drawing.Point(130, 134)
        Me.txt_Nation_id2.Name = "txt_Nation_id2"
        Me.txt_Nation_id2.Size = New System.Drawing.Size(40, 27)
        Me.txt_Nation_id2.TabIndex = 45836
        Me.txt_Nation_id2.Visible = False
        '
        'txtvisa_id2
        '
        Me.txtvisa_id2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtvisa_id2.Enabled = False
        Me.txtvisa_id2.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvisa_id2.Location = New System.Drawing.Point(129, 99)
        Me.txtvisa_id2.Name = "txtvisa_id2"
        Me.txtvisa_id2.Size = New System.Drawing.Size(40, 27)
        Me.txtvisa_id2.TabIndex = 45835
        Me.txtvisa_id2.Visible = False
        '
        'cmb_Nation2
        '
        Me.cmb_Nation2.BackColor = System.Drawing.Color.White
        Me.cmb_Nation2.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_Nation2.FormattingEnabled = True
        Me.cmb_Nation2.Items.AddRange(New Object() {"ວິຊາການ"})
        Me.cmb_Nation2.Location = New System.Drawing.Point(176, 129)
        Me.cmb_Nation2.Name = "cmb_Nation2"
        Me.cmb_Nation2.Size = New System.Drawing.Size(164, 32)
        Me.cmb_Nation2.TabIndex = 45833
        '
        'chk_Nation
        '
        Me.chk_Nation.AutoSize = True
        Me.chk_Nation.Location = New System.Drawing.Point(11, 130)
        Me.chk_Nation.Name = "chk_Nation"
        Me.chk_Nation.Size = New System.Drawing.Size(124, 28)
        Me.chk_Nation.TabIndex = 45832
        Me.chk_Nation.Text = "ສຶກສາທີ່ປະເທດ"
        Me.chk_Nation.UseVisualStyleBackColor = True
        '
        'chk_lang2
        '
        Me.chk_lang2.AutoSize = True
        Me.chk_lang2.Location = New System.Drawing.Point(11, 163)
        Me.chk_lang2.Name = "chk_lang2"
        Me.chk_lang2.Size = New System.Drawing.Size(137, 28)
        Me.chk_lang2.TabIndex = 45831
        Me.chk_lang2.Text = "ພາສາຕ່າງປະເທດ"
        Me.chk_lang2.UseVisualStyleBackColor = True
        '
        'cmb_lang2
        '
        Me.cmb_lang2.BackColor = System.Drawing.Color.White
        Me.cmb_lang2.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_lang2.FormattingEnabled = True
        Me.cmb_lang2.Location = New System.Drawing.Point(175, 163)
        Me.cmb_lang2.Name = "cmb_lang2"
        Me.cmb_lang2.Size = New System.Drawing.Size(164, 32)
        Me.cmb_lang2.TabIndex = 45829
        '
        'cmb_study2
        '
        Me.cmb_study2.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_study2.FormattingEnabled = True
        Me.cmb_study2.Location = New System.Drawing.Point(175, 60)
        Me.cmb_study2.Name = "cmb_study2"
        Me.cmb_study2.Size = New System.Drawing.Size(165, 32)
        Me.cmb_study2.TabIndex = 45825
        '
        'DT_year
        '
        Me.DT_year.CustomFormat = "yyyy"
        Me.DT_year.Enabled = False
        Me.DT_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_year.Location = New System.Drawing.Point(419, 23)
        Me.DT_year.Name = "DT_year"
        Me.DT_year.ShowUpDown = True
        Me.DT_year.Size = New System.Drawing.Size(83, 35)
        Me.DT_year.TabIndex = 45823
        '
        'chk_year
        '
        Me.chk_year.AutoSize = True
        Me.chk_year.Location = New System.Drawing.Point(350, 28)
        Me.chk_year.Name = "chk_year"
        Me.chk_year.Size = New System.Drawing.Size(63, 28)
        Me.chk_year.TabIndex = 45824
        Me.chk_year.Text = "ຈົບປີ:"
        Me.chk_year.UseVisualStyleBackColor = True
        '
        'txtFdate
        '
        Me.txtFdate.CustomFormat = "dd/MM/yyyy"
        Me.txtFdate.Enabled = False
        Me.txtFdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFdate.Location = New System.Drawing.Point(90, 22)
        Me.txtFdate.Name = "txtFdate"
        Me.txtFdate.ShowUpDown = True
        Me.txtFdate.Size = New System.Drawing.Size(103, 35)
        Me.txtFdate.TabIndex = 106
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.Location = New System.Drawing.Point(11, 27)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(84, 28)
        Me.chk_date.TabIndex = 45651
        Me.chk_date.Text = "ວັນທີຈົບ:"
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(122, 232)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 24)
        Me.Label14.TabIndex = 45835
        Me.Label14.Text = "ຈົບປີ"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DT_Finish
        '
        Me.DT_Finish.CustomFormat = "yyyy"
        Me.DT_Finish.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_Finish.Location = New System.Drawing.Point(166, 227)
        Me.DT_Finish.Name = "DT_Finish"
        Me.DT_Finish.ShowUpDown = True
        Me.DT_Finish.Size = New System.Drawing.Size(75, 35)
        Me.DT_Finish.TabIndex = 45834
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(886, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(40, 27)
        Me.TextBox2.TabIndex = 45826
        Me.TextBox2.Visible = False
        '
        'txtremark
        '
        Me.txtremark.Location = New System.Drawing.Point(659, 123)
        Me.txtremark.Multiline = True
        Me.txtremark.Name = "txtremark"
        Me.txtremark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremark.Size = New System.Drawing.Size(473, 171)
        Me.txtremark.TabIndex = 45837
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(564, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 45836
        Me.Label3.Text = "ໜາຍເຫດ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(166, 96)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(132, 28)
        Me.RadioButton1.TabIndex = 45839
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ສາຍສາມັນສຶກສາ"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(304, 97)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(108, 28)
        Me.RadioButton2.TabIndex = 45840
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "ວິຊາສະເພາະ"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 24)
        Me.Label5.TabIndex = 45841
        Me.Label5.Text = "ຂະແໜ່ງວິຊາຮຽນ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 198)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 24)
        Me.Label6.TabIndex = 45842
        Me.Label6.Text = "ສຶກສາທີ່ປະເທດ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtlang_id
        '
        Me.txtlang_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtlang_id.Enabled = False
        Me.txtlang_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlang_id.Location = New System.Drawing.Point(419, 267)
        Me.txtlang_id.Name = "txtlang_id"
        Me.txtlang_id.Size = New System.Drawing.Size(40, 27)
        Me.txtlang_id.TabIndex = 45843
        Me.txtlang_id.Visible = False
        '
        'txtsamun
        '
        Me.txtsamun.Location = New System.Drawing.Point(83, 90)
        Me.txtsamun.Name = "txtsamun"
        Me.txtsamun.Size = New System.Drawing.Size(76, 35)
        Me.txtsamun.TabIndex = 45844
        Me.txtsamun.Visible = False
        '
        'txtsamun_id
        '
        Me.txtsamun_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsamun_id.Enabled = False
        Me.txtsamun_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsamun_id.Location = New System.Drawing.Point(37, 94)
        Me.txtsamun_id.Name = "txtsamun_id"
        Me.txtsamun_id.Size = New System.Drawing.Size(40, 27)
        Me.txtsamun_id.TabIndex = 45845
        Me.txtsamun_id.Visible = False
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button8.Location = New System.Drawing.Point(629, 164)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(42, 34)
        Me.Button8.TabIndex = 45834
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(515, 163)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(108, 35)
        Me.Button9.TabIndex = 45627
        Me.Button9.Text = "OK"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(378, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 47)
        Me.Button7.TabIndex = 45834
        Me.Button7.Text = "ຄົ້ນຫາ"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button6.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button6.Location = New System.Drawing.Point(345, 57)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(34, 34)
        Me.Button6.TabIndex = 45830
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(156, 3)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 47)
        Me.Button4.TabIndex = 45826
        Me.Button4.Text = "   ບັນທຶກ"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Badd
        '
        Me.Badd.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Badd.Image = CType(resources.GetObject("Badd.Image"), System.Drawing.Image)
        Me.Badd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Badd.Location = New System.Drawing.Point(44, 3)
        Me.Badd.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(112, 47)
        Me.Badd.TabIndex = 45825
        Me.Badd.Text = "   ເພີ່ມໃໝ່"
        Me.Badd.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.APInvioce.My.Resources.Resources.preview_f2
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(640, 6)
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
        Me.Button2.Location = New System.Drawing.Point(481, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 47)
        Me.Button2.TabIndex = 112
        Me.Button2.Text = "Refresh/Show all"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.Black
        Me.BtnDel.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.BtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDel.Location = New System.Drawing.Point(267, 4)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(112, 47)
        Me.BtnDel.TabIndex = 111
        Me.BtnDel.Text = "ລືບ"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button1.Location = New System.Drawing.Point(2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 46)
        Me.Button1.TabIndex = 108
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_Persion_Education
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1356, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtsamun_id)
        Me.Controls.Add(Me.txtsamun)
        Me.Controls.Add(Me.txtlang_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_no)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.txtremark)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DT_Finish)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtstudy_id)
        Me.Controls.Add(Me.TxtPersonNmL)
        Me.Controls.Add(Me.cmb_lang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_lang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button91)
        Me.Controls.Add(Me.Badd)
        Me.Controls.Add(Me.txt_Nation_id)
        Me.Controls.Add(Me.txt_type_in_id)
        Me.Controls.Add(Me.cmb_study)
        Me.Controls.Add(Me.cmb_visa)
        Me.Controls.Add(Me.txtvisa_id)
        Me.Controls.Add(Me.Label206)
        Me.Controls.Add(Me.txtSection_ID)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.cmb_Nation)
        Me.Controls.Add(Me.txtdepart_ID)
        Me.Controls.Add(Me.Fg1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Persion_Education"
        Me.Text = "Receipe Supplier list"
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.G.ResumeLayout(False)
        Me.G.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fg1 As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents txtvisa_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_visa As System.Windows.Forms.ComboBox
    Friend WithEvents txtSection_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtdepart_ID As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Department As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_Sections As System.Windows.Forms.ComboBox
    Friend WithEvents chk_department As System.Windows.Forms.CheckBox
    Friend WithEvents chk_section As System.Windows.Forms.CheckBox
    Friend WithEvents txt_type_in_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_type_in As System.Windows.Forms.ComboBox
    Friend WithEvents chk_type_in As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Badd As System.Windows.Forms.Button
    Friend WithEvents TxtPersonNmL As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtstudy_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_lang As System.Windows.Forms.ComboBox
    Friend WithEvents chk_lang As System.Windows.Forms.CheckBox
    Friend WithEvents chk_visa As System.Windows.Forms.CheckBox
    Friend WithEvents Button91 As System.Windows.Forms.Button
    Friend WithEvents txt_Nation_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_study As System.Windows.Forms.ComboBox
    Friend WithEvents Label206 As System.Windows.Forms.Label
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents cmb_visa2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Nation As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_no As System.Windows.Forms.TextBox
    Friend WithEvents G As System.Windows.Forms.GroupBox
    Friend WithEvents txtFdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_year As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_year As System.Windows.Forms.CheckBox
    Friend WithEvents chk_date As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DT_Finish As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_Nation2 As System.Windows.Forms.ComboBox
    Friend WithEvents chk_Nation As System.Windows.Forms.CheckBox
    Friend WithEvents chk_lang2 As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_lang2 As System.Windows.Forms.ComboBox
    Friend WithEvents chk_study As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_study2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txtvisa_id2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nation_id2 As System.Windows.Forms.TextBox
    Friend WithEvents txtstudy_id2 As System.Windows.Forms.TextBox
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtlang_id As System.Windows.Forms.TextBox
    Friend WithEvents txtsamun As System.Windows.Forms.TextBox
    Friend WithEvents txtsamun_id As System.Windows.Forms.TextBox
    Friend WithEvents txtlang_id2 As System.Windows.Forms.TextBox
End Class
