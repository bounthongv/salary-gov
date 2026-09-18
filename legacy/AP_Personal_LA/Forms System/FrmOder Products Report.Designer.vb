<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOder_Products_Report
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTfrom = New System.Windows.Forms.DateTimePicker
        Me.DTTo = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Cacel2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(4, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Cancle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.APInvioce.My.Resources.Resources.iMac_RegTools
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(137, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date:"
        '
        'DTfrom
        '
        Me.DTfrom.CustomFormat = "dd/MM/yyyy"
        Me.DTfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTfrom.Location = New System.Drawing.Point(4, 75)
        Me.DTfrom.Name = "DTfrom"
        Me.DTfrom.Size = New System.Drawing.Size(126, 30)
        Me.DTfrom.TabIndex = 3
        '
        'DTTo
        '
        Me.DTTo.CustomFormat = "dd/MM/yyyy"
        Me.DTTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTTo.Location = New System.Drawing.Point(137, 75)
        Me.DTTo.Name = "DTTo"
        Me.DTTo.Size = New System.Drawing.Size(126, 30)
        Me.DTTo.TabIndex = 4
        '
        'FrmOder_Products_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(265, 125)
        Me.ControlBox = False
        Me.Controls.Add(Me.DTTo)
        Me.Controls.Add(Me.DTfrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOder_Products_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                         Oder Products Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTTo As System.Windows.Forms.DateTimePicker
End Class
