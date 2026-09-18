<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChang_password
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtConfirm = New System.Windows.Forms.TextBox
        Me.txtPWDNew = New System.Windows.Forms.TextBox
        Me.txtPWDOld = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEncrypt = New System.Windows.Forms.TextBox
        Me.lblText_encrypt = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 110)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.txtConfirm)
        Me.Panel2.Controls.Add(Me.txtPWDNew)
        Me.Panel2.Controls.Add(Me.txtPWDOld)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtEncrypt)
        Me.Panel2.Controls.Add(Me.lblText_encrypt)
        Me.Panel2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(357, 105)
        Me.Panel2.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.APInvioce.My.Resources.Resources.Cacel2
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(283, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 48)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "&Cancle"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Save2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(283, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 48)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Save"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtConfirm
        '
        Me.txtConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.ForeColor = System.Drawing.Color.Red
        Me.txtConfirm.Location = New System.Drawing.Point(122, 70)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.Size = New System.Drawing.Size(159, 35)
        Me.txtConfirm.TabIndex = 5
        '
        'txtPWDNew
        '
        Me.txtPWDNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPWDNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPWDNew.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPWDNew.ForeColor = System.Drawing.Color.Blue
        Me.txtPWDNew.Location = New System.Drawing.Point(122, 37)
        Me.txtPWDNew.Name = "txtPWDNew"
        Me.txtPWDNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPWDNew.Size = New System.Drawing.Size(159, 35)
        Me.txtPWDNew.TabIndex = 4
        '
        'txtPWDOld
        '
        Me.txtPWDOld.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPWDOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPWDOld.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPWDOld.Location = New System.Drawing.Point(122, 4)
        Me.txtPWDOld.Name = "txtPWDOld"
        Me.txtPWDOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPWDOld.Size = New System.Drawing.Size(159, 35)
        Me.txtPWDOld.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ຢໍ້າຄືນລະຫັດໃໝ່:"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ລະຫັດຜ່ານໃໝ່:"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ລະຫັດຜ່ານເກົ່າ:"
        '
        'txtEncrypt
        '
        Me.txtEncrypt.Location = New System.Drawing.Point(139, 16)
        Me.txtEncrypt.Name = "txtEncrypt"
        Me.txtEncrypt.Size = New System.Drawing.Size(100, 35)
        Me.txtEncrypt.TabIndex = 106
        '
        'lblText_encrypt
        '
        Me.lblText_encrypt.AutoSize = True
        Me.lblText_encrypt.Location = New System.Drawing.Point(148, 53)
        Me.lblText_encrypt.Name = "lblText_encrypt"
        Me.lblText_encrypt.Size = New System.Drawing.Size(111, 29)
        Me.lblText_encrypt.TabIndex = 105
        Me.lblText_encrypt.Text = "SoUkSaVhAy"
        '
        'FrmChang_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(366, 114)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmChang_password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmChang_password"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtPWDNew As System.Windows.Forms.TextBox
    Friend WithEvents txtPWDOld As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents lblText_encrypt As System.Windows.Forms.Label
End Class
