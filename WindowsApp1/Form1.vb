Imports System.IO.Ports

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each AvailableSerialPorts As String In SerialPort.GetPortNames()
            ComboBox1.Items.Add(AvailableSerialPorts)
            ComboBox1.Text = AvailableSerialPorts

            SerialPort1.ReadTimeout = 2000
        Next
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False

        TextBox1.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.BaudRate = "2204"
        SerialPort1.PortName = ComboBox1.SelectedItem

        Timer1.Enabled = True

        If SerialPort1.IsOpen = False Then
            SerialPort1.Open()
            MsgBox("Connected succesfully!")
            Button1.Visible = False
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = True
            Button10.Visible = True
            Button11.Visible = True
            Button12.Visible = True
            Button13.Visible = True
            Button14.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
            MsgBox("Disconnected succesfully!")
        End If

        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False

        Timer1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Bila+")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Bila-")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Bila")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Bile3")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Bile5")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Bile10")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Rof+")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Rof-")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Rof20")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Rof30")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Rof40")
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine("Rof50")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SerialPort1.IsOpen = True Then

            Dim ReceivedMessage As String
            ReceivedMessage = SerialPort1.ReadExisting
            If ReceivedMessage.Length > 0 Then
                TextBox1.Text = TextBox1.Text + ReceivedMessage + Environment.NewLine

                TextBox1.SelectionStart = TextBox1.MaxLength
                TextBox1.ScrollToCaret()
            End If
        End If
    End Sub
End Class
