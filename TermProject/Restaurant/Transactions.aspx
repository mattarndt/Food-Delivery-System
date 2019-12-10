<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="TermProject.Restaurant.Transactions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Transactions</title>
    <style>
        body{
            background-color: lightblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button runat="server" ID="btnBack" OnClick="btnBack_Click" Text="Back to hub"/>
        <br />
        <br />
        <asp:Label runat="server" ID="lblInstructions" Text="Here are all your transactions for your restaurant"></asp:Label>
        <asp:GridView runat="server" ID="gvTransactions" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="transactionID" HeaderText="Transaction ID" />
                <asp:BoundField DataField="email" HeaderText="From Email" />
                <asp:BoundField DataField="amount" HeaderText="Amount" />
                <asp:BoundField DataField="type" HeaderText="Type" />
                <asp:BoundField DataField="cardNumber" HeaderText="Card Number" />
                <asp:BoundField DataField="merchantID" HeaderText="Merchant ID" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
