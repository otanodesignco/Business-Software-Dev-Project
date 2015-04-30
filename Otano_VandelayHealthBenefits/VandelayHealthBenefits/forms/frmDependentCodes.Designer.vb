<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDependentCodes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DependentCodeLabel As System.Windows.Forms.Label
        Dim DependentDescrLabel As System.Windows.Forms.Label
        Me.menuVandelay = New System.Windows.Forms.MenuStrip()
        Me.menuDepartments = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInsCo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEnroll = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRates = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtBoxCode = New System.Windows.Forms.TextBox()
        Me.txtBoxDescr = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCode = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        DependentCodeLabel = New System.Windows.Forms.Label()
        DependentDescrLabel = New System.Windows.Forms.Label()
        Me.menuVandelay.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DependentCodeLabel
        '
        DependentCodeLabel.AutoSize = True
        DependentCodeLabel.Location = New System.Drawing.Point(14, 34)
        DependentCodeLabel.Name = "DependentCodeLabel"
        DependentCodeLabel.Size = New System.Drawing.Size(91, 13)
        DependentCodeLabel.TabIndex = 24
        DependentCodeLabel.Text = "Dependent Code:"
        '
        'DependentDescrLabel
        '
        DependentDescrLabel.AutoSize = True
        DependentDescrLabel.Location = New System.Drawing.Point(14, 80)
        DependentDescrLabel.Name = "DependentDescrLabel"
        DependentDescrLabel.Size = New System.Drawing.Size(94, 13)
        DependentDescrLabel.TabIndex = 26
        DependentDescrLabel.Text = "Dependent Descr:"
        '
        'menuVandelay
        '
        Me.menuVandelay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDepartments, Me.menuInsCo, Me.menuEnroll, Me.menuRates, Me.menuEmp})
        Me.menuVandelay.Location = New System.Drawing.Point(0, 0)
        Me.menuVandelay.Name = "menuVandelay"
        Me.menuVandelay.Size = New System.Drawing.Size(435, 24)
        Me.menuVandelay.TabIndex = 16
        '
        'menuDepartments
        '
        Me.menuDepartments.Name = "menuDepartments"
        Me.menuDepartments.Size = New System.Drawing.Size(87, 20)
        Me.menuDepartments.Text = "Departments"
        '
        'menuInsCo
        '
        Me.menuInsCo.Name = "menuInsCo"
        Me.menuInsCo.Size = New System.Drawing.Size(133, 20)
        Me.menuInsCo.Text = "Insurance Companies"
        '
        'menuEnroll
        '
        Me.menuEnroll.Name = "menuEnroll"
        Me.menuEnroll.Size = New System.Drawing.Size(82, 20)
        Me.menuEnroll.Text = "Enrollments"
        '
        'menuRates
        '
        Me.menuRates.Name = "menuRates"
        Me.menuRates.Size = New System.Drawing.Size(47, 20)
        Me.menuRates.Text = "Rates"
        '
        'menuEmp
        '
        Me.menuEmp.Name = "menuEmp"
        Me.menuEmp.Size = New System.Drawing.Size(76, 20)
        Me.menuEmp.Text = "Employees"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(123, 278)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 28)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtBoxCode
        '
        Me.txtBoxCode.Location = New System.Drawing.Point(17, 50)
        Me.txtBoxCode.MaxLength = 4
        Me.txtBoxCode.Name = "txtBoxCode"
        Me.txtBoxCode.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxCode.TabIndex = 25
        '
        'txtBoxDescr
        '
        Me.txtBoxDescr.Location = New System.Drawing.Point(17, 96)
        Me.txtBoxDescr.MaxLength = 255
        Me.txtBoxDescr.Multiline = True
        Me.txtBoxDescr.Name = "txtBoxDescr"
        Me.txtBoxDescr.Size = New System.Drawing.Size(377, 118)
        Me.txtBoxDescr.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboCode)
        Me.GroupBox1.Controls.Add(Me.txtBoxCode)
        Me.GroupBox1.Controls.Add(DependentCodeLabel)
        Me.GroupBox1.Controls.Add(Me.txtBoxDescr)
        Me.GroupBox1.Controls.Add(DependentDescrLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 220)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dependent Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Select a dependent code to edit"
        '
        'cboCode
        '
        Me.cboCode.FormattingEnabled = True
        Me.cboCode.Location = New System.Drawing.Point(273, 50)
        Me.cboCode.Name = "cboCode"
        Me.cboCode.Size = New System.Drawing.Size(121, 21)
        Me.cboCode.TabIndex = 28
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(33, 278)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 28)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(303, 278)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(84, 28)
        Me.btnClr.TabIndex = 22
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(213, 278)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 28)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmDependentCodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 356)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.menuVandelay)
        Me.Name = "frmDependentCodes"
        Me.Text = "Dependent Code Entry"
        Me.menuVandelay.ResumeLayout(False)
        Me.menuVandelay.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuVandelay As System.Windows.Forms.MenuStrip
    Friend WithEvents menuDepartments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInsCo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEnroll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxDescr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
