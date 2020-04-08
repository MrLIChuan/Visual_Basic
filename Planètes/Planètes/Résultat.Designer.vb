<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResultats
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblXgRslt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblYgRslt = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMasseMin = New System.Windows.Forms.Label()
        Me.lblMasseMax = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOrdMin = New System.Windows.Forms.Label()
        Me.lblOrdMax = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAbscMin = New System.Windows.Forms.Label()
        Me.lblAbscMax = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coordonnée Xg"
        '
        'lblXgRslt
        '
        Me.lblXgRslt.BackColor = System.Drawing.SystemColors.Window
        Me.lblXgRslt.Location = New System.Drawing.Point(159, 51)
        Me.lblXgRslt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblXgRslt.Name = "lblXgRslt"
        Me.lblXgRslt.Size = New System.Drawing.Size(107, 16)
        Me.lblXgRslt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Coordonnée Yg"
        '
        'lblYgRslt
        '
        Me.lblYgRslt.BackColor = System.Drawing.SystemColors.Window
        Me.lblYgRslt.Location = New System.Drawing.Point(159, 92)
        Me.lblYgRslt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblYgRslt.Name = "lblYgRslt"
        Me.lblYgRslt.Size = New System.Drawing.Size(107, 16)
        Me.lblYgRslt.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblYgRslt)
        Me.GroupBox1.Controls.Add(Me.lblXgRslt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(295, 155)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coordonnées du centre de gravité"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblMasseMin)
        Me.GroupBox2.Controls.Add(Me.lblMasseMax)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 20)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(295, 155)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Masse maximum et minimum du système"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Masse maximum"
        '
        'lblMasseMin
        '
        Me.lblMasseMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblMasseMin.Location = New System.Drawing.Point(159, 92)
        Me.lblMasseMin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMasseMin.Name = "lblMasseMin"
        Me.lblMasseMin.Size = New System.Drawing.Size(107, 16)
        Me.lblMasseMin.TabIndex = 3
        '
        'lblMasseMax
        '
        Me.lblMasseMax.BackColor = System.Drawing.SystemColors.Window
        Me.lblMasseMax.Location = New System.Drawing.Point(159, 51)
        Me.lblMasseMax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMasseMax.Name = "lblMasseMax"
        Me.lblMasseMax.Size = New System.Drawing.Size(107, 16)
        Me.lblMasseMax.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Masse minimum"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblOrdMin)
        Me.GroupBox3.Controls.Add(Me.lblOrdMax)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblAbscMin)
        Me.GroupBox3.Controls.Add(Me.lblAbscMax)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 192)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(658, 155)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Abscisses et ordonnées extrêmes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(378, 55)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Y maximum"
        '
        'lblOrdMin
        '
        Me.lblOrdMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblOrdMin.Location = New System.Drawing.Point(523, 92)
        Me.lblOrdMin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrdMin.Name = "lblOrdMin"
        Me.lblOrdMin.Size = New System.Drawing.Size(107, 16)
        Me.lblOrdMin.TabIndex = 7
        '
        'lblOrdMax
        '
        Me.lblOrdMax.BackColor = System.Drawing.SystemColors.Window
        Me.lblOrdMax.Location = New System.Drawing.Point(523, 51)
        Me.lblOrdMax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrdMax.Name = "lblOrdMax"
        Me.lblOrdMax.Size = New System.Drawing.Size(107, 16)
        Me.lblOrdMax.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(378, 92)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 12)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Y minimum"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "X maximum"
        '
        'lblAbscMin
        '
        Me.lblAbscMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblAbscMin.Location = New System.Drawing.Point(159, 92)
        Me.lblAbscMin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAbscMin.Name = "lblAbscMin"
        Me.lblAbscMin.Size = New System.Drawing.Size(107, 16)
        Me.lblAbscMin.TabIndex = 3
        '
        'lblAbscMax
        '
        Me.lblAbscMax.BackColor = System.Drawing.SystemColors.Window
        Me.lblAbscMax.Location = New System.Drawing.Point(159, 51)
        Me.lblAbscMax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAbscMax.Name = "lblAbscMax"
        Me.lblAbscMax.Size = New System.Drawing.Size(107, 16)
        Me.lblAbscMax.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 92)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 12)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "X minimum"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(730, 34)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 20)
        Me.ComboBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(788, 192)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmResultats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(954, 368)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmResultats"
        Me.Text = "Résultat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblXgRslt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblYgRslt As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMasseMin As Label
    Friend WithEvents lblMasseMax As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOrdMin As Label
    Friend WithEvents lblOrdMax As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAbscMin As Label
    Friend WithEvents lblAbscMax As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
