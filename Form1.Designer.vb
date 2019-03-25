<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.StartNetworkScan = New System.Windows.Forms.Button()
        Me.IpDisplay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ipListBox = New System.Windows.Forms.ListBox()
        Me.scanProgress = New System.Windows.Forms.Label()
        Me.portScanSelect = New System.Windows.Forms.Button()
        Me.portScanAll = New System.Windows.Forms.Button()
        Me.HostDisplayLbl = New System.Windows.Forms.Label()
        Me.HostDisplay = New System.Windows.Forms.Label()
        Me.shutdownSelect = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StartNetworkScan
        '
        Me.StartNetworkScan.BackColor = System.Drawing.Color.Gray
        Me.StartNetworkScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartNetworkScan.ForeColor = System.Drawing.SystemColors.Control
        Me.StartNetworkScan.Location = New System.Drawing.Point(442, 3)
        Me.StartNetworkScan.Name = "StartNetworkScan"
        Me.StartNetworkScan.Size = New System.Drawing.Size(121, 23)
        Me.StartNetworkScan.TabIndex = 0
        Me.StartNetworkScan.Text = "Scan Local Network"
        Me.StartNetworkScan.UseVisualStyleBackColor = False
        '
        'IpDisplay
        '
        Me.IpDisplay.AutoSize = True
        Me.IpDisplay.Location = New System.Drawing.Point(70, 9)
        Me.IpDisplay.Name = "IpDisplay"
        Me.IpDisplay.Size = New System.Drawing.Size(39, 13)
        Me.IpDisplay.TabIndex = 1
        Me.IpDisplay.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your IPv4: "
        '
        'ipListBox
        '
        Me.ipListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ipListBox.FormattingEnabled = True
        Me.ipListBox.Location = New System.Drawing.Point(16, 75)
        Me.ipListBox.Name = "ipListBox"
        Me.ipListBox.Size = New System.Drawing.Size(547, 368)
        Me.ipListBox.TabIndex = 3
        '
        'scanProgress
        '
        Me.scanProgress.AutoSize = True
        Me.scanProgress.Location = New System.Drawing.Point(16, 56)
        Me.scanProgress.Name = "scanProgress"
        Me.scanProgress.Size = New System.Drawing.Size(75, 13)
        Me.scanProgress.TabIndex = 4
        Me.scanProgress.Text = "Not Scaning..."
        '
        'portScanSelect
        '
        Me.portScanSelect.BackColor = System.Drawing.Color.Gray
        Me.portScanSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.portScanSelect.ForeColor = System.Drawing.SystemColors.Control
        Me.portScanSelect.Location = New System.Drawing.Point(452, 46)
        Me.portScanSelect.Name = "portScanSelect"
        Me.portScanSelect.Size = New System.Drawing.Size(111, 23)
        Me.portScanSelect.TabIndex = 5
        Me.portScanSelect.Text = "Port Scan Selected"
        Me.portScanSelect.UseVisualStyleBackColor = False
        '
        'portScanAll
        '
        Me.portScanAll.BackColor = System.Drawing.Color.Gray
        Me.portScanAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.portScanAll.ForeColor = System.Drawing.SystemColors.Control
        Me.portScanAll.Location = New System.Drawing.Point(336, 3)
        Me.portScanAll.Name = "portScanAll"
        Me.portScanAll.Size = New System.Drawing.Size(100, 23)
        Me.portScanAll.TabIndex = 6
        Me.portScanAll.Text = "Port Scan All"
        Me.portScanAll.UseVisualStyleBackColor = False
        '
        'HostDisplayLbl
        '
        Me.HostDisplayLbl.AutoSize = True
        Me.HostDisplayLbl.Location = New System.Drawing.Point(13, 24)
        Me.HostDisplayLbl.Name = "HostDisplayLbl"
        Me.HostDisplayLbl.Size = New System.Drawing.Size(91, 13)
        Me.HostDisplayLbl.TabIndex = 7
        Me.HostDisplayLbl.Text = "Your Host Name: "
        '
        'HostDisplay
        '
        Me.HostDisplay.AutoSize = True
        Me.HostDisplay.Location = New System.Drawing.Point(106, 24)
        Me.HostDisplay.Name = "HostDisplay"
        Me.HostDisplay.Size = New System.Drawing.Size(39, 13)
        Me.HostDisplay.TabIndex = 8
        Me.HostDisplay.Text = "Label2"
        '
        'shutdownSelect
        '
        Me.shutdownSelect.BackColor = System.Drawing.Color.Gray
        Me.shutdownSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.shutdownSelect.ForeColor = System.Drawing.SystemColors.Control
        Me.shutdownSelect.Location = New System.Drawing.Point(334, 46)
        Me.shutdownSelect.Name = "shutdownSelect"
        Me.shutdownSelect.Size = New System.Drawing.Size(112, 23)
        Me.shutdownSelect.TabIndex = 9
        Me.shutdownSelect.Text = "Shutdown Selected"
        Me.shutdownSelect.UseVisualStyleBackColor = False
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(209, 46)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(119, 20)
        Me.searchBox.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(575, 459)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.shutdownSelect)
        Me.Controls.Add(Me.HostDisplay)
        Me.Controls.Add(Me.HostDisplayLbl)
        Me.Controls.Add(Me.portScanAll)
        Me.Controls.Add(Me.portScanSelect)
        Me.Controls.Add(Me.scanProgress)
        Me.Controls.Add(Me.ipListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IpDisplay)
        Me.Controls.Add(Me.StartNetworkScan)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(591, 497)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "LAN Scan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartNetworkScan As Button
    Friend WithEvents IpDisplay As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ipListBox As ListBox
    Friend WithEvents scanProgress As Label
    Friend WithEvents portScanSelect As Button
    Friend WithEvents portScanAll As Button
    Friend WithEvents HostDisplayLbl As Label
    Friend WithEvents HostDisplay As Label
    Friend WithEvents shutdownSelect As Button
    Friend WithEvents searchBox As TextBox
End Class