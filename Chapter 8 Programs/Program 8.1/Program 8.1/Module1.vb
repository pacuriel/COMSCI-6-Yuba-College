Module Module1
    ' Function to Calculate account balance after a withdraw
    Function CheckingAccount(A As Double, B As Double)
        Return A - B
    End Function

    Sub Main()
        ' Declaring variables
        Dim Balance, Withdraw As Double

        Console.WriteLine("Checking Account Balance")
        ' User inputs current account balance
        Console.Write(vbNewLine & "Enter your checking account balance: ")
        Balance = Convert.ToInt32(Console.ReadLine())
        ' User inputs how much they would like to withdraw
        Console.Write(vbNewLine & "Enter how much you would like to withdraw: ")
        Withdraw = Convert.ToInt32(Console.ReadLine())
        ' Tells the user how much is in their balance after withdraw
        Console.WriteLine(vbNewLine & "Your new balance is: " & CheckingAccount(Balance, Withdraw))
        ' If...Then statement to moniter an overdrawn account 
        If CheckingAccount(Balance, Withdraw) < 0 Then
            Console.Write(vbNewLine & "You have overdrawn your account!")
        End If

        Console.ReadKey()
    End Sub

End Module
