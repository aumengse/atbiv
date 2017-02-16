Module functions
    Public Function fractionaltoDecimal(ByVal frac As String) As Double

        Dim decimalVal As String = "0"
        Dim upper As Decimal = 0
        Dim lower As Decimal = 0
        Dim remain As Decimal = 0
        If frac.IndexOf("/") <> -1 Then

            If frac.IndexOf(" ") <> -1 Then
                remain = CType(frac.Substring(0, frac.IndexOf(" ")), Decimal)
                frac = frac.Substring(frac.IndexOf(" "))
            End If

        End If
        upper = CType(frac.Substring(0, frac.IndexOf("/")), Decimal)
        lower = CType(frac.Substring(frac.IndexOf("/") + 1), Decimal)
        If upper > lower Then
            'Return "Error Please Check Fraction"
            decimalVal = (remain + (upper / lower)).ToString
        Else
            decimalVal = (remain + (upper / lower)).ToString
        End If

        Return decimalVal
    End Function
    Private Function validate_matrix_val(ByVal array_b As Double, ByVal obj_b As Object, ByVal matrix_val As Object) As Object()
        Throw New NotImplementedException
    End Function

End Module
