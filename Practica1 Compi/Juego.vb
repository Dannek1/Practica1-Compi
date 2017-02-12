Imports System.Drawing

Public Class Juego

    Dim tablero As Graphics
    Dim Fondo As Image = Image.FromFile(LFondos.Aux.fondo)
    Dim Nave As Image = Image.FromFile(LNaves.Aux.Rnave)
    Dim DisparoN As Image = Image.FromFile(LNaves.Aux.Rdisparo)

    Dim Lapiz As Pen
    Dim Logica(10, 10) As String
    Dim Info(10, 10) As Integer
    Dim x, y, posx As Integer
    Dim pausa As Boolean = False


    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tablero = PictureBox1.CreateGraphics
        PictureBox1.Image = Fondo
        My.Computer.Audio.Play(LFondos.Aux.musica, AudioPlayMode.BackgroundLoop)

        x = 0
        y = 0
        posx = 0

        For x = 0 To 9
            For y = 0 To 9

                Logica(x, y) = "0"
                Info(x, y) = 0

            Next
        Next

        Logica(posx, 9) = "x"

        x = 0
        y = 0
        Timer1.Start()



    End Sub

    Private Sub Juego_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyData = Keys.Right) Then
            If (posx < 9) Then
                Logica(posx, 9) = "0"
                posx = posx + 1
                Logica(posx, 9) = "x"
            End If
        ElseIf (e.KeyData = Keys.Left) Then
            If (posx > 0) Then
                Logica(posx, 9) = "0"
                posx = posx - 1
                Logica(posx, 9) = "x"
            End If
        ElseIf (e.KeyData = Keys.Space) Then
            Logica(posx, 8) = "d"
            tablero.DrawImage(DisparoN, (posx * 60), (8 * 40), 60, 40)
            My.Computer.Audio.Play(LNaves.Aux.RSonido, AudioPlayMode.Background)

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        PictureBox1.Refresh()

        Lapiz = New Pen(Brushes.Black, 10)

        'cuadricula 10x10, cuadros de 60 *40
        For x = 0 To 9
            For y = 0 To 9

                If (Logica(x, y).Equals("x")) Then
                    tablero.DrawImage(Nave, (x * 60), (y * 40), 60, 40)
                ElseIf (Logica(x, y).Equals("d")) Then
                    Logica(x, y) = "0"
                    tablero.DrawImage(DisparoN, (x * 60), (y * 40), 60, 40)
                    If (y <> 0) Then
                        Logica(x, y - 1) = "d"
                    End If

                End If


            Next
        Next

    End Sub
End Class