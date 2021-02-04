Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declare variables
        Const intNICKEL_CENT As Integer = 5
        Const intDIME_CENT As Integer = 10
        Const intQUARTER_CENT As Integer = 25
        Const intDOLLAR_CENT As Integer = 100
        Dim intPennies, intNickels, intDimes, intQuarters, intDollars As Integer

        'Get input
        Integer.TryParse(txtPennies.Text, intPennies)

        'Convert
        ''Get number of Dollars
        intDollars = intPennies \ intDOLLAR_CENT
        intPennies = intPennies Mod intDOLLAR_CENT

        ''Get number of Quarters
        intQuarters = intPennies \ intQUARTER_CENT
        intPennies = intPennies Mod intQUARTER_CENT

        ''Get number Dimes
        intDimes = intPennies \ intDIME_CENT
        intPennies = intPennies Mod intDIME_CENT

        ''Get number of Nickels
        intNickels = intPennies \ intNICKEL_CENT
        intPennies = intPennies Mod intNICKEL_CENT

        'Display All
        txtDollars.Text = intDollars.ToString
        txtQuarters.Text = intQuarters.ToString
        txtDimes.Text = intDimes.ToString
        txtNickels.Text = intNickels.ToString
        txtPenniesLeft.Text = intPennies.ToString
    End Sub

    Private Sub txtPennies_TextChanged(sender As Object, e As EventArgs) Handles txtPennies.TextChanged
        resetForm()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPennies.Clear()
        resetForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub resetForm()
        txtDollars.Clear()
        txtQuarters.Clear()
        txtDimes.Clear()
        txtNickels.Clear()
        txtPenniesLeft.Clear()
    End Sub

    Private Sub txtPennies_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPennies.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            btnCalculate.PerformClick()
        End If
    End Sub
End Class
