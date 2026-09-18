<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomer_item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomer_item))
        Me.txtCusID = New System.Windows.Forms.TextBox
        Me.txtCusNm = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Fg = New AxVSFlex8U.AxVSFlexGrid
        Me.Button2 = New System.Windows.Forms.Button
        Me.FgCust = New AxVSFlex8U.AxVSFlexGrid
        Me.txtbarcode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.chk_all = New System.Windows.Forms.CheckBox
        Me.txtSection_ID = New System.Windows.Forms.TextBox
        Me.txtdepart_ID = New System.Windows.Forms.TextBox
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.txt_job_phuk_id = New System.Windows.Forms.TextBox
        Me.cmb_job_lut = New System.Windows.Forms.ComboBox
        Me.chk_Job_lut = New System.Windows.Forms.CheckBox
        Me.chk_Job_Phuk = New System.Windows.Forms.CheckBox
        Me.cmb_job_phuk = New System.Windows.Forms.ComboBox
        Me.cmb_Department = New System.Windows.Forms.ComboBox
        Me.Cmb_Sections = New System.Windows.Forms.ComboBox
        Me.chk_department = New System.Windows.Forms.CheckBox
        Me.chk_section = New System.Windows.Forms.CheckBox
        Me.txt_job_lut_id = New System.Windows.Forms.TextBox
        CType(Me.Fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FgCust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCusID
        '
        Me.txtCusID.Location = New System.Drawing.Point(195, 4)
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.Size = New System.Drawing.Size(206, 30)
        Me.txtCusID.TabIndex = 0
        '
        'txtCusNm
        '
        Me.txtCusNm.Location = New System.Drawing.Point(554, 6)
        Me.txtCusNm.Name = "txtCusNm"
        Me.txtCusNm.Size = New System.Drawing.Size(171, 30)
        Me.txtCusNm.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button1.Location = New System.Drawing.Point(-1, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 64)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ລະຫັດ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fg
        '
        Me.Fg.Location = New System.Drawing.Point(-1, 83)
        Me.Fg.Name = "Fg"
        Me.Fg.OcxState = CType(resources.GetObject("Fg.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg.Size = New System.Drawing.Size(1238, 459)
        Me.Fg.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Image = Global.APInvioce.My.Resources.Resources.AddNew
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(891, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 31)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "AddNew"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'FgCust
        '
        Me.FgCust.DataSource = Nothing
        Me.FgCust.Location = New System.Drawing.Point(1, 99)
        Me.FgCust.Name = "FgCust"
        Me.FgCust.OcxState = CType(resources.GetObject("FgCust.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FgCust.Size = New System.Drawing.Size(221, 516)
        Me.FgCust.TabIndex = 7
        '
        'txtbarcode
        '
        Me.txtbarcode.Location = New System.Drawing.Point(570, 244)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(235, 30)
        Me.txtbarcode.TabIndex = 45654
        Me.txtbarcode.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(488, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 32)
        Me.Label4.TabIndex = 45653
        Me.Label4.Text = "ບາໂຄດ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(408, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 24)
        Me.Label6.TabIndex = 45655
        Me.Label6.Text = "ຊື່ ແລະນາມສະກຸນ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_all
        '
        Me.chk_all.AutoSize = True
        Me.chk_all.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.chk_all.Location = New System.Drawing.Point(1072, 43)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(120, 28)
        Me.chk_all.TabIndex = 45656
        Me.chk_all.Text = "ສະແດງທັງໝົດ"
        Me.chk_all.UseVisualStyleBackColor = True
        '
        'txtSection_ID
        '
        Me.txtSection_ID.Location = New System.Drawing.Point(877, 233)
        Me.txtSection_ID.Name = "txtSection_ID"
        Me.txtSection_ID.Size = New System.Drawing.Size(43, 30)
        Me.txtSection_ID.TabIndex = 45813
        Me.txtSection_ID.Visible = False
        '
        'txtdepart_ID
        '
        Me.txtdepart_ID.Location = New System.Drawing.Point(874, 193)
        Me.txtdepart_ID.Name = "txtdepart_ID"
        Me.txtdepart_ID.Size = New System.Drawing.Size(46, 30)
        Me.txtdepart_ID.TabIndex = 45812
        Me.txtdepart_ID.Visible = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(49, 5)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(61, 61)
        Me.BtnEdit.TabIndex = 45816
        Me.BtnEdit.Text = "OK"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'txt_job_phuk_id
        '
        Me.txt_job_phuk_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job_phuk_id.Location = New System.Drawing.Point(877, 269)
        Me.txt_job_phuk_id.Name = "txt_job_phuk_id"
        Me.txt_job_phuk_id.Size = New System.Drawing.Size(43, 35)
        Me.txt_job_phuk_id.TabIndex = 45827
        Me.txt_job_phuk_id.Visible = False
        '
        'cmb_job_lut
        '
        Me.cmb_job_lut.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_job_lut.FormattingEnabled = True
        Me.cmb_job_lut.Location = New System.Drawing.Point(554, 39)
        Me.cmb_job_lut.Name = "cmb_job_lut"
        Me.cmb_job_lut.Size = New System.Drawing.Size(171, 32)
        Me.cmb_job_lut.TabIndex = 45830
        '
        'chk_Job_lut
        '
        Me.chk_Job_lut.AutoSize = True
        Me.chk_Job_lut.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Job_lut.Location = New System.Drawing.Point(407, 42)
        Me.chk_Job_lut.Name = "chk_Job_lut"
        Me.chk_Job_lut.Size = New System.Drawing.Size(150, 28)
        Me.chk_Job_lut.TabIndex = 45831
        Me.chk_Job_lut.Text = "ຕຳແໜ່ງຮັບຜິດຊອບ"
        Me.chk_Job_lut.UseVisualStyleBackColor = True
        '
        'chk_Job_Phuk
        '
        Me.chk_Job_Phuk.AutoSize = True
        Me.chk_Job_Phuk.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Job_Phuk.Location = New System.Drawing.Point(729, 39)
        Me.chk_Job_Phuk.Name = "chk_Job_Phuk"
        Me.chk_Job_Phuk.Size = New System.Drawing.Size(100, 28)
        Me.chk_Job_Phuk.TabIndex = 45829
        Me.chk_Job_Phuk.Text = "ຕຳແໜ່ງພັກ"
        Me.chk_Job_Phuk.UseVisualStyleBackColor = True
        '
        'cmb_job_phuk
        '
        Me.cmb_job_phuk.BackColor = System.Drawing.Color.White
        Me.cmb_job_phuk.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_job_phuk.FormattingEnabled = True
        Me.cmb_job_phuk.Location = New System.Drawing.Point(848, 39)
        Me.cmb_job_phuk.Name = "cmb_job_phuk"
        Me.cmb_job_phuk.Size = New System.Drawing.Size(218, 32)
        Me.cmb_job_phuk.TabIndex = 45828
        '
        'cmb_Department
        '
        Me.cmb_Department.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Department.FormattingEnabled = True
        Me.cmb_Department.Location = New System.Drawing.Point(195, 38)
        Me.cmb_Department.Name = "cmb_Department"
        Me.cmb_Department.Size = New System.Drawing.Size(206, 32)
        Me.cmb_Department.TabIndex = 45826
        '
        'Cmb_Sections
        '
        Me.Cmb_Sections.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Sections.FormattingEnabled = True
        Me.Cmb_Sections.Location = New System.Drawing.Point(849, 2)
        Me.Cmb_Sections.Name = "Cmb_Sections"
        Me.Cmb_Sections.Size = New System.Drawing.Size(217, 32)
        Me.Cmb_Sections.TabIndex = 45825
        '
        'chk_department
        '
        Me.chk_department.AutoSize = True
        Me.chk_department.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_department.Location = New System.Drawing.Point(116, 40)
        Me.chk_department.Name = "chk_department"
        Me.chk_department.Size = New System.Drawing.Size(78, 28)
        Me.chk_department.TabIndex = 45824
        Me.chk_department.Text = "ພະແນກ"
        Me.chk_department.UseVisualStyleBackColor = True
        '
        'chk_section
        '
        Me.chk_section.AutoSize = True
        Me.chk_section.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_section.Location = New System.Drawing.Point(729, 7)
        Me.chk_section.Name = "chk_section"
        Me.chk_section.Size = New System.Drawing.Size(124, 28)
        Me.chk_section.TabIndex = 45823
        Me.chk_section.Text = "ບ່ອນປະຈຳການ"
        Me.chk_section.UseVisualStyleBackColor = True
        '
        'txt_job_lut_id
        '
        Me.txt_job_lut_id.Location = New System.Drawing.Point(874, 157)
        Me.txt_job_lut_id.Name = "txt_job_lut_id"
        Me.txt_job_lut_id.Size = New System.Drawing.Size(46, 30)
        Me.txt_job_lut_id.TabIndex = 45832
        Me.txt_job_lut_id.Visible = False
        '
        'FrmCustomer_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1249, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_job_lut_id)
        Me.Controls.Add(Me.txt_job_phuk_id)
        Me.Controls.Add(Me.txtSection_ID)
        Me.Controls.Add(Me.txtdepart_ID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmb_job_lut)
        Me.Controls.Add(Me.chk_Job_lut)
        Me.Controls.Add(Me.chk_Job_Phuk)
        Me.Controls.Add(Me.cmb_job_phuk)
        Me.Controls.Add(Me.cmb_Department)
        Me.Controls.Add(Me.Cmb_Sections)
        Me.Controls.Add(Me.chk_department)
        Me.Controls.Add(Me.chk_section)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.chk_all)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbarcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Fg)
        Me.Controls.Add(Me.FgCust)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCusNm)
        Me.Controls.Add(Me.txtCusID)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmCustomer_item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer item"
        CType(Me.Fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FgCust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCusID As System.Windows.Forms.TextBox
    Friend WithEvents txtCusNm As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Fg As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FgCust As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chk_all As System.Windows.Forms.CheckBox
    Friend WithEvents txtSection_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtdepart_ID As System.Windows.Forms.TextBox
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents txt_job_phuk_id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_job_lut As System.Windows.Forms.ComboBox
    Friend WithEvents chk_Job_lut As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Job_Phuk As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_job_phuk As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Department As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_Sections As System.Windows.Forms.ComboBox
    Friend WithEvents chk_department As System.Windows.Forms.CheckBox
    Friend WithEvents chk_section As System.Windows.Forms.CheckBox
    Friend WithEvents txt_job_lut_id As System.Windows.Forms.TextBox
End Class
