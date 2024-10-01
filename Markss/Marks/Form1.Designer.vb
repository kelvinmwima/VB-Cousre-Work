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
        txtenterMarks = New TextBox()
        txtgrade = New TextBox()
        btnevalute = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(116, 26)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(439, 31)
        Label1.TabIndex = 0
        Label1.Text = "GRADIND SCALE CALCULATOR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(70, 110)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 21)
        Label2.TabIndex = 1
        Label2.Text = "Enter Marks"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(70, 159)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 21)
        Label3.TabIndex = 2
        Label3.Text = "Grade"
        ' 
        ' txtenterMarks
        ' 
        txtenterMarks.Location = New Point(208, 106)
        txtenterMarks.Margin = New Padding(2, 1, 2, 1)
        txtenterMarks.Name = "txtenterMarks"
        txtenterMarks.Size = New Size(246, 23)
        txtenterMarks.TabIndex = 3
        ' 
        ' txtgrade
        ' 
        txtgrade.Location = New Point(208, 158)
        txtgrade.Margin = New Padding(2, 1, 2, 1)
        txtgrade.Name = "txtgrade"
        txtgrade.Size = New Size(246, 23)
        txtgrade.TabIndex = 4
        ' 
        ' btnevalute
        ' 
        btnevalute.Font = New Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnevalute.ForeColor = Color.Teal
        btnevalute.Location = New Point(257, 207)
        btnevalute.Margin = New Padding(2, 1, 2, 1)
        btnevalute.Name = "btnevalute"
        btnevalute.Size = New Size(132, 38)
        btnevalute.TabIndex = 5
        btnevalute.Text = "Evalute"
        btnevalute.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Turquoise
        ClientSize = New Size(722, 351)
        Controls.Add(btnevalute)
        Controls.Add(txtgrade)
        Controls.Add(txtenterMarks)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2, 1, 2, 1)
        Name = "Form1"
        Text = "WABWIRE KELVIN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtenterMarks As TextBox
    Friend WithEvents txtgrade As TextBox
    Friend WithEvents btnevalute As Button

End Class
