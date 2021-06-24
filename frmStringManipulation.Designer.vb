<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStringManipulation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.txtRecord = New System.Windows.Forms.TextBox()
        Me.btnCountVowels = New System.Windows.Forms.Button()
        Me.btnCountWords = New System.Windows.Forms.Button()
        Me.btnBreakApart = New System.Windows.Forms.Button()
        Me.btnFormatPhoneNumber = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtField1 = New System.Windows.Forms.TextBox()
        Me.txtField3 = New System.Windows.Forms.TextBox()
        Me.txtField5 = New System.Windows.Forms.TextBox()
        Me.txtField6 = New System.Windows.Forms.TextBox()
        Me.txtField4 = New System.Windows.Forms.TextBox()
        Me.txtField2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtFormattedPhone = New System.Windows.Forms.TextBox()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Step 1:"
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(54, 63)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(72, 17)
        Me.lblSentence.TabIndex = 1
        Me.lblSentence.Text = "Sentence:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Step 2:"
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Location = New System.Drawing.Point(54, 188)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(58, 17)
        Me.lblRecord.TabIndex = 3
        Me.lblRecord.Text = "Record:"
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(146, 60)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(383, 22)
        Me.txtSentence.TabIndex = 4
        '
        'txtRecord
        '
        Me.txtRecord.Location = New System.Drawing.Point(146, 185)
        Me.txtRecord.Name = "txtRecord"
        Me.txtRecord.Size = New System.Drawing.Size(383, 22)
        Me.txtRecord.TabIndex = 5
        '
        'btnCountVowels
        '
        Me.btnCountVowels.Location = New System.Drawing.Point(194, 97)
        Me.btnCountVowels.Name = "btnCountVowels"
        Me.btnCountVowels.Size = New System.Drawing.Size(114, 29)
        Me.btnCountVowels.TabIndex = 6
        Me.btnCountVowels.Text = "Count &Vowels"
        Me.btnCountVowels.UseVisualStyleBackColor = True
        '
        'btnCountWords
        '
        Me.btnCountWords.Location = New System.Drawing.Point(372, 97)
        Me.btnCountWords.Name = "btnCountWords"
        Me.btnCountWords.Size = New System.Drawing.Size(114, 29)
        Me.btnCountWords.TabIndex = 7
        Me.btnCountWords.Text = "Count &Words"
        Me.btnCountWords.UseVisualStyleBackColor = True
        '
        'btnBreakApart
        '
        Me.btnBreakApart.Location = New System.Drawing.Point(277, 213)
        Me.btnBreakApart.Name = "btnBreakApart"
        Me.btnBreakApart.Size = New System.Drawing.Size(114, 29)
        Me.btnBreakApart.TabIndex = 8
        Me.btnBreakApart.Text = "&Break Apart"
        Me.btnBreakApart.UseVisualStyleBackColor = True
        '
        'btnFormatPhoneNumber
        '
        Me.btnFormatPhoneNumber.Location = New System.Drawing.Point(239, 553)
        Me.btnFormatPhoneNumber.Name = "btnFormatPhoneNumber"
        Me.btnFormatPhoneNumber.Size = New System.Drawing.Size(186, 31)
        Me.btnFormatPhoneNumber.TabIndex = 9
        Me.btnFormatPhoneNumber.Text = "&Format Phone Number"
        Me.btnFormatPhoneNumber.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Field 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Field 3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Field 5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Field 6"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(325, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Field 4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(325, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Field 2"
        '
        'txtField1
        '
        Me.txtField1.Location = New System.Drawing.Point(153, 286)
        Me.txtField1.Name = "txtField1"
        Me.txtField1.Size = New System.Drawing.Size(135, 22)
        Me.txtField1.TabIndex = 16
        '
        'txtField3
        '
        Me.txtField3.Location = New System.Drawing.Point(153, 321)
        Me.txtField3.Name = "txtField3"
        Me.txtField3.Size = New System.Drawing.Size(135, 22)
        Me.txtField3.TabIndex = 17
        '
        'txtField5
        '
        Me.txtField5.Location = New System.Drawing.Point(153, 359)
        Me.txtField5.Name = "txtField5"
        Me.txtField5.Size = New System.Drawing.Size(135, 22)
        Me.txtField5.TabIndex = 18
        '
        'txtField6
        '
        Me.txtField6.Location = New System.Drawing.Point(394, 359)
        Me.txtField6.Name = "txtField6"
        Me.txtField6.Size = New System.Drawing.Size(135, 22)
        Me.txtField6.TabIndex = 21
        '
        'txtField4
        '
        Me.txtField4.Location = New System.Drawing.Point(394, 321)
        Me.txtField4.Name = "txtField4"
        Me.txtField4.Size = New System.Drawing.Size(135, 22)
        Me.txtField4.TabIndex = 20
        '
        'txtField2
        '
        Me.txtField2.Location = New System.Drawing.Point(394, 286)
        Me.txtField2.Name = "txtField2"
        Me.txtField2.Size = New System.Drawing.Size(135, 22)
        Me.txtField2.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(51, 441)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Step 3:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(89, 473)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Enter Phone Number:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(59, 511)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(175, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Formatted Phone Number:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(240, 470)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(183, 22)
        Me.txtPhoneNumber.TabIndex = 25
        '
        'txtFormattedPhone
        '
        Me.txtFormattedPhone.Location = New System.Drawing.Point(240, 508)
        Me.txtFormattedPhone.Name = "txtFormattedPhone"
        Me.txtFormattedPhone.Size = New System.Drawing.Size(183, 22)
        Me.txtFormattedPhone.TabIndex = 26
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(194, 646)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(95, 31)
        Me.btnClearForm.TabIndex = 27
        Me.btnClearForm.Text = "&Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(340, 646)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 31)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStringManipulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 715)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.txtFormattedPhone)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtField6)
        Me.Controls.Add(Me.txtField4)
        Me.Controls.Add(Me.txtField2)
        Me.Controls.Add(Me.txtField5)
        Me.Controls.Add(Me.txtField3)
        Me.Controls.Add(Me.txtField1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnFormatPhoneNumber)
        Me.Controls.Add(Me.btnBreakApart)
        Me.Controls.Add(Me.btnCountWords)
        Me.Controls.Add(Me.btnCountVowels)
        Me.Controls.Add(Me.txtRecord)
        Me.Controls.Add(Me.txtSentence)
        Me.Controls.Add(Me.lblRecord)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSentence)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStringManipulation"
        Me.Text = "String Manipulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblSentence As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRecord As Label
    Friend WithEvents txtSentence As TextBox
    Friend WithEvents txtRecord As TextBox
    Friend WithEvents btnCountVowels As Button
    Friend WithEvents btnCountWords As Button
    Friend WithEvents btnBreakApart As Button
    Friend WithEvents btnFormatPhoneNumber As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtField1 As TextBox
    Friend WithEvents txtField3 As TextBox
    Friend WithEvents txtField5 As TextBox
    Friend WithEvents txtField6 As TextBox
    Friend WithEvents txtField4 As TextBox
    Friend WithEvents txtField2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtFormattedPhone As TextBox
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnExit As Button
End Class
