<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hello.aspx.cs" Inherits="iram2.hello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" BackColor="#FF3399" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="Button2" runat="server" BackColor="#FF3399" OnClick="Button2_Click" Text="SIgnout" />
        <asp:Button ID="Button3" runat="server" BackColor="#FF3399" OnClick="Button3_Click" Text="additem" />
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         <asp:Button ID="Button4" runat="server" BackColor="#FF3399" OnClick="Button4_Click" Text="viewitmes" />
    </form>
</body>
</html>
