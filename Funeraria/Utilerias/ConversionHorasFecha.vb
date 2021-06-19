Public Class ConversionHorasFecha

    Public Shared Function Fecha24H(value As String) As String
        If value <> "" Then
            Dim f1 As String = value
            Dim fecha1 As DateTime = Convert.ToDateTime(f1.Replace("p.m.", "PM").Replace("a.m.", "AM"))
            Dim h1 As String = fecha1.ToString("HH:mm:ss")
            Return h1
        Else
            Return Nothing
        End If

    End Function
    Public Shared Function Fecha12H(value As String) As String
        If value <> "" Then
            Dim f1 As String = value
            Dim fecha1 As DateTime = Convert.ToDateTime(f1.Replace("PM", "p.m.").Replace("AM", "a.m."))
            Dim h1 As String = fecha1.ToString("01/01/1753 HH:mm:ss tt")

            Return h1
        End If

    End Function


    Public Shared Function fechaDB(valor As Date) As String
        Dim fecha As Date = valor
        Dim conversion As String = fecha.ToString("yyyy-MM-dd")

        Return conversion
    End Function

    Public Shared Function fechaSP(valor As Date) As String
        Dim fecha As Date = valor
        Dim conversion As String = fecha.ToString("dd/MM/yyyy")

        Return conversion
    End Function

    Public Shared Function fechaDB24H(valor As DateTime) As String
        Dim fecha As DateTime = valor
        Dim conversion As String = fecha.ToString("yyyy-MM-dd HH:mm:ss")

        Return conversion
    End Function

End Class