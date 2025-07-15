<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowPage.aspx.cs" Inherits="Qualif.Views.BorrowPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="Header" runat="server">BookID : </h1>
        </div>

        <div>
            <asp:Label ID="Label1" runat="server" Text="Book Title : "></asp:Label>
            <asp:Label ID="TitleBook" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="Label2" runat="server" Text="Borrow Until : "></asp:Label>
            <asp:Calendar ID="BorrowCalender" runat="server" AutoPostBack="False"></asp:Calendar>
        </div>

        <asp:Button ID="BorrowButton" runat="server" Text="Borrow" OnClick="BorrowButton_Click"/>
        <br />
        <asp:Label ID="ErrorMsg" runat="server" Text="" ForeColor="Red"></asp:Label>

    </form>
</body>
</html>
