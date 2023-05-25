Imports System.IO
Imports System.Security.Cryptography.X509Certificates


Public Class Nivel1
    Inherits Form

    Private colisionDetector As colisiones
    Private rectangulos As Rectangle()
    Private colisionando As Boolean = False
    Private personaje As personaje
    Private victoria As Victoria
    Private perder As perder
    Private puntos As PictureBox()
    Private puntuacion As Integer = 0
    Private personajeEspecial As PersonajeEspecial
    Private f2 As perder

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
        colisionDetector = New colisiones()
        rectangulos = New Rectangle() {Jugador.Bounds, obstaculo1.Bounds, obstaculo2.Bounds, obstaculo3.Bounds, obstaculo4.Bounds, obstaculo5.Bounds, obstaculo6.Bounds, obstaculo7.Bounds, obstaculo8.Bounds, obstaculo9.Bounds, obstaculo10.Bounds, obstaculo11.Bounds, obstaculo12.Bounds, obstaculo13.Bounds, obstaculo14.Bounds, obstaculo15.Bounds, obstaculo16.Bounds, obstaculo17.Bounds, PBganar.Bounds}
        personaje = New personaje(Jugador)
        victoria = New Victoria()
        perder = New perder()
        puntos = New PictureBox() {punto1, punto2, punto3, punto4}
        personajeEspecial = New PersonajeEspecial(Jugador, disminuir)
    End Sub

    Private Sub Nivel1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        rectangulos(0) = Jugador.Bounds
        rectangulos(1) = obstaculo1.Bounds
        rectangulos(2) = obstaculo2.Bounds
        rectangulos(3) = obstaculo3.Bounds
        rectangulos(4) = obstaculo4.Bounds
        rectangulos(5) = obstaculo5.Bounds
        rectangulos(6) = obstaculo6.Bounds
        rectangulos(7) = obstaculo7.Bounds
        rectangulos(8) = obstaculo8.Bounds
        rectangulos(9) = obstaculo9.Bounds
        rectangulos(10) = obstaculo10.Bounds
        rectangulos(11) = obstaculo11.Bounds
        rectangulos(12) = obstaculo12.Bounds
        rectangulos(13) = obstaculo13.Bounds
        rectangulos(14) = obstaculo14.Bounds
        rectangulos(15) = obstaculo15.Bounds
        rectangulos(16) = obstaculo16.Bounds
        rectangulos(17) = obstaculo17.Bounds

        personaje.MoverJugador(e.KeyCode)
        personajeEspecial.Interactuar()

        If colisionDetector.DetectarColision(rectangulos) Then
            If Not colisionando Then
                colisionando = True
                personaje.choque(25)
                ProgressBar1.Value = personaje.VidaActual

                If ProgressBar1.Value = 0 Then
                    If f2 Is Nothing Then
                        f2 = New perder()
                    End If
                    f2.Show()
                    Me.Hide()
                End If
            End If
        Else
            colisionando = False
        End If

        If rectangulos(0).IntersectsWith(PBganar.Bounds) Then
            Dim a As Form = New Victoria()
            a.Show()
            Me.Close()
            Dim b As Form = New perder()
            b.Close()
        End If

        For Each punto As PictureBox In puntos
            If rectangulos(0).IntersectsWith(punto.Bounds) AndAlso punto.Visible Then
                punto.Visible = False
                puntuacion += 100

                Using writer As StreamWriter = New StreamWriter("C:\Users\juan\Downloads\TAREAS\puntos.txt")
                    writer.WriteLine("Puntuación: " & puntuacion.ToString())
                End Using
            End If
        Next
    End Sub
End Class