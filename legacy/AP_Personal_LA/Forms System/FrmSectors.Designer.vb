<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSectors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSectors))
        Me.PnL2 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnShow = New System.Windows.Forms.Button
        Me.Fg1 = New AxVSFlex8U.AxVSFlexGrid
        Me.Pnl1 = New System.Windows.Forms.Panel
        Me.txtContact_PP = New System.Windows.Forms.RichTextBox
        Me.txtFax = New System.Windows.Forms.RichTextBox
        Me.txtphone = New System.Windows.Forms.RichTextBox
        Me.txtSec_nmE = New System.Windows.Forms.RichTextBox
        Me.txtSec_nmL = New System.Windows.Forms.RichTextBox
        Me.txtSec_id = New System.Windows.Forms.RichTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Fg2 = New AxVSFlex8U.AxVSFlexGrid
        Me.txtaddress = New System.Windows.Forms.RichTextBox
        Me.txtremark = New System.Windows.Forms.RichTextBox
        Me.ChFor_Shop = New System.Windows.Forms.CheckBox
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmb_sakha = New System.Windows.Forms.ComboBox
        Me.txtsakha_id = New System.Windows.Forms.RichTextBox
        Me.PnL2.SuspendLayout()
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl1.SuspendLayout()
        CType(Me.Fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnL2
        '
        Me.PnL2.Controls.Add(Me.Button2)
        Me.PnL2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnL2.Location = New System.Drawing.Point(444, -2)
        Me.PnL2.Name = "PnL2"
        Me.PnL2.Size = New System.Drawing.Size(201, 42)
        Me.PnL2.TabIndex = 49
        Me.PnL2.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(-1, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 35)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "ເຊື່ອງຊ່ອງປ້ອນຂໍ້ມູນ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnShow
        '
        Me.BtnShow.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnShow.Location = New System.Drawing.Point(444, 2)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(153, 34)
        Me.BtnShow.TabIndex = 54
        Me.BtnShow.Text = "ສະແດງຊ່ອງປ້ອນຂໍ້ມູນ"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'Fg1
        '
        Me.Fg1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fg1.DataSource = Nothing
        Me.Fg1.Location = New System.Drawing.Point(4, 46)
        Me.Fg1.Name = "Fg1"
        Me.Fg1.OcxState = CType(resources.GetObject("Fg1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg1.Size = New System.Drawing.Size(947, 435)
        Me.Fg1.TabIndex = 55
        '
        'Pnl1
        '
        Me.Pnl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl1.Controls.Add(Me.txtsakha_id)
        Me.Pnl1.Controls.Add(Me.cmb_sakha)
        Me.Pnl1.Controls.Add(Me.Label9)
        Me.Pnl1.Controls.Add(Me.txtContact_PP)
        Me.Pnl1.Controls.Add(Me.txtFax)
        Me.Pnl1.Controls.Add(Me.txtphone)
        Me.Pnl1.Controls.Add(Me.txtSec_nmE)
        Me.Pnl1.Controls.Add(Me.txtSec_nmL)
        Me.Pnl1.Controls.Add(Me.txtSec_id)
        Me.Pnl1.Controls.Add(Me.Label8)
        Me.Pnl1.Controls.Add(Me.Label7)
        Me.Pnl1.Controls.Add(Me.Label6)
        Me.Pnl1.Controls.Add(Me.Label5)
        Me.Pnl1.Controls.Add(Me.Label4)
        Me.Pnl1.Controls.Add(Me.Label3)
        Me.Pnl1.Controls.Add(Me.Label2)
        Me.Pnl1.Controls.Add(Me.Label1)
        Me.Pnl1.Controls.Add(Me.Fg2)
        Me.Pnl1.Controls.Add(Me.txtaddress)
        Me.Pnl1.Controls.Add(Me.txtremark)
        Me.Pnl1.Controls.Add(Me.ChFor_Shop)
        Me.Pnl1.Location = New System.Drawing.Point(4, 46)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(947, 425)
        Me.Pnl1.TabIndex = 56
        Me.Pnl1.Visible = False
        '
        'txtContact_PP
        '
        Me.txtContact_PP.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact_PP.Location = New System.Drawing.Point(141, 303)
        Me.txtContact_PP.Multiline = False
        Me.txtContact_PP.Name = "txtContact_PP"
        Me.txtContact_PP.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtContact_PP.Size = New System.Drawing.Size(302, 30)
        Me.txtContact_PP.TabIndex = 23
        Me.txtContact_PP.Text = ""
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(141, 270)
        Me.txtFax.Multiline = False
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtFax.Size = New System.Drawing.Size(302, 30)
        Me.txtFax.TabIndex = 22
        Me.txtFax.Text = ""
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(141, 237)
        Me.txtphone.Multiline = False
        Me.txtphone.Name = "txtphone"
        Me.txtphone.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtphone.Size = New System.Drawing.Size(302, 30)
        Me.txtphone.TabIndex = 21
        Me.txtphone.Text = ""
        '
        'txtSec_nmE
        '
        Me.txtSec_nmE.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec_nmE.Location = New System.Drawing.Point(141, 105)
        Me.txtSec_nmE.Multiline = False
        Me.txtSec_nmE.Name = "txtSec_nmE"
        Me.txtSec_nmE.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtSec_nmE.Size = New System.Drawing.Size(302, 30)
        Me.txtSec_nmE.TabIndex = 20
        Me.txtSec_nmE.Text = ""
        '
        'txtSec_nmL
        '
        Me.txtSec_nmL.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec_nmL.Location = New System.Drawing.Point(141, 72)
        Me.txtSec_nmL.Multiline = False
        Me.txtSec_nmL.Name = "txtSec_nmL"
        Me.txtSec_nmL.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtSec_nmL.Size = New System.Drawing.Size(302, 30)
        Me.txtSec_nmL.TabIndex = 19
        Me.txtSec_nmL.Text = ""
        '
        'txtSec_id
        '
        Me.txtSec_id.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec_id.Location = New System.Drawing.Point(141, 39)
        Me.txtSec_id.Multiline = False
        Me.txtSec_id.Name = "txtSec_id"
        Me.txtSec_id.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtSec_id.Size = New System.Drawing.Size(140, 30)
        Me.txtSec_id.TabIndex = 18
        Me.txtSec_id.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-1, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 24)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "ໝາຍເຫດ:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ຜູ້ຕິດຕໍ່ພົວພັນ:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-1, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ເບີໂທລະສານ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-1, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ເບີໂທລະສັບ:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ທີ່ຢູ່:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ຊື່ ພາກສ່ວນ(ອັງກິດ):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ຊື່ ພາກສ່ວນ(ລາວ):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ລະຫັດພາກສ່ວນ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fg2
        '
        Me.Fg2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fg2.DataSource = Nothing
        Me.Fg2.Location = New System.Drawing.Point(453, -2)
        Me.Fg2.Name = "Fg2"
        Me.Fg2.OcxState = CType(resources.GetObject("Fg2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg2.Size = New System.Drawing.Size(494, 435)
        Me.Fg2.TabIndex = 8
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(141, 138)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtaddress.Size = New System.Drawing.Size(302, 96)
        Me.txtaddress.TabIndex = 7
        Me.txtaddress.Text = ""
        '
        'txtremark
        '
        Me.txtremark.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremark.Location = New System.Drawing.Point(141, 336)
        Me.txtremark.Name = "txtremark"
        Me.txtremark.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtremark.Size = New System.Drawing.Size(302, 78)
        Me.txtremark.TabIndex = 6
        Me.txtremark.Text = ""
        '
        'ChFor_Shop
        '
        Me.ChFor_Shop.AutoSize = True
        Me.ChFor_Shop.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChFor_Shop.Location = New System.Drawing.Point(268, 329)
        Me.ChFor_Shop.Name = "ChFor_Shop"
        Me.ChFor_Shop.Size = New System.Drawing.Size(112, 28)
        Me.ChFor_Shop.TabIndex = 9
        Me.ChFor_Shop.Text = "ສໍາລັບຮ້ານຄ້າ"
        Me.ChFor_Shop.UseVisualStyleBackColor = True
        Me.ChFor_Shop.Visible = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.APInvioce.My.Resources.Resources.Edit
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(248, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(96, 34)
        Me.BtnEdit.TabIndex = 53
        Me.BtnEdit.Text = "ແກ້ໄຂ"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(347, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(95, 34)
        Me.Button7.TabIndex = 52
        Me.Button7.Text = "ລຶບ"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.APInvioce.My.Resources.Resources.save_f2
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(147, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 34)
        Me.BtnSave.TabIndex = 51
        Me.BtnSave.Text = "ບັນທຶກ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.APInvioce.My.Resources.Resources.New2
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(49, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 34)
        Me.Button9.TabIndex = 50
        Me.Button9.Text = "ເພີ່ມໃໝ່"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button1.Location = New System.Drawing.Point(4, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 34)
        Me.Button1.TabIndex = 48
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(69, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 24)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "ສາຂາ:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_sakha
        '
        Me.cmb_sakha.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_sakha.FormattingEnabled = True
        Me.cmb_sakha.Items.AddRange(New Object() {"ສາຂາພາຍໃນ", "ສາຂາຕ່າງປະເທດ"})
        Me.cmb_sakha.Location = New System.Drawing.Point(141, 5)
        Me.cmb_sakha.Name = "cmb_sakha"
        Me.cmb_sakha.Size = New System.Drawing.Size(306, 32)
        Me.cmb_sakha.TabIndex = 25
        '
        'txtsakha_id
        '
        Me.txtsakha_id.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsakha_id.Location = New System.Drawing.Point(22, 5)
        Me.txtsakha_id.Multiline = False
        Me.txtsakha_id.Name = "txtsakha_id"
        Me.txtsakha_id.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtsakha_id.Size = New System.Drawing.Size(41, 30)
        Me.txtsakha_id.TabIndex = 26
        Me.txtsakha_id.Text = ""
        Me.txtsakha_id.Visible = False
        '
        'FrmSectors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 470)
        Me.Controls.Add(Me.PnL2)
        Me.Controls.Add(Me.Pnl1)
        Me.Controls.Add(Me.Fg1)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmSectors"
        Me.Text = "Section"
        Me.PnL2.ResumeLayout(False)
        CType(Me.Fg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl1.ResumeLayout(False)
        Me.Pnl1.PerformLayout()
        CType(Me.Fg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnL2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Fg1 As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents txtremark As System.Windows.Forms.RichTextBox
    Friend WithEvents ChFor_Shop As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSec_nmE As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSec_nmL As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSec_id As System.Windows.Forms.RichTextBox
    Friend WithEvents txtContact_PP As System.Windows.Forms.RichTextBox
    Friend WithEvents txtFax As System.Windows.Forms.RichTextBox
    Friend WithEvents txtphone As System.Windows.Forms.RichTextBox
    Friend WithEvents Fg2 As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtsakha_id As System.Windows.Forms.RichTextBox
    Friend WithEvents cmb_sakha As System.Windows.Forms.ComboBox
End Class
