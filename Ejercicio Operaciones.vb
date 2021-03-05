Module Module1

    Sub Main()
        Dim num1 As Double
        Dim num2 As Double
        Dim operacion As Double
        Dim total As Double = 0.0
        Dim res As Integer = 1

        Do While (Res >= 1)



            Console.WriteLine("Ingrese un numero: ")
            num1 = Console.ReadLine()
            Console.WriteLine("")

            Console.WriteLine("Ingrese otro numero: ")
            num2 = Console.ReadLine()
            Console.WriteLine("")

            Console.WriteLine("")
            Console.WriteLine("Escoja una opcion en el menu: ")
            Console.WriteLine("1. Suma + ")
            Console.WriteLine("2. Resta - ")
            Console.WriteLine("3. Multiplicacion * ")
            Console.WriteLine("4. Division / ")
            Console.WriteLine("")
            Console.WriteLine("Escribe el numero de la opcion que desees: ")

            operacion = Console.ReadLine()

            If (operacion = "1") Then
                total = num1 + num2
            ElseIf (operacion = "2") Then
                total = num1 - num2
            ElseIf (operacion = "3") Then
                total = num1 * num2
            ElseIf (operacion = "4") Then
                total = num1 / num2
            End If


            Console.WriteLine("")
            Console.WriteLine("El resultado de tu operacion es: " & total)
            Console.Read()

        Loop




    End Sub

End Module
