<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatrixCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtmatrix_a_x = New System.Windows.Forms.TextBox()
        Me.txtmatrix_a_y = New System.Windows.Forms.TextBox()
        Me.txtmatrix_b_x = New System.Windows.Forms.TextBox()
        Me.txtmatrix_b_y = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtmatrix_a_x
        '
        Me.txtmatrix_a_x.Location = New System.Drawing.Point(28, 24)
        Me.txtmatrix_a_x.Name = "txtmatrix_a_x"
        Me.txtmatrix_a_x.Size = New System.Drawing.Size(60, 20)
        Me.txtmatrix_a_x.TabIndex = 0
        '
        'txtmatrix_a_y
        '
        Me.txtmatrix_a_y.Location = New System.Drawing.Point(132, 24)
        Me.txtmatrix_a_y.Name = "txtmatrix_a_y"
        Me.txtmatrix_a_y.Size = New System.Drawing.Size(60, 20)
        Me.txtmatrix_a_y.TabIndex = 1
        '
        'txtmatrix_b_x
        '
        Me.txtmatrix_b_x.Location = New System.Drawing.Point(36, 20)
        Me.txtmatrix_b_x.Name = "txtmatrix_b_x"
        Me.txtmatrix_b_x.Size = New System.Drawing.Size(60, 20)
        Me.txtmatrix_b_x.TabIndex = 2
        '
        'txtmatrix_b_y
        '
        Me.txtmatrix_b_y.Location = New System.Drawing.Point(147, 20)
        Me.txtmatrix_b_y.Name = "txtmatrix_b_y"
        Me.txtmatrix_b_y.Size = New System.Drawing.Size(60, 20)
        Me.txtmatrix_b_y.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "X"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(18, 80)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtmatrix_a_x)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtmatrix_a_y)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(230, 60)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Matrix A"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtmatrix_b_y)
        Me.GroupBox4.Controls.Add(Me.txtmatrix_b_x)
        Me.GroupBox4.Location = New System.Drawing.Point(289, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(230, 60)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Matrix B"
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(125, 80)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(116, 23)
        Me.btnSubtract.TabIndex = 13
        Me.btnSubtract.Text = "SUBTRACT"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(259, 80)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(117, 23)
        Me.btnMultiply.TabIndex = 14
        Me.btnMultiply.Text = "MULTIPLY"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(400, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "INVERSE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnMultiply)
        Me.Panel1.Controls.Add(Me.btnSubtract)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 186)
        Me.Panel1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(499, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "SHOW RESULT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MatrixCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(554, 209)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MatrixCalculator"
        Me.Text = "Matrix Calculator"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtmatrix_a_x As System.Windows.Forms.TextBox
    Friend WithEvents txtmatrix_a_y As System.Windows.Forms.TextBox
    Friend WithEvents txtmatrix_b_x As System.Windows.Forms.TextBox
    Friend WithEvents txtmatrix_b_y As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
