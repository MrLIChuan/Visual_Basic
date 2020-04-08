Public Class frmAccueil
    Private Sub frmAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If optNewFile.Checked = True Then
            Me.Hide()
            frmSaisie.Show()
        ElseIf optOpen.Checked = True Then
            System.Diagnostics.Process.Start("explorer.exe")
        Else
            End
        End If


    End Sub
End Class
