Public Class Form1

    Dim contador As Integer = 0
    Dim segundos As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Modo Normal")
        ComboBox1.Items.Add("Bonus x2")
        ComboBox1.Items.Add("Bonus x3")
        ComboBox1.SelectedIndex = 0

        Timer1.Start()

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Sumar_Click(sender As Object, e As EventArgs) Handles Sumar.Click
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Modo Normal"
                contador += 1
                PictureBox3.Image = Nothing

            Case "Bonus x2"
                contador += 2
                PictureBox3.Image = My.Resources.x2

            Case "Bonus x3"
                contador += 3
                PictureBox3.Image = My.Resources.x3
        End Select

        Label1.Text = contador
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        segundos += 1
        Dim minutos As Integer = segundos / 60
        Dim seg As Integer = segundos Mod 60

        Label4.Text = minutos.ToString("00") & ":" & seg.ToString("00")
    End Sub
End Class
