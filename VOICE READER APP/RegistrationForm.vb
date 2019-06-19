Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class RegistrationForm
    Dim connection As New MySqlConnection
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim gender As String

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub
    Private Sub BtnDash_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs)
        Dim dd
        dd = LoginForm
        Me.Hide()
        dd.Show()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnMinimizer_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnSubmit_Click_1(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        connection = New MySqlConnection("Server=localhost; username=root; password=; database=vra")
        Try
            connection.Open()
            Dim Query As String
            If TextBox1.Text = "" Then
                MsgBox("Please Enter The Username", MessageBoxIcon.Exclamation)
            ElseIf TextBox2.Text = "" Then
                MsgBox("Please Enter Country", MessageBoxIcon.Exclamation)
            ElseIf gender = "" Then
                MsgBox("Please Enter Gender", MessageBoxIcon.Exclamation)
            ElseIf TextBox3.Text = "" Then
                MsgBox("Please Enter Email Address", MessageBoxIcon.Exclamation)
            ElseIf TextBox4.Text = "" Then
                MsgBox("Please Enter Phone Number", MessageBoxIcon.Exclamation)
            ElseIf TextBox5.Text = "" Then
                MsgBox("Please Enter Password", MessageBoxIcon.Exclamation)
            Else
                Query = "INSERT INTO reg(USERNAME,COUNTRY,GENDER,EMAILADRESS,PHONENUMBER,PASSWORD) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & gender & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
                command = New MySqlCommand(Query, connection)
                reader = command.ExecuteReader()
                MsgBox("You Have Successfully Registered", MessageBoxIcon.Information)
                'cleat the text boxes
                TextBox1.Text = ""
                TextBox2.Text = ""
                gender = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                Dim ma
                ma = LoginForm
                Me.Hide()
                ma.Show()
                connection.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim rslt = MessageBox.Show("Are You Sure You Want To Close An Application", "Voice Reader App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rslt = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnMinimizer_Click_1(sender As Object, e As EventArgs) Handles BtnMinimizer.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel4_MouseMove_1(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        'Mouse Move
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnClear_Click_1(sender As Object, e As EventArgs) Handles BtnClear.Click
        'cleat the text boxes
        TextBox1.Text = ""
        TextBox2.Text = ""
        gender = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub

    Private Sub Male_CheckedChanged(sender As Object, e As EventArgs) Handles Male.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub Female_CheckedChanged(sender As Object, e As EventArgs) Handles Female.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim back
        back = LoginForm
        Me.Hide()
        back.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel3_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
