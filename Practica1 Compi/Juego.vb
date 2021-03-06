﻿Imports System.Drawing

Public Class Juego

    Dim tablero As Graphics
    Dim Fondo As Image = Image.FromFile(LFondos.Aux.fondo)
    Dim Nave As Image = Image.FromFile(LNaves.Aux.Rnave)
    Dim DisparoN As Image = Image.FromFile(LNaves.Aux.Rdisparo)
    Dim Defensa As Image = Image.FromFile(LDefendas.Aux.imagen)
    Dim Lapiz As Pen
    Dim Logica(10, 10) As String
    Dim Evida(10, 10) As Integer
    Dim x, y, posx, vida, puntos, contador As Integer
    Dim pausa As Boolean = False
    Dim numAleatorio As New Random()
    Dim pivote As Integer
    Dim Salidas As Integer = 0
    Dim Enemigos(Frecuencia) As Integer
    Dim IEnemigos(Correlativo) As Image
    Dim DEnemigos(Correlativo) As Image

    Dim Tiempo, Esquivados, Destruidos As Integer




    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tablero = PictureBox1.CreateGraphics
        PictureBox1.Image = Fondo
        My.Computer.Audio.Play(LFondos.Aux.musica, AudioPlayMode.BackgroundLoop)
        vida = LNaves.Aux.vida
        puntos = 0
        contador = 1

        Tiempo = 0
        Esquivados = 0
        Destruidos = 0

        TextBox1.Text = vida
        TextBox2.Text = puntos
        TextBox2.Text = Tiempo

        x = 0
        y = 0
        posx = 0

        For x = 0 To 9
            For y = 0 To 9

                Logica(x, y) = "0"
                Evida(x, y) = 0

            Next
        Next

        Logica(0, 7) = "M"
        Logica(2, 7) = "M"
        Logica(4, 7) = "M"
        Logica(6, 7) = "M"
        Logica(8, 7) = "M"

        Evida(0, 7) = LDefendas.Aux.defensa
        Evida(2, 7) = LDefendas.Aux.defensa
        Evida(4, 7) = LDefendas.Aux.defensa
        Evida(6, 7) = LDefendas.Aux.defensa
        Evida(8, 7) = LDefendas.Aux.defensa

        Logica(posx, 9) = "x"

        x = 0
        y = 0

        CargarImagenes()
        Llenar_Correlativo()
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
        Dim mov As Boolean = False

        PictureBox1.Refresh()

        Lapiz = New Pen(Brushes.Black, 10)

        If (vida <= 0) Then
            Salida()

        End If

        'cuadricula 10x10, cuadros de 60 *40
        For x = 0 To 9
            For y = 0 To 9

                If (Logica(x, y).Equals("x")) Then
                    tablero.DrawImage(Nave, (x * 60), (y * 40), 60, 40)

                ElseIf (Logica(x, y).Equals("M")) Then
                    tablero.DrawImage(Defensa, (x * 60), (y * 40), 60, 40)

                ElseIf (Logica(x, y).Equals("d")) Then
                    If Not ((Logica(x, y - 1).Equals("0") Or Logica(x, y - 1).Equals("M")) And y <> 1) Then
                        If (Logica(x, y - 1).Equals("d")) Then
                            Logica(x, y) = "0"
                            tablero.DrawImage(DisparoN, (x * 60), (y * 40), 60, 40)
                            If (y <> 0) Then
                                Logica(x, y - 1) = "d"
                            End If

                        End If

                    ElseIf (Logica(x, y - 1).Equals("M")) Then
                        Evida(x, y - 1) = Evida(x, y - 1) - LNaves.Aux.ataque
                        Logica(x, y) = "0"

                        If (Evida(x, y - 1) <= 0) Then
                            Evida(x, y - 1) = 0
                            Logica(x, y - 1) = "0"

                        End If
                    Else
                        Logica(x, y) = "0"
                        tablero.DrawImage(DisparoN, (x * 60), (y * 40), 60, 40)
                        If (y <> 0) Then
                            Logica(x, y - 1) = "d"
                        End If
                    End If







                End If
            Next
        Next

        For x = 0 To 9
            For y = 9 To 0 Step -1
                If ((Logica(x, y) <> "0")) Then
                    If Not (Logica(x, y).Equals("x") Or Logica(x, y).Equals("d") Or Logica(x, y).Equals("M") Or Char.IsNumber(Logica(x, y).Chars(0))) Then
                        pivote = BuscarEnemigo(Logica(x, y))
                        tablero.DrawImage(IEnemigos(pivote - 1), (x * 60), (y * 40), 60, 40)
                        If (y <> 9) Then
                            If (Logica(x, y + 1).Equals("x")) Then
                                vida = vida - LEnemigos.Aux.ataque
                                Logica(x, y) = "0"
                                Evida(x, y) = 0
                                TextBox1.Text = vida
                            ElseIf (Logica(x, y + 1).Equals("d")) Then
                                Evida(x, y) = Evida(x, y) - LNaves.Aux.ataque
                                Logica(x, y + 1) = "0"

                                If (Evida(x, y) <= 0) Then
                                    Logica(x, y) = "0"
                                    puntos = puntos + LEnemigos.Aux.punteo
                                    Destruidos = Destruidos + 1
                                    TextBox2.Text = puntos

                                Else
                                    If (LEnemigos.Aux.velocidad = 10 And Evida(x, y + 1) <> 0) Then
                                        Logica(x, y + 1) = Logica(x, y)
                                        Evida(x, y + 1) = Evida(x, y)
                                        Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                        My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                        mov = True

                                    ElseIf (LEnemigos.Aux.velocidad = 9 And ((contador Mod 2) = 0)) Then
                                        Logica(x, y + 1) = Logica(x, y)
                                        Evida(x, y + 1) = Evida(x, y)
                                        Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                        My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                        mov = True
                                    ElseIf (LEnemigos.Aux.velocidad = 8 And ((contador Mod 3) = 0)) Then
                                        Logica(x, y + 1) = Logica(x, y)
                                        Evida(x, y + 1) = Evida(x, y)
                                        Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                        My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                        mov = True
                                    ElseIf (LEnemigos.Aux.velocidad = 7 And ((contador Mod 4) = 0)) Then
                                        Logica(x, y + 1) = Logica(x, y)
                                        Evida(x, y + 1) = Evida(x, y)
                                        Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                        My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                        mov = True
                                    ElseIf (LEnemigos.Aux.velocidad = 6 And ((contador Mod 5) = 0)) Then
                                        Logica(x, y + 1) = Logica(x, y)
                                        Evida(x, y + 1) = Evida(x, y)
                                        Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                        My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                        mov = True
                                    ElseIf (LEnemigos.Aux.velocidad = 5 And ((contador Mod 6) = 0)) Then
                                        Logica(x, y + 1) = Logica(x, y)
                                        Evida(x, y + 1) = Evida(x, y)
                                        Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                        My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                        mov = True
                                    ElseIf (LEnemigos.Aux.velocidad = 4 And ((contador Mod 7) = 0)) Then
                                        Logica(x, y + 1) = Logica(x, y)
                                        Evida(x, y + 1) = Evida(x, y)
                                        Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                        My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                        mov = True
                                    ElseIf (LEnemigos.Aux.velocidad = 3 And ((contador Mod 8) = 0)) Then
                                        Logica(x, y + 1) = Logica(x, y)
                                        Evida(x, y + 1) = Evida(x, y)
                                        Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                        My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                        mov = True
                                    ElseIf (LEnemigos.Aux.velocidad = 2 And ((contador Mod 9) = 0)) Then
                                        Logica(x, y + 1) = Logica(x, y)
                                        Evida(x, y + 1) = Evida(x, y)
                                        Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                        My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                        mov = True
                                    ElseIf (LEnemigos.Aux.velocidad = 1 And ((contador Mod 10) = 0)) Then

                                        Logica(x, y + 1) = Logica(x, y)
                                        Evida(x, y + 1) = Evida(x, y)
                                        Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                        My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                        mov = True

                                    End If
                                End If

                            ElseIf (Logica(x, y + 1).Equals("M")) Then
                                Evida(x, y + 1) = Evida(x, y + 1) - LEnemigos.Aux.ataque

                                If (Evida(x, y + 1) <= 0) Then
                                    Evida(x, y + 1) = 0
                                    Logica(x, y + 1) = "0"

                                End If

                                Evida(x, y) = 0
                                Logica(x, y) = "0"


                            Else

                                If (LEnemigos.Aux.velocidad = 10 And Evida(x, y + 1) <> 0) Then
                                    Logica(x, y + 1) = Logica(x, y)
                                    Evida(x, y + 1) = Evida(x, y)
                                    Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                    My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                    mov = True

                                ElseIf (LEnemigos.Aux.velocidad = 9 And ((contador Mod 2) = 0)) Then
                                    Logica(x, y + 1) = Logica(x, y)
                                    Evida(x, y + 1) = Evida(x, y)
                                    Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                    My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                    mov = True
                                ElseIf (LEnemigos.Aux.velocidad = 8 And ((contador Mod 3) = 0)) Then
                                    Logica(x, y + 1) = Logica(x, y)
                                    Evida(x, y + 1) = Evida(x, y)
                                    Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                    My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                    mov = True
                                ElseIf (LEnemigos.Aux.velocidad = 7 And ((contador Mod 4) = 0)) Then
                                    Logica(x, y + 1) = Logica(x, y)
                                    Evida(x, y + 1) = Evida(x, y)
                                    Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                    My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                    mov = True
                                ElseIf (LEnemigos.Aux.velocidad = 6 And ((contador Mod 5) = 0)) Then
                                    Logica(x, y + 1) = Logica(x, y)
                                    Evida(x, y + 1) = Evida(x, y)
                                    Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                    My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                    mov = True
                                ElseIf (LEnemigos.Aux.velocidad = 5 And ((contador Mod 6) = 0)) Then
                                    Logica(x, y + 1) = Logica(x, y)
                                    Evida(x, y + 1) = Evida(x, y)
                                    Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                    My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                    mov = True
                                ElseIf (LEnemigos.Aux.velocidad = 4 And ((contador Mod 7) = 0)) Then
                                    Logica(x, y + 1) = Logica(x, y)
                                    Evida(x, y + 1) = Evida(x, y)
                                    Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                    My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                    mov = True
                                ElseIf (LEnemigos.Aux.velocidad = 3 And ((contador Mod 8) = 0)) Then
                                    Logica(x, y + 1) = Logica(x, y)
                                    Evida(x, y + 1) = Evida(x, y)
                                    Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                    My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                    mov = True
                                ElseIf (LEnemigos.Aux.velocidad = 2 And ((contador Mod 9) = 0)) Then
                                    Logica(x, y + 1) = Logica(x, y)
                                    Evida(x, y + 1) = Evida(x, y)
                                    Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                    My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                    mov = True
                                ElseIf (LEnemigos.Aux.velocidad = 1 And ((contador Mod 10) = 0)) Then

                                    Logica(x, y + 1) = Logica(x, y)
                                    Evida(x, y + 1) = Evida(x, y)
                                    Logica(x, y + 2) = LEnemigos.Aux.Correlativo
                                    My.Computer.Audio.Play(LEnemigos.Aux.Rsonido, AudioPlayMode.Background)
                                    mov = True

                                End If


                            End If



                        ElseIf (y = 9) Then
                            Esquivados = Esquivados + 1
                        End If
                        If (mov) Then
                            Logica(x, y) = "0"
                            Evida(x, y) = 0
                        End If


                    ElseIf (Char.IsNumber(Logica(x, y).Chars(0))) Then
                        Try
                            pivote = BuscarEnemigo(Integer.Parse(Logica(x, y)))
                            tablero.DrawImage(DEnemigos(pivote - 1), (x * 60), (y * 40), 60, 40)
                            If (Logica(x, y + 1).Equals("M")) Then
                                Evida(x, y + 1) = Evida(x, y + 1) - LEnemigos.Aux.ataque

                                If (Evida(x, y + 1) <= 0) Then
                                    Evida(x, y + 1) = 0
                                    Logica(x, y + 1) = "0"

                                End If

                                Evida(x, y) = 0
                                Logica(x, y) = "0"

                            ElseIf (Logica(x, y + 1).Equals("x")) Then
                                Logica(x, y) = "0"
                                vida = vida - LEnemigos.Aux.ataque
                                TextBox1.Text = vida



                            Else
                                Logica(x, y + 1) = Logica(x, y)
                                Logica(x, y) = "0"
                            End If
                        Catch ex As Exception
                            Logica(x, y) = "0"
                        End Try



                    End If



                    End If

            Next
        Next

        If (Salidas = 20) Then
            Try
                Dim Lugar = numAleatorio.Next(0, 9)
                If (Logica(Lugar, 0).Equals("0")) Then
                    Nuevo_Enemigo()
                    Logica(Lugar, 0) = BuscarEnemigo()
                    Evida(Lugar, 0) = LEnemigos.Aux.vida
                    tablero.DrawImage(IEnemigos(Enemigos(pivote) - 1), (Lugar * 60), 0, 60, 40)

                End If
            Catch ex As Exception

            End Try
            Salidas = 0


        Else
            Salidas = Salidas + 1
        End If

        If (contador = 10) Then
            Tiempo = Tiempo + 1
            TextBox3.Text = Tiempo
            contador = 1
        Else
            contador = contador + 1
        End If

    End Sub
    Public Function BuscarEnemigo(Correlativo As Integer)
        Dim Seguir As Boolean = True
        LEnemigos.Aux = LEnemigos.cabeza

        While (Seguir)

            If (LEnemigos.Aux.Correlativo = Correlativo) Then
                Seguir = False

            Else
                If (LEnemigos.Aux.Siguiente Is Nothing) Then
                    Seguir = False
                Else
                    LEnemigos.Aux = LEnemigos.Aux.Siguiente

                End If

            End If

        End While

        Return LEnemigos.Aux.Correlativo
    End Function

    Public Function BuscarEnemigo(nombre As String)
        Dim Seguir As Boolean = True
        LEnemigos.Aux = LEnemigos.cabeza

        While (Seguir)

            If (LEnemigos.Aux.Nombre.Equals(nombre)) Then
                Seguir = False

            Else
                If (LEnemigos.Aux.Siguiente Is Nothing) Then
                    Seguir = False
                Else
                    LEnemigos.Aux = LEnemigos.Aux.Siguiente

                End If

            End If

        End While

        Return LEnemigos.Aux.Correlativo
    End Function


    Public Function BuscarEnemigo()
        Dim Seguir As Boolean = True
        LEnemigos.Aux = LEnemigos.cabeza

        While (Seguir)

            If (LEnemigos.Aux.Correlativo = pivote) Then
                Seguir = False

            Else
                If (LEnemigos.Aux.Siguiente Is Nothing) Then
                    Seguir = False
                Else
                    LEnemigos.Aux = LEnemigos.Aux.Siguiente

                End If

            End If

        End While

        Return LEnemigos.Aux.Nombre

    End Function

    Public Sub Nuevo_Enemigo()
        Dim k As Integer
        Dim caminante As Integer = 0
        pivote = 1
        k = numAleatorio.Next(1, 50)

        While (caminante <> k)

            If (pivote < Frecuencia) Then
                pivote = pivote + 1
            Else
                pivote = 1
            End If

            caminante = caminante + 1
        End While


    End Sub

    Public Sub Llenar_Correlativo()
        Dim Seguir As Boolean = True
        LEnemigos.Aux = LEnemigos.cabeza
        Dim inicio As Integer = 0
        Dim Final As Integer = LEnemigos.Aux.frecuencia - 1


        While (Seguir)
            For k As Integer = inicio To Final
                Enemigos(k) = LEnemigos.Aux.Correlativo

            Next

            If (LEnemigos.Aux.Siguiente Is Nothing) Then
                Seguir = False
            Else
                inicio = Final + 1
                LEnemigos.Aux = LEnemigos.Aux.Siguiente
                Final = (LEnemigos.Aux.frecuencia - 1 + inicio)
            End If



        End While
    End Sub


    Public Sub CargarImagenes()
        Dim seguir As Boolean = True
        LEnemigos.Aux = LEnemigos.cabeza

        While (seguir)
            IEnemigos(LEnemigos.Aux.Correlativo - 1) = Image.FromFile(LEnemigos.Aux.Renemigo)
            DEnemigos(LEnemigos.Aux.Correlativo - 1) = Image.FromFile(LEnemigos.Aux.Rdisparo)

            If (LEnemigos.Aux.Siguiente Is Nothing) Then
                seguir = False
            Else
                LEnemigos.Aux = LEnemigos.Aux.Siguiente
            End If
        End While
    End Sub

    Public Sub Salida()
        Timer1.Stop()
        Dim Resumen As New Salida

        Resumen.TxtTiempo.Text = Tiempo
        Resumen.TxtPuntos.Text = puntos
        Resumen.txtEsquivar.Text = Esquivados
        Resumen.TxtDestruidos.Text = Destruidos
        Resumen.Show()
        Me.Hide()
    End Sub
End Class