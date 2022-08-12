Module Module1
    Sub Main()
        ' Variable "People" signifies the amount of people in Yuba City.
        Dim People As Integer = 120000
        ' Variable "SquareMiles" signifies the amount of square miles in Yuba City.
        Dim SquareMiles As Integer = 800
        ' Variable "Result" signifies the amount of people per square mile in Yuba City.
        Dim Result As Integer

        Result = People / SquareMiles
        ' The amount of people per square footage in Yuba City is 150.
        Console.WriteLine("Result equals " & Result)
        Console.ReadLine()
    End Sub
End Module