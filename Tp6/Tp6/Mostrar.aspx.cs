using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tp6.Clases;
using System.Data;

namespace Tp6
{
    public partial class Mostrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Tabla"] != null)
                {
                    CargarGridveiw((DataTable)Session["Tabla"]);
                }
                else
                {
                    Error.Text = "Error no pudo caragr pagina";
                }
                    
            }
            
        }

        public void CargarGridveiw(DataTable t)
        {
            grPrducto.DataSource = t;
            grPrducto.DataBind();
        }

    }
}