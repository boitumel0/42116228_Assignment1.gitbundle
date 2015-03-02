<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStdReg
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblinitials = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblAddrs = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtbxTitle = New System.Windows.Forms.TextBox()
        Me.txtbxinitials = New System.Windows.Forms.TextBox()
        Me.txtbxSurname = New System.Windows.Forms.TextBox()
        Me.txtbxAddrs = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.rdobtnMale = New System.Windows.Forms.RadioButton()
        Me.rdobtnFemale = New System.Windows.Forms.RadioButton()
        Me.grpbxGender = New System.Windows.Forms.GroupBox()
        Me.dtetimeBirthDte = New System.Windows.Forms.DateTimePicker()
        Me.grpbxGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        '
        'lblinitials
        '
        Me.lblinitials.AutoSize = True
        Me.lblinitials.Location = New System.Drawing.Point(12, 61)
        Me.lblinitials.Name = "lblinitials"
        Me.lblinitials.Size = New System.Drawing.Size(36, 13)
        Me.lblinitials.TabIndex = 1
        Me.lblinitials.Text = "Initials"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(12, 94)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblSurname.TabIndex = 2
        Me.lblSurname.Text = "Surname"
        '
        'lblAddrs
        '
        Me.lblAddrs.AutoSize = True
        Me.lblAddrs.Location = New System.Drawing.Point(12, 131)
        Me.lblAddrs.Name = "lblAddrs"
        Me.lblAddrs.Size = New System.Drawing.Size(45, 13)
        Me.lblAddrs.TabIndex = 3
        Me.lblAddrs.Text = "Address"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Location = New System.Drawing.Point(12, 171)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(52, 13)
        Me.lblBirthDate.TabIndex = 4
        Me.lblBirthDate.Text = "Birth date"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(15, 229)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 5
        Me.lblGender.Text = "Gender"
        '
        'txtbxTitle
        '
        Me.txtbxTitle.Location = New System.Drawing.Point(77, 16)
        Me.txtbxTitle.Name = "txtbxTitle"
        Me.txtbxTitle.Size = New System.Drawing.Size(113, 20)
        Me.txtbxTitle.TabIndex = 6
        '
        'txtbxinitials
        '
        Me.txtbxinitials.Location = New System.Drawing.Point(77, 54)
        Me.txtbxinitials.Name = "txtbxinitials"
        Me.txtbxinitials.Size = New System.Drawing.Size(113, 20)
        Me.txtbxinitials.TabIndex = 7
        '
        'txtbxSurname
        '
        Me.txtbxSurname.Location = New System.Drawing.Point(77, 87)
        Me.txtbxSurname.Name = "txtbxSurname"
        Me.txtbxSurname.Size = New System.Drawing.Size(113, 20)
        Me.txtbxSurname.TabIndex = 8
        '
        'txtbxAddrs
        '
        Me.txtbxAddrs.Location = New System.Drawing.Point(77, 124)
        Me.txtbxAddrs.Name = "txtbxAddrs"
        Me.txtbxAddrs.Size = New System.Drawing.Size(113, 20)
        Me.txtbxAddrs.TabIndex = 9
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(61, 279)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "S&ubmit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(158, 279)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'rdobtnMale
        '
        Me.rdobtnMale.AutoSize = True
        Me.rdobtnMale.Location = New System.Drawing.Point(6, 24)
        Me.rdobtnMale.Name = "rdobtnMale"
        Me.rdobtnMale.Size = New System.Drawing.Size(48, 17)
        Me.rdobtnMale.TabIndex = 14
        Me.rdobtnMale.TabStop = True
        Me.rdobtnMale.Text = "Male"
        Me.rdobtnMale.UseVisualStyleBackColor = True
        '
        'rdobtnFemale
        '
        Me.rdobtnFemale.AutoSize = True
        Me.rdobtnFemale.Location = New System.Drawing.Point(60, 24)
        Me.rdobtnFemale.Name = "rdobtnFemale"
        Me.rdobtnFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdobtnFemale.TabIndex = 15
        Me.rdobtnFemale.TabStop = True
        Me.rdobtnFemale.Text = "Female"
        Me.rdobtnFemale.UseVisualStyleBackColor = True
        '
        'grpbxGender
        '
        Me.grpbxGender.Controls.Add(Me.rdobtnMale)
        Me.grpbxGender.Controls.Add(Me.rdobtnFemale)
        Me.grpbxGender.Location = New System.Drawing.Point(77, 201)
        Me.grpbxGender.Name = "grpbxGender"
        Me.grpbxGender.Size = New System.Drawing.Size(130, 51)
        Me.grpbxGender.TabIndex = 16
        Me.grpbxGender.TabStop = False
        '
        'dtetimeBirthDte
        '
        Me.dtetimeBirthDte.Location = New System.Drawing.Point(77, 165)
        Me.dtetimeBirthDte.Name = "dtetimeBirthDte"
        Me.dtetimeBirthDte.Size = New System.Drawing.Size(113, 20)
        Me.dtetimeBirthDte.TabIndex = 17
        '
        'frmStdReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 323)
        Me.Controls.Add(Me.dtetimeBirthDte)
        Me.Controls.Add(Me.grpbxGender)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtbxAddrs)
        Me.Controls.Add(Me.txtbxSurname)
        Me.Controls.Add(Me.txtbxinitials)
        Me.Controls.Add(Me.txtbxTitle)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblBirthDate)
        Me.Controls.Add(Me.lblAddrs)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblinitials)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmStdReg"
        Me.Text = "Student Registration"
        Me.grpbxGender.ResumeLayout(False)
        Me.grpbxGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblinitials As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblAddrs As System.Windows.Forms.Label
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents txtbxTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtbxinitials As System.Windows.Forms.TextBox
    Friend WithEvents txtbxSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAddrs As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents rdobtnMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdobtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents grpbxGender As System.Windows.Forms.GroupBox
    Friend WithEvents dtetimeBirthDte As System.Windows.Forms.DateTimePicker
End Class
