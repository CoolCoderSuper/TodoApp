<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtNote = New TextBox()
        btnDelete = New Button()
        btnNew = New Button()
        btnSave = New Button()
        dgvTodo = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvTodo, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNote
        ' 
        txtNote.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNote.Location = New Point(12, 12)
        txtNote.Name = "txtNote"
        txtNote.Size = New Size(379, 23)
        txtNote.TabIndex = 1
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDelete.Location = New Point(397, 12)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNew.Location = New Point(478, 11)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(75, 23)
        btnNew.TabIndex = 3
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnSave.Location = New Point(12, 519)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(537, 23)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' dgvTodo
        ' 
        dgvTodo.AllowUserToAddRows = False
        dgvTodo.AllowUserToDeleteRows = False
        dgvTodo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTodo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTodo.BackgroundColor = SystemColors.ControlLightLight
        dgvTodo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTodo.ColumnHeadersVisible = False
        dgvTodo.Location = New Point(12, 41)
        dgvTodo.MultiSelect = False
        dgvTodo.Name = "dgvTodo"
        dgvTodo.ReadOnly = True
        dgvTodo.RowHeadersVisible = False
        dgvTodo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTodo.Size = New Size(537, 472)
        dgvTodo.TabIndex = 5
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(561, 554)
        Controls.Add(dgvTodo)
        Controls.Add(btnSave)
        Controls.Add(btnNew)
        Controls.Add(btnDelete)
        Controls.Add(txtNote)
        Name = "frmMain"
        Text = "Todo"
        CType(dgvTodo, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtNote As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvTodo As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
