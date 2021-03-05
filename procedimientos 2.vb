Module Module1

    Sub Main()
        Dim valor1, valor2 As Integer
        valor1 = 5
        valor2 = 7
        Console.WriteLine("La suma de los valores es: " & (suma(valor1, valor2)))
        Console.ReadLine()
    End Sub

    Function suma(val1 As Integer, val2 As Integer) As Integer
        Return (val1 + val2)

    End Function

End Module
