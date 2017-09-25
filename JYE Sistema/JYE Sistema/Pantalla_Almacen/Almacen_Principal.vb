Public Class Almacen_Principal
    Private Sub Almacen_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Almacen_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTNProductos_Click(sender As Object, e As EventArgs) Handles BTNProductos.Click
        Productos_Principal.Show()
    End Sub
    Private Sub BTNEntradas_Click(sender As Object, e As EventArgs) Handles BTNEntradas.Click
        Ingreso_Principal.Show()
    End Sub
    Private Sub BTNSalidas_Click(sender As Object, e As EventArgs) Handles BTNSalidas.Click
        Salida_Principal.Show()
    End Sub
    Private Sub BTNEquipos_Click(sender As Object, e As EventArgs) Handles BTNEquipos.Click
        Equipos_Principal.Show()
    End Sub
End Class
