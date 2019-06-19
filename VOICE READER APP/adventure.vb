Imports System.Speech.Synthesis
Imports System.IO
Public Class adventure
    Dim synth As New SpeechSynthesizer
    Private Sub Button1_Click(sender As Object, e As EventArgs)

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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles vol.Click

    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        synth.Pause()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        synth.SpeakAsyncCancelAll()
    End Sub

    Private Sub Adventure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BtnResume_Click(sender As Object, e As EventArgs) Handles BtnResume.Click
        synth.Resume()
    End Sub

    Private Sub SpeechTrackBar_Scroll(sender As Object, e As EventArgs) Handles SpeechTrackBar.Scroll
        ss.Text = SpeechTrackBar.Value & "%"
        synth.Rate = SpeechTrackBar.Value
    End Sub

    Private Sub VolumeTrackBar_Scroll(sender As Object, e As EventArgs) Handles VolumeTrackBar.Scroll
        If VolumeTrackBar.Value = 0 Then
            vol.Text = "Muted"
            Exit Sub
        Else
            synth.Volume = VolumeTrackBar.Value
            vol.Text = VolumeTrackBar.Value & "%"
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles aa.Click
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "A Summer's Day.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Qw_Click(sender As Object, e As EventArgs) Handles qw.Click
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "Prickly leaves.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub

    Private Sub Gf_Click(sender As Object, e As EventArgs) Handles gf.Click
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "Green eyes.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub
End Class