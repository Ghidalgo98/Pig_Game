Public Class Interfaz_Pig

    Private Sub cb_nivel_SelectedIndexChanged(sender As Object, e As EventArgs)
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




        If cb_juga.SelectedIndex = 0 Then
            MsgBox("Seleccione Primero un modulo de juego")

        ElseIf cb_nivel.SelectedIndex = 0 Then

            MsgBox("Seleccione Primero un Nivel de juego")

        ElseIf cb_juga.Items.Count <= 0 Then

            MsgBox("Seleccione Primero una opcion")


        Else
            Pig_Game.Show()

        End If







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