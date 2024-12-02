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
        Me.ControlsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlsToolStrip
        '
        Me.ControlsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMSelectToolStripComboBox, Me.ConnectCOMToolStripButton, Me.ToolStripSeparator1, Me.DisconnetToolStripButton, Me.ToolStripSeparator6, Me.BlankToolStripLabel1, Me.ToolStripSeparator2, Me.SaveSettingsToolStripButton, Me.ToolStripSeparator3, Me.BlankToolStripLabel2, Me.ToolStripSeparator4, Me.QuitProgramToolStripButton, Me.ToolStripSeparator5})
        Me.ControlsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ControlsToolStrip.Name = "ControlsToolStrip"
        Me.ControlsToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.ControlsToolStrip.TabIndex = 0
        Me.ControlsToolStrip.Text = "ToolStrip1"
        '
        'COMSelectToolStripComboBox
        '
        Me.COMSelectToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.TempCheckTimer.Interval = 500
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
        'HvacControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Name = "HvacControlForm"
        Me.Text = "HVAC Control"
        Me.ControlsToolStrip.ResumeLayout(False)
        Me.ControlsToolStrip.PerformLayout()
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
    Friend WithEvents TempCheckTimer As Timer
    Friend WithEvents FanProgressBar As ProgressBar
    Friend WithEvents PowerUpTimer As Timer
End Class
