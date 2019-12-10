<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDashboard.aspx.cs" Inherits="TermProject.CustomerDashboard" %>

<%@ Register Src="../ASCX/UserAccountSettings.ascx" TagPrefix="UserControl" TagName="AccountSettings" %>
<%@ Register Src="../ASCX/WalletManagement.ascx" TagPrefix="UserControl" TagName="EditWallet" %>

<style>
        body{
            background-color: lightblue;
        }
    </style>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Customer</title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label runat="server" ID="lblWelcome"></asp:Label>
        <div class="container">
            <div>
                <table>
                    <tr>
                        <th>Logo</th>
                        <th>Restaurant</th>
                        <th>Email</th>
                        <th>Address</th>
                        <th>Phone Number</th>
                    </tr>
                    <asp:Repeater ID="rptRest" runat="server" OnItemCommand="repeaterRest_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:Label ID="lblLogo" runat="server" ImageUrl='<%# DataBinder.Eval(Container.DataItem, "Logo") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "RestaurantName") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblEmail" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Email") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblAddress" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Address") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblPhone" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Phone") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="btnSelect" Text="Select Restaurant" runat="server" />
                                </td>
                                <br />
                            </tr>
                        </ItemTemplate>
                        <SeparatorTemplate>
                            <hr>
                        </SeparatorTemplate>
                    </asp:Repeater>
                </table>
                <input id="txtHidden" type="hidden" value="0" runat="server" />
            </div>
        </div>
        <br />
        <br />
        <asp:Button runat="server" ID="btnViewTransactions" OnClick="btnViewTransactions_Click" Text="View Transactions"/>
        <br />
        <br />
        <UserControl:AccountSettings runat="server" ID="AccountSettings" />
        <br />
        <UserControl:EditWallet runat="server" ID="EditWallet" />
    </form>
</body>
</html>
