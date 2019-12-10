<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMenu.aspx.cs" Inherits="TermProject.Customer.ViewMenu" %>

<!DOCTYPE html>
<style>
        body{
            background-color: lightblue;
        }
    </style>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Menu View</h1>
        <br />
        <div class="container">
        <div>
            <asp:GridView ID="gvMenu" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="Select">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkSelect" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="ItemID" DataField="Menu_ID">
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Name" DataField="Item_Name">
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Category" DataField="Item_Type">
                    </asp:BoundField>
                    <asp:ImageField HeaderText="Image" DataImageUrlField="Item_Photo">
                    </asp:ImageField>
                    <asp:BoundField HeaderText="Price" DataField="Item_Price" DataFormatString="{0:c}">
                    </asp:BoundField>
                </Columns>
            </asp:GridView>
        </div>
            <br />

            <br />
            <asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click"/>
            <br />
            <br />
            <asp:Label ID="lblOrders" runat="server" Text="Order Information:" visible="false"></asp:Label>
            <br />
            <asp:Label ID="lblOrderName" runat="server" Text="Label" visible="false"></asp:Label>
            <br />
            <asp:Label ID="lblUserEmail" runat="server" Text="Label" visible="false"></asp:Label>
            <br />
            <asp:Label ID="lblRestaurantEmail" runat="server" Text="Label" visible="false"></asp:Label>
            <br />
            <asp:Label ID="lblOrderCost" runat="server" Text="Label" visible="false"></asp:Label>
    </div>
    </form>
</body>
</html>
