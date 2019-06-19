<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adventure
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gf = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.qw = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.aa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PersonalomboBox = New System.Windows.Forms.ComboBox()
        Me.vol = New System.Windows.Forms.Label()
        Me.VolumeTrackBar = New System.Windows.Forms.TrackBar()
        Me.ss = New System.Windows.Forms.Label()
        Me.SpeechTrackBar = New System.Windows.Forms.TrackBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnPause = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnPlay = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnStop = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnResume = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        CType(Me.VolumeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeechTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(788, 38)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 386)
        Me.VScrollBar1.TabIndex = 80
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.gf)
        Me.Panel1.Controls.Add(Me.qw)
        Me.Panel1.Controls.Add(Me.aa)
        Me.Panel1.Location = New System.Drawing.Point(1, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 393)
        Me.Panel1.TabIndex = 71
        '
        'gf
        '
        Me.gf.Activecolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.gf.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.gf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gf.BorderRadius = 0
        Me.gf.ButtonText = "Green Eyes"
        Me.gf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gf.DisabledColor = System.Drawing.Color.Gray
        Me.gf.Iconcolor = System.Drawing.Color.Transparent
        Me.gf.Iconimage = Nothing
        Me.gf.Iconimage_right = Nothing
        Me.gf.Iconimage_right_Selected = Nothing
        Me.gf.Iconimage_Selected = Nothing
        Me.gf.IconMarginLeft = 0
        Me.gf.IconMarginRight = 0
        Me.gf.IconRightVisible = True
        Me.gf.IconRightZoom = 0R
        Me.gf.IconVisible = True
        Me.gf.IconZoom = 90.0R
        Me.gf.IsTab = False
        Me.gf.Location = New System.Drawing.Point(0, 88)
        Me.gf.Margin = New System.Windows.Forms.Padding(4)
        Me.gf.Name = "gf"
        Me.gf.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.gf.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gf.OnHoverTextColor = System.Drawing.Color.White
        Me.gf.selected = False
        Me.gf.Size = New System.Drawing.Size(158, 36)
        Me.gf.TabIndex = 65
        Me.gf.Text = "Green Eyes"
        Me.gf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.gf.Textcolor = System.Drawing.Color.White
        Me.gf.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'qw
        '
        Me.qw.Activecolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.qw.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.qw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.qw.BorderRadius = 0
        Me.qw.ButtonText = "Prickly Leaves"
        Me.qw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.qw.DisabledColor = System.Drawing.Color.Gray
        Me.qw.Iconcolor = System.Drawing.Color.Transparent
        Me.qw.Iconimage = Nothing
        Me.qw.Iconimage_right = Nothing
        Me.qw.Iconimage_right_Selected = Nothing
        Me.qw.Iconimage_Selected = Nothing
        Me.qw.IconMarginLeft = 0
        Me.qw.IconMarginRight = 0
        Me.qw.IconRightVisible = True
        Me.qw.IconRightZoom = 0R
        Me.qw.IconVisible = True
        Me.qw.IconZoom = 90.0R
        Me.qw.IsTab = False
        Me.qw.Location = New System.Drawing.Point(0, 44)
        Me.qw.Margin = New System.Windows.Forms.Padding(4)
        Me.qw.Name = "qw"
        Me.qw.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.qw.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.qw.OnHoverTextColor = System.Drawing.Color.White
        Me.qw.selected = False
        Me.qw.Size = New System.Drawing.Size(158, 36)
        Me.qw.TabIndex = 64
        Me.qw.Text = "Prickly Leaves"
        Me.qw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.qw.Textcolor = System.Drawing.Color.White
        Me.qw.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'aa
        '
        Me.aa.Activecolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.aa.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.aa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.aa.BorderRadius = 0
        Me.aa.ButtonText = "A Summer's Day"
        Me.aa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aa.DisabledColor = System.Drawing.Color.Gray
        Me.aa.Iconcolor = System.Drawing.Color.Transparent
        Me.aa.Iconimage = Nothing
        Me.aa.Iconimage_right = Nothing
        Me.aa.Iconimage_right_Selected = Nothing
        Me.aa.Iconimage_Selected = Nothing
        Me.aa.IconMarginLeft = 0
        Me.aa.IconMarginRight = 0
        Me.aa.IconRightVisible = True
        Me.aa.IconRightZoom = 0R
        Me.aa.IconVisible = True
        Me.aa.IconZoom = 90.0R
        Me.aa.IsTab = False
        Me.aa.Location = New System.Drawing.Point(0, 0)
        Me.aa.Margin = New System.Windows.Forms.Padding(4)
        Me.aa.Name = "aa"
        Me.aa.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.aa.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.aa.OnHoverTextColor = System.Drawing.Color.White
        Me.aa.selected = False
        Me.aa.Size = New System.Drawing.Size(158, 36)
        Me.aa.TabIndex = 63
        Me.aa.Text = "A Summer's Day"
        Me.aa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.aa.Textcolor = System.Drawing.Color.White
        Me.aa.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PersonalomboBox
        '
        Me.PersonalomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PersonalomboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalomboBox.FormattingEnabled = True
        Me.PersonalomboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.PersonalomboBox.Location = New System.Drawing.Point(745, 5)
        Me.PersonalomboBox.Name = "PersonalomboBox"
        Me.PersonalomboBox.Size = New System.Drawing.Size(60, 25)
        Me.PersonalomboBox.TabIndex = 79
        Me.PersonalomboBox.Text = "Male"
        '
        'vol
        '
        Me.vol.AutoSize = True
        Me.vol.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vol.Location = New System.Drawing.Point(707, 427)
        Me.vol.Name = "vol"
        Me.vol.Size = New System.Drawing.Size(57, 16)
        Me.vol.TabIndex = 78
        Me.vol.Text = "Volume"
        '
        'VolumeTrackBar
        '
        Me.VolumeTrackBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.VolumeTrackBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VolumeTrackBar.Location = New System.Drawing.Point(697, 444)
        Me.VolumeTrackBar.Maximum = 100
        Me.VolumeTrackBar.Minimum = -10
        Me.VolumeTrackBar.Name = "VolumeTrackBar"
        Me.VolumeTrackBar.Size = New System.Drawing.Size(104, 45)
        Me.VolumeTrackBar.TabIndex = 77
        '
        'ss
        '
        Me.ss.AutoSize = True
        Me.ss.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss.Location = New System.Drawing.Point(594, 427)
        Me.ss.Name = "ss"
        Me.ss.Size = New System.Drawing.Size(49, 16)
        Me.ss.TabIndex = 76
        Me.ss.Text = "Speed"
        '
        'SpeechTrackBar
        '
        Me.SpeechTrackBar.Location = New System.Drawing.Point(597, 444)
        Me.SpeechTrackBar.Minimum = -10
        Me.SpeechTrackBar.Name = "SpeechTrackBar"
        Me.SpeechTrackBar.Size = New System.Drawing.Size(104, 45)
        Me.SpeechTrackBar.TabIndex = 74
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(164, 31)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(641, 393)
        Me.TextBox1.TabIndex = 72
        '
        'BtnPause
        '
        Me.BtnPause.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPause.BorderRadius = 0
        Me.BtnPause.ButtonText = "Pause"
        Me.BtnPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPause.DisabledColor = System.Drawing.Color.Gray
        Me.BtnPause.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPause.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnPause.Iconimage = Global.VOICE_READER_APP.My.Resources.Resources.paus
        Me.BtnPause.Iconimage_right = Nothing
        Me.BtnPause.Iconimage_right_Selected = Nothing
        Me.BtnPause.Iconimage_Selected = Nothing
        Me.BtnPause.IconMarginLeft = 0
        Me.BtnPause.IconMarginRight = 0
        Me.BtnPause.IconRightVisible = True
        Me.BtnPause.IconRightZoom = 0R
        Me.BtnPause.IconVisible = True
        Me.BtnPause.IconZoom = 30.0R
        Me.BtnPause.IsTab = False
        Me.BtnPause.Location = New System.Drawing.Point(267, 426)
        Me.BtnPause.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPause.OnHovercolor = System.Drawing.Color.Green
        Me.BtnPause.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPause.selected = False
        Me.BtnPause.Size = New System.Drawing.Size(91, 33)
        Me.BtnPause.TabIndex = 83
        Me.BtnPause.Text = "Pause"
        Me.BtnPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPause.Textcolor = System.Drawing.Color.White
        Me.BtnPause.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnPlay
        '
        Me.BtnPlay.Activecolor = System.Drawing.Color.Teal
        Me.BtnPlay.BackColor = System.Drawing.Color.Teal
        Me.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPlay.BorderRadius = 0
        Me.BtnPlay.ButtonText = "Play"
        Me.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPlay.DisabledColor = System.Drawing.Color.Gray
        Me.BtnPlay.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnPlay.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnPlay.Iconimage = Global.VOICE_READER_APP.My.Resources.Resources.ppppppppp
        Me.BtnPlay.Iconimage_right = Nothing
        Me.BtnPlay.Iconimage_right_Selected = Nothing
        Me.BtnPlay.Iconimage_Selected = Nothing
        Me.BtnPlay.IconMarginLeft = 0
        Me.BtnPlay.IconMarginRight = 0
        Me.BtnPlay.IconRightVisible = True
        Me.BtnPlay.IconRightZoom = 0R
        Me.BtnPlay.IconVisible = True
        Me.BtnPlay.IconZoom = 30.0R
        Me.BtnPlay.IsTab = False
        Me.BtnPlay.Location = New System.Drawing.Point(164, 426)
        Me.BtnPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Normalcolor = System.Drawing.Color.Teal
        Me.BtnPlay.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPlay.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPlay.selected = False
        Me.BtnPlay.Size = New System.Drawing.Size(91, 33)
        Me.BtnPlay.TabIndex = 82
        Me.BtnPlay.Text = "Play"
        Me.BtnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPlay.Textcolor = System.Drawing.Color.White
        Me.BtnPlay.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnStop
        '
        Me.BtnStop.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnStop.BackColor = System.Drawing.Color.Maroon
        Me.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStop.BorderRadius = 0
        Me.BtnStop.ButtonText = "Stop"
        Me.BtnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStop.DisabledColor = System.Drawing.Color.Gray
        Me.BtnStop.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStop.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnStop.Iconimage = Global.VOICE_READER_APP.My.Resources.Resources.stop_70px
        Me.BtnStop.Iconimage_right = Nothing
        Me.BtnStop.Iconimage_right_Selected = Nothing
        Me.BtnStop.Iconimage_Selected = Nothing
        Me.BtnStop.IconMarginLeft = 0
        Me.BtnStop.IconMarginRight = 0
        Me.BtnStop.IconRightVisible = True
        Me.BtnStop.IconRightZoom = 0R
        Me.BtnStop.IconVisible = True
        Me.BtnStop.IconZoom = 30.0R
        Me.BtnStop.IsTab = False
        Me.BtnStop.Location = New System.Drawing.Point(366, 426)
        Me.BtnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Normalcolor = System.Drawing.Color.Maroon
        Me.BtnStop.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnStop.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnStop.selected = False
        Me.BtnStop.Size = New System.Drawing.Size(91, 33)
        Me.BtnStop.TabIndex = 81
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnStop.Textcolor = System.Drawing.Color.White
        Me.BtnStop.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnResume
        '
        Me.BtnResume.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BtnResume.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnResume.BorderRadius = 0
        Me.BtnResume.ButtonText = "Resume"
        Me.BtnResume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnResume.DisabledColor = System.Drawing.Color.Gray
        Me.BtnResume.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnResume.Iconimage = Global.VOICE_READER_APP.My.Resources.Resources.resuuuume
        Me.BtnResume.Iconimage_right = Nothing
        Me.BtnResume.Iconimage_right_Selected = Nothing
        Me.BtnResume.Iconimage_Selected = Nothing
        Me.BtnResume.IconMarginLeft = 0
        Me.BtnResume.IconMarginRight = 0
        Me.BtnResume.IconRightVisible = True
        Me.BtnResume.IconRightZoom = 0R
        Me.BtnResume.IconVisible = True
        Me.BtnResume.IconZoom = 30.0R
        Me.BtnResume.IsTab = False
        Me.BtnResume.Location = New System.Drawing.Point(464, 426)
        Me.BtnResume.Name = "BtnResume"
        Me.BtnResume.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnResume.OnHovercolor = System.Drawing.Color.Purple
        Me.BtnResume.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnResume.selected = False
        Me.BtnResume.Size = New System.Drawing.Size(91, 33)
        Me.BtnResume.TabIndex = 95
        Me.BtnResume.Text = "Resume"
        Me.BtnResume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnResume.Textcolor = System.Drawing.Color.White
        Me.BtnResume.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'adventure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(836, 490)
        Me.Controls.Add(Me.BtnResume)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PersonalomboBox)
        Me.Controls.Add(Me.vol)
        Me.Controls.Add(Me.VolumeTrackBar)
        Me.Controls.Add(Me.ss)
        Me.Controls.Add(Me.SpeechTrackBar)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adventure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adventure"
        Me.Panel1.ResumeLayout(False)
        CType(Me.VolumeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeechTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PersonalomboBox As ComboBox
    Friend WithEvents vol As Label
    Friend WithEvents VolumeTrackBar As TrackBar
    Friend WithEvents ss As Label
    Friend WithEvents SpeechTrackBar As TrackBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnPause As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnPlay As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnStop As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnResume As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents aa As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents gf As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents qw As Bunifu.Framework.UI.BunifuFlatButton
End Class
