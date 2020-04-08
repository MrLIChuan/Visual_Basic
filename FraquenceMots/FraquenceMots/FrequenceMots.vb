Public Class frmFrequenceMots

    Private Sub cmdCharger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCharger.Click

        txtDocument.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Sartre.txt")
    End Sub

    Private Sub cmdFrequence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFrequence.Click

        Dim n, p, c As Integer
        n = txtDocument.Text.Length
        p = txtMotCherche.Text.Length
        c = 0

        For k = 0 To n - p
            If txtDocument.Text.Substring(k, p) = txtMotCherche.Text Then

                c = c + 1

            End If
        Next

        lblFrequence.Text = c

    End Sub

    Private Sub cmdRemplacer_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemplacer.Click


        txtDocument.Text = txtDocument.Text.Replace(txtMotCherche.Text, txtMotRemplacement.Text)

    End Sub

    Private Sub cmdQuitter_Click(sender As System.Object, e As System.EventArgs) Handles cmdQuitter.Click
        End
    End Sub
End Class
