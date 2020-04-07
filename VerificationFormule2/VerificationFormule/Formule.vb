Public Class frmFormule
    Dim n As Integer
    Private Sub cmdSaisie_Click(sender As System.Object, e As System.EventArgs) Handles cmdSaisie.Click
        n = CInt(InputBox("Saisir un nombre entier n", "Verification formule"))
        lblEntierSaisi.Text = "Entier Saisi : " & n
        MsgBox("Saisie effectuée", MsgBoxStyle.OkOnly, "Verification formule")

    End Sub

    Private Sub cmdCalculs_Click(sender As System.Object, e As System.EventArgs) Handles cmdCalculs.Click
        Dim S, T As Integer
        S = 0
        For k = 1 To n
            S = S + k * k
        Next
        T = n * (n + 1) * (2 * n + 1) / 6
        lblSomme.Text = S
        lblProduit.Text = T
    End Sub

    Private Sub cmdFin_Click(sender As System.Object, e As System.EventArgs) Handles cmdFin.Click
        End
    End Sub
End Class
