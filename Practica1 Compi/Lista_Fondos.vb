Public Class Lista_Fondos
    Public cabeza As Fondos = Nothing
    Public ultimo As Fondos = Nothing
    Public Aux As Fondos = Nothing




    Public Sub Insertar(nuevo As Fondos)

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
