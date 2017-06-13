<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilidadesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovimientosToolStripMenuItem, Me.CatalogoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(852, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ProvedoresToolStripMenuItem, Me.VendedorToolStripMenuItem})
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CatalogoToolStripMenuItem.Text = "Catalogo"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ProvedoresToolStripMenuItem
        '
        Me.ProvedoresToolStripMenuItem.Name = "ProvedoresToolStripMenuItem"
        Me.ProvedoresToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ProvedoresToolStripMenuItem.Text = "Provedores"
        '
        'VendedorToolStripMenuItem
        '
        Me.VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        Me.VendedorToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.VendedorToolStripMenuItem.Text = "Vendedor"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem1, Me.ComprasToolStripMenuItem1, Me.ExistenciasToolStripMenuItem, Me.UtilidadesToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.ComprasToolStripMenuItem1.Text = "Compras"
        '
        'ExistenciasToolStripMenuItem
        '
        Me.ExistenciasToolStripMenuItem.Name = "ExistenciasToolStripMenuItem"
        Me.ExistenciasToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExistenciasToolStripMenuItem.Text = "Existencias"
        '
        'UtilidadesToolStripMenuItem1
        '
        Me.UtilidadesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.ProvedorToolStripMenuItem, Me.ProductoToolStripMenuItem})
        Me.UtilidadesToolStripMenuItem1.Name = "UtilidadesToolStripMenuItem1"
        Me.UtilidadesToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.UtilidadesToolStripMenuItem1.Text = "Utilidades"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ProvedorToolStripMenuItem
        '
        Me.ProvedorToolStripMenuItem.Name = "ProvedorToolStripMenuItem"
        Me.ProvedorToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ProvedorToolStripMenuItem.Text = "Provedor"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 507)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Control"
        Me.Text = "Control TPV"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExistenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilidadesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedorToolStripMenuItem As ToolStripMenuItem
End Class
