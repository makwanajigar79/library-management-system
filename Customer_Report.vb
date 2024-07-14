Public Class Customer_Report

    Private Sub Customer_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Customer_Report_DataSet.Register_TB' table. You can move, or remove it, as needed.
        Me.Register_TBTableAdapter.Fill(Me.Customer_Report_DataSet.Register_TB)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ReportPage.Show()
    End Sub
End Class