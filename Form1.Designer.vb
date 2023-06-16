<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtBasicSalary = New TextBox()
        txtAllowence = New TextBox()
        txtGrossSalary = New TextBox()
        txtTax = New TextBox()
        txtNetSalary = New TextBox()
        Button4 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(43, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 54)
        Label1.TabIndex = 0
        Label1.Text = "Salary Sheet"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(43, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 25)
        Label2.TabIndex = 1
        Label2.Text = "Basic salary"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(43, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 25)
        Label3.TabIndex = 2
        Label3.Text = "Allowence"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(43, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 25)
        Label4.TabIndex = 3
        Label4.Text = "Gross salary"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(43, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 25)
        Label5.TabIndex = 4
        Label5.Text = "Tax"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(43, 279)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 25)
        Label6.TabIndex = 5
        Label6.Text = "Net salary"
        ' 
        ' txtBasicSalary
        ' 
        txtBasicSalary.Location = New Point(241, 118)
        txtBasicSalary.Name = "txtBasicSalary"
        txtBasicSalary.PlaceholderText = "00.00"
        txtBasicSalary.Size = New Size(100, 23)
        txtBasicSalary.TabIndex = 6
        txtBasicSalary.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtAllowence
        ' 
        txtAllowence.Location = New Point(241, 158)
        txtAllowence.Name = "txtAllowence"
        txtAllowence.PlaceholderText = "00.00"
        txtAllowence.Size = New Size(100, 23)
        txtAllowence.TabIndex = 7
        txtAllowence.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtGrossSalary
        ' 
        txtGrossSalary.Location = New Point(241, 200)
        txtGrossSalary.Name = "txtGrossSalary"
        txtGrossSalary.PlaceholderText = "00.00"
        txtGrossSalary.ReadOnly = True
        txtGrossSalary.Size = New Size(100, 23)
        txtGrossSalary.TabIndex = 8
        txtGrossSalary.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTax
        ' 
        txtTax.Location = New Point(241, 240)
        txtTax.Name = "txtTax"
        txtTax.PlaceholderText = "00.00"
        txtTax.ReadOnly = True
        txtTax.Size = New Size(100, 23)
        txtTax.TabIndex = 9
        txtTax.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtNetSalary
        ' 
        txtNetSalary.Location = New Point(241, 279)
        txtNetSalary.Name = "txtNetSalary"
        txtNetSalary.PlaceholderText = "00.00"
        txtNetSalary.ReadOnly = True
        txtNetSalary.Size = New Size(100, 23)
        txtNetSalary.TabIndex = 10
        txtNetSalary.TextAlign = HorizontalAlignment.Right
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(384, 280)
        Button4.Name = "Button4"
        Button4.Size = New Size(103, 26)
        Button4.TabIndex = 14
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(384, 114)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 26)
        Button1.TabIndex = 15
        Button1.Text = "Calculate tax"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(384, 156)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 26)
        Button2.TabIndex = 16
        Button2.Text = "Net salary"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(384, 236)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 26)
        Button3.TabIndex = 17
        Button3.Text = "Clear"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(517, 339)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(txtNetSalary)
        Controls.Add(txtTax)
        Controls.Add(txtGrossSalary)
        Controls.Add(txtAllowence)
        Controls.Add(txtBasicSalary)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "Form1"
        Text = "Salary sheet"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents txtAllowence As TextBox
    Friend WithEvents txtGrossSalary As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtNetSalary As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
