<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos_Principal
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
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos_Principal))
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.DGVProdcutos = New Telerik.WinControls.UI.RadGridView()
        Me.BTNEliminar = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.BTNNuevo = New Telerik.WinControls.UI.RadButton()
        Me.CBFiltro = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.LBLMarca = New Telerik.WinControls.UI.RadLabel()
        Me.TXTBusqueda = New Telerik.WinControls.UI.RadTextBox()
        Me.LBLCategoria = New Telerik.WinControls.UI.RadLabel()
        Me.LBLDescripcion = New Telerik.WinControls.UI.RadLabel()
        Me.BTNEditar = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel21 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.CHBActivo = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.LBLCantidad = New Telerik.WinControls.UI.RadLabel()
        Me.LBLNombre = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.LBLMoneda2 = New Telerik.WinControls.UI.RadLabel()
        Me.LBLMoneda1 = New Telerik.WinControls.UI.RadLabel()
        Me.LBLPrecio2 = New Telerik.WinControls.UI.RadLabel()
        Me.LBLPrecio1 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.DGVProdcutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVProdcutos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBFiltro.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBFiltro.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHBActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLMoneda2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLMoneda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLPrecio2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLPrecio1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVProdcutos
        '
        Me.DGVProdcutos.BackColor = System.Drawing.Color.White
        Me.DGVProdcutos.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGVProdcutos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.DGVProdcutos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGVProdcutos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DGVProdcutos.Location = New System.Drawing.Point(382, 123)
        '
        '
        '
        Me.DGVProdcutos.MasterTemplate.AllowAddNewRow = False
        Me.DGVProdcutos.MasterTemplate.AllowColumnReorder = False
        Me.DGVProdcutos.MasterTemplate.AllowDeleteRow = False
        Me.DGVProdcutos.MasterTemplate.AllowDragToGroup = False
        Me.DGVProdcutos.MasterTemplate.AllowEditRow = False
        Me.DGVProdcutos.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.DGVProdcutos.MasterTemplate.AllowRowResize = False
        Me.DGVProdcutos.MasterTemplate.EnableFiltering = True
        Me.DGVProdcutos.MasterTemplate.MultiSelect = True
        Me.DGVProdcutos.MasterTemplate.ShowFilteringRow = False
        SortDescriptor1.PropertyName = "TELEFONO"
        Me.DGVProdcutos.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.DGVProdcutos.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.DGVProdcutos.Name = "DGVProdcutos"
        Me.DGVProdcutos.ReadOnly = True
        Me.DGVProdcutos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGVProdcutos.ShowGroupPanelScrollbars = False
        Me.DGVProdcutos.Size = New System.Drawing.Size(443, 358)
        Me.DGVProdcutos.TabIndex = 135
        Me.DGVProdcutos.Text = "RadGridView1"
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Image = CType(resources.GetObject("BTNEliminar.Image"), System.Drawing.Image)
        Me.BTNEliminar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNEliminar.Location = New System.Drawing.Point(498, 45)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(52, 42)
        Me.BTNEliminar.TabIndex = 134
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEliminar.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(20, 201)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(80, 21)
        Me.RadLabel2.TabIndex = 132
        Me.RadLabel2.Text = "Descripción"
        Me.RadLabel2.ThemeName = "TelerikMetroBlue"
        '
        'BTNNuevo
        '
        Me.BTNNuevo.Image = CType(resources.GetObject("BTNNuevo.Image"), System.Drawing.Image)
        Me.BTNNuevo.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNNuevo.Location = New System.Drawing.Point(382, 45)
        Me.BTNNuevo.Name = "BTNNuevo"
        Me.BTNNuevo.Size = New System.Drawing.Size(52, 42)
        Me.BTNNuevo.TabIndex = 109
        Me.BTNNuevo.Text = "Nuevo"
        Me.BTNNuevo.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNNuevo.ThemeName = "TelerikMetroBlue"
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
        Me.CBFiltro.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.CBFiltro.EditorControl.Name = "NestedRadGridView"
        Me.CBFiltro.EditorControl.ReadOnly = True
        Me.CBFiltro.EditorControl.ShowGroupPanel = False
        Me.CBFiltro.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.CBFiltro.EditorControl.TabIndex = 0
        Me.CBFiltro.Location = New System.Drawing.Point(382, 93)
        Me.CBFiltro.Name = "CBFiltro"
        Me.CBFiltro.Size = New System.Drawing.Size(177, 20)
        Me.CBFiltro.TabIndex = 111
        Me.CBFiltro.TabStop = False
        Me.CBFiltro.Text = "Filtro de Búsqueda"
        '
        'LBLMarca
        '
        Me.LBLMarca.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LBLMarca.Location = New System.Drawing.Point(117, 228)
        Me.LBLMarca.Name = "LBLMarca"
        Me.LBLMarca.Size = New System.Drawing.Size(66, 21)
        Me.LBLMarca.TabIndex = 133
        Me.LBLMarca.Text = "Sin Marca"
        Me.LBLMarca.ThemeName = "TelerikMetroBlue"
        '
        'TXTBusqueda
        '
        Me.TXTBusqueda.Location = New System.Drawing.Point(565, 93)
        Me.TXTBusqueda.Name = "TXTBusqueda"
        Me.TXTBusqueda.Size = New System.Drawing.Size(260, 20)
        Me.TXTBusqueda.TabIndex = 112
        '
        'LBLCategoria
        '
        Me.LBLCategoria.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LBLCategoria.Location = New System.Drawing.Point(105, 174)
        Me.LBLCategoria.Name = "LBLCategoria"
        Me.LBLCategoria.Size = New System.Drawing.Size(143, 21)
        Me.LBLCategoria.TabIndex = 130
        Me.LBLCategoria.Text = "Categoria del Producto"
        Me.LBLCategoria.ThemeName = "TelerikMetroBlue"
        '
        'LBLDescripcion
        '
        Me.LBLDescripcion.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.LBLDescripcion.Location = New System.Drawing.Point(117, 204)
        Me.LBLDescripcion.Name = "LBLDescripcion"
        Me.LBLDescripcion.Size = New System.Drawing.Size(152, 18)
        Me.LBLDescripcion.TabIndex = 127
        Me.LBLDescripcion.Text = "Descripcion Breve del Producto"
        Me.LBLDescripcion.ThemeName = "TelerikMetroBlue"
        '
        'BTNEditar
        '
        Me.BTNEditar.Image = CType(resources.GetObject("BTNEditar.Image"), System.Drawing.Image)
        Me.BTNEditar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNEditar.Location = New System.Drawing.Point(440, 45)
        Me.BTNEditar.Name = "BTNEditar"
        Me.BTNEditar.Size = New System.Drawing.Size(52, 42)
        Me.BTNEditar.TabIndex = 110
        Me.BTNEditar.Text = "Editar"
        Me.BTNEditar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEditar.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel21
        '
        Me.RadLabel21.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel21.Location = New System.Drawing.Point(20, 309)
        Me.RadLabel21.Name = "RadLabel21"
        Me.RadLabel21.Size = New System.Drawing.Size(71, 33)
        Me.RadLabel21.TabIndex = 124
        Me.RadLabel21.Text = "Precio"
        Me.RadLabel21.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel10
        '
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel10.Location = New System.Drawing.Point(20, 375)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(58, 21)
        Me.RadLabel10.TabIndex = 119
        Me.RadLabel10.Text = "P. Venta"
        Me.RadLabel10.ThemeName = "TelerikMetroBlue"
        '
        'CHBActivo
        '
        Me.CHBActivo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CHBActivo.ForeColor = System.Drawing.Color.Black
        Me.CHBActivo.Location = New System.Drawing.Point(302, 174)
        Me.CHBActivo.Name = "CHBActivo"
        Me.CHBActivo.Size = New System.Drawing.Size(63, 21)
        Me.CHBActivo.TabIndex = 131
        Me.CHBActivo.Text = "Activo"
        Me.CHBActivo.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel9.Location = New System.Drawing.Point(20, 348)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(72, 21)
        Me.RadLabel9.TabIndex = 118
        Me.RadLabel9.Text = "P. Unitario"
        Me.RadLabel9.ThemeName = "ControlDefault"
        '
        'LBLCantidad
        '
        Me.LBLCantidad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LBLCantidad.Location = New System.Drawing.Point(117, 255)
        Me.LBLCantidad.Name = "LBLCantidad"
        Me.LBLCantidad.Size = New System.Drawing.Size(81, 21)
        Me.LBLCantidad.TabIndex = 116
        Me.LBLCantidad.Text = "00 Unidades"
        Me.LBLCantidad.ThemeName = "TelerikMetroBlue"
        '
        'LBLNombre
        '
        Me.LBLNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LBLNombre.Location = New System.Drawing.Point(20, 131)
        Me.LBLNombre.Name = "LBLNombre"
        Me.LBLNombre.Size = New System.Drawing.Size(254, 37)
        Me.LBLNombre.TabIndex = 113
        Me.LBLNombre.Text = "Nombre del Producto"
        Me.LBLNombre.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(20, 228)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(46, 21)
        Me.RadLabel3.TabIndex = 115
        Me.RadLabel3.Text = "Marca"
        Me.RadLabel3.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(20, 255)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel1.TabIndex = 118
        Me.RadLabel1.Text = "Existencias"
        Me.RadLabel1.ThemeName = "ControlDefault"
        '
        'LBLMoneda2
        '
        Me.LBLMoneda2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LBLMoneda2.Location = New System.Drawing.Point(117, 375)
        Me.LBLMoneda2.Name = "LBLMoneda2"
        Me.LBLMoneda2.Size = New System.Drawing.Size(22, 21)
        Me.LBLMoneda2.TabIndex = 117
        Me.LBLMoneda2.Text = "S/."
        Me.LBLMoneda2.ThemeName = "TelerikMetroBlue"
        '
        'LBLMoneda1
        '
        Me.LBLMoneda1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LBLMoneda1.Location = New System.Drawing.Point(117, 348)
        Me.LBLMoneda1.Name = "LBLMoneda1"
        Me.LBLMoneda1.Size = New System.Drawing.Size(22, 21)
        Me.LBLMoneda1.TabIndex = 117
        Me.LBLMoneda1.Text = "S/."
        Me.LBLMoneda1.ThemeName = "TelerikMetroBlue"
        '
        'LBLPrecio2
        '
        Me.LBLPrecio2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LBLPrecio2.Location = New System.Drawing.Point(145, 375)
        Me.LBLPrecio2.Name = "LBLPrecio2"
        Me.LBLPrecio2.Size = New System.Drawing.Size(40, 21)
        Me.LBLPrecio2.TabIndex = 117
        Me.LBLPrecio2.Text = "65.00"
        Me.LBLPrecio2.ThemeName = "TelerikMetroBlue"
        '
        'LBLPrecio1
        '
        Me.LBLPrecio1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LBLPrecio1.Location = New System.Drawing.Point(145, 348)
        Me.LBLPrecio1.Name = "LBLPrecio1"
        Me.LBLPrecio1.Size = New System.Drawing.Size(40, 21)
        Me.LBLPrecio1.TabIndex = 117
        Me.LBLPrecio1.Text = "50.00"
        Me.LBLPrecio1.ThemeName = "TelerikMetroBlue"
        '
        'Productos_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 527)
        Me.Controls.Add(Me.DGVProdcutos)
        Me.Controls.Add(Me.BTNEliminar)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.BTNNuevo)
        Me.Controls.Add(Me.CBFiltro)
        Me.Controls.Add(Me.LBLMarca)
        Me.Controls.Add(Me.LBLPrecio1)
        Me.Controls.Add(Me.LBLPrecio2)
        Me.Controls.Add(Me.LBLMoneda1)
        Me.Controls.Add(Me.LBLMoneda2)
        Me.Controls.Add(Me.TXTBusqueda)
        Me.Controls.Add(Me.LBLCategoria)
        Me.Controls.Add(Me.LBLDescripcion)
        Me.Controls.Add(Me.BTNEditar)
        Me.Controls.Add(Me.RadLabel21)
        Me.Controls.Add(Me.RadLabel10)
        Me.Controls.Add(Me.CHBActivo)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadLabel9)
        Me.Controls.Add(Me.LBLCantidad)
        Me.Controls.Add(Me.LBLNombre)
        Me.Controls.Add(Me.RadLabel3)
        Me.Name = "Productos_Principal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.DGVProdcutos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVProdcutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBFiltro.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBFiltro.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHBActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLMoneda2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLMoneda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLPrecio2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLPrecio1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents DGVProdcutos As Telerik.WinControls.UI.RadGridView
    Friend WithEvents BTNEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BTNNuevo As Telerik.WinControls.UI.RadButton
    Friend WithEvents CBFiltro As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents LBLMarca As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TXTBusqueda As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LBLCategoria As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLDescripcion As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BTNEditar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel21 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CHBActivo As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLCantidad As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLNombre As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLMoneda2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLMoneda1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLPrecio2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLPrecio1 As Telerik.WinControls.UI.RadLabel
End Class

