<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Issue_Book_Report
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Issue_BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Issue_Book_DataSet = New LIBRARY_MANAGEMENT_SYSTEM.Issue_Book_DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Issue_BookTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.Issue_Book_DataSetTableAdapters.Issue_BookTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.Issue_BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Issue_Book_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Issue_BookBindingSource
        '
        Me.Issue_BookBindingSource.DataMember = "Issue_Book"
        Me.Issue_BookBindingSource.DataSource = Me.Issue_Book_DataSet
        '
        'Issue_Book_DataSet
        '
        Me.Issue_Book_DataSet.DataSetName = "Issue_Book_DataSet"
        Me.Issue_Book_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Issue_BookBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LIBRARY_MANAGEMENT_SYSTEM.Issue_Book_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(14, 73)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1310, 525)
        Me.ReportViewer1.TabIndex = 0
        '
        'Issue_BookTableAdapter
        '
        Me.Issue_BookTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1249, 617)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 31)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Issue_Book_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1338, 682)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Issue_Book_Report"
        Me.Text = "Issue_Book_Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Issue_BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Issue_Book_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Issue_BookBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Issue_Book_DataSet As LIBRARY_MANAGEMENT_SYSTEM.Issue_Book_DataSet
    Friend WithEvents Issue_BookTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.Issue_Book_DataSetTableAdapters.Issue_BookTableAdapter
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
