Imports System.Data.SqlClient
Imports System.Data

Public Class Return_Book

    'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Me.Close()

    End Sub

  
    Private Sub cmbBoxBookName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoxBookName.SelectedIndexChanged

        con.Open()

        cmd = New SqlCommand("Select * from Issue_Book where Book_Name = '" + cmbBoxBookName.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                txtBookId.Text = dr("Book_id")
                DateTimePickerIssueDate.Text = dr("Issuing_date")
                DateTimePickerDueDate.Text = dr("Due_date")
                txtRegisterID.Text = dr("Registration_id")
                cmbBoxName.Text = dr("First_Name")

            End While
        End If
        con.Close()
    End Sub

   

    Private Sub FillGrid()

        ' Dim connectionstring As String = ("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")

        Dim sql As String = "Select * from Return_Book_TB"

        '  Dim connection As New SqlConnection(connectionstring)

        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "Return_Book_TB")

        con.Close()

        DataGridViewReturnBook.DataSource = ds
        DataGridViewReturnBook.DataMember = "Return_Book_TB"

    End Sub

    Private Sub FillName()

        con.Open()

        cmd = New SqlCommand("select * from Issue_Book", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Issue_Book")

        Dim i As Integer = 0

        cmbBoxName.Items.Clear()

        For i = 0 To ds.Tables("Issue_Book").Rows.Count - 1
            cmbBoxName.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
        Next

        con.Close()
    End Sub

    Private Sub FillBookName()

        con.Open()

        cmd = New SqlCommand("select * from Issue_Book", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Issue_Book")

        Dim i As Integer = 0

        cmbBoxBookName.Items.Clear()

        For i = 0 To ds.Tables("Issue_Book").Rows.Count - 1
            cmbBoxBookName.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
        Next

        con.Close()

    End Sub

    Private Sub Return_Book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FillGrid()
        FillName()
        FillBookName()
        txtAvailableBook.Text = AddBook.DataGridView1.Rows.Count - 1

    End Sub

    

    Private Sub resetBook()

        txtBookId.Text = ""
        txtDescription.Text = ""
        ' DateTimePickerDueDate.Text = ""
        ' DateTimePickerIssueDate.Text = ""
        txtRegisterID.Text = ""
        cmbBoxBookName.Text = ""
        cmbBoxName.Text = ""

    End Sub

   
    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        If txtBookId.Text <> "" And cmbBoxBookName.Text <> "" And DateTimePickerIssueDate.Text <> "" And txtRegisterID.Text <> "" And cmbBoxName.Text <> "" And DateTimePickerDueDate.Text <> "" And DateTimePickerReturnDate.Text <> "" And txtDescription.Text <> "" Then

            Try

                con.Open()

                cmd = New SqlCommand("Insert into Return_Book_TB(Book_id,Book_Name,Issue_Date,Description,Registration_id,First_Name,Due_Date,Return_Date) values ('" + txtBookId.Text + "', '" + cmbBoxBookName.Text + "', '" + DateTimePickerIssueDate.Value.ToString("yyyy-MM-dd") + "', '" + txtDescription.Text + "', '" + txtRegisterID.Text + "', '" + cmbBoxName.Text + "', '" + DateTimePickerDueDate.Value.ToString("yyyy-MM-dd") + "', '" + DateTimePickerReturnDate.Value.ToString("yyyy-MM-dd") + "')", con)

                con = cmd.Connection

                cmd.ExecuteNonQuery()

                MsgBox("Book " + cmbBoxBookName.Text + " return Sucessfully....")
                resetBook()
                txtAvailableBook.Text = DataGridViewReturnBook.Rows.Count + 1
                AddBook.txtAvailableBook.Text = DataGridViewReturnBook.Rows.Count + 1

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No Data Inserted..")
        End If

        con.Close()

        FillBookName()
        FillGrid()
        FillName()
        reset()

    End Sub

    Public Sub reset()

        txtBookId.Text = ""
        cmbBoxBookName.Text = ""
        txtDescription.Text = ""
        txtRegisterID.Text = ""
        cmbBoxName.Text = ""

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        reset()
    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged

    End Sub

    Private Sub cmbBoxBookName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBoxBookName.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub

    Private Sub cmbBoxName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBoxName.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub
End Class