<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Watter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Watter))
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Txt_ID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.fg = New AxVSFlex8U.AxVSFlexGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(208, 3)
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
        Me.BtnAddNew.Location = New System.Drawing.Point(96, 3)
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
        Me.Button1.Location = New System.Drawing.Point(321, 3)
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
        Me.Txt_ID.Location = New System.Drawing.Point(97, 41)
        Me.Txt_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(111, 35)
        Me.Txt_ID.TabIndex = 339
        Me.Txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-6, 47)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 338
        Me.Label7.Text = "ລະຫັດ:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_name
        '
        Me.Txt_name.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_name.Location = New System.Drawing.Point(97, 78)
        Me.Txt_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(564, 35)
        Me.Txt_name.TabIndex = 341
        '
        'fg
        '
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.DataSource = Nothing
        Me.fg.Location = New System.Drawing.Point(3, 121)
        Me.fg.Name = "fg"
        Me.fg.OcxState = CType(resources.GetObject("fg.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fg.Size = New System.Drawing.Size(791, 437)
        Me.fg.TabIndex = 342
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-63, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 343
        Me.Label1.Text = "ຊື່ນຳໃຊ້:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(441, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 73)
        Me.Label2.TabIndex = 344
        Me.Label2.Text = "ລາຍການນ້ຳໃຊ້"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Watter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 546)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Txt_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.Button6)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Watter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Unit"
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
    Friend WithEvents Txt_name As System.Windows.Forms.TextBox
    Friend WithEvents fg As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
