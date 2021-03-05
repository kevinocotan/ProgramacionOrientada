Module Module1

    Sub Main()
        Dim numeros(9) As Integer

        For i = 0 To 9 Step 1

            Console.WriteLine("Inserte el numero en la posicion: " & i + 1)
            numeros(i) = Console.ReadLine()

        Next

        Console.WriteLine("")
        Console.WriteLine("            Los valores se ordenaran de forma ascendente: ")
        Console.WriteLine("")
        Array.Sort(numeros)
        For Each orden As Integer In numeros
            Console.WriteLine(orden)
            Console.WriteLine("")

        Next

        Console.ReadLine()

    End Sub

End Module
