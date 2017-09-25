Imports System.Data.SqlClient
Public Class DC
    Public Conexion As New SqlConnection("Data Source=.;Database=JECORP;Integrated Security=SSPI;MultipleActiveResultSets=true;")
    Public Comandos As New SqlCommand

#Region "LOGIN"
    'Public Function LOGIN_EMPLEADOS(Usuario As String, Contrasenia As String, ByRef Verificador As Boolean) As Boolean
    '    Comandos.CommandText = "LOGIN_EMPLEADOS" 'PROCEDIMIENTO ALMACENADO QUE VALIDARÁ LA ENTRADA DEL USUARIO
    '    Comandos.CommandType = CommandType.StoredProcedure
    '    Comandos.Parameters.Clear()
    '    Comandos.Parameters.AddWithValue("@Usuario", Usuario)
    '    Comandos.Parameters.AddWithValue("@Contrasenia", Contrasenia)
    '    'El parametro Verificador se define de tipo output para que retorne un valor de la BD
    '    Dim PRMverificador As New SqlParameter("@Verificador", SqlDbType.VarChar)
    '    PRMverificador.Size = 70
    '    PRMverificador.Direction = ParameterDirection.Output
    '    PRMverificador.Value = Verificador
    '    Comandos.Parameters.Add(PRMverificador)
    '    Conexion.Open() 'SE ABRE LA CONEXION A LA BASE DE DATOS
    '    Comandos.Connection = Conexion
    '    Comandos.ExecuteScalar()
    '    Conexion.Close()
    '    SqlConnection.ClearAllPools()
    '    'Igualar la variable local Verificador al parametro retornado
    '    Verificador = PRMverificador.Value
    '    Return Verificador 'RETORNARÁ SI ES CORRECTO O NO
    'End Function

    Public Function LOGIN_EMPLEADOS(Usuario As String, Contrasenia As String)
        Comandos.CommandText = "login_usuario"
        Comandos.CommandType = CommandType.StoredProcedure
        Comandos.Parameters.Clear()
        Comandos.Parameters.AddWithValue("@USUARIO", Usuario)
        Comandos.Parameters.AddWithValue("@CONTRASENIA", Contrasenia)
        Comandos.Connection = Conexion
        Conexion.Open()
        Dim DRC As SqlDataReader
        DRC = Comandos.ExecuteReader
        DRC.Read()
        Return CBool(DRC.Item(0).ToString)
        Conexion.Close()
    End Function
#End Region


#Region "NACIONALIDADES"
    Public Function SEL_NACIONALIDADES() As List(Of ClasesBase.Clases.NACIONALIDADES)
        Dim listn As New List(Of ClasesBase.Clases.NACIONALIDADES)
        Comandos.Connection = Conexion
        Comandos.CommandType = CommandType.StoredProcedure
        Comandos.CommandText = "SEL_NACIONALIDADES"
        Comandos.Parameters.Clear()
        Dim drn As SqlDataReader
        Conexion.Open()
        drn = Comandos.ExecuteReader
        While drn.Read()
            Dim SELECTN As New ClasesBase.Clases.NACIONALIDADES
            SELECTN.ID_NACIONALIDAD = drn.GetInt32(0)
            SELECTN.DESCRIPCION = drn.GetString(1)
            listn.Add(SELECTN)
        End While
        Conexion.Close()
        Return listn
    End Function
#End Region

    '#Region "CLIENTES"
    '    Public Function SEL_CLIENTES() As List(Of ClasesBase.Clases.CLIENTES)
    '        Dim listc As New List(Of ClasesBase.Clases.CLIENTES)
    '        Comandos.Connection = Conexion
    '        Comandos.CommandType = CommandType.StoredProcedure
    '        Comandos.CommandText = "SEL_CLIENTES"
    '        Comandos.Parameters.Clear()
    '        Dim drc As SqlDataReader
    '        Conexion.Open()
    '        drc = Comandos.ExecuteReader
    '        While drc.Read()
    '            Dim SELECTC As New ClasesBase.Clases.CLIENTES
    '            SELECTC.DNI_CLIENTE = drc.GetString(0)
    '            SELECTC.NOMBRE = drc.GetString(1)
    '            SELECTC.APELLIDOS = drc.GetString(2)
    '            SELECTC.ID_NACIONALIDAD = drc.GetInt32(3)
    '            SELECTC.N_NACIONALIDAD = drc.GetString(4)
    '            SELECTC.SEXO = drc.GetString(5)
    '            SELECTC.DIRECCION = drc.GetString(6)
    '            SELECTC.TELEFONO = drc.GetString(7)
    '            SELECTC.MOVIL = drc.GetString(8)
    '            SELECTC.EMAIL = drc.GetString(9)
    '            SELECTC.ACTIVO = drc.GetBoolean(10)
    '            SELECTC.C_VERSION = drc.GetValue(11)
    '            SELECTC.ID_PROVEEDOR = drc.GetInt32(12)
    '            SELECTC.N_PROVEEDOR = drc.GetString(13)

    '            listc.Add(SELECTC)
    '        End While
    '        Conexion.Close()
    '        Return listc
    '    End Function
    '    Public Function INS_CLIENTES(Cliente As ClasesBase.Clases.CLIENTES) As Boolean
    '        Try
    '            Comandos.CommandText = "INS_CLIENTES"
    '            Comandos.CommandType = CommandType.StoredProcedure
    '            Comandos.Parameters.Clear()
    '            Comandos.Parameters.AddWithValue("@DNI_CLIENTE", Cliente.DNI_CLIENTE)
    '            Comandos.Parameters.AddWithValue("@NOMBRE", Cliente.NOMBRE)
    '            Comandos.Parameters.AddWithValue("@APELLIDOS", Cliente.APELLIDOS)
    '            Comandos.Parameters.AddWithValue("ID_NACIONALIDAD", Cliente.ID_NACIONALIDAD)
    '            Comandos.Parameters.AddWithValue("@SEXO", Cliente.SEXO)
    '            Comandos.Parameters.AddWithValue("@DIRECCION", Cliente.DIRECCION)
    '            Comandos.Parameters.AddWithValue("@TELEFONO", Cliente.TELEFONO)
    '            Comandos.Parameters.AddWithValue("@MOVIL", Cliente.MOVIL)
    '            Comandos.Parameters.AddWithValue("@EMAIL", Cliente.EMAIL)
    '            Comandos.Parameters.AddWithValue("@ID_PROVEEDOR", Cliente.ID_PROVEEDOR)

    '            Comandos.Connection = Conexion
    '            Conexion.Open()
    '            Dim DRC As SqlDataReader
    '            DRC = Comandos.ExecuteReader
    '            DRC.Read()
    '            Return CBool(DRC.Item(0).ToString)
    '            Conexion.Close()
    '        Catch ex As Exception

    '        End Try
    '    End Function
    '    Public Function UPD_CLIENTES(Cliente As ClasesBase.Clases.CLIENTES) As Boolean
    '        Try
    '            Comandos.CommandText = "UPD_CLIENTES"
    '            Comandos.CommandType = CommandType.StoredProcedure
    '            Comandos.Parameters.Clear()
    '            Comandos.Parameters.AddWithValue("@DNI_CLIENTE", Cliente.DNI_CLIENTE)
    '            Comandos.Parameters.AddWithValue("@NOMBRE", Cliente.NOMBRE)
    '            Comandos.Parameters.AddWithValue("@APELLIDOS", Cliente.APELLIDOS)
    '            Comandos.Parameters.AddWithValue("@ID_NACIONALIDAD", Cliente.ID_NACIONALIDAD)
    '            Comandos.Parameters.AddWithValue("@SEXO", Cliente.SEXO)
    '            Comandos.Parameters.AddWithValue("@DIRECCION", Cliente.DIRECCION)
    '            Comandos.Parameters.AddWithValue("@TELEFONO", Cliente.TELEFONO)
    '            Comandos.Parameters.AddWithValue("@MOVIL", Cliente.MOVIL)
    '            Comandos.Parameters.AddWithValue("@EMAIL", Cliente.EMAIL)
    '            Comandos.Parameters.AddWithValue("@ID_PROVEEDOR", Cliente.ID_PROVEEDOR)
    '            Comandos.Parameters.AddWithValue("@CARGO_P", Cliente.CARGO_P)
    '            Comandos.Parameters.AddWithValue("@C_VERSION", Cliente.C_VERSION)
    '            Comandos.Connection = Conexion
    '            Conexion.Open()
    '            Dim drc As SqlDataReader
    '            drc = Comandos.ExecuteReader
    '            drc.Read()
    '            Return CBool(drc.Item(0).ToString)
    '            Conexion.Close()
    '        Catch ex As Exception

    '        End Try
    '    End Function
    '#End Region

#Region "BANCOS Y MONEDAS"
    Public Function SEL_BANCOS() As List(Of ClasesBase.Clases.BANCOS)
        Dim listb As New List(Of ClasesBase.Clases.BANCOS)
        Comandos.Connection = Conexion
        Comandos.CommandType = CommandType.StoredProcedure
        Comandos.CommandText = "SEL_BANCOS"
        Comandos.Parameters.Clear()
        Dim drb As SqlDataReader
        Conexion.Open()
        drb = Comandos.ExecuteReader
        While drb.Read()
            Dim SELECTB As New ClasesBase.Clases.BANCOS
            SELECTB.ID_BANCO = drb.GetInt32(0)
            SELECTB.NOMBRE = drb.GetString(1)
            listb.Add(SELECTB)
        End While
        Conexion.Close()
        Return listb
    End Function
    Public Function SEL_MONEDAS() As List(Of ClasesBase.Clases.MONEDAS)
        Dim listm As New List(Of ClasesBase.Clases.MONEDAS)
        Comandos.Connection = Conexion
        Comandos.CommandType = CommandType.StoredProcedure
        Comandos.CommandText = "SEL_MONEDAS"
        Comandos.Parameters.Clear()
        Dim drm As SqlDataReader
        Conexion.Open()
        drm = Comandos.ExecuteReader
        While drm.Read()
            Dim SELECTM As New ClasesBase.Clases.MONEDAS
            SELECTM.ID_MONEDA = drm.GetInt32(0)
            SELECTM.DESCRIPCION = drm.GetString(1)
            listm.Add(SELECTM)
        End While
        Conexion.Close()
        Return listm
    End Function
#End Region

#Region "DET_PERSONAS"
    Public Function INS_DET_PERSONAS(DET_PERSONA As ClasesBase.Clases.DET_PERSONAS) As Boolean
        Try
            Comandos.CommandText = "INS_DET_PERSONAS"
            Comandos.CommandType = CommandType.StoredProcedure
            Comandos.Parameters.Clear()
            Comandos.Parameters.AddWithValue("@ID_BANCO", DET_PERSONA.ID_BANCO)
            Comandos.Parameters.AddWithValue("@ID_MONEDA", DET_PERSONA.ID_MONEDA)
            Comandos.Parameters.AddWithValue("@NUM_CUENTA", DET_PERSONA.NOTAS)
            Comandos.Connection = Conexion
            Conexion.Open()
            Dim DRD As SqlDataReader
            DRD = Comandos.ExecuteReader
            DRD.Read()
            Return CBool(DRD.Item(0).ToString)
            Conexion.Close()
        Catch ex As Exception

        End Try
    End Function
    Public Function UPD_DET_PERSONAS(DET_PERSONA As ClasesBase.Clases.PERSONAS) As Boolean

    End Function


    Public Function DEL_DET_PERSONAS(DET_PERSONA As ClasesBase.Clases.PERSONAS) As Boolean

    End Function


    Public Function SEL_DET_PERSONAS() As List(Of ClasesBase.Clases.DET_PERSONAS)
        Dim listp As New List(Of ClasesBase.Clases.DET_PERSONAS)
        Comandos.Connection = Conexion
        Comandos.CommandType = CommandType.StoredProcedure
        Comandos.CommandText = "SEL_DET_PERSONAS"
        Comandos.Parameters.Clear()
        Dim drp As SqlDataReader
        Conexion.Open()
        drp = Comandos.ExecuteReader
        While drp.Read()
            Dim SELECTP As New ClasesBase.Clases.DET_PERSONAS
            SELECTP.ID_DET_PERSONA = drp.GetInt32(0)
            SELECTP.DET_ID_PERSONA = drp.GetInt32(1)
            SELECTP.ID_BANCO = drp.GetInt32(2)
            SELECTP.NOMBRE_B = drp.GetString(3)
            SELECTP.ID_MONEDA = drp.GetInt32(4)
            SELECTP.NOMBRE_M = drp.GetString(5)
            SELECTP.NUM_CUENTA = drp.GetString(6)
            SELECTP.NOTAS = drp.GetString(7)
            listp.Add(SELECTP)
        End While
        Conexion.Close()
        Return listp
    End Function

#End Region
    '#Region "PROVEEDORES"
    '    Public Function SEL_PROVEEDORES() As List(Of ClasesBase.Clases.PROVEEDORES)
    '        Dim listp As New List(Of ClasesBase.Clases.PROVEEDORES)
    '        Comandos.Connection = Conexion
    '        Comandos.CommandType = CommandType.StoredProcedure
    '        Comandos.CommandText = "SEL_PROVEEDORES"
    '        Comandos.Parameters.Clear()
    '        Dim drp As SqlDataReader
    '        Conexion.Open()
    '        drp = Comandos.ExecuteReader
    '        While drp.Read()
    '            Dim SELECTP As New ClasesBase.Clases.PROVEEDORES
    '            SELECTP.ID_PROVEEDOR = drp.GetInt32(0)
    '            SELECTP.NOMBRE = drp.GetString(1)
    '            SELECTP.RUC = drp.GetString(2)
    '            SELECTP.DIRECCION = drp.GetString(3)
    '            SELECTP.RUBRO = drp.GetString(4)
    '            SELECTP.TELEFONO = drp.GetString(5)
    '            SELECTP.MOVIL1 = drp.GetString(6)
    '            SELECTP.MOVIL2 = drp.GetString(7)
    '            SELECTP.EMAIL = drp.GetString(8)
    '            SELECTP.PAGINA_WEB = drp.GetString(9)
    '            SELECTP.P_VERSION = drp.GetValue(10)
    '            SELECTP.ACTIVO = drp.GetBoolean(11)
    '            SELECTP.DET_ID_DET_PROVEEDOR = drp.GetInt32(12)
    '            SELECTP.DET_ID_BANCO = drp.GetInt32(13)
    '            SELECTP.DET_NOMBRE_BANCO = drp.GetString(14)
    '            SELECTP.DET_ID_MONEDA = drp.GetInt32(15)
    '            SELECTP.DET_NOMBRE_M = drp.GetString(16)
    '            SELECTP.DET_NUM_CUENTA = drp.GetString(17)
    '            listp.Add(SELECTP)
    '        End While
    '        Conexion.Close()
    '        Return listp
    '    End Function
    '    Public Function INS_PROVEEDOR(Proveedor As ClasesBase.Clases.PROVEEDORES) As Boolean
    '        Try
    '            Comandos.CommandText = "INS_PROVEEDORES"
    '            Comandos.CommandType = CommandType.StoredProcedure
    '            Comandos.Parameters.Clear()
    '            Comandos.Parameters.AddWithValue("@NOMBRE", Proveedor.NOMBRE)
    '            Comandos.Parameters.AddWithValue("@RUC", Proveedor.RUC)
    '            Comandos.Parameters.AddWithValue("@DIRECCION", Proveedor.DIRECCION)
    '            Comandos.Parameters.AddWithValue("@RUBRO", Proveedor.RUBRO)
    '            Comandos.Parameters.AddWithValue("@TELEFONO", Proveedor.TELEFONO)
    '            Comandos.Parameters.AddWithValue("@MOVIL1", Proveedor.MOVIL1)
    '            Comandos.Parameters.AddWithValue("@MOVIL2", Proveedor.MOVIL2)
    '            Comandos.Parameters.AddWithValue("@EMAIL", Proveedor.EMAIL)
    '            Comandos.Parameters.AddWithValue("@PAGINA_WEB", Proveedor.PAGINA_WEB)
    '            Comandos.Parameters.AddWithValue("@ID_BANCO", Proveedor.DET_ID_BANCO)
    '            Comandos.Parameters.AddWithValue("@ID_MONEDA", Proveedor.DET_ID_MONEDA)
    '            Comandos.Parameters.AddWithValue("@NUM_CUENTA", Proveedor.DET_NUM_CUENTA)
    '            Comandos.Connection = Conexion
    '            Conexion.Open()

    '            Dim DRP As SqlDataReader
    '            DRP = Comandos.ExecuteReader
    '            DRP.Read()
    '            Return CBool(DRP.Item(0).ToString)
    '            Conexion.Close()
    '        Catch ex As Exception

    '        End Try
    '    End Function
    '#End Region



End Class
