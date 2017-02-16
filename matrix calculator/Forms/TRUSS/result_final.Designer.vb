<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class result_final
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
        Me.dgv_f_w = New System.Windows.Forms.DataGridView()
        Me.dgv_final_ans = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_f_w, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_final_ans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_f_w
        '
        Me.dgv_f_w.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_f_w.Location = New System.Drawing.Point(197, 12)
        Me.dgv_f_w.Name = "dgv_f_w"
        Me.dgv_f_w.Size = New System.Drawing.Size(277, 161)
        Me.dgv_f_w.TabIndex = 0
        '
        'dgv_final_ans
        '
        Me.dgv_final_ans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_final_ans.Location = New System.Drawing.Point(197, 195)
        Me.dgv_final_ans.Name = "dgv_final_ans"
        Me.dgv_final_ans.Size = New System.Drawing.Size(277, 158)
        Me.dgv_final_ans.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "[/\]  = 1/AE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "[/\]  ="
        '
        'result_final
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 366)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_final_ans)
        Me.Controls.Add(Me.dgv_f_w)
        Me.Name = "result_final"
        Me.Text = "FINAL RESULT"
        CType(Me.dgv_f_w, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_final_ans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_f_w As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_final_ans As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
