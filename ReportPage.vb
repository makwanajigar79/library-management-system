Public Class ReportPage

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnBookReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookReport.Click
        Me.Hide()
        BookReport.Show()
    End Sub

    Private Sub btnCustomerReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerReport.Click
        Me.Hide()
        Customer_Report.Show()

    End Sub

    Private Sub BTNIssueBookReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNIssueBookReport.Click
        Me.Hide()
        Issue_Book_Report.Show()
    End Sub

    Private Sub BTNRturnBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRturnBook.Click
        Me.Hide()
        Return_Book_Report.Show()
    End Sub
End Class