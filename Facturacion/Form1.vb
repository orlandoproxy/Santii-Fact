Imports Facturacion.BussinesManager
Imports Facturacion.Modelos.Periodos

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbPeriodo.Items.Add("Mensual")
        cbPeriodo.Items.Add("Bimestral")
        cbPeriodo.Items.Add("Sementral")
        cbPeriodo.Items.Add("Anual")
    End Sub


    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Validate As Boolean = False
        Dim FechaInicial As Date = dtpFechaInicial.Value
        Dim FechaFinal As Date = dtpFechaFinal.Value
        Dim Periodo As String = cbPeriodo.Text
        Dim DiaCorte As Integer = tbCorte.Text
        Dim DiaImpresion As Integer = tbImpresion.Text
        Dim NumPeriodo As Integer = BussinesManager.ParsePeriodo(Periodo)
        If BussinesManager.ValidarFechas(FechaInicial, FechaFinal) Then
            MessageBox.Show("La fecha final debe ser mayor a la fecha iniciar")
        End If

        Dim resultCalcular As Integer = BussinesManager.GetPeriodos(FechaInicial, FechaFinal, Periodo)
        If resultCalcular < 1 Then
            MessageBox.Show("No existen Periodos validos para mostrar")
        End If
        ''llamamos la funcion para iniciar la lista de fechas
        Dim ListaPeriodo As List(Of Periodos) = New List(Of Periodos)
        ListaPeriodo = BussinesManager.CalcNomina(FechaInicial, FechaFinal, resultCalcular, NumPeriodo, DiaCorte, Periodo, DiaImpresion)
        dgvCalculo.DataSource = ListaPeriodo
        dgvCalculo.Refresh()


    End Sub

    Private Sub dtpFechaFinal_CloseUp(sender As Object, e As EventArgs) Handles dtpFechaFinal.CloseUp
        ''validamos fechas
        Dim FechaInicial As Date = dtpFechaInicial.Value
        Dim FechaFinal As Date = dtpFechaFinal.Value
        If BussinesManager.ValidarFechas(FechaInicial, FechaFinal) Then
            MessageBox.Show("La fecha final debe ser mayor a la fecha iniciar")
        End If
    End Sub

End Class
