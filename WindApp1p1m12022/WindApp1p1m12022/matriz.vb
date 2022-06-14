Public Class matriz

    Const MAXF = 100
    Const MAXC = 100
    Private mx(MAXF, MAXC) As Integer
    Private fi, c As Integer
    Public Sub New()
        fi = 0 : c = 0
    End Sub
    Public Sub cargar(nf As Integer, nc As Integer, vi As Integer, r As Integer)
        Dim f1, c1, i As Integer
        Dim b As Boolean
        fi = nf : c = nc
        b = True
        For f1 = 1 To fi
            For c1 = 1 To c
                i = i + 1
                mx(f1, c1) = vi + (i - 1) * r
            Next
        Next
    End Sub
    Public Function descargar() As String
        Dim f1, c1 As Integer
        Dim s As String
        s = ""
        For f1 = 1 To fi
            For c1 = 1 To c
                s = s + Str(mx(f1, c1)) + Chr(9)
            Next
            s = s + Chr(13) + Chr(10)
        Next
        Return s
    End Function
    Public Sub cargarR(nf As Integer, nc As Integer, a As Integer, b As Integer)
        Dim f1, c1 As Integer
        fi = nf : c = nc
        For f1 = 1 To fi
            For c1 = 1 To c
                mx(f1, c1) = a + Rnd() * (b - a)
            Next
        Next
    End Sub
    Public Sub CargaManual(nf As Integer, nc As Integer)
        Dim f1, c1 As Integer
        Me.fi = nf
        Me.c = nc
        For f1 = 1 To fi
            For c1 = 1 To c
                mx(f1, c1) = InputBox("Ingresar valor")
            Next
        Next
    End Sub
    Public Function ejercicio1p1() As Double
        Dim restando = True
        Dim acum, numero As Double

        For f1 = fi To 1 Step -1
            For c1 = fi To 1 Step -1
                Dim num As nent = New nent()
                num.cargar(mx(f1, c1))
                If (num.verifpri()) Then
                    If (restando) Then
                        numero = num.descargar.ToString
                        acum = acum - (numero ^ (1 / 2))
                    Else
                        numero = num.descargar.ToString
                        acum = acum + (numero ^ (1 / 2))
                    End If
                    restando = Not restando
                End If
            Next
        Next
        Return acum
    End Function

End Class
