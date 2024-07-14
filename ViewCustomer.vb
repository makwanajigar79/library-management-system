Imports System.Data.SqlClient
Imports System.Data

Public Class ViewCustomer

    Private Sub btnSearchName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchName.Click
        If cmbBoxSearch.Text = "" Then
            MsgBox("please select customer name!!!")

        else 

        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Register_TB where First_Name ='" + cmbBoxSearch.Text + "'"
        Dim v = cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridViewCustomer.DataSource = dt
       
            con.Close()
        End If
    End Sub

    Private Sub FillGrid()

        ' Dim connectionstring As String = ("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")

        Dim sql As String = "Select * from Register_TB "

        ' Dim connection As New SqlConnection(connectionstring)

        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "Register_TB")

        con.Close()

        DataGridViewCustomer.DataSource = ds
        DataGridViewCustomer.DataMember = "Register_TB"

    End Sub

    Private Sub FillName()

        con.Open()

        cmd = New SqlCommand("select * from Register_TB", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Register_TB")

        Dim i As Integer = 0

        cmbBoxSearch.Items.Clear()

        For i = 0 To ds.Tables("Register_TB").Rows.Count - 1

            cmbBoxSearch.Items.Add(ds.Tables(0).Rows(i)(2).ToString())

        Next

        con.Close()
    End Sub

    Private Sub ViewCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
        FillName()
        txtRegisterCust.Text = DataGridViewCustomer.Rows.Count - 1
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        CustomerPage.Show()
    End Sub

    Private Sub cmbBoxSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBoxSearch.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub
End Class