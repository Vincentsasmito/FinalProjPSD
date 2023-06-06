<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Final_Project.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username(5 - 15 Characters, alphabet &amp; space only)</div>
        <asp:TextBox ID="TBName" runat="server"></asp:TextBox>
        <p>
            Email</p>
        <asp:TextBox ID="TBEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        Gender
        <asp:RadioButton ID="RadioButtonM" Text="Male" runat="server" />
        <asp:RadioButton ID="RadioButtonF" Text="Female" runat="server" />
        
        <p>
            Password</p>
        <asp:TextBox ID="TBPw" runat="server"></asp:TextBox>
        <p>
            Confirm Password</p>
        <asp:TextBox ID="TBPwC" runat="server"></asp:TextBox>
        
        <p>
            <asp:Button ID="CreateAccBtn" runat="server" Text="Create Account" OnClick="CreateAccBtn_Click" />
        </p>
        
        <asp:ListBox ID="ListBox1" runat="server" Height="152px" Width="342px"></asp:ListBox>
        
    </form>
</body>
</html>
