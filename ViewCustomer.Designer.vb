<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCustomer
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
        Me.txtRegisterCust = New System.Windows.Forms.TextBox()
        Me.lblRegisterUser = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridViewCustomer = New System.Windows.Forms.DataGridView()
        Me.lblsearchCustName = New System.Windows.Forms.Label()
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.cmbBoxSearch = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txtRegisterCust)
        Me.Panel1.Controls.Add(Me.lblRegisterUser)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.DataGridViewCustomer)
        Me.Panel1.Controls.Add(Me.lblsearchCustName)
        Me.Panel1.Controls.Add(Me.btnSearchName)
        Me.Panel1.Controls.Add(Me.cmbBoxSearch)
        Me.Panel1.Location = New System.Drawing.Point(51, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1272, 727)
        Me.Panel1.TabIndex = 1
        '
        'txtRegisterCust
        '
        Me.txtRegisterCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRegisterCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterCust.ForeColor = System.Drawing.Color.Black
        Me.txtRegisterCust.Location = New System.Drawing.Point(1030, 26)
        Me.txtRegisterCust.Name = "txtRegisterCust"
        Me.txtRegisterCust.ReadOnly = True
        Me.txtRegisterCust.Size = New System.Drawing.Size(172, 26)
        Me.txtRegisterCust.TabIndex = 23
        '
        'lblRegisterUser
        '
        Me.lblRegisterUser.AutoSize = True
        Me.lblRegisterUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterUser.ForeColor = System.Drawing.Color.Black
        Me.lblRegisterUser.Location = New System.Drawing.Point(806, 27)
        Me.lblRegisterUser.Name = "lblRegisterUser"
        Me.lblRegisterUser.Size = New System.Drawing.Size(218, 20)
        Me.lblRegisterUser.TabIndex = 22
        Me.lblRegisterUser.Text = "REGISTERD CUSTOMER"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1085, 670)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 42)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DataGridViewCustomer
        '
        Me.DataGridViewCustomer.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomer.Location = New System.Drawing.Point(41, 91)
        Me.DataGridViewCustomer.Name = "DataGridViewCustomer"
        Me.DataGridViewCustomer.Size = New System.Drawing.Size(1173, 548)
        Me.DataGridViewCustomer.TabIndex = 20
        '
        'lblsearchCustName
        '
        Me.lblsearchCustName.AutoSize = True
        Me.lblsearchCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearchCustName.Location = New System.Drawing.Point(57, 27)
        Me.lblsearchCustName.Name = "lblsearchCustName"
        Me.lblsearchCustName.Size = New System.Drawing.Size(271, 20)
        Me.lblsearchCustName.TabIndex = 19
        Me.lblsearchCustName.Text = "SEARCH BY CUSTOMER NAME"
        '
        'btnSearchName
        '
        Me.btnSearchName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchName.Location = New System.Drawing.Point(621, 17)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(150, 40)
        Me.btnSearchName.TabIndex = 18
        Me.btnSearchName.Text = "SEARCH"
        Me.btnSearchName.UseVisualStyleBackColor = False
        '
        'cmbBoxSearch
        '
        Me.cmbBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbBoxSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxSearch.FormattingEnabled = True
        Me.cmbBoxSearch.Location = New System.Drawing.Point(365, 24)
        Me.cmbBoxSearch.Name = "cmbBoxSearch"
        Me.cmbBoxSearch.Size = New System.Drawing.Size(229, 28)
        Me.cmbBoxSearch.TabIndex = 17
        '
        'ViewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1368, 777)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ViewCustomer"
        Me.Text = "ViewCustomer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents lblsearchCustName As System.Windows.Forms.Label
    Friend WithEvents btnSearchName As System.Windows.Forms.Button
    Friend WithEvents cmbBoxSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtRegisterCust As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterUser As System.Windows.Forms.Label
End Class
