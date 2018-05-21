<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProjectPUM.Pages.Account.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Register a new user</h4>
    <hr />
    <p>
        <asp:Literal runat="server" ID="literalStatusMessage" />
    </p>

    User name:<br />
    <asp:TextBox runat="server" ID="txtUserName" CssClass="inputs" /><br />

    Password:
    <br />
    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="inputs" /><br />

    Confirm password:
    <br />
    <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" CssClass="inputs" /><br />
    
    First Name:<br />
    <asp:TextBox runat="server" ID="txtFirstName" CssClass="inputs" /><br />
    
    Last Name:<br />
    <asp:TextBox runat="server" ID="txtLastName" CssClass="inputs" /><br />
    

    <p>
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="buttonRegister_Click" CssClass="button" Width="150px" />
    </p>
</asp:Content>
