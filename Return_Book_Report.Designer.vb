<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Return_Book_Report
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
        Me.Return_Book_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Return_Book_DataSet = New LIBRARY_MANAGEMENT_SYSTEM.Return_Book_DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Return_Book_TBTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.Return_Book_DataSetTableAdapters.Return_Book_TBTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.Return_Book_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Return_Book_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Return_Book_TBBindingSource
        '
        Me.Return_Book_TBBindingSource.DataMember = "Return_Book_TB"
        Me.Return_Book_TBBindingSource.DataSource = Me.Return_Book_DataSet
        '
        'Return_Book_DataSet
        '
        Me.Return_Book_DataSet.DataSetName = "Return_Book_DataSet"
        Me.Return_Book_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Return_Book_TBBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LIBRARY_MANAGEMENT_SYSTEM.Return_Book_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(39, 29)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1184, 664)
        Me.ReportViewer1.TabIndex = 0
        '
        'Return_Book_TBTableAdapter
        '
        Me.Return_Book_TBTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1139, 708)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 31)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Return_Book_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1252, 740)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Return_Book_Report"
        Me.Text = "Return_Book_Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Return_Book_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Return_Book_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Return_Book_TBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Return_Book_DataSet As LIBRARY_MANAGEMENT_SYSTEM.Return_Book_DataSet
    Friend WithEvents Return_Book_TBTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.Return_Book_DataSetTableAdapters.Return_Book_TBTableAdapter
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
