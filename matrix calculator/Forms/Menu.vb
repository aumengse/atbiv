Public Class Menu_main
    Public calculator As Integer

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        MatrixCalculator.Show()
    End Sub

    Private Sub BeamCalculatorToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeamCalculatorToolStripMenuItem.Click
        calculator = 1
        Main_calculator.Show()
    End Sub

    Private Sub FrameCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrameCalculatorToolStripMenuItem.Click
        calculator = 2
        Main_calculator.Show()
    End Sub

    Private Sub TrussCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrussCalculatorToolStripMenuItem.Click
        calculator = 3
        Main_calculator.Show()
    End Sub

End Class