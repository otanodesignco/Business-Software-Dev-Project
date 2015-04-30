Imports VandelayHealthBenefits.VDObjects

Public Class frmInsurance

    Dim ins As New InsCompany

    Private Sub menuDepartments_Click(sender As Object, e As EventArgs) Handles menuDepartments.Click
        frmDepartments.Show()
        Me.Close()
    End Sub

    Private Sub menuEmp_Click(sender As Object, e As EventArgs) Handles menuEmp.Click
        frmEmpolyee.Show()
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

    Private Sub frmInsurance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VDObjects.InsCompany.FillList(cboxCode)
        btnDelete.Enabled = False
        btnUpdate.Enabled = False

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtCode.Text = String.Empty
        txtDescr.Text = String.Empty
        txtName.Text = String.Empty
        cboxCode.SelectedIndex = -1
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim c As Boolean = False
        If txtCode.Text = String.Empty Or txtDescr.Text = String.Empty Or txtName.Text = String.Empty Then
            MsgBox("Please select an insurance company to delete")
        Else
            ins.Code = txtCode.Text
            ins.Descr = txtDescr.Text
            ins.Name = txtName.Text
            c = VDObjects.InsCompany.Delete(ins)
            If c Then
                MsgBox("Insurance company info deleted")
                btnClr.PerformClick()
                VDObjects.InsCompany.FillList(cboxCode)
            Else
                MsgBox("Danger...dander error.....error")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim c As Boolean = False
        If txtCode.Text = String.Empty Or txtDescr.Text = String.Empty Or txtName.Text = String.Empty Then
            MsgBox("Please fill in the form")
        Else
            ins.Code = txtCode.Text
            ins.Descr = txtDescr.Text
            ins.Name = txtName.Text
            c = VDObjects.InsCompany.Insert(ins)
            If c Then
                MsgBox("Insurance Company Saved")
                btnClr.PerformClick()
                VDObjects.InsCompany.FillList(cboxCode)
            Else
                MsgBox("Oops you you have an issue")
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim c As Boolean = False
        If txtCode.Text = String.Empty Or txtDescr.Text = String.Empty Or txtName.Text = String.Empty Then
            MsgBox("Please fill out the form")
        Else
            ' none of the input is empty fill data object with data
            ins.Code = txtCode.Text
            ins.Descr = txtDescr.Text
            ins.Name = txtName.Text
            ' check if it's an update or a save
            If cboxCode.SelectedItem = txtCode.Text Then
                ' do update
                c = VDObjects.InsCompany.Update(ins)
                'check if we got an update or not
                If c Then
                    MsgBox("Insurance Company Updated")
                    btnClr.PerformClick()
                    VDObjects.InsCompany.FillList(cboxCode)
                Else
                    'error
                    MsgBox("Error Errorrrrr")
                End If
            Else
                ' do a save
                c = VDObjects.InsCompany.Insert(ins)
                If c Then
                    ' save ok
                    MsgBox("New Insurance Company info added")
                    btnClr.PerformClick()
                    VDObjects.InsCompany.FillList(cboxCode)
                Else
                    ' error
                    MsgBox("Errorrr Errooorrrr")
                End If
            End If
        End If
    End Sub

    Private Sub cboxCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxCode.SelectedIndexChanged
        Dim c As Boolean = False
        If cboxCode.SelectedIndex <> -1 Then
            ins.Code = cboxCode.SelectedItem
            c = VDObjects.InsCompany.Read(ins)
            If c Then
                txtCode.Text = ins.Code
                txtDescr.Text = ins.Descr
                txtName.Text = ins.Name
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
            End If
        End If
    End Sub
End Class