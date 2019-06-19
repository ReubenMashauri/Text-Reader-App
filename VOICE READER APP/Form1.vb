Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim connection As New MySqlConnection
    Dim command As New MySqlCommand
    Dim READER As MySqlDataReader
    'CODE YA KUHAMISHA APP
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub LblSign_Click(sender As Object, e As EventArgs) Handles LblSign.Click
        Dim xx
        xx = RegistrationForm
        Me.Hide()
        xx.Show()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        connection = New MySqlConnection("Server=localhost; username=root; password=; database=vra;")

        Try
            connection.Open()
            If Btnlog.Text = "" Then
                MsgBox("Please Enter Username", MessageBoxIcon.Warning)
            ElseIf Btnpass.Text = "" Then
                MsgBox("Please Enter Password", MessageBoxIcon.Warning)
            Else
                command = New MySqlCommand("select * from reg where USERNAME='" & Btnlog.Text & "' and PASSWORD='" & Btnpass.Text & "'", connection)
                READER = command.ExecuteReader
                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1
                End While

                If count = 1 Then
                    MsgBox("Successfully Login", MessageBoxIcon.Information)
                    Btnlog.Text = ""
                    Btnpass.Text = ""
                    Dim bb
                    bb = HomeForm
                    Me.Hide()
                    bb.Show()
                ElseIf count > 1 Then
                    MsgBox("Username And Password Are Duplicate", MessageBoxIcon.Warning)
                Else
                    MsgBox("Username And Password Are Not Correct", MessageBoxIcon.Error)
                    Btnlog.Text = ""
                    Btnpass.Text = ""
                End If

            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)
        Finally
            connection.Dispose()
        End Try

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim rslt = MessageBox.Show("Are You Sure You Want To Close An Application", "Voice Reader App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rslt = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        'CODE YA KUHAMISHA POSITION YA APP
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnMinimizer_Click(sender As Object, e As EventArgs) Handles BtnMinimizer.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class
