<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="Pages_ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   
     <div class="login-card">
      <h2>Contact Us</h2>
   
Name:  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
             ErrorMessage="A Name is Required" ControlToValidate="txtname" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
<asp:TextBox style="text-align:center" ID="txtname" runat="server"  CssClass="extra"></asp:TextBox>
        

Email:   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
             ErrorMessage="An Email is Required" ControlToValidate="txtemail" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter a valid Email" ControlToValidate="txtemail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>      
          <asp:TextBox style="text-align:center" ID="txtemail" runat="server"  CssClass="extra" Font-Italic="True" AutoCompleteType="Email"></asp:TextBox>

 Subject:   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
             ErrorMessage="Please enter a Subject" ControlToValidate="txtsubject" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
         <asp:TextBox style="text-align:center" ID="txtsubject" runat="server"  CssClass="extra" Font-Italic="True" ></asp:TextBox>

Comment:  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
             ErrorMessage="Please enter a Comment" ControlToValidate="txtcomment" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
         <asp:TextBox ID="txtcomment" runat="server" TextMode="MultiLine" CssClass="extra" Height="134px" Width="338px"></asp:TextBox>

               <asp:ValidationSummary ID="ValidationSummary1" runat="server" Forecolor= "Red" HeaderText="Please fix the following Errors" />

         <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true"></asp:Label>
 <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button" OnClick="btnSubmit_Click" />

  <div class="login-help">
    <a href="#">Share<asp:Label ID="lblShare" runat="server" Text="">•<a href="Userlogin.aspx">Login</a></asp:Label>
</a>
  </div>
        </div>

</asp:Content>

