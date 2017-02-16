Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Public Class Main_calculator
    Dim fc_x, fc_y, b_x, b_y, w_x, w_y As Integer
    Dim res_q, res_q_sum, array_q
    Dim chosen_cal As String
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        getValues()

    End Sub

    Private Sub getValues()
        If chosen_cal = "BEAM" Then
            fc_x = txtFC_x.Text
            fc_y = txtFC_y.Text

            b_x = txtB_x.Text
            b_y = txtB_y.Text

            dgv_fc.ColumnCount = fc_y
            dgv_fc.ColumnHeadersVisible = True

            dgv_b.ColumnCount = b_y
            dgv_b.ColumnHeadersVisible = True

            Dim count As Integer = 0
            Dim countxx As Integer = count + 1

            While count < fc_y
                dgv_fc.Columns(count).Name = "[FC]" & countxx
                count += 1
                countxx += 1
            End While

            While count < b_y
                dgv_b.Columns(count).Name = "[B]" & countxx
                count += 1
                countxx += 1
            End While
            beam_computation(fc_x, fc_y, b_x, b_y)
        ElseIf chosen_cal = "FRAME" Then
            fc_x = txtFC_x.Text
            fc_y = txtFC_y.Text

            b_x = txtB_x.Text
            b_y = txtB_y.Text

            dgv_fc.ColumnCount = fc_y
            dgv_fc.ColumnHeadersVisible = True

            dgv_b.ColumnCount = b_y
            dgv_b.ColumnHeadersVisible = True

            Dim count As Integer = 0
            Dim countxx As Integer = count + 1

            While count < fc_y
                dgv_fc.Columns(count).Name = "[FC]" & countxx
                count += 1
                countxx += 1
            End While

            While count < b_y
                dgv_b.Columns(count).Name = "[B]" & countxx
                count += 1
                countxx += 1
            End While
            frame_computation(fc_x, fc_y, b_x, b_y)
        ElseIf chosen_cal = "TRUSS" Then
            fc_x = txtFC_x.Text
            fc_y = txtFC_y.Text

            b_x = txtB_x.Text
            b_y = txtB_y.Text

            w_x = txtW_x.Text
            w_y = txtW_y.Text

            dgv_fc.ColumnCount = fc_y
            dgv_fc.ColumnHeadersVisible = True

            dgv_b.ColumnCount = b_y
            dgv_b.ColumnHeadersVisible = True

            dgv_w.ColumnCount = w_y
            dgv_w.ColumnHeadersVisible = True

            Dim count As Integer = 0
            Dim countxx As Integer = count + 1

            While count < fc_y
                dgv_fc.Columns(count).Name = "[FC]" & countxx
                count += 1
                countxx += 1
            End While

            While count < b_y
                dgv_b.Columns(count).Name = "[B]" & countxx
                count += 1
                countxx += 1
            End While

            While count < w_y
                dgv_w.Columns(count).Name = "[W]" & countxx
                count += 1
                countxx += 1
            End While
            truss_computation(fc_x, fc_y, b_x, b_y, w_x, w_y)
        End If
    End Sub

    Private Sub truss_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Menu_main.calculator = 1 Then
            txtW_x.Visible = False
            txtW_y.Visible = False
            dgv_w.Visible = False
            lw.Visible = False
            Lx.Visible = False
            chosen_cal = "BEAM"
        ElseIf Menu_main.calculator = 2 Then
            txtW_x.Visible = False
            txtW_y.Visible = False
            dgv_w.Visible = False
            lw.Visible = False
            Lx.Visible = False
            chosen_cal = "FRAME"
        ElseIf Menu_main.calculator = 3 Then
            chosen_cal = "TRUSS"
        End If
    End Sub

    
End Class