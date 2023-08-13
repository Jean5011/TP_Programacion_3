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
    public partial class Selecionar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridveiw();
            }
        }

        public void CargarGridveiw()
        {
            Procesos Producto = new Procesos();
            grPrducto.DataSource = Producto.ObtenerTodosLosProductos();
            grPrducto.DataBind();
        }

        protected void grPrducto_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grPrducto.PageIndex = e.NewPageIndex;
            CargarGridveiw();
        }

        protected void grPrducto_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string ID = ((Label)grPrducto.Rows[e.NewSelectedIndex].FindControl("Lb_ID")).Text;
            string Nombre = ((Label)grPrducto.Rows[e.NewSelectedIndex].FindControl("LB_Nombre")).Text;
            string Unidad = ((Label)grPrducto.Rows[e.NewSelectedIndex].FindControl("LB_Unidad")).Text;
            string Precio = ((Label)grPrducto.Rows[e.NewSelectedIndex].FindControl("Label1")).Text;
            DataTable tab;
            if (Session["Tabla"] == null)
            {
                tab = CrearTabla();
            }
            else
            {
                tab = (DataTable)Session["Tabla"];
            }
            DataRow i = tab.NewRow();
            i["ID"] = ID;
            i["Nombre"] = Nombre;
            i["CantidadPorUnidad"] = Unidad;
            i["PrecioUnidad"] = Precio;
            tab.Rows.Add(i);
            Session["Tabla"] = tab;


        }
        public DataTable CrearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn colum = new DataColumn("ID", System.Type.GetType("System.String"));
            dt.Columns.Add(colum);
            colum = new DataColumn("Nombre", System.Type.GetType("System.String"));
            dt.Columns.Add(colum);
            colum = new DataColumn("CantidadPorUnidad", System.Type.GetType("System.String"));
            dt.Columns.Add(colum);
            colum = new DataColumn("PrecioUnidad", System.Type.GetType("System.String"));
            dt.Columns.Add(colum);
            return dt;
        }
    }
}