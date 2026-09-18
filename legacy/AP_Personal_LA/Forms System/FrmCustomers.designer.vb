<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomers))
        Me.Fg1 = New AxVSFlex8U.AxVSFlexGrid
        Me.PnL2 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnShow = New System.Windows.Forms.Button
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtRemark = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.fg2 = New AxVSFlex8U.AxVSFlexGrid
        Me.txtLst_order = New System.Windows.Forms.RichTextBox
        Me.Pnl1 = New System.Windows.Forms.Panel
        Me.TxtPV_NM = New System.Windows.Forms.ComboBox
        Me.TxtDt_Nm = New System.Windows.Forms.ComboBox
        Me.txtVillage_nm = New System.Windows.Forms.ComboBox
        Me.txtProvince = New System.Windows.Forms.RichTextBox
        Me.txtDistrict = New System.Windows.Forms.RichTextBox
        Me.txtVillage = New System.Windows.Forms.RichTextBox
        Me.txtPhone = New System.Windows.Forms.RichTextBox
        Me.txtstreet = New System.Windows.Forms.RichTextBox
        Me.txtCust_nmE = New System.Windows.Forms.RichTextBox
        Me.txtCust_id = New System.Windows.Forms.RichTextBox
        Me.txtCust_nmL = New System.Windows.Forms.RichTextBox
        Me.txtContact_PP = New System.Windows.Forms.RichTextBox
        Me.txtCty_id = New System.Windows.Forms.RichTextBox
        Me.txtCty_Nm = New System.Windows.Forms.RichTextBox
        Me.txtFax = New System.Windows.Forms.RichTextBox
        Me.txtCust_Depart = New System.Windows.Forms.RichTextBox
        Me.txtBank_accnt = New System.Windows.Forms.RichTextBox
        Me.Label15 = New System.Windows.Forms.Label
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnL2.SuspendLayout()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fg1
        '
        Me.Fg1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fg1.Location = New System.Drawing.Point(4, 33)
        Me.Fg1.Name = "Fg1"
        Me.Fg1.OcxState = CType(resources.GetObject("Fg1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg1.Size = New System.Drawing.Size(906, 553)
        Me.Fg1.TabIndex = 62
        '
        'PnL2
        '
        Me.PnL2.Controls.Add(Me.Button2)
        Me.PnL2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnL2.Location = New System.Drawing.Point(462, 1)
        Me.PnL2.Name = "PnL2"
        Me.PnL2.Size = New System.Drawing.Size(153, 30)
        Me.PnL2.TabIndex = 123
        Me.PnL2.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 30)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "ເຊື່ອງຊ່ອງປ້ອນຂໍ້ມູນ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnShow
        '
        Me.BtnShow.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnShow.Location = New System.Drawing.Point(462, 1)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(153, 30)
        Me.BtnShow.TabIndex = 129
        Me.BtnShow.Text = "ສະແດງຊ່ອງປ້ອນຂໍ້ມູນ"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.APInvioce.My.Resources.Resources.Edit
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(245, 1)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(105, 30)
        Me.BtnEdit.TabIndex = 128
        Me.BtnEdit.Text = "ແກ້ໄຂ"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(351, 1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(109, 30)
        Me.Button7.TabIndex = 127
        Me.Button7.Text = "ລຶບ"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.APInvioce.My.Resources.Resources.save_f2
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(135, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(109, 30)
        Me.BtnSave.TabIndex = 126
        Me.BtnSave.Text = "ບັນທຶກ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.APInvioce.My.Resources.Resources.New2
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(42, 1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(92, 30)
        Me.Button9.TabIndex = 125
        Me.Button9.Text = "ເພີ່ມໃໝ່"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button1.Location = New System.Drawing.Point(4, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 122
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(172, 302)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtRemark.Size = New System.Drawing.Size(273, 71)
        Me.txtRemark.TabIndex = 47
        Me.txtRemark.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "ລະຫັດລູກຄ້າ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 24)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "ຊື່ ລູກຄ້າ(ລາວ):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-2, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 24)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "ຊື່ ລູກຄ້າ(ອັງກິດ):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(-2, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 24)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "ຖະໜົນ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-3, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 24)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "ເບີໂທລະສັບ:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(454, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 24)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "ເບີໂທລະສານ:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(454, 400)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(173, 24)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "ປະເພດລູກຄ້າ:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-5, 302)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(173, 24)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "ໝາຍເຫດ:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(454, 365)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 24)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "ບັນຊີທະນາຄານ:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(454, 432)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(173, 24)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "ວັນທີ່ສັ່ງຊື້ລ່າສຸດ:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-2, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 24)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "ເຮືອນເລກທີ່:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-3, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 24)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "ເມືອງ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-3, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 24)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "ບ້ານ:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-2, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 24)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "ແຂວງ:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button3.Location = New System.Drawing.Point(721, 395)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 33)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'fg2
        '
        Me.fg2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg2.Location = New System.Drawing.Point(451, -2)
        Me.fg2.Name = "fg2"
        Me.fg2.OcxState = CType(resources.GetObject("fg2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fg2.Size = New System.Drawing.Size(453, 553)
        Me.fg2.TabIndex = 73
        '
        'txtLst_order
        '
        Me.txtLst_order.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLst_order.Location = New System.Drawing.Point(631, 431)
        Me.txtLst_order.Name = "txtLst_order"
        Me.txtLst_order.ReadOnly = True
        Me.txtLst_order.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtLst_order.Size = New System.Drawing.Size(274, 29)
        Me.txtLst_order.TabIndex = 74
        Me.txtLst_order.Text = ""
        '
        'Pnl1
        '
        Me.Pnl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl1.Controls.Add(Me.TxtPV_NM)
        Me.Pnl1.Controls.Add(Me.TxtDt_Nm)
        Me.Pnl1.Controls.Add(Me.txtVillage_nm)
        Me.Pnl1.Controls.Add(Me.txtProvince)
        Me.Pnl1.Controls.Add(Me.txtDistrict)
        Me.Pnl1.Controls.Add(Me.txtVillage)
        Me.Pnl1.Controls.Add(Me.txtPhone)
        Me.Pnl1.Controls.Add(Me.txtstreet)
        Me.Pnl1.Controls.Add(Me.txtCust_nmE)
        Me.Pnl1.Controls.Add(Me.txtCust_id)
        Me.Pnl1.Controls.Add(Me.txtCust_nmL)
        Me.Pnl1.Controls.Add(Me.txtContact_PP)
        Me.Pnl1.Controls.Add(Me.fg2)
        Me.Pnl1.Controls.Add(Me.Label7)
        Me.Pnl1.Controls.Add(Me.Label5)
        Me.Pnl1.Controls.Add(Me.Label6)
        Me.Pnl1.Controls.Add(Me.Label11)
        Me.Pnl1.Controls.Add(Me.Label14)
        Me.Pnl1.Controls.Add(Me.Label8)
        Me.Pnl1.Controls.Add(Me.Label4)
        Me.Pnl1.Controls.Add(Me.Label3)
        Me.Pnl1.Controls.Add(Me.Label2)
        Me.Pnl1.Controls.Add(Me.Label1)
        Me.Pnl1.Controls.Add(Me.txtRemark)
        Me.Pnl1.Controls.Add(Me.txtCty_id)
        Me.Pnl1.Controls.Add(Me.txtCty_Nm)
        Me.Pnl1.Controls.Add(Me.txtFax)
        Me.Pnl1.Controls.Add(Me.txtCust_Depart)
        Me.Pnl1.Controls.Add(Me.txtBank_accnt)
        Me.Pnl1.Controls.Add(Me.txtLst_order)
        Me.Pnl1.Controls.Add(Me.Button3)
        Me.Pnl1.Controls.Add(Me.Label13)
        Me.Pnl1.Controls.Add(Me.Label10)
        Me.Pnl1.Controls.Add(Me.Label12)
        Me.Pnl1.Controls.Add(Me.Label9)
        Me.Pnl1.Controls.Add(Me.Label15)
        Me.Pnl1.Location = New System.Drawing.Point(4, 33)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(906, 553)
        Me.Pnl1.TabIndex = 63
        Me.Pnl1.Visible = False
        '
        'TxtPV_NM
        '
        Me.TxtPV_NM.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPV_NM.FormattingEnabled = True
        Me.TxtPV_NM.Location = New System.Drawing.Point(256, 168)
        Me.TxtPV_NM.Name = "TxtPV_NM"
        Me.TxtPV_NM.Size = New System.Drawing.Size(192, 32)
        Me.TxtPV_NM.TabIndex = 98
        '
        'TxtDt_Nm
        '
        Me.TxtDt_Nm.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDt_Nm.FormattingEnabled = True
        Me.TxtDt_Nm.Location = New System.Drawing.Point(255, 200)
        Me.TxtDt_Nm.Name = "TxtDt_Nm"
        Me.TxtDt_Nm.Size = New System.Drawing.Size(192, 32)
        Me.TxtDt_Nm.TabIndex = 97
        '
        'txtVillage_nm
        '
        Me.txtVillage_nm.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVillage_nm.FormattingEnabled = True
        Me.txtVillage_nm.Location = New System.Drawing.Point(255, 234)
        Me.txtVillage_nm.Name = "txtVillage_nm"
        Me.txtVillage_nm.Size = New System.Drawing.Size(192, 32)
        Me.txtVillage_nm.TabIndex = 96
        '
        'txtProvince
        '
        Me.txtProvince.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(173, 169)
        Me.txtProvince.Multiline = False
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtProvince.Size = New System.Drawing.Size(80, 29)
        Me.txtProvince.TabIndex = 95
        Me.txtProvince.Text = ""
        '
        'txtDistrict
        '
        Me.txtDistrict.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistrict.Location = New System.Drawing.Point(173, 202)
        Me.txtDistrict.Multiline = False
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtDistrict.Size = New System.Drawing.Size(80, 29)
        Me.txtDistrict.TabIndex = 94
        Me.txtDistrict.Text = ""
        '
        'txtVillage
        '
        Me.txtVillage.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVillage.Location = New System.Drawing.Point(172, 236)
        Me.txtVillage.Multiline = False
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtVillage.Size = New System.Drawing.Size(80, 29)
        Me.txtVillage.TabIndex = 93
        Me.txtVillage.Text = ""
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(172, 270)
        Me.txtPhone.Multiline = False
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtPhone.Size = New System.Drawing.Size(275, 29)
        Me.txtPhone.TabIndex = 86
        Me.txtPhone.Text = ""
        '
        'txtstreet
        '
        Me.txtstreet.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstreet.Location = New System.Drawing.Point(175, 135)
        Me.txtstreet.Multiline = False
        Me.txtstreet.Name = "txtstreet"
        Me.txtstreet.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtstreet.Size = New System.Drawing.Size(273, 29)
        Me.txtstreet.TabIndex = 82
        Me.txtstreet.Text = ""
        '
        'txtCust_nmE
        '
        Me.txtCust_nmE.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCust_nmE.Location = New System.Drawing.Point(175, 70)
        Me.txtCust_nmE.Multiline = False
        Me.txtCust_nmE.Name = "txtCust_nmE"
        Me.txtCust_nmE.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtCust_nmE.Size = New System.Drawing.Size(273, 29)
        Me.txtCust_nmE.TabIndex = 81
        Me.txtCust_nmE.Text = ""
        '
        'txtCust_id
        '
        Me.txtCust_id.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCust_id.Location = New System.Drawing.Point(175, 6)
        Me.txtCust_id.Multiline = False
        Me.txtCust_id.Name = "txtCust_id"
        Me.txtCust_id.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtCust_id.Size = New System.Drawing.Size(169, 29)
        Me.txtCust_id.TabIndex = 80
        Me.txtCust_id.Text = ""
        '
        'txtCust_nmL
        '
        Me.txtCust_nmL.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCust_nmL.Location = New System.Drawing.Point(175, 38)
        Me.txtCust_nmL.Multiline = False
        Me.txtCust_nmL.Name = "txtCust_nmL"
        Me.txtCust_nmL.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtCust_nmL.Size = New System.Drawing.Size(273, 29)
        Me.txtCust_nmL.TabIndex = 79
        Me.txtCust_nmL.Text = ""
        '
        'txtContact_PP
        '
        Me.txtContact_PP.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact_PP.Location = New System.Drawing.Point(175, 102)
        Me.txtContact_PP.Multiline = False
        Me.txtContact_PP.Name = "txtContact_PP"
        Me.txtContact_PP.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtContact_PP.Size = New System.Drawing.Size(273, 29)
        Me.txtContact_PP.TabIndex = 77
        Me.txtContact_PP.Text = ""
        '
        'txtCty_id
        '
        Me.txtCty_id.BackColor = System.Drawing.Color.White
        Me.txtCty_id.Location = New System.Drawing.Point(631, 396)
        Me.txtCty_id.Multiline = False
        Me.txtCty_id.Name = "txtCty_id"
        Me.txtCty_id.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtCty_id.Size = New System.Drawing.Size(89, 32)
        Me.txtCty_id.TabIndex = 92
        Me.txtCty_id.Text = ""
        '
        'txtCty_Nm
        '
        Me.txtCty_Nm.BackColor = System.Drawing.Color.White
        Me.txtCty_Nm.Location = New System.Drawing.Point(754, 395)
        Me.txtCty_Nm.Multiline = False
        Me.txtCty_Nm.Name = "txtCty_Nm"
        Me.txtCty_Nm.ReadOnly = True
        Me.txtCty_Nm.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtCty_Nm.Size = New System.Drawing.Size(150, 32)
        Me.txtCty_Nm.TabIndex = 89
        Me.txtCty_Nm.Text = ""
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(631, 332)
        Me.txtFax.Multiline = False
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtFax.Size = New System.Drawing.Size(273, 29)
        Me.txtFax.TabIndex = 87
        Me.txtFax.Text = ""
        '
        'txtCust_Depart
        '
        Me.txtCust_Depart.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCust_Depart.Location = New System.Drawing.Point(631, 108)
        Me.txtCust_Depart.Multiline = False
        Me.txtCust_Depart.Name = "txtCust_Depart"
        Me.txtCust_Depart.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtCust_Depart.Size = New System.Drawing.Size(273, 29)
        Me.txtCust_Depart.TabIndex = 79
        Me.txtCust_Depart.Text = ""
        '
        'txtBank_accnt
        '
        Me.txtBank_accnt.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBank_accnt.Location = New System.Drawing.Point(631, 364)
        Me.txtBank_accnt.Multiline = False
        Me.txtBank_accnt.Name = "txtBank_accnt"
        Me.txtBank_accnt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtBank_accnt.Size = New System.Drawing.Size(273, 29)
        Me.txtBank_accnt.TabIndex = 78
        Me.txtBank_accnt.Text = ""
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(454, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(173, 24)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "ພາກສ່ວນ :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(912, 587)
        Me.ControlBox = False
        Me.Controls.Add(Me.PnL2)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pnl1)
        Me.Controls.Add(Me.Fg1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmCustomers"
        Me.Text = "Customers"
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnL2.ResumeLayout(False)
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fg1 As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents PnL2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtRemark As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg2 As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents txtLst_order As System.Windows.Forms.RichTextBox
    Friend WithEvents Pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtBank_accnt As System.Windows.Forms.RichTextBox
    Friend WithEvents txtContact_PP As System.Windows.Forms.RichTextBox
    Friend WithEvents txtFax As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPhone As System.Windows.Forms.RichTextBox
    Friend WithEvents txtstreet As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCust_nmE As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCust_id As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCust_nmL As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCty_Nm As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCty_id As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCust_Depart As System.Windows.Forms.RichTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtProvince As System.Windows.Forms.RichTextBox
    Friend WithEvents txtDistrict As System.Windows.Forms.RichTextBox
    Friend WithEvents txtVillage As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtPV_NM As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDt_Nm As System.Windows.Forms.ComboBox
    Friend WithEvents txtVillage_nm As System.Windows.Forms.ComboBox
End Class
