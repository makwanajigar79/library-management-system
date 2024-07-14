Imports System.Data.SqlClient
Imports System.Data

Public Class Issue_Book

    Dim id As Integer
    '   Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter

   

    Private Sub btnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssue.Click

        If txtBookId.Text <> "" And cmbBoxBookName.Text <> "" And txtPublisher.Text <> "" And txtAuthor.Text <> "" And cmbBoxPublishYear.Text <> "" And txtEdition.Text <> "" And txtPrice.Text <> "" And cmbBoxBookCopies.Text <> "" And txtRegisterID.Text <> "" And cmbBoxName.Text <> "" And DateTimePickerIssueDate.Text <> "" And DateTimePickerDueDate.Text <> "" And lblTransactionType.Text <> "" Then

            Try

                con.Open()

                cmd = New SqlCommand("Insert into Issue_Book(Book_id,Book_Name,Publisher,Author,Publishing_Year,Edition,Price,Book_Copies,Registration_id,First_Name,Issuing_date,Due_date,Transaction_Type) values ('" + txtBookId.Text + "', '" + cmbBoxBookName.Text + "','" + txtPublisher.Text + "', '" + txtAuthor.Text + "', '" + cmbBoxPublishYear.Text + "', '" + txtEdition.Text + "', '" + txtPrice.Text + "', '" + cmbBoxBookCopies.Text + "', '" + txtRegisterID.Text + "','" + cmbBoxName.Text + "','" + DateTimePickerIssueDate.Text + "','" + DateTimePickerDueDate.Text + "','" + cmbBoxTransactionType.Text + "')", con)

                con = cmd.Connection

                cmd.ExecuteNonQuery()

                MsgBox("Book Name : " + cmbBoxBookName.Text + " Issueing Sucessfully....")
                resetBook()
                txtAvailableBook.Text = DataGridViewIssueBook.Rows.Count - 2
                AddBook.txtAvailableBook.Text = AddBook.DataGridView1.Rows.Count - 2

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No Data Inserted..")
        End If

        con.Close()
        FillGrid()
        FillName()
    End Sub



    Private Sub resetBook()


        txtBookId.Text = ""
        cmbBoxBookName.Text = ""
        txtPublisher.Text = ""
        txtAuthor.Text = ""
        cmbBoxPublishYear.Text = ""
        txtEdition.Text = ""
        txtPrice.Text = ""
        cmbBoxBookCopies.Text = ""
        txtRegisterID.Text = ""
        cmbBoxName.Text = ""
        ' DateTimePickerDueDate.Text = ""
        'DateTimePickerIssueDate.Text = ""

    End Sub

    Private Sub FillGrid()

        '  Dim connectionstring As String = ("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")

        Dim sql As String = "Select * from Issue_Book"

        ' Dim connection As New SqlConnection(connectionstring)

        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "Issue_Book")

        con.Close()

        DataGridViewIssueBook.DataSource = ds
        DataGridViewIssueBook.DataMember = "Issue_Book"
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        resetBook()
    End Sub

    Private Sub Issue_Book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAvailableBook.Text = AddBook.DataGridView1.Rows.Count - 1
        FillGrid()
        FillBook()
        FillName()

    End Sub
    Private Sub FillBook()

        con.Open()

        cmd = New SqlCommand("select * from Book_TB", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Book_TB")

        Dim i As Integer = 0

        cmbBoxBookName.Items.Clear()

        For i = 0 To ds.Tables("Book_TB").Rows.Count - 1
            cmbBoxBookName.Items.Add(ds.Tables(0).Rows(i)(2).ToString())
        Next

        con.Close()
    End Sub
    Private Sub FillName()

        con.Open()

        cmd = New SqlCommand("select * from Register_TB", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Register_TB")

        Dim i As Integer = 0

        cmbBoxName.Items.Clear()

        For i = 0 To ds.Tables("Register_TB").Rows.Count - 1
            cmbBoxName.Items.Add(ds.Tables(0).Rows(i)(2).ToString())
        Next

        con.Close()
    End Sub

    Private Sub cmbBoxName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoxName.SelectedIndexChanged
        con.Open()

        cmd = New SqlCommand("Select * from Register_TB where First_Name = '" + cmbBoxName.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                txtRegisterID.Text = dr("Registration_id")


            End While
        End If

        con.Close()
    End Sub

    Private Sub cmbBoxBookName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoxBookName.SelectedIndexChanged

        con.Open()

        cmd = New SqlCommand("Select * from Book_TB where Book_Name = '" + cmbBoxBookName.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                txtBookId.Text = dr("Book_id")
                txtPublisher.Text = dr("Publisher")
                txtAuthor.Text = dr("Author")
                cmbBoxPublishYear.Text = dr("Publishing_Year")
                txtEdition.Text = dr("Edition")
                txtPrice.Text = dr("Price")
                cmbBoxBookCopies.Text = dr("Book_Copies")

            End While
        End If

        con.Close()
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub DataGridViewIssueBook_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewIssueBook.CellClick

        id = DataGridViewIssueBook.Rows(e.RowIndex).Cells(0).Value
        cmbBoxBookName.Text = DataGridViewIssueBook.Rows(e.RowIndex).Cells(1).Value
        txtPublisher.Text = DataGridViewIssueBook.Rows(e.RowIndex).Cells(2).Value
        txtAuthor.Text = DataGridViewIssueBook.Rows(e.RowIndex).Cells(3).Value
        cmbBoxPublishYear.Text = DataGridViewIssueBook.Rows(e.RowIndex).Cells(4).Value
        txtEdition.Text = DataGridViewIssueBook.Rows(e.RowIndex).Cells(5).Value
        txtPrice.Text = DataGridViewIssueBook.Rows(e.RowIndex).Cells(6).Value
        cmbBoxBookCopies.Text = DataGridViewIssueBook.Rows(e.RowIndex).Cells(7).Value
        txtRegisterID.Text = DataGridViewIssueBook.Rows(e.RowIndex).Cells(8).Value
        cmbBoxName.Text = DataGridViewIssueBook.Rows(e.RowIndex).Cells(9).Value
        DateTimePickerIssueDate.Text = DataGridViewIssueBook.Rows(e.RowIndex).Cells(10).Value


    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub GrpBoxIssueDetail_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpBoxIssueDetail.Enter

    End Sub

    Private Sub cmbBoxBookName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBoxBookName.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub
End Class



