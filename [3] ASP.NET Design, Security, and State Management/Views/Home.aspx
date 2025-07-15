<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PatternSoftwareDesign_S3.Views.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="Name" runat="server" ID="name" />
    </div>
    <div id="ListUserContainer" runat="server">
        <h1>List Users</h1>
        <asp:ListBox ID="listUser" runat="server" Height="300px"></asp:ListBox>
    </div>
    <div>
        <asp:Label Text="0 User(s) Online." runat="server" ID="userLoggedinCount" />
    </div>
    <div>
        <asp:Button ID="logoutButton" runat="server" Text="Logout" OnClick="logoutButton_Click"/>
    </div>
</form>
</body>
</html>
