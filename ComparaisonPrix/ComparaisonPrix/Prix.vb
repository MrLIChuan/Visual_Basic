Public Class frmPrix
    Dim lblMoyArticle(7), lblMoyMagasin(5) As Label
    Dim txtPrix(7, 5) As TextBox
    Dim intNbArticles, intNbMagasins As Integer
    Dim sngPrix(7, 5), sngMoyMagasin(5) As Single

    Private Sub frmPrix_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For i = 1 To 7
            For j = 1 To 5
                txtPrix(i, j) = gbPrix.Controls("TextBox" & 5 * (i - 1) + j)
            Next
        Next

        For j = 1 To 5
            lblMoyMagasin(j) = gbMoyMagasin.Controls("Label" & j + 7)

        Next

        For i = 1 To 7
            lblMoyArticle(i) = gbMoyArticles.Controls("Label" & i)
        Next

    End Sub

    Private Sub cmdSaisie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaisie.Click

        intNbArticles = CInt(txtArticles.Text)
        intNbMagasins = CInt(txtMagasins.Text)

        For i = 1 To 7
            For j = 1 To 5
                txtPrix(i, j).Visible = False
                lblMoyArticle(i).Visible = False
                lblMoyMagasin(j).Visible = False
            Next
        Next

        For i = 1 To intNbArticles
            For j = 1 To intNbMagasins
                txtPrix(i, j).Visible = True
                lblMoyArticle(i).Visible = True
                lblMoyMagasin(j).Visible = True
            Next
        Next

    End Sub

    Private Sub cmdCalculs_Click(sender As System.Object, e As System.EventArgs) Handles cmdCalculs.Click
        Dim S As Integer

        For i = 1 To intNbArticles
            For j = 1 To intNbMagasins
                sngPrix(i, j) = CSng(txtPrix(i, j).Text)
            Next
        Next

        For i = 1 To intNbArticles
            S = 0
            For j = 1 To intNbMagasins

                S = S + sngPrix(i, j)
            Next
            lblMoyArticle(i).Text = S / intNbMagasins

        Next

        For j = 1 To intNbMagasins
            S = 0
            For i = 1 To intNbArticles

                S = S + sngPrix(i, j)
            Next
            lblMoyMagasin(j).Text = S / intNbArticles
            sngMoyMagasin(j) = S / intNbArticles
        Next

        S = 0
        For i = 1 To intNbArticles
            For j = 1 To intNbMagasins
                S = S + sngPrix(i, j)
            Next

        Next
        lblMoyGenerale.Text = S / (intNbArticles * intNbMagasins)

    End Sub

    Private Sub cmdEnd_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnd.Click
        End
    End Sub

   
    Private Sub cmgMagMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmgMagMax.Click
        Dim intMax, MagMax As Integer
        intNbMagasins = txtMagasins.Text
        MagMax = 1

        For i = 1 To intNbArticles
            For j = 1 To intNbMagasins
                txtPrix(i, j).BackColor = Color.White
                lblMoyMagasin(j).BackColor = Color.White
            Next
        Next

        For j = 1 To intNbMagasins
            If sngMoyMagasin(j) > MagMax Then
                MagMax = sngMoyMagasin(j)
                intMax = j
            End If
        Next

        For i = 1 To intNbArticles
            txtPrix(i, intMax).BackColor = Color.Red
            lblMoyMagasin(intMax).BackColor = Color.Red
        Next
    End Sub

    Private Sub cmdArticleMoins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdArticleMoins.Click
        Dim intMinJ, i, intArtMin As Integer
        intNbArticles = txtArticles.Text
        intNbMagasins = txtMagasins.Text


        For i = 1 To intNbArticles
            For j = 1 To intNbMagasins
                txtPrix(i, j).BackColor = Color.White
            Next
        Next


        i = 0
        Do
            intArtMin = 1000
            i = i + 1
            For j = 1 To intNbMagasins
                If sngPrix(i, j) < intArtMin Then
                    intArtMin = sngPrix(i, j)
                    intMinJ = j
                End If
            Next
            txtPrix(i, intMinJ).BackColor = Color.Green
        Loop While i < intNbArticles




    End Sub
End Class
