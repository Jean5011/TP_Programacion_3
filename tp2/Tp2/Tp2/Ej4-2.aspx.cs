using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp2
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Usiario = Request["TextBox2"].ToString();
            string clave = Request["TextBox1"].ToString();

            if (clave == "cosa" && Usiario == "claudio")
            {
                Label1.Text = "Bienvenido a mi pag Sr/a " + Usiario;
            }
        }
    }
}