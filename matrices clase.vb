Module Module1

    Sub Main()

        Dim elementos(2, 2) As String

        For fila = 0 To 1 Step 1
            For columna = 0 To 2 Step 1
                Console.WriteLine("Nombre " & fila & ", " & columna & " :")
                elementos(fila, columna) = Console.ReadLine
            Next
        Next
        For fila = 0 To 1 Step 1
            For columna = 0 To 2 Step 1
                Console.WriteLine("Nombre " & fila & ", " & columna & " :" & elementos(fila, columna))
            Next
        Next
        Console.ReadLine()

    End Sub

End Module
