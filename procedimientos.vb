Module Module1

    Sub Main()
        Dim numero As Integer = 1
        Dim numero2 As Integer = 2
        Console.WriteLine("valor de numero en sub " & numero)
        Console.WriteLine("valor de numero2 en sub " & numero2)
        parametros(numero, numero2)
        Console.WriteLine("valor de numero en sub " & numero)
        Console.WriteLine("valor de numero2 en sub" & numero2)
        Console.ReadLine()
    End Sub
    Sub parametros(ByVal num1 As Integer, ByRef num2 As Integer)
        num1 = 3
        Console.WriteLine("valor de numero en parametros " & num1)
        num2 = 5
        Console.WriteLine("valor de numero en parametros " & num2)
        Console.ReadLine()

    End Sub

End Module
