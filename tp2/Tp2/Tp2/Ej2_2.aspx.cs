using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp2
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Nombre.Text = Request["TBnombre"].ToString();
            Apellido.Text= Request["TBapellido"].ToString();
            string valorSeleccionado = (string)Session["valorSeleccionado"];
            if (valorSeleccionado != null)
            {
                TxtZona.Text = valorSeleccionado; 
            }

            if (Session["ValoresSeleccionados"] != null)
            {
                List<string> valoresSeleccionados = (List<string>)Session["ValoresSeleccionados"];
                foreach (string item in valoresSeleccionados)
                {
                    Label1.Text += "<br />" + item;
                }
            }
        }
    }
}