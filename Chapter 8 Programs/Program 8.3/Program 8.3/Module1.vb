Module Module1
    Sub Main()
        ' I wasn't sure if you wanted us to use a Subroutine or Function
        ' and I'm still not sure I fully understand them so I just coded it like this.
        ' I apologize if it's not how it was supposed to be.

        ' Declaring variable
        Dim Category As Integer

        Console.WriteLine("Yuba College Athletics Season Pass Cost")
        ' Displaying categories
        Console.WriteLine(vbNewLine & "Season Pass Categories:")
        Console.WriteLine("(1) Children under 5")
        Console.WriteLine("(2) Seniors (60+) and Students")
        Console.WriteLine("(3) Adults under 60")
        Console.WriteLine("(4) Pets")
        Console.WriteLine("(5) Parking")
        ' user inputs corresponding number of category
        Console.Write(vbNewLine & "Enter the number of a category to display its price: ")
        Category = Convert.ToInt32(Console.ReadLine())
        ' If...Then statements to display cost of selected category
        If Category < 1 Or Category > 5 Then
            Console.WriteLine(vbNewLine & "You may have inputed the wrong number. Restart the program to try again.")
        ElseIf Category = 1 Then
            Console.WriteLine(vbNewLine & "A season pass for children under 5 is free.")
        ElseIf Category = 2 Then
            Console.WriteLine(vbNewLine & "A season pass for seniors (60+) and students costs $32.50.")
        ElseIf Category = 3 Then
            Console.WriteLine(vbNewLine & "A season pass for adults under 60 costs $43.25.")
        ElseIf Category = 4 Then
            Console.WriteLine(vbNewLine & "A season pass for a pet costs $12.00.")
        ElseIf Category = 5 Then
            Console.WriteLine(vbNewLine & "A season parking pass costs $10.00.")
        End If

        Console.ReadKey()
    End Sub

End Module
