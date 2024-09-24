Imports System.IO
Imports Newtonsoft.Json
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing

Namespace Controllers
    Public Class ZapLeadController
        Inherits Controller

        ' GET: ZapLead
        Function Index() As ActionResult
            Try
                Dim req As Stream = Request.InputStream
                req.Seek(0, System.IO.SeekOrigin.Begin)
                Dim json As String = New StreamReader(req).ReadToEnd()
                Dim arquivoWS As StreamWriter
                arquivoWS = New StreamWriter("\\172.16.171.251\c$\Mielina2\zap\zap" & Now.Ticks & ".txt", True)
                arquivoWS.WriteLine(json)
                arquivoWS.Close()
            Catch ex As Exception

            End Try

            Return New EmptyResult()
        End Function
    End Class
End Namespace