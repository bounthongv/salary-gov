<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Department
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Department))
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Txt_ID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.fg = New AxVSFlex8U.AxVSFlexGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSection_ID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtno = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtoerder_no = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Cmb_Sections = New System.Windows.Forms.ComboBox
        Me.cmb_type = New System.Windows.Forms.ComboBox
        Me.txttype_Id = New System.Windows.Forms.TextBox
        Me.txt_sec_id = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(299, 37)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(112, 33)
        Me.BtnSave.TabIndex = 181
        Me.BtnSave.Text = "ບັນທຶກ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Image = CType(resources.GetObject("BtnAddNew.Image"), System.Drawing.Image)
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(187, 37)
        Me.BtnAddNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(112, 33)
        Me.BtnAddNew.TabIndex = 180
        Me.BtnAddNew.Text = "ເພີ່ມໃໝ່"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(3, 3)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(31, 32)
        Me.Button6.TabIndex = 179
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(412, 37)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 33)
        Me.Button1.TabIndex = 182
        Me.Button1.Text = "ລືບ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Txt_ID
        '
        Me.Txt_ID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ID.Location = New System.Drawing.Point(198, 72)
        Me.Txt_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.ReadOnly = True
        Me.Txt_ID.Size = New System.Drawing.Size(111, 35)
        Me.Txt_ID.TabIndex = 339
        Me.Txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 78)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 24)
        Me.Label7.TabIndex = 338
        Me.Label7.Text = "ລະຫັດ:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_name
        '
        Me.Txt_name.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_name.Location = New System.Drawing.Point(198, 179)
        Me.Txt_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(536, 35)
        Me.Txt_name.TabIndex = 341
        '
        'fg
        '
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.DataSource = Nothing
        Me.fg.Location = New System.Drawing.Point(1, 217)
        Me.fg.Name = "fg"
        Me.fg.OcxState = CType(resources.GetObject("fg.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fg.Size = New System.Drawing.Size(733, 362)
        Me.fg.TabIndex = 342
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 184)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 24)
        Me.Label1.TabIndex = 343
        Me.Label1.Text = "ຊື່:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(215, -4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(393, 41)
        Me.Label2.TabIndex = 344
        Me.Label2.Text = "ລາຍຊື່ພະແນກ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSection_ID
        '
        Me.txtSection_ID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection_ID.Location = New System.Drawing.Point(541, 106)
        Me.txtSection_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSection_ID.Name = "txtSection_ID"
        Me.txtSection_ID.Size = New System.Drawing.Size(81, 35)
        Me.txtSection_ID.TabIndex = 346
        Me.txtSection_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 24)
        Me.Label3.TabIndex = 347
        Me.Label3.Text = "ໝວດພະແນກ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtno
        '
        Me.txtno.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.Location = New System.Drawing.Point(204, 217)
        Me.txtno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(111, 35)
        Me.txtno.TabIndex = 349
        Me.txtno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtno.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(134, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 348
        Me.Label4.Text = "ຊັ້ນ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'txtoerder_no
        '
        Me.txtoerder_no.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoerder_no.Location = New System.Drawing.Point(409, 72)
        Me.txtoerder_no.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtoerder_no.Name = "txtoerder_no"
        Me.txtoerder_no.Size = New System.Drawing.Size(111, 35)
        Me.txtoerder_no.TabIndex = 351
        Me.txtoerder_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(317, 78)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 24)
        Me.Label5.TabIndex = 350
        Me.Label5.Text = "ເລກຈັດລຽງ:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmb_Sections
        '
        Me.Cmb_Sections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Sections.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Sections.FormattingEnabled = True
        Me.Cmb_Sections.Items.AddRange(New Object() {"ນະຄອນຫລວງ (ສູນກາງ)", "ສາຂາພາຍໃນ", "ສາຂາຕ່າງປະເທດ"})
        Me.Cmb_Sections.Location = New System.Drawing.Point(198, 109)
        Me.Cmb_Sections.Name = "Cmb_Sections"
        Me.Cmb_Sections.Size = New System.Drawing.Size(326, 32)
        Me.Cmb_Sections.TabIndex = 345
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"ພະນັກງານສົມບູນ", "ພະນັກງານສັນຍາຈ້າງ"})
        Me.cmb_type.Location = New System.Drawing.Point(198, 144)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(326, 32)
        Me.cmb_type.TabIndex = 352
        '
        'txttype_Id
        '
        Me.txttype_Id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype_Id.Location = New System.Drawing.Point(541, 142)
        Me.txttype_Id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttype_Id.Name = "txttype_Id"
        Me.txttype_Id.Size = New System.Drawing.Size(81, 35)
        Me.txttype_Id.TabIndex = 353
        Me.txttype_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sec_id
        '
        Me.txt_sec_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sec_id.Location = New System.Drawing.Point(663, 67)
        Me.txt_sec_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_sec_id.Name = "txt_sec_id"
        Me.txt_sec_id.Size = New System.Drawing.Size(81, 35)
        Me.txt_sec_id.TabIndex = 356
        Me.txt_sec_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_sec_id.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-4, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 24)
        Me.Label6.TabIndex = 354
        Me.Label6.Text = "ລາຍການສາຂາ(ບ່ອນປະຈຳການ)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_Department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(737, 546)
        Me.Controls.Add(Me.Cmb_Sections)
        Me.Controls.Add(Me.txt_sec_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttype_Id)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.txtoerder_no)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSection_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Txt_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Department"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Unit"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_name As System.Windows.Forms.TextBox
    Friend WithEvents fg As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSection_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtoerder_no As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Sections As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents txttype_Id As System.Windows.Forms.TextBox
    Friend WithEvents txt_sec_id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
