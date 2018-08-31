<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Stats.aspx.cs" Inherits="Pages_AccountManagement_Stats" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>Product Type Chart</p>
    <asp:Chart ID="Chart1" runat="server" DataSourceID="pie" Height="318px" Width="462px">
        <Series>
            <asp:Series Name="Series1" ChartType="Pie" XValueMember="Name" YValueMembers="Id"></asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
    </asp:Chart>


    <asp:SqlDataSource ID="pie" runat="server" ConnectionString="<%$ ConnectionStrings:ElectronicaConnectionString %>" SelectCommand="SELECT [Id], [Name] FROM [ProductTypes]"></asp:SqlDataSource>
    
    <asp:SqlDataSource ID="bar" runat="server" ConnectionString="<%$ ConnectionStrings:ElectronicaConnectionString %>" SelectCommand="SELECT * FROM [Cart]"></asp:SqlDataSource>

</asp:Content>

