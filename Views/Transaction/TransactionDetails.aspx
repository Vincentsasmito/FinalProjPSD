﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetails.aspx.cs" Inherits="Final_Project.Views.Transaction.TransactionDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Transaction Details<br />
        <asp:ListBox ID="ListBox1" runat="server" Height="270px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="671px"></asp:ListBox>
    </form>
</body>
</html>