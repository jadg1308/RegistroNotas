Public Class FrmNuevaAsignatura
    Dim asign As New BDUCADataSetTableAdapters.AsignaturaTableAdapter
    Dim idAsign As Integer
    Dim estado As Boolean
    Dim tblAsig As New BDUCADataSet.AsignaturaDataTable

    Private Sub BtnImprimirFicha_Click(sender As Object, e As EventArgs) Handles BtnImprimirFicha.Click
        asign.FillBy1(tblAsig, idAsign)
        VerReporte(tblAsig, "DsDatos", "C:\Reportes\RptFichaAsig.rdlc")
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        asign.Fill(tblAsig)
        VerReporte(tblAsig, "DsDatos", "C:\Reportes\RptAsignatura.rdlc")

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtNombre.Text = ""
        TxtCreditos.Clear()
        BtnGuardar.Enabled = True
        BtnEliminar.Enabled = False
        BtnEditar.Enabled = False
        BtnImprimirFicha.Enabled = False
        TxtNombre.Focus()
    End Sub

    Private Sub FrmNuevaAsignatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
    End Sub

    Sub llenarGrid()
        DgvRegistros.DataSource = asign.GetData
        DgvRegistros.Refresh()
        'ocultar columna
        DgvRegistros.Columns().Item(3).Visible = False
        GroupBox2.Text = "Registros guardados: " & DgvRegistros.Rows.Count.ToString
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
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

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
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
        asign.ActualizarRegistro(nombre, creditos, estado, idAsign)

        llenarGrid()

    End Sub



    Private Sub DgvRegistros_DoubleClick(sender As Object, e As EventArgs) Handles DgvRegistros.DoubleClick
        Try
            Dim fila As Integer = DgvRegistros.CurrentRow.Index
            idAsign = DgvRegistros.Item(0, fila).Value
            TxtNombre.Text = DgvRegistros.Item(1, fila).Value
            TxtCreditos.Text = DgvRegistros.Item(2, fila).Value
            estado = DgvRegistros.Item(3, fila).Value
            BtnGuardar.Enabled = False
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnImprimirFicha.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                asign.EliminarRegistro(idAsign)
                llenarGrid()
                BtnNuevo.PerformClick()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim dato As String = TxtDato.Text & "%"
            DgvRegistros.DataSource = asign.BuscarPorNombre(dato)
            DgvRegistros.Refresh()

            GroupBox2.Text = "Registros encontrados: " & DgvRegistros.Rows.Count.ToString
        Catch ex As Exception

        End Try
    End Sub


End Class