Public Class frmMain

    Private Sub btnStdntReg_Click(sender As Object, e As EventArgs) Handles btnStdntReg.Click
        frmStdReg.Show()
    End Sub

    Private Sub btnStdntEnrol_Click(sender As Object, e As EventArgs) Handles btnStdntEnrol.Click
        frmStudentEnrol.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRegModules_Click(sender As Object, e As EventArgs) Handles btnRegModules.Click
        frmModuleReg.Show()
    End Sub

    Private Sub EnrolmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrolmentToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ModuleRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModuleRegistrationToolStripMenuItem.Click
        frmModuleReg.Show()
    End Sub

    Private Sub ActivationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivationToolStripMenuItem.Click
        frmModuleAct.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem1.Click
        frmStdReg.Show()
    End Sub

    Private Sub EnrolmentToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EnrolmentToolStripMenuItem2.Click
        frmStudentEnrol.Show()
    End Sub

    Private Sub btnModuleAct_Click(sender As Object, e As EventArgs) Handles btnModuleAct.Click
        frmModuleAct.Show()
    End Sub
End Class
