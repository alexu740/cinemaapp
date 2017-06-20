<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FilmFrameWork.aspx.cs" Inherits="WebApplication1.FilmFrameWork" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 0px;
            height: 1px;
            margin-left: 0px;
        }
    </style>
</head>
<body style="width: 1056px; height: 675px; margin-left: 12px">
    <p><% WebApplication1.Login1.getUser(); %></p>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="152px" style="margin-left: 345px; margin-top: 95px" Width="392px">
            <asp:Button ID="Button1" runat="server" Text="1" Height="50px" style="margin-left: 0px" Width="50px"  OnClick="saveSeat" />
            <asp:Button ID="Button2" runat="server" Height="50px" Text="2" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button3" runat="server" Height="50px" Text="3" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button4" runat="server" Height="50px" Text="4" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button5" runat="server" Height="50px" Text="5" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button6" runat="server" Height="50px" Text="6" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button7" runat="server" Height="50px" Text="7" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button8" runat="server" Height="50px" Text="8" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button9" runat="server" Height="50px" style="margin-top: 0px" Text="9" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button10" runat="server" Height="50px" Text="10" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button11" runat="server" Height="50px" Text="11" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button12" runat="server" Height="50px" Text="12" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button13" runat="server" Height="50px" Text="13" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button14" runat="server" Height="50px" Text="14" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button15" runat="server" Height="50px" style="margin-right: 0px" Text="15" Width="50px" OnClick="saveSeat" />
            <asp:Button ID="Button16" runat="server" Height="50px" Text="16" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button17" runat="server" Height="50px" Text="17" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button18" runat="server" Height="50px" style="margin-right: 0px" Text="18" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button19" runat="server" Height="50px" Text="19" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button20" runat="server" Height="50px" Text="20" Width="50px" OnClick="saveSeat"/>
            <asp:Button ID="Button21" runat="server" Height="50px" Text="21" Width="50px" OnClick="saveSeat"/>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Height="154px" style="margin-left: 272px; margin-right: 31px; margin-top: 43px" Width="577px">
            <asp:Label ID="Label2" runat="server" Text="CC Number:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="30px" style="margin-left: 50px; margin-top: 1px" Width="389px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Expires:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Height="30px" style="margin-left: 79px; margin-top: 13px;" Width="200px"></asp:TextBox>
            <asp:Button ID="Button22" runat="server" Height="36px" style="margin-left: 299px; margin-top: 32px" Text="Pay" Width="70px" OnClick="checkValidity" />
            <p style="height: 35px; width: 112px; margin-left: 274px; margin-top: 26px">or <a href="Login.aspx">Login</a></p>
            
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server">
                <asp:Button ID="Button23" runat="server" style="margin-left: 247px" Text="Pay" OnClick="payLogged" />
            </asp:Panel>
    
    
    </form>
        
    </body>
</html>
