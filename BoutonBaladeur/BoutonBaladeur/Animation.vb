Public Class frmAnimation
    Dim cmdMe(21) As Button

    Private Sub frmAnimation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        For i = 1 To 21
            cmdMe(i) = pnlAnimation.Controls("Button" & i)
            cmdMe(i).Visible = False
        Next

        cmdMe(1).Visible = True

        For Each x As Button In pnlAnimation.Controls
            AddHandler x.MouseMove, AddressOf BoutonBaladeur


        Next

    End Sub

    Private Sub BoutonBaladeur(ByVal sender As Object, ByVal e As System.EventArgs)



        Dim k As Byte

        Randomize()
        sender.visible = False
        k = Int(Rnd() * 21) + 1
        cmdMe(k).Visible = True

    End Sub


    Private Sub pnlAnimation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlAnimation.Enter

    End Sub
End Class
