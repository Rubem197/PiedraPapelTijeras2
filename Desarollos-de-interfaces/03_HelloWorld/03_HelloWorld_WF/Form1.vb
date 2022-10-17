Imports _03_HelloWorld_EntidadesEstandar


Public Class Form1

    ''' <summary>
    ''' comentarios: Evento asociado el clcik btsaludar. Mostrara por pantalla el nombre de la persona.
    ''' precondiciones:Tiene que tener algo escrito
    ''' postcondiciones:
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaludar_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click

        Dim persona1 As New clsPersonas(tbNombre.Text)

        MessageBox.Show("Saludos " + persona1.Nombre)

    End Sub
End Class