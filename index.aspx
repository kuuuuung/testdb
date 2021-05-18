<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BASICDB.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
&nbsp;Password
            <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="cmdAdd" runat="server" OnClick="Button1_Click" Text="ADD" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
