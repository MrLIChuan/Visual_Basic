<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisie
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdQuitter = New System.Windows.Forms.Button()
        Me.cmdAffichage = New System.Windows.Forms.Button()
        Me.cmdCalculs = New System.Windows.Forms.Button()
        Me.cmdSaisie = New System.Windows.Forms.Button()
        Me.txtSaisieC = New System.Windows.Forms.TextBox()
        Me.txtSaisieB = New System.Windows.Forms.TextBox()
        Me.txtSaisieA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdQuitter
        '
        Me.cmdQuitter.Location = New System.Drawing.Point(169, 263)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(75, 23)
        Me.cmdQuitter.TabIndex = 19
        Me.cmdQuitter.Text = "Quitter"
        Me.cmdQuitter.UseVisualStyleBackColor = True
        '
        'cmdAffichage
        '
        Me.cmdAffichage.Location = New System.Drawing.Point(125, 206)
        Me.cmdAffichage.Name = "cmdAffichage"
        Me.cmdAffichage.Size = New System.Drawing.Size(165, 28)
        Me.cmdAffichage.TabIndex = 18
        Me.cmdAffichage.Text = "Affichage Resultats"
        Me.cmdAffichage.UseVisualStyleBackColor = True
        '
        'cmdCalculs
        '
        Me.cmdCalculs.Location = New System.Drawing.Point(169, 150)
        Me.cmdCalculs.Name = "cmdCalculs"
        Me.cmdCalculs.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculs.TabIndex = 17
        Me.cmdCalculs.Text = "Calculs"
        Me.cmdCalculs.UseVisualStyleBackColor = True
        '
        'cmdSaisie
        '
        Me.cmdSaisie.Location = New System.Drawing.Point(169, 101)
        Me.cmdSaisie.Name = "cmdSaisie"
        Me.cmdSaisie.Size = New System.Drawing.Size(75, 23)
        Me.cmdSaisie.TabIndex = 16
        Me.cmdSaisie.Text = "Copie RAM"
        Me.cmdSaisie.UseVisualStyleBackColor = True
        '
        'txtSaisieC
        '
        Me.txtSaisieC.Location = New System.Drawing.Point(283, 59)
        Me.txtSaisieC.Name = "txtSaisieC"
        Me.txtSaisieC.Size = New System.Drawing.Size(100, 20)
        Me.txtSaisieC.TabIndex = 15
        '
        'txtSaisieB
        '
        Me.txtSaisieB.Location = New System.Drawing.Point(163, 59)
        Me.txtSaisieB.Name = "txtSaisieB"
        Me.txtSaisieB.Size = New System.Drawing.Size(100, 20)
        Me.txtSaisieB.TabIndex = 14
        '
        'txtSaisieA
        '
        Me.txtSaisieA.Location = New System.Drawing.Point(40, 59)
        Me.txtSaisieA.Name = "txtSaisieA"
        Me.txtSaisieA.Size = New System.Drawing.Size(100, 20)
        Me.txtSaisieA.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Coefficent c"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Coefficent b"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Coefficent a"
        '
        'frmSaisie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(426, 341)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.cmdAffichage)
        Me.Controls.Add(Me.cmdCalculs)
        Me.Controls.Add(Me.cmdSaisie)
        Me.Controls.Add(Me.txtSaisieC)
        Me.Controls.Add(Me.txtSaisieB)
        Me.Controls.Add(Me.txtSaisieA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSaisie"
        Me.Text = "Saisie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdQuitter As System.Windows.Forms.Button
    Friend WithEvents cmdAffichage As System.Windows.Forms.Button
    Friend WithEvents cmdCalculs As System.Windows.Forms.Button
    Friend WithEvents cmdSaisie As System.Windows.Forms.Button
    Friend WithEvents txtSaisieC As System.Windows.Forms.TextBox
    Friend WithEvents txtSaisieB As System.Windows.Forms.TextBox
    Friend WithEvents txtSaisieA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
