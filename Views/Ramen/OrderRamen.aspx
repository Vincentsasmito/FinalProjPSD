<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="Final_Project.Views.Ramen.OrderRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Order Ramen<br />
            <asp:ListBox ID="ListBox1" runat="server" Width="451px"></asp:ListBox>
            <br />
            <asp:Button ID="ClearButton" runat="server" Text="ClearCart" OnClick="ClearButton_Click"/>
            <asp:Button ID="BuyButton" runat="server" Text="Buy Cart" OnClick="BuyButton_Click" />
            <br />
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <h3><%#Eval("Name") %></h3>
                <p>Broth: <%# Eval("Broth") %></p>
                <p>Price: <%# Eval("Price") %></p>
                <p>Price: <%# Eval("meatName") %></p>
                <asp:Button ID="OrderButton" runat="server" UseSubmitBehavior="false" CommandName="Order" CommandArgument='<%# Eval("id") + "|" + Eval("Name") + "|" + Eval("Broth") + "|" + Eval("Price") + "|" + Eval("meatName") %>' Text="Order Ramen" />
            </ItemTemplate>
        </asp:Repeater>
        </div>
    </form>
</body>
</html>
