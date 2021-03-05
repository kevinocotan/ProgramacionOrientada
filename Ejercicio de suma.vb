Module Module1

    Sub Main()
        Dim compra As Double
        Dim descuento As Double = 0.0
        Dim compraTot As Double

        Console.WriteLine("Introduzca el Valor total de la compra: ")
        compra = Console.ReadLine()

        If ((compra >= 50) And (compra <= 100)) Then
            descuento = (compra * 0.05)

        ElseIf ((compra >= 101) And (compra <= 150)) Then
            descuento = (compra * 0.1)

        ElseIf (compra >= 151) Then
            descuento = (compra * 0.15)

        End If

        compraTot = compra - descuento

        Console.WriteLine("El total de tu compra es: " & compra)
        Console.WriteLine("El descuento es: " & descuento)
        Console.WriteLine("El total de la compra con descuento es: " & compraTot)
        Console.Read()

    End Sub

End Module
