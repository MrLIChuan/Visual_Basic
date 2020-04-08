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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFacExp = New System.Windows.Forms.Label()
        Me.lblAltMax = New System.Windows.Forms.Label()
        Me.lblFlyTime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVol = New System.Windows.Forms.TextBox()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.cmdCalcul = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumVol = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFacExp)
        Me.GroupBox1.Controls.Add(Me.lblAltMax)
        Me.GroupBox1.Controls.Add(Me.lblFlyTime)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtVol)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 282)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Le vol"
        '
        'lblFacExp
        '
        Me.lblFacExp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFacExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacExp.Location = New System.Drawing.Point(568, 188)
        Me.lblFacExp.Name = "lblFacExp"
        Me.lblFacExp.Size = New System.Drawing.Size(92, 27)
        Me.lblFacExp.TabIndex = 8
        '
        'lblAltMax
        '
        Me.lblAltMax.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAltMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltMax.Location = New System.Drawing.Point(568, 128)
        Me.lblAltMax.Name = "lblAltMax"
        Me.lblAltMax.Size = New System.Drawing.Size(92, 27)
        Me.lblAltMax.TabIndex = 7
        '
        'lblFlyTime
        '
        Me.lblFlyTime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFlyTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlyTime.Location = New System.Drawing.Point(568, 67)
        Me.lblFlyTime.Name = "lblFlyTime"
        Me.lblFlyTime.Size = New System.Drawing.Size(92, 27)
        Me.lblFlyTime.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(413, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Facteur d'expansion"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Altitude maximale"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(413, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Durée du vol"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Les termes du vol"
        '
        'txtVol
        '
        Me.txtVol.Location = New System.Drawing.Point(6, 67)
        Me.txtVol.Multiline = True
        Me.txtVol.Name = "txtVol"
        Me.txtVol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVol.Size = New System.Drawing.Size(401, 177)
        Me.txtVol.TabIndex = 0
        '
        'cmdEnd
        '
        Me.cmdEnd.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmdEnd.Location = New System.Drawing.Point(615, 46)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(90, 33)
        Me.cmdEnd.TabIndex = 10
        Me.cmdEnd.Text = "Game Over"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'cmdCalcul
        '
        Me.cmdCalcul.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmdCalcul.Location = New System.Drawing.Point(473, 46)
        Me.cmdCalcul.Name = "cmdCalcul"
        Me.cmdCalcul.Size = New System.Drawing.Size(83, 33)
        Me.cmdCalcul.TabIndex = 8
        Me.cmdCalcul.Text = "GO!!!!!!!!"
        Me.cmdCalcul.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Numéro du vol"
        '
        'txtNumVol
        '
        Me.txtNumVol.Location = New System.Drawing.Point(156, 55)
        Me.txtNumVol.Name = "txtNumVol"
        Me.txtNumVol.Size = New System.Drawing.Size(139, 21)
        Me.txtNumVol.TabIndex = 6
        '
        'frmAffichage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(771, 394)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.cmdCalcul)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumVol)
        Me.Name = "frmAffichage"
        Me.Text = "Affichage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFacExp As Label
    Friend WithEvents lblAltMax As Label
    Friend WithEvents lblFlyTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVol As TextBox
    Friend WithEvents cmdEnd As Button
    Friend WithEvents cmdCalcul As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumVol As TextBox
End Class
