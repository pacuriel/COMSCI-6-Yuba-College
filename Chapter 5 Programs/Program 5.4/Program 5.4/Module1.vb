Module Module1
    Sub Main()
        ' Variables being used throughout code. 
        Dim DayHours As String
        Dim NightHours As String
        Dim TotalHours As String
        Dim DailyCost As String
        Dim MonthlyCost As String
        Dim Customer As String

        ' Program title. I chose March because that's what month it is right now. 
        Console.WriteLine("Squirrel Cage Power Company March Bill Calculator")
        ' Asks user to input number of hours used in both time slots
        Console.Write(vbNewLine & "Enter the number of hours you used electricity from 1 a.m. to 11 a.m.: ")
        DayHours = Convert.ToInt32(Console.ReadLine())
        If DayHours >= 10 Then DayHours = 10
        If DayHours <= 0 Then DayHours = 0
        Console.Write("Enter the number of hours you used electricity from 11 a.m. to 1 a.m. ")
        NightHours = Convert.ToInt32(Console.ReadLine())
        If NightHours >= 14 Then NightHours = 14
        If NightHours <= 0 Then NightHours = 0
        ' Equations for costs and hours
        DailyCost = (45 * DayHours) + (65 * NightHours)
        MonthlyCost = DailyCost * 31
        ' User pays half price if total hours used is less than 100
        TotalHours = (31 * DayHours) + (31 * NightHours)
        If TotalHours < 100 Then MonthlyCost = MonthlyCost * 0.5
        ' Displays total cost for the month of March. The cost seems a bit high. I'm not sure if that's correct.
        Console.WriteLine(vbNewLine & "The total cost for the month of March is ${0:C}.", MonthlyCost)

        Console.ReadKey()

    End Sub
End Module
