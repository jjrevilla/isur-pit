<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contabilidad_Principal
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contabilidad_Principal))
        Dim CartesianArea1 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
        Dim CategoricalAxis1 As Telerik.WinControls.UI.CategoricalAxis = New Telerik.WinControls.UI.CategoricalAxis()
        Dim LinearAxis1 As Telerik.WinControls.UI.LinearAxis = New Telerik.WinControls.UI.LinearAxis()
        Dim BarSeries1 As Telerik.WinControls.UI.BarSeries = New Telerik.WinControls.UI.BarSeries()
        Dim CategoricalDataPoint1 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint2 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint3 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint4 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint5 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim BarSeries2 As Telerik.WinControls.UI.BarSeries = New Telerik.WinControls.UI.BarSeries()
        Dim CategoricalDataPoint6 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint7 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint8 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint9 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint10 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CartesianArea2 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
        Dim CategoricalAxis2 As Telerik.WinControls.UI.CategoricalAxis = New Telerik.WinControls.UI.CategoricalAxis()
        Dim LinearAxis2 As Telerik.WinControls.UI.LinearAxis = New Telerik.WinControls.UI.LinearAxis()
        Dim BarSeries3 As Telerik.WinControls.UI.BarSeries = New Telerik.WinControls.UI.BarSeries()
        Dim CategoricalDataPoint11 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint12 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint13 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint14 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint15 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim BarSeries4 As Telerik.WinControls.UI.BarSeries = New Telerik.WinControls.UI.BarSeries()
        Dim CategoricalDataPoint16 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint17 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint18 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint19 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint20 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.BTNVentas = New Telerik.WinControls.UI.RadButton()
        Me.BTNGastos = New Telerik.WinControls.UI.RadButton()
        Me.RadChartView1 = New Telerik.WinControls.UI.RadChartView()
        Me.RadChartView2 = New Telerik.WinControls.UI.RadChartView()
        CType(Me.BTNVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadChartView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNVentas
        '
        Me.BTNVentas.BackColor = System.Drawing.Color.Transparent
        Me.BTNVentas.Image = CType(resources.GetObject("BTNVentas.Image"), System.Drawing.Image)
        Me.BTNVentas.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNVentas.Location = New System.Drawing.Point(169, 12)
        Me.BTNVentas.Name = "BTNVentas"
        Me.BTNVentas.Size = New System.Drawing.Size(151, 63)
        Me.BTNVentas.TabIndex = 4
        Me.BTNVentas.Text = "Nueva Venta"
        Me.BTNVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNVentas.ThemeName = "TelerikMetroBlue"
        '
        'BTNGastos
        '
        Me.BTNGastos.BackColor = System.Drawing.Color.Transparent
        Me.BTNGastos.Image = CType(resources.GetObject("BTNGastos.Image"), System.Drawing.Image)
        Me.BTNGastos.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNGastos.Location = New System.Drawing.Point(12, 12)
        Me.BTNGastos.Name = "BTNGastos"
        Me.BTNGastos.Size = New System.Drawing.Size(151, 63)
        Me.BTNGastos.TabIndex = 3
        Me.BTNGastos.Text = "Nuevo Gasto"
        Me.BTNGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNGastos.ThemeName = "TelerikMetroBlue"
        '
        'RadChartView1
        '
        Me.RadChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.IsPrimary = True
        CategoricalAxis1.LabelRotationAngle = 300.0R
        CategoricalAxis1.ShowLabels = False
        CategoricalAxis1.Title = ""
        LinearAxis1.AxisType = Telerik.Charting.AxisType.Second
        LinearAxis1.IsPrimary = True
        LinearAxis1.LabelRotationAngle = 300.0R
        LinearAxis1.MajorStep = 10.0R
        LinearAxis1.ShowLabels = False
        LinearAxis1.TickOrigin = Nothing
        LinearAxis1.Title = ""
        Me.RadChartView1.Axes.AddRange(New Telerik.WinControls.UI.Axis() {CategoricalAxis1, LinearAxis1})
        Me.RadChartView1.Location = New System.Drawing.Point(32, 103)
        Me.RadChartView1.Name = "RadChartView1"
        CategoricalDataPoint1.Category = "A"
        CategoricalDataPoint1.Label = 52.0R
        CategoricalDataPoint1.Value = 52.0R
        CategoricalDataPoint2.Category = "B"
        CategoricalDataPoint2.Label = 90.0R
        CategoricalDataPoint2.Value = 90.0R
        CategoricalDataPoint3.Category = "C"
        CategoricalDataPoint3.Label = 61.0R
        CategoricalDataPoint3.Value = 61.0R
        CategoricalDataPoint4.Category = "D"
        CategoricalDataPoint4.Label = 33.0R
        CategoricalDataPoint4.Value = 33.0R
        CategoricalDataPoint5.Category = "E"
        CategoricalDataPoint5.Label = 58.0R
        CategoricalDataPoint5.Value = 58.0R
        BarSeries1.DataPoints.AddRange(New Telerik.Charting.DataPoint() {CategoricalDataPoint1, CategoricalDataPoint2, CategoricalDataPoint3, CategoricalDataPoint4, CategoricalDataPoint5})
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top
        BarSeries1.LegendTitle = Nothing
        BarSeries1.VerticalAxis = LinearAxis1
        CategoricalDataPoint6.Category = "A"
        CategoricalDataPoint6.Label = 67.0R
        CategoricalDataPoint6.Value = 67.0R
        CategoricalDataPoint7.Category = "B"
        CategoricalDataPoint7.Label = 80.0R
        CategoricalDataPoint7.Value = 80.0R
        CategoricalDataPoint8.Category = "C"
        CategoricalDataPoint8.Label = 35.0R
        CategoricalDataPoint8.Value = 35.0R
        CategoricalDataPoint9.Category = "D"
        CategoricalDataPoint9.Label = 72.0R
        CategoricalDataPoint9.Value = 72.0R
        CategoricalDataPoint10.Category = "E"
        CategoricalDataPoint10.Label = 86.0R
        CategoricalDataPoint10.Value = 86.0R
        BarSeries2.DataPoints.AddRange(New Telerik.Charting.DataPoint() {CategoricalDataPoint6, CategoricalDataPoint7, CategoricalDataPoint8, CategoricalDataPoint9, CategoricalDataPoint10})
        BarSeries2.HorizontalAxis = CategoricalAxis1
        BarSeries2.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top
        BarSeries2.LegendTitle = Nothing
        BarSeries2.VerticalAxis = LinearAxis1
        Me.RadChartView1.Series.AddRange(New Telerik.WinControls.UI.ChartSeries() {BarSeries1, BarSeries2})
        Me.RadChartView1.ShowGrid = False
        Me.RadChartView1.ShowTitle = True
        Me.RadChartView1.Size = New System.Drawing.Size(374, 320)
        Me.RadChartView1.TabIndex = 5
        Me.RadChartView1.Text = "Gastos"
        Me.RadChartView1.Title = "Gastos Mensuales"
        '
        'RadChartView2
        '
        Me.RadChartView2.AreaDesign = CartesianArea2
        CategoricalAxis2.IsPrimary = True
        CategoricalAxis2.LabelRotationAngle = 300.0R
        CategoricalAxis2.ShowLabels = False
        CategoricalAxis2.Title = ""
        LinearAxis2.AxisType = Telerik.Charting.AxisType.Second
        LinearAxis2.IsPrimary = True
        LinearAxis2.LabelRotationAngle = 300.0R
        LinearAxis2.MajorStep = 10.0R
        LinearAxis2.ShowLabels = False
        LinearAxis2.TickOrigin = Nothing
        LinearAxis2.Title = ""
        Me.RadChartView2.Axes.AddRange(New Telerik.WinControls.UI.Axis() {CategoricalAxis2, LinearAxis2})
        Me.RadChartView2.Location = New System.Drawing.Point(512, 103)
        Me.RadChartView2.Name = "RadChartView2"
        CategoricalDataPoint11.Category = "A"
        CategoricalDataPoint11.Label = 40.0R
        CategoricalDataPoint11.Value = 40.0R
        CategoricalDataPoint12.Category = "B"
        CategoricalDataPoint12.Label = 75.0R
        CategoricalDataPoint12.Value = 75.0R
        CategoricalDataPoint13.Category = "C"
        CategoricalDataPoint13.Label = 51.0R
        CategoricalDataPoint13.Value = 51.0R
        CategoricalDataPoint14.Category = "D"
        CategoricalDataPoint14.Label = 97.0R
        CategoricalDataPoint14.Value = 97.0R
        CategoricalDataPoint15.Category = "E"
        CategoricalDataPoint15.Label = 85.0R
        CategoricalDataPoint15.Value = 85.0R
        BarSeries3.DataPoints.AddRange(New Telerik.Charting.DataPoint() {CategoricalDataPoint11, CategoricalDataPoint12, CategoricalDataPoint13, CategoricalDataPoint14, CategoricalDataPoint15})
        BarSeries3.HorizontalAxis = CategoricalAxis2
        BarSeries3.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top
        BarSeries3.VerticalAxis = LinearAxis2
        CategoricalDataPoint16.Category = "A"
        CategoricalDataPoint16.Label = 23.0R
        CategoricalDataPoint16.Value = 23.0R
        CategoricalDataPoint17.Category = "B"
        CategoricalDataPoint17.Label = 24.0R
        CategoricalDataPoint17.Value = 24.0R
        CategoricalDataPoint18.Category = "C"
        CategoricalDataPoint18.Label = 10.0R
        CategoricalDataPoint18.Value = 10.0R
        CategoricalDataPoint19.Category = "D"
        CategoricalDataPoint19.Label = 54.0R
        CategoricalDataPoint19.Value = 54.0R
        CategoricalDataPoint20.Category = "E"
        CategoricalDataPoint20.Label = 81.0R
        CategoricalDataPoint20.Value = 81.0R
        BarSeries4.DataPoints.AddRange(New Telerik.Charting.DataPoint() {CategoricalDataPoint16, CategoricalDataPoint17, CategoricalDataPoint18, CategoricalDataPoint19, CategoricalDataPoint20})
        BarSeries4.HorizontalAxis = CategoricalAxis2
        BarSeries4.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top
        BarSeries4.VerticalAxis = LinearAxis2
        Me.RadChartView2.Series.AddRange(New Telerik.WinControls.UI.ChartSeries() {BarSeries3, BarSeries4})
        Me.RadChartView2.ShowGrid = False
        Me.RadChartView2.ShowTitle = True
        Me.RadChartView2.Size = New System.Drawing.Size(374, 320)
        Me.RadChartView2.TabIndex = 5
        Me.RadChartView2.Text = "Ventas"
        Me.RadChartView2.Title = "Ventas Mensuales"
        '
        'Contabilidad_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 527)
        Me.Controls.Add(Me.RadChartView2)
        Me.Controls.Add(Me.RadChartView1)
        Me.Controls.Add(Me.BTNVentas)
        Me.Controls.Add(Me.BTNGastos)
        Me.Name = "Contabilidad_Principal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.BTNVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadChartView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadChartView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents BTNVentas As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNGastos As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadChartView1 As Telerik.WinControls.UI.RadChartView
    Friend WithEvents RadChartView2 As Telerik.WinControls.UI.RadChartView
End Class

