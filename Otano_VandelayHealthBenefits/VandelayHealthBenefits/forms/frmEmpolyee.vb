Imports VandelayHealthBenefits.VDObjects

Public Class frmEmpolyee
    Dim emp As New Employee
    Private Sub menuDepartments_Click(sender As Object, e As EventArgs) Handles menuDepartments.Click
        frmDepartments.Show()
        Me.Close()
    End Sub

    Private Sub menuInsCo_Click(sender As Object, e As EventArgs) Handles menuInsCo.Click
        frmInsurance.Show()
        Me.Close()
    End Sub

    Private Sub menuEnroll_Click(sender As Object, e As EventArgs) Handles menuEnroll.Click
        frmEnrollments.Show()
        Me.Close()
    End Sub

    Private Sub menuRates_Click(sender As Object, e As EventArgs) Handles menuRates.Click
        frmRates.Show()
        Me.Close()
    End Sub

    Private Sub menuDptCode_Click(sender As Object, e As EventArgs) Handles menuDptCode.Click
        frmDependentCodes.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLname.Text = String.Empty
        txID.Text = String.Empty
        txtAddr.Text = String.Empty
        txtExt.Text = String.Empty
        txtCity.Text = String.Empty
        txtState.Text = String.Empty
        txtZip.Text = String.Empty
        txtFname.Text = String.Empty
        cboEmp.SelectedIndex = -1
        cBoxDept.SelectedIndex = -1
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim c As Boolean = False

        If txtLname.Text = String.Empty Or txID.Text = String.Empty Or txtAddr.Text = String.Empty Or _
            txtExt.Text = String.Empty Or txtCity.Text = String.Empty Or txtState.Text = String.Empty _
            Or txtZip.Text = String.Empty Or txtFname.Text = String.Empty Or cBoxDept.SelectedIndex < 0 Then
            MsgBox("Please fill in the form")
        Else
            ' submit
            emp.ID = txID.Text
            emp.Dept = cBoxDept.SelectedItem
            emp.Fname = VDObjects.FirstUCase.Convert(txtFname.Text)
            emp.Lname = VDObjects.FirstUCase.Convert(txtLname.Text)
            emp.Addr = txtAddr.Text
            emp.City = VDObjects.FirstUCase.Convert(txtCity.Text)
            emp.State = txtState.Text.ToUpper()
            emp.Zip = Convert.ToInt32(txtZip.Text)
            emp.Ext = Convert.ToInt32(txtExt.Text)
            c = VDObjects.Employee.Insert(emp)
            If c Then
                btnClear.PerformClick()
                VDObjects.Employee.FillList(cboEmp)
                MsgBox("Employee Saved")
            Else
                MsgBox("Error issue")
            End If
        End If
    End Sub

    Private Sub frmEmpolyee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VDObjects.Department.PopulateDropDown(cBoxDept)
        VDObjects.Employee.FillList(cboEmp)
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
    End Sub
    
    Private Sub cboEmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmp.SelectedIndexChanged
        Dim c As Boolean = False
        If cboEmp.SelectedIndex <> -1 Then
            emp.ID = cboEmp.SelectedItem
            c = VDObjects.Employee.Read(emp)
            If c Then
                txtLname.Text = emp.Lname
                txID.Text = emp.ID
                txtAddr.Text = emp.Addr
                txtExt.Text = emp.Ext
                txtCity.Text = emp.City
                txtState.Text = emp.State
                txtZip.Text = emp.Zip
                txtFname.Text = emp.Fname
                cBoxDept.SelectedItem = emp.Dept
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                btnSave.Enabled = False
            End If
        Else

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim c As Boolean = False
        If txtLname.Text = String.Empty Or txID.Text = String.Empty Or txtAddr.Text = String.Empty Or _
            txtExt.Text = String.Empty Or txtCity.Text = String.Empty Or txtState.Text = String.Empty _
            Or txtZip.Text = String.Empty Or txtFname.Text = String.Empty Or cBoxDept.SelectedIndex < 0 Then
            MsgBox("Please fill out the form")
        Else
            ' check if you need an update or save
            emp.ID = txID.Text
            emp.Dept = cBoxDept.SelectedItem
            emp.Fname = VDObjects.FirstUCase.Convert(txtFname.Text)
            emp.Lname = VDObjects.FirstUCase.Convert(txtLname.Text)
            emp.Addr = txtAddr.Text
            emp.City = VDObjects.FirstUCase.Convert(txtCity.Text)
            emp.State = txtState.Text.ToUpper()
            emp.Zip = Convert.ToInt32(txtZip.Text)
            emp.Ext = Convert.ToInt32(txtExt.Text)
            If txID.Text = cboEmp.SelectedItem Then
                c = VDObjects.Employee.Update(emp)
                If c Then
                    btnClear.PerformClick()
                    VDObjects.Employee.FillList(cboEmp)
                    MsgBox("Employee info updated")
                Else
                    MsgBox("Error does not compute")
                End If
            Else
                c = VDObjects.Employee.Insert(emp)
                If c Then
                    btnClear.PerformClick()
                    VDObjects.Employee.FillList(cboEmp)
                    MsgBox("Employee saved")
                Else
                    MsgBox("Error does not compute")
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim c As Boolean = False
        If txID.Text = cboEmp.SelectedItem Then
            ' we just need the id to perform the delete query
            emp.ID = txID.Text
            c = VDObjects.Employee.Delete(emp)
            If c Then
                btnClear.PerformClick()
                VDObjects.Employee.FillList(cboEmp)
                MsgBox("Employee deleted")
            End If
        Else
            MsgBox("Please a current employee from the employee dropdown list")
        End If
    End Sub

    ' subs that make txtbox numbers only
    Private Sub number_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExt.KeyPress, txtZip.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class