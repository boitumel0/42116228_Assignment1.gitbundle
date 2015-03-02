<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentEnrol
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
        Me.lblModule = New System.Windows.Forms.Label()
        Me.lblStuNo = New System.Windows.Forms.Label()
        Me.txtbxStuNo = New System.Windows.Forms.TextBox()
        Me.cmboxModule = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblModule
        '
        Me.lblModule.AutoSize = True
        Me.lblModule.Location = New System.Drawing.Point(12, 22)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(42, 13)
        Me.lblModule.TabIndex = 0
        Me.lblModule.Text = "Module"
        '
        'lblStuNo
        '
        Me.lblStuNo.AutoSize = True
        Me.lblStuNo.Location = New System.Drawing.Point(12, 60)
        Me.lblStuNo.Name = "lblStuNo"
        Me.lblStuNo.Size = New System.Drawing.Size(84, 13)
        Me.lblStuNo.TabIndex = 1
        Me.lblStuNo.Text = "Student Number"
        '
        'txtbxStuNo
        '
        Me.txtbxStuNo.Location = New System.Drawing.Point(103, 53)
        Me.txtbxStuNo.Name = "txtbxStuNo"
        Me.txtbxStuNo.Size = New System.Drawing.Size(121, 20)
        Me.txtbxStuNo.TabIndex = 3
        '
        'cmboxModule
        '
        Me.cmboxModule.FormattingEnabled = True
        Me.cmboxModule.Location = New System.Drawing.Point(103, 14)
        Me.cmboxModule.Name = "cmboxModule"
        Me.cmboxModule.Size = New System.Drawing.Size(121, 21)
        Me.cmboxModule.TabIndex = 4
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(87, 104)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "S&ubmit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(189, 103)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStudentEnrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 147)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cmboxModule)
        Me.Controls.Add(Me.txtbxStuNo)
        Me.Controls.Add(Me.lblStuNo)
        Me.Controls.Add(Me.lblModule)
        Me.Name = "frmStudentEnrol"
        Me.Text = "Student Enrolment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModule As System.Windows.Forms.Label
    Friend WithEvents lblStuNo As System.Windows.Forms.Label
    Friend WithEvents txtbxStuNo As System.Windows.Forms.TextBox
    Friend WithEvents cmboxModule As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
