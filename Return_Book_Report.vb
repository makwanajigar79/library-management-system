Public Class Return_Book_Report

    Private Sub Return_Book_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Return_Book_DataSet.Return_Book_TB' table. You can move, or remove it, as needed.
        Me.Return_Book_TBTableAdapter.Fill(Me.Return_Book_DataSet.Return_Book_TB)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        ReportPage.Show()
    End Sub
End Class