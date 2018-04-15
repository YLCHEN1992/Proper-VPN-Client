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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.HexTheme1 = New VPN_Connector.HexTheme()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.HexCheckBox2 = New VPN_Connector.HexCheckBox()
        Me.HexCheckBox1 = New VPN_Connector.HexCheckBox()
        Me.HexMini2 = New VPN_Connector.HexMini()
        Me.HexClose2 = New VPN_Connector.HexClose()
        Me.pswrd = New VPN_Connector.HexTextBox()
        Me.usrname = New VPN_Connector.HexTextBox()
        Me.host = New VPN_Connector.HexTextBox()
        Me.dcnct = New VPN_Connector.HexButton()
        Me.cnct = New VPN_Connector.HexButton()
        Me.HexClose1 = New VPN_Connector.HexClose()
        Me.HexMini1 = New VPN_Connector.HexMini()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HexTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-171, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PPTP VPN CONNECTOR"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'HexTheme1
        '
        Me.HexTheme1.BackColor = System.Drawing.Color.White
        Me.HexTheme1.Controls.Add(Me.Label4)
        Me.HexTheme1.Controls.Add(Me.label6)
        Me.HexTheme1.Controls.Add(Me.TextBox1)
        Me.HexTheme1.Controls.Add(Me.HexCheckBox2)
        Me.HexTheme1.Controls.Add(Me.HexCheckBox1)
        Me.HexTheme1.Controls.Add(Me.HexMini2)
        Me.HexTheme1.Controls.Add(Me.HexClose2)
        Me.HexTheme1.Controls.Add(Me.pswrd)
        Me.HexTheme1.Controls.Add(Me.usrname)
        Me.HexTheme1.Controls.Add(Me.host)
        Me.HexTheme1.Controls.Add(Me.dcnct)
        Me.HexTheme1.Controls.Add(Me.cnct)
        Me.HexTheme1.Controls.Add(Me.HexClose1)
        Me.HexTheme1.Controls.Add(Me.HexMini1)
        Me.HexTheme1.Controls.Add(Me.Label3)
        Me.HexTheme1.Controls.Add(Me.Label2)
        Me.HexTheme1.Controls.Add(Me.Label5)
        Me.HexTheme1.Controls.Add(Me.PictureBox1)
        Me.HexTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexTheme1.ForeColor = System.Drawing.Color.White
        Me.HexTheme1.Location = New System.Drawing.Point(0, 0)
        Me.HexTheme1.Name = "HexTheme1"
        Me.HexTheme1.Size = New System.Drawing.Size(293, 223)
        Me.HexTheme1.TabIndex = 14
        Me.HexTheme1.Text = "Proper Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(298, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Seconds"
        Me.Label4.Visible = False
        '
        'label6
        '
        Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.label6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(0, 79)
        Me.label6.Name = "label6"
        Me.label6.ReadOnly = True
        Me.label6.Size = New System.Drawing.Size(293, 15)
        Me.label6.TabIndex = 26
        Me.label6.Text = "The Free Client"
        Me.label6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(293, 23)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.Text = "Proper VPN"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HexCheckBox2
        '
        Me.HexCheckBox2.Checked = False
        Me.HexCheckBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexCheckBox2.Location = New System.Drawing.Point(140, 206)
        Me.HexCheckBox2.Name = "HexCheckBox2"
        Me.HexCheckBox2.Size = New System.Drawing.Size(152, 16)
        Me.HexCheckBox2.TabIndex = 24
        Me.HexCheckBox2.Text = "Connect To Custom VPN"
        '
        'HexCheckBox1
        '
        Me.HexCheckBox1.Checked = True
        Me.HexCheckBox1.Location = New System.Drawing.Point(310, 248)
        Me.HexCheckBox1.Name = "HexCheckBox1"
        Me.HexCheckBox1.Size = New System.Drawing.Size(95, 16)
        Me.HexCheckBox1.TabIndex = 23
        Me.HexCheckBox1.Text = "Use proper decided server"
        '
        'HexMini2
        '
        Me.HexMini2.Location = New System.Drawing.Point(258, 10)
        Me.HexMini2.Name = "HexMini2"
        Me.HexMini2.Size = New System.Drawing.Size(12, 12)
        Me.HexMini2.TabIndex = 22
        Me.HexMini2.Text = "HexMini2"
        '
        'HexClose2
        '
        Me.HexClose2.Location = New System.Drawing.Point(276, 10)
        Me.HexClose2.Name = "HexClose2"
        Me.HexClose2.Size = New System.Drawing.Size(12, 12)
        Me.HexClose2.TabIndex = 21
        Me.HexClose2.Text = "HexClose2"
        '
        'pswrd
        '
        Me.pswrd.BackColor = System.Drawing.Color.Transparent
        Me.pswrd.Enabled = False
        Me.pswrd.Location = New System.Drawing.Point(299, 196)
        Me.pswrd.MaxLength = 32767
        Me.pswrd.Multiline = False
        Me.pswrd.Name = "pswrd"
        Me.pswrd.ReadOnly = False
        Me.pswrd.Size = New System.Drawing.Size(181, 27)
        Me.pswrd.TabIndex = 20
        Me.pswrd.Text = "Password"
        Me.pswrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.pswrd.UseSystemPasswordChar = False
        '
        'usrname
        '
        Me.usrname.BackColor = System.Drawing.Color.Transparent
        Me.usrname.Enabled = False
        Me.usrname.Location = New System.Drawing.Point(299, 152)
        Me.usrname.MaxLength = 32767
        Me.usrname.Multiline = False
        Me.usrname.Name = "usrname"
        Me.usrname.ReadOnly = False
        Me.usrname.Size = New System.Drawing.Size(181, 27)
        Me.usrname.TabIndex = 19
        Me.usrname.Text = "Username"
        Me.usrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.usrname.UseSystemPasswordChar = False
        '
        'host
        '
        Me.host.BackColor = System.Drawing.Color.Transparent
        Me.host.Enabled = False
        Me.host.Location = New System.Drawing.Point(299, 108)
        Me.host.MaxLength = 32767
        Me.host.Multiline = False
        Me.host.Name = "host"
        Me.host.ReadOnly = False
        Me.host.Size = New System.Drawing.Size(181, 27)
        Me.host.TabIndex = 18
        Me.host.Text = "Hostname"
        Me.host.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.host.UseSystemPasswordChar = False
        '
        'dcnct
        '
        Me.dcnct.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dcnct.ForeColor = System.Drawing.Color.White
        Me.dcnct.Location = New System.Drawing.Point(73, 117)
        Me.dcnct.Name = "dcnct"
        Me.dcnct.Size = New System.Drawing.Size(150, 48)
        Me.dcnct.TabIndex = 17
        Me.dcnct.Text = "Disconnect"
        Me.dcnct.Visible = False
        '
        'cnct
        '
        Me.cnct.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnct.ForeColor = System.Drawing.Color.White
        Me.cnct.Location = New System.Drawing.Point(73, 117)
        Me.cnct.Name = "cnct"
        Me.cnct.Size = New System.Drawing.Size(150, 48)
        Me.cnct.TabIndex = 16
        Me.cnct.Text = "Connect"
        '
        'HexClose1
        '
        Me.HexClose1.Location = New System.Drawing.Point(524, 9)
        Me.HexClose1.Name = "HexClose1"
        Me.HexClose1.Size = New System.Drawing.Size(12, 12)
        Me.HexClose1.TabIndex = 15
        Me.HexClose1.Text = "HexClose1"
        '
        'HexMini1
        '
        Me.HexMini1.Location = New System.Drawing.Point(512, 6)
        Me.HexMini1.Name = "HexMini1"
        Me.HexMini1.Size = New System.Drawing.Size(12, 12)
        Me.HexMini1.TabIndex = 14
        Me.HexMini1.Text = "HexMini1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Unable to resolve IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "IP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(289, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Not Connected"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-33, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(293, 223)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HexTheme1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proper PPTP - VPN Client"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.HexTheme1.ResumeLayout(False)
        Me.HexTheme1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HexTheme1 As HexTheme
    Friend WithEvents pswrd As HexTextBox
    Friend WithEvents usrname As HexTextBox
    Friend WithEvents host As HexTextBox
    Friend WithEvents dcnct As HexButton
    Friend WithEvents cnct As HexButton
    Friend WithEvents HexClose1 As HexClose
    Friend WithEvents HexMini1 As HexMini
    Friend WithEvents HexMini2 As HexMini
    Friend WithEvents HexClose2 As HexClose
    Friend WithEvents HexCheckBox1 As HexCheckBox
    Friend WithEvents HexCheckBox2 As HexCheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents label6 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer2 As Timer
End Class
