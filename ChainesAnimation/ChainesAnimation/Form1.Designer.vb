<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimation
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
        Me.components = New System.ComponentModel.Container()
        Me.lblChaine1 = New System.Windows.Forms.Label()
        Me.lblChaine2 = New System.Windows.Forms.Label()
        Me.cmdPermute = New System.Windows.Forms.Button()
        Me.cmdEfface = New System.Windows.Forms.Button()
        Me.cmdFin = New System.Windows.Forms.Button()
        Me.tmrClignote = New System.Windows.Forms.Timer(Me.components)
        Me.tmeDefilement = New System.Windows.Forms.Timer(Me.components)
        Me.txtChaine2 = New System.Windows.Forms.TextBox()
        Me.txtChaine1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblChaine1
        '
        Me.lblChaine1.BackColor = System.Drawing.Color.Red
        Me.lblChaine1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaine1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblChaine1.Location = New System.Drawing.Point(25, 29)
        Me.lblChaine1.Name = "lblChaine1"
        Me.lblChaine1.Size = New System.Drawing.Size(100, 23)
        Me.lblChaine1.TabIndex = 2
        Me.lblChaine1.Text = "Chaîne 1"
        '
        'lblChaine2
        '
        Me.lblChaine2.BackColor = System.Drawing.Color.Green
        Me.lblChaine2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaine2.Location = New System.Drawing.Point(188, 29)
        Me.lblChaine2.Name = "lblChaine2"
        Me.lblChaine2.Size = New System.Drawing.Size(100, 23)
        Me.lblChaine2.TabIndex = 3
        Me.lblChaine2.Text = "Chaîne 2"
        '
        'cmdPermute
        '
        Me.cmdPermute.Location = New System.Drawing.Point(127, 125)
        Me.cmdPermute.Name = "cmdPermute"
        Me.cmdPermute.Size = New System.Drawing.Size(86, 37)
        Me.cmdPermute.TabIndex = 4
        Me.cmdPermute.Text = "Permuter"
        Me.cmdPermute.UseVisualStyleBackColor = True
        '
        'cmdEfface
        '
        Me.cmdEfface.Location = New System.Drawing.Point(127, 178)
        Me.cmdEfface.Name = "cmdEfface"
        Me.cmdEfface.Size = New System.Drawing.Size(86, 37)
        Me.cmdEfface.TabIndex = 5
        Me.cmdEfface.Text = "Effacer"
        Me.cmdEfface.UseVisualStyleBackColor = True
        '
        'cmdFin
        '
        Me.cmdFin.Location = New System.Drawing.Point(127, 238)
        Me.cmdFin.Name = "cmdFin"
        Me.cmdFin.Size = New System.Drawing.Size(86, 32)
        Me.cmdFin.TabIndex = 6
        Me.cmdFin.Text = "Quitter"
        Me.cmdFin.UseVisualStyleBackColor = True
        '
        'tmrClignote
        '
        Me.tmrClignote.Enabled = True
        Me.tmrClignote.Interval = 200
        '
        'tmeDefilement
        '
        Me.tmeDefilement.Enabled = True
        Me.tmeDefilement.Interval = 200
        '
        'txtChaine2
        '
        Me.txtChaine2.Location = New System.Drawing.Point(188, 86)
        Me.txtChaine2.Name = "txtChaine2"
        Me.txtChaine2.Size = New System.Drawing.Size(100, 20)
        Me.txtChaine2.TabIndex = 7
        '
        'txtChaine1
        '
        Me.txtChaine1.Location = New System.Drawing.Point(29, 86)
        Me.txtChaine1.Name = "txtChaine1"
        Me.txtChaine1.Size = New System.Drawing.Size(100, 20)
        Me.txtChaine1.TabIndex = 8
        '
        'frmAnimation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(328, 327)
        Me.Controls.Add(Me.txtChaine1)
        Me.Controls.Add(Me.txtChaine2)
        Me.Controls.Add(Me.cmdFin)
        Me.Controls.Add(Me.cmdEfface)
        Me.Controls.Add(Me.cmdPermute)
        Me.Controls.Add(Me.lblChaine2)
        Me.Controls.Add(Me.lblChaine1)
        Me.Name = "frmAnimation"
        Me.Text = "Animation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChaine1 As System.Windows.Forms.Label
    Friend WithEvents lblChaine2 As System.Windows.Forms.Label
    Friend WithEvents cmdPermute As System.Windows.Forms.Button
    Friend WithEvents cmdEfface As System.Windows.Forms.Button
    Friend WithEvents cmdFin As System.Windows.Forms.Button
    Friend WithEvents tmrClignote As System.Windows.Forms.Timer
    Friend WithEvents tmeDefilement As System.Windows.Forms.Timer
    Friend WithEvents txtChaine2 As System.Windows.Forms.TextBox
    Friend WithEvents txtChaine1 As System.Windows.Forms.TextBox

End Class
