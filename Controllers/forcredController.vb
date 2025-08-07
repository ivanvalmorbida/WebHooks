Imports System.IO

Namespace Controllers
    Public Class forcredController
        Inherits Controller

        ' GET: forcred
        Function Index() As ActionResult
            Try
                Dim req As Stream = Request.InputStream
                req.Seek(0, System.IO.SeekOrigin.Begin)
                Dim json As String = New StreamReader(req).ReadToEnd()
                Dim arquivoWS As StreamWriter
                arquivoWS = New StreamWriter("\\172.16.171.248\Mielina2\forcred\forcred" & Now.Ticks & ".txt", True)
                arquivoWS.WriteLine(json)
                arquivoWS.Close()
            Catch ex As Exception

            End Try

            Return New EmptyResult()
        End Function
    End Class
End Namespace