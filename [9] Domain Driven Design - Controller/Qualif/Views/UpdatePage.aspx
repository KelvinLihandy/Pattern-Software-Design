<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="Qualif.Views.UpdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="Header" runat="server"></h1>
        </div>

        <asp:Label ID="BookTitle" runat="server" Text="Book Title"></asp:Label>
        <asp:TextBox ID="BookTitleTB" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="Label1" runat="server" Text="Copies Available"></asp:Label>
        <asp:TextBox ID="CopiesAvailableTB" runat="server"></asp:TextBox>

        <br />
        <asp:Button ID="SubmitButton" runat="server" Text="Update" OnClick="SubmitButton_Click"/>
        <br />
        <asp:Label ID="Text_Error" runat="server" Text="" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
