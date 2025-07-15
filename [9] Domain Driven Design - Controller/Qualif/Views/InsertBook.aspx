<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertBook.aspx.cs" Inherits="Qualif.Views.InsertBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <div>
            <asp:Label ID="Label1" runat="server" Text="Book Title"></asp:Label>
            <asp:TextBox ID="BookTitle" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label2" runat="server" Text="Copies Available"></asp:Label>
            <asp:TextBox ID="CopiesAvaiable" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click"/>
        </div>

        <div>
            <asp:Label ID="Text_Error" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>

    </form>
</body>
</html>
