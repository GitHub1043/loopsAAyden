Public Class Form1

    Private Sub btnOver_Click(sender As Object, e As EventArgs) Handles btnOver.Click
        Dim intCount As Integer
        Dim intNumber As Integer
        Dim intOver As Integer

        For intCount = 1 To 5 Step 1
            intNumber = Val(InputBox("Enter A Number"))

            If intNumber > 3 Then
                intOver = intOver + 1
            End If
        Next

        MessageBox.Show("You Entered " & intOver & " Number(s) That Were Over 3")
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Randomize()
        Dim intDie1 As Integer
        Dim intDie2 As Integer
        Dim intTotal As Integer
        Dim intRolls As Integer

        Do
            intDie1 = Int(Rnd() * 6) + 1
            intDie2 = Int(Rnd() * 6) + 1
            intTotal = intDie1 + intDie2
            intRolls = intRolls + 1
        Loop Until intTotal = 12

        MessageBox.Show("It Took " & intRolls & " Roll(s) To Get A 12")
    End Sub

    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        Randomize()
        Dim intCount As Integer
        Dim intDie1 As Integer
        Dim intDie2 As Integer
        Dim intTotal As Integer
        Dim intRolls As Integer
        Dim intAverage As Integer
        Const TRIALS As Integer = 1000

        For intCount = 1 To TRIALS

            Do
                intDie1 = Int(Rnd() * 6) + 1
                intDie2 = Int(Rnd() * 6) + 1
                intTotal = intDie1 + intDie2
                intRolls = intRolls + 1
            Loop Until intTotal = 12

            intAverage = intRolls / TRIALS
        Next

        MessageBox.Show("It Took " & intAverage & " Roll(s) On Average To Get A 12")
    End Sub
End Class
