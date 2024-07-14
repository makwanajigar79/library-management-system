<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerPage
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
        Me.PanelcustomerPage = New System.Windows.Forms.Panel()
        Me.btnViewCustomer = New System.Windows.Forms.Button()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
        Me.btnPenaltyStatus = New System.Windows.Forms.Button()
        Me.btnUpdateCustomer = New System.Windows.Forms.Button()
        Me.PanelcustomerPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelcustomerPage
        '
        Me.PanelcustomerPage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelcustomerPage.BackColor = System.Drawing.Color.Transparent
        Me.PanelcustomerPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelcustomerPage.Controls.Add(Me.btnViewCustomer)
        Me.PanelcustomerPage.Controls.Add(Me.btnDeleteCustomer)
        Me.PanelcustomerPage.Controls.Add(Me.btnPenaltyStatus)
        Me.PanelcustomerPage.Controls.Add(Me.btnUpdateCustomer)
        Me.PanelcustomerPage.ForeColor = System.Drawing.Color.Blue
        Me.PanelcustomerPage.Location = New System.Drawing.Point(0, 0)
        Me.PanelcustomerPage.Name = "PanelcustomerPage"
        Me.PanelcustomerPage.Size = New System.Drawing.Size(363, 274)
        Me.PanelcustomerPage.TabIndex = 0
        '
        'btnViewCustomer
        '
        Me.btnViewCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewCustomer.BackColor = System.Drawing.Color.Transparent
        Me.btnViewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewCustomer.ForeColor = System.Drawing.Color.Black
        Me.btnViewCustomer.Location = New System.Drawing.Point(182, 59)
        Me.btnViewCustomer.Name = "btnViewCustomer"
        Me.btnViewCustomer.Size = New System.Drawing.Size(140, 70)
        Me.btnViewCustomer.TabIndex = 1
        Me.btnViewCustomer.Text = "VIEW CUSTOMER"
        Me.btnViewCustomer.UseVisualStyleBackColor = False
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteCustomer.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCustomer.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(182, 135)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(140, 70)
        Me.btnDeleteCustomer.TabIndex = 3
        Me.btnDeleteCustomer.Text = "DELETE CUSTOMER"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = False
        '
        'btnPenaltyStatus
        '
        Me.btnPenaltyStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPenaltyStatus.BackColor = System.Drawing.Color.Transparent
        Me.btnPenaltyStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPenaltyStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenaltyStatus.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyStatus.Location = New System.Drawing.Point(36, 59)
        Me.btnPenaltyStatus.Name = "btnPenaltyStatus"
        Me.btnPenaltyStatus.Size = New System.Drawing.Size(140, 70)
        Me.btnPenaltyStatus.TabIndex = 0
        Me.btnPenaltyStatus.Text = "ADD CUSTOMER"
        Me.btnPenaltyStatus.UseVisualStyleBackColor = False
        '
        'btnUpdateCustomer
        '
        Me.btnUpdateCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateCustomer.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCustomer.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateCustomer.Location = New System.Drawing.Point(36, 135)
        Me.btnUpdateCustomer.Name = "btnUpdateCustomer"
        Me.btnUpdateCustomer.Size = New System.Drawing.Size(140, 70)
        Me.btnUpdateCustomer.TabIndex = 2
        Me.btnUpdateCustomer.Text = "UPDATE CUSTOMER"
        Me.btnUpdateCustomer.UseVisualStyleBackColor = False
        '
        'CustomerPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d433391
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(363, 274)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelcustomerPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerPage"
        Me.Text = "CustomerPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelcustomerPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelcustomerPage As System.Windows.Forms.Panel
    Friend WithEvents btnUpdateCustomer As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyStatus As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCustomer As System.Windows.Forms.Button
    Friend WithEvents btnViewCustomer As System.Windows.Forms.Button
End Class
