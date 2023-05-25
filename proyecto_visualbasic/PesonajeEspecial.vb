Public Class PersonajeEspecial
    Inherits personaje

    Private disminuir As PictureBox
    Private colorInicial As Color

    Public Sub New(ByVal jugador As PictureBox, ByVal disminuir As PictureBox)
        MyBase.New(jugador)
        Me.disminuir = disminuir
        colorInicial = jugador.BackColor
    End Sub

    Public Sub Interactuar()
        If Jugador.Bounds.IntersectsWith(disminuir.Bounds) Then
            Jugador.Location = New Point(355, 202)
            Jugador.Size = New Size(15, 20)
        End If
    End Sub
End Class
