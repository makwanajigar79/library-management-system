<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteCustomer
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
        Me.PanelDeleteCustomer = New System.Windows.Forms.Panel()
        Me.DataGridViewDeleteCust = New System.Windows.Forms.DataGridView()
        Me.cmbRegisterID = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblJoinDate = New System.Windows.Forms.Label()
        Me.lblRegisterID = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBACK = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtEmailid = New System.Windows.Forms.TextBox()
        Me.lblStdEmailId = New System.Windows.Forms.Label()
        Me.txtMobileno = New System.Windows.Forms.TextBox()
        Me.lblmobileno = New System.Windows.Forms.Label()
        Me.txtpincode = New System.Windows.Forms.TextBox()
        Me.lblpincode = New System.Windows.Forms.Label()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.lblcity = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.ComboBoxDept = New System.Windows.Forms.ComboBox()
        Me.TXTLNAME = New System.Windows.Forms.TextBox()
        Me.LblLName = New System.Windows.Forms.Label()
        Me.cmbBoxFName = New System.Windows.Forms.ComboBox()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.PanelDeleteCustomer.SuspendLayout()
        CType(Me.DataGridViewDeleteCust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDeleteCustomer
        '
        Me.PanelDeleteCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelDeleteCustomer.BackColor = System.Drawing.Color.Transparent
        Me.PanelDeleteCustomer.Controls.Add(Me.TXTLNAME)
        Me.PanelDeleteCustomer.Controls.Add(Me.LblLName)
        Me.PanelDeleteCustomer.Controls.Add(Me.cmbBoxFName)
        Me.PanelDeleteCustomer.Controls.Add(Me.lblFname)
        Me.PanelDeleteCustomer.Controls.Add(Me.DataGridViewDeleteCust)
        Me.PanelDeleteCustomer.Controls.Add(Me.cmbRegisterID)
        Me.PanelDeleteCustomer.Controls.Add(Me.DateTimePicker1)
        Me.PanelDeleteCustomer.Controls.Add(Me.lblJoinDate)
        Me.PanelDeleteCustomer.Controls.Add(Me.lblRegisterID)
        Me.PanelDeleteCustomer.Controls.Add(Me.btnReset)
        Me.PanelDeleteCustomer.Controls.Add(Me.btnBACK)
        Me.PanelDeleteCustomer.Controls.Add(Me.btnDelete)
        Me.PanelDeleteCustomer.Controls.Add(Me.txtEmailid)
        Me.PanelDeleteCustomer.Controls.Add(Me.lblStdEmailId)
        Me.PanelDeleteCustomer.Controls.Add(Me.txtMobileno)
        Me.PanelDeleteCustomer.Controls.Add(Me.lblmobileno)
        Me.PanelDeleteCustomer.Controls.Add(Me.txtpincode)
        Me.PanelDeleteCustomer.Controls.Add(Me.lblpincode)
        Me.PanelDeleteCustomer.Controls.Add(Me.txtcity)
        Me.PanelDeleteCustomer.Controls.Add(Me.lblcity)
        Me.PanelDeleteCustomer.Controls.Add(Me.txtaddress)
        Me.PanelDeleteCustomer.Controls.Add(Me.lblAddress)
        Me.PanelDeleteCustomer.Controls.Add(Me.lblDept)
        Me.PanelDeleteCustomer.Controls.Add(Me.ComboBoxDept)
        Me.PanelDeleteCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelDeleteCustomer.ForeColor = System.Drawing.Color.Black
        Me.PanelDeleteCustomer.Location = New System.Drawing.Point(263, 26)
        Me.PanelDeleteCustomer.Name = "PanelDeleteCustomer"
        Me.PanelDeleteCustomer.Size = New System.Drawing.Size(864, 739)
        Me.PanelDeleteCustomer.TabIndex = 2
        '
        'DataGridViewDeleteCust
        '
        Me.DataGridViewDeleteCust.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewDeleteCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDeleteCust.Location = New System.Drawing.Point(39, 434)
        Me.DataGridViewDeleteCust.Name = "DataGridViewDeleteCust"
        Me.DataGridViewDeleteCust.Size = New System.Drawing.Size(798, 173)
        Me.DataGridViewDeleteCust.TabIndex = 32
        '
        'cmbRegisterID
        '
        Me.cmbRegisterID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbRegisterID.Enabled = False
        Me.cmbRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRegisterID.FormattingEnabled = True
        Me.cmbRegisterID.Location = New System.Drawing.Point(296, 15)
        Me.cmbRegisterID.Name = "cmbRegisterID"
        Me.cmbRegisterID.Size = New System.Drawing.Size(198, 26)
        Me.cmbRegisterID.TabIndex = 31
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(654, 55)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePicker1.TabIndex = 30
        '
        'lblJoinDate
        '
        Me.lblJoinDate.AutoSize = True
        Me.lblJoinDate.Enabled = False
        Me.lblJoinDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoinDate.ForeColor = System.Drawing.Color.Black
        Me.lblJoinDate.Location = New System.Drawing.Point(517, 57)
        Me.lblJoinDate.Name = "lblJoinDate"
        Me.lblJoinDate.Size = New System.Drawing.Size(123, 18)
        Me.lblJoinDate.TabIndex = 29
        Me.lblJoinDate.Text = "JOINING DATE"
        '
        'lblRegisterID
        '
        Me.lblRegisterID.AutoSize = True
        Me.lblRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterID.ForeColor = System.Drawing.Color.Black
        Me.lblRegisterID.Location = New System.Drawing.Point(72, 18)
        Me.lblRegisterID.Name = "lblRegisterID"
        Me.lblRegisterID.Size = New System.Drawing.Size(151, 18)
        Me.lblRegisterID.TabIndex = 24
        Me.lblRegisterID.Text = "REGISTRATION ID"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(360, 653)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 70)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnBACK
        '
        Me.btnBACK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBACK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBACK.ForeColor = System.Drawing.Color.Black
        Me.btnBACK.Location = New System.Drawing.Point(622, 653)
        Me.btnBACK.Name = "btnBACK"
        Me.btnBACK.Size = New System.Drawing.Size(160, 70)
        Me.btnBACK.TabIndex = 4
        Me.btnBACK.Text = "BACK"
        Me.btnBACK.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(105, 653)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(160, 70)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtEmailid
        '
        Me.txtEmailid.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmailid.Enabled = False
        Me.txtEmailid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailid.ForeColor = System.Drawing.Color.Black
        Me.txtEmailid.Location = New System.Drawing.Point(293, 376)
        Me.txtEmailid.Name = "txtEmailid"
        Me.txtEmailid.Size = New System.Drawing.Size(201, 24)
        Me.txtEmailid.TabIndex = 9
        '
        'lblStdEmailId
        '
        Me.lblStdEmailId.AutoSize = True
        Me.lblStdEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdEmailId.ForeColor = System.Drawing.Color.Black
        Me.lblStdEmailId.Location = New System.Drawing.Point(146, 382)
        Me.lblStdEmailId.Name = "lblStdEmailId"
        Me.lblStdEmailId.Size = New System.Drawing.Size(77, 18)
        Me.lblStdEmailId.TabIndex = 13
        Me.lblStdEmailId.Text = "EMAIL ID"
        '
        'txtMobileno
        '
        Me.txtMobileno.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMobileno.Enabled = False
        Me.txtMobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileno.ForeColor = System.Drawing.Color.Black
        Me.txtMobileno.Location = New System.Drawing.Point(296, 328)
        Me.txtMobileno.Name = "txtMobileno"
        Me.txtMobileno.Size = New System.Drawing.Size(198, 24)
        Me.txtMobileno.TabIndex = 6
        '
        'lblmobileno
        '
        Me.lblmobileno.AutoSize = True
        Me.lblmobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobileno.ForeColor = System.Drawing.Color.Black
        Me.lblmobileno.Location = New System.Drawing.Point(76, 334)
        Me.lblmobileno.Name = "lblmobileno"
        Me.lblmobileno.Size = New System.Drawing.Size(147, 18)
        Me.lblmobileno.TabIndex = 11
        Me.lblmobileno.Text = "MOBILE NUMBER"
        '
        'txtpincode
        '
        Me.txtpincode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpincode.Enabled = False
        Me.txtpincode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpincode.ForeColor = System.Drawing.Color.Black
        Me.txtpincode.Location = New System.Drawing.Point(640, 287)
        Me.txtpincode.Name = "txtpincode"
        Me.txtpincode.Size = New System.Drawing.Size(177, 24)
        Me.txtpincode.TabIndex = 5
        '
        'lblpincode
        '
        Me.lblpincode.AutoSize = True
        Me.lblpincode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpincode.ForeColor = System.Drawing.Color.Black
        Me.lblpincode.Location = New System.Drawing.Point(539, 290)
        Me.lblpincode.Name = "lblpincode"
        Me.lblpincode.Size = New System.Drawing.Size(83, 18)
        Me.lblpincode.TabIndex = 9
        Me.lblpincode.Text = "PINCODE"
        '
        'txtcity
        '
        Me.txtcity.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcity.Enabled = False
        Me.txtcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.ForeColor = System.Drawing.Color.Black
        Me.txtcity.Location = New System.Drawing.Point(296, 287)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(201, 24)
        Me.txtcity.TabIndex = 4
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcity.ForeColor = System.Drawing.Color.Black
        Me.lblcity.Location = New System.Drawing.Point(179, 290)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(44, 18)
        Me.lblcity.TabIndex = 7
        Me.lblcity.Text = "CITY"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtaddress.Enabled = False
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.Location = New System.Drawing.Point(296, 187)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(201, 82)
        Me.txtaddress.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(136, 190)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(87, 18)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "ADDRESS"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.ForeColor = System.Drawing.Color.Black
        Me.lblDept.Location = New System.Drawing.Point(102, 61)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(121, 18)
        Me.lblDept.TabIndex = 1
        Me.lblDept.Text = "DEPARTMENT"
        '
        'ComboBoxDept
        '
        Me.ComboBoxDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ComboBoxDept.Enabled = False
        Me.ComboBoxDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDept.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxDept.FormattingEnabled = True
        Me.ComboBoxDept.Items.AddRange(New Object() {"B.C.A", "B.B.A", "B.COM", "B.S.C", "L.L.B"})
        Me.ComboBoxDept.Location = New System.Drawing.Point(296, 57)
        Me.ComboBoxDept.Name = "ComboBoxDept"
        Me.ComboBoxDept.Size = New System.Drawing.Size(198, 26)
        Me.ComboBoxDept.TabIndex = 1
        '
        'TXTLNAME
        '
        Me.TXTLNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXTLNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLNAME.ForeColor = System.Drawing.Color.Black
        Me.TXTLNAME.Location = New System.Drawing.Point(296, 148)
        Me.TXTLNAME.Name = "TXTLNAME"
        Me.TXTLNAME.Size = New System.Drawing.Size(201, 24)
        Me.TXTLNAME.TabIndex = 38
        '
        'LblLName
        '
        Me.LblLName.AutoSize = True
        Me.LblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLName.ForeColor = System.Drawing.Color.Black
        Me.LblLName.Location = New System.Drawing.Point(123, 148)
        Me.LblLName.Name = "LblLName"
        Me.LblLName.Size = New System.Drawing.Size(100, 18)
        Me.LblLName.TabIndex = 39
        Me.LblLName.Text = "LAST NAME"
        '
        'cmbBoxFName
        '
        Me.cmbBoxFName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxFName.ForeColor = System.Drawing.Color.Black
        Me.cmbBoxFName.FormattingEnabled = True
        Me.cmbBoxFName.Location = New System.Drawing.Point(296, 104)
        Me.cmbBoxFName.Name = "cmbBoxFName"
        Me.cmbBoxFName.Size = New System.Drawing.Size(198, 26)
        Me.cmbBoxFName.TabIndex = 37
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.ForeColor = System.Drawing.Color.Black
        Me.lblFname.Location = New System.Drawing.Point(116, 107)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(107, 18)
        Me.lblFname.TabIndex = 36
        Me.lblFname.Text = "FIRST NAME"
        '
        'DeleteCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1368, 777)
        Me.Controls.Add(Me.PanelDeleteCustomer)
        Me.Name = "DeleteCustomer"
        Me.Text = "DeleteCustomer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelDeleteCustomer.ResumeLayout(False)
        Me.PanelDeleteCustomer.PerformLayout()
        CType(Me.DataGridViewDeleteCust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelDeleteCustomer As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewDeleteCust As System.Windows.Forms.DataGridView
    Friend WithEvents cmbRegisterID As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblJoinDate As System.Windows.Forms.Label
    Friend WithEvents lblRegisterID As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnBACK As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtEmailid As System.Windows.Forms.TextBox
    Friend WithEvents lblStdEmailId As System.Windows.Forms.Label
    Friend WithEvents txtMobileno As System.Windows.Forms.TextBox
    Friend WithEvents lblmobileno As System.Windows.Forms.Label
    Friend WithEvents txtpincode As System.Windows.Forms.TextBox
    Friend WithEvents lblpincode As System.Windows.Forms.Label
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDept As System.Windows.Forms.ComboBox
    Friend WithEvents TXTLNAME As System.Windows.Forms.TextBox
    Friend WithEvents LblLName As System.Windows.Forms.Label
    Friend WithEvents cmbBoxFName As System.Windows.Forms.ComboBox
    Friend WithEvents lblFname As System.Windows.Forms.Label
End Class
