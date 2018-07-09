Imports MySql.Data.MySqlClient

Public Class EmpresaRep
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            LoadgridEmpresa()


            Page.Title = "hola hola"

        End If
    End Sub

    Private Sub LoadgridEmpresa()
        Dim ds As New DataSet
        ds = Get_grid_empresa()
        Me.rgEmpresa.DataSource = ds.Tables(0)
    End Sub


    Public Function Get_grid_empresa() As DataSet
        Dim oSqlConn As MySqlConnection = New MySqlConnection()
        Dim da As MySqlDataAdapter
        Dim ds As DataSet

        oSqlConn.ConnectionString = ConfigurationManager.AppSettings("connectionString")

        Dim retorno As String = ""
        Try
            oSqlConn.Open()
            Dim Cmd As New MySqlCommand("spgecompanias", oSqlConn)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                retorno = .ExecuteNonQuery

                da = New MySqlDataAdapter(Cmd)
                ds = New DataSet()
                da.Fill(ds)

                '_result = .Parameters("out_result").Value.ToString
                '_message = .Parameters("out_msg").Value.ToString


                If oSqlConn.State = ConnectionState.Open Then
                    oSqlConn.Close()
                End If
            End With
        Catch ex As MySqlException
            Throw ex
        End Try
        Return ds
    End Function


End Class