<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccueil
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
        Me.optNewFile = New System.Windows.Forms.RadioButton()
        Me.optOpen = New System.Windows.Forms.RadioButton()
        Me.optQuitter = New System.Windows.Forms.RadioButton()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LI Chuan"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 56)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gravitron"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(70, 338)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Version 007a"
        '
        'optNewFile
        '
        Me.optNewFile.AutoSize = True
        Me.optNewFile.BackColor = System.Drawing.Color.Transparent
        Me.optNewFile.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNewFile.ForeColor = System.Drawing.Color.LightPink
        Me.optNewFile.Location = New System.Drawing.Point(631, 95)
        Me.optNewFile.Margin = New System.Windows.Forms.Padding(2)
        Me.optNewFile.Name = "optNewFile"
        Me.optNewFile.Size = New System.Drawing.Size(177, 29)
        Me.optNewFile.TabIndex = 6
        Me.optNewFile.TabStop = True
        Me.optNewFile.Text = "Nouveau Fichier"
        Me.optNewFile.UseVisualStyleBackColor = False
        '
        'optOpen
        '
        Me.optOpen.AutoSize = True
        Me.optOpen.BackColor = System.Drawing.Color.Transparent
        Me.optOpen.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOpen.ForeColor = System.Drawing.Color.LightPink
        Me.optOpen.Location = New System.Drawing.Point(676, 175)
        Me.optOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.optOpen.Name = "optOpen"
        Me.optOpen.Size = New System.Drawing.Size(88, 29)
        Me.optOpen.TabIndex = 7
        Me.optOpen.TabStop = True
        Me.optOpen.Text = "Ouvrir"
        Me.optOpen.UseVisualStyleBackColor = False
        '
        'optQuitter
        '
        Me.optQuitter.AutoSize = True
        Me.optQuitter.BackColor = System.Drawing.Color.Transparent
        Me.optQuitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.optQuitter.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optQuitter.ForeColor = System.Drawing.Color.LightPink
        Me.optQuitter.Location = New System.Drawing.Point(631, 250)
        Me.optQuitter.Margin = New System.Windows.Forms.Padding(2)
        Me.optQuitter.Name = "optQuitter"
        Me.optQuitter.Size = New System.Drawing.Size(92, 29)
        Me.optQuitter.TabIndex = 8
        Me.optQuitter.TabStop = True
        Me.optQuitter.Text = "Quitter"
        Me.optQuitter.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(587, 338)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(70, 32)
        Me.cmdOk.TabIndex = 9
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'frmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = Global.Planètes.My.Resources.Resources.Solar_System_2_900x643
        Me.ClientSize = New System.Drawing.Size(881, 478)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.optQuitter)
        Me.Controls.Add(Me.optOpen)
        Me.Controls.Add(Me.optNewFile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents optNewFile As RadioButton
    Friend WithEvents optOpen As RadioButton
    Friend WithEvents optQuitter As RadioButton
    Friend WithEvents cmdOk As Button
End Class
