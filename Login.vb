Imports System.Data.SqlClient
Imports System.Data
Public Class Login
    '  Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataReader



    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click

        If txtunm.Text = "" Or txtpwd.Text = "" Then

            MsgBox("Enter UserName and Password")

        ElseIf txtunm.Text = "jigar" And txtpwd.Text = "2003" Then

            Dim Obj = New Progress
            Obj.Show()
            Me.Hide()
            txtpwd.Text = ""
            txtunm.Text = ""

        Else

            MsgBox("Wrong UserName and Password")
            txtunm.Text = ""
            txtpwd.Text = ""
        End If
    End Sub

    Private Sub CheckBoxPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxPassword.CheckedChanged
        If CheckBoxPassword.Checked = True Then

            txtpwd.UseSystemPasswordChar = False

        Else

            txtpwd.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub txtpwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpwd.TextChanged

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblpwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblpwd.Click

    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
