Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Public Class Directorio_Principal
    Private Sub Directorio_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Call Mostrar_Clientes()
        Call Mostrar_Proveedores()
        'BackgroundWorker1.RunWorkerAsync()
    End Sub


#Region "Clientes"
    Public DNIClie, Nomcli, Apecli As String 'Almacena el id del cliente
    Public idpais, idProveedor As Integer 'Almacena id de pais, proveedor
    Public Updatecli As Boolean = False
    Public Cliver As Object 'Almacena la version

    'Sub Mostrar_Clientes()
    '    Dim wcfconexion As New ServiceReference_J_E.Service1Client
    '    DGVClientes.DataSource = wcfconexion.SEL_CLIENTES
    'End Sub

    Private Sub BTNNuevoC_Click(sender As Object, e As EventArgs) Handles BTNNuevoC.Click
        Cliente_Modal.Show()
    End Sub
    Private Sub BTNEditarC_Click(sender As Object, e As EventArgs) Handles BTNEditarC.Click
        If Updatecli = True Then
            Cliente_Modal.Show()
            Cliente_Modal.TXTDocumento.IsReadOnly = True
            Cliente_Modal.TXTDocumento.Text = DNIClie
            Cliente_Modal.TXTNombre.Text = Nomcli
            Cliente_Modal.TXTApellidos.Text = Apecli
            Cliente_Modal.CBPais.Text = LBLPais.Text
            Cliente_Modal.CBTipoCliente.Text = LBLSexo.Text
            Cliente_Modal.TXTDireccion.Text = LBLDireccion.Text
            Cliente_Modal.TXTTelefono.Text = LBLTelefono.Text
            Cliente_Modal.TXTMovil1.Text = LBLMovil.Text
            Cliente_Modal.TXTEmail.Text = LBLEmail.Text
            Cliente_Modal.TXTEmpresa.Text = LBLEmpresaC.Text

            Cliente_Modal.c_version = Cliver
            Cliente_Modal.id_pro = idProveedor
        Else
            MsgBox("Debe seleccionar un registro antes de actualizar")
        End If


    End Sub
    Private Sub BTNEliminarC_Click(sender As Object, e As EventArgs) Handles BTNEliminarC.Click

    End Sub

    Private Sub DGVClientes_CellClick(sender As Object, e As GridViewCellEventArgs) Handles DGVClientes.CellClick
        Try

            Updatecli = True

            'CARGA DE VARIABLES
            Nomcli = DGVClientes.Rows(e.RowIndex).Cells(1).Value
            Apecli = DGVClientes.Rows(e.RowIndex).Cells(2).Value
            DNIClie = DGVClientes.Rows(e.RowIndex).Cells(6).Value
            Cliver = DGVClientes.Rows(e.RowIndex).Cells(4).Value
            idpais = DGVClientes.Rows(e.RowIndex).Cells(8).Value
            idProveedor = DGVClientes.Rows(e.RowIndex).Cells(9).Value

            'MsgBox(BitConverter.ToString(Cliver)) ''convertir el object en texto
            CHBActivoC.Checked = DGVClientes.Rows(e.RowIndex).Cells(0).Value
            LBLNombres.Text = DGVClientes.Rows(e.RowIndex).Cells(1).Value + " " & DGVClientes.Rows(e.RowIndex).Cells(2).Value
            LBLDni.Text = DGVClientes.Rows(e.RowIndex).Cells(6).Value
            LBLPais.Text = DGVClientes.Rows(e.RowIndex).Cells(11).Value
            LBLSexo.Text = DGVClientes.Rows(e.RowIndex).Cells(13).Value
            LBLDireccion.Text = DGVClientes.Rows(e.RowIndex).Cells(5).Value
            LBLTelefono.Text = DGVClientes.Rows(e.RowIndex).Cells(14).Value
            LBLMovil.Text = DGVClientes.Rows(e.RowIndex).Cells(10).Value
            LBLEmail.Text = DGVClientes.Rows(e.RowIndex).Cells(7).Value
            LBLEmpresaC.Text = DGVClientes.Rows(e.RowIndex).Cells(12).Value

        Catch ex As Exception
        End Try
    End Sub


    'Dim mensajesalida = RadMessageBox.Show(Me, "Desea Eliminar?" + " " & LBLNombre.Text + " " & LBLModelo.Text, "Eliminar", MessageBoxButtons.YesNo, RadMessageIcon.Question)
    'If mensajesalida = DialogResult.Yes Then
    'If wcfconexion.DEL_VEHICULOS(Vehiculo) = True Then
    'Call Mostar_Vehiculos()
    '            RadMessageBox.Show(Me, "Se eliminó Correctamente.", "Eliminar", MessageBoxButtons.OK, RadMessageIcon.Info)
    '        Else
    '            RadMessageBox.Show(Me, "Error al eliminar Registro.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
    '        End If
    'End If

    'Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '    Call Mostrar_Clientes()
    'End Sub
#End Region

#Region "Proveedores"
    Sub Mostrar_Proveedores()
        'Dim wcfselproveedores As New ServiceReference_J_E.Service1Client
        'DGVProveedores.DataSource = wcfselproveedores.SEL_PROVEEDORES
    End Sub
    Private Sub BTNEditarP_Click(sender As Object, e As EventArgs) Handles BTNEditarP.Click

    End Sub
    Private Sub BTNEliminarP_Click(sender As Object, e As EventArgs) Handles BTNEliminarP.Click

    End Sub
    Private Sub DGVProveedores_CellClick(sender As Object, e As GridViewCellEventArgs) Handles DGVProveedores.CellClick
        Try
            'CARGA DE VARIABLES

            'CARGA DE LABELS
            CHBActivoP.Checked = DGVProveedores.Rows(e.RowIndex).Cells(0).Value
            LBLNombre_empresa.Text = DGVProveedores.Rows(e.RowIndex).Cells(11).Value
            LBLRubro.Text = DGVProveedores.Rows(e.RowIndex).Cells(12).Value
            LBLRucP.Text = DGVProveedores.Rows(e.RowIndex).Cells(19).Value
            LBLDireccionP.Text = DGVProveedores.Rows(e.RowIndex).Cells(8).Value
            LBLTelefonoP.Text = DGVProveedores.Rows(e.RowIndex).Cells(13).Value
            LBLMovil1P.Text = DGVProveedores.Rows(e.RowIndex).Cells(14).Value
            LBLMovil2P.Text = DGVProveedores.Rows(e.RowIndex).Cells(15).Value
            LBLEmailP.Text = DGVProveedores.Rows(e.RowIndex).Cells(9).Value
            LBLPaginaWebP.Text = DGVProveedores.Rows(e.RowIndex).Cells(16).Value
            LBLBancoP.Text = DGVProveedores.Rows(e.RowIndex).Cells(5).Value
            LBLMonedaP.Text = DGVProveedores.Rows(e.RowIndex).Cells(6).Value
            LBLNum_cuentaP.Text = DGVProveedores.Rows(e.RowIndex).Cells(7).Value
        Catch ex As Exception

        End Try
    End Sub


#End Region

#Region "Empleados"

#End Region
End Class
