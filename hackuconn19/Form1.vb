Public Class Form1

    Public anxietyCounter As Integer = 0
    Public streak As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        UserUI.Show()
        Me.Location = New Point(100, 100)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        resetButtons()
    End Sub

    Private Sub btnAction1_Click(sender As Object, e As EventArgs) Handles btnAction1.Click
        If buttonsOn() Then
            resetButtons()
        Else
            lblThankYou.Visible = False
        End If
        btnAction1.BackColor = Color.Blue
        btnAction1.ForeColor = Color.White
    End Sub

    Private Sub btnAction2_Click(sender As Object, e As EventArgs) Handles btnAction2.Click
        If buttonsOn() Then
            resetButtons()
        Else
            lblThankYou.Visible = False
        End If
        btnAction2.BackColor = Color.Blue
        btnAction2.ForeColor = Color.White
    End Sub

    Private Sub btnAction3_Click(sender As Object, e As EventArgs) Handles btnAction3.Click
        If buttonsOn() Then
            resetButtons()
        Else
            lblThankYou.Visible = False
        End If
        btnAction3.BackColor = Color.Blue
        btnAction3.ForeColor = Color.White
    End Sub

    Private Sub btnAction4_Click(sender As Object, e As EventArgs) Handles btnAction4.Click
        If buttonsOn() Then
            resetButtons()
        Else
            lblThankYou.Visible = False
        End If
        btnAction4.BackColor = Color.Blue
        btnAction4.ForeColor = Color.White
    End Sub

    Private Sub btnAction5_Click(sender As Object, e As EventArgs) Handles btnAction5.Click
        If buttonsOn() Then
            resetButtons()
        Else
            lblThankYou.Visible = False
        End If
        btnAction5.BackColor = Color.Blue
        btnAction5.ForeColor = Color.White
    End Sub

    Private Sub resetButtons()
        btnAction1.BackColor = DefaultBackColor
        btnAction1.ForeColor = Color.Black
        btnAction2.BackColor = DefaultBackColor
        btnAction2.ForeColor = Color.Black
        btnAction3.BackColor = DefaultBackColor
        btnAction3.ForeColor = Color.Black
        btnAction4.BackColor = DefaultBackColor
        btnAction4.ForeColor = Color.Black
        btnAction5.BackColor = DefaultBackColor
        btnAction5.ForeColor = Color.Black
        lblThankYou.Visible = False
        'dissipateAlert()
    End Sub

    Private Sub btnHappy_Click(sender As Object, e As EventArgs) Handles btnHappy.Click
        If buttonsOn() Then
            TransferData()
            resetButtons()
            lblThankYou.Visible = True
        End If
    End Sub

    Private Function buttonsOn()
        If btnAction1.BackColor <> DefaultBackColor Or btnAction2.BackColor <> DefaultBackColor Or btnAction3.BackColor <> DefaultBackColor Or btnAction4.BackColor <> DefaultBackColor Or btnAction5.BackColor <> DefaultBackColor Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnMeh_Click(sender As Object, e As EventArgs) Handles btnMeh.Click
        If buttonsOn() Then
            TransferData()
            resetButtons()
            lblThankYou.Visible = True
        End If
    End Sub

    Private Sub btnUpset_Click(sender As Object, e As EventArgs) Handles btnUpset.Click
        If buttonsOn() Then
            TransferData()
            resetButtons()
            lblThankYou.Visible = True
        End If
    End Sub

    Private Sub TransferData()
        If btnAction1.BackColor <> DefaultBackColor Then
            UserUI.lblAction1.Top -= 14
            UserUI.lblAction1.Text += 1
            UserUI.pnlAction1.Top -= 14
            UserUI.pnlAction1.Height += 14
        ElseIf btnAction2.BackColor <> DefaultBackColor Then
            UserUI.lblAction2.Top -= 14
            UserUI.lblAction2.Text += 1
            UserUI.pnlAction2.Top -= 14
            UserUI.pnlAction2.Height += 14
            displayAlert()
            If anxietyCounter > 1 Then
                displayResouces()
            End If
        ElseIf btnAction3.BackColor <> DefaultBackColor Then
            UserUI.lblAction3.Top -= 14
            UserUI.lblAction3.Text += 1
            UserUI.pnlAction3.Top -= 14
            UserUI.pnlAction3.Height += 14
        ElseIf btnAction4.BackColor <> DefaultBackColor Then
            UserUI.lblAction4.Top -= 14
            UserUI.lblAction4.Text += 1
            UserUI.pnlAction4.Top -= 14
            UserUI.pnlAction4.Height += 14
        ElseIf btnAction5.BackColor <> DefaultBackColor Then
            UserUI.lblAction5.Top -= 14
            UserUI.lblAction5.Text += 1
            UserUI.pnlAction5.Top -= 14
            UserUI.pnlAction5.Height += 14
        End If

        streak += 1
        If streak > 2 Then
            displayBonus()
            streak = 0
        End If
        UserUI.updatePrevlbls()

    End Sub

    Private Sub displayAlert()
        UserUI.pbxAlert.Location = New Point(UserUI.pbxAlert.Location.X, 410)
        UserUI.lblCalm.Location = New Point(UserUI.lblCalm.Location.X, 410)

        UserUI.pbxAlert.Visible = True
        UserUI.lblCalm.Visible = True

        anxietyCounter += 1

    End Sub

    Private Sub displayResouces()
        UserUI.pbxAlert.Location = New Point(UserUI.pbxAlert.Location.X - 15, 410)
        UserUI.lblResource.Location = New Point(UserUI.lblResource.Location.X - 15, 410)

        UserUI.pbxAlert.Visible = True
        UserUI.lblCalm.Visible = False
        UserUI.lblResource.Visible = True
    End Sub

    Private Sub displayBonus()
        UserUI.pbxCoin.Location = New Point(UserUI.pbxCoin.Location.X - 15, 410)
        UserUI.lblBonus.Location = New Point(UserUI.lblBonus.Location.X - 15, 410)

        UserUI.pbxCoin.Visible = True
        UserUI.lblBonus.Visible = True
        UserUI.lblScore.Text += 50
    End Sub

End Class
