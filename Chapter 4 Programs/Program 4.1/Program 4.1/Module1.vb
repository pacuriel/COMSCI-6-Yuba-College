Module Module1
    Sub Main()
        ' Declaring the variables to be input by the user
        Dim a, b, c, z As Double

        ' Heading that tells user the equation
        Console.WriteLine("Equation #1: z = a * (c - b)")
        ' Directions for the user to input numbers for a, b, and c
        Console.Write(vbNewLine & "Enter a number for a: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Enter a number for b: ")
        b = Convert.ToDouble(Console.ReadLine())
        Console.Write("Enter a number for c: ")
        c = Convert.ToDouble(Console.ReadLine())
        z = a * (c - b)
        ' Displays answer of equation after user has inputted numbers
        Console.WriteLine(vbNewLine & "The answer for Equation #1 is: " & z)
        Console.ReadKey()

        ' Same as equation #1
        Console.WriteLine(vbNewLine & "Equation #2: z = (a + b + c) / 3")
        Console.Write(vbNewLine & "Enter a number for a: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Enter a number for b: ")
        b = Convert.ToDouble(Console.ReadLine())
        Console.Write("Enter a number for c: ")
        c = Convert.ToDouble(Console.ReadLine())
        z = (a + b + c) / 3
        Console.WriteLine(vbNewLine & "The answer for Equation #2 is: " & z)
        Console.ReadKey()

        ' Same as equation #1 except user only plugs in a number for c
        Console.WriteLine(vbNewLine & "Equation #3: z = 8 * (e ^ 5) – c")
        Console.Write("Enter a number for c: ")
        c = Convert.ToDouble(Console.ReadLine())
        ' Declaring variable e with its value
        Dim e As Double = 2.71828182845905
        z = 8 * (e ^ 5) - c
        Console.WriteLine(vbNewLine & "The answer for Equation #3 is: " & z)
        Console.ReadKey()

        ' Same as equation #1
        Console.WriteLine(vbNewLine & "Equation #4: z = a * b - (c - 2)")
        Console.Write(vbNewLine & "Enter a number for a: ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.Write("Enter a number for b: ")
        b = Convert.ToDouble(Console.ReadLine())
        Console.Write("Enter a number for c: ")
        c = Convert.ToDouble(Console.ReadLine())
        z = a * b - (c - 2)
        Console.WriteLine(vbNewLine & "The answer for Equation #4 is: " & z)
        Console.ReadKey()

        ' A thank you to the user for using the program
        Console.WriteLine(vbNewLine & "Thanks for using my program!")
        Console.ReadKey()
    End Sub

End Module