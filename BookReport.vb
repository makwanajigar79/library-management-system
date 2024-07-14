Public Class BookReport

    Private Sub BookReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Book_DataSet.Book_TB' table. You can move, or remove it, as needed.
        Me.Book_TBTableAdapter.Fill(Me.Book_DataSet.Book_TB)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ReportPage.Show()
    End Sub
End Class