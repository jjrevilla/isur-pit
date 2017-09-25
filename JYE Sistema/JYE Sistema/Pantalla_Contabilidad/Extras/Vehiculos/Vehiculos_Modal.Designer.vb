<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehiculos_Modal
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
        Me.DTPFecha_nac = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.PanelContainer = New Telerik.WinControls.UI.DataEntryScrollablePanelContainer()
        Me.BTNCancelar = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.CBColor = New Telerik.WinControls.UI.RadDropDownList()
        Me.TXTPlaca = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.TXTModelo = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.TXTMarca = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.BTNAceptar = New Telerik.WinControls.UI.RadButton()
        CType(Me.DTPFecha_nac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.CBColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTPFecha_nac
        '
        Me.DTPFecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha_nac.Location = New System.Drawing.Point(149, 157)
        Me.DTPFecha_nac.Name = "DTPFecha_nac"
        Me.DTPFecha_nac.Size = New System.Drawing.Size(207, 20)
        Me.DTPFecha_nac.TabIndex = 5
        Me.DTPFecha_nac.TabStop = False
        Me.DTPFecha_nac.Text = "19/04/2017"
        Me.DTPFecha_nac.ThemeName = "ControlDefault"
        Me.DTPFecha_nac.Value = New Date(2017, 4, 19, 18, 47, 53, 811)
        '
        'PanelContainer
        '
        Me.PanelContainer.AutoScroll = False
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.None
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Size = New System.Drawing.Size(439, 266)
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(202, 178)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(110, 24)
        Me.BTNCancelar.TabIndex = 4
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.ThemeName = "TelerikMetroBlue"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.CBColor)
        Me.RadGroupBox1.Controls.Add(Me.TXTPlaca)
        Me.RadGroupBox1.Controls.Add(Me.TXTModelo)
        Me.RadGroupBox1.Controls.Add(Me.TXTMarca)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.HeaderText = "Nuevo Vehiculo"
        Me.RadGroupBox1.Location = New System.Drawing.Point(19, 13)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(341, 148)
        Me.RadGroupBox1.TabIndex = 3
        Me.RadGroupBox1.Text = "Nuevo Vehiculo"
        Me.RadGroupBox1.ThemeName = "TelerikMetroBlue"
        '
        'CBColor
        '
        Me.CBColor.Location = New System.Drawing.Point(149, 110)
        Me.CBColor.Name = "CBColor"
        Me.CBColor.Size = New System.Drawing.Size(125, 20)
        Me.CBColor.TabIndex = 4
        Me.CBColor.Text = "Seleccione Color"
        '
        'TXTPlaca
        '
        Me.TXTPlaca.Location = New System.Drawing.Point(149, 84)
        Me.TXTPlaca.Name = "TXTPlaca"
        Me.TXTPlaca.Size = New System.Drawing.Size(114, 20)
        Me.TXTPlaca.TabIndex = 2
        Me.TXTPlaca.ThemeName = "ControlDefault"
        '
        'TXTModelo
        '
        Me.TXTModelo.Location = New System.Drawing.Point(149, 58)
        Me.TXTModelo.Name = "TXTModelo"
        Me.TXTModelo.Size = New System.Drawing.Size(173, 20)
        Me.TXTModelo.TabIndex = 1
        Me.TXTModelo.ThemeName = "ControlDefault"
        '
        'TXTMarca
        '
        Me.TXTMarca.Location = New System.Drawing.Point(149, 33)
        Me.TXTMarca.Name = "TXTMarca"
        Me.TXTMarca.Size = New System.Drawing.Size(173, 20)
        Me.TXTMarca.TabIndex = 0
        Me.TXTMarca.ThemeName = "ControlDefault"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(20, 108)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(36, 19)
        Me.RadLabel4.TabIndex = 1
        Me.RadLabel4.Text = "Color"
        Me.RadLabel4.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(20, 33)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(40, 19)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Marca"
        Me.RadLabel1.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(20, 84)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(35, 19)
        Me.RadLabel3.TabIndex = 1
        Me.RadLabel3.Text = "Placa"
        Me.RadLabel3.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(20, 58)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(49, 19)
        Me.RadLabel2.TabIndex = 1
        Me.RadLabel2.Text = "Modelo"
        Me.RadLabel2.ThemeName = "TelerikMetroBlue"
        '
        'BTNAceptar
        '
        Me.BTNAceptar.Location = New System.Drawing.Point(86, 178)
        Me.BTNAceptar.Name = "BTNAceptar"
        Me.BTNAceptar.Size = New System.Drawing.Size(110, 24)
        Me.BTNAceptar.TabIndex = 2
        Me.BTNAceptar.Text = "Aceptar"
        Me.BTNAceptar.ThemeName = "TelerikMetroBlue"
        '
        'Vehiculos_Modal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 215)
        Me.Controls.Add(Me.BTNCancelar)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.BTNAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vehiculos_Modal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.DTPFecha_nac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.CBColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTPFecha_nac As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents PanelContainer As Telerik.WinControls.UI.DataEntryScrollablePanelContainer
    Friend WithEvents BTNCancelar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents CBColor As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TXTPlaca As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents TXTModelo As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents TXTMarca As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BTNAceptar As Telerik.WinControls.UI.RadButton
End Class

