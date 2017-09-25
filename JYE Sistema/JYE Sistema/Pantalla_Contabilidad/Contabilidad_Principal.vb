Imports Telerik.Charting
Imports Telerik.WinControls.UI

Public Class Contabilidad_Principal
    Private Sub Gastos_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Contabilidad_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Ejemlo 1
        Dim barSeries As New Telerik.WinControls.UI.BarSeries("Performance", "RepresentativeName")
        barSeries.Name = "Q1"
        barSeries.DataPoints.Add(New CategoricalDataPoint(177, "Administrativos"))
        barSeries.DataPoints.Add(New CategoricalDataPoint(128, "Materiales"))
        barSeries.DataPoints.Add(New CategoricalDataPoint(143, "Operativos"))
        barSeries.DataPoints.Add(New CategoricalDataPoint(111, "RPH"))
        Me.RadChartView1.Series.Add(barSeries)

        'Ejemplo2
        Dim barSeries4 As New Telerik.WinControls.UI.BarSeries("Performance", "RepresentativeName")
        barSeries4.Name = "Q2"
        barSeries4.DataPoints.Add(New CategoricalDataPoint(198, "CPS"))
        barSeries4.DataPoints.Add(New CategoricalDataPoint(156, "Cerro Verde"))
        barSeries4.DataPoints.Add(New CategoricalDataPoint(158, "Majes"))
        barSeries4.DataPoints.Add(New CategoricalDataPoint(456, "Tarumarca"))
        Me.RadChartView2.Series.Add(barSeries4)
    End Sub

    Private Sub BTNGastos_Click(sender As Object, e As EventArgs) Handles BTNGastos.Click
        Gastos_Principal.Show()
    End Sub

    Private Sub BTNVentas_Click(sender As Object, e As EventArgs) Handles BTNVentas.Click
        Ventas_Principal.Show()
    End Sub
End Class
