using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tp6.Clases;

namespace Tp6
{
    public partial class WebForm3 : System.Web.UI.Page
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

        protected void grPrducto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s_IDProducto = ((Label)grPrducto.Rows[e.RowIndex].FindControl("LBID")).Text;
            Producto pro = new Producto();
            pro.IdProducto = Convert.ToInt32(s_IDProducto);
            Procesos gProducto = new Procesos();
            gProducto.EliminarProcudto(pro);
            CargarGridveiw();


        }

        protected void grPrducto_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grPrducto.EditIndex = e.NewEditIndex;
            CargarGridveiw();
        }

        protected void grPrducto_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grPrducto.EditIndex = -1;
            CargarGridveiw();
        }

        protected void grPrducto_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string s_IDProducto = ((Label)grPrducto.Rows[e.RowIndex].FindControl("LB_ID")).Text;
            string s_NombreProducto = ((TextBox)grPrducto.Rows[e.RowIndex].FindControl("TBNombe")).Text;
            string s_Unidades = ((TextBox)grPrducto.Rows[e.RowIndex].FindControl("TBUnidad")).Text;
            string s_Precio = ((TextBox)grPrducto.Rows[e.RowIndex].FindControl("TBPrecio")).Text;
            Producto pro = new Producto();
            pro.IdProducto = Convert.ToInt32(s_IDProducto);
            pro.NombreProducto = s_NombreProducto;
            pro.CantidadPorUnidad = s_Unidades;
            pro.PrecioUnidad = Convert.ToDecimal(s_Precio);

            Procesos proc = new Procesos();
            proc.ActualizarProducto(pro);
            grPrducto.EditIndex = -1;
            CargarGridveiw();
           
        }
    }
}