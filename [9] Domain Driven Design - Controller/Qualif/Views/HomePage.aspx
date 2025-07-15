<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Qualif.Views.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Book List</h2>
        <asp:GridView ID="bookGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="BookID" OnSelectedIndexChanged="bookGridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="BookID" HeaderText="No" ReadOnly="True" />
                <asp:BoundField DataField="Title" HeaderText="Title" ReadOnly="True" />
                <asp:BoundField DataField="CopiesAvailable" HeaderText="Total" />
                <asp:CommandField ShowSelectButton="True" HeaderText="Borrow" />
            </Columns>
        </asp:GridView>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BookID" OnRowDeleting="bookGridView_RowDeleting" OnRowEditing="GridView1_RowEditing">
            <Columns>
                <asp:BoundField DataField="BookID" HeaderText="No" ReadOnly="True" />
                <asp:BoundField DataField="Title" HeaderText="Title" ReadOnly="True" />
                <asp:BoundField DataField="CopiesAvailable" HeaderText="Total" />
                 <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
               <%-- <asp:ButtonField CommandName="Delete" Text="Delete" />
                <asp:ButtonField CommandName="Update" Text="Update" />--%>
            </Columns>
        </asp:GridView>

        <asp:Button ID="ReturnBookButton" runat="server" Text="Return Book" OnClick="ReturnBookButton_Click"/>
        <br />
        <asp:Label ID="ErrorMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="InsertBook" runat="server" Text="InserBook" OnClick="InsertBook_Click"/>
        <br />

    </form>
</body>
</html>
