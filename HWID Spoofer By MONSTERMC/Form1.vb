Imports System.Net
Imports System.IO
Imports System.Threading
Imports System.Text
Imports System.Management
Imports Microsoft.Win32
Public Class Form1

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "spoofer Mad By MONSTERMC test Telegram:@MONSTERMC"
        Button1.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownloadFiles()
    End Sub
#Region "Checker"
    Private Sub btnGetBIOSInfo_Click(sender As Object, e As EventArgs) Handles btnGetBIOSInfo.Click
        Dim info As String = GetBIOSInfo()
        txtBIOSInfo.Text = info
    End Sub

    Private Sub btnGetRAMInfo_Click(sender As Object, e As EventArgs) Handles btnGetRAMInfo.Click
        Dim info As String = GetRAMInfo()
        txtRAMInfo.Text = info
    End Sub

    Private Sub btnGetNetworkAdapterInfo_Click(sender As Object, e As EventArgs) Handles btnGetNetworkAdapterInfo.Click
        Dim info As String = GetNetworkAdapterInfo()
        txtNetworkAdapterInfo.Text = info
    End Sub

    Private Sub btnGetGPUInfo_Click(sender As Object, e As EventArgs) Handles btnGetGPUInfo.Click
        Dim info As String = GetGPUInfo()
        txtGPUInfo.Text = info
    End Sub

    Private Sub btnGetCPUInfo_Click(sender As Object, e As EventArgs) Handles btnGetCPUInfo.Click
        Dim info As String = GetCPUInfo()
        txtCPUInfo.Text = info
    End Sub

    Private Sub btnGetHDDInfo_Click(sender As Object, e As EventArgs) Handles btnGetHDDInfo.Click
        Dim info As String = GetHDDInfo()
        txtHDDInfo.Text = info
    End Sub
    Private Sub btnGetMotherboardInfo_Click_1(sender As Object, e As EventArgs) Handles btnGetMotherboardInfo.Click
        Dim info As String = GetMotherboardInfo()
        txtMotherboardInfo.Text = info
    End Sub
    Private Function GetMotherboardInfo() As String
        Dim info As New StringBuilder()

        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BaseBoard")
        For Each queryObj As ManagementObject In searcher.Get()
            info.AppendLine("Product: " & queryObj("Product"))
            info.AppendLine("Manufacturer: " & queryObj("Manufacturer"))
            info.AppendLine("Serial Number: " & queryObj("SerialNumber"))
        Next

        Return info.ToString()
    End Function

    Private Function GetBIOSInfo() As String
        Dim info As New StringBuilder()

        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BIOS")
        For Each queryObj As ManagementObject In searcher.Get()
            info.AppendLine("BIOS Manufacturer: " & queryObj("Manufacturer"))
            info.AppendLine("BIOS Serial Number: " & queryObj("SerialNumber"))
            info.AppendLine("BIOS Version: " & queryObj("Version"))
            info.AppendLine("SMBIOS Version: " & queryObj("SMBIOSBIOSVersion"))
            info.AppendLine("Release Date: " & queryObj("ReleaseDate"))
        Next

        Return info.ToString()
    End Function

    Private Function GetRAMInfo() As String
        Dim info As New StringBuilder()

        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_PhysicalMemory")
        For Each queryObj As ManagementObject In searcher.Get()
            info.AppendLine("Part Number: " & queryObj("PartNumber"))
            info.AppendLine("Serial Number: " & queryObj("SerialNumber"))
            info.AppendLine("SKU: " & queryObj("SKU"))
        Next

        Return info.ToString()
    End Function

    Private Function GetNetworkAdapterInfo() As String
        Dim info As New StringBuilder()

        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_NetworkAdapter")
        For Each queryObj As ManagementObject In searcher.Get()
            info.AppendLine("MAC Address: " & queryObj("MACAddress"))
            info.AppendLine("Description: " & queryObj("Description"))
        Next

        Return info.ToString()
    End Function

    Private Function GetGPUInfo() As String
        Dim info As New StringBuilder()

        ' يمكنك استخدام استعلامات WMI للحصول على معلومات عن بطاقة الرسومات هنا

        Return info.ToString()
    End Function

    Private Function GetCPUInfo() As String
        Dim info As New StringBuilder()

        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")
        For Each queryObj As ManagementObject In searcher.Get()
            info.AppendLine("Caption: " & queryObj("Caption"))
            info.AppendLine("Processor ID: " & queryObj("ProcessorID"))
            info.AppendLine("Socket Designation: " & queryObj("SocketDesignation"))
            info.AppendLine("Name: " & queryObj("Name"))
        Next

        Return info.ToString()
    End Function

    Private Function GetHDDInfo() As String
        Dim info As New StringBuilder()

        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")
        For Each queryObj As ManagementObject In searcher.Get()
            info.AppendLine("Model: " & queryObj("Model"))
            info.AppendLine("Serial Number: " & queryObj("SerialNumber"))
            info.AppendLine("Name: " & queryObj("Name"))
        Next

        Return info.ToString()
    End Function
#End Region
#Region "Via Reg"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ExecuteCommandsViaReg()
    End Sub
    Private Sub ExecuteCommandsViaReg()
        Dim commands As String() = {
            "REG ADD HKLM\SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName /v ComputerName /t REG_SZ /d MonStErmC-%random% /f",
            "REG ADD HKLM\SYSTEM\CurrentControlSet\Control\ComputerName\ActiveComputerName /v ComputerName /t REG_SZ /d MonStErmC-%random% /f",
            "REG ADD HKLM\SYSTEM\HardwareConfig /v LastConfig /t REG_SZ /d {eac%random%} /f",
            "REG ADD HKLM\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware\Profiles\0001 /v HwProfileGuid /t REG_SZ /d {MonStErmC-%random%-%random%-%random%-%random%} /f",
            "REG ADD HKLM\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware\Profiles\0001 /v GUID /t REG_SZ /d {MonStErmC-%random%-%random%-%random%-%random%} /f",
            "REG ADD HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion /v BuildGUID /t REG_SZ /d MonStErmC-%random% /f",
            "REG ADD HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion /v RegisteredOwner /t REG_SZ /d MonStErmC-%random% /f",
            "REG ADD HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion /v RegisteredOrganization /t REG_SZ /d MonStErmC-%random% /f",
            "REG ADD HKLM\SOFTWARE\Microsoft\Cryptography /v GUID /t REG_SZ /d MonStErmC-%random%-%random%-%random%-%random% /f",
            "REG ADD HKLM\SOFTWARE\Microsoft\Cryptography /v MachineGuid /t REG_SZ /d MonStErmC-%random%-%random%-%random%-%random% /f",
            "REG ADD HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion /v ProductId /t REG_SZ /d %random%-%random%-%random%-%random% /f",
            "REG ADD HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion /v InstallDate /t REG_SZ /d %random% /f",
            "REG ADD HKLM\SYSTEM\CurrentControlSet\Control\SystemInformation /v ComputerHardwareId /t REG_SZ /d {%random%-%random%-%random%-%random%} /f",
            "REG ADD HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography /v MachineGuid /t REG_SZ /d %Hex8%-%Hex1%-%Hex0%-%Hex1%-%Hex10% /f",
            "REG ADD HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion /v BuildGUID /t REG_SZ /d %Hex8%-%Hex1%-%Hex0%-%Hex1%-%Hex10% /f",
            "REG ADD HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e967-e325-11ce-bfc1-08002be10318}\Configuration\Variables\BusDeviceDesc /v PropertyGuid /t REG_SZ /d {%Hex8%-%Hex1%-%Hex0%-%Hex1%-%Hex10%} /f",
            "REG ADD HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\Configuration\Variables\DeviceDesc /v PropertyGuid /t REG_SZ /d {%Hex8%-%Hex1%-%Hex0%-%Hex1%-%Hex10%} /f",
            "REG ADD HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\Configuration\Variables\Driver /v PropertyGuid /t REG_SZ /d {%Hex8%-%Hex1%-%Hex0%-%Hex1%-%Hex10%} /f",
            "REG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\SystemInformation /v ComputerHardwareId /t REG_SZ /d {%Hex8%-%Hex1%-%Hex0%-%Hex1%-%Hex10%} /f",
            "REG ADD HKLM\Software\Microsoft\Windows NT\CurrentVersion /v InstallDate /t REG_SZ /d %random% /f",
            "REG ADD HKLM\Software\Microsoft\Windows NT\CurrentVersion /v ProductId /t REG_SZ /d %random% /f",
            "REG ADD HKLM\System\CurrentControlSet\Control\SystemInformation /v ComputerHardwareId /t REG_SZ /d %random% /f",
            "REG ADD HKLM\System\CurrentControlSet\Control\WMI\Security /v 671a8285-4edb-4cae-99fe-69a15c48c0bc /t REG_SZ /d %random% /f",
            "REG ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate /v SusClientId /t REG_SZ /d {MonStErmC-%random%-%random%-%random%-%random%} /f",
            "sc stop winmgmt",
            "sc start winmgmt",
            "ipconfig /flushdns"
        }

        For Each command As String In commands
            ExecuteCommand(command)
        Next
        Button1.Enabled = True
    End Sub

    Private Sub ExecuteCommand(ByVal command As String)
        Try
            Dim processInfo As New ProcessStartInfo()
            processInfo.FileName = "cmd.exe"
            processInfo.Arguments = "/c " & command
            processInfo.WindowStyle = ProcessWindowStyle.Hidden
            processInfo.CreateNoWindow = True
            Dim process As New Process()
            process.StartInfo = processInfo
            process.Start()
            process.WaitForExit()
        Catch ex As Exception
            MessageBox.Show("Error executing command: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
    ' باقي الأوامر

    Private Sub DownloadFiles()
        Try
            Directory.CreateDirectory("C:\MONSTERMC.syFreePS")

            Dim webClient As New WebClient()
            webClient.DownloadFile("https://github.com/boxakosidk/files-for-woofer/raw/main/AMIDEWIN.EXE", "C:\MONSTERMC.syFreePS\AMIDEWIN.EXE")
            webClient.DownloadFile("https://github.com/boxakosidk/files-for-woofer/raw/main/AMIDEWINx64.EXE", "C:\MONSTERMC.syFreePS\AMIDEWINx64.EXE")
            webClient.DownloadFile("https://github.com/boxakosidk/files-for-woofer/raw/main/AMIFLDRV64.SYS", "C:\MONSTERMC.syFreePS\AMIFLDRV64.SYS")
            webClient.DownloadFile("https://github.com/boxakosidk/files-for-woofer/raw/main/Volumeid64.exe", "C:\MONSTERMC.syFreePS\Volumeid64.exe")

            MessageBox.Show("Files downloaded successfully.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            SpoofVolumeID()
        Catch ex As Exception
            MessageBox.Show("Error downloading files: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SpoofVolumeID()
        Try
            Dim rand As New Random()
            Dim rand1 As Integer = rand.Next(1000, 9999)
            Dim rand2 As Integer = rand.Next(1000, 9999)

            Dim drives As String() = {"c:", "d:", "e:", "f:", "b:", "j:", "i:", "g:", "x:"}

            For Each drive As String In drives
                Dim process As New Process()
                process.StartInfo.FileName = "C:\MONSTERMC.syFreePS\Volumeid64.exe"
                process.StartInfo.Arguments = drive & " " & rand1 & "-" & rand2 & " /accepteula"
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                process.Start()
                Thread.Sleep(3000)
            Next

            MessageBox.Show("Volume IDs spoofed successfully.", "Spoofing Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            SpoofBIOS()
        Catch ex As Exception
            MessageBox.Show("Error spoofing volume IDs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SpoofBIOS()
        Try
            Dim processes As String() = {
                "/BS " & GetRandomSerial(),
                "/SS " & GetRandomSerial(),
                "/SV " & GetRandomSerial(),
                "/SU AUTO",
                "/SK " & GetRandomSerial(),
                "/BM " & GetRandomSerial(),
                "/BV " & GetRandomSerial()
            }

            For Each processArgs As String In processes
                Dim process As New Process()
                process.StartInfo.FileName = "C:\MONSTERMC.syFreePS\AMIDEWIN.EXE"
                process.StartInfo.Arguments = processArgs
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                process.Start()
                Thread.Sleep(3000)
            Next

            MessageBox.Show("BIOS serials spoofed successfully.", "Spoofing Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clean up
            Directory.Delete("C:\MONSTERMC.syFreePS", True)

            MessageBox.Show("Application completed its tasks successfully.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Shutdown()
        Catch ex As Exception
            MessageBox.Show("Error spoofing BIOS serials: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetRandomSerial() As String
        Dim rand As New Random()
        Return rand.Next(1000, 9999) & "u-" & rand.Next()
    End Function

    Private Sub Shutdown()
        MessageBox.Show("The system will restart in 10 seconds.", "Restarting", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Process.Start("shutdown", "/r /t 10")
    End Sub
End Class
