<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.BTNAceptar = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.BTNCancelar = New Telerik.WinControls.UI.RadButton()
        Me.LBLRegistrarse = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBLRecuperarcontrasenia = New System.Windows.Forms.LinkLabel()
        Me.TTMenus = New System.Windows.Forms.ToolTip(Me.components)
        Me.TXTContrasenia = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.TXTUsername = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        CType(Me.BTNAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTContrasenia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNAceptar
        '
        resources.ApplyResources(Me.BTNAceptar, "BTNAceptar")
        Me.BTNAceptar.Name = "BTNAceptar"
        Me.BTNAceptar.ThemeName = "TelerikMetroBlue"
        '
        'RadLabel1
        '
        resources.ApplyResources(Me.RadLabel1, "RadLabel1")
        Me.RadLabel1.Name = "RadLabel1"
        '
        'RadLabel2
        '
        resources.ApplyResources(Me.RadLabel2, "RadLabel2")
        Me.RadLabel2.Name = "RadLabel2"
        '
        'BTNCancelar
        '
        resources.ApplyResources(Me.BTNCancelar, "BTNCancelar")
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.ThemeName = "TelerikMetroBlue"
        '
        'LBLRegistrarse
        '
        resources.ApplyResources(Me.LBLRegistrarse, "LBLRegistrarse")
        Me.LBLRegistrarse.Name = "LBLRegistrarse"
        Me.LBLRegistrarse.TabStop = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'LBLRecuperarcontrasenia
        '
        resources.ApplyResources(Me.LBLRecuperarcontrasenia, "LBLRecuperarcontrasenia")
        Me.LBLRecuperarcontrasenia.Name = "LBLRecuperarcontrasenia"
        Me.LBLRecuperarcontrasenia.TabStop = True
        '
        'TXTContrasenia
        '
        resources.ApplyResources(Me.TXTContrasenia, "TXTContrasenia")
        Me.TXTContrasenia.Name = "TXTContrasenia"
        Me.TXTContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTContrasenia.ThemeName = "ControlDefault"
        '
        'TXTUsername
        '
        resources.ApplyResources(Me.TXTUsername, "TXTUsername")
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.ThemeName = "ControlDefault"
        '
        'Login
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TXTUsername)
        Me.Controls.Add(Me.TXTContrasenia)
        Me.Controls.Add(Me.LBLRecuperarcontrasenia)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LBLRegistrarse)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.BTNCancelar)
        Me.Controls.Add(Me.BTNAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ThemeName = "Windows8"
        CType(Me.BTNAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTContrasenia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents BTNAceptar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BTNCancelar As Telerik.WinControls.UI.RadButton
    Friend WithEvents LBLRegistrarse As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBLRecuperarcontrasenia As LinkLabel
    Friend WithEvents TTMenus As ToolTip
    Friend WithEvents TXTContrasenia As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents TXTUsername As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
End Class

