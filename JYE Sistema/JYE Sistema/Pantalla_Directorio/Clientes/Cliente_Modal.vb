Public Class Cliente_Modal
    Public id_pro As Integer
    Public c_version As Object
    Private Sub CBTipoCliente_TextChanged(sender As Object, e As EventArgs) Handles CBTipoCliente.TextChanged
        If CBTipoCliente.Text = "Persona Jurídica" Then
            LBLDocumento.Text = "Número de RUC"
            LBLNombres.Text = "Razón Social"
            LBLApellidos.Text = "Nombre Comercial"
            GBLaboral.Visible = False
        Else
            LBLDocumento.Text = "Documento de Identidad"
            LBLNombres.Text = "Nombres"
            LBLApellidos.Text = "Apellidos"
            GBLaboral.Visible = True
        End If
    End Sub
    Private Sub Persona_Natural_Modal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#Region "Suggest de Textboxs"
        'Suggest de textbox
        TXTDocumento.NullText = "70189777"
        TXTNombre.NullText = "Ingrese sus Nombres"
        TXTApellidos.NullText = "Ingrese Apellidos"
        TXTEmail.NullText = "ejemplo@123.com"
        TXTTelefono.NullText = "45-45-45"
        TXTMovil1.NullText = "888-888-888"
        TXTMovil2.NullText = "999-999-999"
        TXTDireccion.NullText = "Av siempreviva 777 Mariano Melgar"
        TXTEmpresa.NullText = "Minera Cerro Verde"
        TXTCargo.NullText = "Operador de Maquinaria Pesada"
        TXTNotas.NullText = "Agregue una Nota..."
#End Region
#Region "Carga de Nacionalidades y Tipo de Personas"
        'Tipos de Personas
        Me.CBTipoCliente.AutoCompleteMode = AutoCompleteMode.Suggest
        CBTipoCliente.Items.Add("Persona Jurídica")
        CBTipoCliente.Items.Add("Persona Natural")
        'Items de CBNacionalidades
        Me.CBPais.AutoCompleteMode = AutoCompleteMode.Suggest
        Dim wcfconexion As New ServiceReference_J_E.Service1Client
        CBPais.DataSource = wcfconexion.SEL_NACIONALIDADES
        CBPais.ValueMember = "ID_NACIONALIDAD"
        CBPais.DisplayMember = "DESCRIPCION"
#End Region
    End Sub
#Region "Botones y Sub de utilidad"
    Sub Limpiar() 'Limpiar campos del Formulario
        TXTDocumento.Text = ""
        TXTNombre.Text = ""
        TXTApellidos.Text = ""
        TXTEmail.Text = ""
        TXTTelefono.Text = ""
        TXTMovil1.Text = ""
        TXTMovil2.Text = ""
        TXTDireccion.Text = ""
        TXTEmpresa.Text = ""
        TXTCargo.Text = ""
        CBTipoCliente.Text = "Seleccione Tipo"
    End Sub
    Private Sub BTNLimpiar_Click(sender As Object, e As EventArgs) Handles BTNLimpiar.Click
        Call Limpiar()
    End Sub

    Private Sub BTNBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles BTNBuscarEmpresa.Click
        Buscar_Cliente.Show()
    End Sub
    Private Sub BTNCancelarEmpresa_Click(sender As Object, e As EventArgs) Handles BTNCancelarEmpresa.Click
        TXTEmpresa.Text = ""
        TXTCargo.Text = ""
    End Sub
    Private Sub BTNAceptar_Click(sender As Object, e As EventArgs) Handles BTNAceptar.Click
        '    'Clientes_Principal.RadDesktopAlert1.CaptionText = "Nuevo Cliente Agregado"
        '    'Clientes_Principal.RadDesktopAlert1.ContentText = "Prueba 123"
        '    'Clientes_Principal.RadDesktopAlert1.Show()
        '    Try
        '        If Directorio_Principal.Updatecli = True Then
        '            'UPDATE
        '            Dim wcfconexion As New ServiceReference_J_E.Service1Client
        '            Dim cliente As New ServiceReference_J_E.ClasesCLIENTES
        '            cliente.DNI_CLIENTE = TXTDni.Text
        '            cliente.NOMBRE = TXTNombre.Text
        '            cliente.APELLIDOS = TXTApellidos.Text
        '            cliente.ID_NACIONALIDAD = CBPais.SelectedValue
        '            cliente.SEXO = CBSexo.Text
        '            cliente.DIRECCION = TXTDireccion.Text
        '            cliente.TELEFONO = TXTTelefono.Text
        '            cliente.MOVIL = TXTMovil.Text
        '            cliente.EMAIL = TXTEmail.Text
        '            cliente.ID_PROVEEDOR = id_pro
        '            cliente.C_VERSION = c_version
        '            If wcfconexion.UPD_CLIENTES(cliente) = True Then
        '                MsgBox("Se actualizó Correctamente")
        '                Call Limpiar()
        '                Call Directorio_Principal.Mostrar_Clientes()
        '            Else
        '                MsgBox("Falló")
        '            End If
        '        Else
        '            'INSERT
        '            Dim wcfconexion As New ServiceReference_J_E.Service1Client
        '            Dim cliente As New ServiceReference_J_E.ClasesCLIENTES
        '            ''Revisar condición para que aplique para todos los casos
        '            If TXTDni.Text = "" Then
        '                cliente.DNI_CLIENTE = Nothing
        '            Else
        '                cliente.DNI_CLIENTE = TXTDni.Text
        '            End If
        '            cliente.NOMBRE = TXTNombre.Text
        '            cliente.APELLIDOS = TXTApellidos.Text
        '            cliente.ID_NACIONALIDAD = CBPais.SelectedValue
        '            cliente.SEXO = CBSexo.Text
        '            cliente.DIRECCION = TXTDireccion.Text
        '            cliente.TELEFONO = TXTTelefono.Text
        '            cliente.MOVIL = TXTMovil.Text
        '            cliente.EMAIL = TXTEmail.Text
        '            If TXTEmpresa.Text = "" Then
        '                cliente.ID_PROVEEDOR = 0
        '            Else
        '                cliente.ID_PROVEEDOR = id_pro
        '            End If
        '            cliente.N_PROVEEDOR = TXTEmpresa.Text
        '            If wcfconexion.INS_CLIENTES(cliente) = True Then
        '                MsgBox("Se Agregó Correctamente")
        '                Call Limpiar()
        '                Call Directorio_Principal.Mostrar_Clientes()
        '            Else
        '                MsgBox("Falló")
        '                End If
        '            End If
        '    Catch ex As Exception

        '    End Try
    End Sub

    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click

    End Sub

    Private Sub BTNCuentas_Click(sender As Object, e As EventArgs) Handles BTNCuentas.Click
        Agregar_Cuenta.ShowDialog()
    End Sub


#End Region
End Class
