Public Class Form1
    Dim ScannerThread As Threading.Thread
    Dim ScannerIsActive As Boolean = False
    Dim FoundIpList As Collection = New Collection
    Dim IpListStrings As Collection = New Collection
    Dim PortScannerWindow As PortScan = Nothing

    Public Function GetNameFromIp(addr As String)
        Dim Host As System.Net.IPHostEntry
        Try
            Host = System.Net.Dns.GetHostEntry(addr)
            Return Host.HostName
        Catch ex As Exception
            Console.WriteLine(ex)
            Return "INVALID"
        End Try


    End Function

    Public Function GetLocalIp()
        Dim HostName As String = System.Net.Dns.GetHostName()
        Dim LocalAddr As String = System.Net.Dns.GetHostEntry(HostName).AddressList(1).ToString()
        Return LocalAddr
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IpDisplay.Text = GetLocalIp()
        HostDisplay.Text = GetNameFromIp(GetLocalIp())
    End Sub

    Private Sub ScanNetwork()
        Dim localAddr As String = GetLocalIp()
        Dim scanningBaseAddr As String = localAddr.Substring(0, localAddr.LastIndexOf(".") + 1)
        Dim currentScanningSuffix As Integer = 0 'Set to 150 for testing

        While (currentScanningSuffix <= 255 And ScannerIsActive)
            Dim currentAddr As String = scanningBaseAddr + currentScanningSuffix.ToString()

            Invoke(Sub()
                       scanProgress.Text = "Checking " + currentAddr + "..."
                   End Sub)

            If My.Computer.Network.Ping(currentAddr, 200) Then
                Invoke(Sub()
                           ipListBox.Items.Add(currentAddr + " - " + GetNameFromIp(currentAddr))
                           IpListStrings.Add(currentAddr + " - " + GetNameFromIp(currentAddr))
                       End Sub)
                FoundIpList.Add(currentAddr)
            End If
            currentScanningSuffix += 1
        End While

        If ScannerIsActive Then
            Console.WriteLine("Scanner Thread Finished")
            Invoke(Sub()
                       scanProgress.Text = "Found " + FoundIpList.Count.ToString() + " LAN IPs"
                       StartNetworkScan.Text = "Scan Local Network"
                       BringToFront()
                       MessageBox.Show("Finished Scan, found " + FoundIpList.Count.ToString() + " ips")
                   End Sub)
            ScannerIsActive = False
            ScannerThread = Nothing
        End If
    End Sub

    Private Sub StartNetworkScan_Click(sender As Object, e As EventArgs) Handles StartNetworkScan.Click
        If ScannerThread IsNot Nothing Then
            Console.WriteLine("Halting scanner Thread")
            ScannerIsActive = False
            scanProgress.Text = "Found " + FoundIpList.Count.ToString() + " LAN IPs"
            ScannerThread = Nothing
            StartNetworkScan.Text = "Scan Local Network"
        Else
            ScannerIsActive = True
            FoundIpList = New Collection
            ipListBox.Items.Clear()
            Console.WriteLine("Starting scanner thread")
            ScannerThread = New Threading.Thread(AddressOf ScanNetwork)
            ScannerThread.IsBackground = True
            ScannerThread.Start()
            StartNetworkScan.Text = "Stop Scanning"
        End If
    End Sub

    Private Sub portScanSelect_Click(sender As Object, e As EventArgs) Handles portScanSelect.Click
        If FoundIpList.Count <= 0 Then
            MessageBox.Show("No IPs to scan")
        Else
            If PortScannerWindow IsNot Nothing Then
                PortScannerWindow.Close()
                PortScannerWindow = Nothing
            Else
                PortScannerWindow = New PortScan
                Dim tmpIpList = New Collection
                tmpIpList.Add(parseIpString(ipListBox.SelectedItem))
                PortScannerWindow.setIpList(tmpIpList)
                PortScannerWindow.Show()
            End If
        End If
    End Sub

    Private Sub portScanAll_Click(sender As Object, e As EventArgs) Handles portScanAll.Click
        If FoundIpList.Count <= 0 Then
            MessageBox.Show("No IPs to scan")
        Else
            If PortScannerWindow IsNot Nothing Then
                PortScannerWindow.Close()
                PortScannerWindow = Nothing
            Else
                PortScannerWindow = New PortScan
                Dim tmpIpList = New Collection
                For Each item In ipListBox.Items
                    tmpIpList.Add(parseIpString(item))
                Next
                PortScannerWindow.setIpList(tmpIpList)
                PortScannerWindow.Show()
            End If
        End If
    End Sub

    Private Function parseIpString(str As String)
        Return str.Substring(0, str.IndexOf("-") - 1)
    End Function

    Private Sub shutdownSelect_Click(sender As Object, e As EventArgs) Handles shutdownSelect.Click
        If FoundIpList.Count <= 0 Then
            Return
        End If
        Dim targetToShutdown = parseIpString(ipListBox.SelectedItem)
        If targetToShutdown.Equals(GetLocalIp()) Then
            Dim shouldShutdown = MessageBox.Show("You're about to shut yourself down", "Wait", MessageBoxButtons.YesNo)
            If shouldShutdown.Equals(DialogResult.No) Then
                Return
            End If
        End If
        Console.WriteLine("shutting down " & targetToShutdown)
        Dim shutdownProcess = Process.Start("shutdown", "/s /m \\" & targetToShutdown)
        shutdownProcess.WaitForExit()
        If shutdownProcess.ExitCode <> 0 Then
            Console.WriteLine("Shutdown Error: " & shutdownProcess.ExitCode)
        End If
    End Sub

    Private Sub setListBoxItems(target As ListBox, arr As Collection)
        For Each v In arr
            target.Items.Add(v)
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        Dim matchingIps = 0
        ipListBox.Items.Clear()
        For Each ipstr As String In IpListStrings
            If ipstr.Contains(searchBox.Text.ToUpper()) Then
                matchingIps += 1
                ipListBox.Items.Add(ipstr)
            End If
        Next
        If matchingIps < 1 Then
            MessageBox.Show("No Matching Clients")
            setListBoxItems(ipListBox, IpListStrings)
        End If
    End Sub
End Class
