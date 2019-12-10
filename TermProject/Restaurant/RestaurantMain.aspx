<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestaurantMain.aspx.cs" Inherits="TermProject.RestuarantMain" %>

<%@ Register Src="../ASCX/RestAccountManagement.ascx" TagPrefix="UserControl" TagName="RestAccountSettings" %>
<%@ Register Src="../ASCX/WalletManagement.ascx" TagPrefix="UserControl" TagName="EditWallet" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Restaurant Owner</title>
    <style>
        body{
            background-color: lightblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" ID="lblWelcome"></asp:Label>
        <br />
        <asp:Button runat="server" ID="btnManageMenu" OnClick="btnManageMenu_Click" Text="Manage Menu"/>
        <asp:Button runat="server" ID="btnViewTransactions" OnClick="btnViewTransactions_Click" Text="View Transactions"/>
        <asp:Button runat="server" ID="btnViewCurrentOrders" OnClick="btnViewCurrentOrders_Click" Text="View Current Orders"/>
        <asp:Button runat="server" ID="btnLogout" OnClick="btnLogout_Click" Text="Logout"/>
        <asp:Label runat="server" ID="lblInstructions" Text="<h3>On this page you can update some of your information that gets displayed to the customers.</h3>"></asp:Label>
         
        <UserControl:RestAccountSettings runat="server" ID="AccountSettings" />
        <br />
        <UserControl:EditWallet runat="server" ID="EditWallet" />
    </form>
</body>
</html>
