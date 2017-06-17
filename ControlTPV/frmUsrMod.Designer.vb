<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsrMod
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsrUsr = New System.Windows.Forms.TextBox()
        Me.txtUsrPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsrNom = New System.Windows.Forms.TextBox()
        Me.txtUsrMail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblUsrId = New System.Windows.Forms.Label()
        Me.chkUsrAct = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'txtUsrUsr
        '
        Me.txtUsrUsr.Location = New System.Drawing.Point(136, 58)
        Me.txtUsrUsr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsrUsr.Name = "txtUsrUsr"
        Me.txtUsrUsr.Size = New System.Drawing.Size(173, 22)
        Me.txtUsrUsr.TabIndex = 2
        '
        'txtUsrPass
        '
        Me.txtUsrPass.Location = New System.Drawing.Point(136, 108)
        Me.txtUsrPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsrPass.Name = "txtUsrPass"
        Me.txtUsrPass.Size = New System.Drawing.Size(173, 22)
        Me.txtUsrPass.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 213)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Correo"
        '
        'txtUsrNom
        '
        Me.txtUsrNom.Location = New System.Drawing.Point(136, 159)
        Me.txtUsrNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsrNom.Name = "txtUsrNom"
        Me.txtUsrNom.Size = New System.Drawing.Size(376, 22)
        Me.txtUsrNom.TabIndex = 6
        '
        'txtUsrMail
        '
        Me.txtUsrMail.Location = New System.Drawing.Point(136, 209)
        Me.txtUsrMail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsrMail.Name = "txtUsrMail"
        Me.txtUsrMail.Size = New System.Drawing.Size(376, 22)
        Me.txtUsrMail.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(355, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID"
        '
        'lblUsrId
        '
        Me.lblUsrId.AutoSize = True
        Me.lblUsrId.Location = New System.Drawing.Point(453, 62)
        Me.lblUsrId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsrId.Name = "lblUsrId"
        Me.lblUsrId.Size = New System.Drawing.Size(19, 17)
        Me.lblUsrId.TabIndex = 9
        Me.lblUsrId.Text = "id"
        Me.lblUsrId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkUsrAct
        '
        Me.chkUsrAct.AutoSize = True
        Me.chkUsrAct.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkUsrAct.Checked = True
        Me.chkUsrAct.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUsrAct.Location = New System.Drawing.Point(347, 112)
        Me.chkUsrAct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkUsrAct.Name = "chkUsrAct"
        Me.chkUsrAct.Size = New System.Drawing.Size(121, 21)
        Me.chkUsrAct.TabIndex = 10
        Me.chkUsrAct.Text = "Usuario Activo"
        Me.chkUsrAct.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.GuardarToolStripMenuItem1, Me.BorrarToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(589, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.GuardarToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem1
        '
        Me.GuardarToolStripMenuItem1.Name = "GuardarToolStripMenuItem1"
        Me.GuardarToolStripMenuItem1.Size = New System.Drawing.Size(74, 24)
        Me.GuardarToolStripMenuItem1.Text = "Guardar"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'frmUsrMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 287)
        Me.Controls.Add(Me.chkUsrAct)
        Me.Controls.Add(Me.lblUsrId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsrMail)
        Me.Controls.Add(Me.txtUsrNom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsrPass)
        Me.Controls.Add(Me.txtUsrUsr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmUsrMod"
        Me.Text = "Control Usuarios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsrUsr As TextBox
    Friend WithEvents txtUsrPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsrNom As TextBox
    Friend WithEvents txtUsrMail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUsrId As Label
    Friend WithEvents chkUsrAct As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
End Class
