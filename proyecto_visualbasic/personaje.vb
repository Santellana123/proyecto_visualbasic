Public Class Personaje
    Public Property Jugador As PictureBox
    Public Property VidaActual As Integer

    Public Sub New(ByVal jugador As PictureBox)
        Me.Jugador = jugador
        VidaActual = 100
    End Sub

    Public Sub MoverJugador(ByVal tecla As Keys)
        Select Case tecla
            Case Keys.D
                Jugador.Location = New Point(Jugador.Location.X + 10, Jugador.Location.Y)
            Case Keys.A
                Jugador.Location = New Point(Jugador.Location.X - 10, Jugador.Location.Y)
            Case Keys.W
                Jugador.Location = New Point(Jugador.Location.X, Jugador.Location.Y - 10)
            Case Keys.S
                Jugador.Location = New Point(Jugador.Location.X, Jugador.Location.Y + 10)
        End Select
    End Sub

    Public Overridable Sub Choque(ByVal daño As Integer)
        Jugador.Location = New Point(40, 395)
        Jugador.Size = New Size(30, 31)
        VidaActual -= daño
    End Sub
End Class
