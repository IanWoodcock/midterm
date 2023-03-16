Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = ""
        rbtnInToM.Checked = True
        lblOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decInput As Decimal
        Dim decOutput As Decimal

        If IsNumeric(txtInput.Text) Then
            decInput = Convert.ToDecimal(txtInput.Text)
            If decInput > 0 Then
                If rbtnInToM.Checked Then
                    decOutput = decInput / 39.37
                    lblOutput.Text = (txtInput.Text + " inches is " + Format(decOutput, "0.000") + " meters.")
                ElseIf rbtnMToIn.Checked Then
                    decOutput = decInput * 39.37
                    lblOutput.Text = (txtInput.Text + " meters is " + Format(decOutput, "0.000") + " inches.")
                End If
            Else
                MsgBox("Please enter a positive number to convert", , "Invalid Number Error")

            End If
        Else
            MsgBox("Please enter a number to convert", , "Invalid Entry Error")
        End If
    End Sub
End Class
