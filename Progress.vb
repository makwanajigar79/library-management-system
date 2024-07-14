Public Class Progress

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Enabled = False
            MainMenuForm.Show()
            Me.Close()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 10
        End If

    End Sub

   
    Private Sub Progress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Enabled = True

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class