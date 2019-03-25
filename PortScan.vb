Imports System.Net
Imports System.Net.Sockets

Public Class PortScan
    Private isScanning As Boolean = False
    Private ipScanList As Collection = New Collection
    Private scanThread As Threading.Thread = Nothing

    Public Sub setIpList(list As Collection)
        ipScanList = list

        For Each ip In list
            portScanDisplay.Items.Add(ip)
        Next
    End Sub

    Private Function listOfStringToString(list As Collection) As String
        Dim returnResult As String = ""
        For Each item In list
            returnResult += (item.ToString() + " ")
        Next
        Return returnResult
    End Function

    Private Sub ScanCommonPortsOnIp(ip As String)
        ' Scan common ports for the ip
        Dim commonPorts = {20, 21, 22, 23, 25, 69, 80, 110, 137, 138, 139, 445}
        Dim openPorts As Collection = New Collection

        For Each port In commonPorts
            If Not isScanning Then
                Exit For
            End If
            Invoke(Sub()
                       portScanProgress.Text = "Checking " + ip + ":" + port.ToString()
                   End Sub)
            Dim Socket As TcpClient = New TcpClient()
            Try
                Dim connectAsync = Socket.BeginConnect(ip, port, Nothing, Nothing)
                Dim didConnect As Boolean = connectAsync.AsyncWaitHandle.WaitOne(500)
                If (didConnect) Then
                    openPorts.Add(port)
                    Socket.Close()
                End If
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        Next

        Invoke(Sub()
                   Dim spotOnList = portScanDisplay.Items.IndexOf(ip)
                   portScanDisplay.Items.Remove(ip)
                   portScanDisplay.Items.Insert(spotOnList, ip + " has ports " + listOfStringToString(openPorts) + " open")
               End Sub)

        Console.WriteLine("{0} total open ports on {1}", openPorts.Count, ip)
    End Sub

    Private Sub ScanRangePortsOnIp(ip As String, min As Integer, max As Integer)
        ' Scan a range of ports for the ip
        Dim openPorts As Collection = New Collection

        For i As Integer = min To max Step 1
            If Not isScanning Then
                Exit For
            End If
            Dim port = i
            Invoke(Sub()
                       portScanProgress.Text = "Checking " + ip + ":" + port.ToString()
                   End Sub)
            Dim Socket As TcpClient = New TcpClient()
            Try
                Dim connectAsync = Socket.BeginConnect(ip, port, Nothing, Nothing)
                Dim didConnect As Boolean = connectAsync.AsyncWaitHandle.WaitOne(500)
                If (didConnect) Then
                    openPorts.Add(port)
                    Socket.Close()
                End If
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        Next

        Invoke(Sub()
                   Dim spotOnList = portScanDisplay.Items.IndexOf(ip)
                   portScanDisplay.Items.Remove(ip)
                   portScanDisplay.Items.Insert(spotOnList, ip + " has ports " + listOfStringToString(openPorts) + " open")
               End Sub)

        Console.WriteLine("{0} total open ports on {1}", openPorts.Count, ip)
    End Sub

    Private Sub BeginPortScan()
        If ipScanList.Count.Equals(1) Then
            ' Only scan this one ip
            If commonPortsBtn.Checked Then
                ScanCommonPortsOnIp(ipScanList.Item(1))
            Else
                ScanRangePortsOnIp(ipScanList.Item(1), Integer.Parse(portStartRange.Text), Integer.Parse(portEndRange.Text))
            End If
        Else
            ' For loop to iterate all ips which will be scanned
            If commonPortsBtn.Checked Then
                For Each ip In ipScanList
                    ScanCommonPortsOnIp(ip)
                Next
            Else
                For Each ip In ipScanList
                    ScanRangePortsOnIp(ip, Integer.Parse(portStartRange.Text), Integer.Parse(portEndRange.Text))
                Next
            End If
        End If
        Invoke(Sub()
                   MessageBox.Show("Finished port scanning")
                   isScanning = False
                   portScanToggle.Text = "Start Port Scan"
                   portScanProgress.Text = "Finished a scan"
               End Sub)
    End Sub

    Private Sub portScanToggle_Click(sender As Object, e As EventArgs) Handles portScanToggle.Click
        If Not commonPortsBtn.Checked And Not portRangeBtn.Checked Then
            MessageBox.Show("You must choose common ports or range")
            Return
        End If

        If Not isScanning Then
            isScanning = True
            portScanToggle.Text = "Stop Port Scan"
            portScanDisplay.Items.Clear()
            setIpList(ipScanList)
            scanThread = New Threading.Thread(AddressOf BeginPortScan)
            scanThread.IsBackground = True
            scanThread.Start()
        Else
            isScanning = False
            scanThread = Nothing
            portScanToggle.Text = "Start Port Scan"
        End If
    End Sub
End Class