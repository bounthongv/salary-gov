<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EP_Table
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EP_Table))
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Txt_ID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txtremark = New System.Windows.Forms.TextBox
        Me.fg = New AxVSFlex8U.AxVSFlexGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtPV_NM = New System.Windows.Forms.ComboBox
        Me.TxtPV_ID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtno = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Txt_name2 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtSection_ID = New System.Windows.Forms.TextBox
        Me.txtdepart_ID = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_Department = New System.Windows.Forms.ComboBox
        Me.Cmb_Sections = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.DT_up = New System.Windows.Forms.DateTimePicker
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(181, 3)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(126, 48)
        Me.BtnSave.TabIndex = 181
        Me.BtnSave.Text = "ບັນທຶກ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.BtnAddNew.Image = CType(resources.GetObject("BtnAddNew.Image"), System.Drawing.Image)
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(55, 3)
        Me.BtnAddNew.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(126, 48)
        Me.BtnAddNew.TabIndex = 180
        Me.BtnAddNew.Text = "ເພີ່ມໃໝ່"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(3, 3)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(44, 47)
        Me.Button6.TabIndex = 179
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Txt_ID
        '
        Me.Txt_ID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ID.Location = New System.Drawing.Point(91, 51)
        Me.Txt_ID.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(124, 35)
        Me.Txt_ID.TabIndex = 339
        Me.Txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 29)
        Me.Label7.TabIndex = 338
        Me.Label7.Text = "ເລກນັບ:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtremark
        '
        Me.Txtremark.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtremark.Location = New System.Drawing.Point(554, 111)
        Me.Txtremark.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Txtremark.Name = "Txtremark"
        Me.Txtremark.Size = New System.Drawing.Size(539, 35)
        Me.Txtremark.TabIndex = 341
        '
        'fg
        '
        Me.fg.DataSource = Nothing
        Me.fg.Location = New System.Drawing.Point(1, 155)
        Me.fg.Name = "fg"
        Me.fg.OcxState = CType(resources.GetObject("fg.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fg.Size = New System.Drawing.Size(1092, 362)
        Me.fg.TabIndex = 342
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(472, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 33)
        Me.Label1.TabIndex = 343
        Me.Label1.Text = "ໝາຍເຫດ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPV_NM
        '
        Me.TxtPV_NM.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPV_NM.FormattingEnabled = True
        Me.TxtPV_NM.Location = New System.Drawing.Point(588, 312)
        Me.TxtPV_NM.Name = "TxtPV_NM"
        Me.TxtPV_NM.Size = New System.Drawing.Size(379, 32)
        Me.TxtPV_NM.TabIndex = 345
        Me.TxtPV_NM.Visible = False
        '
        'TxtPV_ID
        '
        Me.TxtPV_ID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPV_ID.Location = New System.Drawing.Point(842, 334)
        Me.TxtPV_ID.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TxtPV_ID.Name = "TxtPV_ID"
        Me.TxtPV_ID.Size = New System.Drawing.Size(126, 35)
        Me.TxtPV_ID.TabIndex = 346
        Me.TxtPV_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPV_ID.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(686, 349)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 29)
        Me.Label3.TabIndex = 347
        Me.Label3.Text = "ແຂວງ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'txtno
        '
        Me.txtno.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.Location = New System.Drawing.Point(230, 210)
        Me.txtno.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(124, 35)
        Me.txtno.TabIndex = 349
        Me.txtno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtno.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(151, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 29)
        Me.Label4.TabIndex = 348
        Me.Label4.Text = "ຊັ້ນ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 263)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 33)
        Me.Label5.TabIndex = 351
        Me.Label5.Text = "ຊືຫຍໍ້:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'Txt_name2
        '
        Me.Txt_name2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_name2.Location = New System.Drawing.Point(245, 262)
        Me.Txt_name2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Txt_name2.Name = "Txt_name2"
        Me.Txt_name2.Size = New System.Drawing.Size(99, 35)
        Me.Txt_name2.TabIndex = 350
        Me.Txt_name2.Visible = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Saysettha OT", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(479, -20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(539, 129)
        Me.Label15.TabIndex = 352
        Me.Label15.Text = "ຕາຕະລາງ EP ລະດັບຄວາມສາມາດ (5 ລະດັບ) ທີ່ຕິດພັນກັບ (ປີ) ປະສົບການເຮັດວຽກ "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSection_ID
        '
        Me.txtSection_ID.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection_ID.Location = New System.Drawing.Point(419, 87)
        Me.txtSection_ID.Name = "txtSection_ID"
        Me.txtSection_ID.Size = New System.Drawing.Size(43, 30)
        Me.txtSection_ID.TabIndex = 45754
        Me.txtSection_ID.Visible = False
        '
        'txtdepart_ID
        '
        Me.txtdepart_ID.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepart_ID.Location = New System.Drawing.Point(419, 116)
        Me.txtdepart_ID.Name = "txtdepart_ID"
        Me.txtdepart_ID.Size = New System.Drawing.Size(46, 30)
        Me.txtdepart_ID.TabIndex = 45753
        Me.txtdepart_ID.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(36, 94)
        Me.Label27.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 24)
        Me.Label27.TabIndex = 45755
        Me.Label27.Text = "ກົມ"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 125)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 24)
        Me.Label2.TabIndex = 45752
        Me.Label2.Text = "ພະແນກ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_Department
        '
        Me.cmb_Department.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Department.FormattingEnabled = True
        Me.cmb_Department.Location = New System.Drawing.Point(91, 120)
        Me.cmb_Department.Name = "cmb_Department"
        Me.cmb_Department.Size = New System.Drawing.Size(322, 32)
        Me.cmb_Department.TabIndex = 45751
        '
        'Cmb_Sections
        '
        Me.Cmb_Sections.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Sections.FormattingEnabled = True
        Me.Cmb_Sections.Location = New System.Drawing.Point(91, 87)
        Me.Cmb_Sections.Name = "Cmb_Sections"
        Me.Cmb_Sections.Size = New System.Drawing.Size(322, 32)
        Me.Cmb_Sections.TabIndex = 45750
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(223, 58)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 24)
        Me.Label14.TabIndex = 45766
        Me.Label14.Text = "ວັນທີ"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DT_up
        '
        Me.DT_up.CustomFormat = "dd/MM/yyyy"
        Me.DT_up.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_up.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_up.Location = New System.Drawing.Point(274, 50)
        Me.DT_up.Name = "DT_up"
        Me.DT_up.ShowUpDown = True
        Me.DT_up.Size = New System.Drawing.Size(105, 35)
        Me.DT_up.TabIndex = 45765
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.APInvioce.My.Resources.Resources.preview_f2
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(308, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 46)
        Me.Button3.TabIndex = 45767
        Me.Button3.Text = "ເບີ່ງ/Preview "
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Frm_EP_Table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1199, 624)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DT_up)
        Me.Controls.Add(Me.txtSection_ID)
        Me.Controls.Add(Me.txtdepart_ID)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_Department)
        Me.Controls.Add(Me.Cmb_Sections)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtremark)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_name2)
        Me.Controls.Add(Me.TxtPV_ID)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Txt_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPV_NM)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_EP_Table"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Unit"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtremark As System.Windows.Forms.TextBox
    Friend WithEvents fg As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPV_NM As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPV_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_name2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSection_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtdepart_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Department As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_Sections As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DT_up As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
