<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="pruebaBootstrap.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


            <div id="mitag">
        <div id="product-promotion" class="content-section">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h1 class="section-title">New Products</h1>
                    </div> <!-- /.col-md-12 -->
                </div> <!-- /.row -->
                <div class="row">
                    <div class="col-md-2 col-sm-3">
                        <div class="item-small">
                            <img src="images/promotion/promotion1.jpg" alt="Product 1">
                            <h4>Nullam Non Ultrices Arcu</h4>
                        </div> <!-- /.item-small -->
                    </div> <!-- /.col-md-2 -->
                    <div class="col-md-8 col-sm-6">
                        <div class="item-large">
                            <div>
                                Mensaje: <br/>
                                    <%
        //string var =Request.QueryString["mensaje"];
        Response.Write(pruebaBootstrap.GlobalClass.usuario);
        %>
                                <br>
                                <%
        Response.Write(Session["login"]);
        %>
                            </div>
                        </div> <!-- /.item-large -->
                    </div> <!-- /.col-md-8 -->
                    <div class="col-md-2 col-sm-3">
                        <div class="item-small">
                            <img src="images/promotion/promotion3.jpg" alt="Product 3">
                            <h4>Morbi Sit Amet Lorem</h4>
                        </div> <!-- /.item-small -->
                    </div> <!-- /.col-md-2 -->
                </div> <!-- /.row -->
            </div> <!-- /.container -->
        </div> <!-- /#product-promotion -->
    </div>
    


</asp:Content>
