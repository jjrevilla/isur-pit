Public Class BL
#Region "LOGIN"
    'Function LOGIN_EMPLEADOS(Usuario As String, Contrasenia As String, ByRef Verificador As Boolean) As Boolean
    '    Dim InstaDC As New DC.DC
    '    Return InstaDC.LOGIN_EMPLEADOS(Usuario, Contrasenia, Verificador)
    'End Function
    Public Function LOGIN_EMPLEADOS(Usuario As String, Contrasenia As String)
        Dim InstaDC As New DC.DC
        Return InstaDC.LOGIN_EMPLEADOS(Usuario, Contrasenia)
    End Function
#End Region



#Region "NACIONALIDADES"
    Function SEL_NACIONALIDADES() As List(Of ClasesBase.Clases.NACIONALIDADES)
        Dim InstaDC As New DC.DC
        Return InstaDC.SEL_NACIONALIDADES()
    End Function
#End Region
#Region "DET_PERSONAS"
    Function SEL_DET_PERSONAS() As List(Of ClasesBase.Clases.DET_PERSONAS)
        Dim InstaDC As New DC.DC
        Return InstaDC.SEL_DET_PERSONAS()
    End Function
    Function INS_DET_PERSONAS(DET_PERSONA As ClasesBase.Clases.DET_PERSONAS) As Boolean
        Dim InstaDC As New DC.DC
        Return InstaDC.INS_DET_PERSONAS(DET_PERSONA)
    End Function
#End Region
    '#Region "CLIENTES"
    '    Function SEL_CLIENTES() As List(Of ClasesBase.Clases.CLIENTES)
    '        Dim InstaDC As New DC.DC
    '        Return InstaDC.SEL_CLIENTES()
    '    End Function
    '    Function INS_CLIENTES(Cliente As ClasesBase.Clases.CLIENTES) As Boolean
    '        Dim InstaDC As New DC.DC
    '        Return InstaDC.INS_CLIENTES(Cliente)
    '    End Function
    '#End Region

    '#Region "PROVEEDORES"
    '    Function SEL_PROVEEDORES() As List(Of ClasesBase.Clases.PROVEEDORES)
    '        Dim InstaDC As New DC.DC
    '        Return InstaDC.SEL_PROVEEDORES()
    '    End Function
    '    Function INS_PROVEEDOR(Proveedor As ClasesBase.Clases.PROVEEDORES) As Boolean
    '        Dim InstaDC As New DC.DC
    '        Return InstaDC.INS_PROVEEDOR(Proveedor)
    '    End Function
    '    Function UPD_CLIENTES(Cliente As ClasesBase.Clases.CLIENTES) As Boolean
    '        Dim InstaDC As New DC.DC
    '        Return InstaDC.UPD_CLIENTES(Cliente)
    '    End Function
    '#End Region

#Region "BANCOS"
    Function SEL_BANCOS() As List(Of ClasesBase.Clases.BANCOS)
        Dim InstaDC As New DC.DC
        Return InstaDC.SEL_BANCOS()
    End Function
#End Region

#Region "MONEDAS"
    Function SEL_MONEDAS() As List(Of ClasesBase.Clases.MONEDAS)
        Dim InstaDC As New DC.DC
        Return InstaDC.SEL_MONEDAS()
    End Function
#End Region
End Class
