<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProjectPUM.Pages.Account.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Zarejestruj się</h4>
    <hr />
    <p>
        <asp:Literal runat="server" ID="literalStatusMessage" />
    </p>

    Login:<br />
    <asp:TextBox runat="server" ID="txtUserName" CssClass="inputs" /><br />

    Hasło:
    <br />
    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="inputs" /><br />

    Potwierdź hasło:
    <br />
    <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" CssClass="inputs" /><br />
    
    Imie:<br />
    <asp:TextBox runat="server" ID="txtFirstName" CssClass="inputs" /><br />
    
    Nazwisko:<br />
    <asp:TextBox runat="server" ID="txtLastName" CssClass="inputs" /><br />
    

    <p>
        <asp:Button ID="btnRegister" runat="server" Text="Zarejestruj się" OnClick="buttonRegister_Click" CssClass="button" Width="150px" />
    </p>
</asp:Content>
