Imports MySql.Data.MySqlClient
Imports System.Web.Security


Imports Microsoft
Public Class login1


    Inherits System.Web.UI.Page

    Private _message As String
    Private _result As String

    'Private MysqlCommand As New MySqlCommand
    'Dim MysqlConnString As String = "server=proyecto; user id= admin ; password=patolink"
    'Public MysqlConexion As MySqlConnection = New MySqlConnection(MysqlConnString)


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try

            Dim ds As New DataSet

            ds = aLogin(Me.txtLogin.Text)

            If _result = "Y" Then

                Session("user") = Me.txtLogin.Text
                Response.Redirect("Menu.aspx")

            Else
                Panelmsg.BackColor = Drawing.Color.Gray
                Me.LbMensaje.Text = _message
                Me.LbMensaje.ForeColor = Drawing.Color.White

            End If


        Catch ex As Exception

        End Try
    End Sub




    Public Function aLogin(ByVal sID As String) As DataSet
        Dim oSqlConn As MySqlConnection = New MySqlConnection()

        oSqlConn.ConnectionString = ConfigurationManager.AppSettings("connectionString")

        Dim retorno As String = ""
        Try
            oSqlConn.Open()
            Dim Cmd As New MySqlCommand("spacceso", oSqlConn)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@in_clave", sID)
                .Parameters.Add("out_result", MySqlDbType.VarChar).Direction = ParameterDirection.Output
                .Parameters.Add("out_msg", MySqlDbType.VarChar).Direction = ParameterDirection.Output
                retorno = .ExecuteNonQuery

                _result = .Parameters("out_result").Value.ToString
                _message = .Parameters("out_msg").Value.ToString


                If oSqlConn.State = ConnectionState.Open Then
                    oSqlConn.Close()
                End If
            End With
        Catch ex As MySqlException
            Throw ex
        End Try
        'Return retorno
    End Function

    
End Class

