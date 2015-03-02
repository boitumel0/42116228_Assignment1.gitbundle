<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuleReg
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
        Me.lblModuleCode = New System.Windows.Forms.Label()
        Me.lblModuleTitle = New System.Windows.Forms.Label()
        Me.lblActSemester = New System.Windows.Forms.Label()
        Me.txtbxModuleTitle = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmboxSemester = New System.Windows.Forms.ComboBox()
        Me.txtbxModuleCode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblModuleCode
        '
        Me.lblModuleCode.AutoSize = True
        Me.lblModuleCode.Location = New System.Drawing.Point(23, 32)
        Me.lblModuleCode.Name = "lblModuleCode"
        Me.lblModuleCode.Size = New System.Drawing.Size(69, 13)
        Me.lblModuleCode.TabIndex = 0
        Me.lblModuleCode.Text = "Module code"
        '
        'lblModuleTitle
        '
        Me.lblModuleTitle.AutoSize = True
        Me.lblModuleTitle.Location = New System.Drawing.Point(23, 68)
        Me.lblModuleTitle.Name = "lblModuleTitle"
        Me.lblModuleTitle.Size = New System.Drawing.Size(61, 13)
        Me.lblModuleTitle.TabIndex = 1
        Me.lblModuleTitle.Text = "Module title"
        '
        'lblActSemester
        '
        Me.lblActSemester.AutoSize = True
        Me.lblActSemester.Location = New System.Drawing.Point(23, 101)
        Me.lblActSemester.Name = "lblActSemester"
        Me.lblActSemester.Size = New System.Drawing.Size(99, 13)
        Me.lblActSemester.TabIndex = 2
        Me.lblActSemester.Text = "Activation semester"
        '
        'txtbxModuleTitle
        '
        Me.txtbxModuleTitle.Location = New System.Drawing.Point(128, 61)
        Me.txtbxModuleTitle.Name = "txtbxModuleTitle"
        Me.txtbxModuleTitle.Size = New System.Drawing.Size(121, 20)
        Me.txtbxModuleTitle.TabIndex = 4
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(91, 145)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "S&ubmit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(183, 145)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmboxSemester
        '
        Me.cmboxSemester.FormattingEnabled = True
        Me.cmboxSemester.Items.AddRange(New Object() {"S1", "S2"})
        Me.cmboxSemester.Location = New System.Drawing.Point(128, 98)
        Me.cmboxSemester.Name = "cmboxSemester"
        Me.cmboxSemester.Size = New System.Drawing.Size(121, 21)
        Me.cmboxSemester.TabIndex = 8
        Me.cmboxSemester.Text = "S1"
        '
        'txtbxModuleCode
        '
        Me.txtbxModuleCode.Location = New System.Drawing.Point(128, 25)
        Me.txtbxModuleCode.Name = "txtbxModuleCode"
        Me.txtbxModuleCode.Size = New System.Drawing.Size(121, 20)
        Me.txtbxModuleCode.TabIndex = 3
        '
        'frmModuleReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 193)
        Me.Controls.Add(Me.cmboxSemester)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtbxModuleTitle)
        Me.Controls.Add(Me.txtbxModuleCode)
        Me.Controls.Add(Me.lblActSemester)
        Me.Controls.Add(Me.lblModuleTitle)
        Me.Controls.Add(Me.lblModuleCode)
        Me.Name = "frmModuleReg"
        Me.Text = "Module Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModuleCode As System.Windows.Forms.Label
    Friend WithEvents lblModuleTitle As System.Windows.Forms.Label
    Friend WithEvents lblActSemester As System.Windows.Forms.Label
    Friend WithEvents txtbxModuleTitle As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmboxSemester As System.Windows.Forms.ComboBox
    Friend WithEvents txtbxModuleCode As System.Windows.Forms.TextBox
End Class
