<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClothType.aspx.cs" Inherits="ClothStoreVBL.Views.ClothType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Cloth Type</h2>
        <asp:GridView ID="clothTypeGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="id" OnRowDeleting="clothTypeGridView_RowDeleting">
            <Columns>
                <asp:ButtonField CommandName="Delete" Text="Delete" />
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" />
                <asp:BoundField DataField="name" HeaderText="name" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
