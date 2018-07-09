Imports System.Web.UI.WebControls
Imports System.Web.UI
Imports System.Web
Imports System.Linq
Imports System.Collections.Generic
Imports System

Namespace MySqlBackupWebSample
    Partial Public Class Backup
        Inherits System.Web.UI.Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            If Session("connectionstring") Is Nothing Then
                Response.Redirect("~/Default.aspx")
            End If
        End Sub
    End Class
End Namespace