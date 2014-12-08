﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="pruebaBootstrap.Principal" %>
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
                                        <asp:Label ID="Label1" runat="server" Text="NDP" ></asp:Label>
                                        <asp:TextBox ID="txtndp" runat="server" ></asp:TextBox>
                                        <br/>
                                        <asp:Label ID="Label2" runat="server" Text="Contraseña: " ></asp:Label>
                                        <asp:TextBox ID="txtpass1" runat="server" placeholder="Contraseña" ></asp:TextBox>
                                        <br/>
                                        <asp:Label ID="Label3" runat="server" Text="Confirme Contraseña: " ></asp:Label>
                                        <asp:TextBox ID="txtpass2" runat="server" placeholder="Confirmacion de contraseña (nuevo usuario)"></asp:TextBox>
                                        &nbsp; <br /> 
                                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>

                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        <!-- <img src="images/promotion/promotion2.jpg" alt="Product 2"> -->
                        <!--
                        <div class="item-large-content">
                            <div class="item-header">
                                <h2 class="pull-left">Fusce facilisis semper magna</h2>
                                <span class="pull-right">Rate: <i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i>
                                <i class="fa fa-star-half-o"></i></span>
                                <div class="clearfix"></div>
                            </div>
                            <p>Integer ac dui interdum, varius sem eu, vulputate ipsum. Donec fringilla, est ac hendrerit elementum, libero nulla sodales odio, a placerat urna lectus at sem. Vivamus vehicula accumsan orci a tempus. Vestibulum a augue iaculis, tincidunt lacus venenatis, aliquet ante. Sprint is <a href="#">free website template</a> that can be used for any purpose.<br><br>Aliquam iaculis lectus accumsan, egestas lorem ac, malesuada purus. Aenean in tincidunt libero. Etiam vitae dolor vel justo temllicitudin. Download free templates for your websites. Sed fermentum, neque in dignissim aliquam, quam ante pellentesque quam, posuere eros purus purus. Ut non est magna.</p>
                        </div> --> <!-- /.item-large-content -->
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