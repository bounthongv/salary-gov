<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAPListEthnic
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAPListEthnic))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txtname = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txt_ID = New System.Windows.Forms.TextBox
        Me.Bdelete = New System.Windows.Forms.Button
        Me.Bsave = New System.Windows.Forms.Button
        Me.Bclos = New System.Windows.Forms.Button
        Me.Badd = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FG = New AxVSFlex8U.AxVSFlexGrid
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.FG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "ຊື່"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ເລກລະຫັດ"
        '
        'Txtname
        '
        Me.Txtname.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtname.Location = New System.Drawing.Point(173, 72)
        Me.Txtname.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(224, 31)
        Me.Txtname.TabIndex = 24
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(173, 40)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(112, 29)
        Me.txtID.TabIndex = 25
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_ID.Location = New System.Drawing.Point(585, 6)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(141, 29)
        Me.txt_ID.TabIndex = 26
        Me.txt_ID.Visible = False
        '
        'Bdelete
        '
        Me.Bdelete.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bdelete.Image = CType(resources.GetObject("Bdelete.Image"), System.Drawing.Image)
        Me.Bdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bdelete.Location = New System.Drawing.Point(285, 3)
        Me.Bdelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bdelete.Name = "Bdelete"
        Me.Bdelete.Size = New System.Drawing.Size(112, 36)
        Me.Bdelete.TabIndex = 22
        Me.Bdelete.Text = "   ລຶບ"
        Me.Bdelete.UseVisualStyleBackColor = True
        '
        'Bsave
        '
        Me.Bsave.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.Image = CType(resources.GetObject("Bsave.Image"), System.Drawing.Image)
        Me.Bsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bsave.Location = New System.Drawing.Point(173, 3)
        Me.Bsave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(112, 36)
        Me.Bsave.TabIndex = 23
        Me.Bsave.Text = "   ບັນທຶກ"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'Bclos
        '
        Me.Bclos.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bclos.Image = CType(resources.GetObject("Bclos.Image"), System.Drawing.Image)
        Me.Bclos.Location = New System.Drawing.Point(4, 3)
        Me.Bclos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bclos.Name = "Bclos"
        Me.Bclos.Size = New System.Drawing.Size(41, 36)
        Me.Bclos.TabIndex = 20
        Me.Bclos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bclos.UseVisualStyleBackColor = True
        '
        'Badd
        '
        Me.Badd.Font = New System.Drawing.Font("Saysettha OT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Badd.Image = CType(resources.GetObject("Badd.Image"), System.Drawing.Image)
        Me.Badd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Badd.Location = New System.Drawing.Point(61, 3)
        Me.Badd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(112, 36)
        Me.Badd.TabIndex = 21
        Me.Badd.Text = "   ເພີ່ມໃໝ່"
        Me.Badd.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(136, 106)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(135, 24)
        Me.ToolStripMenuItem1.Text = "ເພີ່ມໃໝ່"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(135, 24)
        Me.ToolStripMenuItem2.Text = "ບັນທຶກ"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.ToolStripMenuItem3.ShowShortcutKeys = False
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(135, 24)
        Me.ToolStripMenuItem3.Text = "ລຶບ"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(132, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.CloseToolStripMenuItem.ShowShortcutKeys = False
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Panel1.Controls.Add(Me.FG)
        Me.Panel1.Location = New System.Drawing.Point(4, 107)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 218)
        Me.Panel1.TabIndex = 30
        '
        'FG
        '
        Me.FG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FG.Location = New System.Drawing.Point(0, 0)
        Me.FG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FG.Name = "FG"
        Me.FG.OcxState = CType(resources.GetObject("FG.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FG.Size = New System.Drawing.Size(783, 218)
        Me.FG.TabIndex = 0
        '
        'FrmAPListEthnic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(785, 329)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Badd)
        Me.Controls.Add(Me.Bclos)
        Me.Controls.Add(Me.Bdelete)
        Me.Controls.Add(Me.Bsave)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmAPListEthnic"
        Me.ShowIcon = False
        Me.Text = "FrmAPListEthnic"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.FG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Bdelete As System.Windows.Forms.Button
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents Bclos As System.Windows.Forms.Button
    Friend WithEvents Badd As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FG As AxVSFlex8U.AxVSFlexGrid
End Class
