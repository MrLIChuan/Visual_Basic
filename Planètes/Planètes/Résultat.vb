Public Class frmResultats
    Private Sub frmResultats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblXgRslt.Text = sngXg
        lblYgRslt.Text = sngYg

        lblMasseMax.Text = sngMasseMax
        lblMasseMin.Text = sngMasseMin

        lblAbscMax.Text = sngXmax
        lblAbscMin.Text = sngXmin

        lblOrdMax.Text = sngYmax
        lblOrdMin.Text = sngYmin

        For i = 1 To intNbrPoint
            ComboBox1.Items.Add("X = " & txtX(i).Text & "   Y = " & txtY(i).Text & "   M = " & txtM(i).Text & vbCrLf)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmGraph.Show()
    End Sub
End Class