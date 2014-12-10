<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="pruebaBootstrap.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


            
        <div id="product-promotion" class="content-section">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h1 class="section-title">Operacion de Transformacion</h1>
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
                                <asp:ScriptManager ID="smtransformacion" runat="server"></asp:ScriptManager>
                                <asp:UpdatePanel ID="uptransformacion" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                        <asp:FileUpload ID="FileUpload1" runat="server" />
                                    </ContentTemplate>
                                    
                                </asp:UpdatePanel>
                                <asp:Button ID="cmdCargarArchivo" runat="server" Text="Cargar Archivo" OnClick="cmdCargarArchivo_Click" />
                                Mensaje: <br/>
                                <br>
                                <% Response.Write(Session["usuario"]); %>

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




        <div id="Div1" class="content-section">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h1 class="section-title">Operacion de Reversion</h1>
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
                                <br>
                                <% Response.Write(Session["usuario"]); %>

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


        <div id="Div2" class="content-section">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h1 class="section-title">Envío de correo Electrónico</h1>
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
                                <br>
                                <% Response.Write(Session["usuario"]); %>

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


        <div id="Div3" class="content-section">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h1 class="section-title">Reportes</h1>
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
                                <br>
                                <% Response.Write(Session["usuario"]); %>

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

</asp:Content>
