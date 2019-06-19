<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnImport = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnCategory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnDash = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnMinimizer = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panelss = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.BtnMinimizer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.BtnImport)
        Me.Panel1.Controls.Add(Me.BtnCategory)
        Me.Panel1.Controls.Add(Me.BtnDash)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 650)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(275, 35)
        Me.Panel5.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Text Reader Application"
        '
        'BtnLogout
        '
        Me.BtnLogout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogout.BorderRadius = 0
        Me.BtnLogout.ButtonText = "     Log Out"
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.DisabledColor = System.Drawing.Color.Gray
        Me.BtnLogout.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnLogout.Iconimage = Global.VOICE_READER_APP.My.Resources.Resources.logout_rounded_filled_70px
        Me.BtnLogout.Iconimage_right = Nothing
        Me.BtnLogout.Iconimage_right_Selected = Nothing
        Me.BtnLogout.Iconimage_Selected = Nothing
        Me.BtnLogout.IconMarginLeft = 0
        Me.BtnLogout.IconMarginRight = 0
        Me.BtnLogout.IconRightVisible = True
        Me.BtnLogout.IconRightZoom = 0R
        Me.BtnLogout.IconVisible = True
        Me.BtnLogout.IconZoom = 55.0R
        Me.BtnLogout.IsTab = False
        Me.BtnLogout.Location = New System.Drawing.Point(0, 382)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Normalcolor = System.Drawing.Color.Empty
        Me.BtnLogout.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnLogout.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnLogout.selected = False
        Me.BtnLogout.Size = New System.Drawing.Size(275, 44)
        Me.BtnLogout.TabIndex = 12
        Me.BtnLogout.Text = "     Log Out"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.Textcolor = System.Drawing.Color.White
        Me.BtnLogout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnImport
        '
        Me.BtnImport.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BtnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImport.BorderRadius = 0
        Me.BtnImport.ButtonText = "     Import Text  File"
        Me.BtnImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImport.DisabledColor = System.Drawing.Color.Gray
        Me.BtnImport.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImport.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnImport.Iconimage = Global.VOICE_READER_APP.My.Resources.Resources.import_70px
        Me.BtnImport.Iconimage_right = Nothing
        Me.BtnImport.Iconimage_right_Selected = Nothing
        Me.BtnImport.Iconimage_Selected = Nothing
        Me.BtnImport.IconMarginLeft = 0
        Me.BtnImport.IconMarginRight = 0
        Me.BtnImport.IconRightVisible = True
        Me.BtnImport.IconRightZoom = 0R
        Me.BtnImport.IconVisible = True
        Me.BtnImport.IconZoom = 55.0R
        Me.BtnImport.IsTab = False
        Me.BtnImport.Location = New System.Drawing.Point(0, 330)
        Me.BtnImport.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Normalcolor = System.Drawing.Color.Empty
        Me.BtnImport.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnImport.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnImport.selected = False
        Me.BtnImport.Size = New System.Drawing.Size(275, 44)
        Me.BtnImport.TabIndex = 8
        Me.BtnImport.Text = "     Import Text  File"
        Me.BtnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImport.Textcolor = System.Drawing.Color.White
        Me.BtnImport.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnCategory
        '
        Me.BtnCategory.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BtnCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCategory.BorderRadius = 0
        Me.BtnCategory.ButtonText = "    Story Category"
        Me.BtnCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCategory.DisabledColor = System.Drawing.Color.Gray
        Me.BtnCategory.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCategory.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnCategory.Iconimage = Global.VOICE_READER_APP.My.Resources.Resources.sorting_answers_filled_70px
        Me.BtnCategory.Iconimage_right = Nothing
        Me.BtnCategory.Iconimage_right_Selected = Nothing
        Me.BtnCategory.Iconimage_Selected = Nothing
        Me.BtnCategory.IconMarginLeft = 0
        Me.BtnCategory.IconMarginRight = 0
        Me.BtnCategory.IconRightVisible = True
        Me.BtnCategory.IconRightZoom = 0R
        Me.BtnCategory.IconVisible = True
        Me.BtnCategory.IconZoom = 55.0R
        Me.BtnCategory.IsTab = False
        Me.BtnCategory.Location = New System.Drawing.Point(0, 286)
        Me.BtnCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCategory.Name = "BtnCategory"
        Me.BtnCategory.Normalcolor = System.Drawing.Color.Empty
        Me.BtnCategory.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnCategory.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnCategory.selected = False
        Me.BtnCategory.Size = New System.Drawing.Size(275, 44)
        Me.BtnCategory.TabIndex = 7
        Me.BtnCategory.Text = "    Story Category"
        Me.BtnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCategory.Textcolor = System.Drawing.Color.White
        Me.BtnCategory.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnDash
        '
        Me.BtnDash.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BtnDash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDash.BorderRadius = 0
        Me.BtnDash.ButtonText = "    Home"
        Me.BtnDash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDash.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDash.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDash.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDash.Iconimage = Global.VOICE_READER_APP.My.Resources.Resources.hhhhhhhhhhh
        Me.BtnDash.Iconimage_right = Nothing
        Me.BtnDash.Iconimage_right_Selected = Nothing
        Me.BtnDash.Iconimage_Selected = Nothing
        Me.BtnDash.IconMarginLeft = 0
        Me.BtnDash.IconMarginRight = 0
        Me.BtnDash.IconRightVisible = True
        Me.BtnDash.IconRightZoom = 0R
        Me.BtnDash.IconVisible = True
        Me.BtnDash.IconZoom = 55.0R
        Me.BtnDash.IsTab = False
        Me.BtnDash.Location = New System.Drawing.Point(0, 242)
        Me.BtnDash.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDash.Name = "BtnDash"
        Me.BtnDash.Normalcolor = System.Drawing.Color.Empty
        Me.BtnDash.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnDash.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnDash.selected = False
        Me.BtnDash.Size = New System.Drawing.Size(275, 44)
        Me.BtnDash.TabIndex = 6
        Me.BtnDash.Text = "    Home"
        Me.BtnDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDash.Textcolor = System.Drawing.Color.White
        Me.BtnDash.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(275, 201)
        Me.Panel2.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VOICE_READER_APP.My.Resources.Resources.new_vdr_logo
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(275, 198)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 239)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BtnMinimizer)
        Me.Panel4.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(975, 38)
        Me.Panel4.TabIndex = 75
        '
        'BtnMinimizer
        '
        Me.BtnMinimizer.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizer.Image = Global.VOICE_READER_APP.My.Resources.Resources.Icono_Minimizar
        Me.BtnMinimizer.ImageActive = Nothing
        Me.BtnMinimizer.Location = New System.Drawing.Point(912, 8)
        Me.BtnMinimizer.Name = "BtnMinimizer"
        Me.BtnMinimizer.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimizer.TabIndex = 74
        Me.BtnMinimizer.TabStop = False
        Me.BtnMinimizer.Zoom = 10
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Red
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "X"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(945, 8)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Red
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(24, 24)
        Me.BunifuFlatButton2.TabIndex = 73
        Me.BunifuFlatButton2.Text = "X"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panelss)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(275, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(975, 650)
        Me.Panel3.TabIndex = 2
        '
        'Panelss
        '
        Me.Panelss.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelss.Location = New System.Drawing.Point(0, 38)
        Me.Panelss.Name = "Panelss"
        Me.Panelss.Size = New System.Drawing.Size(975, 612)
        Me.Panelss.TabIndex = 76
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 650)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.BtnMinimizer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnDash As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnCategory As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnImport As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnLogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnMinimizer As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panelss As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
End Class
