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
        Me.HeatOnLabel = New System.Windows.Forms.Label()
        Me.FanOnLabel = New System.Windows.Forms.Label()
        Me.AcOnLabel = New System.Windows.Forms.Label()
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
        Me.ChangeModeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeatMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoolMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectCOMMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTempSettingsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitProgramMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeaterStatusButton = New System.Windows.Forms.Button()
        Me.FanStatusButton = New System.Windows.Forms.Button()
        Me.AcStatusButton = New System.Windows.Forms.Button()
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
        Me.COMSelectToolStripComboBox.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DisconnetToolStripButton.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.RefreshCOMToolStripButton.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.SaveSettingsToolStripButton.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.QuitProgramToolStripButton.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.AnalogInput1TestLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogInput1TestLabel.Location = New System.Drawing.Point(135, 106)
        Me.AnalogInput1TestLabel.Name = "AnalogInput1TestLabel"
        Me.AnalogInput1TestLabel.Size = New System.Drawing.Size(33, 15)
        Me.AnalogInput1TestLabel.TabIndex = 1
        Me.AnalogInput1TestLabel.Text = "AN1"
        Me.AnalogInput1TestLabel.Visible = False
        '
        'AnalogInput2TestLabel
        '
        Me.AnalogInput2TestLabel.AutoSize = True
        Me.AnalogInput2TestLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogInput2TestLabel.Location = New System.Drawing.Point(292, 106)
        Me.AnalogInput2TestLabel.Name = "AnalogInput2TestLabel"
        Me.AnalogInput2TestLabel.Size = New System.Drawing.Size(35, 15)
        Me.AnalogInput2TestLabel.TabIndex = 2
        Me.AnalogInput2TestLabel.Text = "AN2"
        Me.AnalogInput2TestLabel.Visible = False
        '
        'AmbientTempFLabel
        '
        Me.AmbientTempFLabel.AutoSize = True
        Me.AmbientTempFLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbientTempFLabel.Location = New System.Drawing.Point(103, 138)
        Me.AmbientTempFLabel.Name = "AmbientTempFLabel"
        Me.AmbientTempFLabel.Size = New System.Drawing.Size(34, 15)
        Me.AmbientTempFLabel.TabIndex = 3
        Me.AmbientTempFLabel.Text = "0 ° F"
        '
        'AmbientTempCLabel
        '
        Me.AmbientTempCLabel.AutoSize = True
        Me.AmbientTempCLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbientTempCLabel.Location = New System.Drawing.Point(103, 164)
        Me.AmbientTempCLabel.Name = "AmbientTempCLabel"
        Me.AmbientTempCLabel.Size = New System.Drawing.Size(36, 15)
        Me.AmbientTempCLabel.TabIndex = 4
        Me.AmbientTempCLabel.Text = "0 ° C"
        '
        'ControlSytemTempFLabel
        '
        Me.ControlSytemTempFLabel.AutoSize = True
        Me.ControlSytemTempFLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlSytemTempFLabel.Location = New System.Drawing.Point(257, 138)
        Me.ControlSytemTempFLabel.Name = "ControlSytemTempFLabel"
        Me.ControlSytemTempFLabel.Size = New System.Drawing.Size(34, 15)
        Me.ControlSytemTempFLabel.TabIndex = 5
        Me.ControlSytemTempFLabel.Text = "0 ° F"
        '
        'ControlSystemTempCLabel
        '
        Me.ControlSystemTempCLabel.AutoSize = True
        Me.ControlSystemTempCLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlSystemTempCLabel.Location = New System.Drawing.Point(256, 164)
        Me.ControlSystemTempCLabel.Name = "ControlSystemTempCLabel"
        Me.ControlSystemTempCLabel.Size = New System.Drawing.Size(36, 15)
        Me.ControlSystemTempCLabel.TabIndex = 6
        Me.ControlSystemTempCLabel.Text = "0 ° C"
        '
        'AmbientTempLabel
        '
        Me.AmbientTempLabel.AutoSize = True
        Me.AmbientTempLabel.Font = New System.Drawing.Font("Museo Slab 500", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbientTempLabel.Location = New System.Drawing.Point(69, 119)
        Me.AmbientTempLabel.Name = "AmbientTempLabel"
        Me.AmbientTempLabel.Size = New System.Drawing.Size(105, 19)
        Me.AmbientTempLabel.TabIndex = 7
        Me.AmbientTempLabel.Text = "Room Temp"
        Me.AmbientTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ControlSystemTempLabel
        '
        Me.ControlSystemTempLabel.AutoSize = True
        Me.ControlSystemTempLabel.Font = New System.Drawing.Font("Museo Slab 500", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlSystemTempLabel.Location = New System.Drawing.Point(216, 119)
        Me.ControlSystemTempLabel.Name = "ControlSystemTempLabel"
        Me.ControlSystemTempLabel.Size = New System.Drawing.Size(115, 19)
        Me.ControlSystemTempLabel.TabIndex = 8
        Me.ControlSystemTempLabel.Text = "System Temp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ControlSystemTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OffRadioButton
        '
        Me.OffRadioButton.AutoSize = True
        Me.OffRadioButton.Checked = True
        Me.OffRadioButton.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OffRadioButton.Location = New System.Drawing.Point(178, 207)
        Me.OffRadioButton.Name = "OffRadioButton"
        Me.OffRadioButton.Size = New System.Drawing.Size(45, 19)
        Me.OffRadioButton.TabIndex = 9
        Me.OffRadioButton.TabStop = True
        Me.OffRadioButton.Text = "Off"
        Me.ToolTip.SetToolTip(Me.OffRadioButton, "Turn the System Off")
        Me.OffRadioButton.UseVisualStyleBackColor = True
        '
        'HeatRadioButton
        '
        Me.HeatRadioButton.AutoSize = True
        Me.HeatRadioButton.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatRadioButton.Location = New System.Drawing.Point(96, 207)
        Me.HeatRadioButton.Name = "HeatRadioButton"
        Me.HeatRadioButton.Size = New System.Drawing.Size(55, 19)
        Me.HeatRadioButton.TabIndex = 10
        Me.HeatRadioButton.Text = "Heat"
        Me.ToolTip.SetToolTip(Me.HeatRadioButton, "Enable Heating Mode")
        Me.HeatRadioButton.UseVisualStyleBackColor = True
        '
        'CoolRadioButton
        '
        Me.CoolRadioButton.AutoSize = True
        Me.CoolRadioButton.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolRadioButton.Location = New System.Drawing.Point(240, 207)
        Me.CoolRadioButton.Name = "CoolRadioButton"
        Me.CoolRadioButton.Size = New System.Drawing.Size(55, 19)
        Me.CoolRadioButton.TabIndex = 11
        Me.CoolRadioButton.Text = "Cool"
        Me.ToolTip.SetToolTip(Me.CoolRadioButton, "Enable Ac ")
        Me.CoolRadioButton.UseVisualStyleBackColor = True
        '
        'HeatOnLabel
        '
        Me.HeatOnLabel.AutoSize = True
        Me.HeatOnLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatOnLabel.Location = New System.Drawing.Point(453, 91)
        Me.HeatOnLabel.Name = "HeatOnLabel"
        Me.HeatOnLabel.Size = New System.Drawing.Size(49, 30)
        Me.HeatOnLabel.TabIndex = 13
        Me.HeatOnLabel.Text = "Heater" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.HeatOnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FanOnLabel
        '
        Me.FanOnLabel.AutoSize = True
        Me.FanOnLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FanOnLabel.Location = New System.Drawing.Point(520, 91)
        Me.FanOnLabel.Name = "FanOnLabel"
        Me.FanOnLabel.Size = New System.Drawing.Size(47, 30)
        Me.FanOnLabel.TabIndex = 15
        Me.FanOnLabel.Text = "Fan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FanOnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AcOnLabel
        '
        Me.AcOnLabel.AutoSize = True
        Me.AcOnLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcOnLabel.Location = New System.Drawing.Point(573, 95)
        Me.AcOnLabel.Name = "AcOnLabel"
        Me.AcOnLabel.Size = New System.Drawing.Size(47, 30)
        Me.AcOnLabel.TabIndex = 17
        Me.AcOnLabel.Text = "AC " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.AcOnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SetLowLabel
        '
        Me.SetLowLabel.AutoSize = True
        Me.SetLowLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetLowLabel.Location = New System.Drawing.Point(370, 189)
        Me.SetLowLabel.Name = "SetLowLabel"
        Me.SetLowLabel.Size = New System.Drawing.Size(97, 15)
        Me.SetLowLabel.TabIndex = 18
        Me.SetLowLabel.Text = "Set Low Temp"
        '
        'SetHighLabel
        '
        Me.SetHighLabel.AutoSize = True
        Me.SetHighLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetHighLabel.Location = New System.Drawing.Point(555, 189)
        Me.SetHighLabel.Name = "SetHighLabel"
        Me.SetHighLabel.Size = New System.Drawing.Size(102, 15)
        Me.SetHighLabel.TabIndex = 19
        Me.SetHighLabel.Text = "Set High Temp"
        '
        'LowTempTextBox
        '
        Me.LowTempTextBox.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowTempTextBox.Location = New System.Drawing.Point(383, 207)
        Me.LowTempTextBox.Name = "LowTempTextBox"
        Me.LowTempTextBox.Size = New System.Drawing.Size(84, 23)
        Me.LowTempTextBox.TabIndex = 20
        Me.LowTempTextBox.Text = "65"
        Me.LowTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HighTempTextBox
        '
        Me.HighTempTextBox.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighTempTextBox.Location = New System.Drawing.Point(572, 207)
        Me.HighTempTextBox.Name = "HighTempTextBox"
        Me.HighTempTextBox.Size = New System.Drawing.Size(84, 23)
        Me.HighTempTextBox.TabIndex = 21
        Me.HighTempTextBox.Text = "70"
        Me.HighTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LowTempUpButton
        '
        Me.LowTempUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowTempUpButton.Location = New System.Drawing.Point(473, 183)
        Me.LowTempUpButton.Name = "LowTempUpButton"
        Me.LowTempUpButton.Size = New System.Drawing.Size(14, 33)
        Me.LowTempUpButton.TabIndex = 22
        Me.LowTempUpButton.Text = "↑"
        Me.ToolTip.SetToolTip(Me.LowTempUpButton, "Increment Low Set Temp by 0.5°")
        Me.LowTempUpButton.UseVisualStyleBackColor = True
        '
        'LowTempDownButton
        '
        Me.LowTempDownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowTempDownButton.Location = New System.Drawing.Point(473, 222)
        Me.LowTempDownButton.Name = "LowTempDownButton"
        Me.LowTempDownButton.Size = New System.Drawing.Size(14, 33)
        Me.LowTempDownButton.TabIndex = 23
        Me.LowTempDownButton.Text = "↓"
        Me.ToolTip.SetToolTip(Me.LowTempDownButton, "Decrement Low Set Temp by 0.5°")
        Me.LowTempDownButton.UseVisualStyleBackColor = True
        '
        'HighTempDownButton
        '
        Me.HighTempDownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighTempDownButton.Location = New System.Drawing.Point(662, 222)
        Me.HighTempDownButton.Name = "HighTempDownButton"
        Me.HighTempDownButton.Size = New System.Drawing.Size(14, 33)
        Me.HighTempDownButton.TabIndex = 25
        Me.HighTempDownButton.Text = "↓"
        Me.ToolTip.SetToolTip(Me.HighTempDownButton, "Decrement High Set Temp by 0.5°")
        Me.HighTempDownButton.UseVisualStyleBackColor = True
        '
        'HighTempUpButton
        '
        Me.HighTempUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighTempUpButton.Location = New System.Drawing.Point(662, 183)
        Me.HighTempUpButton.Name = "HighTempUpButton"
        Me.HighTempUpButton.Size = New System.Drawing.Size(14, 33)
        Me.HighTempUpButton.TabIndex = 24
        Me.HighTempUpButton.Text = "↑"
        Me.ToolTip.SetToolTip(Me.HighTempUpButton, "Increment High Set Temp by 0.5°")
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
        'PowerUpTimer
        '
        Me.PowerUpTimer.Interval = 5000
        '
        'InterlockLabel
        '
        Me.InterlockLabel.AutoSize = True
        Me.InterlockLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InterlockLabel.Location = New System.Drawing.Point(348, 335)
        Me.InterlockLabel.Name = "InterlockLabel"
        Me.InterlockLabel.Size = New System.Drawing.Size(65, 30)
        Me.InterlockLabel.TabIndex = 28
        Me.InterlockLabel.Text = "Safety" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interlock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.InterlockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SafetyInterlockButton
        '
        Me.SafetyInterlockButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.SafetyInterlockButton.Location = New System.Drawing.Point(375, 368)
        Me.SafetyInterlockButton.Name = "SafetyInterlockButton"
        Me.SafetyInterlockButton.Size = New System.Drawing.Size(20, 20)
        Me.SafetyInterlockButton.TabIndex = 29
        Me.SafetyInterlockButton.UseVisualStyleBackColor = False
        '
        'HeaterOverrideButton
        '
        Me.HeaterOverrideButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.HeaterOverrideButton.Location = New System.Drawing.Point(438, 368)
        Me.HeaterOverrideButton.Name = "HeaterOverrideButton"
        Me.HeaterOverrideButton.Size = New System.Drawing.Size(20, 20)
        Me.HeaterOverrideButton.TabIndex = 31
        Me.HeaterOverrideButton.UseVisualStyleBackColor = False
        '
        'HeaterOverrideLabel
        '
        Me.HeaterOverrideLabel.AutoSize = True
        Me.HeaterOverrideLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaterOverrideLabel.Location = New System.Drawing.Point(419, 335)
        Me.HeaterOverrideLabel.Name = "HeaterOverrideLabel"
        Me.HeaterOverrideLabel.Size = New System.Drawing.Size(62, 30)
        Me.HeaterOverrideLabel.TabIndex = 30
        Me.HeaterOverrideLabel.Text = "Heater" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Override" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.HeaterOverrideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FanOverrideButton
        '
        Me.FanOverrideButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.FanOverrideButton.Location = New System.Drawing.Point(506, 367)
        Me.FanOverrideButton.Name = "FanOverrideButton"
        Me.FanOverrideButton.Size = New System.Drawing.Size(20, 20)
        Me.FanOverrideButton.TabIndex = 33
        Me.FanOverrideButton.UseVisualStyleBackColor = False
        '
        'FanOverrideLabel
        '
        Me.FanOverrideLabel.AutoSize = True
        Me.FanOverrideLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FanOverrideLabel.Location = New System.Drawing.Point(487, 335)
        Me.FanOverrideLabel.Name = "FanOverrideLabel"
        Me.FanOverrideLabel.Size = New System.Drawing.Size(62, 30)
        Me.FanOverrideLabel.TabIndex = 32
        Me.FanOverrideLabel.Text = "Fan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Override" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FanOverrideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DifferentialButton
        '
        Me.DifferentialButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.DifferentialButton.Location = New System.Drawing.Point(664, 368)
        Me.DifferentialButton.Name = "DifferentialButton"
        Me.DifferentialButton.Size = New System.Drawing.Size(20, 20)
        Me.DifferentialButton.TabIndex = 35
        Me.DifferentialButton.UseVisualStyleBackColor = False
        '
        'DifferentialLabel
        '
        Me.DifferentialLabel.AutoSize = True
        Me.DifferentialLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DifferentialLabel.Location = New System.Drawing.Point(629, 335)
        Me.DifferentialLabel.Name = "DifferentialLabel"
        Me.DifferentialLabel.Size = New System.Drawing.Size(94, 30)
        Me.DifferentialLabel.TabIndex = 34
        Me.DifferentialLabel.Text = "Differential" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pressure Error" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.DifferentialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AcOverrideButton
        '
        Me.AcOverrideButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.AcOverrideButton.Location = New System.Drawing.Point(577, 368)
        Me.AcOverrideButton.Name = "AcOverrideButton"
        Me.AcOverrideButton.Size = New System.Drawing.Size(20, 20)
        Me.AcOverrideButton.TabIndex = 37
        Me.AcOverrideButton.UseVisualStyleBackColor = False
        '
        'AcOverideLabel
        '
        Me.AcOverideLabel.AutoSize = True
        Me.AcOverideLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcOverideLabel.Location = New System.Drawing.Point(555, 335)
        Me.AcOverideLabel.Name = "AcOverideLabel"
        Me.AcOverideLabel.Size = New System.Drawing.Size(62, 30)
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 24)
        Me.StatusStrip1.TabIndex = 38
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TimeStatusStripLabel
        '
        Me.TimeStatusStripLabel.Font = New System.Drawing.Font("Museo Slab 500", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeStatusStripLabel.Name = "TimeStatusStripLabel"
        Me.TimeStatusStripLabel.Size = New System.Drawing.Size(90, 19)
        Me.TimeStatusStripLabel.Text = "Date Time"
        '
        'BlankStatusStripLabel
        '
        Me.BlankStatusStripLabel.Name = "BlankStatusStripLabel"
        Me.BlankStatusStripLabel.Size = New System.Drawing.Size(166, 19)
        Me.BlankStatusStripLabel.Text = "                                                     "
        '
        'COMStatusStripLabel
        '
        Me.COMStatusStripLabel.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMStatusStripLabel.Name = "COMStatusStripLabel"
        Me.COMStatusStripLabel.Size = New System.Drawing.Size(107, 19)
        Me.COMStatusStripLabel.Text = "Not Connected "
        '
        'ClockTimer
        '
        Me.ClockTimer.Enabled = True
        Me.ClockTimer.Interval = 1000
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDropdownMenuItem, Me.ConnectionMenuItem, Me.ProgramMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip.TabIndex = 39
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ControlDropdownMenuItem
        '
        Me.ControlDropdownMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetHighTemperatureMenuItem, Me.SetLowTemperatureMenuItem, Me.ChangeModeMenuItem})
        Me.ControlDropdownMenuItem.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlDropdownMenuItem.Name = "ControlDropdownMenuItem"
        Me.ControlDropdownMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ControlDropdownMenuItem.Text = "Control"
        Me.ControlDropdownMenuItem.ToolTipText = "Control System Temperature"
        '
        'SetHighTemperatureMenuItem
        '
        Me.SetHighTemperatureMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HighTempUpMenuItem, Me.HighTempDownMenuItem})
        Me.SetHighTemperatureMenuItem.Name = "SetHighTemperatureMenuItem"
        Me.SetHighTemperatureMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.SetHighTemperatureMenuItem.Text = "Set High Temperature"
        Me.SetHighTemperatureMenuItem.ToolTipText = "Change the High Temperature Set Point"
        '
        'HighTempUpMenuItem
        '
        Me.HighTempUpMenuItem.Name = "HighTempUpMenuItem"
        Me.HighTempUpMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.HighTempUpMenuItem.Text = "High Temp Up"
        Me.HighTempUpMenuItem.ToolTipText = "Increment High Set Temp by 0.5°"
        '
        'HighTempDownMenuItem
        '
        Me.HighTempDownMenuItem.Name = "HighTempDownMenuItem"
        Me.HighTempDownMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.HighTempDownMenuItem.Text = "High Temp Down"
        Me.HighTempDownMenuItem.ToolTipText = "Decrement High Set Temp by 0.5°"
        '
        'SetLowTemperatureMenuItem
        '
        Me.SetLowTemperatureMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LowTempUpMenuItem, Me.LowTempDownMenuItem})
        Me.SetLowTemperatureMenuItem.Name = "SetLowTemperatureMenuItem"
        Me.SetLowTemperatureMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.SetLowTemperatureMenuItem.Text = "Set Low Temperature"
        Me.SetLowTemperatureMenuItem.ToolTipText = "Change the Low Set Temperature"
        '
        'LowTempUpMenuItem
        '
        Me.LowTempUpMenuItem.Name = "LowTempUpMenuItem"
        Me.LowTempUpMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.LowTempUpMenuItem.Text = "Low Temp Up"
        Me.LowTempUpMenuItem.ToolTipText = "Increment Low Set Temp by 0.5°"
        '
        'LowTempDownMenuItem
        '
        Me.LowTempDownMenuItem.Name = "LowTempDownMenuItem"
        Me.LowTempDownMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.LowTempDownMenuItem.Text = "Low Temp Down"
        Me.LowTempDownMenuItem.ToolTipText = "Decrement Low Set Temp by 0.5°"
        '
        'ChangeModeMenuItem
        '
        Me.ChangeModeMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HeatMenuItem, Me.OffMenuItem, Me.CoolMenuItem})
        Me.ChangeModeMenuItem.Name = "ChangeModeMenuItem"
        Me.ChangeModeMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ChangeModeMenuItem.Text = "Change Mode"
        Me.ChangeModeMenuItem.ToolTipText = "Change the System Mode"
        '
        'HeatMenuItem
        '
        Me.HeatMenuItem.Name = "HeatMenuItem"
        Me.HeatMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HeatMenuItem.Text = "Heat"
        Me.HeatMenuItem.ToolTipText = "Enable Heat"
        '
        'OffMenuItem
        '
        Me.OffMenuItem.Enabled = False
        Me.OffMenuItem.Name = "OffMenuItem"
        Me.OffMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OffMenuItem.Text = "Off"
        Me.OffMenuItem.ToolTipText = "Turn the System Off"
        '
        'CoolMenuItem
        '
        Me.CoolMenuItem.Name = "CoolMenuItem"
        Me.CoolMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CoolMenuItem.Text = "Cool"
        Me.CoolMenuItem.ToolTipText = "Enable Ac "
        '
        'ConnectionMenuItem
        '
        Me.ConnectionMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectCOMMenuItem, Me.DisconnectMenuItem, Me.RefreshMenuItem})
        Me.ConnectionMenuItem.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectionMenuItem.Name = "ConnectionMenuItem"
        Me.ConnectionMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConnectionMenuItem.Text = "Connection"
        '
        'ConnectCOMMenuItem
        '
        Me.ConnectCOMMenuItem.Name = "ConnectCOMMenuItem"
        Me.ConnectCOMMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConnectCOMMenuItem.Text = "Connect"
        '
        'DisconnectMenuItem
        '
        Me.DisconnectMenuItem.Enabled = False
        Me.DisconnectMenuItem.Name = "DisconnectMenuItem"
        Me.DisconnectMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DisconnectMenuItem.Text = "Disconnect"
        '
        'RefreshMenuItem
        '
        Me.RefreshMenuItem.Name = "RefreshMenuItem"
        Me.RefreshMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RefreshMenuItem.Text = "Refresh"
        '
        'ProgramMenuItem
        '
        Me.ProgramMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveTempSettingsMenuItem, Me.ExitProgramMenuItem})
        Me.ProgramMenuItem.Font = New System.Drawing.Font("Museo Slab 500", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgramMenuItem.Name = "ProgramMenuItem"
        Me.ProgramMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProgramMenuItem.Text = "Program"
        '
        'SaveTempSettingsMenuItem
        '
        Me.SaveTempSettingsMenuItem.Name = "SaveTempSettingsMenuItem"
        Me.SaveTempSettingsMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.SaveTempSettingsMenuItem.Text = "Save Temperature Settings"
        '
        'ExitProgramMenuItem
        '
        Me.ExitProgramMenuItem.Name = "ExitProgramMenuItem"
        Me.ExitProgramMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.ExitProgramMenuItem.Text = "Exit Program"
        '
        'HeaterStatusButton
        '
        Me.HeaterStatusButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.HeaterStatusButton.Location = New System.Drawing.Point(467, 124)
        Me.HeaterStatusButton.Name = "HeaterStatusButton"
        Me.HeaterStatusButton.Size = New System.Drawing.Size(20, 20)
        Me.HeaterStatusButton.TabIndex = 40
        Me.HeaterStatusButton.UseVisualStyleBackColor = False
        '
        'FanStatusButton
        '
        Me.FanStatusButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.FanStatusButton.Location = New System.Drawing.Point(532, 124)
        Me.FanStatusButton.Name = "FanStatusButton"
        Me.FanStatusButton.Size = New System.Drawing.Size(20, 20)
        Me.FanStatusButton.TabIndex = 41
        Me.FanStatusButton.UseVisualStyleBackColor = False
        '
        'AcStatusButton
        '
        Me.AcStatusButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.AcStatusButton.Location = New System.Drawing.Point(588, 128)
        Me.AcStatusButton.Name = "AcStatusButton"
        Me.AcStatusButton.Size = New System.Drawing.Size(20, 20)
        Me.AcStatusButton.TabIndex = 42
        Me.AcStatusButton.UseVisualStyleBackColor = False
        '
        'HvacControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AcStatusButton)
        Me.Controls.Add(Me.FanStatusButton)
        Me.Controls.Add(Me.HeaterStatusButton)
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
        Me.Controls.Add(Me.HighTempDownButton)
        Me.Controls.Add(Me.HighTempUpButton)
        Me.Controls.Add(Me.LowTempDownButton)
        Me.Controls.Add(Me.LowTempUpButton)
        Me.Controls.Add(Me.HighTempTextBox)
        Me.Controls.Add(Me.LowTempTextBox)
        Me.Controls.Add(Me.SetHighLabel)
        Me.Controls.Add(Me.SetLowLabel)
        Me.Controls.Add(Me.AcOnLabel)
        Me.Controls.Add(Me.FanOnLabel)
        Me.Controls.Add(Me.HeatOnLabel)
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
    Friend WithEvents HeatOnLabel As Label
    Friend WithEvents FanOnLabel As Label
    Friend WithEvents AcOnLabel As Label
    Friend WithEvents SetLowLabel As Label
    Friend WithEvents SetHighLabel As Label
    Friend WithEvents LowTempTextBox As TextBox
    Friend WithEvents HighTempTextBox As TextBox
    Friend WithEvents LowTempUpButton As Button
    Friend WithEvents LowTempDownButton As Button
    Friend WithEvents HighTempDownButton As Button
    Friend WithEvents HighTempUpButton As Button
    Friend WithEvents FanShutDownTimer As Timer
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
    Friend WithEvents ChangeModeMenuItem As ToolStripMenuItem
    Friend WithEvents HeatMenuItem As ToolStripMenuItem
    Friend WithEvents OffMenuItem As ToolStripMenuItem
    Friend WithEvents CoolMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectCOMMenuItem As ToolStripMenuItem
    Friend WithEvents DisconnectMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramMenuItem As ToolStripMenuItem
    Friend WithEvents SaveTempSettingsMenuItem As ToolStripMenuItem
    Friend WithEvents ExitProgramMenuItem As ToolStripMenuItem
    Friend WithEvents HeaterStatusButton As Button
    Friend WithEvents FanStatusButton As Button
    Friend WithEvents AcStatusButton As Button
End Class
