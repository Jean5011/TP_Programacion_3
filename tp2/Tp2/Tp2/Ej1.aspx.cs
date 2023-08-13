using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        bool Validacion()
        {
           int num1;
           int num2;
           ///Validar textos
            if (((!int.TryParse(Cant1.Text, out num1)) || (!int.TryParse(Cant2.Text, out num2))) && (TextBox1.Text == "" || TextBox2.Text == ""))
            {
                Label1.Text = "Ingrese producto/s y catidad/es";
                return false;
            }
            ///Validar Numeros
            else if ((!int.TryParse(Cant1.Text, out num1)) || (!int.TryParse(Cant2.Text, out num2)))
            {
                Label1.Text = "Ingrese cantidad/es";
                return false;
            }
            else if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                Label1.Text = "Ingrese producto/s";
                return false;
            }
            return true;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {/// numero1 y numero 2 estan adentro del if por razones que sino ingresamos numeros 
             /// nos dara error al hacer click.
                int numero1 = int.Parse(Cant1.Text);
                int numero2 = int.Parse(Cant2.Text);
                string Tabla = "<Table border = '1'>";
                Tabla += "<tr><td>Producto</td><td>Cantidad</td></tr>";
                Tabla += "<tr><td>" + TextBox1.Text + "</td><td>" + numero1 + "</td></tr>";
                Tabla += "<tr><td>" + TextBox2.Text + "</td><td>" + numero2 + "</td></tr>";
                Tabla += "<tr><td>Total</td><td>" + (numero2 + numero1) + "</td></tr>";
                Tabla += "</table>";
                Label1.Text = Tabla;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cant2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}