<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrint_Barcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrint_Barcode))
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Fg = New AxVSFlex8U.AxVSFlexGrid
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.txtRow = New System.Windows.Forms.TextBox
        Me.txtCol = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.txt_Bk_nm = New System.Windows.Forms.ComboBox
        Me.txt_Bk_ID = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_2 = New System.Windows.Forms.TextBox
        CType(Me.Fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.APInvioce.My.Resources.Resources.Printer_2
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(60, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 43)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "ພີມບາໂຄດ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.APInvioce.My.Resources.Resources.AddCus
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(559, 32)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(108, 44)
        Me.Button8.TabIndex = 74
        Me.Button8.Text = "Show"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.Button1.Location = New System.Drawing.Point(5, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 43)
        Me.Button1.TabIndex = 73
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Fg
        '
        Me.Fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fg.Location = New System.Drawing.Point(114, 81)
        Me.Fg.Name = "Fg"
        Me.Fg.OcxState = CType(resources.GetObject("Fg.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fg.Size = New System.Drawing.Size(744, 400)
        Me.Fg.TabIndex = 76
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsearch.Location = New System.Drawing.Point(728, 39)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(190, 23)
        Me.txtsearch.TabIndex = 77
        Me.txtsearch.Visible = False
        '
        'txtRow
        '
        Me.txtRow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRow.Location = New System.Drawing.Point(12, 110)
        Me.txtRow.Multiline = True
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(89, 23)
        Me.txtRow.TabIndex = 78
        Me.txtRow.Visible = False
        '
        'txtCol
        '
        Me.txtCol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCol.Location = New System.Drawing.Point(12, 139)
        Me.txtCol.Multiline = True
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(89, 23)
        Me.txtCol.TabIndex = 79
        Me.txtCol.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(114, 494)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 138)
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(114, 494)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(744, 138)
        Me.PictureBox2.TabIndex = 81
        Me.PictureBox2.TabStop = False
        '
        'txt_Bk_nm
        '
        Me.txt_Bk_nm.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Bk_nm.FormattingEnabled = True
        Me.txt_Bk_nm.Location = New System.Drawing.Point(286, 5)
        Me.txt_Bk_nm.Name = "txt_Bk_nm"
        Me.txt_Bk_nm.Size = New System.Drawing.Size(264, 32)
        Me.txt_Bk_nm.TabIndex = 416
        '
        'txt_Bk_ID
        '
        Me.txt_Bk_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Bk_ID.Location = New System.Drawing.Point(559, 5)
        Me.txt_Bk_ID.Multiline = True
        Me.txt_Bk_ID.Name = "txt_Bk_ID"
        Me.txt_Bk_ID.Size = New System.Drawing.Size(89, 26)
        Me.txt_Bk_ID.TabIndex = 417
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.Location = New System.Drawing.Point(201, 5)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 33)
        Me.Label28.TabIndex = 418
        Me.Label28.Text = "ໂຮງໝໍ:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 24)
        Me.Label6.TabIndex = 420
        Me.Label6.Text = "ພີມແຕ່ເລກ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_1
        '
        Me.txt_1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_1.Location = New System.Drawing.Point(286, 39)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(89, 35)
        Me.txt_1.TabIndex = 419
        Me.txt_1.Text = "0"
        Me.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(381, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 422
        Me.Label1.Text = "ເຖີງ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_2
        '
        Me.txt_2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_2.Location = New System.Drawing.Point(461, 39)
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(89, 35)
        Me.txt_2.TabIndex = 421
        Me.txt_2.Text = "0"
        Me.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmPrint_Barcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(957, 636)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txt_Bk_ID)
        Me.Controls.Add(Me.txt_Bk_nm)
        Me.Controls.Add(Me.txtCol)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Fg)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmPrint_Barcode"
        Me.Text = "Print Barcode"
        CType(Me.Fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Fg As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtRow As System.Windows.Forms.TextBox
    Friend WithEvents txtCol As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_Bk_nm As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Bk_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_2 As System.Windows.Forms.TextBox
End Class
