<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestaurantRegistration.aspx.cs" Inherits="TermProject.RestaurantRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Restaurant Registration</title>
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
            <h3>Restaurant Registration</h3>
            <asp:Label runat="server" ID="lblIfYouDoNot" Text="<h3>If you do not have an account, you can make one here.</h3>"></asp:Label>
            <asp:Label runat="server" Text="<h5>Account successfully created. Log in to continue</h5>" ID="lblAccountSuccessful" CssClass="green" Visible="false"></asp:Label>
            <asp:Button runat="server" ID="btnBackToLogin" OnClick="BackToLogin_Click" Text="Back to login"></asp:Button>
            <asp:Panel ID="pnlCreateAccount" runat="server" Visible="True">              
                <br />
                <br />
                <asp:Label runat="server" ID="lblId" Text="Enter in your unique Restaurant ID (you will use this to login)"></asp:Label>
                <asp:TextBox runat="server" ID="txtRestaurantId"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblPassword" Text="Enter a password "></asp:Label>
                <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblName" Text="Enter in your restaurant name "></asp:Label>
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblAddress" Text="Enter restaurant address "></asp:Label>
                <asp:TextBox runat="server" ID="txtAddress"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblPhone" Text="Enter in your phone number "></asp:Label>
                <asp:TextBox runat="server" ID="txtRestaurantPhone"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblRestaurantEmail" Text="Enter in a contact email of yours *NOTE: you will not be able to change this entity"></asp:Label>
                <asp:TextBox runat="server" ID="txtRestaurantEmail"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="Label1" Text="Enter in your logo"></asp:Label>
                <asp:TextBox runat="server" ID="txtLogo"></asp:TextBox>
                <br />
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
                <asp:Button runat="server" ID="btnCreateAccount" OnClick="CreateAccount_Click" Text="Create Account"/>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
