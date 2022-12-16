Module Module1

    Sub Main()
        Dim rand As New Random ' plants the seed to generate random numbers

        For i = 1 To 100
            Dim n As Integer
            n = rand.Next(1, 100) ' generate a number from 1 to 99
            Console.Write(n & " ")
        Next

    End Sub

End Module
