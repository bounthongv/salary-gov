<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Book_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Book_List))
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFdate = New System.Windows.Forms.DateTimePicker
        Me.txtIn_no = New System.Windows.Forms.TextBox
        Me.txtTdate = New System.Windows.Forms.DateTimePicker
        Me.Fg1 = New AxVSFlex8U.AxVSFlexGrid
        Me.Fg2 = New AxVSFlex8U.AxVSFlexGrid
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button4 = New System.Windows.Forms.Button
        Me.LbTotal = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.lblpage_total = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_Hder = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtPV_NM = New System.Windows.Forms.ComboBox
        Me.TxtDt_Nm = New System.Windows.Forms.ComboBox
        Me.txtVillage_nm = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtProvince = New System.Windows.Forms.RichTextBox
        Me.txtVillage = New System.Windows.Forms.RichTextBox
        Me.txtDistrict = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBK_no = New System.Windows.Forms.TextBox
        Me.txtbarcode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Dad_Name = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_Mobail1 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_Mobail2 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtmom_name = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 24)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "ເຖິງ:"
        '
        'txtFdate
        '
        Me.txtFdate.CustomFormat = "dd/MM/yyyy"
        Me.txtFdate.Enabled = False
        Me.txtFdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFdate.Location = New System.Drawing.Point(62, 50)
        Me.txtFdate.Name = "txtFdate"
        Me.txtFdate.ShowUpDown = True
        Me.txtFdate.Size = New System.Drawing.Size(105, 35)
        Me.txtFdate.TabIndex = 103
        Me.txtFdate.Value = New Date(2009, 12, 29, 0, 0, 0, 0)
        '
        'txtIn_no
        '
        Me.txtIn_no.Location = New System.Drawing.Point(1122, 127)
        Me.txtIn_no.Name = "txtIn_no"
        Me.txtIn_no.Size = New System.Drawing.Size(173, 35)
        Me.txtIn_no.TabIndex = 104
        Me.txtIn_no.Visible = False
        '
        'txtTdate
        '
        Me.txtTdate.CustomFormat = "dd/MM/yyyy"
        Me.txtTdate.Enabled = False
        Me.txtTdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTdate.Location = New System.Drawing.Point(208, 53)
        Me.txtTdate.Name = "txtTdate"
        Me.txtTdate.ShowUpDown = True
        Me.txtTdate.Size = New System.Drawing.Size(118, 35)
        Me.txtTdate.TabIndex = 105
        '
        'Fg1
        '
        Me.Fg1.DataSource = Nothing
        Me.Fg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fg1.Location = New System.Drawing.Point(0, 0)
        Me.Fg1.Name = "Fg1"
        Me.Fg1.OcxState = CType(resources.GetObject("Fg1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg1.Size = New System.Drawing.Size(1342, 420)
        Me.Fg1.TabIndex = 106
        '
        'Fg2
        '
        Me.Fg2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fg2.DataSource = Nothing
        Me.Fg2.Location = New System.Drawing.Point(12, 290)
        Me.Fg2.Name = "Fg2"
        Me.Fg2.OcxState = CType(resources.GetObject("Fg2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg2.Size = New System.Drawing.Size(1193, 154)
        Me.Fg2.TabIndex = 107
        Me.Fg2.Visible = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Saysettha OT", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(674, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(365, 38)
        Me.Label15.TabIndex = 311
        Me.Label15.Text = "ລາຍການປຶ້ມຕິດຕາມສຸຂະພາບ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton8
        '
        Me.RadioButton8.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadioButton8.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.ForeColor = System.Drawing.Color.Black
        Me.RadioButton8.Location = New System.Drawing.Point(486, 192)
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
        Me.RadioButton7.Location = New System.Drawing.Point(429, 192)
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
        Me.RadioButton6.Location = New System.Drawing.Point(375, 192)
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
        Me.RadioButton5.Location = New System.Drawing.Point(310, 192)
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
        Me.RadioButton9.Location = New System.Drawing.Point(543, 192)
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
        Me.RadioButton4.Location = New System.Drawing.Point(256, 192)
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
        Me.RadioButton3.Location = New System.Drawing.Point(202, 192)
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
        Me.RadioButton10.Location = New System.Drawing.Point(597, 179)
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
        Me.RadioButton2.Location = New System.Drawing.Point(148, 192)
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
        Me.RadioButton11.Location = New System.Drawing.Point(651, 192)
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
        Me.RadioButton1.Location = New System.Drawing.Point(92, 192)
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
        Me.RadioButton12.Location = New System.Drawing.Point(705, 192)
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
        Me.RadioButton14.Location = New System.Drawing.Point(821, 192)
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
        Me.RadioButton13.Location = New System.Drawing.Point(767, 192)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(55, 37)
        Me.RadioButton13.TabIndex = 45599
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "ໝົດປີ"
        Me.RadioButton13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton13.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.LbTotal)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.lblpage_total)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Location = New System.Drawing.Point(0, 591)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1350, 38)
        Me.Panel2.TabIndex = 45626
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(45, 35)
        Me.Button4.TabIndex = 284
        Me.Button4.Text = "<<"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'LbTotal
        '
        Me.LbTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTotal.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotal.ForeColor = System.Drawing.Color.Blue
        Me.LbTotal.Location = New System.Drawing.Point(327, 1)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(1019, 34)
        Me.LbTotal.TabIndex = 45624
        Me.LbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(46, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 35)
        Me.Button6.TabIndex = 285
        Me.Button6.Text = "<"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'lblpage_total
        '
        Me.lblpage_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblpage_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpage_total.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpage_total.ForeColor = System.Drawing.Color.Red
        Me.lblpage_total.Location = New System.Drawing.Point(92, 1)
        Me.lblpage_total.Name = "lblpage_total"
        Me.lblpage_total.Size = New System.Drawing.Size(143, 30)
        Me.lblpage_total.TabIndex = 288
        Me.lblpage_total.Text = "0"
        Me.lblpage_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(236, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(45, 35)
        Me.Button7.TabIndex = 286
        Me.Button7.Text = ">"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(281, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(45, 35)
        Me.Button8.TabIndex = 287
        Me.Button8.Text = ">>"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ທັງໝົດ", "ລະຫັດປື້ມ", "ບາໂຄດສຳຮອງ", "ຊື່ແມ່ມານ", "ບ້ານ", "ເບີໂທ"})
        Me.ComboBox1.Location = New System.Drawing.Point(1212, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 32)
        Me.ComboBox1.TabIndex = 45629
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"ທັງໝົດ", "ຜູ້ສະໜອງພາຍໃນພາຍໃນ", "ຜູ້ສະໜອງຕ່າງປະເທດ"})
        Me.ComboBox2.Location = New System.Drawing.Point(865, 147)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(242, 32)
        Me.ComboBox2.TabIndex = 45630
        Me.ComboBox2.Visible = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(771, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 37)
        Me.Label12.TabIndex = 45631
        Me.Label12.Text = "ຜູ້ສະໜອງ:"
        Me.Label12.Visible = False
        '
        'txt_Hder
        '
        Me.txt_Hder.Location = New System.Drawing.Point(116, 177)
        Me.txt_Hder.Name = "txt_Hder"
        Me.txt_Hder.Size = New System.Drawing.Size(259, 35)
        Me.txt_Hder.TabIndex = 45632
        Me.txt_Hder.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(381, 177)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(129, 35)
        Me.DateTimePicker1.TabIndex = 45633
        Me.DateTimePicker1.Value = New Date(2009, 12, 29, 0, 0, 0, 0)
        Me.DateTimePicker1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1082, 132)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(97, 35)
        Me.TextBox1.TabIndex = 45634
        Me.TextBox1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Fg1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(4, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1342, 420)
        Me.Panel1.TabIndex = 45635
        '
        'TxtPV_NM
        '
        Me.TxtPV_NM.Enabled = False
        Me.TxtPV_NM.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtPV_NM.FormattingEnabled = True
        Me.TxtPV_NM.Location = New System.Drawing.Point(173, 128)
        Me.TxtPV_NM.Name = "TxtPV_NM"
        Me.TxtPV_NM.Size = New System.Drawing.Size(257, 32)
        Me.TxtPV_NM.TabIndex = 409
        '
        'TxtDt_Nm
        '
        Me.TxtDt_Nm.Enabled = False
        Me.TxtDt_Nm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtDt_Nm.FormattingEnabled = True
        Me.TxtDt_Nm.Location = New System.Drawing.Point(518, 127)
        Me.TxtDt_Nm.Name = "TxtDt_Nm"
        Me.TxtDt_Nm.Size = New System.Drawing.Size(180, 32)
        Me.TxtDt_Nm.TabIndex = 408
        '
        'txtVillage_nm
        '
        Me.txtVillage_nm.Enabled = False
        Me.txtVillage_nm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVillage_nm.FormattingEnabled = True
        Me.txtVillage_nm.Location = New System.Drawing.Point(759, 128)
        Me.txtVillage_nm.Name = "txtVillage_nm"
        Me.txtVillage_nm.Size = New System.Drawing.Size(275, 32)
        Me.txtVillage_nm.TabIndex = 407
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(463, 129)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 24)
        Me.Label25.TabIndex = 401
        Me.Label25.Text = "ເມືອງ:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(704, 132)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 24)
        Me.Label24.TabIndex = 402
        Me.Label24.Text = "ບ້ານ:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(106, 129)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 24)
        Me.Label23.TabIndex = 403
        Me.Label23.Text = "ແຂວງ:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProvince
        '
        Me.txtProvince.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(1043, 8)
        Me.txtProvince.Multiline = False
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtProvince.Size = New System.Drawing.Size(68, 29)
        Me.txtProvince.TabIndex = 406
        Me.txtProvince.Text = ""
        Me.txtProvince.Visible = False
        '
        'txtVillage
        '
        Me.txtVillage.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVillage.Location = New System.Drawing.Point(1227, 8)
        Me.txtVillage.Multiline = False
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtVillage.Size = New System.Drawing.Size(68, 29)
        Me.txtVillage.TabIndex = 404
        Me.txtVillage.Text = ""
        Me.txtVillage.Visible = False
        '
        'txtDistrict
        '
        Me.txtDistrict.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDistrict.Location = New System.Drawing.Point(1132, 13)
        Me.txtDistrict.Multiline = False
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtDistrict.Size = New System.Drawing.Size(68, 29)
        Me.txtDistrict.TabIndex = 405
        Me.txtDistrict.Text = ""
        Me.txtDistrict.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(446, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 32)
        Me.Label1.TabIndex = 45636
        Me.Label1.Text = "ລະຫັດປື້ມ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBK_no
        '
        Me.txtBK_no.Location = New System.Drawing.Point(518, 53)
        Me.txtBK_no.Name = "txtBK_no"
        Me.txtBK_no.Size = New System.Drawing.Size(180, 35)
        Me.txtBK_no.TabIndex = 45637
        '
        'txtbarcode
        '
        Me.txtbarcode.Location = New System.Drawing.Point(784, 54)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(250, 35)
        Me.txtbarcode.TabIndex = 45639
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(702, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 32)
        Me.Label4.TabIndex = 45638
        Me.Label4.Text = "ບາໂຄດ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Dad_Name
        '
        Me.txt_Dad_Name.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Dad_Name.Location = New System.Drawing.Point(843, 90)
        Me.txt_Dad_Name.Name = "txt_Dad_Name"
        Me.txt_Dad_Name.Size = New System.Drawing.Size(191, 35)
        Me.txt_Dad_Name.TabIndex = 45641
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(701, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 28)
        Me.Label11.TabIndex = 45642
        Me.Label11.Text = "ຊື່ແລະນາມສະກຸນພໍ່:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Mobail1
        '
        Me.txt_Mobail1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Mobail1.Location = New System.Drawing.Point(1122, 87)
        Me.txt_Mobail1.Name = "txt_Mobail1"
        Me.txt_Mobail1.Size = New System.Drawing.Size(180, 35)
        Me.txt_Mobail1.TabIndex = 45644
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(1033, 87)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 34)
        Me.Label21.TabIndex = 45643
        Me.Label21.Text = "ໂທລະສັບພໍ່:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Mobail2
        '
        Me.txt_Mobail2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Mobail2.Location = New System.Drawing.Point(518, 90)
        Me.txt_Mobail2.Name = "txt_Mobail2"
        Me.txt_Mobail2.Size = New System.Drawing.Size(179, 35)
        Me.txt_Mobail2.TabIndex = 45648
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(429, 94)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(93, 28)
        Me.Label22.TabIndex = 45647
        Me.Label22.Text = "ໂທລະສັບແມ່:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtmom_name
        '
        Me.txtmom_name.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtmom_name.Location = New System.Drawing.Point(172, 91)
        Me.txtmom_name.Name = "txtmom_name"
        Me.txtmom_name.Size = New System.Drawing.Size(258, 35)
        Me.txtmom_name.TabIndex = 45645
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 24)
        Me.Label6.TabIndex = 45646
        Me.Label6.Text = "ຊື່ ແລະນາມສະກຸນ ແມ່:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(0, 127)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(108, 28)
        Me.CheckBox1.TabIndex = 45649
        Me.CheckBox1.Text = "ຊອກຕາມທີ່ຢູ່"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(4, 55)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(64, 28)
        Me.CheckBox2.TabIndex = 45650
        Me.CheckBox2.Text = "ວັນທີ:"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(329, 52)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(108, 36)
        Me.Button9.TabIndex = 45627
        Me.Button9.Text = "ຄົ້ນຫາ"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.APInvioce.My.Resources.Resources.preview_f2
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(534, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 43)
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
        Me.Button2.Location = New System.Drawing.Point(409, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 43)
        Me.Button2.TabIndex = 112
        Me.Button2.Text = "Refresh"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.Black
        Me.BtnDel.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.BtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDel.Location = New System.Drawing.Point(298, 2)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(107, 43)
        Me.BtnDel.TabIndex = 111
        Me.BtnDel.Text = "ລືບ"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.APInvioce.My.Resources.Resources.Edit
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(173, 1)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(122, 43)
        Me.BtnEdit.TabIndex = 110
        Me.BtnEdit.Text = "ແກ້ໄຂ"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Image = Global.APInvioce.My.Resources.Resources.New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(62, 1)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(105, 43)
        Me.BtnAddNew.TabIndex = 109
        Me.BtnAddNew.Text = "ເພີ່ມໃໝ່"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button1.Location = New System.Drawing.Point(4, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 43)
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
        'Frm_Book_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1351, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_Dad_Name)
        Me.Controls.Add(Me.txtFdate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtPV_NM)
        Me.Controls.Add(Me.TxtDt_Nm)
        Me.Controls.Add(Me.txt_Mobail2)
        Me.Controls.Add(Me.txtVillage_nm)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtmom_name)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txt_Mobail1)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.txtVillage)
        Me.Controls.Add(Me.txtDistrict)
        Me.Controls.Add(Me.txtbarcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBK_no)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Panel2)
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
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTdate)
        Me.Controls.Add(Me.txtIn_no)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Fg2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txt_Hder)
        Me.Controls.Add(Me.Label21)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Book_List"
        Me.Text = "Book list"
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtIn_no As System.Windows.Forms.TextBox
    Friend WithEvents txtTdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fg1 As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Fg2 As AxVSFlex8U.AxVSFlexGrid
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LbTotal As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents lblpage_total As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Hder As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBK_no As System.Windows.Forms.TextBox
    Friend WithEvents txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Dad_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Mobail1 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_Mobail2 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtmom_name As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPV_NM As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDt_Nm As System.Windows.Forms.ComboBox
    Friend WithEvents txtVillage_nm As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtProvince As System.Windows.Forms.RichTextBox
    Friend WithEvents txtVillage As System.Windows.Forms.RichTextBox
    Friend WithEvents txtDistrict As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
