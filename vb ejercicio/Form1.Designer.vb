<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textcodigo = New System.Windows.Forms.TextBox()
        Me.Textproducto = New System.Windows.Forms.TextBox()
        Me.Textcantidad = New System.Windows.Forms.TextBox()
        Me.Textprecio = New System.Windows.Forms.TextBox()
        Me.cbestado = New System.Windows.Forms.ComboBox()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.Btnnuevo = New System.Windows.Forms.Button()
        Me.dgproducto = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo del Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Estado"
        '
        'Textcodigo
        '
        Me.Textcodigo.Location = New System.Drawing.Point(230, 26)
        Me.Textcodigo.Name = "Textcodigo"
        Me.Textcodigo.Size = New System.Drawing.Size(182, 31)
        Me.Textcodigo.TabIndex = 5
        '
        'Textproducto
        '
        Me.Textproducto.Location = New System.Drawing.Point(230, 85)
        Me.Textproducto.Name = "Textproducto"
        Me.Textproducto.Size = New System.Drawing.Size(182, 31)
        Me.Textproducto.TabIndex = 6
        '
        'Textcantidad
        '
        Me.Textcantidad.Location = New System.Drawing.Point(230, 146)
        Me.Textcantidad.Name = "Textcantidad"
        Me.Textcantidad.Size = New System.Drawing.Size(182, 31)
        Me.Textcantidad.TabIndex = 7
        '
        'Textprecio
        '
        Me.Textprecio.Location = New System.Drawing.Point(230, 203)
        Me.Textprecio.Name = "Textprecio"
        Me.Textprecio.Size = New System.Drawing.Size(182, 31)
        Me.Textprecio.TabIndex = 8
        '
        'cbestado
        '
        Me.cbestado.FormattingEnabled = True
        Me.cbestado.Location = New System.Drawing.Point(230, 264)
        Me.cbestado.Name = "cbestado"
        Me.cbestado.Size = New System.Drawing.Size(182, 33)
        Me.cbestado.TabIndex = 9
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Location = New System.Drawing.Point(469, 26)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(112, 34)
        Me.Btnbuscar.TabIndex = 10
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'Btnguardar
        '
        Me.Btnguardar.Location = New System.Drawing.Point(610, 137)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(112, 34)
        Me.Btnguardar.TabIndex = 11
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'Btnnuevo
        '
        Me.Btnnuevo.Location = New System.Drawing.Point(610, 200)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.Size = New System.Drawing.Size(112, 34)
        Me.Btnnuevo.TabIndex = 12
        Me.Btnnuevo.Text = "Nuevo"
        Me.Btnnuevo.UseVisualStyleBackColor = True
        '
        'dgproducto
        '
        Me.dgproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgproducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgproducto.Location = New System.Drawing.Point(12, 325)
        Me.dgproducto.Name = "dgproducto"
        Me.dgproducto.RowHeadersWidth = 62
        Me.dgproducto.RowTemplate.Height = 33
        Me.dgproducto.Size = New System.Drawing.Size(960, 225)
        Me.dgproducto.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Producto"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Estado"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Subtotal"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 579)
        Me.Controls.Add(Me.dgproducto)
        Me.Controls.Add(Me.Btnnuevo)
        Me.Controls.Add(Me.Btnguardar)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Controls.Add(Me.cbestado)
        Me.Controls.Add(Me.Textprecio)
        Me.Controls.Add(Me.Textcantidad)
        Me.Controls.Add(Me.Textproducto)
        Me.Controls.Add(Me.Textcodigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "POO"
        CType(Me.dgproducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Textcodigo As TextBox
    Friend WithEvents Textproducto As TextBox
    Friend WithEvents Textcantidad As TextBox
    Friend WithEvents Textprecio As TextBox
    Friend WithEvents cbestado As ComboBox
    Friend WithEvents Btnbuscar As Button
    Friend WithEvents Btnguardar As Button
    Friend WithEvents Btnnuevo As Button
    Friend WithEvents dgproducto As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
