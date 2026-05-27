<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNombre = New TextBox()
        txtPrecio = New TextBox()
        lblCategoria = New Label()
        lblIva = New Label()
        lblPrecioFinal = New Label()
        btnClasificar = New Button()
        btnLimpiar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 3
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 4
        Label5.Text = "Label5"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(319, 52)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 5
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(319, 99)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 6
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Location = New Point(519, 78)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(41, 15)
        lblCategoria.TabIndex = 7
        lblCategoria.Text = "Label6"
        ' 
        ' lblIva
        ' 
        lblIva.AutoSize = True
        lblIva.Location = New Point(519, 107)
        lblIva.Name = "lblIva"
        lblIva.Size = New Size(41, 15)
        lblIva.TabIndex = 8
        lblIva.Text = "Label7"
        ' 
        ' lblPrecioFinal
        ' 
        lblPrecioFinal.AutoSize = True
        lblPrecioFinal.Location = New Point(519, 138)
        lblPrecioFinal.Name = "lblPrecioFinal"
        lblPrecioFinal.Size = New Size(41, 15)
        lblPrecioFinal.TabIndex = 9
        lblPrecioFinal.Text = "Label8"
        ' 
        ' btnClasificar
        ' 
        btnClasificar.Location = New Point(309, 243)
        btnClasificar.Name = "btnClasificar"
        btnClasificar.Size = New Size(75, 23)
        btnClasificar.TabIndex = 10
        btnClasificar.Text = "clasificar"
        btnClasificar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(413, 244)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(75, 23)
        btnLimpiar.TabIndex = 11
        btnLimpiar.Text = "limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLimpiar)
        Controls.Add(btnClasificar)
        Controls.Add(lblPrecioFinal)
        Controls.Add(lblIva)
        Controls.Add(lblCategoria)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombre)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblPrecioFinal As Label
    Friend WithEvents btnClasificar As Button
    Friend WithEvents btnLimpiar As Button

End Class
