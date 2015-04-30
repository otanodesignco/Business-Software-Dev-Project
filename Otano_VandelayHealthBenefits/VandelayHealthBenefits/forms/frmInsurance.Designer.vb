<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsurance
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
        Me.menuEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEnroll = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRates = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDptCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescr = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboxCode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.menuVandelay.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuVandelay
        '
        Me.menuVandelay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDepartments, Me.menuEmp, Me.menuEnroll, Me.menuRates, Me.menuDptCode})
        Me.menuVandelay.Location = New System.Drawing.Point(0, 0)
        Me.menuVandelay.Name = "menuVandelay"
        Me.menuVandelay.Size = New System.Drawing.Size(496, 24)
        Me.menuVandelay.TabIndex = 16
        '
        'menuDepartments
        '
        Me.menuDepartments.Name = "menuDepartments"
        Me.menuDepartments.Size = New System.Drawing.Size(87, 20)
        Me.menuDepartments.Text = "Departments"
        '
        'menuEmp
        '
        Me.menuEmp.Name = "menuEmp"
        Me.menuEmp.Size = New System.Drawing.Size(76, 20)
        Me.menuEmp.Text = "Employees"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Insurance Company Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Short Code"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(139, 87)
        Me.txtCode.MaxLength = 4
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(60, 20)
        Me.txtCode.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Company Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 87)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Company Description"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(15, 135)
        Me.txtDescr.MaxLength = 255
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(469, 96)
        Me.txtDescr.TabIndex = 23
        Me.txtDescr.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(166, 237)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Submit"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(247, 237)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cboxCode
        '
        Me.cboxCode.FormattingEnabled = True
        Me.cboxCode.Location = New System.Drawing.Point(362, 87)
        Me.cboxCode.Name = "cboxCode"
        Me.cboxCode.Size = New System.Drawing.Size(121, 21)
        Me.cboxCode.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Select a company to edit"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(85, 237)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(328, 237)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 25
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'frmInsurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 287)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboxCode)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menuVandelay)
        Me.Name = "frmInsurance"
        Me.Text = "Insurance Company Entry"
        Me.menuVandelay.ResumeLayout(False)
        Me.menuVandelay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuVandelay As System.Windows.Forms.MenuStrip
    Friend WithEvents menuDepartments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEnroll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDptCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cboxCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClr As System.Windows.Forms.Button
End Class
