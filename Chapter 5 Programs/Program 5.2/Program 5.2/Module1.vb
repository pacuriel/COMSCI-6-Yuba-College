Module Module1
    Sub Main()
        ' Main variable "Number" will be used throughout code
        Dim Number As Integer

        ' Directs user to input a 5-digit number
        Console.Write("Enter a 5-digit number: ")
        Number = Convert.ToInt32(Console.ReadLine())

        ' If the inputed number is the same in reverse, then the system tells the user it is a palindrome.
        If Number = StrReverse(Number) Then
            Console.WriteLine(vbNewLine & "Palindrome")
            ' If the inputed number isn't a palidrome, the system will tell the user.
        Else
            Console.WriteLine(vbNewLine & "Not a palindrome. Did you input the 5-digit number correctly?")
        End If

        Console.ReadKey()

    End Sub
End Module
