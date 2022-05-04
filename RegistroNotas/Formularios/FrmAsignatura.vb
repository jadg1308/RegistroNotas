Public Class FrmAsignatura
    Private Sub AsignaturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AsignaturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDUCADataSet)

    End Sub

    Private Sub FrmAsignatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDUCADataSet.Asignatura' Puede moverla o quitarla según sea necesario.
        Me.AsignaturaTableAdapter.Fill(Me.BDUCADataSet.Asignatura)
        'TODO: esta línea de código carga datos en la tabla 'BDUCADataSet.Asignatura' Puede moverla o quitarla según sea necesario.
        Me.AsignaturaTableAdapter.Fill(Me.BDUCADataSet.Asignatura)

    End Sub

    Private Sub AsignaturaBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles AsignaturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AsignaturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDUCADataSet)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        IdAsignTextBox.Text = 0
        EstadoCheckBox.Checked = True
        NombreTextBox.Focus()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub
End Class