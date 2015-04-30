<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRates
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
        Me.menuEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDptCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboxIns = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxDep = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.menuVandelay.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuVandelay
        '
        Me.menuVandelay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDepartments, Me.menuInsCo, Me.menuEnroll, Me.menuEmp, Me.menuDptCode})
        Me.menuVandelay.Location = New System.Drawing.Point(0, 0)
        Me.menuVandelay.Name = "menuVandelay"
        Me.menuVandelay.Size = New System.Drawing.Size(533, 24)
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
        'menuEmp
        '
        Me.menuEmp.Name = "menuEmp"
        Me.menuEmp.Size = New System.Drawing.Size(76, 20)
        Me.menuEmp.Text = "Employees"
        '
        'menuDptCode
        '
        Me.menuDptCode.Name = "menuDptCode"
        Me.menuDptCode.Size = New System.Drawing.Size(113, 20)
        Me.menuDptCode.Text = "Dependent Codes"
        '
        'cboxIns
        '
        Me.cboxIns.FormattingEnabled = True
        Me.cboxIns.Location = New System.Drawing.Point(16, 86)
        Me.cboxIns.Name = "cboxIns"
        Me.cboxIns.Size = New System.Drawing.Size(107, 21)
        Me.cboxIns.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Insurance Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Dependent Code"
        '
        'cboxDep
        '
        Me.cboxDep.FormattingEnabled = True
        Me.cboxDep.Location = New System.Drawing.Point(132, 86)
        Me.cboxDep.Name = "cboxDep"
        Me.cboxDep.Size = New System.Drawing.Size(108, 21)
        Me.cboxDep.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Rate"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(183, 144)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Insurance Rates"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(264, 86)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 26
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(264, 144)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 24
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'frmRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 179)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboxDep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxIns)
        Me.Controls.Add(Me.menuVandelay)
        Me.Name = "frmRates"
        Me.Text = "Rate Entry"
        Me.menuVandelay.ResumeLayout(False)
        Me.menuVandelay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuVandelay As System.Windows.Forms.MenuStrip
    Friend WithEvents menuDepartments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInsCo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEnroll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDptCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboxIns As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboxDep As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents btnClr As System.Windows.Forms.Button
End Class
