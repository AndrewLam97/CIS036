Public Class Number
    Private _strNum As String
    Private _intNum As Integer
    Private _is5Digit As Boolean
    Private intTotal As Integer


    Sub New(ByVal strNum As String, ByVal intNum As Integer, ByVal is5Digit As Boolean)
        _strNum = strNum
        _intNum = intNum
        _is5Digit = is5Digit
    End Sub

End Class
