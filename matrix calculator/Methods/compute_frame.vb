Module compute_frame
    Public Sub frame_computation(ByVal fc_x As Integer, ByVal fc_y As Integer, ByVal b_x As Integer, ByVal b_y As Integer)
        Dim res_q_sum
        Dim matrix_val

        '-------------ENTER values of FC
        Dim array_fc(fc_x, fc_y) As Double

        For i As Integer = 0 To fc_x - 1
            Dim obj_fc(fc_y - 1) As Object
            For ii As Integer = 0 To fc_y - 1
again_fc:       matrix_val = InputBox("ENTER VALUE OF [FC]" & "{" & i + 1 & " , " & ii + 1 & "}")
                If matrix_val <> "" Then
                    If matrix_val.Contains("/") Then
                        array_fc(i, ii) = fractionaltoDecimal(matrix_val.ToString)
                        obj_fc(ii) = fractionaltoDecimal(matrix_val.ToString)
                    Else
                        array_fc(i, ii) = matrix_val
                        obj_fc(ii) = matrix_val
                    End If
                Else
                    GoTo again_fc
                End If

            Next
            Main_calculator.dgv_fc.Rows.Add(obj_fc)
        Next

        '------------enter values of B
        Dim array_b(b_x, b_y) As Double


        For i As Integer = 0 To b_x - 1
            Dim obj_b(b_y - 1) As Object
            For ii As Integer = 0 To b_y - 1
again_b:        matrix_val = InputBox("ENTER VALUE OF [B]" & "{" & i + 1 & " , " & ii + 1 & "}")
                If matrix_val <> "" Then
                    If matrix_val.Contains("/") Then
                        array_b(i, ii) = fractionaltoDecimal(matrix_val.ToString)
                        obj_b(ii) = fractionaltoDecimal(matrix_val.ToString)
                    Else
                        array_b(i, ii) = matrix_val
                        obj_b(ii) = matrix_val
                    End If
                Else
                    GoTo again_b
                End If

            Next
            Main_calculator.dgv_b.Rows.Add(obj_b)
        Next

        '--------------------B Transpose
        Dim array_b_transpose(b_y, b_x) As Double

        For i As Integer = 0 To b_y - 1
            For ii As Integer = 0 To b_x - 1
                array_b_transpose(i, ii) = array_b(ii, i)
            Next
        Next


        '---------------------COMPUTE FC * B
        Dim array_fc_b(fc_x, b_y) As Double

        For ii As Integer = 0 To fc_x - 1
            For a = 0 To b_y - 1
                For b As Integer = 0 To b_x - 1
                    matrix_val = array_fc(ii, b) * array_b(b, a)
                    res_q_sum = res_q_sum + matrix_val
                Next
                array_fc_b(ii, a) = res_q_sum
                res_q_sum = 0
            Next
        Next

        '---------------------COMPUTE B transpose * FC_B
        Dim array_f(b_y, b_y) As Double

        For ii As Integer = 0 To b_y - 1
            For a = 0 To b_y - 1
                For b As Integer = 0 To b_x - 1
                    matrix_val = array_b_transpose(ii, b) * array_fc_b(b, a)
                    res_q_sum = res_q_sum + matrix_val

                Next
                array_f(ii, a) = res_q_sum
                res_q_sum = 0
            Next
        Next

        '--------------get matrix A from the result of F
        Dim array_a(2, 2) As Double
        array_a(0, 0) = array_f(1, 1)
        array_a(0, 1) = array_f(2, 1)
        array_a(1, 0) = array_f(1, 2)
        array_a(1, 1) = array_f(2, 2)

        '----------------get ADJ A
        Dim array_adj_a(2, 2) As Double
        array_adj_a(0, 0) = array_a(1, 1)
        array_adj_a(0, 1) = -array_a(1, 0)
        array_adj_a(1, 0) = -array_a(0, 1)
        array_adj_a(1, 1) = array_a(0, 0)

        '-------------------COMPUTE DET A
        Dim det_a As Double
        det_a = array_a(0, 0) * array_a(1, 1) + array_a(0, 1) * (-array_a(1, 0))

        '--------------compute X1 and X2
        Dim array_x12(2, 2) As Double

        For i As Integer = 0 To 1
            For ii As Integer = 0 To 1
                matrix_val = (1 / det_a) * array_adj_a(i, ii)
                array_x12(i, ii) = matrix_val
            Next
        Next

        '----------------initialize given value
        Dim array_given(2, 1) As Double
        array_given(0, 0) = -16
        array_given(1, 0) = 96

        Dim w As Double = 20

        '-----------------compute R1 and R2
        Dim array_r12(2, 1) As Double

        For ii As Integer = 0 To 1
            For a As Integer = 0 To 0
                For b As Integer = 0 To 1
                    matrix_val = array_x12(ii, b) * array_given(b, a)
                    res_q_sum = res_q_sum + matrix_val

                Next
                array_r12(ii, a) = res_q_sum * w
                res_q_sum = 0
            Next
        Next

        result_r.dgv_R.ColumnCount = 1
        For y As Integer = 0 To 1
            Dim obj_result(0) As Object
            For yy As Integer = 0 To 0
                obj_result(yy) = array_r12(y, yy)
            Next
            result_r.dgv_R.Rows.Add(obj_result)
        Next
        result_r.Show()

        '---------initialize value of W
        Dim array_w(3, 1) As Double
        array_w(0, 0) = w
        array_w(1, 0) = array_r12(0, 0)
        array_w(2, 0) = array_r12(1, 0)

        '-------------compute Q = B * W

        Dim array_q(b_x, 1) As Double


        result_q.dgv_Q.ColumnCount = 1

        For ii As Integer = 0 To b_x - 1
            For a As Integer = 0 To 0
                For b As Integer = 0 To 2
                    matrix_val = array_b(ii, b) * array_w(b, a)
                    res_q_sum = res_q_sum + matrix_val

                Next
                array_q(ii, a) = res_q_sum
                res_q_sum = 0
            Next
        Next

        For y As Integer = 0 To b_x - 1
            Dim obj_result(0) As Object
            For yy As Integer = 0 To 0
                obj_result(yy) = array_q(y, yy)
            Next
            result_q.dgv_Q.Rows.Add(obj_result)
        Next

        result_q.Show()

        '---------------------INITIALIAZE new VALUE of F and the given E and I
        Dim array_new_f(1, 3) As Double
        array_new_f(0, 0) = array_f(0, 0)
        array_new_f(0, 1) = array_f(0, 1)
        array_new_f(0, 2) = array_f(0, 2)

        Dim given_e As Double = 200000000
        Dim given_i As Double = 0.0001

        '---------------------COMPUTE DELTA = F * W
        Dim array_delta(1, 1) As Double
        result_delta.dgv_delta.ColumnCount = 1

        For ii As Integer = 0 To 0
            For a As Integer = 0 To 0
                For b As Integer = 0 To 2
                    matrix_val = array_new_f(ii, b) * array_w(b, a)
                    res_q_sum = res_q_sum + matrix_val
                Next
                array_delta(ii, a) = 4 / (6 * given_e * given_i) * res_q_sum

                res_q_sum = 0
            Next
        Next

        For y As Integer = 0 To 0
            Dim obj_result_final(0) As Object
            For yy As Integer = 0 To 0
                obj_result_final(yy) = array_delta(y, yy)
            Next
            result_delta.dgv_delta.Rows.Add(obj_result_final)
        Next
        result_delta.Show()
    End Sub
End Module
