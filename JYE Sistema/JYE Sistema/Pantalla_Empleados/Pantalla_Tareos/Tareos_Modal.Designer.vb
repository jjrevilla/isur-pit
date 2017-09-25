<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tareos_Modal
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tareos_Modal))
        Me.CBEmpleado = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.TXTProyecto = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.TXTUbicacion = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.TXTActividad = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.TXTObservaciones = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.CBHoras = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.BTNCancelar = New Telerik.WinControls.UI.RadButton()
        Me.BTNAceptar = New Telerik.WinControls.UI.RadButton()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.DTPFecha = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.BTNAñadir_empleado = New Telerik.WinControls.UI.RadButton()
        CType(Me.CBEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBEmpleado.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBEmpleado.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTActividad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBHoras.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBHoras.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNAñadir_empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBEmpleado
        '
        Me.CBEmpleado.AutoSize = True
        '
        'CBEmpleado.NestedRadGridView
        '
        Me.CBEmpleado.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.CBEmpleado.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEmpleado.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CBEmpleado.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.CBEmpleado.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.CBEmpleado.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.CBEmpleado.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.CBEmpleado.EditorControl.MasterTemplate.EnableGrouping = False
        Me.CBEmpleado.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.CBEmpleado.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.CBEmpleado.EditorControl.Name = "NestedRadGridView"
        Me.CBEmpleado.EditorControl.ReadOnly = True
        Me.CBEmpleado.EditorControl.ShowGroupPanel = False
        Me.CBEmpleado.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.CBEmpleado.EditorControl.TabIndex = 0
        Me.CBEmpleado.Location = New System.Drawing.Point(169, 22)
        Me.CBEmpleado.Name = "CBEmpleado"
        Me.CBEmpleado.Size = New System.Drawing.Size(227, 20)
        Me.CBEmpleado.TabIndex = 0
        Me.CBEmpleado.TabStop = False
        Me.CBEmpleado.Text = "Seleccione Empleado"
        '
        'TXTProyecto
        '
        Me.TXTProyecto.Location = New System.Drawing.Point(169, 48)
        Me.TXTProyecto.Name = "TXTProyecto"
        Me.TXTProyecto.Size = New System.Drawing.Size(301, 20)
        Me.TXTProyecto.TabIndex = 1
        Me.TXTProyecto.ThemeName = "ControlDefault"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(29, 22)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(61, 19)
        Me.RadLabel4.TabIndex = 34
        Me.RadLabel4.Text = "Empleado"
        Me.RadLabel4.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(29, 47)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(55, 19)
        Me.RadLabel3.TabIndex = 35
        Me.RadLabel3.Text = "Proyecto"
        Me.RadLabel3.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(29, 73)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(60, 19)
        Me.RadLabel1.TabIndex = 35
        Me.RadLabel1.Text = "Ubicación"
        Me.RadLabel1.ThemeName = "TelerikMetroBlue"
        '
        'TXTUbicacion
        '
        Me.TXTUbicacion.Location = New System.Drawing.Point(169, 74)
        Me.TXTUbicacion.Name = "TXTUbicacion"
        Me.TXTUbicacion.Size = New System.Drawing.Size(301, 20)
        Me.TXTUbicacion.TabIndex = 2
        Me.TXTUbicacion.ThemeName = "ControlDefault"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(29, 99)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(112, 19)
        Me.RadLabel2.TabIndex = 35
        Me.RadLabel2.Text = "Actividad Realizada"
        Me.RadLabel2.ThemeName = "TelerikMetroBlue"
        '
        'TXTActividad
        '
        Me.TXTActividad.Location = New System.Drawing.Point(169, 100)
        Me.TXTActividad.Name = "TXTActividad"
        Me.TXTActividad.Size = New System.Drawing.Size(301, 20)
        Me.TXTActividad.TabIndex = 3
        Me.TXTActividad.ThemeName = "ControlDefault"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(29, 149)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(97, 19)
        Me.RadLabel5.TabIndex = 35
        Me.RadLabel5.Text = "Horas dedicadas"
        Me.RadLabel5.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(29, 175)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(86, 19)
        Me.RadLabel6.TabIndex = 35
        Me.RadLabel6.Text = "Observaciones"
        Me.RadLabel6.ThemeName = "TelerikMetroBlue"
        '
        'TXTObservaciones
        '
        Me.TXTObservaciones.Location = New System.Drawing.Point(169, 176)
        Me.TXTObservaciones.Multiline = True
        Me.TXTObservaciones.Name = "TXTObservaciones"
        Me.TXTObservaciones.Size = New System.Drawing.Size(301, 106)
        Me.TXTObservaciones.TabIndex = 5
        Me.TXTObservaciones.ThemeName = "ControlDefault"
        '
        'CBHoras
        '
        Me.CBHoras.AutoSize = True
        '
        'CBHoras.NestedRadGridView
        '
        Me.CBHoras.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.CBHoras.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBHoras.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CBHoras.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.CBHoras.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.CBHoras.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.CBHoras.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.CBHoras.EditorControl.MasterTemplate.EnableGrouping = False
        Me.CBHoras.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.CBHoras.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.CBHoras.EditorControl.Name = "NestedRadGridView"
        Me.CBHoras.EditorControl.ReadOnly = True
        Me.CBHoras.EditorControl.ShowGroupPanel = False
        Me.CBHoras.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.CBHoras.EditorControl.TabIndex = 0
        Me.CBHoras.Location = New System.Drawing.Point(169, 150)
        Me.CBHoras.Name = "CBHoras"
        Me.CBHoras.Size = New System.Drawing.Size(45, 20)
        Me.CBHoras.TabIndex = 4
        Me.CBHoras.TabStop = False
        Me.CBHoras.Text = "9"
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(31, 256)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(110, 24)
        Me.BTNCancelar.TabIndex = 7
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.ThemeName = "TelerikMetroBlue"
        '
        'BTNAceptar
        '
        Me.BTNAceptar.Location = New System.Drawing.Point(31, 226)
        Me.BTNAceptar.Name = "BTNAceptar"
        Me.BTNAceptar.Size = New System.Drawing.Size(110, 24)
        Me.BTNAceptar.TabIndex = 6
        Me.BTNAceptar.Text = "Aceptar"
        Me.BTNAceptar.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(29, 124)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(38, 19)
        Me.RadLabel7.TabIndex = 35
        Me.RadLabel7.Text = "Fecha"
        Me.RadLabel7.ThemeName = "TelerikMetroBlue"
        '
        'DTPFecha
        '
        Me.DTPFecha.Location = New System.Drawing.Point(169, 126)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(170, 20)
        Me.DTPFecha.TabIndex = 36
        Me.DTPFecha.TabStop = False
        Me.DTPFecha.Text = "viernes, 21 de abril de 2017"
        Me.DTPFecha.Value = New Date(2017, 4, 21, 12, 14, 21, 927)
        '
        'BTNAñadir_empleado
        '
        Me.BTNAñadir_empleado.BackColor = System.Drawing.Color.Transparent
        Me.BTNAñadir_empleado.Image = CType(resources.GetObject("BTNAñadir_empleado.Image"), System.Drawing.Image)
        Me.BTNAñadir_empleado.Location = New System.Drawing.Point(400, 19)
        Me.BTNAñadir_empleado.Name = "BTNAñadir_empleado"
        Me.BTNAñadir_empleado.Size = New System.Drawing.Size(70, 26)
        Me.BTNAñadir_empleado.TabIndex = 37
        Me.BTNAñadir_empleado.Text = "Nuevo"
        Me.BTNAñadir_empleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNAñadir_empleado.ThemeName = "TelerikMetroBlue"
        '
        'Tareos_Modal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 306)
        Me.Controls.Add(Me.BTNAñadir_empleado)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.BTNCancelar)
        Me.Controls.Add(Me.BTNAceptar)
        Me.Controls.Add(Me.CBHoras)
        Me.Controls.Add(Me.CBEmpleado)
        Me.Controls.Add(Me.TXTActividad)
        Me.Controls.Add(Me.TXTObservaciones)
        Me.Controls.Add(Me.TXTUbicacion)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.TXTProyecto)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.MaximizeBox = False
        Me.Name = "Tareos_Modal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.CBEmpleado.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBEmpleado.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTActividad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBHoras.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBHoras.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNAñadir_empleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBEmpleado As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents TXTProyecto As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TXTUbicacion As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TXTActividad As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TXTObservaciones As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents CBHoras As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents BTNCancelar As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNAceptar As Telerik.WinControls.UI.RadButton
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents DTPFecha As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents BTNAñadir_empleado As Telerik.WinControls.UI.RadButton
End Class

