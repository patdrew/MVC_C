<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyAccount.aspx.cs" Inherits="Pages_MyAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <br />
    <br />
    <span style="display:none"><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="UserName" DataValueField="Id">
    </asp:DropDownList></span>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ElectronicaConnectionString %>" SelectCommand="SELECT [UserName], [Id] FROM [AspNetUsers] WHERE ([UserName] = @UserName)">
        <SelectParameters>
            <asp:SessionParameter Name="UserName" SessionField="Name" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:DetailsView ID="detailviewSpecifics" runat="server" AutoGenerateRows="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" Height="50px" Width="100%" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            <asp:BoundField DataField="PostCode" HeaderText="PostCode" SortExpression="PostCode" />
            <asp:CommandField ShowEditButton="True" />
        </Fields>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ElectronicaConnectionString %>" DeleteCommand="DELETE FROM [UserSpecific] WHERE [ID] = @original_ID AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND [Email] = @original_Email AND [Address] = @original_Address AND [PostCode] = @original_PostCode" InsertCommand="INSERT INTO [UserSpecific] ([FirstName], [LastName], [Email], [Address], [PostCode]) VALUES (@FirstName, @LastName, @Email, @Address, @PostCode)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [ID], [FirstName], [LastName], [Email], [Address], [PostCode] FROM [UserSpecific] WHERE ([DGK] = @DGK)" UpdateCommand="UPDATE [UserSpecific] SET [FirstName] = @FirstName, [LastName] = @LastName, [Email] = @Email, [Address] = @Address, [PostCode] = @PostCode WHERE [ID] = @original_ID AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND [Email] = @original_Email AND [Address] = @original_Address AND [PostCode] = @original_PostCode">
        <DeleteParameters>
            <asp:Parameter Name="original_ID" Type="Int32" />
            <asp:Parameter Name="original_FirstName" Type="String" />
            <asp:Parameter Name="original_LastName" Type="String" />
            <asp:Parameter Name="original_Email" Type="String" />
            <asp:Parameter Name="original_Address" Type="String" />
            <asp:Parameter Name="original_PostCode" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="PostCode" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="DGK" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="PostCode" Type="String" />
            <asp:Parameter Name="original_ID" Type="Int32" />
            <asp:Parameter Name="original_FirstName" Type="String" />
            <asp:Parameter Name="original_LastName" Type="String" />
            <asp:Parameter Name="original_Email" Type="String" />
            <asp:Parameter Name="original_Address" Type="String" />
            <asp:Parameter Name="original_PostCode" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="sdsSpecifics" runat="server" ConnectionString="<%$ ConnectionStrings:ElectronicaConnectionString %>" DeleteCommand="DELETE FROM [UserSpecific] WHERE [ID] = @ID" InsertCommand="INSERT INTO [UserSpecific] ([FirstName], [LastName], [Email], [Address], [PostCode]) VALUES (@FirstName, @LastName, @Email, @Address, @PostCode)" SelectCommand="SELECT [FirstName], [LastName], [Email], [Address], [PostCode], [ID] FROM [UserSpecific]" UpdateCommand="UPDATE [UserSpecific] SET [FirstName] = @FirstName, [LastName] = @LastName, [Email] = @Email, [Address] = @Address, [PostCode] = @PostCode WHERE [ID] = @ID">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="PostCode" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="PostCode" Type="String" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>



</asp:Content>



