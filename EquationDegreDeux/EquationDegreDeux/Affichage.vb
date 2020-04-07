Public Class frmAffichage

   

    Private Sub Affichage_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

        lblDelta.Text = D

        If (D >= 0) Then
            lblSigneDelta.Text = "+"
            lblSolution1.Text = X1
            lblSolution2.Text = X2

        Else
            lblSigneDelta.Text = "-"
            lblSolution1.Text = X1 & "+j" & X2
            lblSolution2.Text = X1 & "-j" & X2

        End If
    End Sub


    Private Sub cmdSaisie_Click(sender As System.Object, e As System.EventArgs) Handles cmdSaisie.Click
        Me.Hide()
        frmSaisie.Show()
    End Sub

    Private Sub cmdQuitter_Click(sender As System.Object, e As System.EventArgs) Handles cmdQuitter.Click
        End
    End Sub

   

   
End Class