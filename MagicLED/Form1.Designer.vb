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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tbctrl_1 = New System.Windows.Forms.TabControl()
        Me.tbpg_Slider = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_Slider_Red = New System.Windows.Forms.Label()
        Me.lbl_Slider_Green = New System.Windows.Forms.Label()
        Me.lbl_Slider_Blue = New System.Windows.Forms.Label()
        Me.lbl_Slider_Alpha = New System.Windows.Forms.Label()
        Me.sldr_Slider_Alpha = New MB.Controls.ColorSlider()
        Me.sldr_Slider_Red = New MB.Controls.ColorSlider()
        Me.sldr_Slider_Blue = New MB.Controls.ColorSlider()
        Me.sldr_Slider_Green = New MB.Controls.ColorSlider()
        Me.btn_ResetSlider = New System.Windows.Forms.Button()
        Me.picbx_Slider_Color = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbpg_Colors = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_Colors_Alpha = New System.Windows.Forms.Label()
        Me.sldr_Colors_Alpha = New MB.Controls.ColorSlider()
        Me.rbtn_Colors_white = New System.Windows.Forms.RadioButton()
        Me.btn_RestColors = New System.Windows.Forms.Button()
        Me.rbtn_Colors_pink = New System.Windows.Forms.RadioButton()
        Me.rbtn_Colors_purple = New System.Windows.Forms.RadioButton()
        Me.rbtn_Colors_blue = New System.Windows.Forms.RadioButton()
        Me.rbtn_Colors_teal = New System.Windows.Forms.RadioButton()
        Me.rbtn_Colors_green = New System.Windows.Forms.RadioButton()
        Me.rbtn_Colors_yellow = New System.Windows.Forms.RadioButton()
        Me.rbtn_Colors_orange = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rbtn_Colors_red = New System.Windows.Forms.RadioButton()
        Me.tbpg_Effects = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_RestEffectsFlash = New System.Windows.Forms.Button()
        Me.lbl_Effects_FlashDelay = New System.Windows.Forms.Label()
        Me.sldr_Effects_Flash_Delay = New MB.Controls.ColorSlider()
        Me.chkbx_Effects_Flash_white = New System.Windows.Forms.CheckBox()
        Me.btn_Effects_FlashStop = New System.Windows.Forms.Button()
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_RestEffectsFade = New System.Windows.Forms.Button()
        Me.sldr_Effects_Fade_Delay = New MB.Controls.ColorSlider()
        Me.btn_Effects_FadeStop = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_Effects_FadeDelay = New System.Windows.Forms.Label()
        Me.pgrbr_Effects_Fade = New System.Windows.Forms.ProgressBar()
        Me.btn_Effects_FadeStart = New System.Windows.Forms.Button()
        Me.tbpg_Info = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbpg_Options = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_ResetOptions = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbx_BaudRate = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbx_ComPort = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_Info_Titel = New System.Windows.Forms.Label()
        Me.lbl_Info_Beschreibung = New System.Windows.Forms.Label()
        Me.lbl_Info_Firma = New System.Windows.Forms.Label()
        Me.lbl_Info_Copyright = New System.Windows.Forms.Label()
        Me.lbl_Info_Version = New System.Windows.Forms.Label()
        Me.tbctrl_1.SuspendLayout()
        Me.tbpg_Slider.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picbx_Slider_Color, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpg_Colors.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbpg_Effects.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tbpg_Info.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.tbpg_Options.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbctrl_1
        '
        Me.tbctrl_1.Controls.Add(Me.tbpg_Slider)
        Me.tbctrl_1.Controls.Add(Me.tbpg_Colors)
        Me.tbctrl_1.Controls.Add(Me.tbpg_Effects)
        Me.tbctrl_1.Controls.Add(Me.tbpg_Info)
        Me.tbctrl_1.Controls.Add(Me.tbpg_Options)
        Me.tbctrl_1.Location = New System.Drawing.Point(12, 12)
        Me.tbctrl_1.Name = "tbctrl_1"
        Me.tbctrl_1.SelectedIndex = 0
        Me.tbctrl_1.Size = New System.Drawing.Size(380, 360)
        Me.tbctrl_1.TabIndex = 4
        '
        'tbpg_Slider
        '
        Me.tbpg_Slider.Controls.Add(Me.GroupBox2)
        Me.tbpg_Slider.Location = New System.Drawing.Point(4, 22)
        Me.tbpg_Slider.Name = "tbpg_Slider"
        Me.tbpg_Slider.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpg_Slider.Size = New System.Drawing.Size(372, 334)
        Me.tbpg_Slider.TabIndex = 0
        Me.tbpg_Slider.Text = "RGB Slider"
        Me.tbpg_Slider.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_Slider_Red)
        Me.GroupBox2.Controls.Add(Me.lbl_Slider_Green)
        Me.GroupBox2.Controls.Add(Me.lbl_Slider_Blue)
        Me.GroupBox2.Controls.Add(Me.lbl_Slider_Alpha)
        Me.GroupBox2.Controls.Add(Me.sldr_Slider_Alpha)
        Me.GroupBox2.Controls.Add(Me.sldr_Slider_Red)
        Me.GroupBox2.Controls.Add(Me.sldr_Slider_Blue)
        Me.GroupBox2.Controls.Add(Me.sldr_Slider_Green)
        Me.GroupBox2.Controls.Add(Me.btn_ResetSlider)
        Me.GroupBox2.Controls.Add(Me.picbx_Slider_Color)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 295)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color Picker"
        '
        'lbl_Slider_Red
        '
        Me.lbl_Slider_Red.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Slider_Red.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Slider_Red.Location = New System.Drawing.Point(56, 19)
        Me.lbl_Slider_Red.Name = "lbl_Slider_Red"
        Me.lbl_Slider_Red.Size = New System.Drawing.Size(53, 30)
        Me.lbl_Slider_Red.TabIndex = 36
        Me.lbl_Slider_Red.Text = "0"
        Me.lbl_Slider_Red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Slider_Green
        '
        Me.lbl_Slider_Green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Slider_Green.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Slider_Green.Location = New System.Drawing.Point(56, 55)
        Me.lbl_Slider_Green.Name = "lbl_Slider_Green"
        Me.lbl_Slider_Green.Size = New System.Drawing.Size(53, 30)
        Me.lbl_Slider_Green.TabIndex = 35
        Me.lbl_Slider_Green.Text = "0"
        Me.lbl_Slider_Green.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Slider_Blue
        '
        Me.lbl_Slider_Blue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Slider_Blue.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Slider_Blue.Location = New System.Drawing.Point(56, 92)
        Me.lbl_Slider_Blue.Name = "lbl_Slider_Blue"
        Me.lbl_Slider_Blue.Size = New System.Drawing.Size(53, 30)
        Me.lbl_Slider_Blue.TabIndex = 34
        Me.lbl_Slider_Blue.Text = "0"
        Me.lbl_Slider_Blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Slider_Alpha
        '
        Me.lbl_Slider_Alpha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Slider_Alpha.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Slider_Alpha.Location = New System.Drawing.Point(56, 128)
        Me.lbl_Slider_Alpha.Name = "lbl_Slider_Alpha"
        Me.lbl_Slider_Alpha.Size = New System.Drawing.Size(53, 33)
        Me.lbl_Slider_Alpha.TabIndex = 33
        Me.lbl_Slider_Alpha.Text = "0"
        Me.lbl_Slider_Alpha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sldr_Slider_Alpha
        '
        Me.sldr_Slider_Alpha.BackColor = System.Drawing.Color.Transparent
        Me.sldr_Slider_Alpha.BarInnerColor = System.Drawing.Color.Gainsboro
        Me.sldr_Slider_Alpha.BarOuterColor = System.Drawing.Color.Silver
        Me.sldr_Slider_Alpha.BorderRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Slider_Alpha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sldr_Slider_Alpha.ElapsedInnerColor = System.Drawing.Color.Gold
        Me.sldr_Slider_Alpha.ElapsedOuterColor = System.Drawing.Color.Orange
        Me.sldr_Slider_Alpha.LargeChange = CType(5UI, UInteger)
        Me.sldr_Slider_Alpha.Location = New System.Drawing.Point(115, 128)
        Me.sldr_Slider_Alpha.Maximum = 20
        Me.sldr_Slider_Alpha.Minimum = 5
        Me.sldr_Slider_Alpha.Name = "sldr_Slider_Alpha"
        Me.sldr_Slider_Alpha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sldr_Slider_Alpha.Size = New System.Drawing.Size(200, 33)
        Me.sldr_Slider_Alpha.SmallChange = CType(1UI, UInteger)
        Me.sldr_Slider_Alpha.TabIndex = 32
        Me.sldr_Slider_Alpha.Text = "ColorSlider7"
        Me.sldr_Slider_Alpha.ThumbRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Slider_Alpha.Value = 5
        '
        'sldr_Slider_Red
        '
        Me.sldr_Slider_Red.BackColor = System.Drawing.Color.Transparent
        Me.sldr_Slider_Red.BarInnerColor = System.Drawing.Color.Silver
        Me.sldr_Slider_Red.BarOuterColor = System.Drawing.Color.Gray
        Me.sldr_Slider_Red.BorderRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Slider_Red.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sldr_Slider_Red.ElapsedInnerColor = System.Drawing.Color.Red
        Me.sldr_Slider_Red.ElapsedOuterColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sldr_Slider_Red.LargeChange = CType(5UI, UInteger)
        Me.sldr_Slider_Red.Location = New System.Drawing.Point(115, 19)
        Me.sldr_Slider_Red.Maximum = 255
        Me.sldr_Slider_Red.Name = "sldr_Slider_Red"
        Me.sldr_Slider_Red.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sldr_Slider_Red.Size = New System.Drawing.Size(200, 30)
        Me.sldr_Slider_Red.SmallChange = CType(1UI, UInteger)
        Me.sldr_Slider_Red.TabIndex = 31
        Me.sldr_Slider_Red.Text = "ColorSlider3"
        Me.sldr_Slider_Red.ThumbRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Slider_Red.Value = 0
        '
        'sldr_Slider_Blue
        '
        Me.sldr_Slider_Blue.BackColor = System.Drawing.Color.Transparent
        Me.sldr_Slider_Blue.BarInnerColor = System.Drawing.Color.Silver
        Me.sldr_Slider_Blue.BarOuterColor = System.Drawing.Color.Gray
        Me.sldr_Slider_Blue.BorderRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Slider_Blue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sldr_Slider_Blue.ElapsedInnerColor = System.Drawing.Color.Blue
        Me.sldr_Slider_Blue.ElapsedOuterColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sldr_Slider_Blue.LargeChange = CType(5UI, UInteger)
        Me.sldr_Slider_Blue.Location = New System.Drawing.Point(115, 92)
        Me.sldr_Slider_Blue.Maximum = 255
        Me.sldr_Slider_Blue.Name = "sldr_Slider_Blue"
        Me.sldr_Slider_Blue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sldr_Slider_Blue.Size = New System.Drawing.Size(200, 30)
        Me.sldr_Slider_Blue.SmallChange = CType(1UI, UInteger)
        Me.sldr_Slider_Blue.TabIndex = 30
        Me.sldr_Slider_Blue.Text = "ColorSlider2"
        Me.sldr_Slider_Blue.ThumbRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Slider_Blue.Value = 0
        '
        'sldr_Slider_Green
        '
        Me.sldr_Slider_Green.BackColor = System.Drawing.Color.Transparent
        Me.sldr_Slider_Green.BarInnerColor = System.Drawing.Color.Silver
        Me.sldr_Slider_Green.BarOuterColor = System.Drawing.Color.Gray
        Me.sldr_Slider_Green.BorderRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Slider_Green.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sldr_Slider_Green.ElapsedInnerColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sldr_Slider_Green.ElapsedOuterColor = System.Drawing.Color.Green
        Me.sldr_Slider_Green.LargeChange = CType(5UI, UInteger)
        Me.sldr_Slider_Green.Location = New System.Drawing.Point(115, 55)
        Me.sldr_Slider_Green.Maximum = 255
        Me.sldr_Slider_Green.Name = "sldr_Slider_Green"
        Me.sldr_Slider_Green.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sldr_Slider_Green.Size = New System.Drawing.Size(200, 30)
        Me.sldr_Slider_Green.SmallChange = CType(1UI, UInteger)
        Me.sldr_Slider_Green.TabIndex = 29
        Me.sldr_Slider_Green.Text = "ColorSlider1"
        Me.sldr_Slider_Green.ThumbRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Slider_Green.Value = 0
        '
        'btn_ResetSlider
        '
        Me.btn_ResetSlider.Location = New System.Drawing.Point(133, 266)
        Me.btn_ResetSlider.Name = "btn_ResetSlider"
        Me.btn_ResetSlider.Size = New System.Drawing.Size(75, 23)
        Me.btn_ResetSlider.TabIndex = 28
        Me.btn_ResetSlider.Text = "Reset"
        Me.btn_ResetSlider.UseVisualStyleBackColor = True
        '
        'picbx_Slider_Color
        '
        Me.picbx_Slider_Color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picbx_Slider_Color.Location = New System.Drawing.Point(17, 173)
        Me.picbx_Slider_Color.Name = "picbx_Slider_Color"
        Me.picbx_Slider_Color.Size = New System.Drawing.Size(298, 76)
        Me.picbx_Slider_Color.TabIndex = 7
        Me.picbx_Slider_Color.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Alpha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Red"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Green"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Blue"
        '
        'tbpg_Colors
        '
        Me.tbpg_Colors.BackColor = System.Drawing.SystemColors.Control
        Me.tbpg_Colors.Controls.Add(Me.GroupBox1)
        Me.tbpg_Colors.Location = New System.Drawing.Point(4, 22)
        Me.tbpg_Colors.Name = "tbpg_Colors"
        Me.tbpg_Colors.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpg_Colors.Size = New System.Drawing.Size(372, 334)
        Me.tbpg_Colors.TabIndex = 1
        Me.tbpg_Colors.Text = "Colors"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_Colors_Alpha)
        Me.GroupBox1.Controls.Add(Me.sldr_Colors_Alpha)
        Me.GroupBox1.Controls.Add(Me.rbtn_Colors_white)
        Me.GroupBox1.Controls.Add(Me.btn_RestColors)
        Me.GroupBox1.Controls.Add(Me.rbtn_Colors_pink)
        Me.GroupBox1.Controls.Add(Me.rbtn_Colors_purple)
        Me.GroupBox1.Controls.Add(Me.rbtn_Colors_blue)
        Me.GroupBox1.Controls.Add(Me.rbtn_Colors_teal)
        Me.GroupBox1.Controls.Add(Me.rbtn_Colors_green)
        Me.GroupBox1.Controls.Add(Me.rbtn_Colors_yellow)
        Me.GroupBox1.Controls.Add(Me.rbtn_Colors_orange)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.rbtn_Colors_red)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 295)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colors"
        '
        'lbl_Colors_Alpha
        '
        Me.lbl_Colors_Alpha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Colors_Alpha.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Colors_Alpha.Location = New System.Drawing.Point(71, 181)
        Me.lbl_Colors_Alpha.Name = "lbl_Colors_Alpha"
        Me.lbl_Colors_Alpha.Size = New System.Drawing.Size(53, 33)
        Me.lbl_Colors_Alpha.TabIndex = 30
        Me.lbl_Colors_Alpha.Text = "0"
        Me.lbl_Colors_Alpha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sldr_Colors_Alpha
        '
        Me.sldr_Colors_Alpha.BackColor = System.Drawing.Color.Transparent
        Me.sldr_Colors_Alpha.BarInnerColor = System.Drawing.Color.Gainsboro
        Me.sldr_Colors_Alpha.BarOuterColor = System.Drawing.Color.Silver
        Me.sldr_Colors_Alpha.BorderRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Colors_Alpha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sldr_Colors_Alpha.ElapsedInnerColor = System.Drawing.Color.Gold
        Me.sldr_Colors_Alpha.ElapsedOuterColor = System.Drawing.Color.Orange
        Me.sldr_Colors_Alpha.LargeChange = CType(5UI, UInteger)
        Me.sldr_Colors_Alpha.Location = New System.Drawing.Point(130, 181)
        Me.sldr_Colors_Alpha.Maximum = 20
        Me.sldr_Colors_Alpha.Minimum = 5
        Me.sldr_Colors_Alpha.Name = "sldr_Colors_Alpha"
        Me.sldr_Colors_Alpha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sldr_Colors_Alpha.Size = New System.Drawing.Size(166, 33)
        Me.sldr_Colors_Alpha.SmallChange = CType(1UI, UInteger)
        Me.sldr_Colors_Alpha.TabIndex = 29
        Me.sldr_Colors_Alpha.Text = "ColorSlider4"
        Me.sldr_Colors_Alpha.ThumbRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Colors_Alpha.Value = 5
        '
        'rbtn_Colors_white
        '
        Me.rbtn_Colors_white.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_Colors_white.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_white
        Me.rbtn_Colors_white.Checked = True
        Me.rbtn_Colors_white.Location = New System.Drawing.Point(216, 19)
        Me.rbtn_Colors_white.Name = "rbtn_Colors_white"
        Me.rbtn_Colors_white.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.rbtn_Colors_white.Size = New System.Drawing.Size(80, 30)
        Me.rbtn_Colors_white.TabIndex = 28
        Me.rbtn_Colors_white.TabStop = True
        Me.rbtn_Colors_white.Text = "  "
        Me.rbtn_Colors_white.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Colors_white.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbtn_Colors_white.UseVisualStyleBackColor = False
        '
        'btn_RestColors
        '
        Me.btn_RestColors.Location = New System.Drawing.Point(133, 255)
        Me.btn_RestColors.Name = "btn_RestColors"
        Me.btn_RestColors.Size = New System.Drawing.Size(75, 23)
        Me.btn_RestColors.TabIndex = 27
        Me.btn_RestColors.Text = "Reset"
        Me.btn_RestColors.UseVisualStyleBackColor = True
        '
        'rbtn_Colors_pink
        '
        Me.rbtn_Colors_pink.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_Colors_pink.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_pink
        Me.rbtn_Colors_pink.Location = New System.Drawing.Point(130, 127)
        Me.rbtn_Colors_pink.Name = "rbtn_Colors_pink"
        Me.rbtn_Colors_pink.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.rbtn_Colors_pink.Size = New System.Drawing.Size(80, 30)
        Me.rbtn_Colors_pink.TabIndex = 25
        Me.rbtn_Colors_pink.Text = "  "
        Me.rbtn_Colors_pink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Colors_pink.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbtn_Colors_pink.UseVisualStyleBackColor = False
        '
        'rbtn_Colors_purple
        '
        Me.rbtn_Colors_purple.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_Colors_purple.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_purple
        Me.rbtn_Colors_purple.Location = New System.Drawing.Point(130, 91)
        Me.rbtn_Colors_purple.Name = "rbtn_Colors_purple"
        Me.rbtn_Colors_purple.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.rbtn_Colors_purple.Size = New System.Drawing.Size(80, 30)
        Me.rbtn_Colors_purple.TabIndex = 24
        Me.rbtn_Colors_purple.Text = "  "
        Me.rbtn_Colors_purple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Colors_purple.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbtn_Colors_purple.UseVisualStyleBackColor = False
        '
        'rbtn_Colors_blue
        '
        Me.rbtn_Colors_blue.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_Colors_blue.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_blue
        Me.rbtn_Colors_blue.Location = New System.Drawing.Point(130, 55)
        Me.rbtn_Colors_blue.Name = "rbtn_Colors_blue"
        Me.rbtn_Colors_blue.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.rbtn_Colors_blue.Size = New System.Drawing.Size(80, 30)
        Me.rbtn_Colors_blue.TabIndex = 23
        Me.rbtn_Colors_blue.Text = "  "
        Me.rbtn_Colors_blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Colors_blue.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbtn_Colors_blue.UseVisualStyleBackColor = False
        '
        'rbtn_Colors_teal
        '
        Me.rbtn_Colors_teal.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_Colors_teal.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_teal
        Me.rbtn_Colors_teal.Location = New System.Drawing.Point(130, 19)
        Me.rbtn_Colors_teal.Name = "rbtn_Colors_teal"
        Me.rbtn_Colors_teal.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.rbtn_Colors_teal.Size = New System.Drawing.Size(80, 30)
        Me.rbtn_Colors_teal.TabIndex = 22
        Me.rbtn_Colors_teal.Text = "  "
        Me.rbtn_Colors_teal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Colors_teal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbtn_Colors_teal.UseVisualStyleBackColor = False
        '
        'rbtn_Colors_green
        '
        Me.rbtn_Colors_green.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_Colors_green.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_green
        Me.rbtn_Colors_green.Location = New System.Drawing.Point(44, 127)
        Me.rbtn_Colors_green.Name = "rbtn_Colors_green"
        Me.rbtn_Colors_green.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.rbtn_Colors_green.Size = New System.Drawing.Size(80, 30)
        Me.rbtn_Colors_green.TabIndex = 21
        Me.rbtn_Colors_green.Text = "  "
        Me.rbtn_Colors_green.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Colors_green.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbtn_Colors_green.UseVisualStyleBackColor = False
        '
        'rbtn_Colors_yellow
        '
        Me.rbtn_Colors_yellow.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_Colors_yellow.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_yellow
        Me.rbtn_Colors_yellow.Location = New System.Drawing.Point(44, 91)
        Me.rbtn_Colors_yellow.Name = "rbtn_Colors_yellow"
        Me.rbtn_Colors_yellow.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.rbtn_Colors_yellow.Size = New System.Drawing.Size(80, 30)
        Me.rbtn_Colors_yellow.TabIndex = 20
        Me.rbtn_Colors_yellow.Text = "  "
        Me.rbtn_Colors_yellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Colors_yellow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbtn_Colors_yellow.UseVisualStyleBackColor = False
        '
        'rbtn_Colors_orange
        '
        Me.rbtn_Colors_orange.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_Colors_orange.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_orange
        Me.rbtn_Colors_orange.Location = New System.Drawing.Point(44, 55)
        Me.rbtn_Colors_orange.Name = "rbtn_Colors_orange"
        Me.rbtn_Colors_orange.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.rbtn_Colors_orange.Size = New System.Drawing.Size(80, 30)
        Me.rbtn_Colors_orange.TabIndex = 19
        Me.rbtn_Colors_orange.Text = "  "
        Me.rbtn_Colors_orange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Colors_orange.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbtn_Colors_orange.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Alpha"
        '
        'rbtn_Colors_red
        '
        Me.rbtn_Colors_red.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_Colors_red.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_red
        Me.rbtn_Colors_red.Location = New System.Drawing.Point(44, 19)
        Me.rbtn_Colors_red.Name = "rbtn_Colors_red"
        Me.rbtn_Colors_red.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.rbtn_Colors_red.Size = New System.Drawing.Size(80, 30)
        Me.rbtn_Colors_red.TabIndex = 0
        Me.rbtn_Colors_red.Text = "  "
        Me.rbtn_Colors_red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Colors_red.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.rbtn_Colors_red.UseVisualStyleBackColor = False
        '
        'tbpg_Effects
        '
        Me.tbpg_Effects.BackColor = System.Drawing.SystemColors.Control
        Me.tbpg_Effects.Controls.Add(Me.GroupBox5)
        Me.tbpg_Effects.Controls.Add(Me.GroupBox4)
        Me.tbpg_Effects.Location = New System.Drawing.Point(4, 22)
        Me.tbpg_Effects.Name = "tbpg_Effects"
        Me.tbpg_Effects.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpg_Effects.Size = New System.Drawing.Size(372, 334)
        Me.tbpg_Effects.TabIndex = 2
        Me.tbpg_Effects.Text = "Effects"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_RestEffectsFlash)
        Me.GroupBox5.Controls.Add(Me.lbl_Effects_FlashDelay)
        Me.GroupBox5.Controls.Add(Me.sldr_Effects_Flash_Delay)
        Me.GroupBox5.Controls.Add(Me.chkbx_Effects_Flash_white)
        Me.GroupBox5.Controls.Add(Me.btn_Effects_FlashStop)
        Me.GroupBox5.Controls.Add(Me.chkbx_Effects_Flash_yellow)
        Me.GroupBox5.Controls.Add(Me.chkbx_Effects_Flash_pink)
        Me.GroupBox5.Controls.Add(Me.chkbx_Effects_Flash_purple)
        Me.GroupBox5.Controls.Add(Me.chkbx_Effects_Flash_blue)
        Me.GroupBox5.Controls.Add(Me.chkbx_Effects_Flash_teal)
        Me.GroupBox5.Controls.Add(Me.chkbx_Effects_Flash_green)
        Me.GroupBox5.Controls.Add(Me.chkbx_Effects_Flash_orange)
        Me.GroupBox5.Controls.Add(Me.chkbx_Effects_Flash_red)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.btn_Effects_FlashStart)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 163)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(340, 155)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Flash"
        '
        'btn_RestEffectsFlash
        '
        Me.btn_RestEffectsFlash.Location = New System.Drawing.Point(184, 19)
        Me.btn_RestEffectsFlash.Name = "btn_RestEffectsFlash"
        Me.btn_RestEffectsFlash.Size = New System.Drawing.Size(52, 20)
        Me.btn_RestEffectsFlash.TabIndex = 20
        Me.btn_RestEffectsFlash.Text = "Reset"
        Me.btn_RestEffectsFlash.UseVisualStyleBackColor = True
        '
        'lbl_Effects_FlashDelay
        '
        Me.lbl_Effects_FlashDelay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Effects_FlashDelay.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Effects_FlashDelay.Location = New System.Drawing.Point(85, 45)
        Me.lbl_Effects_FlashDelay.Name = "lbl_Effects_FlashDelay"
        Me.lbl_Effects_FlashDelay.Size = New System.Drawing.Size(53, 20)
        Me.lbl_Effects_FlashDelay.TabIndex = 19
        Me.lbl_Effects_FlashDelay.Text = "0"
        Me.lbl_Effects_FlashDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sldr_Effects_Flash_Delay
        '
        Me.sldr_Effects_Flash_Delay.BackColor = System.Drawing.Color.Transparent
        Me.sldr_Effects_Flash_Delay.BarInnerColor = System.Drawing.Color.Gainsboro
        Me.sldr_Effects_Flash_Delay.BarOuterColor = System.Drawing.Color.Silver
        Me.sldr_Effects_Flash_Delay.BorderRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Effects_Flash_Delay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sldr_Effects_Flash_Delay.ElapsedInnerColor = System.Drawing.Color.Gold
        Me.sldr_Effects_Flash_Delay.ElapsedOuterColor = System.Drawing.Color.Orange
        Me.sldr_Effects_Flash_Delay.LargeChange = CType(5UI, UInteger)
        Me.sldr_Effects_Flash_Delay.Location = New System.Drawing.Point(144, 45)
        Me.sldr_Effects_Flash_Delay.Maximum = 20
        Me.sldr_Effects_Flash_Delay.Minimum = 5
        Me.sldr_Effects_Flash_Delay.Name = "sldr_Effects_Flash_Delay"
        Me.sldr_Effects_Flash_Delay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sldr_Effects_Flash_Delay.Size = New System.Drawing.Size(138, 20)
        Me.sldr_Effects_Flash_Delay.SmallChange = CType(1UI, UInteger)
        Me.sldr_Effects_Flash_Delay.TabIndex = 19
        Me.sldr_Effects_Flash_Delay.Text = "ColorSlider6"
        Me.sldr_Effects_Flash_Delay.ThumbRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Effects_Flash_Delay.Value = 5
        '
        'chkbx_Effects_Flash_white
        '
        Me.chkbx_Effects_Flash_white.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_white_small
        Me.chkbx_Effects_Flash_white.Location = New System.Drawing.Point(196, 114)
        Me.chkbx_Effects_Flash_white.Name = "chkbx_Effects_Flash_white"
        Me.chkbx_Effects_Flash_white.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_white.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_white.TabIndex = 26
        Me.chkbx_Effects_Flash_white.UseVisualStyleBackColor = True
        '
        'btn_Effects_FlashStop
        '
        Me.btn_Effects_FlashStop.Location = New System.Drawing.Point(242, 19)
        Me.btn_Effects_FlashStop.Name = "btn_Effects_FlashStop"
        Me.btn_Effects_FlashStop.Size = New System.Drawing.Size(40, 20)
        Me.btn_Effects_FlashStop.TabIndex = 25
        Me.btn_Effects_FlashStop.Text = "Stop"
        Me.btn_Effects_FlashStop.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_yellow
        '
        Me.chkbx_Effects_Flash_yellow.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_yellow_small
        Me.chkbx_Effects_Flash_yellow.Location = New System.Drawing.Point(150, 78)
        Me.chkbx_Effects_Flash_yellow.Name = "chkbx_Effects_Flash_yellow"
        Me.chkbx_Effects_Flash_yellow.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_yellow.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_yellow.TabIndex = 24
        Me.chkbx_Effects_Flash_yellow.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_pink
        '
        Me.chkbx_Effects_Flash_pink.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_pink_small
        Me.chkbx_Effects_Flash_pink.Location = New System.Drawing.Point(150, 114)
        Me.chkbx_Effects_Flash_pink.Name = "chkbx_Effects_Flash_pink"
        Me.chkbx_Effects_Flash_pink.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_pink.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_pink.TabIndex = 23
        Me.chkbx_Effects_Flash_pink.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_purple
        '
        Me.chkbx_Effects_Flash_purple.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_purple_small
        Me.chkbx_Effects_Flash_purple.Location = New System.Drawing.Point(104, 114)
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
        Me.chkbx_Effects_Flash_blue.Location = New System.Drawing.Point(58, 114)
        Me.chkbx_Effects_Flash_blue.Name = "chkbx_Effects_Flash_blue"
        Me.chkbx_Effects_Flash_blue.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_blue.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_blue.TabIndex = 21
        Me.chkbx_Effects_Flash_blue.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_teal
        '
        Me.chkbx_Effects_Flash_teal.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_teal_small
        Me.chkbx_Effects_Flash_teal.Location = New System.Drawing.Point(242, 78)
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
        Me.chkbx_Effects_Flash_green.Location = New System.Drawing.Point(196, 78)
        Me.chkbx_Effects_Flash_green.Name = "chkbx_Effects_Flash_green"
        Me.chkbx_Effects_Flash_green.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_green.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_green.TabIndex = 19
        Me.chkbx_Effects_Flash_green.UseVisualStyleBackColor = True
        '
        'chkbx_Effects_Flash_orange
        '
        Me.chkbx_Effects_Flash_orange.BackgroundImage = Global.MagicLED.My.Resources.Resources.button_orange_small
        Me.chkbx_Effects_Flash_orange.Location = New System.Drawing.Point(104, 78)
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
        Me.chkbx_Effects_Flash_red.Location = New System.Drawing.Point(58, 78)
        Me.chkbx_Effects_Flash_red.Name = "chkbx_Effects_Flash_red"
        Me.chkbx_Effects_Flash_red.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.chkbx_Effects_Flash_red.Size = New System.Drawing.Size(40, 30)
        Me.chkbx_Effects_Flash_red.TabIndex = 17
        Me.chkbx_Effects_Flash_red.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Delay (ms)"
        '
        'btn_Effects_FlashStart
        '
        Me.btn_Effects_FlashStart.Location = New System.Drawing.Point(288, 19)
        Me.btn_Effects_FlashStart.Name = "btn_Effects_FlashStart"
        Me.btn_Effects_FlashStart.Size = New System.Drawing.Size(40, 20)
        Me.btn_Effects_FlashStart.TabIndex = 13
        Me.btn_Effects_FlashStart.Text = "Start"
        Me.btn_Effects_FlashStart.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_RestEffectsFade)
        Me.GroupBox4.Controls.Add(Me.sldr_Effects_Fade_Delay)
        Me.GroupBox4.Controls.Add(Me.btn_Effects_FadeStop)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.lbl_Effects_FadeDelay)
        Me.GroupBox4.Controls.Add(Me.pgrbr_Effects_Fade)
        Me.GroupBox4.Controls.Add(Me.btn_Effects_FadeStart)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(340, 130)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fade"
        '
        'btn_RestEffectsFade
        '
        Me.btn_RestEffectsFade.Location = New System.Drawing.Point(184, 19)
        Me.btn_RestEffectsFade.Name = "btn_RestEffectsFade"
        Me.btn_RestEffectsFade.Size = New System.Drawing.Size(52, 20)
        Me.btn_RestEffectsFade.TabIndex = 19
        Me.btn_RestEffectsFade.Text = "Reset"
        Me.btn_RestEffectsFade.UseVisualStyleBackColor = True
        '
        'sldr_Effects_Fade_Delay
        '
        Me.sldr_Effects_Fade_Delay.BackColor = System.Drawing.Color.Transparent
        Me.sldr_Effects_Fade_Delay.BarInnerColor = System.Drawing.Color.Gainsboro
        Me.sldr_Effects_Fade_Delay.BarOuterColor = System.Drawing.Color.Silver
        Me.sldr_Effects_Fade_Delay.BorderRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Effects_Fade_Delay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sldr_Effects_Fade_Delay.ElapsedInnerColor = System.Drawing.Color.Gold
        Me.sldr_Effects_Fade_Delay.ElapsedOuterColor = System.Drawing.Color.Orange
        Me.sldr_Effects_Fade_Delay.LargeChange = CType(5UI, UInteger)
        Me.sldr_Effects_Fade_Delay.Location = New System.Drawing.Point(144, 45)
        Me.sldr_Effects_Fade_Delay.Maximum = 20
        Me.sldr_Effects_Fade_Delay.Minimum = 5
        Me.sldr_Effects_Fade_Delay.Name = "sldr_Effects_Fade_Delay"
        Me.sldr_Effects_Fade_Delay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sldr_Effects_Fade_Delay.Size = New System.Drawing.Size(138, 20)
        Me.sldr_Effects_Fade_Delay.SmallChange = CType(1UI, UInteger)
        Me.sldr_Effects_Fade_Delay.TabIndex = 18
        Me.sldr_Effects_Fade_Delay.Text = "ColorSlider5"
        Me.sldr_Effects_Fade_Delay.ThumbRoundRectSize = New System.Drawing.Size(8, 8)
        Me.sldr_Effects_Fade_Delay.Value = 5
        '
        'btn_Effects_FadeStop
        '
        Me.btn_Effects_FadeStop.Location = New System.Drawing.Point(242, 19)
        Me.btn_Effects_FadeStop.Name = "btn_Effects_FadeStop"
        Me.btn_Effects_FadeStop.Size = New System.Drawing.Size(40, 20)
        Me.btn_Effects_FadeStop.TabIndex = 17
        Me.btn_Effects_FadeStop.Text = "Stop"
        Me.btn_Effects_FadeStop.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Delay (ms)"
        '
        'lbl_Effects_FadeDelay
        '
        Me.lbl_Effects_FadeDelay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Effects_FadeDelay.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Effects_FadeDelay.Location = New System.Drawing.Point(85, 45)
        Me.lbl_Effects_FadeDelay.Name = "lbl_Effects_FadeDelay"
        Me.lbl_Effects_FadeDelay.Size = New System.Drawing.Size(53, 20)
        Me.lbl_Effects_FadeDelay.TabIndex = 15
        Me.lbl_Effects_FadeDelay.Text = "0"
        Me.lbl_Effects_FadeDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgrbr_Effects_Fade
        '
        Me.pgrbr_Effects_Fade.Location = New System.Drawing.Point(13, 86)
        Me.pgrbr_Effects_Fade.Name = "pgrbr_Effects_Fade"
        Me.pgrbr_Effects_Fade.Size = New System.Drawing.Size(315, 23)
        Me.pgrbr_Effects_Fade.TabIndex = 14
        '
        'btn_Effects_FadeStart
        '
        Me.btn_Effects_FadeStart.Location = New System.Drawing.Point(288, 19)
        Me.btn_Effects_FadeStart.Name = "btn_Effects_FadeStart"
        Me.btn_Effects_FadeStart.Size = New System.Drawing.Size(40, 20)
        Me.btn_Effects_FadeStart.TabIndex = 13
        Me.btn_Effects_FadeStart.Text = "Start"
        Me.btn_Effects_FadeStart.UseVisualStyleBackColor = True
        '
        'tbpg_Info
        '
        Me.tbpg_Info.BackColor = System.Drawing.SystemColors.Control
        Me.tbpg_Info.Controls.Add(Me.GroupBox6)
        Me.tbpg_Info.Location = New System.Drawing.Point(4, 22)
        Me.tbpg_Info.Name = "tbpg_Info"
        Me.tbpg_Info.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpg_Info.Size = New System.Drawing.Size(372, 334)
        Me.tbpg_Info.TabIndex = 4
        Me.tbpg_Info.Text = "Info"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.MagicLED.My.Resources.Resources.icon_big
        Me.PictureBox2.Location = New System.Drawing.Point(6, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(159, 279)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PictureBox2)
        Me.GroupBox6.Controls.Add(Me.lbl_Info_Version)
        Me.GroupBox6.Controls.Add(Me.lbl_Info_Copyright)
        Me.GroupBox6.Controls.Add(Me.lbl_Info_Firma)
        Me.GroupBox6.Controls.Add(Me.lbl_Info_Beschreibung)
        Me.GroupBox6.Controls.Add(Me.lbl_Info_Titel)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 18)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(340, 301)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Info"
        '
        'tbpg_Options
        '
        Me.tbpg_Options.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbpg_Options.Controls.Add(Me.GroupBox3)
        Me.tbpg_Options.Location = New System.Drawing.Point(4, 22)
        Me.tbpg_Options.Name = "tbpg_Options"
        Me.tbpg_Options.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpg_Options.Size = New System.Drawing.Size(372, 334)
        Me.tbpg_Options.TabIndex = 3
        Me.tbpg_Options.Text = "Options"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_ResetOptions)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cbx_BaudRate)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cbx_ComPort)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(340, 295)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'btn_ResetOptions
        '
        Me.btn_ResetOptions.Location = New System.Drawing.Point(133, 255)
        Me.btn_ResetOptions.Name = "btn_ResetOptions"
        Me.btn_ResetOptions.Size = New System.Drawing.Size(75, 23)
        Me.btn_ResetOptions.TabIndex = 4
        Me.btn_ResetOptions.Text = "Reset"
        Me.btn_ResetOptions.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Bautrate:"
        '
        'cbx_BaudRate
        '
        Me.cbx_BaudRate.FormattingEnabled = True
        Me.cbx_BaudRate.Items.AddRange(New Object() {"300", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200"})
        Me.cbx_BaudRate.Location = New System.Drawing.Point(22, 98)
        Me.cbx_BaudRate.Name = "cbx_BaudRate"
        Me.cbx_BaudRate.Size = New System.Drawing.Size(121, 21)
        Me.cbx_BaudRate.TabIndex = 2
        Me.cbx_BaudRate.Text = "115200"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Comport:"
        '
        'cbx_ComPort
        '
        Me.cbx_ComPort.FormattingEnabled = True
        Me.cbx_ComPort.Location = New System.Drawing.Point(22, 43)
        Me.cbx_ComPort.Name = "cbx_ComPort"
        Me.cbx_ComPort.Size = New System.Drawing.Size(121, 21)
        Me.cbx_ComPort.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 383)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(404, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_StatusLabel
        '
        Me.lbl_StatusLabel.Name = "lbl_StatusLabel"
        Me.lbl_StatusLabel.Size = New System.Drawing.Size(46, 17)
        Me.lbl_StatusLabel.Text = "Bereit..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titel:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Beschreibung:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Version:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(172, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Firma:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(172, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Copyright:"
        '
        'lbl_Info_Titel
        '
        Me.lbl_Info_Titel.AutoSize = True
        Me.lbl_Info_Titel.Location = New System.Drawing.Point(171, 32)
        Me.lbl_Info_Titel.Name = "lbl_Info_Titel"
        Me.lbl_Info_Titel.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Info_Titel.TabIndex = 5
        Me.lbl_Info_Titel.Text = "<Titel>"
        '
        'lbl_Info_Beschreibung
        '
        Me.lbl_Info_Beschreibung.Location = New System.Drawing.Point(172, 126)
        Me.lbl_Info_Beschreibung.Name = "lbl_Info_Beschreibung"
        Me.lbl_Info_Beschreibung.Size = New System.Drawing.Size(162, 60)
        Me.lbl_Info_Beschreibung.TabIndex = 6
        Me.lbl_Info_Beschreibung.Text = "<Beschreibung>"
        '
        'lbl_Info_Firma
        '
        Me.lbl_Info_Firma.AutoSize = True
        Me.lbl_Info_Firma.Location = New System.Drawing.Point(172, 211)
        Me.lbl_Info_Firma.Name = "lbl_Info_Firma"
        Me.lbl_Info_Firma.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Info_Firma.TabIndex = 7
        Me.lbl_Info_Firma.Text = "<Firma>"
        '
        'lbl_Info_Copyright
        '
        Me.lbl_Info_Copyright.AutoSize = True
        Me.lbl_Info_Copyright.Location = New System.Drawing.Point(172, 263)
        Me.lbl_Info_Copyright.Name = "lbl_Info_Copyright"
        Me.lbl_Info_Copyright.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Info_Copyright.TabIndex = 8
        Me.lbl_Info_Copyright.Text = "<Copyright>"
        '
        'lbl_Info_Version
        '
        Me.lbl_Info_Version.AutoSize = True
        Me.lbl_Info_Version.Location = New System.Drawing.Point(172, 87)
        Me.lbl_Info_Version.Name = "lbl_Info_Version"
        Me.lbl_Info_Version.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Info_Version.TabIndex = 9
        Me.lbl_Info_Version.Text = "<Version>"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 405)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tbctrl_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "MagicLED 2012"
        Me.tbctrl_1.ResumeLayout(False)
        Me.tbpg_Slider.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picbx_Slider_Color, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpg_Colors.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbpg_Effects.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tbpg_Info.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tbpg_Options.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbctrl_1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpg_Options As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ResetOptions As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbx_BaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbx_ComPort As System.Windows.Forms.ComboBox
    Friend WithEvents tbpg_Slider As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents sldr_Slider_Alpha As MB.Controls.ColorSlider
    Friend WithEvents sldr_Slider_Red As MB.Controls.ColorSlider
    Friend WithEvents sldr_Slider_Blue As MB.Controls.ColorSlider
    Friend WithEvents sldr_Slider_Green As MB.Controls.ColorSlider
    Friend WithEvents btn_ResetSlider As System.Windows.Forms.Button
    Friend WithEvents picbx_Slider_Color As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbpg_Colors As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtn_Colors_white As System.Windows.Forms.RadioButton
    Friend WithEvents btn_RestColors As System.Windows.Forms.Button
    Friend WithEvents rbtn_Colors_pink As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Colors_purple As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Colors_blue As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Colors_teal As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Colors_green As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Colors_yellow As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Colors_orange As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rbtn_Colors_red As System.Windows.Forms.RadioButton
    Friend WithEvents tbpg_Effects As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkbx_Effects_Flash_white As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Effects_FlashStop As System.Windows.Forms.Button
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Effects_FadeStop As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_Effects_FadeDelay As System.Windows.Forms.Label
    Friend WithEvents pgrbr_Effects_Fade As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_Effects_FadeStart As System.Windows.Forms.Button
    Friend WithEvents tbpg_Info As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents sldr_Colors_Alpha As MB.Controls.ColorSlider
    Friend WithEvents sldr_Effects_Flash_Delay As MB.Controls.ColorSlider
    Friend WithEvents sldr_Effects_Fade_Delay As MB.Controls.ColorSlider
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_Slider_Red As System.Windows.Forms.Label
    Friend WithEvents lbl_Slider_Green As System.Windows.Forms.Label
    Friend WithEvents lbl_Slider_Blue As System.Windows.Forms.Label
    Friend WithEvents lbl_Slider_Alpha As System.Windows.Forms.Label
    Friend WithEvents lbl_Colors_Alpha As System.Windows.Forms.Label
    Friend WithEvents lbl_Effects_FlashDelay As System.Windows.Forms.Label
    Friend WithEvents btn_RestEffectsFlash As System.Windows.Forms.Button
    Friend WithEvents btn_RestEffectsFade As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Info_Version As System.Windows.Forms.Label
    Friend WithEvents lbl_Info_Copyright As System.Windows.Forms.Label
    Friend WithEvents lbl_Info_Firma As System.Windows.Forms.Label
    Friend WithEvents lbl_Info_Beschreibung As System.Windows.Forms.Label
    Friend WithEvents lbl_Info_Titel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
