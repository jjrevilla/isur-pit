Public Class Empleados_Principal
    Private Sub BTNNuevo_Click(sender As Object, e As EventArgs) Handles BTNNuevo.Click
        Empleados_Modal.Show()
    End Sub

    Private Sub BTNAgregar_Click(sender As Object, e As EventArgs) Handles BTNAgregar.Click
        Tareos_Modal.Show()
    End Sub

    Private Sub BTNVer_Click(sender As Object, e As EventArgs) 
        Tareos_Principal.Show()
    End Sub

    Private Sub Empleados_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
