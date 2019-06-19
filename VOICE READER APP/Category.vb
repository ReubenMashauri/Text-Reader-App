Imports System.Speech.Synthesis
Imports System.IO
Public Class Category
    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BtnLove.Click
        With love
            .TopLevel = False
            PanelStory.Controls.Add(love)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnPolitical_Click(sender As Object, e As EventArgs) Handles BtnTravel.Click
        With Travel
            .TopLevel = False
            PanelStory.Controls.Add(Travel)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnThriller_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPlay_Click_1(sender As Object, e As EventArgs) Handles BtnPlay.Click
        Dim synth As New SpeechSynthesizer
        synth.Rate = SpeechTrackBar.Value
        synth.Volume = VolumeTrackBar.Value

        If PersonalomboBox.Text = "Male" Then
            synth.SelectVoiceByHints(VoiceGender.Male)
        End If
        If PersonalomboBox.Text = "Female" Then
            synth.SelectVoiceByHints(VoiceGender.Female)
        End If
        synth.Speak(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs)
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Cc_Click(sender As Object, e As EventArgs) Handles cc.Click

    End Sub

    Private Sub Ll_Click(sender As Object, e As EventArgs) Handles ll.Click

    End Sub

    Private Sub BtnAdventure_Click(sender As Object, e As EventArgs) Handles BtnAdventure.Click
        With adventure
            .TopLevel = False
            PanelStory.Controls.Add(adventure)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnComedy_Click(sender As Object, e As EventArgs) Handles BtnComedy.Click
        With Comedy
            .TopLevel = False
            PanelStory.Controls.Add(Comedy)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Rr_Click(sender As Object, e As EventArgs)

    End Sub
End Class