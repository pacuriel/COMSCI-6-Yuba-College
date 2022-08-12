Module Module1
    Sub Main()
        Dim A As Integer
        Dim ArrayA(0 To 11)
        Dim ArrayB(0 To 11)
        Dim Numbers As Integer

        Console.WriteLine("Multiplying Two Sets of Numbers")
        Console.WriteLine(vbNewLine & "Enter 12 numbers for set A:")
        For A = 0 To 11
            Console.Write("")
            ArrayA(A) = Convert.ToInt32(Console.ReadLine())
        Next

        Console.WriteLine(vbNewLine & "Enter 12 numbers for set B:")
        For A = 0 To 11
            Console.Write("")
            ArrayB(A) = Convert.ToInt32(Console.ReadLine())
        Next
        Console.Write(vbNewLine)
        Console.WriteLine("Sets A and B Mulitiplied: ")
        For A = 0 To 11
            Numbers = (ArrayA(A)) * (ArrayB(A))
            Console.WriteLine("" & ArrayA(A) & " * " & ArrayB(A) & " =  " & Numbers)
        Next

        Console.ReadKey()
    End Sub
End Module
