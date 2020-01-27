Module Module1

    Sub main()

        Dim customname As String = 0
        Dim id As String = ""
        Dim regdate As String = ""
        Dim Telephone As String = ""
        Dim path As String = "C:\Users\Shareef\Desktop/filing.txt"
        Dim path2 As String = "C:\Users\Shareef\Desktop/filing2.txt"
        Dim count As Integer = 1

        FileOpen(1, path, OpenMode.Input)
        FileOpen(2, path2, OpenMode.Output)

        While Not EOF(1)
            customname = LineInput(1)
            Input(1, id)

            Console.Write("Enter Telephone Number of Member " & customname & ":") : Telephone = Console.ReadLine
            Console.Write("Enter Registration Date of Member (DD/MM/YYYY) " & customname & ":") : regdate = Console.ReadLine

            printline(2, customname)
            printline(2, id)
            printline(2, Telephone)
            printline(2, regdate)

            count = count + 1
        End While
        FileClose(1)
        FileClose(2)
    End Sub

End Module