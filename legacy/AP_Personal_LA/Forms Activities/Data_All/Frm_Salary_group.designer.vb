<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Salary_group
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Salary_group))
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Txt_ID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtGroup_percen100 = New System.Windows.Forms.TextBox
        Me.fg = New AxVSFlex8U.AxVSFlexGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtPV_NM = New System.Windows.Forms.ComboBox
        Me.TxtPV_ID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnm = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtGroup_100 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtGroup_90 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtGroup_percen90 = New System.Windows.Forms.TextBox
        Me.txtGroup_80 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtGroup_percen80 = New System.Windows.Forms.TextBox
        Me.txtGroup_70 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtGroup_percen70 = New System.Windows.Forms.TextBox
        Me.txtGroup_60 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtGroup_percen60 = New System.Windows.Forms.TextBox
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(150, 3)
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
        Me.BtnAddNew.Location = New System.Drawing.Point(38, 3)
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
        Me.Button1.Location = New System.Drawing.Point(263, 3)
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
        Me.Txt_ID.Location = New System.Drawing.Point(99, 39)
        Me.Txt_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(111, 35)
        Me.Txt_ID.TabIndex = 339
        Me.Txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 42)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 25)
        Me.Label7.TabIndex = 338
        Me.Label7.Text = "ລະຫັດ:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroup_percen100
        '
        Me.txtGroup_percen100.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup_percen100.Location = New System.Drawing.Point(99, 112)
        Me.txtGroup_percen100.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGroup_percen100.Name = "txtGroup_percen100"
        Me.txtGroup_percen100.ReadOnly = True
        Me.txtGroup_percen100.Size = New System.Drawing.Size(111, 35)
        Me.txtGroup_percen100.TabIndex = 341
        Me.txtGroup_percen100.Text = "100"
        Me.txtGroup_percen100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fg
        '
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.DataSource = Nothing
        Me.fg.Location = New System.Drawing.Point(25, 292)
        Me.fg.Name = "fg"
        Me.fg.OcxState = CType(resources.GetObject("fg.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fg.Size = New System.Drawing.Size(871, 362)
        Me.fg.TabIndex = 342
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 29)
        Me.Label1.TabIndex = 343
        Me.Label1.Text = "ໄດ້ຮັບເງີນ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(393, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(447, 41)
        Me.Label2.TabIndex = 344
        Me.Label2.Text = "ຕັ້ງສູດຄິດໄລ່ລະດັບເງີນເດືອນ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtPV_NM
        '
        Me.TxtPV_NM.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPV_NM.FormattingEnabled = True
        Me.TxtPV_NM.Location = New System.Drawing.Point(523, 333)
        Me.TxtPV_NM.Name = "TxtPV_NM"
        Me.TxtPV_NM.Size = New System.Drawing.Size(337, 32)
        Me.TxtPV_NM.TabIndex = 345
        Me.TxtPV_NM.Visible = False
        '
        'TxtPV_ID
        '
        Me.TxtPV_ID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPV_ID.Location = New System.Drawing.Point(748, 292)
        Me.TxtPV_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPV_ID.Name = "TxtPV_ID"
        Me.TxtPV_ID.Size = New System.Drawing.Size(112, 35)
        Me.TxtPV_ID.TabIndex = 346
        Me.TxtPV_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPV_ID.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(610, 305)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 347
        Me.Label3.Text = "ແຂວງ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'txtnm
        '
        Me.txtnm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnm.Location = New System.Drawing.Point(99, 76)
        Me.txtnm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnm.Name = "txtnm"
        Me.txtnm.Size = New System.Drawing.Size(372, 35)
        Me.txtnm.TabIndex = 349
        Me.txtnm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 25)
        Me.Label4.TabIndex = 348
        Me.Label4.Text = "ຊື່ກຸ່ມ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroup_100
        '
        Me.txtGroup_100.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup_100.Location = New System.Drawing.Point(328, 112)
        Me.txtGroup_100.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGroup_100.Name = "txtGroup_100"
        Me.txtGroup_100.Size = New System.Drawing.Size(143, 35)
        Me.txtGroup_100.TabIndex = 351
        Me.txtGroup_100.Text = "0"
        Me.txtGroup_100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 117)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 25)
        Me.Label5.TabIndex = 350
        Me.Label5.Text = "ອັດຕາຊົວໂມງ:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroup_90
        '
        Me.txtGroup_90.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup_90.Location = New System.Drawing.Point(328, 148)
        Me.txtGroup_90.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGroup_90.Name = "txtGroup_90"
        Me.txtGroup_90.Size = New System.Drawing.Size(143, 35)
        Me.txtGroup_90.TabIndex = 360
        Me.txtGroup_90.Text = "0"
        Me.txtGroup_90.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(215, 153)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 359
        Me.Label6.Text = "ອັດຕາຊົວໂມງ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 149)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 29)
        Me.Label10.TabIndex = 358
        Me.Label10.Text = "ໄດ້ຮັບເງີນ:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroup_percen90
        '
        Me.txtGroup_percen90.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup_percen90.Location = New System.Drawing.Point(99, 148)
        Me.txtGroup_percen90.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGroup_percen90.Name = "txtGroup_percen90"
        Me.txtGroup_percen90.ReadOnly = True
        Me.txtGroup_percen90.Size = New System.Drawing.Size(111, 35)
        Me.txtGroup_percen90.TabIndex = 357
        Me.txtGroup_percen90.Text = "90"
        Me.txtGroup_percen90.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGroup_80
        '
        Me.txtGroup_80.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup_80.Location = New System.Drawing.Point(329, 184)
        Me.txtGroup_80.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGroup_80.Name = "txtGroup_80"
        Me.txtGroup_80.Size = New System.Drawing.Size(143, 35)
        Me.txtGroup_80.TabIndex = 364
        Me.txtGroup_80.Text = "0"
        Me.txtGroup_80.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(216, 189)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 25)
        Me.Label8.TabIndex = 363
        Me.Label8.Text = "ອັດຕາຊົວໂມງ:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 185)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 29)
        Me.Label9.TabIndex = 362
        Me.Label9.Text = "ໄດ້ຮັບເງີນ:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroup_percen80
        '
        Me.txtGroup_percen80.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup_percen80.Location = New System.Drawing.Point(100, 184)
        Me.txtGroup_percen80.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGroup_percen80.Name = "txtGroup_percen80"
        Me.txtGroup_percen80.ReadOnly = True
        Me.txtGroup_percen80.Size = New System.Drawing.Size(111, 35)
        Me.txtGroup_percen80.TabIndex = 361
        Me.txtGroup_percen80.Text = "80"
        Me.txtGroup_percen80.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGroup_70
        '
        Me.txtGroup_70.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup_70.Location = New System.Drawing.Point(329, 220)
        Me.txtGroup_70.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGroup_70.Name = "txtGroup_70"
        Me.txtGroup_70.Size = New System.Drawing.Size(143, 35)
        Me.txtGroup_70.TabIndex = 368
        Me.txtGroup_70.Text = "0"
        Me.txtGroup_70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(216, 225)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 25)
        Me.Label11.TabIndex = 367
        Me.Label11.Text = "ອັດຕາຊົວໂມງ:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 221)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 29)
        Me.Label12.TabIndex = 366
        Me.Label12.Text = "ໄດ້ຮັບເງີນ:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroup_percen70
        '
        Me.txtGroup_percen70.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup_percen70.Location = New System.Drawing.Point(100, 220)
        Me.txtGroup_percen70.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGroup_percen70.Name = "txtGroup_percen70"
        Me.txtGroup_percen70.ReadOnly = True
        Me.txtGroup_percen70.Size = New System.Drawing.Size(111, 35)
        Me.txtGroup_percen70.TabIndex = 365
        Me.txtGroup_percen70.Text = "70"
        Me.txtGroup_percen70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGroup_60
        '
        Me.txtGroup_60.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup_60.Location = New System.Drawing.Point(329, 256)
        Me.txtGroup_60.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGroup_60.Name = "txtGroup_60"
        Me.txtGroup_60.Size = New System.Drawing.Size(143, 35)
        Me.txtGroup_60.TabIndex = 372
        Me.txtGroup_60.Text = "0"
        Me.txtGroup_60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(216, 261)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 25)
        Me.Label13.TabIndex = 371
        Me.Label13.Text = "ອັດຕາຊົວໂມງ:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 257)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 29)
        Me.Label14.TabIndex = 370
        Me.Label14.Text = "ໄດ້ຮັບເງີນ:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroup_percen60
        '
        Me.txtGroup_percen60.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup_percen60.Location = New System.Drawing.Point(100, 256)
        Me.txtGroup_percen60.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGroup_percen60.Name = "txtGroup_percen60"
        Me.txtGroup_percen60.ReadOnly = True
        Me.txtGroup_percen60.Size = New System.Drawing.Size(111, 35)
        Me.txtGroup_percen60.TabIndex = 369
        Me.txtGroup_percen60.Text = "60"
        Me.txtGroup_percen60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Frm_Salary_group
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(925, 629)
        Me.Controls.Add(Me.txtGroup_60)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtGroup_percen60)
        Me.Controls.Add(Me.txtGroup_70)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtGroup_percen70)
        Me.Controls.Add(Me.txtGroup_80)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtGroup_percen80)
        Me.Controls.Add(Me.txtGroup_90)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtGroup_percen90)
        Me.Controls.Add(Me.txtGroup_100)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPV_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.txtGroup_percen100)
        Me.Controls.Add(Me.Txt_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtnm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPV_NM)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Salary_group"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Index"
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
    Friend WithEvents txtGroup_percen100 As System.Windows.Forms.TextBox
    Friend WithEvents fg As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPV_NM As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPV_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGroup_100 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGroup_90 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGroup_percen90 As System.Windows.Forms.TextBox
    Friend WithEvents txtGroup_80 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtGroup_percen80 As System.Windows.Forms.TextBox
    Friend WithEvents txtGroup_70 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGroup_percen70 As System.Windows.Forms.TextBox
    Friend WithEvents txtGroup_60 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtGroup_percen60 As System.Windows.Forms.TextBox
End Class
