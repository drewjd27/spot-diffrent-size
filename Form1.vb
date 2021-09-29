Public Class Form1
    Dim target As Integer
    Dim t1 As Integer = 0
    Dim t2 As Integer = 0
    Dim t3 As Integer = 0
    Dim t4 As Integer = 0
    Dim t5 As Integer = 0
    Dim t6 As Integer = 0
    Dim t7 As Integer = 0
    Dim random As Random

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Sub keadaanawal()
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        bar1.Width = 137
        bar2.Width = 137
        bar3.Width = 137
        bar4.Width = 137
        bar5.Width = 137
        bar6.Width = 137
        bar1.Enabled = False
        bar2.Enabled = False
        bar3.Enabled = False
        bar4.Enabled = False
        bar5.Enabled = False
        bar6.Enabled = False
        label0.Visible = True
        label0.Text = "Klik START untuk memulai!"
        start.Visible = True
        waktuanda.Visible = False
        penghitungwaktu.Visible = False
        playagain.Visible = False
        penghitungwaktu.Text = 0
        t7 = 0
    End Sub

    Sub acak()
        random = New Random
        target = random.Next(1, 6)

        If target = 1 Then
            Timer1.Start()
        ElseIf target = 2 Then
            Timer2.Start()
        ElseIf target = 3 Then
            Timer3.Start()
        ElseIf target = 4 Then
            Timer4.Start()
        ElseIf target = 5 Then
            Timer5.Start()
        ElseIf target = 6 Then
            Timer6.Start()
        End If
    End Sub

    Private Sub start_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles start.Click
        Call acak()
        Timer7.Start()
        bar1.Enabled = True
        bar2.Enabled = True
        bar3.Enabled = True
        bar4.Enabled = True
        bar5.Enabled = True
        bar6.Enabled = True
        label0.Text = "Silahkan pilih bar yang terpanjang!"
        start.Visible = False
        penghitungwaktu.Visible = True
        waktuanda.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
        t1 = t1 + 1
        bar1.Width = bar1.Width + 1
        If bar1.Width = 140 Then
            Timer1.Stop()
            t1 = 0
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        t2 = t2 + 1
        bar2.Width = bar2.Width + 1
        If bar2.Width = 140 Then
            Timer2.Stop()
            t2 = 0
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        t3 = t3 + 1
        bar3.Width = bar2.Width + 1
        If bar3.Width = 140 Then
            Timer3.Stop()
            t3 = 0
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        t4 = t4 + 1
        bar4.Width = bar4.Width + 1
        If bar4.Width = 140 Then
            Timer4.Stop()
            t4 = 0
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        t5 = t5 + 1
        bar5.Width = bar5.Width + 1
        If bar5.Width = 140 Then
            Timer5.Stop()
            t5 = 0
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        t6 = t6 + 1
        bar6.Width = bar6.Width + 1
        If bar6.Width = 140 Then
            Timer6.Stop()
            t6 = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call keadaanawal()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        t7 = t7 + 1
        penghitungwaktu.Text = t7
    End Sub

    Private Sub circle1_Click(sender As Object, e As EventArgs) Handles bar1.Click
        If bar1.Width = 137 Then
            Form3.Show()
        ElseIf bar1.Width > 137 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub

    Private Sub circle2_Click(sender As Object, e As EventArgs) Handles bar2.Click
        If bar2.Width = 137 Then
            Form3.Show()
        ElseIf bar2.Width > 137 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub

    Private Sub circle3_Click(sender As Object, e As EventArgs) Handles bar3.Click
        If bar3.Width = 137 Then
            Form3.Show()
        ElseIf bar3.Width > 137 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub
    Private Sub circle4_Click(sender As Object, e As EventArgs) Handles bar4.Click
        If bar4.Width = 137 Then
            Form3.Show()
        ElseIf bar4.Width > 137 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub

    Private Sub circle5_Click(sender As Object, e As EventArgs) Handles bar5.Click
        If bar5.Width = 137 Then
            Form3.Show()
        ElseIf bar5.Width > 137 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub

    Private Sub circle6_Click(sender As Object, e As EventArgs) Handles bar6.Click
        If bar6.Width = 137 Then
            Form3.Show()
        ElseIf bar6.Width > 137 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub
    Private Sub playagain_Click(sender As Object, e As EventArgs) Handles playagain.Click
        Call keadaanawal()
    End Sub
End Class