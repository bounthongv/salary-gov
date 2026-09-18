<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRrunk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRrunk))
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnDele = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.FG = New AxVSFlex8U.AxVSFlexGrid
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.FG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 24)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "ຊື່:"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(132, 87)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(281, 30)
        Me.txtname.TabIndex = 40
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtID.Location = New System.Drawing.Point(132, 54)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(84, 30)
        Me.TxtID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "ລະຫັດ:"
        '
        'BtnDele
        '
        Me.BtnDele.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDele.Image = CType(resources.GetObject("BtnDele.Image"), System.Drawing.Image)
        Me.BtnDele.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDele.Location = New System.Drawing.Point(216, 3)
        Me.BtnDele.Name = "BtnDele"
        Me.BtnDele.Size = New System.Drawing.Size(79, 51)
        Me.BtnDele.TabIndex = 35
        Me.BtnDele.Text = "  ລຶບ"
        Me.BtnDele.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDele.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSave.Location = New System.Drawing.Point(132, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(84, 51)
        Me.BtnSave.TabIndex = 34
        Me.BtnSave.Text = "  ບັກທຶກ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdd.Location = New System.Drawing.Point(51, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(81, 51)
        Me.BtnAdd.TabIndex = 33
        Me.BtnAdd.Text = "  ເພີ່ມໃຫມ່"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClose.Location = New System.Drawing.Point(3, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 51)
        Me.BtnClose.TabIndex = 43
        Me.BtnClose.Text = "ປິດ"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FG
        '
        Me.FG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FG.Location = New System.Drawing.Point(7, 121)
        Me.FG.Name = "FG"
        Me.FG.OcxState = CType(resources.GetObject("FG.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FG.Size = New System.Drawing.Size(782, 306)
        Me.FG.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(546, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 51)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "ຂໍ້ມູນຕົ້ນກຳເນີດ"
        '
        'FrmRrunk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(789, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FG)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnDele)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmRrunk"
        Me.Text = "ຂໍ້ມູນຕົ້ນກຳເນີດ"
        CType(Me.FG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnDele As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents FG As AxVSFlex8U.AxVSFlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
