<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RestAccountManagement.ascx.cs" Inherits="TermProject.ASCX.RestAccountManagement" %>

<table id="Table1">
    <tr>
        <td><asp:Label runat="server" ID="lblAccountSettings" Text="Manage your account settings" ForeColor="Black"></asp:Label></td>
    </tr>
    <tr>
        <td><asp:Label runat="server" ID="lblId"  Text="Login ID:"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="txtId"  Enabled="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td ><asp:Label runat="server" ID="lblPassword"  Text="Password:"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="txtPassword"  Enabled="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label runat="server" ID="lblName" Text="Name:"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="txtName" Enabled="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label runat="server" ID="lblAddress" Text="Address:"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="txtAddress" Enabled="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label runat="server" ID="lblEmail" Text="Account Email:  (not changeable)"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="txtEmail" Enabled="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label runat="server" ID="lblPhone" Text="Phone:"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="txtPhone" Enabled="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Button runat="server" ID="btnChange" Text="Change" OnClick="btnEdit_Click" />
            <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnUpdate_Click" Enabled="False" />
      </td>
    </tr>
</table>
