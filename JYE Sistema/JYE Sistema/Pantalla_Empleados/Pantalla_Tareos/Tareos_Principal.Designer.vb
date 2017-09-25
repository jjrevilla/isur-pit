<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tareos_Principal
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tareos_Principal))
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CBFiltro = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.TXTBusqueda = New Telerik.WinControls.UI.RadTextBox()
        Me.LBLObservaciones = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.LVLActividad = New Telerik.WinControls.UI.RadLabel()
        Me.LBLEmpleado = New Telerik.WinControls.UI.RadLabel()
        Me.LBLid = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel22 = New Telerik.WinControls.UI.RadLabel()
        Me.LBLFecha = New Telerik.WinControls.UI.RadLabel()
        Me.LBLHoras = New Telerik.WinControls.UI.RadLabel()
        Me.LBLUbicacion = New Telerik.WinControls.UI.RadLabel()
        Me.LBLProyecto = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.BTNEliminar = New Telerik.WinControls.UI.RadButton()
        Me.BTNEditar = New Telerik.WinControls.UI.RadButton()
        Me.BTNNuevo = New Telerik.WinControls.UI.RadButton()
        Me.DGVTareos = New Telerik.WinControls.UI.RadGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CBFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBFiltro.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBFiltro.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LVLActividad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVTareos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVTareos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1152, 473)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CBFiltro)
        Me.TabPage1.Controls.Add(Me.TXTBusqueda)
        Me.TabPage1.Controls.Add(Me.LBLObservaciones)
        Me.TabPage1.Controls.Add(Me.RadLabel4)
        Me.TabPage1.Controls.Add(Me.LVLActividad)
        Me.TabPage1.Controls.Add(Me.LBLEmpleado)
        Me.TabPage1.Controls.Add(Me.LBLid)
        Me.TabPage1.Controls.Add(Me.RadLabel22)
        Me.TabPage1.Controls.Add(Me.LBLFecha)
        Me.TabPage1.Controls.Add(Me.LBLHoras)
        Me.TabPage1.Controls.Add(Me.LBLUbicacion)
        Me.TabPage1.Controls.Add(Me.LBLProyecto)
        Me.TabPage1.Controls.Add(Me.RadLabel7)
        Me.TabPage1.Controls.Add(Me.RadLabel1)
        Me.TabPage1.Controls.Add(Me.RadLabel3)
        Me.TabPage1.Controls.Add(Me.RadLabel19)
        Me.TabPage1.Controls.Add(Me.RadLabel2)
        Me.TabPage1.Controls.Add(Me.BTNEliminar)
        Me.TabPage1.Controls.Add(Me.BTNEditar)
        Me.TabPage1.Controls.Add(Me.BTNNuevo)
        Me.TabPage1.Controls.Add(Me.DGVTareos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1144, 447)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Principal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CBFiltro
        '
        Me.CBFiltro.AutoSize = True
        '
        'CBFiltro.NestedRadGridView
        '
        Me.CBFiltro.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.CBFiltro.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFiltro.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CBFiltro.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.CBFiltro.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.CBFiltro.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.CBFiltro.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.CBFiltro.EditorControl.MasterTemplate.EnableGrouping = False
        Me.CBFiltro.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.CBFiltro.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.CBFiltro.EditorControl.Name = "NestedRadGridView"
        Me.CBFiltro.EditorControl.ReadOnly = True
        Me.CBFiltro.EditorControl.ShowGroupPanel = False
        Me.CBFiltro.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.CBFiltro.EditorControl.TabIndex = 0
        Me.CBFiltro.Location = New System.Drawing.Point(528, 20)
        Me.CBFiltro.Name = "CBFiltro"
        Me.CBFiltro.Size = New System.Drawing.Size(144, 20)
        Me.CBFiltro.TabIndex = 3
        Me.CBFiltro.TabStop = False
        Me.CBFiltro.Text = "Filtro de Búsqueda"
        '
        'TXTBusqueda
        '
        Me.TXTBusqueda.Location = New System.Drawing.Point(678, 20)
        Me.TXTBusqueda.Name = "TXTBusqueda"
        Me.TXTBusqueda.Size = New System.Drawing.Size(458, 20)
        Me.TXTBusqueda.TabIndex = 4
        '
        'LBLObservaciones
        '
        Me.LBLObservaciones.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LBLObservaciones.Location = New System.Drawing.Point(135, 337)
        Me.LBLObservaciones.Name = "LBLObservaciones"
        Me.LBLObservaciones.Size = New System.Drawing.Size(371, 21)
        Me.LBLObservaciones.TabIndex = 90
        Me.LBLObservaciones.Text = "Falló la maquina de Termofusión, se malogró fuente de poder"
        Me.LBLObservaciones.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(12, 333)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(117, 25)
        Me.RadLabel4.TabIndex = 89
        Me.RadLabel4.Text = "Observaciones"
        Me.RadLabel4.ThemeName = "TelerikMetroBlue"
        '
        'LVLActividad
        '
        Me.LVLActividad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LVLActividad.Location = New System.Drawing.Point(167, 250)
        Me.LVLActividad.Name = "LVLActividad"
        Me.LVLActividad.Size = New System.Drawing.Size(279, 21)
        Me.LVLActividad.TabIndex = 88
        Me.LVLActividad.Text = "Instalación de Geomembrana y Tuberia HDPE"
        Me.LVLActividad.ThemeName = "TelerikMetroBlue"
        '
        'LBLEmpleado
        '
        Me.LBLEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEmpleado.Location = New System.Drawing.Point(98, 158)
        Me.LBLEmpleado.Name = "LBLEmpleado"
        Me.LBLEmpleado.Size = New System.Drawing.Size(221, 25)
        Me.LBLEmpleado.TabIndex = 87
        Me.LBLEmpleado.Text = "Daryl Mijail Marcapura Apaza"
        Me.LBLEmpleado.ThemeName = "TelerikMetroBlue"
        '
        'LBLid
        '
        Me.LBLid.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LBLid.Location = New System.Drawing.Point(8, 115)
        Me.LBLid.Name = "LBLid"
        Me.LBLid.Size = New System.Drawing.Size(155, 37)
        Me.LBLid.TabIndex = 86
        Me.LBLid.Text = "Tareo Nº 100"
        Me.LBLid.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel22
        '
        Me.RadLabel22.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel22.Location = New System.Drawing.Point(12, 189)
        Me.RadLabel22.Name = "RadLabel22"
        Me.RadLabel22.Size = New System.Drawing.Size(74, 25)
        Me.RadLabel22.TabIndex = 85
        Me.RadLabel22.Text = "Proyecto"
        Me.RadLabel22.ThemeName = "TelerikMetroBlue"
        '
        'LBLFecha
        '
        Me.LBLFecha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFecha.Location = New System.Drawing.Point(156, 277)
        Me.LBLFecha.Name = "LBLFecha"
        Me.LBLFecha.Size = New System.Drawing.Size(92, 25)
        Me.LBLFecha.TabIndex = 84
        Me.LBLFecha.Text = "21/03/2017"
        Me.LBLFecha.ThemeName = "TelerikMetroBlue"
        '
        'LBLHoras
        '
        Me.LBLHoras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHoras.Location = New System.Drawing.Point(156, 304)
        Me.LBLHoras.Name = "LBLHoras"
        Me.LBLHoras.Size = New System.Drawing.Size(63, 25)
        Me.LBLHoras.TabIndex = 84
        Me.LBLHoras.Text = "5 Horas"
        Me.LBLHoras.ThemeName = "TelerikMetroBlue"
        '
        'LBLUbicacion
        '
        Me.LBLUbicacion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LBLUbicacion.Location = New System.Drawing.Point(97, 219)
        Me.LBLUbicacion.Name = "LBLUbicacion"
        Me.LBLUbicacion.Size = New System.Drawing.Size(399, 21)
        Me.LBLUbicacion.TabIndex = 82
        Me.LBLUbicacion.Text = "Campamento Majes Siguas Tarumarca-Tiscos-Caylloma, Arequipa"
        Me.LBLUbicacion.ThemeName = "TelerikMetroBlue"
        '
        'LBLProyecto
        '
        Me.LBLProyecto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProyecto.Location = New System.Drawing.Point(98, 189)
        Me.LBLProyecto.Name = "LBLProyecto"
        Me.LBLProyecto.Size = New System.Drawing.Size(99, 25)
        Me.LBLProyecto.TabIndex = 83
        Me.LBLProyecto.Text = "Majes Siguas"
        Me.LBLProyecto.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(12, 158)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(82, 25)
        Me.RadLabel7.TabIndex = 80
        Me.RadLabel7.Text = "Empleado"
        Me.RadLabel7.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(12, 277)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(51, 25)
        Me.RadLabel1.TabIndex = 81
        Me.RadLabel1.Text = "Fecha"
        Me.RadLabel1.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(12, 304)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(131, 25)
        Me.RadLabel3.TabIndex = 81
        Me.RadLabel3.Text = "Horas dedicadas"
        Me.RadLabel3.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel19
        '
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel19.Location = New System.Drawing.Point(12, 215)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(82, 25)
        Me.RadLabel19.TabIndex = 78
        Me.RadLabel19.Text = "Ubicación"
        Me.RadLabel19.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(12, 246)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(149, 25)
        Me.RadLabel2.TabIndex = 79
        Me.RadLabel2.Text = "Actividad realizada"
        Me.RadLabel2.ThemeName = "TelerikMetroBlue"
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Image = CType(resources.GetObject("BTNEliminar.Image"), System.Drawing.Image)
        Me.BTNEliminar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNEliminar.Location = New System.Drawing.Point(470, 385)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(52, 42)
        Me.BTNEliminar.TabIndex = 2
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEliminar.ThemeName = "TelerikMetroBlue"
        '
        'BTNEditar
        '
        Me.BTNEditar.Image = CType(resources.GetObject("BTNEditar.Image"), System.Drawing.Image)
        Me.BTNEditar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNEditar.Location = New System.Drawing.Point(470, 94)
        Me.BTNEditar.Name = "BTNEditar"
        Me.BTNEditar.Size = New System.Drawing.Size(52, 42)
        Me.BTNEditar.TabIndex = 1
        Me.BTNEditar.Text = "Editar"
        Me.BTNEditar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEditar.ThemeName = "TelerikMetroBlue"
        '
        'BTNNuevo
        '
        Me.BTNNuevo.Image = CType(resources.GetObject("BTNNuevo.Image"), System.Drawing.Image)
        Me.BTNNuevo.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNNuevo.Location = New System.Drawing.Point(470, 46)
        Me.BTNNuevo.Name = "BTNNuevo"
        Me.BTNNuevo.Size = New System.Drawing.Size(52, 42)
        Me.BTNNuevo.TabIndex = 0
        Me.BTNNuevo.Text = "Nuevo"
        Me.BTNNuevo.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNNuevo.ThemeName = "TelerikMetroBlue"
        '
        'DGVTareos
        '
        Me.DGVTareos.Location = New System.Drawing.Point(528, 46)
        '
        '
        '
        Me.DGVTareos.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.DGVTareos.Name = "DGVTareos"
        Me.DGVTareos.Size = New System.Drawing.Size(608, 381)
        Me.DGVTareos.TabIndex = 74
        Me.DGVTareos.Text = "RadGridView1"
        Me.DGVTareos.ThemeName = "TelerikMetroBlue"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1144, 447)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reportes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Tareos_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 473)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Tareos_Principal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "TelerikMetroBlue"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.CBFiltro.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBFiltro.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LVLActividad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVTareos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVTareos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CBFiltro As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents TXTBusqueda As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LBLObservaciones As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LVLActividad As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLEmpleado As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLid As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel22 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLHoras As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLUbicacion As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLProyecto As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BTNEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNEditar As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNNuevo As Telerik.WinControls.UI.RadButton
    Friend WithEvents DGVTareos As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LBLFecha As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class

