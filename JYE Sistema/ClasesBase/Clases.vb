Public Class Clases
    Public Class ARTICULOS
        Private _ID_ARTICULO As Integer
        Public Property ID_ARTICULO() As Integer
            Get
                Return _ID_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_ARTICULO = value
            End Set
        End Property
        Private _ID_TIPO_ARTICULO As Integer
        Public Property ID_TIPO_ARTICULO() As Integer
            Get
                Return _ID_TIPO_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_TIPO_ARTICULO = value
            End Set
        End Property
        Private _ID_CATEGORIA As Integer
        Public Property ID_CATEGORIA() As Integer
            Get
                Return _ID_CATEGORIA
            End Get
            Set(ByVal value As Integer)
                _ID_CATEGORIA = value
            End Set
        End Property
        Private _NOMBRE As String
        Public Property NOMBRE() As String
            Get
                Return _NOMBRE
            End Get
            Set(ByVal value As String)
                _NOMBRE = value
            End Set
        End Property
        Private _CARACTERISTICAS As String
        Public Property CARACTERISTICAS() As String
            Get
                Return _CARACTERISTICAS
            End Get
            Set(ByVal value As String)
                _CARACTERISTICAS = value
            End Set
        End Property
        Private _MARCA As String
        Public Property MARCA() As String
            Get
                Return _MARCA
            End Get
            Set(ByVal value As String)
                _MARCA = value
            End Set
        End Property
        Private _MODELO As String
        Public Property MODELO() As String
            Get
                Return _MODELO
            End Get
            Set(ByVal value As String)
                _MODELO = value
            End Set
        End Property
        Private _N_PLACA As String
        Public Property N_PLACA() As String
            Get
                Return _N_PLACA
            End Get
            Set(ByVal value As String)
                _N_PLACA = value
            End Set
        End Property
        Private _COLOR As String
        Public Property COLOR() As String
            Get
                Return _COLOR
            End Get
            Set(ByVal value As String)
                _COLOR = value
            End Set
        End Property
        Private _SERIE As String
        Public Property SERIE() As String
            Get
                Return _SERIE
            End Get
            Set(ByVal value As String)
                _SERIE = value
            End Set
        End Property
        Private _ID_MONEDA As Integer
        Public Property ID_MONEDA() As Integer
            Get
                Return _ID_MONEDA
            End Get
            Set(ByVal value As Integer)
                _ID_MONEDA = value
            End Set
        End Property
        Private _U_MEDIDA As String
        Public Property U_MEDIDA() As String
            Get
                Return _U_MEDIDA
            End Get
            Set(ByVal value As String)
                _U_MEDIDA = value
            End Set
        End Property
        Private _EXISTENCIAS As Integer
        Public Property EXISTENCIAS() As Integer
            Get
                Return _EXISTENCIAS
            End Get
            Set(ByVal value As Integer)
                _EXISTENCIAS = value
            End Set
        End Property
        Private _PRECIO_COMPRA As Decimal
        Public Property PRECIO_COMPRA() As Decimal
            Get
                Return _PRECIO_COMPRA
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_COMPRA = value
            End Set
        End Property
        Private _PRECIO_VENTA As Decimal
        Public Property PRECIO_VENTA() As Decimal
            Get
                Return _PRECIO_VENTA
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_VENTA = value
            End Set
        End Property
        Private _F_INGRESO As Date
        Public Property NewProperty() As Date
            Get
                Return _F_INGRESO
            End Get
            Set(ByVal value As Date)
                _F_INGRESO = value
            End Set
        End Property
        Private _FOTO As Byte
        Public Property FOTO() As Byte
            Get
                Return _FOTO
            End Get
            Set(ByVal value As Byte)
                _FOTO = value
            End Set
        End Property
        Private _ACTIVO As Boolean
        Public Property ACTIVO() As Boolean
            Get
                Return _ACTIVO
            End Get
            Set(ByVal value As Boolean)
                _ACTIVO = value
            End Set
        End Property
        Private _P_VERSION As Object
        Public Property P_VERSION() As Object
            Get
                Return _P_VERSION
            End Get
            Set(ByVal value As Object)
                _P_VERSION = value
            End Set
        End Property
    End Class
    Public Class BANCOS
        Private _ID_BANCO As Integer
        Public Property ID_BANCO() As Integer
            Get
                Return _ID_BANCO
            End Get
            Set(ByVal value As Integer)
                _ID_BANCO = value
            End Set
        End Property
        Private _NOMBRE As String
        Public Property NOMBRE() As String
            Get
                Return _NOMBRE
            End Get
            Set(ByVal value As String)
                _NOMBRE = value
            End Set
        End Property
    End Class
    Public Class CATEGORIAS
        Private _ID_CATEGORIA As Integer
        Public Property ID_CATEGORIA() As Integer
            Get
                Return _ID_CATEGORIA
            End Get
            Set(ByVal value As Integer)
                _ID_CATEGORIA = value
            End Set
        End Property
        Private _NOMBRE As String
        Public Property NOMBRE() As String
            Get
                Return _NOMBRE
            End Get
            Set(ByVal value As String)
                _NOMBRE = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
    End Class
    Public Class CENTRO_COSTOS
        Private _ID_CENTRO_COSTOS As Integer
        Public Property ID_CENTRO_COSTOS() As Integer
            Get
                Return _ID_CENTRO_COSTOS
            End Get
            Set(ByVal value As Integer)
                _ID_CENTRO_COSTOS = value
            End Set
        End Property
        Private _ID_PROYECTO As Integer
        Public Property ID_PROYECTO() As Integer
            Get
                Return _ID_PROYECTO
            End Get
            Set(ByVal value As Integer)
                _ID_PROYECTO = value
            End Set
        End Property
        Private _ID_MONEDA As Integer
        Public Property ID_MONEDA() As Integer
            Get
                Return _ID_MONEDA
            End Get
            Set(ByVal value As Integer)
                _ID_MONEDA = value
            End Set
        End Property
        Private _TOTAL As Decimal
        Public Property TOTAL() As Decimal
            Get
                Return _TOTAL
            End Get
            Set(ByVal value As Decimal)
                _TOTAL = value
            End Set
        End Property
        Private _ACTIVO As Boolean
        Public Property ACTIVO() As Boolean
            Get
                Return _ACTIVO
            End Get
            Set(ByVal value As Boolean)
                _ACTIVO = value
            End Set
        End Property
    End Class
    Public Class DEPARTAMENTOS
        Private _ID_DEPARTAMENTO As Integer
        Public Property ID_DEPARTAMENTO() As Integer
            Get
                Return _ID_DEPARTAMENTO
            End Get
            Set(ByVal value As Integer)
                _ID_DEPARTAMENTO = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Private _ID_ROL As Integer
        Public Property ID_ROL() As Integer
            Get
                Return _ID_ROL
            End Get
            Set(ByVal value As Integer)
                _ID_ROL = value
            End Set
        End Property
    End Class
    Public Class EMPLEADOS
        Private _DNI_EMPLEADO As String
        Public Property DNI_EMPLEADO() As String
            Get
                Return _DNI_EMPLEADO
            End Get
            Set(ByVal value As String)
                _DNI_EMPLEADO = value
            End Set
        End Property
        Private _NOMBRES As String
        Public Property NOMBRES() As String
            Get
                Return _NOMBRES
            End Get
            Set(ByVal value As String)
                _NOMBRES = value
            End Set
        End Property
        Private _APELLIDOS As String
        Public Property APELLIDOS() As String
            Get
                Return _APELLIDOS
            End Get
            Set(ByVal value As String)
                _APELLIDOS = value
            End Set
        End Property
        Private _RUC As String
        Public Property RUC() As String
            Get
                Return _RUC
            End Get
            Set(ByVal value As String)
                _RUC = value
            End Set
        End Property
        Private _ID_NACIONALIDAD As Integer
        Public Property ID_NACIONALIDAD() As Integer
            Get
                Return _ID_NACIONALIDAD
            End Get
            Set(ByVal value As Integer)
                _ID_NACIONALIDAD = value
            End Set
        End Property
        Private _ID_DEPARTAMENTO As Integer
        Public Property ID_DEPARTAMENTO() As Integer
            Get
                Return _ID_DEPARTAMENTO
            End Get
            Set(ByVal value As Integer)
                _ID_DEPARTAMENTO = value
            End Set
        End Property
        Private _FECHA_INGRESO As Date
        Public Property FECHA_INGRESO() As Date
            Get
                Return _FECHA_INGRESO
            End Get
            Set(ByVal value As Date)
                _FECHA_INGRESO = value
            End Set
        End Property
        Private _DIRECCION As String
        Public Property DIRECCION() As String
            Get
                Return _DIRECCION
            End Get
            Set(ByVal value As String)
                _DIRECCION = value
            End Set
        End Property
        Private _TELEFONO As String
        Public Property TELEFONO() As String
            Get
                Return _TELEFONO
            End Get
            Set(ByVal value As String)
                _TELEFONO = value
            End Set
        End Property
        Private _MOVIL1 As String
        Public Property MOVIL1() As String
            Get
                Return _MOVIL1
            End Get
            Set(ByVal value As String)
                _MOVIL1 = value
            End Set
        End Property
        Private _MOVIL2 As String
        Public Property MOVIL2() As String
            Get
                Return _MOVIL2
            End Get
            Set(ByVal value As String)
                _MOVIL2 = value
            End Set
        End Property
        Private _EMAIL As String
        Public Property EMAIL() As String
            Get
                Return _EMAIL
            End Get
            Set(ByVal value As String)
                _EMAIL = value
            End Set
        End Property
        Private _EMAIL_CORPORATIVO As String
        Public Property EMAIL_CORPORATIVO() As String
            Get
                Return _EMAIL_CORPORATIVO
            End Get
            Set(ByVal value As String)
                _EMAIL_CORPORATIVO = value
            End Set
        End Property
        Private _ACTIVO As Boolean
        Public Property ACTIVO() As Boolean
            Get
                Return _ACTIVO
            End Get
            Set(ByVal value As Boolean)
                _ACTIVO = value
            End Set
        End Property
        Private _E_VERSION As Object
        Public Property E_VERSION() As Object
            Get
                Return _E_VERSION
            End Get
            Set(ByVal value As Object)
                _E_VERSION = value
            End Set
        End Property
    End Class
    Public Class GANANCIAS
        Private _ID_GANANCIA As Integer
        Public Property ID_GANANCIA() As Integer
            Get
                Return _ID_GANANCIA
            End Get
            Set(ByVal value As Integer)
                _ID_GANANCIA = value
            End Set
        End Property
        Private _MES As String
        Public Property MES() As String
            Get
                Return _MES
            End Get
            Set(ByVal value As String)
                _MES = value
            End Set
        End Property
        Private _ANIO As String
        Public Property ANIO() As String
            Get
                Return _ANIO
            End Get
            Set(ByVal value As String)
                _ANIO = value
            End Set
        End Property
        Private _ID_MONEDA As Integer
        Public Property ID_MONEDA() As Integer
            Get
                Return _ID_MONEDA
            End Get
            Set(ByVal value As Integer)
                _ID_MONEDA = value
            End Set
        End Property
        Private _GANANCIA As Decimal
        Public Property GANANCIA() As Decimal
            Get
                Return _GANANCIA
            End Get
            Set(ByVal value As Decimal)
                _GANANCIA = value
            End Set
        End Property
    End Class
    Public Class GASTOS
        Private _ID_GASTO As Integer
        Public Property ID_GASTO() As Integer
            Get
                Return _ID_GASTO
            End Get
            Set(ByVal value As Integer)
                _ID_GASTO = value
            End Set
        End Property
        Private _ID_CENTRO_COSTOS As Integer
        Public Property ID_CENTRO_COSTOS() As Integer
            Get
                Return _ID_CENTRO_COSTOS
            End Get
            Set(ByVal value As Integer)
                _ID_CENTRO_COSTOS = value
            End Set
        End Property
        Private _ID_TIPO_GASTO As Integer
        Public Property ID_TIPO_GASTO() As Integer
            Get
                Return _ID_TIPO_GASTO
            End Get
            Set(ByVal value As Integer)
                _ID_TIPO_GASTO = value
            End Set
        End Property
        Private _DNI_EMPLEADO As String
        Public Property DNI_EMPLEADO() As String
            Get
                Return _DNI_EMPLEADO
            End Get
            Set(ByVal value As String)
                _DNI_EMPLEADO = value
            End Set
        End Property
        Private _ID_PERSONA As Integer
        Public Property ID_PERSONA() As Integer
            Get
                Return _ID_PERSONA
            End Get
            Set(ByVal value As Integer)
                _ID_PERSONA = value
            End Set
        End Property
        Private _FECHA As Date
        Public Property FECHA() As Date
            Get
                Return _FECHA
            End Get
            Set(ByVal value As Date)
                _FECHA = value
            End Set
        End Property
        Private _ID_COMPROBANTE As Integer
        Public Property ID_COMPROBANTE() As Integer
            Get
                Return _ID_COMPROBANTE
            End Get
            Set(ByVal value As Integer)
                _ID_COMPROBANTE = value
            End Set
        End Property
        Private _NUM_COMPROBANTE As String
        Public Property NUM_COMPROBANTE() As String
            Get
                Return _NUM_COMPROBANTE
            End Get
            Set(ByVal value As String)
                _NUM_COMPROBANTE = value
            End Set
        End Property
        Private _ID_MONEDA As Integer
        Public Property ID_MONEDA() As Integer
            Get
                Return _ID_MONEDA
            End Get
            Set(ByVal value As Integer)
                _ID_MONEDA = value
            End Set
        End Property
        Private _TIPO_CAMBIO As Decimal
        Public Property TIPO_CAMBIO() As Decimal
            Get
                Return _TIPO_CAMBIO
            End Get
            Set(ByVal value As Decimal)
                _TIPO_CAMBIO = value
            End Set
        End Property
        Private _SUBTOTAL As Decimal
        Public Property SUBTOTAL() As Decimal
            Get
                Return _SUBTOTAL
            End Get
            Set(ByVal value As Decimal)
                _SUBTOTAL = value
            End Set
        End Property
        Private _IGV As Decimal
        Public Property IGV() As Decimal
            Get
                Return _IGV
            End Get
            Set(ByVal value As Decimal)
                _IGV = value
            End Set
        End Property
        Private _TOTAL As Decimal
        Public Property TOTAL() As Decimal
            Get
                Return _TOTAL
            End Get
            Set(ByVal value As Decimal)
                _TOTAL = value
            End Set
        End Property
        Private _ACTIVO As Boolean
        Public Property ACTIVO() As Boolean
            Get
                Return _ACTIVO
            End Get
            Set(ByVal value As Boolean)
                _ACTIVO = value
            End Set
        End Property
        Private _G_VERSION As Object
        Public Property G_VERSION() As Object
            Get
                Return _G_VERSION
            End Get
            Set(ByVal value As Object)
                _G_VERSION = value
            End Set
        End Property
        ''DETALLE
        Private _ID_DET_GASTO As Integer
        Public Property ID_DET_GASTO() As Integer
            Get
                Return _ID_DET_GASTO
            End Get
            Set(ByVal value As Integer)
                _ID_DET_GASTO = value
            End Set
        End Property
        Private _DET_ID_GASTO As Integer 'ID_GASTO FK
        Public Property DET_ID_GASTO() As Integer
            Get
                Return _DET_ID_GASTO
            End Get
            Set(ByVal value As Integer)
                _DET_ID_GASTO = value
            End Set
        End Property
        Private _ID_ARTICULO As Integer
        Public Property ID_ARTICULO() As Integer
            Get
                Return _ID_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_ARTICULO = value
            End Set
        End Property
        Private _ID_SERVICIO As Integer
        Public Property ID_SERVICIO() As Integer
            Get
                Return _ID_SERVICIO
            End Get
            Set(ByVal value As Integer)
                _ID_SERVICIO = value
            End Set
        End Property
        Private _CANTIDAD As Integer
        Public Property CANTIDAD() As Integer
            Get
                Return _CANTIDAD
            End Get
            Set(ByVal value As Integer)
                _CANTIDAD = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Private _PRECIO_UNITARIO As Decimal
        Public Property PRECIO_UNITARIO() As Decimal
            Get
                Return _PRECIO_UNITARIO
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_UNITARIO = value
            End Set
        End Property
        Private _VALOR_VENTA As Decimal
        Public Property VALOR_VENTA() As Decimal
            Get
                Return _VALOR_VENTA
            End Get
            Set(ByVal value As Decimal)
                _VALOR_VENTA = value
            End Set
        End Property
        Private _NOTAS As String
        Public Property NOTAS() As String
            Get
                Return _NOTAS
            End Get
            Set(ByVal value As String)
                _NOTAS = value
            End Set
        End Property
    End Class
    Public Class DET_GASTOS
        Private _ID_DET_GASTO As Integer
        Public Property ID_DET_GASTO() As Integer
            Get
                Return _ID_DET_GASTO
            End Get
            Set(ByVal value As Integer)
                _ID_DET_GASTO = value
            End Set
        End Property
        Private _DET_ID_GASTO As Integer 'ID_GASTO FK
        Public Property DET_ID_GASTO() As Integer
            Get
                Return _DET_ID_GASTO
            End Get
            Set(ByVal value As Integer)
                _DET_ID_GASTO = value
            End Set
        End Property
        Private _ID_ARTICULO As Integer
        Public Property ID_ARTICULO() As Integer
            Get
                Return _ID_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_ARTICULO = value
            End Set
        End Property
        Private _ID_SERVICIO As Integer
        Public Property ID_SERVICIO() As Integer
            Get
                Return _ID_SERVICIO
            End Get
            Set(ByVal value As Integer)
                _ID_SERVICIO = value
            End Set
        End Property
        Private _CANTIDAD As Integer
        Public Property CANTIDAD() As Integer
            Get
                Return _CANTIDAD
            End Get
            Set(ByVal value As Integer)
                _CANTIDAD = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Private _PRECIO_UNITARIO As Decimal
        Public Property PRECIO_UNITARIO() As Decimal
            Get
                Return _PRECIO_UNITARIO
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_UNITARIO = value
            End Set
        End Property
        Private _VALOR_VENTA As Decimal
        Public Property VALOR_VENTA() As Decimal
            Get
                Return _VALOR_VENTA
            End Get
            Set(ByVal value As Decimal)
                _VALOR_VENTA = value
            End Set
        End Property
        Private _NOTAS As String
        Public Property NOTAS() As String
            Get
                Return _NOTAS
            End Get
            Set(ByVal value As String)
                _NOTAS = value
            End Set
        End Property
    End Class
    Public Class INGRESOS_ARTICULOS
        Private _ID_INGRESO As Integer
        Public Property ID_INGRESO() As Integer
            Get
                Return _ID_INGRESO
            End Get
            Set(ByVal value As Integer)
                _ID_INGRESO = value
            End Set
        End Property
        Private _ID_GASTO As Integer
        Public Property ID_GASTO() As Integer
            Get
                Return _ID_GASTO
            End Get
            Set(ByVal value As Integer)
                _ID_GASTO = value
            End Set
        End Property
        Private _DNI_EMPLEADO As String
        Public Property DNI_EMPLEADO() As String
            Get
                Return _DNI_EMPLEADO
            End Get
            Set(ByVal value As String)
                _DNI_EMPLEADO = value
            End Set
        End Property
        Private _FECHA_INGRESO As Date
        Public Property FECHA_INGRESO() As Date
            Get
                Return _FECHA_INGRESO
            End Get
            Set(ByVal value As Date)
                _FECHA_INGRESO = value
            End Set
        End Property
        'DETALLE
        Private _ID_DETALLE_INGRESO As Integer
        Public Property ID_DETALLE_INGRESO() As Integer
            Get
                Return _ID_DETALLE_INGRESO
            End Get
            Set(ByVal value As Integer)
                _ID_DETALLE_INGRESO = value
            End Set
        End Property
        Private _DET_ID_INGRESO As Integer
        Public Property DET_ID_INGRESO() As Integer
            Get
                Return _DET_ID_INGRESO
            End Get
            Set(ByVal value As Integer)
                _DET_ID_INGRESO = value
            End Set
        End Property
        Private _ID_ARTICULO As Integer
        Public Property ID_ARTICULO() As Integer
            Get
                Return _ID_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_ARTICULO = value
            End Set
        End Property
        Private _PRECIO_COMPRA As Decimal
        Public Property PRECIO_COMPRA() As Decimal
            Get
                Return _PRECIO_COMPRA
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_COMPRA = value
            End Set
        End Property
        Private _PRECIO_VENTA As Decimal
        Public Property PRECIO_VENTA() As Decimal
            Get
                Return _PRECIO_VENTA
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_VENTA = value
            End Set
        End Property
        Private _CANTIDAD As Integer
        Public Property CANTIDAD() As Integer
            Get
                Return _CANTIDAD
            End Get
            Set(ByVal value As Integer)
                _CANTIDAD = value
            End Set
        End Property
    End Class
    Public Class DET_INGRESOS_ARTICULOS
        Private _ID_DETALLE_INGRESO As Integer
        Public Property ID_DETALLE_INGRESO() As Integer
            Get
                Return _ID_DETALLE_INGRESO
            End Get
            Set(ByVal value As Integer)
                _ID_DETALLE_INGRESO = value
            End Set
        End Property
        Private _DET_ID_INGRESO As Integer
        Public Property DET_ID_INGRESO() As Integer
            Get
                Return _DET_ID_INGRESO
            End Get
            Set(ByVal value As Integer)
                _DET_ID_INGRESO = value
            End Set
        End Property
        Private _ID_ARTICULO As Integer
        Public Property ID_ARTICULO() As Integer
            Get
                Return _ID_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_ARTICULO = value
            End Set
        End Property
        Private _PRECIO_COMPRA As Decimal
        Public Property PRECIO_COMPRA() As Decimal
            Get
                Return _PRECIO_COMPRA
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_COMPRA = value
            End Set
        End Property
        Private _PRECIO_VENTA As Decimal
        Public Property PRECIO_VENTA() As Decimal
            Get
                Return _PRECIO_VENTA
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_VENTA = value
            End Set
        End Property
        Private _CANTIDAD As Integer
        Public Property CANTIDAD() As Integer
            Get
                Return _CANTIDAD
            End Get
            Set(ByVal value As Integer)
                _CANTIDAD = value
            End Set
        End Property
    End Class
    Public Class MONEDAS
        Private _ID_MONEDA As Integer
        Public Property ID_MONEDA() As Integer
            Get
                Return _ID_MONEDA
            End Get
            Set(ByVal value As Integer)
                _ID_MONEDA = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
    End Class
    Public Class NACIONALIDADES
        Private _ID_NACIONALIDAD As Integer
        Public Property ID_NACIONALIDAD() As Integer
            Get
                Return _ID_NACIONALIDAD
            End Get
            Set(ByVal value As Integer)
                _ID_NACIONALIDAD = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
    End Class
    Public Class PERSONAS
        Private _ID_PERSONA As Integer
        Public Property ID_PERSONA() As Integer
            Get
                Return _ID_PERSONA
            End Get
            Set(ByVal value As Integer)
                _ID_PERSONA = value
            End Set
        End Property
        Private _ID_TIPO_PERSONA As Integer
        Public Property ID_TIPO_PERSONA() As Integer
            Get
                Return _ID_TIPO_PERSONA
            End Get
            Set(ByVal value As Integer)
                _ID_TIPO_PERSONA = value
            End Set
        End Property
        Private _NUM_DOCUMENTO As String
        Public Property NUM_DOCUMENTO() As String
            Get
                Return _NUM_DOCUMENTO
            End Get
            Set(ByVal value As String)
                _NUM_DOCUMENTO = value
            End Set
        End Property
        Private _RAZON_SOCIAL As String
        Public Property RAZON_SOCIAL() As String
            Get
                Return _RAZON_SOCIAL
            End Get
            Set(ByVal value As String)
                _RAZON_SOCIAL = value
            End Set
        End Property
        Private _NOMBRE_COMERCIAL As String
        Public Property NOMBRE_COMERCIAL() As String
            Get
                Return _NOMBRE_COMERCIAL
            End Get
            Set(ByVal value As String)
                _NOMBRE_COMERCIAL = value
            End Set
        End Property
        Private _ID_NACIONALIDAD As Integer
        Public Property ID_NACIONALIDAD() As Integer
            Get
                Return _ID_NACIONALIDAD
            End Get
            Set(ByVal value As Integer)
                _ID_NACIONALIDAD = value
            End Set
        End Property
        Private _DIRECCION As String
        Public Property DIRECCION() As String
            Get
                Return _DIRECCION
            End Get
            Set(ByVal value As String)
                _DIRECCION = value
            End Set
        End Property
        Private _TELEFONO As String
        Public Property TELEFONO() As String
            Get
                Return _TELEFONO
            End Get
            Set(ByVal value As String)
                _TELEFONO = value
            End Set
        End Property
        Private _MOVIL1 As String
        Public Property MOVIL1() As String
            Get
                Return _MOVIL1
            End Get
            Set(ByVal value As String)
                _MOVIL1 = value
            End Set
        End Property
        Private _MOVIL2 As String
        Public Property MOVIL2() As String
            Get
                Return _MOVIL2
            End Get
            Set(ByVal value As String)
                _MOVIL2 = value
            End Set
        End Property
        Private _EMAIL As String
        Public Property EMAIL() As String
            Get
                Return _EMAIL
            End Get
            Set(ByVal value As String)
                _EMAIL = value
            End Set
        End Property
        Private _ID_PERSONA_PADRE As Integer
        Public Property ID_PERSONA_PADRE() As Integer
            Get
                Return _ID_PERSONA_PADRE
            End Get
            Set(ByVal value As Integer)
                _ID_PERSONA_PADRE = value
            End Set
        End Property
        Private _NOMBRE_PADRE As String
        Public Property NOMBRE_PADRE() As String
            Get
                Return _NOMBRE_PADRE
            End Get
            Set(ByVal value As String)
                _NOMBRE_PADRE = value
            End Set
        End Property
        Private _CARGO As String
        Public Property CARGO() As String
            Get
                Return _CARGO
            End Get
            Set(ByVal value As String)
                _CARGO = value
            End Set
        End Property
        Private _ACTIVO As Boolean
        Public Property ACTIVO() As Boolean
            Get
                Return _ACTIVO
            End Get
            Set(ByVal value As Boolean)
                _ACTIVO = value
            End Set
        End Property
        Private _P_VERSION As Object
        Public Property P_VERSION() As Object
            Get
                Return _P_VERSION
            End Get
            Set(ByVal value As Object)
                _P_VERSION = value
            End Set
        End Property
        'DETALLE
        Private _ID_DET_PERSONA As Integer
        Public Property ID_DET_PERSONA() As Integer
            Get
                Return _ID_DET_PERSONA
            End Get
            Set(ByVal value As Integer)
                _ID_DET_PERSONA = value
            End Set
        End Property
        Private _DET_ID_PERSONA As Integer
        Public Property DET_ID_PERSONA() As Integer
            Get
                Return _DET_ID_PERSONA
            End Get
            Set(ByVal value As Integer)
                _DET_ID_PERSONA = value
            End Set
        End Property
        Private _ID_BANCO As Integer
        Public Property ID_BANCO() As Integer
            Get
                Return _ID_BANCO
            End Get
            Set(ByVal value As Integer)
                _ID_BANCO = value
            End Set
        End Property
        Private _NOMBRE_BANCO As String
        Public Property NOMBRE_BANCO() As String
            Get
                Return _NOMBRE_BANCO
            End Get
            Set(ByVal value As String)
                _NOMBRE_BANCO = value
            End Set
        End Property
        Private _ID_MONEDA As Integer
        Public Property ID_MONEDA() As Integer
            Get
                Return _ID_MONEDA
            End Get
            Set(ByVal value As Integer)
                _ID_MONEDA = value
            End Set
        End Property
        Private _NOMBRE_MONEDA As String
        Public Property NOMBRE_MONEDA() As String
            Get
                Return _NOMBRE_MONEDA
            End Get
            Set(ByVal value As String)
                _NOMBRE_MONEDA = value
            End Set
        End Property
        Private _NUM_CUENTA As String
        Public Property NUM_CUENTA() As String
            Get
                Return _NUM_CUENTA
            End Get
            Set(ByVal value As String)
                _NUM_CUENTA = value
            End Set
        End Property
        Private _NOTAS As String
        Public Property NOTAS() As String
            Get
                Return _NOTAS
            End Get
            Set(ByVal value As String)
                _NOTAS = value
            End Set
        End Property
    End Class
    Public Class DET_PERSONAS
        Private _ID_DET_PERSONA As Integer
        Public Property ID_DET_PERSONA() As Integer
            Get
                Return _ID_DET_PERSONA
            End Get
            Set(ByVal value As Integer)
                _ID_DET_PERSONA = value
            End Set
        End Property
        Private _DET_ID_PERSONA As Integer
        Public Property DET_ID_PERSONA() As Integer
            Get
                Return _DET_ID_PERSONA
            End Get
            Set(ByVal value As Integer)
                _DET_ID_PERSONA = value
            End Set
        End Property
        Private _ID_BANCO As Integer
        Public Property ID_BANCO() As Integer
            Get
                Return _ID_BANCO
            End Get
            Set(ByVal value As Integer)
                _ID_BANCO = value
            End Set
        End Property
        Private _NOMBRE_B As String
        Public Property NOMBRE_B() As String
            Get
                Return _NOMBRE_B
            End Get
            Set(ByVal value As String)
                _NOMBRE_B = value
            End Set
        End Property
        Private _ID_MONEDA As Integer
        Public Property ID_MONEDA() As Integer
            Get
                Return _ID_MONEDA
            End Get
            Set(ByVal value As Integer)
                _ID_MONEDA = value
            End Set
        End Property
        Private _NOMBRE_M As String
        Public Property NOMBRE_M() As String
            Get
                Return _NOMBRE_M
            End Get
            Set(ByVal value As String)
                _NOMBRE_M = value
            End Set
        End Property
        Private _NUM_CUENTA As String
        Public Property NUM_CUENTA() As String
            Get
                Return _NUM_CUENTA
            End Get
            Set(ByVal value As String)
                _NUM_CUENTA = value
            End Set
        End Property
        Private _NOTAS As String
        Public Property NOTAS() As String
            Get
                Return _NOTAS
            End Get
            Set(ByVal value As String)
                _NOTAS = value
            End Set
        End Property
    End Class
    Public Class PROYECTOS
        Private _ID_PROYECTO As Integer
        Public Property ID_PROYECTO() As Integer
            Get
                Return _ID_PROYECTO
            End Get
            Set(ByVal value As Integer)
                _ID_PROYECTO = value
            End Set
        End Property
        Private _NOMBRE As String
        Public Property NOMBRE() As String
            Get
                Return _NOMBRE
            End Get
            Set(ByVal value As String)
                _NOMBRE = value
            End Set
        End Property
        Private _UNICACION As String
        Public Property UBICACION() As String
            Get
                Return _UNICACION
            End Get
            Set(ByVal value As String)
                _UNICACION = value
            End Set
        End Property
        Private _FECHA_INICIO As Date
        Public Property FECHA_INICIO() As Date
            Get
                Return _FECHA_INICIO
            End Get
            Set(ByVal value As Date)
                _FECHA_INICIO = value
            End Set
        End Property
        Private _FECHA_FIN As Date
        Public Property FECHA_FIN() As Date
            Get
                Return _FECHA_FIN
            End Get
            Set(ByVal value As Date)
                _FECHA_FIN = value
            End Set
        End Property
    End Class
    Public Class ROLES
        Private _ID_ROL As Integer
        Public Property ID_ROL() As Integer
            Get
                Return _ID_ROL
            End Get
            Set(ByVal value As Integer)
                _ID_ROL = value
            End Set
        End Property
        Private _NOMBRE_ROL As String
        Public Property NOMBRE_ROL() As String
            Get
                Return _NOMBRE_ROL
            End Get
            Set(ByVal value As String)
                _NOMBRE_ROL = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
    End Class
    Public Class ROLES_DEPARTAMENTOS
        Private _ID_ROL As Integer
        Public Property ID_ROL() As Integer
            Get
                Return _ID_ROL
            End Get
            Set(ByVal value As Integer)
                _ID_ROL = value
            End Set
        End Property
        Private _ID_DEPARTAMENTO As Integer
        Public Property ID_DEPARTAMENTO() As Integer
            Get
                Return _ID_DEPARTAMENTO
            End Get
            Set(ByVal value As Integer)
                _ID_DEPARTAMENTO = value
            End Set
        End Property
    End Class
    Public Class SALIDAS_ARTICULOS
        Private _ID_SALIDA As Integer
        Public Property ID_SALIDA() As Integer
            Get
                Return _ID_SALIDA
            End Get
            Set(ByVal value As Integer)
                _ID_SALIDA = value
            End Set
        End Property
        Private _ID_VENTA As Integer
        Public Property ID_VENTA() As Integer
            Get
                Return _ID_VENTA
            End Get
            Set(ByVal value As Integer)
                _ID_VENTA = value
            End Set
        End Property
        Private _DNI_EMPLEADO As String
        Public Property DNI_EMPLEADO() As String
            Get
                Return _DNI_EMPLEADO
            End Get
            Set(ByVal value As String)
                _DNI_EMPLEADO = value
            End Set
        End Property
        Private _ID_PERSONA As Integer
        Public Property ID_PERSONA() As Integer
            Get
                Return _ID_PERSONA
            End Get
            Set(ByVal value As Integer)
                _ID_PERSONA = value
            End Set
        End Property
        Private _FECHA_SALIDA As Date
        Public Property FECHA_SALIDA() As Date
            Get
                Return _FECHA_SALIDA
            End Get
            Set(ByVal value As Date)
                _FECHA_SALIDA = value
            End Set
        End Property
        'DETALLE
        Private _ID_DET_SALIDA As Integer
        Public Property ID_DET_SALIDA() As Integer
            Get
                Return _ID_DET_SALIDA
            End Get
            Set(ByVal value As Integer)
                _ID_DET_SALIDA = value
            End Set
        End Property
        Private _DET_ID_SALIDA As Integer
        Public Property DET_ID_SALIDA() As Integer
            Get
                Return _DET_ID_SALIDA
            End Get
            Set(ByVal value As Integer)
                _DET_ID_SALIDA = value
            End Set
        End Property
        Private _ID_ARTICULO As Integer
        Public Property ID_ARTICULO() As Integer
            Get
                Return _ID_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_ARTICULO = value
            End Set
        End Property
        Private _PRECIO_ARTICULO As Decimal
        Public Property PRECIO_ARTICULO() As Decimal
            Get
                Return _PRECIO_ARTICULO
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_ARTICULO = value
            End Set
        End Property
        Private _CANTIDAD As Integer
        Public Property CANTIDAD() As Integer
            Get
                Return _CANTIDAD
            End Get
            Set(ByVal value As Integer)
                _CANTIDAD = value
            End Set
        End Property
    End Class
    Public Class DET_SALIDAS_ARTICULOS
        Private _ID_DET_SALIDA As Integer
        Public Property ID_DET_SALIDA() As Integer
            Get
                Return _ID_DET_SALIDA
            End Get
            Set(ByVal value As Integer)
                _ID_DET_SALIDA = value
            End Set
        End Property
        Private _DET_ID_SALIDA As Integer
        Public Property DET_ID_SALIDA() As Integer
            Get
                Return _DET_ID_SALIDA
            End Get
            Set(ByVal value As Integer)
                _DET_ID_SALIDA = value
            End Set
        End Property
        Private _ID_ARTICULO As Integer
        Public Property ID_ARTICULO() As Integer
            Get
                Return _ID_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_ARTICULO = value
            End Set
        End Property
        Private _PRECIO_ARTICULO As Decimal
        Public Property PRECIO_ARTICULO() As Decimal
            Get
                Return _PRECIO_ARTICULO
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_ARTICULO = value
            End Set
        End Property
        Private _CANTIDAD As Integer
        Public Property CANTIDAD() As Integer
            Get
                Return _CANTIDAD
            End Get
            Set(ByVal value As Integer)
                _CANTIDAD = value
            End Set
        End Property
    End Class
    Public Class SERVICIOS
        Private _ID_SERVICIO As Integer
        Public Property ID_SERVICIO() As Integer
            Get
                Return _ID_SERVICIO
            End Get
            Set(ByVal value As Integer)
                _ID_SERVICIO = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
    End Class
    Public Class TAREOS
        Private _ID_TAREO As Integer
        Public Property ID_TAREO() As Integer
            Get
                Return _ID_TAREO
            End Get
            Set(ByVal value As Integer)
                _ID_TAREO = value
            End Set
        End Property
        Private _DNI_EMPLEADO As String
        Public Property DNI_EMPLEADO() As String
            Get
                Return _DNI_EMPLEADO
            End Get
            Set(ByVal value As String)
                _DNI_EMPLEADO = value
            End Set
        End Property
        Private _FECHA As Date
        Public Property FECHA() As Date
            Get
                Return _FECHA
            End Get
            Set(ByVal value As Date)
                _FECHA = value
            End Set
        End Property
        Private _ID_PROYECTO As Integer
        Public Property ID_PROYECTO() As Integer
            Get
                Return _ID_PROYECTO
            End Get
            Set(ByVal value As Integer)
                _ID_PROYECTO = value
            End Set
        End Property
        Private _ACTIVIDAD_REALIZADA As String
        Public Property ACTIVIDAD_REALIZADA() As String
            Get
                Return _ACTIVIDAD_REALIZADA
            End Get
            Set(ByVal value As String)
                _ACTIVIDAD_REALIZADA = value
            End Set
        End Property
        Private _HORAS_DEDICADAS As Byte
        Public Property HORAS_DEDICADAS() As Byte
            Get
                Return _HORAS_DEDICADAS
            End Get
            Set(ByVal value As Byte)
                _HORAS_DEDICADAS = value
            End Set
        End Property
        Private _OBSERVACIONES As String
        Public Property OBSERVACIONES() As String
            Get
                Return _OBSERVACIONES
            End Get
            Set(ByVal value As String)
                _OBSERVACIONES = value
            End Set
        End Property
        Private _T_VERSION As Object
        Public Property T_VERSION() As Object
            Get
                Return _T_VERSION
            End Get
            Set(ByVal value As Object)
                _T_VERSION = value
            End Set
        End Property
    End Class
    Public Class TIPOS_ARTICULOS
        Private _ID_TIPO_ARTICULO As Integer
        Public Property ID_TIPO_ARTICULO() As Integer
            Get
                Return _ID_TIPO_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_TIPO_ARTICULO = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
    End Class
    Public Class TIPOS_COMPROBANTES
        Private _ID_COMPROBANTE As Integer
        Public Property ID_COMPROBANTE() As Integer
            Get
                Return _ID_COMPROBANTE
            End Get
            Set(ByVal value As Integer)
                _ID_COMPROBANTE = value
            End Set
        End Property
        Private _NOMBRE As String
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
    End Class
    Public Class TIPOS_GASTOS
        Private _ID_TIPO_GASTO As Integer
        Public Property ID_TIPO_GASTO() As Integer
            Get
                Return _ID_TIPO_GASTO
            End Get
            Set(ByVal value As Integer)
                _ID_TIPO_GASTO = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
    End Class
    Public Class TIPOS_PERSONAS
        Private _ID_TIPO_P As Integer
        Public Property ID_TIPO_P() As Integer
            Get
                Return _ID_TIPO_P
            End Get
            Set(ByVal value As Integer)
                _ID_TIPO_P = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
    End Class
    Public Class USUARIOS
        Private _DNI_EMPLEADO As String
        Public Property DNI_EMPLEADO() As String
            Get
                Return _DNI_EMPLEADO
            End Get
            Set(ByVal value As String)
                _DNI_EMPLEADO = value
            End Set
        End Property
        Private _USUARIO As String
        Public Property USUARIO() As String
            Get
                Return _USUARIO
            End Get
            Set(ByVal value As String)
                _USUARIO = value
            End Set
        End Property
        Private _CONTRASENIA As String
        Public Property CONTRASENIA() As String
            Get
                Return _CONTRASENIA
            End Get
            Set(ByVal value As String)
                _CONTRASENIA = value
            End Set
        End Property
        Private _PERMISOS_ESPECIALES As String
        Public Property PERMISOS_ESPECIALES() As String
            Get
                Return _PERMISOS_ESPECIALES
            End Get
            Set(ByVal value As String)
                _PERMISOS_ESPECIALES = value
            End Set
        End Property
        Private _ID_DEPARTAMENTO As Integer
        Public Property ID_DEPARTAMENTO() As Integer
            Get
                Return _ID_DEPARTAMENTO
            End Get
            Set(ByVal value As Integer)
                _ID_DEPARTAMENTO = value
            End Set
        End Property
        Private _ACTIVO As Boolean
        Public Property ACTIVO() As Boolean
            Get
                Return _ACTIVO
            End Get
            Set(ByVal value As Boolean)
                _ACTIVO = value
            End Set
        End Property
    End Class
    Public Class VENTAS
        Private _ID_VENTA As Integer
        Public Property ID_VENTA() As Integer
            Get
                Return _ID_VENTA
            End Get
            Set(ByVal value As Integer)
                _ID_VENTA = value
            End Set
        End Property
        Private _ID_COMPROBANTE As Integer
        Public Property ID_COMPROBANTE() As Integer
            Get
                Return _ID_COMPROBANTE
            End Get
            Set(ByVal value As Integer)
                _ID_COMPROBANTE = value
            End Set
        End Property
        Private _NUM_COMPROBANTE As String
        Public Property NUM_COMPROBANTE() As String
            Get
                Return _NUM_COMPROBANTE
            End Get
            Set(ByVal value As String)
                _NUM_COMPROBANTE = value
            End Set
        End Property
        Private _ID_PERSONA As Integer
        Public Property ID_PERSONA() As Integer
            Get
                Return _ID_PERSONA
            End Get
            Set(ByVal value As Integer)
                _ID_PERSONA = value
            End Set
        End Property
        Private _DNI_EMPLEADO As String
        Public Property DNI_EMPLEADO() As String
            Get
                Return _DNI_EMPLEADO
            End Get
            Set(ByVal value As String)
                _DNI_EMPLEADO = value
            End Set
        End Property
        Private _FECHA As Date
        Public Property FECHA() As Date
            Get
                Return _FECHA
            End Get
            Set(ByVal value As Date)
                _FECHA = value
            End Set
        End Property
        Private _FECHA_VENCIMIENTO As Date
        Public Property FECHA_VENCIMIENTO() As Date
            Get
                Return _FECHA_VENCIMIENTO
            End Get
            Set(ByVal value As Date)
                _FECHA_VENCIMIENTO = value
            End Set
        End Property
        Private _TIPO_VENTA As String
        Public Property TIPO_VENTA() As String
            Get
                Return _TIPO_VENTA
            End Get
            Set(ByVal value As String)
                _TIPO_VENTA = value
            End Set
        End Property
        Private _ID_MONEDA As Integer
        Public Property ID_MONEDA() As Integer
            Get
                Return _ID_MONEDA
            End Get
            Set(ByVal value As Integer)
                _ID_MONEDA = value
            End Set
        End Property
        Private _TIPO_CAMBIO As Decimal
        Public Property TIPO_CAMBIO() As Decimal
            Get
                Return _TIPO_CAMBIO
            End Get
            Set(ByVal value As Decimal)
                _TIPO_CAMBIO = value
            End Set
        End Property
        Private _SUBTOTAL As Decimal
        Public Property SUBTOTAL() As Decimal
            Get
                Return _SUBTOTAL
            End Get
            Set(ByVal value As Decimal)
                _SUBTOTAL = value
            End Set
        End Property
        Private _IGV As Decimal
        Public Property IGV() As Decimal
            Get
                Return _IGV
            End Get
            Set(ByVal value As Decimal)
                _IGV = value
            End Set
        End Property
        Private _DETRACCION As Decimal
        Public Property DETRACCION() As Decimal
            Get
                Return _DETRACCION
            End Get
            Set(ByVal value As Decimal)
                _DETRACCION = value
            End Set
        End Property
        Private _TOTAL As Decimal
        Public Property TOTAL() As Decimal
            Get
                Return _TOTAL
            End Get
            Set(ByVal value As Decimal)
                _TOTAL = value
            End Set
        End Property
        Private _ESTADO As String
        Public Property ESTADO() As String
            Get
                Return _ESTADO
            End Get
            Set(ByVal value As String)
                _ESTADO = value
            End Set
        End Property
        Private _ACTIVO As Boolean
        Public Property ACTIVO() As Boolean
            Get
                Return _ACTIVO
            End Get
            Set(ByVal value As Boolean)
                _ACTIVO = value
            End Set
        End Property
        Private _V_VERSION As Object
        Public Property V_VERSION() As Object
            Get
                Return _V_VERSION
            End Get
            Set(ByVal value As Object)
                _V_VERSION = value
            End Set
        End Property
        'DETALLE
        Private _ID_DET_VENTA As Integer
        Public Property ID_DET_VENTA() As Integer
            Get
                Return _ID_DET_VENTA
            End Get
            Set(ByVal value As Integer)
                _ID_DET_VENTA = value
            End Set
        End Property
        Private _DET_ID_VENTA As Integer
        Public Property DET_ID_VENTA() As Integer
            Get
                Return _DET_ID_VENTA
            End Get
            Set(ByVal value As Integer)
                _DET_ID_VENTA = value
            End Set
        End Property
        Private _ID_ARTICULO As Integer
        Public Property ID_ARTICULO() As Integer
            Get
                Return _ID_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_ARTICULO = value
            End Set
        End Property
        Private _ID_SERVICIO As Integer
        Public Property ID_SERVICIO() As Integer
            Get
                Return _ID_SERVICIO
            End Get
            Set(ByVal value As Integer)
                _ID_SERVICIO = value
            End Set
        End Property
        Private _CANTIDAD As Integer
        Public Property CANTIDAD() As Integer
            Get
                Return _CANTIDAD
            End Get
            Set(ByVal value As Integer)
                _CANTIDAD = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Private _PRECIO_UNITARIO As Decimal
        Public Property PRECIO_UNITARIO() As Decimal
            Get
                Return _PRECIO_UNITARIO
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_UNITARIO = value
            End Set
        End Property
        Private _VALOR_VENTA As Decimal
        Public Property NewProperty() As Decimal
            Get
                Return _VALOR_VENTA
            End Get
            Set(ByVal value As Decimal)
                _VALOR_VENTA = value
            End Set
        End Property
        Private _NOTAS As String
        Public Property NOTAS() As String
            Get
                Return _NOTAS
            End Get
            Set(ByVal value As String)
                _NOTAS = value
            End Set
        End Property
    End Class
    Public Class DET_VENTAS
        Private _ID_DET_VENTA As Integer
        Public Property ID_DET_VENTA() As Integer
            Get
                Return _ID_DET_VENTA
            End Get
            Set(ByVal value As Integer)
                _ID_DET_VENTA = value
            End Set
        End Property
        Private _DET_ID_VENTA As Integer
        Public Property DET_ID_VENTA() As Integer
            Get
                Return _DET_ID_VENTA
            End Get
            Set(ByVal value As Integer)
                _DET_ID_VENTA = value
            End Set
        End Property
        Private _ID_ARTICULO As Integer
        Public Property ID_ARTICULO() As Integer
            Get
                Return _ID_ARTICULO
            End Get
            Set(ByVal value As Integer)
                _ID_ARTICULO = value
            End Set
        End Property
        Private _ID_SERVICIO As Integer
        Public Property ID_SERVICIO() As Integer
            Get
                Return _ID_SERVICIO
            End Get
            Set(ByVal value As Integer)
                _ID_SERVICIO = value
            End Set
        End Property
        Private _CANTIDAD As Integer
        Public Property CANTIDAD() As Integer
            Get
                Return _CANTIDAD
            End Get
            Set(ByVal value As Integer)
                _CANTIDAD = value
            End Set
        End Property
        Private _DESCRIPCION As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Private _PRECIO_UNITARIO As Decimal
        Public Property PRECIO_UNITARIO() As Decimal
            Get
                Return _PRECIO_UNITARIO
            End Get
            Set(ByVal value As Decimal)
                _PRECIO_UNITARIO = value
            End Set
        End Property
        Private _VALOR_VENTA As Decimal
        Public Property NewProperty() As Decimal
            Get
                Return _VALOR_VENTA
            End Get
            Set(ByVal value As Decimal)
                _VALOR_VENTA = value
            End Set
        End Property
        Private _NOTAS As String
        Public Property NOTAS() As String
            Get
                Return _NOTAS
            End Get
            Set(ByVal value As String)
                _NOTAS = value
            End Set
        End Property
    End Class

End Class
