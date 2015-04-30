<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpolyee
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
        Me.menuVandelay = New System.Windows.Forms.MenuStrip()
        Me.menuDepartments = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInsCo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEnroll = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRates = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDptCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TblEmployeesTableAdapter = New VandelayHealthBenefits.VandelayDataSetTableAdapters.tblEmployeesTableAdapter()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.cBoxDept = New System.Windows.Forms.ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txID = New System.Windows.Forms.TextBox()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.cboEmp = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.menuVandelay.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuVandelay
        '
        Me.menuVandelay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDepartments, Me.menuInsCo, Me.menuEnroll, Me.menuRates, Me.menuDptCode})
        Me.menuVandelay.Location = New System.Drawing.Point(0, 0)
        Me.menuVandelay.Name = "menuVandelay"
        Me.menuVandelay.Size = New System.Drawing.Size(479, 24)
        Me.menuVandelay.TabIndex = 15
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
        'menuDptCode
        '
        Me.menuDptCode.Name = "menuDptCode"
        Me.menuDptCode.Size = New System.Drawing.Size(113, 20)
        Me.menuDptCode.Text = "Dependent Codes"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(163, 333)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Location = New System.Drawing.Point(244, 333)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'TblEmployeesTableAdapter
        '
        Me.TblEmployeesTableAdapter.ClearBeforeFill = True
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(13, 167)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(57, 13)
        Me.lblFname.TabIndex = 0
        Me.lblFname.Text = "First Name"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(13, 183)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(100, 20)
        Me.txtFname.TabIndex = 1
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(137, 167)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(58, 13)
        Me.lblLname.TabIndex = 2
        Me.lblLname.Text = "Last Name"
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(140, 183)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(100, 20)
        Me.txtLname.TabIndex = 3
        '
        'cBoxDept
        '
        Me.cBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxDept.FormattingEnabled = True
        Me.cBoxDept.Location = New System.Drawing.Point(116, 98)
        Me.cBoxDept.Name = "cBoxDept"
        Me.cBoxDept.Size = New System.Drawing.Size(106, 21)
        Me.cBoxDept.TabIndex = 4
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(116, 81)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 5
        Me.lblDepartment.Text = "Department"
        '
        'txID
        '
        Me.txID.Location = New System.Drawing.Point(13, 98)
        Me.txID.MaxLength = 4
        Me.txID.Name = "txID"
        Me.txID.Size = New System.Drawing.Size(81, 20)
        Me.txID.TabIndex = 6
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(10, 81)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(67, 13)
        Me.lblEmpID.TabIndex = 7
        Me.lblEmpID.Text = "Employee ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Employee Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Street Address"
        '
        'txtAddr
        '
        Me.txtAddr.Location = New System.Drawing.Point(12, 233)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(176, 20)
        Me.txtAddr.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Employee Company Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(262, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Ext #"
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(265, 183)
        Me.txtExt.MaxLength = 3
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(54, 20)
        Me.txtExt.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(12, 286)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(137, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "State"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(140, 286)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(38, 20)
        Me.txtState.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(205, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Zip"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(208, 286)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 25
        '
        'cboEmp
        '
        Me.cboEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmp.FormattingEnabled = True
        Me.cboEmp.Location = New System.Drawing.Point(324, 97)
        Me.cboEmp.Name = "cboEmp"
        Me.cboEmp.Size = New System.Drawing.Size(121, 21)
        Me.cboEmp.TabIndex = 28
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(325, 333)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(83, 333)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Select an employee to update"
        '
        'frmEmpolyee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 416)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboEmp)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.txID)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.cBoxDept)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.menuVandelay)
        Me.MainMenuStrip = Me.menuVandelay
        Me.Name = "frmEmpolyee"
        Me.Text = "Employee Entry"
        Me.menuVandelay.ResumeLayout(False)
        Me.menuVandelay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuVandelay As System.Windows.Forms.MenuStrip
    Friend WithEvents menuDepartments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInsCo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEnroll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDptCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents TblEmployeesTableAdapter As VandelayHealthBenefits.VandelayDataSetTableAdapters.tblEmployeesTableAdapter
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents cBoxDept As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents txID As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtExt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents cboEmp As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
