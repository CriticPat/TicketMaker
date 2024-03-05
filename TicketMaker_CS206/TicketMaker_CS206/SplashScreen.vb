Public Class SplashScreen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerSplash.Tick
        If (pgbarSplash.Value = pgbarSplash.Maximum) Then
            timerSplash.Stop()
            Me.Hide()
            LoginScreen.Show()
        Else
            pgbarSplash.PerformStep()

        End If
    End Sub
End Class
