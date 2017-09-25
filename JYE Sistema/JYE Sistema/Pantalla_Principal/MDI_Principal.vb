Public Class MDI_Principal
    Private Sub MDI_Principal_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub BTNClientes_Click(sender As Object, e As EventArgs) Handles BTNClientes.Click


    End Sub

    Private Sub BTNNuevoC_Click(sender As Object, e As EventArgs) Handles BTNNuevoC.Click
        Dim menuhijo As New Cliente_Modal
        menuhijo.MdiParent = Me
        menuhijo.Show()
    End Sub

    Private Sub BTNBuscarC_Click(sender As Object, e As EventArgs) Handles BTNBuscarC.Click

    End Sub

    Private Sub RadRibbonBar1_Click(sender As Object, e As EventArgs) Handles RadRibbonBar1.Click

    End Sub
End Class
