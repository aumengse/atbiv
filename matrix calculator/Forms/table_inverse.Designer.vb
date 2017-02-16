<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class table_inverse
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.list_matrix_b = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "RESULT"
        '
        'list_matrix_b
        '
        Me.list_matrix_b.FormattingEnabled = True
        Me.list_matrix_b.Location = New System.Drawing.Point(12, 30)
        Me.list_matrix_b.Name = "list_matrix_b"
        Me.list_matrix_b.Size = New System.Drawing.Size(431, 420)
        Me.list_matrix_b.TabIndex = 8
        '
        'table_inverse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 469)
        Me.Controls.Add(Me.list_matrix_b)
        Me.Controls.Add(Me.Label1)
        Me.Name = "table_inverse"
        Me.Text = "table_inverse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents list_matrix_b As System.Windows.Forms.ListBox
End Class
