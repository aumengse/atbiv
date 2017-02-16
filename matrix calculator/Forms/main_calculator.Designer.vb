<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_calculator
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
        Me.txtFC_x = New System.Windows.Forms.TextBox()
        Me.txtFC_y = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtB_y = New System.Windows.Forms.TextBox()
        Me.txtB_x = New System.Windows.Forms.TextBox()
        Me.Lx = New System.Windows.Forms.Label()
        Me.txtW_y = New System.Windows.Forms.TextBox()
        Me.txtW_x = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lw = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.dgv_fc = New System.Windows.Forms.DataGridView()
        Me.dgv_b = New System.Windows.Forms.DataGridView()
        Me.dgv_w = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_fc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_w, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFC_x
        '
        Me.txtFC_x.Location = New System.Drawing.Point(67, 29)
        Me.txtFC_x.Name = "txtFC_x"
        Me.txtFC_x.Size = New System.Drawing.Size(100, 20)
        Me.txtFC_x.TabIndex = 0
        '
        'txtFC_y
        '
        Me.txtFC_y.Location = New System.Drawing.Point(194, 29)
        Me.txtFC_y.Name = "txtFC_y"
        Me.txtFC_y.Size = New System.Drawing.Size(100, 20)
        Me.txtFC_y.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X"
        '
        'txtB_y
        '
        Me.txtB_y.Location = New System.Drawing.Point(195, 303)
        Me.txtB_y.Name = "txtB_y"
        Me.txtB_y.Size = New System.Drawing.Size(100, 20)
        Me.txtB_y.TabIndex = 4
        '
        'txtB_x
        '
        Me.txtB_x.Location = New System.Drawing.Point(68, 303)
        Me.txtB_x.Name = "txtB_x"
        Me.txtB_x.Size = New System.Drawing.Size(100, 20)
        Me.txtB_x.TabIndex = 3
        '
        'Lx
        '
        Me.Lx.AutoSize = True
        Me.Lx.Location = New System.Drawing.Point(596, 308)
        Me.Lx.Name = "Lx"
        Me.Lx.Size = New System.Drawing.Size(14, 13)
        Me.Lx.TabIndex = 8
        Me.Lx.Text = "X"
        '
        'txtW_y
        '
        Me.txtW_y.Location = New System.Drawing.Point(616, 302)
        Me.txtW_y.Name = "txtW_y"
        Me.txtW_y.Size = New System.Drawing.Size(100, 20)
        Me.txtW_y.TabIndex = 7
        '
        'txtW_x
        '
        Me.txtW_x.Location = New System.Drawing.Point(489, 302)
        Me.txtW_x.Name = "txtW_x"
        Me.txtW_x.Size = New System.Drawing.Size(100, 20)
        Me.txtW_x.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "[ FC ]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "[ B ]"
        '
        'lw
        '
        Me.lw.AutoSize = True
        Me.lw.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lw.Location = New System.Drawing.Point(430, 297)
        Me.lw.Name = "lw"
        Me.lw.Size = New System.Drawing.Size(53, 24)
        Me.lw.TabIndex = 11
        Me.lw.Text = "[ W ]"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(15, 597)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(714, 24)
        Me.btnCompute.TabIndex = 12
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'dgv_fc
        '
        Me.dgv_fc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fc.Location = New System.Drawing.Point(15, 55)
        Me.dgv_fc.Name = "dgv_fc"
        Me.dgv_fc.Size = New System.Drawing.Size(714, 228)
        Me.dgv_fc.TabIndex = 16
        '
        'dgv_b
        '
        Me.dgv_b.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_b.Location = New System.Drawing.Point(15, 334)
        Me.dgv_b.Name = "dgv_b"
        Me.dgv_b.Size = New System.Drawing.Size(393, 246)
        Me.dgv_b.TabIndex = 17
        '
        'dgv_w
        '
        Me.dgv_w.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_w.Location = New System.Drawing.Point(431, 334)
        Me.dgv_w.Name = "dgv_w"
        Me.dgv_w.Size = New System.Drawing.Size(298, 246)
        Me.dgv_w.TabIndex = 18
        '
        'Main_calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 635)
        Me.Controls.Add(Me.dgv_w)
        Me.Controls.Add(Me.dgv_b)
        Me.Controls.Add(Me.dgv_fc)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lw)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Lx)
        Me.Controls.Add(Me.txtW_y)
        Me.Controls.Add(Me.txtW_x)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtB_y)
        Me.Controls.Add(Me.txtB_x)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFC_y)
        Me.Controls.Add(Me.txtFC_x)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Main_calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIN CALCULATOR"
        CType(Me.dgv_fc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_w, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFC_x As System.Windows.Forms.TextBox
    Friend WithEvents txtFC_y As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtB_y As System.Windows.Forms.TextBox
    Friend WithEvents txtB_x As System.Windows.Forms.TextBox
    Friend WithEvents Lx As System.Windows.Forms.Label
    Friend WithEvents txtW_y As System.Windows.Forms.TextBox
    Friend WithEvents txtW_x As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lw As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents dgv_fc As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_b As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_w As System.Windows.Forms.DataGridView
End Class
