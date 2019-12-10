<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageMenu.aspx.cs" Inherits="TermProject.Restaurant.ManageMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Your Menu</title>
    <style>
        body{
            background-color: lightblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button runat="server" ID="btnBack" Text="Back to Hub" OnClick="btnBack_Click"/>
        <br />
        <br />
        <asp:Button ID="btnNewItem" runat="server" Text="New Item" OnClick="btnNewItem_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <br />
        <br />
        <asp:Panel runat="server" ID="pnlBuild" Visible="false">
            <asp:Label runat="server" Text="Item Name"></asp:Label>
            <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Price"></asp:Label>
            <asp:TextBox runat="server" ID="txtPrice"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Type"></asp:Label>
            <asp:TextBox runat="server" ID="txtType"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Item Image"></asp:Label>
            <asp:FileUpload runat="server" ID="fuImage" />
            <br />
            <asp:Button runat="server" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"/>
            <br />
            <br />
        </asp:Panel>
        


        <asp:GridView ID="gvMenu" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="ItemID" DataField="Menu_ID">
                </asp:BoundField>
                <asp:BoundField HeaderText="Title" DataField="Item_Name">
                </asp:BoundField>
                <asp:BoundField DataField="Item_Type" HeaderText="Category">
                </asp:BoundField>
                <asp:ImageField HeaderText="Image" DataImageUrlField="Item_Photo">
                </asp:ImageField>
                <asp:BoundField HeaderText="Price" DataField="Item_Price" DataFormatString="{0:c}">
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
