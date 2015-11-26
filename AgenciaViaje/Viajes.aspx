<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Viajes.aspx.cs" Inherits="Viajes" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" style="margin-top: 20px;">
        <div class="row">
            <div class="col-md-1">
            </div>
            <div class="col-md-10">
                <ul class="nav nav-pills">
                    <li class="active"><a data-toggle="pill" href="#home">Home</a></li>
                    <li><a data-toggle="pill" href="#menu1">Menu 1</a></li>
                    <li><a data-toggle="pill" href="#menu2">Menu 2</a></li>
                </ul>
                <div class="tab-content">
                    <div id="home" class="tab-pane fade in active">
                        <h3>
                            HOME</h3>
                        <p>
                            Some content.</p>
                        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                            <!-- Indicators -->
                            <ol class="carousel-indicators">
                                <asp:PlaceHolder runat="server" ID="phCarruselUno"/>  
                            </ol>
                            <!-- Wrapper for slides -->
                            <div class="carousel-inner" role="listbox">
                                <asp:PlaceHolder runat="server" ID="phCarrucelDos"/>  
                                <%--<div class="item active">
                                    <img src="img/AcapulcoPort.png" style="margin: auto; margin-top: 17px;">
                                    <div class="carousel-caption">
                                        <h3>
                                            Hola Mundo</h3>
                                        <p>
                                            Hola Pequeño Mundo</p>
                                    </div>
                                </div>
                                <div class="item">
                                    <img src="img/Cancunport.png" style="margin: auto; margin-top: 17px;">
                                    <div class="carousel-caption">
                                        <h3>
                                            Hola Mundo</h3>
                                        <p>
                                            Hola Pequeño Mundo</p>
                                    </div>
                                </div>
                                ...--%>
                            </div>
                            <!-- Controls -->
                            <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
                                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">
                                    Previous</span> </a><a class="right carousel-control" href="#carousel-example-generic"
                                        role="button" data-slide="next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true">
                                        </span><span class="sr-only">Next</span> </a>
                        </div>
                    </div>
                    <div id="menu1" class="tab-pane fade">
                        <h3>
                            Menu 1</h3>
                        <p>
                            Some content in menu 1.</p>
                    </div>
                </div>
                <div class="panel-body" style="background-color: Gray; margin-top: 20px">
                    <div class="col-md-4">
                        <asp:TextBox ID="txtFechaAlta" runat="server" CssClass="form-control" placeholder="dd/MM/yyyy" />
                    </div>
                    <div class="col-md-4">
                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCategoria">
                            <asp:ListItem Text="[Categoria]" Value="-1" />
                            <asp:ListItem Text="text2" />
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlDestino" runat="server" CssClass="form-control">
                            <asp:ListItem Text="[Destino]" Value="-1" />
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-4" style="margin-top: 28px">
                        <asp:TextBox ID="txtLugar" runat="server" CssClass="form-control" />
                    </div>
                    <div class="col-md-4" style="margin-top: 20px; text-align: center">
                        <asp:ImageButton ImageUrl="~/img/Consultas.jpg" Style="width: 260px; border-radius: 50px;"
                            CssClass="btn" ID="imgbConsulta" runat="server" />
                    </div>
                    <div class="col-md-4" style="margin-top: 20px">
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4" style="margin-top: 20px">
                        <div class="panel panel-default">
                            <div class="panel-heading img-responsive " style="height: 200px;">
                                <img src="img/Lasvegasport.png" alt="Alternate Text" class="img-rounded img-responsive"
                                    style="margin: auto;" width="250px" />
                                <div>
                                    Casino royal
                                </div>
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-xs-4" style="overflow: hidden; height: 100px;">
                                        <img src="img/LasVegasmini.png" alt="Alternate Text" class="img-responsive img-rounded" />
                                    </div>
                                    <div class="col-xs-8">
                                        <span>Vigencia: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>11/2015</label><br />
                                        <span>Categria: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>3 estrellas</label><br />
                                        <span>Destino: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>Nevadas</label><br />
                                        <span>Lugar: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>Las Vegas</label><br />
                                    </div>
                                </div>
                            </div>
                            <div id="sinopsis" style="text-align: center;">
                                <textarea id="txtSinopsis" class="form-control" cols="45" rows="4" style="text-align: justify;
                                    background-color: White;" disabled="disabled">viaja y diviertete con nuestro mas surdito y varidad en nuetros hoteles y restaurantes</textarea>
                            </div>
                            <div id="video" style="text-align: center; margin-top: 10px">
                                <iframe src="https://www.youtube.com/embed/LbmnFSTUm2U" width="250" frameborder="0"
                                    allowfullscreen></iframe>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4" style="margin-top: 20px">
                        <div class="panel panel-default">
                            <div class="panel-heading img-responsive " style="height: 200px;">
                                <img src="img/Lasvegasport.png" alt="Alternate Text" class="img-rounded img-responsive"
                                    style="margin: auto;" width="250px" />
                                <div>
                                    Casino royal
                                </div>
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-xs-4" style="overflow: hidden; height: 100px;">
                                        <img src="img/LasVegasmini.png" alt="Alternate Text" class="img-responsive img-rounded" />
                                    </div>
                                    <div class="col-xs-8">
                                        <span>Vigencia: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>11/2015</label><br />
                                        <span>Categria: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>3 estrellas</label><br />
                                        <span>Destino: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>Nevadas</label><br />
                                        <span>Lugar: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>Las Vegas</label><br />
                                    </div>
                                </div>
                            </div>
                            <div id="Div1" style="text-align: center;">
                                <textarea id="Textarea1" class="form-control" cols="45" rows="4" style="text-align: justify;
                                    background-color: White;" disabled="disabled">viaja y diviertete con nuestro mas surdito y varidad en nuetros hoteles y restaurantes</textarea>
                            </div>
                            <div id="Div2" style="text-align: center; margin-top: 10px">
                                <iframe src="https://www.youtube.com/embed/LbmnFSTUm2U" width="250" frameborder="0"
                                    allowfullscreen></iframe>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4" style="margin-top: 20px">
                        <div class="panel panel-default">
                            <div class="panel-heading img-responsive " style="height: 200px;">
                                <img src="img/Lasvegasport.png" alt="Alternate Text" class="img-rounded img-responsive"
                                    style="margin: auto;" width="250px" />
                                <div>
                                    Casino royal
                                </div>
                            </div>
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-xs-4" style="overflow: hidden; height: 100px;">
                                        <img src="img/LasVegasmini.png" alt="Alternate Text" class="img-responsive img-rounded" />
                                    </div>
                                    <div class="col-xs-8">
                                        <span>Vigencia: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>11/2015</label><br />
                                        <span>Categria: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>3 estrellas</label><br />
                                        <span>Destino: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>Nevadas</label><br />
                                        <span>Lugar: &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</span><label>Las Vegas</label><br />
                                    </div>
                                </div>
                            </div>
                            <div id="Div3" style="text-align: center;">
                                <textarea id="Textarea2" class="form-control" cols="45" rows="4" style="text-align: justify;
                                    background-color: White;" disabled="disabled">viaja y diviertete con nuestro mas surdito y varidad en nuetros hoteles y restaurantes</textarea>
                            </div>
                            <div id="Div4" style="text-align: center; margin-top: 10px">
                                <iframe src="https://www.youtube.com/embed/LbmnFSTUm2U" width="250" frameborder="0"
                                    allowfullscreen></iframe>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-1">
            </div>
        </div>
    </div>
    </form>
    <script src="js/jquery-2.1.4.js" type="text/javascript"></script>
    <script src="js/bootstrap.js" type="text/javascript"></script>
</body>
</html>
