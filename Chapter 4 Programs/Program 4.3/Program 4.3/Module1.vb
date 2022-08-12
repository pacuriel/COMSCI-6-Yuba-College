Module Module1
    Sub Main()
        ' Heading explaining the program
        Console.WriteLine("Numbers 1-4 using different Console.Write() statements")

        ' First line of numbers using one Console.Write() statement
        Console.Write("1 2 3 4")

        Console.Write(vbNewLine)

        ' Second line of numbers using four Console.Write() statements
        Console.Write(vbNewLine & "1 ")
        Console.Write("2 ")
        Console.Write("3 ")
        Console.Write("4")

        Console.ReadKey()
    End Sub

End Module