<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBook
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpBoxBookDetail = New System.Windows.Forms.GroupBox()
        Me.txtAvailableBook = New System.Windows.Forms.TextBox()
        Me.lblAvailableBook = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDiscription = New System.Windows.Forms.Label()
        Me.cmbboxBookCopies = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtEdition = New System.Windows.Forms.TextBox()
        Me.cmbboxPublishYear = New System.Windows.Forms.ComboBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtBookId = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblEdition = New System.Windows.Forms.Label()
        Me.lblPublishingYear = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lblBookId = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdateBook = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpBoxBookDetail.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxBookDetail
        '
        Me.grpBoxBookDetail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpBoxBookDetail.BackColor = System.Drawing.Color.Transparent
        Me.grpBoxBookDetail.Controls.Add(Me.txtAvailableBook)
        Me.grpBoxBookDetail.Controls.Add(Me.lblAvailableBook)
        Me.grpBoxBookDetail.Controls.Add(Me.txtDescription)
        Me.grpBoxBookDetail.Controls.Add(Me.lblDiscription)
        Me.grpBoxBookDetail.Controls.Add(Me.cmbboxBookCopies)
        Me.grpBoxBookDetail.Controls.Add(Me.txtPrice)
        Me.grpBoxBookDetail.Controls.Add(Me.txtEdition)
        Me.grpBoxBookDetail.Controls.Add(Me.cmbboxPublishYear)
        Me.grpBoxBookDetail.Controls.Add(Me.txtAuthor)
        Me.grpBoxBookDetail.Controls.Add(Me.txtPublisher)
        Me.grpBoxBookDetail.Controls.Add(Me.txtBookName)
        Me.grpBoxBookDetail.Controls.Add(Me.txtBookId)
        Me.grpBoxBookDetail.Controls.Add(Me.lblStatus)
        Me.grpBoxBookDetail.Controls.Add(Me.lblPrice)
        Me.grpBoxBookDetail.Controls.Add(Me.lblEdition)
        Me.grpBoxBookDetail.Controls.Add(Me.lblPublishingYear)
        Me.grpBoxBookDetail.Controls.Add(Me.lblAuthor)
        Me.grpBoxBookDetail.Controls.Add(Me.lblPublisher)
        Me.grpBoxBookDetail.Controls.Add(Me.lblBookName)
        Me.grpBoxBookDetail.Controls.Add(Me.lblBookId)
        Me.grpBoxBookDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxBookDetail.ForeColor = System.Drawing.Color.Black
        Me.grpBoxBookDetail.Location = New System.Drawing.Point(147, 34)
        Me.grpBoxBookDetail.Name = "grpBoxBookDetail"
        Me.grpBoxBookDetail.Size = New System.Drawing.Size(1078, 311)
        Me.grpBoxBookDetail.TabIndex = 1
        Me.grpBoxBookDetail.TabStop = False
        Me.grpBoxBookDetail.Text = "BOOKS DETAIL"
        '
        'txtAvailableBook
        '
        Me.txtAvailableBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAvailableBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableBook.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableBook.Location = New System.Drawing.Point(788, 256)
        Me.txtAvailableBook.Name = "txtAvailableBook"
        Me.txtAvailableBook.ReadOnly = True
        Me.txtAvailableBook.Size = New System.Drawing.Size(247, 26)
        Me.txtAvailableBook.TabIndex = 11
        '
        'lblAvailableBook
        '
        Me.lblAvailableBook.AutoSize = True
        Me.lblAvailableBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableBook.ForeColor = System.Drawing.Color.Black
        Me.lblAvailableBook.Location = New System.Drawing.Point(600, 259)
        Me.lblAvailableBook.Name = "lblAvailableBook"
        Me.lblAvailableBook.Size = New System.Drawing.Size(173, 20)
        Me.lblAvailableBook.TabIndex = 10
        Me.lblAvailableBook.Text = "AVAILABLE BOOKS"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(787, 135)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(247, 100)
        Me.txtDescription.TabIndex = 9
        '
        'lblDiscription
        '
        Me.lblDiscription.AutoSize = True
        Me.lblDiscription.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscription.ForeColor = System.Drawing.Color.Black
        Me.lblDiscription.Location = New System.Drawing.Point(629, 138)
        Me.lblDiscription.Name = "lblDiscription"
        Me.lblDiscription.Size = New System.Drawing.Size(129, 20)
        Me.lblDiscription.TabIndex = 9
        Me.lblDiscription.Text = "DESCRIPTION"
        '
        'cmbboxBookCopies
        '
        Me.cmbboxBookCopies.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbboxBookCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxBookCopies.ForeColor = System.Drawing.Color.Black
        Me.cmbboxBookCopies.FormattingEnabled = True
        Me.cmbboxBookCopies.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbboxBookCopies.Location = New System.Drawing.Point(788, 88)
        Me.cmbboxBookCopies.Name = "cmbboxBookCopies"
        Me.cmbboxBookCopies.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbboxBookCopies.Size = New System.Drawing.Size(247, 28)
        Me.cmbboxBookCopies.TabIndex = 8
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.Location = New System.Drawing.Point(788, 40)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(247, 26)
        Me.txtPrice.TabIndex = 7
        '
        'txtEdition
        '
        Me.txtEdition.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEdition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdition.ForeColor = System.Drawing.Color.Black
        Me.txtEdition.Location = New System.Drawing.Point(273, 282)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.Size = New System.Drawing.Size(247, 26)
        Me.txtEdition.TabIndex = 6
        '
        'cmbboxPublishYear
        '
        Me.cmbboxPublishYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbboxPublishYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxPublishYear.ForeColor = System.Drawing.Color.Black
        Me.cmbboxPublishYear.FormattingEnabled = True
        Me.cmbboxPublishYear.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.cmbboxPublishYear.Location = New System.Drawing.Point(273, 233)
        Me.cmbboxPublishYear.Name = "cmbboxPublishYear"
        Me.cmbboxPublishYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbboxPublishYear.Size = New System.Drawing.Size(247, 28)
        Me.cmbboxPublishYear.TabIndex = 5
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.ForeColor = System.Drawing.Color.Black
        Me.txtAuthor.Location = New System.Drawing.Point(273, 188)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAuthor.Size = New System.Drawing.Size(247, 26)
        Me.txtAuthor.TabIndex = 4
        '
        'txtPublisher
        '
        Me.txtPublisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.ForeColor = System.Drawing.Color.Black
        Me.txtPublisher.Location = New System.Drawing.Point(273, 138)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPublisher.Size = New System.Drawing.Size(247, 26)
        Me.txtPublisher.TabIndex = 3
        '
        'txtBookName
        '
        Me.txtBookName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookName.ForeColor = System.Drawing.Color.Black
        Me.txtBookName.Location = New System.Drawing.Point(273, 90)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBookName.Size = New System.Drawing.Size(247, 26)
        Me.txtBookName.TabIndex = 2
        '
        'txtBookId
        '
        Me.txtBookId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBookId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBookId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookId.ForeColor = System.Drawing.Color.Black
        Me.txtBookId.Location = New System.Drawing.Point(273, 40)
        Me.txtBookId.Name = "txtBookId"
        Me.txtBookId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBookId.Size = New System.Drawing.Size(247, 26)
        Me.txtBookId.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(629, 88)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(129, 20)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "BOOK COPIES"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Black
        Me.lblPrice.Location = New System.Drawing.Point(673, 43)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(63, 20)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "PRICE"
        '
        'lblEdition
        '
        Me.lblEdition.AutoSize = True
        Me.lblEdition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdition.ForeColor = System.Drawing.Color.Black
        Me.lblEdition.Location = New System.Drawing.Point(98, 282)
        Me.lblEdition.Name = "lblEdition"
        Me.lblEdition.Size = New System.Drawing.Size(81, 20)
        Me.lblEdition.TabIndex = 2
        Me.lblEdition.Text = "EDITION"
        '
        'lblPublishingYear
        '
        Me.lblPublishingYear.AutoSize = True
        Me.lblPublishingYear.BackColor = System.Drawing.Color.Transparent
        Me.lblPublishingYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublishingYear.ForeColor = System.Drawing.Color.Black
        Me.lblPublishingYear.Location = New System.Drawing.Point(59, 236)
        Me.lblPublishingYear.Name = "lblPublishingYear"
        Me.lblPublishingYear.Size = New System.Drawing.Size(172, 20)
        Me.lblPublishingYear.TabIndex = 5
        Me.lblPublishingYear.Text = "PUBLISHING YEAR"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.ForeColor = System.Drawing.Color.Black
        Me.lblAuthor.Location = New System.Drawing.Point(110, 191)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(83, 20)
        Me.lblAuthor.TabIndex = 4
        Me.lblAuthor.Text = "AUTHOR"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisher.ForeColor = System.Drawing.Color.Black
        Me.lblPublisher.Location = New System.Drawing.Point(96, 141)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(111, 20)
        Me.lblPublisher.TabIndex = 3
        Me.lblPublisher.Text = "PUBLISHER"
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookName.ForeColor = System.Drawing.Color.Black
        Me.lblBookName.Location = New System.Drawing.Point(96, 93)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(113, 20)
        Me.lblBookName.TabIndex = 2
        Me.lblBookName.Text = "BOOK NAME"
        '
        'lblBookId
        '
        Me.lblBookId.AutoSize = True
        Me.lblBookId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookId.ForeColor = System.Drawing.Color.Black
        Me.lblBookId.Location = New System.Drawing.Point(125, 43)
        Me.lblBookId.Name = "lblBookId"
        Me.lblBookId.Size = New System.Drawing.Size(82, 20)
        Me.lblBookId.TabIndex = 0
        Me.lblBookId.Text = "BOOK ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnUpdateBook)
        Me.GroupBox2.Controls.Add(Me.btnAddNew)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(150, 594)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1075, 130)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(663, 39)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 70)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(885, 39)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(160, 70)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(444, 39)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(160, 70)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdateBook
        '
        Me.btnUpdateBook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBook.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateBook.Location = New System.Drawing.Point(228, 39)
        Me.btnUpdateBook.Name = "btnUpdateBook"
        Me.btnUpdateBook.Size = New System.Drawing.Size(160, 70)
        Me.btnUpdateBook.TabIndex = 11
        Me.btnUpdateBook.Text = "UPDATE"
        Me.btnUpdateBook.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Black
        Me.btnAddNew.Location = New System.Drawing.Point(16, 39)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(160, 70)
        Me.btnAddNew.TabIndex = 10
        Me.btnAddNew.Text = "ADD NEW"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(150, 351)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Size = New System.Drawing.Size(1075, 237)
        Me.DataGridView1.TabIndex = 11
        '
        'AddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1368, 777)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpBoxBookDetail)
        Me.Name = "AddBook"
        Me.Text = "AddBook"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpBoxBookDetail.ResumeLayout(False)
        Me.grpBoxBookDetail.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBoxBookDetail As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscription As System.Windows.Forms.Label
    Friend WithEvents cmbboxBookCopies As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtEdition As System.Windows.Forms.TextBox
    Friend WithEvents cmbboxPublishYear As System.Windows.Forms.ComboBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents txtBookName As System.Windows.Forms.TextBox
    Friend WithEvents txtBookId As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblEdition As System.Windows.Forms.Label
    Friend WithEvents lblPublishingYear As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblPublisher As System.Windows.Forms.Label
    Friend WithEvents lblBookName As System.Windows.Forms.Label
    Friend WithEvents lblBookId As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdateBook As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtAvailableBook As System.Windows.Forms.TextBox
    Friend WithEvents lblAvailableBook As System.Windows.Forms.Label
End Class
