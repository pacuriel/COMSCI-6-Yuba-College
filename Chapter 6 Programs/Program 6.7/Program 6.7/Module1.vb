Module Module1
    Sub Main()
        ' Declaring variables that will be used throughout code
        Dim Miles, Gallons, MPG As Double
        ' Title/header of program
        Console.WriteLine("Miles Per Gallon Calculator for the Month of March 2019")
        ' Code for MPG of Week 1
        Console.WriteLine(vbNewLine & "Week of 3/1/2019:")
        ' User inputs miles for week 1
        Console.Write("Miles driven: ")
        Miles = Convert.ToDouble(Console.ReadLine())
        'User inputs gallons for week 1
        Console.Write("Gallons used: ")
        Gallons = Convert.ToDouble(Console.ReadLine())
        ' Equation to find MPG for week 1
        MPG = Miles / Gallons
        ' Rounding MPG to 2 decimal places
        MPG = Math.Round(MPG, 2)
        Console.Write("MPG for week of 3/1/2019 is: " & MPG)

        ' Week 1 format will be used to find MPG for weeks 1-3

        Console.WriteLine(vbNewLine & vbNewLine & "Week of 3/8/2019:")
        Console.Write("Miles driven: ")
        Miles = Convert.ToDouble(Console.ReadLine())
        Console.Write("Gallons used: ")
        Gallons = Convert.ToDouble(Console.ReadLine())
        MPG = Miles / Gallons
        MPG = Math.Round(MPG, 2)
        Console.Write("MPG for week of 3/8/2019 is: " & MPG)

        Console.WriteLine(vbNewLine & vbNewLine & vbNewLine & "Week of 3/15/2019:")
        Console.Write("Miles driven: ")
        Miles = Convert.ToDouble(Console.ReadLine())
        Console.Write("Gallons used: ")
        Gallons = Convert.ToDouble(Console.ReadLine())
        MPG = Miles / Gallons
        MPG = Math.Round(MPG, 2)
        Console.Write("MPG for week of 3/15/2019 is: " & MPG)

        Console.WriteLine(vbNewLine & vbNewLine & vbNewLine & vbNewLine & "Week of 3/22/2019:")
        Console.Write("Miles driven: ")
        Miles = Convert.ToDouble(Console.ReadLine())
        Console.Write("Gallons used: ")
        Gallons = Convert.ToDouble(Console.ReadLine())
        MPG = Miles / Gallons
        MPG = Math.Round(MPG, 2)
        Console.Write("MPG for week of 3/22/2019 is: " & MPG)

        Console.ReadKey()

    End Sub
End Module