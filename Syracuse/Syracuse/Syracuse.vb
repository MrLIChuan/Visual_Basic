Public Class frmSyracuse

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles cmdCalcul.Click
        Dim X, X1, Xmax, C As Integer


        X = txtNumVol.Text
        txtVol.Text = X
        C = 1
        Xmax = X
        X1 = X

        FileOpen(1, Application.StartupPath & "\Syracuse-Vol-500.nic", OpenMode.Random)
        FilePut(1, X, 1)

        Do
            If X Mod (2) = 0 Then
                X = X / 2
            Else
                X = 3 * X + 1
            End If

            txtVol.Text = txtVol.Text & vbCrLf & X
            C = C + 1
            FilePut(1, X, C)

            If X > Xmax Then
                Xmax = X

            End If

        Loop Until X = 1

        lblFlyTime.Text = C
        lblAltMax.Text = Xmax
        lblFacExp.Text = Xmax / X1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdVolRec.Click
        Me.Hide()
        frmAffichage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click
        End
    End Sub
End Class
