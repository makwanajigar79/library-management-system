<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Issue_Book
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
        Me.GroupBoxControl = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.GrpBoxIssueDetail = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerDueDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtRegisterID = New System.Windows.Forms.TextBox()
        Me.cmbBoxName = New System.Windows.Forms.ComboBox()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblissueDate = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblRegisterID = New System.Windows.Forms.Label()
        Me.GrpBoxBookDetails = New System.Windows.Forms.GroupBox()
        Me.txtAvailableBook = New System.Windows.Forms.TextBox()
        Me.lblAvailableBook = New System.Windows.Forms.Label()
        Me.cmbBoxTransactionType = New System.Windows.Forms.ComboBox()
        Me.lblTransactionType = New System.Windows.Forms.Label()
        Me.cmbBoxBookCopies = New System.Windows.Forms.ComboBox()
        Me.cmbBoxPublishYear = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtEdition = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtBookId = New System.Windows.Forms.TextBox()
        Me.cmbBoxBookName = New System.Windows.Forms.ComboBox()
        Me.lblBookCopies = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblEdition = New System.Windows.Forms.Label()
        Me.lblPublishingYear = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.DataGridViewIssueBook = New System.Windows.Forms.DataGridView()
        Me.GroupBoxControl.SuspendLayout()
        Me.GrpBoxIssueDetail.SuspendLayout()
        Me.GrpBoxBookDetails.SuspendLayout()
        CType(Me.DataGridViewIssueBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxControl
        '
        Me.GroupBoxControl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxControl.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxControl.Controls.Add(Me.btnBack)
        Me.GroupBoxControl.Controls.Add(Me.btnReset)
        Me.GroupBoxControl.Controls.Add(Me.btnIssue)
        Me.GroupBoxControl.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxControl.Location = New System.Drawing.Point(175, 648)
        Me.GroupBoxControl.Name = "GroupBoxControl"
        Me.GroupBoxControl.Size = New System.Drawing.Size(1030, 117)
        Me.GroupBoxControl.TabIndex = 17
        Me.GroupBoxControl.TabStop = False
        Me.GroupBoxControl.Text = "CONTROL"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(749, 29)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(160, 70)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(415, 29)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 70)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnIssue
        '
        Me.btnIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.ForeColor = System.Drawing.Color.Black
        Me.btnIssue.Location = New System.Drawing.Point(88, 29)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(160, 70)
        Me.btnIssue.TabIndex = 1
        Me.btnIssue.Text = "ISSUE"
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'GrpBoxIssueDetail
        '
        Me.GrpBoxIssueDetail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpBoxIssueDetail.BackColor = System.Drawing.Color.Transparent
        Me.GrpBoxIssueDetail.Controls.Add(Me.DateTimePickerDueDate)
        Me.GrpBoxIssueDetail.Controls.Add(Me.DateTimePickerIssueDate)
        Me.GrpBoxIssueDetail.Controls.Add(Me.txtRegisterID)
        Me.GrpBoxIssueDetail.Controls.Add(Me.cmbBoxName)
        Me.GrpBoxIssueDetail.Controls.Add(Me.lblDueDate)
        Me.GrpBoxIssueDetail.Controls.Add(Me.lblissueDate)
        Me.GrpBoxIssueDetail.Controls.Add(Me.lblFName)
        Me.GrpBoxIssueDetail.Controls.Add(Me.lblRegisterID)
        Me.GrpBoxIssueDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxIssueDetail.ForeColor = System.Drawing.Color.Black
        Me.GrpBoxIssueDetail.Location = New System.Drawing.Point(175, 283)
        Me.GrpBoxIssueDetail.Name = "GrpBoxIssueDetail"
        Me.GrpBoxIssueDetail.Size = New System.Drawing.Size(1030, 144)
        Me.GrpBoxIssueDetail.TabIndex = 16
        Me.GrpBoxIssueDetail.TabStop = False
        Me.GrpBoxIssueDetail.Text = "Issue details"
        '
        'DateTimePickerDueDate
        '
        Me.DateTimePickerDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDueDate.Location = New System.Drawing.Point(780, 91)
        Me.DateTimePickerDueDate.Name = "DateTimePickerDueDate"
        Me.DateTimePickerDueDate.Size = New System.Drawing.Size(247, 26)
        Me.DateTimePickerDueDate.TabIndex = 21
        '
        'DateTimePickerIssueDate
        '
        Me.DateTimePickerIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerIssueDate.Location = New System.Drawing.Point(780, 35)
        Me.DateTimePickerIssueDate.Name = "DateTimePickerIssueDate"
        Me.DateTimePickerIssueDate.Size = New System.Drawing.Size(247, 26)
        Me.DateTimePickerIssueDate.TabIndex = 20
        '
        'txtRegisterID
        '
        Me.txtRegisterID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterID.Location = New System.Drawing.Point(240, 36)
        Me.txtRegisterID.Name = "txtRegisterID"
        Me.txtRegisterID.ReadOnly = True
        Me.txtRegisterID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRegisterID.Size = New System.Drawing.Size(247, 26)
        Me.txtRegisterID.TabIndex = 19
        '
        'cmbBoxName
        '
        Me.cmbBoxName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxName.Location = New System.Drawing.Point(240, 92)
        Me.cmbBoxName.Name = "cmbBoxName"
        Me.cmbBoxName.Size = New System.Drawing.Size(247, 28)
        Me.cmbBoxName.TabIndex = 18
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(617, 91)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(99, 20)
        Me.lblDueDate.TabIndex = 17
        Me.lblDueDate.Text = "DUE DATE"
        '
        'lblissueDate
        '
        Me.lblissueDate.AutoSize = True
        Me.lblissueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblissueDate.Location = New System.Drawing.Point(591, 40)
        Me.lblissueDate.Name = "lblissueDate"
        Me.lblissueDate.Size = New System.Drawing.Size(136, 20)
        Me.lblissueDate.TabIndex = 3
        Me.lblissueDate.Text = "ISSUING DATE"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(97, 96)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(116, 20)
        Me.lblFName.TabIndex = 3
        Me.lblFName.Text = "FIRST NAME"
        '
        'lblRegisterID
        '
        Me.lblRegisterID.AutoSize = True
        Me.lblRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterID.Location = New System.Drawing.Point(42, 41)
        Me.lblRegisterID.Name = "lblRegisterID"
        Me.lblRegisterID.Size = New System.Drawing.Size(171, 20)
        Me.lblRegisterID.TabIndex = 16
        Me.lblRegisterID.Text = "REGISTRATION ID "
        '
        'GrpBoxBookDetails
        '
        Me.GrpBoxBookDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpBoxBookDetails.BackColor = System.Drawing.Color.Transparent
        Me.GrpBoxBookDetails.Controls.Add(Me.txtAvailableBook)
        Me.GrpBoxBookDetails.Controls.Add(Me.lblAvailableBook)
        Me.GrpBoxBookDetails.Controls.Add(Me.cmbBoxTransactionType)
        Me.GrpBoxBookDetails.Controls.Add(Me.lblTransactionType)
        Me.GrpBoxBookDetails.Controls.Add(Me.cmbBoxBookCopies)
        Me.GrpBoxBookDetails.Controls.Add(Me.cmbBoxPublishYear)
        Me.GrpBoxBookDetails.Controls.Add(Me.txtPrice)
        Me.GrpBoxBookDetails.Controls.Add(Me.txtEdition)
        Me.GrpBoxBookDetails.Controls.Add(Me.txtAuthor)
        Me.GrpBoxBookDetails.Controls.Add(Me.txtPublisher)
        Me.GrpBoxBookDetails.Controls.Add(Me.txtBookId)
        Me.GrpBoxBookDetails.Controls.Add(Me.cmbBoxBookName)
        Me.GrpBoxBookDetails.Controls.Add(Me.lblBookCopies)
        Me.GrpBoxBookDetails.Controls.Add(Me.lblPrice)
        Me.GrpBoxBookDetails.Controls.Add(Me.lblEdition)
        Me.GrpBoxBookDetails.Controls.Add(Me.lblPublishingYear)
        Me.GrpBoxBookDetails.Controls.Add(Me.lblAuthor)
        Me.GrpBoxBookDetails.Controls.Add(Me.lblPublisher)
        Me.GrpBoxBookDetails.Controls.Add(Me.lblBookName)
        Me.GrpBoxBookDetails.Controls.Add(Me.lblBookID)
        Me.GrpBoxBookDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxBookDetails.ForeColor = System.Drawing.Color.Black
        Me.GrpBoxBookDetails.Location = New System.Drawing.Point(175, 26)
        Me.GrpBoxBookDetails.Name = "GrpBoxBookDetails"
        Me.GrpBoxBookDetails.Size = New System.Drawing.Size(1030, 251)
        Me.GrpBoxBookDetails.TabIndex = 15
        Me.GrpBoxBookDetails.TabStop = False
        Me.GrpBoxBookDetails.Text = "BOOKS DETAIL"
        '
        'txtAvailableBook
        '
        Me.txtAvailableBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAvailableBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableBook.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableBook.Location = New System.Drawing.Point(749, 205)
        Me.txtAvailableBook.Name = "txtAvailableBook"
        Me.txtAvailableBook.ReadOnly = True
        Me.txtAvailableBook.Size = New System.Drawing.Size(247, 26)
        Me.txtAvailableBook.TabIndex = 18
        '
        'lblAvailableBook
        '
        Me.lblAvailableBook.AutoSize = True
        Me.lblAvailableBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableBook.ForeColor = System.Drawing.Color.Black
        Me.lblAvailableBook.Location = New System.Drawing.Point(570, 208)
        Me.lblAvailableBook.Name = "lblAvailableBook"
        Me.lblAvailableBook.Size = New System.Drawing.Size(173, 20)
        Me.lblAvailableBook.TabIndex = 17
        Me.lblAvailableBook.Text = "AVAILABLE BOOKS"
        '
        'cmbBoxTransactionType
        '
        Me.cmbBoxTransactionType.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxTransactionType.Enabled = False
        Me.cmbBoxTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxTransactionType.FormattingEnabled = True
        Me.cmbBoxTransactionType.Items.AddRange(New Object() {"issue", ""})
        Me.cmbBoxTransactionType.Location = New System.Drawing.Point(749, 168)
        Me.cmbBoxTransactionType.Name = "cmbBoxTransactionType"
        Me.cmbBoxTransactionType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbBoxTransactionType.Size = New System.Drawing.Size(247, 28)
        Me.cmbBoxTransactionType.TabIndex = 16
        Me.cmbBoxTransactionType.Text = "Issue Book"
        Me.cmbBoxTransactionType.Visible = False
        '
        'lblTransactionType
        '
        Me.lblTransactionType.AutoSize = True
        Me.lblTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionType.Location = New System.Drawing.Point(537, 170)
        Me.lblTransactionType.Name = "lblTransactionType"
        Me.lblTransactionType.Size = New System.Drawing.Size(183, 20)
        Me.lblTransactionType.TabIndex = 15
        Me.lblTransactionType.Text = "TRANSACTION TYPE"
        Me.lblTransactionType.Visible = False
        '
        'cmbBoxBookCopies
        '
        Me.cmbBoxBookCopies.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxBookCopies.Enabled = False
        Me.cmbBoxBookCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxBookCopies.FormattingEnabled = True
        Me.cmbBoxBookCopies.Location = New System.Drawing.Point(749, 126)
        Me.cmbBoxBookCopies.Name = "cmbBoxBookCopies"
        Me.cmbBoxBookCopies.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbBoxBookCopies.Size = New System.Drawing.Size(247, 28)
        Me.cmbBoxBookCopies.TabIndex = 14
        '
        'cmbBoxPublishYear
        '
        Me.cmbBoxPublishYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxPublishYear.Enabled = False
        Me.cmbBoxPublishYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxPublishYear.FormattingEnabled = True
        Me.cmbBoxPublishYear.Items.AddRange(New Object() {"Available", "Rented"})
        Me.cmbBoxPublishYear.Location = New System.Drawing.Point(209, 203)
        Me.cmbBoxPublishYear.Name = "cmbBoxPublishYear"
        Me.cmbBoxPublishYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbBoxPublishYear.Size = New System.Drawing.Size(247, 28)
        Me.cmbBoxPublishYear.TabIndex = 11
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(749, 80)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrice.Size = New System.Drawing.Size(247, 26)
        Me.txtPrice.TabIndex = 13
        '
        'txtEdition
        '
        Me.txtEdition.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEdition.Enabled = False
        Me.txtEdition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdition.Location = New System.Drawing.Point(749, 36)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.ReadOnly = True
        Me.txtEdition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEdition.Size = New System.Drawing.Size(247, 26)
        Me.txtEdition.TabIndex = 12
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAuthor.Enabled = False
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(209, 162)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.ReadOnly = True
        Me.txtAuthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAuthor.Size = New System.Drawing.Size(247, 26)
        Me.txtAuthor.TabIndex = 10
        '
        'txtPublisher
        '
        Me.txtPublisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPublisher.Enabled = False
        Me.txtPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.Location = New System.Drawing.Point(209, 118)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.ReadOnly = True
        Me.txtPublisher.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPublisher.Size = New System.Drawing.Size(247, 26)
        Me.txtPublisher.TabIndex = 9
        '
        'txtBookId
        '
        Me.txtBookId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBookId.Enabled = False
        Me.txtBookId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookId.Location = New System.Drawing.Point(209, 28)
        Me.txtBookId.Name = "txtBookId"
        Me.txtBookId.ReadOnly = True
        Me.txtBookId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBookId.Size = New System.Drawing.Size(247, 26)
        Me.txtBookId.TabIndex = 8
        '
        'cmbBoxBookName
        '
        Me.cmbBoxBookName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxBookName.FormattingEnabled = True
        Me.cmbBoxBookName.Location = New System.Drawing.Point(209, 72)
        Me.cmbBoxBookName.Name = "cmbBoxBookName"
        Me.cmbBoxBookName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbBoxBookName.Size = New System.Drawing.Size(247, 28)
        Me.cmbBoxBookName.TabIndex = 6
        '
        'lblBookCopies
        '
        Me.lblBookCopies.AutoSize = True
        Me.lblBookCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookCopies.Location = New System.Drawing.Point(581, 128)
        Me.lblBookCopies.Name = "lblBookCopies"
        Me.lblBookCopies.Size = New System.Drawing.Size(129, 20)
        Me.lblBookCopies.TabIndex = 2
        Me.lblBookCopies.Text = "BOOK COPIES"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(629, 80)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(63, 20)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "PRICE"
        '
        'lblEdition
        '
        Me.lblEdition.AutoSize = True
        Me.lblEdition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdition.Location = New System.Drawing.Point(611, 36)
        Me.lblEdition.Name = "lblEdition"
        Me.lblEdition.Size = New System.Drawing.Size(81, 20)
        Me.lblEdition.TabIndex = 2
        Me.lblEdition.Text = "EDITION"
        '
        'lblPublishingYear
        '
        Me.lblPublishingYear.AutoSize = True
        Me.lblPublishingYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublishingYear.Location = New System.Drawing.Point(9, 203)
        Me.lblPublishingYear.Name = "lblPublishingYear"
        Me.lblPublishingYear.Size = New System.Drawing.Size(172, 20)
        Me.lblPublishingYear.TabIndex = 5
        Me.lblPublishingYear.Text = "PUBLISHING YEAR"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(84, 165)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(83, 20)
        Me.lblAuthor.TabIndex = 4
        Me.lblAuthor.Text = "AUTHOR"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisher.Location = New System.Drawing.Point(70, 121)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(111, 20)
        Me.lblPublisher.TabIndex = 3
        Me.lblPublisher.Text = "PUBLISHER"
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookName.Location = New System.Drawing.Point(63, 72)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(113, 20)
        Me.lblBookName.TabIndex = 2
        Me.lblBookName.Text = "BOOK NAME"
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.Location = New System.Drawing.Point(94, 31)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(82, 20)
        Me.lblBookID.TabIndex = 0
        Me.lblBookID.Text = "BOOK ID"
        '
        'DataGridViewIssueBook
        '
        Me.DataGridViewIssueBook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridViewIssueBook.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewIssueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIssueBook.Location = New System.Drawing.Point(175, 442)
        Me.DataGridViewIssueBook.Name = "DataGridViewIssueBook"
        Me.DataGridViewIssueBook.Size = New System.Drawing.Size(1030, 186)
        Me.DataGridViewIssueBook.TabIndex = 18
        '
        'Issue_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1368, 777)
        Me.Controls.Add(Me.DataGridViewIssueBook)
        Me.Controls.Add(Me.GroupBoxControl)
        Me.Controls.Add(Me.GrpBoxIssueDetail)
        Me.Controls.Add(Me.GrpBoxBookDetails)
        Me.Name = "Issue_Book"
        Me.Text = "Issue_Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxControl.ResumeLayout(False)
        Me.GrpBoxIssueDetail.ResumeLayout(False)
        Me.GrpBoxIssueDetail.PerformLayout()
        Me.GrpBoxBookDetails.ResumeLayout(False)
        Me.GrpBoxBookDetails.PerformLayout()
        CType(Me.DataGridViewIssueBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxControl As System.Windows.Forms.GroupBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents GrpBoxIssueDetail As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRegisterID As System.Windows.Forms.TextBox
    Friend WithEvents cmbBoxName As System.Windows.Forms.ComboBox
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents lblissueDate As System.Windows.Forms.Label
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblRegisterID As System.Windows.Forms.Label
    Friend WithEvents GrpBoxBookDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBoxBookCopies As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBoxPublishYear As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtEdition As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents txtBookId As System.Windows.Forms.TextBox
    Friend WithEvents cmbBoxBookName As System.Windows.Forms.ComboBox
    Friend WithEvents lblBookCopies As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblEdition As System.Windows.Forms.Label
    Friend WithEvents lblPublishingYear As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblPublisher As System.Windows.Forms.Label
    Friend WithEvents lblBookName As System.Windows.Forms.Label
    Friend WithEvents lblBookID As System.Windows.Forms.Label
    Friend WithEvents DataGridViewIssueBook As System.Windows.Forms.DataGridView
    Friend WithEvents cmbBoxTransactionType As System.Windows.Forms.ComboBox
    Friend WithEvents lblTransactionType As System.Windows.Forms.Label
    Friend WithEvents txtAvailableBook As System.Windows.Forms.TextBox
    Friend WithEvents lblAvailableBook As System.Windows.Forms.Label
End Class
