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
End Class
