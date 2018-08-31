<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegisterUsers.aspx.cs" Inherits="Pages_AccountManagement_RegisterUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Literal ID="literalstat" runat="server"></asp:Literal><br />

   


    <div class="login-card">
        <h2>Welcome</h2>
    <h2>Register with email</h2><br>
  
    Username: <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
             ErrorMessage="A User Name is Required" ControlToValidate="txtuser_name" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:TextBox style="text-align:center" ID="txtuser_name" runat="server"  CssClass="extra"></asp:TextBox>

Email:<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtemail" ForeColor="Red" Text="*"
    ErrorMessage="An Email is Required" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic"
            ErrorMessage="Enter a Valid Email" ControlToValidate="txtemail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator> 
        <asp:TextBox style="text-align:center" ID="txtemail" runat="server"  CssClass="extra"></asp:TextBox>
       



 Password: <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
             ErrorMessage="A password is Required" ControlToValidate="txt_pass" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:TextBox style="text-align:center" ID="txt_pass" runat="server" TextMode="Password" Text="Password" CssClass="extra" Font-Italic="True"></asp:TextBox>
       
 Confirm Password:  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
             ErrorMessage="A password is Required" ControlToValidate="txtconfirm" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" Text="*" runat="server" ForeColor="Red" ControlToValidate="txtconfirm" ControlToCompare="txt_pass" Operator="Equal" ErrorMessage="Both passwords must match"></asp:CompareValidator>
        
        <asp:TextBox style="text-align:center" ID="txtconfirm" runat="server" TextMode="Password" CssClass="extra" Font-Italic="True"></asp:TextBox>
        
First Name:  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
             ErrorMessage="A First Name is Required" ControlToValidate="textfirstname" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:TextBox style="text-align:center" ID="textfirstname" runat="server"  CssClass="extra" Font-Italic="True" AutoCompleteType="FirstName"></asp:TextBox>

Last Name:  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
             ErrorMessage="A Last Name is Required" ControlToValidate="textlastname" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:TextBox style="text-align:center" ID="textlastname" runat="server"  CssClass="extra" Font-Italic="True" AutoCompleteType="LastName"></asp:TextBox>
       
 Address:  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
             ErrorMessage="A valid Address is Required" ControlToValidate="textaddress" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:TextBox style="text-align:center" ID="textaddress" runat="server"  CssClass="extra" Font-Italic="True" AutoCompleteType="HomeStreetAddress"></asp:TextBox>
 
        Post Code:  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
             ErrorMessage="A valid Postcode is Required" ControlToValidate="textpostcode" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:TextBox style="text-align:center" ID="textpostcode" runat="server"  CssClass="extra" Font-Italic="True" AutoCompleteType="HomeZipCode"></asp:TextBox>

               <asp:ValidationSummary ID="ValidationSummary1" runat="server" Forecolor= "Red" HeaderText="Please fix the following Errors" />

 <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="button" OnClick="btnRegister_Click" />

  <div class="login-help">
    <a href="Userlogin.aspx">Login</a> • <a href="#">Forgot Password</a>
  </div>
        </div>
</asp:Content>

