Imports System.IO
Imports System.Reflection.Emit

Public Class Victoria
    Public Sub New()
        InitializeComponent()

        Dim filePath = "C:\Users\juan\Downloads\TAREAS\puntos.txt"
        Using sr As StreamReader = New StreamReader(filePath)
            Dim contenido As String = sr.ReadToEnd()


            Label2.Text = contenido
        End Using


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Form = New Nivel1()
        A.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim B As Form = New Form1()
        B.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class