<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Categorias))
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.DGVCategorias = New Telerik.WinControls.UI.RadGridView()
        Me.TXTBusqueda = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.BTNAgregarCategoria = New Telerik.WinControls.UI.RadButton()
        CType(Me.DGVCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCategorias.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNAgregarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVCategorias
        '
        Me.DGVCategorias.Location = New System.Drawing.Point(14, 52)
        '
        '
        '
        Me.DGVCategorias.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.DGVCategorias.Name = "DGVCategorias"
        Me.DGVCategorias.Size = New System.Drawing.Size(378, 316)
        Me.DGVCategorias.TabIndex = 0
        Me.DGVCategorias.Text = "RadGridView1"
        '
        'TXTBusqueda
        '
        Me.TXTBusqueda.Location = New System.Drawing.Point(119, 26)
        Me.TXTBusqueda.Name = "TXTBusqueda"
        Me.TXTBusqueda.Size = New System.Drawing.Size(237, 20)
        Me.TXTBusqueda.TabIndex = 3
        Me.TXTBusqueda.ThemeName = "ControlDefault"
        '
        'BTNAgregarCategoria
        '
        Me.BTNAgregarCategoria.Image = CType(resources.GetObject("BTNAgregarCategoria.Image"), System.Drawing.Image)
        Me.BTNAgregarCategoria.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNAgregarCategoria.Location = New System.Drawing.Point(362, 23)
        Me.BTNAgregarCategoria.Name = "BTNAgregarCategoria"
        Me.BTNAgregarCategoria.Size = New System.Drawing.Size(33, 24)
        Me.BTNAgregarCategoria.TabIndex = 15
        '
        'Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 385)
        Me.Controls.Add(Me.BTNAgregarCategoria)
        Me.Controls.Add(Me.TXTBusqueda)
        Me.Controls.Add(Me.DGVCategorias)
        Me.Name = "Categorias"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.DGVCategorias.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNAgregarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents DGVCategorias As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TXTBusqueda As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents BTNAgregarCategoria As Telerik.WinControls.UI.RadButton
End Class

