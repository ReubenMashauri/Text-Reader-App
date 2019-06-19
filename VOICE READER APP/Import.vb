Imports System.Speech.Synthesis
Imports System.IO
Public Class Import
    Dim synth As New SpeechSynthesizer
    Private Sub BtnChoose_Click(sender As Object, e As EventArgs) Handles BtnChoose.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            'ElseIf OpenFileDialog1.Filter = "PDF Files |*,pdf" Then
            'If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            'AxAcroPDF1.src = OpenFileDialog1.FileName
            'End If
        End If
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        synth.Rate = SpeechTrackBar.Value
        synth.Volume = VolumeTrackBar.Value
        'synthesizer.SelectVoiceByHints(VoiceGender.Female, );
        If PersonalomboBox.Text = "Male" Then
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child)
        End If
        If PersonalomboBox.Text = "Female" Then
            synth.SelectVoiceByHints(VoiceGender.Female)
        End If
        synth.SpeakAsync(TextBox1.Text)
        'synth.Speak(TextBox1.Text)
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        synth.Pause()
    End Sub

    Public Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        synth.SpeakAsyncCancelAll()
    End Sub

    Private Sub VolumeTrackBar_Scroll(sender As Object, e As EventArgs) Handles VolumeTrackBar.Scroll
        If VolumeTrackBar.Value = 0 Then
            Label1Vol.Text = "Muted"
            Exit Sub
        Else
            synth.Volume = VolumeTrackBar.Value
            Label1Vol.Text = VolumeTrackBar.Value & "%"
        End If

    End Sub

    Private Sub SpeechTrackBar_Scroll(sender As Object, e As EventArgs) Handles SpeechTrackBar.Scroll
        LabelSpeech.Text = SpeechTrackBar.Value & "%"
        synth.Rate = SpeechTrackBar.Value
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label1Vol.Click

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim fs As New FileStream(SaveFileDialog1.FileName, FileMode.Create, FileAccess.Write)
                synth.SetOutputToWaveStream(fs)
                synth.Speak(TextBox1.Text)
                synth.SetOutputToDefaultAudioDevice()
                fs.Close()
            Catch ex As Exception
                MsgBox("Error Occured When Saving Audio", MsgBoxStyle.Critical)
            End Try
            MsgBox("Successfully Converted To Audio", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Dispose()
    End Sub

    Private Sub BtnResume_Click(sender As Object, e As EventArgs) Handles BtnResume.Click
        synth.Resume()
    End Sub

    Private Sub PersonalomboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PersonalomboBox.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            BtnPlay.Enabled = False
            BtnResume.Enabled = False
            BtnPause.Enabled = False
            BtnStop.Enabled = False
            BtnChoose.Enabled = False
            BtnSave.Enabled = False
        Else

            BtnPlay.Enabled = True
            BtnResume.Enabled = True
            BtnPause.Enabled = True
            BtnStop.Enabled = True
            BtnChoose.Enabled = True
            BtnSave.Enabled = True
        End If
    End Sub
End Class