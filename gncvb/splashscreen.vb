﻿Public Class splashscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label2.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = 100 Then

            Login.Show()
            Me.Hide()
            Timer1.Stop()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


End Class