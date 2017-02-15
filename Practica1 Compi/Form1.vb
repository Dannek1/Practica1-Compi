Imports System.IO


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text.Equals("")) Then
            MessageBox.Show("No hay nada que analizar", "Error")
        Else
            MyParser.Setup()

            If (MyParser.Parse(New StringReader(TextBox1.Text))) Then
                Dim Seleccion As New Seleccion
                Seleccion.Label1.Text = Nombre_Juego
                Seleccion.Show()
                Me.Hide()
            Else
                MessageBox.Show("Ha habido un Error" + SError, "Error")
            End If
            TextBox1.Clear()
















        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
            TextBox1.Text = (sr.ReadToEnd)
            sr.Close()
        End If
    End Sub
End Class
