<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebShopOnesie._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container text-center">
        <div class="row">
            <div class="col-lg-4 col-md-6 col-xs-12">
                <h2>Women</h2>
               <a runat="server" href="~/pagesProducts/Women.aspx"><img class="img-thumbnail img-center img-rounded" src="klädImages/main_cat-generic_men.jpg"/></a>
            </div>
            <div class="col-lg-4 col-md-6 col-xs-12">
                <h2>Men</h2>
                <a runat="server" href="~/pagesProducts/Men.aspx">
                <img class="img-thumbnail img-center img-rounded" src="klädImages/main_cat-generic_men.jpg"/></a>
            </div>
            <div class="col-lg-4 col-md-6 col-xs-12">
                <h2>Kids</h2>
                <a runat="server" href="~/pagesProducts/kids.aspx"><img class="img-thumbnail img-center img-rounded"src="klädImages/main_cat-generic_men.jpg"/></a>
            </div>
        </div>
    </div>
    <%--<div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>--%>
</asp:Content>
