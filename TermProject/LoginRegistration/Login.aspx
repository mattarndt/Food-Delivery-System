<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TermProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - Term Project</title>
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
            <asp:Label runat="server" ID="lblWelcome" Text="<h4>If you have an account, you may login here.</h4>"></asp:Label>
            <asp:Label runat="server" ID="lblNoAccount" Text="Could not find this account, please try again." Visible="false"></asp:Label>
            <br />
            <asp:Label runat="server" ID="lblUsrname">Username</asp:Label>
            <asp:TextBox runat="server" ID="txtUsrname"></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lblPssword">Password</asp:Label>
            <asp:TextBox runat="server" ID="txtPssword"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="cbRememberLogin" runat="server" Text="Remember my login?" />
            <asp:Button runat="server" ID="btnForgetInfo" Text="Forget my login info" OnClick="btnForgetInfo_Click"/>
            <br />
            <br />
            <asp:Button runat="server" ID="btnLogin" OnClick="Login_Click" Text="Login"></asp:Button>
        </div>
        <div>
            <asp:Label runat="server" ID="lblIfYouDoNot" Text="<h3>If you do not have an account, you can make one here.</h3>"></asp:Label>
            <asp:Button runat="server" ID="btnCustomerRegistration" Text="Create Customer Account" OnClick="btnCustomerRegistration_Click"/>
            <asp:Button runat="server" ID="btnRestaurantRegistration" Text="Create Restaurant Account" OnClick="btnRestaurantRegistration_Click"/>
        </div>
    </form>
</body>
</html>