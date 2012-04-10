Public Class Form1

  
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Info_Titel.Text = My.Application.Info.Title
        lbl_Info_Version.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        lbl_Info_Beschreibung.Text = My.Application.Info.Description
        lbl_Info_Firma.Text = My.Application.Info.CompanyName
        lbl_Info_Copyright.Text = My.Application.Info.Copyright

        sldr_Slider_Red.Value = sldr_Slider_Red.Minimum
        sldr_Slider_Green.Value = sldr_Slider_Green.Minimum
        sldr_Slider_Blue.Value = sldr_Slider_Blue.Minimum
        sldr_Slider_Alpha.Value = sldr_Slider_Alpha.Maximum
        sldr_Colors_Alpha.Value = sldr_Colors_Alpha.Maximum
        sldr_Effects_Fade_Delay.Value = sldr_Effects_Fade_Delay.Maximum
        sldr_Effects_Flash_Delay.Value = sldr_Effects_Flash_Delay.Maximum

        tbctrl_1.SelectTab("tbpg_Options")

        Try
            Dim Ports As String() = System.IO.Ports.SerialPort.GetPortNames()
            For Each Port As String In Ports
                cbx_ComPort.Items.Add(Port)
            Next Port
        Catch ex As Exception
        End Try

        Try
            If (My.Settings.ComPort <> "") Then cbx_ComPort.Text = My.Settings.ComPort
            If (My.Settings.Baudrate <> "") Then cbx_BaudRate.Text = My.Settings.Baudrate
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SerialPort1.Close()
    End Sub

#Region "RGB_Slider"

    Private Sub sldr_Slider_Red_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldr_Slider_Red.ValueChanged
        lbl_Slider_Red.Text = sldr_Slider_Red.Value
        CheckColor(sldr_Slider_Red.Value, sldr_Slider_Green.Value, sldr_Slider_Blue.Value)
        sendSliderCommand(sldr_Slider_Red, "re")
    End Sub

    Private Sub sldr_Slider_Green_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldr_Slider_Green.ValueChanged
        lbl_Slider_Green.Text = sldr_Slider_Green.Value
        CheckColor(sldr_Slider_Red.Value, sldr_Slider_Green.Value, sldr_Slider_Blue.Value)
        sendSliderCommand(sldr_Slider_Green, "gr")
    End Sub

    Private Sub sldr_Slider_Blue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldr_Slider_Blue.ValueChanged
        lbl_Slider_Blue.Text = sldr_Slider_Blue.Value
        CheckColor(sldr_Slider_Red.Value, sldr_Slider_Green.Value, sldr_Slider_Blue.Value)
        sendSliderCommand(sldr_Slider_Blue, "bl")
    End Sub

    Private Sub sldr_Slider_Alpha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldr_Slider_Alpha.ValueChanged
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

    Private Sub sldr_Colors_Alpha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldr_Colors_Alpha.ValueChanged
        lbl_Colors_Alpha.Text = sldr_Colors_Alpha.Value
    End Sub

    Private Sub btn_RestColors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RestColors.Click
        rbtn_Colors_white.Checked = True
        sldr_Colors_Alpha.Value = sldr_Colors_Alpha.Maximum
    End Sub

#End Region

#Region "Effects_Fade"

    Private Sub sldr_Effects_Fade_Delay_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldr_Effects_Fade_Delay.ValueChanged
        lbl_Effects_FadeDelay.Text = sldr_Effects_Fade_Delay.Value
    End Sub

    Private Sub btn_RestEffectsFade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RestEffectsFade.Click
        sldr_Effects_Fade_Delay.Value = sldr_Effects_Fade_Delay.Maximum
        pgrbr_Effects_Fade.Value = pgrbr_Effects_Fade.Minimum
    End Sub

#End Region

#Region "Effects_Flash"

    Private Sub sldr_Effects_Flash_Delay_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldr_Effects_Flash_Delay.ValueChanged
        lbl_Effects_FlashDelay.Text = sldr_Effects_Flash_Delay.Value
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
            If (Command.Length < CommandLength) Then
            Else
                SerialPort1.Write(Command)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub sendSliderCommand(ByVal Slider As System.Object, ByVal Farbe As String)
        If (Slider.Value < 100 And Slider.Value > 10) Then
            sendCommand(Farbe & "0" & Slider.Value, 5)
        ElseIf (Slider.Value < 10) Then
            sendCommand(Farbe & "00" & Slider.Value, 5)
        Else
            sendCommand(Farbe & Slider.Value, 5)
        End If
    End Sub

#End Region

#Region "Settings"
    Private Sub cbx_ComPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_ComPort.SelectedIndexChanged
        My.Settings.ComPort = cbx_ComPort.SelectedItem.ToString()
        My.Settings.Save()
    End Sub

    Private Sub cbx_BaudRate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_BaudRate.SelectedIndexChanged
        My.Settings.Baudrate = cbx_BaudRate.SelectedItem.ToString()
        My.Settings.Save()
    End Sub

    Private Sub open_ComPort()
        Try
            SerialPort1.PortName = cbx_ComPort.Text
            SerialPort1.BaudRate = cbx_BaudRate.Text
            If Not (SerialPort1.IsOpen) Then SerialPort1.Open()
        Catch ex As Exception
            lbl_StatusLabel.Text = "COM-Port kann nicht geöffnet werden"
        End Try
    End Sub

    Private Sub btn_OpenComOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OpenComOptions.Click
        Try
            If Not (SerialPort1.IsOpen) Then
                open_ComPort()
                btn_OpenComOptions.Text = "Trennen"
            Else
                SerialPort1.Close()
                btn_OpenComOptions.Text = "Verbinden"
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region


    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            SerialPort1.DiscardInBuffer()
        Catch ex As Exception
        End Try
    End Sub
End Class
