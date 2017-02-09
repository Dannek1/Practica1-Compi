Public Class Lista_Fondos
    Public cabeza As Fondos = Nothing
    Public ultimo As Fondos = Nothing
    Public Aux As Fondos = Nothing




    Public Sub Insertar(nuevo As Fondos)

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
