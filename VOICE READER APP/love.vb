Imports System.Speech.Synthesis
Imports System.IO
Public Class love
    Dim synth As New SpeechSynthesizer
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "panelLovee.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        synth.Rate = SpeechTrackBar.Value
        synth.Volume = VolumeTrackBar.Value

        If PersonalomboBox.Text = "Male" Then
            synth.SelectVoiceByHints(VoiceGender.Male)
        End If
        If PersonalomboBox.Text = "Female" Then
            synth.SelectVoiceByHints(VoiceGender.Female)
        End If
        synth.SpeakAsync(TextBox1.Text)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BtnResume_Click(sender As Object, e As EventArgs) Handles BtnResume.Click
        synth.Resume()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        synth.SpeakAsyncCancelAll()
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        synth.Pause()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            BtnPlay.Enabled = False
            BtnResume.Enabled = False
            BtnPause.Enabled = False
            BtnStop.Enabled = False
        Else

            BtnPlay.Enabled = True
            BtnResume.Enabled = True
            BtnPause.Enabled = True
            BtnStop.Enabled = True
        End If
    End Sub

    Private Sub SpeechTrackBar_Scroll(sender As Object, e As EventArgs) Handles SpeechTrackBar.Scroll
        sada.Text = SpeechTrackBar.Value & "%"
        synth.Rate = SpeechTrackBar.Value
    End Sub

    Private Sub VolumeTrackBar_Scroll(sender As Object, e As EventArgs) Handles VolumeTrackBar.Scroll
        If VolumeTrackBar.Value = 0 Then
            fia.Text = "Muted"
            Exit Sub
        Else
            synth.Volume = VolumeTrackBar.Value
            fia.Text = VolumeTrackBar.Value & "%"
        End If
    End Sub

    Private Sub Qq_Click(sender As Object, e As EventArgs) Handles qq.Click
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "Love Letters.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub

    Private Sub Rr_Click(sender As Object, e As EventArgs)
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "Mountain Man.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub

    Private Sub Cc_Click(sender As Object, e As EventArgs) Handles cc.Click
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "No Arm No Leg.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub

    Private Sub Ll_Click(sender As Object, e As EventArgs) Handles ll.Click
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "The Bicycle Ride.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub
End Class