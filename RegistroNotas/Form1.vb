Public Class Form1
    Private Sub AsignaturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignaturaToolStripMenuItem.Click
        FrmAsignatura.Show()
    End Sub

    Private Sub NuevaAsignaturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaAsignaturaToolStripMenuItem.Click
        FrmNuevaAsignatura.Show()
    End Sub

    Private Sub NotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasToolStripMenuItem.Click
        FrmNota.MdiParent = Me
        FrmNota.Show()
    End Sub
End Class
