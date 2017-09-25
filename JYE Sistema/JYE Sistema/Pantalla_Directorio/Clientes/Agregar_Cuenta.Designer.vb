<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Cuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Cuenta))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.CBMoneda = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.TXTNotas = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.CBBanco = New Telerik.WinControls.UI.RadDropDownList()
        Me.DGVDetalle = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.BTNLimpiar = New Telerik.WinControls.UI.RadButton()
        Me.BTNEliminar = New Telerik.WinControls.UI.RadButton()
        Me.BTNAgregar = New Telerik.WinControls.UI.RadButton()
        Me.TXTNumCuenta = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.CBMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDetalle.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.BTNLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTNumCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBMoneda
        '
        Me.CBMoneda.Location = New System.Drawing.Point(138, 50)
        Me.CBMoneda.Name = "CBMoneda"
        Me.CBMoneda.Size = New System.Drawing.Size(144, 20)
        Me.CBMoneda.TabIndex = 9
        Me.CBMoneda.Text = "Seleccione Moneda"
        Me.CBMoneda.ThemeName = "Windows8"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(29, 50)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(52, 19)
        Me.RadLabel4.TabIndex = 6
        Me.RadLabel4.Text = "Moneda"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'TXTNotas
        '
        Me.TXTNotas.Location = New System.Drawing.Point(138, 102)
        Me.TXTNotas.Multiline = True
        Me.TXTNotas.Name = "TXTNotas"
        Me.TXTNotas.Size = New System.Drawing.Size(393, 47)
        Me.TXTNotas.TabIndex = 4
        Me.TXTNotas.ThemeName = "Windows8"
        '
        'RadLabel13
        '
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(29, 102)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(39, 19)
        Me.RadLabel13.TabIndex = 5
        Me.RadLabel13.Text = "Notas"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(29, 25)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(40, 19)
        Me.RadLabel1.TabIndex = 6
        Me.RadLabel1.Text = "Banco"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'CBBanco
        '
        Me.CBBanco.Location = New System.Drawing.Point(138, 24)
        Me.CBBanco.Name = "CBBanco"
        Me.CBBanco.Size = New System.Drawing.Size(241, 20)
        Me.CBBanco.TabIndex = 9
        Me.CBBanco.Text = "Seleccione Banco"
        Me.CBBanco.ThemeName = "Windows8"
        '
        'DGVDetalle
        '
        Me.DGVDetalle.Location = New System.Drawing.Point(15, 24)
        '
        '
        '
        Me.DGVDetalle.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.Size = New System.Drawing.Size(488, 203)
        Me.DGVDetalle.TabIndex = 10
        Me.DGVDetalle.Text = "RadGridView1"
        Me.DGVDetalle.ThemeName = "Windows8"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.DGVDetalle)
        Me.RadGroupBox1.HeaderText = "Detalle de Cuentas"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 185)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(519, 251)
        Me.RadGroupBox1.TabIndex = 11
        Me.RadGroupBox1.Text = "Detalle de Cuentas"
        Me.RadGroupBox1.ThemeName = "Windows8"
        '
        'BTNLimpiar
        '
        Me.BTNLimpiar.Image = CType(resources.GetObject("BTNLimpiar.Image"), System.Drawing.Image)
        Me.BTNLimpiar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNLimpiar.Location = New System.Drawing.Point(385, 21)
        Me.BTNLimpiar.Name = "BTNLimpiar"
        Me.BTNLimpiar.Size = New System.Drawing.Size(33, 24)
        Me.BTNLimpiar.TabIndex = 14
        Me.BTNLimpiar.ThemeName = "Windows8"
        '
        'BTNEliminar
        '
        Me.BTNEliminar.Image = CType(resources.GetObject("BTNEliminar.Image"), System.Drawing.Image)
        Me.BTNEliminar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNEliminar.Location = New System.Drawing.Point(493, 155)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(33, 24)
        Me.BTNEliminar.TabIndex = 14
        Me.BTNEliminar.ThemeName = "Windows8"
        '
        'BTNAgregar
        '
        Me.BTNAgregar.Image = CType(resources.GetObject("BTNAgregar.Image"), System.Drawing.Image)
        Me.BTNAgregar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNAgregar.Location = New System.Drawing.Point(454, 155)
        Me.BTNAgregar.Name = "BTNAgregar"
        Me.BTNAgregar.Size = New System.Drawing.Size(33, 24)
        Me.BTNAgregar.TabIndex = 14
        Me.BTNAgregar.ThemeName = "Windows8"
        '
        'TXTNumCuenta
        '
        Me.TXTNumCuenta.Location = New System.Drawing.Point(138, 76)
        Me.TXTNumCuenta.Name = "TXTNumCuenta"
        Me.TXTNumCuenta.Size = New System.Drawing.Size(241, 20)
        Me.TXTNumCuenta.TabIndex = 15
        Me.TXTNumCuenta.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(29, 77)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(78, 19)
        Me.RadLabel2.TabIndex = 5
        Me.RadLabel2.Text = "Num. Cuenta"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'Agregar_Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 447)
        Me.Controls.Add(Me.TXTNumCuenta)
        Me.Controls.Add(Me.BTNAgregar)
        Me.Controls.Add(Me.BTNEliminar)
        Me.Controls.Add(Me.BTNLimpiar)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.CBBanco)
        Me.Controls.Add(Me.CBMoneda)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.TXTNotas)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel13)
        Me.Name = "Agregar_Cuenta"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Cuentas"
        Me.ThemeName = "Windows8"
        CType(Me.CBMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDetalle.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.BTNLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTNumCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents CBMoneda As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TXTNotas As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CBBanco As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents DGVDetalle As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BTNLimpiar As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNAgregar As Telerik.WinControls.UI.RadButton
    Friend WithEvents TXTNumCuenta As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
End Class

