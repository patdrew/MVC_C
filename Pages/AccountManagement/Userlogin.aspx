<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Userlogin.aspx.cs" Inherits="Pages_AccountManagement_Userlogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Literal ID="Literalstat" runat="server"></asp:Literal>
    <div class="login-card">
    <h2>Log-in </h2><br>
  
    Username: <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
             ErrorMessage="A password is Required" ControlToValidate="txtuser_name" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:TextBox ID="txtuser_name" runat="server" Text="User Name" CssClass="extra"></asp:TextBox>
        
        
        Password: <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
             ErrorMessage="A password is Required" ControlToValidate="txt_pass" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        
        <asp:TextBox ID="txt_pass" runat="server" TextMode="Password" Text="Password" CssClass="extra"></asp:TextBox>
        
                       <asp:ValidationSummary ID="ValidationSummary1" runat="server" Forecolor= "Red" HeaderText="Please fix the following Errors" />

 <asp:Button ID="btnlogin" runat="server" Text="Login" CssClass="button" OnClick="btnlogin_Click" />

  <div class="login-help">
    <a href="#">Register</a> • <a href="#">Forgot Password</a>
  </div>
        </div>
</asp:Content>

