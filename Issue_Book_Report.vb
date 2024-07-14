Public Class Issue_Book_Report

    Private Sub Issue_Book_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Issue_Book_DataSet.Issue_Book' table. You can move, or remove it, as needed.
        Me.Issue_BookTableAdapter.Fill(Me.Issue_Book_DataSet.Issue_Book)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ReportPage.Show()
    End Sub
End Class