Module Module1

    Sub Main()
        Dim nombres(9) As String

        For i = 0 To nombres.Length - 1 Step 1
            Console.WriteLine("Ingrese nombre " & (i + 1))
            nombres(i) = Console.ReadLine

        Next

        For i = 0 To nombres.Length - 1 Step 1
            Console.WriteLine("Ingrese nombre " & (i + 1) & " : " & nombres(i))

        Next
        Console.ReadLine()

    End Sub

End Module
