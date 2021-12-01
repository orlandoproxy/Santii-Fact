Public Class Periodos

    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Private _fechaImpresion As Date

    Public Property FechaInicial() As Date
        Get
            Return _fechaInicial
        End Get
        Set(value As Date)
            _fechaInicial = value
        End Set
    End Property

    Public Property FechaFinal() As Date
        Get
            Return _fechaFinal
        End Get
        Set(value As Date)
            _fechaFinal = value
        End Set
    End Property

    Public Property FechaImpresion() As Date
        Get
            Return _fechaImpresion
        End Get
        Set(value As Date)
            _fechaImpresion = value
        End Set
    End Property


End Class
