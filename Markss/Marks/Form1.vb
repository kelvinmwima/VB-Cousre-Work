Public Class Form1
    Private Sub btnevalute_Click(sender As Object, e As EventArgs) Handles btnevalute.Click


        'code to hold the marks

        Dim marks As Integer = txtenterMarks.Text

        If Integer.TryParse(txtenterMarks.Text, marks) Then

            'check if the mark exceeds 100, if so let a message box display the message

            If marks > 100 Then
                MessageBox.Show("Wrong entry, Please re-enter the mark.")
                txtenterMarks.Clear()
                txtenterMarks.Focus()

                'solution code for the marks entery

            ElseIf marks >= 90 AndAlso marks <= 100 Then
                txtgrade.Text = "Excellent"
            ElseIf marks >= 80 AndAlso marks <= 89 Then
                txtgrade.Text = "Very Good"
            ElseIf marks >= 70 AndAlso marks <= 79 Then
                txtgrade.Text = "Good"
            ElseIf marks >= 60 AndAlso marks <= 69 Then
                txtgrade.Text = "medium"
            ElseIf marks >= 50 AndAlso marks <= 59 Then
                txtgrade.Text = "Pass"
            ElseIf marks >= 0 AndAlso marks <= 49 Then
                txtgrade.Text = "Fail"

            End If



        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtenterMarks_TextChanged(sender As Object, e As EventArgs) Handles txtenterMarks.TextChanged

    End Sub
End Class
