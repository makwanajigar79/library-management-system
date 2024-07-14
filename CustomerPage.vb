Public Class CustomerPage

    Private Sub btnAddCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateCustomer.Click
        Me.Hide()
        Update_Customer.Show()
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenaltyStatus.Click
        Me.Hide()
        Add_Customer.Show()
    End Sub

    Private Sub PanelcustomerPage_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelcustomerPage.Paint

    End Sub

    Private Sub btnDeleteCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCustomer.Click
        Me.Hide()
        DeleteCustomer.Show()
    End Sub

    Private Sub btnViewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCustomer.Click
        Me.Hide()
        ViewCustomer.Show()
    End Sub
End Class