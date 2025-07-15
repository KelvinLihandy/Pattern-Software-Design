<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cloth.aspx.cs" Inherits="ClothStoreVBL.Views.Cloth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Cloth</h2>
        <asp:GridView ID="ClothGridView" runat="server" AutoGenerateColumns="False" BorderWidth="1px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="brand" HeaderText="Brand" />
                <asp:BoundField DataField="size" HeaderText="Size" />
                <asp:BoundField DataField="stock" HeaderText="Stock" />
                <asp:BoundField DataField="price" HeaderText="Price" DataFormatString="{0:N0}" />
                <asp:BoundField DataField="cloth_typeid" HeaderText="Cloth Type ID" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
