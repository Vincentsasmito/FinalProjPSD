﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="Final_Project.Views.UpdateRamen"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Update Ramen</div>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="160px">
        </asp:DropDownList>
        <p>
        Meat Type:</p>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Value="1">Chicken</asp:ListItem>
            <asp:ListItem Value="2">Beef</asp:ListItem>
            <asp:ListItem Value="3">Pork</asp:ListItem>
        </asp:RadioButtonList>
        <p>
            Name (Must have &quot;Ramen&quot;):</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="173px"></asp:TextBox>
        </p>
        <p>
            Broth:</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Width="166px"></asp:TextBox>
        </p>
        <p>
            Price (&gt;= 3000):</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update Ramen" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    </form>
</body>
</html>
