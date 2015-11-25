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
                <ul class="nav nav-tabs">
                    <li class="active"><a data-toggle="tab" href="#home">Nacionales</a></li>
                    <li><a data-toggle="tab" href="#menu1">Internacionales</a></li>
                </ul>
                <div class="tab-content">
                    <div id="home" class="tab-pane fade in active">
                        <h3>
                            Vista México</h3>
                        <p>
                            Viaja con tus membrecias</p>
                        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                            <!-- Indicators -->
                            <ol class="carousel-indicators">
                                <asp:PlaceHolder runat="server" ID="phCarrucelUno" />
                            </ol>
                            <!-- Wrapper for slides -->
                            <div class="carousel-inner" role="listbox">
                                <asp:PlaceHolder runat="server" ID="phCarrucelDos" />
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
                            Visita Sitios Extrangeros</h3>
                        <p>
                            Viaja a meses sin intereses</p>
                        <div id="carousel-example-genericUno" class="carousel slide" data-ride="carousel">
                            <!-- Indicators -->
                            <ol class="carousel-indicators">
                                <li data-target="#carousel-example-genericUno" data-slide-to="0" class="active">
                                </li>
                                <li data-target="#carousel-example-genericUno" data-slide-to="1"></li>
                                <%--<li data-target="#carousel-example-generic" data-slide-to="2"></li>--%>
                            </ol>
                            <!-- Wrapper for slides -->
                            <div class="carousel-inner" role="listbox">
                                <div class="item active">
                                    <img src="img/Lasvegasport.png" style="margin: auto; margin-top: 17px" alt="Viajes Directo a Cancun">
                                    <div class="carousel-caption">
                                        <div style="background-color: rgba(0, 128, 128, 0.59);">
                                            <h3>
                                                <asp:Label ID="Label1" Text="Viaja a la Vegas ¡Ven pronto!" runat="server" />
                                            </h3>
                                            <p>
                                                Visita nuestros ejores Casinos
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class="item">
                                    <img src="img/Ddubaiportada.png" style="margin: auto; margin-top: 17px" alt="Acapulco">
                                    <div class="carousel-caption">
                                        <div style="background-color: rgba(0, 128, 128, 0.59);">
                                            <h3>
                                                <asp:Label ID="Label3" Text="Viaja al lugar mas lujoso del mundo Dubai" runat="server" />
                                            </h3>
                                            <p>
                                                visita nuestras hermosas playas
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                ...
                            </div>
                            <!-- Controls -->
                            <a class="left carousel-control" href="#carousel-example-genericUno" role="<%--button--%>"
                                data-slide="prev"><span class="glyphicon glyphicon-chevron-left" aria-hidden="true">
                                </span><span class="sr-only">Previous</span> </a><a class="right carousel-control"
                                    href="#carousel-example-genericUno" role="button" data-slide="next"><span class="glyphicon glyphicon-chevron-right"
                                        aria-hidden="true"></span><span class="sr-only">Next</span> </a>
                        </div>
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
