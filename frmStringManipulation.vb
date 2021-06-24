'*********************************************
' Neina Cichon
' June 14, 2020
' String Manipulation
'*********************************************


Public Class frmStringManipulation
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes Program
        Close()

    End Sub

    Private Sub btnCountVowels_Click(sender As Object, e As EventArgs) Handles btnCountVowels.Click

        'Declare Variables
        Dim strSentence As String

        'Call routines
        GetSentence(strSentence)
        CountVowels(strSentence)
        DisplayVowel(CountVowels(strSentence))

    End Sub

    'Gets Record from textbox and turns into string
    Sub GetRecord(ByRef Record As String)

        ' put text box value into string variable
        Record = txtRecord.Text

    End Sub

    'Gets Sentence from textbox and turns into string
    Sub GetSentence(ByRef Sentence As String)

        ' put text box value into string variable
        Sentence = txtSentence.Text

    End Sub

    'Calculation to get vowel count
    Private Function CountVowels(ByVal Sentence As String) As Integer

        'Declare variable
        Dim intVowels As Integer
        Dim strCurrentLetter As String

        'Change all characters to uppercase to make case-insensitive
        Sentence = Sentence.ToUpper()

        'Check for Vowels and calculate count
        For intindex = 0 To Sentence.Length - 1
            strCurrentLetter = Sentence.Substring(intindex, 1)
            If strCurrentLetter = "A" Or strCurrentLetter =
            "E" Or strCurrentLetter = "I" Or strCurrentLetter = "O" Or strCurrentLetter = "U" Then
                intVowels += 1
            End If
        Next

        Return intVowels
    End Function

    Sub DisplayVowel(ByVal VowelCount As Integer)

        ' display vowel count in Message box
        MessageBox.Show("Vowel Count is " & VowelCount)

    End Sub

    'Function to Count Words
    Private Function CountWords(ByVal Sentence As String) As Integer

        'Declare variable
        Dim intWords As Integer

        'Find words by spaces or end of Sentence punctuation.
        Dim strCurrentLetter As String
        Sentence = Sentence.ToLower()
        Sentence = Sentence.TrimEnd(" ", "?", ".", "!")
        For i = 0 To Sentence.Length - 1
            strCurrentLetter = Sentence.Substring(i, 1)
            If strCurrentLetter = " " Then
                intWords += 1
            End If
        Next

        Return intWords + 1

    End Function

    'Display the word count in Message Box
    Sub DisplayWord(ByVal WordCount As Integer)

        ' display value
        MessageBox.Show("Word Count is " & WordCount)

    End Sub


    Private Sub btnCountWords_Click(sender As Object, e As EventArgs) Handles btnCountWords.Click

        'Declare variable
        Dim strSentence As String

        'Call routines to get and word count
        GetSentence(strSentence)
        CountWords(strSentence)
        DisplayWord(CountWords(strSentence))

    End Sub


    Private Sub btnBreakApart_Click(sender As Object, e As EventArgs) Handles btnBreakApart.Click

        'Declare Variable
        Dim strRecord As String

        'Call routines to break apart comma delimited record and put into seperate textboxes
        GetRecord(strRecord)
        BreakApartRecord(strRecord)

    End Sub

    Private Sub BreakApartRecord(ByVal Record As String)

        ' Declare variables
        Dim intCount As Integer = 1
        Dim intIndex As Integer
        Dim strSubString As String

        ' Check for commas
        intIndex = Record.IndexOf(",")

        ' loop until no more commas
        Do Until intIndex = -1

            ' get characters up to comma
            strSubString = Record.Substring(0, intIndex)

            ' pass partial string and loop count to display routine
            DisplayValue(strSubString, intCount)


            ' Remove first sub-string and comma to find next comma
            Record = Record.Remove(0, intIndex + 1)

            ' increment loop counter to pass to DisplayValue Routine
            intCount += 1

            ' Get the index of the next comma. If no comma found will return -1
            intIndex = Record.IndexOf(",")

        Loop

        'clear the textbox
        txtRecord.Clear()

    End Sub

    Sub DisplayValue(ByVal SubString As String, ByVal LoopCount As Integer)

        ' display value in textboxes. Drop anything after 6th comma.
        If LoopCount = 1 Then
            txtField1.Text = SubString.Trim(" ")
        ElseIf LoopCount = 2 Then
            txtField2.Text = SubString.Trim(" ")
        ElseIf LoopCount = 3 Then
            txtField3.Text = SubString.Trim(" ")
        ElseIf LoopCount = 4 Then
            txtField4.Text = SubString.Trim(" ")
        ElseIf LoopCount = 5 Then
            txtField5.Text = SubString.Trim(" ")
        ElseIf LoopCount = 6 Then
            txtField6.Text = SubString.Trim(" ")
        End If

    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click

        'Clears the form
        txtSentence.Clear()
        txtRecord.Clear()
        txtPhoneNumber.Clear()
        txtFormattedPhone.Clear()
        txtField1.Clear()
        txtField2.Clear()
        txtField3.Clear()
        txtField4.Clear()
        txtField5.Clear()
        txtField6.Clear()

        'Sets Focus back up at top textbox
        txtSentence.Focus()

        'Sets textbox back to white in case of error
        txtPhoneNumber.BackColor = Color.White

    End Sub

    Private Sub btnFormatPhoneNumber_Click(sender As Object, e As EventArgs) Handles btnFormatPhoneNumber.Click

        'Declare Variable
        Dim strPhone As String

        'validate phone entry and call routines
        If ValidatePhone(strPhone) = True Then
            FormatPhone(strPhone)
            DisplayPhone(FormatPhone(strPhone))
        End If

    End Sub

    'Create Function to validate phone number
    Function ValidatePhone(ByRef Phone As String) As Boolean

        'Validating Numbers Only
        If IsNumeric(txtPhoneNumber.Text) Then
            Phone = txtPhoneNumber.Text
            'Validating 10 digits only
            If Phone.Length = 10 Then
                Return True
            Else
                MessageBox.Show("Please enter 10 digit phone number.") 'error message
                txtPhoneNumber.BackColor = Color.Yellow     'Set color to yellow
                txtPhoneNumber.Focus()    'set focus back to errored cell for user
                Return False
            End If
        Else
            MessageBox.Show("Please enter 10 digit phone number. Numbers Only!") 'error message
            txtPhoneNumber.BackColor = Color.Yellow     'Set color to yellow
            txtPhoneNumber.Focus()    'set focus back to errored cell for user
            Return False
        End If
    End Function

    Private Function FormatPhone(ByVal Phone As String) As String

        'Declare Variable
        FormatPhone = Phone

        'add formatting to phone number
        FormatPhone = FormatPhone.Insert(0, "(")
        FormatPhone = FormatPhone.Insert(4, ") ")
        FormatPhone = FormatPhone.Insert(9, "-")

        Return FormatPhone

    End Function

    Sub DisplayPhone(ByRef Phone As String)

        'Set Background colors back to white in case of error
        txtPhoneNumber.BackColor = Color.White

        'puts formatted phone number into Formatted Phone Textbox
        txtFormattedPhone.Text = Phone

    End Sub

End Class
