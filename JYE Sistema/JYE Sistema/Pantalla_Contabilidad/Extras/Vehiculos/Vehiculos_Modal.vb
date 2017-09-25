Imports Telerik.WinControls
Imports System.Windows.Forms

Public Class Vehiculos_Modal

    Private Sub Vehiculos_Modal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTMarca.NullText = "Ingrese la Marca"
        TXTModelo.NullText = "Ingrese el Modelo"
        TXTPlaca.NullText = "Número de Placa"
        'Suggest
        Me.CBColor.AutoCompleteMode = AutoCompleteMode.Suggest
        ''Items de CB
        CBColor.Items.Add("Amarillo")
        CBColor.Items.Add("Azul")
        CBColor.Items.Add("Blanco")
        CBColor.Items.Add("Naranja")
        CBColor.Items.Add("Negro")
        CBColor.Items.Add("Plateado")
        CBColor.Items.Add("Rojo")
        CBColor.Items.Add("Verde")
        CBColor.Items.Add("Violeta")
        CBColor.Items.Add("Seleccione Color")
    End Sub
    'Private Sub Vehiculos_Modal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    Vehiculos_Principal.Show()
    '    Call Vehiculos_Principal.Mostar_Vehiculos()
    'End Sub
    'Private Sub BTNAceptar_Click(sender As Object, e As EventArgs) Handles BTNAceptar.Click
    '    If Vehiculos_Principal.updatev = True Then
    '        Dim wcfconexion As New ServiceReference_J_E.Service1Client
    '        Dim Vehiculo As New ServiceReference_J_E.ClasesVEHICULOS
    '        Vehiculo.ID_VEHICULO = Vehiculos_Principal.IDVehiculo
    '        Vehiculo.N_PLACA = Vehiculos_Principal.LBLPlaca.Text
    '        Vehiculo.MARCA = Vehiculos_Principal.LBLNombre.Text
    '        Vehiculo.MODELO = Vehiculos_Principal.LBLModelo.Text
    '        Vehiculo.COLOR = Vehiculos_Principal.LBLColor.Text
    '        Vehiculo.V_VERSION = Vehiculos_Principal.v_vehiculo
    '        If wcfconexion.UPD_VEHICULOS(Vehiculo) Then
    '            MsgBox("Correcto, se actualizó")
    '            Call Vehiculos_Principal.Mostar_Vehiculos()
    '        Else
    '            MsgBox("No se actualizó")
    '        End If
    '    Else
    '        'Conexion
    '        Dim wcfconexion As New ServiceReference_J_E.Service1Client
    '        Dim Vehiculo As New ServiceReference_J_E.ClasesVEHICULOS
    '        'Valores
    '        Vehiculo.N_PLACA = TXTPlaca.Text
    '        Vehiculo.MARCA = TXTMarca.Text
    '        Vehiculo.MODELO = TXTModelo.Text
    '        Vehiculo.COLOR = CBColor.Text
    '        'Vehiculo.V_VERSION = version
    '        If wcfconexion.INS_VEHICULO(Vehiculo) = True Then
    '            RadMessageBox.SetThemeName("TelerikMetroBlue")
    '            RadMessageBox.Show(Me, "Se Agregó Vehiculo Correctamente.", "Correcto", MessageBoxButtons.OK, RadMessageIcon.Info)
    '            Dim mensajesalida = RadMessageBox.Show(Me, "Desea Agregar mas Vehiculos?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question)
    '            If mensajesalida = DialogResult.Yes Then
    '                Call limpiar()
    '            Else
    '                Me.Close()
    '            End If
    '        Else
    '            MsgBox("Falló al ingresar")
    '        End If
    '    End If
    'End Sub
    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click
        RadMessageBox.SetThemeName("TelerikMetroBlue")
        Dim mensajesalida = RadMessageBox.Show(Me, "Cancelar?", "Salir", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        If mensajesalida = DialogResult.Yes Then
            Vehiculos_Principal.Show()
            Call limpiar()
            Me.Close()
        End If
    End Sub
    Sub limpiar()
        TXTPlaca.Text = ""
        TXTModelo.Text = ""
        TXTMarca.Text = ""
        CBColor.Text = "Seleccione Color"
    End Sub

End Class
