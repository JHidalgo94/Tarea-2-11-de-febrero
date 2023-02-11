<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.primerparcialTextBox1 = New System.Windows.Forms.TextBox()
        Me.segundoparcialTextBox2 = New System.Windows.Forms.TextBox()
        Me.tercerparcialTextBox3 = New System.Windows.Forms.TextBox()
        Me.cuartoparcialTextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.promedioButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'primerparcialTextBox1
        '
        Me.primerparcialTextBox1.Location = New System.Drawing.Point(138, 142)
        Me.primerparcialTextBox1.Name = "primerparcialTextBox1"
        Me.primerparcialTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.primerparcialTextBox1.TabIndex = 0
        '
        'segundoparcialTextBox2
        '
        Me.segundoparcialTextBox2.Location = New System.Drawing.Point(138, 185)
        Me.segundoparcialTextBox2.Name = "segundoparcialTextBox2"
        Me.segundoparcialTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.segundoparcialTextBox2.TabIndex = 1
        '
        'tercerparcialTextBox3
        '
        Me.tercerparcialTextBox3.Location = New System.Drawing.Point(138, 221)
        Me.tercerparcialTextBox3.Name = "tercerparcialTextBox3"
        Me.tercerparcialTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.tercerparcialTextBox3.TabIndex = 2
        '
        'cuartoparcialTextBox4
        '
        Me.cuartoparcialTextBox4.Location = New System.Drawing.Point(138, 259)
        Me.cuartoparcialTextBox4.Name = "cuartoparcialTextBox4"
        Me.cuartoparcialTextBox4.Size = New System.Drawing.Size(100, 20)
        Me.cuartoparcialTextBox4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese las notas del parcial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "1 Parcial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "2 Parcial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "3 Parcial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "4 Parcial"
        '
        'promedioButton1
        '
        Me.promedioButton1.Location = New System.Drawing.Point(381, 185)
        Me.promedioButton1.Name = "promedioButton1"
        Me.promedioButton1.Size = New System.Drawing.Size(75, 23)
        Me.promedioButton1.TabIndex = 9
        Me.promedioButton1.Text = "Promedio"
        Me.promedioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.promedioButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cuartoparcialTextBox4)
        Me.Controls.Add(Me.tercerparcialTextBox3)
        Me.Controls.Add(Me.segundoparcialTextBox2)
        Me.Controls.Add(Me.primerparcialTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents primerparcialTextBox1 As TextBox
    Friend WithEvents segundoparcialTextBox2 As TextBox
    Friend WithEvents tercerparcialTextBox3 As TextBox
    Friend WithEvents cuartoparcialTextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents promedioButton1 As Button
End Class
