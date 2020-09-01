Option Strict On
Option Explicit On


Module RunningTotal

    Sub Main()
        Dim userInput As String
        Dim runningTotal As Integer
        Const TAXRATE As Decimal = 0.06D



        While userInput <> "q"
            Console.WriteLine("Please select an option.")
            Console.WriteLine("1. Add Item")
            Console.WriteLine("2. Calculate")

            'userInput = Console.ReadLine()
            userInput = Console.ReadLine()

            If userInput = "1" Then
                Console.WriteLine("Enter the items coast")
                userInput = Console.ReadLine()
                Try
                    ''runningTotal = runningTotal + CInt(userInput)
                    runningTotal += CInt(userInput)

                Catch ex As Exception
                    'prompt useer to givew you good data
                End Try
                Console.WriteLine("Totale: " & runningTotal)
            ElseIf userInput = "2" Then
                Console.WriteLine("Tax: " & runningTotal * TAXRATE)
            Else
                'promppt user
            End If
        End While

        Console.ReadLine()

    End Sub

End Module
