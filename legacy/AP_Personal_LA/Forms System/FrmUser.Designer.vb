<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUser))
        Me.txtUsr_id = New System.Windows.Forms.TextBox
        Me.txtConfrim = New System.Windows.Forms.TextBox
        Me.txtPWD = New System.Windows.Forms.TextBox
        Me.txtUsr_nm = New System.Windows.Forms.TextBox
        Me.CheckWrite_bit = New System.Windows.Forms.CheckBox
        Me.CheckDelete_bit = New System.Windows.Forms.CheckBox
        Me.CheckEdit_bit = New System.Windows.Forms.CheckBox
        Me.cmbpermision = New System.Windows.Forms.ComboBox
        Me.cmbUsrPermit = New System.Windows.Forms.ComboBox
        Me.lblID = New System.Windows.Forms.Label
        Me.lblNm = New System.Windows.Forms.Label
        Me.lblPass = New System.Windows.Forms.Label
        Me.lblConfirm = New System.Windows.Forms.Label
        Me.lblPermission = New System.Windows.Forms.Label
        Me.lblSec = New System.Windows.Forms.Label
        Me.lblPermissions = New System.Windows.Forms.Label
        Me.Fg = New AxVSFlex8U.AxVSFlexGrid
        Me.txtDep_ID = New System.Windows.Forms.TextBox
        Me.txtDep_Nm = New System.Windows.Forms.TextBox
        Me.ChkForStaff = New System.Windows.Forms.CheckBox
        Me.txtStff_Id = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblText_encrypt = New System.Windows.Forms.Label
        Me.txtEncrypt = New System.Windows.Forms.TextBox
        Me.TxtPV_NM = New System.Windows.Forms.ComboBox
        Me.txtProvince_id = New System.Windows.Forms.RichTextBox
        Me.Cmb_hospital = New System.Windows.Forms.ComboBox
        Me.txt_hospital_id = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbDist = New System.Windows.Forms.ComboBox
        Me.txtDis_id = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cmb_HSV = New System.Windows.Forms.ComboBox
        Me.txtHSV_id = New System.Windows.Forms.TextBox
        Me.Chk_hospital = New System.Windows.Forms.CheckBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txtpermision_id = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.Fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsr_id
        '
        Me.txtUsr_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsr_id.Location = New System.Drawing.Point(155, 57)
        Me.txtUsr_id.Name = "txtUsr_id"
        Me.txtUsr_id.Size = New System.Drawing.Size(188, 35)
        Me.txtUsr_id.TabIndex = 0
        '
        'txtConfrim
        '
        Me.txtConfrim.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfrim.Location = New System.Drawing.Point(486, 131)
        Me.txtConfrim.Name = "txtConfrim"
        Me.txtConfrim.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfrim.Size = New System.Drawing.Size(186, 35)
        Me.txtConfrim.TabIndex = 69
        '
        'txtPWD
        '
        Me.txtPWD.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPWD.Location = New System.Drawing.Point(486, 93)
        Me.txtPWD.Name = "txtPWD"
        Me.txtPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPWD.Size = New System.Drawing.Size(185, 35)
        Me.txtPWD.TabIndex = 70
        '
        'txtUsr_nm
        '
        Me.txtUsr_nm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsr_nm.Location = New System.Drawing.Point(155, 94)
        Me.txtUsr_nm.Name = "txtUsr_nm"
        Me.txtUsr_nm.Size = New System.Drawing.Size(188, 35)
        Me.txtUsr_nm.TabIndex = 71
        '
        'CheckWrite_bit
        '
        Me.CheckWrite_bit.AutoSize = True
        Me.CheckWrite_bit.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckWrite_bit.Location = New System.Drawing.Point(1188, 103)
        Me.CheckWrite_bit.Name = "CheckWrite_bit"
        Me.CheckWrite_bit.Size = New System.Drawing.Size(66, 28)
        Me.CheckWrite_bit.TabIndex = 72
        Me.CheckWrite_bit.Text = "Write"
        Me.CheckWrite_bit.UseVisualStyleBackColor = True
        Me.CheckWrite_bit.Visible = False
        '
        'CheckDelete_bit
        '
        Me.CheckDelete_bit.AutoSize = True
        Me.CheckDelete_bit.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDelete_bit.Location = New System.Drawing.Point(1188, 174)
        Me.CheckDelete_bit.Name = "CheckDelete_bit"
        Me.CheckDelete_bit.Size = New System.Drawing.Size(76, 28)
        Me.CheckDelete_bit.TabIndex = 73
        Me.CheckDelete_bit.Text = "Delete"
        Me.CheckDelete_bit.UseVisualStyleBackColor = True
        Me.CheckDelete_bit.Visible = False
        '
        'CheckEdit_bit
        '
        Me.CheckEdit_bit.AutoSize = True
        Me.CheckEdit_bit.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit_bit.Location = New System.Drawing.Point(1188, 139)
        Me.CheckEdit_bit.Name = "CheckEdit_bit"
        Me.CheckEdit_bit.Size = New System.Drawing.Size(57, 28)
        Me.CheckEdit_bit.TabIndex = 74
        Me.CheckEdit_bit.Text = "Edit"
        Me.CheckEdit_bit.UseVisualStyleBackColor = True
        Me.CheckEdit_bit.Visible = False
        '
        'cmbpermision
        '
        Me.cmbpermision.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpermision.FormattingEnabled = True
        Me.cmbpermision.Items.AddRange(New Object() {"Admin", "SupAdmin", "Pro-Super", "Pro-User", "Dis-Super", "Dis-User", "Visitor"})
        Me.cmbpermision.Location = New System.Drawing.Point(486, 60)
        Me.cmbpermision.Name = "cmbpermision"
        Me.cmbpermision.Size = New System.Drawing.Size(186, 32)
        Me.cmbpermision.TabIndex = 75
        Me.cmbpermision.Text = "Admin"
        '
        'cmbUsrPermit
        '
        Me.cmbUsrPermit.FormattingEnabled = True
        Me.cmbUsrPermit.Items.AddRange(New Object() {"Administrator", "User"})
        Me.cmbUsrPermit.Location = New System.Drawing.Point(403, -33)
        Me.cmbUsrPermit.Name = "cmbUsrPermit"
        Me.cmbUsrPermit.Size = New System.Drawing.Size(133, 29)
        Me.cmbUsrPermit.TabIndex = 77
        Me.cmbUsrPermit.Text = "Administrator"
        Me.cmbUsrPermit.Visible = False
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(31, 58)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(108, 32)
        Me.lblID.TabIndex = 78
        Me.lblID.Text = "ລະຫັດຜູ້ໃຊ້:"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNm
        '
        Me.lblNm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNm.Location = New System.Drawing.Point(39, 96)
        Me.lblNm.Name = "lblNm"
        Me.lblNm.Size = New System.Drawing.Size(108, 33)
        Me.lblNm.TabIndex = 79
        Me.lblNm.Text = "ຊື່ຜູ້ໃຊ້:"
        Me.lblNm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPass
        '
        Me.lblPass.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(378, 95)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(108, 33)
        Me.lblPass.TabIndex = 80
        Me.lblPass.Text = "ລະຫັດຜ່ານ:"
        Me.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConfirm
        '
        Me.lblConfirm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.Location = New System.Drawing.Point(351, 131)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(131, 30)
        Me.lblConfirm.TabIndex = 81
        Me.lblConfirm.Text = "ຢໍ້າຄືນລະຫັດຜ່ານ:"
        Me.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPermission
        '
        Me.lblPermission.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermission.Location = New System.Drawing.Point(295, -30)
        Me.lblPermission.Name = "lblPermission"
        Me.lblPermission.Size = New System.Drawing.Size(101, 21)
        Me.lblPermission.TabIndex = 82
        Me.lblPermission.Text = "ສິດໃຊ້ໂປຣແກຣມ:"
        Me.lblPermission.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPermission.Visible = False
        '
        'lblSec
        '
        Me.lblSec.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.Location = New System.Drawing.Point(1303, 63)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(100, 32)
        Me.lblSec.TabIndex = 83
        Me.lblSec.Text = "ຊື່ພາກສ່ວນ:"
        Me.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSec.Visible = False
        '
        'lblPermissions
        '
        Me.lblPermissions.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermissions.Location = New System.Drawing.Point(349, 60)
        Me.lblPermissions.Name = "lblPermissions"
        Me.lblPermissions.Size = New System.Drawing.Size(135, 31)
        Me.lblPermissions.TabIndex = 85
        Me.lblPermissions.Text = "ສິດໃຊ້ໂປຣແກຣມ:"
        Me.lblPermissions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fg
        '
        Me.Fg.Location = New System.Drawing.Point(33, 172)
        Me.Fg.Name = "Fg"
        Me.Fg.OcxState = CType(resources.GetObject("Fg.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg.Size = New System.Drawing.Size(704, 390)
        Me.Fg.TabIndex = 86
        '
        'txtDep_ID
        '
        Me.txtDep_ID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDep_ID.Location = New System.Drawing.Point(1407, 61)
        Me.txtDep_ID.Multiline = True
        Me.txtDep_ID.Name = "txtDep_ID"
        Me.txtDep_ID.Size = New System.Drawing.Size(133, 32)
        Me.txtDep_ID.TabIndex = 93
        Me.txtDep_ID.Text = "1"
        Me.txtDep_ID.Visible = False
        '
        'txtDep_Nm
        '
        Me.txtDep_Nm.BackColor = System.Drawing.Color.White
        Me.txtDep_Nm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDep_Nm.Location = New System.Drawing.Point(1387, 23)
        Me.txtDep_Nm.Multiline = True
        Me.txtDep_Nm.Name = "txtDep_Nm"
        Me.txtDep_Nm.ReadOnly = True
        Me.txtDep_Nm.Size = New System.Drawing.Size(145, 32)
        Me.txtDep_Nm.TabIndex = 95
        Me.txtDep_Nm.Visible = False
        '
        'ChkForStaff
        '
        Me.ChkForStaff.AutoSize = True
        Me.ChkForStaff.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkForStaff.Location = New System.Drawing.Point(1188, 207)
        Me.ChkForStaff.Name = "ChkForStaff"
        Me.ChkForStaff.Size = New System.Drawing.Size(94, 28)
        Me.ChkForStaff.TabIndex = 96
        Me.ChkForStaff.Text = "For Staff"
        Me.ChkForStaff.UseVisualStyleBackColor = True
        Me.ChkForStaff.Visible = False
        '
        'txtStff_Id
        '
        Me.txtStff_Id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStff_Id.Location = New System.Drawing.Point(1189, 14)
        Me.txtStff_Id.Name = "txtStff_Id"
        Me.txtStff_Id.ReadOnly = True
        Me.txtStff_Id.Size = New System.Drawing.Size(103, 35)
        Me.txtStff_Id.TabIndex = 97
        Me.txtStff_Id.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 63)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "ກຳນົດສິດຜູ້ໃຊ້"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblText_encrypt
        '
        Me.lblText_encrypt.AutoSize = True
        Me.lblText_encrypt.Location = New System.Drawing.Point(1377, 85)
        Me.lblText_encrypt.Name = "lblText_encrypt"
        Me.lblText_encrypt.Size = New System.Drawing.Size(89, 21)
        Me.lblText_encrypt.TabIndex = 103
        Me.lblText_encrypt.Text = "SoUkSaVhAy"
        Me.lblText_encrypt.Visible = False
        '
        'txtEncrypt
        '
        Me.txtEncrypt.Location = New System.Drawing.Point(1368, 59)
        Me.txtEncrypt.Name = "txtEncrypt"
        Me.txtEncrypt.Size = New System.Drawing.Size(100, 30)
        Me.txtEncrypt.TabIndex = 104
        Me.txtEncrypt.Visible = False
        '
        'TxtPV_NM
        '
        Me.TxtPV_NM.Enabled = False
        Me.TxtPV_NM.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtPV_NM.FormattingEnabled = True
        Me.TxtPV_NM.Location = New System.Drawing.Point(155, 131)
        Me.TxtPV_NM.Name = "TxtPV_NM"
        Me.TxtPV_NM.Size = New System.Drawing.Size(188, 32)
        Me.TxtPV_NM.TabIndex = 45552
        '
        'txtProvince_id
        '
        Me.txtProvince_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProvince_id.Location = New System.Drawing.Point(1189, 55)
        Me.txtProvince_id.Multiline = False
        Me.txtProvince_id.Name = "txtProvince_id"
        Me.txtProvince_id.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtProvince_id.Size = New System.Drawing.Size(74, 29)
        Me.txtProvince_id.TabIndex = 45553
        Me.txtProvince_id.Text = ""
        Me.txtProvince_id.Visible = False
        '
        'Cmb_hospital
        '
        Me.Cmb_hospital.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmb_hospital.FormattingEnabled = True
        Me.Cmb_hospital.Location = New System.Drawing.Point(853, 190)
        Me.Cmb_hospital.Name = "Cmb_hospital"
        Me.Cmb_hospital.Size = New System.Drawing.Size(266, 32)
        Me.Cmb_hospital.TabIndex = 45554
        Me.Cmb_hospital.Visible = False
        '
        'txt_hospital_id
        '
        Me.txt_hospital_id.Location = New System.Drawing.Point(951, 231)
        Me.txt_hospital_id.Name = "txt_hospital_id"
        Me.txt_hospital_id.Size = New System.Drawing.Size(100, 30)
        Me.txt_hospital_id.TabIndex = 45555
        Me.txt_hospital_id.Visible = False
        '
        'Label3
        '
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 33)
        Me.Label3.TabIndex = 45556
        Me.Label3.Text = "ແຂວງ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(756, -4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 33)
        Me.Label5.TabIndex = 45560
        Me.Label5.Text = "ເມືອງ:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'cmbDist
        '
        Me.cmbDist.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbDist.FormattingEnabled = True
        Me.cmbDist.Location = New System.Drawing.Point(871, -2)
        Me.cmbDist.Name = "cmbDist"
        Me.cmbDist.Size = New System.Drawing.Size(227, 32)
        Me.cmbDist.TabIndex = 45559
        Me.cmbDist.Visible = False
        '
        'txtDis_id
        '
        Me.txtDis_id.Location = New System.Drawing.Point(951, 195)
        Me.txtDis_id.Name = "txtDis_id"
        Me.txtDis_id.Size = New System.Drawing.Size(100, 30)
        Me.txtDis_id.TabIndex = 45558
        Me.txtDis_id.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(756, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 33)
        Me.Label6.TabIndex = 45562
        Me.Label6.Text = "ສຸກສາລາ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label6.Visible = False
        '
        'Cmb_HSV
        '
        Me.Cmb_HSV.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmb_HSV.FormattingEnabled = True
        Me.Cmb_HSV.Location = New System.Drawing.Point(871, 33)
        Me.Cmb_HSV.Name = "Cmb_HSV"
        Me.Cmb_HSV.Size = New System.Drawing.Size(252, 32)
        Me.Cmb_HSV.TabIndex = 45561
        Me.Cmb_HSV.Visible = False
        '
        'txtHSV_id
        '
        Me.txtHSV_id.Location = New System.Drawing.Point(951, 267)
        Me.txtHSV_id.Name = "txtHSV_id"
        Me.txtHSV_id.Size = New System.Drawing.Size(100, 30)
        Me.txtHSV_id.TabIndex = 45563
        Me.txtHSV_id.Visible = False
        '
        'Chk_hospital
        '
        Me.Chk_hospital.AutoSize = True
        Me.Chk_hospital.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_hospital.Location = New System.Drawing.Point(778, 194)
        Me.Chk_hospital.Name = "Chk_hospital"
        Me.Chk_hospital.Size = New System.Drawing.Size(75, 28)
        Me.Chk_hospital.TabIndex = 45565
        Me.Chk_hospital.Text = "ໂຮງໝໍ:"
        Me.Chk_hospital.UseVisualStyleBackColor = True
        Me.Chk_hospital.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(1294, 82)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 28)
        Me.RadioButton1.TabIndex = 45568
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ໂຮງໝໍ:"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'txtpermision_id
        '
        Me.txtpermision_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpermision_id.Location = New System.Drawing.Point(742, 153)
        Me.txtpermision_id.Name = "txtpermision_id"
        Me.txtpermision_id.Size = New System.Drawing.Size(41, 35)
        Me.txtpermision_id.TabIndex = 45570
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button3.Location = New System.Drawing.Point(1223, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 35)
        Me.Button3.TabIndex = 100
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Search
        Me.Button1.Location = New System.Drawing.Point(1225, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 32)
        Me.Button1.TabIndex = 94
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BtnDel
        '
        Me.BtnDel.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.Image = Global.APInvioce.My.Resources.Resources.Delete
        Me.BtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDel.Location = New System.Drawing.Point(513, 268)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(91, 48)
        Me.BtnDel.TabIndex = 91
        Me.BtnDel.Text = "ລຶບ"
        Me.BtnDel.UseVisualStyleBackColor = True
        Me.BtnDel.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.APInvioce.My.Resources.Resources.Save
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(176, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(102, 49)
        Me.BtnSave.TabIndex = 90
        Me.BtnSave.Text = "ບັນທຶກ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Image = Global.APInvioce.My.Resources.Resources.AddNew
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(72, 2)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(98, 49)
        Me.BtnAddNew.TabIndex = 89
        Me.BtnAddNew.Text = "ເພີ່ມໃໝ່"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button2.Location = New System.Drawing.Point(5, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 49)
        Me.Button2.TabIndex = 88
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(955, 574)
        Me.Controls.Add(Me.Fg)
        Me.Controls.Add(Me.txtpermision_id)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Chk_hospital)
        Me.Controls.Add(Me.txtHSV_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cmb_HSV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbDist)
        Me.Controls.Add(Me.txtDis_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_hospital_id)
        Me.Controls.Add(Me.Cmb_hospital)
        Me.Controls.Add(Me.txtProvince_id)
        Me.Controls.Add(Me.TxtPV_NM)
        Me.Controls.Add(Me.txtUsr_id)
        Me.Controls.Add(Me.txtPWD)
        Me.Controls.Add(Me.txtConfrim)
        Me.Controls.Add(Me.txtEncrypt)
        Me.Controls.Add(Me.lblText_encrypt)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtStff_Id)
        Me.Controls.Add(Me.ChkForStaff)
        Me.Controls.Add(Me.txtDep_Nm)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDep_ID)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblPermissions)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.lblPermission)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblNm)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.cmbUsrPermit)
        Me.Controls.Add(Me.cmbpermision)
        Me.Controls.Add(Me.CheckEdit_bit)
        Me.Controls.Add(Me.CheckDelete_bit)
        Me.Controls.Add(Me.CheckWrite_bit)
        Me.Controls.Add(Me.txtUsr_nm)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmUser"
        Me.Text = "List of user"
        CType(Me.Fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsr_id As System.Windows.Forms.TextBox
    Friend WithEvents txtConfrim As System.Windows.Forms.TextBox
    Friend WithEvents txtPWD As System.Windows.Forms.TextBox
    Friend WithEvents txtUsr_nm As System.Windows.Forms.TextBox
    Friend WithEvents CheckWrite_bit As System.Windows.Forms.CheckBox
    Friend WithEvents CheckDelete_bit As System.Windows.Forms.CheckBox
    Friend WithEvents CheckEdit_bit As System.Windows.Forms.CheckBox
    Friend WithEvents cmbpermision As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUsrPermit As System.Windows.Forms.ComboBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblNm As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents lblPermission As System.Windows.Forms.Label
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents lblPermissions As System.Windows.Forms.Label
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Fg As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents txtDep_ID As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtDep_Nm As System.Windows.Forms.TextBox
    Friend WithEvents ChkForStaff As System.Windows.Forms.CheckBox
    Friend WithEvents txtStff_Id As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblText_encrypt As System.Windows.Forms.Label
    Friend WithEvents txtEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents TxtPV_NM As System.Windows.Forms.ComboBox
    Friend WithEvents txtProvince_id As System.Windows.Forms.RichTextBox
    Friend WithEvents Cmb_hospital As System.Windows.Forms.ComboBox
    Friend WithEvents txt_hospital_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDist As System.Windows.Forms.ComboBox
    Friend WithEvents txtDis_id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmb_HSV As System.Windows.Forms.ComboBox
    Friend WithEvents txtHSV_id As System.Windows.Forms.TextBox
    Friend WithEvents Chk_hospital As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtpermision_id As System.Windows.Forms.TextBox
End Class
