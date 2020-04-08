Public Class frmTri

    Dim txtSaisie(10) As TextBox
    Dim lblAffichage(10) As Label
    Dim lblRang(10) As Label
    Dim X(10) As Integer




    Private Sub Toto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For i = 1 To 10

            txtSaisie(i) = gbSaisie.Controls("TextBox" & i)

            lblRang(i) = gbRang.Controls("Label" & i)

            lblAffichage(i) = gbAffichage.Controls("Label" & i + 10)

        Next



    End Sub



    Private Sub optAuto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optAuto.CheckedChanged

        
        For i = 1 To 10
            If optAuto.Checked Then
                txtSaisie(i).Text = Int(Rnd() * 20)
            Else
                txtSaisie(i).Text = ""
            End If
        Next
    End Sub

    Private Sub cmdSaisie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaisie.Click


        For i = 1 To 10
            X(i) = CInt(txtSaisie(i).Text)

            lblRang(i).Text = 1
        Next
        For i = 1 To 10
            For j = 1 To 10
                If X(i) < X(j) Then
                    lblRang(i).Text = lblRang(i).Text + 1
                End If
            Next

        Next
        For i = 1 To 10
            lblAffichage(i).Text = X(i)
        Next
    End Sub

    Private Sub cmdTri_Click(sender As System.Object, e As System.EventArgs) Handles cmdTri.Click

        Dim K, S As Integer

        K = 1
        While K = 1
            K = 0
            For i = 2 To 10
                If optTriCroissant.Checked Then
                    If X(i - 1) > X(i) Then
                        S = X(i)
                        X(i) = X(i - 1)
                        X(i - 1) = S
                        K = 1
                    End If


                ElseIf X(i - 1) < X(i) Then
                    S = X(i)
                    X(i) = X(i - 1)
                    X(i - 1) = S
                    K = 1

                End If


            Next
        End While

        For i = 1 To 10
            lblAffichage(i).Text = X(i)
        Next

    End Sub

    Private Sub cmdQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitter.Click
        End
    End Sub

End Class
