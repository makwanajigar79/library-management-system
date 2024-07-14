Imports System.Data.SqlClient
Imports System.Data

Public Class AddBook

    '  Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim BookId As Integer

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click

        If txtBookId.Text <> "" And txtBookName.Text <> "" And txtPublisher.Text <> "" And txtAuthor.Text <> "" And cmbboxPublishYear.Text <> "" And txtEdition.Text <> "" And txtPrice.Text <> "" And cmbboxBookCopies.Text <> "" Then

            Try

                con.Open()

                cmd = New SqlCommand("Insert into Book_TB(Book_id,Book_name,Publisher,Author,Publishing_Year,Edition,Price,Book_Copies,Description) values ('" + txtBookId.Text + "','" + txtBookName.Text + "', '" + txtPublisher.Text + "', '" + txtAuthor.Text + "', '" + cmbboxPublishYear.Text + "', '" + txtEdition.Text + "', '" + txtPrice.Text + "', '" + cmbboxBookCopies.Text + "', '" + txtDescription.Text + "')", con)

                con = cmd.Connection

                cmd.ExecuteNonQuery()

                MsgBox("Book " + txtBookName.Text + " Inserted Sucessfully....")
                resetBook()

                txtAvailableBook.Text = DataGridView1.Rows.Count

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No Data Inserted..")
        End If

        con.Close()


        FillGrid()
    End Sub

    Private Sub btnUpdateBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateBook.Click

        If txtBookId.Text <> "" Or txtBookName.Text <> "" Or txtPublisher.Text <> "" Or txtAuthor.Text <> "" Or cmbboxPublishYear.Text <> "" Or txtEdition.Text <> "" Or txtPrice.Text <> "" Or cmbboxBookCopies.Text <> "" Then

            con.Open()

            cmd = New SqlCommand("update Book_TB set Book_id ='" + txtBookId.Text + "',Book_Name = '" + txtBookName.Text + "',Publisher = '" + txtPublisher.Text + "',Author ='" + txtAuthor.Text + "',Publishing_Year = '" + cmbboxPublishYear.Text + "',Edition = '" + txtEdition.Text + "',Book_Copies = '" + cmbboxBookCopies.Text + "',Price ='" + txtPrice.Text + "',Description ='" + txtDescription.Text + "'where Book_Name = '" + txtBookName.Text + "'", con)

            cmd.ExecuteNonQuery()

            MsgBox("Book_Name " + txtBookName.Text + " updated Sucessfully.....")

        Else
            MsgBox("No Data Selected...")
        End If


        con.Close()
        FillGrid()

        resetBook()

    End Sub

    Private Sub resetBook()


        txtBookId.Text = ""
        txtBookName.Text = ""
        txtPublisher.Text = ""
        txtAuthor.Text = ""
        cmbboxPublishYear.Text = ""
        txtEdition.Text = ""
        txtPrice.Text = ""
        cmbboxBookCopies.Text = ""
        txtDescription.Text = ""

    End Sub
    Private Sub FillGrid()

        '  Dim connectionstring As String = ("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")

        Dim sql As String = "Select * from Book_TB"

        ' Dim conn As New SqlConnection(con)

        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "Book_TB")

        con.Close()

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Book_TB"

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        resetBook()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim strDelete As String

        strDelete = MsgBox("Do you want to delete ?", vbYesNo)

        If strDelete = vbYes Then

            Dim n As String = "0"

            con.Open()

            cmd = New SqlCommand("Delete from Book_TB where Book_Name = '" + txtBookName.Text + "'", con)

            con = cmd.Connection

            n = cmd.ExecuteNonQuery()

            If n.ToString = "1" Then

                MsgBox("Book Name: " + txtBookName.Text + " Delete Sucessfully done")
                resetBook()
                txtAvailableBook.Text = DataGridView1.Rows.Count - 1
            Else
                MsgBox("Record Not Found.....")
            End If
        End If

        con.Close()


        FillGrid()


    End Sub



    Private Sub AddBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FillGrid()
        txtAvailableBook.Text = DataGridView1.Rows.Count - 1
    End Sub

    Private Sub cmbboxStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbboxBookCopies.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub cmbBoxSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        txtBookId.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtBookName.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txtPublisher.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txtAuthor.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        cmbboxPublishYear.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        txtEdition.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        txtPrice.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        cmbboxBookCopies.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        txtDescription.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value

    End Sub

    Private Sub grpBoxBookDetail_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpBoxBookDetail.Enter

    End Sub

    Private Sub lblEdition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEdition.Click

    End Sub

    Private Sub lblPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPrice.Click

    End Sub

    Private Sub txtBookId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBookId.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only digits are allowed")
        End If
    End Sub

    Private Sub cmbboxPublishYear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbboxPublishYear.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 4 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only 4 digits are allowed")
        End If
    End Sub

    Private Sub txtEdition_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdition.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only digits are allowed")
        End If
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only digits are allowed")
        End If
    End Sub

    Private Sub cmbboxBookCopies_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbboxBookCopies.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only digits are allowed")
        End If
    End Sub

    Private Sub txtBookName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBookName.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub

    Private Sub txtPublisher_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPublisher.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub

    Private Sub txtAuthor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAuthor.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub
End Class