<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="PatternSoftwareDesign_S2.Views.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>View Page</h1>
            <asp:GridView ID="clothGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="deleteData" OnRowEditing="editingData">
                <Columns>
                    <asp:BoundField DataField="cloth_id" HeaderText="Id" SortExpression="cloth_id" />
                    <asp:BoundField DataField="brand" HeaderText="Brand" SortExpression="brand" />
                    <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
                    <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="insertPageBtn" runat="server" Text="Redirect to Insert Page" OnClick="insertPageBtn_Click" />
        </div>
    </form>
</body>
</html>
