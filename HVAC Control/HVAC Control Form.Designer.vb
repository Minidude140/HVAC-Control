<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ControlsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.COMSelectToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ConnectCOMToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveSettingsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitProgramToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ControlsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlsToolStrip
        '
        Me.ControlsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMSelectToolStripComboBox, Me.ConnectCOMToolStripButton, Me.ToolStripSeparator1, Me.BlankToolStripLabel1, Me.ToolStripSeparator2, Me.SaveSettingsToolStripButton, Me.ToolStripSeparator3, Me.BlankToolStripLabel2, Me.ToolStripSeparator4, Me.ExitProgramToolStripButton})
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
        'ConnectCOMToolStripButton
        '
        Me.ConnectCOMToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConnectCOMToolStripButton.Image = Global.HVAC_Control.My.Resources.Resources.icons8_usb_connector_30
        Me.ConnectCOMToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConnectCOMToolStripButton.Name = "ConnectCOMToolStripButton"
        Me.ConnectCOMToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ConnectCOMToolStripButton.Text = "ToolStripButton1"
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
        'SaveSettingsToolStripButton
        '
        Me.SaveSettingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveSettingsToolStripButton.Image = CType(resources.GetObject("SaveSettingsToolStripButton.Image"), System.Drawing.Image)
        Me.SaveSettingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveSettingsToolStripButton.Name = "SaveSettingsToolStripButton"
        Me.SaveSettingsToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveSettingsToolStripButton.Text = "ToolStripButton1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BlankToolStripLabel2
        '
        Me.BlankToolStripLabel2.Name = "BlankToolStripLabel2"
        Me.BlankToolStripLabel2.Size = New System.Drawing.Size(235, 22)
        Me.BlankToolStripLabel2.Text = "                                                                            "
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ExitProgramToolStripButton
        '
        Me.ExitProgramToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExitProgramToolStripButton.Image = CType(resources.GetObject("ExitProgramToolStripButton.Image"), System.Drawing.Image)
        Me.ExitProgramToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitProgramToolStripButton.Name = "ExitProgramToolStripButton"
        Me.ExitProgramToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ExitProgramToolStripButton.Text = "ToolStripButton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ControlsToolStrip)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents ExitProgramToolStripButton As ToolStripButton
End Class
