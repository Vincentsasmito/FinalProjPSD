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
                <h3><%#Eval("id") %></h3>
                    <p>
                        Staff ID: <%# Eval("staffid") %>
                    </p>
                    <p>
                        Customer ID: <%# Eval("Customerid") %>
                    </p>
                    <p>
                        Date: <%# Eval("Date") %>
                    </p>
                    <asp:Button ID="HandleButton" runat="server" CommandArgument='<%# Eval("id") %>' CommandName="Handle" Text="Handle" UseSubmitBehavior="false" />
            </ItemTemplate>
        </asp:Repeater>
        </div>
    </form>
    <p>
        Handled</p>
     <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <h3><%#Eval("id") %></h3>
                    <p>
                        Staff ID: <%# Eval("staffid") %>
                    </p>
                    <p>
                        Customer ID: <%# Eval("Customerid") %>
                    </p>
                    <p>
                        Date: <%# Eval("Date") %>
                    </p>
            </ItemTemplate>
        </asp:Repeater>
    <p>
        &nbsp;</p>
</body>
</html>
