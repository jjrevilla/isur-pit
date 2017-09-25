' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function


    'IMPLEMENTACION
#Region " LOGIN"
    'Function LOGIN_EMPLEADOS(Usuario As String, Contrasenia As String, ByRef Verificador As Boolean) As Boolean Implements IService1.LOGIN_EMPLEADOS
    '    Dim InstaBL As New BL.BL
    '    Return InstaBL.LOGIN_EMPLEADOS(Usuario, Contrasenia, Verificador)
    'End Function
    Function LOGIN_EMPLEADOS(Usuario As String, Contrasenia As String) Implements IService1.LOGIN_EMPLEADOS
        Dim InstaBL As New BL.BL
        Return InstaBL.LOGIN_EMPLEADOS(Usuario, Contrasenia)
    End Function

#End Region



#Region "NACIONALIDADES"
    Function SEL_NACIONALIDADES() As List(Of ClasesBase.Clases.NACIONALIDADES) Implements IService1.SEL_NACIONALIDADES
        Dim InstaBL As New BL.BL
        Return InstaBL.SEL_NACIONALIDADES()
    End Function
#End Region
#Region "DET_PERSONAS"
    Function SEL_DET_PERSONAS() As List(Of ClasesBase.Clases.DET_PERSONAS) Implements IService1.SEL_DET_PERSONAS
        Dim InstaBL As New BL.BL
        Return InstaBL.SEL_DET_PERSONAS()
    End Function
    Function INS_DET_PERSONAS(DET_PERSONA As ClasesBase.Clases.DET_PERSONAS) As Boolean Implements IService1.INS_DET_PERSONAS
        Dim InstaBL As New BL.BL
        Return InstaBL.INS_DET_PERSONAS(DET_PERSONA)
    End Function
#End Region
    '#Region "CLIENTES"
    '    Function SEL_CLIENTES() As List(Of ClasesBase.Clases.CLIENTES) Implements IService1.SEL_CLIENTES
    '        Dim InstaBL As New BL.BL
    '        Return InstaBL.SEL_CLIENTES()
    '    End Function
    '    Function INS_CLIENTES(Cliente As ClasesBase.Clases.CLIENTES) As Boolean Implements IService1.INS_CLIENTES
    '        Dim InstaBL As New BL.BL
    '        Return InstaBL.INS_CLIENTES(Cliente)
    '    End Function
    '    Function UPD_CLIENTES(Cliente As ClasesBase.Clases.CLIENTES) As Boolean Implements IService1.UPD_CLIENTES
    '        Dim InstaBL As New BL.BL
    '        Return InstaBL.UPD_CLIENTES(Cliente)
    '    End Function
    '#End Region

    '#Region "PROVEEDORES"
    '    Function SEL_PROVEEDORES() As List(Of ClasesBase.Clases.PROVEEDORES) Implements IService1.SEL_PROVEEDORES
    '        Dim InstaBL As New BL.BL
    '        Return InstaBL.SEL_PROVEEDORES()
    '    End Function
    '    Function INS_PROVEEDOR(Proveedor As ClasesBase.Clases.PROVEEDORES) As Boolean Implements IService1.INS_PROVEEDOR
    '        Dim InstaBL As New BL.BL
    '        Return InstaBL.INS_PROVEEDOR(Proveedor)
    '    End Function
    '#End Region

#Region "BANCOS"
    Function SEL_BANCOS() As List(Of ClasesBase.Clases.BANCOS) Implements IService1.SEL_BANCOS
        Dim InstaBL As New BL.BL
        Return InstaBL.SEL_BANCOS()
    End Function
#End Region

#Region "MONEDAS"
    Function SEL_MONEDAS() As List(Of ClasesBase.Clases.MONEDAS) Implements IService1.SEL_MONEDAS
        Dim InstaBL As New BL.BL
        Return InstaBL.SEL_MONEDAS()
    End Function
#End Region


End Class
