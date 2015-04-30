Imports VandelayHealthBenefits.VDObjects

Public Class frmDependentCodes

    Dim depend As New DependentCode

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

    Private Sub menuEmp_Click(sender As Object, e As EventArgs) Handles menuEmp.Click
        frmEmpolyee.Show()
        Me.Close()
    End Sub

    Private Sub frmDependentCodes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VDObjects.DependentCode.FillCombox(cboCode)
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub cboCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCode.SelectedIndexChanged
        If cboCode.SelectedIndex <> -1 Then
            depend.DependCode = cboCode.SelectedItem
            'MsgBox(cboCode.SelectedItem)
            VDObjects.DependentCode.Read(depend)
            txtBoxCode.Text = depend.DependCode
            txtBoxDescr.Text = depend.DependDescr
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtBoxCode.Text = String.Empty
        txtBoxDescr.Text = String.Empty
        cboCode.SelectedIndex = -1
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim c As Boolean = False
        ' either of the boxes is empty do nothing show error
        If txtBoxCode.Text = String.Empty Or txtBoxDescr.Text = String.Empty Then
            MsgBox("Please fill out the form")
        Else
            ' assign object values
            depend.DependCode = txtBoxCode.Text
            depend.DependDescr = txtBoxDescr.Text
            ' check if cbox is equal to txtbox then update else save
            If txtBoxCode.Text = cboCode.SelectedItem Then
                c = VDObjects.DependentCode.Update(depend)
                ' check if update happened and update cbox and show msg or err if not
                If c Then
                    MsgBox("Dependent Code Update happened")
                    VDObjects.DependentCode.FillCombox(cboCode)
                    btnClr.PerformClick()
                Else
                    MsgBox("Oops something went wrong nothing saved")
                End If
            Else
                c = VDObjects.DependentCode.Insert(depend)
                If c Then
                    MsgBox("Dependent Code Save happened")
                    btnClr.PerformClick()
                    VDObjects.DependentCode.FillCombox(cboCode)

                Else
                    MsgBox("Oops something went wrong nothing saved")
                End If
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim c As Boolean = False
        If txtBoxCode.Text = String.Empty Or txtBoxDescr.Text = String.Empty Then
            'error msg
            MsgBox("Please fill out the form")
        Else
            'process save
            depend.DependCode = txtBoxCode.Text
            depend.DependDescr = txtBoxDescr.Text
            c = VDObjects.DependentCode.Insert(depend)
            If c Then
                MsgBox("Dependent Code Saved")
                VDObjects.DependentCode.FillCombox(cboCode)
                btnClr.PerformClick()
            Else
                MsgBox("Oops error error")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim c As Boolean = True
        If cboCode.SelectedItem = txtBoxCode.Text Then
            'entry is actually from the list so we can delete it
            depend.DependCode = txtBoxCode.Text
            depend.DependDescr = txtBoxDescr.Text
            c = VDObjects.DependentCode.Delete(depend)
            If c Then
                MsgBox("Dependent Code Deleted")
                btnClr.PerformClick()
                VDObjects.DependentCode.FillCombox(cboCode)

            Else
                MsgBox("Something went wrong error")
            End If
        End If
    End Sub
End Class