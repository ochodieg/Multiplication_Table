'D. Ivan Ochoa
'RCET0265
'Fall 2020
'Multiplication_Table


Option Strict On
Option Explicit On
Option Compare Text


Module Multiplication_Table

    Sub Main()
        Dim xData As Boolean
        Dim data(12, 12) As Integer

        Dim x, quit As String
        Dim y, column, row As Integer




        Console.WriteLine("Press Q to quit.")

        Do

            Do



                Console.WriteLine("Enter any number between 1 and 12 or press q to wuit")

                Try

                    x = Console.ReadLine()

                    y = CInt(x)

                    If y < 13 And y > 0 Then

                        xData = True

                    ElseIf y >= 13 Or y <= 0 Then

                        Console.Clear()

                        Console.WriteLine("remember, only numbers 1 through 12")

                        xData = False

                    End If

                Catch

                    If x = ("Q") Then

                        Exit Sub

                    End If

                    xData = False

                    Console.Clear()

                    Console.WriteLine("remember, only numbers 1 through 12")
                End Try

            Loop Until xData = True

            Console.WriteLine($"below is the  {y}  *  {y}  multiplication table {vbNewLine}")

            For column = 1 To y

                For row = 1 To y

                    data(row, column) = row * column

                    Console.Write(data(row, column) & vbTab)

                Next

                Console.WriteLine()

            Next

            Console.WriteLine("Press Enter to continue or q to quit")

            quit = Console.ReadLine

            If quit = "q" Then

                Exit Sub

            End If

            Console.Clear()

        Loop



    End Sub

End Module
