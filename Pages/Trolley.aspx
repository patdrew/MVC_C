<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Trolley.aspx.cs" Inherits="Pages_Trolley" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="paneltrolley" runat="server">

    
    </asp:Panel>

    <table>
            <tr>
                <td>
                    <b>Total: </b> </td>
                <td>
                    <asp:Literal ID="literaltot" runat="server" Text=""></asp:Literal>
                </td> </tr>

            <tr>
                <td>
                    <b>Vat (TAX): </b></td>
                <td>
                    <asp:Literal ID="literalVat" runat="server" Text="" />
                </td>
            </tr>
            <tr>
                <td>  <b>Shipping cost: </b>
                </td>
                <td>
                    £20
                </td>
            </tr>

            <tr>
                <td>
                    <b>Total Amount: </b>
                </td>
                <td>
                    <asp:Literal ID="literalTotAmt" runat="server" Text="" />
                </td>
            </tr>

            <tr>
                <td>
                    <br />
                    <asp:LinkButton ID="LinkNext" runat="server" PostBackUrl="~/Index.aspx">Do you want to Carry on Shopping</asp:LinkButton> &nbsp;&nbsp; OR                     
                    <asp:Button ID="btnChkout" runat="server" Text="Check Out" CssClass="button" Width="250px" PostBackUrl="~/Pages/Done.aspx" />

                    <br />

                    <asp:LinkButton ID="literalPaypal" Text="" runat="server" />
                </td>
            </tr>

        </table>
</asp:Content>

