Public Class MoyenneNombres

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdSaisie_Click(sender As System.Object, e As System.EventArgs) Handles cmdSaisie.Click

        Dim x, s, c, m As Integer
        s = 0
        c = 0

        Do
            x = CSng(InputBox("Saisir un nombre entier x", "Verification formule"))
            s = s + x
            c = c + 1

        Loop Until x = 0

        m = s / (c - 1)

        lblResultat.Text = m

    End Sub

    Private Sub cmdQuitter_Click(sender As System.Object, e As System.EventArgs) Handles cmdQuitter.Click
        End
    End Sub
End Class
