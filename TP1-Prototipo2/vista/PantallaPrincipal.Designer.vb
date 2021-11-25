<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaPrincipal
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
        Me.labelID = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnStock = New System.Windows.Forms.Button()
        Me.BtnVentaProd = New System.Windows.Forms.Button()
        Me.BtnGestProd = New System.Windows.Forms.Button()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelID
        '
        Me.labelID.AutoSize = True
        Me.labelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelID.Location = New System.Drawing.Point(277, 69)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(14, 18)
        Me.labelID.TabIndex = 33
        Me.labelID.Text = "-"
        Me.labelID.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(85, 276)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(206, 35)
        Me.BtnSalir.TabIndex = 32
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnStock
        '
        Me.BtnStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStock.Location = New System.Drawing.Point(85, 221)
        Me.BtnStock.Name = "BtnStock"
        Me.BtnStock.Size = New System.Drawing.Size(206, 35)
        Me.BtnStock.TabIndex = 31
        Me.BtnStock.Text = "Stock"
        Me.BtnStock.UseVisualStyleBackColor = True
        '
        'BtnVentaProd
        '
        Me.BtnVentaProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentaProd.Location = New System.Drawing.Point(85, 163)
        Me.BtnVentaProd.Name = "BtnVentaProd"
        Me.BtnVentaProd.Size = New System.Drawing.Size(206, 35)
        Me.BtnVentaProd.TabIndex = 30
        Me.BtnVentaProd.Text = "Venta de Productos"
        Me.BtnVentaProd.UseVisualStyleBackColor = True
        '
        'BtnGestProd
        '
        Me.BtnGestProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestProd.Location = New System.Drawing.Point(85, 105)
        Me.BtnGestProd.Name = "BtnGestProd"
        Me.BtnGestProd.Size = New System.Drawing.Size(206, 35)
        Me.BtnGestProd.TabIndex = 29
        Me.BtnGestProd.Text = "Gestionar Productos"
        Me.BtnGestProd.UseVisualStyleBackColor = True
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNombre.Location = New System.Drawing.Point(177, 69)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(14, 18)
        Me.labelNombre.TabIndex = 28
        Me.labelNombre.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "USUARIO ACTIVO: "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(342, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "La Tienda - Pantalla Principal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 338)
        Me.Controls.Add(Me.labelID)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnStock)
        Me.Controls.Add(Me.BtnVentaProd)
        Me.Controls.Add(Me.BtnGestProd)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Name = "PantallaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PantallaPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelID As Windows.Forms.Label
    Friend WithEvents BtnSalir As Windows.Forms.Button
    Friend WithEvents BtnStock As Windows.Forms.Button
    Friend WithEvents BtnVentaProd As Windows.Forms.Button
    Friend WithEvents BtnGestProd As Windows.Forms.Button
    Friend WithEvents labelNombre As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
End Class
