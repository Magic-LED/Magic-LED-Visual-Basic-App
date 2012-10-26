<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_alpha = New System.Windows.Forms.Button()
        Me.numUpDwn_RGB_Alpha = New System.Windows.Forms.NumericUpDown()
        Me.sldr_RGB_Alpha = New System.Windows.Forms.TrackBar()
        Me.ColorPanel1 = New PJLControls.ColorPanel()
        Me.ColorPicker1 = New PJLControls.CustomColorPicker()
        Me.gbx_flash = New System.Windows.Forms.GroupBox()
        Me.numUpDwn_Effects_Flash_Delay = New System.Windows.Forms.NumericUpDown()
        Me.btn_RestEffectsFlash = New System.Windows.Forms.Button()
        Me.chkbx_Effects_Flash_white = New System.Windows.Forms.CheckBox()
        Me.chkbx_Effects_Flash_yellow = New System.Windows.Forms.CheckBox()
        Me.chkbx_Effects_Flash_pink = New System.Windows.Forms.CheckBox()
        Me.chkbx_Effects_Flash_purple = New System.Windows.Forms.CheckBox()
        Me.chkbx_Effects_Flash_blue = New System.Windows.Forms.CheckBox()
        Me.chkbx_Effects_Flash_teal = New System.Windows.Forms.CheckBox()
        Me.chkbx_Effects_Flash_green = New System.Windows.Forms.CheckBox()
        Me.chkbx_Effects_Flash_orange = New System.Windows.Forms.CheckBox()
        Me.chkbx_Effects_Flash_red = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_Effects_FlashStart = New System.Windows.Forms.Button()
        Me.gbx_fade = New System.Windows.Forms.GroupBox()
        Me.numUpDwn_Effects_Fade_Delay = New System.Windows.Forms.NumericUpDown()
        Me.btn_RestEffectsFade = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_Effects_FadeStart = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_status_Datarcv = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_status_rcv = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbx_ComportOptions = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cbx_BaudrateOptions = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_OpenComOptions = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_SaveOptions = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_info = New System.Windows.Forms.ToolStripButton()
        Me.gbx_slider = New System.Windows.Forms.GroupBox()
        Me.btn_ResetSlider = New System.Windows.Forms.Button()
        CType(Me.numUpDwn_RGB_Alpha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sldr_RGB_Alpha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_flash.SuspendLayout()
        CType(Me.numUpDwn_Effects_Flash_Delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_fade.SuspendLayout()
        CType(Me.numUpDwn_Effects_Fade_Delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbx_slider.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_alpha
        '
        Me.btn_alpha.Location = New System.Drawing.Point(467, 27)
        Me.btn_alpha.Name = "btn_alpha"
        Me.btn_alpha.Size = New System.Drawing.Size(48, 24)
        Me.btn_alpha.TabIndex = 33
        Me.btn_alpha.Text = "Alpha"
        Me.btn_alpha.UseVisualStyleBackColor = True
        '
        'numUpDwn_RGB_Alpha
        '
        Me.numUpDwn_RGB_Alpha.Location = New System.Drawing.Point(470, 259)
        Me.numUpDwn_RGB_Alpha.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numUpDwn_RGB_Alpha.Name = "numUpDwn_RGB_Alpha"
        Me.numUpDwn_RGB_Alpha.Size = New System.Drawing.Size(47, 20)
        Me.numUpDwn_RGB_Alpha.TabIndex = 32
        Me.numUpDwn_RGB_Alpha.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'sldr_RGB_Alpha
        '
        Me.sldr_RGB_Alpha.Location = New System.Drawing.Point(472, 51)
        Me.sldr_RGB_Alpha.Maximum = 255
        Me.sldr_RGB_Alpha.Name = "sldr_RGB_Alpha"
        Me.sldr_RGB_Alpha.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.sldr_RGB_Alpha.Size = New System.Drawing.Size(42, 208)
        Me.sldr_RGB_Alpha.TabIndex = 31
        Me.sldr_RGB_Alpha.TickFrequency = 16
        Me.sldr_RGB_Alpha.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.sldr_RGB_Alpha.Value = 255
        '
        'ColorPanel1
        '
        Me.ColorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ColorPanel1.Color = System.Drawing.Color.White
        Me.ColorPanel1.ColorSet = PJLControls.ColorSet.Custom
        Me.ColorPanel1.ColorSortOrder = PJLControls.ColorSortOrder.Brightness
        Me.ColorPanel1.ColorWellSize = New System.Drawing.Size(30, 30)
        Me.ColorPanel1.Columns = 14
        Me.ColorPanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColorPanel1.CustomColors = New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.White, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, System.Drawing.Color.Yellow, System.Drawing.Color.Orange, System.Drawing.Color.Teal, System.Drawing.Color.Pink, System.Drawing.Color.Purple, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.Maroon, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))}
        Me.ColorPanel1.Location = New System.Drawing.Point(12, 295)
        Me.ColorPanel1.Name = "ColorPanel1"
        Me.ColorPanel1.Size = New System.Drawing.Size(422, 32)
        Me.ColorPanel1.TabIndex = 30
        '
        'ColorPicker1
        '
        Me.ColorPicker1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ColorPicker1.Location = New System.Drawing.Point(6, 19)
        Me.ColorPicker1.Name = "ColorPicker1"
        Me.ColorPicker1.Size = New System.Drawing.Size(448, 272)
        Me.ColorPicker1.TabIndex = 29
        '
        'gbx_flash
        '
        Me.gbx_flash.Controls.Add(Me.numUpDwn_Effects_Flash_Delay)
        Me.gbx_flash.Controls.Add(Me.btn_RestEffectsFlash)
        Me.gbx_flash.Controls.Add(Me.chkbx_Effects_Flash_white)
        Me.gbx_flash.Controls.Add(Me.chkbx_Effects_Flash_yellow)
        Me.gbx_flash.Controls.Add(Me.chkbx_Effects_Flash_pink)
        Me.gbx_flash.Controls.Add(Me.chkbx_Effects_Flash_purple)
        Me.gbx_flash.Controls.Add(Me.chkbx_Effects_Flash_blue)
        Me.gbx_flash.Controls.Add(Me.chkbx_Effects_Flash_teal)
        Me.gbx_flash.Controls.Add(Me.chkbx_Effects_Flash_green)
        Me.gbx_flash.Controls.Add(Me.chkbx_Effects_Flash_orange)
        Me.gbx_flash.Controls.Add(Me.chkbx_Effects_Flash_red)
        Me.gbx_flash.Controls.Add(Me.Label15)
        Me.gbx_flash.Controls.Add(Me.btn_Effects_FlashStart)
        Me.gbx_flash.Location = New System.Drawing.Point(574, 40)
        Me.gbx_flash.Name = "gbx_flash"
        Me.gbx_flash.Size = New System.Drawing.Size(158, 218)
        Me.gbx_flash.TabIndex = 17
        Me.gbx_flash.TabStop = False
        Me.gbx_flash.Text = "Flash"
        '
        'numUpDwn_Effects_Flash_Delay
        '
        Me.numUpDwn_Effects_Flash_Delay.BackColor = System.Drawing.SystemColors.Control
        Me.numUpDwn_Effects_Flash_Delay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDwn_Effects_Flash_Delay.Location = New System.Drawing.Point(79, 64)
        Me.numUpDwn_Effects_Flash_Delay.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numUpDwn_Effects_Flash_Delay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUpDwn_Effects_Flash_Delay.Name = "numUpDwn_Effects_Flash_Delay"
        Me.numUpDwn_Effects_Flash_Delay.Size = New System.Drawing.Size(71, 24)
        Me.numUpDwn_Effects_Flash_Delay.TabIndex = 21
        Me.numUpDwn_Effects_Flash_Delay.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'btn_RestEffectsFlash
        '
        Me.btn_RestEffectsFlash.Location = New System.Drawing.Point(6, 19)
        Me.btn_RestEffectsFlash.Name = "btn_RestEffectsFlash"
        Me.btn_RestEffectsFlash.Size = New System.Drawing.Size(52, 24)
        Me.btn_RestEffectsFlash.TabIndex = 20
        Me.btn_RestEffectsFlash.Text = "Reset"
        Me.btn_RestEffectsFlash.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_white
        '
        Me.chkbx_Effects_Flash_white.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_white_small
        Me.chkbx_Effects_Flash_white.Location = New System.Drawing.Point(59, 182)
        Me.chkbx_Effects_Flash_white.Name = "chkbx_Effects_Flash_white"
        Me.chkbx_Effects_Flash_white.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_white.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_white.TabIndex = 26
        Me.chkbx_Effects_Flash_white.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_yellow
        '
        Me.chkbx_Effects_Flash_yellow.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_yellow_small
        Me.chkbx_Effects_Flash_yellow.Location = New System.Drawing.Point(59, 146)
        Me.chkbx_Effects_Flash_yellow.Name = "chkbx_Effects_Flash_yellow"
        Me.chkbx_Effects_Flash_yellow.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_yellow.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_yellow.TabIndex = 24
        Me.chkbx_Effects_Flash_yellow.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_pink
        '
        Me.chkbx_Effects_Flash_pink.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_pink_small
        Me.chkbx_Effects_Flash_pink.Location = New System.Drawing.Point(6, 182)
        Me.chkbx_Effects_Flash_pink.Name = "chkbx_Effects_Flash_pink"
        Me.chkbx_Effects_Flash_pink.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_pink.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_pink.TabIndex = 23
        Me.chkbx_Effects_Flash_pink.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_purple
        '
        Me.chkbx_Effects_Flash_purple.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_purple_small
        Me.chkbx_Effects_Flash_purple.Location = New System.Drawing.Point(6, 146)
        Me.chkbx_Effects_Flash_purple.Name = "chkbx_Effects_Flash_purple"
        Me.chkbx_Effects_Flash_purple.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_purple.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_purple.TabIndex = 22
        Me.chkbx_Effects_Flash_purple.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_blue
        '
        Me.chkbx_Effects_Flash_blue.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_blue_small
        Me.chkbx_Effects_Flash_blue.Checked = True
        Me.chkbx_Effects_Flash_blue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbx_Effects_Flash_blue.Location = New System.Drawing.Point(110, 110)
        Me.chkbx_Effects_Flash_blue.Name = "chkbx_Effects_Flash_blue"
        Me.chkbx_Effects_Flash_blue.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_blue.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_blue.TabIndex = 21
        Me.chkbx_Effects_Flash_blue.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_teal
        '
        Me.chkbx_Effects_Flash_teal.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_teal_small
        Me.chkbx_Effects_Flash_teal.Location = New System.Drawing.Point(110, 182)
        Me.chkbx_Effects_Flash_teal.Name = "chkbx_Effects_Flash_teal"
        Me.chkbx_Effects_Flash_teal.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_teal.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_teal.TabIndex = 20
        Me.chkbx_Effects_Flash_teal.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_green
        '
        Me.chkbx_Effects_Flash_green.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_green_small
        Me.chkbx_Effects_Flash_green.Checked = True
        Me.chkbx_Effects_Flash_green.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbx_Effects_Flash_green.Location = New System.Drawing.Point(59, 110)
        Me.chkbx_Effects_Flash_green.Name = "chkbx_Effects_Flash_green"
        Me.chkbx_Effects_Flash_green.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_green.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_green.TabIndex = 19
        Me.chkbx_Effects_Flash_green.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_orange
        '
        Me.chkbx_Effects_Flash_orange.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_orange_small
        Me.chkbx_Effects_Flash_orange.Location = New System.Drawing.Point(110, 146)
        Me.chkbx_Effects_Flash_orange.Name = "chkbx_Effects_Flash_orange"
        Me.chkbx_Effects_Flash_orange.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_orange.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_orange.TabIndex = 18
        Me.chkbx_Effects_Flash_orange.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_red
        '
        Me.chkbx_Effects_Flash_red.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_red_small
        Me.chkbx_Effects_Flash_red.Checked = True
        Me.chkbx_Effects_Flash_red.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbx_Effects_Flash_red.Location = New System.Drawing.Point(6, 110)
        Me.chkbx_Effects_Flash_red.Name = "chkbx_Effects_Flash_red"
        Me.chkbx_Effects_Flash_red.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_red.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_red.TabIndex = 17
        Me.chkbx_Effects_Flash_red.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Delay (ms)"
        '
        'btn_Effects_FlashStart
        '
        Me.btn_Effects_FlashStart.Location = New System.Drawing.Point(64, 19)
        Me.btn_Effects_FlashStart.Name = "btn_Effects_FlashStart"
        Me.btn_Effects_FlashStart.Size = New System.Drawing.Size(86, 24)
        Me.btn_Effects_FlashStart.TabIndex = 13
        Me.btn_Effects_FlashStart.Text = "Start"
        Me.btn_Effects_FlashStart.UseVisualStyleBackColor = True
        '
        'gbx_fade
        '
        Me.gbx_fade.Controls.Add(Me.numUpDwn_Effects_Fade_Delay)
        Me.gbx_fade.Controls.Add(Me.btn_RestEffectsFade)
        Me.gbx_fade.Controls.Add(Me.Label14)
        Me.gbx_fade.Controls.Add(Me.btn_Effects_FadeStart)
        Me.gbx_fade.Location = New System.Drawing.Point(574, 264)
        Me.gbx_fade.Name = "gbx_fade"
        Me.gbx_fade.Size = New System.Drawing.Size(158, 121)
        Me.gbx_fade.TabIndex = 0
        Me.gbx_fade.TabStop = False
        Me.gbx_fade.Text = "Fade"
        '
        'numUpDwn_Effects_Fade_Delay
        '
        Me.numUpDwn_Effects_Fade_Delay.BackColor = System.Drawing.SystemColors.Control
        Me.numUpDwn_Effects_Fade_Delay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDwn_Effects_Fade_Delay.Location = New System.Drawing.Point(79, 64)
        Me.numUpDwn_Effects_Fade_Delay.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numUpDwn_Effects_Fade_Delay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUpDwn_Effects_Fade_Delay.Name = "numUpDwn_Effects_Fade_Delay"
        Me.numUpDwn_Effects_Fade_Delay.Size = New System.Drawing.Size(71, 24)
        Me.numUpDwn_Effects_Fade_Delay.TabIndex = 20
        Me.numUpDwn_Effects_Fade_Delay.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'btn_RestEffectsFade
        '
        Me.btn_RestEffectsFade.Location = New System.Drawing.Point(6, 19)
        Me.btn_RestEffectsFade.Name = "btn_RestEffectsFade"
        Me.btn_RestEffectsFade.Size = New System.Drawing.Size(52, 24)
        Me.btn_RestEffectsFade.TabIndex = 19
        Me.btn_RestEffectsFade.Text = "Reset"
        Me.btn_RestEffectsFade.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Delay (ms)"
        '
        'btn_Effects_FadeStart
        '
        Me.btn_Effects_FadeStart.Location = New System.Drawing.Point(64, 19)
        Me.btn_Effects_FadeStart.Name = "btn_Effects_FadeStart"
        Me.btn_Effects_FadeStart.Size = New System.Drawing.Size(86, 24)
        Me.btn_Effects_FadeStart.TabIndex = 13
        Me.btn_Effects_FadeStart.Text = "Start"
        Me.btn_Effects_FadeStart.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_StatusLabel, Me.lbl_status_Datarcv, Me.lbl_status_rcv})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 398)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(744, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_StatusLabel
        '
        Me.lbl_StatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lbl_StatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lbl_StatusLabel.Name = "lbl_StatusLabel"
        Me.lbl_StatusLabel.Size = New System.Drawing.Size(51, 17)
        Me.lbl_StatusLabel.Text = "Bereit..."
        '
        'lbl_status_Datarcv
        '
        Me.lbl_status_Datarcv.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lbl_status_Datarcv.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lbl_status_Datarcv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lbl_status_Datarcv.Name = "lbl_status_Datarcv"
        Me.lbl_status_Datarcv.Size = New System.Drawing.Size(23, 17)
        Me.lbl_status_Datarcv.Text = "    "
        '
        'lbl_status_rcv
        '
        Me.lbl_status_rcv.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lbl_status_rcv.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lbl_status_rcv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lbl_status_rcv.Name = "lbl_status_rcv"
        Me.lbl_status_rcv.Size = New System.Drawing.Size(23, 17)
        Me.lbl_status_rcv.Text = "    "
        '
        'SerialPort1
        '
        Me.SerialPort1.DtrEnable = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cbx_ComportOptions, Me.ToolStripLabel2, Me.cbx_BaudrateOptions, Me.ToolStripSeparator1, Me.btn_OpenComOptions, Me.ToolStripSeparator2, Me.btn_SaveOptions, Me.ToolStripSeparator4, Me.btn_info})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(744, 33)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(52, 30)
        Me.ToolStripLabel1.Text = "ComPort:"
        '
        'cbx_ComportOptions
        '
        Me.cbx_ComportOptions.Name = "cbx_ComportOptions"
        Me.cbx_ComportOptions.Size = New System.Drawing.Size(121, 33)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(55, 30)
        Me.ToolStripLabel2.Text = "Baudrate:"
        '
        'cbx_BaudrateOptions
        '
        Me.cbx_BaudrateOptions.Items.AddRange(New Object() {"9600", "115200"})
        Me.cbx_BaudrateOptions.Name = "cbx_BaudrateOptions"
        Me.cbx_BaudrateOptions.Size = New System.Drawing.Size(121, 33)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'btn_OpenComOptions
        '
        Me.btn_OpenComOptions.Image = CType(resources.GetObject("btn_OpenComOptions.Image"), System.Drawing.Image)
        Me.btn_OpenComOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_OpenComOptions.Name = "btn_OpenComOptions"
        Me.btn_OpenComOptions.Size = New System.Drawing.Size(67, 30)
        Me.btn_OpenComOptions.Text = "Connect"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'btn_SaveOptions
        '
        Me.btn_SaveOptions.Image = CType(resources.GetObject("btn_SaveOptions.Image"), System.Drawing.Image)
        Me.btn_SaveOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_SaveOptions.Name = "btn_SaveOptions"
        Me.btn_SaveOptions.Size = New System.Drawing.Size(51, 30)
        Me.btn_SaveOptions.Text = "Save"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 33)
        '
        'btn_info
        '
        Me.btn_info.Image = CType(resources.GetObject("btn_info.Image"), System.Drawing.Image)
        Me.btn_info.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(47, 30)
        Me.btn_info.Text = "Info"
        '
        'gbx_slider
        '
        Me.gbx_slider.Controls.Add(Me.btn_ResetSlider)
        Me.gbx_slider.Controls.Add(Me.btn_alpha)
        Me.gbx_slider.Controls.Add(Me.numUpDwn_RGB_Alpha)
        Me.gbx_slider.Controls.Add(Me.sldr_RGB_Alpha)
        Me.gbx_slider.Controls.Add(Me.ColorPanel1)
        Me.gbx_slider.Controls.Add(Me.ColorPicker1)
        Me.gbx_slider.Location = New System.Drawing.Point(12, 40)
        Me.gbx_slider.Name = "gbx_slider"
        Me.gbx_slider.Size = New System.Drawing.Size(542, 345)
        Me.gbx_slider.TabIndex = 12
        Me.gbx_slider.TabStop = False
        Me.gbx_slider.Text = "Color Picker"
        '
        'btn_ResetSlider
        '
        Me.btn_ResetSlider.Location = New System.Drawing.Point(463, 295)
        Me.btn_ResetSlider.Name = "btn_ResetSlider"
        Me.btn_ResetSlider.Size = New System.Drawing.Size(52, 32)
        Me.btn_ResetSlider.TabIndex = 27
        Me.btn_ResetSlider.Text = "Reset"
        Me.btn_ResetSlider.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 420)
        Me.Controls.Add(Me.gbx_flash)
        Me.Controls.Add(Me.gbx_slider)
        Me.Controls.Add(Me.gbx_fade)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "MagicLED 2012"
        CType(Me.numUpDwn_RGB_Alpha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sldr_RGB_Alpha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_flash.ResumeLayout(False)
        Me.gbx_flash.PerformLayout()
        CType(Me.numUpDwn_Effects_Flash_Delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_fade.ResumeLayout(False)
        Me.gbx_fade.PerformLayout()
        CType(Me.numUpDwn_Effects_Fade_Delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbx_slider.ResumeLayout(False)
        Me.gbx_slider.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbx_flash As System.Windows.Forms.GroupBox
    Friend WithEvents chkbx_Effects_Flash_white As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_Effects_Flash_yellow As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_Effects_Flash_pink As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_Effects_Flash_purple As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_Effects_Flash_blue As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_Effects_Flash_teal As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_Effects_Flash_green As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_Effects_Flash_orange As System.Windows.Forms.CheckBox
    Friend WithEvents chkbx_Effects_Flash_red As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_Effects_FlashStart As System.Windows.Forms.Button
    Friend WithEvents gbx_fade As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_Effects_FadeStart As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_RestEffectsFlash As System.Windows.Forms.Button
    Friend WithEvents btn_RestEffectsFade As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents lbl_status_Datarcv As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_status_rcv As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ColorPicker1 As PJLControls.CustomColorPicker
    Friend WithEvents ColorPanel1 As PJLControls.ColorPanel
    Friend WithEvents sldr_RGB_Alpha As System.Windows.Forms.TrackBar
    Friend WithEvents btn_alpha As System.Windows.Forms.Button
    Friend WithEvents numUpDwn_RGB_Alpha As System.Windows.Forms.NumericUpDown
    Friend WithEvents numUpDwn_Effects_Flash_Delay As System.Windows.Forms.NumericUpDown
    Friend WithEvents numUpDwn_Effects_Fade_Delay As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cbx_ComportOptions As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cbx_BaudrateOptions As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btn_OpenComOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_SaveOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_info As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbx_slider As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_ResetSlider As System.Windows.Forms.Button

End Class
