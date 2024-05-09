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
        Me.btnGetBIOSInfo = New System.Windows.Forms.Button()
        Me.btnGetRAMInfo = New System.Windows.Forms.Button()
        Me.btnGetNetworkAdapterInfo = New System.Windows.Forms.Button()
        Me.btnGetGPUInfo = New System.Windows.Forms.Button()
        Me.btnGetCPUInfo = New System.Windows.Forms.Button()
        Me.btnGetHDDInfo = New System.Windows.Forms.Button()
        Me.btnGetMotherboardInfo = New System.Windows.Forms.Button()
        Me.txtBIOSInfo = New System.Windows.Forms.TextBox()
        Me.txtRAMInfo = New System.Windows.Forms.TextBox()
        Me.txtNetworkAdapterInfo = New System.Windows.Forms.TextBox()
        Me.txtGPUInfo = New System.Windows.Forms.TextBox()
        Me.txtCPUInfo = New System.Windows.Forms.TextBox()
        Me.txtHDDInfo = New System.Windows.Forms.TextBox()
        Me.txtMotherboardInfo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGetBIOSInfo
        '
        Me.btnGetBIOSInfo.Location = New System.Drawing.Point(12, 12)
        Me.btnGetBIOSInfo.Name = "btnGetBIOSInfo"
        Me.btnGetBIOSInfo.Size = New System.Drawing.Size(146, 23)
        Me.btnGetBIOSInfo.TabIndex = 0
        Me.btnGetBIOSInfo.Text = "btnGetBIOSInfo"
        Me.btnGetBIOSInfo.UseVisualStyleBackColor = True
        '
        'btnGetRAMInfo
        '
        Me.btnGetRAMInfo.Location = New System.Drawing.Point(164, 12)
        Me.btnGetRAMInfo.Name = "btnGetRAMInfo"
        Me.btnGetRAMInfo.Size = New System.Drawing.Size(146, 23)
        Me.btnGetRAMInfo.TabIndex = 1
        Me.btnGetRAMInfo.Text = "btnGetRAMInfo"
        Me.btnGetRAMInfo.UseVisualStyleBackColor = True
        '
        'btnGetNetworkAdapterInfo
        '
        Me.btnGetNetworkAdapterInfo.Location = New System.Drawing.Point(316, 12)
        Me.btnGetNetworkAdapterInfo.Name = "btnGetNetworkAdapterInfo"
        Me.btnGetNetworkAdapterInfo.Size = New System.Drawing.Size(188, 23)
        Me.btnGetNetworkAdapterInfo.TabIndex = 2
        Me.btnGetNetworkAdapterInfo.Text = "btnGetNetworkAdapterInfo"
        Me.btnGetNetworkAdapterInfo.UseVisualStyleBackColor = True
        '
        'btnGetGPUInfo
        '
        Me.btnGetGPUInfo.Location = New System.Drawing.Point(510, 12)
        Me.btnGetGPUInfo.Name = "btnGetGPUInfo"
        Me.btnGetGPUInfo.Size = New System.Drawing.Size(146, 23)
        Me.btnGetGPUInfo.TabIndex = 3
        Me.btnGetGPUInfo.Text = "btnGetGPUInfo"
        Me.btnGetGPUInfo.UseVisualStyleBackColor = True
        '
        'btnGetCPUInfo
        '
        Me.btnGetCPUInfo.Location = New System.Drawing.Point(12, 41)
        Me.btnGetCPUInfo.Name = "btnGetCPUInfo"
        Me.btnGetCPUInfo.Size = New System.Drawing.Size(146, 23)
        Me.btnGetCPUInfo.TabIndex = 4
        Me.btnGetCPUInfo.Text = "btnGetCPUInfo"
        Me.btnGetCPUInfo.UseVisualStyleBackColor = True
        '
        'btnGetHDDInfo
        '
        Me.btnGetHDDInfo.Location = New System.Drawing.Point(164, 41)
        Me.btnGetHDDInfo.Name = "btnGetHDDInfo"
        Me.btnGetHDDInfo.Size = New System.Drawing.Size(146, 23)
        Me.btnGetHDDInfo.TabIndex = 5
        Me.btnGetHDDInfo.Text = "btnGetHDDInfo"
        Me.btnGetHDDInfo.UseVisualStyleBackColor = True
        '
        'btnGetMotherboardInfo
        '
        Me.btnGetMotherboardInfo.Location = New System.Drawing.Point(316, 41)
        Me.btnGetMotherboardInfo.Name = "btnGetMotherboardInfo"
        Me.btnGetMotherboardInfo.Size = New System.Drawing.Size(146, 23)
        Me.btnGetMotherboardInfo.TabIndex = 6
        Me.btnGetMotherboardInfo.Text = "btnGetMotherboardInfo"
        Me.btnGetMotherboardInfo.UseVisualStyleBackColor = True
        '
        'txtBIOSInfo
        '
        Me.txtBIOSInfo.Location = New System.Drawing.Point(12, 70)
        Me.txtBIOSInfo.Name = "txtBIOSInfo"
        Me.txtBIOSInfo.Size = New System.Drawing.Size(146, 20)
        Me.txtBIOSInfo.TabIndex = 7
        '
        'txtRAMInfo
        '
        Me.txtRAMInfo.Location = New System.Drawing.Point(164, 70)
        Me.txtRAMInfo.Name = "txtRAMInfo"
        Me.txtRAMInfo.Size = New System.Drawing.Size(146, 20)
        Me.txtRAMInfo.TabIndex = 8
        '
        'txtNetworkAdapterInfo
        '
        Me.txtNetworkAdapterInfo.Location = New System.Drawing.Point(316, 70)
        Me.txtNetworkAdapterInfo.Name = "txtNetworkAdapterInfo"
        Me.txtNetworkAdapterInfo.Size = New System.Drawing.Size(188, 20)
        Me.txtNetworkAdapterInfo.TabIndex = 9
        '
        'txtGPUInfo
        '
        Me.txtGPUInfo.Location = New System.Drawing.Point(510, 70)
        Me.txtGPUInfo.Name = "txtGPUInfo"
        Me.txtGPUInfo.Size = New System.Drawing.Size(146, 20)
        Me.txtGPUInfo.TabIndex = 10
        '
        'txtCPUInfo
        '
        Me.txtCPUInfo.Location = New System.Drawing.Point(12, 96)
        Me.txtCPUInfo.Name = "txtCPUInfo"
        Me.txtCPUInfo.Size = New System.Drawing.Size(146, 20)
        Me.txtCPUInfo.TabIndex = 11
        '
        'txtHDDInfo
        '
        Me.txtHDDInfo.Location = New System.Drawing.Point(164, 96)
        Me.txtHDDInfo.Name = "txtHDDInfo"
        Me.txtHDDInfo.Size = New System.Drawing.Size(146, 20)
        Me.txtHDDInfo.TabIndex = 12
        '
        'txtMotherboardInfo
        '
        Me.txtMotherboardInfo.Location = New System.Drawing.Point(316, 96)
        Me.txtMotherboardInfo.Name = "txtMotherboardInfo"
        Me.txtMotherboardInfo.Size = New System.Drawing.Size(120, 20)
        Me.txtMotherboardInfo.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(442, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 20)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Start Spoof Using UFI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(567, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 20)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Spoof Via Reg"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 126)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMotherboardInfo)
        Me.Controls.Add(Me.txtHDDInfo)
        Me.Controls.Add(Me.txtCPUInfo)
        Me.Controls.Add(Me.txtGPUInfo)
        Me.Controls.Add(Me.txtNetworkAdapterInfo)
        Me.Controls.Add(Me.txtRAMInfo)
        Me.Controls.Add(Me.txtBIOSInfo)
        Me.Controls.Add(Me.btnGetMotherboardInfo)
        Me.Controls.Add(Me.btnGetHDDInfo)
        Me.Controls.Add(Me.btnGetCPUInfo)
        Me.Controls.Add(Me.btnGetGPUInfo)
        Me.Controls.Add(Me.btnGetNetworkAdapterInfo)
        Me.Controls.Add(Me.btnGetRAMInfo)
        Me.Controls.Add(Me.btnGetBIOSInfo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGetBIOSInfo As Button
    Friend WithEvents btnGetRAMInfo As Button
    Friend WithEvents btnGetNetworkAdapterInfo As Button
    Friend WithEvents btnGetGPUInfo As Button
    Friend WithEvents btnGetCPUInfo As Button
    Friend WithEvents btnGetHDDInfo As Button
    Friend WithEvents btnGetMotherboardInfo As Button
    Friend WithEvents txtBIOSInfo As TextBox
    Friend WithEvents txtRAMInfo As TextBox
    Friend WithEvents txtNetworkAdapterInfo As TextBox
    Friend WithEvents txtGPUInfo As TextBox
    Friend WithEvents txtCPUInfo As TextBox
    Friend WithEvents txtHDDInfo As TextBox
    Friend WithEvents txtMotherboardInfo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
