Module Module1
    Sub Main()
        ' Declaring variables
        Dim Count As Integer
        Dim Numbers(0 To 19) As Integer
        ' Asking user to input 20 numbers
        Console.WriteLine("Enter 20 numbers. Press the Enter key after each number.")
        Console.Write(vbNewLine)
        ' For Next loop asking user to input numbers 20 times
        For Count = 0 To 19
            Console.Write("Enter a number: ")
            Numbers(Count) = Convert.ToInt32(Console.ReadLine())
        Next
        ' Displaying even numbers
        Console.Write(vbNewLine)
        Console.Write("Even numbers: " & vbTab)
        ' For Next loop that displays even numbers
        For Count = 0 To 19
            If (Numbers(Count)) Mod 2 = 0 Then
                Console.Write("" & Numbers(Count) & vbTab)
            End If
        Next
        ' Displaying odd numbers
        Console.WriteLine(vbNewLine)
        Console.Write("Odd numbers: " & vbTab)
        ' For Next loop that displays odd numbers
        For Count = 0 To 19
            If (Numbers(Count)) Mod 2 > 0 Then
                Console.Write("" & Numbers(Count) & vbTab)
            End If
        Next

        Console.ReadKey()
    End Sub
End Module
