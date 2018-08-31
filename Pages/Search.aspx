<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Pages_Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



	<!-- HTML for SEARCH BAR -->
	<div id="tfheader">
		<%--<form id="tfnewsearch" method="get" action="http://www.google.com">--%>
            <asp:TextBox  ID="txtsearch" class="tftextinput" size="21" maxlength="120" runat="server"></asp:TextBox>
            <asp:Button ID="search" runat="server" Text="Search"  CssClass="tfbutton" OnClick="search_Click" PostBackUrl="~/Pages/Search.aspx" />
            
		<%--</form>--%>
	<div class="tfclear"></div>
	</div>



    <asp:GridView ID="Gridsearch" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" Width="90%">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
    

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ElectronicaConnectionString %>" SelectCommand="SELECT [Image], [Description], [Price], [Name] FROM [Product] WHERE ([Name] LIKE '%' + @Name + '%')">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="" Name="Name" SessionField="searchKey" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    

</asp:Content>

