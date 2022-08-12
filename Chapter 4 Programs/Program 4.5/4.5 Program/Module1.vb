Module Module1
    Sub Main()
        ' Declaring variables X and Y to be used throughout the code
        Dim X As Double
        Dim Y As Double

        ' Using the same equations to display the squares and cubes of numbers 1 through 5
        Console.WriteLine("Numbers     Squares     Cubes")
        X = 0 ^ 2
        Y = 0 ^ 3
        Console.WriteLine("   0           " & X & "          " & Y)
        X = 1 ^ 2
        Y = 1 ^ 3
        Console.WriteLine("   1           " & X & "          " & Y)
        X = 2 ^ 2
        Y = 2 ^ 3
        Console.WriteLine("   2           " & X & "          " & Y)
        X = 3 ^ 2
        Y = 3 ^ 3
        Console.WriteLine("   3           " & X & "          " & Y)
        X = 4 ^ 2
        Y = 4 ^ 3
        Console.WriteLine("   4           " & X & "         " & Y)
        X = 5 ^ 2
        Y = 5 ^ 3
        Console.WriteLine("   5           " & X & "         " & Y)

        Console.ReadKey()

    End Sub

End Module
