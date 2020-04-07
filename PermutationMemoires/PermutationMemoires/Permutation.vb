Public Class frmPermutation
    Dim X, Y As String
    Private Sub cmdCopie_Click(sender As System.Object, e As System.EventArgs) Handles cmdCopie.Click
        X = txtMemoire1.Text
        Y = txtMemoire2.Text
        MsgBox("Copie effectué", MsgBoxStyle.OkOnly, "Permutation")
    End Sub

    Private Sub cmdPermute_Click(sender As System.Object, e As System.EventArgs) Handles cmdPermute.Click
        Dim Z As String
        Z = X
        X = Y
        Y = Z
        lblMemoire1.Text = X
        lblMemoire2.Text = Y
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
