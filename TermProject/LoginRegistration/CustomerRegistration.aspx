<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRegistration.aspx.cs" Inherits="TermProject.CustomerRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Registration</title>
    <style>
        body{
            background-color: lightsalmon;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hello, welcome to Postman's</h1>
        </div>
        <div>
            <h3>Customer Registration</h3>
            <asp:Label runat="server" ID="lblIfYouDoNot" Text="<h3>If you do not have an account, you can make one here.</h3>"></asp:Label>
            <asp:Label runat="server" Text="<h5>Account successfully created. Log in to continue</h5>" ID="lblAccountSuccessful" Visible="false"></asp:Label>
            <asp:Button runat="server" ID="btnBackToLogin" OnClick="BackToLogin_Click" Text="Black to login"></asp:Button>
            <asp:Panel ID="pnlCreateAccount" runat="server" Visible="True">              
                <br />
                <br />
                <asp:Label runat="server" ID="lblId" Text="Enter in a unique Customer ID (this will be what you login with)"></asp:Label>
                <asp:TextBox runat="server" ID="txtCustomerId"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblPassword" Text="Enter a password "></asp:Label>
                <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblDeliveryAddress" Text="Enter your delivery address"></asp:Label>
                <asp:TextBox runat="server" ID="txtDeliveryAddress"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblBillingAddress" Text="Enter your billing address"></asp:Label>
                <asp:TextBox runat="server" ID="txtBillingAddress"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblContactEmail" Text="Enter in a contact email of yours *NOTE: you will not be able to change this entity"></asp:Label>
                <asp:TextBox runat="server" ID="txtContactEmail"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblName" Text="Enter in your name"></asp:Label>
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                <br />
                <h3>Enter in your payment information</h3>
                <asp:Label runat="server" ID="Label2" Text="Enter in your bank name"></asp:Label>
                <asp:TextBox runat="server" ID="txtBankName"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="Label3" Text="Enter in your credit card type"></asp:Label>
                <asp:TextBox runat="server" ID="txtCardType"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="Label4" Text="Enter in your credit card number"></asp:Label>
                <asp:TextBox runat="server" ID="txtCardNumber"></asp:TextBox>
                <br />
                <br />
                <asp:Button runat="server" ID="btnCreateAccount" OnClick="CreateAccount_Click" Text="Create Account"/>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
