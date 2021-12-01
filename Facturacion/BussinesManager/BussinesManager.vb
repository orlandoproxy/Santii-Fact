Public Class BussinesManager
    Public Shared Function ValidarFechas(fechaInicial As Date, fechaFinal As Date) As Boolean

        If fechaFinal > fechaInicial Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function GetPeriodos(fechaInicial As Date, fechaFinal As Date, Periodo As String)
        'buscamos la diferencia de acuerdo los periodos
        Dim meses As Integer = DateDiff("m", fechaInicial, fechaFinal)
        Dim PeriodoNum = ParsePeriodo(Periodo)
        Dim PeriodosCount = meses / PeriodoNum
        Return PeriodosCount
    End Function

    Public Shared Function CalcNomina(fechaInicial As Date, fechaFinal As Date, NumPeridos As Integer, Perido As Integer, DiaCorte As Integer, PeriodoText As String, DiaImpresion As Integer)
        Dim ListaFechas As Object = New List(Of Periodos)
        Dim PeriodoNum = ParsePeriodo(PeriodoText)
        Dim periodoInicial As Periodos = New Periodos
        PeriodoNum -= 1
        Dim FechaPeriodoInicial As Date = fechaInicial
        Dim FechaPeriodoFinal As Date = New Date(fechaInicial.Year, fechaInicial.Month + PeriodoNum, 1)
        Dim FechaPeridoImpresion As Date = New Date(FechaPeriodoFinal.Year, FechaPeriodoFinal.Month, 1)
        Try
            FechaPeriodoFinal = New Date(FechaPeriodoFinal.Year, FechaPeriodoFinal.Month, DiaCorte)
        Catch ex As Exception
            FechaPeriodoFinal = FechaPeriodoFinal.AddMonths(1).AddDays(-1)
        End Try
        Try
            FechaPeridoImpresion = New Date(FechaPeriodoFinal.Year, FechaPeriodoFinal.Month, DiaImpresion)
        Catch ex As Exception
            FechaPeridoImpresion = FechaPeridoImpresion.AddMonths(1).AddDays(-1)
        End Try
        periodoInicial.FechaInicial = FechaPeriodoInicial
        periodoInicial.FechaFinal = FechaPeriodoFinal
        periodoInicial.FechaImpresion = FechaPeridoImpresion
        ListaFechas.add(periodoInicial)
        NumPeridos -= 1

        Do While NumPeridos >= 0
            periodoInicial = New Periodos
            'fecha inicial es un perido despues
            'FechaPeriodoInicial = New Date(FechaPeriodoFinal.Year, FechaPeriodoFinal.Month + 1, fechaInicial.Day)
            FechaPeriodoInicial = FechaPeriodoFinal.AddDays(1)
            Try
                FechaPeriodoFinal = New Date(FechaPeriodoInicial.Year, FechaPeriodoInicial.Month + PeriodoNum + 1, DiaCorte)
            Catch ex As Exception
                FechaPeriodoFinal = New Date(FechaPeriodoFinal.Year, FechaPeriodoFinal.Month + PeriodoNum + 1, 1)
                FechaPeriodoFinal = FechaPeriodoFinal.AddMonths(1).AddDays(-1)
            End Try
            Try
                FechaPeridoImpresion = New Date(FechaPeriodoFinal.Year, FechaPeriodoFinal.Month, DiaImpresion)
            Catch ex As Exception
                FechaPeridoImpresion = FechaPeridoImpresion.AddMonths(1).AddDays(-1)
            End Try
            periodoInicial.FechaInicial = FechaPeriodoInicial
            periodoInicial.FechaFinal = FechaPeriodoFinal
            periodoInicial.FechaImpresion = FechaPeridoImpresion
            ListaFechas.add(periodoInicial)
            NumPeridos = NumPeridos - 1
        Loop
        Return ListaFechas
    End Function

    Public Shared Function ParsePeriodo(Periodo As String) As Integer
        Dim PeriodoNum As Integer = 1
        Select Case Periodo
            Case "Mensual"
                PeriodoNum = 1
            Case "Bimestral"
                PeriodoNum = 2
            Case "Sementral"
                PeriodoNum = 6
            Case "Anual"
                PeriodoNum = 12
        End Select
        Return PeriodoNum
    End Function

End Class
