<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Location_BK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Location_BK))
        Me.Txt_ID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.fg = New AxVSFlex8U.AxVSFlexGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtPV_NM = New System.Windows.Forms.ComboBox
        Me.TxtPV_ID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_Dist = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDist_id = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_ID
        '
        Me.Txt_ID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ID.Location = New System.Drawing.Point(72, 146)
        Me.Txt_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(111, 35)
        Me.Txt_ID.TabIndex = 339
        Me.Txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-31, 152)
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
        Me.Txt_name.Location = New System.Drawing.Point(287, 148)
        Me.Txt_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(181, 35)
        Me.Txt_name.TabIndex = 341
        '
        'fg
        '
        Me.fg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fg.DataSource = Nothing
        Me.fg.Location = New System.Drawing.Point(3, 191)
        Me.fg.Name = "fg"
        Me.fg.OcxState = CType(resources.GetObject("fg.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fg.Size = New System.Drawing.Size(465, 343)
        Me.fg.TabIndex = 342
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 343
        Me.Label1.Text = "ຊື່ສະຖານທີ່:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPV_NM
        '
        Me.TxtPV_NM.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPV_NM.FormattingEnabled = True
        Me.TxtPV_NM.Location = New System.Drawing.Point(70, 78)
        Me.TxtPV_NM.Name = "TxtPV_NM"
        Me.TxtPV_NM.Size = New System.Drawing.Size(397, 32)
        Me.TxtPV_NM.TabIndex = 345
        '
        'TxtPV_ID
        '
        Me.TxtPV_ID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPV_ID.Location = New System.Drawing.Point(331, 191)
        Me.TxtPV_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPV_ID.Name = "TxtPV_ID"
        Me.TxtPV_ID.Size = New System.Drawing.Size(28, 35)
        Me.TxtPV_ID.TabIndex = 346
        Me.TxtPV_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPV_ID.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 347
        Me.Label3.Text = "ແຂວງ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_Dist
        '
        Me.cmb_Dist.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Dist.FormattingEnabled = True
        Me.cmb_Dist.Location = New System.Drawing.Point(71, 113)
        Me.cmb_Dist.Name = "cmb_Dist"
        Me.cmb_Dist.Size = New System.Drawing.Size(397, 32)
        Me.cmb_Dist.TabIndex = 348
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 350
        Me.Label4.Text = "ເມືອງ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDist_id
        '
        Me.txtDist_id.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDist_id.Location = New System.Drawing.Point(331, 229)
        Me.txtDist_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDist_id.Name = "txtDist_id"
        Me.txtDist_id.Size = New System.Drawing.Size(28, 35)
        Me.txtDist_id.TabIndex = 349
        Me.txtDist_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDist_id.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(80, -9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(363, 41)
        Me.Label5.TabIndex = 351
        Me.Label5.Text = "ລາຍການສຸກສາລາ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(697, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 63)
        Me.Label2.TabIndex = 344
        Me.Label2.Text = "ລາຍການສະຖານທີ່"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Delete2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(295, 34)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 43)
        Me.Button1.TabIndex = 182
        Me.Button1.Text = "ລືບ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(182, 34)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(112, 43)
        Me.BtnSave.TabIndex = 181
        Me.BtnSave.Text = "ບັນທຶກ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Image = CType(resources.GetObject("BtnAddNew.Image"), System.Drawing.Image)
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(70, 34)
        Me.BtnAddNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(112, 43)
        Me.BtnAddNew.TabIndex = 180
        Me.BtnAddNew.Text = "ເພີ່ມໃໝ່"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(3, 34)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 42)
        Me.Button6.TabIndex = 179
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Frm_Location_BK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(494, 546)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_Dist)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDist_id)
        Me.Controls.Add(Me.TxtPV_NM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPV_ID)
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
        Me.Name = "Frm_Location_BK"
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
    Friend WithEvents TxtPV_NM As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPV_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_Dist As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDist_id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
