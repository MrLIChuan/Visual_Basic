Module ModMaths
    Public x As Single
    Public n As Byte
    Public p As Long
    Public Function f(ByVal x As Single) As Double

        f = Math.Sin(2 * x + Math.PI * 5 / 3)

    End Function

    Public Function Fact(ByVal n As Byte) As Long

        If n > 0 Then
            p = 1
            Do
                p = p * n
                n = n - 1
            Loop Until n <= 1

        Else
            p = 1
        End If

        Fact = p
    End Function
End Module
