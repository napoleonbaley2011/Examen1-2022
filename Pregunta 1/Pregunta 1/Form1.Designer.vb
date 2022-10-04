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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.A = New System.Windows.Forms.TextBox()
        Me.B = New System.Windows.Forms.TextBox()
        Me.C = New System.Windows.Forms.TextBox()
        Me.RES = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDENAR"
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(33, 52)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(50, 20)
        Me.A.TabIndex = 1
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(33, 90)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(50, 20)
        Me.B.TabIndex = 2
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(33, 127)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(50, 20)
        Me.C.TabIndex = 3
        '
        'RES
        '
        Me.RES.Location = New System.Drawing.Point(205, 90)
        Me.RES.Name = "RES"
        Me.RES.Size = New System.Drawing.Size(151, 20)
        Me.RES.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ORDENAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 164)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RES)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents A As TextBox
    Friend WithEvents B As TextBox
    Friend WithEvents C As TextBox
    Friend WithEvents RES As TextBox
    Friend WithEvents Button1 As Button
End Class
