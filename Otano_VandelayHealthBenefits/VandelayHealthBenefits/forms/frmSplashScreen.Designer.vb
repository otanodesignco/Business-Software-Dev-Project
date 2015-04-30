<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.menuVandelay = New System.Windows.Forms.MenuStrip()
        Me.menuDepartments = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInsCo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEnroll = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDptCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRates = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuVandelay.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuVandelay
        '
        Me.menuVandelay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDepartments, Me.menuInsCo, Me.menuEnroll, Me.menuEmp, Me.menuDptCode, Me.menuRates})
        Me.menuVandelay.Location = New System.Drawing.Point(0, 0)
        Me.menuVandelay.Name = "menuVandelay"
        Me.menuVandelay.Size = New System.Drawing.Size(594, 24)
        Me.menuVandelay.TabIndex = 17
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
        'menuRates
        '
        Me.menuRates.Name = "menuRates"
        Me.menuRates.Size = New System.Drawing.Size(47, 20)
        Me.menuRates.Text = "Rates"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(135, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 332)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.menuVandelay)
        Me.Name = "frmSplashScreen"
        Me.Text = "Vandelay Health Benefits"
        Me.menuVandelay.ResumeLayout(False)
        Me.menuVandelay.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuVandelay As System.Windows.Forms.MenuStrip
    Friend WithEvents menuDepartments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInsCo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEnroll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDptCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
