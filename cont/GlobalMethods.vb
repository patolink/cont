Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace MySqlBackupWebSample
    Public Class GlobalMethods
        Public Shared Sub DeleteOldFile()
            Dim timeNow As String = DateTime.Now.AddMinutes(-15).ToString("yyyyMMddHHmmss")
            Dim iTimeNow As Long = Convert.ToInt64(timeNow)
            Dim oldFiles As String() = System.IO.Directory.GetFiles(HttpContext.Current.Server.MapPath("~/dumpfiles"))

            For Each s As String In oldFiles
                If Not s.EndsWith("sql") Then Continue For
                Dim file As String = System.IO.Path.GetFileNameWithoutExtension(s)
                file = file.Replace("-", String.Empty)
                Dim fileTime As Long = Convert.ToInt64(file)

                If fileTime < iTimeNow Then

                    Try
                        System.IO.File.Delete(s)
                    Catch
                    End Try
                End If
            Next
        End Sub

        Public Shared Function GetHtmlString(ByVal input As String) As String
            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()

            For Each c As Char In input

                Select Case c
                    Case "&"c
                        sb.AppendFormat("&amp;")
                    Case """"c
                        sb.AppendFormat("&quot;")
                    Case "'"c
                        sb.AppendFormat("&#39;")
                    Case "<"c
                        sb.AppendFormat("&lt;")
                    Case ">"c
                        sb.AppendFormat("&gt;")
                    Case Else
                        sb.Append(c)
                End Select
            Next

            Return sb.ToString()
        End Function
    End Class
End Namespace
