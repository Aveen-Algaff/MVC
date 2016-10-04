<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebShopOnesie.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container"> 
    <div class="row"> 
        <div class="col-sm-6 col-md-4 col-md-offset-4"> 
            
            <h1 class="text-center login-title">Sign in to continue</h1> 
            <div class="account-wall"> 
                <img class="profile-img" src="../klädImages/main_cat-generic_men.jpg" alt="photo">                
                 <asp:Label ID="lbllogin" runat="server" Text=""></asp:Label>
                <div class="form-signin">
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>
                    <asp:Button ID="btnSignup" class="btn btn-lg btn-block btn-primary " runat="server" Text="Sign in" OnClick="btnSignup_Click" />
                    <asp:CheckBox ID="ChkRemember" class="checkbox pull-left" runat="server" value="remember-me" Text="Remember me " />
             
                 <a href="#" class="pull-right need-help">Need help? </a><span class="clearfix"></span> 
                 </div> 
             </div> 
             <a href="~/Account/Register.aspx" class="text-center new-account" runat="server">Create an account </a> 
         </div> 
     </div> 
 </div> 

</asp:Content>
