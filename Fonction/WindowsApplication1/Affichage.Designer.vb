<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFonction
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
        Me.TxtValX = New System.Windows.Forms.TextBox()
        Me.cmdCalcul = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFctX = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valeur de x"
        '
        'TxtValX
        '
        Me.TxtValX.Location = New System.Drawing.Point(12, 52)
        Me.TxtValX.Name = "TxtValX"
        Me.TxtValX.Size = New System.Drawing.Size(100, 21)
        Me.TxtValX.TabIndex = 2
        '
        'cmdCalcul
        '
        Me.cmdCalcul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalcul.Location = New System.Drawing.Point(167, 22)
        Me.cmdCalcul.Name = "cmdCalcul"
        Me.cmdCalcul.Size = New System.Drawing.Size(93, 51)
        Me.cmdCalcul.TabIndex = 3
        Me.cmdCalcul.Text = "---Calcul-->"
        Me.cmdCalcul.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Valeur de f(x)"
        '
        'txtFctX
        '
        Me.txtFctX.Location = New System.Drawing.Point(304, 52)
        Me.txtFctX.Name = "txtFctX"
        Me.txtFctX.Size = New System.Drawing.Size(100, 21)
        Me.txtFctX.TabIndex = 5
        '
        'frmFonction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(426, 93)
        Me.Controls.Add(Me.txtFctX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCalcul)
        Me.Controls.Add(Me.TxtValX)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFonction"
        Me.Text = "Fonction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtValX As TextBox
    Friend WithEvents cmdCalcul As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFctX As TextBox
End Class
