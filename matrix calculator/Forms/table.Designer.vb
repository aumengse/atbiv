<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class table
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
        Me.DataGridViewMatrixA = New System.Windows.Forms.DataGridView()
        Me.DataGridViewResult = New System.Windows.Forms.DataGridView()
        Me.DataGridViewMatrixB = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewMatrixA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewMatrixB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewMatrixA
        '
        Me.DataGridViewMatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMatrixA.Location = New System.Drawing.Point(12, 26)
        Me.DataGridViewMatrixA.Name = "DataGridViewMatrixA"
        Me.DataGridViewMatrixA.Size = New System.Drawing.Size(590, 320)
        Me.DataGridViewMatrixA.TabIndex = 0
        '
        'DataGridViewResult
        '
        Me.DataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResult.Location = New System.Drawing.Point(608, 26)
        Me.DataGridViewResult.Name = "DataGridViewResult"
        Me.DataGridViewResult.Size = New System.Drawing.Size(629, 669)
        Me.DataGridViewResult.TabIndex = 1
        '
        'DataGridViewMatrixB
        '
        Me.DataGridViewMatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMatrixB.Location = New System.Drawing.Point(12, 375)
        Me.DataGridViewMatrixB.Name = "DataGridViewMatrixB"
        Me.DataGridViewMatrixB.Size = New System.Drawing.Size(590, 320)
        Me.DataGridViewMatrixB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MATRIX A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MATRIX B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(881, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RESULT"
        '
        'table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 707)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewMatrixB)
        Me.Controls.Add(Me.DataGridViewResult)
        Me.Controls.Add(Me.DataGridViewMatrixA)
        Me.Name = "table"
        Me.Text = "table"
        CType(Me.DataGridViewMatrixA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewMatrixB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewMatrixA As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewResult As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewMatrixB As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub table_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
