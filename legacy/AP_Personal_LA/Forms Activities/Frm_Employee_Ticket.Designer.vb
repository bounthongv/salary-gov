<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Employee_Ticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Employee_Ticket))
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSection_ID = New System.Windows.Forms.TextBox
        Me.txtdepart_ID = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtid = New System.Windows.Forms.TextBox
        Me.cmb_Department = New System.Windows.Forms.ComboBox
        Me.Cmb_Sections = New System.Windows.Forms.ComboBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtremark = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.DT_year = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_no = New System.Windows.Forms.TextBox
        Me.TxtPersonNmE = New System.Windows.Forms.TextBox
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.Label204 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtabount = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtPersonNmL = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Bclos = New System.Windows.Forms.Button
        Me.Badd = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTecket_year = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTecket_use = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.FG = New AxVSFlex8U.AxVSFlexGrid
        Me.Button61 = New System.Windows.Forms.Button
        Me.Button62 = New System.Windows.Forms.Button
        CType(Me.FG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(30, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 45751
        Me.Label2.Tag = "2001"
        Me.Label2.Text = "ລະຫັດພະນັກງານ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSection_ID
        '
        Me.txtSection_ID.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection_ID.Location = New System.Drawing.Point(515, 84)
        Me.txtSection_ID.Name = "txtSection_ID"
        Me.txtSection_ID.Size = New System.Drawing.Size(43, 30)
        Me.txtSection_ID.TabIndex = 45744
        Me.txtSection_ID.Visible = False
        '
        'txtdepart_ID
        '
        Me.txtdepart_ID.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepart_ID.Location = New System.Drawing.Point(514, 118)
        Me.txtdepart_ID.Name = "txtdepart_ID"
        Me.txtdepart_ID.Size = New System.Drawing.Size(46, 30)
        Me.txtdepart_ID.TabIndex = 45743
        Me.txtdepart_ID.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(32, 90)
        Me.Label27.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(105, 24)
        Me.Label27.TabIndex = 45749
        Me.Label27.Text = "ບ່ອນປະຈຳການ"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 45739
        Me.Label1.Text = "ພະແນກ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(147, 155)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(205, 35)
        Me.txtid.TabIndex = 45750
        '
        'cmb_Department
        '
        Me.cmb_Department.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Department.FormattingEnabled = True
        Me.cmb_Department.Location = New System.Drawing.Point(147, 120)
        Me.cmb_Department.Name = "cmb_Department"
        Me.cmb_Department.Size = New System.Drawing.Size(364, 32)
        Me.cmb_Department.TabIndex = 45738
        '
        'Cmb_Sections
        '
        Me.Cmb_Sections.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Sections.FormattingEnabled = True
        Me.Cmb_Sections.Location = New System.Drawing.Point(147, 87)
        Me.Cmb_Sections.Name = "Cmb_Sections"
        Me.Cmb_Sections.Size = New System.Drawing.Size(364, 32)
        Me.Cmb_Sections.TabIndex = 45737
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(563, 50)
        Me.Label38.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(83, 24)
        Me.Label38.TabIndex = 149
        Me.Label38.Text = "ລາຍລະອຽດ"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtremark
        '
        Me.txtremark.BackColor = System.Drawing.Color.White
        Me.txtremark.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremark.ForeColor = System.Drawing.Color.Black
        Me.txtremark.Location = New System.Drawing.Point(566, 219)
        Me.txtremark.Multiline = True
        Me.txtremark.Name = "txtremark"
        Me.txtremark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremark.Size = New System.Drawing.Size(594, 77)
        Me.txtremark.TabIndex = 45746
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(562, 192)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 24)
        Me.Label17.TabIndex = 45745
        Me.Label17.Text = "ໝາຍເຫດ"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(332, 54)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 24)
        Me.Label14.TabIndex = 45764
        Me.Label14.Text = "ປະຈຳປີ"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DT_year
        '
        Me.DT_year.CustomFormat = "dd/MM/yyyy"
        Me.DT_year.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_year.Location = New System.Drawing.Point(393, 49)
        Me.DT_year.Name = "DT_year"
        Me.DT_year.ShowUpDown = True
        Me.DT_year.Size = New System.Drawing.Size(116, 35)
        Me.DT_year.TabIndex = 45763
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(24, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 24)
        Me.Label16.TabIndex = 45766
        Me.Label16.Tag = "2001"
        Me.Label16.Text = "ເລກທີໃບເບີກຈ່າຍ"
        '
        'txt_no
        '
        Me.txt_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_no.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no.Location = New System.Drawing.Point(147, 50)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(180, 35)
        Me.txt_no.TabIndex = 45765
        '
        'TxtPersonNmE
        '
        Me.TxtPersonNmE.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPersonNmE.Location = New System.Drawing.Point(147, 226)
        Me.TxtPersonNmE.Name = "TxtPersonNmE"
        Me.TxtPersonNmE.Size = New System.Drawing.Size(363, 35)
        Me.TxtPersonNmE.TabIndex = 45775
        '
        'TxtTel
        '
        Me.TxtTel.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(147, 261)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(363, 35)
        Me.TxtTel.TabIndex = 45776
        '
        'Label204
        '
        Me.Label204.AutoSize = True
        Me.Label204.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label204.Location = New System.Drawing.Point(59, 267)
        Me.Label204.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label204.Name = "Label204"
        Me.Label204.Size = New System.Drawing.Size(85, 24)
        Me.Label204.TabIndex = 45772
        Me.Label204.Text = "ເບີໂທລະສັບ"
        Me.Label204.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 234)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 45770
        Me.Label5.Text = "ຊື່ (ພາສາອັງກິດ)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtabount
        '
        Me.txtabount.BackColor = System.Drawing.Color.White
        Me.txtabount.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtabount.ForeColor = System.Drawing.Color.Black
        Me.txtabount.Location = New System.Drawing.Point(566, 79)
        Me.txtabount.Multiline = True
        Me.txtabount.Name = "txtabount"
        Me.txtabount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtabount.Size = New System.Drawing.Size(595, 111)
        Me.txtabount.TabIndex = 45783
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 24)
        Me.Label4.TabIndex = 45769
        Me.Label4.Text = "ຊື່ ແລະ ນາມສະກຸນ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPersonNmL
        '
        Me.TxtPersonNmL.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPersonNmL.Location = New System.Drawing.Point(146, 191)
        Me.TxtPersonNmL.Name = "TxtPersonNmL"
        Me.TxtPersonNmL.Size = New System.Drawing.Size(364, 35)
        Me.TxtPersonNmL.TabIndex = 45774
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button1.Location = New System.Drawing.Point(354, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 34)
        Me.Button1.TabIndex = 45752
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(169, 3)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 41)
        Me.Button2.TabIndex = 95
        Me.Button2.Text = "   ບັນທຶກ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Bclos
        '
        Me.Bclos.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bclos.Image = CType(resources.GetObject("Bclos.Image"), System.Drawing.Image)
        Me.Bclos.Location = New System.Drawing.Point(8, 3)
        Me.Bclos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Bclos.Name = "Bclos"
        Me.Bclos.Size = New System.Drawing.Size(47, 40)
        Me.Bclos.TabIndex = 93
        Me.Bclos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bclos.UseVisualStyleBackColor = True
        '
        'Badd
        '
        Me.Badd.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Badd.Image = CType(resources.GetObject("Badd.Image"), System.Drawing.Image)
        Me.Badd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Badd.Location = New System.Drawing.Point(57, 2)
        Me.Badd.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(112, 41)
        Me.Badd.TabIndex = 94
        Me.Badd.Text = "   ເພີ່ມໃໝ່"
        Me.Badd.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Saysettha OT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(300, -11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(686, 66)
        Me.Label15.TabIndex = 45784
        Me.Label15.Text = "ປີ້ນະໂຍບາຍຂອງພະນັກງານ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTecket_year
        '
        Me.txtTecket_year.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTecket_year.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTecket_year.Location = New System.Drawing.Point(761, 113)
        Me.txtTecket_year.Name = "txtTecket_year"
        Me.txtTecket_year.Size = New System.Drawing.Size(120, 35)
        Me.txtTecket_year.TabIndex = 45786
        Me.txtTecket_year.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(618, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 24)
        Me.Label3.TabIndex = 45785
        Me.Label3.Text = "ຈຳນວນປີ້ນະໂຍບາຍ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'txtTecket_use
        '
        Me.txtTecket_use.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTecket_use.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTecket_use.Location = New System.Drawing.Point(1000, 113)
        Me.txtTecket_use.Name = "txtTecket_use"
        Me.txtTecket_use.Size = New System.Drawing.Size(125, 35)
        Me.txtTecket_use.TabIndex = 45788
        Me.txtTecket_use.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(886, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 45787
        Me.Label6.Text = "ຈຳນວນປີ້ໄດ້ຮັບ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'FG
        '
        Me.FG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FG.DataSource = Nothing
        Me.FG.Location = New System.Drawing.Point(146, 302)
        Me.FG.Name = "FG"
        Me.FG.OcxState = CType(resources.GetObject("FG.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FG.Size = New System.Drawing.Size(1014, 192)
        Me.FG.TabIndex = 45789
        '
        'Button61
        '
        Me.Button61.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button61.Image = CType(resources.GetObject("Button61.Image"), System.Drawing.Image)
        Me.Button61.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button61.Location = New System.Drawing.Point(61, 343)
        Me.Button61.Name = "Button61"
        Me.Button61.Size = New System.Drawing.Size(82, 38)
        Me.Button61.TabIndex = 45859
        Me.Button61.Tag = "3006"
        Me.Button61.Text = "ລືບແຖວ"
        Me.Button61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button61.UseVisualStyleBackColor = True
        '
        'Button62
        '
        Me.Button62.BackgroundImage = CType(resources.GetObject("Button62.BackgroundImage"), System.Drawing.Image)
        Me.Button62.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button62.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button62.ForeColor = System.Drawing.Color.Black
        Me.Button62.Location = New System.Drawing.Point(61, 302)
        Me.Button62.Name = "Button62"
        Me.Button62.Size = New System.Drawing.Size(82, 37)
        Me.Button62.TabIndex = 45860
        Me.Button62.Tag = "3003"
        Me.Button62.Text = "ເພີ່ມແຖວ"
        Me.Button62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button62.UseVisualStyleBackColor = True
        '
        'Frm_Employee_Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1165, 571)
        Me.Controls.Add(Me.txtabount)
        Me.Controls.Add(Me.Button61)
        Me.Controls.Add(Me.Button62)
        Me.Controls.Add(Me.FG)
        Me.Controls.Add(Me.txtTecket_use)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTecket_year)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPersonNmE)
        Me.Controls.Add(Me.TxtPersonNmL)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.txtremark)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label204)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_no)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DT_year)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txtSection_ID)
        Me.Controls.Add(Me.txtdepart_ID)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.cmb_Department)
        Me.Controls.Add(Me.Cmb_Sections)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Bclos)
        Me.Controls.Add(Me.Badd)
        Me.Controls.Add(Me.Label15)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Employee_Ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Uplevel"
        CType(Me.FG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Bclos As System.Windows.Forms.Button
    Friend WithEvents Badd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSection_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtdepart_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Department As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_Sections As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DT_year As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_no As System.Windows.Forms.TextBox
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtPersonNmE As System.Windows.Forms.TextBox
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label204 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtabount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPersonNmL As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTecket_year As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTecket_use As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FG As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Button61 As System.Windows.Forms.Button
    Friend WithEvents Button62 As System.Windows.Forms.Button
End Class
