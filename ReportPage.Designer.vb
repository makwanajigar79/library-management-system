<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTNIssueBookReport = New System.Windows.Forms.Button()
        Me.BTNRturnBook = New System.Windows.Forms.Button()
        Me.btnBookReport = New System.Windows.Forms.Button()
        Me.btnCustomerReport = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.BTNIssueBookReport)
        Me.Panel1.Controls.Add(Me.BTNRturnBook)
        Me.Panel1.Controls.Add(Me.btnBookReport)
        Me.Panel1.Controls.Add(Me.btnCustomerReport)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 277)
        Me.Panel1.TabIndex = 2
        '
        'BTNIssueBookReport
        '
        Me.BTNIssueBookReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNIssueBookReport.BackColor = System.Drawing.Color.Transparent
        Me.BTNIssueBookReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNIssueBookReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIssueBookReport.ForeColor = System.Drawing.Color.Black
        Me.BTNIssueBookReport.Location = New System.Drawing.Point(170, 57)
        Me.BTNIssueBookReport.Name = "BTNIssueBookReport"
        Me.BTNIssueBookReport.Size = New System.Drawing.Size(140, 70)
        Me.BTNIssueBookReport.TabIndex = 2
        Me.BTNIssueBookReport.Text = "ISSUE  REPORT"
        Me.BTNIssueBookReport.UseVisualStyleBackColor = False
        '
        'BTNRturnBook
        '
        Me.BTNRturnBook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNRturnBook.BackColor = System.Drawing.Color.Transparent
        Me.BTNRturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRturnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRturnBook.ForeColor = System.Drawing.Color.Black
        Me.BTNRturnBook.Location = New System.Drawing.Point(170, 133)
        Me.BTNRturnBook.Name = "BTNRturnBook"
        Me.BTNRturnBook.Size = New System.Drawing.Size(140, 70)
        Me.BTNRturnBook.TabIndex = 3
        Me.BTNRturnBook.Text = "RETURN REPORT"
        Me.BTNRturnBook.UseVisualStyleBackColor = False
        '
        'btnBookReport
        '
        Me.btnBookReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBookReport.BackColor = System.Drawing.Color.Transparent
        Me.btnBookReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookReport.ForeColor = System.Drawing.Color.Black
        Me.btnBookReport.Location = New System.Drawing.Point(22, 57)
        Me.btnBookReport.Name = "btnBookReport"
        Me.btnBookReport.Size = New System.Drawing.Size(140, 70)
        Me.btnBookReport.TabIndex = 0
        Me.btnBookReport.Text = "BOOK REPORT"
        Me.btnBookReport.UseVisualStyleBackColor = False
        '
        'btnCustomerReport
        '
        Me.btnCustomerReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCustomerReport.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerReport.ForeColor = System.Drawing.Color.Black
        Me.btnCustomerReport.Location = New System.Drawing.Point(22, 133)
        Me.btnCustomerReport.Name = "btnCustomerReport"
        Me.btnCustomerReport.Size = New System.Drawing.Size(140, 70)
        Me.btnCustomerReport.TabIndex = 1
        Me.btnCustomerReport.Text = "CUSTOMER REPORT"
        Me.btnCustomerReport.UseVisualStyleBackColor = False
        '
        'ReportPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d433391
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(330, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportPage"
        Me.Text = "ReportPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBookReport As System.Windows.Forms.Button
    Friend WithEvents btnCustomerReport As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BTNIssueBookReport As System.Windows.Forms.Button
    Friend WithEvents BTNRturnBook As System.Windows.Forms.Button
End Class
