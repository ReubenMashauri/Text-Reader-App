Public Class splash
    Public Property Form1 As Object

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        splashProgress.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If splashProgress.Value = 20 Then
            Timer1.Stop()
            Me.Hide()
            Dim bb
            bb = Form1
            bb.Show()
            'Form1.Show()
        Else
            splashProgress.Value = splashProgress.Value + 1
        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label3.Click

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimizer_Click(sender As Object, e As EventArgs) Handles BtnMinimizer.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class