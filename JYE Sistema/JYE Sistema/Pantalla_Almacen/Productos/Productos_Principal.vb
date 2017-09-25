Public Class Productos_Principal
    Private Sub Productos_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTNNuevo_Click(sender As Object, e As EventArgs) Handles BTNNuevo.Click
        Productos_Modal.Show()
    End Sub

    Private Sub Productos_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Almacen_Principal.Show()
    End Sub
End Class
