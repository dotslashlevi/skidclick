Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SkidClick
    Dim rnd As New Random

    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles MinValBar.Scroll
        Label1.Text = MinValBar.Value
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles MaxValBar.Scroll
        Label2.Text = MaxValBar.Value
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Start.Click
        Timer1.Start()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Stop2_Click(sender As Object, e As EventArgs) Handles Stop2.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()

        Dim minval As Integer

        Dim maxval As Integer

        maxval = 1000 / MaxValBar.Value

        minval = 1000 / MinValBar.Value



        Timer1.Interval = Rnd.Next(maxval, minval)

        If MouseButtons = MouseButtons.Left Then

            mouse_event(&H4, 0, 0, 0, 0)

            mouse_event(&H2, 0, 0, 0, 0)

        End If
    End Sub
End Class
