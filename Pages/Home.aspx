<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Pages_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 style="text-align:center">Welcome to ℗Evolution Electronics  </h2>

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate >
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
    
    <asp:Image ID="Image1" height= "400px" ImageAlign="Middle" Width="1000px" runat="server" /> 
            
            <br></br>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            
            <br></br>
            
            <br></br>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Stop SlideShow" />
            </br>
            </br>
            </br>

        </ContentTemplate>

    </asp:UpdatePanel>

    
</asp:Content>

