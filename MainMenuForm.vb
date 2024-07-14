Public Class MainMenuForm

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Login.Show()
    End Sub

    Private Sub AddBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddBook.Show()
    End Sub

   
    Private Sub CheckPenaltyStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Penalty_Form.Show()
    End Sub

    Private Sub IssueBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Issue_Book.Show()
    End Sub

    Private Sub ReturnBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Return_Book.Show()
    End Sub

    Private Sub AddUpdateDeleteStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Update_Customer.Show()

    End Sub

    Private Sub btnBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBook.Click
        With BookPage
            .TopLevel = False
            PanelMainMenu.Controls.Add(BookPage)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        Progress.Close()
        Login.Show()
    End Sub

   

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        With CustomerPage
            .TopLevel = False
            PanelMainMenu.Controls.Add(CustomerPage)
            .BringToFront()
            .Show()
        End With
    End Sub

    

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        With ReportPage
            .TopLevel = False
            PanelMainMenu.Controls.Add(ReportPage)
            .BringToFront()
            .Show()
        End With
    End Sub
  
    Private Sub MainMenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Progress.Close()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnPenalty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenalty.Click
        With PenaltyPage
            .TopLevel = False
            PanelMainMenu.Controls.Add(PenaltyPage)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class