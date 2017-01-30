<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pig_Game
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
        Me.components = New System.ComponentModel.Container()
        Me.txt_jug1 = New System.Windows.Forms.TextBox()
        Me.txt_jug2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_jugar = New System.Windows.Forms.Button()
        Me.bt_acomular = New System.Windows.Forms.Button()
        Me.txt_dado = New System.Windows.Forms.TextBox()
        Me.bt_db = New System.Windows.Forms.Button()
        Me.bt_ceder = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txt_jug1
        '
        Me.txt_jug1.Enabled = False
        Me.txt_jug1.Location = New System.Drawing.Point(50, 37)
        Me.txt_jug1.Name = "txt_jug1"
        Me.txt_jug1.ReadOnly = True
        Me.txt_jug1.Size = New System.Drawing.Size(100, 20)
        Me.txt_jug1.TabIndex = 0
        '
        'txt_jug2
        '
        Me.txt_jug2.Enabled = False
        Me.txt_jug2.Location = New System.Drawing.Point(449, 37)
        Me.txt_jug2.Name = "txt_jug2"
        Me.txt_jug2.ReadOnly = True
        Me.txt_jug2.Size = New System.Drawing.Size(100, 20)
        Me.txt_jug2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "JUGADOR 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(476, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PIG"
        '
        'bt_jugar
        '
        Me.bt_jugar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_jugar.Location = New System.Drawing.Point(270, 287)
        Me.bt_jugar.Name = "bt_jugar"
        Me.bt_jugar.Size = New System.Drawing.Size(99, 33)
        Me.bt_jugar.TabIndex = 4
        Me.bt_jugar.Text = "Jugar"
        Me.bt_jugar.UseVisualStyleBackColor = True
        '
        'bt_acomular
        '
        Me.bt_acomular.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_acomular.Location = New System.Drawing.Point(50, 114)
        Me.bt_acomular.Name = "bt_acomular"
        Me.bt_acomular.Size = New System.Drawing.Size(100, 35)
        Me.bt_acomular.TabIndex = 5
        Me.bt_acomular.Text = "Acomular"
        Me.bt_acomular.UseVisualStyleBackColor = True
        '
        'txt_dado
        '
        Me.txt_dado.Enabled = False
        Me.txt_dado.Location = New System.Drawing.Point(287, 182)
        Me.txt_dado.Multiline = True
        Me.txt_dado.Name = "txt_dado"
        Me.txt_dado.ReadOnly = True
        Me.txt_dado.Size = New System.Drawing.Size(82, 46)
        Me.txt_dado.TabIndex = 6
        '
        'bt_db
        '
        Me.bt_db.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_db.Location = New System.Drawing.Point(500, 114)
        Me.bt_db.Name = "bt_db"
        Me.bt_db.Size = New System.Drawing.Size(112, 35)
        Me.bt_db.TabIndex = 7
        Me.bt_db.Text = "Darse de Baja"
        Me.bt_db.UseVisualStyleBackColor = True
        '
        'bt_ceder
        '
        Me.bt_ceder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ceder.Location = New System.Drawing.Point(270, 114)
        Me.bt_ceder.Name = "bt_ceder"
        Me.bt_ceder.Size = New System.Drawing.Size(120, 35)
        Me.bt_ceder.TabIndex = 8
        Me.bt_ceder.Text = "Ceder"
        Me.bt_ceder.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Pig_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 413)
        Me.Controls.Add(Me.bt_ceder)
        Me.Controls.Add(Me.bt_db)
        Me.Controls.Add(Me.txt_dado)
        Me.Controls.Add(Me.bt_acomular)
        Me.Controls.Add(Me.bt_jugar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_jug2)
        Me.Controls.Add(Me.txt_jug1)
        Me.Name = "Pig_Game"
        Me.Text = "Pig Game :Gilberth"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_jug1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_jug2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_jugar As System.Windows.Forms.Button
    Friend WithEvents bt_acomular As System.Windows.Forms.Button
    Friend WithEvents txt_dado As System.Windows.Forms.TextBox
    Friend WithEvents bt_db As System.Windows.Forms.Button
    Friend WithEvents bt_ceder As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
