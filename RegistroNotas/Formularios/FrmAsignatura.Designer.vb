<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignatura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdAsignLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CreditosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignatura))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EstadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.AsignaturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDUCADataSet = New RegistroNotas.BDUCADataSet()
        Me.CreditosTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.IdAsignTextBox = New System.Windows.Forms.TextBox()
        Me.AsignaturaTableAdapter = New RegistroNotas.BDUCADataSetTableAdapters.AsignaturaTableAdapter()
        Me.TableAdapterManager = New RegistroNotas.BDUCADataSetTableAdapters.TableAdapterManager()
        Me.AsignaturaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AsignaturaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        IdAsignLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CreditosLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AsignaturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDUCADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AsignaturaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdAsignLabel
        '
        IdAsignLabel.AutoSize = True
        IdAsignLabel.Location = New System.Drawing.Point(56, 35)
        IdAsignLabel.Name = "IdAsignLabel"
        IdAsignLabel.Size = New System.Drawing.Size(18, 13)
        IdAsignLabel.TabIndex = 0
        IdAsignLabel.Text = "ID"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(20, 75)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(54, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "NOMBRE"
        '
        'CreditosLabel
        '
        CreditosLabel.AutoSize = True
        CreditosLabel.Location = New System.Drawing.Point(12, 105)
        CreditosLabel.Name = "CreditosLabel"
        CreditosLabel.Size = New System.Drawing.Size(62, 13)
        CreditosLabel.TabIndex = 4
        CreditosLabel.Text = "CREDITOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EstadoCheckBox)
        Me.GroupBox1.Controls.Add(CreditosLabel)
        Me.GroupBox1.Controls.Add(Me.CreditosTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(IdAsignLabel)
        Me.GroupBox1.Controls.Add(Me.IdAsignTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 146)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'EstadoCheckBox
        '
        Me.EstadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AsignaturaBindingSource, "estado", True))
        Me.EstadoCheckBox.Location = New System.Drawing.Point(186, 30)
        Me.EstadoCheckBox.Name = "EstadoCheckBox"
        Me.EstadoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EstadoCheckBox.TabIndex = 7
        Me.EstadoCheckBox.Text = "Activo"
        Me.EstadoCheckBox.UseVisualStyleBackColor = True
        '
        'AsignaturaBindingSource
        '
        Me.AsignaturaBindingSource.DataMember = "Asignatura"
        Me.AsignaturaBindingSource.DataSource = Me.BDUCADataSet
        '
        'BDUCADataSet
        '
        Me.BDUCADataSet.DataSetName = "BDUCADataSet"
        Me.BDUCADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CreditosTextBox
        '
        Me.CreditosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignaturaBindingSource, "creditos", True))
        Me.CreditosTextBox.Location = New System.Drawing.Point(80, 102)
        Me.CreditosTextBox.Name = "CreditosTextBox"
        Me.CreditosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreditosTextBox.TabIndex = 5
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignaturaBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(80, 68)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(202, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'IdAsignTextBox
        '
        Me.IdAsignTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignaturaBindingSource, "idAsign", True))
        Me.IdAsignTextBox.Location = New System.Drawing.Point(80, 32)
        Me.IdAsignTextBox.Name = "IdAsignTextBox"
        Me.IdAsignTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdAsignTextBox.TabIndex = 1
        '
        'AsignaturaTableAdapter
        '
        Me.AsignaturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AsignaturaTableAdapter = Me.AsignaturaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EstudianteTableAdapter = Nothing
        Me.TableAdapterManager.NotaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RegistroNotas.BDUCADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AsignaturaBindingNavigator
        '
        Me.AsignaturaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AsignaturaBindingNavigator.BindingSource = Me.AsignaturaBindingSource
        Me.AsignaturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AsignaturaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AsignaturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AsignaturaBindingNavigatorSaveItem})
        Me.AsignaturaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AsignaturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AsignaturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AsignaturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AsignaturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AsignaturaBindingNavigator.Name = "AsignaturaBindingNavigator"
        Me.AsignaturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AsignaturaBindingNavigator.Size = New System.Drawing.Size(339, 25)
        Me.AsignaturaBindingNavigator.TabIndex = 2
        Me.AsignaturaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AsignaturaBindingNavigatorSaveItem
        '
        Me.AsignaturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AsignaturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("AsignaturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AsignaturaBindingNavigatorSaveItem.Name = "AsignaturaBindingNavigatorSaveItem"
        Me.AsignaturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AsignaturaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FrmAsignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 223)
        Me.Controls.Add(Me.AsignaturaBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAsignatura"
        Me.Text = "Asignatura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AsignaturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDUCADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AsignaturaBindingNavigator.ResumeLayout(False)
        Me.AsignaturaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BDUCADataSet As BDUCADataSet
    Friend WithEvents AsignaturaBindingSource As BindingSource
    Friend WithEvents AsignaturaTableAdapter As BDUCADataSetTableAdapters.AsignaturaTableAdapter
    Friend WithEvents TableAdapterManager As BDUCADataSetTableAdapters.TableAdapterManager
    Friend WithEvents AsignaturaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AsignaturaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EstadoCheckBox As CheckBox
    Friend WithEvents CreditosTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents IdAsignTextBox As TextBox
End Class
