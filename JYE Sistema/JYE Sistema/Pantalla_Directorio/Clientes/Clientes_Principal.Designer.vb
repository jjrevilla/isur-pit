<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes_Principal))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.DGVCllientes = New Telerik.WinControls.UI.RadGridView()
        Me.BTNNuevo = New Telerik.WinControls.UI.RadButton()
        CType(Me.DGVCllientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCllientes.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVCllientes
        '
        Me.DGVCllientes.Location = New System.Drawing.Point(282, 50)
        '
        '
        '
        Me.DGVCllientes.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.DGVCllientes.Name = "DGVCllientes"
        Me.DGVCllientes.Size = New System.Drawing.Size(453, 293)
        Me.DGVCllientes.TabIndex = 0
        Me.DGVCllientes.Text = "RadGridView1"
        Me.DGVCllientes.ThemeName = "Windows8"
        '
        'BTNNuevo
        '
        Me.BTNNuevo.Image = CType(resources.GetObject("BTNNuevo.Image"), System.Drawing.Image)
        Me.BTNNuevo.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BTNNuevo.Location = New System.Drawing.Point(25, 50)
        Me.BTNNuevo.Name = "BTNNuevo"
        Me.BTNNuevo.Size = New System.Drawing.Size(52, 42)
        Me.BTNNuevo.TabIndex = 85
        Me.BTNNuevo.Text = "Nuevo"
        Me.BTNNuevo.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNNuevo.ThemeName = "TelerikMetroBlue"
        '
        'Clientes_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 500)
        Me.Controls.Add(Me.BTNNuevo)
        Me.Controls.Add(Me.DGVCllientes)
        Me.Name = "Clientes_Principal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Clientes"
        Me.ThemeName = "Windows8"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.DGVCllientes.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCllientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents DGVCllientes As Telerik.WinControls.UI.RadGridView
    Friend WithEvents BTNNuevo As Telerik.WinControls.UI.RadButton
End Class

