'Zachary Christensen
'RCET Advanced Programming
'12/1/24
'HVAC Control Final
'GitHub:https://github.com/Minidude140/HVAC-Control


Option Explicit On
Option Strict On
Imports System.Threading

Public Class HvacControlForm
    '*****************************************Global Variables******************************************
    Dim ambientTempSensor As Integer
    Dim controlSystemTempSensor As Integer
    Dim digitalinputs As Byte
    Dim shutdownInterlock As Boolean = False
    Dim heaterOveride As Boolean = False
    Dim fanOverride As Boolean = False
    Dim differentialSensor As Boolean = False
    Dim modeSelect As String

    'ISU Color Pallet
    Public GrowlGreyLight As Color = Color.FromArgb(230, 231, 232)
    Public GrowlGreyMed As Color = Color.FromArgb(167, 167, 167)
    Public GrowlGrey As Color = Color.FromArgb(130, 130, 130)
    Public Roarange As Color = Color.FromArgb(244, 121, 32)
    Public RoarangeL As Color = Color.FromArgb(246, 146, 64)
    Public BengalBlack As Color = Color.FromArgb(0, 0, 0)
    '**********************************************Custom Methods*******************************************
    ''' <summary>
    ''' Fill Combo Box With Available COM Ports
    ''' </summary>
    Sub PopulateCOMSelect()
        'Clear any Previous List Items
        COMSelectToolStripComboBox.Items.Clear()
        For Each portName In COMSerialPort.GetPortNames
            'add available Com Ports to combo box
            COMSelectToolStripComboBox.Items.Add(portName)
        Next
        'Select First Option
        COMSelectToolStripComboBox.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Attempt Connection To Selected COM Port.  Verifies Selected COM is a QY@t Board
    ''' </summary>
    Sub ConnectCOM()
        COMSerialPort.PortName = CStr(COMSelectToolStripComboBox.SelectedItem)
        COMSerialPort.BaudRate = 9600
        Try
            'Try to Open Selected COM
            COMSerialPort.Open()
            'Test if COM opened is a QY@t Board
            If GetQySettings() = True Then
                'Verified Selected COM as QY@t Board
                MsgBox("Successfully Connected to Selected COM Port.  Verified QY@ Board Input")
                'Enable COM Timer
                COMTimer.Enabled = True
                'Enable Disconnect button
                DisconnetToolStripButton.Enabled = True
                'Disable Connect Button
                ConnectCOMToolStripButton.Enabled = False
            Else
                'Not a QY@t Board Close COM
                MsgBox("Selected COM Port is not a QY@ Board")
                COMSerialPort.Close()
            End If
        Catch ex As Exception
            'Could Not Connect Close COM
            MsgBox("Sorry We Could Not Connect to Selected COM")
            COMSerialPort.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Get Settings from Com Return True if Qy@ identifier is found
    ''' </summary>
    ''' <returns></returns>
    Function GetQySettings() As Boolean
        'Boolean Used to Check if COM is a Qy@ Board
        Dim isQY As Boolean = False
        'command QY Board to output settings data
        Dim command(0) As Byte
        command(0) = &B11110000
        COMSerialPort.Write(command, 0, 1)
        'Wait for Response
        Thread.Sleep(5)
        'create an array of bytes with the length of given bytes
        Dim data(COMSerialPort.BytesToRead) As Byte
        'populates data with incoming port data starting at 0 bit and reading the full bytes
        COMSerialPort.Read(data, 0, COMSerialPort.BytesToRead)
        'loops through the data array and writes each item to console (converts to hex)
        If data.Length < 61 Then
            'do nothing
        ElseIf data(58) = 81 And data(59) = 121 And data(60) = 64 Then
            'COM Selected is a Qy@ Board
            isQY = True
        End If
        Return isQY
    End Function

    ''' <summary>
    ''' Read Analog Input 1.  Return 9 Bit Count
    ''' </summary>
    Function Qy_AnalogReadA1() As Integer
        'High and Low Byte Data
        Dim Result As Integer
        'command to QY board to read analog data
        Dim command(0) As Byte
        command(0) = &B1010001
        COMSerialPort.Write(command, 0, 1)
        'Wait for Response
        Thread.Sleep(5)
        'create an array of bytes with the length of input data
        Dim data(COMSerialPort.BytesToRead) As Byte
        'Populate array with input data
        COMSerialPort.Read(data, 0, COMSerialPort.BytesToRead)
        'Add the First 8 high bytes
        Result = data(0)
        'Shift Result Left for incoming bit
        Result = Result * 2
        'Test if bit 7 of the low byte is high
        If data(1) >= 128 Then
            'Shift in a 1
            Result = Result + 1
        Else
            'Shift in a 0 (do nothing)
        End If
        'Shift Result Left for incoming bit
        Result = Result * 2
        If data(1) >= 64 Then
            'Shift in a 1
            Result = Result + 1
        Else
            'Shift in a 0 (do nothing)
        End If
        'Return 10 bits of Analog Data
        Return Result
    End Function

    ''' <summary>
    ''' Read Analog Input 2.  Return 10 Bit Count 
    ''' </summary>
    Function Qy_AnalogReadA2() As Integer
        'High and Low Byte Data
        Dim Result As Integer
        'command to QY board to read analog data
        Dim command(0) As Byte
        command(0) = &B1010010
        COMSerialPort.Write(command, 0, 1)
        'Wait for Response
        Thread.Sleep(5)
        'create an array of bytes with the length of input data
        Dim data(COMSerialPort.BytesToRead) As Byte
        'Populate array with input data
        COMSerialPort.Read(data, 0, COMSerialPort.BytesToRead)
        'Add the First 8 high bytes
        Result = data(0)
        'Shift Result Left for incoming bit
        Result = Result * 2
        'Test if bit 7 of the low byte is high
        If data(1) >= 128 Then
            'Shift in a 1
            Result = Result + 1
        Else
            'Shift in a 0 (do nothing)
        End If
        'Shift Result Left for incoming bit
        Result = Result * 2
        If data(1) >= 64 Then
            'Shift in a 1
            Result = Result + 1
        Else
            'Shift in a 0 (do nothing)
        End If
        'Return 10 bits of Analog Data
        Return Result
    End Function

    ''' <summary>
    ''' Read Digital Inputs.  Return Byte of current input status
    ''' </summary>
    ''' <returns></returns>
    Function Qy_DigitalRead() As Byte
        'command to QY board to read Digital Inputs
        Dim command(0) As Byte
        command(0) = &B110000
        COMSerialPort.Write(command, 0, 1)
        'Wait for Response
        Thread.Sleep(5)
        'create an array of bytes with the length of input data
        Dim data(COMSerialPort.BytesToRead) As Byte
        'Populate array with input data
        COMSerialPort.Read(data, 0, COMSerialPort.BytesToRead)
        Return data(0)
    End Function

    ''' <summary>
    ''' Convert the Input Data to Degrees F
    ''' </summary>
    ''' <param name="inputData"></param>
    ''' <returns></returns>
    Function ConvertToTempF(inputData As Integer) As Double
        Dim degreeF As Double
        'Convert Input of ____ to degrees F
        'LM34 : 10mV/°F
        '* 0.66 Gain : 6.6mV/°F
        'Analog Input of 10 bits:
        ' 3.3V/((2^10)-1) = VResolution:3.2mv/Count (1 Count ~= 0.5°) 
        degreeF = inputData * 0.5
        'Return Degrees F
        Return degreeF
    End Function

    ''' <summary>
    ''' Conters Degrees F Returns Degrees C
    ''' </summary>
    ''' <param name="tempF"></param>
    ''' <returns></returns>
    Function ConvertToTempC(tempF As Double) As Double
        Dim degreeC As Double
        'Convert F to C
        degreeC = Math.Round(((tempF - 32) * (5 / 9)), 1)
        'Return Degrees C
        Return degreeC
    End Function

    ''' <summary>
    ''' Updates the Form Labels with current Data
    ''' </summary>
    Sub UpdateLabels()
        'Update Test Labels
        AnalogInput1TestLabel.Text = CStr(ambientTempSensor)
        AnalogInput2TestLabel.Text = CStr(controlSystemTempSensor)
        'Update Ambient Temp Labels
        AmbientTempFLabel.Text = $"{CStr(ConvertToTempF(ambientTempSensor))}°F"
        AmbientTempCLabel.Text = $"{CStr(ConvertToTempC(ConvertToTempF(ambientTempSensor)))}°C"
        'Update Control System Temp Labels
        ControlSytemTempFLabel.Text = $"{CStr(ConvertToTempF(controlSystemTempSensor))}°F"
        ControlSystemTempCLabel.Text = $"{CStr(ConvertToTempC(ConvertToTempF(controlSystemTempSensor)))}°C"

    End Sub

    ''' <summary>
    ''' Increment the given value by 0.5
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Function Increment(value As Double) As Double
        value = value + 0.5
        Return value
    End Function

    ''' <summary>
    ''' Decrement given value by 0.5
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Function Decrement(value As Double) As Double
        value = value - 0.5
        Return value
    End Function

    ''' <summary>
    ''' Controls the Status of the Fan Argument true to turn on, argument false to turn off (Includes Shut Down Timer)
    ''' </summary>
    ''' <param name="turnOn"></param>
    Sub FanControl(turnOn As Boolean)
        If turnOn = True Then
            'Turn on Fan
            'turn on GUI indicator
            FanProgressBar.Value = 1
            PowerUpTimer.Enabled = True
            '***********Send Digital Output Signal Fan ON Here***************
        ElseIf turnOn = False Then
            'Begin Fan ShutDown (Wait 5s before Shutting Off)
            FanShutDownTimer.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Controls the Status of the Heater Argument true to turn on, argument false to turn off
    ''' </summary>
    ''' <param name="turnOn"></param>
    Sub HeaterControl(turnOn As Boolean)
        If turnOn = True Then
            'Turn on Heater
            'turn on GUI indicator
            HeaterProgressBar.Value = 1
            '***********Send Digital Output Signal Heater ON Here***************
        ElseIf turnOn = False Then
            'Turn off Heater
            'turn on GUI indicator
            HeaterProgressBar.Value = 0
            '***********Send Digital Output Signal Heater OFF Here***************
        End If
    End Sub

    ''' <summary>
    ''' Controls the Status of the AC Argument true to turn on, argument false to turn off
    ''' </summary>
    ''' <param name="turnOn"></param>
    Sub AcControl(turnOn As Boolean)
        If turnOn = True Then
            'Turn on AC
            'turn on GUI indicator
            AcProgressBar.Value = 1
            '***********Send Digital Output Signal Ac ON Here***************
        ElseIf turnOn = False Then
            'Turn off AC
            'turn on GUI indicator
            AcProgressBar.Value = 0
            '***********Send Digital Output Signal Ac OFF Here***************
        End If
    End Sub

    ''' <summary>
    ''' Test a given byte at a given index return true if high.  Return False if low.
    ''' </summary>
    ''' <param name="data"></param>
    ''' <param name="index"></param>
    ''' <returns></returns>
    Function TestBit(data As Byte, index As Integer) As Boolean
        Dim testArray As New BitArray({data})
        If testArray(index) = True Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Test Bits of Digital Inputs and Update Interlocks, Overrides, and Sensor Booleans and indicators
    ''' </summary>
    Sub TestDigitalInputs()
        If TestBit(digitalinputs, 1) = True Then
            shutdownInterlock = True
            SafetyInterlockButton.BackColor = Roarange
        Else
            shutdownInterlock = False
            SafetyInterlockButton.BackColor = GrowlGreyLight
        End If
        If TestBit(digitalinputs, 2) = True Then
            heaterOveride = True
            HeaterOverrideButton.BackColor = Roarange
        Else
            heaterOveride = False
            HeaterOverrideButton.BackColor = GrowlGreyLight
        End If
        If TestBit(digitalinputs, 3) = True Then
            fanOverride = True
            FanOverrideButton.BackColor = Roarange
        Else
            fanOverride = False
            FanOverrideButton.BackColor = GrowlGreyLight
        End If
        If TestBit(digitalinputs, 4) = True Then
            differentialSensor = True
            DifferentialButton.BackColor = Roarange
        Else
            differentialSensor = False
            DifferentialButton.BackColor = GrowlGreyLight
        End If
    End Sub

    ''' <summary>
    ''' Change Mode Based On input Argument O is off, H is Heat, C is Cool
    ''' </summary>
    Sub ChangeMode(modeselect As String)
        Select Case modeselect
            Case = "O"
                'Mode is Off
                'Shut Down AC
                AcControl(False)
                'Shut Down Heater
                HeaterControl(False)
                'Begin Fan Shut Down
                FanControl(False)
            Case = "H"
                'Mode is Heat
                'Disable any previous shut down routine
                FanShutDownTimer.Enabled = False
                'Only Enable is not already on
                If HeaterProgressBar.Value = 0 Then
                    'Shut Down AC
                    AcControl(False)
                    'Turn on Fan
                    FanControl(True)
                End If

            Case = "C"
                'Mode is Cool
                'Disable any previous shut down routine
                FanShutDownTimer.Enabled = False
                If AcProgressBar.Value = 0 Then
                    'Shut Down Heater
                    HeaterControl(False)
                    'Turn on Fan
                    FanControl(True)
                End If
            Case = "F"
                'Only Fan Mode
                'Disable any previous shut down routine
                FanShutDownTimer.Enabled = False
                'Shut Down Heater
                HeaterControl(False)
                'Shut Down AC
                AcControl(False)
                'Turn On Fan
                FanControl(True)
            Case Else
                'Should Not Happen
        End Select
    End Sub

    Sub OverrideMode()
        If shutdownInterlock = True Then
            'Safety Interlock enable shut down operation **First Priority**
            ChangeMode("O")
            TempCheckTimer.Enabled = False
        ElseIf fanOverride = True Then
            'Fan override Turn on Only Fan Mode
            ChangeMode("F")
            TempCheckTimer.Enabled = False
        Else
            'No Interlocks enabled return to normal operation
            TempCheckTimer.Enabled = True
        End If
    End Sub

    '**********************************************Event Handlers*******************************************
    Private Sub HvacControlForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Fill Com Select Combo Box Options
        PopulateCOMSelect()
    End Sub

    Private Sub QuitProgramToolStripButton_Click(sender As Object, e As EventArgs) Handles QuitProgramToolStripButton.Click
        'Exit the program
        Me.Close()
    End Sub

    Private Sub ConnectCOMToolStripButton_Click(sender As Object, e As EventArgs) Handles ConnectCOMToolStripButton.Click
        ConnectCOM()
    End Sub


    Private Sub DisconnetToolStripButton_Click(sender As Object, e As EventArgs) Handles DisconnetToolStripButton.Click
        'Disable COM Timer
        COMTimer.Enabled = False
        'Close COM Port
        COMSerialPort.Close()
        'Disable Disconnect Button
        DisconnetToolStripButton.Enabled = False
        'Enable Connect Button
        ConnectCOMToolStripButton.Enabled = True
    End Sub
    Private Sub RefreshCOMToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshCOMToolStripButton.Click
        PopulateCOMSelect()
    End Sub
    Private Sub COMTimer_Tick(sender As Object, e As EventArgs) Handles COMTimer.Tick
        'Update Ambient Temp Sensor Data
        ambientTempSensor = Qy_AnalogReadA1()
        'Update Control System Temp Sensor Data
        controlSystemTempSensor = Qy_AnalogReadA2()
        'Update Digital Input States
        digitalinputs = Qy_DigitalRead()
        'Update Booleans From Input Buttons
        TestDigitalInputs()
        'Test any Overrides/Interlocks
        OverrideMode()
        'Update Form Output Labels
        UpdateLabels()
    End Sub
    Private Sub LowTempUpButton_Click(sender As Object, e As EventArgs) Handles LowTempUpButton.Click
        'Create Variable For Current Value
        Dim currentSetPoint As Double
        currentSetPoint = CDbl(LowTempTextBox.Text)
        'Only Increment is Less Than 90
        If currentSetPoint < 90 Then
            'Increment Current Value by 0.5
            currentSetPoint = Increment(currentSetPoint)
            'Update Text Box With Incremented Value
            LowTempTextBox.Text = CStr(currentSetPoint)
        End If
    End Sub

    Private Sub LowTempDownButton_Click(sender As Object, e As EventArgs) Handles LowTempDownButton.Click
        'Create Variable For Current Value
        Dim currentSetPoint As Double
        currentSetPoint = CDbl(LowTempTextBox.Text)
        'Only Decrement if More than 50
        If currentSetPoint > 50 Then
            'Decrement Current Value by 0.5
            currentSetPoint = Decrement(currentSetPoint)
            'Update Text Box With Decremented Value
            LowTempTextBox.Text = CStr(currentSetPoint)
        End If
    End Sub

    Private Sub HighTempUpButton_Click(sender As Object, e As EventArgs) Handles HighTempUpButton.Click
        'Create Variable For Current Value
        Dim currentSetPoint As Double
        currentSetPoint = CDbl(HighTempTextBox.Text)
        'Only Increment is Less Than 90
        If currentSetPoint < 90 Then
            'Increment Current Value by 0.5
            currentSetPoint = Increment(currentSetPoint)
            'Update Text Box With Incremented Value
            HighTempTextBox.Text = CStr(currentSetPoint)
        End If
    End Sub

    Private Sub HighTempDownButton_Click(sender As Object, e As EventArgs) Handles HighTempDownButton.Click
        'Create Variable For Current Value
        Dim currentSetPoint As Double
        currentSetPoint = CDbl(HighTempTextBox.Text)
        'Only Decrement if More than 50
        If currentSetPoint > 50 Then
            'Decrement Current Value by 0.5
            currentSetPoint = Decrement(currentSetPoint)
            'Update Text Box With Decremented Value
            HighTempTextBox.Text = CStr(currentSetPoint)
        End If
    End Sub

    Private Sub FanShutDownTimer_Tick(sender As Object, e As EventArgs) Handles FanShutDownTimer.Tick
        'Turn off Fan Shutdown Timer
        FanShutDownTimer.Enabled = False
        'turn off GUI indicator
        FanProgressBar.Value = 0
        '***********Send Digital Output Signal Fan OFF Here***************
    End Sub

    Private Sub PowerUpTimer_Tick(sender As Object, e As EventArgs) Handles PowerUpTimer.Tick
        PowerUpTimer.Enabled = False
        Select Case modeSelect
            Case = "H"
                'Turn on Heater
                HeaterControl(True)
            Case = "C"
                'Turn on Ac
                AcControl(True)
        End Select
    End Sub

    Private Sub HeatRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles HeatRadioButton.CheckedChanged
        If HeatRadioButton.Checked = True Then
            'turn on heat mode
            modeSelect = "H"
        End If
    End Sub

    Private Sub OffRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles OffRadioButton.CheckedChanged
        If OffRadioButton.Checked = True Then
            'turn off heat and Ac mode
            modeSelect = "O"
        End If
    End Sub

    Private Sub CoolRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CoolRadioButton.CheckedChanged
        If CoolRadioButton.Checked = True Then
            'turn on Ac mode
            modeSelect = "C"
        End If
    End Sub

    Private Sub TempCheckTimer_Tick(sender As Object, e As EventArgs) Handles TempCheckTimer.Tick
        If fanOverride = True Then
            ChangeMode("F")
        Else
            ChangeMode(modeSelect)
        End If
    End Sub


End Class
