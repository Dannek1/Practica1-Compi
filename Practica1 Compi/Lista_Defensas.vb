Public Class Lista_Defensas
    Public cabeza As Defensas = Nothing
    Public ultimo As Defensas = Nothing
    Public Aux As Defensas = Nothing




    Public Sub Insertar(nuevo As Defensas)

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
