<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rate_setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rate_setting))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.o = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.p = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTHB_LAK = New System.Windows.Forms.TextBox
        Me.txtUSD_LAK = New System.Windows.Forms.TextBox
        Me.txtEUR_THB = New System.Windows.Forms.TextBox
        Me.txtEUR_LAK = New System.Windows.Forms.TextBox
        Me.txtEUR_USD = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtUSD_THB = New System.Windows.Forms.TextBox
        Me.txtCerrent = New System.Windows.Forms.TextBox
        Me.DTrate = New System.Windows.Forms.DateTimePicker
        Me.BtnExit = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.FG_Rate = New AxVSFlex8U.AxVSFlexGrid
        Me.Panel1.SuspendLayout()
        CType(Me.FG_Rate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 58)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "ປະຈໍາວັນທີ່:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(616, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 26)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "ດົ້ງ-ກີບ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'o
        '
        Me.o.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.o.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.o.ForeColor = System.Drawing.Color.Black
        Me.o.Location = New System.Drawing.Point(524, 0)
        Me.o.Name = "o"
        Me.o.Size = New System.Drawing.Size(93, 26)
        Me.o.TabIndex = 52
        Me.o.Text = "ຢູໂຣ-ໂດລາ"
        Me.o.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(227, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 26)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "ໂດລາ-ບາດ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'p
        '
        Me.p.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p.ForeColor = System.Drawing.Color.Black
        Me.p.Location = New System.Drawing.Point(326, 0)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(100, 26)
        Me.p.TabIndex = 52
        Me.p.Text = "ໂດລາ-ກີບ"
        Me.p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(425, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 27)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "ຢູໂຣ-ບາດ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(128, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 26)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "ບາດ-ກີບ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 25)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "ອັດຕາແລກປ່ຽນ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 34)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "(Rate ExChange)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTHB_LAK
        '
        Me.txtTHB_LAK.BackColor = System.Drawing.Color.White
        Me.txtTHB_LAK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTHB_LAK.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHB_LAK.ForeColor = System.Drawing.Color.Blue
        Me.txtTHB_LAK.Location = New System.Drawing.Point(128, 25)
        Me.txtTHB_LAK.Name = "txtTHB_LAK"
        Me.txtTHB_LAK.Size = New System.Drawing.Size(100, 30)
        Me.txtTHB_LAK.TabIndex = 124
        Me.txtTHB_LAK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUSD_LAK
        '
        Me.txtUSD_LAK.BackColor = System.Drawing.Color.White
        Me.txtUSD_LAK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUSD_LAK.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSD_LAK.ForeColor = System.Drawing.Color.Blue
        Me.txtUSD_LAK.Location = New System.Drawing.Point(326, 25)
        Me.txtUSD_LAK.Name = "txtUSD_LAK"
        Me.txtUSD_LAK.Size = New System.Drawing.Size(100, 30)
        Me.txtUSD_LAK.TabIndex = 127
        Me.txtUSD_LAK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEUR_THB
        '
        Me.txtEUR_THB.BackColor = System.Drawing.Color.White
        Me.txtEUR_THB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEUR_THB.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEUR_THB.ForeColor = System.Drawing.Color.Blue
        Me.txtEUR_THB.Location = New System.Drawing.Point(425, 25)
        Me.txtEUR_THB.Name = "txtEUR_THB"
        Me.txtEUR_THB.Size = New System.Drawing.Size(100, 30)
        Me.txtEUR_THB.TabIndex = 126
        Me.txtEUR_THB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEUR_LAK
        '
        Me.txtEUR_LAK.BackColor = System.Drawing.Color.White
        Me.txtEUR_LAK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEUR_LAK.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEUR_LAK.ForeColor = System.Drawing.Color.Blue
        Me.txtEUR_LAK.Location = New System.Drawing.Point(616, 25)
        Me.txtEUR_LAK.Name = "txtEUR_LAK"
        Me.txtEUR_LAK.Size = New System.Drawing.Size(99, 30)
        Me.txtEUR_LAK.TabIndex = 129
        Me.txtEUR_LAK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEUR_USD
        '
        Me.txtEUR_USD.BackColor = System.Drawing.Color.White
        Me.txtEUR_USD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEUR_USD.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEUR_USD.ForeColor = System.Drawing.Color.Blue
        Me.txtEUR_USD.Location = New System.Drawing.Point(524, 25)
        Me.txtEUR_USD.Name = "txtEUR_USD"
        Me.txtEUR_USD.Size = New System.Drawing.Size(93, 30)
        Me.txtEUR_USD.TabIndex = 128
        Me.txtEUR_USD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtUSD_THB)
        Me.Panel1.Controls.Add(Me.txtCerrent)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtEUR_LAK)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtEUR_USD)
        Me.Panel1.Controls.Add(Me.txtTHB_LAK)
        Me.Panel1.Controls.Add(Me.txtUSD_LAK)
        Me.Panel1.Controls.Add(Me.txtEUR_THB)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.p)
        Me.Panel1.Controls.Add(Me.o)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(133, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(719, 59)
        Me.Panel1.TabIndex = 130
        '
        'txtUSD_THB
        '
        Me.txtUSD_THB.BackColor = System.Drawing.Color.White
        Me.txtUSD_THB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUSD_THB.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSD_THB.ForeColor = System.Drawing.Color.Blue
        Me.txtUSD_THB.Location = New System.Drawing.Point(227, 25)
        Me.txtUSD_THB.Name = "txtUSD_THB"
        Me.txtUSD_THB.Size = New System.Drawing.Size(100, 30)
        Me.txtUSD_THB.TabIndex = 132
        Me.txtUSD_THB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCerrent
        '
        Me.txtCerrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCerrent.Location = New System.Drawing.Point(131, 124)
        Me.txtCerrent.Name = "txtCerrent"
        Me.txtCerrent.Size = New System.Drawing.Size(100, 30)
        Me.txtCerrent.TabIndex = 130
        '
        'DTrate
        '
        Me.DTrate.CalendarFont = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTrate.CustomFormat = "dd/MM/yyyy"
        Me.DTrate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTrate.Location = New System.Drawing.Point(5, 61)
        Me.DTrate.Name = "DTrate"
        Me.DTrate.Size = New System.Drawing.Size(124, 30)
        Me.DTrate.TabIndex = 131
        Me.DTrate.Value = New Date(2009, 12, 31, 0, 0, 0, 0)
        '
        'BtnExit
        '
        Me.BtnExit.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.BtnExit.Location = New System.Drawing.Point(4, 1)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(32, 30)
        Me.BtnExit.TabIndex = 108
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.BtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDel.Location = New System.Drawing.Point(235, 1)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(97, 30)
        Me.BtnDel.TabIndex = 42
        Me.BtnDel.Text = "ລຶບ"
        Me.BtnDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.APInvioce.My.Resources.Resources.save_f2
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(134, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(101, 30)
        Me.BtnSave.TabIndex = 41
        Me.BtnSave.Text = "ບັນທຶກ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Image = Global.APInvioce.My.Resources.Resources.New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(44, 1)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(90, 30)
        Me.BtnAddNew.TabIndex = 40
        Me.BtnAddNew.Text = "ເພີ່ມໃໝ່"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'FG_Rate
        '
        Me.FG_Rate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FG_Rate.Location = New System.Drawing.Point(4, 92)
        Me.FG_Rate.Name = "FG_Rate"
        Me.FG_Rate.OcxState = CType(resources.GetObject("FG_Rate.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FG_Rate.Size = New System.Drawing.Size(964, 276)
        Me.FG_Rate.TabIndex = 52
        '
        'Rate_setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 370)
        Me.ControlBox = False
        Me.Controls.Add(Me.DTrate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.FG_Rate)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Rate_setting"
        Me.Text = "Rate setting"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FG_Rate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents o As System.Windows.Forms.Label
    Friend WithEvents p As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTHB_LAK As System.Windows.Forms.TextBox
    Friend WithEvents txtUSD_LAK As System.Windows.Forms.TextBox
    Friend WithEvents txtEUR_THB As System.Windows.Forms.TextBox
    Friend WithEvents txtEUR_LAK As System.Windows.Forms.TextBox
    Friend WithEvents txtEUR_USD As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCerrent As System.Windows.Forms.TextBox
    Friend WithEvents DTrate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FG_Rate As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents txtUSD_THB As System.Windows.Forms.TextBox
End Class
