<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebShopOnesie.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container"> 
    <div class="row"> 
        <div class="col-sm-6 col-md-4 col-md-offset-4"> 
            <h1 class="text-center login-title">Sign in to continue</h1> 
            <div class="account-wall"> 
                <img class="profile-img" src="../klädImages/main_cat-generic_men.jpg" alt=""> 
                <div class="form-signin"> 
                <input type="text" class="form-control" placeholder="Email" required autofocus id="txtUserName"> 
                 <input type="password" class="form-control" placeholder="Password" required id="txtPassword"> 
                 <button class="btn btn-lg btn-block btn-primary " type="submit"> 
                     Sign in</button> 
                 <label class="checkbox pull-left"> 
                     <input type="checkbox" ID="ChbRemember" runat="server" value="remember-me"> 
                     Remember me 
                 </label> 
                 <a href="#" class="pull-right need-help">Need help? </a><span class="clearfix"></span> 
                 </div> 
             </div> 
             <a href="~/Account/Register.aspx" class="text-center new-account" runat="server">Create an account </a> 
         </div> 
     </div> 
 </div> 

</asp:Content>
