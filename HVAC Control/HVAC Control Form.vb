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
    Dim heaterOverride As Boolean = False
    Dim fanOverride As Boolean = False
    Dim acOverride As Boolean = False
    Dim differentialSensorError As Boolean = False
    Dim modeSelect As String
    Dim modeSelectSave As String
    Dim currentOutputData As Byte

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
                'Enable Disconnect Button and Menu Button
                DisconnetToolStripButton.Enabled = True
                DisconnectMenuItem.Enabled = True
                'Disable Connect Button and Menu Button
                ConnectCOMToolStripButton.Enabled = False
                ConnectCOMMenuItem.Enabled = False
                'Turn off all outputs
                Qy_DigitalWrite(CByte(&H0))
                'Start Checking For Interlock Errors
                ErrorLogDelayTimer.Enabled = True
                'Update Status Strip Connection Status
                COMStatusStripLabel.Text = "Currently Connected to: " & COMSerialPort.PortName
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
    ''' Write the Given Byte to the Digital Output Pins
    ''' </summary>
    ''' <param name="output"></param>
    Sub Qy_DigitalWrite(output As Byte)
        'command to QY board to Write Output Byte Digital Inputs
        Dim command(1) As Byte
        'Digital Write Command
        command(0) = &B100000
        'Byte to Write Out
        command(1) = output
        'Send Data to Qy@ Board
        COMSerialPort.Write(command, 0, 2)
    End Sub

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
            'Test if Fan is already on
            If TestBit(currentOutputData, 2) = True Then
                'Turn On Fan Output and Send to Qy@t Board
                currentOutputData = FlipBit(currentOutputData, 2)
                Qy_DigitalWrite(currentOutputData)
            Else
                'Fan Already On
            End If

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
            HeaterStatusButton.BackColor = Roarange
            'Test if Heater is already on
            If TestBit(currentOutputData, 1) = True Then
                'Flip Heater On Bit
                currentOutputData = FlipBit(currentOutputData, 1)
                'Send Digital Output ON Signal
                Qy_DigitalWrite(currentOutputData)
            Else
                'Heater Already On
            End If
        ElseIf turnOn = False Then
            'Turn off Heater
            'turn off GUI indicator
            HeaterStatusButton.BackColor = GrowlGreyLight
            'Test if Heater is already off
            If TestBit(currentOutputData, 1) = False Then
                    currentOutputData = FlipBit(currentOutputData, 1)
                'Send Digital Output OFF Signal
                Qy_DigitalWrite(currentOutputData)
                End If
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
            'Test if Ac is already On
            If TestBit(currentOutputData, 3) = True Then
                'Flip AC On Bit
                currentOutputData = FlipBit(currentOutputData, 3)
                'Send Digital Output ON Signal
                Qy_DigitalWrite(currentOutputData)
            Else
                'Ac Already On
            End If
        ElseIf turnOn = False Then
            'Turn off AC
            'turn on GUI indicator
            AcProgressBar.Value = 0
            'Test if Ac is already off
            If TestBit(currentOutputData, 3) = False Then
                currentOutputData = FlipBit(currentOutputData, 3)
                'Send Digital Output OFF Signal
                Qy_DigitalWrite(currentOutputData)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Test a given byte at a given index return true if low.  Return False if high.
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
        If TestBit(digitalinputs, 0) = True Then
            shutdownInterlock = True
            SafetyInterlockButton.BackColor = Roarange
        Else
            shutdownInterlock = False
            SafetyInterlockButton.BackColor = GrowlGreyLight
        End If
        If TestBit(digitalinputs, 1) = True Then
            heaterOverride = True
            HeaterOverrideButton.BackColor = Roarange
        Else
            heaterOverride = False
            HeaterOverrideButton.BackColor = GrowlGreyLight
        End If
        If TestBit(digitalinputs, 2) = True Then
            fanOverride = True
            FanOverrideButton.BackColor = Roarange
        Else
            fanOverride = False
            FanOverrideButton.BackColor = GrowlGreyLight
        End If
        If TestBit(digitalinputs, 3) = True Then
            acOverride = True
            AcOverrideButton.backcolor = Roarange
        Else
            acOverride = False
            AcOverrideButton.backcolor = GrowlGreyLight
        End If
        If TestBit(digitalinputs, 4) = True Then
            differentialSensorError = True
            DifferentialButton.BackColor = Roarange
        Else
            differentialSensorError = False
            DifferentialButton.BackColor = GrowlGreyLight
        End If
    End Sub

    ''' <summary>
    ''' Change Mode Based On input Argument O is off, H is Heat, C is Cool
    ''' </summary>
    Sub ChangeMode(currentMode As String)
        Select Case currentMode
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
                If HeaterStatusButton.BackColor = GrowlGreyLight Then
                    'Shut Down AC
                    AcControl(False)
                    'Turn on Fan
                    FanControl(True)
                End If

            Case = "C"
                'Mode is Cool
                'Disable any previous shut down routine
                FanShutDownTimer.Enabled = False
                'Only Enable is not already on
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

    ''' <summary>
    ''' Test Interlocks and Override Booleans and enable corresponding mode
    ''' </summary>
    Sub OverrideMode()
        If shutdownInterlock = True Then
            'Safety Interlock enable shut down operation **First Priority**
            ChangeMode("O")
            'Disable Normal Operation
            TempCheckTimer.Enabled = False
            'Test if Interlock LED is already ON
            If TestBit(currentOutputData, 0) = True Then
                'Flip Interlock LEd On Bit
                currentOutputData = FlipBit(currentOutputData, 0)
                'Send Digital Output ON Signal
                Qy_DigitalWrite(currentOutputData)
            Else
                'LED Already On
            End If
        ElseIf heaterOverride = True Then
            'Heater Override Turn on Heater Mode
            modeSelect = "H"
            'Mode Select is changed and used to keep the Heater On Delay After the Fan turns on
            ChangeMode(modeSelect)
            'Disable Normal Operation
            TempCheckTimer.Enabled = False
        ElseIf fanOverride = True Then
            'Fan override Turn on Only Fan Mode
            ChangeMode("F")
            'Disable Normal Operation
            TempCheckTimer.Enabled = False
        ElseIf acOverride = True Then
            'AC Override Turn on Cool Mode
            modeSelect = "C"
            'Mode Select is changed and used to keep the Heater On Delay After the Fan turns on
            ChangeMode(modeSelect)
            'Disable Normal Operation
            TempCheckTimer.Enabled = False
        ElseIf differentialSensorError = True Then
            'Disable Heater and AC
            AcControl(False)
            HeaterControl(False)
        Else
            'No Interlocks enabled return to normal operation
            'Return Mode Select to Previous State (Radio buttons only Update mode select on change)
            modeSelect = modeSelectSave
            If modeSelect = "O" Then
                'Turn Off All outputs if Off mode
                ChangeMode("O")
            Else
                'Return to Checking Temp in in Heat or Cool Mode
                TempCheckTimer.Enabled = True
            End If
            'Turn off Interlock LED if not already off
            If TestBit(currentOutputData, 0) = False Then
                currentOutputData = FlipBit(currentOutputData, 0)
                'Send Digital Output OFF Signal
                Qy_DigitalWrite(currentOutputData)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Check if a Differential Error Has Occurred.  If it has message user and LOG Error
    ''' </summary>
    Sub CheckDifferentialStatus()
        If differentialSensorError = True Then
            'Report to User the Error
            MsgBox("There is an air deferential Error.  Check Fan or Sensor.")
            LogError("Pressure Differential Error")
        End If
    End Sub

    ''' <summary>
    ''' Checks the system and ambient temperatures base on current mode. 
    ''' <br/>
    ''' True if in Heat Mode System Hotter than ambient
    ''' <br/>
    ''' True if in Cool Mode System Cooler than ambient
    ''' <br/>
    ''' Default Return False
    ''' </summary>
    ''' <returns></returns>
    Function CheckTempSensors() As Boolean
        Dim Valid As Boolean
        If modeSelect = "H" Then
            'Heat Mode Test if System temp is greater than Room temp
            If controlSystemTempSensor >= ambientTempSensor Then
                Valid = True
            Else
                Valid = False
            End If
        ElseIf modeSelect = "C" Then
            'Cool Mode Test if System Temp is Less than Cool Temp
            If controlSystemTempSensor <= ambientTempSensor Then
                Valid = True
            Else
                Valid = False
            End If
        Else
            'if not in heat or cool mode this check will fail
            Valid = False
        End If
        Return Valid
    End Function

    ''' <summary>
    ''' Checks Ambient temp against Set temp.
    ''' <br/>
    ''' If In Heat Mode Will Return True When Under Threshold
    ''' <br/>
    ''' If in Cool Mode Will Return True if Over Threshold
    ''' <br/>
    ''' Default Return is False
    ''' </summary>
    ''' <returns></returns>
    Function TestSetTemp() As Boolean
        Dim turnOn As Boolean
        Select Case modeSelect
            Case = "H"
                If ConvertToTempF(ambientTempSensor) < (CDbl(HighTempTextBox.Text) + 2) Then
                    'Ambient is Cooler than Set Temp plus 2 degrees
                    turnOn = True
                ElseIf ConvertToTempF(ambientTempSensor) >= (CDbl(HighTempTextBox.Text) + 2) Then
                    'Ambient Temp is at or Above Set Temp Plus 2 Degrees
                    turnOn = False
                End If
            Case = "C"
                If ConvertToTempF(ambientTempSensor) > (CDbl(LowTempTextBox.Text) - 2) Then
                    'Ambient is Hotter than Set Temp Minus 2 Degrees
                    turnOn = True
                ElseIf ConvertToTempF(ambientTempSensor) <= (CDbl(LowTempTextBox.Text) - 2) Then
                    'Ambient is at or Below Set temp Minus 2 degrees
                    turnOn = False
                End If
            Case Else
                'Should NOt Occur
                turnOn = False
        End Select
        Return turnOn
    End Function

    ''' <summary>
    ''' Will Toggle the bit number (0-7) from the given byte
    ''' <br/>
    ''' Returns the new byte With the Selected Bit Toggled
    ''' </summary>
    ''' <param name="currentData"></param>
    ''' <param name="bitNumber"></param>
    ''' <returns></returns>
    Function FlipBit(currentData As Byte, bitNumber As Integer) As Byte
        Select Case bitNumber
            Case = 0
                currentData = currentData Xor CByte(&H1)
            Case = 1
                currentData = currentData Xor CByte(&H2)
            Case = 2
                currentData = currentData Xor CByte(&H4)
            Case = 3
                currentData = currentData Xor CByte(&H8)
            Case = 4
                currentData = currentData Xor CByte(&H10)
            Case = 5
                currentData = currentData Xor CByte(&H20)
            Case = 6
                currentData = currentData Xor CByte(&H40)
            Case = 7
                currentData = currentData Xor CByte(&H80)
        End Select
        Return currentData
    End Function

    ''' <summary>
    ''' Saves the Current Set temperatures to a text file
    ''' </summary>
    Sub SaveSettings()
        'Name file and open
        Dim fileName As String = "..\..\..\HVAC Settings.txt"
        Dim fileNumber As Integer = FreeFile()
        FileOpen(fileNumber, fileName, OpenMode.Output)
        'Write Program Key as the first record
        Write(fileNumber, "HVACSETTINGS")
        WriteLine(fileNumber)
        Write(fileNumber, "LOW")
        'Write Low set Value As Record Right After LOW
        Write(fileNumber, LowTempTextBox.Text)
        WriteLine(fileNumber)
        Write(fileNumber, "HIGH")
        'Write High Set Value as Record Right After HIGH
        Write(fileNumber, HighTempTextBox.Text)
        WriteLine(fileNumber)
        FileClose(fileNumber)
        'Prompt user that the Settings have been saved
        MsgBox("Temperature settings have been saved.")
    End Sub

    ''' <summary>
    ''' Load HVAC Setting File and Update Set Temperatures
    ''' </summary>
    Sub ImportSettings()
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String
        Dim splitRecord(2) As String
        Try
            Dim fileName As String = "..\..\..\HVAC Settings.txt"
            FileOpen(fileNumber, fileName, OpenMode.Input)
            'input the current record
            Input(fileNumber, currentRecord)
            If currentRecord = "HVACSETTINGS" Then
                'Text File is from this application continue to save data

                'Input Low setting
                Input(fileNumber, currentRecord)
                Input(fileNumber, currentRecord)
                Input(fileNumber, currentRecord)
                LowTempTextBox.Text = currentRecord
                'Input High Settings
                Input(fileNumber, currentRecord)
                Input(fileNumber, currentRecord)
                Input(fileNumber, currentRecord)
                HighTempTextBox.Text = currentRecord
            Else
                'Text file not recognized load default temps
                LowTempTextBox.Text = "65"
                HighTempTextBox.Text = "70"
            End If
            'Close File
            FileClose(fileNumber)
        Catch ex As Exception
            MsgBox("Sorry an Error Occurred While Reading the File")
        End Try
    End Sub

    ''' <summary>
    ''' Saves given error message and logs the time to HVAC system log
    ''' </summary>
    ''' <param name="errormessage"></param>
    Sub LogError(errormessage As String)
        'Name file and open
        Dim fileName As String = "..\..\..\HVAC system log.txt"
        Dim fileNumber As Integer = FreeFile()
        FileOpen(fileNumber, fileName, OpenMode.Append)
        'Write the Error Message and log the time
        Write(fileNumber, errormessage & "Time: " & DateTime.Now.ToString("yyMMddhhmmssff"))
        WriteLine(fileNumber)
        FileClose(fileNumber)
    End Sub

    '**********************************************Event Handlers*******************************************
    Private Sub HvacControlForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Fill Com Select Combo Box Options
        PopulateCOMSelect()
        'Load Previous Temperature Settings
        ImportSettings()

    End Sub
    Private Sub QuitProgramToolStripButton_Click(sender As Object, e As EventArgs) Handles QuitProgramToolStripButton.Click,
                                                                                           ExitProgramMenuItem.Click
        'Exit the program
        Me.Close()
    End Sub

    Private Sub ConnectCOMToolStripButton_Click(sender As Object, e As EventArgs) Handles ConnectCOMToolStripButton.Click,
                                                                                          ConnectCOMMenuItem.Click
        ConnectCOM()
    End Sub
    Private Sub DisconnetToolStripButton_Click(sender As Object, e As EventArgs) Handles DisconnetToolStripButton.Click,
                                                                                         DisconnectMenuItem.Click
        'Disable COM Timer
        COMTimer.Enabled = False
        'Turn Off all Outputs
        Qy_DigitalWrite(CByte(&H0))
        'Close COM Port
        COMSerialPort.Close()
        'Disable Disconnect Button and Menu Button
        DisconnetToolStripButton.Enabled = False
        DisconnectMenuItem.Enabled = False
        'Enable Connect Button and Menu Button
        ConnectCOMToolStripButton.Enabled = True
        ConnectCOMMenuItem.Enabled = True
        'Update Status Strip Connection Status
        COMStatusStripLabel.Text = "Not Connected"
    End Sub
    Private Sub RefreshCOMToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshCOMToolStripButton.Click,
                                                                                          RefreshMenuItem.Click
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

    Private Sub LowTempUpButton_Click(sender As Object, e As EventArgs) Handles LowTempUpButton.Click,
                                                                                LowTempUpMenuItem.Click
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
    Private Sub LowTempDownButton_Click(sender As Object, e As EventArgs) Handles LowTempDownButton.Click,
                                                                                  LowTempDownMenuItem.Click
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
    Private Sub HighTempUpButton_Click(sender As Object, e As EventArgs) Handles HighTempUpButton.Click,
                                                                                 HighTempUpMenuItem.Click
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
    Private Sub HighTempDownButton_Click(sender As Object, e As EventArgs) Handles HighTempDownButton.Click,
                                                                                   HighTempDownMenuItem.Click
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

    Private Sub PowerUpTimer_Tick(sender As Object, e As EventArgs) Handles PowerUpTimer.Tick
        PowerUpTimer.Enabled = False
        Select Case modeSelect
            Case = "H"
                'Turn on Heater
                HeaterControl(True)
                'Check test differential pressure sensor and report to user
                CheckDifferentialStatus()
            Case = "C"
                'Turn on Ac
                AcControl(True)
                'Check test differential pressure sensor and report to user
                CheckDifferentialStatus()
        End Select
    End Sub
    Private Sub FanShutDownTimer_Tick(sender As Object, e As EventArgs) Handles FanShutDownTimer.Tick
        'Turn off Fan Shutdown Timer
        FanShutDownTimer.Enabled = False
        'turn off GUI indicator
        FanProgressBar.Value = 0
        'Send Digital Output OFF Signal if not already off
        If TestBit(currentOutputData, 2) = False Then
            currentOutputData = FlipBit(currentOutputData, 2)
            Qy_DigitalWrite(currentOutputData)
        End If
    End Sub

    Private Sub HeatRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles HeatRadioButton.CheckedChanged
        If HeatRadioButton.Checked = True Then
            'turn on heat mode
            modeSelect = "H"
            'Enable Temp Checking
            TempCheckTimer.Enabled = True
            'Disable Heat Menu Button
            HeatMenuItem.Enabled = False
            'Enable Other Buttons
            OffMenuItem.Enabled = True
            CoolRadioButton.Enabled = True
        End If
        'Save Mode Select sate for When we change mode Select in Override
        modeSelectSave = modeSelect
    End Sub
    Private Sub OffRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles OffRadioButton.CheckedChanged
        If OffRadioButton.Checked = True Then
            'turn off heat and Ac mode
            modeSelect = "O"
            ChangeMode(modeSelect)
            'Disable Temp Checking
            TempCheckTimer.Enabled = False
            'Check Off Button
            OffRadioButton.Checked = True
            'Disable Off Menu Button
            OffMenuItem.Enabled = False
            'Enable other Menu Buttons
            HeatMenuItem.Enabled = True
            CoolMenuItem.Enabled = True
        End If
        'Save Mode Select sate for When we change mode Select in Override
        modeSelectSave = modeSelect
    End Sub
    Private Sub CoolRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CoolRadioButton.CheckedChanged
        If CoolRadioButton.Checked = True Then
            'turn on Ac mode
            modeSelect = "C"
            'Enable Temp Checking
            TempCheckTimer.Enabled = True
            'Check Cool Radio Button
            CoolRadioButton.Checked = True
            'Disable Cool Menu Button
            CoolMenuItem.Enabled = False
            'Enable Other Menu Buttons
            HeatMenuItem.Enabled = True
            OffMenuItem.Enabled = True
        End If
        'Save Mode Select sate for When we change mode Select in Override
        modeSelectSave = modeSelect
    End Sub
    Private Sub HeatMenuItem_Click(sender As Object, e As EventArgs) Handles HeatMenuItem.Click
        'Check Heat Button
        HeatRadioButton.Checked = True
        'Disable Heat Menu Button
        HeatMenuItem.Enabled = False
        'Enable Other Buttons
        OffMenuItem.Enabled = True
        CoolRadioButton.Enabled = True
    End Sub
    Private Sub OffMenuItem_Click(sender As Object, e As EventArgs) Handles OffMenuItem.Click
        'Check Off Button
        OffRadioButton.Checked = True
        'Disable Off Menu Button
        OffMenuItem.Enabled = False
        'Enable other Menu Buttons
        HeatMenuItem.Enabled = True
        CoolMenuItem.Enabled = True
    End Sub
    Private Sub CoolMenuItem_Click(sender As Object, e As EventArgs) Handles CoolMenuItem.Click
        'Check Cool Radio Button
        CoolRadioButton.Checked = True
        'Disable Cool Menu Button
        CoolMenuItem.Enabled = False
        'Enable Other Menu Buttons
        HeatMenuItem.Enabled = True
        OffMenuItem.Enabled = True
    End Sub

    Private Sub TempCheckTimer_Tick(sender As Object, e As EventArgs) Handles TempCheckTimer.Tick
        If CheckTempSensors() = True Then
            'System/Ambient Temp Check Pass Continue to Activate System
            If TestSetTemp() = True Then
                'Ambient Outside Set Range Turn ON System
                ChangeMode(modeSelect)
            Else
                'Ambient inside the Range Turn Off System
                ChangeMode("O")
            End If
        Else
            'System/Ambient Temp Check Fail Do not Turn on System
            MsgBox("There is a Temperature Difference Error")
            LogError("Temperature Differential Error")
        End If
        'Check test differential pressure sensor and report to user
        CheckDifferentialStatus()
    End Sub

    Private Sub SaveSettingsToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveSettingsToolStripButton.Click,
                                                                                            SaveTempSettingsMenuItem.Click
        SaveSettings()
    End Sub

    Private Sub ErrorLogDelayTimer_Tick(sender As Object, e As EventArgs) Handles ErrorLogDelayTimer.Tick
        If shutdownInterlock = True Then
            LogError("ShutDown Interlock Engaged")
        End If
        If heaterOverride = True Then
            LogError("Heater Override Engaged")
        End If
        If fanOverride = True Then
            LogError("Fan Override Engaged")
        End If
        If acOverride = True Then
            LogError("AC Override Engaged")
        End If
    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        Dim currentTime As String
        currentTime = FormatDateTime(TimeOfDay)
        TimeStatusStripLabel.Text = currentTime
    End Sub
End Class
