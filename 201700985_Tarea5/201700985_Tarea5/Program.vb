Imports System

Module Program
    Sub Main()
        Dim num, i As Integer
        Dim fact As String
        Console.Clear()
        Console.Write("Ingrese un número entero positivo: ")
        num = Console.ReadLine()
        fact = 1
        Console.WriteLine()
        If (num > 0) Then
            Dim indice As Integer = num
            For i = 1 To num
                fact = fact * i
            Next
            Console.WriteLine("El resultado del factorial es: " + fact)
        Else
            Console.WriteLine("El número debe de ser positivo.")
        End If

        If (fact > 1) Then
            Dim indice = 1
            Dim multiplos As Integer = 0
            Dim resultado As String = ""

            While (indice <= fact)
                If (indice Mod 4 = 0) Then
                    resultado = resultado + indice.ToString + ", "
                    multiplos = multiplos + 1
                End If
                indice = indice + 1
            End While
            Console.WriteLine(resultado)
            Console.WriteLine()
            Console.WriteLine("La cantidad de múltiplos de 4, entre 0 y el factorial calculado es de: " + multiplos.ToString)
        End If
        Console.ReadKey()
    End Sub
End Module
