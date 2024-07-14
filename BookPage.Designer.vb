<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookPage
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
        Me.PanelBookPage = New System.Windows.Forms.Panel()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnBookReturn = New System.Windows.Forms.Button()
        Me.btnBookIssue = New System.Windows.Forms.Button()
        Me.btnViewBook = New System.Windows.Forms.Button()
        Me.PanelBookPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBookPage
        '
        Me.PanelBookPage.BackColor = System.Drawing.Color.Transparent
        Me.PanelBookPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelBookPage.Controls.Add(Me.btnAddBook)
        Me.PanelBookPage.Controls.Add(Me.btnBookReturn)
        Me.PanelBookPage.Controls.Add(Me.btnBookIssue)
        Me.PanelBookPage.Controls.Add(Me.btnViewBook)
        Me.PanelBookPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBookPage.ForeColor = System.Drawing.Color.White
        Me.PanelBookPage.Location = New System.Drawing.Point(0, 0)
        Me.PanelBookPage.Name = "PanelBookPage"
        Me.PanelBookPage.Size = New System.Drawing.Size(363, 274)
        Me.PanelBookPage.TabIndex = 9
        '
        'btnAddBook
        '
        Me.btnAddBook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddBook.BackColor = System.Drawing.Color.Transparent
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.ForeColor = System.Drawing.Color.Black
        Me.btnAddBook.Location = New System.Drawing.Point(37, 62)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(140, 70)
        Me.btnAddBook.TabIndex = 0
        Me.btnAddBook.Text = "ADD BOOK"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'btnBookReturn
        '
        Me.btnBookReturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBookReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnBookReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookReturn.ForeColor = System.Drawing.Color.Black
        Me.btnBookReturn.Location = New System.Drawing.Point(186, 141)
        Me.btnBookReturn.Name = "btnBookReturn"
        Me.btnBookReturn.Size = New System.Drawing.Size(140, 70)
        Me.btnBookReturn.TabIndex = 3
        Me.btnBookReturn.Text = "BOOK RETURN"
        Me.btnBookReturn.UseVisualStyleBackColor = False
        '
        'btnBookIssue
        '
        Me.btnBookIssue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBookIssue.BackColor = System.Drawing.Color.Transparent
        Me.btnBookIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookIssue.ForeColor = System.Drawing.Color.Black
        Me.btnBookIssue.Location = New System.Drawing.Point(37, 141)
        Me.btnBookIssue.Name = "btnBookIssue"
        Me.btnBookIssue.Size = New System.Drawing.Size(140, 70)
        Me.btnBookIssue.TabIndex = 2
        Me.btnBookIssue.Text = "BOOK ISSUE"
        Me.btnBookIssue.UseVisualStyleBackColor = False
        '
        'btnViewBook
        '
        Me.btnViewBook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewBook.BackColor = System.Drawing.Color.Transparent
        Me.btnViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewBook.ForeColor = System.Drawing.Color.Black
        Me.btnViewBook.Location = New System.Drawing.Point(186, 62)
        Me.btnViewBook.Name = "btnViewBook"
        Me.btnViewBook.Size = New System.Drawing.Size(140, 70)
        Me.btnViewBook.TabIndex = 1
        Me.btnViewBook.Text = "VIEW BOOK"
        Me.btnViewBook.UseVisualStyleBackColor = False
        '
        'BookPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.photo_1577017040065_650ee4d433391
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(363, 274)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelBookPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookPage"
        Me.Text = "BookPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelBookPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBookPage As System.Windows.Forms.Panel
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents btnBookReturn As System.Windows.Forms.Button
    Friend WithEvents btnBookIssue As System.Windows.Forms.Button
    Friend WithEvents btnViewBook As System.Windows.Forms.Button
End Class
