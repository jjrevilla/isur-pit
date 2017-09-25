
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class Vehiculos_Principal
    ''_________________________________________________
    ''
    ''FALTA= ACTUALIZAR VEHICULOS
    ''Click en el headerrow y muere la aplicacion, solucionar esto
    'Implementar funcionalidad de Imprimir Grilla
    ''Implementar funcionalidad de Exportar a PDF, Excel
    ''Controlar ingreso de informacion mediante Regex
    ''Los labels tienen que Mostrar el ultimo Registro ingresado (como una especie de caché)
    ''Error Provider para recuadros vacíos
    ''Debe de serleccionar un filtro para realizar la búsqueda.
    ''_________________________________________________

    ''VARIABLES
    Public IDVehiculo As Integer 'Almacena el id
    Public v_vehiculo As Object 'Se almacena la version
    Public updatev As Boolean 'Controlar la actualización de Datos

    Private Sub Vehiculos_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTNEliminar.Enabled = False
        BTNEditar.Enabled = False
        'Mostar_Vehiculos()
        'Suggest
        Me.CBFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
        'Items CB
        CBFiltro.Items.Add("Marca")
        CBFiltro.Items.Add("Modelo")
        CBFiltro.Items.Add("Placa")
        CBFiltro.Items.Add("Color")
    End Sub
    'Public Sub Mostar_Vehiculos()
    '    Dim wcfconexion As New ServiceReference_J_E.Service1Client
    '    DGVVehiculos.DataSource = wcfconexion.SEL_VEHICULOS
    'End Sub
    Private Sub BTNNuevo_Click(sender As Object, e As EventArgs) Handles BTNNuevo.Click
        Vehiculos_Modal.Show()
    End Sub
    Private Sub BTNEditar_Click(sender As Object, e As EventArgs) Handles BTNEditar.Click
        updatev = True
        Vehiculos_Modal.Show()
        Vehiculos_Modal.TXTMarca.Text = LBLNombre.Text
        Vehiculos_Modal.TXTModelo.Text = LBLModelo.Text
        Vehiculos_Modal.TXTPlaca.Text = LBLPlaca.Text
        Vehiculos_Modal.CBColor.Text = LBLColor.Text
    End Sub
    Private Sub BTNEliminar_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click
        'Dim wcfconexion As New ServiceReference_J_E.Service1Client
        'Dim Vehiculo As New ServiceReference_J_E.ClasesVEHICULOS
        'RadMessageBox.SetThemeName("TelerikMetroBlue")
        'Vehiculo.ID_VEHICULO = IDVehiculo 'numero de item
        'Dim mensajesalida = RadMessageBox.Show(Me, "Desea Eliminar?" + " " & LBLNombre.Text + " " & LBLModelo.Text, "Eliminar", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        'If mensajesalida = DialogResult.Yes Then
        '    If wcfconexion.DEL_VEHICULOS(Vehiculo) = True Then
        '        Call Mostar_Vehiculos()
        '        RadMessageBox.Show(Me, "Se eliminó Correctamente.", "Eliminar", MessageBoxButtons.OK, RadMessageIcon.Info)
        '    Else
        '        RadMessageBox.Show(Me, "Error al eliminar Registro.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        '    End If
        'End If
        'Mostar_Vehiculos()
    End Sub
    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click
        Me.Close()
    End Sub
    Private Sub DGVVehiculos_CellClick(sender As Object, e As GridViewCellEventArgs) Handles DGVVehiculos.CellClick
        ''Arreglar la logica de la aplicacion
        BTNEditar.Enabled = True
        BTNEliminar.Enabled = True
        ''Añadir la funcionalidad de SearchRow 
        ''Carga de valores ID y Version
        IDVehiculo = DGVVehiculos.Rows(e.RowIndex).Cells(4).Value
        v_vehiculo = DGVVehiculos.Rows(e.RowIndex).Cells(5).Value
        ''Carga de Valores labels
        LBLNombre.Text = DGVVehiculos.Rows(e.RowIndex).Cells(0).Value
        LBLModelo.Text = DGVVehiculos.Rows(e.RowIndex).Cells(1).Value
        LBLPlaca.Text = DGVVehiculos.Rows(e.RowIndex).Cells(2).Value
        LBLColor.Text = DGVVehiculos.Rows(e.RowIndex).Cells(3).Value
        LBLID.Text = "Item Seleccionado: " & DGVVehiculos.Rows(e.RowIndex).Cells(4).Value
    End Sub

    'MENSAJES DE INFORMACION
    Private Sub BTNAceptar_MouseHover(sender As Object, e As EventArgs) Handles BTNAceptar.MouseHover
        TTVehiculos.ToolTipIcon = ToolTipIcon.Info
        TTVehiculos.ToolTipTitle = "Aceptar"
        TTVehiculos.SetToolTip(BTNAceptar, "Aceptar Selección")
    End Sub

    Private Sub BTNCancelar_MouseHover(sender As Object, e As EventArgs) Handles BTNCancelar.MouseHover
        TTVehiculos.ToolTipIcon = ToolTipIcon.Info
        TTVehiculos.ToolTipTitle = "Cancelar"
        TTVehiculos.SetToolTip(BTNCancelar, "Cancelar y Salir")
    End Sub
    Private Sub BTNNuevo_MouseHover(sender As Object, e As EventArgs) Handles BTNNuevo.MouseHover
        TTVehiculos.ToolTipIcon = ToolTipIcon.Info
        TTVehiculos.ToolTipTitle = "Nuevo Vehículo"
        TTVehiculos.SetToolTip(BTNNuevo, "Agregue un nuevo vehículo a su base de datos.")
    End Sub
    Private Sub BTNEditar_MouseHover(sender As Object, e As EventArgs) Handles BTNEditar.MouseHover
        TTVehiculos.ToolTipIcon = ToolTipIcon.Info
        TTVehiculos.ToolTipTitle = "Editar Vehículo"
        TTVehiculos.SetToolTip(BTNEditar, "Actualice la información de un vehículo seleccionado.")
    End Sub

    Private Sub BTNEliminar_MouseHover(sender As Object, e As EventArgs) Handles BTNEliminar.MouseHover
        TTVehiculos.ToolTipIcon = ToolTipIcon.Warning
        TTVehiculos.ToolTipTitle = "Eliminar"
        TTVehiculos.SetToolTip(BTNEliminar, "Elimine el Vehículo seleccionado")
    End Sub

    Private Sub CBFiltro_MouseHover(sender As Object, e As EventArgs) Handles CBFiltro.MouseHover
        TTVehiculos.ToolTipIcon = ToolTipIcon.Info
        TTVehiculos.ToolTipTitle = "Filtro de Búsqueda"
        TTVehiculos.SetToolTip(CBFiltro, "Seleccione las condiciones de búsqueda y filtre la información.")
    End Sub

    Private Sub TXTBusqueda_MouseHover(sender As Object, e As EventArgs) Handles TXTBusqueda.MouseHover
        TTVehiculos.ToolTipIcon = ToolTipIcon.Info
        TTVehiculos.ToolTipTitle = "Búsqueda"
        TTVehiculos.SetToolTip(TXTBusqueda, "Filtre sus Registros.")
    End Sub

    Private Sub DGVVehiculos_MouseHover(sender As Object, e As EventArgs) Handles DGVVehiculos.MouseHover
        TTVehiculos.ToolTipIcon = ToolTipIcon.Info
        TTVehiculos.ToolTipTitle = "Lista de vehículos"
        TTVehiculos.SetToolTip(DGVVehiculos, "Lista de Vehículos existentes en su base de datos.")
    End Sub
End Class
