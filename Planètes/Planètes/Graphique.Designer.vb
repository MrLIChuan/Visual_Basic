<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraph
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
        Me.pcbCircles = New System.Windows.Forms.PictureBox()
        Me.cmdZoom = New System.Windows.Forms.Button()
        Me.cmdDezoom = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdDroite = New System.Windows.Forms.Button()
        Me.cmdHaut = New System.Windows.Forms.Button()
        Me.cmdBas = New System.Windows.Forms.Button()
        Me.cmdGauche = New System.Windows.Forms.Button()
        CType(Me.pcbCircles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbCircles
        '
        Me.pcbCircles.Location = New System.Drawing.Point(11, 11)
        Me.pcbCircles.Margin = New System.Windows.Forms.Padding(2)
        Me.pcbCircles.Name = "pcbCircles"
        Me.pcbCircles.Size = New System.Drawing.Size(643, 418)
        Me.pcbCircles.TabIndex = 0
        Me.pcbCircles.TabStop = False
        '
        'cmdZoom
        '
        Me.cmdZoom.Location = New System.Drawing.Point(158, 44)
        Me.cmdZoom.Name = "cmdZoom"
        Me.cmdZoom.Size = New System.Drawing.Size(66, 49)
        Me.cmdZoom.TabIndex = 1
        Me.cmdZoom.Text = "+"
        Me.cmdZoom.UseVisualStyleBackColor = True
        '
        'cmdDezoom
        '
        Me.cmdDezoom.Location = New System.Drawing.Point(20, 44)
        Me.cmdDezoom.Name = "cmdDezoom"
        Me.cmdDezoom.Size = New System.Drawing.Size(66, 49)
        Me.cmdDezoom.TabIndex = 0
        Me.cmdDezoom.Text = "-"
        Me.cmdDezoom.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdZoom)
        Me.GroupBox2.Controls.Add(Me.cmdDezoom)
        Me.GroupBox2.Location = New System.Drawing.Point(659, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 109)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Zoom"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdDroite)
        Me.GroupBox1.Controls.Add(Me.cmdHaut)
        Me.GroupBox1.Controls.Add(Me.cmdBas)
        Me.GroupBox1.Controls.Add(Me.cmdGauche)
        Me.GroupBox1.Location = New System.Drawing.Point(659, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 179)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Déplacement"
        '
        'cmdDroite
        '
        Me.cmdDroite.Location = New System.Drawing.Point(160, 76)
        Me.cmdDroite.Name = "cmdDroite"
        Me.cmdDroite.Size = New System.Drawing.Size(70, 54)
        Me.cmdDroite.TabIndex = 6
        Me.cmdDroite.Text = ">"
        Me.cmdDroite.UseVisualStyleBackColor = True
        '
        'cmdHaut
        '
        Me.cmdHaut.Location = New System.Drawing.Point(93, 20)
        Me.cmdHaut.Name = "cmdHaut"
        Me.cmdHaut.Size = New System.Drawing.Size(61, 54)
        Me.cmdHaut.TabIndex = 4
        Me.cmdHaut.Text = "H"
        Me.cmdHaut.UseVisualStyleBackColor = True
        '
        'cmdBas
        '
        Me.cmdBas.Location = New System.Drawing.Point(93, 125)
        Me.cmdBas.Name = "cmdBas"
        Me.cmdBas.Size = New System.Drawing.Size(61, 48)
        Me.cmdBas.TabIndex = 7
        Me.cmdBas.Text = "B"
        Me.cmdBas.UseVisualStyleBackColor = True
        '
        'cmdGauche
        '
        Me.cmdGauche.Location = New System.Drawing.Point(20, 76)
        Me.cmdGauche.Name = "cmdGauche"
        Me.cmdGauche.Size = New System.Drawing.Size(67, 54)
        Me.cmdGauche.TabIndex = 5
        Me.cmdGauche.Text = "<"
        Me.cmdGauche.UseVisualStyleBackColor = True
        '
        'frmGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(906, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pcbCircles)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmGraph"
        Me.Text = "Graphique"
        CType(Me.pcbCircles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbCircles As PictureBox
    Friend WithEvents cmdZoom As Button
    Friend WithEvents cmdDezoom As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdDroite As Button
    Friend WithEvents cmdHaut As Button
    Friend WithEvents cmdBas As Button
    Friend WithEvents cmdGauche As Button
End Class
