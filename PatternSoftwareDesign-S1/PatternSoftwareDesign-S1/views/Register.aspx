<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PatternSoftwareDesign_S1.views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>This is register page</title>
</head>
<body>
    <form id="form1" runat="server">
        <%--comment = ctrl k c--%>
        <%--uncomment = ctrl k u--%>
        <h1>Register Page</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TBUsername" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TBPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Date of Birth"></asp:Label>
            <asp:Calendar ID="CalendarDOB" runat="server"></asp:Calendar>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonGender" runat="server">
                <asp:ListItem Value="Male">Male</asp:ListItem>
                <asp:ListItem Value="Female">Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Status"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="Menikah">Menikah</asp:ListItem>
                <asp:ListItem Value="Belum Menikah">Belum Menikah</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click"/>
        </div>
        <div>
            <asp:Label ID="ErrorMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>