<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Return_Book
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
        Me.GrpBoxControl = New System.Windows.Forms.GroupBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.GrpBoxIssueDetail = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerDueDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.txtRegisterID = New System.Windows.Forms.TextBox()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.cmbBoxName = New System.Windows.Forms.ComboBox()
        Me.lblReturnDate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRegisterID = New System.Windows.Forms.Label()
        Me.GrpBoxBookDetail = New System.Windows.Forms.GroupBox()
        Me.txtAvailableBook = New System.Windows.Forms.TextBox()
        Me.lblAvailableBook = New System.Windows.Forms.Label()
        Me.DateTimePickerIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtBookId = New System.Windows.Forms.TextBox()
        Me.cmbBoxBookName = New System.Windows.Forms.ComboBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblissueDate = New System.Windows.Forms.Label()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.DataGridViewReturnBook = New System.Windows.Forms.DataGridView()
        Me.GrpBoxControl.SuspendLayout()
        Me.GrpBoxIssueDetail.SuspendLayout()
        Me.GrpBoxBookDetail.SuspendLayout()
        CType(Me.DataGridViewReturnBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpBoxControl
        '
        Me.GrpBoxControl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpBoxControl.BackColor = System.Drawing.Color.Transparent
        Me.GrpBoxControl.Controls.Add(Me.BtnBack)
        Me.GrpBoxControl.Controls.Add(Me.btnReset)
        Me.GrpBoxControl.Controls.Add(Me.btnReturn)
        Me.GrpBoxControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxControl.ForeColor = System.Drawing.Color.Black
        Me.GrpBoxControl.Location = New System.Drawing.Point(190, 608)
        Me.GrpBoxControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrpBoxControl.Name = "GrpBoxControl"
        Me.GrpBoxControl.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrpBoxControl.Size = New System.Drawing.Size(1030, 134)
        Me.GrpBoxControl.TabIndex = 18
        Me.GrpBoxControl.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.Black
        Me.BtnBack.Location = New System.Drawing.Point(720, 37)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(160, 70)
        Me.BtnBack.TabIndex = 11
        Me.BtnBack.Text = "BACK"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(445, 37)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 70)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.Black
        Me.btnReturn.Location = New System.Drawing.Point(187, 37)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(160, 70)
        Me.btnReturn.TabIndex = 9
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'GrpBoxIssueDetail
        '
        Me.GrpBoxIssueDetail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpBoxIssueDetail.BackColor = System.Drawing.Color.Transparent
        Me.GrpBoxIssueDetail.Controls.Add(Me.DateTimePickerDueDate)
        Me.GrpBoxIssueDetail.Controls.Add(Me.DateTimePickerReturnDate)
        Me.GrpBoxIssueDetail.Controls.Add(Me.txtRegisterID)
        Me.GrpBoxIssueDetail.Controls.Add(Me.lblDueDate)
        Me.GrpBoxIssueDetail.Controls.Add(Me.cmbBoxName)
        Me.GrpBoxIssueDetail.Controls.Add(Me.lblReturnDate)
        Me.GrpBoxIssueDetail.Controls.Add(Me.lblName)
        Me.GrpBoxIssueDetail.Controls.Add(Me.lblRegisterID)
        Me.GrpBoxIssueDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxIssueDetail.ForeColor = System.Drawing.Color.Black
        Me.GrpBoxIssueDetail.Location = New System.Drawing.Point(190, 260)
        Me.GrpBoxIssueDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrpBoxIssueDetail.Name = "GrpBoxIssueDetail"
        Me.GrpBoxIssueDetail.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrpBoxIssueDetail.Size = New System.Drawing.Size(1030, 182)
        Me.GrpBoxIssueDetail.TabIndex = 17
        Me.GrpBoxIssueDetail.TabStop = False
        Me.GrpBoxIssueDetail.Text = "ISSUE DETAIL"
        '
        'DateTimePickerDueDate
        '
        Me.DateTimePickerDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDueDate.Location = New System.Drawing.Point(759, 36)
        Me.DateTimePickerDueDate.Name = "DateTimePickerDueDate"
        Me.DateTimePickerDueDate.Size = New System.Drawing.Size(247, 26)
        Me.DateTimePickerDueDate.TabIndex = 18
        '
        'DateTimePickerReturnDate
        '
        Me.DateTimePickerReturnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerReturnDate.Location = New System.Drawing.Point(759, 99)
        Me.DateTimePickerReturnDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePickerReturnDate.Name = "DateTimePickerReturnDate"
        Me.DateTimePickerReturnDate.Size = New System.Drawing.Size(247, 26)
        Me.DateTimePickerReturnDate.TabIndex = 8
        '
        'txtRegisterID
        '
        Me.txtRegisterID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRegisterID.Enabled = False
        Me.txtRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterID.Location = New System.Drawing.Point(300, 49)
        Me.txtRegisterID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRegisterID.Name = "txtRegisterID"
        Me.txtRegisterID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRegisterID.Size = New System.Drawing.Size(247, 26)
        Me.txtRegisterID.TabIndex = 7
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(600, 49)
        Me.lblDueDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(99, 20)
        Me.lblDueDate.TabIndex = 3
        Me.lblDueDate.Text = "DUE DATE"
        '
        'cmbBoxName
        '
        Me.cmbBoxName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxName.Enabled = False
        Me.cmbBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxName.FormattingEnabled = True
        Me.cmbBoxName.Location = New System.Drawing.Point(300, 104)
        Me.cmbBoxName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbBoxName.Name = "cmbBoxName"
        Me.cmbBoxName.Size = New System.Drawing.Size(247, 28)
        Me.cmbBoxName.TabIndex = 5
        '
        'lblReturnDate
        '
        Me.lblReturnDate.AutoSize = True
        Me.lblReturnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnDate.Location = New System.Drawing.Point(587, 105)
        Me.lblReturnDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReturnDate.Name = "lblReturnDate"
        Me.lblReturnDate.Size = New System.Drawing.Size(134, 20)
        Me.lblReturnDate.TabIndex = 17
        Me.lblReturnDate.Text = "RETURN DATE"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(156, 107)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "NAME"
        '
        'lblRegisterID
        '
        Me.lblRegisterID.AutoSize = True
        Me.lblRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterID.Location = New System.Drawing.Point(96, 52)
        Me.lblRegisterID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegisterID.Name = "lblRegisterID"
        Me.lblRegisterID.Size = New System.Drawing.Size(179, 20)
        Me.lblRegisterID.TabIndex = 16
        Me.lblRegisterID.Text = "REGISTRARTION ID"
        '
        'GrpBoxBookDetail
        '
        Me.GrpBoxBookDetail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpBoxBookDetail.BackColor = System.Drawing.Color.Transparent
        Me.GrpBoxBookDetail.Controls.Add(Me.txtAvailableBook)
        Me.GrpBoxBookDetail.Controls.Add(Me.lblAvailableBook)
        Me.GrpBoxBookDetail.Controls.Add(Me.DateTimePickerIssueDate)
        Me.GrpBoxBookDetail.Controls.Add(Me.txtDescription)
        Me.GrpBoxBookDetail.Controls.Add(Me.txtBookId)
        Me.GrpBoxBookDetail.Controls.Add(Me.cmbBoxBookName)
        Me.GrpBoxBookDetail.Controls.Add(Me.lblDescription)
        Me.GrpBoxBookDetail.Controls.Add(Me.lblissueDate)
        Me.GrpBoxBookDetail.Controls.Add(Me.lblBookName)
        Me.GrpBoxBookDetail.Controls.Add(Me.lblBookID)
        Me.GrpBoxBookDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxBookDetail.ForeColor = System.Drawing.Color.Black
        Me.GrpBoxBookDetail.Location = New System.Drawing.Point(190, 33)
        Me.GrpBoxBookDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrpBoxBookDetail.Name = "GrpBoxBookDetail"
        Me.GrpBoxBookDetail.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrpBoxBookDetail.Size = New System.Drawing.Size(1030, 228)
        Me.GrpBoxBookDetail.TabIndex = 16
        Me.GrpBoxBookDetail.TabStop = False
        Me.GrpBoxBookDetail.Text = "BOOKS DETAIL"
        '
        'txtAvailableBook
        '
        Me.txtAvailableBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAvailableBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableBook.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableBook.Location = New System.Drawing.Point(757, 164)
        Me.txtAvailableBook.Name = "txtAvailableBook"
        Me.txtAvailableBook.ReadOnly = True
        Me.txtAvailableBook.Size = New System.Drawing.Size(247, 26)
        Me.txtAvailableBook.TabIndex = 13
        '
        'lblAvailableBook
        '
        Me.lblAvailableBook.AutoSize = True
        Me.lblAvailableBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableBook.ForeColor = System.Drawing.Color.Black
        Me.lblAvailableBook.Location = New System.Drawing.Point(558, 164)
        Me.lblAvailableBook.Name = "lblAvailableBook"
        Me.lblAvailableBook.Size = New System.Drawing.Size(173, 20)
        Me.lblAvailableBook.TabIndex = 12
        Me.lblAvailableBook.Text = "AVAILABLE BOOKS"
        '
        'DateTimePickerIssueDate
        '
        Me.DateTimePickerIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerIssueDate.Location = New System.Drawing.Point(276, 159)
        Me.DateTimePickerIssueDate.Name = "DateTimePickerIssueDate"
        Me.DateTimePickerIssueDate.Size = New System.Drawing.Size(247, 26)
        Me.DateTimePickerIssueDate.TabIndex = 5
        Me.DateTimePickerIssueDate.Value = New Date(2023, 2, 1, 0, 0, 0, 0)
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(757, 41)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(247, 101)
        Me.txtDescription.TabIndex = 4
        Me.txtDescription.Text = "Return Book"
        '
        'txtBookId
        '
        Me.txtBookId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBookId.Enabled = False
        Me.txtBookId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookId.Location = New System.Drawing.Point(276, 44)
        Me.txtBookId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBookId.Name = "txtBookId"
        Me.txtBookId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBookId.Size = New System.Drawing.Size(247, 26)
        Me.txtBookId.TabIndex = 2
        '
        'cmbBoxBookName
        '
        Me.cmbBoxBookName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxBookName.FormattingEnabled = True
        Me.cmbBoxBookName.Location = New System.Drawing.Point(276, 100)
        Me.cmbBoxBookName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbBoxBookName.Name = "cmbBoxBookName"
        Me.cmbBoxBookName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbBoxBookName.Size = New System.Drawing.Size(247, 28)
        Me.cmbBoxBookName.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(592, 47)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(129, 20)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "DESCRIPTION"
        '
        'lblissueDate
        '
        Me.lblissueDate.AutoSize = True
        Me.lblissueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblissueDate.Location = New System.Drawing.Point(119, 164)
        Me.lblissueDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblissueDate.Name = "lblissueDate"
        Me.lblissueDate.Size = New System.Drawing.Size(116, 20)
        Me.lblissueDate.TabIndex = 3
        Me.lblissueDate.Text = "ISSUE DATE"
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookName.Location = New System.Drawing.Point(122, 108)
        Me.lblBookName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(113, 20)
        Me.lblBookName.TabIndex = 2
        Me.lblBookName.Text = "BOOK NAME"
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.Location = New System.Drawing.Point(133, 50)
        Me.lblBookID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(82, 20)
        Me.lblBookID.TabIndex = 0
        Me.lblBookID.Text = "BOOK ID"
        '
        'DataGridViewReturnBook
        '
        Me.DataGridViewReturnBook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridViewReturnBook.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReturnBook.Location = New System.Drawing.Point(190, 450)
        Me.DataGridViewReturnBook.Name = "DataGridViewReturnBook"
        Me.DataGridViewReturnBook.Size = New System.Drawing.Size(1030, 150)
        Me.DataGridViewReturnBook.TabIndex = 19
        '
        'Return_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1368, 777)
        Me.Controls.Add(Me.DataGridViewReturnBook)
        Me.Controls.Add(Me.GrpBoxControl)
        Me.Controls.Add(Me.GrpBoxIssueDetail)
        Me.Controls.Add(Me.GrpBoxBookDetail)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Return_Book"
        Me.Text = "Return_Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxControl.ResumeLayout(False)
        Me.GrpBoxIssueDetail.ResumeLayout(False)
        Me.GrpBoxIssueDetail.PerformLayout()
        Me.GrpBoxBookDetail.ResumeLayout(False)
        Me.GrpBoxBookDetail.PerformLayout()
        CType(Me.DataGridViewReturnBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBoxControl As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents GrpBoxIssueDetail As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRegisterID As System.Windows.Forms.TextBox
    Friend WithEvents cmbBoxName As System.Windows.Forms.ComboBox
    Friend WithEvents lblReturnDate As System.Windows.Forms.Label
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblRegisterID As System.Windows.Forms.Label
    Friend WithEvents GrpBoxBookDetail As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtBookId As System.Windows.Forms.TextBox
    Friend WithEvents cmbBoxBookName As System.Windows.Forms.ComboBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblissueDate As System.Windows.Forms.Label
    Friend WithEvents lblBookName As System.Windows.Forms.Label
    Friend WithEvents lblBookID As System.Windows.Forms.Label
    Friend WithEvents DataGridViewReturnBook As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePickerIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAvailableBook As System.Windows.Forms.TextBox
    Friend WithEvents lblAvailableBook As System.Windows.Forms.Label
End Class
