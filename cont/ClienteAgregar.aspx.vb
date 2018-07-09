Imports MySql.Data.MySqlClient
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.IO
Imports System.Web.UI
Imports System.Web.UI.WebControls



Public Class ClienteAgregar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try










        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btBackup_Click(sender As Object, e As EventArgs)
        lbMsg.Text = ""
        Session("connectionstring") = "server=127.0.0.1;user=admin;password=patolink;database=Proyecto;"
        Session("sCliente") = txtCliente.Text

        If Not TestConnection() Then
            Return
        End If

        Response.Redirect("~/Backup.aspx", True)
    End Sub

    Private Function TestConnection() As Boolean
        Try
            Dim conn As MySqlConnection = New MySqlConnection("server=127.0.0.1;user=admin;password=patolink;database=Proyecto;")
            conn.Open()
            conn.Close()
            Return True
        Catch ex As Exception
            lbMsg.Text = ex.Message
            Return False
        End Try
    End Function

End Class