Public Class SoloNumeros
    Public Shared Sub soloNumeros(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar = ".") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Shared Function strNumeros(valor As Object) As Boolean
        Dim rs As Boolean
        rs = IsNumeric(valor)
        Return rs
    End Function

    Public Shared Function numero2Digitos(valor As Integer) As String
        Dim cadena As String
        If valor <= 9 Then
            cadena = "0" & valor
        Else
            cadena = valor
        End If

        Return cadena
    End Function

    Public Shared Function formatoNumero(valor As Object) As String
        If valor IsNot Nothing Then
            Dim cantidad As Object = FormatNumber(valor, 2)
            Return cantidad
        End If

    End Function

    Public Shared Function formatoMoneda(valor As Object) As String
        Dim cadena As String = valor.ToString
        If valor IsNot Nothing And cadena <> "" Then
            Dim cantidad As Object = FormatCurrency(valor, 2, 0, TriState.True, TriState.True)
            Return cantidad
        End If

    End Function

End Class