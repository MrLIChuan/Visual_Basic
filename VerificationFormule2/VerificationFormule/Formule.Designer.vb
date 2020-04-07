<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormule
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
        Me.lblEntierSaisi = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSomme = New System.Windows.Forms.Label()
        Me.lblProduit = New System.Windows.Forms.Label()
        Me.cmdSaisie = New System.Windows.Forms.Button()
        Me.cmdCalculs = New System.Windows.Forms.Button()
        Me.cmdFin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEntierSaisi
        '
        Me.lblEntierSaisi.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblEntierSaisi.Location = New System.Drawing.Point(145, 89)
        Me.lblEntierSaisi.Name = "lblEntierSaisi"
        Me.lblEntierSaisi.Size = New System.Drawing.Size(100, 32)
        Me.lblEntierSaisi.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valeur de la somme"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valeur du produit"
        '
        'lblSomme
        '
        Me.lblSomme.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSomme.Location = New System.Drawing.Point(21, 233)
        Me.lblSomme.Name = "lblSomme"
        Me.lblSomme.Size = New System.Drawing.Size(100, 40)
        Me.lblSomme.TabIndex = 3
        '
        'lblProduit
        '
        Me.lblProduit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblProduit.Location = New System.Drawing.Point(256, 233)
        Me.lblProduit.Name = "lblProduit"
        Me.lblProduit.Size = New System.Drawing.Size(100, 40)
        Me.lblProduit.TabIndex = 4
        '
        'cmdSaisie
        '
        Me.cmdSaisie.Location = New System.Drawing.Point(148, 49)
        Me.cmdSaisie.Name = "cmdSaisie"
        Me.cmdSaisie.Size = New System.Drawing.Size(97, 37)
        Me.cmdSaisie.TabIndex = 5
        Me.cmdSaisie.Text = "Saisie"
        Me.cmdSaisie.UseVisualStyleBackColor = True
        '
        'cmdCalculs
        '
        Me.cmdCalculs.Location = New System.Drawing.Point(148, 146)
        Me.cmdCalculs.Name = "cmdCalculs"
        Me.cmdCalculs.Size = New System.Drawing.Size(97, 31)
        Me.cmdCalculs.TabIndex = 6
        Me.cmdCalculs.Text = "Calculs"
        Me.cmdCalculs.UseVisualStyleBackColor = True
        '
        'cmdFin
        '
        Me.cmdFin.Location = New System.Drawing.Point(24, 305)
        Me.cmdFin.Name = "cmdFin"
        Me.cmdFin.Size = New System.Drawing.Size(332, 35)
        Me.cmdFin.TabIndex = 7
        Me.cmdFin.Text = "Quitter"
        Me.cmdFin.UseVisualStyleBackColor = True
        '
        'frmFormule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(378, 373)
        Me.Controls.Add(Me.cmdFin)
        Me.Controls.Add(Me.cmdCalculs)
        Me.Controls.Add(Me.cmdSaisie)
        Me.Controls.Add(Me.lblProduit)
        Me.Controls.Add(Me.lblSomme)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblEntierSaisi)
        Me.Name = "frmFormule"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEntierSaisi As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSomme As System.Windows.Forms.Label
    Friend WithEvents lblProduit As System.Windows.Forms.Label
    Friend WithEvents cmdSaisie As System.Windows.Forms.Button
    Friend WithEvents cmdCalculs As System.Windows.Forms.Button
    Friend WithEvents cmdFin As System.Windows.Forms.Button

End Class
