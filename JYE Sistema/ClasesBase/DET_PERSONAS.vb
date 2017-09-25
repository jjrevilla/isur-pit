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
