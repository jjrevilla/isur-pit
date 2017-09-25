<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vehiculos_Principal
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vehiculos_Principal))
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.BTNNuevo = New Telerik.WinControls.UI.RadButton()
        Me.BTNCancelar = New Telerik.WinControls.UI.RadButton()
        Me.BTNAceptar = New Telerik.WinControls.UI.RadButton()
        Me.BTNEditar = New Telerik.WinControls.UI.RadButton()
        Me.TXTBusqueda = New Telerik.WinControls.UI.RadTextBox()
        Me.LBLPlaca = New Telerik.WinControls.UI.RadLabel()
        Me.LBLColor = New Telerik.WinControls.UI.RadLabel()
        Me.LBLNombre = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.LBLModelo = New Telerik.WinControls.UI.RadLabel()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.CBFiltro = New Telerik.WinControls.UI.RadDropDownList()
        Me.BTNEliminar = New Telerik.WinControls.UI.RadButton()
        Me.LBLID = New Telerik.WinControls.UI.RadLabel()
        Me.ClasesVEHICULOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DGVVehiculos = New Telerik.WinControls.UI.RadGridView()
        Me.ClasesVEHICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTVehiculos = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.BTNNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClasesVEHICULOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVVehiculos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClasesVEHICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNNuevo
        '
        Me.BTNNuevo.Image = CType(resources.GetObject("BTNNuevo.Image"), System.Drawing.Image)
        Me.BTNNuevo.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNNuevo.Location = New System.Drawing.Point(12, 12)
        Me.BTNNuevo.Name = "BTNNuevo"
        Me.BTNNuevo.Size = New System.Drawing.Size(52, 42)
        Me.BTNNuevo.TabIndex = 0
        Me.BTNNuevo.Text = "Nuevo"
        Me.BTNNuevo.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNNuevo.ThemeName = "TelerikMetroBlue"
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(315, 332)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(110, 24)
        Me.BTNCancelar.TabIndex = 5
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.ThemeName = "TelerikMetroBlue"
        '
        'BTNAceptar
        '
        Me.BTNAceptar.Location = New System.Drawing.Point(199, 332)
        Me.BTNAceptar.Name = "BTNAceptar"
        Me.BTNAceptar.Size = New System.Drawing.Size(110, 24)
        Me.BTNAceptar.TabIndex = 4
        Me.BTNAceptar.Text = "Aceptar"
        Me.BTNAceptar.ThemeName = "TelerikMetroBlue"
        '
        'BTNEditar
        '
        Me.BTNEditar.Image = CType(resources.GetObject("BTNEditar.Image"), System.Drawing.Image)
        Me.BTNEditar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNEditar.Location = New System.Drawing.Point(70, 12)
        Me.BTNEditar.Name = "BTNEditar"
        Me.BTNEditar.Size = New System.Drawing.Size(52, 42)
        Me.BTNEditar.TabIndex = 1
        Me.BTNEditar.Text = "Editar"
        Me.BTNEditar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEditar.ThemeName = "TelerikMetroBlue"
        '
        'TXTBusqueda
        '
        Me.TXTBusqueda.Location = New System.Drawing.Point(211, 41)
        Me.TXTBusqueda.Name = "TXTBusqueda"
        Me.TXTBusqueda.Size = New System.Drawing.Size(169, 20)
        Me.TXTBusqueda.TabIndex = 3
        '
        'LBLPlaca
        '
        Me.LBLPlaca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPlaca.Location = New System.Drawing.Point(87, 146)
        Me.LBLPlaca.Name = "LBLPlaca"
        Me.LBLPlaca.Size = New System.Drawing.Size(92, 25)
        Me.LBLPlaca.TabIndex = 55
        Me.LBLPlaca.Text = "Nº de Placa"
        Me.LBLPlaca.ThemeName = "TelerikMetroBlue"
        '
        'LBLColor
        '
        Me.LBLColor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLColor.Location = New System.Drawing.Point(87, 168)
        Me.LBLColor.Name = "LBLColor"
        Me.LBLColor.Size = New System.Drawing.Size(46, 25)
        Me.LBLColor.TabIndex = 56
        Me.LBLColor.Text = "Color"
        Me.LBLColor.ThemeName = "TelerikMetroBlue"
        '
        'LBLNombre
        '
        Me.LBLNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNombre.Location = New System.Drawing.Point(10, 68)
        Me.LBLNombre.Name = "LBLNombre"
        Me.LBLNombre.Size = New System.Drawing.Size(90, 41)
        Me.LBLNombre.TabIndex = 52
        Me.LBLNombre.Text = "Marca"
        Me.LBLNombre.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel19
        '
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel19.Location = New System.Drawing.Point(16, 145)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(47, 25)
        Me.RadLabel19.TabIndex = 53
        Me.RadLabel19.Text = "Placa"
        Me.RadLabel19.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(16, 167)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(48, 25)
        Me.RadLabel2.TabIndex = 54
        Me.RadLabel2.Text = "Color"
        Me.RadLabel2.ThemeName = "TelerikMetroBlue"
        '
        'LBLModelo
        '
        Me.LBLModelo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLModelo.Location = New System.Drawing.Point(46, 104)
        Me.LBLModelo.Name = "LBLModelo"
        Me.LBLModelo.Size = New System.Drawing.Size(60, 25)
        Me.LBLModelo.TabIndex = 57
        Me.LBLModelo.Text = "Modelo"
        Me.LBLModelo.ThemeName = "TelerikMetroBlue"
        '
        'CBFiltro
        '
        Me.CBFiltro.Location = New System.Drawing.Point(211, 15)
        Me.CBFiltro.Name = "CBFiltro"
        Me.CBFiltro.Size = New System.Drawing.Size(140, 20)
        Me.CBFiltro.TabIndex = 58
        Me.CBFiltro.Text = "Filtro de Búsqueda"
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Image = CType(resources.GetObject("BTNEliminar.Image"), System.Drawing.Image)
        Me.BTNEliminar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNEliminar.Location = New System.Drawing.Point(128, 12)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(52, 42)
        Me.BTNEliminar.TabIndex = 59
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEliminar.ThemeName = "TelerikMetroBlue"
        '
        'LBLID
        '
        Me.LBLID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLID.Location = New System.Drawing.Point(357, 11)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(40, 25)
        Me.LBLID.TabIndex = 60
        Me.LBLID.Text = "Item"
        Me.LBLID.ThemeName = "TelerikMetroBlue"
        '
        'ClasesVEHICULOSBindingSource1
        '

        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "V_VERSION"
        Me.DataGridViewTextBoxColumn1.HeaderText = "V_VERSION"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "V_VERSION"
        Me.DataGridViewImageColumn1.HeaderText = "V_VERSION"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DGVVehiculos
        '
        Me.DGVVehiculos.BackColor = System.Drawing.Color.White
        Me.DGVVehiculos.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGVVehiculos.EnableCustomSorting = True
        Me.DGVVehiculos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.DGVVehiculos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGVVehiculos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DGVVehiculos.Location = New System.Drawing.Point(211, 67)
        '
        '
        '
        Me.DGVVehiculos.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.DGVVehiculos.MasterTemplate.AllowAddNewRow = False
        Me.DGVVehiculos.MasterTemplate.AllowColumnReorder = False
        Me.DGVVehiculos.MasterTemplate.AllowColumnResize = False
        Me.DGVVehiculos.MasterTemplate.AllowDeleteRow = False
        Me.DGVVehiculos.MasterTemplate.AllowDragToGroup = False
        Me.DGVVehiculos.MasterTemplate.AllowEditRow = False
        Me.DGVVehiculos.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.DGVVehiculos.MasterTemplate.AllowRowResize = False
        Me.DGVVehiculos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "MARCA"
        GridViewTextBoxColumn1.HeaderText = "MARCA"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "MARCA"
        GridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending
        GridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn1.Width = 83
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "MODELO"
        GridViewTextBoxColumn2.HeaderText = "MODELO"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "MODELO"
        GridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn2.Width = 86
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "N_PLACA"
        GridViewTextBoxColumn3.HeaderText = "N_PLACA"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.Name = "N_PLACA"
        GridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn3.Width = 95
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "COLOR"
        GridViewTextBoxColumn4.HeaderText = "COLOR"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "COLOR"
        GridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn4.Width = 94
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "ID_VEHICULO"
        GridViewDecimalColumn1.HeaderText = "ID_VEHICULO"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.IsVisible = False
        GridViewDecimalColumn1.Name = "ID_VEHICULO"
        GridViewDecimalColumn1.Width = 75
        GridViewTextBoxColumn5.DataType = GetType(Object)
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "V_VERSION"
        GridViewTextBoxColumn5.HeaderText = "V_VERSION"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.IsVisible = False
        GridViewTextBoxColumn5.Name = "V_VERSION"
        GridViewTextBoxColumn5.Width = 110
        Me.DGVVehiculos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewDecimalColumn1, GridViewTextBoxColumn5})
        Me.DGVVehiculos.MasterTemplate.DataSource = Me.ClasesVEHICULOSBindingSource
        Me.DGVVehiculos.MasterTemplate.EnableCustomSorting = True
        SortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor1.PropertyName = "MARCA"
        Me.DGVVehiculos.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.DGVVehiculos.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.DGVVehiculos.Name = "DGVVehiculos"
        Me.DGVVehiculos.ReadOnly = True
        Me.DGVVehiculos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGVVehiculos.Size = New System.Drawing.Size(376, 253)
        Me.DGVVehiculos.TabIndex = 62
        Me.DGVVehiculos.Text = "Relacion de Vehiculos"
        Me.DGVVehiculos.ThemeName = "ControlDefault"
        '
        'ClasesVEHICULOSBindingSource
        '

        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "V_VERSION"
        Me.DataGridViewTextBoxColumn2.HeaderText = "V_VERSION"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'TTVehiculos
        '
        Me.TTVehiculos.IsBalloon = True
        '
        'Vehiculos_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 375)
        Me.Controls.Add(Me.DGVVehiculos)
        Me.Controls.Add(Me.LBLID)
        Me.Controls.Add(Me.BTNEliminar)
        Me.Controls.Add(Me.CBFiltro)
        Me.Controls.Add(Me.LBLModelo)
        Me.Controls.Add(Me.LBLPlaca)
        Me.Controls.Add(Me.LBLColor)
        Me.Controls.Add(Me.LBLNombre)
        Me.Controls.Add(Me.RadLabel19)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.TXTBusqueda)
        Me.Controls.Add(Me.BTNEditar)
        Me.Controls.Add(Me.BTNCancelar)
        Me.Controls.Add(Me.BTNAceptar)
        Me.Controls.Add(Me.BTNNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vehiculos_Principal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.BTNNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClasesVEHICULOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVVehiculos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClasesVEHICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNNuevo As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNCancelar As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNAceptar As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNEditar As Telerik.WinControls.UI.RadButton
    Friend WithEvents TXTBusqueda As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LBLPlaca As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLColor As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLNombre As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LBLModelo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents CBFiltro As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents BTNEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents LBLID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ClasesVEHICULOSBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DGVVehiculos As Telerik.WinControls.UI.RadGridView
    Friend WithEvents ClasesVEHICULOSBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TTVehiculos As ToolTip
End Class

