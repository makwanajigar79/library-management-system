Imports System.Data.SqlClient
Imports System.Data

Public Class Update_Customer

    ' Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter

   
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        CustomerPage.Show()
    End Sub

  
    Private Sub cmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRegisterID.SelectedIndexChanged

        con.Open()

        cmd = New SqlCommand("Select * from Register_TB where Registration_id = '" + cmbRegisterID.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                txtMobileno.Text = dr("MobileNumber")
                txtaddress.Text = dr("Address")
                txtcity.Text = dr("City")
                TXTLNAME.Text = dr("Last_Name")
                txtEmailid.Text = dr("Emailid")
                cmbBoxFName.Text = dr("First_Name")
                txtpincode.Text = dr("Pincode")
                ComboBoxDept.Text = dr("Department")
                cmbRegisterID.Text = dr("Registration_id")


            End While
        End If

        con.Close()
    End Sub

    Private Sub FillGrid()

        '  Dim connectionstring As String = ("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\JIGAR_PROJECT\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LIBRARY_MANAGEMENT_SYSTEM\LMS.mdf;Integrated Security=True;User Instance=True")

        Dim sql As String = "Select * from Register_TB"

        '  Dim connection As New SqlConnection(connectionstring)

        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "Register_TB")

        con.Close()

        DataGridViewUpdateCust.DataSource = ds
        DataGridViewUpdateCust.DataMember = "Register_TB"

    End Sub

    Private Sub FillName()

        con.Open()

        cmd = New SqlCommand("select * from Register_TB", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Register_TB")

        Dim i As Integer = 0

        cmbRegisterID.Items.Clear()

        For i = 0 To ds.Tables("Register_TB").Rows.Count - 1

            cmbBoxFName.Items.Add(ds.Tables(0).Rows(i)(2).ToString())

        Next

        con.Close()
    End Sub

    Private Sub FillRegisterID()

        con.Open()

        cmd = New SqlCommand("select * from Register_TB", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Register_TB")

        Dim i As Integer = 0

        cmbRegisterID.Items.Clear()

        For i = 0 To ds.Tables("Register_TB").Rows.Count - 1
            cmbRegisterID.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
        Next

        con.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim rdtype As String

        If RdbtnMale.Checked = True Then
            rdtype = "Male"

        Else
            rdtype = "Female"
        End If

        If cmbRegisterID.Text <> "" And ComboBoxDept.Text <> "" And cmbBoxFName.Text <> "" And txtaddress.Text <> "" And txtcity.Text <> "" And txtpincode.Text <> "" And txtMobileno.Text <> "" And txtEmailid.Text <> "" Then

            con.Open()

            cmd = New SqlCommand("update Register_TB set Registration_id='" + cmbRegisterID.Text + "',Department='" + ComboBoxDept.Text + "',First_Name='" + cmbBoxFName.Text + "',Last_Name='" + TXTLNAME.Text + "',Address='" + txtaddress.Text + "',City='" + txtcity.Text + "',Pincode='" + txtpincode.Text + "',MobileNumber='" + txtMobileno.Text + "',Emailid='" + txtEmailid.Text + "'where First_Name= '" + cmbBoxFName.Text + "'", con)

            cmd.ExecuteNonQuery()

            MsgBox("Name : " + cmbBoxFName.Text + "  updated Sucessfully.....")

        Else
            MsgBox("No Data Selected...")
        End If

        con.Close()
        FillGrid()
        FillName()
        reset()
    End Sub

    Private Sub Update_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
        FillName()
        FillRegisterID()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBACK.Click
        Me.Close()
        CustomerPage.Show()
    End Sub

    Private Sub cmbBoxName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoxFName.SelectedIndexChanged

        con.Open()

        cmd = New SqlCommand("Select * from Register_TB where First_Name = '" + cmbBoxFName.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                txtMobileno.Text = dr("MobileNumber")
                txtaddress.Text = dr("Address")
                txtcity.Text = dr("City")
                TXTLNAME.Text = dr("Last_Name")
                txtEmailid.Text = dr("Emailid")
                cmbBoxFName.Text = dr("First_Name")

                txtpincode.Text = dr("Pincode")
                ComboBoxDept.Text = dr("Department")
                cmbRegisterID.Text = dr("Registration_id")


            End While
        End If

        con.Close()
    End Sub

    Private Sub reset()
        txtaddress.Text = ""
        txtcity.Text = ""
        TXTLNAME.Text = ""
        txtaddress.Text = ""
        txtEmailid.Text = ""
        txtMobileno.Text = ""
        txtpincode.Text = ""
        cmbBoxFName.Text = ""
        cmbRegisterID.Text = ""
        ComboBoxDept.Text = ""
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtaddress.Text = ""
        txtcity.Text = ""
        TXTLNAME.Text = ""
        txtaddress.Text = ""
        txtEmailid.Text = ""
        txtMobileno.Text = ""

        txtpincode.Text = ""
        cmbBoxFName.Text = ""
        cmbRegisterID.Text = ""
        ComboBoxDept.Text = ""

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridViewUpdateCust_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewUpdateCust.CellClick

        cmbRegisterID.Text = DataGridViewUpdateCust.Rows(e.RowIndex).Cells(0).Value
        ComboBoxDept.Text = DataGridViewUpdateCust.Rows(e.RowIndex).Cells(1).Value
        cmbBoxFName.Text = DataGridViewUpdateCust.Rows(e.RowIndex).Cells(2).Value
        TXTLNAME.Text = DataGridViewUpdateCust.Rows(e.RowIndex).Cells(3).Value
        txtaddress.Text = DataGridViewUpdateCust.Rows(e.RowIndex).Cells(4).Value
        txtcity.Text = DataGridViewUpdateCust.Rows(e.RowIndex).Cells(5).Value
        txtpincode.Text = DataGridViewUpdateCust.Rows(e.RowIndex).Cells(6).Value
        txtMobileno.Text = DataGridViewUpdateCust.Rows(e.RowIndex).Cells(8).Value
        txtEmailid.Text = DataGridViewUpdateCust.Rows(e.RowIndex).Cells(9).Value

        DateTimePicker1.Text = DataGridViewUpdateCust.Rows(e.RowIndex).Cells(10).Value

    End Sub

    Private Sub lblStdEmailId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStdEmailId.Click

    End Sub

    Private Sub cmbRegisterID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRegisterID.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only digits are allowed")
        End If
    End Sub

    Private Sub txtpincode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpincode.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 6 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only 6 digits are allowed")
        End If
    End Sub

    Private Sub txtMobileno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobileno.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 10 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only 10 digits are allowed")
        End If
    End Sub

    Private Sub ComboBoxDept_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxDept.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub

    Private Sub cmbBoxFName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBoxFName.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub

    Private Sub TXTLNAME_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTLNAME.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub

    Private Sub txtcity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub
End Class