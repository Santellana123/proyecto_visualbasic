Public Class colisiones
    Public Function DetectarColision(ByVal rectangulos As Rectangle()) As Boolean
        For i = 0 To rectangulos.Length - 1 - 1
            For j = i + 1 To rectangulos.Length - 1
                If rectangulos(i).IntersectsWith(rectangulos(j)) Then
                    Return True
                End If
            Next
        Next

        Return False
    End Function
End Class
