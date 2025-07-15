<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="PatternSoftwareDesign_S5.Page.TransactionDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Transaction <%: Request.QueryString["id"] %></h1>
        <hr/>

        <div style="padding: 50px">
            <table style="width: 500px">
                <tr>
                    <td>Date</td>
                    <td><%= tran.transaction_date %></td>
                </tr>
                <tr>
                    <td>Buyer</td>
                    <td><%= tran.user.name %></td>
                </tr>
                <tr>
                    <td>Total Product</td>
                    <td><%= tran.transaction_details.Count() %></td>
                </tr>
                <tr>
                    <td>Total Quantity</td>
                    <td><%= tran.transaction_details.Sum(detail => detail.quantity) %></td>
                </tr>
                <tr>
                    <td>Total Type</td>
                    <td><%= tran.transaction_details.GroupBy(detail => detail.cloth.cloth_typeid).Count() %></td>
                </tr>
                <tr>
                    <td>Total Money Spent</td>
                    <td><%= tran.user.transactions.Sum(tran => tran.transaction_details.Sum(detail => detail.quantity * detail.cloth.price)) %></td>
                </tr>
                <tr>
                    <td>Max Spending</td>
                    <td><%= tran.user.transactions.Max(tran => tran.transaction_details.Sum(detail => detail.quantity * detail.cloth.price)) %></td>
                </tr>
                <tr>
                    <td>Min Spending</td>
                    <td><%= tran.user.transactions.Min(tran => tran.transaction_details.Sum(detail => detail.quantity * detail.cloth.price)) %></td>
                </tr>
                <tr>
                    <td>Average Spending</td>
                    <td><%= tran.user.transactions.Average(tran => tran.transaction_details.Sum(detail => detail.quantity * detail.cloth.price)) %>></td>
                </tr>
            </table>
        </div>


        <table border="1">
            <tr>
                <td>Cloth</td>
                <td>Cloth Type</td>
                <td>Quantity</td>
                <td>SubTotal</td>
            </tr>
            <% foreach(var detail in tran.transaction_details)
            { %>
            <tr>
                <td><%= detail.cloth.brand %></td>
                <td><%= detail.cloth.cloth_types.name %></td>
                <td><%= detail.quantity %></td>
                <td><%= detail.cloth.price %></td>
            </tr>
            <% } %>
            <tr>
                <td ColumnSpan="3">Total</td>
                <td ColumnSpan="3"><%= tran.transaction_details.Sum(detail => detail.quantity * detail.cloth.price) %></td>
            </tr>    
        </table>
    </form>
</body>
</html>
