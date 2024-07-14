<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Report
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
        Me.Register_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_Report_DataSet = New LIBRARY_MANAGEMENT_SYSTEM.Customer_Report_DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Register_TBTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.Customer_Report_DataSetTableAdapters.Register_TBTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.Register_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_Report_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Register_TBBindingSource
        '
        Me.Register_TBBindingSource.DataMember = "Register_TB"
        Me.Register_TBBindingSource.DataSource = Me.Customer_Report_DataSet
        '
        'Customer_Report_DataSet
        '
        Me.Customer_Report_DataSet.DataSetName = "Customer_Report_DataSet"
        Me.Customer_Report_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None
        ReportDataSource1.Name = "Customer_Report_DataSet"
        ReportDataSource1.Value = Me.Register_TBBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LIBRARY_MANAGEMENT_SYSTEM.Customer_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(36, 39)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1252, 584)
        Me.ReportViewer1.TabIndex = 0
        '
        'Register_TBTableAdapter
        '
        Me.Register_TBTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1170, 647)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 41)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Customer_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d433391
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1323, 715)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Customer_Report"
        Me.Text = "Customer_Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Register_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_Report_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Register_TBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_Report_DataSet As LIBRARY_MANAGEMENT_SYSTEM.Customer_Report_DataSet
    Friend WithEvents Register_TBTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.Customer_Report_DataSetTableAdapters.Register_TBTableAdapter
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
