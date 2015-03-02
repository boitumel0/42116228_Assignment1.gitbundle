Imports System.IO

Public Class frmModuleReg
    Dim strRead As StreamReader
    Dim b As String
    Dim theModuleFile As String = "C:\Users\Boitumelo\Documents\Visual Studio 2012\Projects\StudentRegister\StudentRegister\modules.txt"

    Dim recordExist As Boolean = False

    Private Sub frmModuleReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(theModuleFile) Then
            Dim fileStr As FileStream
            fileStr = File.Create(theModuleFile)
            fileStr.Close()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtbxModuleCode.Text = Nothing Then
            MsgBox("Enter the module code")
        ElseIf txtbxModuleTitle.Text = Nothing Then
            MsgBox("Enter the module Title")
        Else
            Dim theRecord As String
            theRecord = txtbxModuleCode.Text.ToUpper + "," + txtbxModuleTitle.Text.ToUpper + "," + cmboxSemester.Text.ToUpper
            File.AppendAllText(theModuleFile, theRecord & vbCrLf)
            txtbxModuleCode.Text = ""
            txtbxModuleTitle.Text = ""
            cmboxSemester.Text = ""
            MsgBox("Module details have been saved", MsgBoxStyle.Information, "Saved")
        End If
    End Sub

    Private Sub readFile()
        Dim myReader As New FileIO.TextFieldParser(theModuleFile)
        myReader.TextFieldType = FileIO.FieldType.Delimited
        myReader.SetDelimiters(",")

        Dim currentRecord As String()
        While Not myReader.EndOfData
            Try
                currentRecord = myReader.ReadFields()
                Dim currentField As String
                For Each currentField In currentRecord
                    If (currentField = txtbxModuleCode.Text) Then
                        recordExist = True
                    End If
                    'MsgBox(currentField)
                Next
            Catch ex As FileIO.MalformedLineException
                MsgBox("Line" & ex.Message & "is not valid and will be skipped.")
            End Try
        End While

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtbxModuleCode_Leave(sender As Object, e As EventArgs) Handles txtbxModuleCode.Leave
        readFile()
        If (recordExist) Then
            MsgBox("Code already exists", MsgBoxStyle.Exclamation, "Module Code Validation")
            txtbxModuleCode.Text = ""
            txtbxModuleCode.Focus()
            recordExist = False
        End If
    End Sub
End Class