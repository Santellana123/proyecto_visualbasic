Public Class Victoria
    Public Function ComprobarVictoria(ByVal rectangulos As Rectangle(), ByVal puntos As Rectangle()) As Boolean
        For Each puntoRectangulo As Rectangle In puntos
            If rectangulos(0).IntersectsWith(puntoRectangulo) Then
                Return True
            End If
        Next

        Return False
    End Function
End Class
