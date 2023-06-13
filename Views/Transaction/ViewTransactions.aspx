<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactions.aspx.cs" Inherits="Final_Project.Views.Transaction.ViewTransactions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View Transactions<br />
            <br />
            Unhandled
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <h3><%#Eval("Name") %></h3>
                <p>Broth: <%# Eval("Broth") %></p>
                <p>Price: <%# Eval("Price") %></p>
                <p>Meat: <%# Eval("meatName") %></p>
                <asp:Button ID="UpdateButton" runat="server" UseSubmitBehavior="false" CommandName="Update" CommandArgument='<%# Eval("id") %>' Text="Update" />
                <asp:Button ID="DeleteButton" runat="server" UseSubmitBehavior="false" CommandName="Delete" CommandArgument='<%# Eval("id") %>' Text="Delete" />
            </ItemTemplate>
        </asp:Repeater>
        </div>
    </form>
    <p>
        Handled</p>
     <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <h3><%#Eval("Name") %></h3>
                <p>Broth: <%# Eval("Broth") %></p>
                <p>Price: <%# Eval("Price") %></p>
                <p>Meat: <%# Eval("meatName") %></p>
                <asp:Button ID="UpdateButton" runat="server" UseSubmitBehavior="false" CommandName="Update" CommandArgument='<%# Eval("id") %>' Text="Update" />
                <asp:Button ID="DeleteButton" runat="server" UseSubmitBehavior="false" CommandName="Delete" CommandArgument='<%# Eval("id") %>' Text="Delete" />
            </ItemTemplate>
        </asp:Repeater>
    <p>
        &nbsp;</p>
</body>
</html>
