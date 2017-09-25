Imports System.Security.Cryptography
Imports Telerik.WinControls
Public Class Login
    Dim conexionWCF As New ServiceReference_J_E.Service1Client
    Dim Verificador As Boolean
    Private Sub CifradoMd5(ByVal TextoCifrar As String) 'Recibe una cadena de caracteres a cifrar
        'Variable para almacenar el textomd5
        Dim TextoCifrado As String
        TextoCifrado = “”
        'se crea una instancia
        Dim md5 As New MD5CryptoServiceProvider
        'variable para almacenar la cantidad de bytes del texto a cifrar
        Dim bytValue() As Byte
        'variable para almacenar el hash
        Dim bytHash() As Byte
        'variable para el ciclo
        Dim i As Integer
        'calcula los bytes del texto introducido y lo almacena en una variable
        bytValue = System.Text.Encoding.UTF8.GetBytes(TextoCifrar)
        'Calcula el valor hash para la matriz de bytes especificada.
        bytHash = md5.ComputeHash(bytValue)
        'se “limpia” el proceso md5 (por si se ha utilizado antes)
        md5.Clear()
        'for tomar el valor hash de la variable bythash y convertirla a texto
        For i = 0 To bytHash.Length - 1
            TextoCifrado &= bytHash(i).ToString(“x”).PadLeft(2, “0”)
        Next
        TXTContrasenia.Text = TextoCifrado
    End Sub
    Private Sub BTNAceptar_Click(sender As Object, e As EventArgs) Handles BTNAceptar.Click
        MDI_Principal.Show()
        Me.Hide()
        'CifradoMd5(TXTContrasenia.Text)
        ''enviamos la cadena de caracteres a cifrar
        'conexionWCF.LOGIN_EMPLEADOS(TXTUsername.Text, TXTContrasenia.Text, Verificador)
        'If Verificador = True Then
        '    TXTContrasenia.Clear()
        '    DashBoard.LBLUsuario.Text = TXTUsername.Text
        '    DashBoard.Show()
        '    Me.Hide()
        'Else
        '    TXTContrasenia.Clear()
        '    RadMessageBox.SetThemeName("TelerikMetroBlue")
        '    RadMessageBox.Show(Me, "Usuario o Contraseña Incorrectos", "Error", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        '    'RadMessageBox.Show("Usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, "Contactese con el administrador, o llame al número 992737357")
        'End If

        Me.Hide()
    End Sub
    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click
        RadMessageBox.SetThemeName("TelerikMetroBlue")
        Dim mensajesalida = RadMessageBox.Show(Me, "Desea Salir?", "Salir", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        If mensajesalida = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub LBLRegistrarse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LBLRegistrarse.LinkClicked
        Empleados_Modal.Show()
    End Sub




















    ''MENSAJES DE AYUDA
    Private Sub LBLRegistrarse_MouseHover(sender As Object, e As EventArgs) Handles LBLRegistrarse.MouseHover
        TTMenus.SetToolTip(LBLRegistrarse, "Registre un nuevo empleado")
    End Sub

    Private Sub LinkLabel1_MouseHover(sender As Object, e As EventArgs) Handles LBLRecuperarcontrasenia.MouseHover
        TTMenus.SetToolTip(LBLRecuperarcontrasenia, "Contactese con el administrador para recuperar su contraseña.")
    End Sub
    Private Sub BTNAceptar_MouseHover(sender As Object, e As EventArgs) Handles BTNAceptar.MouseHover
        TTMenus.SetToolTip(BTNAceptar, "Ingresar al Sistema.")
    End Sub
    Private Sub BTNCancelar_MouseHover(sender As Object, e As EventArgs) Handles BTNCancelar.MouseHover
        TTMenus.SetToolTip(BTNCancelar, "Salir")
    End Sub

    ''MOVIMIENTO 
    'NO FUNCIONA MOVIMIENTO AUN

    'Private xIni As Single
    'Private yIni As Single

    'Private Sub Login_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    '    'Asignacion de las coordenadas 'X' y 'Y' del Control
    '    xIni = X
    '    yIni = Y
    'End Sub

    'Private Sub Login_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    '    'Verificar que se presione el Boton del Mouse
    '    If Button = 1 Then
    '        Me.Top = Me.Top + (Y - yIni)
    '        Me.Left = Me.Left + (X - xIni)
    '    End If
    'End Sub

End Class
