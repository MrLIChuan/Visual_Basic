Public Class frmAffichage
    Private Sub cmdCalcul_Click(sender As Object, e As EventArgs) Handles cmdCalcul.Click
        Dim intNumVol, X, Xmax, X1, intAdresse As Integer


        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Syracuse-Vol-500.nic") Then
            MsgBox("File found.")

            intNumVol = txtNumVol.Text
            intAdresse = 1

            FileGet(intNumVol, X, intAdresse)
            txtVol.Text = X
            X1 = txtVol.Text

            Do
                intAdresse = intAdresse + 1
                FileGet(intNumVol, X, intAdresse)
                txtVol.Text = txtVol.Text & vbCrLf & X

                If X > Xmax Then
                    Xmax = X

                End If
            Loop Until X = 1

            lblFlyTime.Text = intAdresse
            lblAltMax.Text = Xmax
            lblFacExp.Text = Xmax / X1

        Else

            MsgBox("File not found.")

        End If

    End Sub

    Private Sub cmdEnd_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click
        End
    End Sub
End Class