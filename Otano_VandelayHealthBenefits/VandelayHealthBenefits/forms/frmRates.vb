Imports VandelayHealthBenefits.VDObjects

Public Class frmRates

    Dim r As New Rate

    Private Sub menuDepartments_Click(sender As Object, e As EventArgs) Handles menuDepartments.Click

        Dim DeptForm As New frmDepartments()
        DeptForm.Show()
        DeptForm = Nothing
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

    Private Sub menuEmployees_Click(sender As Object, e As EventArgs) Handles menuEmp.Click
        Dim EmpForm As New frmEmpolyee()
        EmpForm.Show()
        EmpForm = Nothing
        Me.Close()
    End Sub

    Private Sub menuDptCode_Click(sender As Object, e As EventArgs) Handles menuDptCode.Click
        Dim DepCodeForm As New frmDependentCodes()
        DepCodeForm.Show()
        DepCodeForm = Nothing
        Me.Close()
    End Sub

    Private Sub frmRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VDObjects.DependentCode.FillCombox(cboxDep)
        VDObjects.InsCompany.FillList(cboxIns)

    End Sub
    Private Sub number_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim c As Boolean = False
        If cboxDep.SelectedIndex >= 0 And cboxIns.SelectedIndex >= 0 And Not txtRate.Text = String.Empty Then
            ' we got data now lets try to save it!
            r.DepCode = cboxDep.SelectedItem
            r.insCode = cboxIns.SelectedItem
            ' because we're looking for a decimal we need to try to type cast the string if not error
            If Decimal.TryParse(txtRate.Text, r.Rates) Then
                ' all set add it to the db
                c = VDObjects.Rate.Insert(r)
                If c Then
                    btnClr.PerformClick()
                    MsgBox("Rate saved")
                Else
                    MsgBox("Something went wrong")
                End If
            Else
                ' show msg not a dollar amount
                MsgBox("The rate you entered is not a dollar amount, please use this format 00.00")
            End If
        End If

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        cboxDep.SelectedIndex = -1
        cboxIns.SelectedIndex = -1
        txtRate.Text = String.Empty
    End Sub
End Class