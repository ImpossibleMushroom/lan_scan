<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PortScan
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
        Me.portScanDisplay = New System.Windows.Forms.ListBox()
        Me.commonPortsBtn = New System.Windows.Forms.RadioButton()
        Me.portRangeBtn = New System.Windows.Forms.RadioButton()
        Me.portStartRange = New System.Windows.Forms.TextBox()
        Me.portEndRange = New System.Windows.Forms.TextBox()
        Me.tolbl = New System.Windows.Forms.Label()
        Me.portScanToggle = New System.Windows.Forms.Button()
        Me.portScanProgress = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'portScanDisplay
        '
        Me.portScanDisplay.FormattingEnabled = True
        Me.portScanDisplay.Location = New System.Drawing.Point(12, 85)
        Me.portScanDisplay.Name = "portScanDisplay"
        Me.portScanDisplay.Size = New System.Drawing.Size(384, 199)
        Me.portScanDisplay.TabIndex = 0
        '
        'commonPortsBtn
        '
        Me.commonPortsBtn.AutoSize = True
        Me.commonPortsBtn.Location = New System.Drawing.Point(12, 13)
        Me.commonPortsBtn.Name = "commonPortsBtn"
        Me.commonPortsBtn.Size = New System.Drawing.Size(93, 17)
        Me.commonPortsBtn.TabIndex = 1
        Me.commonPortsBtn.TabStop = True
        Me.commonPortsBtn.Text = "Common Ports"
        Me.commonPortsBtn.UseVisualStyleBackColor = True
        '
        'portRangeBtn
        '
        Me.portRangeBtn.AutoSize = True
        Me.portRangeBtn.Location = New System.Drawing.Point(111, 13)
        Me.portRangeBtn.Name = "portRangeBtn"
        Me.portRangeBtn.Size = New System.Drawing.Size(79, 17)
        Me.portRangeBtn.TabIndex = 3
        Me.portRangeBtn.TabStop = True
        Me.portRangeBtn.Text = "Port Range"
        Me.portRangeBtn.UseVisualStyleBackColor = True
        '
        'portStartRange
        '
        Me.portStartRange.Location = New System.Drawing.Point(197, 13)
        Me.portStartRange.Name = "portStartRange"
        Me.portStartRange.Size = New System.Drawing.Size(68, 20)
        Me.portStartRange.TabIndex = 4
        '
        'portEndRange
        '
        Me.portEndRange.Location = New System.Drawing.Point(297, 12)
        Me.portEndRange.Name = "portEndRange"
        Me.portEndRange.Size = New System.Drawing.Size(68, 20)
        Me.portEndRange.TabIndex = 5
        '
        'tolbl
        '
        Me.tolbl.AutoSize = True
        Me.tolbl.Location = New System.Drawing.Point(271, 13)
        Me.tolbl.Name = "tolbl"
        Me.tolbl.Size = New System.Drawing.Size(20, 13)
        Me.tolbl.TabIndex = 6
        Me.tolbl.Text = "To"
        Me.tolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'portScanToggle
        '
        Me.portScanToggle.BackColor = System.Drawing.Color.Gray
        Me.portScanToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.portScanToggle.ForeColor = System.Drawing.SystemColors.Control
        Me.portScanToggle.Location = New System.Drawing.Point(12, 39)
        Me.portScanToggle.Name = "portScanToggle"
        Me.portScanToggle.Size = New System.Drawing.Size(384, 23)
        Me.portScanToggle.TabIndex = 8
        Me.portScanToggle.Text = "Start Port Scan"
        Me.portScanToggle.UseVisualStyleBackColor = False
        '
        'portScanProgress
        '
        Me.portScanProgress.AutoSize = True
        Me.portScanProgress.Location = New System.Drawing.Point(13, 66)
        Me.portScanProgress.Name = "portScanProgress"
        Me.portScanProgress.Size = New System.Drawing.Size(101, 13)
        Me.portScanProgress.TabIndex = 9
        Me.portScanProgress.Text = "Please Start a Scan"
        '
        'PortScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 296)
        Me.Controls.Add(Me.portScanProgress)
        Me.Controls.Add(Me.portScanToggle)
        Me.Controls.Add(Me.tolbl)
        Me.Controls.Add(Me.portEndRange)
        Me.Controls.Add(Me.portStartRange)
        Me.Controls.Add(Me.portRangeBtn)
        Me.Controls.Add(Me.commonPortsBtn)
        Me.Controls.Add(Me.portScanDisplay)
        Me.Name = "PortScan"
        Me.ShowIcon = False
        Me.Text = "PortScan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents portScanDisplay As ListBox
    Friend WithEvents commonPortsBtn As RadioButton
    Friend WithEvents portRangeBtn As RadioButton
    Friend WithEvents portStartRange As TextBox
    Friend WithEvents portEndRange As TextBox
    Friend WithEvents tolbl As Label
    Friend WithEvents portScanToggle As Button
    Friend WithEvents portScanProgress As Label
End Class
