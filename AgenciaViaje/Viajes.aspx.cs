using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgenciaViaje.Web.Business.Entity;
using AgenciaViaje.Web.Business;

public partial class Viajes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            CargarCarteleras();
        }
        catch (Exception ex)
        {
            Title = ex.Message;
        }
    }

    private void CargarCarteleras()
    {
        List<EntViaje> list = new BusViaje().Obtener();
        LlenarLiteralCarrucel(list);
    }

    private void LlenarLiteralCarrucel(List<EntViaje> list)
    {
        LiteralControl literal = new LiteralControl();
        LiteralControl literalDos = new LiteralControl();
        literal.Text = "";
        literalDos.Text = "";

        int contador = 0;

        foreach (EntViaje ent in list)
        {
            if (contador == 0)
                literal.Text += "<li data-target=\"#carousel-example-generic\" data-slide-to=\"0\" class=\"active\"></li>";
            else
                literal.Text += "<li data-target=\"#carousel-example-generic\" data-slide-to=\"0\"></li>";
            if (contador == 0)
                literalDos.Text += "                                <div class=\"item active\">";
            else
                literalDos.Text += "                                <div class=\"item\">";

            literalDos.Text += "                                    <img src=\""+ent.FotoLugar+"\" style=\"margin: auto; margin-top: 17px;\">";
            literalDos.Text += "                                    <div class=\"carousel-caption\">";
            literalDos.Text += "                                        <h3>";
            literalDos.Text += "                                            "+ent.Descripcion+"</h3>";
            literalDos.Text += "                                        <p>";
            literalDos.Text += "                                            "+ent.Destino+"</p>";
            literalDos.Text += "                                    </div>";
            literalDos.Text += "                                </div>";

            contador++;




        }
        phCarruselUno.Controls.Add(literal);
        phCarrucelDos.Controls.Add(literalDos);
        //LiteralControl literal = new LiteralControl();
        //LiteralControl literalDos = new LiteralControl();
        //literalDos.Text = "";
        //literal.Text = "";
        //int contador = 0;

        //foreach (EntViaje ent in list)
        //{
        //    if (contador == 0)
        //        literal.Text += "<li data-target=\"#carousel-example-generic\" data-slide-to=\"" + contador + "\" class=\"active\"></li>";
        //    else
        //        literal.Text += "<li data-target=\"#carousel-example-generic\" data-slide-to=\"" + contador + "\"></li>";

        //    if (contador == 0)
        //        literal.Text += "<div class=\"item active\">";
        //    else
        //        literal.Text += "<div class=\"item\">";

        //    literalDos.Text += "                                    <img src=\""+ent.FotoLugar+"\" style=\"margin: auto; margin-top: 17px\" alt=\"Viajes Directo a Cancun\">";
        //    literalDos.Text += "                                    <div class=\"carousel-caption\">";
        //    literalDos.Text += "                                        <div style=\"background-color: rgba(0, 128, 128, 0.59);\">";
        //    literalDos.Text += "                                            <h3>";
        //    literalDos.Text += "                        <Label/>"+ent.Descripcion+"</label>";
        //    literalDos.Text += "                                            </h3>";
        //    literalDos.Text += "                                            <p>";
        //    literalDos.Text += "                                                Ven Visitanos pronto";
        //    literalDos.Text += "                                            </p>";
        //    literalDos.Text += "                                        </div>";
        //    literalDos.Text += "                                    </div>";
        //    literalDos.Text += "                                </div>";
        //    contador++;
        //}
        //phCarrucelUno.Controls.Add(literal);
        //phCarrucelDos.Controls.Add(literalDos);

    }
}