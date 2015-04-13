<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formcliente
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
        Me.listadatos = New System.Windows.Forms.GroupBox()
        Me.botonnuevo = New System.Windows.Forms.Button()
        Me.botoneditar = New System.Windows.Forms.Button()
        Me.botoncancelar = New System.Windows.Forms.Button()
        Me.cajamail = New System.Windows.Forms.TextBox()
        Me.Lmail = New System.Windows.Forms.Label()
        Me.cajadni = New System.Windows.Forms.TextBox()
        Me.Ldni = New System.Windows.Forms.Label()
        Me.cajacuit = New System.Windows.Forms.TextBox()
        Me.Lcuit = New System.Windows.Forms.Label()
        Me.cajalocalidad = New System.Windows.Forms.TextBox()
        Me.Llocalidad = New System.Windows.Forms.Label()
        Me.cajadomicilio = New System.Windows.Forms.TextBox()
        Me.Ldomicilio = New System.Windows.Forms.Label()
        Me.cajatelefono = New System.Windows.Forms.TextBox()
        Me.Ltelefono = New System.Windows.Forms.Label()
        Me.cajaestadocu = New System.Windows.Forms.TextBox()
        Me.Lestadocuenta = New System.Windows.Forms.Label()
        Me.cajanombre = New System.Windows.Forms.TextBox()
        Me.Lnombre = New System.Windows.Forms.Label()
        Me.cajaapellido = New System.Windows.Forms.TextBox()
        Me.Lapellido = New System.Windows.Forms.Label()
        Me.cajacuenta = New System.Windows.Forms.TextBox()
        Me.Lcuenta = New System.Windows.Forms.Label()
        Me.cajacliente = New System.Windows.Forms.TextBox()
        Me.Lcliente = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.botoneliminar = New System.Windows.Forms.Button()
        Me.Lnoexiste = New System.Windows.Forms.Label()
        Me.cajabuscar = New System.Windows.Forms.TextBox()
        Me.combobusqueda = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.listadatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listadatos
        '
        Me.listadatos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.listadatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.listadatos.Controls.Add(Me.botonnuevo)
        Me.listadatos.Controls.Add(Me.botoneditar)
        Me.listadatos.Controls.Add(Me.botoncancelar)
        Me.listadatos.Controls.Add(Me.cajamail)
        Me.listadatos.Controls.Add(Me.Lmail)
        Me.listadatos.Controls.Add(Me.cajadni)
        Me.listadatos.Controls.Add(Me.Ldni)
        Me.listadatos.Controls.Add(Me.cajacuit)
        Me.listadatos.Controls.Add(Me.Lcuit)
        Me.listadatos.Controls.Add(Me.cajalocalidad)
        Me.listadatos.Controls.Add(Me.Llocalidad)
        Me.listadatos.Controls.Add(Me.cajadomicilio)
        Me.listadatos.Controls.Add(Me.Ldomicilio)
        Me.listadatos.Controls.Add(Me.cajatelefono)
        Me.listadatos.Controls.Add(Me.Ltelefono)
        Me.listadatos.Controls.Add(Me.cajaestadocu)
        Me.listadatos.Controls.Add(Me.Lestadocuenta)
        Me.listadatos.Controls.Add(Me.cajanombre)
        Me.listadatos.Controls.Add(Me.Lnombre)
        Me.listadatos.Controls.Add(Me.cajaapellido)
        Me.listadatos.Controls.Add(Me.Lapellido)
        Me.listadatos.Controls.Add(Me.cajacuenta)
        Me.listadatos.Controls.Add(Me.Lcuenta)
        Me.listadatos.Controls.Add(Me.cajacliente)
        Me.listadatos.Controls.Add(Me.Lcliente)
        Me.listadatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.listadatos.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listadatos.ForeColor = System.Drawing.Color.DimGray
        Me.listadatos.Location = New System.Drawing.Point(12, 120)
        Me.listadatos.Name = "listadatos"
        Me.listadatos.Size = New System.Drawing.Size(365, 391)
        Me.listadatos.TabIndex = 0
        Me.listadatos.TabStop = False
        Me.listadatos.Text = "Clientes"
        '
        'botonnuevo
        '
        Me.botonnuevo.BackColor = System.Drawing.Color.LightYellow
        Me.botonnuevo.Location = New System.Drawing.Point(21, 347)
        Me.botonnuevo.Name = "botonnuevo"
        Me.botonnuevo.Size = New System.Drawing.Size(85, 26)
        Me.botonnuevo.TabIndex = 24
        Me.botonnuevo.Text = "Nuevo"
        Me.botonnuevo.UseVisualStyleBackColor = False
        '
        'botoneditar
        '
        Me.botoneditar.BackColor = System.Drawing.Color.LightYellow
        Me.botoneditar.Location = New System.Drawing.Point(142, 348)
        Me.botoneditar.Name = "botoneditar"
        Me.botoneditar.Size = New System.Drawing.Size(83, 25)
        Me.botoneditar.TabIndex = 23
        Me.botoneditar.Text = "Editar"
        Me.botoneditar.UseVisualStyleBackColor = False
        '
        'botoncancelar
        '
        Me.botoncancelar.BackColor = System.Drawing.Color.LightYellow
        Me.botoncancelar.Location = New System.Drawing.Point(250, 348)
        Me.botoncancelar.Name = "botoncancelar"
        Me.botoncancelar.Size = New System.Drawing.Size(84, 26)
        Me.botoncancelar.TabIndex = 22
        Me.botoncancelar.Text = "Cancelar"
        Me.botoncancelar.UseVisualStyleBackColor = False
        '
        'cajamail
        '
        Me.cajamail.Location = New System.Drawing.Point(180, 292)
        Me.cajamail.Name = "cajamail"
        Me.cajamail.Size = New System.Drawing.Size(145, 22)
        Me.cajamail.TabIndex = 21
        '
        'Lmail
        '
        Me.Lmail.AutoSize = True
        Me.Lmail.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lmail.Location = New System.Drawing.Point(29, 297)
        Me.Lmail.Name = "Lmail"
        Me.Lmail.Size = New System.Drawing.Size(52, 16)
        Me.Lmail.TabIndex = 20
        Me.Lmail.Text = "E-mail"
        '
        'cajadni
        '
        Me.cajadni.Location = New System.Drawing.Point(180, 264)
        Me.cajadni.Name = "cajadni"
        Me.cajadni.Size = New System.Drawing.Size(145, 22)
        Me.cajadni.TabIndex = 19
        '
        'Ldni
        '
        Me.Ldni.AutoSize = True
        Me.Ldni.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ldni.Location = New System.Drawing.Point(29, 271)
        Me.Ldni.Name = "Ldni"
        Me.Ldni.Size = New System.Drawing.Size(62, 16)
        Me.Ldni.TabIndex = 18
        Me.Ldni.Text = "DNI, LE"
        '
        'cajacuit
        '
        Me.cajacuit.Location = New System.Drawing.Point(180, 238)
        Me.cajacuit.Name = "cajacuit"
        Me.cajacuit.Size = New System.Drawing.Size(145, 22)
        Me.cajacuit.TabIndex = 17
        '
        'Lcuit
        '
        Me.Lcuit.AutoSize = True
        Me.Lcuit.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcuit.Location = New System.Drawing.Point(29, 245)
        Me.Lcuit.Name = "Lcuit"
        Me.Lcuit.Size = New System.Drawing.Size(38, 16)
        Me.Lcuit.TabIndex = 16
        Me.Lcuit.Text = "Cuit"
        '
        'cajalocalidad
        '
        Me.cajalocalidad.Location = New System.Drawing.Point(180, 213)
        Me.cajalocalidad.Name = "cajalocalidad"
        Me.cajalocalidad.Size = New System.Drawing.Size(145, 22)
        Me.cajalocalidad.TabIndex = 15
        '
        'Llocalidad
        '
        Me.Llocalidad.AutoSize = True
        Me.Llocalidad.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llocalidad.Location = New System.Drawing.Point(29, 220)
        Me.Llocalidad.Name = "Llocalidad"
        Me.Llocalidad.Size = New System.Drawing.Size(76, 16)
        Me.Llocalidad.TabIndex = 14
        Me.Llocalidad.Text = "Localidad"
        '
        'cajadomicilio
        '
        Me.cajadomicilio.Location = New System.Drawing.Point(180, 187)
        Me.cajadomicilio.Name = "cajadomicilio"
        Me.cajadomicilio.Size = New System.Drawing.Size(145, 22)
        Me.cajadomicilio.TabIndex = 13
        '
        'Ldomicilio
        '
        Me.Ldomicilio.AutoSize = True
        Me.Ldomicilio.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ldomicilio.Location = New System.Drawing.Point(29, 194)
        Me.Ldomicilio.Name = "Ldomicilio"
        Me.Ldomicilio.Size = New System.Drawing.Size(75, 16)
        Me.Ldomicilio.TabIndex = 12
        Me.Ldomicilio.Text = "Domicilio"
        '
        'cajatelefono
        '
        Me.cajatelefono.Location = New System.Drawing.Point(180, 161)
        Me.cajatelefono.Name = "cajatelefono"
        Me.cajatelefono.Size = New System.Drawing.Size(145, 22)
        Me.cajatelefono.TabIndex = 11
        '
        'Ltelefono
        '
        Me.Ltelefono.AutoSize = True
        Me.Ltelefono.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltelefono.Location = New System.Drawing.Point(29, 164)
        Me.Ltelefono.Name = "Ltelefono"
        Me.Ltelefono.Size = New System.Drawing.Size(67, 16)
        Me.Ltelefono.TabIndex = 10
        Me.Ltelefono.Text = "Teléfono"
        '
        'cajaestadocu
        '
        Me.cajaestadocu.Location = New System.Drawing.Point(180, 135)
        Me.cajaestadocu.Name = "cajaestadocu"
        Me.cajaestadocu.Size = New System.Drawing.Size(145, 22)
        Me.cajaestadocu.TabIndex = 9
        '
        'Lestadocuenta
        '
        Me.Lestadocuenta.AutoSize = True
        Me.Lestadocuenta.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lestadocuenta.Location = New System.Drawing.Point(29, 137)
        Me.Lestadocuenta.Name = "Lestadocuenta"
        Me.Lestadocuenta.Size = New System.Drawing.Size(125, 16)
        Me.Lestadocuenta.TabIndex = 8
        Me.Lestadocuenta.Text = "Estado de cuenta"
        '
        'cajanombre
        '
        Me.cajanombre.Location = New System.Drawing.Point(180, 109)
        Me.cajanombre.Name = "cajanombre"
        Me.cajanombre.Size = New System.Drawing.Size(145, 22)
        Me.cajanombre.TabIndex = 7
        '
        'Lnombre
        '
        Me.Lnombre.AutoSize = True
        Me.Lnombre.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnombre.Location = New System.Drawing.Point(29, 111)
        Me.Lnombre.Name = "Lnombre"
        Me.Lnombre.Size = New System.Drawing.Size(63, 16)
        Me.Lnombre.TabIndex = 6
        Me.Lnombre.Text = "Nombre"
        '
        'cajaapellido
        '
        Me.cajaapellido.Location = New System.Drawing.Point(180, 79)
        Me.cajaapellido.Name = "cajaapellido"
        Me.cajaapellido.Size = New System.Drawing.Size(145, 22)
        Me.cajaapellido.TabIndex = 5
        '
        'Lapellido
        '
        Me.Lapellido.AutoSize = True
        Me.Lapellido.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lapellido.Location = New System.Drawing.Point(29, 81)
        Me.Lapellido.Name = "Lapellido"
        Me.Lapellido.Size = New System.Drawing.Size(67, 16)
        Me.Lapellido.TabIndex = 4
        Me.Lapellido.Text = "Apellido"
        '
        'cajacuenta
        '
        Me.cajacuenta.Location = New System.Drawing.Point(180, 51)
        Me.cajacuenta.Name = "cajacuenta"
        Me.cajacuenta.Size = New System.Drawing.Size(145, 22)
        Me.cajacuenta.TabIndex = 3
        '
        'Lcuenta
        '
        Me.Lcuenta.AutoSize = True
        Me.Lcuenta.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcuenta.Location = New System.Drawing.Point(29, 49)
        Me.Lcuenta.Name = "Lcuenta"
        Me.Lcuenta.Size = New System.Drawing.Size(96, 16)
        Me.Lcuenta.TabIndex = 2
        Me.Lcuenta.Text = "N° De cuenta"
        '
        'cajacliente
        '
        Me.cajacliente.Location = New System.Drawing.Point(180, 23)
        Me.cajacliente.Name = "cajacliente"
        Me.cajacliente.Size = New System.Drawing.Size(145, 22)
        Me.cajacliente.TabIndex = 1
        '
        'Lcliente
        '
        Me.Lcliente.AutoSize = True
        Me.Lcliente.Font = New System.Drawing.Font("Cooper Std Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcliente.Location = New System.Drawing.Point(29, 25)
        Me.Lcliente.Name = "Lcliente"
        Me.Lcliente.Size = New System.Drawing.Size(77, 16)
        Me.Lcliente.TabIndex = 0
        Me.Lcliente.Text = "N° Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.botoneliminar)
        Me.GroupBox2.Controls.Add(Me.Lnoexiste)
        Me.GroupBox2.Controls.Add(Me.cajabuscar)
        Me.GroupBox2.Controls.Add(Me.combobusqueda)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Cooper Std Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(383, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(799, 418)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de clientes"
        '
        'botoneliminar
        '
        Me.botoneliminar.BackColor = System.Drawing.Color.LightYellow
        Me.botoneliminar.Location = New System.Drawing.Point(6, 382)
        Me.botoneliminar.Name = "botoneliminar"
        Me.botoneliminar.Size = New System.Drawing.Size(84, 26)
        Me.botoneliminar.TabIndex = 23
        Me.botoneliminar.Text = "Eliminar"
        Me.botoneliminar.UseVisualStyleBackColor = False
        '
        'Lnoexiste
        '
        Me.Lnoexiste.AutoSize = True
        Me.Lnoexiste.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnoexiste.Location = New System.Drawing.Point(333, 216)
        Me.Lnoexiste.Name = "Lnoexiste"
        Me.Lnoexiste.Size = New System.Drawing.Size(124, 16)
        Me.Lnoexiste.TabIndex = 3
        Me.Lnoexiste.Text = "No existen datos"
        '
        'cajabuscar
        '
        Me.cajabuscar.Location = New System.Drawing.Point(166, 27)
        Me.cajabuscar.Name = "cajabuscar"
        Me.cajabuscar.Size = New System.Drawing.Size(177, 21)
        Me.cajabuscar.TabIndex = 2
        '
        'combobusqueda
        '
        Me.combobusqueda.FormattingEnabled = True
        Me.combobusqueda.Items.AddRange(New Object() {"nombrec", "apellido", "dni", "idcliente"})
        Me.combobusqueda.Location = New System.Drawing.Point(6, 27)
        Me.combobusqueda.Name = "combobusqueda"
        Me.combobusqueda.Size = New System.Drawing.Size(154, 21)
        Me.combobusqueda.TabIndex = 1
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(6, 58)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(787, 320)
        Me.datalistado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Formcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(1202, 513)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.listadatos)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.Name = "Formcliente"
        Me.Text = "Listado de clientes"
        Me.listadatos.ResumeLayout(False)
        Me.listadatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listadatos As System.Windows.Forms.GroupBox
    Friend WithEvents cajacliente As System.Windows.Forms.TextBox
    Friend WithEvents Lcliente As System.Windows.Forms.Label
    Friend WithEvents cajamail As System.Windows.Forms.TextBox
    Friend WithEvents Lmail As System.Windows.Forms.Label
    Friend WithEvents cajadni As System.Windows.Forms.TextBox
    Friend WithEvents Ldni As System.Windows.Forms.Label
    Friend WithEvents cajacuit As System.Windows.Forms.TextBox
    Friend WithEvents Lcuit As System.Windows.Forms.Label
    Friend WithEvents cajalocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Llocalidad As System.Windows.Forms.Label
    Friend WithEvents cajadomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Ldomicilio As System.Windows.Forms.Label
    Friend WithEvents cajatelefono As System.Windows.Forms.TextBox
    Friend WithEvents Ltelefono As System.Windows.Forms.Label
    Friend WithEvents cajaestadocu As System.Windows.Forms.TextBox
    Friend WithEvents Lestadocuenta As System.Windows.Forms.Label
    Friend WithEvents cajanombre As System.Windows.Forms.TextBox
    Friend WithEvents Lnombre As System.Windows.Forms.Label
    Friend WithEvents cajaapellido As System.Windows.Forms.TextBox
    Friend WithEvents Lapellido As System.Windows.Forms.Label
    Friend WithEvents cajacuenta As System.Windows.Forms.TextBox
    Friend WithEvents Lcuenta As System.Windows.Forms.Label
    Friend WithEvents botonnuevo As System.Windows.Forms.Button
    Friend WithEvents botoneditar As System.Windows.Forms.Button
    Friend WithEvents botoncancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cajabuscar As System.Windows.Forms.TextBox
    Friend WithEvents combobusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents botoneliminar As System.Windows.Forms.Button
    Friend WithEvents Lnoexiste As System.Windows.Forms.Label
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
