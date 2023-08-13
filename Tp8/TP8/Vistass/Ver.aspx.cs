using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistass
{
    public partial class Ver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Todo_Click(object sender, EventArgs e)
        {
            Sucursal_Negocio sur = new Sucursal_Negocio();
            GridView1.DataSource = sur.TodasSuscursal();
            GridView1.DataBind();
        }

        protected void Por_Id_Click(object sender, EventArgs e)
        {
            Sucursal_Negocio sur = new Sucursal_Negocio();
            int id = int.Parse(TextBox1.Text);
            GridView1.DataSource=sur.IDSuscursal(id);
            GridView1.DataBind();
        }
    }
}