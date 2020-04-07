Public Class frmSaisie
    Dim a, b, c As Single
    Private Sub cmdSaisie_Click(sender As System.Object, e As System.EventArgs) Handles cmdSaisie.Click
        a = CSng(txtSaisieA.Text)
        If (a = 0) Then
            MsgBox(txtSaisieA.Text = "a doit être non nul")
            txtSaisieA.Text = "a doit être non nul"
            txtSaisieA.Focus()
            Exit Sub
        End If
        b = CSng(txtSaisieB.Text)
        c = CSng(txtSaisieC.Text)

        

    End Sub

    Private Sub cmdCalculs_Click(sender As System.Object, e As System.EventArgs) Handles cmdCalculs.Click
        D = (b * b) - (4 * a * c)
        If (D >= 0) Then
            X1 = (-b + Math.Sqrt(D)) / (2 * a)
            X2 = (-b - Math.Sqrt(D)) / (2 * a)

        Else
            X1 = -b / (2 * a)
            X2 = Math.Sqrt(-D) / (2 * a)

            If X2 < 0 Then
                X2 = -X2
            End If

            End If
    End Sub

    Private Sub cmdAffichage_Click(sender As System.Object, e As System.EventArgs) Handles cmdAffichage.Click
        Me.Hide()
        frmAffichage.Show()
    End Sub

    Private Sub cmdQuitter_Click(sender As System.Object, e As System.EventArgs) Handles cmdQuitter.Click
        End
    End Sub

    Private Sub frmSaisie_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
