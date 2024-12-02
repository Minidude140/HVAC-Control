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

    '**********************************************Custom Methods*******************************************
    ''' <summary>
    ''' Fill Combo Box With Available COM Ports
    ''' </summary>
    Sub PopulateCOMSelect()
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

    Private Sub COMTimer_Tick(sender As Object, e As EventArgs) Handles COMTimer.Tick
        'Update Ambient Temp Sensor Data
        ambientTempSensor = Qy_AnalogReadA1()
        'Update Control System Temp Sensor Data
        controlSystemTempSensor = Qy_AnalogReadA2()
        'Update Form Output Labels
        UpdateLabels()
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

    Private Sub LowTempUpButton_Click(sender As Object, e As EventArgs) Handles LowTempUpButton.Click
        'Create Variable For Current Value
        Dim currentSetPoint As Double
        currentSetPoint = CDbl(LowTempTextBox.Text)
        'Increment Current Value by 0.5
        currentSetPoint = Increment(currentSetPoint)
        'Update Text Box With Incremented Value
        LowTempTextBox.Text = CStr(currentSetPoint)
    End Sub

    Private Sub LowTempDownButton_Click(sender As Object, e As EventArgs) Handles LowTempDownButton.Click
        'Create Variable For Current Value
        Dim currentSetPoint As Double
        currentSetPoint = CDbl(LowTempTextBox.Text)
        'Decrement Current Value by 0.5
        currentSetPoint = Decrement(currentSetPoint)
        'Update Text Box With Decremented Value
        LowTempTextBox.Text = CStr(currentSetPoint)
    End Sub

    Private Sub HighTempUpButton_Click(sender As Object, e As EventArgs) Handles HighTempUpButton.Click
        'Create Variable For Current Value
        Dim currentSetPoint As Double
        currentSetPoint = CDbl(HighTempTextBox.Text)
        'Increment Current Value by 0.5
        currentSetPoint = Increment(currentSetPoint)
        'Update Text Box With Incremented Value
        HighTempTextBox.Text = CStr(currentSetPoint)
    End Sub

    Private Sub HighTempDownButton_Click(sender As Object, e As EventArgs) Handles HighTempDownButton.Click
        'Create Variable For Current Value
        Dim currentSetPoint As Double
        currentSetPoint = CDbl(HighTempTextBox.Text)
        'Decrement Current Value by 0.5
        currentSetPoint = Decrement(currentSetPoint)
        'Update Text Box With Decremented Value
        HighTempTextBox.Text = CStr(currentSetPoint)
    End Sub
End Class
