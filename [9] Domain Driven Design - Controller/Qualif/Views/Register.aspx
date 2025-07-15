<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Qualif.Views.Register" %>

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
            <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="EmailTB" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="PasswordTB" runat="server"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="ConfirmPasswordLabel" runat="server" Text="Confirm Password"></asp:Label>
            <br />
            <asp:TextBox ID="ConfirmPasswordTB" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"/>
            <br />
            <asp:Label ID="Text_Error" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
