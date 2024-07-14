Imports System.Data.SqlClient
Imports System.Data

Public Class ViewBook

    Private Sub btnSearchBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBook.Click
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Book_TB where Book_Name ='" + cmbBoxSearch.Text + "'"
        Dim v = cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        con.Close()

    End Sub

    Private Sub FillGrid()

        ' Dim connectionstring As String = ("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")

        Dim sql As String = "Select * from Book_TB "

        ' Dim connection As New SqlConnection(connectionstring)

        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "Book_TB")

        con.Close()

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Book_TB"

    End Sub

    Private Sub FillBook()

        con.Open()

        cmd = New SqlCommand("select * from Book_TB", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Book_TB")

        Dim i As Integer = 0

        cmbBoxSearch.Items.Clear()

        For i = 0 To ds.Tables("Book_TB").Rows.Count - 1
            cmbBoxSearch.Items.Add(ds.Tables(0).Rows(i)(2).ToString())
        Next

        con.Close()

    End Sub

    Private Sub ViewBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
        FillBook()
        txtAvailableBook.Text = DataGridView1.Rows.Count - 1
    End Sub

    Private Sub cmbBoxSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoxSearch.SelectedIndexChanged
  
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class