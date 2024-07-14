Imports System.Data.SqlClient
Imports System.Data

Public Class Add_Customer

    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBACK.Click
        Me.Close()
        CustomerPage.Show()
    End Sub
    Private Sub reset()
        txtcity.Clear()
        txtLname.Clear()
        txtEmailid.Clear()
        txtaddress.Clear()
        txtFName.Clear()
        txtMobileno.Clear()

        txtpincode.Clear()
        RdbtnMale.Checked = False
        RdbtnFemale.Checked = False
        ComboBoxDept.Text = ""
        txtRegisterID.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub rdbtnStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub GetRegisterID()
        Dim str As String

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        str = "select max(Registration_id) from Register_TB"
        cmd = New SqlCommand(Str, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)

        Dim st As String
        st = ds.Tables(0).Rows(0).Item(0).ToString()

        If st = vbNullString Then
            txtRegisterID.Text = "1"
        Else
            txtRegisterID.Text = CInt(st) + 1

        End If
        con.Close()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim gender As String

        If RdbtnMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"

        End If

        DateTimePicker1.Value.ToString("dd-mm-yyyy")


        If txtRegisterID.Text <> "" And ComboBoxDept.Text <> "" And txtFName.Text <> "" And txtaddress.Text <> "" And txtcity.Text <> "" And txtpincode.Text <> "" And txtMobileno.Text <> "" And txtEmailid.Text <> "" And txtLname.Text <> "" And DateTimePicker1.Text <> "" Then

            Try

                con.Open()

                cmd = New SqlCommand("Insert into Register_TB(Registration_id,Department,First_Name,Last_Name,Address,City,Pincode,Gender,MobileNumber,EmailId,Joining_Date) values ('" + txtRegisterID.Text + "', '" + ComboBoxDept.Text + "', '" + txtFName.Text + "', '" + txtLname.Text + "','" + txtaddress.Text + "', '" + txtcity.Text + "', '" + txtpincode.Text + "', '" + gender + "','" + txtMobileno.Text + "', '" + txtEmailid.Text + "', '" + DateTimePicker1.Text + "')", con)

                con = cmd.Connection

                cmd.ExecuteNonQuery()

                MsgBox("Customer " + txtFName.Text + " Registration Sucessfully.... ")

                GetRegisterID()

                reset()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No Data Inserted..")
        End If

        con.Close()



    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RdbtnMale.Checked = True
        GetRegisterID()
    End Sub

    Private Sub lblregform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtRegisterID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRegisterID.KeyPress
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

    Private Sub txtFName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFName.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub

    Private Sub txtLname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLname.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only Alphabets are allowed")
        End If
    End Sub

    Private Sub txtcity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcity.TextChanged

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