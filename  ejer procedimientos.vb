Module Module1

    Sub Main()
        Dim nombre As String

        Console.WriteLine("¿Cual es su nombre?: ")
        nombre = Console.ReadLine
        parametros(nombre)

    End Sub

    Sub parametros(ByVal nombre As String)

        Console.WriteLine("Bienvenido, " & nombre & " , Gracias por pasar")
        Console.ReadLine()
    End Sub
End Module
