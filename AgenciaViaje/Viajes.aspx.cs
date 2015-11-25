using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        List<EntViajes> list = new BusViajes().Obtener();
        LlenarLiteralCarrucel(list);
    }

    private void LlenarLiteralCarrucel(List<EntViajes> list)
    {
        LiteralControl literal = new LiteralControl();
        LiteralControl literalDos = new LiteralControl();
        literalDos.Text = "";
        literal.Text = "";
        int contador = 0;

        foreach (EntViaje ent in list)
        {
            if (contador == 0)
                literal.Text = "<li data-target=\"#carousel-example-generic\" data-slide-to=\"" + contador + "\" class=\"active\"></li>";
            else
                literal.Text = "<li data-target=\"#carousel-example-generic\" data-slide-to=\"" + contador + "\"></li>";
            contador++;
            if (contador == 0)
                literal.Text += "<div class=\"item active\">";
            else
                literal.Text += "<div class=\"item\">";

            literalDos.Text += "                                    <img src=\"img/Cancunport.png\" style=\"margin: auto; margin-top: 17px\" alt=\"Viajes Directo a Cancun\">";
            literalDos.Text += "                                    <div class=\"carousel-caption\">";
            literalDos.Text += "                                        <div style=\"background-color: rgba(0, 128, 128, 0.59);\">";
            literalDos.Text += "                                            <h3>";
            literalDos.Text += "                                                <asp:Label ID=\"Label4\" Text=\"Viaje Directo a Cancun ¡Todo Incluido!\" runat=\"server\" />";
            literalDos.Text += "                                            </h3>";
            literalDos.Text += "                                            <p>";
            literalDos.Text += "                                                Ven Visitanos pronto";
            literalDos.Text += "                                            </p>";
            literalDos.Text += "                                        </div>";
            literalDos.Text += "                                    </div>";
            literalDos.Text += "                                </div>";
            
        }
    }
}