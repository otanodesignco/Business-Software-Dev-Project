<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartments
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
        Me.components = New System.ComponentModel.Container()
        Dim DepartmentIDLabel As System.Windows.Forms.Label
        Dim DeptDescrLabel As System.Windows.Forms.Label
        Me.menuVandelay = New System.Windows.Forms.MenuStrip()
        Me.menuEmployees = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInsCo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEnroll = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRates = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDptCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.txtDeptID = New System.Windows.Forms.TextBox()
        Me.cbxDeptID = New System.Windows.Forms.ComboBox()
        Me.txtBoxDeptDescr = New System.Windows.Forms.TextBox()
        Me.TblDepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VandelayDataSet = New VandelayHealthBenefits.VandelayDataSet()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TblDepartmentsTableAdapter = New VandelayHealthBenefits.VandelayDataSetTableAdapters.tblDepartmentsTableAdapter()
        Me.TableAdapterManager = New VandelayHealthBenefits.VandelayDataSetTableAdapters.TableAdapterManager()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        DepartmentIDLabel = New System.Windows.Forms.Label()
        DeptDescrLabel = New System.Windows.Forms.Label()
        Me.menuVandelay.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblDepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VandelayDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentIDLabel
        '
        DepartmentIDLabel.AutoSize = True
        DepartmentIDLabel.Location = New System.Drawing.Point(4, 38)
        DepartmentIDLabel.Name = "DepartmentIDLabel"
        DepartmentIDLabel.Size = New System.Drawing.Size(79, 13)
        DepartmentIDLabel.TabIndex = 0
        DepartmentIDLabel.Text = "Department ID:"
        '
        'DeptDescrLabel
        '
        DeptDescrLabel.AutoSize = True
        DeptDescrLabel.Location = New System.Drawing.Point(4, 98)
        DeptDescrLabel.Name = "DeptDescrLabel"
        DeptDescrLabel.Size = New System.Drawing.Size(64, 13)
        DeptDescrLabel.TabIndex = 2
        DeptDescrLabel.Text = "Dept Descr:"
        '
        'menuVandelay
        '
        Me.menuVandelay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEmployees, Me.menuInsCo, Me.menuEnroll, Me.menuRates, Me.menuDptCode})
        Me.menuVandelay.Location = New System.Drawing.Point(0, 0)
        Me.menuVandelay.Name = "menuVandelay"
        Me.menuVandelay.Size = New System.Drawing.Size(471, 24)
        Me.menuVandelay.TabIndex = 16
        '
        'menuEmployees
        '
        Me.menuEmployees.Name = "menuEmployees"
        Me.menuEmployees.Size = New System.Drawing.Size(76, 20)
        Me.menuEmployees.Text = "Employees"
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
        'menuDptCode
        '
        Me.menuDptCode.Name = "menuDptCode"
        Me.menuDptCode.Size = New System.Drawing.Size(113, 20)
        Me.menuDptCode.Text = "Dependent Codes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblUpdate)
        Me.GroupBox1.Controls.Add(Me.txtDeptID)
        Me.GroupBox1.Controls.Add(Me.cbxDeptID)
        Me.GroupBox1.Controls.Add(DepartmentIDLabel)
        Me.GroupBox1.Controls.Add(DeptDescrLabel)
        Me.GroupBox1.Controls.Add(Me.txtBoxDeptDescr)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 254)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Department"
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Location = New System.Drawing.Point(285, 38)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(150, 13)
        Me.lblUpdate.TabIndex = 6
        Me.lblUpdate.Text = "Select a department to update"
        '
        'txtDeptID
        '
        Me.txtDeptID.Location = New System.Drawing.Point(8, 53)
        Me.txtDeptID.MaxLength = 4
        Me.txtDeptID.Name = "txtDeptID"
        Me.txtDeptID.Size = New System.Drawing.Size(115, 20)
        Me.txtDeptID.TabIndex = 5
        '
        'cbxDeptID
        '
        Me.cbxDeptID.FormattingEnabled = True
        Me.cbxDeptID.Location = New System.Drawing.Point(314, 53)
        Me.cbxDeptID.Name = "cbxDeptID"
        Me.cbxDeptID.Size = New System.Drawing.Size(121, 21)
        Me.cbxDeptID.TabIndex = 4
        '
        'txtBoxDeptDescr
        '
        Me.txtBoxDeptDescr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDepartmentsBindingSource, "DeptDescr", True))
        Me.txtBoxDeptDescr.Location = New System.Drawing.Point(8, 114)
        Me.txtBoxDeptDescr.MaxLength = 255
        Me.txtBoxDeptDescr.Multiline = True
        Me.txtBoxDeptDescr.Name = "txtBoxDeptDescr"
        Me.txtBoxDeptDescr.Size = New System.Drawing.Size(438, 129)
        Me.txtBoxDeptDescr.TabIndex = 3
        '
        'TblDepartmentsBindingSource
        '
        Me.TblDepartmentsBindingSource.DataMember = "tblDepartments"
        Me.TblDepartmentsBindingSource.DataSource = Me.VandelayDataSet
        '
        'VandelayDataSet
        '
        Me.VandelayDataSet.DataSetName = "VandelayDataSet"
        Me.VandelayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(159, 319)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TblDepartmentsTableAdapter
        '
        Me.TblDepartmentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Me.TblDepartmentsTableAdapter
        Me.TableAdapterManager.tblDependentCodesTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeesTableAdapter = Nothing
        Me.TableAdapterManager.tblEnrollmentsTableAdapter = Nothing
        Me.TableAdapterManager.tblInsuranceCosTableAdapter = Nothing
        Me.TableAdapterManager.tblRatesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = VandelayHealthBenefits.VandelayDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(321, 319)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 25
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(240, 319)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(78, 319)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 363)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.menuVandelay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDepartments"
        Me.Text = "Department Entry"
        Me.menuVandelay.ResumeLayout(False)
        Me.menuVandelay.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblDepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VandelayDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuVandelay As System.Windows.Forms.MenuStrip
    Friend WithEvents menuEmployees As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInsCo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEnroll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDptCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents VandelayDataSet As VandelayHealthBenefits.VandelayDataSet
    Friend WithEvents TblDepartmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDepartmentsTableAdapter As VandelayHealthBenefits.VandelayDataSetTableAdapters.tblDepartmentsTableAdapter
    Friend WithEvents TableAdapterManager As VandelayHealthBenefits.VandelayDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtBoxDeptDescr As System.Windows.Forms.TextBox
    Friend WithEvents cbxDeptID As System.Windows.Forms.ComboBox
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblUpdate As System.Windows.Forms.Label
    Friend WithEvents txtDeptID As System.Windows.Forms.TextBox
End Class
