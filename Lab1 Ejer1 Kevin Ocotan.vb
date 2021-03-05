Module Module1

    Sub Main()
        Dim numeros(9) As Integer

        Dim suma As Integer = 0

        For i As Integer = 0 To numeros.Length - 1
            Console.WriteLine("Inserte un numero en la posicion: " & i + 1)
            numeros(i) = Console.ReadLine

            suma += numeros(i)

        Next

        Console.WriteLine("")
        Console.WriteLine("El resultado de la suma es: = " & suma)

        Console.ReadLine()

    End Sub

End Module
