<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 445px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="Panel2" runat="server" Height="279px" style="margin-left: 229px; margin-top: 146px" Width="482px">
            <asp:Label ID="Label3" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 69px; margin-top: 0px" Width="319px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 55px; margin-top: 11px" Width="322px" TextMode="Password"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="E-mail:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 71px; margin-top: 12px" Width="323px"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="CC Number:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 34px; margin-top: 18px" Width="320px"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="Valid Thru:"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 40px; margin-top: 8px" Width="318px"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" style="margin-left: 186px; margin-top: 19px" Text="Sign Up" OnClick="signUp" />
        </asp:Panel>
    </form>
</body>
</html>
