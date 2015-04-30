Imports VandelayHealthBenefits.VDObjects

Public Class frmEnrollments
    Dim enroll As New Enrollment

    Private Sub menuDepartments_Click(sender As Object, e As EventArgs) Handles menuDepartments.Click

        frmDepartments.Show()
        Me.Close()

    End Sub

    Private Sub menuInsCo_Click(sender As Object, e As EventArgs) Handles menuInsCo.Click

        frmInsurance.Show()
        Me.Close()

    End Sub

    Private Sub menuEmp_Click(sender As Object, e As EventArgs) Handles menuEmp.Click

        frmEmpolyee.Show()
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


    Private Sub frmEnrollments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VDObjects.DependentCode.FillCombox(cboDep)
        VDObjects.InsCompany.FillList(cboIns)
        VDObjects.Employee.FillList(cboEmp)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim c As Boolean = False
        If cboDep.SelectedIndex >= 0 Or cboEmp.SelectedIndex >= 0 Or cboIns.SelectedIndex >= 0 Or Not txtDate.Text = String.Empty Then
            enroll.DepCode = cboDep.SelectedItem
            enroll.EmpID = cboEmp.SelectedItem
            enroll.InsCode = cboIns.SelectedItem
            Date.TryParse(txtDate.Text, enroll.EffctDate)

            c = VDObjects.Enrollment.Insert(enroll)
            If c Then
                btnClr.PerformClick()
                MsgBox("Employee enrolled in health insurance")
            Else
                MsgBox("Ummm...you broke it")
            End If
        End If
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        cboDep.SelectedIndex = -1
        cboEmp.SelectedIndex = -1
        cboIns.SelectedIndex = -1
        txtDate.Text = String.Empty
    End Sub
End Class