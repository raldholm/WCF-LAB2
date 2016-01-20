<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="AgeWebClient._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Please enter your birthday [YYYY-MM-DD]<br />
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get birthdayinfo!" />
        <br />
        <br />
        You are
        <asp:Label ID="Label1" runat="server" Text="(numberOfDays)"></asp:Label>
&nbsp;days old.<br />
        <br />
        Your next 1000 days celebration will be on: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
