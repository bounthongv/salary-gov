<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Position_work
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Position_work))
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTdate = New System.Windows.Forms.DateTimePicker
        Me.Fg1 = New AxVSFlex8U.AxVSFlexGrid
        Me.Label15 = New System.Windows.Forms.Label
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_job_phuk_id = New System.Windows.Forms.TextBox
        Me.chk_Job_Phuk = New System.Windows.Forms.CheckBox
        Me.cmb_job_phuk = New System.Windows.Forms.ComboBox
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
        Me.Button4 = New System.Windows.Forms.Button
        Me.Badd = New System.Windows.Forms.Button
        Me.TxtPersonNmL = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.txt_duties_id = New System.Windows.Forms.TextBox
        Me.cmb_job_lut_visakan = New System.Windows.Forms.ComboBox
        Me.chk_job_lut_visakan = New System.Windows.Forms.CheckBox
        Me.chk_job_lut = New System.Windows.Forms.CheckBox
        Me.chk_Job_Phuk2 = New System.Windows.Forms.CheckBox
        Me.Button91 = New System.Windows.Forms.Button
        Me.txt_job_lut_id = New System.Windows.Forms.TextBox
        Me.cmb_duties = New System.Windows.Forms.ComboBox
        Me.Label206 = New System.Windows.Forms.Label
        Me.Button15 = New System.Windows.Forms.Button
        Me.cmb_job_phuk2 = New System.Windows.Forms.ComboBox
        Me.cmb_job_lut = New System.Windows.Forms.ComboBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_no = New System.Windows.Forms.TextBox
        Me.G = New System.Windows.Forms.GroupBox
        Me.chk_duties = New System.Windows.Forms.CheckBox
        Me.txt_duties_id2 = New System.Windows.Forms.TextBox
        Me.txt_job_lut_id2 = New System.Windows.Forms.TextBox
        Me.txt_job_phuk_id2 = New System.Windows.Forms.TextBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.cmb_job_lut_visakan2 = New System.Windows.Forms.ComboBox
        Me.chk_job_lut_visakan2 = New System.Windows.Forms.CheckBox
        Me.chk_job_lut2 = New System.Windows.Forms.CheckBox
        Me.cmb_job_lut2 = New System.Windows.Forms.ComboBox
        Me.cmb_duties2 = New System.Windows.Forms.ComboBox
        Me.DT_year = New System.Windows.Forms.DateTimePicker
        Me.chk_year = New System.Windows.Forms.CheckBox
        Me.txtFdate = New System.Windows.Forms.DateTimePicker
        Me.chk_date = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.DT_up = New System.Windows.Forms.DateTimePicker
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.txtremark = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.Label15.Location = New System.Drawing.Point(787, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(182, 46)
        Me.Label15.TabIndex = 311
        Me.Label15.Text = "ໜ້າທີ່ຕຳແໜ່ງ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(11, 199)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(108, 35)
        Me.Button9.TabIndex = 45627
        Me.Button9.Text = "OK"
        Me.Button9.UseVisualStyleBackColor = True
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
        'txt_job_phuk_id
        '
        Me.txt_job_phuk_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_job_phuk_id.Enabled = False
        Me.txt_job_phuk_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job_phuk_id.Location = New System.Drawing.Point(563, 204)
        Me.txt_job_phuk_id.Name = "txt_job_phuk_id"
        Me.txt_job_phuk_id.Size = New System.Drawing.Size(40, 27)
        Me.txt_job_phuk_id.TabIndex = 45818
        Me.txt_job_phuk_id.Visible = False
        '
        'chk_Job_Phuk
        '
        Me.chk_Job_Phuk.AutoSize = True
        Me.chk_Job_Phuk.Location = New System.Drawing.Point(50, 204)
        Me.chk_Job_Phuk.Name = "chk_Job_Phuk"
        Me.chk_Job_Phuk.Size = New System.Drawing.Size(100, 28)
        Me.chk_Job_Phuk.TabIndex = 45817
        Me.chk_Job_Phuk.Text = "ຕຳແໜ່ງພັກ"
        Me.chk_Job_Phuk.UseVisualStyleBackColor = True
        '
        'cmb_job_phuk
        '
        Me.cmb_job_phuk.BackColor = System.Drawing.Color.White
        Me.cmb_job_phuk.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_phuk.FormattingEnabled = True
        Me.cmb_job_phuk.Location = New System.Drawing.Point(219, 198)
        Me.cmb_job_phuk.Name = "cmb_job_phuk"
        Me.cmb_job_phuk.Size = New System.Drawing.Size(299, 32)
        Me.cmb_job_phuk.TabIndex = 45816
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
        Me.chk_department.Location = New System.Drawing.Point(352, 128)
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
        Me.Label1.Location = New System.Drawing.Point(97, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 45828
        Me.Label1.Tag = "2001"
        Me.Label1.Text = "ລະຫັດພະນັກງານ"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 128)
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
        Me.txtid.Location = New System.Drawing.Point(219, 88)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(174, 34)
        Me.txtid.TabIndex = 45827
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
        'TxtPersonNmL
        '
        Me.TxtPersonNmL.Location = New System.Drawing.Point(219, 125)
        Me.TxtPersonNmL.Name = "TxtPersonNmL"
        Me.TxtPersonNmL.Size = New System.Drawing.Size(299, 35)
        Me.TxtPersonNmL.TabIndex = 45829
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(521, 166)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(41, 29)
        Me.Button5.TabIndex = 111
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_duties_id
        '
        Me.txt_duties_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_duties_id.Enabled = False
        Me.txt_duties_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_duties_id.Location = New System.Drawing.Point(564, 166)
        Me.txt_duties_id.Name = "txt_duties_id"
        Me.txt_duties_id.Size = New System.Drawing.Size(40, 27)
        Me.txt_duties_id.TabIndex = 110
        Me.txt_duties_id.Visible = False
        '
        'cmb_job_lut_visakan
        '
        Me.cmb_job_lut_visakan.BackColor = System.Drawing.Color.White
        Me.cmb_job_lut_visakan.Enabled = False
        Me.cmb_job_lut_visakan.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_lut_visakan.FormattingEnabled = True
        Me.cmb_job_lut_visakan.Items.AddRange(New Object() {"ວິຊາການ"})
        Me.cmb_job_lut_visakan.Location = New System.Drawing.Point(219, 267)
        Me.cmb_job_lut_visakan.Name = "cmb_job_lut_visakan"
        Me.cmb_job_lut_visakan.Size = New System.Drawing.Size(299, 32)
        Me.cmb_job_lut_visakan.TabIndex = 109
        '
        'chk_job_lut_visakan
        '
        Me.chk_job_lut_visakan.AutoSize = True
        Me.chk_job_lut_visakan.Location = New System.Drawing.Point(49, 267)
        Me.chk_job_lut_visakan.Name = "chk_job_lut_visakan"
        Me.chk_job_lut_visakan.Size = New System.Drawing.Size(164, 28)
        Me.chk_job_lut_visakan.TabIndex = 108
        Me.chk_job_lut_visakan.Text = "ຕຳແໜ່ງລັດ ວິຊາການ"
        Me.chk_job_lut_visakan.UseVisualStyleBackColor = True
        '
        'chk_job_lut
        '
        Me.chk_job_lut.AutoSize = True
        Me.chk_job_lut.Location = New System.Drawing.Point(50, 237)
        Me.chk_job_lut.Name = "chk_job_lut"
        Me.chk_job_lut.Size = New System.Drawing.Size(158, 28)
        Me.chk_job_lut.TabIndex = 107
        Me.chk_job_lut.Text = "ຕຳແໜ່ງລັດ ບໍລິຫານ"
        Me.chk_job_lut.UseVisualStyleBackColor = True
        '
        'chk_Job_Phuk2
        '
        Me.chk_Job_Phuk2.AutoSize = True
        Me.chk_Job_Phuk2.Location = New System.Drawing.Point(11, 97)
        Me.chk_Job_Phuk2.Name = "chk_Job_Phuk2"
        Me.chk_Job_Phuk2.Size = New System.Drawing.Size(100, 28)
        Me.chk_Job_Phuk2.TabIndex = 106
        Me.chk_Job_Phuk2.Text = "ຕຳແໜ່ງພັກ"
        Me.chk_Job_Phuk2.UseVisualStyleBackColor = True
        '
        'Button91
        '
        Me.Button91.Enabled = False
        Me.Button91.ForeColor = System.Drawing.Color.Black
        Me.Button91.Location = New System.Drawing.Point(522, 236)
        Me.Button91.Name = "Button91"
        Me.Button91.Size = New System.Drawing.Size(41, 29)
        Me.Button91.TabIndex = 98
        Me.Button91.Text = "..."
        Me.Button91.UseVisualStyleBackColor = True
        '
        'txt_job_lut_id
        '
        Me.txt_job_lut_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_job_lut_id.Enabled = False
        Me.txt_job_lut_id.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job_lut_id.Location = New System.Drawing.Point(564, 236)
        Me.txt_job_lut_id.Name = "txt_job_lut_id"
        Me.txt_job_lut_id.Size = New System.Drawing.Size(40, 27)
        Me.txt_job_lut_id.TabIndex = 91
        Me.txt_job_lut_id.Visible = False
        '
        'cmb_duties
        '
        Me.cmb_duties.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_duties.FormattingEnabled = True
        Me.cmb_duties.Location = New System.Drawing.Point(219, 163)
        Me.cmb_duties.Name = "cmb_duties"
        Me.cmb_duties.Size = New System.Drawing.Size(299, 32)
        Me.cmb_duties.TabIndex = 93
        '
        'Label206
        '
        Me.Label206.AutoSize = True
        Me.Label206.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label206.Location = New System.Drawing.Point(-5, 169)
        Me.Label206.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label206.Name = "Label206"
        Me.Label206.Size = New System.Drawing.Size(213, 24)
        Me.Label206.TabIndex = 92
        Me.Label206.Text = "ໜ້າທີ່ຮັບຜິດຊອບລົງເລິກ ວຽກງານ"
        Me.Label206.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button15
        '
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Location = New System.Drawing.Point(522, 204)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(41, 29)
        Me.Button15.TabIndex = 87
        Me.Button15.Text = "..."
        Me.Button15.UseVisualStyleBackColor = True
        '
        'cmb_job_phuk2
        '
        Me.cmb_job_phuk2.BackColor = System.Drawing.Color.White
        Me.cmb_job_phuk2.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_phuk2.FormattingEnabled = True
        Me.cmb_job_phuk2.Location = New System.Drawing.Point(175, 95)
        Me.cmb_job_phuk2.Name = "cmb_job_phuk2"
        Me.cmb_job_phuk2.Size = New System.Drawing.Size(164, 32)
        Me.cmb_job_phuk2.TabIndex = 46
        '
        'cmb_job_lut
        '
        Me.cmb_job_lut.BackColor = System.Drawing.Color.White
        Me.cmb_job_lut.Enabled = False
        Me.cmb_job_lut.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_lut.FormattingEnabled = True
        Me.cmb_job_lut.Location = New System.Drawing.Point(219, 233)
        Me.cmb_job_lut.Name = "cmb_job_lut"
        Me.cmb_job_lut.Size = New System.Drawing.Size(299, 32)
        Me.cmb_job_lut.TabIndex = 48
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button6.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button6.Location = New System.Drawing.Point(398, 89)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(34, 34)
        Me.Button6.TabIndex = 45830
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(984, 17)
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
        Me.txt_no.Location = New System.Drawing.Point(1041, 12)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(97, 34)
        Me.txt_no.TabIndex = 45831
        Me.txt_no.Visible = False
        '
        'G
        '
        Me.G.Controls.Add(Me.chk_duties)
        Me.G.Controls.Add(Me.txt_duties_id2)
        Me.G.Controls.Add(Me.txt_job_lut_id2)
        Me.G.Controls.Add(Me.txt_job_phuk_id2)
        Me.G.Controls.Add(Me.Button8)
        Me.G.Controls.Add(Me.cmb_job_lut_visakan2)
        Me.G.Controls.Add(Me.chk_job_lut_visakan2)
        Me.G.Controls.Add(Me.chk_job_lut2)
        Me.G.Controls.Add(Me.cmb_job_lut2)
        Me.G.Controls.Add(Me.cmb_duties2)
        Me.G.Controls.Add(Me.DT_year)
        Me.G.Controls.Add(Me.chk_year)
        Me.G.Controls.Add(Me.txtFdate)
        Me.G.Controls.Add(Me.txtTdate)
        Me.G.Controls.Add(Me.Label2)
        Me.G.Controls.Add(Me.Button9)
        Me.G.Controls.Add(Me.chk_date)
        Me.G.Controls.Add(Me.chk_department)
        Me.G.Controls.Add(Me.chk_Job_Phuk2)
        Me.G.Controls.Add(Me.cmb_Department)
        Me.G.Controls.Add(Me.cmb_type_in)
        Me.G.Controls.Add(Me.chk_type_in)
        Me.G.Controls.Add(Me.Cmb_Sections)
        Me.G.Controls.Add(Me.chk_section)
        Me.G.Controls.Add(Me.cmb_job_phuk2)
        Me.G.Location = New System.Drawing.Point(582, 62)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(746, 237)
        Me.G.TabIndex = 45833
        Me.G.TabStop = False
        Me.G.Text = "ຄັ້ນຫາ"
        Me.G.Visible = False
        '
        'chk_duties
        '
        Me.chk_duties.AutoSize = True
        Me.chk_duties.Location = New System.Drawing.Point(11, 62)
        Me.chk_duties.Name = "chk_duties"
        Me.chk_duties.Size = New System.Drawing.Size(133, 28)
        Me.chk_duties.TabIndex = 45827
        Me.chk_duties.Text = "ໜ້າທີ່ຮັບຜິດຊອບ"
        Me.chk_duties.UseVisualStyleBackColor = True
        '
        'txt_duties_id2
        '
        Me.txt_duties_id2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_duties_id2.Enabled = False
        Me.txt_duties_id2.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_duties_id2.Location = New System.Drawing.Point(134, 62)
        Me.txt_duties_id2.Name = "txt_duties_id2"
        Me.txt_duties_id2.Size = New System.Drawing.Size(40, 27)
        Me.txt_duties_id2.TabIndex = 45837
        Me.txt_duties_id2.Visible = False
        '
        'txt_job_lut_id2
        '
        Me.txt_job_lut_id2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_job_lut_id2.Enabled = False
        Me.txt_job_lut_id2.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job_lut_id2.Location = New System.Drawing.Point(175, 205)
        Me.txt_job_lut_id2.Name = "txt_job_lut_id2"
        Me.txt_job_lut_id2.Size = New System.Drawing.Size(40, 27)
        Me.txt_job_lut_id2.TabIndex = 45836
        Me.txt_job_lut_id2.Visible = False
        '
        'txt_job_phuk_id2
        '
        Me.txt_job_phuk_id2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_job_phuk_id2.Enabled = False
        Me.txt_job_phuk_id2.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job_phuk_id2.Location = New System.Drawing.Point(125, 100)
        Me.txt_job_phuk_id2.Name = "txt_job_phuk_id2"
        Me.txt_job_phuk_id2.Size = New System.Drawing.Size(40, 27)
        Me.txt_job_phuk_id2.TabIndex = 45835
        Me.txt_job_phuk_id2.Visible = False
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button8.Location = New System.Drawing.Point(125, 200)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(42, 34)
        Me.Button8.TabIndex = 45834
        Me.Button8.UseVisualStyleBackColor = True
        '
        'cmb_job_lut_visakan2
        '
        Me.cmb_job_lut_visakan2.BackColor = System.Drawing.Color.White
        Me.cmb_job_lut_visakan2.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_lut_visakan2.FormattingEnabled = True
        Me.cmb_job_lut_visakan2.Items.AddRange(New Object() {"ວິຊາການ"})
        Me.cmb_job_lut_visakan2.Location = New System.Drawing.Point(175, 164)
        Me.cmb_job_lut_visakan2.Name = "cmb_job_lut_visakan2"
        Me.cmb_job_lut_visakan2.Size = New System.Drawing.Size(164, 32)
        Me.cmb_job_lut_visakan2.TabIndex = 45833
        '
        'chk_job_lut_visakan2
        '
        Me.chk_job_lut_visakan2.AutoSize = True
        Me.chk_job_lut_visakan2.Location = New System.Drawing.Point(10, 165)
        Me.chk_job_lut_visakan2.Name = "chk_job_lut_visakan2"
        Me.chk_job_lut_visakan2.Size = New System.Drawing.Size(164, 28)
        Me.chk_job_lut_visakan2.TabIndex = 45832
        Me.chk_job_lut_visakan2.Text = "ຕຳແໜ່ງລັດ ວິຊາການ"
        Me.chk_job_lut_visakan2.UseVisualStyleBackColor = True
        '
        'chk_job_lut2
        '
        Me.chk_job_lut2.AutoSize = True
        Me.chk_job_lut2.Location = New System.Drawing.Point(11, 129)
        Me.chk_job_lut2.Name = "chk_job_lut2"
        Me.chk_job_lut2.Size = New System.Drawing.Size(158, 28)
        Me.chk_job_lut2.TabIndex = 45831
        Me.chk_job_lut2.Text = "ຕຳແໜ່ງລັດ ບໍລິຫານ"
        Me.chk_job_lut2.UseVisualStyleBackColor = True
        '
        'cmb_job_lut2
        '
        Me.cmb_job_lut2.BackColor = System.Drawing.Color.White
        Me.cmb_job_lut2.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_job_lut2.FormattingEnabled = True
        Me.cmb_job_lut2.Location = New System.Drawing.Point(175, 129)
        Me.cmb_job_lut2.Name = "cmb_job_lut2"
        Me.cmb_job_lut2.Size = New System.Drawing.Size(164, 32)
        Me.cmb_job_lut2.TabIndex = 45829
        '
        'cmb_duties2
        '
        Me.cmb_duties2.Font = New System.Drawing.Font("Saysettha OT", 11.25!)
        Me.cmb_duties2.FormattingEnabled = True
        Me.cmb_duties2.Location = New System.Drawing.Point(175, 60)
        Me.cmb_duties2.Name = "cmb_duties2"
        Me.cmb_duties2.Size = New System.Drawing.Size(165, 32)
        Me.cmb_duties2.TabIndex = 45825
        '
        'DT_year
        '
        Me.DT_year.CustomFormat = "yyyy"
        Me.DT_year.Enabled = False
        Me.DT_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_year.Location = New System.Drawing.Point(426, 23)
        Me.DT_year.Name = "DT_year"
        Me.DT_year.ShowUpDown = True
        Me.DT_year.Size = New System.Drawing.Size(83, 35)
        Me.DT_year.TabIndex = 45823
        '
        'chk_year
        '
        Me.chk_year.AutoSize = True
        Me.chk_year.Location = New System.Drawing.Point(352, 26)
        Me.chk_year.Name = "chk_year"
        Me.chk_year.Size = New System.Drawing.Size(68, 28)
        Me.chk_year.TabIndex = 45824
        Me.chk_year.Text = "ໝົດປີ:"
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
        Me.chk_date.Location = New System.Drawing.Point(11, 29)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(64, 28)
        Me.chk_date.TabIndex = 45651
        Me.chk_date.Text = "ວັນທີ:"
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(168, 55)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 24)
        Me.Label14.TabIndex = 45835
        Me.Label14.Text = "ວັນທີ"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DT_up
        '
        Me.DT_up.CustomFormat = "dd/MM/yyyy"
        Me.DT_up.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_up.Location = New System.Drawing.Point(219, 52)
        Me.DT_up.Name = "DT_up"
        Me.DT_up.ShowUpDown = True
        Me.DT_up.Size = New System.Drawing.Size(105, 35)
        Me.DT_up.TabIndex = 45834
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
        'txtremark
        '
        Me.txtremark.Location = New System.Drawing.Point(770, 117)
        Me.txtremark.Multiline = True
        Me.txtremark.Name = "txtremark"
        Me.txtremark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremark.Size = New System.Drawing.Size(473, 182)
        Me.txtremark.TabIndex = 45837
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(619, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 24)
        Me.Label3.TabIndex = 45836
        Me.Label3.Text = "ໜາຍເຫດ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_Position_work
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1356, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.txtremark)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DT_up)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_no)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txt_duties_id)
        Me.Controls.Add(Me.TxtPersonNmL)
        Me.Controls.Add(Me.cmb_job_lut_visakan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_job_lut_visakan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chk_job_lut)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button91)
        Me.Controls.Add(Me.Badd)
        Me.Controls.Add(Me.txt_job_lut_id)
        Me.Controls.Add(Me.txt_type_in_id)
        Me.Controls.Add(Me.cmb_duties)
        Me.Controls.Add(Me.cmb_job_phuk)
        Me.Controls.Add(Me.txt_job_phuk_id)
        Me.Controls.Add(Me.chk_Job_Phuk)
        Me.Controls.Add(Me.Label206)
        Me.Controls.Add(Me.txtSection_ID)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.cmb_job_lut)
        Me.Controls.Add(Me.txtdepart_ID)
        Me.Controls.Add(Me.Fg1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Position_work"
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
    Friend WithEvents txt_job_phuk_id As System.Windows.Forms.TextBox
    Friend WithEvents chk_Job_Phuk As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_job_phuk As System.Windows.Forms.ComboBox
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
    Friend WithEvents txt_duties_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_job_lut_visakan As System.Windows.Forms.ComboBox
    Friend WithEvents chk_job_lut_visakan As System.Windows.Forms.CheckBox
    Friend WithEvents chk_job_lut As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Job_Phuk2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button91 As System.Windows.Forms.Button
    Friend WithEvents txt_job_lut_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_duties As System.Windows.Forms.ComboBox
    Friend WithEvents Label206 As System.Windows.Forms.Label
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents cmb_job_phuk2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_job_lut As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_no As System.Windows.Forms.TextBox
    Friend WithEvents G As System.Windows.Forms.GroupBox
    Friend WithEvents txtFdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_year As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_year As System.Windows.Forms.CheckBox
    Friend WithEvents chk_date As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DT_up As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_job_lut_visakan2 As System.Windows.Forms.ComboBox
    Friend WithEvents chk_job_lut_visakan2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_job_lut2 As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_job_lut2 As System.Windows.Forms.ComboBox
    Friend WithEvents chk_duties As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_duties2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txt_job_phuk_id2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_job_lut_id2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_duties_id2 As System.Windows.Forms.TextBox
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
