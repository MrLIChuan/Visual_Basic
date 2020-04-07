<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAffichage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdSaisie = New System.Windows.Forms.Button()
        Me.cmdQuitter = New System.Windows.Forms.Button()
        Me.lblSolution1 = New System.Windows.Forms.Label()
        Me.lblSolution2 = New System.Windows.Forms.Label()
        Me.lblDelta = New System.Windows.Forms.Label()
        Me.lblSigneDelta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solution 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Signe Delta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Valeur Delta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Solution 2"
        '
        'cmdSaisie
        '
        Me.cmdSaisie.Location = New System.Drawing.Point(268, 122)
        Me.cmdSaisie.Name = "cmdSaisie"
        Me.cmdSaisie.Size = New System.Drawing.Size(115, 23)
        Me.cmdSaisie.TabIndex = 5
        Me.cmdSaisie.Text = "Retour feuille saisie"
        Me.cmdSaisie.UseVisualStyleBackColor = True
        '
        'cmdQuitter
        '
        Me.cmdQuitter.Location = New System.Drawing.Point(268, 184)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(75, 23)
        Me.cmdQuitter.TabIndex = 6
        Me.cmdQuitter.Text = "Quitter"
        Me.cmdQuitter.UseVisualStyleBackColor = True
        '
        'lblSolution1
        '
        Me.lblSolution1.BackColor = System.Drawing.SystemColors.Control
        Me.lblSolution1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolution1.Location = New System.Drawing.Point(123, 122)
        Me.lblSolution1.Name = "lblSolution1"
        Me.lblSolution1.Size = New System.Drawing.Size(139, 23)
        Me.lblSolution1.TabIndex = 7
        '
        'lblSolution2
        '
        Me.lblSolution2.BackColor = System.Drawing.SystemColors.Control
        Me.lblSolution2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolution2.Location = New System.Drawing.Point(123, 184)
        Me.lblSolution2.Name = "lblSolution2"
        Me.lblSolution2.Size = New System.Drawing.Size(139, 23)
        Me.lblSolution2.TabIndex = 8
        '
        'lblDelta
        '
        Me.lblDelta.BackColor = System.Drawing.SystemColors.Control
        Me.lblDelta.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelta.Location = New System.Drawing.Point(123, 52)
        Me.lblDelta.Name = "lblDelta"
        Me.lblDelta.Size = New System.Drawing.Size(79, 23)
        Me.lblDelta.TabIndex = 9
        '
        'lblSigneDelta
        '
        Me.lblSigneDelta.BackColor = System.Drawing.SystemColors.Control
        Me.lblSigneDelta.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigneDelta.Location = New System.Drawing.Point(265, 52)
        Me.lblSigneDelta.Name = "lblSigneDelta"
        Me.lblSigneDelta.Size = New System.Drawing.Size(79, 23)
        Me.lblSigneDelta.TabIndex = 10
        '
        'frmAffichage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(454, 329)
        Me.Controls.Add(Me.lblSigneDelta)
        Me.Controls.Add(Me.lblDelta)
        Me.Controls.Add(Me.lblSolution2)
        Me.Controls.Add(Me.lblSolution1)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.cmdSaisie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAffichage"
        Me.Text = "Affichage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdSaisie As System.Windows.Forms.Button
    Friend WithEvents cmdQuitter As System.Windows.Forms.Button
    Friend WithEvents lblSolution1 As System.Windows.Forms.Label
    Friend WithEvents lblSolution2 As System.Windows.Forms.Label
    Friend WithEvents lblDelta As System.Windows.Forms.Label
    Friend WithEvents lblSigneDelta As System.Windows.Forms.Label
End Class
