Imports System.Data.SqlClient
Imports System.Data

Public Class DeleteCustomer

    Dim BookId As Integer
    '   Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter

    Private Sub FillGrid()

        ' Dim connectionstring As String = ("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")

        Dim sql As String = "Select * from Register_TB"

        '  Dim connection As New SqlConnection(connectionstring)

        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "Register_TB")

        con.Close()

        DataGridViewDeleteCust.DataSource = ds
        DataGridViewDeleteCust.DataMember = "Register_TB"

    End Sub

    Private Sub FillName()

        con.Open()

        cmd = New SqlCommand("select * from Register_TB", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Register_TB")

        Dim i As Integer = 0

        cmbBoxFName.Items.Clear()

        For i = 0 To ds.Tables("Register_TB").Rows.Count - 1
            cmbBoxFName.Items.Add(ds.Tables(0).Rows(i)(2).ToString())
        Next

        con.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBACK.Click
        Me.Close()
        CustomerPage.Show()
    End Sub

    Private Sub DeleteCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
        FillName()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click


        Dim strDelete As String

        strDelete = MsgBox("Do you want to delete ?", vbYesNo)

        If strDelete = vbYes Then

            Dim n As String = "0"

            con.Open()

            cmd = New SqlCommand("Delete from Register_TB where First_Name = '" + cmbBoxFName.Text + "'", con)

            con = cmd.Connection

            n = cmd.ExecuteNonQuery()

            If n.ToString = "2" Then

                MsgBox("Customer Name : " + cmbBoxFName.Text + " Delete Sucessfully done")

            Else

                MsgBox("Record Not Found.....")
            End If
        End If

        con.Close()

        FillName()
        FillGrid()
        reset()

    End Sub

    Private Sub cmbBoxName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        con.Open()

        cmd = New SqlCommand("Select * from Register_TB where First_Name = '" + cmbBoxFName.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                txtMobileno.Text = dr("MobileNumber")
                txtaddress.Text = dr("Address")
                txtcity.Text = dr("City")
                DateTimePicker1.Text = dr("Joining_Date")
                txtEmailid.Text = dr("Emailid")
                cmbBoxFName.Text = dr("First_Name")
                TXTLNAME.Text = dr("Last_Name")
                txtpincode.Text = dr("Pincode")
                ComboBoxDept.Text = dr("Department")
                cmbRegisterID.Text = dr("Registration_id")

            End While

        End If
        con.Close()

    End Sub

    Private Sub DataGridViewDeleteCust_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewDeleteCust.CellClick

        ' BookId = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(0).Value
        cmbRegisterID.Text = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(0).Value
        ComboBoxDept.Text = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(1).Value
        cmbBoxFName.Text = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(2).Value
        TXTLNAME.Text = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(3).Value
        txtaddress.Text = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(4).Value
        txtcity.Text = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(5).Value
        txtpincode.Text = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(6).Value
        txtMobileno.Text = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(8).Value
        txtEmailid.Text = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(9).Value
        DateTimePicker1.Text = DataGridViewDeleteCust.Rows(e.RowIndex).Cells(10).Value

    End Sub

    Private Sub reset()
        txtcity.Clear()
        cmbRegisterID.Text = ""
        txtEmailid.Clear()
        txtaddress.Clear()
        cmbBoxFName.Text = ""
        txtMobileno.Clear()
        TXTLNAME.Clear()
        txtpincode.Clear()
        txtMobileno.Clear()
      
        ComboBoxDept.Text = ""


    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub PanelDeleteCustomer_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelDeleteCustomer.Paint

    End Sub
End Class