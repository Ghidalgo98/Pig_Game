﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interfaz_Pig
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
        Me.cb_nivel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_nombre = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt_jugar = New System.Windows.Forms.Button()
        Me.lb_jug = New System.Windows.Forms.Label()
        Me.cb_juga = New System.Windows.Forms.ComboBox()
        Me.lb_jug2 = New System.Windows.Forms.Label()
        Me.txt_jugador_2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cb_nivel
        '
        Me.cb_nivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_nivel.FormattingEnabled = True
        Me.cb_nivel.Items.AddRange(New Object() {"Experto", "Medio", "Novato", "Seleccione un nivel"})
        Me.cb_nivel.Location = New System.Drawing.Point(156, 131)
        Me.cb_nivel.Name = "cb_nivel"
        Me.cb_nivel.Size = New System.Drawing.Size(121, 21)
        Me.cb_nivel.Sorted = True
        Me.cb_nivel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PIG GAME:GILBERTH"
        '
        'lb_nombre
        '
        Me.lb_nombre.AutoSize = True
        Me.lb_nombre.Location = New System.Drawing.Point(12, 99)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(57, 13)
        Me.lb_nombre.TabIndex = 2
        Me.lb_nombre.Text = "Jugador_1"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(156, 88)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(121, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nivel de Difultad"
        '
        'bt_jugar
        '
        Me.bt_jugar.Location = New System.Drawing.Point(16, 294)
        Me.bt_jugar.Name = "bt_jugar"
        Me.bt_jugar.Size = New System.Drawing.Size(123, 35)
        Me.bt_jugar.TabIndex = 5
        Me.bt_jugar.Text = "Jugar"
        Me.bt_jugar.UseVisualStyleBackColor = True
        '
        'lb_jug
        '
        Me.lb_jug.AutoSize = True
        Me.lb_jug.Location = New System.Drawing.Point(13, 180)
        Me.lb_jug.Name = "lb_jug"
        Me.lb_jug.Size = New System.Drawing.Size(105, 13)
        Me.lb_jug.TabIndex = 6
        Me.lb_jug.Text = "Modalidad De Juego"
        '
        'cb_juga
        '
        Me.cb_juga.AllowDrop = True
        Me.cb_juga.FormattingEnabled = True
        Me.cb_juga.Items.AddRange(New Object() {"Seleccione modalidad de Juego", "Contra Pig", "Contra Otro Jugador"})
        Me.cb_juga.Location = New System.Drawing.Point(156, 180)
        Me.cb_juga.Name = "cb_juga"
        Me.cb_juga.Size = New System.Drawing.Size(121, 21)
        Me.cb_juga.TabIndex = 7
        '
        'lb_jug2
        '
        Me.lb_jug2.AutoSize = True
        Me.lb_jug2.Location = New System.Drawing.Point(306, 88)
        Me.lb_jug2.Name = "lb_jug2"
        Me.lb_jug2.Size = New System.Drawing.Size(57, 13)
        Me.lb_jug2.TabIndex = 8
        Me.lb_jug2.Text = "Jugador_2"
        Me.lb_jug2.Visible = False
        '
        'txt_jugador_2
        '
        Me.txt_jugador_2.Location = New System.Drawing.Point(369, 81)
        Me.txt_jugador_2.Name = "txt_jugador_2"
        Me.txt_jugador_2.Size = New System.Drawing.Size(121, 20)
        Me.txt_jugador_2.TabIndex = 9
        Me.txt_jugador_2.Visible = False
        '
        'Interfaz_Pig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 374)
        Me.Controls.Add(Me.txt_jugador_2)
        Me.Controls.Add(Me.lb_jug2)
        Me.Controls.Add(Me.cb_juga)
        Me.Controls.Add(Me.lb_jug)
        Me.Controls.Add(Me.bt_jugar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lb_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_nivel)
        Me.Name = "Interfaz_Pig"
        Me.Text = "Interfaz_Pig"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_jugar As System.Windows.Forms.Button
    Friend WithEvents lb_jug As System.Windows.Forms.Label
    Friend WithEvents cb_juga As System.Windows.Forms.ComboBox
    Friend WithEvents lb_jug2 As System.Windows.Forms.Label
    Friend WithEvents txt_jugador_2 As System.Windows.Forms.TextBox
    Private WithEvents cb_nivel As System.Windows.Forms.ComboBox
End Class
