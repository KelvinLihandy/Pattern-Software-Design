<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBook.aspx.cs" Inherits="Qualif.Views.ReturnBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="Header" runat="server">Welcome : </h1>
        </div>
        <br />

       <asp:GridView ID="bookBorrow" runat="server" AutoGenerateColumns="False" DataKeyNames="DetailId" OnSelectedIndexChanged="bookGridView_SelectedIndexChanged1">
            <Columns>
                <asp:BoundField DataField="DetailId" HeaderText="BorrowId" ReadOnly="True" />
                <asp:BoundField DataField="BookId" HeaderText="BookId" ReadOnly="True" />
                <asp:BoundField DataField="Title" HeaderText="Title" ReadOnly="True" />
                <asp:BoundField DataField="DueDate" HeaderText="Due Date" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:CommandField ShowSelectButton="True" HeaderText="Return" />
            </Columns>
        </asp:GridView>

    </form>
</body>
</html>
