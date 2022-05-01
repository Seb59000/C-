<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageArtiste.aspx.cs" Inherits="MusicForFreedom.PageArtiste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Retourner au Classement" Width="100%" />
        <%--<asp:Button ID="Button2" runat="server" Text="Faire un don" />--%>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <%--<iframe id="frame1" scrolling="auto" runat="server"></iframe>--%>
<iframe id="frame1"   width="100%" runat="server" height="1024px" >
  <p>Your browser does not support iframes.</p>
</iframe>
      
    </form>
</body>
</html>
