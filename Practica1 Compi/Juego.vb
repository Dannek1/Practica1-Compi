Imports System.Drawing

Public Class Juego

    Dim tablero As Graphics
    Dim Imagen As Image = Image.FromFile(LFondos.Aux.fondo)
    Dim Lapiz As Pen
    Dim Logica(10, 10) As String
    Dim x, y As Integer

    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tablero = PictureBox1.CreateGraphics
        PictureBox1.Image = Imagen
        x = 0
        y = 0

        For x = 0 To 9
            For y = 0 To 9

                Logica(x, y) = "s"

            Next
        Next
        x = 0
        y = 0
        Timer1.Start()



    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lapiz = New Pen(Brushes.Black, 10)

        'cuadricula 10x10, cuadros de 60 *40



    End Sub
End Class