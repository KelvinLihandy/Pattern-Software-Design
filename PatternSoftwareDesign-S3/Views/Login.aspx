<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PatternSoftwareDesign_S3.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Login</h1>
    </div>
    <div>
        <asp:Label Text="Username:" runat="server" />
        <input id="usernameBox" type="text" runat="server" placeholder="Enter username" />
    </div>
    <div>
        <asp:Label Text="Password:" runat="server" />
        <input id="passwordBox" type="password" runat="server" placeholder="Enter password" />
    </div>
    <div>
        <asp:CheckBox ID="rememberMe" runat="server" Text="Remember Me" />
    </div>
    <div style="color: red;">
        <asp:Label Text="" runat="server" ID="error" />
    </div>
    <div>
        <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click"/>
    </div>
</form>
</body>
</html>
