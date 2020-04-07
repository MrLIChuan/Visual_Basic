Public Class frmAnimation
    Dim X, n As String
    Private Sub txtChaine1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cmdPermute_Click(sender As System.Object, e As System.EventArgs) Handles cmdPermute.Click

        X = txtChaine1.Text
        txtChaine1.Text = txtChaine2.Text
        txtChaine2.Text = X
    End Sub

    Private Sub cmdEfface_Click(sender As System.Object, e As System.EventArgs) Handles cmdEfface.Click
        txtChaine1.Text = ""
        txtChaine2.Text = ""
    End Sub

    Private Sub cmdFin_Click(sender As System.Object, e As System.EventArgs) Handles cmdFin.Click
        End
    End Sub

    Private Sub tmrClignote_Tick(sender As System.Object, e As System.EventArgs) Handles tmrClignote.Tick
        If (lblChaine1.BackColor = Color.Red) Then
            lblChaine1.BackColor = Color.Green
            lblChaine2.BackColor = Color.Red

        Else

            lblChaine1.BackColor = Color.Red
            lblChaine2.BackColor = Color.Green
        End If
    End Sub

    Private Sub tmeDefilement_Tick(sender As System.Object, e As System.EventArgs) Handles tmeDefilement.Tick
        X = lblChaine1.Text
        n = lblChaine1.Text.Length

        lblChaine1.Text = X.Substring(n - 1, 1) & X.Substring(0, n - 1)

        X = lblChaine2.Text
        n = lblChaine2.Text.Length

        lblChaine2.Text = X.Substring(1, n - 1) & X.Substring(0, 1)
        
    End Sub

    Private Sub frmAnimation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblChaine2_Click(sender As System.Object, e As System.EventArgs) Handles lblChaine2.Click

    End Sub
End Class
