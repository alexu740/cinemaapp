<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Label ID="user" runat="server" Text="" />
    <br />
    <br />

    <form id="form1" runat="server">
    <div>
  
    </div>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource2" DataKeyField="Id">
            <ItemTemplate>
                Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                movie:
                <asp:Label ID="movieLabel" runat="server" Text='<%# Eval("movie") %>' />
                <br />
                time:
                <asp:Label ID="timeLabel" runat="server" Text='<%# Eval("time") %>' />
                <br />
                description:
                <asp:Label ID="descriptionLabel" runat="server" Text='<%# Eval("description") %>' />
                <br />
                <br />
                <asp:Button CommandArgument='<%# Eval("Id") %>' text="Check Free Seats" runat="server" OnClick="buttonClick" />
            </ItemTemplate>
        </asp:DataList>
         
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Assignment;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Id], [movie], [time], [description] FROM [film]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT [Id], [movie], [description], [time] FROM [film]" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
    </form>
</body>
</html>
