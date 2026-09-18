<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStaff))
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Fg1 = New AxVSFlex8U.AxVSFlexGrid
        Me.Pnl = New System.Windows.Forms.Panel
        Me.Fg2 = New AxVSFlex8U.AxVSFlexGrid
        Me.txtVillage = New System.Windows.Forms.RichTextBox
        Me.txtStreet = New System.Windows.Forms.RichTextBox
        Me.txtStaffNmE = New System.Windows.Forms.RichTextBox
        Me.txtStaffNmL = New System.Windows.Forms.RichTextBox
        Me.txtContact_pp = New System.Windows.Forms.RichTextBox
        Me.txtPhone = New System.Windows.Forms.RichTextBox
        Me.txtProvince = New System.Windows.Forms.RichTextBox
        Me.txtDistrict = New System.Windows.Forms.RichTextBox
        Me.txtStaff_ID = New System.Windows.Forms.RichTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.PnL2 = New System.Windows.Forms.Panel
        Me.BtnShow = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl.SuspendLayout()
        CType(Me.Fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnL2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.APInvioce.My.Resources.Resources.Edit
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(241, 1)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(114, 33)
        Me.BtnEdit.TabIndex = 46
        Me.BtnEdit.Text = "ແກ້ໄຂ"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(356, 1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(111, 33)
        Me.Button7.TabIndex = 45
        Me.Button7.Text = "ລຶບ"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.APInvioce.My.Resources.Resources.save_f2
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(138, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(102, 33)
        Me.BtnSave.TabIndex = 44
        Me.BtnSave.Text = "ບັນທຶກ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.APInvioce.My.Resources.Resources.New2
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(40, 1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(97, 33)
        Me.Button9.TabIndex = 43
        Me.Button9.Text = "ເພີ່ມໃໝ່"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button1.Location = New System.Drawing.Point(3, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Fg1
        '
        Me.Fg1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fg1.Location = New System.Drawing.Point(3, 40)
        Me.Fg1.Name = "Fg1"
        Me.Fg1.OcxState = CType(resources.GetObject("Fg1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg1.Size = New System.Drawing.Size(840, 487)
        Me.Fg1.TabIndex = 48
        '
        'Pnl
        '
        Me.Pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl.Controls.Add(Me.Fg2)
        Me.Pnl.Controls.Add(Me.txtVillage)
        Me.Pnl.Controls.Add(Me.txtStreet)
        Me.Pnl.Controls.Add(Me.txtStaffNmE)
        Me.Pnl.Controls.Add(Me.txtStaffNmL)
        Me.Pnl.Controls.Add(Me.txtContact_pp)
        Me.Pnl.Controls.Add(Me.txtPhone)
        Me.Pnl.Controls.Add(Me.txtProvince)
        Me.Pnl.Controls.Add(Me.txtDistrict)
        Me.Pnl.Controls.Add(Me.txtStaff_ID)
        Me.Pnl.Controls.Add(Me.Label9)
        Me.Pnl.Controls.Add(Me.Label8)
        Me.Pnl.Controls.Add(Me.Label7)
        Me.Pnl.Controls.Add(Me.Label6)
        Me.Pnl.Controls.Add(Me.Label5)
        Me.Pnl.Controls.Add(Me.Label4)
        Me.Pnl.Controls.Add(Me.Label3)
        Me.Pnl.Controls.Add(Me.Label2)
        Me.Pnl.Controls.Add(Me.Label1)
        Me.Pnl.Location = New System.Drawing.Point(3, 40)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(840, 478)
        Me.Pnl.TabIndex = 49
        Me.Pnl.Visible = False
        '
        'Fg2
        '
        Me.Fg2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fg2.Location = New System.Drawing.Point(488, 6)
        Me.Fg2.Name = "Fg2"
        Me.Fg2.OcxState = CType(resources.GetObject("Fg2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg2.Size = New System.Drawing.Size(350, 544)
        Me.Fg2.TabIndex = 18
        '
        'txtVillage
        '
        Me.txtVillage.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVillage.Location = New System.Drawing.Point(182, 137)
        Me.txtVillage.Multiline = False
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtVillage.Size = New System.Drawing.Size(301, 30)
        Me.txtVillage.TabIndex = 27
        Me.txtVillage.Text = ""
        '
        'txtStreet
        '
        Me.txtStreet.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(182, 104)
        Me.txtStreet.Multiline = False
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtStreet.Size = New System.Drawing.Size(301, 30)
        Me.txtStreet.TabIndex = 26
        Me.txtStreet.Text = ""
        '
        'txtStaffNmE
        '
        Me.txtStaffNmE.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffNmE.Location = New System.Drawing.Point(182, 71)
        Me.txtStaffNmE.Multiline = False
        Me.txtStaffNmE.Name = "txtStaffNmE"
        Me.txtStaffNmE.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtStaffNmE.Size = New System.Drawing.Size(301, 30)
        Me.txtStaffNmE.TabIndex = 25
        Me.txtStaffNmE.Text = ""
        '
        'txtStaffNmL
        '
        Me.txtStaffNmL.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffNmL.Location = New System.Drawing.Point(182, 38)
        Me.txtStaffNmL.Multiline = False
        Me.txtStaffNmL.Name = "txtStaffNmL"
        Me.txtStaffNmL.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtStaffNmL.Size = New System.Drawing.Size(301, 30)
        Me.txtStaffNmL.TabIndex = 24
        Me.txtStaffNmL.Text = ""
        '
        'txtContact_pp
        '
        Me.txtContact_pp.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact_pp.Location = New System.Drawing.Point(182, 269)
        Me.txtContact_pp.Multiline = False
        Me.txtContact_pp.Name = "txtContact_pp"
        Me.txtContact_pp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtContact_pp.Size = New System.Drawing.Size(301, 30)
        Me.txtContact_pp.TabIndex = 23
        Me.txtContact_pp.Text = ""
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(182, 236)
        Me.txtPhone.Multiline = False
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtPhone.Size = New System.Drawing.Size(301, 30)
        Me.txtPhone.TabIndex = 22
        Me.txtPhone.Text = ""
        '
        'txtProvince
        '
        Me.txtProvince.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(182, 203)
        Me.txtProvince.Multiline = False
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtProvince.Size = New System.Drawing.Size(301, 30)
        Me.txtProvince.TabIndex = 21
        Me.txtProvince.Text = ""
        '
        'txtDistrict
        '
        Me.txtDistrict.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistrict.Location = New System.Drawing.Point(182, 170)
        Me.txtDistrict.Multiline = False
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtDistrict.Size = New System.Drawing.Size(301, 30)
        Me.txtDistrict.TabIndex = 20
        Me.txtDistrict.Text = ""
        '
        'txtStaff_ID
        '
        Me.txtStaff_ID.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaff_ID.Location = New System.Drawing.Point(182, 5)
        Me.txtStaff_ID.Multiline = False
        Me.txtStaff_ID.Name = "txtStaff_ID"
        Me.txtStaff_ID.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtStaff_ID.Size = New System.Drawing.Size(168, 30)
        Me.txtStaff_ID.TabIndex = 19
        Me.txtStaff_ID.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 24)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "ຜູ້ຕິດຕໍ່ພົວພັນ:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 24)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ເບີໂທລະສັບ:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ແຂວງ:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ເມືອງ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ບ້ານ:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ຖະໜົນ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ຊື່ ພະນັກງານ(ອັງກິດ):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ຊື່ ພະນັກງານ(ລາວ):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ລະຫັດພະນັກງານ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 33)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "ເຊື່ອງຊ່ອງປ້ອນຂໍ້ມູນ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PnL2
        '
        Me.PnL2.Controls.Add(Me.Button2)
        Me.PnL2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnL2.Location = New System.Drawing.Point(468, 1)
        Me.PnL2.Name = "PnL2"
        Me.PnL2.Size = New System.Drawing.Size(153, 33)
        Me.PnL2.TabIndex = 19
        Me.PnL2.Visible = False
        '
        'BtnShow
        '
        Me.BtnShow.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnShow.Location = New System.Drawing.Point(468, 1)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(153, 33)
        Me.BtnShow.TabIndex = 47
        Me.BtnShow.Text = "ສະແດງຊ່ອງປ້ອນຂໍ້ມູນ"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.APInvioce.My.Resources.Resources.preview_f2
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(625, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 33)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "ພີມ/ວີວ"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'FrmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(846, 520)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PnL2)
        Me.Controls.Add(Me.Pnl)
        Me.Controls.Add(Me.Fg1)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmStaff"
        Me.Text = "Staff"
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl.ResumeLayout(False)
        CType(Me.Fg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnL2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Fg1 As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PnL2 As System.Windows.Forms.Panel
    Friend WithEvents txtContact_pp As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPhone As System.Windows.Forms.RichTextBox
    Friend WithEvents txtProvince As System.Windows.Forms.RichTextBox
    Friend WithEvents txtDistrict As System.Windows.Forms.RichTextBox
    Friend WithEvents txtStaff_ID As System.Windows.Forms.RichTextBox
    Friend WithEvents txtVillage As System.Windows.Forms.RichTextBox
    Friend WithEvents txtStreet As System.Windows.Forms.RichTextBox
    Friend WithEvents txtStaffNmE As System.Windows.Forms.RichTextBox
    Friend WithEvents txtStaffNmL As System.Windows.Forms.RichTextBox
    Friend WithEvents Fg2 As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
