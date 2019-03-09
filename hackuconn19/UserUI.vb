Public Class UserUI

    Public previous As New List(Of Integer)
    Public prevActionlbls As New List(Of Label)
    Public Actionlbls As New List(Of Label)

    Private Sub UserUI_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Size = New Size(Me.Width, 530)
        Me.Location = New Point(110 + Form1.Width, 100)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None

        'Setting initial sizes for the bar graph
        lblAction1.Top -= 58
        pnlAction1.Top -= 58
        pnlAction1.Height = 65

        lblAction2.Top -= 33
        pnlAction2.Top -= 33
        pnlAction2.Height = 40

        lblAction3.Top -= 47
        pnlAction3.Top -= 47
        pnlAction3.Height = 54

        lblAction4.Top -= 13
        pnlAction4.Top -= 13
        pnlAction4.Height = 20

        lblAction5.Top -= 33
        pnlAction5.Top -= 33
        pnlAction5.Height = 40

        previous.Add(10)
        previous.Add(5)
        previous.Add(8)
        previous.Add(2)
        previous.Add(4)

        prevActionlbls.Add(lblPrevAction1)
        prevActionlbls.Add(lblPrevAction2)
        prevActionlbls.Add(lblPrevAction3)
        prevActionlbls.Add(lblPrevAction4)
        prevActionlbls.Add(lblPrevAction5)

        Actionlbls.Add(lblAction1)
        Actionlbls.Add(lblAction2)
        Actionlbls.Add(lblAction3)
        Actionlbls.Add(lblAction4)
        Actionlbls.Add(lblAction5)

        updatePrevlbls()

    End Sub

    Public Sub updatePrevlbls()
        Dim temp As Integer = 0

        For i = 0 To 4
            temp = previous(i)
            temp = Math.Ceiling(100 * ((Actionlbls(i).Text - temp) / Actionlbls(i).Text))
            prevActionlbls(i).Text = temp.ToString() + "%"
        Next
        lblScore.Text += 3
    End Sub

    Private Sub UserUI_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Close()
    End Sub

    Private Sub lblSummary_Click(sender As Object, e As EventArgs) Handles lblSummary.Click
        Me.Close()
    End Sub

    Private Sub pbxAlert_Click(sender As Object, e As EventArgs) Handles pbxAlert.Click
        pbxAlert.Visible = False
        lblCalm.Visible = False
    End Sub
End Class