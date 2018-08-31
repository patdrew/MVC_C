<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Item.aspx.cs" Inherits="Pages_Item" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table>
        <tr> 
            <td rowspan ="4">
            <asp:Image ID="imgProd" runat ="server" CssClass = "detlImg" /></td>
            <td> <h2>  <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>

                
                </h2> <hr/></td>
        </tr>

        <tr> 
            <td>
                <asp:Label ID="lblDesc" runat="server" CssClass="detlDesc"></asp:Label> </td>
            <td>
                <asp:Label ID="lblPrice" runat="server" CssClass="detlPrice"></asp:Label> <br />

                Quantity:<asp:DropDownList ID="ddlAmt" runat="server"></asp:DropDownList> <br />
                <asp:Button ID="btnAdd" runat="server" Text="Add more Items" CssClass="button" OnClick="btnAdd_Click" /> <br />

                 <asp:Label ID="lblResults" runat="server" Text=""></asp:Label> 
            </td> 
        
           
        </tr>

        <tr> 
            <td>Product ID: <br /> <asp:Label ID="lblIDno" runat="server" Style="font-style: italic" Text="Label"></asp:Label></td>
           
        </tr>

        <tr> 
            <td class="auto-style2">&nbsp;<asp:Label ID="lblAvailable" runat="server" CssClass="prodPrice">Available!</asp:Label></td>
            <asp:Label ID="lblShare" runat="server" Text=""></asp:Label>
        </tr>
    </table>
</asp:Content>

