<%@ Page Title="ASasASasAS" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="EmpleadoList.aspx.vb" Inherits="cont.EmpleadoList" %>

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
                                      
                                          
                                       <telerik:RadGrid ID="rgEmpleado" runat="server" Width="100%"  AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" Skin="Metro" PageSize="30">
<GroupingSettings CollapseAllTooltip="Collapse all groups"></GroupingSettings>
                                           <MasterTableView>
                                               <Columns>
                                                   <telerik:GridBoundColumn DataField="EmpClave" FilterControlAltText="Filter EmpClave column" HeaderText="EmpClave" UniqueName="EmpClave">
                                                   </telerik:GridBoundColumn>
                                                   <telerik:GridBoundColumn DataField="DptClave" FilterControlAltText="Filter DptClave column" UniqueName="DptClave" HeaderText="DptClave">
                                                   </telerik:GridBoundColumn>
                                                   <telerik:GridBoundColumn DataField="EmpPaterno" FilterControlAltText="Filter EmpPaterno column" HeaderText="EmpPaterno" UniqueName="EmpPaterno">
                                                   </telerik:GridBoundColumn>
                                                   <telerik:GridBoundColumn DataField="EmpMaterno" FilterControlAltText="Filter EmpMaterno column" HeaderText="EmpMaterno" UniqueName="EmpMaterno">
                                                   </telerik:GridBoundColumn>
                                                   <telerik:GridBoundColumn DataField="EmpNombre" FilterControlAltText="Filter EmpNombre column" HeaderText="EmpNombre" UniqueName="EmpNombre">
                                                   </telerik:GridBoundColumn>
                                                 
                                                   <telerik:GridBoundColumn DataField="UserNombre" FilterControlAltText="Filter UserNombre column" HeaderText="UserNombre" UniqueName="UserNombre">
                                                   </telerik:GridBoundColumn>
                                                   <telerik:GridEditCommandColumn>
                                                   </telerik:GridEditCommandColumn>
                                               </Columns>

<EditFormSettings>
<EditColumn UniqueName="EditCommandColumn1" FilterControlAltText="Filter EditCommandColumn1 column"></EditColumn>
    <FormTemplate>
        <%--<table border="0">
                                        <tr>
                                            <td style="text-align: right">
                                                COLOR:</td>
                                            <td>
                                                <asp:TextBox ID="txtColor" runat="server" Text='<%# Eval("EmpPaterno") %>' 
                                                    TextMode="SingleLine"></asp:TextBox>
                                            </td>
                                        </tr>
                                       
                                        <tr>
                                            <td align="right" colspan="2">
                                                <asp:Button ID="Button2" runat="server" 
                                                    CommandName='<%# Iif (TypeOf Container is GridEditFormInsertItem, "PerformInsert", "Update") %>' 
                                                    Text='<%# Iif (TypeOf Container is GridEditFormInsertItem, "Insert", "Update") %>' />
                                                &nbsp;
                                                <asp:Button ID="btnCancel0" runat="server" CausesValidation="False" 
                                                    CommandName="Cancel" Text="Cancel" />
                                            </td>
                                        </tr>
                                    </table>--%>
    </FormTemplate>
</EditFormSettings>
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
