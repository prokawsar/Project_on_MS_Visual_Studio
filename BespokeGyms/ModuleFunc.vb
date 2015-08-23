Module ModuleFunc


    Function cheek_(ByVal str As String) As Boolean
        Dim oneCha As String
        Dim r As Boolean = True

        If Not IsNumeric(str) Then
            r = False
        ElseIf (CInt(str) = 0) Then
            r = False
            Return r
            Exit Function
        End If
        For x = 0 To str.Length - 1
            oneCha = str.Substring(x, 1)
            If (oneCha = " ") Then
                r = False
                Exit For
            ElseIf (oneCha = ".") Then
                r = False
                Exit For
            End If
        Next
        Return r
    End Function

    Function Num(ByVal str As String) As Integer
        Dim i As Integer = 1
        Dim oneCha As String
        If Not IsNumeric(str) Then
            i = 0
        ElseIf (CInt(str) = 0) Then
            i = 0
            Return i
            Exit Function
        End If

        For x = 0 To str.Length - 1
            oneCha = str.Substring(x, 1)
            If (oneCha = ".") Then
                i = 0
                Exit For
            End If
        Next
        Return i
    End Function
End Module
