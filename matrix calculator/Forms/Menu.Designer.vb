<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_main
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BeamCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrameCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrussCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(881, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripLabel1.Text = "Matrix Calculator"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeamCalculatorToolStripMenuItem, Me.FrameCalculatorToolStripMenuItem, Me.TrussCalculatorToolStripMenuItem})
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripLabel2.Text = "Structure Calculator"
        '
        'BeamCalculatorToolStripMenuItem
        '
        Me.BeamCalculatorToolStripMenuItem.Name = "BeamCalculatorToolStripMenuItem"
        Me.BeamCalculatorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BeamCalculatorToolStripMenuItem.Text = "Beam Calculator"
        '
        'FrameCalculatorToolStripMenuItem
        '
        Me.FrameCalculatorToolStripMenuItem.Name = "FrameCalculatorToolStripMenuItem"
        Me.FrameCalculatorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FrameCalculatorToolStripMenuItem.Text = "Frame Calculator"
        '
        'TrussCalculatorToolStripMenuItem
        '
        Me.TrussCalculatorToolStripMenuItem.Name = "TrussCalculatorToolStripMenuItem"
        Me.TrussCalculatorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TrussCalculatorToolStripMenuItem.Text = "Truss Calculator"
        '
        'Menu_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 395)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Menu_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BeamCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrameCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrussCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
