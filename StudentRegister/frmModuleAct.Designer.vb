<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuleAct
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
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.cmbxModule = New System.Windows.Forms.ComboBox()
        Me.cmbxSemester = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.chkbxActive = New System.Windows.Forms.CheckBox()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblModule
        '
        Me.lblModule.AutoSize = True
        Me.lblModule.Location = New System.Drawing.Point(12, 25)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(75, 13)
        Me.lblModule.TabIndex = 0
        Me.lblModule.Text = "Select Module"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(12, 55)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(62, 13)
        Me.lblYear.TabIndex = 1
        Me.lblYear.Text = "Select Year"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(12, 89)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(84, 13)
        Me.lblSemester.TabIndex = 2
        Me.lblSemester.Text = "Select Semester"
        '
        'cmbxModule
        '
        Me.cmbxModule.FormattingEnabled = True
        Me.cmbxModule.Location = New System.Drawing.Point(102, 17)
        Me.cmbxModule.Name = "cmbxModule"
        Me.cmbxModule.Size = New System.Drawing.Size(121, 21)
        Me.cmbxModule.TabIndex = 3
        '
        'cmbxSemester
        '
        Me.cmbxSemester.FormattingEnabled = True
        Me.cmbxSemester.Items.AddRange(New Object() {"Semester 1", "Semester 2"})
        Me.cmbxSemester.Location = New System.Drawing.Point(102, 81)
        Me.cmbxSemester.Name = "cmbxSemester"
        Me.cmbxSemester.Size = New System.Drawing.Size(121, 21)
        Me.cmbxSemester.TabIndex = 4
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(134, 159)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "S&ubmit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'chkbxActive
        '
        Me.chkbxActive.AutoSize = True
        Me.chkbxActive.Location = New System.Drawing.Point(102, 129)
        Me.chkbxActive.Name = "chkbxActive"
        Me.chkbxActive.Size = New System.Drawing.Size(15, 14)
        Me.chkbxActive.TabIndex = 7
        Me.chkbxActive.UseVisualStyleBackColor = True
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Location = New System.Drawing.Point(12, 130)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(46, 13)
        Me.lblActive.TabIndex = 8
        Me.lblActive.Text = "Activate"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(225, 159)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(102, 47)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'frmModuleAct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 195)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.chkbxActive)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cmbxSemester)
        Me.Controls.Add(Me.cmbxModule)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModule)
        Me.Name = "frmModuleAct"
        Me.Text = "Module Activation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModule As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents cmbxModule As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxSemester As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents chkbxActive As System.Windows.Forms.CheckBox
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
