<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNumeros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvNumeros = New System.Windows.Forms.DataGridView()
        Me.Negro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rojo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.dgvNegros = New System.Windows.Forms.DataGridView()
        Me.lblNumeros = New System.Windows.Forms.Label()
        Me.lblNegros = New System.Windows.Forms.Label()
        Me.dgvRojos = New System.Windows.Forms.DataGridView()
        Me.lblRojos = New System.Windows.Forms.Label()
        Me.txtGiros = New System.Windows.Forms.TextBox()
        Me.lblGiros = New System.Windows.Forms.Label()
        Me.txtNumeroRojo = New System.Windows.Forms.TextBox()
        Me.txtNumeroNegro = New System.Windows.Forms.TextBox()
        CType(Me.dgvNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNegros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRojos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvNumeros
        '
        Me.dgvNumeros.AllowUserToAddRows = False
        Me.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNumeros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Negro, Me.Rojo})
        Me.dgvNumeros.Location = New System.Drawing.Point(12, 67)
        Me.dgvNumeros.Name = "dgvNumeros"
        Me.dgvNumeros.Size = New System.Drawing.Size(155, 371)
        Me.dgvNumeros.TabIndex = 0
        '
        'Negro
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Negro.DefaultCellStyle = DataGridViewCellStyle3
        Me.Negro.HeaderText = "Negro"
        Me.Negro.MaxInputLength = 2
        Me.Negro.Name = "Negro"
        Me.Negro.Width = 50
        '
        'Rojo
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rojo.DefaultCellStyle = DataGridViewCellStyle4
        Me.Rojo.HeaderText = "Rojo"
        Me.Rojo.MaxInputLength = 2
        Me.Rojo.Name = "Rojo"
        Me.Rojo.Width = 50
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(12, 12)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'dgvNegros
        '
        Me.dgvNegros.AllowUserToAddRows = False
        Me.dgvNegros.AllowUserToDeleteRows = False
        Me.dgvNegros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvNegros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNegros.Location = New System.Drawing.Point(173, 67)
        Me.dgvNegros.Name = "dgvNegros"
        Me.dgvNegros.ReadOnly = True
        Me.dgvNegros.Size = New System.Drawing.Size(155, 371)
        Me.dgvNegros.TabIndex = 2
        '
        'lblNumeros
        '
        Me.lblNumeros.AutoSize = True
        Me.lblNumeros.Location = New System.Drawing.Point(36, 44)
        Me.lblNumeros.Name = "lblNumeros"
        Me.lblNumeros.Size = New System.Drawing.Size(14, 13)
        Me.lblNumeros.TabIndex = 3
        Me.lblNumeros.Text = "#"
        '
        'lblNegros
        '
        Me.lblNegros.AutoSize = True
        Me.lblNegros.Location = New System.Drawing.Point(170, 44)
        Me.lblNegros.Name = "lblNegros"
        Me.lblNegros.Size = New System.Drawing.Size(44, 13)
        Me.lblNegros.TabIndex = 4
        Me.lblNegros.Text = "Negros:"
        '
        'dgvRojos
        '
        Me.dgvRojos.AllowUserToAddRows = False
        Me.dgvRojos.AllowUserToDeleteRows = False
        Me.dgvRojos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvRojos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRojos.Location = New System.Drawing.Point(334, 67)
        Me.dgvRojos.Name = "dgvRojos"
        Me.dgvRojos.ReadOnly = True
        Me.dgvRojos.Size = New System.Drawing.Size(155, 371)
        Me.dgvRojos.TabIndex = 2
        '
        'lblRojos
        '
        Me.lblRojos.AutoSize = True
        Me.lblRojos.Location = New System.Drawing.Point(331, 44)
        Me.lblRojos.Name = "lblRojos"
        Me.lblRojos.Size = New System.Drawing.Size(37, 13)
        Me.lblRojos.TabIndex = 4
        Me.lblRojos.Text = "Rojos:"
        '
        'txtGiros
        '
        Me.txtGiros.Location = New System.Drawing.Point(133, 14)
        Me.txtGiros.Name = "txtGiros"
        Me.txtGiros.Size = New System.Drawing.Size(100, 20)
        Me.txtGiros.TabIndex = 5
        Me.txtGiros.Text = "50"
        '
        'lblGiros
        '
        Me.lblGiros.AutoSize = True
        Me.lblGiros.Location = New System.Drawing.Point(93, 17)
        Me.lblGiros.Name = "lblGiros"
        Me.lblGiros.Size = New System.Drawing.Size(34, 13)
        Me.lblGiros.TabIndex = 3
        Me.lblGiros.Text = "Giros:"
        '
        'txtNumeroRojo
        '
        Me.txtNumeroRojo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroRojo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNumeroRojo.Location = New System.Drawing.Point(107, 41)
        Me.txtNumeroRojo.MaxLength = 2
        Me.txtNumeroRojo.Name = "txtNumeroRojo"
        Me.txtNumeroRojo.Size = New System.Drawing.Size(45, 20)
        Me.txtNumeroRojo.TabIndex = 5
        Me.txtNumeroRojo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumeroNegro
        '
        Me.txtNumeroNegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroNegro.Location = New System.Drawing.Point(56, 41)
        Me.txtNumeroNegro.MaxLength = 2
        Me.txtNumeroNegro.Name = "txtNumeroNegro"
        Me.txtNumeroNegro.Size = New System.Drawing.Size(45, 20)
        Me.txtNumeroNegro.TabIndex = 5
        Me.txtNumeroNegro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 450)
        Me.Controls.Add(Me.txtNumeroNegro)
        Me.Controls.Add(Me.txtNumeroRojo)
        Me.Controls.Add(Me.txtGiros)
        Me.Controls.Add(Me.lblRojos)
        Me.Controls.Add(Me.lblNegros)
        Me.Controls.Add(Me.lblGiros)
        Me.Controls.Add(Me.lblNumeros)
        Me.Controls.Add(Me.dgvRojos)
        Me.Controls.Add(Me.dgvNegros)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.dgvNumeros)
        Me.Name = "frmNumeros"
        Me.Text = "Números"
        CType(Me.dgvNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNegros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRojos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvNumeros As DataGridView
    Friend WithEvents btnCalcular As Button
    Friend WithEvents dgvNegros As DataGridView
    Friend WithEvents lblNumeros As Label
    Friend WithEvents lblNegros As Label
    Friend WithEvents dgvRojos As DataGridView
    Friend WithEvents lblRojos As Label
    Friend WithEvents txtGiros As TextBox
    Friend WithEvents lblGiros As Label
    Friend WithEvents txtNumeroRojo As TextBox
    Friend WithEvents txtNumeroNegro As TextBox
    Friend WithEvents Negro As DataGridViewTextBoxColumn
    Friend WithEvents Rojo As DataGridViewTextBoxColumn
End Class
