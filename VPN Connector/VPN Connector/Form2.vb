Imports System.Net

Public Class Form2
    Private Sub dcnct_Click(sender As Object, e As EventArgs) Handles dcnct.Click
        'Label6.Text = "Disconnecting..."
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
            '   Timer1.Enabled = False
            Try
                Dim strin As String = New WebClient().DownloadString(("http://api.ipify.org/"))

                MsgBox(strin)
                '    Label6.Text = "Not Connected"
            Catch ex As Exception

            End Try
            cnct.Visible = True
            dcnct.Visible = False
            Application.Restart()

        End If
    End Sub

    Private Sub cnct_Click(sender As Object, e As EventArgs) Handles cnct.Click

        'Label6.Text = "Connecting..."
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

            ' starttime = Now
            ' Timer1.Enabled = True

            Dim strin As String = New WebClient().DownloadString(("http://api.ipify.org/"))

            ' Label3.Text = strin


            'Label6.Text = "Connected"
            cnct.Visible = False
            dcnct.Visible = True
            MsgBox(strin)
        Else
            ' Label6.Text = "Failed To Connect!"

        End If





        ' End If
    End Sub

    Private Sub HexClose1_Click(sender As Object, e As EventArgs) Handles HexClose1.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class