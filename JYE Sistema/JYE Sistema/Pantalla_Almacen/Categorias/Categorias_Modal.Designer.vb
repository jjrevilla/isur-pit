<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias_Modal
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
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.BTNAceptar = New Telerik.WinControls.UI.RadButton()
        Me.BTNCancelar = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.TXTEmpresa = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.TXTCargo = New Telerik.WinControls.UI.RadTextBoxControl()
        CType(Me.BTNAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNAceptar
        '
        Me.BTNAceptar.Location = New System.Drawing.Point(81, 127)
        Me.BTNAceptar.Name = "BTNAceptar"
        Me.BTNAceptar.Size = New System.Drawing.Size(110, 24)
        Me.BTNAceptar.TabIndex = 13
        Me.BTNAceptar.Text = "Aceptar"
        Me.BTNAceptar.ThemeName = "TelerikMetroBlue"
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(197, 127)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(110, 24)
        Me.BTNCancelar.TabIndex = 14
        Me.BTNCancelar.Text = "Cancelar"
        Me.BTNCancelar.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel12
        '
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel12.Location = New System.Drawing.Point(26, 25)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(125, 19)
        Me.RadLabel12.TabIndex = 18
        Me.RadLabel12.Text = "Nombre de Categoria"
        Me.RadLabel12.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(26, 51)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(70, 19)
        Me.RadLabel9.TabIndex = 17
        Me.RadLabel9.Text = "Descripción"
        Me.RadLabel9.ThemeName = "TelerikMetroBlue"
        '
        'TXTEmpresa
        '
        Me.TXTEmpresa.IsReadOnly = True
        Me.TXTEmpresa.Location = New System.Drawing.Point(155, 24)
        Me.TXTEmpresa.Name = "TXTEmpresa"
        Me.TXTEmpresa.Size = New System.Drawing.Size(207, 20)
        Me.TXTEmpresa.TabIndex = 16
        Me.TXTEmpresa.ThemeName = "ControlDefault"
        '
        'TXTCargo
        '
        Me.TXTCargo.Location = New System.Drawing.Point(155, 50)
        Me.TXTCargo.Multiline = True
        Me.TXTCargo.Name = "TXTCargo"
        Me.TXTCargo.Size = New System.Drawing.Size(207, 61)
        Me.TXTCargo.TabIndex = 15
        Me.TXTCargo.ThemeName = "ControlDefault"
        '
        'Categorias_Modal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 174)
        Me.Controls.Add(Me.TXTCargo)
        Me.Controls.Add(Me.TXTEmpresa)
        Me.Controls.Add(Me.RadLabel9)
        Me.Controls.Add(Me.RadLabel12)
        Me.Controls.Add(Me.BTNCancelar)
        Me.Controls.Add(Me.BTNAceptar)
        Me.Name = "Categorias_Modal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.BTNAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents BTNAceptar As Telerik.WinControls.UI.RadButton
    Friend WithEvents BTNCancelar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TXTEmpresa As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents TXTCargo As Telerik.WinControls.UI.RadTextBoxControl
End Class

