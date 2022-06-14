Public Class nent
    Private n As Integer
    Public Sub nent()
        n = 0
    End Sub
    Public Sub cargar(dato As Integer)
        n = dato
    End Sub
    Public Function descargar() As Integer
        Return n
    End Function
    Public Function verifpar() As Boolean
        Return n Mod 2 = 0
    End Function
    Public Function verifnummult(num As Integer) As Boolean
        Return (n Mod num = 0)
    End Function
    Public Function verifnumsubmult(num As Integer) As Boolean
        Return (num Mod n = 0)
    End Function
    Public Function verifpri() As Boolean
        Dim i, c, r As Integer
        c = 0
        For i = 1 To n
            r = n Mod i
            If r = 0 Then
                c = c + 1
            End If
        Next
        Return c = 2
    End Function
    Public Function verifnumcapicua() As Boolean
        Dim na, nu, dig As Integer
        na = n
        nu = 0
        While na > 0
            dig = na Mod 10
            nu = nu * 10 + dig
            na = na \ 10
        End While
        Return n = nu
    End Function
    Public Function VerifDigPar() As Boolean
        Return (n Mod 2 = 0)
    End Function
    Public Function impar() As Boolean
        Return (n Mod 2 <> 0)
    End Function
    Public Function veriffibo() As Boolean
        Dim a, b, f As Integer
        a = -1 : b = 1
        While f < n
            f = a + b
            a = b
            b = f
        End While
        Return f = n
    End Function


End Class
