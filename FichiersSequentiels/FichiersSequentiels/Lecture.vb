Public Class frmLecture

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        lblLecture.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Fichier.txt")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        frmEcriture.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub lblLecture_Click(sender As System.Object, e As System.EventArgs) Handles lblLecture.Click

    End Sub
End Class