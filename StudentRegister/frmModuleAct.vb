Imports System.IO

Public Class frmModuleAct
    Dim strRead As StreamReader
    Dim b As String
    Dim theActiveModuleFile As String = "C:\Users\Boitumelo\Documents\Visual Studio 2012\Projects\StudentRegister\StudentRegister\modulesactive.txt"
    Dim theModuleFile As String = "C:\Users\Boitumelo\Documents\Visual Studio 2012\Projects\StudentRegister\StudentRegister\modules.txt"


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmModuleAct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(theActiveModuleFile) Then
            Dim fileStr As FileStream
            fileStr = File.Create(theActiveModuleFile)
            fileStr.Close()
        End If
    End Sub

    Private Sub loadRegModules()
        Dim myReader As New FileIO.TextFieldParser(theModuleFile)
        myReader.TextFieldType = FileIO.FieldType.Delimited
        myReader.SetDelimiters(",")

        Dim currentRecord As String()
        While Not myReader.EndOfData
            Try
                currentRecord = myReader.ReadFields()
                Dim currentField As String
                For Each currentField In currentRecord
                    MsgBox(currentField)
                Next
            Catch ex As FileIO.MalformedLineException
                MsgBox("Line" & ex.Message & "is not valid and will be skipped.")
            End Try
        End While
    End Sub
End Class