<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookReport
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
        Me.Book_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_DataSet = New LIBRARY_MANAGEMENT_SYSTEM.Book_DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Book_TBTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.Book_DataSetTableAdapters.Book_TBTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.Book_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Book_TBBindingSource
        '
        Me.Book_TBBindingSource.DataMember = "Book_TB"
        Me.Book_TBBindingSource.DataSource = Me.Book_DataSet
        '
        'Book_DataSet
        '
        Me.Book_DataSet.DataSetName = "Book_DataSet"
        Me.Book_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Book_TBBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LIBRARY_MANAGEMENT_SYSTEM.Book_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1018, 578)
        Me.ReportViewer1.TabIndex = 0
        '
        'Book_TBTableAdapter
        '
        Me.Book_TBTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(946, 606)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 34)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'BookReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d433391
        Me.ClientSize = New System.Drawing.Size(1069, 642)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "BookReport"
        Me.Text = "BookReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Book_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Book_TBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_DataSet As LIBRARY_MANAGEMENT_SYSTEM.Book_DataSet
    Friend WithEvents Book_TBTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.Book_DataSetTableAdapters.Book_TBTableAdapter
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
