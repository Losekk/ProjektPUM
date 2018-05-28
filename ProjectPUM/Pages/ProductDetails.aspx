<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ProjectPUM.Pages.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td rowspan="4" style="width: 400px">
                <asp:Image ID="productImage" runat="server" CssClass="detailsImage" />
            </td>
            <td style="width: 400px;">
                <h2>
                    <asp:Label ID="labelTitle" runat="server"></asp:Label></h2>
                <hr />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelDescription" runat="server" CssClass="detailsDescription"></asp:Label>
            </td>
            <td style="margin-left: 10px">
                <asp:Label ID="labelPrice" runat="server" CssClass="detailsPrice"></asp:Label><br />
                Ilość:<asp:TextBox ID="quantityTextBox" runat="server"></asp:TextBox><br />
                <asp:Button ID="buttonAdd" runat="server" CssClass="button" OnClick="buttonAdd_Click" Text="Dodaj produkt" />
                <br />
                
                <asp:Label ID="labelResult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;<asp:Label ID="labelAvailable" runat="server" CssClass="productPrice">Dostępny!</asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
