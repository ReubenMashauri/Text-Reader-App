Imports System.Speech.Synthesis
Imports System.IO
Public Class Comedy
    Dim synth As New SpeechSynthesizer
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

    Private Sub Comedy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        sdsd.Text = SpeechTrackBar.Value & "%"
        synth.Rate = SpeechTrackBar.Value
    End Sub

    Private Sub VolumeTrackBar_Scroll(sender As Object, e As EventArgs) Handles VolumeTrackBar.Scroll
        If VolumeTrackBar.Value = 0 Then
            cate.Text = "Muted"
            Exit Sub
        Else
            synth.Volume = VolumeTrackBar.Value
            cate.Text = VolumeTrackBar.Value & "%"
        End If
    End Sub

    Private Sub Vc_Click(sender As Object, e As EventArgs) Handles vc.Click
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "All The Fish.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub

    Private Sub Bn_Click(sender As Object, e As EventArgs) Handles bn.Click
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "Drama Class.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub

    Private Sub Mj_Click(sender As Object, e As EventArgs) Handles mj.Click
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "Oh Semen.txt", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub

    Private Sub Lk_Click(sender As Object, e As EventArgs)
        Dim filename As Integer = FreeFile()
        Dim temps As String = ""
        Dim templ As String
        FileOpen(filename, "The Fake Cards", OpenMode.Input)
        Do Until EOF(filename)
            templ = LineInput(filename)
            temps += templ + vbCrLf
        Loop

        FileClose(filename)
        TextBox1.Text = temps
    End Sub
End Class