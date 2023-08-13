using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace Vistass
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio_Provincia Datos = new Negocio_Provincia();
            DropDownList1.DataSource = Datos.Provincia();
            DropDownList1.DataTextField = "DescripcionProvincia";
            DropDownList1.DataValueField = "Id_Provincia";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Sucursal suc = new Sucursal();
            Sucursal_Negocio surNg = new Sucursal_Negocio();
            suc.NombreSucursal1 = TextBox1.Text;
            suc.DescripcionSucursal1 = TextBox2.Text;
            suc.Id_ProvinciaSucursal1 = int.Parse(DropDownList1.SelectedValue);
            suc.Direccion1 = TextBox4.Text;
            if (surNg.AgragarSucusal(suc) == 0)
            {
                Label1.Text = "error";
            }
            else
            {
                Label1.Text = "ok";
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox4.Text = "";
        }
    }
}