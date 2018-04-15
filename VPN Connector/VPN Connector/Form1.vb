Imports System.Net

Public Class Form1

    Dim starttime As DateTime
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub dcnct_Click(sender As Object, e As EventArgs)
        Label6.Text = "Disconnecting..."
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"), "rasdial/d")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Minimized


        connect.Start()
        connect.WaitForExit()
        Do Until connect.HasExited
            Application.DoEvents()

        Loop
        If connect.HasExited Then
            Timer1.Enabled = False
            Try
                Dim strin As String = New WebClient().DownloadString(("http://api.ipify.org/"))

                Label3.Text = strin
                Label6.Text = "Not Connected"
            Catch ex As Exception

            End Try
            cnct.Visible = True
            dcnct.Visible = False
            Application.Restart()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        label6.Text = "Connected for " & DateDiff(DateInterval.Second, starttime, Now) & " seconds"

    End Sub

    Private Sub pswrd_TextChanged(sender As Object, e As EventArgs)
        If pswrd.Text = "Password" Then
            pswrd.UseSystemPasswordChar = False
        Else
            If Not pswrd.Text = "Passsword" Then
                pswrd.UseSystemPasswordChar = True
            Else
                pswrd.UseSystemPasswordChar = False

            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim x As Integer
        Dim y As Integer

        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        Try
            Dim strin As String = New WebClient().DownloadString(("http://api.ipify.org/"))
            Label3.Text = strin
        Catch ex As Exception
        End Try


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub HexTheme1_Click(sender As Object, e As EventArgs) Handles HexTheme1.Click

    End Sub
    Public Sub retunactions()
        Try
            Dim strin As String = New WebClient().DownloadString(("http://api.ipify.org/"))

            Label3.Text = strin
        Catch ex As Exception
            Label3.Text = "Unable to resolve IP. Trying Again..."
            Try
                Dim strin As String = New WebClient().DownloadString(("http://api.ipify.org/"))

                Label3.Text = strin
            Catch ex678 As Exception
                Label3.Text = "Failed to resolve IP Address"
            End Try
        End Try
        starttime = Now
        Timer1.Enabled = True



        TextBox1.Text = "Proper VPN"
        label6.Text = "Connected"
        cnct.Visible = False
        dcnct.Visible = True
        MsgBox("You are currently connected to: " + Label3.Text)

    End Sub
    Private Sub cnct_Click(sender As Object, e As EventArgs) Handles cnct.Click
        If HexCheckBox1.Checked = True Then




            Label6.Text = "Connecting To Proper VPN..."
            If Not IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector") Then

                IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector")


            End If


            IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk"), "[VPN]" & vbNewLine & "MEDIA=rastapi" & vbNewLine & "Port=VPN2-0" & vbNewLine & "Device=WAN Miniport (IKEv2)" & vbNewLine & "DEVICE=vpn" & vbNewLine & "PhoneNumber=us1.sshagan.us")
            IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"), "rasdial ""VPN"" " & "sshagan" & " " & "abcd1234" & " /phonebook:" & """" & System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk" & """")


            Dim connect As System.Diagnostics.Process
            connect = New System.Diagnostics.Process()
            connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"
            connect.StartInfo.WindowStyle = ProcessWindowStyle.Minimized


            connect.Start()


            Do Until connect.HasExited = True
                Application.DoEvents()
                TextBox1.Text = "Connecting"
                label6.Text = "Free users wait 30 seconds..."
            Loop
            Application.DoEvents()
            retunactions()



        Else



            Label6.Text = "Connecting..."
        If Not IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector") Then

            IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector")


        End If


        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk"), "[VPN]" & vbNewLine & "MEDIA=rastapi" & vbNewLine & "Port=VPN2-0" & vbNewLine & "Device=WAN Miniport (IKEv2)" & vbNewLine & "DEVICE=vpn" & vbNewLine & "PhoneNumber=" & host.Text)
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"), "rasdial ""VPN"" " & usrname.Text & " " & pswrd.Text & " /phonebook:" & """" & System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk" & """")


        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Minimized


        connect.Start()
        connect.WaitForExit()

        If connect.HasExited Then

            starttime = Now
            Timer1.Enabled = True

            Dim strin As String = New WebClient().DownloadString(("http://api.ipify.org/"))

            Label3.Text = strin


            Label6.Text = "Connected"
                cnct.Visible = False
                dcnct.Visible = True
                MsgBox("You are currently connected to: " + Label3.Text)
            Else
            Label6.Text = "Failed To Connect!"

        End If





         End If

    End Sub

    Private Sub dcnct_Click_1(sender As Object, e As EventArgs) Handles dcnct.Click
        Label6.Text = "Disconnecting..."
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"), "rasdial/d")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Minimized


        connect.Start()
        connect.WaitForExit()
        Do Until connect.HasExited
            Application.DoEvents()

        Loop
        If connect.HasExited Then
            Timer1.Enabled = False
            Try
                Dim strin As String = New WebClient().DownloadString(("http://api.ipify.org/"))

                Label3.Text = strin
                Label6.Text = "Not Connected"
            Catch ex As Exception

            End Try
            cnct.Visible = True
            dcnct.Visible = False
            Application.Restart()

        End If
    End Sub

    Private Sub HexCheckBox1_CheckedChanged(sender As Object) Handles HexCheckBox1.CheckedChanged
        If HexCheckBox1.Checked = True Then
            usrname.Enabled = False
            host.Enabled = False
            pswrd.Enabled = False
        Else
            If HexCheckBox1.Checked = False Then
                Form2.Show()

            Else
                usrname.Enabled = False
                host.Enabled = False
                pswrd.Enabled = False
            End If
        End If
    End Sub

    Private Sub HexClose2_Click(sender As Object, e As EventArgs) Handles HexClose2.Click
        Label6.Text = "Disconnecting..."
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"), "rasdial/d")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Minimized


        connect.Start()
        connect.WaitForExit()
        Do Until connect.HasExited
            Application.DoEvents()

        Loop
        If connect.HasExited Then
            Timer1.Enabled = False
            Try
                Dim strin As String = New WebClient().DownloadString(("http://api.ipify.org/"))

                Label3.Text = strin
                Label6.Text = "Not Connected"
            Catch ex As Exception

            End Try
            cnct.Enabled = True
            dcnct.Enabled = False
            Application.Exit()


        End If
    End Sub

    Private Sub HexCheckBox2_CheckedChanged(sender As Object) Handles HexCheckBox2.CheckedChanged
        If HexCheckBox2.Checked = True Then
            Form2.Show()
        Else
            Form2.Hide()

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        Label4.Text = DateDiff(DateInterval.Second, starttime, Now) & " seconds"


    End Sub
End Class
