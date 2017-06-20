<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p style="height: 28px; margin-top: 0px"><a href="SignUp.aspx">Sign Up</a>  </p>  
            <asp:Panel ID="Panel2" runat="server" Height="163px" style="margin-left: 229px; margin-top: 146px" Width="482px">
            <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 62px; margin-top: 0px" Width="319px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 38px; margin-top: 11px" Width="322px" TextMode="Password"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" style="margin-left: 202px; margin-top: 32px" Text="Login" OnClick="login" />
    </asp:Panel>
    </div>
    </form>
</body>
</html>
