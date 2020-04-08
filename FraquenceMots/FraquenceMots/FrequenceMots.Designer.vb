<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrequenceMots
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDocument = New System.Windows.Forms.TextBox()
        Me.cmdCharger = New System.Windows.Forms.Button()
        Me.cmdFrequence = New System.Windows.Forms.Button()
        Me.cmdRemplacer = New System.Windows.Forms.Button()
        Me.cmdQuitter = New System.Windows.Forms.Button()
        Me.txtMotCherche = New System.Windows.Forms.TextBox()
        Me.txtMotRemplacement = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFrequence = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDocument
        '
        Me.txtDocument.Location = New System.Drawing.Point(164, 12)
        Me.txtDocument.Multiline = True
        Me.txtDocument.Name = "txtDocument"
        Me.txtDocument.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDocument.Size = New System.Drawing.Size(453, 211)
        Me.txtDocument.TabIndex = 0
        '
        'cmdCharger
        '
        Me.cmdCharger.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCharger.Location = New System.Drawing.Point(241, 229)
        Me.cmdCharger.Name = "cmdCharger"
        Me.cmdCharger.Size = New System.Drawing.Size(271, 37)
        Me.cmdCharger.TabIndex = 1
        Me.cmdCharger.Text = "Charger un texte du disque dur"
        Me.cmdCharger.UseVisualStyleBackColor = True
        '
        'cmdFrequence
        '
        Me.cmdFrequence.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFrequence.Location = New System.Drawing.Point(31, 332)
        Me.cmdFrequence.Name = "cmdFrequence"
        Me.cmdFrequence.Size = New System.Drawing.Size(249, 38)
        Me.cmdFrequence.TabIndex = 2
        Me.cmdFrequence.Text = "Fréquence du mot recherché"
        Me.cmdFrequence.UseVisualStyleBackColor = True
        '
        'cmdRemplacer
        '
        Me.cmdRemplacer.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemplacer.Location = New System.Drawing.Point(289, 487)
        Me.cmdRemplacer.Name = "cmdRemplacer"
        Me.cmdRemplacer.Size = New System.Drawing.Size(215, 54)
        Me.cmdRemplacer.TabIndex = 3
        Me.cmdRemplacer.Text = "Remplacer !!"
        Me.cmdRemplacer.UseVisualStyleBackColor = True
        '
        'cmdQuitter
        '
        Me.cmdQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuitter.Location = New System.Drawing.Point(171, 569)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(446, 48)
        Me.cmdQuitter.TabIndex = 4
        Me.cmdQuitter.Text = "Quitter"
        Me.cmdQuitter.UseVisualStyleBackColor = True
        '
        'txtMotCherche
        '
        Me.txtMotCherche.Location = New System.Drawing.Point(333, 283)
        Me.txtMotCherche.Name = "txtMotCherche"
        Me.txtMotCherche.Size = New System.Drawing.Size(230, 20)
        Me.txtMotCherche.TabIndex = 5
        '
        'txtMotRemplacement
        '
        Me.txtMotRemplacement.Location = New System.Drawing.Point(333, 414)
        Me.txtMotRemplacement.Name = "txtMotRemplacement"
        Me.txtMotRemplacement.Size = New System.Drawing.Size(230, 20)
        Me.txtMotRemplacement.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Mot cherché"
        '
        'lblFrequence
        '
        Me.lblFrequence.BackColor = System.Drawing.SystemColors.Control
        Me.lblFrequence.Location = New System.Drawing.Point(362, 333)
        Me.lblFrequence.Name = "lblFrequence"
        Me.lblFrequence.Size = New System.Drawing.Size(182, 37)
        Me.lblFrequence.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mot de remplacement"
        '
        'frmFrequenceMots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(790, 651)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFrequence)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMotRemplacement)
        Me.Controls.Add(Me.txtMotCherche)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.cmdRemplacer)
        Me.Controls.Add(Me.cmdFrequence)
        Me.Controls.Add(Me.cmdCharger)
        Me.Controls.Add(Me.txtDocument)
        Me.Name = "frmFrequenceMots"
        Me.Text = "Frequence Mots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDocument As System.Windows.Forms.TextBox
    Friend WithEvents cmdCharger As System.Windows.Forms.Button
    Friend WithEvents cmdFrequence As System.Windows.Forms.Button
    Friend WithEvents cmdRemplacer As System.Windows.Forms.Button
    Friend WithEvents cmdQuitter As System.Windows.Forms.Button
    Friend WithEvents txtMotCherche As System.Windows.Forms.TextBox
    Friend WithEvents txtMotRemplacement As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFrequence As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
