Public Class frmEcriture
    Dim Y As Boolean

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Y = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Y = True
    End Sub

    Private Sub cmdEcriture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEcriture.Click
        Dim X As String
        X = txtBox1.Text
        My.Computer.FileSystem.WriteAllText("C:\Users\TEMP.ETUD.001\Desktop\FichiersSequentiels" & "\Fichier.txt", X, Y)


    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        frmLecture.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub txtBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBox1.TextChanged

    End Sub
End Class
