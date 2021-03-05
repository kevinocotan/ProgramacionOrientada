Module Module1

    Sub Main()
        Dim acumulado As Integer = 0
        For i = 0 To 20 Step 1

            acumulado += i
            If (i = 20) Then
                Console.WriteLine(acumulado)
            Else
                Console.WriteLine(acumulado & ", ")
            End If

        Next
        Console.Read()
    End Sub

End Module
