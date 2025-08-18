Imports System.Data.SqlClient
Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json.Linq

Public Class ValuesController
    Inherits ApiController

    ' GET api/values
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/values/5
    Public Function GetValue(ByVal id As Integer) As String
        Dim arr2(), strKey As String, coll As NameValueCollection

        coll = HttpContext.Current.Request.Headers
        arr2 = coll.GetValues("key636")
        strKey = arr2(0)

        If strKey = "ivanluis" Then
            Return "value"
        Else
            Return ""
        End If
    End Function

    ' POST api/values
    Public Sub PostValue(<FromBody()> ByVal value As cxxx)
        Console.WriteLine(value.nome)
    End Sub

    ' PUT api/values/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As cxxx)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub

    Public Class cxxx
        Public Property id As Integer
        Public Property nome As String
    End Class
End Class
