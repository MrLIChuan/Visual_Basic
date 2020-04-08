<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoyenneNombres
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResultat = New System.Windows.Forms.Label()
        Me.cmdSaisie = New System.Windows.Forms.Button()
        Me.cmdQuitter = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Moyenne"
        '
        'lblResultat
        '
        Me.lblResultat.BackColor = System.Drawing.Color.White
        Me.lblResultat.Location = New System.Drawing.Point(184, 203)
        Me.lblResultat.Name = "lblResultat"
        Me.lblResultat.Size = New System.Drawing.Size(139, 71)
        Me.lblResultat.TabIndex = 2
        '
        'cmdSaisie
        '
        Me.cmdSaisie.Location = New System.Drawing.Point(199, 120)
        Me.cmdSaisie.Name = "cmdSaisie"
        Me.cmdSaisie.Size = New System.Drawing.Size(106, 44)
        Me.cmdSaisie.TabIndex = 3
        Me.cmdSaisie.Text = "OK"
        Me.cmdSaisie.UseVisualStyleBackColor = True
        '
        'cmdQuitter
        '
        Me.cmdQuitter.Location = New System.Drawing.Point(135, 314)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(242, 40)
        Me.cmdQuitter.TabIndex = 4
        Me.cmdQuitter.Text = "Quitter"
        Me.cmdQuitter.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(119, 61)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(296, 18)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Saisie de plusieurs nombres non nuls : "
        '
        'MoyenneNombres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(516, 380)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.cmdSaisie)
        Me.Controls.Add(Me.lblResultat)
        Me.Controls.Add(Me.Label2)
        Me.Name = "MoyenneNombres"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResultat As System.Windows.Forms.Label
    Friend WithEvents cmdSaisie As System.Windows.Forms.Button
    Friend WithEvents cmdQuitter As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label

End Class
