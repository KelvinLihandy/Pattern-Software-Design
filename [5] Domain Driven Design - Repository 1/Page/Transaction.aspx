<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="PatternSoftwareDesign_S5.Page.Transaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Transaction Page</h1>
<hr />
<div style="padding: 50px">
    <table style="width: 500px" border="1">
        <tr>
            <th>Date</th>
            <th>Buyer</th>
            <th>Total Product</th>
        </tr>
       
        <%--Server Side Rendering--%>
        <%foreach(var tran in transaction)
            { %>
        <tr>
            <td><% Response.Write(tran.transaction_date); %></td>
            <td><%= tran.user.name %></td>
            <td><%= tran.transaction_details.Count() %></td>
            <td><a href="~/Page/TransactionDetailPage.aspx?id=<%= tran.id %>">Details</a></td>
        </tr>
           <% } %>
    </table>
</div>
    </form>
</body>
</html>
