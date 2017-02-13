Public Class Lista_Enenigos
    Public cabeza As Enemigos = Nothing
    Public ultimo As Enemigos = Nothing
    Public Aux As Enemigos = Nothing




    Public Sub Insertar(nuevo As Enemigos)

        If (cabeza Is Nothing) Then

            cabeza = nuevo

        ElseIf (ultimo Is Nothing) Then

            ultimo = nuevo
            cabeza.Siguiente = ultimo
            ultimo.Anterior = cabeza




        Else


            Aux = nuevo
            ultimo.Siguiente = Aux
            Aux.Anterior = ultimo
            ultimo = Aux



        End If



    End Sub
End Class
