Public Class Categorias_Modal
    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub Categorias_Modal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Categorias.Show()
    End Sub

    Private Sub Categorias_Modal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
