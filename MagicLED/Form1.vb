Public Class Form1

    Dim Commandlength As Integer = 9
    Dim Command(5) As Byte '0 = A, 1 = R, 2 = G, 3 = B, 4 = Command
    Dim FlashArray(9) As Boolean
    Dim CurrentColor As Color

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Set_UIF_Enable(True)

        Dim port As String
        For Each port In My.Computer.Ports.SerialPortNames
            cbx_ComportOptions.Items.Add(port)
        Next port

        SerialPort1.PortName = My.Settings.ComPort
        SerialPort1.BaudRate = CInt(My.Settings.BaudRate)

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
        SerialPort1.Close()
    End Sub

#Region "RGB_Slider"

    Private Sub ColorPicker1_ColorChanged(sender As System.Object, e As PJLControls.ColorChangedEventArgs) Handles ColorPicker1.ColorChanged
        Set_Color_To_Command(sldr_RGB_Alpha.Value, ColorPicker1.Color.R, ColorPicker1.Color.G, ColorPicker1.Color.B)
    End Sub

    Private Sub ColorPanel1_ColorChanged(sender As System.Object, e As PJLControls.ColorChangedEventArgs) Handles ColorPanel1.ColorChanged
        ColorPicker1.Color = ColorPanel1.Color
    End Sub

    Private Sub numUpDwn_RGB_Alpha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numUpDwn_RGB_Alpha.ValueChanged
        sldr_RGB_Alpha.Value = Convert.ToInt32(numUpDwn_RGB_Alpha.Value)
    End Sub

    Private Sub btn_alpha_Click(sender As System.Object, e As System.EventArgs) Handles btn_alpha.Click
        numUpDwn_RGB_Alpha.Value = 255
    End Sub

    Private Sub sldr_RGB_Alpha_Scroll(sender As System.Object, e As System.EventArgs) Handles sldr_RGB_Alpha.Scroll
        numUpDwn_RGB_Alpha.Value = sldr_RGB_Alpha.Value
        Set_Color_To_Command(sldr_RGB_Alpha.Value, ColorPicker1.Color.R, ColorPicker1.Color.G, ColorPicker1.Color.B)
    End Sub

    Private Sub btn_ResetSlider_Click(sender As System.Object, e As System.EventArgs) Handles btn_ResetSlider.Click
        ColorPicker1.Color = Color.FromKnownColor(KnownColor.Black)
        ColorPanel1.Color = Color.Black
        sldr_RGB_Alpha.Value = 255
        numUpDwn_RGB_Alpha.Value = 255
        Set_Color_To_Command(sldr_RGB_Alpha.Value, ColorPicker1.Color.R, ColorPicker1.Color.G, ColorPicker1.Color.B)
    End Sub

#End Region

#Region "Colors"


#End Region

#Region "Effects_Fade"

    Private Sub btn_RestEffectsFade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RestEffectsFade.Click

    End Sub

    Private Sub btn_Effects_FadeStart_Click(sender As System.Object, e As System.EventArgs) Handles btn_Effects_FadeStart.Click

    End Sub



#End Region

#Region "Effects_Flash"

    Private Sub btn_Effects_FlashStart_Click(sender As System.Object, e As System.EventArgs) Handles btn_Effects_FlashStart.Click

    End Sub

    Private Sub btn_RestEffectsFlash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RestEffectsFlash.Click
        numUpDwn_Effects_Flash_Delay.Value = 20
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

    Private Sub chkbx_Effects_Flash_red_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbx_Effects_Flash_red.CheckedChanged

    End Sub

    Private Sub chkbx_Effects_Flash_orange_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbx_Effects_Flash_orange.CheckedChanged

    End Sub

    Private Sub chkbx_Effects_Flash_yellow_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbx_Effects_Flash_yellow.CheckedChanged

    End Sub

    Private Sub chkbx_Effects_Flash_green_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbx_Effects_Flash_green.CheckedChanged

    End Sub

    Private Sub chkbx_Effects_Flash_teal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbx_Effects_Flash_teal.CheckedChanged

    End Sub

    Private Sub chkbx_Effects_Flash_blue_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbx_Effects_Flash_blue.CheckedChanged

    End Sub

    Private Sub chkbx_Effects_Flash_purple_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbx_Effects_Flash_purple.CheckedChanged

    End Sub

    Private Sub chkbx_Effects_Flash_pink_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbx_Effects_Flash_pink.CheckedChanged

    End Sub

    Private Sub chkbx_Effects_Flash_white_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbx_Effects_Flash_white.CheckedChanged

    End Sub

#End Region

#Region "Commands"

    Public Sub Send_Command(ByVal Command As String)
        Try
            If SerialPort1.IsOpen Then
                Control.CheckForIllegalCrossThreadCalls = False
                SerialPort1.Write(Command, 0, Commandlength)
                SerialPort1.DiscardOutBuffer()
                lbl_StatusLabel.Text = Command & " | " & "Length: " & Command.Length
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Set_Color_To_Command(ByVal alpha As Byte, ByVal red As Byte, ByVal green As Byte, blue As Byte)
        Command(0) = alpha
        Command(1) = red
        Command(2) = green
        Command(3) = blue
        Set_StatusMessage(Command(0) & " | " & Command(1) & " | " & Command(2) & " | " & Command(3) & " | " & Command(4))
    End Sub

#End Region

#Region "Toolbar"

    Private Sub btn_OpenComOptions_Click(sender As System.Object, e As System.EventArgs) Handles btn_OpenComOptions.Click
        Try
            If SerialPort1.IsOpen = False Then
                SerialPort1.Open()
                btn_OpenComOptions.BackColor = Color.LightPink
                btn_OpenComOptions.Text = "Disconnect"
                System.Threading.Thread.Sleep(500)
                Set_UIF_Enable(True)
            Else
                SerialPort1.Close()
                btn_OpenComOptions.BackColor = Color.LightGreen
                btn_OpenComOptions.Text = "Connect"
                Set_UIF_Enable(False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Set_UIF_Enable(False)
        End Try
    End Sub

    Private Sub btn_SaveOptions_Click(sender As System.Object, e As System.EventArgs) Handles btn_SaveOptions.Click
        Try
            My.Settings.ComPort = cbx_ComportOptions.Text
            My.Settings.BaudRate = CInt(cbx_BaudrateOptions.Text)
            My.Settings.Save()
            MsgBox("Einstellungen erfolgreich gespeichert")
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            lbl_status_rcv.BackColor = Color.Red
            lbl_status_Datarcv.Text = SerialPort1.ReadLine
            lbl_status_rcv.BackColor = Color.Gray
            SerialPort1.DiscardInBuffer()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_info_Click(sender As System.Object, e As System.EventArgs) Handles btn_info.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Set_StatusMessage(ByVal message As String)
        lbl_StatusLabel.Text = message
    End Sub

#End Region

    Private Sub Set_UIF_Enable(ByVal enabled As Boolean)
        If enabled = False Then
            gbx_fade.Enabled = False
            gbx_flash.Enabled = False
            gbx_slider.Enabled = False
        Else
            gbx_fade.Enabled = True
            gbx_flash.Enabled = True
            gbx_slider.Enabled = True
        End If
    End Sub




End Class
