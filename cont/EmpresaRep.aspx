<%@ Page Title="ASasASasAS" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="EmpresaRep.aspx.vb" Inherits="cont.EmpresaRep" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
                    <div class="col-lg-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Empresas Detalle
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-lg-6">
                                      
                                          
                                       <telerik:RadGrid ID="rgEmpresa" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" Skin="Metro">
<GroupingSettings CollapseAllTooltip="Collapse all groups"></GroupingSettings>
                                           <MasterTableView>
                                               <Columns>
                                                   <telerik:GridBoundColumn DataField="CiaNombre" FilterControlAltText="Filter CiaNombre column" HeaderText="Nombre Compañia" UniqueName="CiaNombre">
                                                   </telerik:GridBoundColumn>
                                                   <telerik:GridBoundColumn DataField="CiaRepLegal" FilterControlAltText="Filter CiaRepLegal column" UniqueName="CiaRepLegal">
                                                   </telerik:GridBoundColumn>
                                                   <telerik:GridEditCommandColumn HeaderText="Ver detalle">
                                                   </telerik:GridEditCommandColumn>
                                               </Columns>
                                           </MasterTableView>
                                        </telerik:RadGrid>   
                                        
                                    </div>
                        </div> 
                                    <!-- /.col-lg-6 (nested) -->
                                    
                                    <!-- /.col-lg-6 (nested) -->
                                </div>
                                <!-- /.row (nested) -->
                           </div>
                        
</asp:Content>
