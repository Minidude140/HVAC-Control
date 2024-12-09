<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HvacControlForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ControlsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.COMSelectToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ConnectCOMToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisconnetToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshCOMToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveSettingsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitProgramToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.COMSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.COMTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AnalogInput1TestLabel = New System.Windows.Forms.Label()
        Me.AnalogInput2TestLabel = New System.Windows.Forms.Label()
        Me.AmbientTempFLabel = New System.Windows.Forms.Label()
        Me.AmbientTempCLabel = New System.Windows.Forms.Label()
        Me.ControlSytemTempFLabel = New System.Windows.Forms.Label()
        Me.ControlSystemTempCLabel = New System.Windows.Forms.Label()
        Me.AmbientTempLabel = New System.Windows.Forms.Label()
        Me.ControlSystemTempLabel = New System.Windows.Forms.Label()
        Me.OffRadioButton = New System.Windows.Forms.RadioButton()
        Me.HeatRadioButton = New System.Windows.Forms.RadioButton()
        Me.CoolRadioButton = New System.Windows.Forms.RadioButton()
        Me.HeaterProgressBar = New System.Windows.Forms.ProgressBar()
        Me.HeatOnLabel = New System.Windows.Forms.Label()
        Me.FanOnLabel = New System.Windows.Forms.Label()
        Me.AcOnLabel = New System.Windows.Forms.Label()
        Me.AcProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SetLowLabel = New System.Windows.Forms.Label()
        Me.SetHighLabel = New System.Windows.Forms.Label()
        Me.LowTempTextBox = New System.Windows.Forms.TextBox()
        Me.HighTempTextBox = New System.Windows.Forms.TextBox()
        Me.LowTempUpButton = New System.Windows.Forms.Button()
        Me.LowTempDownButton = New System.Windows.Forms.Button()
        Me.HighTempDownButton = New System.Windows.Forms.Button()
        Me.HighTempUpButton = New System.Windows.Forms.Button()
        Me.FanShutDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TempCheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FanProgressBar = New System.Windows.Forms.ProgressBar()
        Me.PowerUpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InterlockLabel = New System.Windows.Forms.Label()
        Me.SafetyInterlockButton = New System.Windows.Forms.Button()
        Me.HeaterOverrideButton = New System.Windows.Forms.Button()
        Me.HeaterOverrideLabel = New System.Windows.Forms.Label()
        Me.FanOverrideButton = New System.Windows.Forms.Button()
        Me.FanOverrideLabel = New System.Windows.Forms.Label()
        Me.DifferentialButton = New System.Windows.Forms.Button()
        Me.DifferentialLabel = New System.Windows.Forms.Label()
        Me.AcOverrideButton = New System.Windows.Forms.Button()
        Me.AcOverideLabel = New System.Windows.Forms.Label()
        Me.ErrorLogDelayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TimeStatusStripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BlankStatusStripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.COMStatusStripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ControlDropdownMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetHighTemperatureMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighTempUpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighTempDownMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetLowTemperatureMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LowTempUpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LowTempDownMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverridesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleSafetyInterlockMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleHeaterOverrideMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleFanOverrideMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleACOverrideMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsToolStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlsToolStrip
        '
        Me.ControlsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMSelectToolStripComboBox, Me.ConnectCOMToolStripButton, Me.ToolStripSeparator1, Me.DisconnetToolStripButton, Me.ToolStripSeparator6, Me.RefreshCOMToolStripButton, Me.ToolStripSeparator7, Me.BlankToolStripLabel1, Me.ToolStripSeparator2, Me.SaveSettingsToolStripButton, Me.ToolStripSeparator3, Me.BlankToolStripLabel2, Me.ToolStripSeparator4, Me.QuitProgramToolStripButton, Me.ToolStripSeparator5})
        Me.ControlsToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ControlsToolStrip.Name = "ControlsToolStrip"
        Me.ControlsToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.ControlsToolStrip.TabIndex = 0
        Me.ControlsToolStrip.Text = "ToolStrip1"
        '
        'COMSelectToolStripComboBox
        '
        Me.COMSelectToolStripComboBox.Name = "COMSelectToolStripComboBox"
        Me.COMSelectToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'ConnectCOMToolStripButton
        '
        Me.ConnectCOMToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConnectCOMToolStripButton.Image = Global.HVAC_Control.My.Resources.Resources.icons8_usb_connector_30
        Me.ConnectCOMToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConnectCOMToolStripButton.Name = "ConnectCOMToolStripButton"
        Me.ConnectCOMToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ConnectCOMToolStripButton.Text = "ToolStripButton1"
        Me.ConnectCOMToolStripButton.ToolTipText = "Attempt Connection to Device"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'DisconnetToolStripButton
        '
        Me.DisconnetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DisconnetToolStripButton.Enabled = False
        Me.DisconnetToolStripButton.Image = Global.HVAC_Control.My.Resources.Resources.icons8_disconnect_30
        Me.DisconnetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DisconnetToolStripButton.Name = "DisconnetToolStripButton"
        Me.DisconnetToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DisconnetToolStripButton.Text = "Disconnect"
        Me.DisconnetToolStripButton.ToolTipText = "Disconnect Current Connection"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'RefreshCOMToolStripButton
        '
        Me.RefreshCOMToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshCOMToolStripButton.Image = Global.HVAC_Control.My.Resources.Resources.icons8_refresh_24
        Me.RefreshCOMToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshCOMToolStripButton.Name = "RefreshCOMToolStripButton"
        Me.RefreshCOMToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.RefreshCOMToolStripButton.Text = "ToolStripButton1"
        Me.RefreshCOMToolStripButton.ToolTipText = "Refresh Connection List"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BlankToolStripLabel1
        '
        Me.BlankToolStripLabel1.Name = "BlankToolStripLabel1"
        Me.BlankToolStripLabel1.Size = New System.Drawing.Size(112, 22)
        Me.BlankToolStripLabel1.Text = "                                   "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SaveSettingsToolStripButton
        '
        Me.SaveSettingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveSettingsToolStripButton.Image = Global.HVAC_Control.My.Resources.Resources.icons8_save_30
        Me.SaveSettingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveSettingsToolStripButton.Name = "SaveSettingsToolStripButton"
        Me.SaveSettingsToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveSettingsToolStripButton.Text = "ToolStripButton1"
        Me.SaveSettingsToolStripButton.ToolTipText = "Save Current Temp Settings"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BlankToolStripLabel2
        '
        Me.BlankToolStripLabel2.Name = "BlankToolStripLabel2"
        Me.BlankToolStripLabel2.Size = New System.Drawing.Size(289, 22)
        Me.BlankToolStripLabel2.Text = "                                                                                 " &
    "             "
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'QuitProgramToolStripButton
        '
        Me.QuitProgramToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QuitProgramToolStripButton.Image = Global.HVAC_Control.My.Resources.Resources.icons8_quit_50
        Me.QuitProgramToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.QuitProgramToolStripButton.Name = "QuitProgramToolStripButton"
        Me.QuitProgramToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.QuitProgramToolStripButton.Text = "ToolStripButton1"
        Me.QuitProgramToolStripButton.ToolTipText = "Quit the Program"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'COMSerialPort
        '
        Me.COMSerialPort.ReadTimeout = 250
        Me.COMSerialPort.WriteTimeout = 250
        '
        'COMTimer
        '
        Me.COMTimer.Interval = 500
        '
        'AnalogInput1TestLabel
        '
        Me.AnalogInput1TestLabel.AutoSize = True
        Me.AnalogInput1TestLabel.Location = New System.Drawing.Point(102, 143)
        Me.AnalogInput1TestLabel.Name = "AnalogInput1TestLabel"
        Me.AnalogInput1TestLabel.Size = New System.Drawing.Size(39, 13)
        Me.AnalogInput1TestLabel.TabIndex = 1
        Me.AnalogInput1TestLabel.Text = "Label1"
        '
        'AnalogInput2TestLabel
        '
        Me.AnalogInput2TestLabel.AutoSize = True
        Me.AnalogInput2TestLabel.Location = New System.Drawing.Point(252, 143)
        Me.AnalogInput2TestLabel.Name = "AnalogInput2TestLabel"
        Me.AnalogInput2TestLabel.Size = New System.Drawing.Size(39, 13)
        Me.AnalogInput2TestLabel.TabIndex = 2
        Me.AnalogInput2TestLabel.Text = "Label1"
        '
        'AmbientTempFLabel
        '
        Me.AmbientTempFLabel.AutoSize = True
        Me.AmbientTempFLabel.Location = New System.Drawing.Point(106, 172)
        Me.AmbientTempFLabel.Name = "AmbientTempFLabel"
        Me.AmbientTempFLabel.Size = New System.Drawing.Size(29, 13)
        Me.AmbientTempFLabel.TabIndex = 3
        Me.AmbientTempFLabel.Text = "0 ° F"
        '
        'AmbientTempCLabel
        '
        Me.AmbientTempCLabel.AutoSize = True
        Me.AmbientTempCLabel.Location = New System.Drawing.Point(106, 198)
        Me.AmbientTempCLabel.Name = "AmbientTempCLabel"
        Me.AmbientTempCLabel.Size = New System.Drawing.Size(30, 13)
        Me.AmbientTempCLabel.TabIndex = 4
        Me.AmbientTempCLabel.Text = "0 ° C"
        '
        'ControlSytemTempFLabel
        '
        Me.ControlSytemTempFLabel.AutoSize = True
        Me.ControlSytemTempFLabel.Location = New System.Drawing.Point(257, 172)
        Me.ControlSytemTempFLabel.Name = "ControlSytemTempFLabel"
        Me.ControlSytemTempFLabel.Size = New System.Drawing.Size(29, 13)
        Me.ControlSytemTempFLabel.TabIndex = 5
        Me.ControlSytemTempFLabel.Text = "0 ° F"
        '
        'ControlSystemTempCLabel
        '
        Me.ControlSystemTempCLabel.AutoSize = True
        Me.ControlSystemTempCLabel.Location = New System.Drawing.Point(256, 198)
        Me.ControlSystemTempCLabel.Name = "ControlSystemTempCLabel"
        Me.ControlSystemTempCLabel.Size = New System.Drawing.Size(30, 13)
        Me.ControlSystemTempCLabel.TabIndex = 6
        Me.ControlSystemTempCLabel.Text = "0 ° C"
        '
        'AmbientTempLabel
        '
        Me.AmbientTempLabel.AutoSize = True
        Me.AmbientTempLabel.Location = New System.Drawing.Point(80, 108)
        Me.AmbientTempLabel.Name = "AmbientTempLabel"
        Me.AmbientTempLabel.Size = New System.Drawing.Size(82, 26)
        Me.AmbientTempLabel.TabIndex = 7
        Me.AmbientTempLabel.Text = "Ambient Temp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Analog Input 1)"
        Me.AmbientTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ControlSystemTempLabel
        '
        Me.ControlSystemTempLabel.AutoSize = True
        Me.ControlSystemTempLabel.Location = New System.Drawing.Point(218, 108)
        Me.ControlSystemTempLabel.Name = "ControlSystemTempLabel"
        Me.ControlSystemTempLabel.Size = New System.Drawing.Size(107, 26)
        Me.ControlSystemTempLabel.TabIndex = 8
        Me.ControlSystemTempLabel.Text = "Control System Temp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Analog Input 2)"
        Me.ControlSystemTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OffRadioButton
        '
        Me.OffRadioButton.AutoSize = True
        Me.OffRadioButton.Checked = True
        Me.OffRadioButton.Location = New System.Drawing.Point(188, 267)
        Me.OffRadioButton.Name = "OffRadioButton"
        Me.OffRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.OffRadioButton.TabIndex = 9
        Me.OffRadioButton.TabStop = True
        Me.OffRadioButton.Text = "Off"
        Me.OffRadioButton.UseVisualStyleBackColor = True
        '
        'HeatRadioButton
        '
        Me.HeatRadioButton.AutoSize = True
        Me.HeatRadioButton.Location = New System.Drawing.Point(106, 267)
        Me.HeatRadioButton.Name = "HeatRadioButton"
        Me.HeatRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.HeatRadioButton.TabIndex = 10
        Me.HeatRadioButton.Text = "Heat"
        Me.HeatRadioButton.UseVisualStyleBackColor = True
        '
        'CoolRadioButton
        '
        Me.CoolRadioButton.AutoSize = True
        Me.CoolRadioButton.Location = New System.Drawing.Point(250, 267)
        Me.CoolRadioButton.Name = "CoolRadioButton"
        Me.CoolRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.CoolRadioButton.TabIndex = 11
        Me.CoolRadioButton.Text = "Cool"
        Me.CoolRadioButton.UseVisualStyleBackColor = True
        '
        'HeaterProgressBar
        '
        Me.HeaterProgressBar.Location = New System.Drawing.Point(467, 126)
        Me.HeaterProgressBar.Maximum = 1
        Me.HeaterProgressBar.Name = "HeaterProgressBar"
        Me.HeaterProgressBar.Size = New System.Drawing.Size(20, 14)
        Me.HeaterProgressBar.TabIndex = 12
        '
        'HeatOnLabel
        '
        Me.HeatOnLabel.AutoSize = True
        Me.HeatOnLabel.Location = New System.Drawing.Point(459, 95)
        Me.HeatOnLabel.Name = "HeatOnLabel"
        Me.HeatOnLabel.Size = New System.Drawing.Size(39, 26)
        Me.HeatOnLabel.TabIndex = 13
        Me.HeatOnLabel.Text = "Heater" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.HeatOnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FanOnLabel
        '
        Me.FanOnLabel.AutoSize = True
        Me.FanOnLabel.Location = New System.Drawing.Point(517, 95)
        Me.FanOnLabel.Name = "FanOnLabel"
        Me.FanOnLabel.Size = New System.Drawing.Size(37, 26)
        Me.FanOnLabel.TabIndex = 15
        Me.FanOnLabel.Text = "Fan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FanOnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AcOnLabel
        '
        Me.AcOnLabel.AutoSize = True
        Me.AcOnLabel.Location = New System.Drawing.Point(573, 95)
        Me.AcOnLabel.Name = "AcOnLabel"
        Me.AcOnLabel.Size = New System.Drawing.Size(37, 26)
        Me.AcOnLabel.TabIndex = 17
        Me.AcOnLabel.Text = "AC " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.AcOnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AcProgressBar
        '
        Me.AcProgressBar.Location = New System.Drawing.Point(581, 126)
        Me.AcProgressBar.Maximum = 1
        Me.AcProgressBar.Name = "AcProgressBar"
        Me.AcProgressBar.Size = New System.Drawing.Size(20, 14)
        Me.AcProgressBar.TabIndex = 16
        '
        'SetLowLabel
        '
        Me.SetLowLabel.AutoSize = True
        Me.SetLowLabel.Location = New System.Drawing.Point(411, 252)
        Me.SetLowLabel.Name = "SetLowLabel"
        Me.SetLowLabel.Size = New System.Drawing.Size(76, 13)
        Me.SetLowLabel.TabIndex = 18
        Me.SetLowLabel.Text = "Set Low Temp"
        '
        'SetHighLabel
        '
        Me.SetHighLabel.AutoSize = True
        Me.SetHighLabel.Location = New System.Drawing.Point(589, 252)
        Me.SetHighLabel.Name = "SetHighLabel"
        Me.SetHighLabel.Size = New System.Drawing.Size(78, 13)
        Me.SetHighLabel.TabIndex = 19
        Me.SetHighLabel.Text = "Set High Temp"
        '
        'LowTempTextBox
        '
        Me.LowTempTextBox.Location = New System.Drawing.Point(403, 291)
        Me.LowTempTextBox.Name = "LowTempTextBox"
        Me.LowTempTextBox.Size = New System.Drawing.Size(84, 20)
        Me.LowTempTextBox.TabIndex = 20
        Me.LowTempTextBox.Text = "65"
        Me.LowTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HighTempTextBox
        '
        Me.HighTempTextBox.Location = New System.Drawing.Point(592, 291)
        Me.HighTempTextBox.Name = "HighTempTextBox"
        Me.HighTempTextBox.Size = New System.Drawing.Size(84, 20)
        Me.HighTempTextBox.TabIndex = 21
        Me.HighTempTextBox.Text = "70"
        Me.HighTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LowTempUpButton
        '
        Me.LowTempUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowTempUpButton.Location = New System.Drawing.Point(493, 267)
        Me.LowTempUpButton.Name = "LowTempUpButton"
        Me.LowTempUpButton.Size = New System.Drawing.Size(14, 33)
        Me.LowTempUpButton.TabIndex = 22
        Me.LowTempUpButton.Text = "↑"
        Me.LowTempUpButton.UseVisualStyleBackColor = True
        '
        'LowTempDownButton
        '
        Me.LowTempDownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowTempDownButton.Location = New System.Drawing.Point(493, 306)
        Me.LowTempDownButton.Name = "LowTempDownButton"
        Me.LowTempDownButton.Size = New System.Drawing.Size(14, 33)
        Me.LowTempDownButton.TabIndex = 23
        Me.LowTempDownButton.Text = "↓"
        Me.LowTempDownButton.UseVisualStyleBackColor = True
        '
        'HighTempDownButton
        '
        Me.HighTempDownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighTempDownButton.Location = New System.Drawing.Point(682, 306)
        Me.HighTempDownButton.Name = "HighTempDownButton"
        Me.HighTempDownButton.Size = New System.Drawing.Size(14, 33)
        Me.HighTempDownButton.TabIndex = 25
        Me.HighTempDownButton.Text = "↓"
        Me.HighTempDownButton.UseVisualStyleBackColor = True
        '
        'HighTempUpButton
        '
        Me.HighTempUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighTempUpButton.Location = New System.Drawing.Point(682, 267)
        Me.HighTempUpButton.Name = "HighTempUpButton"
        Me.HighTempUpButton.Size = New System.Drawing.Size(14, 33)
        Me.HighTempUpButton.TabIndex = 24
        Me.HighTempUpButton.Text = "↑"
        Me.HighTempUpButton.UseVisualStyleBackColor = True
        '
        'FanShutDownTimer
        '
        Me.FanShutDownTimer.Interval = 5000
        '
        'TempCheckTimer
        '
        Me.TempCheckTimer.Interval = 10000
        '
        'FanProgressBar
        '
        Me.FanProgressBar.Location = New System.Drawing.Point(524, 126)
        Me.FanProgressBar.Maximum = 1
        Me.FanProgressBar.Name = "FanProgressBar"
        Me.FanProgressBar.Size = New System.Drawing.Size(20, 14)
        Me.FanProgressBar.TabIndex = 26
        '
        'PowerUpTimer
        '
        Me.PowerUpTimer.Interval = 5000
        '
        'InterlockLabel
        '
        Me.InterlockLabel.AutoSize = True
        Me.InterlockLabel.Location = New System.Drawing.Point(26, 365)
        Me.InterlockLabel.Name = "InterlockLabel"
        Me.InterlockLabel.Size = New System.Drawing.Size(48, 26)
        Me.InterlockLabel.TabIndex = 28
        Me.InterlockLabel.Text = "Safety" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interlock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.InterlockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SafetyInterlockButton
        '
        Me.SafetyInterlockButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.SafetyInterlockButton.Location = New System.Drawing.Point(39, 394)
        Me.SafetyInterlockButton.Name = "SafetyInterlockButton"
        Me.SafetyInterlockButton.Size = New System.Drawing.Size(20, 20)
        Me.SafetyInterlockButton.TabIndex = 29
        Me.SafetyInterlockButton.UseVisualStyleBackColor = False
        '
        'HeaterOverrideButton
        '
        Me.HeaterOverrideButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.HeaterOverrideButton.Location = New System.Drawing.Point(93, 394)
        Me.HeaterOverrideButton.Name = "HeaterOverrideButton"
        Me.HeaterOverrideButton.Size = New System.Drawing.Size(20, 20)
        Me.HeaterOverrideButton.TabIndex = 31
        Me.HeaterOverrideButton.UseVisualStyleBackColor = False
        '
        'HeaterOverrideLabel
        '
        Me.HeaterOverrideLabel.AutoSize = True
        Me.HeaterOverrideLabel.Location = New System.Drawing.Point(80, 365)
        Me.HeaterOverrideLabel.Name = "HeaterOverrideLabel"
        Me.HeaterOverrideLabel.Size = New System.Drawing.Size(47, 26)
        Me.HeaterOverrideLabel.TabIndex = 30
        Me.HeaterOverrideLabel.Text = "Heater" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Override" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.HeaterOverrideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FanOverrideButton
        '
        Me.FanOverrideButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.FanOverrideButton.Location = New System.Drawing.Point(146, 394)
        Me.FanOverrideButton.Name = "FanOverrideButton"
        Me.FanOverrideButton.Size = New System.Drawing.Size(20, 20)
        Me.FanOverrideButton.TabIndex = 33
        Me.FanOverrideButton.UseVisualStyleBackColor = False
        '
        'FanOverrideLabel
        '
        Me.FanOverrideLabel.AutoSize = True
        Me.FanOverrideLabel.Location = New System.Drawing.Point(133, 365)
        Me.FanOverrideLabel.Name = "FanOverrideLabel"
        Me.FanOverrideLabel.Size = New System.Drawing.Size(47, 26)
        Me.FanOverrideLabel.TabIndex = 32
        Me.FanOverrideLabel.Text = "Fan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Override" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FanOverrideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DifferentialButton
        '
        Me.DifferentialButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.DifferentialButton.Location = New System.Drawing.Point(266, 394)
        Me.DifferentialButton.Name = "DifferentialButton"
        Me.DifferentialButton.Size = New System.Drawing.Size(20, 20)
        Me.DifferentialButton.TabIndex = 35
        Me.DifferentialButton.UseVisualStyleBackColor = False
        '
        'DifferentialLabel
        '
        Me.DifferentialLabel.AutoSize = True
        Me.DifferentialLabel.Location = New System.Drawing.Point(244, 365)
        Me.DifferentialLabel.Name = "DifferentialLabel"
        Me.DifferentialLabel.Size = New System.Drawing.Size(73, 26)
        Me.DifferentialLabel.TabIndex = 34
        Me.DifferentialLabel.Text = "Differential" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pressure Error" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.DifferentialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AcOverrideButton
        '
        Me.AcOverrideButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.AcOverrideButton.Location = New System.Drawing.Point(198, 394)
        Me.AcOverrideButton.Name = "AcOverrideButton"
        Me.AcOverrideButton.Size = New System.Drawing.Size(20, 20)
        Me.AcOverrideButton.TabIndex = 37
        Me.AcOverrideButton.UseVisualStyleBackColor = False
        '
        'AcOverideLabel
        '
        Me.AcOverideLabel.AutoSize = True
        Me.AcOverideLabel.Location = New System.Drawing.Point(186, 365)
        Me.AcOverideLabel.Name = "AcOverideLabel"
        Me.AcOverideLabel.Size = New System.Drawing.Size(47, 26)
        Me.AcOverideLabel.TabIndex = 36
        Me.AcOverideLabel.Text = "AC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Override" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.AcOverideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorLogDelayTimer
        '
        Me.ErrorLogDelayTimer.Interval = 5000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeStatusStripLabel, Me.BlankStatusStripLabel, Me.COMStatusStripLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 38
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TimeStatusStripLabel
        '
        Me.TimeStatusStripLabel.Name = "TimeStatusStripLabel"
        Me.TimeStatusStripLabel.Size = New System.Drawing.Size(60, 17)
        Me.TimeStatusStripLabel.Text = "Date Time"
        '
        'BlankStatusStripLabel
        '
        Me.BlankStatusStripLabel.Name = "BlankStatusStripLabel"
        Me.BlankStatusStripLabel.Size = New System.Drawing.Size(166, 17)
        Me.BlankStatusStripLabel.Text = "                                                     "
        '
        'COMStatusStripLabel
        '
        Me.COMStatusStripLabel.Name = "COMStatusStripLabel"
        Me.COMStatusStripLabel.Size = New System.Drawing.Size(91, 17)
        Me.COMStatusStripLabel.Text = "Not Connected "
        '
        'ClockTimer
        '
        Me.ClockTimer.Enabled = True
        Me.ClockTimer.Interval = 1000
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDropdownMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip.TabIndex = 39
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ControlDropdownMenuItem
        '
        Me.ControlDropdownMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetHighTemperatureMenuItem, Me.SetLowTemperatureMenuItem, Me.OverridesMenuItem})
        Me.ControlDropdownMenuItem.Name = "ControlDropdownMenuItem"
        Me.ControlDropdownMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ControlDropdownMenuItem.Text = "Control"
        '
        'SetHighTemperatureMenuItem
        '
        Me.SetHighTemperatureMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HighTempUpMenuItem, Me.HighTempDownMenuItem})
        Me.SetHighTemperatureMenuItem.Name = "SetHighTemperatureMenuItem"
        Me.SetHighTemperatureMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SetHighTemperatureMenuItem.Text = "Set High Temperature"
        '
        'HighTempUpMenuItem
        '
        Me.HighTempUpMenuItem.Name = "HighTempUpMenuItem"
        Me.HighTempUpMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HighTempUpMenuItem.Text = "High Temp Up"
        '
        'HighTempDownMenuItem
        '
        Me.HighTempDownMenuItem.Name = "HighTempDownMenuItem"
        Me.HighTempDownMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HighTempDownMenuItem.Text = "High Temp Down"
        '
        'SetLowTemperatureMenuItem
        '
        Me.SetLowTemperatureMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LowTempUpMenuItem, Me.LowTempDownMenuItem})
        Me.SetLowTemperatureMenuItem.Name = "SetLowTemperatureMenuItem"
        Me.SetLowTemperatureMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SetLowTemperatureMenuItem.Text = "Set Low Temperature"
        '
        'LowTempUpMenuItem
        '
        Me.LowTempUpMenuItem.Name = "LowTempUpMenuItem"
        Me.LowTempUpMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LowTempUpMenuItem.Text = "Low Temp Up"
        '
        'LowTempDownMenuItem
        '
        Me.LowTempDownMenuItem.Name = "LowTempDownMenuItem"
        Me.LowTempDownMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LowTempDownMenuItem.Text = "Low Temp Down"
        '
        'OverridesMenuItem
        '
        Me.OverridesMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToggleSafetyInterlockMenuItem, Me.ToggleHeaterOverrideMenuItem, Me.ToggleFanOverrideMenuItem, Me.ToggleACOverrideMenuItem})
        Me.OverridesMenuItem.Name = "OverridesMenuItem"
        Me.OverridesMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.OverridesMenuItem.Text = "Overrides"
        '
        'ToggleSafetyInterlockMenuItem
        '
        Me.ToggleSafetyInterlockMenuItem.Name = "ToggleSafetyInterlockMenuItem"
        Me.ToggleSafetyInterlockMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ToggleSafetyInterlockMenuItem.Text = "Toggle Safety Interlock"
        '
        'ToggleHeaterOverrideMenuItem
        '
        Me.ToggleHeaterOverrideMenuItem.Name = "ToggleHeaterOverrideMenuItem"
        Me.ToggleHeaterOverrideMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ToggleHeaterOverrideMenuItem.Text = "Toggle Heater Override"
        '
        'ToggleFanOverrideMenuItem
        '
        Me.ToggleFanOverrideMenuItem.Name = "ToggleFanOverrideMenuItem"
        Me.ToggleFanOverrideMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ToggleFanOverrideMenuItem.Text = "Toggle Fan Override"
        '
        'ToggleACOverrideMenuItem
        '
        Me.ToggleACOverrideMenuItem.Name = "ToggleACOverrideMenuItem"
        Me.ToggleACOverrideMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ToggleACOverrideMenuItem.Text = "Toggle AC Override"
        '
        'HvacControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.AcOverrideButton)
        Me.Controls.Add(Me.AcOverideLabel)
        Me.Controls.Add(Me.DifferentialButton)
        Me.Controls.Add(Me.DifferentialLabel)
        Me.Controls.Add(Me.FanOverrideButton)
        Me.Controls.Add(Me.FanOverrideLabel)
        Me.Controls.Add(Me.HeaterOverrideButton)
        Me.Controls.Add(Me.HeaterOverrideLabel)
        Me.Controls.Add(Me.SafetyInterlockButton)
        Me.Controls.Add(Me.InterlockLabel)
        Me.Controls.Add(Me.FanProgressBar)
        Me.Controls.Add(Me.HighTempDownButton)
        Me.Controls.Add(Me.HighTempUpButton)
        Me.Controls.Add(Me.LowTempDownButton)
        Me.Controls.Add(Me.LowTempUpButton)
        Me.Controls.Add(Me.HighTempTextBox)
        Me.Controls.Add(Me.LowTempTextBox)
        Me.Controls.Add(Me.SetHighLabel)
        Me.Controls.Add(Me.SetLowLabel)
        Me.Controls.Add(Me.AcOnLabel)
        Me.Controls.Add(Me.AcProgressBar)
        Me.Controls.Add(Me.FanOnLabel)
        Me.Controls.Add(Me.HeatOnLabel)
        Me.Controls.Add(Me.HeaterProgressBar)
        Me.Controls.Add(Me.CoolRadioButton)
        Me.Controls.Add(Me.HeatRadioButton)
        Me.Controls.Add(Me.OffRadioButton)
        Me.Controls.Add(Me.ControlSystemTempLabel)
        Me.Controls.Add(Me.AmbientTempLabel)
        Me.Controls.Add(Me.ControlSystemTempCLabel)
        Me.Controls.Add(Me.ControlSytemTempFLabel)
        Me.Controls.Add(Me.AmbientTempCLabel)
        Me.Controls.Add(Me.AmbientTempFLabel)
        Me.Controls.Add(Me.AnalogInput2TestLabel)
        Me.Controls.Add(Me.AnalogInput1TestLabel)
        Me.Controls.Add(Me.ControlsToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "HvacControlForm"
        Me.Text = "HVAC Control"
        Me.ControlsToolStrip.ResumeLayout(False)
        Me.ControlsToolStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ControlsToolStrip As ToolStrip
    Friend WithEvents COMSelectToolStripComboBox As ToolStripComboBox
    Friend WithEvents ConnectCOMToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BlankToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SaveSettingsToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BlankToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents QuitProgramToolStripButton As ToolStripButton
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents COMSerialPort As IO.Ports.SerialPort
    Friend WithEvents COMTimer As Timer
    Friend WithEvents AnalogInput1TestLabel As Label
    Friend WithEvents AnalogInput2TestLabel As Label
    Friend WithEvents DisconnetToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents AmbientTempFLabel As Label
    Friend WithEvents AmbientTempCLabel As Label
    Friend WithEvents ControlSytemTempFLabel As Label
    Friend WithEvents ControlSystemTempCLabel As Label
    Friend WithEvents AmbientTempLabel As Label
    Friend WithEvents ControlSystemTempLabel As Label
    Friend WithEvents OffRadioButton As RadioButton
    Friend WithEvents HeatRadioButton As RadioButton
    Friend WithEvents CoolRadioButton As RadioButton
    Friend WithEvents HeaterProgressBar As ProgressBar
    Friend WithEvents HeatOnLabel As Label
    Friend WithEvents FanOnLabel As Label
    Friend WithEvents AcOnLabel As Label
    Friend WithEvents AcProgressBar As ProgressBar
    Friend WithEvents SetLowLabel As Label
    Friend WithEvents SetHighLabel As Label
    Friend WithEvents LowTempTextBox As TextBox
    Friend WithEvents HighTempTextBox As TextBox
    Friend WithEvents LowTempUpButton As Button
    Friend WithEvents LowTempDownButton As Button
    Friend WithEvents HighTempDownButton As Button
    Friend WithEvents HighTempUpButton As Button
    Friend WithEvents FanShutDownTimer As Timer
    Friend WithEvents FanProgressBar As ProgressBar
    Friend WithEvents PowerUpTimer As Timer
    Friend WithEvents InterlockLabel As Label
    Friend WithEvents SafetyInterlockButton As Button
    Friend WithEvents HeaterOverrideButton As Button
    Friend WithEvents HeaterOverrideLabel As Label
    Friend WithEvents FanOverrideButton As Button
    Friend WithEvents FanOverrideLabel As Label
    Friend WithEvents DifferentialButton As Button
    Friend WithEvents DifferentialLabel As Label
    Friend WithEvents RefreshCOMToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents AcOverrideButton As Button
    Friend WithEvents AcOverideLabel As Label
    Friend WithEvents TempCheckTimer As Timer
    Friend WithEvents ErrorLogDelayTimer As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TimeStatusStripLabel As ToolStripStatusLabel
    Friend WithEvents BlankStatusStripLabel As ToolStripStatusLabel
    Friend WithEvents COMStatusStripLabel As ToolStripStatusLabel
    Friend WithEvents ClockTimer As Timer
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ControlDropdownMenuItem As ToolStripMenuItem
    Friend WithEvents SetHighTemperatureMenuItem As ToolStripMenuItem
    Friend WithEvents HighTempUpMenuItem As ToolStripMenuItem
    Friend WithEvents HighTempDownMenuItem As ToolStripMenuItem
    Friend WithEvents SetLowTemperatureMenuItem As ToolStripMenuItem
    Friend WithEvents LowTempUpMenuItem As ToolStripMenuItem
    Friend WithEvents LowTempDownMenuItem As ToolStripMenuItem
    Friend WithEvents OverridesMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleSafetyInterlockMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleHeaterOverrideMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleFanOverrideMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleACOverrideMenuItem As ToolStripMenuItem
End Class
