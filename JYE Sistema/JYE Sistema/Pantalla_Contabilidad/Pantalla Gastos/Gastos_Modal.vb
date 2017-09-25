Public Class Gastos_Modal
    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click
        Me.Dispose()
        Contabilidad_Principal.Show()
    End Sub

    Private Sub Gastos_Modal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Contabilidad_Principal.Show()
    End Sub

    Private Sub BTNVehiculo_Click(sender As Object, e As EventArgs) Handles BTNVehiculo.Click
        Vehiculos_Principal.Show()
    End Sub
End Class
