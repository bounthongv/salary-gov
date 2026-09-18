<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonthlyclosingaccount_S
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtYear = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMonth = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFromDate = New System.Windows.Forms.Label
        Me.lblToDate = New System.Windows.Forms.Label
        Me.txtFileNane = New System.Windows.Forms.TextBox
        Me.txtSaveIn = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSdate = New System.Windows.Forms.TextBox
        Me.DtSdate = New System.Windows.Forms.DateTimePicker
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Wayoutssss
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(14, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&CloseAccnt"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = Global.APInvioce.My.Resources.Resources.Cacel2
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(126, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 54)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Cancle"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ເດືອນ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtYear
        '
        Me.txtYear.CustomFormat = "yyyy"
        Me.txtYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtYear.Location = New System.Drawing.Point(157, 13)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ShowUpDown = True
        Me.txtYear.Size = New System.Drawing.Size(55, 30)
        Me.txtYear.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(107, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ປີ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMonth
        '
        Me.txtMonth.CustomFormat = "MM"
        Me.txtMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtMonth.Location = New System.Drawing.Point(54, 13)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.ShowUpDown = True
        Me.txtMonth.Size = New System.Drawing.Size(53, 30)
        Me.txtMonth.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(-3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ປິດບັນຊີປະຈໍາເດືອນ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFromDate
        '
        Me.lblFromDate.BackColor = System.Drawing.Color.White
        Me.lblFromDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFromDate.Location = New System.Drawing.Point(36, 312)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(96, 21)
        Me.lblFromDate.TabIndex = 4
        Me.lblFromDate.Text = "Label4"
        '
        'lblToDate
        '
        Me.lblToDate.BackColor = System.Drawing.Color.White
        Me.lblToDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblToDate.Location = New System.Drawing.Point(142, 312)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(96, 21)
        Me.lblToDate.TabIndex = 5
        Me.lblToDate.Text = "Label5"
        '
        'txtFileNane
        '
        Me.txtFileNane.Location = New System.Drawing.Point(36, 377)
        Me.txtFileNane.Name = "txtFileNane"
        Me.txtFileNane.Size = New System.Drawing.Size(202, 30)
        Me.txtFileNane.TabIndex = 6
        '
        'txtSaveIn
        '
        Me.txtSaveIn.Location = New System.Drawing.Point(36, 341)
        Me.txtSaveIn.Name = "txtSaveIn"
        Me.txtSaveIn.Size = New System.Drawing.Size(202, 30)
        Me.txtSaveIn.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtYear)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtMonth)
        Me.Panel1.Location = New System.Drawing.Point(14, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 58)
        Me.Panel1.TabIndex = 8
        '
        'txtSdate
        '
        Me.txtSdate.Location = New System.Drawing.Point(38, 279)
        Me.txtSdate.Name = "txtSdate"
        Me.txtSdate.Size = New System.Drawing.Size(202, 30)
        Me.txtSdate.TabIndex = 9
        '
        'DtSdate
        '
        Me.DtSdate.CustomFormat = "dd/MM/yyyy"
        Me.DtSdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtSdate.Location = New System.Drawing.Point(38, 243)
        Me.DtSdate.Name = "DtSdate"
        Me.DtSdate.Size = New System.Drawing.Size(202, 30)
        Me.DtSdate.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(341, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 30)
        Me.TextBox1.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(69, 174)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(158, 35)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FrmMonthly_closing_account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(259, 162)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DtSdate)
        Me.Controls.Add(Me.txtSdate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtSaveIn)
        Me.Controls.Add(Me.txtFileNane)
        Me.Controls.Add(Me.lblToDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMonthly_closing_account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents txtFileNane As System.Windows.Forms.TextBox
    Friend WithEvents txtSaveIn As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSdate As System.Windows.Forms.TextBox
    Friend WithEvents DtSdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
