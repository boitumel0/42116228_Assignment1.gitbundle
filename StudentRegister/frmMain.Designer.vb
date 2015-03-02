<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStdntReg = New System.Windows.Forms.Button()
        Me.btnRegModules = New System.Windows.Forms.Button()
        Me.btnModuleAct = New System.Windows.Forms.Button()
        Me.btnStdntEnrol = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrolmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabctrlStdMod = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrolmentToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.tabctrlStdMod.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStdntReg
        '
        Me.btnStdntReg.Location = New System.Drawing.Point(6, 6)
        Me.btnStdntReg.Name = "btnStdntReg"
        Me.btnStdntReg.Size = New System.Drawing.Size(162, 23)
        Me.btnStdntReg.TabIndex = 0
        Me.btnStdntReg.Text = "Student Registration"
        Me.btnStdntReg.UseVisualStyleBackColor = True
        '
        'btnRegModules
        '
        Me.btnRegModules.Location = New System.Drawing.Point(3, 6)
        Me.btnRegModules.Name = "btnRegModules"
        Me.btnRegModules.Size = New System.Drawing.Size(162, 23)
        Me.btnRegModules.TabIndex = 1
        Me.btnRegModules.Text = "Module Registration"
        Me.btnRegModules.UseVisualStyleBackColor = True
        '
        'btnModuleAct
        '
        Me.btnModuleAct.Location = New System.Drawing.Point(3, 35)
        Me.btnModuleAct.Name = "btnModuleAct"
        Me.btnModuleAct.Size = New System.Drawing.Size(162, 23)
        Me.btnModuleAct.TabIndex = 2
        Me.btnModuleAct.Text = "Module Activation"
        Me.btnModuleAct.UseVisualStyleBackColor = True
        '
        'btnStdntEnrol
        '
        Me.btnStdntEnrol.Location = New System.Drawing.Point(6, 45)
        Me.btnStdntEnrol.Name = "btnStdntEnrol"
        Me.btnStdntEnrol.Size = New System.Drawing.Size(162, 23)
        Me.btnStdntEnrol.TabIndex = 3
        Me.btnStdntEnrol.Text = "Student Enrolment"
        Me.btnStdntEnrol.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(118, 155)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.StudentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(293, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnrolmentToolStripMenuItem})
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.StudentsToolStripMenuItem.Text = "&File"
        '
        'EnrolmentToolStripMenuItem
        '
        Me.EnrolmentToolStripMenuItem.Name = "EnrolmentToolStripMenuItem"
        Me.EnrolmentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.EnrolmentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EnrolmentToolStripMenuItem.Text = "E&xit"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModuleRegistrationToolStripMenuItem, Me.ActivationToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.MaintenanceToolStripMenuItem.Text = "&Modules"
        '
        'ModuleRegistrationToolStripMenuItem
        '
        Me.ModuleRegistrationToolStripMenuItem.Name = "ModuleRegistrationToolStripMenuItem"
        Me.ModuleRegistrationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModuleRegistrationToolStripMenuItem.Text = "&Registration"
        '
        'ActivationToolStripMenuItem
        '
        Me.ActivationToolStripMenuItem.Name = "ActivationToolStripMenuItem"
        Me.ActivationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActivationToolStripMenuItem.Text = "&Activation"
        '
        'tabctrlStdMod
        '
        Me.tabctrlStdMod.Controls.Add(Me.TabPage1)
        Me.tabctrlStdMod.Controls.Add(Me.TabPage2)
        Me.tabctrlStdMod.Location = New System.Drawing.Point(12, 27)
        Me.tabctrlStdMod.Name = "tabctrlStdMod"
        Me.tabctrlStdMod.SelectedIndex = 0
        Me.tabctrlStdMod.Size = New System.Drawing.Size(213, 110)
        Me.tabctrlStdMod.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnStdntReg)
        Me.TabPage1.Controls.Add(Me.btnStdntEnrol)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(205, 84)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Students"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnRegModules)
        Me.TabPage2.Controls.Add(Me.btnModuleAct)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(205, 84)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modules"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem1, Me.EnrolmentToolStripMenuItem2})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.StudentToolStripMenuItem.Text = "&Student"
        '
        'RegistrationToolStripMenuItem1
        '
        Me.RegistrationToolStripMenuItem1.Name = "RegistrationToolStripMenuItem1"
        Me.RegistrationToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.RegistrationToolStripMenuItem1.Text = "&Registration"
        '
        'EnrolmentToolStripMenuItem2
        '
        Me.EnrolmentToolStripMenuItem2.Name = "EnrolmentToolStripMenuItem2"
        Me.EnrolmentToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.EnrolmentToolStripMenuItem2.Text = "&Enrolment"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 195)
        Me.Controls.Add(Me.tabctrlStdMod)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Student System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabctrlStdMod.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStdntReg As System.Windows.Forms.Button
    Friend WithEvents btnRegModules As System.Windows.Forms.Button
    Friend WithEvents btnModuleAct As System.Windows.Forms.Button
    Friend WithEvents btnStdntEnrol As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnrolmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabctrlStdMod As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnrolmentToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem

End Class
