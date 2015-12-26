Public Class Form1

    Dim score1 As Integer = 0
    Dim score2 As Integer = 0
    Dim quantity1 As Integer = 0
    Dim quantity2 As Integer = 0
    Dim arrayrow As Integer = 5000
    Dim myarray(arrayrow) As Integer
    Dim itemcollected As Integer = 0
    Dim winner(arrayrow) As String
    Dim results As Integer = 0
    Private Sub btnPlayer1_Click(sender As Object, e As EventArgs) Handles btnPlayer1.Click

        'number of attempts to get 100
        For count As Integer = 0 To arrayrow - 1
            If count = 0 Then
                quantity1 += 1
                lblRandom1.Text = quantity1.ToString
            End If
        Next

        'disabling player 2 until player 1 reaches 100 randomly
        btnPlayer1.Enabled = False
        Randomize()
        score1 = CInt(Int((6 * Rnd()) + 1))
        btnPlayer2.Enabled = True

        'to show images
        lblScore1.Text += score1
        If score1 = 6 Then
            pxbxDice6.Visible = True
            pxbxDice1.Visible = False
            pxbxDice2.Visible = False
            pxbxDice3.Visible = False
            pxbxDice4.Visible = False
            pxbxDice5.Visible = False
            pxbxMain.Visible = False
        ElseIf score1 = 5 Then
            pxbxDice5.Visible = True
            pxbxDice1.Visible = False
            pxbxDice2.Visible = False
            pxbxDice3.Visible = False
            pxbxDice4.Visible = False
            pxbxMain.Visible = False
            pxbxDice6.Visible = False
        ElseIf score1 = 4 Then
            pxbxDice4.Visible = True
            pxbxDice1.Visible = False
            pxbxDice2.Visible = False
            pxbxDice3.Visible = False
            pxbxMain.Visible = False
            pxbxDice5.Visible = False
            pxbxDice6.Visible = False
        ElseIf score1 = 3 Then
            pxbxDice3.Visible = True
            pxbxDice1.Visible = False
            pxbxDice2.Visible = False
            pxbxMain.Visible = False
            pxbxDice4.Visible = False
            pxbxDice5.Visible = False
            pxbxDice6.Visible = False
        ElseIf score1 = 2 Then
            pxbxDice2.Visible = True
            pxbxDice1.Visible = False
            pxbxMain.Visible = False
            pxbxDice3.Visible = False
            pxbxDice4.Visible = False
            pxbxDice5.Visible = False
            pxbxDice6.Visible = False
        ElseIf score1 = 1 Then
            pxbxDice1.Visible = True
            pxbxMain.Visible = False
            pxbxDice2.Visible = False
            pxbxDice3.Visible = False
            pxbxDice4.Visible = False
            pxbxDice5.Visible = False
            pxbxDice6.Visible = False
        End If

        'enable the next button once it reaches 100
        If lblScore1.Text >= 100 Then
            lblResultPly1.Visible = True
            btnPlayer1.Enabled = False
            btnPlayer2.Enabled = False
            results = quantity1
        End If

        'collect results
        myarray(itemcollected) = CInt(results)
        itemcollected += 1

        'sort items in textbox
        Dim temporary As Integer
        If itemcollected > 1 Then
            For loops = 0 To arrayrow - 1
                For count As Integer = 0 To itemcollected - 2

                    If myarray(count) < myarray(count + 1) Then
                        temporary = myarray(count)
                        myarray(count) = myarray(count + 1)
                        myarray(count + 1) = temporary
                        winner(count) = txtbxP1.Text
                    End If

                Next
            Next loops
        End If

        'displays the score in the listbox
        lstbxHiScores.Items.Clear()
        For count As Integer = 0 To arrayrow - 4996

            lstbxHiScores.Items.Add(myarray(count).ToString & "   " & winner(count))

        Next

    End Sub
    Private Sub btnPlayer2_Click(sender As Object, e As EventArgs) Handles btnPlayer2.Click

        'number of attempts to get 100
        For count As Integer = 0 To arrayrow - 1
            If count = 0 Then
                quantity2 += 1
                lblRandom2.Text = quantity2.ToString
            End If
        Next

        'disabling player 1 until player 2 reaches 100 randomly
        btnPlayer2.Enabled = False
        Randomize()
        score2 = CInt(Int((6 * Rnd()) + 1))
        btnPlayer1.Enabled = True

        'to show images
        lblScore2.Text += score2
        If score2 = 6 Then
            pxbxDice6.Visible = True
            pxbxDice1.Visible = False
            pxbxDice2.Visible = False
            pxbxDice3.Visible = False
            pxbxDice4.Visible = False
            pxbxDice5.Visible = False
            pxbxMain.Visible = False
        ElseIf score2 = 5 Then
            pxbxDice5.Visible = True
            pxbxDice1.Visible = False
            pxbxDice2.Visible = False
            pxbxDice3.Visible = False
            pxbxDice4.Visible = False
            pxbxMain.Visible = False
            pxbxDice6.Visible = False
        ElseIf score2 = 4 Then
            pxbxDice4.Visible = True
            pxbxDice1.Visible = False
            pxbxDice2.Visible = False
            pxbxDice3.Visible = False
            pxbxMain.Visible = False
            pxbxDice5.Visible = False
            pxbxDice6.Visible = False
        ElseIf score2 = 3 Then
            pxbxDice3.Visible = True
            pxbxDice1.Visible = False
            pxbxDice2.Visible = False
            pxbxMain.Visible = False
            pxbxDice4.Visible = False
            pxbxDice5.Visible = False
            pxbxDice6.Visible = False
        ElseIf score2 = 2 Then
            pxbxDice2.Visible = True
            pxbxDice1.Visible = False
            pxbxMain.Visible = False
            pxbxDice3.Visible = False
            pxbxDice4.Visible = False
            pxbxDice5.Visible = False
            pxbxDice6.Visible = False
        ElseIf score2 = 1 Then
            pxbxDice1.Visible = True
            pxbxMain.Visible = False
            pxbxDice2.Visible = False
            pxbxDice3.Visible = False
            pxbxDice4.Visible = False
            pxbxDice5.Visible = False
            pxbxDice6.Visible = False
        End If


        'enable the next button once it reaches 100
        If lblScore2.Text >= 100 Then
            lblResultPly2.Visible = True
            btnPlayer1.Enabled = False
            btnPlayer2.Enabled = False
            results = quantity2

        End If

        'displays the score in the listbox
        lstbxHiScores.Items.Clear()
        For count As Integer = 0 To arrayrow - 4996

            lstbxHiScores.Items.Add(myarray(count).ToString & "   " & winner(count))

        Next

    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'players must enter their names to continue playing
        If txtbxP1.Text = "" Then
            MsgBox("Please Enter Player 1 Name")
        ElseIf txtbxP2.Text = "" Then
            MsgBox("Please Enter Player 2 Name")
        Else
            lblP1.Text = txtbxP1.Text
            lblP2.Text = txtbxP2.Text
            btnClear.Enabled = True
            btnRestart.Enabled = True
            btnStart.Enabled = False
            btnPlayer1.Enabled = True
            btnPlayer2.Enabled = True
            txtbxP1.Enabled = False
            txtbxP2.Enabled = False
        End If

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtbxP1.Clear()
        txtbxP2.Clear()
        lblRandom1.Text = "0"
        lblRandom2.Text = "0"
        lblScore1.Text = "0"
        lblScore2.Text = "0"
        lblP1.Text = "Player 1"
        lblP2.Text = "Player 2"
        results = 0
        score1 = 0
        score2 = 0
        quantity1 = 0
        quantity2 = 0
        btnPlayer1.Enabled = False
        btnPlayer2.Enabled = False
        pxbxMain.Visible = True

        'lblResultPly are not shown because it only shows up on top of the player who won.
        lblResultPly1.Visible = False
        lblResultPly2.Visible = False
        btnStart.Enabled = True
        btnClear.Enabled = False
        btnRestart.Enabled = False
        txtbxP1.Enabled = True
        txtbxP2.Enabled = True
    End Sub
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        'restart game name of players are maintained
        lblRandom1.Text = "0"
        lblRandom2.Text = "0"
        lblScore1.Text = "0"
        lblScore2.Text = "0"

        'lblResultPly are not shown because it only shows up on top of the player who won.
        lblResultPly1.Visible = False
        lblResultPly2.Visible = False
        btnPlayer1.Enabled = True
        btnPlayer2.Enabled = True
        results = 0
        score1 = 0
        score2 = 0
        quantity1 = 0
        quantity2 = 0
        pxbxMain.Visible = True
    End Sub
    Private Sub txtbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbxSearch.TextChanged
        lstbxHiScores1.Visible = True
        lstbxHiScores1.Items.Clear()
        For Each item In lstbxHiScores.Items
            If item.contains(txtbxSearch.Text) Then
                lstbxHiScores1.Items.Add(item)
            End If
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstbxHiScores1.Visible = False
        For Each item In lstbxHiScores.Items
            lstbxHiScores1.Items.Add(item)
        Next
    End Sub

End Class
