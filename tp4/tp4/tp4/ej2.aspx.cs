using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace tp4
{
    public partial class ej2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Flitrar_Click(object sender, EventArgs e)
        {
            
                SqlConnection cn = new SqlConnection("Data Source=PCOK\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                cn.Open();
                string DDL_P = DDL_Producto.SelectedValue;
                string DDL_C = DDL_Categoria.SelectedValue;
                int n1 = int.Parse(TB_Producto.Text);
                int n2 = int.Parse(TB_Categoria.Text);
            DataSet ds = new DataSet();
            /// Se hizo validacioin desde el codigo SQL
            string Consulta = "select * from [Productos] where IdProducto " + (DDL_P) + (n1) + " and [IdCategoría] " + (DDL_C) + (n2)+"";
            SqlDataAdapter adpt = new SqlDataAdapter(Consulta, cn);
               
               adpt.Fill(ds, "Producuto");
                GRD.DataSource = ds.Tables["Producuto"];
                GRD.DataBind();
                cn.Close();
            Label1.Text = "";
     
            if (GRD.Rows.Count > 0)
            {
                    GRD.Visible = true;
            }
            else
            {
                Label1.Text = "DATOS NO EXISTENTES";
            }
        }

        protected void Quitar_flitro_Click(object sender, EventArgs e)
        {
            GRD.Visible = false;
            Label1.Text = "";
        }
    }
}

