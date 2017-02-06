Public Class Interfaz_Pig

    Private Sub cb_nivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_nivel.SelectedIndexChanged
        If cb_nivel.SelectedIndex = 0 Then



        End If

    End Sub

    Private Sub Interfaz_Pig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_jugar_Click(sender As Object, e As EventArgs) Handles bt_jugar.Click
        Pig_Game.lb_Jugador_1.Text = txt_nombre.Text

        If cb_juga.SelectedIndex = 2 Then
            
            Pig_Game.lb_jugador_2.Text = txt_jugador_2.Text

        End If

        Pig_Game.Show()

    End Sub

    Private Sub cb_juga_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_juga.SelectedIndexChanged
        If cb_juga.SelectedIndex = 2 Then
            lb_jug2.Visible = True
            txt_jugador_2.Visible = True

        ElseIf cb_juga.SelectedIndex = 1 Then

            lb_jug2.Visible = False
            txt_jugador_2.Visible = False

        End If
    End Sub
End Class