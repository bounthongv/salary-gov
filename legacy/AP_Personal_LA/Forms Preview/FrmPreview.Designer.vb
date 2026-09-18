<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPreview
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
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BtnBack = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer.AutoSize = True
        Me.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportViewer.Location = New System.Drawing.Point(28, -2)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.SelectionFormula = ""
        Me.ReportViewer.Size = New System.Drawing.Size(361, 433)
        Me.ReportViewer.TabIndex = 0
        Me.ReportViewer.ViewTimeSelectionFormula = ""
        '
        'BtnBack
        '
        Me.BtnBack.Image = Global.APInvioce.My.Resources.Resources.Close_Form
        Me.BtnBack.Location = New System.Drawing.Point(-2, -2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(30, 31)
        Me.BtnBack.TabIndex = 3
        Me.BtnBack.Tag = ""
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'FrmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.ReportViewer)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmPreview"
        Me.Text = "Preview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnBack As System.Windows.Forms.Button
End Class
