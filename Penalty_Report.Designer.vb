<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penalty_Report
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
        Me.panalty_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Penalty_Report_DataSet = New LIBRARY_MANAGEMENT_SYSTEM.Penalty_Report_DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Book_DataSet = New LIBRARY_MANAGEMENT_SYSTEM.Book_DataSet()
        Me.Book_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_TBTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.Book_DataSetTableAdapters.Book_TBTableAdapter()
        Me.panalty_TBTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.Penalty_Report_DataSetTableAdapters.panalty_TBTableAdapter()
        CType(Me.panalty_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Penalty_Report_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panalty_TBBindingSource
        '
        Me.panalty_TBBindingSource.DataMember = "panalty_TB"
        Me.panalty_TBBindingSource.DataSource = Me.Penalty_Report_DataSet
        '
        'Penalty_Report_DataSet
        '
        Me.Penalty_Report_DataSet.DataSetName = "Penalty_Report_DataSet"
        Me.Penalty_Report_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None
        ReportDataSource1.Name = "Penalty_Report_DataSet"
        ReportDataSource1.Value = Me.panalty_TBBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LIBRARY_MANAGEMENT_SYSTEM.Penalty_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(30, 34)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1207, 677)
        Me.ReportViewer1.TabIndex = 0
        '
        'Book_DataSet
        '
        Me.Book_DataSet.DataSetName = "Book_DataSet"
        Me.Book_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Book_TBBindingSource
        '
        Me.Book_TBBindingSource.DataMember = "Book_TB"
        Me.Book_TBBindingSource.DataSource = Me.Book_DataSet
        '
        'Book_TBTableAdapter
        '
        Me.Book_TBTableAdapter.ClearBeforeFill = True
        '
        'panalty_TBTableAdapter
        '
        Me.panalty_TBTableAdapter.ClearBeforeFill = True
        '
        'Penalty_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.ClientSize = New System.Drawing.Size(1269, 741)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Penalty_Report"
        Me.Text = "Penalty_Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.panalty_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Penalty_Report_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Book_TBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_DataSet As LIBRARY_MANAGEMENT_SYSTEM.Book_DataSet
    Friend WithEvents Book_TBTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.Book_DataSetTableAdapters.Book_TBTableAdapter
    Friend WithEvents panalty_TBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Penalty_Report_DataSet As LIBRARY_MANAGEMENT_SYSTEM.Penalty_Report_DataSet
    Friend WithEvents panalty_TBTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.Penalty_Report_DataSetTableAdapters.panalty_TBTableAdapter
End Class
