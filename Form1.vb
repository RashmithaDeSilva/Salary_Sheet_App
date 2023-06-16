Public Class Form1

    Dim grossSalary As Integer = 0
    Dim tax As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Basic salary textbox
    Private Sub txtBasicSalary_TextChanged(sender As Object, e As EventArgs) Handles txtBasicSalary.TextChanged
        grossSalary = Val(txtBasicSalary.Text) + Val(txtAllowence.Text)
        txtGrossSalary.Text = grossSalary

    End Sub

    ' Allowence textbox
    Private Sub txtAllowence_TextChanged(sender As Object, e As EventArgs) Handles txtAllowence.TextChanged
        grossSalary = Val(txtBasicSalary.Text) + Val(txtAllowence.Text)
        txtGrossSalary.Text = grossSalary
    End Sub

    ' Gross salary textbox
    Private Sub txtGrossSalary_TextChanged(sender As Object, e As EventArgs) Handles txtGrossSalary.TextChanged

    End Sub

    ' Tax textbox
    Private Sub txtTax_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged

    End Sub

    ' Net salary textbox
    Private Sub txtNetSalary_TextChanged(sender As Object, e As EventArgs) Handles txtNetSalary.TextChanged

    End Sub

    ' Tax calulatin button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Between 65000 and 100000 the tax rate is 4%
        If 65000 < grossSalary And grossSalary <= 100000 Then
            tax = (grossSalary / 100) * 4
            txtTax.Text = tax

            ' Between 100000 and 150000 the tax rate is 8%
        ElseIf 100000 < grossSalary And grossSalary <= 150000 Then
            tax = (grossSalary / 100) * 8
            txtTax.Text = tax

            ' More than 150000 tax rate is 12%
        ElseIf grossSalary > 150000 Then
            tax = (grossSalary / 100) * 12
            txtTax.Text = tax

            ' Lesthan 65000 no tax
        Else
            tax = 0
            txtTax.Text = tax

        End If
    End Sub

    ' Net salary calulatin button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtNetSalary.Text = grossSalary - tax
    End Sub

    ' Clear button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtBasicSalary.Clear()
        txtAllowence.Clear()
        txtGrossSalary.Clear()
        txtTax.Clear()
        txtNetSalary.Clear()
    End Sub

    ' Exit button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

End Class
