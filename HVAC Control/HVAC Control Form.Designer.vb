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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.COMSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.COMTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AnalogInput1TestLabel = New System.Windows.Forms.Label()
        Me.AnalogInput2TestLabel = New System.Windows.Forms.Label()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConnectCOMToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DisconnetToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveSettingsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.QuitProgramToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AmbientTempFLabel = New System.Windows.Forms.Label()
        Me.AmbientTempCLabel = New System.Windows.Forms.Label()
        Me.ControlSytemTempFLabel = New System.Windows.Forms.Label()
        Me.ControlSystemTempCLabel = New System.Windows.Forms.Label()
        Me.AmbientTempLabel = New System.Windows.Forms.Label()
        Me.ControlSystemTempLabel = New System.Windows.Forms.Label()
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
        Me.COMSelectToolStripComboBox.Name = "COMSelectToolStripComboBox"
        Me.COMSelectToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
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
        'HvacControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
