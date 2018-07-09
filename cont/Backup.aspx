﻿<%@ <%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Backup.aspx.vb" Inherits="MySqlBackupWebSample.Backup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>MySqlBackup.NET</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="refresh" content="1; url=BackupRun.aspx" />
</head>
<body>
    <form id="Form1" runat="server">
    <div class="page">
        <div class="header">
            <div class="title">
                <h1>
                    Demo (Basic Implementation) of Using MySqlBackup With ASP.NET C#</h1>
            </div>
            
            <div class="clear hideSkiplink">
                <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home"/>
                        <asp:MenuItem NavigateUrl="~/dumpfiles/Default.aspx" Text="Dump Files" 
                            Value="Dump Files"/>
                    </Items>
                </asp:Menu>
            </div>
        </div>
        <div class="main">

            <h2>
                Backup in progress...</h2>
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/progressbar.gif" />

        </div>
        <div class="clear">
        </div>
    </div>
    <div class="footer">
        
    </div>
    </form>
</body>
</html>
