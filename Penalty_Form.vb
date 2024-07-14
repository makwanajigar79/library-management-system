Imports System.Data.SqlClient
Imports System.Data

Public Class Penalty_Form

    Dim id As Integer
    '  Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter

    Private Sub Penalty_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillName()
        FillBookName()
        FillGrid()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBACK.Click
        Me.Close()
        PenaltyPage.Show()
    End Sub

    Private Sub btnPayNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayNow.Click

        If lblRegistrationIDOP.Text <> "" And lblNameOP.Text <> "" And lblBookIdOP.Text <> "" And lblBookNameOP.Text <> "" And lblBookAuthorOP.Text <> "" And DateTimePickerIssueDate.Text <> "" And DateTimePickerPanaltydate.Text <> "" And cmbBoxPenaltyStatus.Text <> "" And txtPanaltyAmount.Text <> "" And txtReason.Text <> "" Then

            Try

                con.Open()

                cmd = New SqlCommand("Insert into panalty_TB(Registration_id,Name,Book_id,Book_name,Book_author,Issue_date,Penalty_date,Panalty_status,Panalty_amount,Reason) values ('" + lblRegistrationIDOP.Text + "', '" + lblNameOP.Text + "','" + lblBookIdOP.Text + "', '" + lblBookNameOP.Text + "', '" + lblBookAuthorOP.Text + "', '" + DateTimePickerIssueDate.Value.ToString("yyyy/MM/dd") + "', '" + DateTimePickerPanaltydate.Value.ToString("yyyy/MM/dd") + "', '" + cmbBoxPenaltyStatus.Text + "', '" + txtPanaltyAmount.Text + "','" + txtReason.Text + "')", con)

                con = cmd.Connection

                cmd.ExecuteNonQuery()

                MsgBox(" Name : " + lblNameOP.Text + " for Pay Penalty Rs. " + txtPanaltyAmount.Text + " Sucessfully....")

                reset()

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

    Private Sub FillName()

        con.Open()

        cmd = New SqlCommand("select * from Register_TB", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Register_TB")

        Dim i As Integer = 0

        cmbBoxSelectUser.Items.Clear()

        For i = 0 To ds.Tables("Register_TB").Rows.Count - 1
            cmbBoxSelectUser.Items.Add(ds.Tables(0).Rows(i)(2).ToString())
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

        cmbBoxSelectBook.Items.Clear()

        For i = 0 To ds.Tables("Issue_Book").Rows.Count - 1
            cmbBoxSelectBook.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
        Next

        con.Close()
    End Sub

    Public Sub FillGrid()

        '    Dim connectionstring As String = ("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")

        Dim sql As String = "Select * from panalty_TB"

        '  Dim connection As New SqlConnection(connectionstring)

        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "panalty_TB")

        con.Close()

        DataGridViewPenaltyForm.DataSource = ds
        DataGridViewPenaltyForm.DataMember = "panalty_TB"

    End Sub

    Private Sub cmbBoxSelectUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoxSelectUser.SelectedIndexChanged

        con.Open()

        cmd = New SqlCommand("Select * from Register_TB where First_Name = '" + cmbBoxSelectUser.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                lblRegistrationIDOP.Text = dr("Registration_id")
                lblNameOP.Text = dr("First_Name")

            End While
        End If

        con.Close()
    End Sub

    Private Sub cmbBoxSelectBook_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoxSelectBook.SelectedIndexChanged

        con.Open()

        cmd = New SqlCommand("Select * from Issue_Book where Book_Name = '" + cmbBoxSelectBook.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                lblBookIdOP.Text = dr("Book_id")
                lblBookNameOP.Text = dr("Book_Name")
                lblBookAuthorOP.Text = dr("Author")
                DateTimePickerIssueDate.Text = dr("Issuing_date")

            End While
        End If

        con.Close()
    End Sub


    Private Sub cmbBoxPenaltyStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoxPenaltyStatus.SelectedIndexChanged

        If cmbBoxPenaltyStatus.SelectedItem = "YES" Then
            txtPanaltyAmount.Text = "100"
        Else
            txtPanaltyAmount.Text = ""
        End If

    End Sub

    Private Sub reset()

        lblRegistrationIDOP.Text = ""
        lblNameOP.Text = ""
        lblBookIdOP.Text = ""
        lblBookNameOP.Text = ""
        lblBookAuthorOP.Text = ""
        DateTimePickerIssueDate.Text = ""
        DateTimePickerPanaltydate.Text = ""
        cmbBoxPenaltyStatus.Text = ""
        txtPanaltyAmount.Text = ""
        txtReason.Text = ""
        cmbBoxSelectBook.Text = ""
        cmbBoxSelectUser.Text = ""

    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        reset()

    End Sub


    Private Sub DataGridViewPenaltyForm_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewPenaltyForm.CellClick

        '  id = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(0).Value
        lblRegistrationIDOP.Text = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(0).Value
        lblNameOP.Text = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(1).Value
        lblBookIdOP.Text = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(2).Value
        lblBookNameOP.Text = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(3).Value
        lblBookAuthorOP.Text = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(4).Value
        DateTimePickerIssueDate.Text = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(5).Value
        DateTimePickerPanaltydate.Text = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(7).Value
        cmbBoxPenaltyStatus.Text = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(6).Value
        txtPanaltyAmount.Text = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(8).Value
        txtReason.Text = DataGridViewPenaltyForm.Rows(e.RowIndex).Cells(9).Value




    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class