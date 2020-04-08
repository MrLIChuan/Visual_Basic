Public Class frmGraph
    'On peut initialiser les variables à la déclaration ! 
    Dim sngEchelleX As Single = 7
    Dim sngEchelleY As Single = -7     'Pourquoi le “ – “ ? 
    Dim sngOrigineX As Single = 8
    Dim sngOrigineY As Single = -5
    'creation d’un objet graphisme  
    Dim gphDessin As System.Drawing.Graphics
    Dim ftMessage As New Font("Arial", 1, FontStyle.Bold)


    Private Sub Button1_Click(sender As Object, e As EventArgs)

        gphDessin = pcbCircles.CreateGraphics()

        'Construction du repère         
        gphDessin.PageUnit = GraphicsUnit.Millimeter 'UNITES : passage en millimetre         
        gphDessin.ScaleTransform(sngEchelleX, sngEchelleY) 'Changement d’échelle         
        gphDessin.TranslateTransform(sngOrigineX, sngOrigineY) 'Changement d’origine 

        'Tracé des axes 
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), -50, 0, 50, 0) 'Axe des x        
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), 0, -50, 0, 50) 'Axe des y 

        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y

        For i = -50 To 50
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), i, 0.1F, i, -0.1F)
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), -0.1F, i, 0.1F, i)
            gphDessin.DrawString(i, ftMessage, Brushes.Black, i, 0.3F)
            gphDessin.DrawString(-i, ftMessage, Brushes.Black, 0.3F, i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y

        For i = 1 To 10
            gphDessin.DrawEllipse(New Pen(Color.Red, 0.01), CSng(txtX(i).Text), CSng(txtY(i).Text), CSng(txtM(i).Text), CSng(txtM(i).Text))
        Next
    End Sub

    Private Sub cmdHaut_Click(sender As Object, e As EventArgs) Handles cmdHaut.Click
        Dim ftMessage As New Font("Arial", 1, FontStyle.Bold)
        Dim P As Single
        Dim sngPas As Single = 0.001 'pas de la boucle for 

        gphDessin.Clear(Color.White)    'efface la pictureBox
        sngOrigineY = sngOrigineY - 1 'augmente la coordonnée de Y de 1  


        gphDessin = pcbCircles.CreateGraphics()
        'Construction du repère         
        gphDessin.PageUnit = GraphicsUnit.Millimeter 'UNITES : passage en millimetre         
        gphDessin.ScaleTransform(sngEchelleX, sngEchelleY) 'Changement d’échelle         
        gphDessin.TranslateTransform(sngOrigineX, sngOrigineY) 'Changement d’origine 

        'Tracé des axes 
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), -50, 0, 50, 0) 'Axe des x        
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), 0, -50, 0, 50) 'Axe des y 

        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y
        For i = -50 To 50
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), i, 0.1F, i, -0.1F)
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), -0.1F, i, 0.1F, i)
            gphDessin.DrawString(i, ftMessage, Brushes.Black, i, 0.3F)
            gphDessin.DrawString(-i, ftMessage, Brushes.Black, 0.3F, i)
        Next

        P = 0.01
        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y
        For x = -50 To 50 Step P
            gphDessin.DrawLine(New Pen(Color.Red, 0.01), x, f(x), x + P, f(x + P))
        Next
        gphDessin.DrawEllipse(New Pen(Color.Red, 0.01), -4, -1, 4, 4)
        gphDessin.DrawLine(New Pen(Color.Black, 0.01), -1.7F, 1, -2.3F, 1)
        gphDessin.DrawLine(New Pen(Color.Black, 0.01), -2, 1.3F, -2, 0.7F)

        For x = -50 To 50 Step sngPas
            gphDessin.DrawLine(New Pen(Color.Red, 0.01F), x, g(x), x + sngPas, g(x + sngPas))
        Next
    End Sub

    Private Function f(x As Single) As Single
        f = (2 * x) - 1

    End Function

    Private Sub cmdDezoom_Click(sender As Object, e As EventArgs) Handles cmdDezoom.Click
        Dim P As Single
        Dim ftMessage As New Font("Arial", 1, FontStyle.Bold)
        Dim sngPas As Single = 0.001 'pas de la boucle for 

        gphDessin.Clear(Color.White)    'efface la pictureBox 
        sngEchelleX = 0.8 * sngEchelleX     'change l’echelle des X 
        sngEchelleY = 0.8 * sngEchelleY     'change l’echelle des Y 

        gphDessin = pcbCircles.CreateGraphics()
        'Construction du repère         
        gphDessin.PageUnit = GraphicsUnit.Millimeter 'UNITES : passage en millimetre         
        gphDessin.ScaleTransform(sngEchelleX, sngEchelleY) 'Changement d’échelle         
        gphDessin.TranslateTransform(sngOrigineX, sngOrigineY) 'Changement d’origine 

        'Tracé des axes 
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), -50, 0, 50, 0) 'Axe des x        
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), 0, -50, 0, 50) 'Axe des y 

        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y
        For i = -50 To 50
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), i, 0.1F, i, -0.1F)
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), -0.1F, i, 0.1F, i)
            gphDessin.DrawString(i, ftMessage, Brushes.Black, i, 0.3F)
            gphDessin.DrawString(-i, ftMessage, Brushes.Black, 0.3F, i)
        Next

        P = 0.01
        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y
        For x = -50 To 50 Step P
            gphDessin.DrawLine(New Pen(Color.Red, 0.01), x, f(x), x + P, f(x + P))
        Next
        gphDessin.DrawEllipse(New Pen(Color.Red, 0.01), -4, -1, 4, 4)
        gphDessin.DrawLine(New Pen(Color.Black, 0.01), -1.7F, 1, -2.3F, 1)
        gphDessin.DrawLine(New Pen(Color.Black, 0.01), -2, 1.3F, -2, 0.7F)

        For x = -50 To 50 Step sngPas
            gphDessin.DrawLine(New Pen(Color.Red, 0.01F), x, g(x), x + sngPas, g(x + sngPas))
        Next
    End Sub

    Private Sub cmdBas_Click(sender As Object, e As EventArgs) Handles cmdBas.Click
        Dim ftMessage As New Font("Arial", 1, FontStyle.Bold)
        Dim P As Single
        Dim sngPas As Single = 0.001 'pas de la boucle for 

        gphDessin.Clear(Color.White)    'efface la pictureBox
        sngOrigineY = sngOrigineY + 1


        gphDessin = pcbCircles.CreateGraphics()
        'Construction du repère         
        gphDessin.PageUnit = GraphicsUnit.Millimeter 'UNITES : passage en millimetre         
        gphDessin.ScaleTransform(sngEchelleX, sngEchelleY) 'Changement d’échelle         
        gphDessin.TranslateTransform(sngOrigineX, sngOrigineY) 'Changement d’origine 

        'Tracé des axes 
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), -50, 0, 50, 0) 'Axe des x        
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), 0, -50, 0, 50) 'Axe des y 

        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y
        For i = -50 To 50
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), i, 0.1F, i, -0.1F)
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), -0.1F, i, 0.1F, i)
            gphDessin.DrawString(i, ftMessage, Brushes.Black, i, 0.3F)
            gphDessin.DrawString(-i, ftMessage, Brushes.Black, 0.3F, i)
        Next

        P = 0.01
        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y
        For x = -50 To 50 Step P
            gphDessin.DrawLine(New Pen(Color.Red, 0.01), x, f(x), x + P, f(x + P))
        Next
        gphDessin.DrawEllipse(New Pen(Color.Red, 0.01), -4, -1, 4, 4)
        gphDessin.DrawLine(New Pen(Color.Black, 0.01), -1.7F, 1, -2.3F, 1)
        gphDessin.DrawLine(New Pen(Color.Black, 0.01), -2, 1.3F, -2, 0.7F)

        For x = -50 To 50 Step sngPas
            gphDessin.DrawLine(New Pen(Color.Red, 0.01F), x, g(x), x + sngPas, g(x + sngPas))
        Next
    End Sub

    Private Sub cmdGauche_Click(sender As Object, e As EventArgs) Handles cmdGauche.Click
        Dim ftMessage As New Font("Arial", 1, FontStyle.Bold)
        Dim P As Single
        Dim sngPas As Single = 0.001 'pas de la boucle for 

        gphDessin.Clear(Color.White)    'efface la pictureBox
        sngOrigineX = sngOrigineX + 1


        gphDessin = pcbCircles.CreateGraphics()
        'Construction du repère         
        gphDessin.PageUnit = GraphicsUnit.Millimeter 'UNITES : passage en millimetre         
        gphDessin.ScaleTransform(sngEchelleX, sngEchelleY) 'Changement d’échelle         
        gphDessin.TranslateTransform(sngOrigineX, sngOrigineY) 'Changement d’origine 

        'Tracé des axes 
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), -50, 0, 50, 0) 'Axe des x        
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), 0, -50, 0, 50) 'Axe des y 

        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y
        For i = -50 To 50
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), i, 0.1F, i, -0.1F)
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), -0.1F, i, 0.1F, i)
            gphDessin.DrawString(i, ftMessage, Brushes.Black, i, 0.3F)
            gphDessin.DrawString(-i, ftMessage, Brushes.Black, 0.3F, i)
        Next

        P = 0.01
        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y
        For x = -50 To 50 Step P
            gphDessin.DrawLine(New Pen(Color.Red, 0.01), x, f(x), x + P, f(x + P))
        Next
        gphDessin.DrawEllipse(New Pen(Color.Red, 0.01), -4, -1, 4, 4)
        gphDessin.DrawLine(New Pen(Color.Black, 0.01), -1.7F, 1, -2.3F, 1)
        gphDessin.DrawLine(New Pen(Color.Black, 0.01), -2, 1.3F, -2, 0.7F)

        For x = -50 To 50 Step sngPas
            gphDessin.DrawLine(New Pen(Color.Red, 0.01F), x, g(x), x + sngPas, g(x + sngPas))
        Next
    End Sub

    Private Sub cmdDroite_Click(sender As Object, e As EventArgs) Handles cmdDroite.Click
        Dim ftMessage As New Font("Arial", 1, FontStyle.Bold)
        Dim P As Single
        Dim sngPas As Single = 0.001 'pas de la boucle for 

        gphDessin.Clear(Color.White)    'efface la pictureBox
        sngOrigineX = sngOrigineX - 1


        gphDessin = pcbCircles.CreateGraphics()
        'Construction du repère         
        gphDessin.PageUnit = GraphicsUnit.Millimeter 'UNITES : passage en millimetre         
        gphDessin.ScaleTransform(sngEchelleX, sngEchelleY) 'Changement d’échelle         
        gphDessin.TranslateTransform(sngOrigineX, sngOrigineY) 'Changement d’origine 

        'Tracé des axes 
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), -50, 0, 50, 0) 'Axe des x        
        gphDessin.DrawLine(New Pen(Color.Green, 0.01), 0, -50, 0, 50) 'Axe des y 

        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y
        For i = -50 To 50
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), i, 0.1F, i, -0.1F)
            gphDessin.DrawLine(New Pen(Color.Black, 0.01), -0.1F, i, 0.1F, i)
            gphDessin.DrawString(i, ftMessage, Brushes.Black, i, 0.3F)
            gphDessin.DrawString(-i, ftMessage, Brushes.Black, 0.3F, i)
        Next

        P = 0.01
        gphDessin.ScaleTransform(1, -1) 'Changement d’échelle, inversion de l'axe y
        For x = -50 To 50 Step P
            gphDessin.DrawLine(New Pen(Color.Red, 0.01), x, f(x), x + P, f(x + P))
        Next
        gphDessin.DrawEllipse(New Pen(Color.Red, 0.01), -4, -1, 4, 4)
        gphDessin.DrawLine(New Pen(Color.Black, 0.01), -1.7F, 1, -2.3F, 1)
        gphDessin.DrawLine(New Pen(Color.Black, 0.01), -2, 1.3F, -2, 0.7F)

        For x = -50 To 50 Step sngPas
            gphDessin.DrawLine(New Pen(Color.Red, 0.01F), x, g(x), x + sngPas, g(x + sngPas))
        Next
    End Sub

    Private Function g(x As Single) As Single
        g = Math.Sin(x)
    End Function
End Class