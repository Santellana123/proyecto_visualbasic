Public Class perder
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Form = New Nivel1()
        A.Show()
        Me.Close()
    End Sub
End Class