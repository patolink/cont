Imports MySql.Data.MySqlClient

Public Class empAgregar
    Inherits System.Web.UI.Page

    Public _IsValid As Boolean
    Public _Message As String
    Public _result As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then


            LoadcomboboxDepto()
            LoadcomboboxInfonavit()
            LoadcomboboxAguinaldo()
            LoadcomboboxBanco()



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

    Private Sub LoadcomboboxBanco()
        Dim ds As New DataSet

        'Me.lbmensaje.Text = Session("mensaje")
        ds = Get_combobox_Banco()
        Me.txtBanco.DataSource = ds.Tables(0)
        Me.txtBanco.DataValueField = "bcoClave"
        Me.txtBanco.DataTextField = "BcoNombre"
        Me.txtBanco.DataBind()
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


    Public Function Get_combobox_Banco() As DataSet
        Dim oSqlConn As MySqlConnection = New MySqlConnection()
        Dim da As MySqlDataAdapter
        Dim ds As DataSet

        oSqlConn.ConnectionString = ConfigurationManager.AppSettings("connectionString")

        Dim retorno As String = ""
        Try
            oSqlConn.Open()
            Dim Cmd As New MySqlCommand("spgetBanco", oSqlConn)
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

            Dim ds As New DataSet
            ' Dim objEmp As New ClsEmp
            Dim sNombreCompleto As String
            sNombreCompleto = Me.txtPaterno.Text.ToUpper.Trim.ToString + " " + Me.txtMaterno.Text.ToUpper.Trim.ToString + " " + txtNombre.Text.ToUpper.Trim.ToString

            ds = Emp_valid(sNombreCompleto)


            If _result = "Y" Then
                MsgBox(_Message.ToString)

                Exit Sub
            Else

                Dim myDate As String = txtNacimiento.SelectedDate
                Dim dateValue As DateTime = DateTime.Parse(myDate)
                Dim format As String = "yyyy-MM-dd"
                Dim dateNac As String = dateValue.ToString(format)

                Dim cDeclara As Integer = Convert.ToInt32(chkDeclara.Checked)
                Dim cAsimilada As Integer = Convert.ToInt32(chkasimilado.Checked)
                Dim cSindicalizado As Integer = Convert.ToInt32(chkSindicaliado.Checked)






                Emp_add(rcbDepto.SelectedItem.Value, txtPaterno.Text, txtMaterno.Text, txtNombre.Text, sNombreCompleto.ToUpper, txtCalle.Text, txtnoExterior.Text, txtnoInterior.Text, txtdireccion.Text,
                        txtColonia.Text, txtLocalidad.Text, txtreferencia.Text, txtMunicipio.Text, txtEstado.Text, txtPais.Text, txtCP.Text, txttelefono1.Text, txttelefono2.Text, txtemail.Text, rxrRFC.Text, txtIMSS.Text, txtCurp.Text,
dateNac, rcbInfonavit.SelectedItem.Text, txtInfoNum.Text, rcbAguinaldo.SelectedItem.Text, txtAguinaldoNum.Text, txtSalario.Text, txtIndice.Text, txtIntegrado.Text, rcbSexo.SelectedItem.Value, txtBanco.SelectedItem.Value, txtSatRegi.Text, txtSatContrato.Text, txtSatJornada.Text, txtOcupacion.Text, cDeclara, cAsimilada, cSindicalizado, Session("nombre").ToString)




            End If




        Catch ex As Exception

        End Try
    End Sub


    Public Function Emp_valid(ByVal emp As String) As DataSet
        Dim oSqlConn As MySqlConnection = New MySqlConnection()

        oSqlConn.ConnectionString = ConfigurationManager.AppSettings("connectionString")

        Dim retorno As String = ""
        Try
            oSqlConn.Open()
            Dim Cmd As New MySqlCommand("spvalidaemp", oSqlConn)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@in_emp_name", emp)
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


    Public Function Emp_add(ByVal Depto As Integer, ByVal Paterno As String, ByVal Materno As String, ByVal Nombre As String, ByVal Name As String, ByVal Calle As String, ByVal noExterior As String, ByVal noInterior As String, ByVal direccion As String, ByVal Colonia As String, ByVal Localidad As String, ByVal referencia As String, ByVal Municipio As String, ByVal Estado As String, ByVal Pais As String, ByVal CP As String, ByVal TEL1 As String, ByVal TEL2 As String, ByVal MAIL As String, ByVal RFC As String, ByVal IMSS As String, ByVal CURP As String, ByVal NACIMIENTO As String, ByVal INFONAVIT As String, ByVal INFONAVITNUM As Integer, ByVal AGUINALDO As String, ByVal AGUINALDONUM As String, ByVal SALARIO As String, ByVal INDICE As String, ByVal INTEGRADO As String, ByVal SEXO As String, ByVal BANCO As Integer, ByVal SATREGI As String, ByVal SATCONTRATO As String, ByVal SATJORNADA As String, ByVal OCUPACION As String, ByVal DECLARA As Integer, ByVal ASIMILADO As Integer, ByVal SINDICALIZADO As Integer, ByVal USUARIO As String) As DataSet
        Dim oSqlConn As MySqlConnection = New MySqlConnection()

        oSqlConn.ConnectionString = ConfigurationManager.AppSettings("connectionString")

        Dim retorno As String = ""
        Try
            oSqlConn.Open()
            Dim Cmd As New MySqlCommand("spEmpAgregar", oSqlConn)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@in_depto", Depto)
                .Parameters.AddWithValue("@in_Paterno", Paterno)
                .Parameters.AddWithValue("@in_Materno", Materno)
                .Parameters.AddWithValue("@in_Nombre", Nombre)
                .Parameters.AddWithValue("@in_name", Name)
                .Parameters.AddWithValue("@in_Calle", Calle)
                .Parameters.AddWithValue("@in_noExterior", noExterior)
                .Parameters.AddWithValue("@in_noInterior", noInterior)
                .Parameters.AddWithValue("@in_direccion", direccion)
                .Parameters.AddWithValue("@in_Colonia", Colonia)
                .Parameters.AddWithValue("@in_Localidad", Localidad)
                .Parameters.AddWithValue("@in_referencia", referencia)
                .Parameters.AddWithValue("@in_Municipio", Municipio)
                .Parameters.AddWithValue("@in_Estado", Estado)
                .Parameters.AddWithValue("@in_Pais", Pais)
                .Parameters.AddWithValue("@in_CP", CP)
                .Parameters.AddWithValue("@in_tel1", TEL1)
                .Parameters.AddWithValue("@in_tel2", TEL2)
                .Parameters.AddWithValue("@in_email", MAIL)
                .Parameters.AddWithValue("@in_RFC", RFC)
                .Parameters.AddWithValue("@in_IMSS", IMSS)
                .Parameters.AddWithValue("@in_CURP", CURP)
                .Parameters.AddWithValue("@in_NACIMIENTO", NACIMIENTO)
                .Parameters.AddWithValue("@in_INFONAVIT", INFONAVIT)
                .Parameters.AddWithValue("@in_INFONAVIT_num", INFONAVITNUM)
                .Parameters.AddWithValue("@in_AGUINALDO", AGUINALDO)
                .Parameters.AddWithValue("@in_AGUINALDO_num", AGUINALDONUM)
                .Parameters.AddWithValue("@in_SALARIO", SALARIO)
                .Parameters.AddWithValue("@in_INDICE", INDICE)
                .Parameters.AddWithValue("@in_INTEGRADO", INTEGRADO)
                .Parameters.AddWithValue("@in_SEXO", SEXO)
                .Parameters.AddWithValue("@in_BANCO", BANCO)
                .Parameters.AddWithValue("@in_SATREGI", SATREGI)
                .Parameters.AddWithValue("@in_SATCONTRATO", SATCONTRATO)
                .Parameters.AddWithValue("@in_SATJORNADA", SATJORNADA)
                .Parameters.AddWithValue("@in_OCUPACION", OCUPACION)
                .Parameters.AddWithValue("@in_DECLARA", DECLARA)
                .Parameters.AddWithValue("@in_ASIMILADO", ASIMILADO)
                .Parameters.AddWithValue("@in_SINDICALIZADO", SINDICALIZADO)
                .Parameters.AddWithValue("@in_UserNombre", USUARIO)
                '.Parameters.Add("out_result", MySqlDbType.VarChar).Direction = ParameterDirection.Output
                '.Parameters.Add("out_msg", MySqlDbType.VarChar).Direction = ParameterDirection.Output
                retorno = .ExecuteNonQuery

                '_result = .Parameters("out_result").Value.ToString
                '_Message = .Parameters("out_msg").Value.ToString


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