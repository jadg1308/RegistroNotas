Imports System.Data.SqlClient

Public Class FrmNota
    Dim asig As New BDUCADataSetTableAdapters.AsignaturaTableAdapter
    Dim est As New BDUCADataSetTableAdapters.ConsultaEstTableAdapter
    Dim nota As New BDUCADataSetTableAdapters.NotaTableAdapter
    Dim regNotas As New BDUCADataSetTableAdapters.NotasTableAdapter

    Sub llenarAsig()
        CmbAsignatura.DataSource = asig.GetData()
        CmbAsignatura.DisplayMember = "nombre"
        CmbAsignatura.ValueMember = "idAsign"
        CmbAsignatura.Refresh()
    End Sub

    'Public Function mostrarEst() As DataSet
    '    Dim tsql As String = "select idEst, CONCAT(nombre, ' ', apellido) as 'NombreCompleto' from Estudiante"
    '    Dim strConex As String = My.Settings.CsBdUCA
    '    Dim ds As New DataSet
    '    Dim da As New SqlDataAdapter(tsql, strConex)
    '    da.Fill(ds)
    '    Return ds

    'End Function

    Sub llenarEst()

        CmbEstudiante.DataSource = est.GetData
        CmbEstudiante.DisplayMember = "NombreCompleto"
        CmbEstudiante.ValueMember = "idEst"
        CmbEstudiante.Refresh()
    End Sub

    Private Sub FrmNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarAsig()
        llenarEst()
        llenarGrid()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim idAsig As Integer = CInt(CmbAsignatura.SelectedValue)
            Dim idEst As Integer = CInt(CmbEstudiante.SelectedValue)
            Dim cal As Integer = CInt(TxtNota.Text)
            nota.InsertarRegistro(idEst, idAsig, cal)
            llenarGrid()
        Catch ex As Exception

        End Try
    End Sub

    Sub llenarGrid()
        DgvRegistros.DataSource = regNotas.GetData
        DgvRegistros.Refresh()

        GroupBox2.Text = "Registros guardados: " & DgvRegistros.Rows.Count
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub
End Class