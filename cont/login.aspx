<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="cont.login1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Login</title>
      <!-- Bootstrap -->
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
    <link href="bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet" media="screen"/>
    <link href="assets/styles.css" rel="stylesheet" media="screen"/>
     <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
    <script src="js/vendor/modernizr-2.6.2-respond-1.1.0.min.js"></script>
</head>
 <body id="login">
    <div class="container">
    <form id="form1" class="form-signin" runat="server">
        <h2 class="form-signin-heading">Inicio de Sesion</h2>
<asp:TextBox ID="txtLogin" class="input-block-level" runat="server"></asp:TextBox>
       <asp:Panel ID="Panelmsg" runat="server" Height="50px" HorizontalAlign="Center">
                            <asp:Label ID="LbMensaje" runat="server" Font-Bold="True" Font-Size="12px"></asp:Label>
                        </asp:Panel>
        <label class="checkbox">
          <input type="checkbox" value="remember-me"> Recordar
        </label>
       
        <asp:Button ID="btnLogin" class="btn btn-large btn-primary" runat="server" Text="Entrar" />
    </form>
        
    </div> <!-- /container -->
    <script src="vendors/jquery-1.9.1.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
  </body>

</html>
