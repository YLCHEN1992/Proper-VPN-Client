<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.HexTheme1 = New VPN_Connector.HexTheme()
        Me.dcnct = New VPN_Connector.HexButton()
        Me.cnct = New VPN_Connector.HexButton()
        Me.pswrd = New VPN_Connector.HexTextBox()
        Me.usrname = New VPN_Connector.HexTextBox()
        Me.host = New VPN_Connector.HexTextBox()
        Me.HexClose1 = New VPN_Connector.HexClose()
        Me.HexTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HexTheme1
        '
        Me.HexTheme1.Controls.Add(Me.dcnct)
        Me.HexTheme1.Controls.Add(Me.cnct)
        Me.HexTheme1.Controls.Add(Me.pswrd)
        Me.HexTheme1.Controls.Add(Me.usrname)
        Me.HexTheme1.Controls.Add(Me.host)
        Me.HexTheme1.Controls.Add(Me.HexClose1)
        Me.HexTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexTheme1.Location = New System.Drawing.Point(0, 0)
        Me.HexTheme1.Name = "HexTheme1"
        Me.HexTheme1.Size = New System.Drawing.Size(284, 241)
        Me.HexTheme1.TabIndex = 0
        Me.HexTheme1.Text = "Connect To Server"
        '
        'dcnct
        '
        Me.dcnct.Location = New System.Drawing.Point(169, 187)
        Me.dcnct.Name = "dcnct"
        Me.dcnct.Size = New System.Drawing.Size(93, 30)
        Me.dcnct.TabIndex = 25
        Me.dcnct.Text = "Disconnect"
        '
        'cnct
        '
        Me.cnct.Location = New System.Drawing.Point(22, 187)
        Me.cnct.Name = "cnct"
        Me.cnct.Size = New System.Drawing.Size(77, 30)
        Me.cnct.TabIndex = 24
        Me.cnct.Text = "Connect"
        '
        'pswrd
        '
        Me.pswrd.BackColor = System.Drawing.Color.Transparent
        Me.pswrd.Location = New System.Drawing.Point(22, 141)
        Me.pswrd.MaxLength = 32767
        Me.pswrd.Multiline = False
        Me.pswrd.Name = "pswrd"
        Me.pswrd.ReadOnly = False
        Me.pswrd.Size = New System.Drawing.Size(240, 27)
        Me.pswrd.TabIndex = 23
        Me.pswrd.Text = "Password"
        Me.pswrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.pswrd.UseSystemPasswordChar = False
        '
        'usrname
        '
        Me.usrname.BackColor = System.Drawing.Color.Transparent
        Me.usrname.Location = New System.Drawing.Point(22, 97)
        Me.usrname.MaxLength = 32767
        Me.usrname.Multiline = False
        Me.usrname.Name = "usrname"
        Me.usrname.ReadOnly = False
        Me.usrname.Size = New System.Drawing.Size(240, 27)
        Me.usrname.TabIndex = 22
        Me.usrname.Text = "Username"
        Me.usrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.usrname.UseSystemPasswordChar = False
        '
        'host
        '
        Me.host.BackColor = System.Drawing.Color.Transparent
        Me.host.Location = New System.Drawing.Point(22, 53)
        Me.host.MaxLength = 32767
        Me.host.Multiline = False
        Me.host.Name = "host"
        Me.host.ReadOnly = False
        Me.host.Size = New System.Drawing.Size(240, 27)
        Me.host.TabIndex = 21
        Me.host.Text = "Hostname"
        Me.host.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.host.UseSystemPasswordChar = False
        '
        'HexClose1
        '
        Me.HexClose1.Location = New System.Drawing.Point(272, 3)
        Me.HexClose1.Name = "HexClose1"
        Me.HexClose1.Size = New System.Drawing.Size(12, 12)
        Me.HexClose1.TabIndex = 0
        Me.HexClose1.Text = "HexClose1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 241)
        Me.Controls.Add(Me.HexTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connect to server"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.HexTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HexTheme1 As HexTheme
    Friend WithEvents HexClose1 As HexClose
    Friend WithEvents pswrd As HexTextBox
    Friend WithEvents usrname As HexTextBox
    Friend WithEvents host As HexTextBox
    Friend WithEvents dcnct As HexButton
    Friend WithEvents cnct As HexButton
End Class
