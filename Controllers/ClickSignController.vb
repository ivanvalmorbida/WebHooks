Imports System.IO
Imports System.Web.Mvc

Namespace Controllers
    Public Class ClickSignController
        Inherits Controller

        ' GET: ClickSign
        Function Index() As ActionResult
            Try
                Dim req As Stream = Request.InputStream
                req.Seek(0, System.IO.SeekOrigin.Begin)
                Dim json As String = New StreamReader(req).ReadToEnd()
                Dim arquivoWS As StreamWriter
                arquivoWS = New StreamWriter("C:\Mielina2\clicksign\clicksign" & Now.Ticks & ".json", True)
                arquivoWS.WriteLine(json)
                arquivoWS.Close()
            Catch ex As Exception

            End Try

            Return New EmptyResult()
        End Function
    End Class
End Namespace