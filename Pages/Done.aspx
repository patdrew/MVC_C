<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Done.aspx.cs" Inherits="Pages_Done" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/thankyou.png" />

    <h1 style="text-align:center">Thank you</h1>
    <h2><p style="text-align:center">
        Your payment has been received. Thank you for your purchase.
    </p></h2>
    <p>
        <small style="text-align:center">
            We won't actually send anything though.  Shhhhhhhh...
        </small>
    </p>
</asp:Content>

