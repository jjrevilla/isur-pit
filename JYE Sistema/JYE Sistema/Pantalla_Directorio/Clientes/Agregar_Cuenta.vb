Public Class Agregar_Cuenta
    Private Sub Agregar_Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MONEDAS
        Me.CBMoneda.AutoCompleteMode = AutoCompleteMode.Suggest
        Dim wcfselectmonedas As New ServiceReference_J_E.Service1Client
        CBMoneda.DataSource = wcfselectmonedas.SEL_MONEDAS
        CBMoneda.ValueMember = "ID_MONEDA"
        CBMoneda.DisplayMember = "DESCRIPCION"
        'BANCOS
        Me.CBBanco.AutoCompleteMode = AutoCompleteMode.Suggest
        Dim wcfselectbancos As New ServiceReference_J_E.Service1Client
        CBBanco.DataSource = wcfselectbancos.SEL_BANCOS
        CBBanco.ValueMember = "ID_BANCO"
        CBBanco.DisplayMember = "NOMBRE"
    End Sub
#Region "BOTONES"
    Private Sub BTNAgregar_Click(sender As Object, e As EventArgs) Handles BTNAgregar.Click
        Try
            Dim wcfconexion As New ServiceReference_J_E.Service1Client
            Dim det_persona As New ServiceReference_J_E.ClasesDET_PERSONAS
            det_persona.ID_BANCO = CBBanco.SelectedValue
            det_persona.ID_MONEDA = CBMoneda.SelectedValue
            det_persona.NUM_CUENTA = TXTNumCuenta.Text
            det_persona.NOTAS = TXTNotas.Text

            If wcfconexion.INS_DET_PERSONAS(det_persona) = True Then
                MsgBox("Se Agregó Correctamente.")
            Else
                MsgBox("Falló")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTNEliminar_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click

    End Sub

#End Region



End Class
