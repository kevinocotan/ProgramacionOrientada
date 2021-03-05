Module Module1

    Sub Main()
        Dim valores(9) As Integer = 0
        Dim suma As Integer = 0
        Dim i As Integer = 0

        While (i <= (valores.Length - 1))
            Console.WriteLine("Ingresa el valor " & i + 1 & " :")
            valores(i) = Console.ReadLine()
            suma += valores(i)
            i = i + 1
        End While

        For j = 0 To 9 Step 1
            Console.WriteLine("Valor " & j + i & " :" & valores(j))

        Next
        Console.WriteLine("La suma es : " & suma)
        Console.ReadLine()


    End Sub

End Module
