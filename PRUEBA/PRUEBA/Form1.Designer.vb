<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.cmdInsertar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(119, 35)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(134, 22)
        Me.txtcodigo.TabIndex = 3
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(119, 75)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(280, 22)
        Me.txtnombre.TabIndex = 4
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(119, 109)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(280, 22)
        Me.txtapellido.TabIndex = 5
        '
        'cmdInsertar
        '
        Me.cmdInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsertar.Location = New System.Drawing.Point(49, 174)
        Me.cmdInsertar.Name = "cmdInsertar"
        Me.cmdInsertar.Size = New System.Drawing.Size(109, 36)
        Me.cmdInsertar.TabIndex = 6
        Me.cmdInsertar.Text = "Insertar"
        Me.cmdInsertar.UseVisualStyleBackColor = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizar.Location = New System.Drawing.Point(164, 176)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(131, 34)
        Me.cmdActualizar.TabIndex = 7
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Location = New System.Drawing.Point(419, 176)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(102, 34)
        Me.cmdEliminar.TabIndex = 8
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLimpiar.Location = New System.Drawing.Point(301, 176)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(112, 34)
        Me.cmdLimpiar.TabIndex = 9
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(527, 175)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(101, 35)
        Me.cmdSalir.TabIndex = 10
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Apellido})
        Me.DataGridView1.Location = New System.Drawing.Point(49, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(579, 167)
        Me.DataGridView1.TabIndex = 11
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 125
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 150
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 448)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cmdInsertar)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents cmdInsertar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
