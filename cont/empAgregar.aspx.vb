Imports MySql.Data.MySqlClient

Public Class empAgregar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then


            LoadcomboboxDepto()
            LoadcomboboxInfonavit()
            LoadcomboboxAguinaldo()



        End If
    End Sub




    Private Sub LoadcomboboxDepto()
        Dim ds As New DataSet

        'Me.lbmensaje.Text = Session("mensaje")
        ds = Get_combobox_depto()
        Me.rcbDepto.DataSource = ds.Tables(0)
        Me.rcbDepto.DataValueField = "DptClave"
        Me.rcbDepto.DataTextField = "DptNombre"
        Me.rcbDepto.DataBind()
    End Sub


    Private Sub LoadcomboboxInfonavit()
        Dim ds As New DataSet

        'Me.lbmensaje.Text = Session("mensaje")
        ds = Get_combobox_info()
        Me.rcbInfonavit.DataSource = ds.Tables(0)
        Me.rcbInfonavit.DataValueField = "id"
        Me.rcbInfonavit.DataTextField = "valor"
        Me.rcbInfonavit.DataBind()
    End Sub


    Private Sub LoadcomboboxAguinaldo()
        Dim ds As New DataSet

        'Me.lbmensaje.Text = Session("mensaje")
        ds = Get_combobox_Aguinaldo()
        Me.rcbAguinaldo.DataSource = ds.Tables(0)
        Me.rcbAguinaldo.DataValueField = "id"
        Me.rcbAguinaldo.DataTextField = "valor"
        Me.rcbAguinaldo.DataBind()
    End Sub

    Public Function Get_combobox_depto() As DataSet
        Dim oSqlConn As MySqlConnection = New MySqlConnection()
        Dim da As MySqlDataAdapter
        Dim ds As DataSet

        oSqlConn.ConnectionString = ConfigurationManager.AppSettings("connectionString")

        Dim retorno As String = ""
        Try
            oSqlConn.Open()
            Dim Cmd As New MySqlCommand("spgetdepto", oSqlConn)
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

    Public Function Get_combobox_info() As DataSet
        Dim oSqlConn As MySqlConnection = New MySqlConnection()
        Dim da As MySqlDataAdapter
        Dim ds As DataSet

        oSqlConn.ConnectionString = ConfigurationManager.AppSettings("connectionString")

        Dim retorno As String = ""
        Try
            oSqlConn.Open()
            Dim Cmd As New MySqlCommand("spgetinfonavit", oSqlConn)
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

    Public Function Get_combobox_Aguinaldo() As DataSet
        Dim oSqlConn As MySqlConnection = New MySqlConnection()
        Dim da As MySqlDataAdapter
        Dim ds As DataSet

        oSqlConn.ConnectionString = ConfigurationManager.AppSettings("connectionString")

        Dim retorno As String = ""
        Try
            oSqlConn.Open()
            Dim Cmd As New MySqlCommand("spgetaguinaldo", oSqlConn)
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

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try









        Catch ex As Exception

        End Try
    End Sub
End Class