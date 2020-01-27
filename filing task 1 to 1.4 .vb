Module Module1

    Sub Main()
        Dim num As Integer = 0
        Console.WriteLine("1: Input Data To File")
        Console.WriteLine("2: Search In A File")
        num = Console.ReadLine
        If num = 1 Then
            Call writefile()
        Else
            If num = 2 Then
                Call search()
            End If
        End If
    End Sub

    Sub writefile()
        Dim path As String = "C:\Users\Shareef\Desktop\filing.txt"
        Dim num As Integer = 0
        Dim str1 As String = "NAME: "
        Dim str2 As String = "MEMBER ID: "



        Console.WriteLine("Please Input Number Of Members")
        num = Console.ReadLine

        Dim customname(num) As String
        Dim id(num) As String

        For count = 1 To num
            Console.WriteLine("Please Enter Member's Name")
            customname(count) = Console.ReadLine
            Console.WriteLine("Please Enter Member's Id")
            id(count) = Console.ReadLine
        Next

        ' Create or overwrite the file.
        FileOpen(1, path, OpenMode.Append)
        For count = 1 To num
            PrintLine(1, str1 & customname(count))
            PrintLine(1, str2 & id(count))
        Next
        FileClose(1)
        Console.ReadKey()

    End Sub

    Sub search()
        Dim searchname As String = ""
        Dim name As String = ""
        Dim id As String = ""
        Dim path As String = "C:\Users\Shareef\Desktop/filing.txt"
        Dim isfound As Boolean = False

        Console.WriteLine("Please Enter Member's Name")
        searchname = "NAME: " & Console.ReadLine
        Console.WriteLine(searchname)

        FileOpen(1, path, OpenMode.Input)
        While Not EOF(1)
            name = LineInput(1)
            Input(1, id)

            If searchname = name Then
                isfound = True
                Console.WriteLine("ID:" & id)
                Console.WriteLine()
            End If
        End While
        FileClose(1)

        If Not isfound Then
            Console.WriteLine("Record For " & searchname & " couldn't be found...")
        End If
        Console.ReadKey()
    End Sub

End Module
