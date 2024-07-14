<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PenaltyPage
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
        Me.btnPenaltyReport = New System.Windows.Forms.Button()
        Me.btnCheckPenalty = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPenaltyReport
        '
        Me.btnPenaltyReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPenaltyReport.BackColor = System.Drawing.Color.Transparent
        Me.btnPenaltyReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPenaltyReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenaltyReport.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyReport.Location = New System.Drawing.Point(103, 120)
        Me.btnPenaltyReport.Name = "btnPenaltyReport"
        Me.btnPenaltyReport.Size = New System.Drawing.Size(140, 70)
        Me.btnPenaltyReport.TabIndex = 4
        Me.btnPenaltyReport.Text = "PENALTY REPORT"
        Me.btnPenaltyReport.UseVisualStyleBackColor = False
        '
        'btnCheckPenalty
        '
        Me.btnCheckPenalty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCheckPenalty.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCheckPenalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckPenalty.ForeColor = System.Drawing.Color.Black
        Me.btnCheckPenalty.Location = New System.Drawing.Point(103, 44)
        Me.btnCheckPenalty.Name = "btnCheckPenalty"
        Me.btnCheckPenalty.Size = New System.Drawing.Size(140, 70)
        Me.btnCheckPenalty.TabIndex = 3
        Me.btnCheckPenalty.Text = "CHECK PENALTY"
        Me.btnCheckPenalty.UseVisualStyleBackColor = False
        '
        'PenaltyPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d433391
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(347, 235)
        Me.Controls.Add(Me.btnPenaltyReport)
        Me.Controls.Add(Me.btnCheckPenalty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PenaltyPage"
        Me.Text = "PenaltyPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPenaltyReport As System.Windows.Forms.Button
    Friend WithEvents btnCheckPenalty As System.Windows.Forms.Button
End Class
