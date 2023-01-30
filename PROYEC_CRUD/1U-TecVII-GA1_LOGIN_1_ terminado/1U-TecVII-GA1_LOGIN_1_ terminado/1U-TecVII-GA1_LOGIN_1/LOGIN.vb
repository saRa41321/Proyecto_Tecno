Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data

Public Class LOGIN
    Dim con As conexion = New conexion
    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim f2 = Admistrador1
        Dim verificar As String = "update SECCION set ROLL=ROLL where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and ROLL='administrador'"
        Dim verificar2 As String = "update SECCION set ROLL=ROLL where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and ROLL='usuario'"
        Dim verificar3 As String = "update SECCION set ROLL=ROLL where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and ROLL='secretaria'"

        If con.Verificacion(verificar) Then
            Admistrador1.BringToFront()


        ElseIf con.Verificacion(verificar2) Then
            Admistrador1.BringToFront()
            f2.btn_borrar.Visible = False
            f2.btn_editar.Visible = False
            f2.btn_insetar.Visible = False
        ElseIf con.Verificacion(verificar3) Then

            Admistrador1.BringToFront()
        Else
            MsgBox("Error")
        End If
        If con.Verificacion(verificar3) Then
            f2.btn_insetar.Visible = False
        End If

    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub txt_contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_contraseña.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
