<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermutation
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
        Me.txtMemoire1 = New System.Windows.Forms.TextBox()
        Me.txtMemoire2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMemoire1 = New System.Windows.Forms.Label()
        Me.lblMemoire2 = New System.Windows.Forms.Label()
        Me.cmdCopie = New System.Windows.Forms.Button()
        Me.cmdPermute = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMemoire1
        '
        Me.txtMemoire1.Location = New System.Drawing.Point(63, 177)
        Me.txtMemoire1.Name = "txtMemoire1"
        Me.txtMemoire1.Size = New System.Drawing.Size(100, 20)
        Me.txtMemoire1.TabIndex = 0
        '
        'txtMemoire2
        '
        Me.txtMemoire2.Location = New System.Drawing.Point(228, 177)
        Me.txtMemoire2.Name = "txtMemoire2"
        Me.txtMemoire2.Size = New System.Drawing.Size(100, 20)
        Me.txtMemoire2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Memoire 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Memoire 2"
        '
        'lblMemoire1
        '
        Me.lblMemoire1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMemoire1.Location = New System.Drawing.Point(63, 219)
        Me.lblMemoire1.Name = "lblMemoire1"
        Me.lblMemoire1.Size = New System.Drawing.Size(100, 23)
        Me.lblMemoire1.TabIndex = 4
        '
        'lblMemoire2
        '
        Me.lblMemoire2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMemoire2.Location = New System.Drawing.Point(228, 219)
        Me.lblMemoire2.Name = "lblMemoire2"
        Me.lblMemoire2.Size = New System.Drawing.Size(100, 23)
        Me.lblMemoire2.TabIndex = 5
        '
        'cmdCopie
        '
        Me.cmdCopie.Location = New System.Drawing.Point(388, 174)
        Me.cmdCopie.Name = "cmdCopie"
        Me.cmdCopie.Size = New System.Drawing.Size(75, 23)
        Me.cmdCopie.TabIndex = 6
        Me.cmdCopie.Text = "Copie Ram"
        Me.cmdCopie.UseVisualStyleBackColor = True
        '
        'cmdPermute
        '
        Me.cmdPermute.Location = New System.Drawing.Point(388, 219)
        Me.cmdPermute.Name = "cmdPermute"
        Me.cmdPermute.Size = New System.Drawing.Size(75, 23)
        Me.cmdPermute.TabIndex = 7
        Me.cmdPermute.Text = "Permutation"
        Me.cmdPermute.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(388, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "End"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPermutation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(490, 403)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdPermute)
        Me.Controls.Add(Me.cmdCopie)
        Me.Controls.Add(Me.lblMemoire2)
        Me.Controls.Add(Me.lblMemoire1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMemoire2)
        Me.Controls.Add(Me.txtMemoire1)
        Me.Name = "frmPermutation"
        Me.Text = "Permutation de deux memoires"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMemoire1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMemoire2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMemoire1 As System.Windows.Forms.Label
    Friend WithEvents lblMemoire2 As System.Windows.Forms.Label
    Friend WithEvents cmdCopie As System.Windows.Forms.Button
    Friend WithEvents cmdPermute As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
