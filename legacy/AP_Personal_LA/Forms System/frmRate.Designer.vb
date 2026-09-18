<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRate))
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DTrate = New System.Windows.Forms.DateTimePicker
        Me.FG = New AxVSFlex8U.AxVSFlexGrid
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button21 = New System.Windows.Forms.Button
        Me.dtp_Month = New System.Windows.Forms.DateTimePicker
        CType(Me.FG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.LightGray
        Me.Button4.Location = New System.Drawing.Point(3, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(55, 43)
        Me.Button4.TabIndex = 45624
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(163, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 43)
        Me.Button2.TabIndex = 45623
        Me.Button2.Tag = "3004"
        Me.Button2.Text = "Save"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Blue
        Me.Button5.Location = New System.Drawing.Point(57, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 42)
        Me.Button5.TabIndex = 45622
        Me.Button5.Tag = "3003"
        Me.Button5.Text = "Add New"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(470, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 29)
        Me.Label8.TabIndex = 45625
        Me.Label8.Text = "ອັດຕາແລກປ່ຽນ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(475, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 39)
        Me.Label5.TabIndex = 45626
        Me.Label5.Text = "(Rate ExChange)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTrate
        '
        Me.DTrate.CalendarFont = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTrate.CustomFormat = "dd/MM/yyyy"
        Me.DTrate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTrate.Location = New System.Drawing.Point(819, 37)
        Me.DTrate.Name = "DTrate"
        Me.DTrate.ShowUpDown = True
        Me.DTrate.Size = New System.Drawing.Size(139, 35)
        Me.DTrate.TabIndex = 45627
        Me.DTrate.Value = New Date(2013, 5, 7, 0, 0, 0, 0)
        Me.DTrate.Visible = False
        '
        'FG
        '
        Me.FG.DataSource = Nothing
        Me.FG.Location = New System.Drawing.Point(163, 104)
        Me.FG.Name = "FG"
        Me.FG.OcxState = CType(resources.GetObject("FG.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FG.Size = New System.Drawing.Size(866, 314)
        Me.FG.TabIndex = 45628
        '
        'Button20
        '
        Me.Button20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button20.Image = CType(resources.GetObject("Button20.Image"), System.Drawing.Image)
        Me.Button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button20.Location = New System.Drawing.Point(76, 151)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(81, 43)
        Me.Button20.TabIndex = 45851
        Me.Button20.Tag = "3006"
        Me.Button20.Text = "ລືບແຖວ"
        Me.Button20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.BackgroundImage = CType(resources.GetObject("Button21.BackgroundImage"), System.Drawing.Image)
        Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button21.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.Black
        Me.Button21.Location = New System.Drawing.Point(76, 104)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(81, 42)
        Me.Button21.TabIndex = 45852
        Me.Button21.Tag = "3003"
        Me.Button21.Text = "ເພີ່ມແຖວ"
        Me.Button21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button21.UseVisualStyleBackColor = True
        '
        'dtp_Month
        '
        Me.dtp_Month.CustomFormat = "MM/yyyy"
        Me.dtp_Month.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Month.Location = New System.Drawing.Point(163, 63)
        Me.dtp_Month.Name = "dtp_Month"
        Me.dtp_Month.ShowUpDown = True
        Me.dtp_Month.Size = New System.Drawing.Size(113, 35)
        Me.dtp_Month.TabIndex = 45853
        '
        'frmRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1189, 483)
        Me.Controls.Add(Me.dtp_Month)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.FG)
        Me.Controls.Add(Me.DTrate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmRate"
        Me.Text = "Rate"
        CType(Me.FG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTrate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FG As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents dtp_Month As System.Windows.Forms.DateTimePicker
End Class
