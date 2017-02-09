Public Class Lista_Enenigos
    Public cabeza As Enemigos = Nothing
    Public ultimo As Enemigos = Nothing
    Public Aux As Enemigos = Nothing




    Public Sub Insertar(nuevo As Enemigos)

        If (cabeza.Equals(Nothing)) Then

            cabeza = nuevo

        ElseIf (ultimo.Equals(Nothing)) Then

            ultimo = nuevo
            cabeza.Siguiente = ultimo
            ultimo.Anterior = cabeza

        ElseIf (Aux.Equals(Nothing)) Then

            Aux = nuevo
            ultimo.Siguiente = Aux
            Aux.Anterior = ultimo
            ultimo = Aux

        End If



    End Sub
End Class
