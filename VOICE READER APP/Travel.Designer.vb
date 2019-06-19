<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Travel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PersonalomboBox = New System.Windows.Forms.ComboBox()
        Me.VolumeTrackBar = New System.Windows.Forms.TrackBar()
        Me.LabelSp = New System.Windows.Forms.Label()
        Me.SpeechTrackBar = New System.Windows.Forms.TrackBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnPause = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnPlay = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnStop = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnResume = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        CType(Me.VolumeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeechTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 423)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 36)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "The Adventure Begins"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PersonalomboBox
        '
        Me.PersonalomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PersonalomboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalomboBox.FormattingEnabled = True
        Me.PersonalomboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.PersonalomboBox.Location = New System.Drawing.Point(744, 4)
        Me.PersonalomboBox.Name = "PersonalomboBox"
        Me.PersonalomboBox.Size = New System.Drawing.Size(60, 25)
        Me.PersonalomboBox.TabIndex = 76
        Me.PersonalomboBox.Text = "Male"
        '
        'VolumeTrackBar
        '
        Me.VolumeTrackBar.Location = New System.Drawing.Point(715, 427)
        Me.VolumeTrackBar.Maximum = 100
        Me.VolumeTrackBar.Minimum = -10
        Me.VolumeTrackBar.Name = "VolumeTrackBar"
        Me.VolumeTrackBar.Size = New System.Drawing.Size(89, 45)
        Me.VolumeTrackBar.TabIndex = 75
        '
        'LabelSp
        '
        Me.LabelSp.AutoSize = True
        Me.LabelSp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSp.Location = New System.Drawing.Point(597, 408)
        Me.LabelSp.Name = "LabelSp"
        Me.LabelSp.Size = New System.Drawing.Size(49, 16)
        Me.LabelSp.TabIndex = 74
        Me.LabelSp.Text = "Speed"
        '
        'SpeechTrackBar
        '
        Me.SpeechTrackBar.Location = New System.Drawing.Point(600, 428)
        Me.SpeechTrackBar.Minimum = -10
        Me.SpeechTrackBar.Name = "SpeechTrackBar"
        Me.SpeechTrackBar.Size = New System.Drawing.Size(104, 45)
        Me.SpeechTrackBar.TabIndex = 72
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Location = New System.Drawing.Point(168, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(636, 370)
        Me.Panel3.TabIndex = 78
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(636, 370)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.WordWrap = False
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
        Me.BtnPause.Location = New System.Drawing.Point(268, 412)
        Me.BtnPause.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPause.OnHovercolor = System.Drawing.Color.Green
        Me.BtnPause.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPause.selected = False
        Me.BtnPause.Size = New System.Drawing.Size(91, 33)
        Me.BtnPause.TabIndex = 49
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
        Me.BtnPlay.Location = New System.Drawing.Point(165, 412)
        Me.BtnPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Normalcolor = System.Drawing.Color.Teal
        Me.BtnPlay.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPlay.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPlay.selected = False
        Me.BtnPlay.Size = New System.Drawing.Size(91, 33)
        Me.BtnPlay.TabIndex = 48
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
        Me.BtnStop.Location = New System.Drawing.Point(367, 412)
        Me.BtnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Normalcolor = System.Drawing.Color.Maroon
        Me.BtnStop.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnStop.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnStop.selected = False
        Me.BtnStop.Size = New System.Drawing.Size(91, 33)
        Me.BtnStop.TabIndex = 47
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnStop.Textcolor = System.Drawing.Color.White
        Me.BtnStop.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(712, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Volume"
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
        Me.BtnResume.Location = New System.Drawing.Point(474, 412)
        Me.BtnResume.Name = "BtnResume"
        Me.BtnResume.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnResume.OnHovercolor = System.Drawing.Color.Purple
        Me.BtnResume.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnResume.selected = False
        Me.BtnResume.Size = New System.Drawing.Size(91, 33)
        Me.BtnResume.TabIndex = 79
        Me.BtnResume.Text = "Resume"
        Me.BtnResume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnResume.Textcolor = System.Drawing.Color.White
        Me.BtnResume.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Travel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(865, 485)
        Me.Controls.Add(Me.BtnResume)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.PersonalomboBox)
        Me.Controls.Add(Me.VolumeTrackBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelSp)
        Me.Controls.Add(Me.SpeechTrackBar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Travel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Travel"
        Me.Panel1.ResumeLayout(False)
        CType(Me.VolumeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeechTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PersonalomboBox As ComboBox
    Friend WithEvents VolumeTrackBar As TrackBar
    Friend WithEvents LabelSp As Label
    Friend WithEvents SpeechTrackBar As TrackBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnPause As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnPlay As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnStop As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnResume As Bunifu.Framework.UI.BunifuFlatButton
End Class
