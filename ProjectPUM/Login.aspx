<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectPUM.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Zaloguj się</title>
    <link rel="stylesheet" href="Style/StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="formclass">
            <h2> Zaloguj się!</h2>
            <asp:TextBox ID="txtuser" CssClass="input" placeholder="Login" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtpass" CssClass="input" placeholder="Hasło" TextMode="Password" runat="server"></asp:TextBox>
            <asp:Button ID="Login_bt" CssClass="input" runat="server" Text="Zaloguj się" OnClick="Login_bt_Click" />
        </div>
    </form>
</body>
</html>
