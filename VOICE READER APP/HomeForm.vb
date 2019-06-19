Imports System.Runtime.InteropServices
Imports System.Speech.Synthesis
Imports System.IO
Public Class HomeForm
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub
    Public Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim gg
        DashBoard.Dispose()
        Category.Dispose()
        Import.Dispose()

        gg = LoginForm
        Me.Hide()
        Dim unused = gg.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnMinimizer_Click(sender As Object, e As EventArgs) Handles BtnMinimizer.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim rslt = MessageBox.Show("Are You Sure You Want To Close An Application", "Voice Reader App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rslt = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub BtnDash_Click(sender As Object, e As EventArgs) Handles BtnDash.Click
        With DashBoard
            .TopLevel = False
            Panelss.Controls.Add(DashBoard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click
        With Import
            .TopLevel = False
            Panelss.Controls.Add(Import)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Btnthemes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCategory_Click(sender As Object, e As EventArgs) Handles BtnCategory.Click

        With Category
            .TopLevel = False
            Panelss.Controls.Add(Category)
            Category.BringToFront()
            Category.Show()
        End With
    End Sub

    Private Sub Panelss_Paint(sender As Object, e As PaintEventArgs) Handles Panelss.Paint
        With DashBoard
            .TopLevel = False
            Panelss.Controls.Add(DashBoard)
            .BringToFront()
            .Show()
        End With
    End Sub


End Class