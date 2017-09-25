Public Class Productos_Modal
    Private Sub Productos_Modal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTNBuscarCategorias_Click(sender As Object, e As EventArgs) Handles BTNBuscarCategorias.Click
        Categorias.Show()
    End Sub

    Private Sub Productos_Modal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Productos_Principal.Show()
    End Sub
End Class
