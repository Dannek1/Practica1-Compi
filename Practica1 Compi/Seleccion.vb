﻿Public Class Seleccion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboNaves.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Seleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarNaves()
        CargarFondos()
        CargarDefensas()
        CargarEnemigos()


    End Sub

    Public Sub CargarNaves()
        Dim seguir As Boolean = True

        LNaves.Aux = LNaves.cabeza

        While (seguir)
            LNaves.Aux.Rdisparo = Recortar_Comillas(LNaves.Aux.Rdisparo)
            LNaves.Aux.Rnave = Recortar_Comillas(LNaves.Aux.Rnave)
            LNaves.Aux.RSonido = Recortar_Comillas(LNaves.Aux.RSonido)
            ComboNaves.Items.Add(LNaves.Aux.Nombre)

            If (LNaves.Aux.Siguiente Is Nothing) Then
                seguir = False
            Else
                LNaves.Aux = LNaves.Aux.Siguiente
            End If


        End While
    End Sub

    Public Sub CargarFondos()
        Dim seguir As Boolean = True

        LFondos.Aux = LFondos.cabeza

        While (seguir)
            LFondos.Aux.fondo = Recortar_Comillas(LFondos.Aux.fondo)
            LFondos.Aux.musica = Recortar_Comillas(LFondos.Aux.musica)
            ComboFondos.Items.Add(LFondos.Aux.Nombre)

            If (LFondos.Aux.Siguiente Is Nothing) Then
                seguir = False
            Else
                LFondos.Aux = LFondos.Aux.Siguiente
            End If


        End While

    End Sub

    Public Sub CargarDefensas()
        Dim seguir As Boolean = True

        LDefendas.Aux = LDefendas.cabeza

        While (seguir)
            LDefendas.Aux.imagen = Recortar_Comillas(LDefendas.Aux.imagen)
            ComboDefensas.Items.Add(LDefendas.Aux.Nombre)

            If (LDefendas.Aux.Siguiente Is Nothing) Then
                seguir = False
            Else
                LDefendas.Aux = LDefendas.Aux.Siguiente
            End If


        End While

    End Sub
    Public Sub CargarEnemigos()
        Dim seguir As Boolean = True

        LEnemigos.Aux = LEnemigos.cabeza

        While (seguir)
            LEnemigos.Aux.Nombre = Recortar_Comillas(LEnemigos.Aux.Nombre)
            LEnemigos.Aux.Rdisparo = Recortar_Comillas(LEnemigos.Aux.Rdisparo)
            LEnemigos.Aux.Renemigo = Recortar_Comillas(LEnemigos.Aux.Renemigo)
            LEnemigos.Aux.Rsonido = Recortar_Comillas(LEnemigos.Aux.Rsonido)

            If (LEnemigos.Aux.Siguiente Is Nothing) Then
                seguir = False
            Else
                LEnemigos.Aux = LEnemigos.Aux.Siguiente
            End If


        End While

    End Sub

    Public Function Recortar_Comillas(cadena As String) As String
        Dim respuesta As String = ""
        For x As Integer = 0 To cadena.Length - 1
            If (cadena.Chars(x) <> Chr(34)) Then
                respuesta = respuesta + cadena.Chars(x)
            End If
        Next x

        Return respuesta
    End Function

    Private Sub ComboNaves_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboNaves.SelectedIndexChanged
        BuscarNave()
    End Sub

    Private Sub BuscarNave()
        Dim seguir As Boolean = True

        LNaves.Aux = LNaves.cabeza

        While (seguir)
            If (LNaves.Aux.Nombre.Equals(ComboNaves.Text)) Then
                seguir = False

                Dim Imagen As Image = Image.FromFile(LNaves.Aux.Rnave)
                ImgNaves.Image = Imagen


            ElseIf (LNaves.Aux.Siguiente Is Nothing) Then
                seguir = False
            Else
                LNaves.Aux = LNaves.Aux.Siguiente
            End If


        End While
    End Sub

    Private Sub BuscarFondos()
        Dim seguir As Boolean = True

        LFondos.Aux = LFondos.cabeza

        While (seguir)
            If (LFondos.Aux.Nombre.Equals(ComboFondos.Text)) Then
                seguir = False

                Dim Imagen As Image = Image.FromFile(LFondos.Aux.fondo)
                ImgFondos.Image = Imagen


            ElseIf (LFondos.Aux.Siguiente Is Nothing) Then
                seguir = False
            Else
                LFondos.Aux = LFondos.Aux.Siguiente
            End If


        End While
    End Sub

    Private Sub BuscarDefensas()
        Dim seguir As Boolean = True

        LDefendas.Aux = LDefendas.cabeza

        While (seguir)
            If (LDefendas.Aux.Nombre.Equals(ComboDefensas.Text)) Then
                seguir = False

                Dim Imagen As Image = Image.FromFile(LDefendas.Aux.imagen)
                ImgDefensas.Image = Imagen


            ElseIf (LDefendas.Aux.Siguiente Is Nothing) Then
                seguir = False
            Else
                LDefendas.Aux = LDefendas.Aux.Siguiente
            End If


        End While
    End Sub

    Private Sub ComboFondos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboFondos.SelectedIndexChanged
        BuscarFondos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboFondos.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim juego As New Juego

        juego.Show()
        Me.Hide()

    End Sub

    Private Sub ComboDefensas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDefensas.SelectedIndexChanged
        BuscarDefensas()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComboDefensas.Enabled = False
        Button5.Enabled = False
    End Sub
End Class