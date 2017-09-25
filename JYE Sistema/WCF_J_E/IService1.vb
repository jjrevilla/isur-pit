' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IService1

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String

    <OperationContract()>
    Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    '<OperationContract()>
    'Function LOGIN_EMPLEADOS(Usuario As String, Contrasenia As String, ByRef Verificador As Boolean) As Boolean
    ' TODO: agregue aquí sus operaciones de servicio
#Region "LOGIN"
    <OperationContract()>
    Function LOGIN_EMPLEADOS(Usuario As String, Contrasenia As String)
#End Region


#Region "NACIONALIDADES"
    <OperationContract>
    Function SEL_NACIONALIDADES() As List(Of ClasesBase.Clases.NACIONALIDADES)
#End Region
#Region "DET_PERSONAS"
    <OperationContract>
    Function SEL_DET_PERSONAS() As List(Of ClasesBase.Clases.DET_PERSONAS)
    <OperationContract>
    Function INS_DET_PERSONAS(DET_PERSONA As ClasesBase.Clases.DET_PERSONAS) As Boolean
#End Region
    ''#Region "CLIENTES"
    ''    <OperationContract>
    ''    Function SEL_CLIENTES() As List(Of ClasesBase.Clases.CLIENTES)
    ''    <OperationContract>
    ''    Function INS_CLIENTES(Cliente As ClasesBase.Clases.CLIENTES) As Boolean
    ''    <OperationContract>
    ''    Function UPD_CLIENTES(Cliente As ClasesBase.Clases.CLIENTES) As Boolean
    ''#End Region
    ''#Region "PROVEEDORES"
    ''    <OperationContract>
    ''    Function INS_PROVEEDOR(Proveedor As ClasesBase.Clases.PROVEEDORES) As Boolean
    ''#End Region
#Region "MONEDAS"
    <OperationContract>
    Function SEL_MONEDAS() As List(Of ClasesBase.Clases.MONEDAS)
#End Region
#Region "BANCOS"
    <OperationContract>
    Function SEL_BANCOS() As List(Of ClasesBase.Clases.BANCOS)
#End Region
    ''#Region "PROVEEDORES"
    ''    <OperationContract>
    ''    Function SEL_PROVEEDORES() As List(Of ClasesBase.Clases.PROVEEDORES)
    ''#End Region
End Interface

' Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean

    <DataMember()>
    Public Property StringValue() As String

End Class
