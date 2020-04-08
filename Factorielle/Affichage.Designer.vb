<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactorielle
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
        Me.txtFactN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCalcul = New System.Windows.Forms.Button()
        Me.TxtValN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFactN
        '
        Me.txtFactN.Location = New System.Drawing.Point(342, 76)
        Me.txtFactN.Name = "txtFactN"
        Me.txtFactN.Size = New System.Drawing.Size(100, 21)
        Me.txtFactN.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(339, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Valeur de n!"
        '
        'cmdCalcul
        '
        Me.cmdCalcul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalcul.Location = New System.Drawing.Point(182, 46)
        Me.cmdCalcul.Name = "cmdCalcul"
        Me.cmdCalcul.Size = New System.Drawing.Size(93, 51)
        Me.cmdCalcul.TabIndex = 8
        Me.cmdCalcul.Text = "---Calcul-->"
        Me.cmdCalcul.UseVisualStyleBackColor = True
        '
        'TxtValN
        '
        Me.TxtValN.Location = New System.Drawing.Point(27, 76)
        Me.TxtValN.Name = "TxtValN"
        Me.TxtValN.Size = New System.Drawing.Size(100, 21)
        Me.TxtValN.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Valeur de n"
        '
        'frmFactorielle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(472, 146)
        Me.Controls.Add(Me.txtFactN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCalcul)
        Me.Controls.Add(Me.TxtValN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFactorielle"
        Me.Text = "Factorielle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFactN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdCalcul As Button
    Friend WithEvents TxtValN As TextBox
    Friend WithEvents Label1 As Label
End Class
