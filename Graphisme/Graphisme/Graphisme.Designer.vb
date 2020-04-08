<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraphisme
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
        Me.pctGraphe = New System.Windows.Forms.PictureBox()
        Me.cmdTracerAxes = New System.Windows.Forms.Button()
        Me.cmdTracerDroiteCercle = New System.Windows.Forms.Button()
        Me.cmdTracerCourbe = New System.Windows.Forms.Button()
        Me.cmdHaut = New System.Windows.Forms.Button()
        Me.cmdGauche = New System.Windows.Forms.Button()
        Me.cmdDroite = New System.Windows.Forms.Button()
        Me.cmdBas = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdZoom = New System.Windows.Forms.Button()
        Me.cmdDezoom = New System.Windows.Forms.Button()
        CType(Me.pctGraphe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctGraphe
        '
        Me.pctGraphe.BackColor = System.Drawing.SystemColors.Window
        Me.pctGraphe.Location = New System.Drawing.Point(74, 108)
        Me.pctGraphe.Name = "pctGraphe"
        Me.pctGraphe.Size = New System.Drawing.Size(721, 454)
        Me.pctGraphe.TabIndex = 0
        Me.pctGraphe.TabStop = False
        '
        'cmdTracerAxes
        '
        Me.cmdTracerAxes.Location = New System.Drawing.Point(94, 24)
        Me.cmdTracerAxes.Name = "cmdTracerAxes"
        Me.cmdTracerAxes.Size = New System.Drawing.Size(122, 63)
        Me.cmdTracerAxes.TabIndex = 1
        Me.cmdTracerAxes.Text = "Dessiner axes"
        Me.cmdTracerAxes.UseVisualStyleBackColor = True
        '
        'cmdTracerDroiteCercle
        '
        Me.cmdTracerDroiteCercle.Location = New System.Drawing.Point(291, 24)
        Me.cmdTracerDroiteCercle.Name = "cmdTracerDroiteCercle"
        Me.cmdTracerDroiteCercle.Size = New System.Drawing.Size(122, 63)
        Me.cmdTracerDroiteCercle.TabIndex = 2
        Me.cmdTracerDroiteCercle.Text = "Dessiner droite et cercle"
        Me.cmdTracerDroiteCercle.UseVisualStyleBackColor = True
        '
        'cmdTracerCourbe
        '
        Me.cmdTracerCourbe.Location = New System.Drawing.Point(501, 24)
        Me.cmdTracerCourbe.Name = "cmdTracerCourbe"
        Me.cmdTracerCourbe.Size = New System.Drawing.Size(122, 63)
        Me.cmdTracerCourbe.TabIndex = 3
        Me.cmdTracerCourbe.Text = "Dessiner courbe"
        Me.cmdTracerCourbe.UseVisualStyleBackColor = True
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
        'cmdGauche
        '
        Me.cmdGauche.Location = New System.Drawing.Point(20, 76)
        Me.cmdGauche.Name = "cmdGauche"
        Me.cmdGauche.Size = New System.Drawing.Size(67, 54)
        Me.cmdGauche.TabIndex = 5
        Me.cmdGauche.Text = "<"
        Me.cmdGauche.UseVisualStyleBackColor = True
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
        'cmdBas
        '
        Me.cmdBas.Location = New System.Drawing.Point(93, 125)
        Me.cmdBas.Name = "cmdBas"
        Me.cmdBas.Size = New System.Drawing.Size(61, 48)
        Me.cmdBas.TabIndex = 7
        Me.cmdBas.Text = "B"
        Me.cmdBas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdDroite)
        Me.GroupBox1.Controls.Add(Me.cmdHaut)
        Me.GroupBox1.Controls.Add(Me.cmdBas)
        Me.GroupBox1.Controls.Add(Me.cmdGauche)
        Me.GroupBox1.Location = New System.Drawing.Point(801, 281)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 179)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Déplacement"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdZoom)
        Me.GroupBox2.Controls.Add(Me.cmdDezoom)
        Me.GroupBox2.Location = New System.Drawing.Point(801, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 147)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Zoom"
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
        'frmGraphisme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1066, 591)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdTracerCourbe)
        Me.Controls.Add(Me.cmdTracerDroiteCercle)
        Me.Controls.Add(Me.cmdTracerAxes)
        Me.Controls.Add(Me.pctGraphe)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmGraphisme"
        Me.Text = "Graphisme"
        CType(Me.pctGraphe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctGraphe As PictureBox
    Friend WithEvents cmdTracerAxes As Button
    Friend WithEvents cmdTracerDroiteCercle As Button
    Friend WithEvents cmdTracerCourbe As Button
    Friend WithEvents cmdHaut As Button
    Friend WithEvents cmdGauche As Button
    Friend WithEvents cmdDroite As Button
    Friend WithEvents cmdBas As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdZoom As Button
    Friend WithEvents cmdDezoom As Button
End Class
