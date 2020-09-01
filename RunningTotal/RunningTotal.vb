Option Strict Off
Option Explicit On
Option Compare Text


Module RunningTotal

    Sub Main()
        Dim userInput As String = ""
        Dim runningTotal As Integer
        Const TAXRATE As Decimal = 0.06D
        Dim taxAmount As Decimal
        Dim badData As Boolean = True


        While userInput <> "q"

            Console.WriteLine("Please select an option.")
            Console.WriteLine("1. Add Item")
            Console.WriteLine("2. Calculate tax")

            'userInput = Console.ReadLine()
            userInput = Console.ReadLine()

            If userInput = "1" Then
                Console.WriteLine("Enter the items coast")
                userInput = Console.ReadLine()

                Do
                    Try
                        'runningTotal = runningTotal + CInt(userInput)
                        runningTotal += CDec(userInput)
                        badData = False
                    Catch ex As Exception
                        'prompt useer to givew you good data
                        Console.WriteLine("item coast must be a number.")
                        badData = True
                    End Try
                Loop While badData

                Console.WriteLine("Totale: " & runningTotal.ToString("C"))

            ElseIf userInput = "2" Then
                taxAmount = runningTotal * TAXRATE
                Console.WriteLine("Tax: " & CStr(runningTotal * TAXRATE).ToString("C"))
            Else
                'promppt user
            End If

        End While

        'Console.ReadLine()

    End Sub

End Module
