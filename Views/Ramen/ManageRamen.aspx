<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageRamen.aspx.cs" EnableEventValidation="false" Inherits="Final_Project.Views.Ramen.ManageRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Manage Ramen<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Insert Ramen" OnClick="Button1_Click" />
            <br />
        </div>
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
    </form>
</body>
</html>
