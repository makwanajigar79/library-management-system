Public Class Penalty_Report

    Private Sub Penalty_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Penalty_Report_DataSet.panalty_TB' table. You can move, or remove it, as needed.
        Me.panalty_TBTableAdapter.Fill(Me.Penalty_Report_DataSet.panalty_TB)
        'TODO: This line of code loads data into the 'Book_DataSet.Book_TB' table. You can move, or remove it, as needed.
        Me.Book_TBTableAdapter.Fill(Me.Book_DataSet.Book_TB)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class