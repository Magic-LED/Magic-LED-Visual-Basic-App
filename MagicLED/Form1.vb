Imports System.Xml

Public Class Form1

    Dim ConfigPath As String = Application.StartupPath & "\config.xml"
    Dim ConfigData As New XmlDocument
    Dim ConfigNode As XmlNode
    Dim ComPort As String
    Dim BaudRate As String
    Dim ColorFlash As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigData.Load(ConfigPath)
        ConfigNode = ConfigData.SelectSingleNode("/Systemconfig")
        ComPort = ConfigNode.SelectSingleNode("ComPort").InnerText
        BaudRate = ConfigNode.SelectSingleNode("BaudRate").InnerText

        Dim port As String
        For Each port In My.Computer.Ports.SerialPortNames
            cbx_ComportOptions.Items.Add(port)
        Next port

        SerialPort1.PortName = ComPort
        SerialPort1.BaudRate = CInt(BaudRate)

        cbx_ComportOptions.Text = SerialPort1.PortName
        cbx_BaudrateOptions.Text = SerialPort1.BaudRate

        tbpg_Slider.Enabled = False
        tbpg_Info.Enabled = False
        tbpg_Effects.Enabled = False
        tbpg_Colors.Enabled = False

        lbl_Info_Titel.Text = My.Application.Info.Title
        lbl_Info_Version.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        lbl_Info_Beschreibung.Text = My.Application.Info.Description
        lbl_Info_Firma.Text = My.Application.Info.CompanyName
        lbl_Info_Copyright.Text = My.Application.Info.Copyright

        tbctrl_1.SelectTab("tbpg_Options")

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SerialPort1.Close()
    End Sub

#Region "RGB_Slider"

    Private Sub sldr_Slider_Red_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sldr_Slider_Red.Scroll
        lbl_Slider_Red.Text = sldr_Slider_Red.Value
        CheckColor(sldr_Slider_Red.Value, sldr_Slider_Green.Value, sldr_Slider_Blue.Value)
        sendSliderCommand(sldr_Slider_Red, "re")
    End Sub

    Private Sub sldr_Slider_Green_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sldr_Slider_Green.Scroll
        lbl_Slider_Green.Text = sldr_Slider_Green.Value
        CheckColor(sldr_Slider_Red.Value, sldr_Slider_Green.Value, sldr_Slider_Blue.Value)
        sendSliderCommand(sldr_Slider_Green, "gr")
    End Sub

    Private Sub sldr_Slider_Blue_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sldr_Slider_Blue.Scroll
        lbl_Slider_Blue.Text = sldr_Slider_Blue.Value
        CheckColor(sldr_Slider_Red.Value, sldr_Slider_Green.Value, sldr_Slider_Blue.Value)
        sendSliderCommand(sldr_Slider_Blue, "bl")
    End Sub

    Private Sub sldr_Slider_Alpha_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sldr_Slider_Alpha.Scroll
        lbl_Slider_Alpha.Text = sldr_Slider_Alpha.Value
    End Sub

    Private Sub CheckColor(ByVal Red As Integer, ByVal Green As Integer, ByVal Blue As Integer)
        picbx_Slider_Color.BackColor = Color.FromArgb(Red, Green, Blue)
    End Sub

    Private Sub btn_ResetSlider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ResetSlider.Click
        sldr_Slider_Red.Value = sldr_Slider_Red.Minimum
        sldr_Slider_Green.Value = sldr_Slider_Green.Minimum
        sldr_Slider_Blue.Value = sldr_Slider_Blue.Minimum
        sldr_Slider_Alpha.Value = sldr_Slider_Alpha.Maximum
    End Sub

#End Region

#Region "Colors"

    Private Sub sldr_Colors_Alpha_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sldr_Colors_Alpha.Scroll
        lbl_Colors_Alpha.Text = sldr_Colors_Alpha.Value
    End Sub

    Private Sub btn_RestColors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RestColors.Click
        rbtn_Colors_white.Checked = True
        sldr_Colors_Alpha.Value = sldr_Colors_Alpha.Maximum
    End Sub

    Private Sub rbtnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_Colors_blue.Click, _
        rbtn_Colors_green.Click, rbtn_Colors_orange.Click, rbtn_Colors_pink.Click, rbtn_Colors_purple.Click, _
        rbtn_Colors_red.Click, rbtn_Colors_teal.Click, rbtn_Colors_white.Click, rbtn_Colors_yellow.Click, rbtn_Colors_black.Click

        Select Case True
            Case rbtn_Colors_blue.Checked
                sendCommand("SC000", 5)
                Return
            Case rbtn_Colors_green.Checked
                sendCommand("SC001", 5)
                Return
            Case rbtn_Colors_orange.Checked
                sendCommand("SC002", 5)
                Return
            Case rbtn_Colors_pink.Checked
                sendCommand("SC003", 5)
                Return
            Case rbtn_Colors_purple.Checked
                sendCommand("SC004", 5)
                Return
            Case rbtn_Colors_red.Checked
                sendCommand("SC005", 5)
                Return
            Case rbtn_Colors_teal.Checked
                sendCommand("SC006", 5)
                Return
            Case rbtn_Colors_white.Checked
                sendCommand("SC007", 5)
                Return
            Case rbtn_Colors_yellow.Checked
                sendCommand("SC008", 5)
                Return
            Case rbtn_Colors_black.Checked
                sendCommand("SC009", 5)
                Return
            Case Else
                Return
        End Select
    End Sub
#End Region

#Region "Effects_Fade"

    Private Sub sldr_Effects_Fade_Delay_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sldr_Effects_Fade_Delay.Scroll
        lbl_Effects_FadeDelay.Text = sldr_Effects_Fade_Delay.Value
    End Sub

    Private Sub btn_RestEffectsFade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RestEffectsFade.Click
        sldr_Effects_Fade_Delay.Value = sldr_Effects_Fade_Delay.Maximum
        pgrbr_Effects_Fade.Value = pgrbr_Effects_Fade.Minimum
    End Sub

#End Region

#Region "Effects_Flash"

    Private Sub sldr_Effects_Flash_Delay_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sldr_Effects_Flash_Delay.Scroll
        lbl_Effects_FlashDelay.Text = sldr_Effects_Flash_Delay.Value
    End Sub

    Private Sub CheckFlashColors()

    End Sub

    Private Sub btn_RestEffectsFlash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RestEffectsFlash.Click
        sldr_Effects_Flash_Delay.Value = sldr_Effects_Flash_Delay.Maximum
        chkbx_Effects_Flash_red.Checked = True
        chkbx_Effects_Flash_green.Checked = True
        chkbx_Effects_Flash_blue.Checked = True
        chkbx_Effects_Flash_orange.Checked = False
        chkbx_Effects_Flash_pink.Checked = False
        chkbx_Effects_Flash_purple.Checked = False
        chkbx_Effects_Flash_teal.Checked = False
        chkbx_Effects_Flash_white.Checked = False
        chkbx_Effects_Flash_yellow.Checked = False
    End Sub

#End Region


#Region "Commands"

    Private Sub sendCommand(ByVal Command As String, ByVal CommandLength As Integer)
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            SerialPort1.Write(Command, 0, CommandLength)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub sendSliderCommand(ByVal Slider As System.Object, ByVal Farbe As String)
        If (Slider.Value < 100 And Slider.Value > 10) Then
            sendCommand(Farbe & "0" & Slider.Value, 5)
            lbl_StatusLabel.Text = Farbe & "0" & Slider.Value
        ElseIf (Slider.Value < 10) Then
            sendCommand(Farbe & "00" & Slider.Value, 5)
            lbl_StatusLabel.Text = Farbe & "00" & Slider.Value
        Else
            sendCommand(Farbe & Slider.Value, 5)
            lbl_StatusLabel.Text = Farbe & Slider.Value
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            SerialPort1.DiscardInBuffer()
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Settings"

    Private Sub btn_OpenComOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OpenComOptions.Click
        Try
            If SerialPort1.IsOpen = False Then
                SerialPort1.Open()
                btn_OpenComOptions.Text = "Trennen"
                tbpg_Slider.Enabled = True
                tbpg_Info.Enabled = True
                tbpg_Effects.Enabled = True
                tbpg_Colors.Enabled = True
            Else
                SerialPort1.Close()
                btn_OpenComOptions.Text = "Verbinden"
                tbpg_Slider.Enabled = False
                tbpg_Info.Enabled = False
                tbpg_Effects.Enabled = False
                tbpg_Colors.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btn_SaveOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SaveOptions.Click
        Try
            ConfigNode.SelectSingleNode("ComPort").InnerText = cbx_ComportOptions.Text
            ConfigNode.SelectSingleNode("BaudRate").InnerText = cbx_BaudrateOptions.Text
            ConfigData.Save(ConfigPath)
            MsgBox("Einstellungen erfolgreich gespeichert")
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

#End Region



End Class
