<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="cont.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="row">
                    <div class="col-lg-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Crear empresa
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-lg-6">
                                      
                                        
                                                <asp:Button ID="btBackup" runat="server" onclick="btBackup_Click" 
                Text="Backup a MySQL Database" style="height: 26px" />
            
                                                <br />
                                                <br />
            
                                          <asp:Label ID="lbMsg" runat="server" ForeColor="Red"></asp:Label>
                                                <br />
                                                <br />
                                                <asp:TextBox ID="txtCliente" runat="server"></asp:TextBox>
                                    </div>
                        </div> 
                                    <!-- /.col-lg-6 (nested) -->
                                    
                                    <!-- /.col-lg-6 (nested) -->
                                </div>
                                <!-- /.row (nested) -->
                           </div>
                        </div> 
    </form>
</body>
</html>
