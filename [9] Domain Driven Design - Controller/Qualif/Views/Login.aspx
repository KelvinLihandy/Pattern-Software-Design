<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Qualif.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="UsernameTB" runat="server"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="PasswordTB" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me" />
            <br />
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"/>
            <br />
            <asp:Label ID="Text_Error" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
            <a href="Register.aspx">Doesnt have account? Click here</a>
        </div>
    </form>
</body>
</html>
