<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="EmpresaAgregar.aspx.vb" Inherits="cont.EmpresaAgregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
     <div class="row">
                    <div class="col-lg-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Crear Empresa
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-lg-6">
                                       <%-- <form role="form">--%>
                                            <div class="form-group">
                                                <label>NOMBRE:</label>
                                                 <div class="form-group">
                                                <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                         
                                            </div>
                                            <div class="form-group">
                                                <label>FISCAL:</label>
                                                <div class="form-group">
                                                <asp:TextBox ID="txtPaterno" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                            <div class="form-group">
                                                <label>REP LEGAL:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtMaterno" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                          
                                            <div class="form-group">
                                                <label>No EXT:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtNoExt" Width="100px"  class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>NO INTERIOR:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtCalle" Width="100px"  class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>COLONIA:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtnoExterior" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>LOCALIDAD:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtColonia" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>REFERENCIA:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtLocalidad" class="form-control" runat="server"></asp:TextBox>
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
                                                <label>R.F.C:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="rxrRFC" Width="500px"  class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>I.M.S.S:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtIMSS" Width="500px" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>REGIMEN:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtCurp" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                         <div class="form-group">
                                                <label>EMAIL:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtNacimiento" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                            
                                              
                                         <div class="form-group">
                                                <label>GIRO:</label>
                                                  <div class="form-group">
  <asp:TextBox ID="txtGiro" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                            
                                             
                                         <div class="form-group">
                                                <label>CLABE:</label>
                                                  <div class="form-group">
                                             <asp:TextBox ID="txtClabe" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                                            
                                               
                                         <div class="form-group">
                                                <label>BANCO SAT:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtSalario" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>

                               <div class="form-group">
                                                <label>RIESGO SAT:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtIndice" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                             <div class="form-group">
                                                <label>NIVELES:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtIntegrado" Width="200px" class="form-control" runat="server"></asp:TextBox>
                                                      <label>AÑO Y MES:</label>
                                                      <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
                                                      <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                             <div class="form-group">
                                                <label>SEXO:</label>
                                                  <div class="form-group">

                                                        <telerik:radcombobox ID="rcbSexo" class="form-control" runat="server">
                                                            <Items>
                                                                <telerik:radcomboboxitem runat="server" Text="M" Value="M" />
                                                                <telerik:radcomboboxitem runat="server" Text="F" Value="F" />
                                                            </Items>
                                                        </telerik:radcombobox>
                                                    </div> 
                                            </div>

                             <div class="form-group">
                                                <label>BANCO:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="txtBanco" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                             <div class="form-group">
                                                <label>SAT REGIMEN:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="TextBox23" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                             <div class="form-group">
                                                <label>SAT CONTRATO:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="TextBox24" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>

                             <div class="form-group">
                                                <label>SAT JORNADA:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="TextBox25" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
                             <div class="form-group">
                                                <label>OCUPACION:</label>
                                                  <div class="form-group">
                                                <asp:TextBox ID="TextBox26" class="form-control" runat="server"></asp:TextBox>
                                                    </div> 
                                            </div>
<asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Agregar" />
                                        <asp:Button ID="btnReset" class="btn btn-default" runat="server" Text="Borrar" />
                                          
                                          
                                        
                                    </div>
                        </div> 
                                    <!-- /.col-lg-6 (nested) -->
                                    
                                    <!-- /.col-lg-6 (nested) -->
                                </div>
                                <!-- /.row (nested) -->
                           </div> 
</asp:Content>
