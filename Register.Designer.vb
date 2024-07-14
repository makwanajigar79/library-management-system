<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Customer
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
        Me.lblDept = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.ComboBoxDept = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblJoinDate = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.RdbtnFemale = New System.Windows.Forms.RadioButton()
        Me.RdbtnMale = New System.Windows.Forms.RadioButton()
        Me.txtRegisterID = New System.Windows.Forms.TextBox()
        Me.lblRegisterID = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.btnBACK = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.ForeColor = System.Drawing.Color.Black
        Me.lblDept.Location = New System.Drawing.Point(153, 78)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(121, 18)
        Me.lblDept.TabIndex = 1
        Me.lblDept.Text = "DEPARTMENT"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.ForeColor = System.Drawing.Color.Black
        Me.lblFname.Location = New System.Drawing.Point(167, 123)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(107, 18)
        Me.lblFname.TabIndex = 3
        Me.lblFname.Text = "FIRST NAME"
        '
        'txtFName
        '
        Me.txtFName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.ForeColor = System.Drawing.Color.Black
        Me.txtFName.Location = New System.Drawing.Point(337, 120)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(247, 24)
        Me.txtFName.TabIndex = 2
        '
        'ComboBoxDept
        '
        Me.ComboBoxDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ComboBoxDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDept.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxDept.FormattingEnabled = True
        Me.ComboBoxDept.Items.AddRange(New Object() {"B.C.A", "B.B.A", "B.COM", "B.S.C", "L.L.B", "Science", "Commerce", "Arts", "M.C.A", "M.B.A", "M.B.B.S", "M.S.C", "BIO-LOGY"})
        Me.ComboBoxDept.Location = New System.Drawing.Point(337, 75)
        Me.ComboBoxDept.Name = "ComboBoxDept"
        Me.ComboBoxDept.Size = New System.Drawing.Size(247, 26)
        Me.ComboBoxDept.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.lblJoinDate)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.RdbtnFemale)
        Me.Panel1.Controls.Add(Me.RdbtnMale)
        Me.Panel1.Controls.Add(Me.txtRegisterID)
        Me.Panel1.Controls.Add(Me.lblRegisterID)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.txtLname)
        Me.Panel1.Controls.Add(Me.lblLname)
        Me.Panel1.Controls.Add(Me.btnBACK)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.txtEmailid)
        Me.Panel1.Controls.Add(Me.lblStdEmailId)
        Me.Panel1.Controls.Add(Me.txtMobileno)
        Me.Panel1.Controls.Add(Me.lblmobileno)
        Me.Panel1.Controls.Add(Me.txtpincode)
        Me.Panel1.Controls.Add(Me.lblpincode)
        Me.Panel1.Controls.Add(Me.txtcity)
        Me.Panel1.Controls.Add(Me.lblcity)
        Me.Panel1.Controls.Add(Me.txtaddress)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.lblDept)
        Me.Panel1.Controls.Add(Me.txtFName)
        Me.Panel1.Controls.Add(Me.ComboBoxDept)
        Me.Panel1.Controls.Add(Me.lblFname)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(171, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 700)
        Me.Panel1.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(811, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePicker1.TabIndex = 14
        '
        'lblJoinDate
        '
        Me.lblJoinDate.AutoSize = True
        Me.lblJoinDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoinDate.ForeColor = System.Drawing.Color.Black
        Me.lblJoinDate.Location = New System.Drawing.Point(669, 37)
        Me.lblJoinDate.Name = "lblJoinDate"
        Me.lblJoinDate.Size = New System.Drawing.Size(123, 18)
        Me.lblJoinDate.TabIndex = 29
        Me.lblJoinDate.Text = "JOINING DATE"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(195, 452)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(79, 18)
        Me.lblGender.TabIndex = 28
        Me.lblGender.Text = "GENDER"
        '
        'RdbtnFemale
        '
        Me.RdbtnFemale.AutoSize = True
        Me.RdbtnFemale.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RdbtnFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbtnFemale.ForeColor = System.Drawing.Color.Black
        Me.RdbtnFemale.Location = New System.Drawing.Point(460, 452)
        Me.RdbtnFemale.Name = "RdbtnFemale"
        Me.RdbtnFemale.Size = New System.Drawing.Size(91, 22)
        Me.RdbtnFemale.TabIndex = 9
        Me.RdbtnFemale.TabStop = True
        Me.RdbtnFemale.Text = "FEMALE"
        Me.RdbtnFemale.UseVisualStyleBackColor = False
        '
        'RdbtnMale
        '
        Me.RdbtnMale.AutoSize = True
        Me.RdbtnMale.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RdbtnMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbtnMale.ForeColor = System.Drawing.Color.Black
        Me.RdbtnMale.Location = New System.Drawing.Point(357, 450)
        Me.RdbtnMale.Name = "RdbtnMale"
        Me.RdbtnMale.Size = New System.Drawing.Size(70, 22)
        Me.RdbtnMale.TabIndex = 8
        Me.RdbtnMale.TabStop = True
        Me.RdbtnMale.Text = "MALE"
        Me.RdbtnMale.UseVisualStyleBackColor = False
        '
        'txtRegisterID
        '
        Me.txtRegisterID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterID.ForeColor = System.Drawing.Color.Black
        Me.txtRegisterID.Location = New System.Drawing.Point(337, 37)
        Me.txtRegisterID.Name = "txtRegisterID"
        Me.txtRegisterID.Size = New System.Drawing.Size(247, 24)
        Me.txtRegisterID.TabIndex = 0
        '
        'lblRegisterID
        '
        Me.lblRegisterID.AutoSize = True
        Me.lblRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterID.ForeColor = System.Drawing.Color.Black
        Me.lblRegisterID.Location = New System.Drawing.Point(123, 40)
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
        Me.btnReset.Location = New System.Drawing.Point(428, 598)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 70)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'txtLname
        '
        Me.txtLname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.ForeColor = System.Drawing.Color.Black
        Me.txtLname.Location = New System.Drawing.Point(337, 166)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(247, 24)
        Me.txtLname.TabIndex = 3
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.ForeColor = System.Drawing.Color.Black
        Me.lblLname.Location = New System.Drawing.Point(174, 169)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(100, 18)
        Me.lblLname.TabIndex = 17
        Me.lblLname.Text = "LAST NAME"
        '
        'btnBACK
        '
        Me.btnBACK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBACK.ForeColor = System.Drawing.Color.Black
        Me.btnBACK.Location = New System.Drawing.Point(664, 598)
        Me.btnBACK.Name = "btnBACK"
        Me.btnBACK.Size = New System.Drawing.Size(160, 70)
        Me.btnBACK.TabIndex = 13
        Me.btnBACK.Text = "BACK"
        Me.btnBACK.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.Location = New System.Drawing.Point(190, 598)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(160, 70)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtEmailid
        '
        Me.txtEmailid.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmailid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailid.ForeColor = System.Drawing.Color.Black
        Me.txtEmailid.Location = New System.Drawing.Point(337, 493)
        Me.txtEmailid.Name = "txtEmailid"
        Me.txtEmailid.Size = New System.Drawing.Size(247, 24)
        Me.txtEmailid.TabIndex = 10
        '
        'lblStdEmailId
        '
        Me.lblStdEmailId.AutoSize = True
        Me.lblStdEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdEmailId.ForeColor = System.Drawing.Color.Black
        Me.lblStdEmailId.Location = New System.Drawing.Point(197, 496)
        Me.lblStdEmailId.Name = "lblStdEmailId"
        Me.lblStdEmailId.Size = New System.Drawing.Size(77, 18)
        Me.lblStdEmailId.TabIndex = 13
        Me.lblStdEmailId.Text = "EMAIL ID"
        '
        'txtMobileno
        '
        Me.txtMobileno.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileno.ForeColor = System.Drawing.Color.Black
        Me.txtMobileno.Location = New System.Drawing.Point(337, 405)
        Me.txtMobileno.Name = "txtMobileno"
        Me.txtMobileno.Size = New System.Drawing.Size(247, 24)
        Me.txtMobileno.TabIndex = 7
        '
        'lblmobileno
        '
        Me.lblmobileno.AutoSize = True
        Me.lblmobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobileno.ForeColor = System.Drawing.Color.Black
        Me.lblmobileno.Location = New System.Drawing.Point(127, 408)
        Me.lblmobileno.Name = "lblmobileno"
        Me.lblmobileno.Size = New System.Drawing.Size(147, 18)
        Me.lblmobileno.TabIndex = 11
        Me.lblmobileno.Text = "MOBILE NUMBER"
        '
        'txtpincode
        '
        Me.txtpincode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpincode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpincode.ForeColor = System.Drawing.Color.Black
        Me.txtpincode.Location = New System.Drawing.Point(337, 358)
        Me.txtpincode.Name = "txtpincode"
        Me.txtpincode.Size = New System.Drawing.Size(247, 24)
        Me.txtpincode.TabIndex = 6
        '
        'lblpincode
        '
        Me.lblpincode.AutoSize = True
        Me.lblpincode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpincode.ForeColor = System.Drawing.Color.Black
        Me.lblpincode.Location = New System.Drawing.Point(187, 361)
        Me.lblpincode.Name = "lblpincode"
        Me.lblpincode.Size = New System.Drawing.Size(83, 18)
        Me.lblpincode.TabIndex = 9
        Me.lblpincode.Text = "PINCODE"
        '
        'txtcity
        '
        Me.txtcity.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.ForeColor = System.Drawing.Color.Black
        Me.txtcity.Location = New System.Drawing.Point(337, 312)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(247, 24)
        Me.txtcity.TabIndex = 5
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcity.ForeColor = System.Drawing.Color.Black
        Me.lblcity.Location = New System.Drawing.Point(207, 315)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(44, 18)
        Me.lblcity.TabIndex = 7
        Me.lblcity.Text = "CITY"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.Location = New System.Drawing.Point(337, 215)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(247, 79)
        Me.txtaddress.TabIndex = 4
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(187, 218)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(87, 18)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "ADDRESS"
        '
        'Add_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1368, 777)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_Customer"
        Me.Text = "Add_Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxDept As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents btnBACK As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents txtEmailid As System.Windows.Forms.TextBox
    Friend WithEvents lblStdEmailId As System.Windows.Forms.Label
    Friend WithEvents txtMobileno As System.Windows.Forms.TextBox
    Friend WithEvents lblmobileno As System.Windows.Forms.Label
    Friend WithEvents txtpincode As System.Windows.Forms.TextBox
    Friend WithEvents lblpincode As System.Windows.Forms.Label
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtRegisterID As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterID As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents RdbtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RdbtnMale As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblJoinDate As System.Windows.Forms.Label
End Class
