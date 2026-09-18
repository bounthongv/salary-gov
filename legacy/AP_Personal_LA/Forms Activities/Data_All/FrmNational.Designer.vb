<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNationall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNationall))
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabOffiice = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Bsave = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BAddnew = New System.Windows.Forms.Button
        Me.FG = New AxVSFlex8U.AxVSFlexGrid
        CType(Me.FG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(144, 41)
        Me.txtID.MaxLength = 15
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(96, 28)
        Me.txtID.TabIndex = 179
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(119, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 24)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "ຊື່:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabOffiice
        '
        Me.LabOffiice.AutoSize = True
        Me.LabOffiice.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabOffiice.ForeColor = System.Drawing.Color.Black
        Me.LabOffiice.Location = New System.Drawing.Point(88, 40)
        Me.LabOffiice.Name = "LabOffiice"
        Me.LabOffiice.Size = New System.Drawing.Size(55, 24)
        Me.LabOffiice.TabIndex = 180
        Me.LabOffiice.Text = "ລະຫັດ:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(240, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 34)
        Me.Button2.TabIndex = 185
        Me.Button2.Text = "ລືບ"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(144, 71)
        Me.txtname.MaxLength = 15
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(192, 28)
        Me.txtname.TabIndex = 182
        '
        'Bsave
        '
        Me.Bsave.Image = CType(resources.GetObject("Bsave.Image"), System.Drawing.Image)
        Me.Bsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bsave.Location = New System.Drawing.Point(144, 6)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(96, 34)
        Me.Bsave.TabIndex = 186
        Me.Bsave.Text = "ບັກທຶກ"
        Me.Bsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(2, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 34)
        Me.Button1.TabIndex = 184
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BAddnew
        '
        Me.BAddnew.Image = CType(resources.GetObject("BAddnew.Image"), System.Drawing.Image)
        Me.BAddnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAddnew.Location = New System.Drawing.Point(48, 6)
        Me.BAddnew.Name = "BAddnew"
        Me.BAddnew.Size = New System.Drawing.Size(96, 33)
        Me.BAddnew.TabIndex = 183
        Me.BAddnew.Text = "ເພີ່ມໃໝ່"
        Me.BAddnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAddnew.UseVisualStyleBackColor = True
        '
        'FG
        '
        Me.FG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FG.DataSource = Nothing
        Me.FG.Location = New System.Drawing.Point(10, 102)
        Me.FG.Name = "FG"
        Me.FG.OcxState = CType(resources.GetObject("FG.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FG.Size = New System.Drawing.Size(648, 326)
        Me.FG.TabIndex = 187
        '
        'FrmNationall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.FG)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabOffiice)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Bsave)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BAddnew)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmNationall"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "National"
        CType(Me.FG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabOffiice As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BAddnew As System.Windows.Forms.Button
    Friend WithEvents FG As AxVSFlex8U.AxVSFlexGrid
End Class
