<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="PatternSoftwareDesign_S2.Views.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Edit Page</h1>
            <asp:Label runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="idTB" runat="server" ></asp:TextBox><br />
            <asp:Label runat="server" Text="Brand"></asp:Label>
            <asp:TextBox ID="brandTB" runat="server" ></asp:TextBox><br />
            <asp:Label runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="priceTB" runat="server" ></asp:TextBox><br />
            <asp:Label runat="server" Text="Type"></asp:Label>
            <asp:DropDownList ID="typeList" runat="server"></asp:DropDownList><br />
            <asp:Button ID="editBtn" runat="server" Text="Edit" OnClick="editBtn_Click" />
        </div>
    </form>
</body>
</html>
