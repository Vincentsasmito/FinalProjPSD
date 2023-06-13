<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="Final_Project.Views.Transaction.History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Transaction History<br />
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
                    <asp:Button ID="DetailsButton" runat="server" CommandArgument='<%# Eval("id") %>' CommandName="Details" Text="Details" UseSubmitBehavior="false" />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
