<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WalletManagement.ascx.cs" Inherits="TermProject.ASCX.WalletManagement" %>

<table id="Table1" >
    <tr>
        <td><asp:Label ID="lblWalletSetting" runat="server" Text="Change your payment information:"></asp:Label></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label></td>
        <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label></td>
        <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblEmail" runat="server" Text="Email: (NEEDS to be same as above)"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td><asp:Label ID="lblBankName" runat="server" Text="Bank Name:"></asp:Label></td>
        <td><asp:TextBox ID="txtBankName" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="lblCardType" runat="server" Text="Card Type:"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCardType" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td><asp:Label ID="lblCardNumber" runat="server" Text="CardNumber:"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCardNumber" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
        </td>
    </tr>
    <asp:Label runat="server" ID="lblSuccess" Text="Your payment info has been updated." Visible="false"></asp:Label>
    <asp:Label runat="server" ID="lblFailure" Text="Error - your payment info failed to update" Visible="false"></asp:Label>
</table>