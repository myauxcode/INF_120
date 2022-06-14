Public Class Form1

    Dim m1, m2, m3 As matriz
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m1 = New matriz
        m2 = New matriz
        m3 = New matriz
    End Sub
    Private Sub CargarDatoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        m1.CargaManual(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        m1.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox5.Text = m1.descargar()
    End Sub



    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox6.Text = m2.descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        TextBox7.Text = m3.descargar()
    End Sub
    Private Sub EjercicioP1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EjercicioP1ToolStripMenuItem1.Click
        TextBox5.Text = m1.ejercicio1p1
    End Sub


    Private Sub CargarRToolStripMenuItem_Click(sender As Object, e As EventArgs)
        m1.cargarR(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub



    Private Sub CargarDatoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarDatoToolStripMenuItem1.Click
        m2.CargaManual(TextBox1.Text, TextBox2.Text)
    End Sub


    Private Sub CargarDatoToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        m1.CargaManual(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub CargarToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        m1.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarRNDToolStripMenuItem_Click(sender As Object, e As EventArgs)
        m1.cargarR(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        TextBox5.Text = m1.descargar()
    End Sub





    Private Sub CargarDatoToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CargarDatoToolStripMenuItem3.Click
        m1.CargaManual(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = m1.descargar()
    End Sub

    Private Sub CargarToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        m1.Cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem4.Click
        m1.cargarR(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem4.Click
        TextBox5.Text = m1.descargar()

    End Sub




End Class
