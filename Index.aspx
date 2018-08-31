<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="ddlTypes" runat="server" OnSelectedIndexChanged="ddlTypes_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True">

<asp:ListItem Text="--Choose--" Value="0" />

</asp:DropDownList>

    <asp:Panel ID="panlProds" runat="server">
    </asp:Panel>

    <div style ="clear:both"></div>
</asp:Content>

