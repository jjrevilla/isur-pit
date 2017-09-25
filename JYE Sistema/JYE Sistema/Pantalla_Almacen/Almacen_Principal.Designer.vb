<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Almacen_Principal))
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.TXTTelefono = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.BTNEntradas = New Telerik.WinControls.UI.RadButton()
        Me.BTNSalidas = New Telerik.WinControls.UI.RadButton()
        Me.BTNProductos = New Telerik.WinControls.UI.RadButton()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.BTNEquipos = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(12, 109)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(813, 409)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        '
        'TXTTelefono
        '
        Me.TXTTelefono.Location = New System.Drawing.Point(473, 83)
        Me.TXTTelefono.Name = "TXTTelefono"
        Me.TXTTelefono.Size = New System.Drawing.Size(352, 20)
        Me.TXTTelefono.TabIndex = 1
        Me.TXTTelefono.ThemeName = "ControlDefault"
        '
        'BTNEntradas
        '
        Me.BTNEntradas.BackColor = System.Drawing.Color.Transparent
        Me.BTNEntradas.Image = CType(resources.GetObject("BTNEntradas.Image"), System.Drawing.Image)
        Me.BTNEntradas.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNEntradas.Location = New System.Drawing.Point(326, 12)
        Me.BTNEntradas.Name = "BTNEntradas"
        Me.BTNEntradas.Size = New System.Drawing.Size(151, 63)
        Me.BTNEntradas.TabIndex = 5
        Me.BTNEntradas.Text = "Ingreso de Productos"
        Me.BTNEntradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNEntradas.ThemeName = "TelerikMetroBlue"
        '
        'BTNSalidas
        '
        Me.BTNSalidas.BackColor = System.Drawing.Color.Transparent
        Me.BTNSalidas.Image = CType(resources.GetObject("BTNSalidas.Image"), System.Drawing.Image)
        Me.BTNSalidas.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNSalidas.Location = New System.Drawing.Point(483, 12)
        Me.BTNSalidas.Name = "BTNSalidas"
        Me.BTNSalidas.Size = New System.Drawing.Size(151, 63)
        Me.BTNSalidas.TabIndex = 6
        Me.BTNSalidas.Text = "Salida de Productos"
        Me.BTNSalidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNSalidas.ThemeName = "TelerikMetroBlue"
        '
        'BTNProductos
        '
        Me.BTNProductos.BackColor = System.Drawing.Color.Transparent
        Me.BTNProductos.Image = CType(resources.GetObject("BTNProductos.Image"), System.Drawing.Image)
        Me.BTNProductos.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNProductos.Location = New System.Drawing.Point(12, 12)
        Me.BTNProductos.Name = "BTNProductos"
        Me.BTNProductos.Size = New System.Drawing.Size(151, 63)
        Me.BTNProductos.TabIndex = 4
        Me.BTNProductos.Text = "Productos"
        Me.BTNProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNProductos.ThemeName = "TelerikMetroBlue"
        '
        'BTNEquipos
        '
        Me.BTNEquipos.BackColor = System.Drawing.Color.Transparent
        Me.BTNEquipos.Image = CType(resources.GetObject("BTNEquipos.Image"), System.Drawing.Image)
        Me.BTNEquipos.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNEquipos.Location = New System.Drawing.Point(169, 12)
        Me.BTNEquipos.Name = "BTNEquipos"
        Me.BTNEquipos.Size = New System.Drawing.Size(151, 63)
        Me.BTNEquipos.TabIndex = 4
        Me.BTNEquipos.Text = "Equipos"
        Me.BTNEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNEquipos.ThemeName = "TelerikMetroBlue"
        '
        'Almacen_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 532)
        Me.Controls.Add(Me.BTNEntradas)
        Me.Controls.Add(Me.BTNSalidas)
        Me.Controls.Add(Me.BTNEquipos)
        Me.Controls.Add(Me.BTNProductos)
        Me.Controls.Add(Me.TXTTelefono)
        Me.Controls.Add(Me.RadGridView1)
        Me.Name = "Almacen_Principal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TXTTelefono As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents BTNEntradas As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNSalidas As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNProductos As Telerik.WinControls.UI.RadButton
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents BTNEquipos As Telerik.WinControls.UI.RadButton
End Class

