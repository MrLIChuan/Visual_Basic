Public Class frmFactorielle
    Private Sub cmdCalcul_Click(sender As Object, e As EventArgs) Handles cmdCalcul.Click
        n = TxtValN.Text

        txtFactN.Text = Fact(n)
    End Sub
End Class
