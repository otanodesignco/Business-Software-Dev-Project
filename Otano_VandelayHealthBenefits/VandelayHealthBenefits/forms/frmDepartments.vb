Imports VandelayHealthBenefits.VDObjects

Public Class frmDepartments

    Dim dept As New Department

    ' begin menu link functionality
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

    Private Sub menuDepartments_Click(sender As Object, e As EventArgs) Handles menuEmployees.Click
        frmEmpolyee.Show()
        Me.Close()
    End Sub
    ' end menu functionality

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDeptID.Text = String.Empty Or txtBoxDeptDescr.Text = String.Empty Then
            MsgBox("Please fill out the form")
        Else
            Dim c As Boolean = False
            dept.DeptID = txtDeptID.Text
            dept.DeptDescr = txtBoxDeptDescr.Text

            c = VDObjects.Department.Insert(dept)
            If c Then
                btnClr.PerformClick()
                MsgBox("Department saved successfully!")
                VDObjects.Department.PopulateDropDown(cbxDeptID)

            Else
                MsgBox("Ooops something went wrong!")
            End If
            
            

        End If

    End Sub



    Private Sub frmDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VDObjects.Department.PopulateDropDown(cbxDeptID)
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtBoxDeptDescr.Text = String.Empty
        txtDeptID.Text = String.Empty
        cbxDeptID.SelectedIndex = -1
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtDeptID.Text = String.Empty Then
            MsgBox("Please select a departmnet for the dropdown box")
        Else
            Dim c As Boolean = False
            dept.DeptID = txtDeptID.Text
            
            c = VDObjects.Department.Delete(dept)

            If c Then
                btnClr.PerformClick()
                VDObjects.Department.PopulateDropDown(cbxDeptID)
                MsgBox("Department deleted successfully!")
            Else
                MsgBox("Ooops something went wrong!")
            End If

        End If
    End Sub

    Private Sub cbxDeptID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDeptID.SelectedIndexChanged
        If cbxDeptID.SelectedIndex <> -1 Then
            dept.DeptID = cbxDeptID.SelectedItem
            VDObjects.Department.Read(dept)
            txtBoxDeptDescr.Text = dept.DeptDescr
            txtDeptID.Text = dept.DeptID
            ' enable delete button now that updates can be done
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
        End If
        
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim c As Boolean = False
        If txtDeptID.Text = String.Empty Or txtBoxDeptDescr.Text = String.Empty Then
            MsgBox("Please use the drop down to select a department")
        Else
            dept.DeptID = txtDeptID.Text
            dept.DeptDescr = txtBoxDeptDescr.Text
            If dept.DeptID = cbxDeptID.SelectedItem Then
                c = VDObjects.Department.Update(dept)
                If c Then
                    btnClr.PerformClick()
                    VDObjects.Department.PopulateDropDown(cbxDeptID)
                    MsgBox("Update happened!")
                Else
                    MsgBox("Umm...nothing happened!")
                End If
            Else
                c = VDObjects.Department.Insert(dept)
                If c Then
                    btnClr.PerformClick()
                    VDObjects.Department.PopulateDropDown(cbxDeptID)
                    MsgBox("Department saved")
                Else
                    MsgBox("Error system crash")
                End If
            End If
            
        End If

    End Sub
End Class