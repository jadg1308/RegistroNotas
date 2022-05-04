Public Class FrmNuevaAsignatura
    Dim asign As New BDUCADataSetTableAdapters.AsignaturaTableAdapter
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        TxtNombre.Text = ""
        TxtCreditos.Clear()
        TxtNombre.Focus()
    End Sub

    Private Sub FrmNuevaAsignatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
    End Sub

    Sub llenarGrid()
        DgvRegistros.DataSource = asign.GetData
        DgvRegistros.Refresh()
        GroupBox2.Text = "Registros guardados: " & DgvRegistros.Rows.Count.ToString
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If (String.IsNullOrEmpty(TxtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            TxtNombre.Focus()
            Exit Sub
        End If
        If (Not IsNumeric(TxtCreditos.Text)) Then
            MsgBox("Los crédito deben ser numericos", MsgBoxStyle.Critical, "ERROR")
            TxtCreditos.Focus()
            Exit Sub
        End If
        Dim nombre As String = TxtNombre.Text.Trim
        Dim creditos As Integer = CInt(TxtCreditos.Text.Trim)
        asign.InsertarRegistro(nombre, creditos, True)
        llenarGrid()

    End Sub
End Class