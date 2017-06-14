<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsr
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnNuevoUsr = New System.Windows.Forms.Button()
        Me.usrBaja = New System.Windows.Forms.RadioButton()
        Me.btnBuscarMail = New System.Windows.Forms.Button()
        Me.btnBuscarNom = New System.Windows.Forms.Button()
        Me.btnBuscarUsr = New System.Windows.Forms.Button()
        Me.txtUsrBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.btnNuevoUsr)
        Me.GroupBox1.Controls.Add(Me.usrBaja)
        Me.GroupBox1.Controls.Add(Me.btnBuscarMail)
        Me.GroupBox1.Controls.Add(Me.btnBuscarNom)
        Me.GroupBox1.Controls.Add(Me.btnBuscarUsr)
        Me.GroupBox1.Controls.Add(Me.txtUsrBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1046, 577)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Administración de Usuario"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(858, 82)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(155, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnNuevoUsr
        '
        Me.btnNuevoUsr.Location = New System.Drawing.Point(684, 131)
        Me.btnNuevoUsr.Name = "btnNuevoUsr"
        Me.btnNuevoUsr.Size = New System.Drawing.Size(155, 23)
        Me.btnNuevoUsr.TabIndex = 7
        Me.btnNuevoUsr.Text = "Nuevo"
        Me.btnNuevoUsr.UseVisualStyleBackColor = True
        '
        'usrBaja
        '
        Me.usrBaja.AutoSize = True
        Me.usrBaja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.usrBaja.Location = New System.Drawing.Point(869, 133)
        Me.usrBaja.Name = "usrBaja"
        Me.usrBaja.Size = New System.Drawing.Size(132, 21)
        Me.usrBaja.TabIndex = 6
        Me.usrBaja.TabStop = True
        Me.usrBaja.Text = "Usuario De Baja"
        Me.usrBaja.UseVisualStyleBackColor = True
        '
        'btnBuscarMail
        '
        Me.btnBuscarMail.Location = New System.Drawing.Point(502, 131)
        Me.btnBuscarMail.Name = "btnBuscarMail"
        Me.btnBuscarMail.Size = New System.Drawing.Size(155, 23)
        Me.btnBuscarMail.TabIndex = 5
        Me.btnBuscarMail.Text = "Correo"
        Me.btnBuscarMail.UseVisualStyleBackColor = True
        '
        'btnBuscarNom
        '
        Me.btnBuscarNom.Location = New System.Drawing.Point(684, 82)
        Me.btnBuscarNom.Name = "btnBuscarNom"
        Me.btnBuscarNom.Size = New System.Drawing.Size(155, 23)
        Me.btnBuscarNom.TabIndex = 4
        Me.btnBuscarNom.Text = "Nombre"
        Me.btnBuscarNom.UseVisualStyleBackColor = True
        '
        'btnBuscarUsr
        '
        Me.btnBuscarUsr.Location = New System.Drawing.Point(502, 82)
        Me.btnBuscarUsr.Name = "btnBuscarUsr"
        Me.btnBuscarUsr.Size = New System.Drawing.Size(155, 23)
        Me.btnBuscarUsr.TabIndex = 3
        Me.btnBuscarUsr.Text = "Usuario"
        Me.btnBuscarUsr.UseVisualStyleBackColor = True
        '
        'txtUsrBuscar
        '
        Me.txtUsrBuscar.Location = New System.Drawing.Point(140, 82)
        Me.txtUsrBuscar.Name = "txtUsrBuscar"
        Me.txtUsrBuscar.Size = New System.Drawing.Size(325, 22)
        Me.txtUsrBuscar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Palabra Clave"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Location = New System.Drawing.Point(20, 188)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1020, 368)
        Me.DataGridView1.TabIndex = 0
        '
        'frmUsr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 603)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUsr"
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscarMail As Button
    Friend WithEvents btnBuscarNom As Button
    Friend WithEvents btnBuscarUsr As Button
    Friend WithEvents txtUsrBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents btnNuevoUsr As Button
    Friend WithEvents usrBaja As RadioButton
End Class
