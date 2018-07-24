<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="empAgregar.aspx.vb" Inherits="cont.empAgregar" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="row">
                    <div class="col-lg-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Agregar Usuario
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-lg-6">
                                       <%-- <form role="form">--%>
                                            <div class="form-group">
                                                <label>DEPTO:</label>

                                  


                                                  <div class="form-group">  
                                                  <asp:DropDownList ID="rcbDepto" class="form-control" runat="server"></asp:DropDownList>
</div> </div>

                                         
                                          

                                            <div class="form-group">
                                                <label>PATERNO:</label>
                                                <div class="form-group">
                                                <asp:TextBox ID="txtPaterno" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                            <div class="form-group">
                                                <label>MATERNO:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtMaterno" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                          
                                            <div class="form-group">
                                                <label>NOMBRE:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>CALLE:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtCalle" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>NO EXTERIOR:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtnoExterior" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>NO INTERIOR:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtnoInterior" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>DIRECCION:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtdireccion" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>COLONIA:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtColonia" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>LOCALIDAD:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtLocalidad" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                        <div class="form-group">
                                                <label>REFERENCIA:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtreferencia" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>MUNICIPIO:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtMunicipio" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>ESTADO:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtEstado" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>PAIS:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtPais" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>C.P:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtCP" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>

                                         <div class="form-group">
                                                <label>TELEFONO 1:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txttelefono1" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                             <label>TELEFONO 1:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txttelefono2" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>E-MAIL:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtemail" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>R.F.C:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="rxrRFC" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>I.M.S.S:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtIMSS" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>C.U.R.P:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtCurp" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>NACIMIENTO:</label>
                                                  <div class="form-group">

<telerik:RadDatePicker ID="txtNacimiento" class="form-control"  DateInput-DateInput-DisplayDateFormat="yyyy-dd-MM" DateInput-DateFormat="yyyy-dd-MM"  runat="server" MinDate="1900-01-01">
  
</telerik:RadDatePicker>
                                               
                                                    </div> 
                                            </div>
                                            
                                              
                                         <div class="form-group">
                                                <label>INFONAVIT:</label>
                                                  <div class="form-group">
                                                       <asp:DropDownList ID="rcbInfonavit" class="form-control" Width="100px" runat="server"></asp:DropDownList>

<asp:TextBox ID="txtInfoNum" class="form-control" Width="60px" runat="server"></asp:TextBox>
                                               
                                                    </div> 
                                            </div>
                                            
                                             
                                         <div class="form-group">
                                                <label>AGUINALDO:</label>
                                                  <div class="form-group">
                                                        <asp:DropDownList ID="rcbAguinaldo" class="form-control" Width="100px" runat="server"></asp:DropDownList>
                                             <asp:TextBox ID="txtAguinaldoNum" class="form-control" Width="60px" runat="server"></asp:TextBox>
                                                  </div> 
                                            </div>
                                            
                                               
                                         <div class="form-group">
                                                <label>SALARIO:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtSalario" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>

                               <div class="form-group">
                                                <label>INDICE INT:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtIndice" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                             <div class="form-group">
                                                <label>INTEGRADO:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtIntegrado" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                             <div class="form-group">
                                                <label>SEXO:</label>
                                                  <div class="form-group">
                                                      <asp:DropDownList ID="rcbSexo" class="form-control" runat="server">
                                                          <asp:ListItem>MAS</asp:ListItem>
                                                          <asp:ListItem>FEM</asp:ListItem>
                                                      </asp:DropDownList>
                                                     
                                                      
                                                   
                                                    </div> 
                                            </div>

                             <div class="form-group">
                                                <label>BANCO:</label>
                                                  <div class="form-group">

                                                        <asp:DropDownList ID="txtBanco" class="form-control" runat="server"></asp:DropDownList>

                                                <%--<asp:TextBox ID="txtBanco" class="form-control" runat="server"></asp:TextBox>--%>
                                                    </div> 
                                            </div>
                             <div class="form-group">
                                                <label>SAT REGIMEN:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtSatRegi" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                             <div class="form-group">
                                                <label>SAT CONTRATO:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtSatContrato" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>

                             <div class="form-group">
                                                <label>SAT JORNADA:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtSatJornada" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                             <div class="form-group">
                                                <label>OCUPACION:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtOcupacion" class="form-control" runat="server" Width="131px"></asp:TextBox>
                                                    </div> 
                                            </div>

                                           <div class="form-group">
                                              
                                                  <asp:CheckBox ID="chkDeclara" class="form-control"  runat="server" Text=" NO DECLARA?" />
                                                 <asp:CheckBox ID="chkasimilado" class="form-control"  runat="server" Text=" A SIMILADO?" />
                                               <asp:CheckBox ID="chkSindicaliado" class="form-control"  runat="server" Text=" SINDICALIZADO?" />
                                            </div>

<asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="SAVE" />
                                        <asp:Button ID="btnReset" class="btn btn-default" runat="server" Text="Borrar" />
                                          
                                          
                                        
                                    </div>
                        </div> 
                                    <!-- /.col-lg-6 (nested) -->
                                    
                                    <!-- /.col-lg-6 (nested) -->
                                </div>
                                <!-- /.row (nested) -->
                           </div> 
</asp:Content>
