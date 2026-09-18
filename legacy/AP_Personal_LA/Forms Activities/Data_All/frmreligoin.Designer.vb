<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreligoin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreligoin))
        Me.FG = New AxVSFlex8U.AxVSFlexGrid
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Bdel = New System.Windows.Forms.Button
        Me.Bsave = New System.Windows.Forms.Button
        Me.Badd = New System.Windows.Forms.Button
        Me.Bclose = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.FG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FG
        '
        Me.FG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FG.DataSource = Nothing
        Me.FG.Location = New System.Drawing.Point(9, 105)
        Me.FG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FG.Name = "FG"
        Me.FG.OcxState = CType(resources.GetObject("FG.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FG.Size = New System.Drawing.Size(805, 231)
        Me.FG.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(155, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(101, 29)
        Me.txtID.TabIndex = 1
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(155, 71)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(323, 30)
        Me.txtname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ຊື່ສາດສະໜາ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ເລກລະຫັດ"
        '
        'Bdel
        '
        Me.Bdel.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bdel.Image = CType(resources.GetObject("Bdel.Image"), System.Drawing.Image)
        Me.Bdel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bdel.Location = New System.Drawing.Point(256, 1)
        Me.Bdel.Name = "Bdel"
        Me.Bdel.Size = New System.Drawing.Size(101, 38)
        Me.Bdel.TabIndex = 2
        Me.Bdel.Text = "   ລຶບ"
        Me.Bdel.UseVisualStyleBackColor = True
        '
        'Bsave
        '
        Me.Bsave.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.Image = CType(resources.GetObject("Bsave.Image"), System.Drawing.Image)
        Me.Bsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bsave.Location = New System.Drawing.Point(155, 1)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(101, 38)
        Me.Bsave.TabIndex = 2
        Me.Bsave.Text = "   ບັນທຶກ"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'Badd
        '
        Me.Badd.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Badd.Image = CType(resources.GetObject("Badd.Image"), System.Drawing.Image)
        Me.Badd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Badd.Location = New System.Drawing.Point(54, 1)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(101, 38)
        Me.Badd.TabIndex = 2
        Me.Badd.Text = "   ເພີ່ມໃໝ່"
        Me.Badd.UseVisualStyleBackColor = True
        '
        'Bclose
        '
        Me.Bclose.Image = CType(resources.GetObject("Bclose.Image"), System.Drawing.Image)
        Me.Bclose.Location = New System.Drawing.Point(9, 1)
        Me.Bclose.Name = "Bclose"
        Me.Bclose.Size = New System.Drawing.Size(39, 38)
        Me.Bclose.TabIndex = 2
        Me.Bclose.UseVisualStyleBackColor = True
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
        'frmreligoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 350)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bclose)
        Me.Controls.Add(Me.FG)
        Me.Controls.Add(Me.Bdel)
        Me.Controls.Add(Me.Bsave)
        Me.Controls.Add(Me.Badd)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtname)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmreligoin"
        Me.ShowIcon = False
        Me.Text = "frmreligoin"
        CType(Me.FG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FG As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Bclose As System.Windows.Forms.Button
    Friend WithEvents Badd As System.Windows.Forms.Button
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents Bdel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
