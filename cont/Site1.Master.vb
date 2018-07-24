Imports MySql.Data.MySqlClient

Public Class Site1
    Inherits System.Web.UI.MasterPage

    Private _message As String
    Private _result As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Session("user") = Nothing Then


                Response.Redirect("login.aspx")


            End If

            aLoginName(Session("user"))
            lbuser.Text = _result.ToString
            Session("nombre") = _result.ToString

        Else



        End If
    End Sub
    Public Function aLoginName(ByVal sID As String) As DataSet
        Dim oSqlConn As MySqlConnection = New MySqlConnection()

        oSqlConn.ConnectionString = ConfigurationManager.AppSettings("connectionString")

        Dim retorno As String = ""
        Try
            oSqlConn.Open()
            Dim Cmd As New MySqlCommand("spUsuarioName", oSqlConn)
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