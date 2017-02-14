<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImgNaves = New System.Windows.Forms.PictureBox()
        Me.ComboNaves = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ImgFondos = New System.Windows.Forms.PictureBox()
        Me.ComboFondos = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ImgDefensas = New System.Windows.Forms.PictureBox()
        Me.ComboDefensas = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgNaves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ImgFondos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ImgDefensas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ImgNaves)
        Me.GroupBox1.Controls.Add(Me.ComboNaves)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Naves"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Elegir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImgNaves
        '
        Me.ImgNaves.Location = New System.Drawing.Point(7, 58)
        Me.ImgNaves.Name = "ImgNaves"
        Me.ImgNaves.Size = New System.Drawing.Size(168, 156)
        Me.ImgNaves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgNaves.TabIndex = 1
        Me.ImgNaves.TabStop = False
        '
        'ComboNaves
        '
        Me.ComboNaves.FormattingEnabled = True
        Me.ComboNaves.Location = New System.Drawing.Point(7, 30)
        Me.ComboNaves.Name = "ComboNaves"
        Me.ComboNaves.Size = New System.Drawing.Size(168, 21)
        Me.ComboNaves.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.ImgFondos)
        Me.GroupBox2.Controls.Add(Me.ComboFondos)
        Me.GroupBox2.Location = New System.Drawing.Point(252, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 275)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fondos"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(42, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Elegir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ImgFondos
        '
        Me.ImgFondos.Location = New System.Drawing.Point(7, 58)
        Me.ImgFondos.Name = "ImgFondos"
        Me.ImgFondos.Size = New System.Drawing.Size(168, 156)
        Me.ImgFondos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgFondos.TabIndex = 1
        Me.ImgFondos.TabStop = False
        '
        'ComboFondos
        '
        Me.ComboFondos.FormattingEnabled = True
        Me.ComboFondos.Location = New System.Drawing.Point(7, 30)
        Me.ComboFondos.Name = "ComboFondos"
        Me.ComboFondos.Size = New System.Drawing.Size(168, 21)
        Me.ComboFondos.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(76, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "&Iniciar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(498, 335)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "&Volver a Analizar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.ImgDefensas)
        Me.GroupBox3.Controls.Add(Me.ComboDefensas)
        Me.GroupBox3.Location = New System.Drawing.Point(470, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(187, 275)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fondos"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(42, 238)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Elegir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ImgDefensas
        '
        Me.ImgDefensas.Location = New System.Drawing.Point(7, 58)
        Me.ImgDefensas.Name = "ImgDefensas"
        Me.ImgDefensas.Size = New System.Drawing.Size(168, 156)
        Me.ImgDefensas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgDefensas.TabIndex = 1
        Me.ImgDefensas.TabStop = False
        '
        'ComboDefensas
        '
        Me.ComboDefensas.FormattingEnabled = True
        Me.ComboDefensas.Location = New System.Drawing.Point(7, 30)
        Me.ComboDefensas.Name = "ComboDefensas"
        Me.ComboDefensas.Size = New System.Drawing.Size(168, 21)
        Me.ComboDefensas.TabIndex = 0
        '
        'Seleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Seleccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ImgNaves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ImgFondos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ImgDefensas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ImgNaves As PictureBox
    Friend WithEvents ComboNaves As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ImgFondos As PictureBox
    Friend WithEvents ComboFondos As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents ImgDefensas As PictureBox
    Friend WithEvents ComboDefensas As ComboBox
End Class
