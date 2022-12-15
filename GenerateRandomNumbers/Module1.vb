Module Module1

    Sub Main()
        Dim rand As New Random
        For i = 1 To 100
            Dim n As Integer = rand.Next(1, 100)
            Console.WriteLine(n)
        Next
    End Sub

End Module
