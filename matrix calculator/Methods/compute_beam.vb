Imports System.Text.RegularExpressions

Module compute_beam
    Public Sub beam_computation(ByVal fc_x As Integer, ByVal fc_y As Integer, ByVal b_x As Integer, ByVal b_y As Integer)
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
        Dim suffix As Char

        For i As Integer = 0 To b_x - 1
            Dim obj_b(b_y - 1) As Object
            For ii As Integer = 0 To b_y - 1
again_b:        matrix_val = InputBox("ENTER VALUE OF [B]" & "{" & i + 1 & " , " & ii + 1 & "}")
                If matrix_val <> "" Then
                    If matrix_val.Contains("/") Then
                        array_b(i, ii) = fractionaltoDecimal(matrix_val.ToString)
                        obj_b(ii) = fractionaltoDecimal(matrix_val.ToString)
                    ElseIf Char.IsLetter(matrix_val) = True Then
                        suffix = matrix_val(0).ToString.ToUpper
                        matrix_val = 1
                        array_b(i, ii) = matrix_val
                        obj_b(ii) = matrix_val.ToString + suffix
                    ElseIf Regex.IsMatch(matrix_val, "^[A-Za-z0-9]+$") Then
                        If Regex.IsMatch(matrix_val, "^[0-9]+$") Then
                            array_b(i, ii) = matrix_val
                            obj_b(ii) = matrix_val
                        Else
                            suffix = matrix_val(1).ToString.ToUpper
                            matrix_val = matrix_val(0)
                            array_b(i, ii) = Double.Parse(matrix_val)
                            obj_b(ii) = matrix_val + suffix
                        End If

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

        '--------------get matrix A from the result of F
        Dim array_a(2, 2) As Double
        array_a(0, 0) = array_f(1, 1)
        array_a(0, 1) = array_f(2, 1)
        array_a(1, 0) = array_f(1, 2)
        array_a(1, 1) = array_f(2, 2)

        Dim array_cof_a(2, 2) As Double
        array_cof_a(0, 0) = array_a(1, 1)
        array_cof_a(0, 1) = -array_a(1, 0)
        array_cof_a(1, 0) = -array_a(0, 1)
        array_cof_a(1, 1) = array_a(0, 0)

        Dim det_a As Double
        det_a = array_a(0, 0) * array_a(1, 1) + array_a(0, 1) * (-array_a(1, 0))

        MsgBox(det_a)



    End Sub

   
End Module
