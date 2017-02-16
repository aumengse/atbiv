Module compute_truss
    Public Sub truss_computation(ByVal fc_x As Integer, ByVal fc_y As Integer, ByVal b_x As Integer, ByVal b_y As Integer, ByVal w_x As Integer, ByVal w_y As Integer)
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

        '-----------------enter value of w

        Dim array_w(w_x, w_y) As Double

        For i As Integer = 0 To w_x - 1
            Dim obj_w(w_y - 1) As Object
            For ii As Integer = 0 To w_y - 1
again_w:        matrix_val = InputBox("ENTER VALUE OF [W]" & "{" & i + 1 & " , " & ii + 1 & "}")
                If matrix_val <> "" Then
                    If matrix_val.Contains("/") Then
                        array_w(i, ii) = fractionaltoDecimal(matrix_val.ToString)
                        obj_w(ii) = fractionaltoDecimal(matrix_val.ToString)
                    Else
                        array_w(i, ii) = matrix_val.ToString
                        obj_w(ii) = matrix_val.ToString
                    End If
                Else
                    GoTo again_w
                End If
                
            Next
            Main_calculator.dgv_w.Rows.Add(obj_w)
        Next

        '------------------- COMPUTE Q = B * W

        Dim array_q(b_x, w_y) As Double
        Dim a As Integer

        result_q.dgv_Q.ColumnCount = w_y

        For ii As Integer = 0 To b_x - 1
            For a = 0 To w_y - 1
                For b As Integer = 0 To w_x - 1
                    matrix_val = array_b(ii, b) * array_w(b, a)
                    res_q_sum = res_q_sum + matrix_val

                Next
                array_q(ii, a) = res_q_sum
                res_q_sum = 0
            Next
        Next

        For y As Integer = 0 To b_x - 1
            Dim obj_result(w_y - 1) As Object
            For yy As Integer = 0 To w_y - 1
                obj_result(yy) = array_q(y, yy)
            Next
            result_q.dgv_Q.Rows.Add(obj_result)
        Next

        result_q.Show()

        '--------------------B Transpose
        Dim array_b_transpose(b_y, b_x) As Double

        result_btranspose.dgv_bTranspose.ColumnCount = b_x

        For i As Integer = 0 To b_y - 1
            Dim obj_result(b_x - 1) As Object
            For ii As Integer = 0 To b_x - 1
                array_b_transpose(i, ii) = array_b(ii, i)
                obj_result(ii) = array_b_transpose(i, ii)
            Next
            result_btranspose.dgv_bTranspose.Rows.Add(obj_result)
        Next
        result_btranspose.Show()


        '---------------------COMPUTE FC * B
        Dim array_fc_b(fc_x, b_y) As Double
        'Dim a As Integer

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

        result_f.dgv_f_b.ColumnCount = b_y

        For y As Integer = 0 To fc_x - 1
            Dim obj_result(b_y - 1) As Object
            For yy As Integer = 0 To b_y - 1
                obj_result(yy) = array_fc_b(y, yy)
            Next
            result_f.dgv_f_b.Rows.Add(obj_result)
        Next
        result_f.Show()

        '---------------------COMPUTE B transpose * FC_B
        Dim array_f(b_y, b_y) As Double
        'Dim a As Integer

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

        result_f.dgv_f.ColumnCount = b_y

        For y As Integer = 0 To b_y - 1
            Dim obj_result(b_y - 1) As Object
            For yy As Integer = 0 To b_y - 1
                obj_result(yy) = array_f(y, yy)
            Next
            result_f.dgv_f.Rows.Add(obj_result)
        Next
        result_f.Show()

        '------------------- COMPUTE F * W

        Dim array_f_w(b_y, w_y) As Double
        Dim array_final_ans(b_y, w_y) As Double

        Dim given_a As Integer = 12
        Dim given_e As Double = 30000
        Dim final_ans As Double

        result_final.dgv_f_w.ColumnCount = w_y
        result_final.dgv_final_ans.ColumnCount = w_y

        For ii As Integer = 0 To b_y - 1
            For a = 0 To w_y - 1
                For b As Integer = 0 To w_x - 1
                    matrix_val = array_f(ii, b) * array_w(b, a)
                    res_q_sum = res_q_sum + matrix_val

                Next
                array_f_w(ii, a) = res_q_sum
                final_ans = (res_q_sum * given_a) / given_e
                array_final_ans(ii, a) = Format(final_ans, "0.000")
                res_q_sum = 0
            Next
        Next

        For y As Integer = 0 To b_y - 1
            Dim obj_result(w_y - 1) As Object
            Dim obj_result_final(w_y - 1) As Object
            For yy As Integer = 0 To w_y - 1
                obj_result(yy) = array_f_w(y, yy)
                obj_result_final(yy) = array_final_ans(y, yy)
            Next
            result_final.dgv_f_w.Rows.Add(obj_result)
            result_final.dgv_final_ans.Rows.Add(obj_result_final)
        Next

        result_final.Show()

    End Sub
End Module
