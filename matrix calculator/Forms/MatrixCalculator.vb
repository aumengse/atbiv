Public Class MatrixCalculator
    Dim matrix_a
    Dim matrix_a_string
    Dim matrix_b
    Dim matrix_b_string
    Dim array_a
    Dim array_b
    Dim res_add
    Dim res_sub
    Dim res_mul
    Dim add_multiplication_res
    Dim res_string
    Dim matrix_ax, matrix_ay, matrix_bx, matrix_by As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        getText()

        table.DataGridViewMatrixA.ColumnCount = matrix_ay
        table.DataGridViewMatrixA.ColumnHeadersVisible = True

        table.DataGridViewMatrixB.ColumnCount = matrix_ay
        table.DataGridViewMatrixB.ColumnHeadersVisible = True

        table.DataGridViewResult.ColumnCount = matrix_ay
        table.DataGridViewResult.ColumnHeadersVisible = True

        Dim count As Integer = 0
        Dim countxx As Integer = count + 1

        While count < matrix_ay
            table.DataGridViewMatrixA.Columns(count).Name = "A" & countxx
            table.DataGridViewMatrixB.Columns(count).Name = "B" & countxx
            table.DataGridViewResult.Columns(count).Name = "R" & countxx
            count += 1
            countxx += 1
        End While


        If matrix_ax = matrix_ay And matrix_bx = matrix_by Or matrix_ax = matrix_bx And matrix_ay = matrix_by Then

            Dim array_a(matrix_ax, matrix_ay) As Double
            Dim array_b(matrix_bx, matrix_by) As Double

            For i As Integer = 0 To matrix_ax - 1
                Dim obj_a(matrix_ay - 1) As Object
                For ii As Integer = 0 To matrix_ay - 1
                    matrix_a = InputBox("Enter Matrix A" & "{" & i + 1 & " , " & ii + 1 & "}")
                    array_a(i, ii) = matrix_a
                    obj_a(ii) = matrix_a
                Next
                table.DataGridViewMatrixA.Rows.Add(obj_a)
            Next

            For i As Integer = 0 To matrix_bx - 1
                Dim obj_b(matrix_by - 1) As Object
                For ii As Integer = 0 To matrix_by - 1
                    matrix_b = InputBox("Enter Matrix B" & "{" & i + 1 & " , " & ii + 1 & "}")
                    array_b(i, ii) = matrix_b
                    obj_b(ii) = matrix_b
                Next
                table.DataGridViewMatrixB.Rows.Add(obj_b)
            Next

            For i As Integer = 0 To matrix_ax - 1
                Dim obj_result(matrix_by - 1) As Object
                For ii As Integer = 0 To matrix_by - 1
                    res_add = array_a(i, ii) + array_b(i, ii)
                    obj_result(ii) = res_add
                Next

                table.DataGridViewResult.Rows.Add(obj_result)
            Next
        Else
            MessageBox.Show("THE MATRIX IS/ARE INVALID", "Error")
            clearfields()
            txtmatrix_a_x.Focus()
        End If
        clearfields()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        getText()

        table.DataGridViewMatrixA.ColumnCount = matrix_ay
        table.DataGridViewMatrixA.ColumnHeadersVisible = True

        table.DataGridViewMatrixB.ColumnCount = matrix_ay
        table.DataGridViewMatrixB.ColumnHeadersVisible = True

        table.DataGridViewResult.ColumnCount = matrix_ay
        table.DataGridViewResult.ColumnHeadersVisible = True

        Dim count As Integer = 0
        Dim countxx As Integer = count + 1

        If matrix_ax = matrix_ay And matrix_bx = matrix_by Or matrix_ax = matrix_bx And matrix_ay = matrix_by Then

            Dim array_a(matrix_ax, matrix_ay) As Double
            Dim array_b(matrix_bx, matrix_by) As Double

            For i As Integer = 0 To matrix_ax - 1
                Dim obj_a(matrix_ay - 1) As Object
                For ii As Integer = 0 To matrix_ay - 1
                    matrix_a = InputBox("Enter Matrix A" & "{" & i + 1 & " , " & ii + 1 & "}")
                    array_a(i, ii) = matrix_a
                    obj_a(ii) = matrix_a
                Next
                table.DataGridViewMatrixA.Rows.Add(obj_a)
            Next

            For i As Integer = 0 To matrix_bx - 1
                Dim obj_b(matrix_by - 1) As Object
                For ii As Integer = 0 To matrix_by - 1
                    matrix_b = InputBox("Enter Matrix B" & "{" & i + 1 & " , " & ii + 1 & "}")
                    array_b(i, ii) = matrix_b
                    obj_b(ii) = matrix_b
                Next
                table.DataGridViewMatrixB.Rows.Add(obj_b)
            Next

            For i As Integer = 0 To matrix_ax - 1
                Dim obj_result(matrix_by - 1) As Object
                For ii As Integer = 0 To matrix_by - 1
                    res_add = array_a(i, ii) - array_b(i, ii)
                    obj_result(ii) = res_add
                Next

                table.DataGridViewResult.Rows.Add(obj_result)
            Next
        Else
            MessageBox.Show("THE MATRIX IS/ARE INVALID", "Error")
            clearfields()
            txtmatrix_a_x.Focus()
        End If
        clearfields()
       
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        getText()


        table.DataGridViewMatrixA.ColumnCount = matrix_ay
        table.DataGridViewMatrixA.ColumnHeadersVisible = True

        table.DataGridViewMatrixB.ColumnCount = matrix_by
        table.DataGridViewMatrixB.ColumnHeadersVisible = True

        table.DataGridViewResult.ColumnCount = matrix_by
        table.DataGridViewResult.ColumnHeadersVisible = True

        Dim count As Integer = 0
        Dim countxx As Integer = count + 1

        While count < matrix_ay
            table.DataGridViewMatrixA.Columns(count).Name = "A" & countxx

            count += 1
            countxx += 1
        End While

        count = 0
        countxx = count + 1
        While count < matrix_by
            table.DataGridViewMatrixB.Columns(count).Name = "B" & countxx
            table.DataGridViewResult.Columns(count).Name = "R" & countxx
            count += 1
            countxx += 1
        End While



        Dim array_multiply(matrix_ax, matrix_by) As Double
        Dim a As Integer

        If matrix_ay = matrix_bx Then

            Dim array_a(matrix_ax, matrix_ay) As Double
            Dim array_b(matrix_bx, matrix_by) As Double

            For i As Integer = 0 To matrix_ax - 1
                Dim obj_a(matrix_ay - 1) As Object
                For ii As Integer = 0 To matrix_ay - 1
                    matrix_a = InputBox("Enter Matrix A" & "{" & i + 1 & " , " & ii + 1 & "}")
                    array_a(i, ii) = matrix_a
                    obj_a(ii) = matrix_a
                Next
                table.DataGridViewMatrixA.Rows.Add(obj_a)
            Next

            For i As Integer = 0 To matrix_bx - 1
                Dim obj_b(matrix_by - 1) As Object
                For ii As Integer = 0 To matrix_by - 1
                    matrix_b = InputBox("Enter Matrix B" & "{" & i + 1 & " , " & ii + 1 & "}")
                    array_b(i, ii) = matrix_b
                    obj_b(ii) = matrix_b
                Next
                table.DataGridViewMatrixB.Rows.Add(obj_b)
            Next

            For ii As Integer = 0 To matrix_ax - 1
                For a = 0 To matrix_by - 1
                    For b As Integer = 0 To matrix_bx - 1
                        res_mul = array_a(ii, b) * array_b(b, a)
                        add_multiplication_res = add_multiplication_res + res_mul

                    Next
                    array_multiply(ii, a) = add_multiplication_res
                    add_multiplication_res = 0
                Next
            Next

            For y As Integer = 0 To matrix_ax - 1
                Dim obj_result(matrix_by - 1) As Object
                For yy As Integer = 0 To matrix_by - 1
                    obj_result(yy) = array_multiply(y, yy)
                Next
                table.DataGridViewResult.Rows.Add(obj_result)
            Next

        Else
            MessageBox.Show("THE MATRIX IS/ARE INVALID", "Error")
        End If
        clearfields()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        matrix_ax = txtmatrix_a_x.Text
        matrix_ay = txtmatrix_a_y.Text
        Dim default_value As Integer = 1

        Dim array_inverse(matrix_ax, matrix_ay) As Double
        Dim array_C(matrix_ax) As Double
        Dim co_factor(matrix_ax, matrix_ay) As Double

        'list_matrix_a.Items.Clear()
        table_inverse.list_matrix_b.Items.Clear()
        'list_result.Items.Clear()

        If matrix_ax = matrix_ay Then
            For i As Integer = 1 To matrix_ax
                For ii As Integer = 1 To matrix_ay
                    matrix_a = InputBox("Enter Matrix A" & "{" & i & " , " & ii & "}")
                    array_inverse(i, ii) = matrix_a

                    If matrix_a > 0 Then
                        Dim sign As String
                        sign = "+"
                        matrix_a_string = matrix_a_string & sign & "     " & matrix_a & "X(" & ii & ")" & "     "
                    Else
                        matrix_a_string = matrix_a_string & "     " & matrix_a & "X(" & ii & ")" & "     "
                    End If
                Next

                table_inverse.list_matrix_b.Items.Add(matrix_a_string)
                table_inverse.list_matrix_b.Items.Add(vbLf)
                matrix_a_string = ""
            Next

            For i As Integer = 1 To default_value
                table_inverse.list_matrix_b.Items.Add("VALUE OF C")
                For ii As Integer = 1 To matrix_ay
                    matrix_a = InputBox("Enter C value" & "{" & ii & " , " & i & "}")
                    array_C(ii) = matrix_a
                    table_inverse.list_matrix_b.Items.Add(array_C(ii))
                    matrix_a_string = ""
                Next
                table_inverse.list_matrix_b.Items.Add(vbLf)
            Next

            For i As Integer = 1 To matrix_ax
                For ii As Integer = 1 To matrix_ay
                    If i = 1 Then
                        If ii = 1 Then
                            co_factor(i, ii) = ((array_inverse(2, 2) * array_inverse(3, 3)) - (array_inverse(2, 3) * array_inverse(3, 2)) * 1)
                        End If

                        If ii = 2 Then
                            co_factor(i, ii) = (((array_inverse(2, 1) * array_inverse(3, 3)) - (array_inverse(2, 3) * array_inverse(3, 1))) * -1)
                        End If

                        If ii = 3 Then
                            co_factor(i, ii) = ((array_inverse(2, 1) * array_inverse(3, 2)) - (array_inverse(2, 2) * array_inverse(3, 1)) * 1)
                        End If
                    End If

                    If i = 2 Then
                        If ii = 1 Then
                            co_factor(i, ii) = (((array_inverse(1, 2) * array_inverse(3, 3)) - (array_inverse(1, 3) * array_inverse(3, 2))) * -1)
                        End If

                        If ii = 2 Then
                            co_factor(i, ii) = ((array_inverse(1, 1) * array_inverse(3, 3)) - (array_inverse(1, 3) * array_inverse(3, 1)) * 1)
                        End If

                        If ii = 3 Then
                            co_factor(i, ii) = (((array_inverse(1, 1) * array_inverse(3, 2)) - (array_inverse(1, 2) * array_inverse(3, 1))) * -1)
                        End If
                    End If

                    If i = 3 Then
                        If ii = 1 Then
                            co_factor(i, ii) = ((array_inverse(1, 2) * array_inverse(2, 3)) - (array_inverse(1, 3) * array_inverse(2, 2)) * 1)
                        End If

                        If ii = 2 Then
                            co_factor(i, ii) = (((array_inverse(1, 1) * array_inverse(2, 3)) - (array_inverse(1, 3) * array_inverse(2, 1))) * -1)
                        End If

                        If ii = 3 Then
                            co_factor(i, ii) = ((array_inverse(1, 1) * array_inverse(2, 2)) - (array_inverse(1, 2) * array_inverse(2, 1)) * 1)
                        End If
                    End If
                Next
            Next

            table_inverse.list_matrix_b.Items.Add("CO-FACTOR:")
            For b_x As Integer = 1 To matrix_ax
                For b_y As Integer = 1 To matrix_ay
                    res_string = res_string & "     " + Convert.ToString(co_factor(b_x, b_y)) & "     "
                Next
                table_inverse.list_matrix_b.Items.Add(res_string)
                table_inverse.list_matrix_b.Items.Add(vbLf)
                res_string = ""
            Next

            table_inverse.list_matrix_b.Items.Add("DETERMINANT:")
            Dim determinant As Double
            For x As Integer = 1 To 1
                For xx As Integer = 1 To matrix_ax
                    determinant = determinant + (array_inverse(x, xx) * (co_factor(x, xx)))
                Next
                table_inverse.list_matrix_b.Items.Add(determinant)
                table_inverse.list_matrix_b.Items.Add(vbLf)
                res_string = ""
            Next

            table_inverse.list_matrix_b.Items.Add("ADJOINT:")
            Dim adjoint(matrix_ax, matrix_ay) As Double
            For x As Integer = 1 To matrix_ax
                For xx As Integer = 1 To matrix_ay
                    adjoint(x, xx) = co_factor(xx, x)
                    res_string = res_string & "     " + Convert.ToString(adjoint(x, xx)) & "     "
                Next
                table_inverse.list_matrix_b.Items.Add(res_string)
                table_inverse.list_matrix_b.Items.Add(vbLf)
                res_string = ""
            Next

            Dim ans(matrix_ax) As Double
            Dim ans1 As Double

            table_inverse.list_matrix_b.Items.Add("RESULT:")
            For aa As Integer = 1 To 1
                For bb As Integer = 1 To matrix_ax
                    For cc As Integer = 1 To matrix_ay
                        ans1 = ((ans1) + ((1 / determinant) * (adjoint(bb, cc)) * (array_C(cc))))
                    Next
                    res_string = "X(" & bb & ") = " & ans1
                    table_inverse.list_matrix_b.Items.Add(res_string)
                    res_string = ""
                    ans1 = 0
                Next
            Next

            table_inverse.Show()

        Else
            MessageBox.Show("THE MATRIX IS/ARE INVALID", "Error")
        End If
        clearfields()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        table.Show()
    End Sub

    Private Sub txtmatrix_b_x_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmatrix_b_x.TextChanged

    End Sub

    Private Sub getText()
        matrix_ax = txtmatrix_a_x.Text
        matrix_ay = txtmatrix_a_y.Text
        matrix_bx = txtmatrix_b_x.Text
        matrix_by = txtmatrix_b_y.Text

    End Sub

    Private Sub MatrixCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub clearfields()
        txtmatrix_a_x.Text = ""
        txtmatrix_a_y.Text = ""
        txtmatrix_b_x.Text = ""
        txtmatrix_b_y.Text = ""
    End Sub

End Class
