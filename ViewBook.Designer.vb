<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBook
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
        Me.txtAvailableBook = New System.Windows.Forms.TextBox()
        Me.lblAvailableBook = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblsearchBook = New System.Windows.Forms.Label()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.cmbBoxSearch = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txtAvailableBook)
        Me.Panel1.Controls.Add(Me.lblAvailableBook)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.lblsearchBook)
        Me.Panel1.Controls.Add(Me.btnSearchBook)
        Me.Panel1.Controls.Add(Me.cmbBoxSearch)
        Me.Panel1.Location = New System.Drawing.Point(35, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 727)
        Me.Panel1.TabIndex = 0
        '
        'txtAvailableBook
        '
        Me.txtAvailableBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAvailableBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableBook.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableBook.Location = New System.Drawing.Point(1004, 35)
        Me.txtAvailableBook.Name = "txtAvailableBook"
        Me.txtAvailableBook.ReadOnly = True
        Me.txtAvailableBook.Size = New System.Drawing.Size(152, 26)
        Me.txtAvailableBook.TabIndex = 23
        '
        'lblAvailableBook
        '
        Me.lblAvailableBook.AutoSize = True
        Me.lblAvailableBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableBook.ForeColor = System.Drawing.Color.Black
        Me.lblAvailableBook.Location = New System.Drawing.Point(793, 38)
        Me.lblAvailableBook.Name = "lblAvailableBook"
        Me.lblAvailableBook.Size = New System.Drawing.Size(173, 20)
        Me.lblAvailableBook.TabIndex = 22
        Me.lblAvailableBook.Text = "AVAILABLE BOOKS"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1095, 664)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 42)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1186, 548)
        Me.DataGridView1.TabIndex = 20
        '
        'lblsearchBook
        '
        Me.lblsearchBook.AutoSize = True
        Me.lblsearchBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearchBook.Location = New System.Drawing.Point(116, 38)
        Me.lblsearchBook.Name = "lblsearchBook"
        Me.lblsearchBook.Size = New System.Drawing.Size(178, 20)
        Me.lblsearchBook.TabIndex = 19
        Me.lblsearchBook.Text = "SEARCH BY BOOKS"
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearchBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBook.Location = New System.Drawing.Point(536, 25)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(160, 47)
        Me.btnSearchBook.TabIndex = 18
        Me.btnSearchBook.Text = "SEARCH BOOK"
        Me.btnSearchBook.UseVisualStyleBackColor = False
        '
        'cmbBoxSearch
        '
        Me.cmbBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbBoxSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxSearch.FormattingEnabled = True
        Me.cmbBoxSearch.Location = New System.Drawing.Point(316, 35)
        Me.cmbBoxSearch.Name = "cmbBoxSearch"
        Me.cmbBoxSearch.Size = New System.Drawing.Size(181, 28)
        Me.cmbBoxSearch.TabIndex = 17
        '
        'ViewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d43339
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1358, 777)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ViewBook"
        Me.Text = "ViewBook"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblsearchBook As System.Windows.Forms.Label
    Friend WithEvents btnSearchBook As System.Windows.Forms.Button
    Friend WithEvents cmbBoxSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtAvailableBook As System.Windows.Forms.TextBox
    Friend WithEvents lblAvailableBook As System.Windows.Forms.Label
End Class
