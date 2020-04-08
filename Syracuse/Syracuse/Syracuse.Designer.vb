<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSyracuse
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
        Me.txtNumVol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCalcul = New System.Windows.Forms.Button()
        Me.cmdVolRec = New System.Windows.Forms.Button()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFacExp = New System.Windows.Forms.Label()
        Me.lblAltMax = New System.Windows.Forms.Label()
        Me.lblFlyTime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVol = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumVol
        '
        Me.txtNumVol.Location = New System.Drawing.Point(199, 30)
        Me.txtNumVol.Name = "txtNumVol"
        Me.txtNumVol.Size = New System.Drawing.Size(105, 20)
        Me.txtNumVol.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Saisir le premier terme"
        '
        'cmdCalcul
        '
        Me.cmdCalcul.Location = New System.Drawing.Point(327, 21)
        Me.cmdCalcul.Name = "cmdCalcul"
        Me.cmdCalcul.Size = New System.Drawing.Size(83, 36)
        Me.cmdCalcul.TabIndex = 2
        Me.cmdCalcul.Text = "GO!"
        Me.cmdCalcul.UseVisualStyleBackColor = True
        '
        'cmdVolRec
        '
        Me.cmdVolRec.Location = New System.Drawing.Point(440, 20)
        Me.cmdVolRec.Name = "cmdVolRec"
        Me.cmdVolRec.Size = New System.Drawing.Size(131, 36)
        Me.cmdVolRec.TabIndex = 3
        Me.cmdVolRec.Text = "Vols Enregistrés"
        Me.cmdVolRec.UseVisualStyleBackColor = True
        '
        'cmdEnd
        '
        Me.cmdEnd.Location = New System.Drawing.Point(594, 20)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(90, 36)
        Me.cmdEnd.TabIndex = 4
        Me.cmdEnd.Text = "Quitter"
        Me.cmdEnd.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(24, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 305)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Le vol"
        '
        'lblFacExp
        '
        Me.lblFacExp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFacExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacExp.Location = New System.Drawing.Point(568, 204)
        Me.lblFacExp.Name = "lblFacExp"
        Me.lblFacExp.Size = New System.Drawing.Size(92, 29)
        Me.lblFacExp.TabIndex = 8
        '
        'lblAltMax
        '
        Me.lblAltMax.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAltMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltMax.Location = New System.Drawing.Point(568, 139)
        Me.lblAltMax.Name = "lblAltMax"
        Me.lblAltMax.Size = New System.Drawing.Size(92, 29)
        Me.lblAltMax.TabIndex = 7
        '
        'lblFlyTime
        '
        Me.lblFlyTime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFlyTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlyTime.Location = New System.Drawing.Point(568, 73)
        Me.lblFlyTime.Name = "lblFlyTime"
        Me.lblFlyTime.Size = New System.Drawing.Size(92, 29)
        Me.lblFlyTime.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(413, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Facteur d'expansion"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Altitude maximale"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(413, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Durée du vol"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Les termes du vol"
        '
        'txtVol
        '
        Me.txtVol.Location = New System.Drawing.Point(6, 73)
        Me.txtVol.Multiline = True
        Me.txtVol.Name = "txtVol"
        Me.txtVol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVol.Size = New System.Drawing.Size(401, 191)
        Me.txtVol.TabIndex = 0
        '
        'frmSyracuse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(800, 455)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.cmdVolRec)
        Me.Controls.Add(Me.cmdCalcul)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumVol)
        Me.Name = "frmSyracuse"
        Me.Text = "Syracuse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumVol As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCalcul As System.Windows.Forms.Button
    Friend WithEvents cmdVolRec As System.Windows.Forms.Button
    Friend WithEvents cmdEnd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFacExp As System.Windows.Forms.Label
    Friend WithEvents lblAltMax As System.Windows.Forms.Label
    Friend WithEvents lblFlyTime As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVol As System.Windows.Forms.TextBox

End Class
