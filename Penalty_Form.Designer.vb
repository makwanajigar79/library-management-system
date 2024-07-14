<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penalty_Form
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.DataGridViewPenaltyForm = New System.Windows.Forms.DataGridView()
        Me.cmbBoxPenaltyStatus = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerPanaltydate = New System.Windows.Forms.DateTimePicker()
        Me.LblPanaltyDate = New System.Windows.Forms.Label()
        Me.DateTimePickerIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRegisterID = New System.Windows.Forms.Label()
        Me.lblBookIdOP = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.btnBACK = New System.Windows.Forms.Button()
        Me.btnPayNow = New System.Windows.Forms.Button()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.txtPanaltyAmount = New System.Windows.Forms.TextBox()
        Me.lblPanaltyAmount = New System.Windows.Forms.Label()
        Me.lblPenaltyStatus = New System.Windows.Forms.Label()
        Me.lblIssueDate = New System.Windows.Forms.Label()
        Me.lblRegistrationIDOP = New System.Windows.Forms.Label()
        Me.lblNameOP = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBookAuthorOP = New System.Windows.Forms.Label()
        Me.lblBookAuthor = New System.Windows.Forms.Label()
        Me.lblBookNameOP = New System.Windows.Forms.Label()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.cmbBoxSelectBook = New System.Windows.Forms.ComboBox()
        Me.lblSelectBook = New System.Windows.Forms.Label()
        Me.cmbBoxSelectUser = New System.Windows.Forms.ComboBox()
        Me.lblSelectUser = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewPenaltyForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.DataGridViewPenaltyForm)
        Me.Panel1.Controls.Add(Me.cmbBoxPenaltyStatus)
        Me.Panel1.Controls.Add(Me.DateTimePickerPanaltydate)
        Me.Panel1.Controls.Add(Me.LblPanaltyDate)
        Me.Panel1.Controls.Add(Me.DateTimePickerIssueDate)
        Me.Panel1.Controls.Add(Me.lblRegisterID)
        Me.Panel1.Controls.Add(Me.lblBookIdOP)
        Me.Panel1.Controls.Add(Me.lblBookID)
        Me.Panel1.Controls.Add(Me.btnBACK)
        Me.Panel1.Controls.Add(Me.btnPayNow)
        Me.Panel1.Controls.Add(Me.txtReason)
        Me.Panel1.Controls.Add(Me.lblReason)
        Me.Panel1.Controls.Add(Me.txtPanaltyAmount)
        Me.Panel1.Controls.Add(Me.lblPanaltyAmount)
        Me.Panel1.Controls.Add(Me.lblPenaltyStatus)
        Me.Panel1.Controls.Add(Me.lblIssueDate)
        Me.Panel1.Controls.Add(Me.lblRegistrationIDOP)
        Me.Panel1.Controls.Add(Me.lblNameOP)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblBookAuthorOP)
        Me.Panel1.Controls.Add(Me.lblBookAuthor)
        Me.Panel1.Controls.Add(Me.lblBookNameOP)
        Me.Panel1.Controls.Add(Me.lblBookName)
        Me.Panel1.Controls.Add(Me.cmbBoxSelectBook)
        Me.Panel1.Controls.Add(Me.lblSelectBook)
        Me.Panel1.Controls.Add(Me.cmbBoxSelectUser)
        Me.Panel1.Controls.Add(Me.lblSelectUser)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(74, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 749)
        Me.Panel1.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(454, 661)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 70)
        Me.btnReset.TabIndex = 34
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'DataGridViewPenaltyForm
        '
        Me.DataGridViewPenaltyForm.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewPenaltyForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPenaltyForm.Location = New System.Drawing.Point(63, 466)
        Me.DataGridViewPenaltyForm.Name = "DataGridViewPenaltyForm"
        Me.DataGridViewPenaltyForm.Size = New System.Drawing.Size(964, 168)
        Me.DataGridViewPenaltyForm.TabIndex = 33
        '
        'cmbBoxPenaltyStatus
        '
        Me.cmbBoxPenaltyStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxPenaltyStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxPenaltyStatus.FormattingEnabled = True
        Me.cmbBoxPenaltyStatus.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbBoxPenaltyStatus.Location = New System.Drawing.Point(284, 298)
        Me.cmbBoxPenaltyStatus.Name = "cmbBoxPenaltyStatus"
        Me.cmbBoxPenaltyStatus.Size = New System.Drawing.Size(247, 26)
        Me.cmbBoxPenaltyStatus.TabIndex = 32
        Me.cmbBoxPenaltyStatus.Text = "NO"
        '
        'DateTimePickerPanaltydate
        '
        Me.DateTimePickerPanaltydate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerPanaltydate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPanaltydate.Location = New System.Drawing.Point(754, 336)
        Me.DateTimePickerPanaltydate.Name = "DateTimePickerPanaltydate"
        Me.DateTimePickerPanaltydate.Size = New System.Drawing.Size(247, 24)
        Me.DateTimePickerPanaltydate.TabIndex = 31
        '
        'LblPanaltyDate
        '
        Me.LblPanaltyDate.AutoSize = True
        Me.LblPanaltyDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPanaltyDate.Location = New System.Drawing.Point(603, 341)
        Me.LblPanaltyDate.Name = "LblPanaltyDate"
        Me.LblPanaltyDate.Size = New System.Drawing.Size(129, 18)
        Me.LblPanaltyDate.TabIndex = 30
        Me.LblPanaltyDate.Text = "PENALTY DATE"
        '
        'DateTimePickerIssueDate
        '
        Me.DateTimePickerIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerIssueDate.Location = New System.Drawing.Point(284, 258)
        Me.DateTimePickerIssueDate.Name = "DateTimePickerIssueDate"
        Me.DateTimePickerIssueDate.Size = New System.Drawing.Size(247, 24)
        Me.DateTimePickerIssueDate.TabIndex = 29
        '
        'lblRegisterID
        '
        Me.lblRegisterID.AutoSize = True
        Me.lblRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterID.ForeColor = System.Drawing.Color.Black
        Me.lblRegisterID.Location = New System.Drawing.Point(99, 185)
        Me.lblRegisterID.Name = "lblRegisterID"
        Me.lblRegisterID.Size = New System.Drawing.Size(151, 18)
        Me.lblRegisterID.TabIndex = 28
        Me.lblRegisterID.Text = "REGISTRATION ID"
        '
        'lblBookIdOP
        '
        Me.lblBookIdOP.AutoSize = True
        Me.lblBookIdOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookIdOP.ForeColor = System.Drawing.Color.Black
        Me.lblBookIdOP.Location = New System.Drawing.Point(291, 73)
        Me.lblBookIdOP.Name = "lblBookIdOP"
        Me.lblBookIdOP.Size = New System.Drawing.Size(32, 18)
        Me.lblBookIdOP.TabIndex = 27
        Me.lblBookIdOP.Text = "OP"
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.ForeColor = System.Drawing.Color.Black
        Me.lblBookID.Location = New System.Drawing.Point(164, 73)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(77, 18)
        Me.lblBookID.TabIndex = 26
        Me.lblBookID.Text = "BOOK ID"
        '
        'btnBACK
        '
        Me.btnBACK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBACK.ForeColor = System.Drawing.Color.Black
        Me.btnBACK.Location = New System.Drawing.Point(706, 661)
        Me.btnBACK.Name = "btnBACK"
        Me.btnBACK.Size = New System.Drawing.Size(160, 70)
        Me.btnBACK.TabIndex = 25
        Me.btnBACK.Text = "BACK"
        Me.btnBACK.UseVisualStyleBackColor = False
        '
        'btnPayNow
        '
        Me.btnPayNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayNow.ForeColor = System.Drawing.Color.Black
        Me.btnPayNow.Location = New System.Drawing.Point(201, 661)
        Me.btnPayNow.Name = "btnPayNow"
        Me.btnPayNow.Size = New System.Drawing.Size(160, 70)
        Me.btnPayNow.TabIndex = 24
        Me.btnPayNow.Text = "PAY NOW"
        Me.btnPayNow.UseVisualStyleBackColor = False
        '
        'txtReason
        '
        Me.txtReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.ForeColor = System.Drawing.Color.Black
        Me.txtReason.Location = New System.Drawing.Point(284, 378)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(247, 71)
        Me.txtReason.TabIndex = 23
        '
        'lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.ForeColor = System.Drawing.Color.Black
        Me.lblReason.Location = New System.Drawing.Point(170, 381)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(77, 18)
        Me.lblReason.TabIndex = 22
        Me.lblReason.Text = "REASON"
        '
        'txtPanaltyAmount
        '
        Me.txtPanaltyAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPanaltyAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanaltyAmount.ForeColor = System.Drawing.Color.Black
        Me.txtPanaltyAmount.Location = New System.Drawing.Point(284, 335)
        Me.txtPanaltyAmount.Name = "txtPanaltyAmount"
        Me.txtPanaltyAmount.Size = New System.Drawing.Size(247, 24)
        Me.txtPanaltyAmount.TabIndex = 21
        '
        'lblPanaltyAmount
        '
        Me.lblPanaltyAmount.AutoSize = True
        Me.lblPanaltyAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanaltyAmount.ForeColor = System.Drawing.Color.Black
        Me.lblPanaltyAmount.Location = New System.Drawing.Point(93, 335)
        Me.lblPanaltyAmount.Name = "lblPanaltyAmount"
        Me.lblPanaltyAmount.Size = New System.Drawing.Size(157, 18)
        Me.lblPanaltyAmount.TabIndex = 20
        Me.lblPanaltyAmount.Text = "PENALTY AMOUNT"
        '
        'lblPenaltyStatus
        '
        Me.lblPenaltyStatus.AutoSize = True
        Me.lblPenaltyStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenaltyStatus.ForeColor = System.Drawing.Color.Black
        Me.lblPenaltyStatus.Location = New System.Drawing.Point(100, 301)
        Me.lblPenaltyStatus.Name = "lblPenaltyStatus"
        Me.lblPenaltyStatus.Size = New System.Drawing.Size(150, 18)
        Me.lblPenaltyStatus.TabIndex = 18
        Me.lblPenaltyStatus.Text = "PENALTY STATUS"
        '
        'lblIssueDate
        '
        Me.lblIssueDate.AutoSize = True
        Me.lblIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueDate.ForeColor = System.Drawing.Color.Black
        Me.lblIssueDate.Location = New System.Drawing.Point(145, 266)
        Me.lblIssueDate.Name = "lblIssueDate"
        Me.lblIssueDate.Size = New System.Drawing.Size(105, 18)
        Me.lblIssueDate.TabIndex = 16
        Me.lblIssueDate.Text = "ISSUE DATE"
        '
        'lblRegistrationIDOP
        '
        Me.lblRegistrationIDOP.AutoSize = True
        Me.lblRegistrationIDOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationIDOP.ForeColor = System.Drawing.Color.Black
        Me.lblRegistrationIDOP.Location = New System.Drawing.Point(291, 185)
        Me.lblRegistrationIDOP.Name = "lblRegistrationIDOP"
        Me.lblRegistrationIDOP.Size = New System.Drawing.Size(32, 18)
        Me.lblRegistrationIDOP.TabIndex = 15
        Me.lblRegistrationIDOP.Text = "OP"
        '
        'lblNameOP
        '
        Me.lblNameOP.AutoSize = True
        Me.lblNameOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOP.ForeColor = System.Drawing.Color.Black
        Me.lblNameOP.Location = New System.Drawing.Point(291, 222)
        Me.lblNameOP.Name = "lblNameOP"
        Me.lblNameOP.Size = New System.Drawing.Size(32, 18)
        Me.lblNameOP.TabIndex = 13
        Me.lblNameOP.Text = "OP"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(192, 222)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 18)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "NAME"
        '
        'lblBookAuthorOP
        '
        Me.lblBookAuthorOP.AutoSize = True
        Me.lblBookAuthorOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookAuthorOP.ForeColor = System.Drawing.Color.Black
        Me.lblBookAuthorOP.Location = New System.Drawing.Point(291, 144)
        Me.lblBookAuthorOP.Name = "lblBookAuthorOP"
        Me.lblBookAuthorOP.Size = New System.Drawing.Size(32, 18)
        Me.lblBookAuthorOP.TabIndex = 9
        Me.lblBookAuthorOP.Text = "OP"
        '
        'lblBookAuthor
        '
        Me.lblBookAuthor.AutoSize = True
        Me.lblBookAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookAuthor.ForeColor = System.Drawing.Color.Black
        Me.lblBookAuthor.Location = New System.Drawing.Point(111, 144)
        Me.lblBookAuthor.Name = "lblBookAuthor"
        Me.lblBookAuthor.Size = New System.Drawing.Size(130, 18)
        Me.lblBookAuthor.TabIndex = 8
        Me.lblBookAuthor.Text = "BOOK AUTHOR"
        '
        'lblBookNameOP
        '
        Me.lblBookNameOP.AutoSize = True
        Me.lblBookNameOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookNameOP.ForeColor = System.Drawing.Color.Black
        Me.lblBookNameOP.Location = New System.Drawing.Point(291, 109)
        Me.lblBookNameOP.Name = "lblBookNameOP"
        Me.lblBookNameOP.Size = New System.Drawing.Size(32, 18)
        Me.lblBookNameOP.TabIndex = 7
        Me.lblBookNameOP.Text = "OP"
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookName.ForeColor = System.Drawing.Color.Black
        Me.lblBookName.Location = New System.Drawing.Point(133, 109)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(108, 18)
        Me.lblBookName.TabIndex = 6
        Me.lblBookName.Text = "BOOK NAME"
        '
        'cmbBoxSelectBook
        '
        Me.cmbBoxSelectBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxSelectBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBoxSelectBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxSelectBook.ForeColor = System.Drawing.Color.Black
        Me.cmbBoxSelectBook.FormattingEnabled = True
        Me.cmbBoxSelectBook.Location = New System.Drawing.Point(796, 18)
        Me.cmbBoxSelectBook.Name = "cmbBoxSelectBook"
        Me.cmbBoxSelectBook.Size = New System.Drawing.Size(247, 26)
        Me.cmbBoxSelectBook.TabIndex = 2
        '
        'lblSelectBook
        '
        Me.lblSelectBook.AutoSize = True
        Me.lblSelectBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSelectBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectBook.ForeColor = System.Drawing.Color.Black
        Me.lblSelectBook.Location = New System.Drawing.Point(649, 21)
        Me.lblSelectBook.Name = "lblSelectBook"
        Me.lblSelectBook.Size = New System.Drawing.Size(125, 18)
        Me.lblSelectBook.TabIndex = 2
        Me.lblSelectBook.Text = "SELECT BOOK"
        '
        'cmbBoxSelectUser
        '
        Me.cmbBoxSelectUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbBoxSelectUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxSelectUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxSelectUser.ForeColor = System.Drawing.Color.Black
        Me.cmbBoxSelectUser.FormattingEnabled = True
        Me.cmbBoxSelectUser.Location = New System.Drawing.Point(303, 21)
        Me.cmbBoxSelectUser.Name = "cmbBoxSelectUser"
        Me.cmbBoxSelectUser.Size = New System.Drawing.Size(247, 26)
        Me.cmbBoxSelectUser.TabIndex = 1
        '
        'lblSelectUser
        '
        Me.lblSelectUser.AutoSize = True
        Me.lblSelectUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectUser.ForeColor = System.Drawing.Color.Black
        Me.lblSelectUser.Location = New System.Drawing.Point(47, 24)
        Me.lblSelectUser.Name = "lblSelectUser"
        Me.lblSelectUser.Size = New System.Drawing.Size(241, 18)
        Me.lblSelectUser.TabIndex = 0
        Me.lblSelectUser.Text = "SELECT USER FOR PENALTY"
        '
        'Penalty_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1308, 777)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Penalty_Form"
        Me.Text = "Penalty_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewPenaltyForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSelectUser As System.Windows.Forms.Label
    Friend WithEvents cmbBoxSelectBook As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectBook As System.Windows.Forms.Label
    Friend WithEvents cmbBoxSelectUser As System.Windows.Forms.ComboBox
    Friend WithEvents lblBookNameOP As System.Windows.Forms.Label
    Friend WithEvents lblBookName As System.Windows.Forms.Label
    Friend WithEvents lblBookAuthorOP As System.Windows.Forms.Label
    Friend WithEvents lblBookAuthor As System.Windows.Forms.Label
    Friend WithEvents lblPenaltyStatus As System.Windows.Forms.Label
    Friend WithEvents lblIssueDate As System.Windows.Forms.Label
    Friend WithEvents lblRegistrationIDOP As System.Windows.Forms.Label
    Friend WithEvents lblNameOP As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPanaltyAmount As System.Windows.Forms.Label
    Friend WithEvents btnPayNow As System.Windows.Forms.Button
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents txtPanaltyAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnBACK As System.Windows.Forms.Button
    Friend WithEvents lblRegisterID As System.Windows.Forms.Label
    Friend WithEvents lblBookIdOP As System.Windows.Forms.Label
    Friend WithEvents lblBookID As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerPanaltydate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblPanaltyDate As System.Windows.Forms.Label
    Friend WithEvents cmbBoxPenaltyStatus As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewPenaltyForm As System.Windows.Forms.DataGridView
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
