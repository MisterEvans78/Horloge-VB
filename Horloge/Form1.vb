Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim heure As String = Date.Now.Hour
        If heure < 10 And heure >= 0 Then
            heure = "0" & heure
        End If
        Dim minute As String = Date.Now.Minute
        If minute < 10 And minute >= 0 Then
            minute = "0" & minute
        End If
        Dim seconde As String = Date.Now.Second
        If seconde < 10 And seconde >= 0 Then
            seconde = "0" & seconde
        End If
        Label1.Text = heure & " : " & minute & " : " & seconde
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim heure2 As String = Date.Now.Hour
        If heure2 < 10 And heure2 >= 0 Then
            heure2 = "0" & heure2
        End If
        Dim minute2 As String = Date.Now.Minute
        If minute2 < 10 And minute2 >= 0 Then
            minute2 = "0" & minute2
        End If
        Label1.Text = heure2 & " : " & minute2
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        MsgBox("Horloge v1.20" & vbNewLine & "Développé par MisterEvans78", MsgBoxStyle.Information)
    End Sub

    Private Sub FondToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FondToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub TexteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TexteToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color
        Label2.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub DefautToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefautToolStripMenuItem.Click
        Me.BackColor = DefaultBackColor
        Label1.ForeColor = DefaultForeColor
        Label2.ForeColor = DefaultForeColor
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckBox1.Checked = True Then
            Timer2.Start()
            Timer1.Stop()
        Else
            Timer1.Start()
            Timer2.Stop()
        End If
    End Sub

    Private Sub MasquerLesSecondesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If CheckBox1.Checked = False Then
            CheckBox1.Checked = True
            Timer1.Stop()
            Timer2.Start()
        ElseIf CheckBox1.Checked = True Then
            CheckBox1.Checked = False
            Timer2.Stop()
            Timer1.Start()
        End If
    End Sub

    Private Sub MasquerLeTexteDaideToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If CheckBox1.Checked = False Then
            CheckBox1.Checked = True
            Label2.Hide()
        ElseIf CheckBox1.Checked = True Then
            CheckBox1.Checked = False
            Label2.Show()
        End If
    End Sub
End Class
