Public Class BookPage

    Private Sub btnAddBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBook.Click
        AddBook.Show()
    End Sub

    Private Sub btnViewBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewBook.Click
        ViewBook.Show()
    End Sub

    Private Sub btnBookIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookIssue.Click
        Issue_Book.Show()
    End Sub

    Private Sub btnBookReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookReturn.Click
        Return_Book.Show()
    End Sub

    Private Sub PanelBookPage_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelBookPage.Paint

    End Sub
End Class