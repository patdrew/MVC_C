<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Manage_TypeProducts.aspx.cs" Inherits="Pages_Admin_Management_Manage_TypeProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Name:</p>
    <p>
        <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btn_Submit" runat="server" OnClick="btn_Submit_Click" Text="Submit" />
    </p>
    <p>
        <asp:Label ID="lbl_Results" runat="server"></asp:Label>
    </p>
</asp:Content>

