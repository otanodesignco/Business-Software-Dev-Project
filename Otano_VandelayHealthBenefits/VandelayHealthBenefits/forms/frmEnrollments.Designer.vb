<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnrollments
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
        Me.menuEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRates = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDptCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEmp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.cboIns = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDep = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.menuVandelay.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuVandelay
        '
        Me.menuVandelay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDepartments, Me.menuInsCo, Me.menuEmp, Me.menuRates, Me.menuDptCode})
        Me.menuVandelay.Location = New System.Drawing.Point(0, 0)
        Me.menuVandelay.Name = "menuVandelay"
        Me.menuVandelay.Size = New System.Drawing.Size(488, 24)
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
        'menuEmp
        '
        Me.menuEmp.Name = "menuEmp"
        Me.menuEmp.Size = New System.Drawing.Size(76, 20)
        Me.menuEmp.Text = "Employees"
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
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(378, 113)
        Me.txtDate.Mask = "00/00/0000"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(66, 20)
        Me.txtDate.TabIndex = 19
        Me.txtDate.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Employee ID"
        '
        'cboEmp
        '
        Me.cboEmp.FormattingEnabled = True
        Me.cboEmp.Location = New System.Drawing.Point(26, 113)
        Me.cboEmp.Name = "cboEmp"
        Me.cboEmp.Size = New System.Drawing.Size(100, 21)
        Me.cboEmp.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Effective Date"
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(249, 184)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 32
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'cboIns
        '
        Me.cboIns.FormattingEnabled = True
        Me.cboIns.Location = New System.Drawing.Point(145, 113)
        Me.cboIns.Name = "cboIns"
        Me.cboIns.Size = New System.Drawing.Size(93, 21)
        Me.cboIns.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Insurance Company"
        '
        'cboDep
        '
        Me.cboDep.FormattingEnabled = True
        Me.cboDep.Location = New System.Drawing.Point(262, 113)
        Me.cboDep.Name = "cboDep"
        Me.cboDep.Size = New System.Drawing.Size(88, 21)
        Me.cboDep.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Dependent Code"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(168, 184)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmEnrollments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 229)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboIns)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboEmp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.menuVandelay)
        Me.Name = "frmEnrollments"
        Me.Text = "Insurance Enrollment"
        Me.menuVandelay.ResumeLayout(False)
        Me.menuVandelay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuVandelay As System.Windows.Forms.MenuStrip
    Friend WithEvents menuDepartments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInsCo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDptCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents cboIns As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDep As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
