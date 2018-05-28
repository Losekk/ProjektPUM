<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master"  CodeBehind="ShoppingCart.aspx.cs" Inherits="ProjectPUM.Pages.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="pnlShoppingCart" runat="server">
    </asp:Panel>
        <table>
            <tr>
                <td>
                    <b>Koszt: </b>
                </td>
                <td>
                    <asp:Literal ID="litTotal" runat="server" Text=""></asp:Literal>
                </td>
            </tr>

          

            <tr>
                <td>
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button" PostBackUrl="~/Pages/Index.aspx">Kontynuuj zakupy</asp:LinkButton> &nbsp;&nbsp;                      
                    <asp:LinkButton ID="btnCheckout" runat="server" CssClass="button" Width="250px" PostBackUrl="~/Pages/Success.aspx">Podsumowanie</asp:LinkButton>

                    <br />

                    
                </td>
            </tr>

        </table>
</asp:Content>
