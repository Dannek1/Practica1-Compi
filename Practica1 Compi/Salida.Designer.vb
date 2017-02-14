<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salida
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtPuntos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTiempo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEsquivar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDestruidos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 274)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(393, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtPuntos
        '
        Me.TxtPuntos.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPuntos.Location = New System.Drawing.Point(207, 47)
        Me.TxtPuntos.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.TxtPuntos.Name = "TxtPuntos"
        Me.TxtPuntos.ReadOnly = True
        Me.TxtPuntos.Size = New System.Drawing.Size(104, 24)
        Me.TxtPuntos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Puntos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tiempo"
        '
        'TxtTiempo
        '
        Me.TxtTiempo.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTiempo.Location = New System.Drawing.Point(207, 89)
        Me.TxtTiempo.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.TxtTiempo.Name = "TxtTiempo"
        Me.TxtTiempo.ReadOnly = True
        Me.TxtTiempo.Size = New System.Drawing.Size(104, 24)
        Me.TxtTiempo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Esquivados"
        '
        'txtEsquivar
        '
        Me.txtEsquivar.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEsquivar.Location = New System.Drawing.Point(207, 137)
        Me.txtEsquivar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtEsquivar.Name = "txtEsquivar"
        Me.txtEsquivar.ReadOnly = True
        Me.txtEsquivar.Size = New System.Drawing.Size(104, 24)
        Me.txtEsquivar.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 185)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Destruidos"
        '
        'TxtDestruidos
        '
        Me.TxtDestruidos.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDestruidos.Location = New System.Drawing.Point(207, 182)
        Me.TxtDestruidos.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.TxtDestruidos.Name = "TxtDestruidos"
        Me.TxtDestruidos.ReadOnly = True
        Me.TxtDestruidos.Size = New System.Drawing.Size(104, 24)
        Me.TxtDestruidos.TabIndex = 7
        '
        'Salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtDestruidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEsquivar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTiempo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPuntos)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("BankGothic Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "Salida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TxtPuntos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTiempo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEsquivar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDestruidos As TextBox
End Class
