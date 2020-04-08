Public Class frmSaisie
    


    Private Sub cmdResultats_Click(sender As Object, e As EventArgs) Handles cmdResultats.Click


        For i = 1 To intNbrPoint 'Condition paramétrique de X
            If CSng(txtX(i).Text) < -20 Then
                MsgBox("Veuillez entrer une valeur comprise entre -20 et 20 pour X")
            End If
        Next
        For i = 1 To intNbrPoint
            If CSng(txtX(i).Text) > 20 Then
                MsgBox("Veuillez entrer une valeur comprise entre -20 et 20 pour X")
            End If
        Next

        For i = 1 To intNbrPoint 'Condition paramétrique de Y
            If CSng(txtY(i).Text) < -20 Then
                MsgBox("Veuillez entrer une valeur comprise entre -20 et 20 pour Y")
            End If
        Next
        For i = 1 To intNbrPoint
            If CSng(txtY(i).Text) > 20 Then
                MsgBox("Veuillez entrer une valeur comprise entre -20 et 20 pour Y")
            End If
        Next

        For i = 1 To intNbrPoint 'Condition paramétrique de M
            If CSng(txtM(i).Text) < 0 Then
                MsgBox("Veuillez entrer une valeur comprise entre 0 et 10 pour M")
            End If
        Next
        For i = 1 To intNbrPoint
            If CSng(txtM(i).Text) > 10 Then
                MsgBox("Veuillez entrer une valeur comprise entre 0 et 10 pour M")
            End If
        Next


            sngMg = 0 'Somme des masses
        For i = 1 To intNbrPoint
            sngMg = sngMg + CSng(txtM(i).Text)
        Next

        sngXg = 0 'Calcul de la coordonné X du centre de gravité
        For i = 1 To intNbrPoint
            sngXg = sngXg + (CSng(txtM(i).Text) * CSng(txtX(i).Text))
        Next
        sngXg = sngXg / sngMg

        sngYg = 0 'Calcul de la coordonné Y du centre de gravité
        For i = 1 To intNbrPoint
            sngYg = sngYg + (CSng(txtM(i).Text) * CSng(txtY(i).Text))
        Next
        sngYg = sngYg / sngMg

        sngMasseMax = 0 'Calcul de la masse maximum
        For i = 1 To intNbrPoint
            If CSng(txtM(i).Text) > sngMasseMax Then
                sngMasseMax = CSng(txtM(i).Text)
            End If
        Next

        sngMasseMin = 10 'Calcul de la masse minimum
        For i = 1 To intNbrPoint
            If CSng(txtM(i).Text) < sngMasseMin Then
                sngMasseMin = CSng(txtM(i).Text)
            End If
        Next

        sngXmax = -20 ' Calcul de l'abscisse maximum
        For i = 1 To intNbrPoint
            If CSng(txtX(i).Text) > sngXmax Then
                sngXmax = CSng(txtX(i).Text)
            End If
        Next

        sngXmin = 20 ' Calcul de l'abscisse minimum
        For i = 1 To intNbrPoint
            If CSng(txtX(i).Text) < sngXmin Then
                sngXmin = CSng(txtX(i).Text)
            End If
        Next

        sngYmax = -20 ' Calcul de l'ordonnée maximum
        For i = 1 To intNbrPoint
            If CSng(txtY(i).Text) > sngYmax Then
                sngYmax = CSng(txtY(i).Text)
            End If
        Next

        sngYmin = 20 ' Calcul de l'ordonnée minimum
        For i = 1 To intNbrPoint
            If CSng(txtY(i).Text) < sngYmin Then
                sngYmin = CSng(txtY(i).Text)
            End If
        Next

        Me.Hide()
        frmResultats.Show()
    End Sub

    Private Sub cmdValeurN_Click(sender As Object, e As EventArgs) Handles cmdValeurN.Click
        intNbrPoint = CInt(NumericUpDown1.Text) 'Séléction du nombre de point

        For i = 1 To 10
                txtX(i).Visible = False
                txtY(i).Visible = False
                txtM(i).Visible = False
            Next

        For i = 1 To intNbrPoint
                txtX(i).Visible = True
                txtY(i).Visible = True
                txtM(i).Visible = True
            Next

    End Sub

    Private Sub frmSaisie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Indexation des différentes TextBox (masse, X et Y)
        For i = 1 To 10
            txtX(i) = gbAxeX.Controls("TextBox" & i)
        Next

        For i = 1 To 10
            txtY(i) = gbAxeY.Controls("TextBox" & i + 10)
        Next

        For i = 1 To 10
            txtM(i) = gbMasseM.Controls("TextBox" & i + 20)
        Next

    End Sub
End Class