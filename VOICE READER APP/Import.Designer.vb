<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Import
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PersonalomboBox = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SpeechTrackBar = New System.Windows.Forms.TrackBar()
        Me.LabelSpeech = New System.Windows.Forms.Label()
        Me.VolumeTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label1Vol = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnChoose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.CategoryHeader = New System.Windows.Forms.Panel()
        Me.Labelyy = New System.Windows.Forms.Label()
        Me.BtnResume = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnPause = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnPlay = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnStop = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.SpeechTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.CategoryHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(729, 557)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Convert To Audio"
        '
        'PersonalomboBox
        '
        Me.PersonalomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PersonalomboBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalomboBox.FormattingEnabled = True
        Me.PersonalomboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.PersonalomboBox.Location = New System.Drawing.Point(886, 57)
        Me.PersonalomboBox.Name = "PersonalomboBox"
        Me.PersonalomboBox.Size = New System.Drawing.Size(60, 25)
        Me.PersonalomboBox.TabIndex = 83
        Me.PersonalomboBox.Text = "Male"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SpeechTrackBar
        '
        Me.SpeechTrackBar.Location = New System.Drawing.Point(67, 557)
        Me.SpeechTrackBar.Minimum = -10
        Me.SpeechTrackBar.Name = "SpeechTrackBar"
        Me.SpeechTrackBar.Size = New System.Drawing.Size(104, 45)
        Me.SpeechTrackBar.TabIndex = 79
        '
        'LabelSpeech
        '
        Me.LabelSpeech.AutoSize = True
        Me.LabelSpeech.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSpeech.Location = New System.Drawing.Point(12, 557)
        Me.LabelSpeech.Name = "LabelSpeech"
        Me.LabelSpeech.Size = New System.Drawing.Size(49, 16)
        Me.LabelSpeech.TabIndex = 80
        Me.LabelSpeech.Text = "Speed"
        '
        'VolumeTrackBar
        '
        Me.VolumeTrackBar.Location = New System.Drawing.Point(240, 557)
        Me.VolumeTrackBar.Maximum = 100
        Me.VolumeTrackBar.Minimum = -10
        Me.VolumeTrackBar.Name = "VolumeTrackBar"
        Me.VolumeTrackBar.Size = New System.Drawing.Size(104, 45)
        Me.VolumeTrackBar.TabIndex = 81
        '
        'Label1Vol
        '
        Me.Label1Vol.AutoSize = True
        Me.Label1Vol.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1Vol.Location = New System.Drawing.Point(177, 557)
        Me.Label1Vol.Name = "Label1Vol"
        Me.Label1Vol.Size = New System.Drawing.Size(57, 16)
        Me.Label1Vol.TabIndex = 82
        Me.Label1Vol.Text = "Volume"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(13, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(934, 449)
        Me.Panel2.TabIndex = 45
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(934, 449)
        Me.TextBox1.TabIndex = 0
        '
        'BtnChoose
        '
        Me.BtnChoose.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnChoose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnChoose.BorderRadius = 0
        Me.BtnChoose.ButtonText = "Browse"
        Me.BtnChoose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChoose.DisabledColor = System.Drawing.Color.Gray
        Me.BtnChoose.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChoose.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnChoose.Iconimage = Nothing
        Me.BtnChoose.Iconimage_right = Nothing
        Me.BtnChoose.Iconimage_right_Selected = Nothing
        Me.BtnChoose.Iconimage_Selected = Nothing
        Me.BtnChoose.IconMarginLeft = 0
        Me.BtnChoose.IconMarginRight = 0
        Me.BtnChoose.IconRightVisible = True
        Me.BtnChoose.IconRightZoom = 0R
        Me.BtnChoose.IconVisible = True
        Me.BtnChoose.IconZoom = 90.0R
        Me.BtnChoose.IsTab = False
        Me.BtnChoose.Location = New System.Drawing.Point(13, 49)
        Me.BtnChoose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnChoose.Name = "BtnChoose"
        Me.BtnChoose.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnChoose.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnChoose.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnChoose.selected = False
        Me.BtnChoose.Size = New System.Drawing.Size(122, 33)
        Me.BtnChoose.TabIndex = 35
        Me.BtnChoose.Text = "Browse"
        Me.BtnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnChoose.Textcolor = System.Drawing.Color.White
        Me.BtnChoose.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CategoryHeader
        '
        Me.CategoryHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.CategoryHeader.Controls.Add(Me.Labelyy)
        Me.CategoryHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.CategoryHeader.Location = New System.Drawing.Point(0, 0)
        Me.CategoryHeader.Name = "CategoryHeader"
        Me.CategoryHeader.Size = New System.Drawing.Size(975, 42)
        Me.CategoryHeader.TabIndex = 3
        '
        'Labelyy
        '
        Me.Labelyy.AutoSize = True
        Me.Labelyy.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelyy.ForeColor = System.Drawing.Color.Black
        Me.Labelyy.Location = New System.Drawing.Point(427, 9)
        Me.Labelyy.Name = "Labelyy"
        Me.Labelyy.Size = New System.Drawing.Size(125, 23)
        Me.Labelyy.TabIndex = 1
        Me.Labelyy.Text = "IMPORT FILES"
        '
        'BtnResume
        '
        Me.BtnResume.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BtnResume.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BtnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnResume.BorderRadius = 0
        Me.BtnResume.ButtonText = "Resume"
        Me.BtnResume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnResume.DisabledColor = System.Drawing.Color.Gray
        Me.BtnResume.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BtnResume.IconZoom = 40.0R
        Me.BtnResume.IsTab = False
        Me.BtnResume.Location = New System.Drawing.Point(586, 48)
        Me.BtnResume.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnResume.Name = "BtnResume"
        Me.BtnResume.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BtnResume.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BtnResume.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnResume.selected = False
        Me.BtnResume.Size = New System.Drawing.Size(95, 34)
        Me.BtnResume.TabIndex = 85
        Me.BtnResume.Text = "Resume"
        Me.BtnResume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnResume.Textcolor = System.Drawing.Color.White
        Me.BtnResume.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSave
        '
        Me.BtnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.BorderRadius = 0
        Me.BtnSave.ButtonText = "Audio"
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.DisabledColor = System.Drawing.Color.Gray
        Me.BtnSave.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnSave.Iconimage = Global.VOICE_READER_APP.My.Resources.Resources.music_52px1
        Me.BtnSave.Iconimage_right = Nothing
        Me.BtnSave.Iconimage_right_Selected = Nothing
        Me.BtnSave.Iconimage_Selected = Nothing
        Me.BtnSave.IconMarginLeft = 0
        Me.BtnSave.IconMarginRight = 0
        Me.BtnSave.IconRightVisible = True
        Me.BtnSave.IconRightZoom = 0R
        Me.BtnSave.IconVisible = True
        Me.BtnSave.IconZoom = 40.0R
        Me.BtnSave.IsTab = False
        Me.BtnSave.Location = New System.Drawing.Point(855, 557)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.OnHovercolor = System.Drawing.Color.Maroon
        Me.BtnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSave.selected = False
        Me.BtnSave.Size = New System.Drawing.Size(91, 33)
        Me.BtnSave.TabIndex = 84
        Me.BtnSave.Text = "Audio"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSave.Textcolor = System.Drawing.Color.White
        Me.BtnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BtnPause.Location = New System.Drawing.Point(689, 49)
        Me.BtnPause.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPause.OnHovercolor = System.Drawing.Color.Green
        Me.BtnPause.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPause.selected = False
        Me.BtnPause.Size = New System.Drawing.Size(91, 33)
        Me.BtnPause.TabIndex = 46
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
        Me.BtnPlay.Location = New System.Drawing.Point(487, 48)
        Me.BtnPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Normalcolor = System.Drawing.Color.Teal
        Me.BtnPlay.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPlay.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPlay.selected = False
        Me.BtnPlay.Size = New System.Drawing.Size(91, 33)
        Me.BtnPlay.TabIndex = 39
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
        Me.BtnStop.Location = New System.Drawing.Point(788, 49)
        Me.BtnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Normalcolor = System.Drawing.Color.Maroon
        Me.BtnStop.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnStop.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnStop.selected = False
        Me.BtnStop.Size = New System.Drawing.Size(91, 33)
        Me.BtnStop.TabIndex = 28
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnStop.Textcolor = System.Drawing.Color.White
        Me.BtnStop.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(975, 612)
        Me.Controls.Add(Me.BtnResume)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.PersonalomboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1Vol)
        Me.Controls.Add(Me.VolumeTrackBar)
        Me.Controls.Add(Me.LabelSpeech)
        Me.Controls.Add(Me.SpeechTrackBar)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnChoose)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.CategoryHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Import"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import"
        CType(Me.SpeechTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.CategoryHeader.ResumeLayout(False)
        Me.CategoryHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnStop As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnPlay As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnPause As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnResume As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents PersonalomboBox As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SpeechTrackBar As TrackBar
    Friend WithEvents LabelSpeech As Label
    Friend WithEvents VolumeTrackBar As TrackBar
    Friend WithEvents Label1Vol As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnChoose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents CategoryHeader As Panel
    Friend WithEvents Labelyy As Label
    Friend WithEvents TextBox1 As TextBox
End Class
