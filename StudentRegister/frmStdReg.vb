Imports System.IO

Public Class frmStdReg
    Dim myStudent As Student

    Dim strReader As StreamReader
    Dim b As String
    Dim theStdFile As String = "C:\Users\Boitumelo\Documents\Visual Studio 2012\Projects\StudentRegister\StudentRegister\studentfile.txt"

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim theTitle, theInit, theSurname, theAddr As String
        Dim theGender As Char
        Dim theBdate As Date

        theTitle = txtbxTitle.Text.ToUpper
        theInit = txtbxinitials.Text.ToUpper
        theSurname = txtbxSurname.Text.ToUpper
        theAddr = txtbxAddrs.Text.ToUpper
        theBdate = Me.dtetimeBirthDte.Value.Date

        If (rdobtnFemale.Focus) Then
            theGender = "F"
        Else
            theGender = "M"
        End If

        myStudent = New Student(theTitle, theInit, theSurname, theAddr, theBdate, theGender)
        myStudent.writeToStudentFile(theStdFile)
        txtbxTitle.Text = ""
        txtbxinitials.Text = ""
        txtbxSurname.Text = ""
        txtbxAddrs.Text = ""
        txtbxTitle.Focus()

    End Sub

    Private Sub frmStdReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(theStdFile) Then
            Dim fileStr As FileStream
            fileStr = File.Create(theStdFile)
            fileStr.Close()

        End If
    End Sub

End Class