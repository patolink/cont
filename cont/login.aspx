<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="cont.login1" %>

<!DOCTYPE html>
<html lang="en">
    <head runat="server">
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="description" content="">
        <meta name="author" content="">

        <title>Login</title>

        <!-- Bootstrap Core CSS -->
        <link href="/css/bootstrap.min.css" rel="stylesheet">

        <!-- MetisMenu CSS -->
       <%-- <link href="/css/metisMenu.min.css" rel="stylesheet">--%>

        <!-- Custom CSS -->
      <%--  <link href="/css/startmin.css" rel="stylesheet">--%>

        <!-- Custom Fonts -->
       <%-- <link href="/css/font-awesome.min.css" rel="stylesheet" type="text/css">--%>

        <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
        <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
        <![endif]-->
    </head>
    <body>
         <form id="form1" runat="server">

        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <div class="login-panel panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Please Sign In</h3>
                        </div>
                        <div class="panel-body">
                          
                                <fieldset>
                                    <div class="form-group">
                                       <%-- <input class="form-control" placeholder="E-mail" name="email" type="email" autofocus>--%>
                                    <asp:TextBox ID="txtLogin" class="form-control" runat="server"></asp:TextBox></div>
                                    <div class="form-group">
                                        <asp:Label ID="lbmessage" class="alert alert-danger"  runat="server"></asp:Label> </div>
                                    <div class="checkbox">
                                        <label>
                                            <input name="remember" type="checkbox" value="Remember Me">Remember Me
                                        </label>
                                    </div>
                                    <!-- Change this to a button or input when using this as a form -->
                                 <%--   <a href="index.html" class="btn btn-lg btn-success btn-block">Login</a>--%>
                                <asp:Button ID="btnLogin" runat="server" class="btn btn-lg btn-success btn-block" Text="Login"  /></fieldset>
                            <%--  <asp:Panel ID="Panelmsg" runat="server" Height="50px" HorizontalAlign="Center">
                            <asp:Label ID="LbMensaje" runat="server" Font-Bold="True" Font-Size="20px"></asp:Label>
                        </asp:Panel>--%>
                              <%--    <div class="alert alert-danger">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href="#" class="alert-link">Alert Link</a>.
                                </div>
                                <asp:Label ID="lbmessage" class="alert alert-danger" runat="server"></asp:Label>--%>
                               <%-- <div class="alert alert-danger">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href="#" class="alert-link">Alert Link</a>.
                                </div>--%>
                            
                              
                        </div>
                      
                    </div>
                 </div>
            </div>
                  
              
        </div>

        <!-- jQuery -->
        <script src="../js/jquery.min.js"></script>

        <!-- Bootstrap Core JavaScript -->
        <script src="../js/bootstrap.min.js"></script>

        <!-- Metis Menu Plugin JavaScript -->
        <script src="../js/metisMenu.min.js"></script>

        <!-- Custom Theme JavaScript -->
        <script src="../js/startmin.js"></script>
        </form>
    </body>
</html>

