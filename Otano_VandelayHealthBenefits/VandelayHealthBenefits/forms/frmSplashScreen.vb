Public Class frmSplashScreen

    Private Sub menuDepartments_Click(sender As Object, e As EventArgs) Handles menuDepartments.Click

        Dim DepartmentForm As New frmDepartments()
        DepartmentForm.Show()
        DepartmentForm = Nothing
        Me.Close()

    End Sub

    Private Sub menuInsCo_Click(sender As Object, e As EventArgs) Handles menuInsCo.Click

        Dim InsuranceForm As New frmInsurance()
        InsuranceForm.Show()
        InsuranceForm = Nothing
        Me.Close()

    End Sub

    Private Sub menuEnroll_Click(sender As Object, e As EventArgs) Handles menuEnroll.Click

        Dim EnrollForm As New frmEnrollments()
        EnrollForm.Show()
        EnrollForm = Nothing
        Me.Close()

    End Sub

    Private Sub menuEmp_Click(sender As Object, e As EventArgs) Handles menuEmp.Click

        Dim EmployeeForm As New frmEmpolyee()
        EmployeeForm.Show()
        EmployeeForm = Nothing
        Me.Close()

    End Sub

    Private Sub menuDptCode_Click(sender As Object, e As EventArgs) Handles menuDptCode.Click

        Dim DeptForm As New frmDependentCodes()
        DeptForm.Show()
        DeptForm = Nothing
        Me.Close()

    End Sub

    Private Sub menuRates_Click(sender As Object, e As EventArgs) Handles menuRates.Click

        Dim RateForm As New frmRates()
        RateForm.Show()
        RateForm = Nothing
        Me.Close()

    End Sub
End Class