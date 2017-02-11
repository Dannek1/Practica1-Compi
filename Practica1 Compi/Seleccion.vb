Public Class Seleccion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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


End Class