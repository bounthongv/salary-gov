<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSSO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSSO))
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtid = New System.Windows.Forms.TextBox
        Me.FG = New AxVSFlex8U.AxVSFlexGrid
        Me.txtsymbol = New System.Windows.Forms.TextBox
        Me.txtnm = New System.Windows.Forms.TextBox
        Me.txtnme = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.txtnm_L = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dt_month = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.FG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button10
        '
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(320, 6)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(97, 38)
        Me.Button10.TabIndex = 45614
        Me.Button10.Tag = "3006"
        Me.Button10.Text = "ລືບຂໍ້ມູນ"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(76, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 37)
        Me.Button3.TabIndex = 45615
        Me.Button3.Tag = "3003"
        Me.Button3.Text = "ເພີ່ມໃໝ່"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Saysettha OT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(426, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 31)
        Me.Label11.TabIndex = 45613
        Me.Label11.Tag = "2005"
        Me.Label11.Text = "ຫັກປະກັນສັງຄົມ"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.LightGray
        Me.Button4.Location = New System.Drawing.Point(8, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 47)
        Me.Button4.TabIndex = 45616
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(198, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 38)
        Me.Button1.TabIndex = 45617
        Me.Button1.Tag = "3004"
        Me.Button1.Text = "ບັນທຶກ"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(57, 186)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(77, 35)
        Me.txtid.TabIndex = 45618
        Me.txtid.Visible = False
        '
        'FG
        '
        Me.FG.DataSource = Nothing
        Me.FG.Location = New System.Drawing.Point(140, 129)
        Me.FG.Name = "FG"
        Me.FG.OcxState = CType(resources.GetObject("FG.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FG.Size = New System.Drawing.Size(672, 470)
        Me.FG.TabIndex = 45619
        '
        'txtsymbol
        '
        Me.txtsymbol.Location = New System.Drawing.Point(218, 186)
        Me.txtsymbol.Name = "txtsymbol"
        Me.txtsymbol.Size = New System.Drawing.Size(219, 35)
        Me.txtsymbol.TabIndex = 45621
        Me.txtsymbol.Visible = False
        '
        'txtnm
        '
        Me.txtnm.Location = New System.Drawing.Point(140, 91)
        Me.txtnm.Name = "txtnm"
        Me.txtnm.Size = New System.Drawing.Size(77, 35)
        Me.txtnm.TabIndex = 45622
        Me.txtnm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnme
        '
        Me.txtnme.Location = New System.Drawing.Point(228, 333)
        Me.txtnme.Name = "txtnme"
        Me.txtnme.Size = New System.Drawing.Size(322, 35)
        Me.txtnme.TabIndex = 45623
        Me.txtnme.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(523, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 24)
        Me.Label5.TabIndex = 45628
        Me.Label5.Tag = "2007"
        Me.Label5.Text = "ລະຫັດ"
        Me.Label5.Visible = False
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(503, 202)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(219, 35)
        Me.txtcode.TabIndex = 45627
        Me.txtcode.Visible = False
        '
        'txtnm_L
        '
        Me.txtnm_L.Location = New System.Drawing.Point(301, 91)
        Me.txtnm_L.Name = "txtnm_L"
        Me.txtnm_L.Size = New System.Drawing.Size(97, 35)
        Me.txtnm_L.TabIndex = 45641
        Me.txtnm_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 24)
        Me.Label6.TabIndex = 45640
        Me.Label6.Tag = "2002"
        Me.Label6.Text = "ຜູ້ຈ້າງ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 45639
        Me.Label7.Tag = "2002"
        Me.Label7.Text = "ພະນັກງານ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 24)
        Me.Label8.TabIndex = 45638
        Me.Label8.Tag = "2001"
        Me.Label8.Text = "ລະຫັດ"
        Me.Label8.Visible = False
        '
        'dt_month
        '
        Me.dt_month.CustomFormat = "dd/MM/yyyy"
        Me.dt_month.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_month.Location = New System.Drawing.Point(140, 51)
        Me.dt_month.Name = "dt_month"
        Me.dt_month.ShowUpDown = True
        Me.dt_month.Size = New System.Drawing.Size(107, 35)
        Me.dt_month.TabIndex = 45774
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 24)
        Me.Label1.TabIndex = 45775
        Me.Label1.Tag = "2002"
        Me.Label1.Text = "ວັນທີ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 24)
        Me.Label2.TabIndex = 45776
        Me.Label2.Tag = "2002"
        Me.Label2.Text = "%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 24)
        Me.Label3.TabIndex = 45777
        Me.Label3.Tag = "2002"
        Me.Label3.Text = "%"
        '
        'frmSSO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(822, 611)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dt_month)
        Me.Controls.Add(Me.txtnm_L)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FG)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.txtnme)
        Me.Controls.Add(Me.txtnm)
        Me.Controls.Add(Me.txtsymbol)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmSSO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTitle_List"
        CType(Me.FG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents FG As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents txtsymbol As System.Windows.Forms.TextBox
    Friend WithEvents txtnm As System.Windows.Forms.TextBox
    Friend WithEvents txtnme As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtnm_L As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dt_month As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
