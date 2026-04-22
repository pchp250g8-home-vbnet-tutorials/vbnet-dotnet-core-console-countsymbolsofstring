Imports System
Imports System.Runtime.InteropServices.JavaScript.JSType

Module Program
    Sub Main(args As String())
        Console.WriteLine("Input a string")
        Dim strLine = Console.ReadLine()
        Dim nLen = strLine.Length
        For i = 0 To nLen - 1
            Dim c = 0
            For j = 0 To nLen - 1
                If (strLine(i) = strLine(j)) Then
                    c += 1
                End If
            Next
            Console.WriteLine("The symbol ""{0}"" occurs {1} times", strLine(i), c)
        Next
        Console.Read()
    End Sub
End Module
