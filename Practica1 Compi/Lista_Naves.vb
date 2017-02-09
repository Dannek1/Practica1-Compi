Public Class Lista_Naves
    Public cabeza As Naves = Nothing
    Public ultimo As Naves = Nothing
    Public Aux As Naves = Nothing




    Public Sub Insertar(nuevo As Naves)
        If (cabeza.Equals(Nothing)) Then

            cabeza = nuevo

        ElseIf (ultimo.Equals(Nothing)) Then

            ultimo = nuevo
            cabeza.Siguiente = ultimo
            ultimo.anterior = cabeza

        ElseIf (Aux.Equals(Nothing)) Then

            Aux = nuevo
            ultimo.Siguiente = Aux
            Aux.anterior = ultimo
            ultimo = Aux

        End If
    End Sub


End Class
