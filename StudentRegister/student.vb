Imports System.IO

Public Class Student
    'STUDENT CLASS VARIABLES
    Public cStudentNo As String
    Public cTitle As String
    Public cInitials As String
    Public cSurname As String
    Public cAddress As String
    Public cBirthDate As Date
    Public cGender As Char
    Public cNumberoRegStudents As Integer = 1

    Public Sub New(Title As String, Init As String, Surname As String, Address As String,
                   Bdate As Date, Gender As String)
        generateStudentNo()
        cTitle = Title.ToUpper
        cInitials = Init.ToUpper
        cSurname = Surname.ToUpper
        cAddress = Address.ToUpper
        cBirthDate = Bdate
        cGender = Gender.ToUpper
    End Sub

    Public Sub generateStudentNo()
        Dim StdNo As String
        Dim theYear As String
        Dim NoOfRegStudents As String
        Dim CheckDigit As Short
        Dim SixDgtStudentNo As String
        Dim SumofSix As Integer

        'Determine two digits of the year
        theYear = Format(Today, "yy")

        MessageBox.Show(theYear.ToString())
        'Get the number of registered students and padd with '0'
        getNoOfRegStudents()
        NoOfRegStudents = cNumberoRegStudents.ToString("0000")

        'Calculation of check digit
        SixDgtStudentNo = theYear + NoOfRegStudents
        MessageBox.Show(SixDgtStudentNo)
        For Each element As Char In SixDgtStudentNo
            SumofSix += Integer.Parse(element)
        Next

        'divide by 10 and take remainder
        Dim theremainder As Integer = Integer.Parse(SixDgtStudentNo) Mod 10
        If (theremainder = 0) Then
            CheckDigit = 0
        Else
            CheckDigit = 10 - theremainder
        End If

        'combine to make the student number
        StdNo = SixDgtStudentNo + CheckDigit.ToString()

        MessageBox.Show(StdNo, "sudent no")
        cStudentNo = StdNo
    End Sub

    Public Sub getNoOfRegStudents()
        Dim SourcePath As String = "c:\users\user\documents\visual studio 2012\Projects\StudentRegister\StudentRegister\studentfile.txt"

        Dim FileNum As Integer = FreeFile()
        Dim TempS As String = ""
        Dim TempL As String

        If My.Computer.FileSystem.FileExists(SourcePath) Then
            FileOpen(FileNum, SourcePath, OpenMode.Input)

            Do Until EOF(FileNum)
                cNumberoRegStudents += 1
                TempL = LineInput(FileNum)
                TempS += TempL + vbCrLf
            Loop
            FileClose(FileNum)

        Else
            MsgBox("File does not exist, so this must be a new record. Number of records is 1")
            cNumberoRegStudents = 1
        End If

    End Sub

    Public Sub writeToStudentFile(fileName As String)
        Dim theRecord As String

        theRecord = cStudentNo + "," + cTitle + "," + cInitials + "," + cSurname + "," _
            + cAddress + "," + cBirthDate.ToString("d") + "," + cGender
        File.AppendAllText(fileName, theRecord & vbCrLf)
        MsgBox("Student details have been saved!", MsgBoxStyle.Information, "Saved")
    End Sub

    Public Function isStudentNoValid(ByVal StudentNo As String) As Boolean
        Dim SumStudentNo As Integer = 0 '1400212

        For Each element As Char In StudentNo
            SumStudentNo += Integer.Parse(element)
        Next

        If (SumStudentNo Mod 10 = 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub validateStudentNo(stdNumber As String)

    End Sub
End Class
